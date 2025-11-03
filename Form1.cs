using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Weather_Generation
{
    public partial class Form1 : Form
    {
        readonly Random random = new Random();
        int rollTemp;
        int tempMod;
        int rollPrec;
        int precMod;
        int rollWind;
        int windMod;
        int counter = 0;
        string matches = "null";
        string tempRange;
        string precRange;
        string windRange;
        string weather;
        string weatherCode;
        public Form1()
        {
            InitializeComponent();
        }
        public void RollTemp()
        {
            rollTemp = random.Next(1, 7);
            lbxTemperature.Items.Insert(0, rollTemp);

            int tempSeasonMod = 0;
            if (radSummer.Checked) tempSeasonMod++;
            else if (radWinter.Checked) tempSeasonMod--;

            int tempClimateMod = 0;
            if (radTropic.Checked) tempClimateMod++;
            else if (radTaiga.Checked) tempClimateMod--;

            int tempModMult = 1;
            if (cbxMidseason.Checked) tempModMult = 2;
            
            tempMod = (tempSeasonMod * tempModMult) + tempClimateMod;
            lbxTempMod.Items.Insert(0, tempMod);
        }
        public void RollPrec()
        {
            rollPrec = random.Next(1, 7);
            lbxPrecipitation.Items.Insert(0, rollPrec);

            int precSeasonMod = 0;
            if (radSpring.Checked) precSeasonMod++;

            int precClimateMod = 0;
            if (radTropic.Checked) precClimateMod++;
            if (radDesert.Checked) precClimateMod--;

            int precModMult = 1;
            if (cbxMidseason.Checked) precModMult = 2;
            
            precMod = (precSeasonMod * precModMult) + precClimateMod;
            lbxPrecMod.Items.Insert(0, precMod);
        }
        public int RollWind()
        {
            rollWind = random.Next(1, 7);
            lbxWind.Items.Insert(0, rollWind);

            int windSeasonMod = 0;
            if (radAutumn.Checked) windSeasonMod++;

            int windClimateMod = 0;
            if (radTaiga.Checked) windClimateMod++;

            int windModMult = 1;
            if (cbxMidseason.Checked) windModMult = 2;

            windMod = (windSeasonMod * windModMult) + windClimateMod;
            lbxWindMod.Items.Insert(0, windMod);

            return rollWind;
        }
        public void GenWeather()
        {
            lbxWeather.Items.Insert(0, weather);
        }

        private void btnRollAll_Click(object sender, EventArgs e)
        {
            RollTemp();
            RollPrec();
            RollWind();
            CheckDoubleTriple();
            AssignRange();
            SetWeather();
            GenWeather();
        }
        public void Roll2()
        {
            if (rollTemp == 0 || rollPrec == 0 || rollWind == 0)
            {
                RollTemp();
                RollPrec();
                RollWind();
            }
            else if (counter == 0) // Temp Prec
            {
                RollTemp();
                RollPrec();
                lbxWind.Items.Insert(0, rollWind);
                counter++;
            }
            else if (counter == 1) // Prec Wind
            {
                lbxTemperature.Items.Insert(0, rollTemp);
                RollPrec();
                RollWind();
                counter++;
            }
            else if (counter == 2) // Wind Temp
            {
                RollTemp();
                lbxPrecipitation.Items.Insert(0, rollPrec);
                RollWind();
                counter = 0;
            }
        }
        private void btnRoll2_Click(object sender, EventArgs e)
        {
            Roll2();
            CheckDoubleTriple();
            AssignRange();
            GenWeather();
        }

        public void Roll1()
        {
            if (rollTemp == 0 || rollPrec == 0 || rollWind == 0)
            {
                RollTemp();
                RollPrec();
                RollWind();
            }
            else if (counter == 0) // Temp
            {
                RollTemp();
                lbxPrecipitation.Items.Insert(0, rollPrec);
                lbxWind.Items.Insert(0, rollWind);
                counter++;
            }
            else if (counter == 1) // Prec
            {
                lbxTemperature.Items.Insert(0, rollTemp);
                RollPrec();
                lbxWind.Items.Insert(0, rollWind);
                counter++;
            }
            else if (counter == 2) // Wind
            {
                lbxTemperature.Items.Insert(0, rollTemp);
                lbxPrecipitation.Items.Insert(0, rollPrec);
                RollWind();
                counter = 0;
            }
        }
        private void btnRoll1_Click(object sender, EventArgs e)
        {
            Roll1();
            CheckDoubleTriple();
            AssignRange();
            GenWeather();
        }
        public void CheckDoubleTriple()
        {
            if (rollTemp == rollPrec && rollPrec == rollWind && rollWind == rollTemp) //Check for triples
            {
                matches = "Tr";
            }
            else if (rollTemp == rollPrec || rollPrec == rollWind || rollWind == rollTemp) //Check for doubles
            {
                matches = "Do";
            }
            else { matches = ""; }
        }
        public void AssignRange()
            //Because I don't want 216 different weathers, I'm treating a 1-2, 3-4. and 5-6 the same.
            //Doubles and Triples still use their original numbers though. Because Triples are fun.
            //Lo = Low, Mi = Mid, Hi = High.
        {
            if (rollTemp + tempMod <= 2) tempRange = "Lo";
            else if (rollTemp + tempMod >= 3 && rollTemp + tempMod <= 4) tempRange = "Mi";
            else tempRange = "Hi";

            if (rollPrec + precMod <= 2) precRange = "Lo";
            else if (rollPrec + precMod >= 3 && rollPrec + precMod <= 4) precRange = "Mi";
            else precRange = "Hi";

            if (rollWind + windMod <= 2) windRange = "Lo";
            else if (rollWind + windMod >= 3 && rollWind + windMod <= 4) windRange = "Mi";
            else windRange = "Hi";

            weatherCode = $"{tempRange}{precRange}{windRange}{matches}";
        }
        public void SetWeather()
        { 
            if (weatherCode == "LoLoLoTr" && rollTemp == 1) weather = "DISASTER 1";
            if (weatherCode == "LoLoLoTr" && rollTemp == 2) weather = "DISASTER 2";
            if (weatherCode == "LoLoLoDo") weather = "Cold Dry Still Danger";
            if (weatherCode == "LoLoMiDo") weather = "Cold Dry Calm Danger";
            if (weatherCode == "LoLoMi") weather = "Cold Dry Calm";
            if (weatherCode == "LoLoHiDo") weather = "Cold Dry Wind Danger";
            if (weatherCode == "LoLoHi") weather = "Cold Dry Wind";

            if (weatherCode == "LoMiLoDo") weather = "Cold Damp Still Danger";
            if (weatherCode == "LoMiLo") weather = "Cold Damp Still";
            if (weatherCode == "LoMiMiDo") weather = "Cold Damp Calm Danger";
            if (weatherCode == "LoMiMi") weather = "Cold Damp Calm";
            if (weatherCode == "LoMiHi") weather = "Cold Damp Wind";

            if (weatherCode == "LoHiLoDo") weather = "Cold Wet Still Danger";
            if (weatherCode == "LoHiLo") weather = "Cold Wet Still";
            if (weatherCode == "LoHiMi") weather = "Cold Wet Calm";
            if (weatherCode == "LoHiHiDo") weather = "Cold Wet Wind Danger";
            if (weatherCode == "LoHiHi") weather = "Cold Wet Wind";


            if (weatherCode == "MiLoLoDo") weather = "Tepid Dry Still Danger";
            if (weatherCode == "MiLoLo") weather = "Tepid Dry Still";
            if (weatherCode == "MiLoMiDo") weather = "Tepid Dry Calm Danger";
            if (weatherCode == "MiLoMi") weather = "Tepid Dry Calm";
            if (weatherCode == "MiLoHi") weather = "Tepid Dry Wind";

            if (weatherCode == "MiMiLoDo") weather = "Tepid Damp Still Danger";
            if (weatherCode == "MiMiLo") weather = "Tepid Damp Still";
            if (weatherCode == "MiMiMiTr" && rollTemp == 3) weather = "DISASTER 3";
            if (weatherCode == "MiMiMiTr" && rollTemp == 4) weather = "DISASTER 4";
            if (weatherCode == "MiMiMiDo") weather = "Tepid Damp Still Danger";
            if (weatherCode == "MiMiHiDo") weather = "Tepid Damp Wind Danger";
            if (weatherCode == "MiMiHi") weather = "Tepid Damp Wind";

            if (weatherCode == "MiHiLo") weather = "Tepid Wet Still";
            if (weatherCode == "MiHiMiDo") weather = "Tepid Wet Calm Danger";
            if (weatherCode == "MiHiMi") weather = "Tepid Wet Calm";
            if (weatherCode == "MiHiHiDo") weather = "Tepid Wet Wind Danger";
            if (weatherCode == "MiHiHi") weather = "Tepid Wet Wind";


            if (weatherCode == "HiLoLoDo") weather = "Hot Dry Still Danger";
            if (weatherCode == "HiLoLo") weather = "Hot Dry Still";
            if (weatherCode == "HiLoMi") weather = "Hot Dry Calm";
            if (weatherCode == "HiLoHiDo") weather = "Hot Dry Wind Danger";
            if (weatherCode == "HiLoHi") weather = "Hot Dry Wind";

            if (weatherCode == "HiMiLo") weather = "Hot Damp Still";
            if (weatherCode == "HiMiMiDo") weather = "Hot Damp Calm Danger";
            if (weatherCode == "HiMiMi") weather = "Hot Damp Calm";
            if (weatherCode == "HiMiHiDo") weather = "Hot Damp Wind Danger";
            if (weatherCode == "HiMiHi") weather = "Hot Damp Wind";

            if (weatherCode == "HiHiLoDo") weather = "Hot Wet Still Danger";
            if (weatherCode == "HiHiLo") weather = "Hot Wet Still";
            if (weatherCode == "HiHiMiDo") weather = "Hot Wet Calm Danger";
            if (weatherCode == "HiHiMi") weather = "Hot Wet Calm";
            if (weatherCode == "HiHiHiTr" && rollTemp == 5) weather = "DISASTER 5";
            if (weatherCode == "HiHiHiTr" && rollTemp == 6) weather = "DISASTER 6";
            if (weatherCode == "HiHiHiDo") weather = "Hot Wet Wind Danger";
        }
    }
}
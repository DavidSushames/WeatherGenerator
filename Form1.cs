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
        //what the dice rolled from 1-6
        int rollTemp;
        int rollPrec;
        int rollWind;
        //how much seasons/climate affects the roll
        int tempMod;
        int precMod;
        int windMod;
        int cycleCounter = 0; //loops which variables are/aren't being rolled
        string matches = "null"; //checks the rolls for doubles/triples. Doubles are dangerous, Triples are disasterous.
        //condenses 1-6 into low-mid-high
        string tempRange;
        string precRange;
        string windRange;
        string weatherCode; //Ranges and match concatenated into one string
        string weather; //reads weatherCode and assigns an actual weather
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
            else if (cycleCounter == 0) // Temp Prec
            {
                RollTemp();
                RollPrec();
                lbxWind.Items.Insert(0, rollWind);
                cycleCounter++;
            }
            else if (cycleCounter == 1) // Prec Wind
            {
                lbxTemperature.Items.Insert(0, rollTemp);
                RollPrec();
                RollWind();
                cycleCounter++;
            }
            else if (cycleCounter == 2) // Wind Temp
            {
                RollTemp();
                lbxPrecipitation.Items.Insert(0, rollPrec);
                RollWind();
                cycleCounter = 0;
            }
        }
        private void btnRoll2_Click(object sender, EventArgs e)
        {
            Roll2();
            CheckDoubleTriple();
            AssignRange();
            SetWeather();
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
            else if (cycleCounter == 0) // Temp
            {
                RollTemp();
                lbxPrecipitation.Items.Insert(0, rollPrec);
                lbxPrecMod.Items.Insert(0, precMod);
                lbxWind.Items.Insert(0, rollWind);
                lbxWindMod.Items.Insert(0, windMod);
                cycleCounter++;
            }
            else if (cycleCounter == 1) // Prec
            {
                lbxTemperature.Items.Insert(0, rollTemp);
                lbxTempMod.Items.Insert(0, tempMod);
                RollPrec();
                lbxWind.Items.Insert(0, rollWind);
                lbxWindMod.Items.Insert(0, windMod);
                cycleCounter++;
            }
            else if (cycleCounter == 2) // Wind
            {
                lbxTemperature.Items.Insert(0, rollTemp);
                lbxTempMod.Items.Insert(0, tempMod);
                lbxPrecipitation.Items.Insert(0, rollPrec);
                lbxPrecMod.Items.Insert(0, precMod);
                RollWind();
                cycleCounter = 0;
            }
        }
        private void btnRoll1_Click(object sender, EventArgs e)
        {
            Roll1();
            CheckDoubleTriple();
            AssignRange();
            SetWeather();
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

            if (matches == "Tr") weatherCode = $"Triple{rollTemp}";
            else weatherCode = $"{tempRange}{precRange}{windRange}{matches}";
        }
        public void SetWeather()
        {
            weather = WeatherDictionary.weatherDict[weatherCode];
        }
    }
}
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
        int tempRoll;
        int precRoll;
        int windRoll;
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
            tempRoll = random.Next(1, 7);

            int tempSeasonMod = 0;
            if (radSummer.Checked) tempSeasonMod++;
            else if (radWinter.Checked) tempSeasonMod--;

            int tempClimateMod = 0;
            if (radTropic.Checked) tempClimateMod++;
            else if (radTaiga.Checked) tempClimateMod--;

            int tempModMult = 1;
            if (cbxMidseason.Checked) tempModMult = 2;
            
            tempMod = (tempSeasonMod * tempModMult) + tempClimateMod;
        }
        public void RollPrec()
        {
            precRoll = random.Next(1, 7);

            int precSeasonMod = 0;
            if (radSpring.Checked) precSeasonMod++;

            int precClimateMod = 0;
            if (radTropic.Checked) precClimateMod++;
            if (radDesert.Checked) precClimateMod--;

            int precModMult = 1;
            if (cbxMidseason.Checked) precModMult = 2;
            
            precMod = (precSeasonMod * precModMult) + precClimateMod;
        }
        public void RollWind()
        {
            windRoll = random.Next(1, 7);

            int windSeasonMod = 0;
            if (radAutumn.Checked) windSeasonMod++;

            int windClimateMod = 0;
            if (radTaiga.Checked) windClimateMod++;

            int windModMult = 1;
            if (cbxMidseason.Checked) windModMult = 2;

            windMod = (windSeasonMod * windModMult) + windClimateMod;
        }
        private void btnRollAll_Click(object sender, EventArgs e)
        {
            RollTemp();
            RollPrec();
            RollWind();
            Continue();
        }
        public void Roll2()
        {
            if (tempRoll == 0 || precRoll == 0 || windRoll == 0)
            {
                RollTemp();
                RollPrec();
                RollWind();
            }
            else if (cycleCounter == 1) // Temp Prec
            {
                RollTemp();
                RollPrec();
            }
            else if (cycleCounter == 2) // Prec Wind
            {
                RollPrec();
                RollWind();
            }
            else if (cycleCounter == 0) // Wind Temp
            {
                RollTemp();
                RollWind();
            }
            cycleCounter = (cycleCounter + 1) % 3;
        }
        private void btnRoll2_Click(object sender, EventArgs e)
        {
            Roll2();
            Continue();
        }
        public void Roll1()
        {
            if (tempRoll == 0 || precRoll == 0 || windRoll == 0)
            {
                RollTemp();
                RollPrec();
                RollWind();
            }
            else if (cycleCounter == 1) // Temp
            {
                RollTemp();
            }
            else if (cycleCounter == 2) // Prec
            {
                RollPrec();
            }
            else if (cycleCounter == 0) // Wind
            {
                RollWind();
            }
            cycleCounter = (cycleCounter+1) % 3;
        }
        private void btnRoll1_Click(object sender, EventArgs e)
        {
            Roll1();
            Continue();
        }
        private void Continue()
        {
            CheckDoubleTriple();
            AssignRange();
            FillDataView();
        }
        public void CheckDoubleTriple()
        {
            if (tempRoll == precRoll && precRoll == windRoll && windRoll == tempRoll) //Check for triples
            {
                matches = "Triple";
            }
            else if (tempRoll == precRoll || precRoll == windRoll || windRoll == tempRoll) //Check for doubles
            {
                matches = " Double";
            }
            else { matches = ""; }
        }
        public void AssignRange()
        {
            //Temperature
            if (tempRoll + tempMod <= 0) tempRange = "Freezing";
            else if (tempRoll + tempMod >= 1 && tempRoll + tempMod <= 2) tempRange = "Cold";
            else if (tempRoll + tempMod >= 3 && tempRoll + tempMod <= 4) tempRange = "Comfortable";
            else if (tempRoll + tempMod >= 5 && tempRoll + tempMod <= 6) tempRange = "Hot";
            else if (tempRoll + tempMod >= 7) tempRange = "Burning";

            //Precipitation
            if (precRoll + precMod <= 2) precRange = "Clear";
            else if (precRoll + precMod >= 3 && precRoll + precMod <= 4) precRange = "Overcast";
            else if (precRoll + precMod >= 5 && precRoll + precMod <= 6) precRange = "Rain";
            else if (precRoll + precMod >= 7) precRange = "Downpour";

            //Wind
            if (windRoll + windMod <= 1) windRange = "Still";
            else if (windRoll + windMod >= 2 && windRoll + windMod <= 4) windRange = "Gentle";
            else if (windRoll + windMod == 5) windRange = "Windy";
            else if (windRoll + windMod >= 6) windRange = "Gale";

            if (matches == "Triple") weatherCode = $"TRIPLE {tempRoll}, NUKE THEM.";
            else weatherCode = $"{tempRange} {precRange} {windRange}{matches}";
        }
        public void FillDataView()
        {
            dgvWeather.Rows.Insert(0, tempRoll, tempMod, precRoll, precMod, windRoll, windMod, weatherCode);
        }
        public void SetWeather()
        {
            weather = WeatherDictionary.weatherDict[weatherCode];
        }
    }
}
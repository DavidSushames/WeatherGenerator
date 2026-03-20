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
        readonly Random random = new();
        int rollNum;
        //what the dice rolled from 1-6
        int tempRoll;
        int precRoll;
        int windRoll;
        int cycleCounter = 0; //loops which variables are/aren't being rolled
        //checks the rolls for doubles/triples. Doubles are dangerous, Triples are disasterous.
        string matches = "null";
        //how much seasons/climate affects the roll
        int tempMod;
        int precMod;
        int windMod;
        //Combines roll and modifier into single number.
        int tempVal;
        int precVal;
        int windVal;
        //condenses 1-6 into low-mid-high
        string tempRange;
        string precRange;
        string windRange;
        string weatherCode; //Ranges and match concatenated into one string
        readonly StringBuilder weatherConditions = new(""); //What it looks like
        readonly StringBuilder weatherHazards = new(""); //What is dangerous
        public Form1()
        {
            InitializeComponent();
            tbxTempMod.Text = "0";
            tbxPrecMod.Text = "0";
            tbxWindMod.Text = "0";
        }
        private void UpdateTextBoxes(object sender, EventArgs e)
        {
            tempMod = trbSeasonTemp.Value + trbClimateTemp.Value;
            precMod = trbSeasonPrec.Value + trbClimatePrec.Value;
            windMod = trbSeasonWind.Value + trbClimateWind.Value;
            tbxTempMod.Text = tempMod.ToString();
            tbxPrecMod.Text = precMod.ToString();
            tbxWindMod.Text = windMod.ToString();
        }
        public void RollTemp()
        {
            tempRoll = random.Next(1, 7);
            tempVal = tempRoll + tempMod;
        }
        public void RollPrec()
        {
            precRoll = random.Next(1, 7);
            precVal = precRoll + precMod;
        }
        public void RollWind()
        {
            windRoll = random.Next(1, 7);
            windVal = windRoll + windMod;
        }
        private void btnRollAll_Click(object sender, EventArgs e)
        {
            RollTemp();
            RollPrec();
            RollWind();
            Continue();
        }
        private void btnRoll2_Click(object sender, EventArgs e)
        {
            Roll2();
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
            switch (cycleCounter)
            {
                case 1:
                    RollTemp();
                    RollPrec();
                    break;

                case 2:
                    RollPrec();
                    RollWind();
                    break;

                case 0:
                    RollTemp();
                    RollWind();
                    break;
            }
            cycleCounter = (cycleCounter + 1) % 3;
        }
        private void btnRoll1_Click(object sender, EventArgs e)
        {
            Roll1();
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
            switch (cycleCounter)
            {
                case 1:
                    RollTemp();
                    break;

                case 2:
                    RollPrec();
                    break;

                case 0:
                    RollWind();
                    break;
            }
            cycleCounter = (cycleCounter+1) % 3;
        }
        private void Continue()
        {
            CheckDoubleTriple();
            AssignRange();
            DefineWeather();
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
                matches = "Double";
            }
            else { matches = ""; }
        }
        public void AssignRange()
        {
            precRange = precVal switch
            {
                <= 2 => "Clear",
                <= 4 => "Overcast",
                <= 6 => "Rain",
                >= 7 => "Downpour"
            };

            windRange = windVal switch
            {
                <= 1 => "Still",
                <= 4 => "Gentle",
                <= 5 => "Windy",
                >= 6 => "Gale"
            };

            //High wind and rain should make temperatures colder.
            if (precVal >= 6) { tempVal -= 1; }
            if (windVal >= 6) { tempVal -= 1; }

            tempRange = tempVal switch
            {
                <= 0 => "Freezing",
                <= 2 => "Cold",
                <= 4 => "Temperate",
                <= 6 => "Hot",
                >= 7 => "Burning"
            };

            if (matches == "Triple") { weatherCode = $"TRIPLE {tempRoll}, NUKE EM."; }
            else weatherCode = $"{tempRange}, {precRange}, {windRange}";
        }
        public void DefineWeather()
        {
            //Set all weather conditions to blank, otherwise they'll always trigger lol
            weatherConditions.Clear();
            weatherHazards.Clear();

            //Check for Snow
            switch (trbClimateTemp.Value)
            {
                case >= 1: //Snow in the desert/tropics should be possible but definitely uncommon.
                    if (tempVal <= 0 && precVal >= 5) { weatherConditions.Append("Snowy, "); }
                    break;

                case <= -1: //Snow in the taiga should be frequent.
                    if (tempVal <= 3 && precVal >= 5) { weatherConditions.Append("Snowy, "); }
                    break;

                default: //Snow everywhere else
                    if (tempVal <= 0 && precVal >= 5) { weatherConditions.Append("Snowy, "); }
                    break;
            };

            //Check for descriptors
            if (tempVal <= 4 && precVal >= 3 && windVal <= 3) { weatherConditions.Append("Misty, "); }
            if (tempVal <= 2 && precVal >= 3 && windVal <= 3) { weatherConditions.Append("Morning frost, "); }
            else if (tempVal >= 3 && tempVal <= 5 && precVal >= 2 && windVal <= 2) { weatherConditions.Append("Morning dew, "); }
            if (tempVal >=6 && precVal >= 4 && windVal <=2) { weatherConditions.Append("Sticky, ");  }

            //Checking for hazardous conditions.
            if (matches == "Double")
            {
                //Setting hazards based on basic conditions
                if (tempVal <= 0 || tempVal >= 7) { weatherHazards.Append(tempRange + ", "); }
                if (precVal >= 7) { weatherHazards.Append(precRange + ", "); }
                if (windVal >= 6) { weatherHazards.Append(windRange + ", "); }
                
                //Other conditions
                if (weatherConditions.ToString().Contains("Snowy, "))
                {
                    weatherHazards.Append("Snow, ");
                    if (windVal >= 5)
                    {
                        weatherHazards.Append("Blizzard, ");
                    }
                }
                    if (weatherConditions.ToString().Contains("Misty ")) { weatherHazards.Append("Fog, "); }
                    if (tempVal >= 3 && precVal >= 5 && windVal >= 4) { weatherHazards.Append("Thunderstorm, "); }
                    if (precVal <= 4 && windVal >= 7) { weatherHazards.Append("Windstorm, "); }
            }
            if (matches == "Triple")
            {
                weatherConditions.Clear();
                weatherConditions.Append($"TRIPLE {tempRoll}, NUKE EM");
                weatherHazards.Clear();
                weatherHazards.Append($"TRIPLE {tempRoll}, NUKE EM");
            }
            else //Remove any trailing commas from the end.
            {
                if (weatherConditions.Length >= 2) { weatherConditions.Length = weatherConditions.Length - 2; }
                if (weatherHazards.Length >= 2) { weatherHazards.Length = weatherHazards.Length - 2; }
            }
        } 
        public void FillDataView()
        {
            rollNum += 1;
            dgvWeather.Rows.Insert(0, rollNum, tempRoll, tempVal, precRoll, precVal, windRoll, windVal, weatherCode, weatherConditions.ToString(), weatherHazards.ToString());
        }
    }
}
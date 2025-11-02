using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
        string checkMatch = "null";
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
            lbxWeather.Items.Insert(0, $"{rollTemp} {rollPrec} {rollWind} {checkMatch}");
        }

        private void btnRollAll_Click(object sender, EventArgs e)
        {
            RollTemp();
            RollPrec();
            RollWind();
            checkDoubleTriple();
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
            checkDoubleTriple();
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
            checkDoubleTriple();
            GenWeather();
        }
        public void checkDoubleTriple()
        {
            if (rollTemp == rollPrec && rollPrec == rollWind && rollWind == rollTemp) //Check for triples
            {
                checkMatch = "- TRIPLE";
            }
            else if (rollTemp == rollPrec || rollPrec == rollWind || rollWind == rollTemp) //Check for doubles
            {
                checkMatch = "- Double";
            }
            else { checkMatch = ""; }

        }
    }
}

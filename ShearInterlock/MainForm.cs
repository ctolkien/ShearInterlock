using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitConversion;

namespace ShearInterlock
{
    public partial class MainForm : Form
    {
        public const string _code = "Per: CSA A23.3-04";

        Parameter Fc = new Parameter("fc", DisplayUnit.MEGAPASCAL, UnitType.STRESS);
        //public double Fc { get; set; }
        public double Lambda { get; set; }
        public double PhiC { get; set; }
        public double PhiS { get; set; }
        Parameter Avf = new Parameter("Avf", DisplayUnit.SQUARE_MILLIMETER, UnitType.AREA);
        //public double Avf { get; set; }
        Parameter Acv = new Parameter("Acv", DisplayUnit.SQUARE_MILLIMETER, UnitType.AREA);
        //public double Acv { get; set; }
        public double Rhov { get; set; }
        Parameter Fy = new Parameter("Fy", DisplayUnit.MEGAPASCAL, UnitType.STRESS);
        //public double Fy { get; set; }
        Parameter Ag = new Parameter("Ag", DisplayUnit.SQUARE_MILLIMETER, UnitType.AREA);
        //public double Ag { get; set; }
        Parameter N = new Parameter("N", DisplayUnit.KILONEWTON, UnitType.FORCE);
        //public double N { get; set; }
        public double AlphaS { get; set; }
        Parameter Vr = new Parameter("Vr", DisplayUnit.KILONEWTON, UnitType.FORCE);
        //public double Vr { get; set; }
        public double Sigma { get; set; }
         

        public double C;
        public double Mu;


        public MainForm()
        {
            InitializeComponent();

            codeLabel.Text = _code;
            cu1RadioButton.Text = "Concrete placed against clean concrete";
            cu2RadioButton.Text = "Concrete placed against clean, roughened concrete (amplitude > 5 mm)";
            cu3RadioButton.Text = "Concrete placed monolithically";
            cu4RadioButton.Text = "Concrete anchored to as-rolled structural steel by studs or reinforcement";

            avfToolTip.SetToolTip(avfTextBox, "Area of shear friction reinforcement");
            acvToolTip.SetToolTip(acvTextBox, "Area of concrete resisting shear transfer");

            C = 0.25;
            Mu = 0.60;
            cTextBox.Text = C.ToString();
            muTextBox.Text = Mu.ToString();

            vrLabel.Text = "";
            fcTextBox.Select();

        }

        public double StringReader(TextBox textbox)
        {
            if (!string.IsNullOrWhiteSpace(textbox.Text) && 
                double.TryParse(textbox.Text, out double number))
            {
                SelectNextControl(textbox, true, true, false, true);
                TextBox newtextbox = ActiveControl as TextBox;
                if(newtextbox != null)
                {
                    newtextbox.SelectionStart = 0;
                    newtextbox.SelectionLength = textbox.Text.Length;
                }
                return number;
            }
            else
            {
                MessageBox.Show("Invalid Entry");
                textbox.SelectionStart = 0;
                textbox.SelectionLength = textbox.Text.Length;
                return 0;
            }

        }

        public void UpdateCalc()
        {
            GetRhoV();
            GetSigma();
            GetVr();
        }

        public void GetVr()
        {
            if (Lambda * PhiC * (C + Mu * Sigma) > 0.25 * PhiC * Fc.Value)
            {
                Vr.Value = 0.25 * PhiC * Fc.Value + PhiS * Rhov * Fy.Value * Math.Cos(Math.PI * AlphaS / 180);
                Vr.Value = Math.Round(Vr.Value, 2);
                vrLabel.Text = "λϕc(c+μσ) > 0.25ϕcf'c";
            }
            else
            {
                Vr.Value = Lambda * PhiC * (C + Mu * Sigma) + PhiS * Rhov * Fy.Value * Math.Cos(Math.PI * AlphaS / 180);
                Vr.Value = Math.Round(Vr.Value, 2);
            }

            vrTextBox.Text = Vr.GetValueString();
        }

        public void GetSigma()
        {
            Sigma = Rhov * Fy.Value * Math.Sin(Math.PI * AlphaS / 180) + N.Value / Ag.Value;
            Sigma = Math.Round(Sigma, 2);
            sigmaTextBox.Text = Sigma.ToString();
        }

        public void GetRhoV()
        {
            Rhov = Avf.Value / Acv.Value;
            Rhov = Math.Round(Rhov, 2);
            rhovTextBox.Text = Rhov.ToString();
        }

        private void cu1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cu1RadioButton.Checked)
            {
                C = 0.25;
                Mu = 0.60;
                cTextBox.Text = C.ToString();
                muTextBox.Text = Mu.ToString();
                UpdateCalc();
            }
        }

        private void cu2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cu2RadioButton.Checked)
            {
                C = 0.50;
                Mu = 1.00;
                cTextBox.Text = C.ToString();
                muTextBox.Text = Mu.ToString();
                UpdateCalc();
            }
        }

        private void cu3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cu3RadioButton.Checked)
            {
                C = 1.00;
                Mu = 1.40;
                cTextBox.Text = C.ToString();
                muTextBox.Text = Mu.ToString();
                UpdateCalc();
            }
        }

        private void cu4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cu4RadioButton.Checked)
            {
                C = 0.00;
                Mu = 0.60;
                cTextBox.Text = C.ToString();
                muTextBox.Text = Mu.ToString();
                UpdateCalc();
            }
        }

        private void lambdaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Lambda = StringReader(lambdaTextBox);
                UpdateCalc();
            }
        }

        private void phicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PhiC = StringReader(phicTextBox);
                UpdateCalc();
            } 
        }

        private void phisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PhiS = StringReader(phisTextBox);
                UpdateCalc();
            }
        }

        private void avfTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Avf.SetValue(avfTextBox.Text);
                SelectNextControl(avfTextBox, true, true, false, true);
                avfTextBox.Text = Avf.GetValueString();
                UpdateCalc();
            }
        }

        private void acvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Acv.SetValue(acvTextBox.Text);
                SelectNextControl(acvTextBox, true, true, false, true);
                acvTextBox.Text = Acv.GetValueString();
                UpdateCalc();
            }
        }

        private void fyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Fy.SetValue(fyTextBox.Text);
                SelectNextControl(fyTextBox, true, true, false, true);
                fyTextBox.Text = Fy.GetValueString();
                UpdateCalc();
            }
        }

        private void agTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Ag.SetValue(agTextBox.Text);
                SelectNextControl(agTextBox, true, true, false, true);
                agTextBox.Text = Ag.GetValueString();
                UpdateCalc();
            }
        }

        private void nTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                N.SetValue(nTextBox.Text);
                SelectNextControl(nTextBox, true, true, false, true);
                nTextBox.Text = N.GetValueString();
                UpdateCalc();
            }
        }

        private void alphasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AlphaS = StringReader(alphasTextBox);
                UpdateCalc();
            }
        }

        private void fcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Fc.SetValue(fcTextBox.Text);
                SelectNextControl(fcTextBox, true, true, false, true);
                fcTextBox.Text = Fc.GetValueString();
                UpdateCalc();
            }
        }

        private void fcTextBox_Click(object sender, EventArgs e)
        {
            fcTextBox.SelectionStart = 0;
            fcTextBox.SelectionLength = fcTextBox.Text.Length;
        }

        private void lambdaTextBox_Click(object sender, EventArgs e)
        {
            lambdaTextBox.SelectionStart = 0;
            lambdaTextBox.SelectionLength = lambdaTextBox.Text.Length;
        }

        private void phicTextBox_Click(object sender, EventArgs e)
        {
            phicTextBox.SelectionStart = 0;
            phicTextBox.SelectionLength = phicTextBox.Text.Length;
        }

        private void phisTextBox_Click(object sender, EventArgs e)
        {
            phisTextBox.SelectionStart = 0;
            phisTextBox.SelectionLength = phisTextBox.Text.Length;
        }

        private void avfTextBox_Click(object sender, EventArgs e)
        {
            avfTextBox.SelectionStart = 0;
            avfTextBox.SelectionLength = avfTextBox.Text.Length;
        }

        private void acvTextBox_Click(object sender, EventArgs e)
        {
            acvTextBox.SelectionStart = 0;
            acvTextBox.SelectionLength = acvTextBox.Text.Length;
        }

        private void fyTextBox_Click(object sender, EventArgs e)
        {
            fyTextBox.SelectionStart = 0;
            fyTextBox.SelectionLength = fyTextBox.Text.Length;
        }

        private void agTextBox_Click(object sender, EventArgs e)
        {
            agTextBox.SelectionStart = 0;
            agTextBox.SelectionLength = agTextBox.Text.Length;
        }

        private void nTextBox_Click(object sender, EventArgs e)
        {
            nTextBox.SelectionStart = 0;
            nTextBox.SelectionLength = nTextBox.Text.Length;
        }

        private void alphasTextBox_Click(object sender, EventArgs e)
        {
            alphasTextBox.SelectionStart = 0;
            alphasTextBox.SelectionLength = nTextBox.Text.Length;
        }

        private void vrTextBox_Click(object sender, EventArgs e)
        {
            vrTextBox.SelectionStart = 0;
            vrTextBox.SelectionLength = vrTextBox.Text.Length;
        }
    }
}

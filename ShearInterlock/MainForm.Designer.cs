namespace ShearInterlock
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lambdaTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phicTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cu1RadioButton = new System.Windows.Forms.RadioButton();
            this.cu2RadioButton = new System.Windows.Forms.RadioButton();
            this.cu3RadioButton = new System.Windows.Forms.RadioButton();
            this.cu4RadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.muTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phisTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rhovTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.avfTextBox = new System.Windows.Forms.TextBox();
            this.avfToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.acvToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.acvTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.fyTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.agTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.alphasTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.vrTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.sigmaTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.fcTextBox = new System.Windows.Forms.TextBox();
            this.vrLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shear Interlock Transfer";
            // 
            // lambdaTextBox
            // 
            this.lambdaTextBox.Location = new System.Drawing.Point(57, 89);
            this.lambdaTextBox.Name = "lambdaTextBox";
            this.lambdaTextBox.Size = new System.Drawing.Size(100, 20);
            this.lambdaTextBox.TabIndex = 2;
            this.lambdaTextBox.Click += new System.EventHandler(this.lambdaTextBox_Click);
            this.lambdaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lambdaTextBox_KeyPress);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(12, 22);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(37, 13);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Steel Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "λ =";
            // 
            // phicTextBox
            // 
            this.phicTextBox.Location = new System.Drawing.Point(57, 115);
            this.phicTextBox.Name = "phicTextBox";
            this.phicTextBox.Size = new System.Drawing.Size(100, 20);
            this.phicTextBox.TabIndex = 3;
            this.phicTextBox.Click += new System.EventHandler(this.phicTextBox_Click);
            this.phicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phicTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ϕc =";
            // 
            // cu1RadioButton
            // 
            this.cu1RadioButton.AutoSize = true;
            this.cu1RadioButton.Checked = true;
            this.cu1RadioButton.Location = new System.Drawing.Point(33, 155);
            this.cu1RadioButton.Name = "cu1RadioButton";
            this.cu1RadioButton.Size = new System.Drawing.Size(214, 17);
            this.cu1RadioButton.TabIndex = 1;
            this.cu1RadioButton.TabStop = true;
            this.cu1RadioButton.Text = "Concrete placed against clean concrete";
            this.cu1RadioButton.UseVisualStyleBackColor = true;
            this.cu1RadioButton.CheckedChanged += new System.EventHandler(this.cu1RadioButton_CheckedChanged);
            // 
            // cu2RadioButton
            // 
            this.cu2RadioButton.AutoSize = true;
            this.cu2RadioButton.Location = new System.Drawing.Point(33, 178);
            this.cu2RadioButton.Name = "cu2RadioButton";
            this.cu2RadioButton.Size = new System.Drawing.Size(362, 17);
            this.cu2RadioButton.TabIndex = 1;
            this.cu2RadioButton.Text = "Concrete placed against clean, roughened concrete (amplitude > 5 mm)";
            this.cu2RadioButton.UseVisualStyleBackColor = true;
            this.cu2RadioButton.CheckedChanged += new System.EventHandler(this.cu2RadioButton_CheckedChanged);
            // 
            // cu3RadioButton
            // 
            this.cu3RadioButton.AutoSize = true;
            this.cu3RadioButton.Location = new System.Drawing.Point(33, 201);
            this.cu3RadioButton.Name = "cu3RadioButton";
            this.cu3RadioButton.Size = new System.Drawing.Size(168, 17);
            this.cu3RadioButton.TabIndex = 1;
            this.cu3RadioButton.Text = "Concrete placed monolithically";
            this.cu3RadioButton.UseVisualStyleBackColor = true;
            this.cu3RadioButton.CheckedChanged += new System.EventHandler(this.cu3RadioButton_CheckedChanged);
            // 
            // cu4RadioButton
            // 
            this.cu4RadioButton.AutoSize = true;
            this.cu4RadioButton.Location = new System.Drawing.Point(33, 224);
            this.cu4RadioButton.Name = "cu4RadioButton";
            this.cu4RadioButton.Size = new System.Drawing.Size(362, 17);
            this.cu4RadioButton.TabIndex = 1;
            this.cu4RadioButton.Text = "Concrete anchored to as-rolled structural steel by studs or reinforcement";
            this.cu4RadioButton.UseVisualStyleBackColor = true;
            this.cu4RadioButton.CheckedChanged += new System.EventHandler(this.cu4RadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "c =";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(57, 261);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.ReadOnly = true;
            this.cTextBox.Size = new System.Drawing.Size(100, 20);
            this.cTextBox.TabIndex = 1;
            this.cTextBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "μ =";
            // 
            // muTextBox
            // 
            this.muTextBox.Location = new System.Drawing.Point(57, 287);
            this.muTextBox.Name = "muTextBox";
            this.muTextBox.ReadOnly = true;
            this.muTextBox.Size = new System.Drawing.Size(100, 20);
            this.muTextBox.TabIndex = 1;
            this.muTextBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ϕs =";
            // 
            // phisTextBox
            // 
            this.phisTextBox.Location = new System.Drawing.Point(57, 341);
            this.phisTextBox.Name = "phisTextBox";
            this.phisTextBox.Size = new System.Drawing.Size(100, 20);
            this.phisTextBox.TabIndex = 4;
            this.phisTextBox.Click += new System.EventHandler(this.phisTextBox_Click);
            this.phisTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phisTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Concrete Input:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ρv =";
            // 
            // rhovTextBox
            // 
            this.rhovTextBox.Location = new System.Drawing.Point(57, 418);
            this.rhovTextBox.Name = "rhovTextBox";
            this.rhovTextBox.ReadOnly = true;
            this.rhovTextBox.Size = new System.Drawing.Size(100, 20);
            this.rhovTextBox.TabIndex = 1;
            this.rhovTextBox.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Avf =";
            // 
            // avfTextBox
            // 
            this.avfTextBox.Location = new System.Drawing.Point(57, 367);
            this.avfTextBox.Name = "avfTextBox";
            this.avfTextBox.Size = new System.Drawing.Size(100, 20);
            this.avfTextBox.TabIndex = 5;
            this.avfTextBox.Click += new System.EventHandler(this.avfTextBox_Click);
            this.avfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avfTextBox_KeyPress);
            // 
            // avfToolTip
            // 
            this.avfToolTip.AutomaticDelay = 100;
            this.avfToolTip.AutoPopDelay = 5000;
            this.avfToolTip.InitialDelay = 100;
            this.avfToolTip.IsBalloon = true;
            this.avfToolTip.ReshowDelay = 20;
            this.avfToolTip.ShowAlways = true;
            // 
            // acvToolTip
            // 
            this.acvToolTip.AutomaticDelay = 100;
            this.acvToolTip.AutoPopDelay = 5000;
            this.acvToolTip.InitialDelay = 100;
            this.acvToolTip.IsBalloon = true;
            this.acvToolTip.ReshowDelay = 20;
            this.acvToolTip.ShowAlways = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Acv =";
            // 
            // acvTextBox
            // 
            this.acvTextBox.Location = new System.Drawing.Point(57, 392);
            this.acvTextBox.Name = "acvTextBox";
            this.acvTextBox.Size = new System.Drawing.Size(100, 20);
            this.acvTextBox.TabIndex = 6;
            this.acvTextBox.Click += new System.EventHandler(this.acvTextBox_Click);
            this.acvTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acvTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "fy =";
            // 
            // fyTextBox
            // 
            this.fyTextBox.Location = new System.Drawing.Point(57, 470);
            this.fyTextBox.Name = "fyTextBox";
            this.fyTextBox.Size = new System.Drawing.Size(100, 20);
            this.fyTextBox.TabIndex = 7;
            this.fyTextBox.Click += new System.EventHandler(this.fyTextBox_Click);
            this.fyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fyTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 499);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ag =";
            // 
            // agTextBox
            // 
            this.agTextBox.Location = new System.Drawing.Point(57, 496);
            this.agTextBox.Name = "agTextBox";
            this.agTextBox.Size = new System.Drawing.Size(100, 20);
            this.agTextBox.TabIndex = 8;
            this.agTextBox.Click += new System.EventHandler(this.agTextBox_Click);
            this.agTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agTextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 559);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "N =";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(57, 556);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 20);
            this.nTextBox.TabIndex = 9;
            this.nTextBox.Click += new System.EventHandler(this.nTextBox_Click);
            this.nTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nTextBox_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 530);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Load and geometry Input:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 585);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "αs =";
            // 
            // alphasTextBox
            // 
            this.alphasTextBox.Location = new System.Drawing.Point(57, 582);
            this.alphasTextBox.Name = "alphasTextBox";
            this.alphasTextBox.Size = new System.Drawing.Size(100, 20);
            this.alphasTextBox.TabIndex = 10;
            this.alphasTextBox.Click += new System.EventHandler(this.alphasTextBox_Click);
            this.alphasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphasTextBox_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 611);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "vr =";
            // 
            // vrTextBox
            // 
            this.vrTextBox.Location = new System.Drawing.Point(57, 608);
            this.vrTextBox.Name = "vrTextBox";
            this.vrTextBox.Size = new System.Drawing.Size(100, 20);
            this.vrTextBox.TabIndex = 11;
            this.vrTextBox.Click += new System.EventHandler(this.vrTextBox_Click);
            this.vrTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphasTextBox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 447);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "σ =";
            // 
            // sigmaTextBox
            // 
            this.sigmaTextBox.Location = new System.Drawing.Point(57, 444);
            this.sigmaTextBox.Name = "sigmaTextBox";
            this.sigmaTextBox.ReadOnly = true;
            this.sigmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.sigmaTextBox.TabIndex = 1;
            this.sigmaTextBox.TabStop = false;
            this.sigmaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fyTextBox_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "fc =";
            // 
            // fcTextBox
            // 
            this.fcTextBox.Location = new System.Drawing.Point(57, 63);
            this.fcTextBox.Name = "fcTextBox";
            this.fcTextBox.Size = new System.Drawing.Size(100, 20);
            this.fcTextBox.TabIndex = 1;
            this.fcTextBox.Click += new System.EventHandler(this.fcTextBox_Click);
            this.fcTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fcTextBox_KeyPress);
            // 
            // vrLabel
            // 
            this.vrLabel.AutoSize = true;
            this.vrLabel.Location = new System.Drawing.Point(163, 611);
            this.vrLabel.Name = "vrLabel";
            this.vrLabel.Size = new System.Drawing.Size(60, 13);
            this.vrLabel.TabIndex = 0;
            this.vrLabel.Text = "WARNING";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 636);
            this.Controls.Add(this.cu4RadioButton);
            this.Controls.Add(this.cu3RadioButton);
            this.Controls.Add(this.cu2RadioButton);
            this.Controls.Add(this.muTextBox);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.acvTextBox);
            this.Controls.Add(this.avfTextBox);
            this.Controls.Add(this.vrTextBox);
            this.Controls.Add(this.alphasTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.agTextBox);
            this.Controls.Add(this.sigmaTextBox);
            this.Controls.Add(this.fyTextBox);
            this.Controls.Add(this.rhovTextBox);
            this.Controls.Add(this.phisTextBox);
            this.Controls.Add(this.phicTextBox);
            this.Controls.Add(this.vrLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cu1RadioButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fcTextBox);
            this.Controls.Add(this.lambdaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Concrete Shear Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lambdaTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phicTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton cu1RadioButton;
        private System.Windows.Forms.RadioButton cu4RadioButton;
        private System.Windows.Forms.RadioButton cu3RadioButton;
        private System.Windows.Forms.RadioButton cu2RadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox muTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phisTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rhovTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox avfTextBox;
        private System.Windows.Forms.ToolTip avfToolTip;
        private System.Windows.Forms.ToolTip acvToolTip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox acvTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fyTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox agTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox alphasTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox vrTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox sigmaTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox fcTextBox;
        private System.Windows.Forms.Label vrLabel;
    }
}


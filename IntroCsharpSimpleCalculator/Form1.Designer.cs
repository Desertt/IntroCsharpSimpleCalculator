namespace IntroCsharpSimpleCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelResultCalc = new System.Windows.Forms.Label();
            this.textBoxNumberSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberFirst = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonDividing = new System.Windows.Forms.Button();
            this.buttonmultiplying = new System.Windows.Forms.Button();
            this.buttonSubtracting = new System.Windows.Forms.Button();
            this.buttonAdding = new System.Windows.Forms.Button();
            this.labelShowPanel = new System.Windows.Forms.Label();
            this.labelWarningP2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelResultCalc);
            this.groupBox2.Controls.Add(this.textBoxNumberSecond);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNumberFirst);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.labelShowPanel);
            this.groupBox2.Controls.Add(this.labelWarningP2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 213);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basip Hesap Makinesi/Simple Calculator";
            // 
            // labelResultCalc
            // 
            this.labelResultCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelResultCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultCalc.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelResultCalc.Location = new System.Drawing.Point(210, 163);
            this.labelResultCalc.Name = "labelResultCalc";
            this.labelResultCalc.Size = new System.Drawing.Size(207, 26);
            this.labelResultCalc.TabIndex = 23;
            this.labelResultCalc.Text = "0";
            this.labelResultCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNumberSecond
            // 
            this.textBoxNumberSecond.Location = new System.Drawing.Point(152, 49);
            this.textBoxNumberSecond.Name = "textBoxNumberSecond";
            this.textBoxNumberSecond.Size = new System.Drawing.Size(115, 20);
            this.textBoxNumberSecond.TabIndex = 21;
            this.textBoxNumberSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberSecond_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sayı Giriniz / Enter number:";
            // 
            // textBoxNumberFirst
            // 
            this.textBoxNumberFirst.Location = new System.Drawing.Point(152, 23);
            this.textBoxNumberFirst.Name = "textBoxNumberFirst";
            this.textBoxNumberFirst.Size = new System.Drawing.Size(115, 20);
            this.textBoxNumberFirst.TabIndex = 10;
            this.textBoxNumberFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberFirst_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMod);
            this.panel1.Controls.Add(this.buttonDividing);
            this.panel1.Controls.Add(this.buttonmultiplying);
            this.panel1.Controls.Add(this.buttonSubtracting);
            this.panel1.Controls.Add(this.buttonAdding);
            this.panel1.Location = new System.Drawing.Point(66, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 80);
            this.panel1.TabIndex = 20;
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(210, 32);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(83, 27);
            this.buttonMod.TabIndex = 27;
            this.buttonMod.Text = "%MOD";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonDividing
            // 
            this.buttonDividing.Location = new System.Drawing.Point(117, 46);
            this.buttonDividing.Name = "buttonDividing";
            this.buttonDividing.Size = new System.Drawing.Size(83, 27);
            this.buttonDividing.TabIndex = 26;
            this.buttonDividing.Text = "/";
            this.buttonDividing.UseVisualStyleBackColor = true;
            this.buttonDividing.Click += new System.EventHandler(this.buttonDividing_Click);
            // 
            // buttonmultiplying
            // 
            this.buttonmultiplying.Location = new System.Drawing.Point(16, 46);
            this.buttonmultiplying.Name = "buttonmultiplying";
            this.buttonmultiplying.Size = new System.Drawing.Size(83, 27);
            this.buttonmultiplying.TabIndex = 25;
            this.buttonmultiplying.Text = "x";
            this.buttonmultiplying.UseVisualStyleBackColor = true;
            this.buttonmultiplying.Click += new System.EventHandler(this.buttonmultiplying_Click);
            // 
            // buttonSubtracting
            // 
            this.buttonSubtracting.Location = new System.Drawing.Point(117, 13);
            this.buttonSubtracting.Name = "buttonSubtracting";
            this.buttonSubtracting.Size = new System.Drawing.Size(83, 27);
            this.buttonSubtracting.TabIndex = 24;
            this.buttonSubtracting.Text = "-";
            this.buttonSubtracting.UseVisualStyleBackColor = true;
            this.buttonSubtracting.Click += new System.EventHandler(this.buttonSubtracting_Click);
            // 
            // buttonAdding
            // 
            this.buttonAdding.Location = new System.Drawing.Point(16, 13);
            this.buttonAdding.Name = "buttonAdding";
            this.buttonAdding.Size = new System.Drawing.Size(83, 27);
            this.buttonAdding.TabIndex = 23;
            this.buttonAdding.Text = "+";
            this.buttonAdding.UseVisualStyleBackColor = true;
            this.buttonAdding.Click += new System.EventHandler(this.buttonAdding_Click);
            // 
            // labelShowPanel
            // 
            this.labelShowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelShowPanel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelShowPanel.Location = new System.Drawing.Point(273, 16);
            this.labelShowPanel.Name = "labelShowPanel";
            this.labelShowPanel.Size = new System.Drawing.Size(157, 60);
            this.labelShowPanel.TabIndex = 19;
            this.labelShowPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWarningP2
            // 
            this.labelWarningP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarningP2.Location = new System.Drawing.Point(120, 165);
            this.labelWarningP2.Name = "labelWarningP2";
            this.labelWarningP2.Size = new System.Drawing.Size(84, 26);
            this.labelWarningP2.TabIndex = 16;
            this.labelWarningP2.Text = "Sonuç:/Result:";
            this.labelWarningP2.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sayı Giriniz / Enter number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 213);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basip Hesap Makinesi/Simple Calculator";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelResultCalc;
        private System.Windows.Forms.TextBox textBoxNumberSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberFirst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonDividing;
        private System.Windows.Forms.Button buttonmultiplying;
        private System.Windows.Forms.Button buttonSubtracting;
        private System.Windows.Forms.Button buttonAdding;
        private System.Windows.Forms.Label labelShowPanel;
        private System.Windows.Forms.Label labelWarningP2;
        private System.Windows.Forms.Label label5;
    }
}


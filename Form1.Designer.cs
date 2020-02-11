namespace Lab3_Marisa_Wade
{
    partial class frmMain
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
            this.grpboxGen = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.grpboxAge = new System.Windows.Forms.GroupBox();
            this.rdo30Over = new System.Windows.Forms.RadioButton();
            this.rdo30Under = new System.Windows.Forms.RadioButton();
            this.grpboxWght = new System.Windows.Forms.GroupBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.grpMeasurements = new System.Windows.Forms.GroupBox();
            this.lblWrist = new System.Windows.Forms.Label();
            this.lblForearm = new System.Windows.Forms.Label();
            this.lblHips = new System.Windows.Forms.Label();
            this.lblWaist = new System.Windows.Forms.Label();
            this.txtWrist = new System.Windows.Forms.TextBox();
            this.txtForearm = new System.Windows.Forms.TextBox();
            this.txtHips = new System.Windows.Forms.TextBox();
            this.txtWaist = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpboxGen.SuspendLayout();
            this.grpboxAge.SuspendLayout();
            this.grpboxWght.SuspendLayout();
            this.grpMeasurements.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxGen
            // 
            this.grpboxGen.Controls.Add(this.rdoFemale);
            this.grpboxGen.Controls.Add(this.rdoMale);
            this.grpboxGen.Location = new System.Drawing.Point(12, 12);
            this.grpboxGen.Name = "grpboxGen";
            this.grpboxGen.Size = new System.Drawing.Size(161, 50);
            this.grpboxGen.TabIndex = 0;
            this.grpboxGen.TabStop = false;
            this.grpboxGen.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(79, 19);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 19);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // grpboxAge
            // 
            this.grpboxAge.Controls.Add(this.rdo30Over);
            this.grpboxAge.Controls.Add(this.rdo30Under);
            this.grpboxAge.Location = new System.Drawing.Point(227, 12);
            this.grpboxAge.Name = "grpboxAge";
            this.grpboxAge.Size = new System.Drawing.Size(200, 50);
            this.grpboxAge.TabIndex = 0;
            this.grpboxAge.TabStop = false;
            this.grpboxAge.Text = "Age";
            // 
            // rdo30Over
            // 
            this.rdo30Over.AutoSize = true;
            this.rdo30Over.Location = new System.Drawing.Point(97, 19);
            this.rdo30Over.Name = "rdo30Over";
            this.rdo30Over.Size = new System.Drawing.Size(63, 17);
            this.rdo30Over.TabIndex = 2;
            this.rdo30Over.TabStop = true;
            this.rdo30Over.Text = "Over 30";
            this.rdo30Over.UseVisualStyleBackColor = true;
            // 
            // rdo30Under
            // 
            this.rdo30Under.AutoSize = true;
            this.rdo30Under.Location = new System.Drawing.Point(6, 19);
            this.rdo30Under.Name = "rdo30Under";
            this.rdo30Under.Size = new System.Drawing.Size(88, 17);
            this.rdo30Under.TabIndex = 3;
            this.rdo30Under.TabStop = true;
            this.rdo30Under.Text = "30 and under";
            this.rdo30Under.UseVisualStyleBackColor = true;
            // 
            // grpboxWght
            // 
            this.grpboxWght.Controls.Add(this.lblWeight);
            this.grpboxWght.Controls.Add(this.txtWeight);
            this.grpboxWght.Location = new System.Drawing.Point(487, 12);
            this.grpboxWght.Name = "grpboxWght";
            this.grpboxWght.Size = new System.Drawing.Size(200, 50);
            this.grpboxWght.TabIndex = 1;
            this.grpboxWght.TabStop = false;
            this.grpboxWght.Text = "Weight";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(98, 21);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(43, 13);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Pounds";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(25, 19);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(67, 20);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // grpMeasurements
            // 
            this.grpMeasurements.Controls.Add(this.lblWrist);
            this.grpMeasurements.Controls.Add(this.lblForearm);
            this.grpMeasurements.Controls.Add(this.lblHips);
            this.grpMeasurements.Controls.Add(this.lblWaist);
            this.grpMeasurements.Controls.Add(this.txtWrist);
            this.grpMeasurements.Controls.Add(this.txtForearm);
            this.grpMeasurements.Controls.Add(this.txtHips);
            this.grpMeasurements.Controls.Add(this.txtWaist);
            this.grpMeasurements.Location = new System.Drawing.Point(18, 81);
            this.grpMeasurements.Name = "grpMeasurements";
            this.grpMeasurements.Size = new System.Drawing.Size(669, 223);
            this.grpMeasurements.TabIndex = 3;
            this.grpMeasurements.TabStop = false;
            this.grpMeasurements.Text = "Measurements in inches";
            // 
            // lblWrist
            // 
            this.lblWrist.AutoSize = true;
            this.lblWrist.Location = new System.Drawing.Point(121, 181);
            this.lblWrist.Name = "lblWrist";
            this.lblWrist.Size = new System.Drawing.Size(325, 13);
            this.lblWrist.TabIndex = 7;
            this.lblWrist.Text = "WRIST - Measure just above bony protuberance towards the hand.";
            // 
            // lblForearm
            // 
            this.lblForearm.AutoSize = true;
            this.lblForearm.Location = new System.Drawing.Point(121, 131);
            this.lblForearm.Name = "lblForearm";
            this.lblForearm.Size = new System.Drawing.Size(341, 13);
            this.lblForearm.TabIndex = 6;
            this.lblForearm.Text = "FOREARM - Clench fist, measure widest part between wrist and elbow.";
            // 
            // lblHips
            // 
            this.lblHips.AutoSize = true;
            this.lblHips.Location = new System.Drawing.Point(120, 85);
            this.lblHips.Name = "lblHips";
            this.lblHips.Size = new System.Drawing.Size(398, 13);
            this.lblHips.TabIndex = 5;
            this.lblHips.Text = "HIPS - Feet 4 inches apart, measure at greatest circumfrence around hips and butt" +
    ".";
            // 
            // lblWaist
            // 
            this.lblWaist.AutoSize = true;
            this.lblWaist.Location = new System.Drawing.Point(121, 35);
            this.lblWaist.Name = "lblWaist";
            this.lblWaist.Size = new System.Drawing.Size(331, 13);
            this.lblWaist.TabIndex = 4;
            this.lblWaist.Text = "WAIST - Measure at greatest circumfrence; relaxed and comfortable.";
            // 
            // txtWrist
            // 
            this.txtWrist.Location = new System.Drawing.Point(15, 174);
            this.txtWrist.Name = "txtWrist";
            this.txtWrist.Size = new System.Drawing.Size(67, 20);
            this.txtWrist.TabIndex = 3;
            // 
            // txtForearm
            // 
            this.txtForearm.Location = new System.Drawing.Point(15, 124);
            this.txtForearm.Name = "txtForearm";
            this.txtForearm.Size = new System.Drawing.Size(67, 20);
            this.txtForearm.TabIndex = 2;
            // 
            // txtHips
            // 
            this.txtHips.Location = new System.Drawing.Point(15, 78);
            this.txtHips.Name = "txtHips";
            this.txtHips.Size = new System.Drawing.Size(67, 20);
            this.txtHips.TabIndex = 1;
            // 
            // txtWaist
            // 
            this.txtWaist.Location = new System.Drawing.Point(15, 32);
            this.txtWaist.Name = "txtWaist";
            this.txtWaist.Size = new System.Drawing.Size(67, 20);
            this.txtWaist.TabIndex = 0;
            // 
            // grpResults
            // 
            this.grpResults.Location = new System.Drawing.Point(204, 320);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(483, 100);
            this.grpResults.TabIndex = 4;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            this.grpResults.Enter += new System.EventHandler(this.grpResults_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 329);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(33, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpMeasurements);
            this.Controls.Add(this.grpboxWght);
            this.Controls.Add(this.grpboxAge);
            this.Controls.Add(this.grpboxGen);
            this.Name = "frmMain";
            this.Text = "Ideal Weight Estimator";
            this.grpboxGen.ResumeLayout(false);
            this.grpboxGen.PerformLayout();
            this.grpboxAge.ResumeLayout(false);
            this.grpboxAge.PerformLayout();
            this.grpboxWght.ResumeLayout(false);
            this.grpboxWght.PerformLayout();
            this.grpMeasurements.ResumeLayout(false);
            this.grpMeasurements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxGen;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.GroupBox grpboxAge;
        private System.Windows.Forms.RadioButton rdo30Over;
        private System.Windows.Forms.RadioButton rdo30Under;
        private System.Windows.Forms.GroupBox grpboxWght;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.GroupBox grpMeasurements;
        private System.Windows.Forms.Label lblWrist;
        private System.Windows.Forms.Label lblForearm;
        private System.Windows.Forms.Label lblHips;
        private System.Windows.Forms.Label lblWaist;
        private System.Windows.Forms.TextBox txtWrist;
        private System.Windows.Forms.TextBox txtForearm;
        private System.Windows.Forms.TextBox txtHips;
        private System.Windows.Forms.TextBox txtWaist;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}


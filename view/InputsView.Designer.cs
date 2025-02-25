﻿namespace ReuseSchemeTool.view
{
    partial class InputsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputsView));
            this.clbSectionTypes = new System.Windows.Forms.CheckedListBox();
            this.prgbProgress = new System.Windows.Forms.ProgressBar();
            this.trbMinLength = new System.Windows.Forms.TrackBar();
            this.trbMaxLength = new System.Windows.Forms.TrackBar();
            this.lblProgrBar = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblSectionTypes = new System.Windows.Forms.Label();
            this.lblSteelGrades = new System.Windows.Forms.Label();
            this.clbSteelGrades = new System.Windows.Forms.CheckedListBox();
            this.lblMinLength = new System.Windows.Forms.Label();
            this.lblMaxLength = new System.Windows.Forms.Label();
            this.trbMinWeight = new System.Windows.Forms.TrackBar();
            this.trbMaxWeight = new System.Windows.Forms.TrackBar();
            this.lblMinWeight = new System.Windows.Forms.Label();
            this.lblMaxWeight = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMinLengthValue = new System.Windows.Forms.Label();
            this.lblMaxLengthValue = new System.Windows.Forms.Label();
            this.lblMinWeightValue = new System.Windows.Forms.Label();
            this.lblMaxWeightValue = new System.Windows.Forms.Label();
            this.lblCutOffValue = new System.Windows.Forms.Label();
            this.lblCutOff = new System.Windows.Forms.Label();
            this.trbCutOff = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMaxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCutOff)).BeginInit();
            this.SuspendLayout();
            // 
            // clbSectionTypes
            // 
            this.clbSectionTypes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSectionTypes.FormattingEnabled = true;
            this.clbSectionTypes.Items.AddRange(new object[] {
            "CHS",
            "PFC",
            "RHS",
            "SHS",
            "UB",
            "UC"});
            this.clbSectionTypes.Location = new System.Drawing.Point(20, 92);
            this.clbSectionTypes.Margin = new System.Windows.Forms.Padding(2);
            this.clbSectionTypes.Name = "clbSectionTypes";
            this.clbSectionTypes.Size = new System.Drawing.Size(113, 84);
            this.clbSectionTypes.TabIndex = 0;
            // 
            // prgbProgress
            // 
            this.prgbProgress.Location = new System.Drawing.Point(20, 596);
            this.prgbProgress.Margin = new System.Windows.Forms.Padding(2);
            this.prgbProgress.Name = "prgbProgress";
            this.prgbProgress.Size = new System.Drawing.Size(242, 26);
            this.prgbProgress.TabIndex = 1;
            // 
            // trbMinLength
            // 
            this.trbMinLength.Location = new System.Drawing.Point(25, 217);
            this.trbMinLength.Margin = new System.Windows.Forms.Padding(2);
            this.trbMinLength.Maximum = 6;
            this.trbMinLength.Minimum = 2;
            this.trbMinLength.Name = "trbMinLength";
            this.trbMinLength.Size = new System.Drawing.Size(193, 45);
            this.trbMinLength.TabIndex = 2;
            this.trbMinLength.Value = 2;
            // 
            // trbMaxLength
            // 
            this.trbMaxLength.BackColor = System.Drawing.SystemColors.Control;
            this.trbMaxLength.Location = new System.Drawing.Point(25, 278);
            this.trbMaxLength.Margin = new System.Windows.Forms.Padding(2);
            this.trbMaxLength.Maximum = 18;
            this.trbMaxLength.Minimum = 6;
            this.trbMaxLength.Name = "trbMaxLength";
            this.trbMaxLength.Size = new System.Drawing.Size(193, 45);
            this.trbMaxLength.TabIndex = 3;
            this.trbMaxLength.Value = 6;
            // 
            // lblProgrBar
            // 
            this.lblProgrBar.AutoSize = true;
            this.lblProgrBar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrBar.Location = new System.Drawing.Point(17, 574);
            this.lblProgrBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgrBar.Name = "lblProgrBar";
            this.lblProgrBar.Size = new System.Drawing.Size(120, 13);
            this.lblProgrBar.TabIndex = 29;
            this.lblProgrBar.Text = "Iteration in Progress...";
            // 
            // btnRun
            // 
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(91, 522);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(106, 38);
            this.btnRun.TabIndex = 30;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblSectionTypes
            // 
            this.lblSectionTypes.AutoSize = true;
            this.lblSectionTypes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionTypes.Location = new System.Drawing.Point(35, 76);
            this.lblSectionTypes.Name = "lblSectionTypes";
            this.lblSectionTypes.Size = new System.Drawing.Size(84, 13);
            this.lblSectionTypes.TabIndex = 36;
            this.lblSectionTypes.Text = "SECTION TYPES";
            // 
            // lblSteelGrades
            // 
            this.lblSteelGrades.AutoSize = true;
            this.lblSteelGrades.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteelGrades.Location = new System.Drawing.Point(168, 76);
            this.lblSteelGrades.Name = "lblSteelGrades";
            this.lblSteelGrades.Size = new System.Drawing.Size(81, 13);
            this.lblSteelGrades.TabIndex = 38;
            this.lblSteelGrades.Text = "STEEL GRADES";
            // 
            // clbSteelGrades
            // 
            this.clbSteelGrades.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSteelGrades.FormattingEnabled = true;
            this.clbSteelGrades.Items.AddRange(new object[] {
            "S455",
            "S355",
            "S275",
            "S235",
            "Steel",
            "UNKNOWN"});
            this.clbSteelGrades.Location = new System.Drawing.Point(150, 92);
            this.clbSteelGrades.Margin = new System.Windows.Forms.Padding(2);
            this.clbSteelGrades.Name = "clbSteelGrades";
            this.clbSteelGrades.Size = new System.Drawing.Size(113, 84);
            this.clbSteelGrades.TabIndex = 37;
            // 
            // lblMinLength
            // 
            this.lblMinLength.AutoSize = true;
            this.lblMinLength.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinLength.Location = new System.Drawing.Point(69, 201);
            this.lblMinLength.Name = "lblMinLength";
            this.lblMinLength.Size = new System.Drawing.Size(121, 13);
            this.lblMinLength.TabIndex = 39;
            this.lblMinLength.Text = "MINIMUM LENGTH [m]";
            // 
            // lblMaxLength
            // 
            this.lblMaxLength.AutoSize = true;
            this.lblMaxLength.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLength.Location = new System.Drawing.Point(68, 261);
            this.lblMaxLength.Name = "lblMaxLength";
            this.lblMaxLength.Size = new System.Drawing.Size(123, 13);
            this.lblMaxLength.TabIndex = 40;
            this.lblMaxLength.Text = "MAXIMUM LENGTH [m]";
            // 
            // trbMinWeight
            // 
            this.trbMinWeight.LargeChange = 10;
            this.trbMinWeight.Location = new System.Drawing.Point(25, 400);
            this.trbMinWeight.Margin = new System.Windows.Forms.Padding(2);
            this.trbMinWeight.Maximum = 100;
            this.trbMinWeight.Minimum = 10;
            this.trbMinWeight.Name = "trbMinWeight";
            this.trbMinWeight.Size = new System.Drawing.Size(193, 45);
            this.trbMinWeight.SmallChange = 5;
            this.trbMinWeight.TabIndex = 41;
            this.trbMinWeight.Value = 10;
            // 
            // trbMaxWeight
            // 
            this.trbMaxWeight.LargeChange = 100;
            this.trbMaxWeight.Location = new System.Drawing.Point(25, 461);
            this.trbMaxWeight.Margin = new System.Windows.Forms.Padding(2);
            this.trbMaxWeight.Maximum = 800;
            this.trbMaxWeight.Minimum = 100;
            this.trbMaxWeight.Name = "trbMaxWeight";
            this.trbMaxWeight.Size = new System.Drawing.Size(193, 45);
            this.trbMaxWeight.SmallChange = 25;
            this.trbMaxWeight.TabIndex = 42;
            this.trbMaxWeight.Value = 100;
            this.trbMaxWeight.Scroll += new System.EventHandler(this.trbMaxWeight_Scroll);
            // 
            // lblMinWeight
            // 
            this.lblMinWeight.AutoSize = true;
            this.lblMinWeight.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinWeight.Location = new System.Drawing.Point(60, 381);
            this.lblMinWeight.Name = "lblMinWeight";
            this.lblMinWeight.Size = new System.Drawing.Size(139, 13);
            this.lblMinWeight.TabIndex = 43;
            this.lblMinWeight.Text = "MINIMUM WEIGHT [kg/m]";
            // 
            // lblMaxWeight
            // 
            this.lblMaxWeight.AutoSize = true;
            this.lblMaxWeight.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWeight.Location = new System.Drawing.Point(59, 441);
            this.lblMaxWeight.Name = "lblMaxWeight";
            this.lblMaxWeight.Size = new System.Drawing.Size(141, 13);
            this.lblMaxWeight.TabIndex = 44;
            this.lblMaxWeight.Text = "MAXIMUM WEIGHT [kg/m]";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(22, 9);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(239, 53);
            this.lblDescription.TabIndex = 45;
            this.lblDescription.Text = "Select Section Type, Steel Grade as well as range of lengths and weights that are" +
    " acceptable for reuse purposes.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMinLengthValue
            // 
            this.lblMinLengthValue.BackColor = System.Drawing.SystemColors.Info;
            this.lblMinLengthValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinLengthValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinLengthValue.Location = new System.Drawing.Point(222, 217);
            this.lblMinLengthValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinLengthValue.Name = "lblMinLengthValue";
            this.lblMinLengthValue.Size = new System.Drawing.Size(45, 20);
            this.lblMinLengthValue.TabIndex = 50;
            this.lblMinLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxLengthValue
            // 
            this.lblMaxLengthValue.BackColor = System.Drawing.SystemColors.Info;
            this.lblMaxLengthValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxLengthValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLengthValue.Location = new System.Drawing.Point(222, 278);
            this.lblMaxLengthValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxLengthValue.Name = "lblMaxLengthValue";
            this.lblMaxLengthValue.Size = new System.Drawing.Size(45, 20);
            this.lblMaxLengthValue.TabIndex = 51;
            this.lblMaxLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinWeightValue
            // 
            this.lblMinWeightValue.BackColor = System.Drawing.SystemColors.Info;
            this.lblMinWeightValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinWeightValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinWeightValue.Location = new System.Drawing.Point(222, 400);
            this.lblMinWeightValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinWeightValue.Name = "lblMinWeightValue";
            this.lblMinWeightValue.Size = new System.Drawing.Size(45, 20);
            this.lblMinWeightValue.TabIndex = 52;
            this.lblMinWeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxWeightValue
            // 
            this.lblMaxWeightValue.BackColor = System.Drawing.SystemColors.Info;
            this.lblMaxWeightValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxWeightValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWeightValue.Location = new System.Drawing.Point(222, 461);
            this.lblMaxWeightValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxWeightValue.Name = "lblMaxWeightValue";
            this.lblMaxWeightValue.Size = new System.Drawing.Size(45, 20);
            this.lblMaxWeightValue.TabIndex = 53;
            this.lblMaxWeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCutOffValue
            // 
            this.lblCutOffValue.BackColor = System.Drawing.SystemColors.Info;
            this.lblCutOffValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCutOffValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutOffValue.Location = new System.Drawing.Point(222, 339);
            this.lblCutOffValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCutOffValue.Name = "lblCutOffValue";
            this.lblCutOffValue.Size = new System.Drawing.Size(45, 20);
            this.lblCutOffValue.TabIndex = 56;
            this.lblCutOffValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCutOff
            // 
            this.lblCutOff.AutoSize = true;
            this.lblCutOff.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutOff.Location = new System.Drawing.Point(78, 321);
            this.lblCutOff.Name = "lblCutOff";
            this.lblCutOff.Size = new System.Drawing.Size(102, 13);
            this.lblCutOff.TabIndex = 55;
            this.lblCutOff.Text = "ENDS CUT-OFF [m]";
            // 
            // trbCutOff
            // 
            this.trbCutOff.BackColor = System.Drawing.SystemColors.Control;
            this.trbCutOff.Location = new System.Drawing.Point(25, 339);
            this.trbCutOff.Margin = new System.Windows.Forms.Padding(2);
            this.trbCutOff.Name = "trbCutOff";
            this.trbCutOff.Size = new System.Drawing.Size(193, 45);
            this.trbCutOff.TabIndex = 54;
            // 
            // InputsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 645);
            this.Controls.Add(this.lblCutOffValue);
            this.Controls.Add(this.lblCutOff);
            this.Controls.Add(this.lblMaxWeightValue);
            this.Controls.Add(this.lblMinWeightValue);
            this.Controls.Add(this.lblMaxLengthValue);
            this.Controls.Add(this.lblMinLengthValue);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMaxWeight);
            this.Controls.Add(this.lblMinWeight);
            this.Controls.Add(this.trbMaxWeight);
            this.Controls.Add(this.trbMinWeight);
            this.Controls.Add(this.lblMaxLength);
            this.Controls.Add(this.lblMinLength);
            this.Controls.Add(this.lblSteelGrades);
            this.Controls.Add(this.clbSteelGrades);
            this.Controls.Add(this.lblSectionTypes);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblProgrBar);
            this.Controls.Add(this.trbMaxLength);
            this.Controls.Add(this.trbMinLength);
            this.Controls.Add(this.prgbProgress);
            this.Controls.Add(this.clbSectionTypes);
            this.Controls.Add(this.trbCutOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputsView";
            this.Text = "InputsView";
            ((System.ComponentModel.ISupportInitialize)(this.trbMinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMaxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCutOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckedListBox clbSectionTypes;
        public System.Windows.Forms.ProgressBar prgbProgress;
        public System.Windows.Forms.TrackBar trbMinLength;
        public System.Windows.Forms.TrackBar trbMaxLength;
        internal System.Windows.Forms.Label lblProgrBar;
        public System.Windows.Forms.Button btnRun;
        internal System.Windows.Forms.Label lblSectionTypes;
        internal System.Windows.Forms.Label lblSteelGrades;
        public System.Windows.Forms.CheckedListBox clbSteelGrades;
        internal System.Windows.Forms.Label lblMinLength;
        internal System.Windows.Forms.Label lblMaxLength;
        public System.Windows.Forms.TrackBar trbMinWeight;
        public System.Windows.Forms.TrackBar trbMaxWeight;
        internal System.Windows.Forms.Label lblMinWeight;
        internal System.Windows.Forms.Label lblMaxWeight;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.Label lblMinLengthValue;
        public System.Windows.Forms.Label lblMaxLengthValue;
        public System.Windows.Forms.Label lblMinWeightValue;
        public System.Windows.Forms.Label lblMaxWeightValue;
        public System.Windows.Forms.Label lblCutOffValue;
        internal System.Windows.Forms.Label lblCutOff;
        public System.Windows.Forms.TrackBar trbCutOff;
    }
}
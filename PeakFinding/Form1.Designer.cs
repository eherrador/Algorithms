namespace PeakFinding
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
            this.btnPeakFinding1D = new System.Windows.Forms.Button();
            this.gbPeak1D = new System.Windows.Forms.GroupBox();
            this.lblArrayLength = new System.Windows.Forms.Label();
            this.txtArrayLength = new System.Windows.Forms.TextBox();
            this.rbtnDivideAndConquer = new System.Windows.Forms.RadioButton();
            this.rbtnScanAllArray = new System.Windows.Forms.RadioButton();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.gbPeak2D = new System.Windows.Forms.GroupBox();
            this.btnPeakFinding2D = new System.Windows.Forms.Button();
            this.txtMatrixDimension = new System.Windows.Forms.TextBox();
            this.lblMatrixDimension = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtnScanAllMatrix = new System.Windows.Forms.RadioButton();
            this.gbPeak1D.SuspendLayout();
            this.gbPeak2D.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPeakFinding1D
            // 
            this.btnPeakFinding1D.Location = new System.Drawing.Point(217, 42);
            this.btnPeakFinding1D.Name = "btnPeakFinding1D";
            this.btnPeakFinding1D.Size = new System.Drawing.Size(136, 23);
            this.btnPeakFinding1D.TabIndex = 5;
            this.btnPeakFinding1D.Text = "Run the algorithm";
            this.btnPeakFinding1D.UseVisualStyleBackColor = true;
            this.btnPeakFinding1D.Click += new System.EventHandler(this.btnPeakFinding1D_Click);
            // 
            // gbPeak1D
            // 
            this.gbPeak1D.Controls.Add(this.lblArrayLength);
            this.gbPeak1D.Controls.Add(this.txtArrayLength);
            this.gbPeak1D.Controls.Add(this.rbtnDivideAndConquer);
            this.gbPeak1D.Controls.Add(this.btnPeakFinding1D);
            this.gbPeak1D.Controls.Add(this.rbtnScanAllArray);
            this.gbPeak1D.Location = new System.Drawing.Point(12, 12);
            this.gbPeak1D.Name = "gbPeak1D";
            this.gbPeak1D.Size = new System.Drawing.Size(359, 75);
            this.gbPeak1D.TabIndex = 0;
            this.gbPeak1D.TabStop = false;
            this.gbPeak1D.Text = "Peak Finding 1D";
            // 
            // lblArrayLength
            // 
            this.lblArrayLength.AutoSize = true;
            this.lblArrayLength.Location = new System.Drawing.Point(217, 20);
            this.lblArrayLength.Name = "lblArrayLength";
            this.lblArrayLength.Size = new System.Drawing.Size(67, 13);
            this.lblArrayLength.TabIndex = 3;
            this.lblArrayLength.Text = "Array Length";
            // 
            // txtArrayLength
            // 
            this.txtArrayLength.Location = new System.Drawing.Point(291, 16);
            this.txtArrayLength.MaxLength = 3;
            this.txtArrayLength.Name = "txtArrayLength";
            this.txtArrayLength.Size = new System.Drawing.Size(61, 20);
            this.txtArrayLength.TabIndex = 4;
            this.txtArrayLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtnDivideAndConquer
            // 
            this.rbtnDivideAndConquer.AutoSize = true;
            this.rbtnDivideAndConquer.Location = new System.Drawing.Point(7, 48);
            this.rbtnDivideAndConquer.Name = "rbtnDivideAndConquer";
            this.rbtnDivideAndConquer.Size = new System.Drawing.Size(119, 17);
            this.rbtnDivideAndConquer.TabIndex = 2;
            this.rbtnDivideAndConquer.Text = "Divide and Conquer";
            this.rbtnDivideAndConquer.UseVisualStyleBackColor = true;
            // 
            // rbtnScanAllArray
            // 
            this.rbtnScanAllArray.AutoSize = true;
            this.rbtnScanAllArray.Checked = true;
            this.rbtnScanAllArray.Location = new System.Drawing.Point(7, 24);
            this.rbtnScanAllArray.Name = "rbtnScanAllArray";
            this.rbtnScanAllArray.Size = new System.Drawing.Size(164, 17);
            this.rbtnScanAllArray.TabIndex = 1;
            this.rbtnScanAllArray.TabStop = true;
            this.rbtnScanAllArray.Text = "Scan all array from left to right";
            this.rbtnScanAllArray.UseVisualStyleBackColor = true;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 221);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.ScrollAlwaysVisible = true;
            this.lstOutput.Size = new System.Drawing.Size(359, 199);
            this.lstOutput.TabIndex = 3;
            // 
            // gbPeak2D
            // 
            this.gbPeak2D.Controls.Add(this.btnPeakFinding2D);
            this.gbPeak2D.Controls.Add(this.txtMatrixDimension);
            this.gbPeak2D.Controls.Add(this.lblMatrixDimension);
            this.gbPeak2D.Controls.Add(this.radioButton2);
            this.gbPeak2D.Controls.Add(this.radioButton1);
            this.gbPeak2D.Controls.Add(this.rbtnScanAllMatrix);
            this.gbPeak2D.Location = new System.Drawing.Point(12, 106);
            this.gbPeak2D.Name = "gbPeak2D";
            this.gbPeak2D.Size = new System.Drawing.Size(359, 100);
            this.gbPeak2D.TabIndex = 6;
            this.gbPeak2D.TabStop = false;
            this.gbPeak2D.Text = "Peak Finding 2D";
            // 
            // btnPeakFinding2D
            // 
            this.btnPeakFinding2D.Location = new System.Drawing.Point(217, 67);
            this.btnPeakFinding2D.Name = "btnPeakFinding2D";
            this.btnPeakFinding2D.Size = new System.Drawing.Size(135, 23);
            this.btnPeakFinding2D.TabIndex = 12;
            this.btnPeakFinding2D.Text = "Run the algorithm";
            this.btnPeakFinding2D.UseVisualStyleBackColor = true;
            this.btnPeakFinding2D.Click += new System.EventHandler(this.btnPeakFinding2D_Click);
            // 
            // txtMatrixDimension
            // 
            this.txtMatrixDimension.Location = new System.Drawing.Point(291, 35);
            this.txtMatrixDimension.MaxLength = 3;
            this.txtMatrixDimension.Name = "txtMatrixDimension";
            this.txtMatrixDimension.Size = new System.Drawing.Size(61, 20);
            this.txtMatrixDimension.TabIndex = 11;
            this.txtMatrixDimension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMatrixDimension
            // 
            this.lblMatrixDimension.AutoSize = true;
            this.lblMatrixDimension.Location = new System.Drawing.Point(265, 19);
            this.lblMatrixDimension.Name = "lblMatrixDimension";
            this.lblMatrixDimension.Size = new System.Drawing.Size(87, 13);
            this.lblMatrixDimension.TabIndex = 10;
            this.lblMatrixDimension.Text = "Matrix Dimension";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtnScanAllMatrix
            // 
            this.rbtnScanAllMatrix.AutoSize = true;
            this.rbtnScanAllMatrix.Checked = true;
            this.rbtnScanAllMatrix.Location = new System.Drawing.Point(6, 19);
            this.rbtnScanAllMatrix.Name = "rbtnScanAllMatrix";
            this.rbtnScanAllMatrix.Size = new System.Drawing.Size(188, 17);
            this.rbtnScanAllMatrix.TabIndex = 7;
            this.rbtnScanAllMatrix.TabStop = true;
            this.rbtnScanAllMatrix.Text = "Scan matrix from L to R and T to B";
            this.rbtnScanAllMatrix.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 428);
            this.Controls.Add(this.gbPeak2D);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.gbPeak1D);
            this.Name = "Form1";
            this.Text = "Peak Finding";
            this.gbPeak1D.ResumeLayout(false);
            this.gbPeak1D.PerformLayout();
            this.gbPeak2D.ResumeLayout(false);
            this.gbPeak2D.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPeakFinding1D;
        private System.Windows.Forms.GroupBox gbPeak1D;
        private System.Windows.Forms.RadioButton rbtnDivideAndConquer;
        private System.Windows.Forms.RadioButton rbtnScanAllArray;
        private System.Windows.Forms.Label lblArrayLength;
        private System.Windows.Forms.TextBox txtArrayLength;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.GroupBox gbPeak2D;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtnScanAllMatrix;
        private System.Windows.Forms.Button btnPeakFinding2D;
        private System.Windows.Forms.TextBox txtMatrixDimension;
        private System.Windows.Forms.Label lblMatrixDimension;

    }
}


﻿namespace CSC455_ProjectCalculator
{
    partial class AdvancedCalc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.circlePerim = new System.Windows.Forms.Button();
            this.trianglePerim = new System.Windows.Forms.Button();
            this.rectPerim = new System.Windows.Forms.Button();
            this.circleArea = new System.Windows.Forms.Button();
            this.triangleArea = new System.Windows.Forms.Button();
            this.rectArea = new System.Windows.Forms.Button();
            this.dotProd = new System.Windows.Forms.Button();
            this.crossProd = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnQuadRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.textBox1.Location = new System.Drawing.Point(35, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // circlePerim
            // 
            this.circlePerim.Location = new System.Drawing.Point(35, 280);
            this.circlePerim.Name = "circlePerim";
            this.circlePerim.Size = new System.Drawing.Size(151, 31);
            this.circlePerim.TabIndex = 1;
            this.circlePerim.Text = "Perimeter of Circle";
            this.circlePerim.UseVisualStyleBackColor = true;
            this.circlePerim.Click += new System.EventHandler(this.circlePerim_Click);
            // 
            // trianglePerim
            // 
            this.trianglePerim.Location = new System.Drawing.Point(192, 280);
            this.trianglePerim.Name = "trianglePerim";
            this.trianglePerim.Size = new System.Drawing.Size(151, 31);
            this.trianglePerim.TabIndex = 2;
            this.trianglePerim.Text = "Perimeter of Triangle";
            this.trianglePerim.UseVisualStyleBackColor = true;
            this.trianglePerim.Click += new System.EventHandler(this.trianglePerim_Click);
            // 
            // rectPerim
            // 
            this.rectPerim.Location = new System.Drawing.Point(349, 280);
            this.rectPerim.Name = "rectPerim";
            this.rectPerim.Size = new System.Drawing.Size(151, 31);
            this.rectPerim.TabIndex = 3;
            this.rectPerim.Text = "Perimeter of Rectangle";
            this.rectPerim.UseVisualStyleBackColor = true;
            this.rectPerim.Click += new System.EventHandler(this.rectPerim_Click);
            // 
            // circleArea
            // 
            this.circleArea.Location = new System.Drawing.Point(35, 335);
            this.circleArea.Name = "circleArea";
            this.circleArea.Size = new System.Drawing.Size(151, 31);
            this.circleArea.TabIndex = 4;
            this.circleArea.Text = "Area of Circle";
            this.circleArea.UseVisualStyleBackColor = true;
            this.circleArea.Click += new System.EventHandler(this.circleArea_Click);
            // 
            // triangleArea
            // 
            this.triangleArea.Location = new System.Drawing.Point(192, 335);
            this.triangleArea.Name = "triangleArea";
            this.triangleArea.Size = new System.Drawing.Size(151, 31);
            this.triangleArea.TabIndex = 5;
            this.triangleArea.Text = "Area of Triangle";
            this.triangleArea.UseVisualStyleBackColor = true;
            this.triangleArea.Click += new System.EventHandler(this.triangleArea_Click);
            // 
            // rectArea
            // 
            this.rectArea.Location = new System.Drawing.Point(349, 335);
            this.rectArea.Name = "rectArea";
            this.rectArea.Size = new System.Drawing.Size(151, 31);
            this.rectArea.TabIndex = 6;
            this.rectArea.Text = "Area of Rectangle";
            this.rectArea.UseVisualStyleBackColor = true;
            this.rectArea.Click += new System.EventHandler(this.rectArea_Click);
            // 
            // dotProd
            // 
            this.dotProd.Location = new System.Drawing.Point(35, 391);
            this.dotProd.Name = "dotProd";
            this.dotProd.Size = new System.Drawing.Size(151, 31);
            this.dotProd.TabIndex = 7;
            this.dotProd.Text = "Dot Product";
            this.dotProd.UseVisualStyleBackColor = true;
            this.dotProd.Click += new System.EventHandler(this.dotProd_Click);
            // 
            // crossProd
            // 
            this.crossProd.Location = new System.Drawing.Point(192, 391);
            this.crossProd.Name = "crossProd";
            this.crossProd.Size = new System.Drawing.Size(151, 31);
            this.crossProd.TabIndex = 8;
            this.crossProd.Text = "Cross Product";
            this.crossProd.UseVisualStyleBackColor = true;
            this.crossProd.Click += new System.EventHandler(this.crossProd_Click);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(349, 391);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(151, 31);
            this.average.TabIndex = 9;
            this.average.Text = "Average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(221, 206);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(165, 50);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 50);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.MaximumSize = new System.Drawing.Size(400, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please Select Your Calculation";
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.labelResult.Location = new System.Drawing.Point(35, 143);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(351, 50);
            this.labelResult.TabIndex = 14;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuadRoot
            // 
            this.btnQuadRoot.Location = new System.Drawing.Point(35, 440);
            this.btnQuadRoot.Name = "btnQuadRoot";
            this.btnQuadRoot.Size = new System.Drawing.Size(151, 31);
            this.btnQuadRoot.TabIndex = 15;
            this.btnQuadRoot.Text = "Quadratic Roots";
            this.btnQuadRoot.UseVisualStyleBackColor = true;
            this.btnQuadRoot.Click += new System.EventHandler(this.btnQuadRoot_Click);
            // 
            // AdvancedCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 500);
            this.Controls.Add(this.btnQuadRoot);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.average);
            this.Controls.Add(this.crossProd);
            this.Controls.Add(this.dotProd);
            this.Controls.Add(this.rectArea);
            this.Controls.Add(this.triangleArea);
            this.Controls.Add(this.circleArea);
            this.Controls.Add(this.rectPerim);
            this.Controls.Add(this.trianglePerim);
            this.Controls.Add(this.circlePerim);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdvancedCalc";
            this.Text = "AdvancedCalc";
            this.Load += new System.EventHandler(this.AdvancedCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button circlePerim;
        private System.Windows.Forms.Button trianglePerim;
        private System.Windows.Forms.Button rectPerim;
        private System.Windows.Forms.Button circleArea;
        private System.Windows.Forms.Button triangleArea;
        private System.Windows.Forms.Button rectArea;
        private System.Windows.Forms.Button dotProd;
        private System.Windows.Forms.Button crossProd;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnQuadRoot;
    }
}
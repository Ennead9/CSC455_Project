namespace CSC455_ProjectCalculator
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(116, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please Select Your Calculation";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // circlePerim
            // 
            this.circlePerim.Location = new System.Drawing.Point(116, 108);
            this.circlePerim.Name = "circlePerim";
            this.circlePerim.Size = new System.Drawing.Size(151, 31);
            this.circlePerim.TabIndex = 1;
            this.circlePerim.Text = "Perimeter of Circle";
            this.circlePerim.UseVisualStyleBackColor = true;
            // 
            // trianglePerim
            // 
            this.trianglePerim.Location = new System.Drawing.Point(316, 108);
            this.trianglePerim.Name = "trianglePerim";
            this.trianglePerim.Size = new System.Drawing.Size(151, 31);
            this.trianglePerim.TabIndex = 2;
            this.trianglePerim.Text = "Perimeter of Triangle";
            this.trianglePerim.UseVisualStyleBackColor = true;
            // 
            // rectPerim
            // 
            this.rectPerim.Location = new System.Drawing.Point(522, 108);
            this.rectPerim.Name = "rectPerim";
            this.rectPerim.Size = new System.Drawing.Size(151, 31);
            this.rectPerim.TabIndex = 3;
            this.rectPerim.Text = "Perimeter of Rectangle";
            this.rectPerim.UseVisualStyleBackColor = true;
            // 
            // circleArea
            // 
            this.circleArea.Location = new System.Drawing.Point(116, 202);
            this.circleArea.Name = "circleArea";
            this.circleArea.Size = new System.Drawing.Size(151, 31);
            this.circleArea.TabIndex = 4;
            this.circleArea.Text = "Area of Circle";
            this.circleArea.UseVisualStyleBackColor = true;
            // 
            // triangleArea
            // 
            this.triangleArea.Location = new System.Drawing.Point(316, 202);
            this.triangleArea.Name = "triangleArea";
            this.triangleArea.Size = new System.Drawing.Size(151, 31);
            this.triangleArea.TabIndex = 5;
            this.triangleArea.Text = "Area of Triangle";
            this.triangleArea.UseVisualStyleBackColor = true;
            // 
            // rectArea
            // 
            this.rectArea.Location = new System.Drawing.Point(522, 202);
            this.rectArea.Name = "rectArea";
            this.rectArea.Size = new System.Drawing.Size(151, 31);
            this.rectArea.TabIndex = 6;
            this.rectArea.Text = "Area of Rectangle";
            this.rectArea.UseVisualStyleBackColor = true;
            // 
            // dotProd
            // 
            this.dotProd.Location = new System.Drawing.Point(116, 283);
            this.dotProd.Name = "dotProd";
            this.dotProd.Size = new System.Drawing.Size(151, 31);
            this.dotProd.TabIndex = 7;
            this.dotProd.Text = "Dot Product";
            this.dotProd.UseVisualStyleBackColor = true;
            // 
            // crossProd
            // 
            this.crossProd.Location = new System.Drawing.Point(316, 283);
            this.crossProd.Name = "crossProd";
            this.crossProd.Size = new System.Drawing.Size(151, 31);
            this.crossProd.TabIndex = 8;
            this.crossProd.Text = "Cross Product";
            this.crossProd.UseVisualStyleBackColor = true;
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(522, 283);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(151, 31);
            this.average.TabIndex = 9;
            this.average.Text = "Average";
            this.average.UseVisualStyleBackColor = true;
            // 
            // AdvancedCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
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
            this.Name = "AdvancedCalc";
            this.Text = "AdvancedCalc";
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
    }
}
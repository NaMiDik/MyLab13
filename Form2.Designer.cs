namespace MyLab13_2
{
    partial class Form2
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
            this.txtSquareSide = new System.Windows.Forms.TextBox();
            this.txtCircleRadius = new System.Windows.Forms.TextBox();
            this.lblSquareArea = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCircleArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSquareSide
            // 
            this.txtSquareSide.Location = new System.Drawing.Point(325, 25);
            this.txtSquareSide.Name = "txtSquareSide";
            this.txtSquareSide.Size = new System.Drawing.Size(91, 22);
            this.txtSquareSide.TabIndex = 0;
            // 
            // txtCircleRadius
            // 
            this.txtCircleRadius.Location = new System.Drawing.Point(325, 66);
            this.txtCircleRadius.Name = "txtCircleRadius";
            this.txtCircleRadius.Size = new System.Drawing.Size(91, 22);
            this.txtCircleRadius.TabIndex = 1;
            // 
            // lblSquareArea
            // 
            this.lblSquareArea.AutoSize = true;
            this.lblSquareArea.BackColor = System.Drawing.Color.MistyRose;
            this.lblSquareArea.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSquareArea.Location = new System.Drawing.Point(192, 156);
            this.lblSquareArea.Name = "lblSquareArea";
            this.lblSquareArea.Size = new System.Drawing.Size(18, 19);
            this.lblSquareArea.TabIndex = 2;
            this.lblSquareArea.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.MistyRose;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(104, 105);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(231, 36);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Розрахувати площі";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCircleArea
            // 
            this.lblCircleArea.AutoSize = true;
            this.lblCircleArea.BackColor = System.Drawing.Color.MistyRose;
            this.lblCircleArea.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCircleArea.Location = new System.Drawing.Point(192, 195);
            this.lblCircleArea.Name = "lblCircleArea";
            this.lblCircleArea.Size = new System.Drawing.Size(18, 19);
            this.lblCircleArea.TabIndex = 5;
            this.lblCircleArea.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введіть сторону квадрата А:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введіть радіус кола R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Площа Квадрата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Площа кола:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(428, 235);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCircleArea);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSquareArea);
            this.Controls.Add(this.txtCircleRadius);
            this.Controls.Add(this.txtSquareSide);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 6";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSquareSide;
        private System.Windows.Forms.TextBox txtCircleRadius;
        private System.Windows.Forms.Label lblSquareArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCircleArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
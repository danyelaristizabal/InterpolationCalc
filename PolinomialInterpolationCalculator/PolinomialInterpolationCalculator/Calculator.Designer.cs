namespace PolinomialInterpolationCalculator
{
    partial class Main
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Xlbl = new System.Windows.Forms.Label();
            this.Ylbl = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.Intructions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Xlbl
            // 
            this.Xlbl.AutoSize = true;
            this.Xlbl.Location = new System.Drawing.Point(145, 75);
            this.Xlbl.Name = "Xlbl";
            this.Xlbl.Size = new System.Drawing.Size(14, 13);
            this.Xlbl.TabIndex = 2;
            this.Xlbl.Text = "X";
            // 
            // Ylbl
            // 
            this.Ylbl.AutoSize = true;
            this.Ylbl.Location = new System.Drawing.Point(267, 75);
            this.Ylbl.Name = "Ylbl";
            this.Ylbl.Size = new System.Drawing.Size(14, 13);
            this.Ylbl.TabIndex = 3;
            this.Ylbl.Text = "Y";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(585, 121);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 13);
            this.Result.TabIndex = 4;
            this.Result.Text = "Result";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(110, 168);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(219, 23);
            this.CalculateBtn.TabIndex = 5;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            // 
            // Intructions
            // 
            this.Intructions.AutoSize = true;
            this.Intructions.Location = new System.Drawing.Point(139, 31);
            this.Intructions.Name = "Intructions";
            this.Intructions.Size = new System.Drawing.Size(483, 13);
            this.Intructions.TabIndex = 6;
            this.Intructions.Text = "To add cordinates press enter, when you finish adding cordinates press calcualte " +
    "to get your polinom.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Intructions);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Ylbl);
            this.Controls.Add(this.Xlbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Xlbl;
        private System.Windows.Forms.Label Ylbl;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label Intructions;
        private System.Windows.Forms.Button button1;
    }
}


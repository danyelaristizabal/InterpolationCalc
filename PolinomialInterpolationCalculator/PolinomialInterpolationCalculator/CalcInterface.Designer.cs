namespace PolinomialInterpolationCalculator
{
    partial class CalcInterface
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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.IntructionsLbl = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.Ylbl = new System.Windows.Forms.Label();
            this.Xlbl = new System.Windows.Forms.Label();
            this.YTxtB = new System.Windows.Forms.TextBox();
            this.XTxtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(106, 236);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(219, 28);
            this.ResetBtn.TabIndex = 15;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // IntructionsLbl
            // 
            this.IntructionsLbl.AutoSize = true;
            this.IntructionsLbl.Location = new System.Drawing.Point(135, 58);
            this.IntructionsLbl.Name = "IntructionsLbl";
            this.IntructionsLbl.Size = new System.Drawing.Size(483, 13);
            this.IntructionsLbl.TabIndex = 14;
            this.IntructionsLbl.Text = "To add cordinates press enter, when you finish adding cordinates press calcualte " +
    "to get your polinom.";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(106, 195);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(219, 23);
            this.CalculateBtn.TabIndex = 13;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Location = new System.Drawing.Point(581, 148);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(37, 13);
            this.Resultlbl.TabIndex = 12;
            this.Resultlbl.Text = "Result";
            // 
            // Ylbl
            // 
            this.Ylbl.AutoSize = true;
            this.Ylbl.Location = new System.Drawing.Point(263, 102);
            this.Ylbl.Name = "Ylbl";
            this.Ylbl.Size = new System.Drawing.Size(14, 13);
            this.Ylbl.TabIndex = 11;
            this.Ylbl.Text = "Y";
            // 
            // Xlbl
            // 
            this.Xlbl.AutoSize = true;
            this.Xlbl.Location = new System.Drawing.Point(141, 102);
            this.Xlbl.Name = "Xlbl";
            this.Xlbl.Size = new System.Drawing.Size(14, 13);
            this.Xlbl.TabIndex = 10;
            this.Xlbl.Text = "X";
            // 
            // YTxtB
            // 
            this.YTxtB.Location = new System.Drawing.Point(225, 141);
            this.YTxtB.Name = "YTxtB";
            this.YTxtB.Size = new System.Drawing.Size(100, 20);
            this.YTxtB.TabIndex = 9;
            this.YTxtB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.YTxtB_KeyUp);
            // 
            // XTxtB
            // 
            this.XTxtB.Location = new System.Drawing.Point(106, 141);
            this.XTxtB.Name = "XTxtB";
            this.XTxtB.Size = new System.Drawing.Size(100, 20);
            this.XTxtB.TabIndex = 8;
            this.XTxtB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.XTxtB_KeyUp);
            // 
            // CalcInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.IntructionsLbl);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.Ylbl);
            this.Controls.Add(this.Xlbl);
            this.Controls.Add(this.YTxtB);
            this.Controls.Add(this.XTxtB);
            this.Name = "CalcInterface";
            this.Text = "CalcInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label IntructionsLbl;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Label Ylbl;
        private System.Windows.Forms.Label Xlbl;
        private System.Windows.Forms.TextBox YTxtB;
        private System.Windows.Forms.TextBox XTxtB;
    }
}
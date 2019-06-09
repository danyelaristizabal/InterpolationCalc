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
            this.AddBtn = new System.Windows.Forms.Button();
            this.justresultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(265, 226);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(219, 28);
            this.ResetBtn.TabIndex = 15;
            this.ResetBtn.TabStop = false;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // IntructionsLbl
            // 
            this.IntructionsLbl.AutoSize = true;
            this.IntructionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntructionsLbl.Location = new System.Drawing.Point(29, 29);
            this.IntructionsLbl.Name = "IntructionsLbl";
            this.IntructionsLbl.Size = new System.Drawing.Size(741, 18);
            this.IntructionsLbl.TabIndex = 14;
            this.IntructionsLbl.Text = "To add cordinates,  press the Add button, when you finish adding cordinates press" +
    " calcualte to get your polinom.";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(265, 197);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(219, 23);
            this.CalculateBtn.TabIndex = 13;
            this.CalculateBtn.TabStop = false;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resultlbl.Location = new System.Drawing.Point(132, 309);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(0, 20);
            this.Resultlbl.TabIndex = 12;
            // 
            // Ylbl
            // 
            this.Ylbl.AutoSize = true;
            this.Ylbl.Location = new System.Drawing.Point(422, 104);
            this.Ylbl.Name = "Ylbl";
            this.Ylbl.Size = new System.Drawing.Size(14, 13);
            this.Ylbl.TabIndex = 11;
            this.Ylbl.Text = "Y";
            // 
            // Xlbl
            // 
            this.Xlbl.AutoSize = true;
            this.Xlbl.Location = new System.Drawing.Point(300, 104);
            this.Xlbl.Name = "Xlbl";
            this.Xlbl.Size = new System.Drawing.Size(14, 13);
            this.Xlbl.TabIndex = 10;
            this.Xlbl.Text = "X";
            // 
            // YTxtB
            // 
            this.YTxtB.Location = new System.Drawing.Point(384, 143);
            this.YTxtB.Name = "YTxtB";
            this.YTxtB.Size = new System.Drawing.Size(100, 20);
            this.YTxtB.TabIndex = 1;
            // 
            // XTxtB
            // 
            this.XTxtB.Location = new System.Drawing.Point(265, 143);
            this.XTxtB.Name = "XTxtB";
            this.XTxtB.Size = new System.Drawing.Size(100, 20);
            this.XTxtB.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(265, 169);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(219, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // justresultlabel
            // 
            this.justresultlabel.AutoSize = true;
            this.justresultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.justresultlabel.Location = new System.Drawing.Point(26, 299);
            this.justresultlabel.Name = "justresultlabel";
            this.justresultlabel.Size = new System.Drawing.Size(100, 31);
            this.justresultlabel.TabIndex = 16;
            this.justresultlabel.Text = "Result:";
            this.justresultlabel.UseMnemonic = false;
            // 
            // CalcInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.justresultlabel);
            this.Controls.Add(this.AddBtn);
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
            this.Load += new System.EventHandler(this.CalcInterface_Load);
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
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label justresultlabel;
    }
}
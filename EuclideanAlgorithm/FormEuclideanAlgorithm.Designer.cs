namespace EuclideanAlgorithm
{
    partial class FormEuclideanAlgorithm
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
            this.BtnFindGCD = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnGcdOf3Numbers = new System.Windows.Forms.Button();
            this.BtnFindLCM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFindGCD
            // 
            this.BtnFindGCD.Location = new System.Drawing.Point(42, 52);
            this.BtnFindGCD.Name = "BtnFindGCD";
            this.BtnFindGCD.Size = new System.Drawing.Size(162, 57);
            this.BtnFindGCD.TabIndex = 0;
            this.BtnFindGCD.Text = "Find the GCD";
            this.BtnFindGCD.UseVisualStyleBackColor = true;
            this.BtnFindGCD.Click += new System.EventHandler(this.BtnFindGCD_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(234, 52);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(452, 342);
            this.TxtResult.TabIndex = 1;
            // 
            // BtnGcdOf3Numbers
            // 
            this.BtnGcdOf3Numbers.Location = new System.Drawing.Point(42, 140);
            this.BtnGcdOf3Numbers.Name = "BtnGcdOf3Numbers";
            this.BtnGcdOf3Numbers.Size = new System.Drawing.Size(161, 59);
            this.BtnGcdOf3Numbers.TabIndex = 2;
            this.BtnGcdOf3Numbers.Text = "Find GCD of 3 numbers";
            this.BtnGcdOf3Numbers.UseVisualStyleBackColor = true;
            this.BtnGcdOf3Numbers.Click += new System.EventHandler(this.BtnGcdOf3Numbers_Click);
            // 
            // BtnFindLCM
            // 
            this.BtnFindLCM.Location = new System.Drawing.Point(42, 232);
            this.BtnFindLCM.Name = "BtnFindLCM";
            this.BtnFindLCM.Size = new System.Drawing.Size(160, 60);
            this.BtnFindLCM.TabIndex = 3;
            this.BtnFindLCM.Text = "Find the LCM";
            this.BtnFindLCM.UseVisualStyleBackColor = true;
            this.BtnFindLCM.Click += new System.EventHandler(this.BtnFindLCM_Click);
            // 
            // FormEuclideanAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFindLCM);
            this.Controls.Add(this.BtnGcdOf3Numbers);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnFindGCD);
            this.Name = "FormEuclideanAlgorithm";
            this.Text = "Euclidean Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFindGCD;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnGcdOf3Numbers;
        private System.Windows.Forms.Button BtnFindLCM;
    }
}


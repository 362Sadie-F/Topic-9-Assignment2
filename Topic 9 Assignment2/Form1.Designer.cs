namespace Topic_9_Assignment2
{
    partial class AssignmentForm
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblDivi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlus.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(32, 131);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(119, 71);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMinus.Font = new System.Drawing.Font("Lucida Calligraphy", 50F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(32, 296);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(119, 69);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimes.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimes.Location = new System.Drawing.Point(32, 439);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(119, 71);
            this.btnTimes.TabIndex = 4;
            this.btnTimes.Text = "×";
            this.btnTimes.UseVisualStyleBackColor = false;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDivi.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivi.Location = new System.Drawing.Point(32, 593);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(119, 71);
            this.btnDivi.TabIndex = 6;
            this.btnDivi.Text = "÷";
            this.btnDivi.UseVisualStyleBackColor = false;
            this.btnDivi.Click += new System.EventHandler(this.btnDivi_Click);
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Lucida Calligraphy", 44F);
            this.lblPlus.Location = new System.Drawing.Point(204, 131);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(233, 76);
            this.lblPlus.TabIndex = 7;
            this.lblPlus.Text = "8 + 5 =";
            this.lblPlus.Visible = false;
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Font = new System.Drawing.Font("Lucida Calligraphy", 44F);
            this.lblMinus.Location = new System.Drawing.Point(204, 296);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(214, 76);
            this.lblMinus.TabIndex = 8;
            this.lblMinus.Text = "8 - 5 =";
            this.lblMinus.Visible = false;
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Font = new System.Drawing.Font("Lucida Calligraphy", 44F);
            this.lblTimes.Location = new System.Drawing.Point(204, 439);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(233, 76);
            this.lblTimes.TabIndex = 9;
            this.lblTimes.Text = "8 × 5 =";
            this.lblTimes.Visible = false;
            // 
            // lblDivi
            // 
            this.lblDivi.AutoSize = true;
            this.lblDivi.Font = new System.Drawing.Font("Lucida Calligraphy", 44F);
            this.lblDivi.Location = new System.Drawing.Point(204, 593);
            this.lblDivi.Name = "lblDivi";
            this.lblDivi.Size = new System.Drawing.Size(253, 76);
            this.lblDivi.TabIndex = 10;
            this.lblDivi.Text = "8 ÷ 5 = ";
            this.lblDivi.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 44F);
            this.label1.Location = new System.Drawing.Point(275, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 76);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numbers: 8 , 5";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnQuit.Location = new System.Drawing.Point(811, 738);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "End";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1179, 850);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDivi);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AssignmentForm";
            this.Text = "Calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblDivi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
    }
}


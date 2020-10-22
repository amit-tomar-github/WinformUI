namespace WinformUI
{
    partial class MinForm
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
            this.btnDarkTheme = new System.Windows.Forms.Button();
            this.btnPlayerUI = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDarkTheme
            // 
            this.btnDarkTheme.Location = new System.Drawing.Point(112, 88);
            this.btnDarkTheme.Name = "btnDarkTheme";
            this.btnDarkTheme.Size = new System.Drawing.Size(101, 31);
            this.btnDarkTheme.TabIndex = 0;
            this.btnDarkTheme.Text = "Dark Theme";
            this.btnDarkTheme.UseVisualStyleBackColor = true;
            this.btnDarkTheme.Click += new System.EventHandler(this.btnDarkTheme_Click);
            // 
            // btnPlayerUI
            // 
            this.btnPlayerUI.Location = new System.Drawing.Point(240, 85);
            this.btnPlayerUI.Name = "btnPlayerUI";
            this.btnPlayerUI.Size = new System.Drawing.Size(101, 36);
            this.btnPlayerUI.TabIndex = 1;
            this.btnPlayerUI.Text = "Player UI";
            this.btnPlayerUI.UseVisualStyleBackColor = true;
            this.btnPlayerUI.Click += new System.EventHandler(this.btnPlayerUI_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.Location = new System.Drawing.Point(374, 88);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(101, 36);
            this.btnFastFood.TabIndex = 2;
            this.btnFastFood.Text = "Fast Food";
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Skype";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "fOODaPP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFastFood);
            this.Controls.Add(this.btnPlayerUI);
            this.Controls.Add(this.btnDarkTheme);
            this.Name = "MinForm";
            this.Text = "MinForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDarkTheme;
        private System.Windows.Forms.Button btnPlayerUI;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
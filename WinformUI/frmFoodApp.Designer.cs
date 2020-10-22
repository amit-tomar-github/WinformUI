namespace WinformUI
{
    partial class frmFoodApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodApp));
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.btnFood = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlOnButtonFood = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlOnBtnHelp = new System.Windows.Forms.Panel();
            this.pnlOnbtnDrinnks = new System.Windows.Forms.Panel();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.pnlOnBtnDeserts = new System.Windows.Forms.Panel();
            this.btnDeserts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlLeftSide.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.pnlLeftSide.Controls.Add(this.label1);
            this.pnlLeftSide.Controls.Add(this.pnlOnBtnDeserts);
            this.pnlLeftSide.Controls.Add(this.btnDeserts);
            this.pnlLeftSide.Controls.Add(this.pnlOnbtnDrinnks);
            this.pnlLeftSide.Controls.Add(this.btnDrinks);
            this.pnlLeftSide.Controls.Add(this.pnlOnBtnHelp);
            this.pnlLeftSide.Controls.Add(this.btnHelp);
            this.pnlLeftSide.Controls.Add(this.pnlOnButtonFood);
            this.pnlLeftSide.Controls.Add(this.btnFood);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(200, 459);
            this.pnlLeftSide.TabIndex = 0;
            // 
            // btnFood
            // 
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Image = global::WinformUI.Properties.Resources.ic_home;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(3, 68);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(194, 38);
            this.btnFood.TabIndex = 3;
            this.btnFood.Text = "   Foods";
            this.btnFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.pnlTop.Controls.Add(this.button2);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.button6);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(551, 23);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlOnButtonFood
            // 
            this.pnlOnButtonFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.pnlOnButtonFood.Location = new System.Drawing.Point(1, 68);
            this.pnlOnButtonFood.Name = "pnlOnButtonFood";
            this.pnlOnButtonFood.Size = new System.Drawing.Size(10, 38);
            this.pnlOnButtonFood.TabIndex = 2;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::WinformUI.Properties.Resources.ic_home;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(3, 233);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(194, 38);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "   Help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlOnBtnHelp
            // 
            this.pnlOnBtnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.pnlOnBtnHelp.Location = new System.Drawing.Point(1, 233);
            this.pnlOnBtnHelp.Name = "pnlOnBtnHelp";
            this.pnlOnBtnHelp.Size = new System.Drawing.Size(10, 38);
            this.pnlOnBtnHelp.TabIndex = 3;
            this.pnlOnBtnHelp.Visible = false;
            // 
            // pnlOnbtnDrinnks
            // 
            this.pnlOnbtnDrinnks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.pnlOnbtnDrinnks.Location = new System.Drawing.Point(0, 123);
            this.pnlOnbtnDrinnks.Name = "pnlOnbtnDrinnks";
            this.pnlOnbtnDrinnks.Size = new System.Drawing.Size(10, 38);
            this.pnlOnbtnDrinnks.TabIndex = 5;
            this.pnlOnbtnDrinnks.Visible = false;
            // 
            // btnDrinks
            // 
            this.btnDrinks.FlatAppearance.BorderSize = 0;
            this.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinks.ForeColor = System.Drawing.Color.White;
            this.btnDrinks.Image = global::WinformUI.Properties.Resources.ic_home;
            this.btnDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinks.Location = new System.Drawing.Point(2, 123);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(194, 38);
            this.btnDrinks.TabIndex = 6;
            this.btnDrinks.Text = "   Drinks";
            this.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // pnlOnBtnDeserts
            // 
            this.pnlOnBtnDeserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.pnlOnBtnDeserts.Location = new System.Drawing.Point(0, 178);
            this.pnlOnBtnDeserts.Name = "pnlOnBtnDeserts";
            this.pnlOnBtnDeserts.Size = new System.Drawing.Size(10, 38);
            this.pnlOnBtnDeserts.TabIndex = 7;
            this.pnlOnBtnDeserts.Visible = false;
            // 
            // btnDeserts
            // 
            this.btnDeserts.FlatAppearance.BorderSize = 0;
            this.btnDeserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeserts.ForeColor = System.Drawing.Color.White;
            this.btnDeserts.Image = global::WinformUI.Properties.Resources.ic_home;
            this.btnDeserts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeserts.Location = new System.Drawing.Point(2, 178);
            this.btnDeserts.Name = "btnDeserts";
            this.btnDeserts.Size = new System.Drawing.Size(194, 38);
            this.btnDeserts.TabIndex = 8;
            this.btnDeserts.Text = "   Deserts";
            this.btnDeserts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeserts.UseVisualStyleBackColor = true;
            this.btnDeserts.Click += new System.EventHandler(this.btnDeserts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "foodApp";
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(518, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 23);
            this.button6.TabIndex = 10;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(485, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(452, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmFoodApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(751, 459);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeftSide);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFoodApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFoodApp";
            this.pnlLeftSide.ResumeLayout(false);
            this.pnlLeftSide.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Panel pnlOnButtonFood;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOnBtnDeserts;
        private System.Windows.Forms.Button btnDeserts;
        private System.Windows.Forms.Panel pnlOnbtnDrinnks;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Panel pnlOnBtnHelp;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
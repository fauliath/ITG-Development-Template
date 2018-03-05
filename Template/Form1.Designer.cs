namespace Template
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Button_Minimise = new Template.FlatButton();
            this.Button_Close = new Template.FlatButton();
            this.Picture_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Body.SuspendLayout();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackColor = System.Drawing.Color.White;
            this.Panel_Body.Controls.Add(this.Picture_Logo);
            this.Panel_Body.Location = new System.Drawing.Point(2, 25);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(996, 623);
            this.Panel_Body.TabIndex = 1;
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.Panel_Title.Controls.Add(this.Button_Minimise);
            this.Panel_Title.Controls.Add(this.Button_Close);
            this.Panel_Title.Location = new System.Drawing.Point(-4, -4);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(1005, 30);
            this.Panel_Title.TabIndex = 0;
            this.Panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Form);
            // 
            // Button_Minimise
            // 
            this.Button_Minimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Minimise.FlatAppearance.BorderSize = 0;
            this.Button_Minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Minimise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Minimise.ForeColor = System.Drawing.Color.White;
            this.Button_Minimise.Location = new System.Drawing.Point(944, 3);
            this.Button_Minimise.Name = "Button_Minimise";
            this.Button_Minimise.Size = new System.Drawing.Size(26, 27);
            this.Button_Minimise.TabIndex = 1;
            this.Button_Minimise.TabStop = false;
            this.Button_Minimise.Text = "-";
            this.Button_Minimise.UseVisualStyleBackColor = false;
            this.Button_Minimise.Click += new System.EventHandler(this.Button_Minimise_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Close.ForeColor = System.Drawing.Color.White;
            this.Button_Close.Location = new System.Drawing.Point(976, 3);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(26, 27);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.TabStop = false;
            this.Button_Close.Text = "X";
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Picture_Logo
            // 
            this.Picture_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Logo.Image")));
            this.Picture_Logo.Location = new System.Drawing.Point(904, 573);
            this.Picture_Logo.Name = "Picture_Logo";
            this.Picture_Logo.Size = new System.Drawing.Size(89, 50);
            this.Picture_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Logo.TabIndex = 0;
            this.Picture_Logo.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Panel Panel_Title;
        private FlatButton Button_Close;
        private FlatButton Button_Minimise;
        private System.Windows.Forms.PictureBox Picture_Logo;
    }
}


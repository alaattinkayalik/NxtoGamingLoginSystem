namespace nxtologinsystem
{
    partial class signUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.signgroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passreptext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ıdntext = new System.Windows.Forms.TextBox();
            this.loginlabel = new System.Windows.Forms.LinkLabel();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.signbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.signgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 48);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(431, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NXTO";
            // 
            // signgroup
            // 
            this.signgroup.Controls.Add(this.label8);
            this.signgroup.Controls.Add(this.label7);
            this.signgroup.Controls.Add(this.label6);
            this.signgroup.Controls.Add(this.passreptext);
            this.signgroup.Controls.Add(this.emailtext);
            this.signgroup.Controls.Add(this.label5);
            this.signgroup.Controls.Add(this.ıdntext);
            this.signgroup.Controls.Add(this.loginlabel);
            this.signgroup.Controls.Add(this.passwordtext);
            this.signgroup.Controls.Add(this.signbutton);
            this.signgroup.Location = new System.Drawing.Point(47, 81);
            this.signgroup.Name = "signgroup";
            this.signgroup.Size = new System.Drawing.Size(400, 312);
            this.signgroup.TabIndex = 10;
            this.signgroup.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(38, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(38, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(36, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "*";
            // 
            // passreptext
            // 
            this.passreptext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.passreptext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passreptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passreptext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.passreptext.Location = new System.Drawing.Point(56, 162);
            this.passreptext.Multiline = true;
            this.passreptext.Name = "passreptext";
            this.passreptext.Size = new System.Drawing.Size(287, 26);
            this.passreptext.TabIndex = 9;
            this.passreptext.Text = "Password Repeat";
            this.passreptext.Click += new System.EventHandler(this.passreptext_Click);
            // 
            // emailtext
            // 
            this.emailtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.emailtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.emailtext.Location = new System.Drawing.Point(56, 92);
            this.emailtext.Multiline = true;
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(287, 26);
            this.emailtext.TabIndex = 8;
            this.emailtext.Text = "Email";
            this.emailtext.Click += new System.EventHandler(this.emailtext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.label5.Location = new System.Drawing.Point(50, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "S I G N   U P";
            // 
            // ıdntext
            // 
            this.ıdntext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ıdntext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ıdntext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ıdntext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıdntext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.ıdntext.Location = new System.Drawing.Point(56, 56);
            this.ıdntext.Multiline = true;
            this.ıdntext.Name = "ıdntext";
            this.ıdntext.Size = new System.Drawing.Size(287, 26);
            this.ıdntext.TabIndex = 2;
            this.ıdntext.Text = "ID";
            this.ıdntext.Click += new System.EventHandler(this.ıdntext_Click);
            this.ıdntext.TextChanged += new System.EventHandler(this.ıdntext_TextChanged);
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginlabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.loginlabel.Location = new System.Drawing.Point(56, 276);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(43, 15);
            this.loginlabel.TabIndex = 6;
            this.loginlabel.TabStop = true;
            this.loginlabel.Text = "Login";
            this.loginlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginlabel_LinkClicked);
            // 
            // passwordtext
            // 
            this.passwordtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.passwordtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.passwordtext.Location = new System.Drawing.Point(56, 127);
            this.passwordtext.Multiline = true;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(287, 26);
            this.passwordtext.TabIndex = 3;
            this.passwordtext.Text = "Password";
            this.passwordtext.Click += new System.EventHandler(this.passwordtext_Click);
            // 
            // signbutton
            // 
            this.signbutton.FlatAppearance.BorderSize = 0;
            this.signbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signbutton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.signbutton.Location = new System.Drawing.Point(56, 207);
            this.signbutton.Name = "signbutton";
            this.signbutton.Size = new System.Drawing.Size(287, 53);
            this.signbutton.TabIndex = 5;
            this.signbutton.Text = "Sign Up";
            this.signbutton.UseVisualStyleBackColor = false;
            this.signbutton.Click += new System.EventHandler(this.signbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(630, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 34);
            this.label4.TabIndex = 20;
            this.label4.Text = "TO NXTO!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(615, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "WELCOME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(698, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(938, 431);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signgroup);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.signUpForm_Load);
            this.Click += new System.EventHandler(this.signUpForm_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.signgroup.ResumeLayout(false);
            this.signgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox signgroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passreptext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ıdntext;
        private System.Windows.Forms.LinkLabel loginlabel;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button signbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
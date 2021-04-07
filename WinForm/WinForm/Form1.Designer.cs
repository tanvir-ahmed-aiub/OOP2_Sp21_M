namespace WinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProfession = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtBio = new System.Windows.Forms.RichTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMovies = new System.Windows.Forms.CheckBox();
            this.cbMusic = new System.Windows.Forms.CheckBox();
            this.cbSports = new System.Windows.Forms.CheckBox();
            this.cbGames = new System.Windows.Forms.CheckBox();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(189, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to UI";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(362, 111);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(302, 41);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(362, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(302, 41);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(362, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(302, 41);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(6, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(97, 38);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(136, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(129, 38);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Profession";
            // 
            // cbProfession
            // 
            this.cbProfession.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfession.FormattingEnabled = true;
            this.cbProfession.Items.AddRange(new object[] {
            "Service",
            "Student",
            "Business"});
            this.cbProfession.Location = new System.Drawing.Point(362, 328);
            this.cbProfession.Name = "cbProfession";
            this.cbProfession.Size = new System.Drawing.Size(302, 42);
            this.cbProfession.TabIndex = 11;
            this.cbProfession.Text = "Choose";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bio";
            // 
            // rtBio
            // 
            this.rtBio.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtBio.Location = new System.Drawing.Point(362, 385);
            this.rtBio.Name = "rtBio";
            this.rtBio.Size = new System.Drawing.Size(302, 88);
            this.rtBio.TabIndex = 13;
            this.rtBio.Text = "";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(275, 629);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(174, 46);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.RegisterClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(159, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 34);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hobbies";
            // 
            // cbMovies
            // 
            this.cbMovies.AutoSize = true;
            this.cbMovies.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovies.Location = new System.Drawing.Point(362, 508);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(130, 38);
            this.cbMovies.TabIndex = 16;
            this.cbMovies.Text = "Movies";
            this.cbMovies.UseVisualStyleBackColor = true;
            // 
            // cbMusic
            // 
            this.cbMusic.AutoSize = true;
            this.cbMusic.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMusic.Location = new System.Drawing.Point(498, 508);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(114, 38);
            this.cbMusic.TabIndex = 17;
            this.cbMusic.Text = "Music";
            this.cbMusic.UseVisualStyleBackColor = true;
            // 
            // cbSports
            // 
            this.cbSports.AutoSize = true;
            this.cbSports.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSports.Location = new System.Drawing.Point(498, 552);
            this.cbSports.Name = "cbSports";
            this.cbSports.Size = new System.Drawing.Size(130, 38);
            this.cbSports.TabIndex = 19;
            this.cbSports.Text = "Sports";
            this.cbSports.UseVisualStyleBackColor = true;
            // 
            // cbGames
            // 
            this.cbGames.AutoSize = true;
            this.cbGames.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGames.Location = new System.Drawing.Point(362, 552);
            this.cbGames.Name = "cbGames";
            this.cbGames.Size = new System.Drawing.Size(114, 38);
            this.cbGames.TabIndex = 18;
            this.cbGames.Text = "Games";
            this.cbGames.UseVisualStyleBackColor = true;
            // 
            // rtOutput
            // 
            this.rtOutput.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtOutput.Location = new System.Drawing.Point(774, 9);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Size = new System.Drawing.Size(502, 666);
            this.rtOutput.TabIndex = 20;
            this.rtOutput.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(512, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "Subscribe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Location = new System.Drawing.Point(362, 276);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(302, 46);
            this.gbGender.TabIndex = 22;
            this.gbGender.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1351, 700);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtOutput);
            this.Controls.Add(this.cbSports);
            this.Controls.Add(this.cbGames);
            this.Controls.Add(this.cbMusic);
            this.Controls.Add(this.cbMovies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rtBio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProfession);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbProfession;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtBio;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbMovies;
        private System.Windows.Forms.CheckBox cbMusic;
        private System.Windows.Forms.CheckBox cbSports;
        private System.Windows.Forms.CheckBox cbGames;
        private System.Windows.Forms.RichTextBox rtOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbGender;
    }
}


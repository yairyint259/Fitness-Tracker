namespace Fitness_tracking_software
{
    partial class frmActivity
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
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoBtnOption1 = new System.Windows.Forms.RadioButton();
            this.rdoBtnOption3 = new System.Windows.Forms.RadioButton();
            this.rdoBtnOption2 = new System.Windows.Forms.RadioButton();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetGoal = new System.Windows.Forms.Button();
            this.btnUpdateGoal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Weekly Target Goal :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(443, 73);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(127, 22);
            this.txtGoal.TabIndex = 1;
            this.txtGoal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoal_KeyPress);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Lime;
            this.btnForward.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnForward.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnForward.Location = new System.Drawing.Point(451, 465);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(208, 57);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = "Forward ->";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Visible = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // cboActivity
            // 
            this.cboActivity.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Items.AddRange(new object[] {
            "Walking",
            "Swimming",
            "Running",
            "Bicycling",
            "Dancing",
            "Sport"});
            this.cboActivity.Location = new System.Drawing.Point(166, 245);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(493, 31);
            this.cboActivity.TabIndex = 5;
            this.cboActivity.Text = "-------Select an Activity-------";
            this.cboActivity.SelectedIndexChanged += new System.EventHandler(this.cboActivity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(162, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Your Activities";
            // 
            // rdoBtnOption1
            // 
            this.rdoBtnOption1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoBtnOption1.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnOption1.Location = new System.Drawing.Point(166, 292);
            this.rdoBtnOption1.Name = "rdoBtnOption1";
            this.rdoBtnOption1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rdoBtnOption1.Size = new System.Drawing.Size(493, 41);
            this.rdoBtnOption1.TabIndex = 7;
            this.rdoBtnOption1.UseVisualStyleBackColor = false;
            this.rdoBtnOption1.Visible = false;
            // 
            // rdoBtnOption3
            // 
            this.rdoBtnOption3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoBtnOption3.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnOption3.Location = new System.Drawing.Point(166, 405);
            this.rdoBtnOption3.Name = "rdoBtnOption3";
            this.rdoBtnOption3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rdoBtnOption3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoBtnOption3.Size = new System.Drawing.Size(493, 41);
            this.rdoBtnOption3.TabIndex = 8;
            this.rdoBtnOption3.UseVisualStyleBackColor = false;
            this.rdoBtnOption3.Visible = false;
            // 
            // rdoBtnOption2
            // 
            this.rdoBtnOption2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoBtnOption2.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnOption2.Location = new System.Drawing.Point(166, 349);
            this.rdoBtnOption2.Name = "rdoBtnOption2";
            this.rdoBtnOption2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rdoBtnOption2.Size = new System.Drawing.Size(493, 41);
            this.rdoBtnOption2.TabIndex = 9;
            this.rdoBtnOption2.UseVisualStyleBackColor = false;
            this.rdoBtnOption2.Visible = false;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.Color.White;
            this.lblCurrentUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCurrentUser.Location = new System.Drawing.Point(13, 97);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(0, 19);
            this.lblCurrentUser.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Calories";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Fitness_tracking_software.Properties.Resources.usrProfile;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(536, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ready To Burn Your Calories Within a Week?";
            // 
            // btnSetGoal
            // 
            this.btnSetGoal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSetGoal.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnSetGoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetGoal.Location = new System.Drawing.Point(439, 124);
            this.btnSetGoal.Name = "btnSetGoal";
            this.btnSetGoal.Size = new System.Drawing.Size(104, 57);
            this.btnSetGoal.TabIndex = 14;
            this.btnSetGoal.Text = "Set Goal";
            this.btnSetGoal.UseVisualStyleBackColor = false;
            this.btnSetGoal.Click += new System.EventHandler(this.btnSetGoal_Click);
            // 
            // btnUpdateGoal
            // 
            this.btnUpdateGoal.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateGoal.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.btnUpdateGoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateGoal.Location = new System.Drawing.Point(549, 124);
            this.btnUpdateGoal.Name = "btnUpdateGoal";
            this.btnUpdateGoal.Size = new System.Drawing.Size(110, 57);
            this.btnUpdateGoal.TabIndex = 15;
            this.btnUpdateGoal.Text = "Update Goal";
            this.btnUpdateGoal.UseVisualStyleBackColor = false;
            this.btnUpdateGoal.Click += new System.EventHandler(this.btnUpdateGoal_Click);
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(699, 566);
            this.Controls.Add(this.btnUpdateGoal);
            this.Controls.Add(this.btnSetGoal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.rdoBtnOption2);
            this.Controls.Add(this.rdoBtnOption3);
            this.Controls.Add(this.rdoBtnOption1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboActivity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.label1);
            this.Name = "frmActivity";
            this.Text = "Activity_Form";
            this.Load += new System.EventHandler(this.frmActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoBtnOption1;
        private System.Windows.Forms.RadioButton rdoBtnOption3;
        private System.Windows.Forms.RadioButton rdoBtnOption2;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetGoal;
        private System.Windows.Forms.Button btnUpdateGoal;
    }
}
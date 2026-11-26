namespace Fitness_tracking_software
{
    partial class frmReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartActivity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtTargetGoal = new System.Windows.Forms.TextBox();
            this.txtWorkoutDay = new System.Windows.Forms.TextBox();
            this.txtTotalReport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalWeeklyReport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCongrat = new System.Windows.Forms.Label();
            this.btn_returnReporttoActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekly Calories Burned Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Target Goal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 551);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your Current Progress :";
            // 
            // chartActivity
            // 
            chartArea3.Name = "ChartArea1";
            this.chartActivity.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartActivity.Legends.Add(legend3);
            this.chartActivity.Location = new System.Drawing.Point(30, 79);
            this.chartActivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartActivity.Name = "chartActivity";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartActivity.Series.Add(series3);
            this.chartActivity.Size = new System.Drawing.Size(611, 363);
            this.chartActivity.TabIndex = 3;
            this.chartActivity.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(19, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Your Workout Day";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar.Location = new System.Drawing.Point(226, 538);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(415, 38);
            this.progressBar.TabIndex = 5;
            // 
            // txtTargetGoal
            // 
            this.txtTargetGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetGoal.Location = new System.Drawing.Point(22, 59);
            this.txtTargetGoal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTargetGoal.Name = "txtTargetGoal";
            this.txtTargetGoal.Size = new System.Drawing.Size(132, 24);
            this.txtTargetGoal.TabIndex = 6;
            // 
            // txtWorkoutDay
            // 
            this.txtWorkoutDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorkoutDay.Location = new System.Drawing.Point(22, 167);
            this.txtWorkoutDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtWorkoutDay.Name = "txtWorkoutDay";
            this.txtWorkoutDay.Size = new System.Drawing.Size(132, 24);
            this.txtWorkoutDay.TabIndex = 7;
            // 
            // txtTotalReport
            // 
            this.txtTotalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalReport.Location = new System.Drawing.Point(24, 265);
            this.txtTotalReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalReport.Name = "txtTotalReport";
            this.txtTotalReport.Size = new System.Drawing.Size(132, 24);
            this.txtTotalReport.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Weekly Burned ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 461);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Your Weekly Result Bar Chart ";
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.Location = new System.Drawing.Point(287, 549);
            this.lblProgressPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(0, 18);
            this.lblProgressPercent.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(165, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Calories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(165, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(165, 368);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Calories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTotalWeeklyReport);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTargetGoal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtWorkoutDay);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTotalReport);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(672, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 426);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(164, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Calories";
            // 
            // txtTotalWeeklyReport
            // 
            this.txtTotalWeeklyReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalWeeklyReport.Location = new System.Drawing.Point(24, 362);
            this.txtTotalWeeklyReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalWeeklyReport.Name = "txtTotalWeeklyReport";
            this.txtTotalWeeklyReport.Size = new System.Drawing.Size(132, 24);
            this.txtTotalWeeklyReport.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(18, 223);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total Current Burned";
            // 
            // lblCongrat
            // 
            this.lblCongrat.AutoSize = true;
            this.lblCongrat.BackColor = System.Drawing.Color.Gold;
            this.lblCongrat.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCongrat.Location = new System.Drawing.Point(38, 502);
            this.lblCongrat.Name = "lblCongrat";
            this.lblCongrat.Size = new System.Drawing.Size(0, 26);
            this.lblCongrat.TabIndex = 16;
            // 
            // btn_returnReporttoActivity
            // 
            this.btn_returnReporttoActivity.BackColor = System.Drawing.Color.Lime;
            this.btn_returnReporttoActivity.Font = new System.Drawing.Font("Modern No. 20", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnReporttoActivity.ForeColor = System.Drawing.Color.Crimson;
            this.btn_returnReporttoActivity.Location = new System.Drawing.Point(672, 511);
            this.btn_returnReporttoActivity.Name = "btn_returnReporttoActivity";
            this.btn_returnReporttoActivity.Size = new System.Drawing.Size(250, 72);
            this.btn_returnReporttoActivity.TabIndex = 17;
            this.btn_returnReporttoActivity.Text = "Click Here To Burn Next Day";
            this.btn_returnReporttoActivity.UseVisualStyleBackColor = false;
            this.btn_returnReporttoActivity.Click += new System.EventHandler(this.btn_returnReporttoActivity_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(988, 637);
            this.Controls.Add(this.btn_returnReporttoActivity);
            this.Controls.Add(this.lblCongrat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProgressPercent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chartActivity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmReport";
            this.Text = "Resultcs";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartActivity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtTargetGoal;
        private System.Windows.Forms.TextBox txtWorkoutDay;
        private System.Windows.Forms.TextBox txtTotalReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCongrat;
        private System.Windows.Forms.Button btn_returnReporttoActivity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalWeeklyReport;
        private System.Windows.Forms.Label label11;
    }
}
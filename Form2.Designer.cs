namespace ARTIFACT_Analyzer
{
    partial class Form2
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.t_amcache_dir = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.t_prefetch_dir = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.t_eventlog_dir = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.t_jumplist_dir = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.t_lnk_dir = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.t_appcompatcache_dir = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.cb_timezone = new MetroFramework.Controls.MetroCheckBox();
            this.cb_timeforamt = new MetroFramework.Controls.MetroCheckBox();
            this.t_timeforamt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Amcache Dir : ";
            // 
            // t_amcache_dir
            // 
            this.t_amcache_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_amcache_dir.Location = new System.Drawing.Point(108, 68);
            this.t_amcache_dir.Name = "t_amcache_dir";
            this.t_amcache_dir.Size = new System.Drawing.Size(317, 23);
            this.t_amcache_dir.TabIndex = 1;
            this.t_amcache_dir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_amcache_dir_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // t_prefetch_dir
            // 
            this.t_prefetch_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_prefetch_dir.Location = new System.Drawing.Point(108, 111);
            this.t_prefetch_dir.Name = "t_prefetch_dir";
            this.t_prefetch_dir.Size = new System.Drawing.Size(317, 23);
            this.t_prefetch_dir.TabIndex = 3;
            this.t_prefetch_dir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_prefetch_dir_MouseClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Prefetch Dir : ";
            // 
            // t_eventlog_dir
            // 
            this.t_eventlog_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_eventlog_dir.Location = new System.Drawing.Point(108, 153);
            this.t_eventlog_dir.Name = "t_eventlog_dir";
            this.t_eventlog_dir.Size = new System.Drawing.Size(317, 23);
            this.t_eventlog_dir.TabIndex = 5;
            this.t_eventlog_dir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_eventlog_dir_MouseClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "EventLog Dir : ";
            // 
            // t_jumplist_dir
            // 
            this.t_jumplist_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_jumplist_dir.Location = new System.Drawing.Point(108, 194);
            this.t_jumplist_dir.Name = "t_jumplist_dir";
            this.t_jumplist_dir.Size = new System.Drawing.Size(317, 23);
            this.t_jumplist_dir.TabIndex = 7;
            this.t_jumplist_dir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_jumplist_dir_MouseClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 194);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "JumpList Dir : ";
            // 
            // t_lnk_dir
            // 
            this.t_lnk_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_lnk_dir.Location = new System.Drawing.Point(108, 236);
            this.t_lnk_dir.Name = "t_lnk_dir";
            this.t_lnk_dir.Size = new System.Drawing.Size(317, 23);
            this.t_lnk_dir.TabIndex = 9;
            this.t_lnk_dir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_lnk_dir_MouseClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 236);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "LNK File Dir : ";
            // 
            // t_appcompatcache_dir
            // 
            this.t_appcompatcache_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_appcompatcache_dir.Location = new System.Drawing.Point(174, 279);
            this.t_appcompatcache_dir.Name = "t_appcompatcache_dir";
            this.t_appcompatcache_dir.Size = new System.Drawing.Size(251, 23);
            this.t_appcompatcache_dir.TabIndex = 11;
            this.t_appcompatcache_dir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_appcompatcache_dir_MouseClick);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 279);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(150, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "AppCompatCache Dir : ";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(300, 317);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(125, 49);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "저장";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // cb_timezone
            // 
            this.cb_timezone.AutoSize = true;
            this.cb_timezone.Location = new System.Drawing.Point(18, 317);
            this.cb_timezone.Name = "cb_timezone";
            this.cb_timezone.Size = new System.Drawing.Size(85, 15);
            this.cb_timezone.TabIndex = 13;
            this.cb_timezone.Text = "UTC+9 변환";
            this.cb_timezone.UseSelectable = true;
            // 
            // cb_timeforamt
            // 
            this.cb_timeforamt.AutoSize = true;
            this.cb_timeforamt.Location = new System.Drawing.Point(18, 345);
            this.cb_timeforamt.Name = "cb_timeforamt";
            this.cb_timeforamt.Size = new System.Drawing.Size(101, 15);
            this.cb_timeforamt.TabIndex = 14;
            this.cb_timeforamt.Text = "시간 형식 지정";
            this.cb_timeforamt.UseSelectable = true;
            this.cb_timeforamt.CheckedChanged += new System.EventHandler(this.cb_timeforamt_CheckedChanged);
            // 
            // t_timeforamt
            // 
            this.t_timeforamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_timeforamt.Enabled = false;
            this.t_timeforamt.Location = new System.Drawing.Point(122, 342);
            this.t_timeforamt.Name = "t_timeforamt";
            this.t_timeforamt.Size = new System.Drawing.Size(169, 23);
            this.t_timeforamt.TabIndex = 15;
            this.t_timeforamt.Text = "yyyy-MM-DD HH:mm:ss";
            this.t_timeforamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 377);
            this.Controls.Add(this.t_timeforamt);
            this.Controls.Add(this.cb_timeforamt);
            this.Controls.Add(this.cb_timezone);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.t_appcompatcache_dir);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.t_lnk_dir);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.t_jumplist_dir);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.t_eventlog_dir);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.t_prefetch_dir);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.t_amcache_dir);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form2";
            this.Text = "설정";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel metroLabel1;
        private TextBox t_amcache_dir;
        private OpenFileDialog openFileDialog1;
        private TextBox t_prefetch_dir;
        private MetroLabel metroLabel2;
        private TextBox t_eventlog_dir;
        private MetroLabel metroLabel3;
        private TextBox t_jumplist_dir;
        private MetroLabel metroLabel4;
        private TextBox t_lnk_dir;
        private MetroLabel metroLabel5;
        private TextBox t_appcompatcache_dir;
        private MetroLabel metroLabel6;
        private MetroTile metroTile1;
        private MetroCheckBox cb_timezone;
        private MetroCheckBox cb_timeforamt;
        private TextBox t_timeforamt;
    }
}
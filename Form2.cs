namespace ARTIFACT_Analyzer
{
    public partial class Form2 : MetroForm
    {
        Setting set = new Setting();
        Files files = new Files();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            isChecked(Chb_kisa, Chb_Custom);
        }
        public void isChecked(MetroCheckBox chb,MetroCheckBox chb1)
        {
            if (chb.Checked)
            {
                chb.Checked = true;
                chb1.Checked = false;
                t_amcache_dir.Enabled = false;
                t_appcompatcache_dir.Enabled = false;
                t_prefetch_dir.Enabled = false;
                t_eventlog_dir.Enabled = false;
                t_jumplist_dir.Enabled = false;
                t_lnk_dir.Enabled = false;
            }
            else
            {
                chb1.Checked = true;
                chb.Checked = false;
                t_amcache_dir.Enabled = true;
                t_appcompatcache_dir.Enabled = true;
                t_prefetch_dir.Enabled = true;
                t_eventlog_dir.Enabled = true;
                t_jumplist_dir.Enabled = true;
                t_lnk_dir.Enabled = true;
            }
        }
        private void t_amcache_dir_MouseClick(object sender, MouseEventArgs e)
        {
            t_amcache_dir.Text = set.OP_File();
        }

        private void t_appcompatcache_dir_MouseClick(object sender, MouseEventArgs e)
        {
            t_appcompatcache_dir.Text = set.OP_File();
        }

        private void t_prefetch_dir_MouseClick(object sender, MouseEventArgs e)
        {
            t_prefetch_dir.Text = set.OP_File();
        }

        private void t_eventlog_dir_MouseClick(object sender, MouseEventArgs e)
        {
            t_eventlog_dir.Text = set.OP_File();
        }

        private void t_jumplist_dir_MouseClick(object sender, MouseEventArgs e)
        {
            t_jumplist_dir.Text = set.OP_File();
        }

        private void t_lnk_dir_MouseClick(object sender, MouseEventArgs e)
        {
            t_lnk_dir.Text = set.OP_File();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            set.Amcache = t_amcache_dir.Text;
            set.Prefetch = t_prefetch_dir.Text;
            set.Eventlog = t_eventlog_dir.Text;
            set.Appcompatcache = t_appcompatcache_dir.Text;
            set.Lnk = t_lnk_dir.Text;
            set.Jumplist = t_jumplist_dir.Text;
            set.Timeformat = t_timeforamt.Text;
            this.Close();
            string title = @"
-----------------------------------------------------------------------
 _______        __   __   ___              __     
|   _   |.----.|  |_|__|.'  _|.---.-.----.|  |_   
|       ||   _||   _|  ||   _||  _  |  __||   _|  
|___|___||__|  |____|__||__|  |___._|____||____|  
                                                  
 _______               __                         
|   _   |.-----.---.-.|  |.--.--.-----.-----.----.
|       ||     |  _  ||  ||  |  |-- __|  -__|   _|
|___|___||__|__|___._||__||___  |_____|_____|__|  
                          |_____|                 
-----------------------------------------------------------------------";
            Console.WriteLine(title);
            Console.WriteLine("Amcache: " + set.Amcache);
            Console.WriteLine("Prefetch: " + set.Prefetch);
            Console.WriteLine("EventLog: " + set.Eventlog);
            Console.WriteLine("AppCompatCache: " + set.Appcompatcache);
            Console.WriteLine("LinkFile: " + set.Lnk);
            Console.WriteLine("JumpList: " + set.Jumplist);
            Console.WriteLine("Args: " + "--csv " + set.SaveDir + " --dt " + "yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(files.getConsoleMsg(Application.StartupPath + "Module\\LECmd\\LECmd.exe","hahaha"));
            this.Close();
        }

        private void cb_timeforamt_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_timeforamt.Checked)
            {
                t_timeforamt.Enabled = true;
            }
            else
            {
                t_timeforamt.Enabled = false;
            }
        }

        private void Chb_kisa_Click(object sender, EventArgs e)
        {
            Chb_kisa.Checked = true;
            Chb_Custom.Checked = false;
            t_amcache_dir.Enabled = false;
            t_appcompatcache_dir.Enabled = false;
            t_prefetch_dir.Enabled = false;
            t_eventlog_dir.Enabled = false;
            t_jumplist_dir.Enabled = false;
            t_lnk_dir.Enabled = false;
        }

        private void Chb_Custom_Click(object sender, EventArgs e)
        {
            Chb_Custom.Checked = true;
            Chb_kisa.Checked = false;
            t_amcache_dir.Enabled = true;
            t_appcompatcache_dir.Enabled = true;
            t_prefetch_dir.Enabled = true;
            t_eventlog_dir.Enabled = true;
            t_jumplist_dir.Enabled = true;
            t_lnk_dir.Enabled = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}

namespace ARTIFACT_Analyzer
{
    public partial class Form2 : MetroForm
    {
        Setting set = new Setting();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            (new Form1()).Show();
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
    }
}

namespace ARTIFACT_Analyzer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Files f = new Files();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Mod = f.GetFileList(Application.StartupPath + "Module", "*.exe");
            for (int i = 0; i < Mod.Length; i++)
            {
                string Name = Mod[i].Split('\\').Last().Split('.')[0];
                string Mod_ver = f.GetFileVersion(Mod[i]);
                bool Status = false;
                string Mod_dis = f.GetFileDescription(Mod[i]);

                if (Mod_ver != null || Mod_dis != null)
                {
                    Status = true;
                }

                string[] items = new string[] {Name, Mod_ver,Status.ToString(),Mod_dis };
                ListViewItem lvi = new ListViewItem(items);
                mlist_module.Items.Add(lvi);
            }
        }
    }
}
namespace lsp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenGuru_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            MainContentPanel.Visible = false;
            Guru FormActive = new Guru();
            FormActive.MdiParent = this;
            FormActive.Show();
            TitleLabel.Text = "Kelola Data Guru";
        }

        private void OpenMapel_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            MainContentPanel.Visible = false;
            Mapel FormActive = new Mapel();
            FormActive.MdiParent = this;
            FormActive.Show();
            TitleLabel.Text = "Kelola Data Mapel";
        }

        private void OpenSiswa_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            MainContentPanel.Visible = false;
            Siswa FormActive = new Siswa();
            FormActive.MdiParent = this;
            FormActive.Show();
            TitleLabel.Text = "Kelola Data Siswa";
        }

        private void OpenNilai_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            MainContentPanel.Visible = false;
            Nilai FormActive = new Nilai();
            FormActive.MdiParent = this;
            FormActive.Show();
            TitleLabel.Text = "Kelola Data Nilai";
        }
    }
}
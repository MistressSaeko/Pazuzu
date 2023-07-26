namespace Pazuzu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CharacterEditorButton_Click(object sender, EventArgs e)
        {
            CharacterEditor ChrEdit = new();
            ChrEdit.ShowDialog();
        }

        private void WeaponEditorButton_Click(object sender, EventArgs e)
        {
            WeaponEditor WpnEdit = new();
            WpnEdit.ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new();
            about.ShowDialog();
        }
    }
}
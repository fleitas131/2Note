namespace _2Note
{
    public partial class NoteMain : Form
    {
        public NoteMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del programa?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
            
            
        }
    }
}
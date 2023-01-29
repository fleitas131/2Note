namespace _2Note
{
    public partial class NoteMain : Form
    {
        public NoteMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) //preguntamos si quiere cerrar el programa
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

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) //se muestra info sobre 2note
        {
            MessageBox.Show("2Note notepad, proyecto de afleitas.com", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e) //hace un clear de texbox para nuevo notepad
        {
            if (richTextBox1.Text != null && MessageBox.Show("Desea un nuevo notepad?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                richTextBox1.Text = "";
            }
            else
            {
                return;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e) //abre archivo txt
        {
            OpenFileDialog NoteOpenFile = new OpenFileDialog();
            NoteOpenFile.Filter = "Text files (*.txt)|*.txt";
            NoteOpenFile.Title = "Abrir Note";
            if (NoteOpenFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(NoteOpenFile.FileName);
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e) //guarda el archivo como txt
        {
            SaveFileDialog NoteSaveFile = new SaveFileDialog();
            NoteSaveFile.Filter = "Text files (*.txt)|*.txt";
            NoteSaveFile.Title = "Guardar Note";
            NoteSaveFile.RestoreDirectory = true;
            if (NoteSaveFile.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(NoteSaveFile.FileName, richTextBox1.Text);
            }
        }
    }
}
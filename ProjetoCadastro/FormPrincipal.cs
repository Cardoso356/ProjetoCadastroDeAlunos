using ReaLTaiizor.Forms;

namespace ProjetoCadastro
{
    public partial class FormPrincipal : MaterialForm
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAluno formAluno = new FormCadastroAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        public void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroDeCursos formCurso = new FormCadastroDeCursos();
            formCurso.MdiParent = this;
            formCurso.Show();
        }
    }
}

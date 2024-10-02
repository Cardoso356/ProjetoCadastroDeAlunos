using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroDeCursos : MaterialForm
    {
        string cursoFileName = "cursos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;

        public FormCadastroDeCursos()
        {
            InitializeComponent();
        }

        private void FormCadastroDeCursos_Load(object sender, EventArgs e)
        {

        }

        private void BotaoSalvarCurso_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                tabControlCadastroCursos.SelectedIndex = 1;
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(CampoCodigoCurso.Text))
            {
                MessageBox.Show("Código obrigatório!");
                CampoCodigoCurso.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(CampoNomeCurso.Text))
            {
                MessageBox.Show("Nome obrigatório!");
                CampoNomeCurso.Focus();
                return false;
            }

            return true;
        }


        private void Salvar()
        {
            var line = $"{CampoCodigoCurso.Text};" +
                       $"{CampoNomeCurso.Text};" +
                       $"{CampoDeNivelDoCurso.Text};" +
                       $"{CampoDeDuracaoDoCurso.Text};" +
                       $"{CampoDePeriodoDoCurso.Text};" +
                       $"{CampoDeAreaDoCurso.Text};";


            if (!isAlteracao)
            {
                var file = new StreamWriter(cursoFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                string[] cursos = File.ReadAllLines(cursoFileName);
                cursos[indexSelecionado] = line;
                File.WriteAllLines(cursoFileName, cursos);
            }
            LimpaCampos();
        }


        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabControlCadastroCursos.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //desconsidere
        }
    }
}

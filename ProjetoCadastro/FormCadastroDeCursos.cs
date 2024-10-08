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


        public void CARREGAlistView()
        {
            Cursor.Current = Cursors.WaitCursor;
            mlvCursos.Columns.Clear();
            mlvCursos.Items.Clear();
            mlvCursos.Columns.Add("Código");
            mlvCursos.Columns.Add("Nome");
            mlvCursos.Columns.Add("Nível");
            mlvCursos.Columns.Add("Período");
            mlvCursos.Columns.Add("Duração do Semestre");
            mlvCursos.Columns.Add("Área");

            string[] cursos = File.ReadAllLines(cursoFileName);

            foreach (string curso in cursos)
            {
                var campos = curso.Split(';');
                mlvCursos.Items.Add(new ListViewItem(campos));

            }
            mlvCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //desconsidere
        }

        private void BotaoCancelarCurso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \n\n" +
            "Deseja cancelar ?", "Pergunta", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastroCursos.SelectedIndex = 1;
            }

        }

        private void tabPage2_Enter(object sender, EventArgs e)//página da consulta
        {
            CARREGAlistView();
        }


        public void Editar()
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                indexSelecionado = mlvCursos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = mlvCursos.SelectedItems[0];
                CampoCodigoCurso.Text = item.SubItems[0].Text;
                CampoNomeCurso.Text = item.SubItems[1].Text;
                CampoDeNivelDoCurso.Text = item.SubItems[2].Text;
                CampoDePeriodoDoCurso.Text = item.SubItems[3].Text;
                CampoDeDuracaoDoCurso.Text = item.SubItems[4].Text;
                CampoDeAreaDoCurso.Text = item.SubItems[5].Text;
                tabControlCadastroCursos.SelectedIndex = 0;
                CampoCodigoCurso.Focus();
                
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BotaoDeEditarCurso_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void mlvCursos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void BotaoDeNovoCurso_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabControlCadastroCursos.SelectedIndex = 0;
            CampoCodigoCurso.Focus();
        }

        public void Excluir()
        {
            List<string> cursos = File.ReadAllLines(cursoFileName).ToList();
            cursos.RemoveAt(indexSelecionado);
            File.WriteAllLines(cursoFileName, cursos);

        }

        private void BotaoDeExcluirCurso_Click(object sender, EventArgs e)
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente deletar o curso selecionado ?",
                    "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = mlvCursos.SelectedItems[0].Index;
                    Excluir();
                    CARREGAlistView();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mlvCursos_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Editar();
        }
    }
}

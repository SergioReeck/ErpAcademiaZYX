using BusinessLogicalLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInterfaceUserLayer
{
    public partial class frmPesquisaAluno : Form
    {
        AlunoBLL alunoBLL = new AlunoBLL();

        public frmPesquisaAluno()
        {
            InitializeComponent();
            this.Load += frmPesquisaAluno_Load;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtPesquisar.Text;
            DataResponse<Aluno> response = alunoBLL.PesquisarAluno(aluno);
            if (response.Success)
            {
                this.dgvResultadosPesquisa.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Aluno> response = alunoBLL.GetAll();
            if (response.Success)
            {
                this.dgvResultadosPesquisa.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Aluno aluno = (Aluno)this.dgvResultadosPesquisa.SelectedRows[0].DataBoundItem;
            frmEditAluno fea = new frmEditAluno(aluno);
            fea.ShowDialog();
        }

        private void frmPesquisaAluno_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}

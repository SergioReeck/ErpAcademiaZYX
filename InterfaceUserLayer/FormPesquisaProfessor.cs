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
    public partial class frmPesquisaProfessor : Form
    {
        private ProfessorBLL professorBLL = new ProfessorBLL();

        public frmPesquisaProfessor()
        {
            InitializeComponent();
            this.Load += frmPesquisaProfessor_Load;
            this.dgvResultadosPesquisa.RowsAdded += DgvResultadosPesquisa_RowsAdded;
        }

        private void AtualizarGrid()
        {
            DataResponse<Professor> response = professorBLL.GetAll();
            if (response.Success)
            {
                this.dgvResultadosPesquisa.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void frmPesquisaProfessor_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Nome = txtPesquisar.Text;
            DataResponse<Professor> response = professorBLL.PesquisarProfessor(professor);
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
            Professor professor = (Professor)this.dgvResultadosPesquisa.SelectedRows[0].DataBoundItem;
            frmEditProfessores fep = new frmEditProfessores(professor);
            fep.ShowDialog();
        }

        private void DgvResultadosPesquisa_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvResultadosPesquisa.Rows[e.RowIndex].Cells[14].Style.Format = "C2";
        }
    }
}

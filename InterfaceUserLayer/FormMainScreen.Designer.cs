
namespace WinFormsInterfaceUserLayer
{
    partial class frmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroFormasPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroModalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroCredenciais = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEntradadeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultarEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRealizarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSairSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.sslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Silver;
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastros,
            this.mnEstoque,
            this.mnPedidos,
            this.mnOpcoes});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MdiWindowListItem = this.mnCadastros;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Menu Principal";
            // 
            // mnCadastros
            // 
            this.mnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastroClientes,
            this.mnCadastroFuncionarios,
            this.mnCadastroProdutos,
            this.mnCadastroFormasPagamento,
            this.mnCadastroModalidades,
            this.mnCadastroCredenciais});
            this.mnCadastros.Name = "mnCadastros";
            this.mnCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnCadastros.Text = "&Cadastros";
            // 
            // mnCadastroClientes
            // 
            this.mnCadastroClientes.Name = "mnCadastroClientes";
            this.mnCadastroClientes.Size = new System.Drawing.Size(259, 22);
            this.mnCadastroClientes.Text = "Cadastro de Clientes";
            this.mnCadastroClientes.Click += new System.EventHandler(this.mnCadastroClientes_Click);
            // 
            // mnCadastroFuncionarios
            // 
            this.mnCadastroFuncionarios.Name = "mnCadastroFuncionarios";
            this.mnCadastroFuncionarios.Size = new System.Drawing.Size(259, 22);
            this.mnCadastroFuncionarios.Text = "Cadastro de Funcionários";
            this.mnCadastroFuncionarios.Click += new System.EventHandler(this.mnCadastroFuncionarios_Click);
            // 
            // mnCadastroProdutos
            // 
            this.mnCadastroProdutos.Name = "mnCadastroProdutos";
            this.mnCadastroProdutos.Size = new System.Drawing.Size(259, 22);
            this.mnCadastroProdutos.Text = "Cadastro de Produtos";
            this.mnCadastroProdutos.Click += new System.EventHandler(this.mnCadastroProdutos_Click);
            // 
            // mnCadastroFormasPagamento
            // 
            this.mnCadastroFormasPagamento.Name = "mnCadastroFormasPagamento";
            this.mnCadastroFormasPagamento.Size = new System.Drawing.Size(259, 22);
            this.mnCadastroFormasPagamento.Text = "Cadastro de Formas de Pagamento";
            this.mnCadastroFormasPagamento.Click += new System.EventHandler(this.mnCadastroFormasPagamento_Click);
            // 
            // mnCadastroModalidades
            // 
            this.mnCadastroModalidades.Name = "mnCadastroModalidades";
            this.mnCadastroModalidades.Size = new System.Drawing.Size(259, 22);
            this.mnCadastroModalidades.Text = "Cadastro de Modalidades";
            this.mnCadastroModalidades.Click += new System.EventHandler(this.mnCadastroModalidades_Click);
            // 
            // mnCadastroCredenciais
            // 
            this.mnCadastroCredenciais.Name = "mnCadastroCredenciais";
            this.mnCadastroCredenciais.Size = new System.Drawing.Size(259, 22);
            this.mnCadastroCredenciais.Text = "Cadastro de Credenciais";
            this.mnCadastroCredenciais.Click += new System.EventHandler(this.mnCadastroCredenciais_Click);
            // 
            // mnEstoque
            // 
            this.mnEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEntradadeProdutos,
            this.mnConsultarEstoque});
            this.mnEstoque.Name = "mnEstoque";
            this.mnEstoque.Size = new System.Drawing.Size(61, 20);
            this.mnEstoque.Text = "&Estoque";
            // 
            // mnEntradadeProdutos
            // 
            this.mnEntradadeProdutos.Name = "mnEntradadeProdutos";
            this.mnEntradadeProdutos.Size = new System.Drawing.Size(181, 22);
            this.mnEntradadeProdutos.Text = "Entrada de Produtos";
            this.mnEntradadeProdutos.Click += new System.EventHandler(this.mnEntradaProdutos_Click);
            // 
            // mnConsultarEstoque
            // 
            this.mnConsultarEstoque.Name = "mnConsultarEstoque";
            this.mnConsultarEstoque.Size = new System.Drawing.Size(181, 22);
            this.mnConsultarEstoque.Text = "Consultar Estoque";
            // 
            // mnPedidos
            // 
            this.mnPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRealizarVenda});
            this.mnPedidos.Name = "mnPedidos";
            this.mnPedidos.Size = new System.Drawing.Size(61, 20);
            this.mnPedidos.Text = "&Pedidos";
            // 
            // mnRealizarVenda
            // 
            this.mnRealizarVenda.Name = "mnRealizarVenda";
            this.mnRealizarVenda.Size = new System.Drawing.Size(180, 22);
            this.mnRealizarVenda.Text = "Realizar Venda";
            this.mnRealizarVenda.Click += new System.EventHandler(this.mnRealizarVenda_Click);
            // 
            // mnOpcoes
            // 
            this.mnOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSairSistema});
            this.mnOpcoes.Name = "mnOpcoes";
            this.mnOpcoes.Size = new System.Drawing.Size(59, 20);
            this.mnOpcoes.Text = "&Opções";
            // 
            // mnSairSistema
            // 
            this.mnSairSistema.CheckOnClick = true;
            this.mnSairSistema.Name = "mnSairSistema";
            this.mnSairSistema.Size = new System.Drawing.Size(180, 22);
            this.mnSairSistema.Text = "Sair do Sistema";
            this.mnSairSistema.Click += new System.EventHandler(this.mnSairSistema_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.BackColor = System.Drawing.Color.Silver;
            this.mainStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslUsuario,
            this.sslNomeUsuario,
            this.sslLogin,
            this.sslDateTime});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.mainStatusStrip.TabIndex = 1;
            // 
            // sslUsuario
            // 
            this.sslUsuario.Name = "sslUsuario";
            this.sslUsuario.Size = new System.Drawing.Size(50, 17);
            this.sslUsuario.Text = "Usuário:";
            // 
            // sslNomeUsuario
            // 
            this.sslNomeUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sslNomeUsuario.Name = "sslNomeUsuario";
            this.sslNomeUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // sslLogin
            // 
            this.sslLogin.Name = "sslLogin";
            this.sslLogin.Size = new System.Drawing.Size(121, 17);
            this.sslLogin.Text = "-  Login efetuado em:";
            // 
            // sslDateTime
            // 
            this.sslDateTime.Name = "sslDateTime";
            this.sslDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMainScreen";
            this.ShowIcon = false;
            this.Text = "Academia ZYX - Fitness Center";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainScreen_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroClientes;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel sslNomeUsuario;
        private System.Windows.Forms.ToolStripStatusLabel sslDateTime;
        private System.Windows.Forms.ToolStripStatusLabel sslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel sslLogin;
        private System.Windows.Forms.ToolStripMenuItem mnCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnOpcoes;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroDeFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroDeProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroDeFormasDePagamento;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroDeModalidades;
        private System.Windows.Forms.ToolStripMenuItem mnEntradadeProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnRealizarVenda;
        private System.Windows.Forms.ToolStripMenuItem mnSairSistema;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroDeCredenciais;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroFormasPagamento;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroModalidades;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroCredenciais;
        private System.Windows.Forms.ToolStripMenuItem mnConsultarEstoque;
    }
}
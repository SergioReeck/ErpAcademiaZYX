
namespace WinFormsInterfaceUserLayer
{
    partial class frmLoadScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadScreen));
            this.pbiSplashScreen = new System.Windows.Forms.PictureBox();
            this.pbSplashScreen = new System.Windows.Forms.ProgressBar();
            this.lblLoadSystem = new System.Windows.Forms.Label();
            this.tmProgressBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbiSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbiSplashScreen
            // 
            this.pbiSplashScreen.Image = ((System.Drawing.Image)(resources.GetObject("pbiSplashScreen.Image")));
            this.pbiSplashScreen.Location = new System.Drawing.Point(12, 12);
            this.pbiSplashScreen.Name = "pbiSplashScreen";
            this.pbiSplashScreen.Size = new System.Drawing.Size(355, 272);
            this.pbiSplashScreen.TabIndex = 0;
            this.pbiSplashScreen.TabStop = false;
            // 
            // pbSplashScreen
            // 
            this.pbSplashScreen.Location = new System.Drawing.Point(12, 285);
            this.pbSplashScreen.Name = "pbSplashScreen";
            this.pbSplashScreen.Size = new System.Drawing.Size(355, 10);
            this.pbSplashScreen.TabIndex = 2;
            // 
            // lblLoadSystem
            // 
            this.lblLoadSystem.AutoSize = true;
            this.lblLoadSystem.BackColor = System.Drawing.Color.White;
            this.lblLoadSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoadSystem.Location = new System.Drawing.Point(152, 258);
            this.lblLoadSystem.Name = "lblLoadSystem";
            this.lblLoadSystem.Size = new System.Drawing.Size(82, 21);
            this.lblLoadSystem.TabIndex = 1;
            this.lblLoadSystem.Text = "Iniciando...";
            // 
            // tmProgressBar
            // 
            this.tmProgressBar.Enabled = true;
            this.tmProgressBar.Tick += new System.EventHandler(this.tmProgressBar_Tick);
            // 
            // frmLoadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 307);
            this.Controls.Add(this.lblLoadSystem);
            this.Controls.Add(this.pbSplashScreen);
            this.Controls.Add(this.pbiSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoadScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbiSplashScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbiSplashScreen;
        private System.Windows.Forms.ProgressBar pbSplashScreen;
        private System.Windows.Forms.Label lblLoadSystem;
        private System.Windows.Forms.Timer tmProgressBar;
    }
}
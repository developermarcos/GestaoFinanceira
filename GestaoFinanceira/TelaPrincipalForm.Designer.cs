namespace GestaoFinanceira
{
    partial class TelaPrincipalForm
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
            this.panelNavegation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.imagemNavegacao = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelRodape = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelNavegation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemNavegacao)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavegation
            // 
            this.panelNavegation.Controls.Add(this.button1);
            this.panelNavegation.Controls.Add(this.btnDashboard);
            this.panelNavegation.Controls.Add(this.imagemNavegacao);
            this.panelNavegation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavegation.Location = new System.Drawing.Point(0, 0);
            this.panelNavegation.Name = "panelNavegation";
            this.panelNavegation.Size = new System.Drawing.Size(190, 597);
            this.panelNavegation.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(0, 67);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(181, 32);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // imagemNavegacao
            // 
            this.imagemNavegacao.Location = new System.Drawing.Point(3, 3);
            this.imagemNavegacao.Name = "imagemNavegacao";
            this.imagemNavegacao.Size = new System.Drawing.Size(181, 58);
            this.imagemNavegacao.TabIndex = 0;
            this.imagemNavegacao.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelTitulo);
            this.panelHeader.Controls.Add(this.btnCadastrar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(190, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(872, 55);
            this.panelHeader.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(6, 21);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(43, 15);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "[titulo]";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(742, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 32);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "[cadastrar]";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(190, 55);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(872, 542);
            this.panelConteudo.TabIndex = 2;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.labelRodape);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(190, 559);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(872, 38);
            this.panelFooter.TabIndex = 2;
            // 
            // labelRodape
            // 
            this.labelRodape.AutoSize = true;
            this.labelRodape.Location = new System.Drawing.Point(6, 14);
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(116, 15);
            this.labelRodape.TabIndex = 4;
            this.labelRodape.Text = "[mensagem_rodape]";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 597);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelNavegation);
            this.Name = "TelaPrincipalForm";
            this.Text = "TelaPrincipalForm";
            this.panelNavegation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemNavegacao)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNavegation;
        private PictureBox imagemNavegacao;
        private Panel panelHeader;
        private Panel panelConteudo;
        private Panel panelFooter;
        private Button btnDashboard;
        private Button btnCadastrar;
        private Label labelTitulo;
        private Label labelRodape;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
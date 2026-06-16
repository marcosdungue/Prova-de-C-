namespace Chat
{
    partial class FrmConversa
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
            txtNome = new TextBox();
            txtMensagem = new RichTextBox();
            btEnviar = new Button();
            txtHistorico = new RichTextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.BackColor = Color.GhostWhite;
            txtNome.Location = new Point(12, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(322, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtMensagem
            // 
            txtMensagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMensagem.BackColor = Color.GhostWhite;
            txtMensagem.Location = new Point(12, 540);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(221, 96);
            txtMensagem.TabIndex = 1;
            txtMensagem.Text = "";
            txtMensagem.TextChanged += txtMensagem_TextChanged;
            // 
            // btEnviar
            // 
            btEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btEnviar.BackColor = Color.FromArgb(192, 192, 255);
            btEnviar.Font = new Font("Swis721 LtEx BT", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEnviar.Location = new Point(239, 540);
            btEnviar.Name = "btEnviar";
            btEnviar.Size = new Size(95, 96);
            btEnviar.TabIndex = 2;
            btEnviar.Text = "&Enviar";
            btEnviar.UseVisualStyleBackColor = false;
            btEnviar.Click += btEnviar_Click;
            // 
            // txtHistorico
            // 
            txtHistorico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHistorico.BackColor = Color.Lavender;
            txtHistorico.Font = new Font("Swis721 LtEx BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHistorico.Location = new Point(12, 41);
            txtHistorico.Name = "txtHistorico";
            txtHistorico.ReadOnly = true;
            txtHistorico.Size = new Size(322, 493);
            txtHistorico.TabIndex = 3;
            txtHistorico.Text = "";
            // 
            // FrmConversa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 648);
            Controls.Add(txtHistorico);
            Controls.Add(btEnviar);
            Controls.Add(txtMensagem);
            Controls.Add(txtNome);
            Name = "FrmConversa";
            Text = "FrmConversa";
            FormClosing += FrmConversa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private RichTextBox txtMensagem;
        private Button btEnviar;
        private RichTextBox txtHistorico;
    }
}
using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class FrmConversa : Form
    {
        Form1 mestre;
        string nome;

        public FrmConversa(Form1 m)
        {
            InitializeComponent();
            mestre = m;
            Random r = new Random();
            int id = r.Next(1, 10000);

            AtribuirNome($"Usuário {id}");

            txtNome.Text = $"Usuário {id}";

            btEnviar.Enabled = false;
        }

        void AtribuirNome(string n)
        {
            nome = n;
            Text = nome;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            AtribuirNome(txtNome.Text);
        }

        private void FrmConversa_FormClosing(object sender, FormClosingEventArgs e)
        {
            // chame a função Fechar do mestre para desalocar a posição desse form no list de usuarios
            mestre.Fechar(this);
        }

        public void ReceberMensagem(string usuario, string texto)
        {
            // concatenar no texto do txtHistorico "{usuario} :: {texto}" se o usuario for outro
            // se for mensagem própria, ou seja, usuario igual ao nome, concatenar "Você :: {texto}"
            if (usuario == nome)
            {
                txtHistorico.AppendText($"Você :: {texto}\r \n");
            }
            else
            {
                txtHistorico.AppendText($"{usuario} :: {texto}\r \n");
            }
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            // no TextChange do txtMensagem, verificar se está vazio, se estiver, travar botão <enviar>
            // programe o evento click do btEnviar para funcionar conforme previsto
            if (txtMensagem.Text.Trim() != "")
            {
                mestre.Disparar(nome, txtMensagem.Text);
                txtMensagem.Clear();
                txtMensagem.Focus();
            }
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {
            btEnviar.Enabled = (txtMensagem.Text.Trim() != "");
        }
    }
}
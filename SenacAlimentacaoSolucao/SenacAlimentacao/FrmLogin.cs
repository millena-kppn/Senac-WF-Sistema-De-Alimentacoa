namespace SenacAlimentacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e) 
        {
            bool loginValido = ValidarLogin(txtLogin.Text, txtSenha.Text);
            //se o login for v�lido ele exibe o formul�rio principal
            if (loginValido == true)
                {
                    //ocultar o formul�rio FrmLogin
                    this.Hide();
                    //criar uma inst�ncia do formul�rio FrmPrincipal
                    var frmPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                    //exibir o formul�rio FrmPrincipal
                    frmPrincipal.Show();
                }
        }
        

        private bool ValidarLogin(string nome, string senha)
        {

            //se nome � igual a "Millena" e senha � igual a "123"
            if (nome == "Millena" && senha == "123")
            {
            //verifica se o nome e a senha est�o corretos RETORNA VERDADEIRO
                return true;
            }
            else
            //exibe uma mensagem de erro
            {
                MessageBox.Show("Nome ou senha inv�lidos!");
            }
            //verifica se o nome e a senha est�o corretos RETORNA FALSO
            return false;
        }

        private void btnFecharLogin_Click(object sender, EventArgs e)
        {
            //fecha a tela de login
            Close();
            //encerra o aplicativo
            Application.Exit();
        }
    }
}

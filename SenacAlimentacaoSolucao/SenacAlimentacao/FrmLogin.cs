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
            //se o login for válido ele exibe o formulário principal
            if (loginValido == true)
                {
                    //ocultar o formulário FrmLogin
                    this.Hide();
                    //criar uma instância do formulário FrmPrincipal
                    var frmPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                    //exibir o formulário FrmPrincipal
                    frmPrincipal.Show();
                }
        }
        

        private bool ValidarLogin(string nome, string senha)
        {

            //se nome é igual a "Millena" e senha é igual a "123"
            if (nome == "Millena" && senha == "123")
            {
            //verifica se o nome e a senha estão corretos RETORNA VERDADEIRO
                return true;
            }
            else
            //exibe uma mensagem de erro
            {
                MessageBox.Show("Nome ou senha inválidos!");
            }
            //verifica se o nome e a senha estão corretos RETORNA FALSO
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

namespace boas_vinda
{
    public partial class form1 : Form
    {
        public form1()
        { /* Executado sempre que apertar o botão */
            InitializeComponent();
        }

        /* Metodo que inicia no evento de click*/
        private void btnSaudacao_Click(object sender, EventArgs e)
        {
            /*Quando clicado o botão irá aparecer a mensagem de saudação e também o nome que foi digitado no Txt Nome*/
            MessageBox.Show("Olá! Bem-vindo(a) " + txtNome.Text );
        }
    }
}

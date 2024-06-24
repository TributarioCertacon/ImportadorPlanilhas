using MaterialSkin;
using PRJ_CONSOLIDADOR;
using System.Windows.Forms;

namespace CShp_MaterialDesing
{
    public partial class Certacon : MaterialSkin.Controls.MaterialForm
    {
        public Certacon()
        {
            InitializeComponent();
            //TEMA
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema 
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Orange700,
                TextShade.WHITE
            );

        }
        private void BTN_IMPORTAR_ORIGEM_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.Filter = "CSV|*.csv";
            openFileDialog1.Title = "selecione o arquivo csv";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }

        }

        private void materialLabel1_Click(object sender, System.EventArgs e)
        {


        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.BTN_SELECIONAR_ORIGEM.Click += new System.EventHandler(this.BTN_IMPORTAR_ORIGEM_Click);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void BTN_SELECIONAR_DESTINO_Click(object sender, System.EventArgs e)
        {

        }

        private void TXT_DESTINO_Click(object sender, System.EventArgs e)
        {

        }

        private void TXT_ORIGEM_Click(object sender, System.EventArgs e)
        {

        }

        private void Processamento_Click(object sender, System.EventArgs e)
        {

            
        }

        private void BTN_GERAR_Click(object sender, System.EventArgs e)
        {
            
        }

        private void BTN_CONFIG_Click(object sender, System.EventArgs e)
        {
            Configuracoes configuracao = new Configuracoes();

            configuracao.Show();
        }
    }
}




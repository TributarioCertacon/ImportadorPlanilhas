using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using System.IO;
using System.Data.SqlClient;

namespace PRJ_CONSOLIDADOR
{
    public partial class Leitura : MaterialSkin.Controls.MaterialForm
    {

        Configuracoes configuracao = new Configuracoes();

        List<Models.TB_CAT17_EXTRATOR> ListaObjs = new List<Models.TB_CAT17_EXTRATOR>();

        public Leitura()
        {
            InitializeComponent();
                      {

                //TEMA
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Configure color schema 
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue700,
                Primary.Blue800, Accent.Blue400,
                TextShade.WHITE);

            }
        }
        // Seleciona Origem

        public void BtnSelecionarOrigem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBox1.Text;

            //exibe o dialogo folderbrowser
            DialogResult drResultado = folderBrowserDialog1.ShowDialog();

            //atribui o nome da pasta selecionada à caixa de texto

            if (drResultado == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;


        }

        //Botão que processa os arquivos

        public void BtnProcessar_Click(object sender, EventArgs e)
        {

            ProgressBar.Style = ProgressBarStyle.Marquee;
            ProgressBar.MarqueeAnimationSpeed = 5;
            BtnProcessar.Enabled = false;
            textBox1.Enabled = false;
            BtnSelecionarOrigem.Enabled = false;
            buttonLimpar.Enabled = false;
            //executa o processo de forma assincrona.
            BgWorker.RunWorkerAsync();

            aviso1.Text = "Processando...";
        }

        private void limpaTXT()
        {
            textBox1.Text = "";
          
        }

        //Seleciona o destino

   
        private void Leitura_Load(object sender, EventArgs e, FormClosingEventArgs b)
        {

        }

        private void BulkInsertData(DataTable dataTable, int batchSize)
            {
            using (SqlConnection connection = new SqlConnection("Data Source=192.168.0.90; Initial Catalog=SUPERMERCADO_JOANIN; user=sa; pwd=Certa@2024"))
                {
                connection.Open();

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                    bulkCopy.BulkCopyTimeout = 300;
                    bulkCopy.DestinationTableName = "dbo.TB_CAT17_EXTRATOR";

                    // Map columns explicitly
                    foreach (DataColumn column in dataTable.Columns)
                        {
                        bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                        }

                    // Process data in batches
                    int rowCount = dataTable.Rows.Count;
                    int startIndex = 0;

                    while (startIndex < rowCount)
                        {
                        int endIndex = Math.Min(startIndex + batchSize, rowCount);
                        DataTable batchDataTable = dataTable.Clone(); // Create a new DataTable with the same structure

                        for (int i = startIndex; i < endIndex; i++)
                            {
                            batchDataTable.ImportRow(dataTable.Rows[i]);
                            }

                        bulkCopy.WriteToServer(batchDataTable);
                        startIndex += batchSize;
                        }
                    }
                }
            }

        // INICIO PROGRESS BAR LOADING

        //Executa a ação do botão processa
        public void Processar()
        {
            DataTable dataTable = new DataTable("TB_CAT17_EXTRATOR");
            foreach (var property in typeof(Models.TB_CAT17_EXTRATOR).GetProperties())
                {
                dataTable.Columns.Add(property.Name, property.PropertyType);
                }

            DirectoryInfo diretorios = new DirectoryInfo(textBox1.Text);

            DirectoryInfo diretorios_layout = new DirectoryInfo(textBox2.Text);


            if (diretorios.Exists)
            {
               
                FileInfo[] rgFiles = diretorios.GetFiles("*." + domainUpDown2.Text);
                int countFile = 0;
                int batchSize = 100000;

                foreach (FileInfo fi in rgFiles)
                {
                    DataTable obj = new DataTable();

                    Controllers.LeituraController objt = new Controllers.LeituraController();

                    //obj = objt.ler_form(fi, countFile);

                    objt.ler_form(fi,  this, dataTable);
                    countFile++;
                    if (dataTable.Rows.Count >= batchSize || countFile == rgFiles.Length)
                        {
                        BulkInsertData(dataTable, 10000);
                        dataTable.Clear();
                        }
                    }
                }
            else
            {
                MessageBox.Show("Diretorio nao existe", "Atenção");
            }

        }

        public void BgWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker bw = sender as BackgroundWorker;


            if (bw.CancellationPending == true)
            {
                //se sim, define a propriedade Cancel para true
                //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                e.Cancel = true;
                return;

            }
            else
            {
                Processar();
            }

        }

        private void BgProgress(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;

            Porcentagem.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void BgRunCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.MarqueeAnimationSpeed = 0;
            ProgressBar.Style = ProgressBarStyle.Blocks;
            ProgressBar.Value = 0;

            this.__Habilita_btn();
            this.__Habilita_txt();

            if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.

                ProgressBar.MarqueeAnimationSpeed = 0;
                ProgressBar.Style = ProgressBarStyle.Blocks;
                ProgressBar.Value = 0;
                aviso1.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                aviso1.Text = "Tarefa Concluida com sucesso!";
            }

        }

        private void __Habilita_txt()
        {
            this.textBox1.Enabled = true;
   

        }


        private void __Habilita_btn()
        {
            this.buttonLimpar.Enabled = true;
            this.BtnProcessar.Enabled = true;

            this.BtnSelecionarOrigem.Enabled = true;
       

        }


        //Ação que define sim ou não para o fechamento da aplicação
        private void Leitura_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Tem a certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (escolha == DialogResult.No)
                e.Cancel = true;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
   
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Deseja Cancelar a Operação?", "Mensagem do Sistema", MessageBoxButtons.YesNo
                );
            if (res == System.Windows.Forms.DialogResult.Yes)
            {

                this.BgWorker.WorkerSupportsCancellation = true;
                this.BgWorker.CancelAsync();


                //Controllers.LeituraController objt = new Controllers.LeituraController();
                //objt.encerraApp();

                // return;


                //return;
            }


        }

        public void Leitura_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
            {
            folderBrowserDialog2.SelectedPath = textBox2.Text;

            //exibe o dialogo folderbrowser
            DialogResult drResultado = folderBrowserDialog2.ShowDialog();

            //atribui o nome da pasta selecionada à caixa de texto

            if (drResultado == System.Windows.Forms.DialogResult.OK)
                textBox2.Text = folderBrowserDialog2.SelectedPath;
            }

        private void materialLabel3_Click(object sender, EventArgs e)
            {

            }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
            {

            }
        }
}

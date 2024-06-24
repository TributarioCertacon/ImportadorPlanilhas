namespace PRJ_CONSOLIDADOR
    {
    partial class Leitura
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
            this.BtnSelecionarOrigem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnProcessar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Input = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.aviso1 = new System.Windows.Forms.Label();
            this.Porcentagem = new System.Windows.Forms.Label();
            this.buttonLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // BtnSelecionarOrigem
            // 
            this.BtnSelecionarOrigem.Depth = 0;
            this.BtnSelecionarOrigem.Location = new System.Drawing.Point(696, 226);
            this.BtnSelecionarOrigem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelecionarOrigem.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSelecionarOrigem.Name = "BtnSelecionarOrigem";
            this.BtnSelecionarOrigem.Primary = true;
            this.BtnSelecionarOrigem.Size = new System.Drawing.Size(112, 32);
            this.BtnSelecionarOrigem.TabIndex = 2;
            this.BtnSelecionarOrigem.Text = "...";
            this.BtnSelecionarOrigem.UseVisualStyleBackColor = true;
            this.BtnSelecionarOrigem.Click += new System.EventHandler(this.BtnSelecionarOrigem_Click);
            // 
            // BtnProcessar
            // 
            this.BtnProcessar.Depth = 0;
            this.BtnProcessar.Location = new System.Drawing.Point(624, 502);
            this.BtnProcessar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnProcessar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProcessar.Name = "BtnProcessar";
            this.BtnProcessar.Primary = true;
            this.BtnProcessar.Size = new System.Drawing.Size(184, 58);
            this.BtnProcessar.TabIndex = 4;
            this.BtnProcessar.Text = "PROCESSAR";
            this.BtnProcessar.UseVisualStyleBackColor = true;
            this.BtnProcessar.Click += new System.EventHandler(this.BtnProcessar_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(200, 645);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(538, 3);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(56, 586);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(764, 35);
            this.ProgressBar.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 226);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 26);
            this.textBox1.TabIndex = 16;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.BackColor = System.Drawing.Color.Transparent;
            this.Input.Depth = 0;
            this.Input.Font = new System.Drawing.Font("Roboto", 11F);
            this.Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Input.Location = new System.Drawing.Point(39, 223);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Input.MouseState = MaterialSkin.MouseState.HOVER;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(177, 27);
            this.Input.TabIndex = 17;
            this.Input.Text = "Pasta de Origem:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(369, 672);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(154, 27);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Certacon 2023";
            // 
            // BgWorker
            // 
            this.BgWorker.WorkerSupportsCancellation = true;
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWork);
            this.BgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgProgress);
            this.BgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgRunCompleted);
            // 
            // aviso1
            // 
            this.aviso1.AutoSize = true;
            this.aviso1.Location = new System.Drawing.Point(384, 600);
            this.aviso1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aviso1.Name = "aviso1";
            this.aviso1.Size = new System.Drawing.Size(0, 20);
            this.aviso1.TabIndex = 23;
            // 
            // Porcentagem
            // 
            this.Porcentagem.AutoSize = true;
            this.Porcentagem.Location = new System.Drawing.Point(388, 672);
            this.Porcentagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Size = new System.Drawing.Size(0, 20);
            this.Porcentagem.TabIndex = 24;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Depth = 0;
            this.buttonLimpar.Location = new System.Drawing.Point(387, 502);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Primary = true;
            this.buttonLimpar.Size = new System.Drawing.Size(184, 58);
            this.buttonLimpar.TabIndex = 25;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(134, 175);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 27);
            this.materialLabel2.TabIndex = 30;
            this.materialLabel2.Text = "Layout:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 177);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 26);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "C:\\Users\\dba\\Desktop\\PRJ_CONSOLIDADOR_LAYOUT_FINAL\\PRJ_CONSOLIDADOR_AYUMI\\layout";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(696, 177);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(112, 32);
            this.materialRaisedButton1.TabIndex = 28;
            this.materialRaisedButton1.Text = "...";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.AllowDrop = true;
            this.domainUpDown2.Items.Add("CSV");
            this.domainUpDown2.Items.Add("XLSX");
            this.domainUpDown2.Items.Add("XLS");
            this.domainUpDown2.Items.Add("TXT");
            this.domainUpDown2.Location = new System.Drawing.Point(268, 317);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(240, 26);
            this.domainUpDown2.TabIndex = 32;
            this.domainUpDown2.Text = "Selecione";
            this.domainUpDown2.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(15, 318);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(210, 27);
            this.materialLabel3.TabIndex = 31;
            this.materialLabel3.Text = "Formato do Arquivo:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // Leitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 822);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.Porcentagem);
            this.Controls.Add(this.aviso1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.BtnProcessar);
            this.Controls.Add(this.BtnSelecionarOrigem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Leitura";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXTRATOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leitura_FormClosing);
            this.Load += new System.EventHandler(this.Leitura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        public MaterialSkin.Controls.MaterialRaisedButton BtnSelecionarOrigem;
        public MaterialSkin.Controls.MaterialRaisedButton BtnProcessar;
        public MaterialSkin.Controls.MaterialDivider materialDivider1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.ProgressBar ProgressBar;
        public MaterialSkin.Controls.MaterialLabel Input;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label aviso1;
        public System.Windows.Forms.Label Porcentagem;
        public MaterialSkin.Controls.MaterialRaisedButton buttonLimpar;
        public System.ComponentModel.BackgroundWorker BgWorker;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.TextBox textBox2;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        public System.Windows.Forms.DomainUpDown domainUpDown2;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        }
    }
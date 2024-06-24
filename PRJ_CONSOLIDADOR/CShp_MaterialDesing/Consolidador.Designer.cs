namespace CShp_MaterialDesing
{
    partial class Certacon
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
            this.TXT_ORIGEM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BTN_GERAR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Rodape = new MaterialSkin.Controls.MaterialDivider();
            this.TXT_DESTINO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BTN_SELECIONAR_ORIGEM = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BTN_SELECIONAR_DESTINO = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Label_Certacon = new MaterialSkin.Controls.MaterialLabel();
            this.BTN_CONFIG = new MaterialSkin.Controls.MaterialFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TXT_ORIGEM
            // 
            this.TXT_ORIGEM.Depth = 0;
            this.TXT_ORIGEM.Hint = "Pasta origem do arquivo";
            this.TXT_ORIGEM.Location = new System.Drawing.Point(53, 156);
            this.TXT_ORIGEM.MouseState = MaterialSkin.MouseState.HOVER;
            this.TXT_ORIGEM.Name = "TXT_ORIGEM";
            this.TXT_ORIGEM.PasswordChar = '\0';
            this.TXT_ORIGEM.SelectedText = "";
            this.TXT_ORIGEM.SelectionLength = 0;
            this.TXT_ORIGEM.SelectionStart = 0;
            this.TXT_ORIGEM.Size = new System.Drawing.Size(289, 23);
            this.TXT_ORIGEM.TabIndex = 0;
            this.TXT_ORIGEM.UseSystemPasswordChar = false;
            this.TXT_ORIGEM.Click += new System.EventHandler(this.TXT_ORIGEM_Click);
            // 
            // BTN_GERAR
            // 
            this.BTN_GERAR.Depth = 0;
            this.BTN_GERAR.Location = new System.Drawing.Point(322, 271);
            this.BTN_GERAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_GERAR.Name = "BTN_GERAR";
            this.BTN_GERAR.Primary = true;
            this.BTN_GERAR.Size = new System.Drawing.Size(116, 47);
            this.BTN_GERAR.TabIndex = 3;
            this.BTN_GERAR.Text = "GERAR";
            this.BTN_GERAR.UseVisualStyleBackColor = true;
            this.BTN_GERAR.Click += new System.EventHandler(this.BTN_GERAR_Click);
            // 
            // Rodape
            // 
            this.Rodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rodape.Depth = 0;
            this.Rodape.Location = new System.Drawing.Point(29, 356);
            this.Rodape.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rodape.Name = "Rodape";
            this.Rodape.Size = new System.Drawing.Size(409, 2);
            this.Rodape.TabIndex = 4;
            this.Rodape.Text = "Rodape";
            // 
            // TXT_DESTINO
            // 
            this.TXT_DESTINO.Depth = 0;
            this.TXT_DESTINO.Hint = "Pasta destino do arquivo";
            this.TXT_DESTINO.Location = new System.Drawing.Point(53, 206);
            this.TXT_DESTINO.MouseState = MaterialSkin.MouseState.HOVER;
            this.TXT_DESTINO.Name = "TXT_DESTINO";
            this.TXT_DESTINO.PasswordChar = '\0';
            this.TXT_DESTINO.SelectedText = "";
            this.TXT_DESTINO.SelectionLength = 0;
            this.TXT_DESTINO.SelectionStart = 0;
            this.TXT_DESTINO.Size = new System.Drawing.Size(289, 23);
            this.TXT_DESTINO.TabIndex = 6;
            this.TXT_DESTINO.UseSystemPasswordChar = false;
            this.TXT_DESTINO.Click += new System.EventHandler(this.TXT_DESTINO_Click);
            // 
            // BTN_SELECIONAR_ORIGEM
            // 
            this.BTN_SELECIONAR_ORIGEM.Depth = 0;
            this.BTN_SELECIONAR_ORIGEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SELECIONAR_ORIGEM.Location = new System.Drawing.Point(365, 156);
            this.BTN_SELECIONAR_ORIGEM.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_SELECIONAR_ORIGEM.Name = "BTN_SELECIONAR_ORIGEM";
            this.BTN_SELECIONAR_ORIGEM.Primary = true;
            this.BTN_SELECIONAR_ORIGEM.Size = new System.Drawing.Size(75, 23);
            this.BTN_SELECIONAR_ORIGEM.TabIndex = 7;
            this.BTN_SELECIONAR_ORIGEM.Text = "...";
            this.BTN_SELECIONAR_ORIGEM.UseVisualStyleBackColor = true;
            this.BTN_SELECIONAR_ORIGEM.Click += new System.EventHandler(this.BTN_IMPORTAR_ORIGEM_Click);
            // 
            // BTN_SELECIONAR_DESTINO
            // 
            this.BTN_SELECIONAR_DESTINO.Depth = 0;
            this.BTN_SELECIONAR_DESTINO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SELECIONAR_DESTINO.Location = new System.Drawing.Point(365, 206);
            this.BTN_SELECIONAR_DESTINO.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_SELECIONAR_DESTINO.Name = "BTN_SELECIONAR_DESTINO";
            this.BTN_SELECIONAR_DESTINO.Primary = true;
            this.BTN_SELECIONAR_DESTINO.Size = new System.Drawing.Size(75, 23);
            this.BTN_SELECIONAR_DESTINO.TabIndex = 8;
            this.BTN_SELECIONAR_DESTINO.Text = "...";
            this.BTN_SELECIONAR_DESTINO.UseVisualStyleBackColor = true;
            this.BTN_SELECIONAR_DESTINO.Click += new System.EventHandler(this.BTN_SELECIONAR_DESTINO_Click);
            // 
            // Label_Certacon
            // 
            this.Label_Certacon.AutoSize = true;
            this.Label_Certacon.BackColor = System.Drawing.Color.Transparent;
            this.Label_Certacon.Depth = 0;
            this.Label_Certacon.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label_Certacon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Certacon.Location = new System.Drawing.Point(168, 380);
            this.Label_Certacon.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Certacon.Name = "Label_Certacon";
            this.Label_Certacon.Size = new System.Drawing.Size(106, 19);
            this.Label_Certacon.TabIndex = 5;
            this.Label_Certacon.Text = "Certacon 2018";
            this.Label_Certacon.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // BTN_CONFIG
            // 
            this.BTN_CONFIG.AutoSize = true;
            this.BTN_CONFIG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_CONFIG.Depth = 0;
            this.BTN_CONFIG.Location = new System.Drawing.Point(316, 79);
            this.BTN_CONFIG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_CONFIG.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_CONFIG.Name = "BTN_CONFIG";
            this.BTN_CONFIG.Primary = false;
            this.BTN_CONFIG.Size = new System.Drawing.Size(122, 36);
            this.BTN_CONFIG.TabIndex = 9;
            this.BTN_CONFIG.Text = "Configurações";
            this.BTN_CONFIG.UseVisualStyleBackColor = true;
            this.BTN_CONFIG.Click += new System.EventHandler(this.BTN_CONFIG_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Certacon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 420);
            this.Controls.Add(this.BTN_CONFIG);
            this.Controls.Add(this.BTN_SELECIONAR_DESTINO);
            this.Controls.Add(this.BTN_SELECIONAR_ORIGEM);
            this.Controls.Add(this.TXT_DESTINO);
            this.Controls.Add(this.Label_Certacon);
            this.Controls.Add(this.Rodape);
            this.Controls.Add(this.BTN_GERAR);
            this.Controls.Add(this.TXT_ORIGEM);
            this.Name = "Certacon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSOLIDADOR DE ARQUIVOS CERTACON";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
  
        private MaterialSkin.Controls.MaterialSingleLineTextField TXT_ORIGEM;
        private MaterialSkin.Controls.MaterialRaisedButton BTN_GERAR;
        private MaterialSkin.Controls.MaterialDivider Rodape;
        private MaterialSkin.Controls.MaterialSingleLineTextField TXT_DESTINO;
        private MaterialSkin.Controls.MaterialRaisedButton BTN_SELECIONAR_ORIGEM;
        private MaterialSkin.Controls.MaterialRaisedButton BTN_SELECIONAR_DESTINO;
        private MaterialSkin.Controls.MaterialLabel Label_Certacon;
        private MaterialSkin.Controls.MaterialFlatButton BTN_CONFIG;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


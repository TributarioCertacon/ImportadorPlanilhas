using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;



namespace PRJ_CONSOLIDADOR
{
    public partial class Configuracoes : MaterialSkin.Controls.MaterialForm
    {
        public Configuracoes()
        {
            InitializeComponent();
            {

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

        }


        private void Configuracoes_Load(object sender, EventArgs e)
        {

        }

        private void SingleLineDestino_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelecionarDestino_Click(object sender, EventArgs e)
        {

        }
    }
}


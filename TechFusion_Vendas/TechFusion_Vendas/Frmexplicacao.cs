using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechFusion_Vendas
{
    public partial class Frmexplicacao : Form
    {
        bool sidebarbool;
        bool homebool;
        public Frmexplicacao()
        {
            InitializeComponent();
        }

        private void Frmexplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarbool)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarbool = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarbool = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homebool)
            {
                HomePainel.Height += 10;
                if (HomePainel.Height == HomePainel.MaximumSize.Height)
                {
                    homebool = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                HomePainel.Height -= 10;
                if (HomePainel.Height == HomePainel.MinimumSize.Height)
                {
                    homebool = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUserInicial user = new FrmUserInicial();
            this.Hide();
            user.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmHomeInicial hm = new FrmHomeInicial();
            this.Hide();
            hm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmexplicacao exp = new Frmexplicacao();
            this.Hide();
            exp.ShowDialog();
        }

        private void Frmexplicacao_Load(object sender, EventArgs e)
        {
            label2.Text = "Olá, Bem vindo ao sistema da TechFusion, uma empresa expecifica para venda de projetos relacionados a Redes, infelizmente, por termos produzido \n" +
                          "esse aplicativo as pressas e sem muito conhecimento, podeser que algumas seções não estejam funcionando e por tanto seja redirecionado para cá \n" +
                          "Agradeçemos por sua participação e auxilio.\n" +
                          "";

            textAviso.Text = "";
            string cont = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            int contador;
            String contadores;
            int controle = cont.Length;
            //MessageBox.Show(controle.ToString());
            for (int i = 0; i < 26; i++)
            {
                textAviso.Text += '═';
            }
            textAviso.Text += "Avisos de Funcionamento";
            for (int i = 0; i < 24; i++)
            {
                textAviso.Text += '═';
            }
            textAviso.Text += "\n";
            textAviso.Text += "       Tenha Certeza que antes de Rodar o Código você ativou as seguintes funções:     \n";


            contadores = "Ligar o Xampp";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Ligar o Xampp";
            textAviso.Text += "\n";


            contadores = "Reinstalar o NuGet";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Reinstalar o NuGet";
            textAviso.Text += "\n";

            contadores = "Executou o DataBase";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Executou o DataBase";
            textAviso.Text += "\n";

            contadores = "Executou os Dados da DataBase";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Executou os Dados da DataBase";
            textAviso.Text += "\n";

            contadores = "Clonou toda as pastas";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Clonou toda as pastas";
            textAviso.Text += "\n";

            contadores = "Otimizou o Computador";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Otimizou o Computador";
            textAviso.Text += "\n";
            textAviso.Text += "esse projeto é apenas educativo sem fins lucrativos, ou seja não terá " +
                              "dinheiro real envolvido, e nem reais fornecedores ou produtos, todos os " +
                              "itens mostrados durante \nesse projeto serão todos de cunho educativo e com " +
                              "foco no aprendizado.\n\n" +
                              "A ideia desse projeto é demonstrar nossos conhecimentos obtidos sobre C# ao longo do ano" +
                              " e assim receber nota e passar de ano\n\nEntão.....\nDai-nos nota prof!!!!!!!\n\nOutra infromaçã" +
                              "o de extrema importanci é que no momento da criação deste código não há nenhuma empresa ou grupo" +
                              " com nome techFusion portanto perdoe-nos se estivermos usando os direitos autorais de terceiros." +
                              "\nDito isso A TechFusion apresenta...\nO seu aplicativo Desktop" +
                              "\n\n\n\nCaso concorde com tudo dito Click em OK para seguir adiante.\n\nMas caso não concorde ou deixou de ativar alguma função, então clique CANCELAR para fechar o aplicativo \n\n\n\n\nAgradeço a Atenção\n\n\n";

        }
    }
}

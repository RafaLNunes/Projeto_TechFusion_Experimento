using Csharp_and_Database;
using MySqlX.XDevAPI;
using System.Data;
using TechFusion_Vendas;

namespace Backup2
{
    public partial class comprasoft : Form
    {

        Image produto;

        bool sidebarbool;
        bool homebool;
        bool salebool;

        public comprasoft()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dados;

            float tam = 20;
            produto = pictureBox2.Image;
            Connection cn = new Connection();
            Classe_produto cp = new Classe_produto();
            cp.nome = label1.Text;
            cp.imagem = pictureBox2.Image;
            dados = cn.obterdados("Select * from produto_soft where Cod_produto = " + 1);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            pagsoft form2 = new pagsoft(cp, tam);
            form2.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dados;

            float tam = 17;
            produto = pictureBox3.Image;
            Classe_produto cp = new Classe_produto();
            cp.nome = label2.Text;
            cp.imagem = pictureBox3.Image;

            Connection cn = new Connection();
            dados = cn.obterdados("Select *  produto_soft where Cod_produto = " + 2);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            pagsoft form2 = new pagsoft(cp, tam);
            form2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dados;
            float tam = 15;
            produto = pictureBox4.Image;
            Classe_produto cp = new Classe_produto();
            cp.nome = label3.Text;
            cp.imagem = pictureBox4.Image;


            Connection cn = new Connection();
            dados = cn.obterdados("Select * from  produto_soft where Cod_produto = " + 3);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            pagsoft form2 = new pagsoft(cp, tam);
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dados;
            float tam = 17;
            produto = pictureBox5.Image;
            Classe_produto cp = new Classe_produto();
            cp.nome = label4.Text;
            cp.imagem = pictureBox5.Image;
            Connection cn = new Connection();
            dados = cn.obterdados("Select * from produto_soft where Cod_produto = " + 4);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            pagsoft form2 = new pagsoft(cp, tam);
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dados;
            float tam = 17;
            produto = pictureBox6.Image;
            Classe_produto cp = new Classe_produto();
            cp.nome = label5.Text;
            cp.imagem = pictureBox6.Image;
            Connection cn = new Connection();
            dados = cn.obterdados("Select * from  produto_soft where Cod_produto = " + 5);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            pagsoft form2 = new pagsoft(cp, tam);
            form2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dados;
            float tam = 15;
            produto = pictureBox7.Image;
            Classe_produto cp = new Classe_produto();
            cp.nome = label6.Text;
            cp.imagem = pictureBox7.Image;
            Connection cn = new Connection();
            dados = cn.obterdados("Select *  produto_soft where Cod_produto = " + 6);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            pagsoft form2 = new pagsoft(cp, tam);
            form2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dados;
            float tam = 17;
            produto = pictureBox8.Image;
            Classe_produto cp = new Classe_produto();
            cp.nome = label7.Text;
            cp.imagem = pictureBox8.Image;
            Connection cn = new Connection();

            dados = cn.obterdados("Select * from  produto_soft where Cod_produto = " + 7);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            pagsoft form2 = new pagsoft(cp, tam);
            form2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dados;
            float tam = 20;
            produto = pictureBox9.Image;
            Classe_produto cp = new Classe_produto();
            cp.nome = label8.Text;
            cp.imagem = pictureBox9.Image;
            Connection cn = new Connection();
            dados = cn.obterdados("Select * from  produto_soft where Cod_produto = " + 8);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            pagsoft form2 = new pagsoft(cp, tam);
            form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comprasoft_Load(object sender, EventArgs e)
        {

        }



        private void button9_Click(object sender, EventArgs e)
        {
            FrmHomePrincipal hm = new FrmHomePrincipal();
            this.Hide();
            hm.ShowDialog();
        }

        private void comprasoft_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

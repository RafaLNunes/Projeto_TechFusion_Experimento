using Csharp_and_Database;
using MySqlX.XDevAPI;
using System.Data;
using TechFusion_Vendas;

namespace Backup2
{
    public partial class HardWare : Form
    {

        Image produto;



        public HardWare()
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
            cp.imagem = produto;
            dados = cn.obterdados("Select * from produto where Cod_prod = " + 1);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            Form2 form2 = new Form2(cp, tam, 1);
            form2.Hide();
            form2.ShowDialog();

            Form4 form4 = new Form4(cp, label1.Text);
            form4.Hide();
            form4.ShowDialog();
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
            dados = cn.obterdados("Select * from produto where Cod_prod = " + 2);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            Form2 form2 = new Form2(cp, tam, 2);
            form2.Hide();
            form2.ShowDialog();

            Form4 form4 = new Form4(cp, label2.Text);
            form4.Hide();
            form4.ShowDialog();
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
            dados = cn.obterdados("Select * from produto where Cod_prod = " + 3);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            Form2 form2 = new Form2(cp, tam, 3);
            form2.Hide();
            form2.ShowDialog();

            Form4 form4 = new Form4(cp, label3.Text);
            form4.Hide();
            form4.ShowDialog();
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
            dados = cn.obterdados("Select * from produto where Cod_prod = " + 4);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            Form2 form2 = new Form2(cp, tam, 4);
            form2.Hide();
            form2.ShowDialog();

            Form4 form4 = new Form4(cp, label4.Text);
            form4.Hide();
            form4.ShowDialog();
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
            dados = cn.obterdados("Select * from produto where Cod_prod = " + 5);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            Form2 form2 = new Form2(cp, tam, 5);
            form2.Hide();
            form2.ShowDialog();

            Form4 form4 = new Form4(cp, label5.Text);
            form4.Hide();
            form4.ShowDialog();
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
            dados = cn.obterdados("Select * from produto where Cod_prod = " + 6);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            Form2 form2 = new Form2(cp, tam, 6);
            form2.Hide();
            form2.ShowDialog();
            Form4 form4 = new Form4(cp, label6.Text);
            form4.Hide();
            form4.ShowDialog();
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

            dados = cn.obterdados("Select * from produto where Cod_prod = " + 7);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            Form2 form2 = new Form2(cp, tam, 7);
            form2.Hide();
            form2.ShowDialog();

            Form4 form4 = new Form4(cp, label7.Text);
            form4.Hide();
            form4.ShowDialog();
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
            dados = cn.obterdados("Select * from produto where Cod_prod = " + 8);
            cp.preco = float.Parse(dados.Rows[0][2].ToString());

            Form2 form2 = new Form2(cp, tam, 8);
            form2.Hide();
            form2.ShowDialog();

            Form4 form4 = new Form4(cp, label8.Text);
            form4.Hide();
            form4.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HardWare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {

        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {

        }

        private void SaleTimer_Tick(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmHomePrincipal hm = new FrmHomePrincipal();
            this.Hide();
            hm.ShowDialog();
        }

        private void HardWare_Load(object sender, EventArgs e)
        {

        }
    }
}

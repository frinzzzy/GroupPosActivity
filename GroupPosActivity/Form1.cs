using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GroupPosActivity
{
    // The Designer wants Form1 to be the FIRST class in the namespace
    public partial class Form1 : Form
    {
        int burgerCount = 0;

        // This list will hold your grid rows
        BindingList<Product> cartItems = new BindingList<Product>();

        public Form1()
        {
            InitializeComponent();
            whopper.Cursor = Cursors.Hand;

            // Link your list to the data grid
            dataGridView1.DataSource = cartItems;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add a product to the grid when clicked
            cartItems.Add(new Product { Name = "Whopper", Price = 150.00m });

            burgerCount++;
            MessageBox.Show("Done buying");
        }

        private void whopper_MouseEnter(object sender, EventArgs e)
        {
            whopper.Width += 10; whopper.Height += 10;
            whopper.Left -= 5; whopper.Top -= 5;
        }

        private void whopper_MouseLeave(object sender, EventArgs e)
        {
            whopper.Width -= 10; whopper.Height -= 10;
            whopper.Left += 5; whopper.Top += 5;
        }

        // --- Keep your other empty events below ---
        private void Form1_Load(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox12_Click(object sender, EventArgs e) { }
        private void whopperlabel_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void baconking_MouseEnter(object sender, EventArgs e)
        {
            baconking.Width += 10; baconking.Height += 10;
            baconking.Left -= 5; baconking.Top -= 5;
        }

        private void baconking_MouseLeave(object sender, EventArgs e)
        {
            baconking.Width -= 10; baconking.Height -= 10;
            baconking.Left += 5; baconking.Top += 5;
        }

        private void fourcheese_MouseEnter(object sender, EventArgs e)
        {
            fourcheese.Width += 10; fourcheese.Height += 10;
            fourcheese.Left -= 5; fourcheese.Top -= 5;

        }

        private void fourcheese_MouseLeave(object sender, EventArgs e)
        {
            fourcheese.Width -= 10; fourcheese.Height -= 10;
            fourcheese.Left += 5; fourcheese.Top += 5;
        }

        private void nuggets_MouseEnter(object sender, EventArgs e)
        {
            nuggets.Width += 10; nuggets.Height += 10;
            nuggets.Left -= 5; nuggets.Top -= 5;
        }

        private void nuggets_MouseLeave(object sender, EventArgs e)
        {

            nuggets.Width -= 10; nuggets.Height -= 10;
            nuggets.Left += 5; nuggets.Top += 5;
        }

        private void chking_MouseEnter(object sender, EventArgs e)
        {
            chking.Width += 10; chking.Height += 10;
            chking.Left -= 5; chking.Top -= 5;
        }

        private void chking_MouseLeave(object sender, EventArgs e)
        {
            chking.Width -= 10; chking.Height -= 10;
            chking.Left += 5; chking.Top += 5;
        }

        private void stacker_MouseEnter(object sender, EventArgs e)
        {
            stacker.Width += 10; stacker.Height += 10;
            stacker.Left -= 5; stacker.Top -= 5;
        }

        private void stacker_MouseLeave(object sender, EventArgs e)
        {
            stacker.Width -= 10; stacker.Height -= 10;
            stacker.Left += 5; stacker.Top += 5;
        }

        private void plantbased_MouseEnter(object sender, EventArgs e)
        {
            plantbased.Width += 10; plantbased.Height += 10;
            plantbased.Left -= 5; plantbased.Top -= 5;
        }

        private void plantbased_MouseLeave(object sender, EventArgs e)
        {
            plantbased.Width -= 10; plantbased.Height -= 10;
            plantbased.Left += 5; plantbased.Top += 5;
        }

        private void rodeo_MouseEnter(object sender, EventArgs e)
        {
            rodeo.Width += 10; rodeo.Height += 10;
            rodeo.Left -= 5; rodeo.Top -= 5;
        }

        private void rodeo_MouseLeave(object sender, EventArgs e)
        {
            rodeo.Width -= 10; rodeo.Height -= 10;
            rodeo.Left += 5; rodeo.Top += 5;
        }

        private void xtralong_MouseEnter(object sender, EventArgs e)
        {
            xtralong.Width += 10; xtralong.Height += 10;
            xtralong.Left -= 5; xtralong.Top -= 5;
        }

        private void xtralong_MouseLeave(object sender, EventArgs e)
        {

            xtralong.Width -= 10; xtralong.Height -= 10;
            xtralong.Left += 5; xtralong.Top += 5;
        }

        private void bigking_MouseEnter(object sender, EventArgs e)
        {
            bigking.Width += 10; bigking.Height += 10;
            bigking.Left -= 5;  bigking.Top -= 5;
        }
        
        private void bigking_MouseLeave(object sender, EventArgs e)
        {
            bigking.Width -= 10; bigking.Height -= 10;
            bigking.Left += 5; bigking.Top += 5;
        }
    }

    // MOVE THE PRODUCT CLASS HERE (Bottom of the file)
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
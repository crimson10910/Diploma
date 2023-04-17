using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class EditWindow : Form
    {
        int tag = 0;
        string filename = string.Empty;
        string newPath = string.Empty;
        public bool isAvalibleBool(int i)
        {
               if (i == 0)
                return true;
            return false;
        }
        public int isAvalibleInt(bool i)
        {
            if (i == false)
            {
                return 1;
            }
            return 0;
        }

        public EditWindow(int tag)
        {
            InitializeComponent();
            this.Text = SettingsGeneral.Default.ProgrammName + " - Измнение товара";
            openFileDialog.Filter = "Text filter(*.png)|*.png |(*.jpg)|*.jpg|(*.jpеg)|*.jpеg";
            comboBox1.SelectedIndex = 0;
            this.tag = tag;
            using (TestDBContext db = new TestDBContext())
            {
                var output = db.Products.Skip(tag).Take(1);
                foreach (var item in output)
                {
                    textBox1.Text = item.id_Product.ToString();
                    textBox2.Text = item.ProductName.ToString();
                    textBox3.Text = item.ProductPrice.ToString();
                   // comboBox1.SelectedIndex = isAvalibleInt(item.Status);
                    if (item.ProductPicture != null)
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile(item.ProductPicture);
                    }
                    
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                DialogResult dialogerror = MessageBox.Show("Введите данные во все поля!", 
                    "Ошибка заполнения карточки товара", MessageBoxButtons.OK);
                return;
            }
            DialogResult dialog= MessageBox.Show("Сохранить текущие данные?", 
                "Сохранение изменений", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (TestDBContext db = new TestDBContext())
                {
                    var input = db.Products.Skip(tag).Take(1);
                    foreach (var item in input)
                    {
                        item.ProductName = textBox2.Text.ToString();
                        item.ProductPrice = Convert.ToDecimal(textBox3.Text);

                        if (filename != "")
                        {
                            item.ProductPicture = newPath;
                        }
                        //item.Status = isAvalibleBool(comboBox1.SelectedIndex);
                    }
                    db.SaveChanges();

                }
                this.Close();
            }
            else
            {
                return;
            }
                
        }

        private async void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            newPath = "img/" + Convert.ToString(tag) + ".jpg";
            if (System.IO.File.Exists(newPath))
            {
                pictureBox1.Image = Image.FromFile("img/error.jpg");
               
                //System.IO.File.Delete(newPath);
            }
            filename = openFileDialog.FileName;
            pictureBox1.Image = System.Drawing.Image.FromFile(filename);
            
            

            
            pictureBox1.Image.Save(newPath);

        }

        private void defence(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            //Text = textBox.Text;
            e.Handled = true;
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            if (textBox.Text.Contains(',') == false 
                && (textBox.Text != "" && textBox.Text != "-") 
                && e.KeyChar == ',')
            {
                e.Handled = false;
                return;
            }

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
        }
    }
}

//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WinFormsApp1
{
    public partial class NewWindow : Form
    {
        public NewWindow()
        {
            InitializeComponent();
            this.Text = SettingsGeneral.Default.ProgrammName + " - Добавление товара";
            using (TestDBContext db = new TestDBContext())
            {
                count = db.Products.Count();
            }
        }
        string filename = string.Empty;
        string newPath = string.Empty;
        int count = 0;
        

        private void buttonImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            filename = openFileDialog1.FileName;
            pictureBox1.Image = System.Drawing.Image.FromFile(filename);

            newPath = "img/" + Convert.ToString(count) + ".jpg";
            pictureBox1.Image.Save(newPath);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty || textBoxPrice.Text == string.Empty)
            {
                this.Text = "Редактирование - Ошибка!";
                return;
            }
            using (TestDBContext db = new TestDBContext())
            {
                var good = new Product();
                good.id_Product = count;
                good.ProductName = textBoxName.Text;
                good.ProductPrice = Convert.ToInt32(textBoxPrice.Text);
               // good.Status = true;
                if (newPath != string.Empty)
                {
                    good.ProductPicture = newPath;
                }
                else
                {
                    good.ProductPicture = null;
                }
                db.Products.Add(good);

                db.SaveChanges();
            }
            this.Close();
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
            if (textBox.Text.Contains(',') == false && (textBox.Text != "" && textBox.Text != "-") && e.KeyChar == ',')
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

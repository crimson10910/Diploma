namespace WinFormsApp1
{
    partial class NewWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonImg = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(278, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 129);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 14);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 27);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(109, 47);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(163, 27);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.defence);
            // 
            // buttonImg
            // 
            this.buttonImg.Location = new System.Drawing.Point(26, 80);
            this.buttonImg.Name = "buttonImg";
            this.buttonImg.Size = new System.Drawing.Size(246, 29);
            this.buttonImg.TabIndex = 5;
            this.buttonImg.Text = "Изменить изображение";
            this.buttonImg.UseVisualStyleBackColor = true;
            this.buttonImg.Click += new System.EventHandler(this.buttonImg_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(26, 114);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(246, 29);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Готово";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 152);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonImg);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewWindow";
            this.Text = "Добавление товара";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Button buttonImg;
        private Button buttonDone;
        private OpenFileDialog openFileDialog1;
    }
}
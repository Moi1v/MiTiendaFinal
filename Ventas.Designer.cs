namespace MiTienda
{
    partial class Ventas
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
            dataGridViewProducts = new DataGridView();
            ShowProductImage = new PictureBox();
            Total = new Label();
            textBoxSearch = new TextBox();
            buttonConfirmSale = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowProductImage).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 12);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(461, 257);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            // 
            // ShowProductImage
            // 
            ShowProductImage.Image = Properties.Resources.images;
            ShowProductImage.Location = new Point(561, 130);
            ShowProductImage.Name = "ShowProductImage";
            ShowProductImage.Size = new Size(147, 139);
            ShowProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ShowProductImage.TabIndex = 1;
            ShowProductImage.TabStop = false;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.BackColor = SystemColors.ControlDark;
            Total.Location = new Point(12, 272);
            Total.Name = "Total";
            Total.Size = new Size(35, 15);
            Total.TabIndex = 2;
            Total.Text = "Total:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(649, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(100, 23);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged_TextChanged;
            // 
            // buttonConfirmSale
            // 
            buttonConfirmSale.Location = new Point(333, 275);
            buttonConfirmSale.Name = "buttonConfirmSale";
            buttonConfirmSale.Size = new Size(102, 50);
            buttonConfirmSale.TabIndex = 4;
            buttonConfirmSale.Text = "Confirmar";
            buttonConfirmSale.UseVisualStyleBackColor = true;
            buttonConfirmSale.Click += buttonConfirmSale_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar:";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonConfirmSale);
            Controls.Add(textBoxSearch);
            Controls.Add(Total);
            Controls.Add(ShowProductImage);
            Controls.Add(dataGridViewProducts);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private PictureBox ShowProductImage;
        private Label Total;
        private TextBox textBoxSearch;
        private Button buttonConfirmSale;
        private Label label1;
    }
}
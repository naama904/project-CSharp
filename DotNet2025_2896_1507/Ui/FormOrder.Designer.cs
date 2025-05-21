namespace Ui
{
    partial class FormOrder
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
            finishOrder = new Button();
            priceToPay = new Label();
            addProductToOrder = new Button();
            AmountToOrder = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            selectnameProduct = new ComboBox();
            listOrder = new ListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)AmountToOrder).BeginInit();
            SuspendLayout();
            // 
            // finishOrder
            // 
            finishOrder.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            finishOrder.Location = new Point(446, 454);
            finishOrder.Name = "finishOrder";
            finishOrder.Size = new Size(140, 67);
            finishOrder.TabIndex = 15;
            finishOrder.Text = "לסיום הזמנה";
            finishOrder.UseVisualStyleBackColor = true;
            finishOrder.Click += finishOrder_Click;
            // 
            // priceToPay
            // 
            priceToPay.AutoSize = true;
            priceToPay.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            priceToPay.Location = new Point(332, 494);
            priceToPay.Name = "priceToPay";
            priceToPay.Size = new Size(22, 27);
            priceToPay.TabIndex = 14;
            priceToPay.Text = "0";
            // 
            // addProductToOrder
            // 
            addProductToOrder.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addProductToOrder.Location = new Point(878, 390);
            addProductToOrder.Name = "addProductToOrder";
            addProductToOrder.Size = new Size(164, 63);
            addProductToOrder.TabIndex = 13;
            addProductToOrder.Text = "הוספה לסל";
            addProductToOrder.UseVisualStyleBackColor = true;
            addProductToOrder.Click += addProductToOrder_Click;
            // 
            // AmountToOrder
            // 
            AmountToOrder.Location = new Point(689, 318);
            AmountToOrder.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AmountToOrder.Name = "AmountToOrder";
            AmountToOrder.Size = new Size(150, 27);
            AmountToOrder.TabIndex = 12;
            AmountToOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(902, 315);
            label2.Name = "label2";
            label2.Size = new Size(140, 26);
            label2.TabIndex = 10;
            label2.Text = "כמות להזמנה:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(907, 258);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
            label1.TabIndex = 11;
            label1.Text = "בחר שם מוצר";
            // 
            // selectnameProduct
            // 
            selectnameProduct.FormattingEnabled = true;
            selectnameProduct.Location = new Point(689, 260);
            selectnameProduct.Name = "selectnameProduct";
            selectnameProduct.Size = new Size(151, 28);
            selectnameProduct.TabIndex = 9;
            // 
            // listOrder
            // 
            listOrder.FormattingEnabled = true;
            listOrder.HorizontalScrollbar = true;
            listOrder.ItemHeight = 20;
            listOrder.Location = new Point(26, 41);
            listOrder.Name = "listOrder";
            listOrder.ScrollAlwaysVisible = true;
            listOrder.Size = new Size(574, 304);
            listOrder.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(689, 57);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 16;
            label3.Text = "label3";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 539);
            Controls.Add(label3);
            Controls.Add(finishOrder);
            Controls.Add(priceToPay);
            Controls.Add(addProductToOrder);
            Controls.Add(AmountToOrder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selectnameProduct);
            Controls.Add(listOrder);
            Name = "FormOrder";
            RightToLeft = RightToLeft.Yes;
            Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)AmountToOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button finishOrder;
        private Label priceToPay;
        private Button addProductToOrder;
        private NumericUpDown AmountToOrder;
        private Label label2;
        private Label label1;
        private ComboBox selectnameProduct;
        private ListBox listOrder;
        private Label label3;
    }
}
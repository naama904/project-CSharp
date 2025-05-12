namespace Ui
{
    partial class finiishOrder
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
            listOrder = new ListBox();
            selectnameProduct = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            AmountToOrder = new NumericUpDown();
            addProductToOrder = new Button();
            priceToPay = new Label();
            finishOrder = new Button();
            label3 = new Label();
            identity = new TextBox();
            witchCustomer = new Label();
            ((System.ComponentModel.ISupportInitialize)AmountToOrder).BeginInit();
            SuspendLayout();
            // 
            // listOrder
            // 
            listOrder.FormattingEnabled = true;
            listOrder.HorizontalScrollbar = true;
            listOrder.ItemHeight = 20;
            listOrder.Location = new Point(12, 12);
            listOrder.Name = "listOrder";
            listOrder.ScrollAlwaysVisible = true;
            listOrder.Size = new Size(574, 304);
            listOrder.TabIndex = 0;
            // 
            // selectnameProduct
            // 
            selectnameProduct.FormattingEnabled = true;
            selectnameProduct.Location = new Point(689, 123);
            selectnameProduct.Name = "selectnameProduct";
            selectnameProduct.Size = new Size(151, 28);
            selectnameProduct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(907, 121);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
            label1.TabIndex = 3;
            label1.Text = "בחר שם מוצר";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(902, 178);
            label2.Name = "label2";
            label2.Size = new Size(140, 26);
            label2.TabIndex = 3;
            label2.Text = "כמות להזמנה:";
            // 
            // AmountToOrder
            // 
            AmountToOrder.Location = new Point(689, 181);
            AmountToOrder.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AmountToOrder.Name = "AmountToOrder";
            AmountToOrder.Size = new Size(150, 27);
            AmountToOrder.TabIndex = 4;
            AmountToOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addProductToOrder
            // 
            addProductToOrder.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addProductToOrder.Location = new Point(878, 253);
            addProductToOrder.Name = "addProductToOrder";
            addProductToOrder.Size = new Size(164, 63);
            addProductToOrder.TabIndex = 5;
            addProductToOrder.Text = "הוספה לסל";
            addProductToOrder.UseVisualStyleBackColor = true;
            addProductToOrder.Click += addProductToOrder_Click;
            // 
            // priceToPay
            // 
            priceToPay.AutoSize = true;
            priceToPay.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            priceToPay.Location = new Point(332, 469);
            priceToPay.Name = "priceToPay";
            priceToPay.Size = new Size(22, 27);
            priceToPay.TabIndex = 6;
            priceToPay.Text = "0";
            // 
            // finishOrder
            // 
            finishOrder.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            finishOrder.Location = new Point(446, 429);
            finishOrder.Name = "finishOrder";
            finishOrder.Size = new Size(140, 67);
            finishOrder.TabIndex = 7;
            finishOrder.Text = "לסיום הזמנה";
            finishOrder.UseVisualStyleBackColor = true;
            finishOrder.Click += finishOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(890, 67);
            label3.Name = "label3";
            label3.Size = new Size(152, 26);
            label3.TabIndex = 3;
            label3.Text = "הכנס ת\"ז לקוח:";
            // 
            // identity
            // 
            identity.Location = new Point(689, 66);
            identity.Name = "identity";
            identity.Size = new Size(150, 27);
            identity.TabIndex = 8;
            identity.TextChanged += identity_TextChanged;
            // 
            // witchCustomer
            // 
            witchCustomer.AutoSize = true;
            witchCustomer.Location = new Point(689, 22);
            witchCustomer.Name = "witchCustomer";
            witchCustomer.Size = new Size(0, 20);
            witchCustomer.TabIndex = 9;
            // 
            // finiishOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 539);
            Controls.Add(witchCustomer);
            Controls.Add(identity);
            Controls.Add(finishOrder);
            Controls.Add(priceToPay);
            Controls.Add(addProductToOrder);
            Controls.Add(AmountToOrder);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(selectnameProduct);
            Controls.Add(listOrder);
            Name = "finiishOrder";
            RightToLeft = RightToLeft.Yes;
            Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)AmountToOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listOrder;
        private ComboBox selectnameProduct;
        private Label label1;
        private Label label2;
        private NumericUpDown AmountToOrder;
        private Button addProductToOrder;
        private Label priceToPay;
        private Button finishOrder;
        private Label label3;
        private TextBox identity;
        private Label witchCustomer;
    }
}
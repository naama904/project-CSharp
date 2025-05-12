namespace Ui
{
    partial class FormProduct
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            quentity = new NumericUpDown();
            price = new NumericUpDown();
            buttonKeep = new Button();
            labelQuntity = new Label();
            labelCategory = new Label();
            label2 = new Label();
            labelName = new Label();
            name = new TextBox();
            category = new ComboBox();
            tabPage2 = new TabPage();
            readOneProduct = new ComboBox();
            label9 = new Label();
            buttonReadOne = new Button();
            buttonReadByParam = new Button();
            buttonReadAll = new Button();
            listProduct = new ListBox();
            tabPage4 = new TabPage();
            selectNameProduct = new ComboBox();
            quentityToUpdate = new NumericUpDown();
            priceToUpdate = new NumericUpDown();
            save = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            nameToUpdate = new TextBox();
            categoryToUpdate = new ComboBox();
            label1 = new Label();
            tabPage5 = new TabPage();
            selectedProduct = new ComboBox();
            buttonDelete = new Button();
            label3 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quentity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quentityToUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceToUpdate).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(207, 104);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(724, 484);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(quentity);
            tabPage1.Controls.Add(price);
            tabPage1.Controls.Add(buttonKeep);
            tabPage1.Controls.Add(labelQuntity);
            tabPage1.Controls.Add(labelCategory);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(labelName);
            tabPage1.Controls.Add(name);
            tabPage1.Controls.Add(category);
            tabPage1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.ForeColor = SystemColors.WindowFrame;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(714, 456);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // quentity
            // 
            quentity.Location = new Point(191, 245);
            quentity.Name = "quentity";
            quentity.Size = new Size(208, 38);
            quentity.TabIndex = 4;
            // 
            // price
            // 
            price.Location = new Point(191, 196);
            price.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            price.Name = "price";
            price.Size = new Size(208, 38);
            price.TabIndex = 4;
            // 
            // buttonKeep
            // 
            buttonKeep.Location = new Point(191, 305);
            buttonKeep.Name = "buttonKeep";
            buttonKeep.Size = new Size(134, 38);
            buttonKeep.TabIndex = 3;
            buttonKeep.Text = "שמירה";
            buttonKeep.UseVisualStyleBackColor = true;
            buttonKeep.Click += buttonKeep_Click;
            // 
            // labelQuntity
            // 
            labelQuntity.AutoSize = true;
            labelQuntity.Location = new Point(418, 245);
            labelQuntity.Name = "labelQuntity";
            labelQuntity.Size = new Size(142, 31);
            labelQuntity.TabIndex = 2;
            labelQuntity.Text = "כמות במלאי:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(458, 147);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(102, 31);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "קטגוריה:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 198);
            label2.Name = "label2";
            label2.Size = new Size(71, 31);
            label2.TabIndex = 2;
            label2.Text = "מחיר:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(506, 102);
            labelName.Name = "labelName";
            labelName.Size = new Size(54, 31);
            labelName.TabIndex = 2;
            labelName.Text = "שם:";
            // 
            // name
            // 
            name.Location = new Point(191, 99);
            name.Name = "name";
            name.Size = new Size(208, 38);
            name.TabIndex = 1;
            // 
            // category
            // 
            category.DropDownStyle = ComboBoxStyle.DropDownList;
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "בגדים", "שמיכות_וכובעים", "בקבוקים_ומוצצים", "עגלות", "צמידים_ועגילים" });
            category.Location = new Point(191, 147);
            category.Name = "category";
            category.Size = new Size(208, 39);
            category.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(readOneProduct);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(buttonReadOne);
            tabPage2.Controls.Add(buttonReadByParam);
            tabPage2.Controls.Add(buttonReadAll);
            tabPage2.Controls.Add(listProduct);
            tabPage2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.ForeColor = SystemColors.WindowFrame;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(716, 451);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "תצוגה";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // readOneProduct
            // 
            readOneProduct.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            readOneProduct.FormattingEnabled = true;
            readOneProduct.Location = new Point(502, 311);
            readOneProduct.Name = "readOneProduct";
            readOneProduct.Size = new Size(208, 29);
            readOneProduct.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(500, 258);
            label9.Name = "label9";
            label9.Size = new Size(199, 27);
            label9.TabIndex = 4;
            label9.Text = "בחר שם מוצר להצגה:";
            // 
            // buttonReadOne
            // 
            buttonReadOne.Location = new Point(502, 369);
            buttonReadOne.Name = "buttonReadOne";
            buttonReadOne.Size = new Size(168, 60);
            buttonReadOne.TabIndex = 3;
            buttonReadOne.Text = "הצגת מוצר זה";
            buttonReadOne.UseVisualStyleBackColor = true;
            buttonReadOne.Click += buttonReadOne_Click;
            // 
            // buttonReadByParam
            // 
            buttonReadByParam.Location = new Point(502, 144);
            buttonReadByParam.Name = "buttonReadByParam";
            buttonReadByParam.Size = new Size(189, 71);
            buttonReadByParam.TabIndex = 2;
            buttonReadByParam.Text = "מוצרים שמכירם עד 100 ש\"ח";
            buttonReadByParam.UseVisualStyleBackColor = true;
            buttonReadByParam.Click += buttonReadByParam_Click;
            // 
            // buttonReadAll
            // 
            buttonReadAll.Location = new Point(502, 19);
            buttonReadAll.Name = "buttonReadAll";
            buttonReadAll.Size = new Size(189, 71);
            buttonReadAll.TabIndex = 1;
            buttonReadAll.Text = "להצגת המוצרים במלאי";
            buttonReadAll.UseVisualStyleBackColor = true;
            buttonReadAll.Click += buttonReadAll_Click;
            // 
            // listProduct
            // 
            listProduct.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listProduct.FormattingEnabled = true;
            listProduct.ItemHeight = 22;
            listProduct.Location = new Point(19, 19);
            listProduct.Name = "listProduct";
            listProduct.Size = new Size(468, 422);
            listProduct.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(selectNameProduct);
            tabPage4.Controls.Add(quentityToUpdate);
            tabPage4.Controls.Add(priceToUpdate);
            tabPage4.Controls.Add(save);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(nameToUpdate);
            tabPage4.Controls.Add(categoryToUpdate);
            tabPage4.Controls.Add(label1);
            tabPage4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(714, 456);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "עריכה";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // selectNameProduct
            // 
            selectNameProduct.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectNameProduct.FormattingEnabled = true;
            selectNameProduct.Location = new Point(111, 48);
            selectNameProduct.Name = "selectNameProduct";
            selectNameProduct.Size = new Size(203, 29);
            selectNameProduct.TabIndex = 14;
            // 
            // quentityToUpdate
            // 
            quentityToUpdate.Location = new Point(111, 236);
            quentityToUpdate.Name = "quentityToUpdate";
            quentityToUpdate.Size = new Size(208, 38);
            quentityToUpdate.TabIndex = 12;
            // 
            // priceToUpdate
            // 
            priceToUpdate.Location = new Point(111, 187);
            priceToUpdate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceToUpdate.Name = "priceToUpdate";
            priceToUpdate.Size = new Size(208, 38);
            priceToUpdate.TabIndex = 13;
            // 
            // save
            // 
            save.Location = new Point(111, 296);
            save.Name = "save";
            save.Size = new Size(134, 38);
            save.TabIndex = 11;
            save.Text = "שמירה";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 236);
            label5.Name = "label5";
            label5.Size = new Size(142, 31);
            label5.TabIndex = 7;
            label5.Text = "כמות במלאי:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(378, 138);
            label6.Name = "label6";
            label6.Size = new Size(102, 31);
            label6.TabIndex = 8;
            label6.Text = "קטגוריה:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(409, 189);
            label7.Name = "label7";
            label7.Size = new Size(71, 31);
            label7.TabIndex = 9;
            label7.Text = "מחיר:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 93);
            label8.Name = "label8";
            label8.Size = new Size(54, 31);
            label8.TabIndex = 10;
            label8.Text = "שם:";
            // 
            // nameToUpdate
            // 
            nameToUpdate.Location = new Point(111, 90);
            nameToUpdate.Name = "nameToUpdate";
            nameToUpdate.Size = new Size(208, 38);
            nameToUpdate.TabIndex = 6;
            // 
            // categoryToUpdate
            // 
            categoryToUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryToUpdate.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            categoryToUpdate.FormattingEnabled = true;
            categoryToUpdate.Items.AddRange(new object[] { "בגדים", "שמיכות וכובעים", "בקבוקים ומוצצים", "עגלות", "צמידים ועגילים" });
            categoryToUpdate.Location = new Point(111, 143);
            categoryToUpdate.Name = "categoryToUpdate";
            categoryToUpdate.Size = new Size(208, 29);
            categoryToUpdate.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 46);
            label1.Name = "label1";
            label1.Size = new Size(173, 31);
            label1.TabIndex = 0;
            label1.Text = "הכנס קוד מוצר :";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(selectedProduct);
            tabPage5.Controls.Add(buttonDelete);
            tabPage5.Controls.Add(label3);
            tabPage5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(714, 456);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "מחיקה";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // selectedProduct
            // 
            selectedProduct.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectedProduct.FormattingEnabled = true;
            selectedProduct.Location = new Point(125, 62);
            selectedProduct.Name = "selectedProduct";
            selectedProduct.Size = new Size(203, 29);
            selectedProduct.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(125, 202);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(113, 48);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "מחיקה";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 53);
            label3.Name = "label3";
            label3.Size = new Size(260, 31);
            label3.TabIndex = 1;
            label3.Text = "הכנס שם מוצר למחיקה :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(500, 41);
            label4.Name = "label4";
            label4.Size = new Size(198, 72);
            label4.TabIndex = 3;
            label4.Text = "מוצרים";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 626);
            Controls.Add(label4);
            Controls.Add(tabControl1);
            Name = "FormProduct";
            Text = "FormProduct";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quentity).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quentityToUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceToUpdate).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private ComboBox category;
        private TextBox name;
        private Label labelName;
        private Label labelQuntity;
        private Label labelCategory;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button buttonKeep;
        private NumericUpDown price;
        private NumericUpDown quentity;
        private Button buttonDelete;
        private NumericUpDown quentityToUpdate;
        private NumericUpDown priceToUpdate;
        private Button save;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox nameToUpdate;
        private ComboBox categoryToUpdate;
        private ListBox listProduct;
        private Button buttonReadAll;
        private Button buttonReadByParam;
        private Label label9;
        private Button buttonReadOne;
        private ComboBox selectedProduct;
        private ComboBox readOneProduct;
        private ComboBox selectNameProduct;
    }
}
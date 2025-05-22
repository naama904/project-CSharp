namespace Ui
{
    partial class FormSale
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
            selectProductToSale = new ComboBox();
            friandClub = new RadioButton();
            buttonSaveSale = new Button();
            allCustomer = new RadioButton();
            dateEnd = new DateTimePicker();
            labelQuntity = new Label();
            dateStart = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            labelName = new Label();
            label10 = new Label();
            amountToGetSale = new TextBox();
            label14 = new Label();
            priceInSale = new TextBox();
            tabPage2 = new TabPage();
            selectProductReadSale = new ComboBox();
            label9 = new Label();
            buttonReadOneS = new Button();
            buttonReadByParamS = new Button();
            buttonReadAllS = new Button();
            listSale = new ListBox();
            tabPage4 = new TabPage();
            sumPriceSale = new NumericUpDown();
            acountToGetSale = new NumericUpDown();
            selectSaleToUpdate = new ComboBox();
            saleClubCustomer = new RadioButton();
            saleAllCustomer = new RadioButton();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            buttonSaveS = new Button();
            label5 = new Label();
            productToSale = new TextBox();
            label6 = new Label();
            label13 = new Label();
            label7 = new Label();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            tabPage5 = new TabPage();
            selectSaleToDeleteSale = new ComboBox();
            buttonDeleteD = new Button();
            label3 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sumPriceSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acountToGetSale).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(131, 107);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(810, 486);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(selectProductToSale);
            tabPage1.Controls.Add(friandClub);
            tabPage1.Controls.Add(buttonSaveSale);
            tabPage1.Controls.Add(allCustomer);
            tabPage1.Controls.Add(dateEnd);
            tabPage1.Controls.Add(labelQuntity);
            tabPage1.Controls.Add(dateStart);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(labelName);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(amountToGetSale);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(priceInSale);
            tabPage1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.ForeColor = SystemColors.WindowFrame;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(802, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // selectProductToSale
            // 
            selectProductToSale.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectProductToSale.FormattingEnabled = true;
            selectProductToSale.Location = new Point(28, 20);
            selectProductToSale.Name = "selectProductToSale";
            selectProductToSale.Size = new Size(207, 29);
            selectProductToSale.TabIndex = 28;
            // 
            // friandClub
            // 
            friandClub.AutoSize = true;
            friandClub.Location = new Point(28, 186);
            friandClub.Name = "friandClub";
            friandClub.Size = new Size(150, 35);
            friandClub.TabIndex = 26;
            friandClub.TabStop = true;
            friandClub.Text = "חברי מועדון";
            friandClub.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSale
            // 
            buttonSaveSale.Location = new Point(27, 321);
            buttonSaveSale.Name = "buttonSaveSale";
            buttonSaveSale.Size = new Size(134, 38);
            buttonSaveSale.TabIndex = 3;
            buttonSaveSale.Text = "שמירה";
            buttonSaveSale.UseVisualStyleBackColor = true;
            buttonSaveSale.Click += buttonSaveSale_Click;
            // 
            // allCustomer
            // 
            allCustomer.AutoSize = true;
            allCustomer.Location = new Point(212, 186);
            allCustomer.Name = "allCustomer";
            allCustomer.Size = new Size(168, 35);
            allCustomer.TabIndex = 27;
            allCustomer.TabStop = true;
            allCustomer.Text = "כלל הלקוחות";
            allCustomer.UseVisualStyleBackColor = true;
            // 
            // dateEnd
            // 
            dateEnd.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateEnd.Location = new Point(56, 267);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(250, 28);
            dateEnd.TabIndex = 25;
            // 
            // labelQuntity
            // 
            labelQuntity.AutoSize = true;
            labelQuntity.Location = new Point(415, 115);
            labelQuntity.Name = "labelQuntity";
            labelQuntity.Size = new Size(164, 31);
            labelQuntity.TabIndex = 2;
            labelQuntity.Text = "המחיר במבצע:";
            // 
            // dateStart
            // 
            dateStart.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateStart.Location = new Point(329, 267);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(250, 28);
            dateStart.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 71);
            label2.Name = "label2";
            label2.Size = new Size(228, 31);
            label2.TabIndex = 2;
            label2.Text = "כמות לקבלת המבצע:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 233);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 21;
            label1.Text = "תאריך סיום המבצע:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(395, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(185, 31);
            labelName.TabIndex = 2;
            labelName.Text = "שם מוצר למבצע:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(333, 233);
            label10.Name = "label10";
            label10.Size = new Size(246, 31);
            label10.TabIndex = 22;
            label10.Text = "תאריך התחלת המבצע:";
            // 
            // amountToGetSale
            // 
            amountToGetSale.Location = new Point(27, 71);
            amountToGetSale.Name = "amountToGetSale";
            amountToGetSale.Size = new Size(208, 38);
            amountToGetSale.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(386, 186);
            label14.Name = "label14";
            label14.Size = new Size(193, 31);
            label14.TabIndex = 23;
            label14.Text = "למי המבצע מיועד:";
            // 
            // priceInSale
            // 
            priceInSale.Location = new Point(27, 123);
            priceInSale.Name = "priceInSale";
            priceInSale.Size = new Size(208, 38);
            priceInSale.TabIndex = 1;
            priceInSale.TextChanged += priceInSale_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(selectProductReadSale);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(buttonReadOneS);
            tabPage2.Controls.Add(buttonReadByParamS);
            tabPage2.Controls.Add(buttonReadAllS);
            tabPage2.Controls.Add(listSale);
            tabPage2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.ForeColor = SystemColors.WindowFrame;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(802, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "תצוגה";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectProductReadSale
            // 
            selectProductReadSale.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectProductReadSale.FormattingEnabled = true;
            selectProductReadSale.Location = new Point(527, 280);
            selectProductReadSale.Name = "selectProductReadSale";
            selectProductReadSale.Size = new Size(202, 29);
            selectProductReadSale.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(527, 227);
            label9.Name = "label9";
            label9.Size = new Size(267, 27);
            label9.TabIndex = 4;
            label9.Text = "בחר שם מוצר להצגת המבצע:";
            // 
            // buttonReadOneS
            // 
            buttonReadOneS.Location = new Point(527, 346);
            buttonReadOneS.Name = "buttonReadOneS";
            buttonReadOneS.Size = new Size(202, 60);
            buttonReadOneS.TabIndex = 3;
            buttonReadOneS.Text = "הצגת מבצע זה";
            buttonReadOneS.UseVisualStyleBackColor = true;
            buttonReadOneS.Click += buttonReadOneS_Click;
            // 
            // buttonReadByParamS
            // 
            buttonReadByParamS.Location = new Point(527, 114);
            buttonReadByParamS.Name = "buttonReadByParamS";
            buttonReadByParamS.Size = new Size(202, 71);
            buttonReadByParamS.TabIndex = 2;
            buttonReadByParamS.Text = "מבצעים ללקוחות ללא מועדון";
            buttonReadByParamS.UseVisualStyleBackColor = true;
            buttonReadByParamS.Click += buttonReadByParamS_Click;
            // 
            // buttonReadAllS
            // 
            buttonReadAllS.Location = new Point(527, 37);
            buttonReadAllS.Name = "buttonReadAllS";
            buttonReadAllS.Size = new Size(202, 71);
            buttonReadAllS.TabIndex = 1;
            buttonReadAllS.Text = "להצגת המבצעים:";
            buttonReadAllS.UseVisualStyleBackColor = true;
            buttonReadAllS.Click += buttonReadAllS_Click;
            // 
            // listSale
            // 
            listSale.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listSale.FormattingEnabled = true;
            listSale.ItemHeight = 21;
            listSale.Location = new Point(19, 19);
            listSale.Name = "listSale";
            listSale.RightToLeft = RightToLeft.No;
            listSale.Size = new Size(502, 424);
            listSale.TabIndex = 0;
            listSale.SelectedIndexChanged += listSale_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(sumPriceSale);
            tabPage4.Controls.Add(acountToGetSale);
            tabPage4.Controls.Add(selectSaleToUpdate);
            tabPage4.Controls.Add(saleClubCustomer);
            tabPage4.Controls.Add(saleAllCustomer);
            tabPage4.Controls.Add(dateTimePickerEnd);
            tabPage4.Controls.Add(dateTimePickerStart);
            tabPage4.Controls.Add(buttonSaveS);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(productToSale);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label11);
            tabPage4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(802, 453);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "עריכה";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // sumPriceSale
            // 
            sumPriceSale.ForeColor = SystemColors.WindowFrame;
            sumPriceSale.Location = new Point(16, 182);
            sumPriceSale.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            sumPriceSale.Name = "sumPriceSale";
            sumPriceSale.Size = new Size(208, 38);
            sumPriceSale.TabIndex = 24;
            // 
            // acountToGetSale
            // 
            acountToGetSale.ForeColor = SystemColors.WindowFrame;
            acountToGetSale.Location = new Point(16, 129);
            acountToGetSale.Name = "acountToGetSale";
            acountToGetSale.Size = new Size(208, 38);
            acountToGetSale.TabIndex = 23;
            // 
            // selectSaleToUpdate
            // 
            selectSaleToUpdate.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectSaleToUpdate.FormattingEnabled = true;
            selectSaleToUpdate.Location = new Point(16, 31);
            selectSaleToUpdate.Name = "selectSaleToUpdate";
            selectSaleToUpdate.Size = new Size(208, 29);
            selectSaleToUpdate.TabIndex = 22;
            selectSaleToUpdate.SelectedIndexChanged += selectSaleToUpdate_SelectedIndexChanged;
            // 
            // saleClubCustomer
            // 
            saleClubCustomer.AutoSize = true;
            saleClubCustomer.ForeColor = SystemColors.WindowFrame;
            saleClubCustomer.Location = new Point(64, 213);
            saleClubCustomer.Name = "saleClubCustomer";
            saleClubCustomer.Size = new Size(150, 35);
            saleClubCustomer.TabIndex = 20;
            saleClubCustomer.TabStop = true;
            saleClubCustomer.Text = "חברי מועדון";
            saleClubCustomer.UseVisualStyleBackColor = true;
            // 
            // saleAllCustomer
            // 
            saleAllCustomer.AutoSize = true;
            saleAllCustomer.ForeColor = SystemColors.WindowFrame;
            saleAllCustomer.Location = new Point(248, 213);
            saleAllCustomer.Name = "saleAllCustomer";
            saleAllCustomer.Size = new Size(168, 35);
            saleAllCustomer.TabIndex = 20;
            saleAllCustomer.TabStop = true;
            saleAllCustomer.Text = "כלל הלקוחות";
            saleAllCustomer.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(92, 294);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 28);
            dateTimePickerEnd.TabIndex = 19;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(365, 294);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 28);
            dateTimePickerStart.TabIndex = 18;
            // 
            // buttonSaveS
            // 
            buttonSaveS.Location = new Point(16, 362);
            buttonSaveS.Name = "buttonSaveS";
            buttonSaveS.Size = new Size(134, 38);
            buttonSaveS.TabIndex = 16;
            buttonSaveS.Text = "שמירה";
            buttonSaveS.UseVisualStyleBackColor = true;
            buttonSaveS.Click += buttonSaveS_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(138, 260);
            label5.Name = "label5";
            label5.Size = new Size(213, 31);
            label5.TabIndex = 11;
            label5.Text = "תאריך סיום המבצע:";
            // 
            // productToSale
            // 
            productToSale.Location = new Point(16, 77);
            productToSale.Name = "productToSale";
            productToSale.Size = new Size(208, 38);
            productToSale.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.WindowFrame;
            label6.Location = new Point(369, 260);
            label6.Name = "label6";
            label6.Size = new Size(246, 31);
            label6.TabIndex = 12;
            label6.Text = "תאריך התחלת המבצע:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.WindowFrame;
            label13.Location = new Point(422, 213);
            label13.Name = "label13";
            label13.Size = new Size(193, 31);
            label13.TabIndex = 13;
            label13.Text = "למי המבצע מיועד:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.WindowFrame;
            label7.Location = new Point(451, 157);
            label7.Name = "label7";
            label7.Size = new Size(164, 31);
            label7.TabIndex = 13;
            label7.Text = "המחיר במבצע:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.WindowFrame;
            label12.Location = new Point(431, 26);
            label12.Name = "label12";
            label12.Size = new Size(187, 31);
            label12.TabIndex = 15;
            label12.Text = "קוד מבצע לעדכון:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(387, 113);
            label8.Name = "label8";
            label8.Size = new Size(228, 31);
            label8.TabIndex = 14;
            label8.Text = "כמות לקבלת המבצע:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.WindowFrame;
            label11.Location = new Point(431, 70);
            label11.Name = "label11";
            label11.Size = new Size(151, 31);
            label11.TabIndex = 15;
            label11.Text = " מוצר למבצע:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(selectSaleToDeleteSale);
            tabPage5.Controls.Add(buttonDeleteD);
            tabPage5.Controls.Add(label3);
            tabPage5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(802, 453);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "מחיקה";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // selectSaleToDeleteSale
            // 
            selectSaleToDeleteSale.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectSaleToDeleteSale.ForeColor = SystemColors.WindowFrame;
            selectSaleToDeleteSale.FormattingEnabled = true;
            selectSaleToDeleteSale.Location = new Point(35, 53);
            selectSaleToDeleteSale.Name = "selectSaleToDeleteSale";
            selectSaleToDeleteSale.Size = new Size(201, 29);
            selectSaleToDeleteSale.TabIndex = 4;
            // 
            // buttonDeleteD
            // 
            buttonDeleteD.ForeColor = SystemColors.WindowFrame;
            buttonDeleteD.Location = new Point(35, 299);
            buttonDeleteD.Name = "buttonDeleteD";
            buttonDeleteD.Size = new Size(113, 48);
            buttonDeleteD.TabIndex = 3;
            buttonDeleteD.Text = "מחיקה";
            buttonDeleteD.UseVisualStyleBackColor = true;
            buttonDeleteD.Click += buttonDeleteD_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(251, 51);
            label3.Name = "label3";
            label3.Size = new Size(353, 31);
            label3.TabIndex = 1;
            label3.Text = "בחר שם מוצר לביטול המבצע שלו:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(456, 32);
            label4.Name = "label4";
            label4.Size = new Size(217, 72);
            label4.TabIndex = 5;
            label4.Text = "מבצעים";
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 626);
            Controls.Add(label4);
            Controls.Add(tabControl1);
            Name = "FormSale";
            Text = "FormSale";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sumPriceSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)acountToGetSale).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonSaveSale;
        private Label labelQuntity;
        private Label labelCategory;
        private Label label2;
        private Label labelName;
        private TextBox phone;
        private TextBox nameCustomer;
        private TextBox address;
        private TabPage tabPage2;
        private Label label9;
        private Button buttonReadOneS;
        private Button buttonReadByParamS;
        private Button buttonReadAllS;
        private ListBox listSale;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button buttonDeleteD;
        private Label label3;
        private Label label4;
        private TextBox amountToGetSale;
        private TextBox priceInSale;
        private Button buttonSaveS;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private RadioButton saleClubCustomer;
        private RadioButton saleAllCustomer;
        private Label label13;
        private RadioButton friandClub;
        private RadioButton allCustomer;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Label label1;
        private Label label10;
        private Label label14;
        private ComboBox selectSaleToDeleteSale;
        private ComboBox selectProductToSale;
        private ComboBox selectProductReadSale;
        private ComboBox selectSaleToUpdate;
        private TextBox productToSale;
        private NumericUpDown sumPriceSale;
        private NumericUpDown acountToGetSale;
    }
}
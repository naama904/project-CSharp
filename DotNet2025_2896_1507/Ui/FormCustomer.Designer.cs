namespace Ui
{
    partial class FormCustomer
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
            buttonSaveCustomer = new Button();
            labelQuntity = new Label();
            labelCategory = new Label();
            label2 = new Label();
            labelName = new Label();
            phone = new TextBox();
            nameCustomer = new TextBox();
            address = new TextBox();
            identity = new TextBox();
            tabPage2 = new TabPage();
            selectIdentity = new ComboBox();
            label9 = new Label();
            buttonReadOneC = new Button();
            buttonReadByParamC = new Button();
            buttonReadAllC = new Button();
            listCustomer = new ListBox();
            tabPage4 = new TabPage();
            selectCustomerUpdate = new ComboBox();
            buttonSaveUpdate = new Button();
            phoneToUpdate = new TextBox();
            nameToUpdate = new TextBox();
            addressToUpdate = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tabPage5 = new TabPage();
            selectCustomer = new ComboBox();
            buttonDeleteC = new Button();
            label3 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(190, 112);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(722, 489);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonSaveCustomer);
            tabPage1.Controls.Add(labelQuntity);
            tabPage1.Controls.Add(labelCategory);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(labelName);
            tabPage1.Controls.Add(phone);
            tabPage1.Controls.Add(nameCustomer);
            tabPage1.Controls.Add(address);
            tabPage1.Controls.Add(identity);
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
            // buttonSaveCustomer
            // 
            buttonSaveCustomer.Location = new Point(84, 272);
            buttonSaveCustomer.Name = "buttonSaveCustomer";
            buttonSaveCustomer.Size = new Size(134, 38);
            buttonSaveCustomer.TabIndex = 3;
            buttonSaveCustomer.Text = "שמירה";
            buttonSaveCustomer.UseVisualStyleBackColor = true;
            buttonSaveCustomer.Click += buttonSaveCustomer_Click;
            // 
            // labelQuntity
            // 
            labelQuntity.AutoSize = true;
            labelQuntity.Location = new Point(396, 203);
            labelQuntity.Name = "labelQuntity";
            labelQuntity.Size = new Size(76, 31);
            labelQuntity.TabIndex = 2;
            labelQuntity.Text = "טלפון:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(417, 58);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(55, 31);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "ת\"ז:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 150);
            label2.Name = "label2";
            label2.Size = new Size(87, 31);
            label2.TabIndex = 2;
            label2.Text = "כתובת:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(418, 105);
            labelName.Name = "labelName";
            labelName.Size = new Size(54, 31);
            labelName.TabIndex = 2;
            labelName.Text = "שם:";
            // 
            // phone
            // 
            phone.Location = new Point(84, 200);
            phone.Name = "phone";
            phone.Size = new Size(208, 38);
            phone.TabIndex = 1;
            // 
            // nameCustomer
            // 
            nameCustomer.Location = new Point(84, 105);
            nameCustomer.Name = "nameCustomer";
            nameCustomer.Size = new Size(208, 38);
            nameCustomer.TabIndex = 1;
            // 
            // address
            // 
            address.Location = new Point(84, 150);
            address.Name = "address";
            address.Size = new Size(208, 38);
            address.TabIndex = 1;
            // 
            // identity
            // 
            identity.Location = new Point(84, 55);
            identity.Name = "identity";
            identity.Size = new Size(208, 38);
            identity.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(selectIdentity);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(buttonReadOneC);
            tabPage2.Controls.Add(buttonReadByParamC);
            tabPage2.Controls.Add(buttonReadAllC);
            tabPage2.Controls.Add(listCustomer);
            tabPage2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.ForeColor = SystemColors.WindowFrame;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(714, 456);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "תצוגה";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectIdentity
            // 
            selectIdentity.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectIdentity.FormattingEnabled = true;
            selectIdentity.Location = new Point(506, 276);
            selectIdentity.Name = "selectIdentity";
            selectIdentity.Size = new Size(189, 29);
            selectIdentity.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB Demi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(491, 231);
            label9.Name = "label9";
            label9.Size = new Size(211, 27);
            label9.TabIndex = 4;
            label9.Text = "הכנס ת\"ז לקוח להצגה:";
            // 
            // buttonReadOneC
            // 
            buttonReadOneC.Location = new Point(506, 355);
            buttonReadOneC.Name = "buttonReadOneC";
            buttonReadOneC.Size = new Size(168, 60);
            buttonReadOneC.TabIndex = 3;
            buttonReadOneC.Text = "הצגת לקוח זה";
            buttonReadOneC.UseVisualStyleBackColor = true;
            buttonReadOneC.Click += buttonReadOneC_Click;
            // 
            // buttonReadByParamC
            // 
            buttonReadByParamC.Location = new Point(506, 124);
            buttonReadByParamC.Name = "buttonReadByParamC";
            buttonReadByParamC.Size = new Size(189, 71);
            buttonReadByParamC.TabIndex = 2;
            buttonReadByParamC.Text = "לקוחות הגרים במודיעין עילית";
            buttonReadByParamC.UseVisualStyleBackColor = true;
            buttonReadByParamC.Click += buttonReadByParamC_Click;
            // 
            // buttonReadAllC
            // 
            buttonReadAllC.Location = new Point(506, 19);
            buttonReadAllC.Name = "buttonReadAllC";
            buttonReadAllC.Size = new Size(189, 71);
            buttonReadAllC.TabIndex = 1;
            buttonReadAllC.Text = "להצגת הלקוחות המנויים";
            buttonReadAllC.UseVisualStyleBackColor = true;
            buttonReadAllC.Click += buttonReadAllC_Click;
            // 
            // listCustomer
            // 
            listCustomer.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listCustomer.FormattingEnabled = true;
            listCustomer.ItemHeight = 21;
            listCustomer.Location = new Point(19, 19);
            listCustomer.Name = "listCustomer";
            listCustomer.Size = new Size(466, 424);
            listCustomer.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(selectCustomerUpdate);
            tabPage4.Controls.Add(buttonSaveUpdate);
            tabPage4.Controls.Add(phoneToUpdate);
            tabPage4.Controls.Add(nameToUpdate);
            tabPage4.Controls.Add(addressToUpdate);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label8);
            tabPage4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(714, 456);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "עריכה";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // selectCustomerUpdate
            // 
            selectCustomerUpdate.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectCustomerUpdate.FormattingEnabled = true;
            selectCustomerUpdate.Location = new Point(111, 84);
            selectCustomerUpdate.Name = "selectCustomerUpdate";
            selectCustomerUpdate.Size = new Size(208, 29);
            selectCustomerUpdate.TabIndex = 16;
            selectCustomerUpdate.SelectedIndexChanged += selectCustomerUpdate_SelectedIndexChanged;
            // 
            // buttonSaveUpdate
            // 
            buttonSaveUpdate.Location = new Point(111, 292);
            buttonSaveUpdate.Name = "buttonSaveUpdate";
            buttonSaveUpdate.Size = new Size(134, 38);
            buttonSaveUpdate.TabIndex = 15;
            buttonSaveUpdate.Text = "שמירה";
            buttonSaveUpdate.UseVisualStyleBackColor = true;
            buttonSaveUpdate.Click += buttonSaveUpdate_Click_1;
            // 
            // phoneToUpdate
            // 
            phoneToUpdate.Location = new Point(111, 227);
            phoneToUpdate.Name = "phoneToUpdate";
            phoneToUpdate.Size = new Size(208, 38);
            phoneToUpdate.TabIndex = 12;
            // 
            // nameToUpdate
            // 
            nameToUpdate.Location = new Point(111, 132);
            nameToUpdate.Name = "nameToUpdate";
            nameToUpdate.Size = new Size(208, 38);
            nameToUpdate.TabIndex = 13;
            // 
            // addressToUpdate
            // 
            addressToUpdate.Location = new Point(111, 177);
            addressToUpdate.Name = "addressToUpdate";
            addressToUpdate.Size = new Size(208, 38);
            addressToUpdate.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 230);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 8;
            label5.Text = "טלפון:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 84);
            label6.Name = "label6";
            label6.Size = new Size(169, 31);
            label6.TabIndex = 9;
            label6.Text = "ת\"ז של הלקוח :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 177);
            label7.Name = "label7";
            label7.Size = new Size(87, 31);
            label7.TabIndex = 10;
            label7.Text = "כתובת:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 132);
            label8.Name = "label8";
            label8.Size = new Size(54, 31);
            label8.TabIndex = 11;
            label8.Text = "שם:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(selectCustomer);
            tabPage5.Controls.Add(buttonDeleteC);
            tabPage5.Controls.Add(label3);
            tabPage5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(714, 456);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "מחיקה";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // selectCustomer
            // 
            selectCustomer.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            selectCustomer.FormattingEnabled = true;
            selectCustomer.Location = new Point(73, 29);
            selectCustomer.Name = "selectCustomer";
            selectCustomer.Size = new Size(200, 29);
            selectCustomer.TabIndex = 4;
            // 
            // buttonDeleteC
            // 
            buttonDeleteC.Location = new Point(73, 192);
            buttonDeleteC.Name = "buttonDeleteC";
            buttonDeleteC.Size = new Size(113, 48);
            buttonDeleteC.TabIndex = 3;
            buttonDeleteC.Text = "מחיקה";
            buttonDeleteC.UseVisualStyleBackColor = true;
            buttonDeleteC.Click += buttonDeleteC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 32);
            label3.Name = "label3";
            label3.Size = new Size(262, 31);
            label3.TabIndex = 1;
            label3.Text = "הכנס ת\"ז לקוח למחיקה :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(463, 23);
            label4.Name = "label4";
            label4.Size = new Size(203, 72);
            label4.TabIndex = 4;
            label4.Text = "לקוחות";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 626);
            Controls.Add(label4);
            Controls.Add(tabControl1);
            Name = "FormCustomer";
            Text = "FormCustomer";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonSaveCustomer;
        private Label labelQuntity;
        private Label labelCategory;
        private Label label2;
        private Label labelName;
        private TextBox identity;
        private TabPage tabPage2;
        private Label label9;
        private Button buttonReadOneC;
        private Button buttonReadByParamC;
        private Button buttonReadAllC;
        private ListBox listCustomer;
        private TabPage tabPage4;
        private TextBox idProduct;
        private Label label1;
        private TabPage tabPage5;
        private Button buttonDeleteC;
        private Label label3;
        private Label label4;
        private TextBox phone;
        private TextBox nameCustomer;
        private TextBox address;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonSaveUpdate;
        private TextBox phoneToUpdate;
        private TextBox nameToUpdate;
        private TextBox addressToUpdate;
        private ComboBox selectIdentity;
        private ComboBox selectCustomer;
        private ComboBox selectCustomerUpdate;
    }
}
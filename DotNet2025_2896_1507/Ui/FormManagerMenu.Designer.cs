﻿namespace Ui
{
    partial class FormManagerMenu
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
            buttonProduct = new Button();
            buttoCustomer = new Button();
            buttonSales = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonProduct
            // 
            buttonProduct.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProduct.ForeColor = SystemColors.WindowFrame;
            buttonProduct.Location = new Point(676, 289);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(177, 70);
            buttonProduct.TabIndex = 0;
            buttonProduct.Text = "מוצרים";
            buttonProduct.UseVisualStyleBackColor = true;
            buttonProduct.Click += buttonProduct_Click;
            // 
            // buttoCustomer
            // 
            buttoCustomer.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttoCustomer.ForeColor = SystemColors.WindowFrame;
            buttoCustomer.Location = new Point(477, 289);
            buttoCustomer.Name = "buttoCustomer";
            buttoCustomer.Size = new Size(177, 70);
            buttoCustomer.TabIndex = 0;
            buttoCustomer.Text = "לקוחות";
            buttoCustomer.UseVisualStyleBackColor = true;
            buttoCustomer.Click += buttoCustomer_Click;
            // 
            // buttonSales
            // 
            buttonSales.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSales.ForeColor = SystemColors.WindowFrame;
            buttonSales.Location = new Point(272, 289);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(177, 70);
            buttonSales.TabIndex = 0;
            buttonSales.Text = "מבצעים";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(365, 174);
            label1.Name = "label1";
            label1.Size = new Size(407, 54);
            label1.TabIndex = 1;
            label1.Text = "בחר בקטגוריה הרצויה";
            // 
            // FormManagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 626);
            Controls.Add(label1);
            Controls.Add(buttonSales);
            Controls.Add(buttoCustomer);
            Controls.Add(buttonProduct);
            Name = "FormManagerMenu";
            Text = "FormManagerMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonProduct;
        private Button buttoCustomer;
        private Button buttonSales;
        private Label label1;
    }
}
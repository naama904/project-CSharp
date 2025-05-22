namespace Ui
{
    partial class FormLogin
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
            startOrder = new Button();
            identity = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // startOrder
            // 
            startOrder.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            startOrder.ForeColor = SystemColors.ControlDarkDark;
            startOrder.Location = new Point(322, 210);
            startOrder.Name = "startOrder";
            startOrder.Size = new Size(181, 53);
            startOrder.TabIndex = 0;
            startOrder.Text = "התחל הזמנה";
            startOrder.UseVisualStyleBackColor = true;
            startOrder.Click += startOrder_Click;
            // 
            // identity
            // 
            identity.Location = new Point(325, 118);
            identity.Name = "identity";
            identity.Size = new Size(178, 27);
            identity.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(527, 117);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 2;
            label1.Text = "הכנס ת\"ז לקוח:";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(identity);
            Controls.Add(startOrder);
            Name = "FormLogin";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startOrder;
        private TextBox identity;
        private Label label1;
    }
}
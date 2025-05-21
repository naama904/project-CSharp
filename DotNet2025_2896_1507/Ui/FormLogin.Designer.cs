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
            SuspendLayout();
            // 
            // startOrder
            // 
            startOrder.Location = new Point(322, 207);
            startOrder.Name = "startOrder";
            startOrder.Size = new Size(181, 29);
            startOrder.TabIndex = 0;
            startOrder.Text = "התחל הזמנה";
            startOrder.UseVisualStyleBackColor = true;
            startOrder.Click += startOrder_Click;
            // 
            // identity
            // 
            identity.Location = new Point(322, 117);
            identity.Name = "identity";
            identity.Size = new Size(125, 27);
            identity.TabIndex = 1;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(identity);
            Controls.Add(startOrder);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startOrder;
        private TextBox identity;
    }
}
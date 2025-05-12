namespace Ui
{
    partial class formEnter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameStore = new Label();
            buttonManagger = new Button();
            buttonShopkeeper = new Button();
            SuspendLayout();
            // 
            // nameStore
            // 
            nameStore.AutoSize = true;
            nameStore.Font = new Font("Vladimir Script", 72F, FontStyle.Bold, GraphicsUnit.Point);
            nameStore.ForeColor = SystemColors.ControlDarkDark;
            nameStore.Location = new Point(268, 73);
            nameStore.Name = "nameStore";
            nameStore.Size = new Size(601, 145);
            nameStore.TabIndex = 0;
            nameStore.Text = "Baby World";
            nameStore.Click += label1_Click;
            // 
            // buttonManagger
            // 
            buttonManagger.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonManagger.Location = new Point(832, 222);
            buttonManagger.Margin = new Padding(3, 4, 3, 4);
            buttonManagger.Name = "buttonManagger";
            buttonManagger.Size = new Size(156, 96);
            buttonManagger.TabIndex = 1;
            buttonManagger.Text = "מנהל";
            buttonManagger.UseVisualStyleBackColor = true;
            buttonManagger.Click += buttonManagger_Click;
            // 
            // buttonShopkeeper
            // 
            buttonShopkeeper.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShopkeeper.Location = new Point(149, 222);
            buttonShopkeeper.Margin = new Padding(3, 4, 3, 4);
            buttonShopkeeper.Name = "buttonShopkeeper";
            buttonShopkeeper.Size = new Size(156, 96);
            buttonShopkeeper.TabIndex = 2;
            buttonShopkeeper.Text = "קופאי";
            buttonShopkeeper.UseVisualStyleBackColor = true;
            buttonShopkeeper.Click += buttonShopkeeper_Click;
            // 
            // formEnter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 626);
            Controls.Add(buttonShopkeeper);
            Controls.Add(buttonManagger);
            Controls.Add(nameStore);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formEnter";
            Text = "formEnter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameStore;
        private Button buttonManagger;
        private Button buttonShopkeeper;
    }
}

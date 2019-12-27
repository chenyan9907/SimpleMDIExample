namespace SimpleMDIExample
{
    partial class FrmDoc
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
            this.rTBDoc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTBDoc
            // 
            this.rTBDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBDoc.Location = new System.Drawing.Point(0, 0);
            this.rTBDoc.Name = "rTBDoc";
            this.rTBDoc.Size = new System.Drawing.Size(592, 460);
            this.rTBDoc.TabIndex = 0;
            this.rTBDoc.Text = "";
            this.rTBDoc.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FrmDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 460);
            this.Controls.Add(this.rTBDoc);
            this.Name = "FrmDoc";
            this.Text = "FrmDoc";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rTBDoc;
    }
}
namespace Sample
{
    partial class Form1
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
            this.customLookUpEdit1 = new Sample.CustomLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.customLookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customLookUpEdit1
            // 
            this.customLookUpEdit1.Location = new System.Drawing.Point(12, 12);
            this.customLookUpEdit1.Name = "customLookUpEdit1";
            this.customLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customLookUpEdit1.Size = new System.Drawing.Size(211, 20);
            this.customLookUpEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.customLookUpEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customLookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomLookUpEdit customLookUpEdit1;
    }
}


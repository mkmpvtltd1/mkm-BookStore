namespace BookStore
{
    partial class init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(init));
            this.holder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // holder
            // 
            this.holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holder.Location = new System.Drawing.Point(0, 0);
            this.holder.Name = "holder";
            this.holder.Size = new System.Drawing.Size(265, 291);
            this.holder.TabIndex = 0;
            // 
            // init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 291);
            this.Controls.Add(this.holder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "init";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "init";
            this.Load += new System.EventHandler(this.init_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel holder;
    }
}
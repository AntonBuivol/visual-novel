namespace visual_novel
{
    partial class Scene1
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
            this.Label = new visual_novel.CustomLabel();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BorderColor = System.Drawing.Color.Black;
            this.Label.BorderThickness = 6;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(53, 309);
            this.Label.MaximumSize = new System.Drawing.Size(650, 80);
            this.Label.MinimumSize = new System.Drawing.Size(650, 80);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Label.Radius = 10;
            this.Label.Size = new System.Drawing.Size(650, 80);
            this.Label.TabIndex = 1;
            this.Label.Text = "something text";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // Scene1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label);
            this.Name = "Scene1";
            this.Text = "Scene1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomLabel Label;
    }
}
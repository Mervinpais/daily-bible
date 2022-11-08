namespace Daily_Bible
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
            this.ok_btn = new System.Windows.Forms.Button();
            this.bible_verse_lb = new System.Windows.Forms.Label();
            this.verse_from_bible_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(320, 361);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(177, 53);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // bible_verse_lb
            // 
            this.bible_verse_lb.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bible_verse_lb.Location = new System.Drawing.Point(56, 49);
            this.bible_verse_lb.Name = "bible_verse_lb";
            this.bible_verse_lb.Size = new System.Drawing.Size(649, 218);
            this.bible_verse_lb.TabIndex = 1;
            this.bible_verse_lb.Text = "MainVerse";
            // 
            // verse_from_bible_lb
            // 
            this.verse_from_bible_lb.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verse_from_bible_lb.Location = new System.Drawing.Point(467, 286);
            this.verse_from_bible_lb.Name = "verse_from_bible_lb";
            this.verse_from_bible_lb.Size = new System.Drawing.Size(292, 44);
            this.verse_from_bible_lb.TabIndex = 2;
            this.verse_from_bible_lb.Text = "verse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verse_from_bible_lb);
            this.Controls.Add(this.bible_verse_lb);
            this.Controls.Add(this.ok_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Daily Bible";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label bible_verse_lb;
        private System.Windows.Forms.Label verse_from_bible_lb;
    }
}


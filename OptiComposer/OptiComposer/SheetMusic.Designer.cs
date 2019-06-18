namespace OptiComposer
{
    partial class SheetMusic
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
            this.DrawPanel = new System.Windows.Forms.PictureBox();
            this.NoteHighlight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoteHighlight)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Location = new System.Drawing.Point(37, 42);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(850, 350);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.TabStop = false;
            this.DrawPanel.MouseHover += new System.EventHandler(this.DrawPanel_Hover);
            // 
            // NoteHighlight
            // 
            this.NoteHighlight.BackColor = System.Drawing.Color.Black;
            this.NoteHighlight.Location = new System.Drawing.Point(12, 119);
            this.NoteHighlight.Name = "NoteHighlight";
            this.NoteHighlight.Size = new System.Drawing.Size(55, 74);
            this.NoteHighlight.TabIndex = 1;
            this.NoteHighlight.TabStop = false;
            this.NoteHighlight.Visible = false;
            this.NoteHighlight.Click += new System.EventHandler(this.NoteHighlight_Click);
            // 
            // SheetMusic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(924, 561);
            this.Controls.Add(this.NoteHighlight);
            this.Controls.Add(this.DrawPanel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SheetMusic";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptiComposer";
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoteHighlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawPanel;
        private System.Windows.Forms.PictureBox NoteHighlight;
    }
}


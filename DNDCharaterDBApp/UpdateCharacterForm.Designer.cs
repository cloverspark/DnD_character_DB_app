
namespace DNDCharaterDBApp
{
    partial class UpdateCharacterForm
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
            this.CharacterListBx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CharacterListBx
            // 
            this.CharacterListBx.FormattingEnabled = true;
            this.CharacterListBx.ItemHeight = 16;
            this.CharacterListBx.Location = new System.Drawing.Point(25, 33);
            this.CharacterListBx.Name = "CharacterListBx";
            this.CharacterListBx.Size = new System.Drawing.Size(416, 596);
            this.CharacterListBx.TabIndex = 0;
            // 
            // UpdateCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 675);
            this.Controls.Add(this.CharacterListBx);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateCharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCharater";
            this.Load += new System.EventHandler(this.UpdateCharacterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CharacterListBx;
    }
}
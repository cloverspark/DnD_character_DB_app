
namespace DNDCharaterDBApp
{
    partial class DeleteCharacterForm
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
            this.CharacterSheetCB = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharacterSheetCB
            // 
            this.CharacterSheetCB.FormattingEnabled = true;
            this.CharacterSheetCB.Location = new System.Drawing.Point(40, 61);
            this.CharacterSheetCB.Name = "CharacterSheetCB";
            this.CharacterSheetCB.Size = new System.Drawing.Size(369, 28);
            this.CharacterSheetCB.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(584, 65);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(101, 59);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DeleteCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 247);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CharacterSheetCB);
            this.Name = "DeleteCharacterForm";
            this.Text = "DeleteCharater";
            this.Load += new System.EventHandler(this.DeleteCharacterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CharacterSheetCB;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
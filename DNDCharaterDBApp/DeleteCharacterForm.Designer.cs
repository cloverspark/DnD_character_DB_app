
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
            this.CharacterDeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DescritionCB = new System.Windows.Forms.ComboBox();
            this.DescriptionDeleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CharacterSheetCB
            // 
            this.CharacterSheetCB.FormattingEnabled = true;
            this.CharacterSheetCB.Location = new System.Drawing.Point(40, 61);
            this.CharacterSheetCB.Name = "CharacterSheetCB";
            this.CharacterSheetCB.Size = new System.Drawing.Size(538, 28);
            this.CharacterSheetCB.TabIndex = 0;
            // 
            // CharacterDeleteBtn
            // 
            this.CharacterDeleteBtn.Location = new System.Drawing.Point(594, 61);
            this.CharacterDeleteBtn.Name = "CharacterDeleteBtn";
            this.CharacterDeleteBtn.Size = new System.Drawing.Size(101, 59);
            this.CharacterDeleteBtn.TabIndex = 1;
            this.CharacterDeleteBtn.Text = "Delete";
            this.CharacterDeleteBtn.UseVisualStyleBackColor = true;
            this.CharacterDeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Character Sheets";
            // 
            // DescritionCB
            // 
            this.DescritionCB.FormattingEnabled = true;
            this.DescritionCB.Location = new System.Drawing.Point(40, 164);
            this.DescritionCB.Name = "DescritionCB";
            this.DescritionCB.Size = new System.Drawing.Size(538, 28);
            this.DescritionCB.TabIndex = 3;
            // 
            // DescriptionDeleteBtn
            // 
            this.DescriptionDeleteBtn.Location = new System.Drawing.Point(594, 164);
            this.DescriptionDeleteBtn.Name = "DescriptionDeleteBtn";
            this.DescriptionDeleteBtn.Size = new System.Drawing.Size(101, 59);
            this.DescriptionDeleteBtn.TabIndex = 5;
            this.DescriptionDeleteBtn.Text = "button2";
            this.DescriptionDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Description";
            // 
            // DeleteCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 247);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionDeleteBtn);
            this.Controls.Add(this.DescritionCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharacterDeleteBtn);
            this.Controls.Add(this.CharacterSheetCB);
            this.Name = "DeleteCharacterForm";
            this.Text = "DeleteCharater";
            this.Load += new System.EventHandler(this.DeleteCharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CharacterSheetCB;
        private System.Windows.Forms.Button CharacterDeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DescritionCB;
        private System.Windows.Forms.Button DescriptionDeleteBtn;
        private System.Windows.Forms.Label label2;
    }
}

namespace DNDCharaterDBApp
{
    partial class AddCharaterForm
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
            this.DescritionCB = new System.Windows.Forms.ComboBox();
            this.CharacterNameTxtBx = new System.Windows.Forms.TextBox();
            this.ClassNameTxtBx = new System.Windows.Forms.TextBox();
            this.AddCharacterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescritionCB
            // 
            this.DescritionCB.FormattingEnabled = true;
            this.DescritionCB.Location = new System.Drawing.Point(55, 267);
            this.DescritionCB.Name = "DescritionCB";
            this.DescritionCB.Size = new System.Drawing.Size(453, 28);
            this.DescritionCB.TabIndex = 0;
            // 
            // CharacterNameTxtBx
            // 
            this.CharacterNameTxtBx.Location = new System.Drawing.Point(55, 112);
            this.CharacterNameTxtBx.Name = "CharacterNameTxtBx";
            this.CharacterNameTxtBx.Size = new System.Drawing.Size(453, 26);
            this.CharacterNameTxtBx.TabIndex = 1;
            // 
            // ClassNameTxtBx
            // 
            this.ClassNameTxtBx.Location = new System.Drawing.Point(55, 416);
            this.ClassNameTxtBx.Name = "ClassNameTxtBx";
            this.ClassNameTxtBx.Size = new System.Drawing.Size(453, 26);
            this.ClassNameTxtBx.TabIndex = 2;
            // 
            // AddCharacterBtn
            // 
            this.AddCharacterBtn.Location = new System.Drawing.Point(55, 575);
            this.AddCharacterBtn.Name = "AddCharacterBtn";
            this.AddCharacterBtn.Size = new System.Drawing.Size(123, 66);
            this.AddCharacterBtn.TabIndex = 3;
            this.AddCharacterBtn.Text = "Add";
            this.AddCharacterBtn.UseVisualStyleBackColor = true;
            this.AddCharacterBtn.Click += new System.EventHandler(this.AddCharacterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Character Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class Name";
            // 
            // AddCharaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 689);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCharacterBtn);
            this.Controls.Add(this.ClassNameTxtBx);
            this.Controls.Add(this.CharacterNameTxtBx);
            this.Controls.Add(this.DescritionCB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCharaterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCharater";
            this.Load += new System.EventHandler(this.AddCharaterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DescritionCB;
        private System.Windows.Forms.TextBox CharacterNameTxtBx;
        private System.Windows.Forms.TextBox ClassNameTxtBx;
        private System.Windows.Forms.Button AddCharacterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

namespace DNDCharaterDBApp
{
    partial class CurrentCharacterForm
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
            this.RaceNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CharacterSheetCB
            // 
            this.CharacterSheetCB.FormattingEnabled = true;
            this.CharacterSheetCB.Location = new System.Drawing.Point(48, 103);
            this.CharacterSheetCB.Name = "CharacterSheetCB";
            this.CharacterSheetCB.Size = new System.Drawing.Size(263, 28);
            this.CharacterSheetCB.TabIndex = 0;
            this.CharacterSheetCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RaceNameTB
            // 
            this.RaceNameTB.Location = new System.Drawing.Point(472, 105);
            this.RaceNameTB.Name = "RaceNameTB";
            this.RaceNameTB.Size = new System.Drawing.Size(181, 26);
            this.RaceNameTB.TabIndex = 2;
            // 
            // CurrentCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RaceNameTB);
            this.Controls.Add(this.CharacterSheetCB);
            this.Name = "CurrentCharacterForm";
            this.Text = "CurrentCharaters";
            this.Load += new System.EventHandler(this.CurrentCharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CharacterSheetCB;
        private System.Windows.Forms.TextBox RaceNameTB;
    }
}
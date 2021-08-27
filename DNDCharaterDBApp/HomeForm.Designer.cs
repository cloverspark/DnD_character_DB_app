
namespace DNDCharaterDBApp
{
    partial class homeForm
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
            this.AddCharacterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddDescriptionBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCharacterBtn
            // 
            this.AddCharacterBtn.Location = new System.Drawing.Point(59, 337);
            this.AddCharacterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCharacterBtn.Name = "AddCharacterBtn";
            this.AddCharacterBtn.Size = new System.Drawing.Size(122, 69);
            this.AddCharacterBtn.TabIndex = 5;
            this.AddCharacterBtn.Text = " New Character";
            this.AddCharacterBtn.UseVisualStyleBackColor = true;
            this.AddCharacterBtn.Click += new System.EventHandler(this.AddCharacterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click to add new character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "fix home pagefi";
            // 
            // CurrentBtn
            // 
            this.CurrentBtn.Location = new System.Drawing.Point(59, 82);
            this.CurrentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentBtn.Name = "CurrentBtn";
            this.CurrentBtn.Size = new System.Drawing.Size(122, 69);
            this.CurrentBtn.TabIndex = 0;
            this.CurrentBtn.Text = "Current Characters";
            this.CurrentBtn.UseVisualStyleBackColor = true;
            this.CurrentBtn.Click += new System.EventHandler(this.CurrentBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(319, 82);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(122, 69);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click to update a finished character";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Click to delete a character";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(319, 337);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(122, 69);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete Sheet";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddDescriptionBtn
            // 
            this.AddDescriptionBtn.Location = new System.Drawing.Point(59, 483);
            this.AddDescriptionBtn.Name = "AddDescriptionBtn";
            this.AddDescriptionBtn.Size = new System.Drawing.Size(122, 69);
            this.AddDescriptionBtn.TabIndex = 8;
            this.AddDescriptionBtn.Text = "New Description";
            this.AddDescriptionBtn.UseVisualStyleBackColor = true;
            this.AddDescriptionBtn.Click += new System.EventHandler(this.AddDescriptionBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Click to add new Description";
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddDescriptionBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CurrentBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCharacterBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCharacterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CurrentBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddDescriptionBtn;
        private System.Windows.Forms.Label label5;
    }
}


﻿namespace ContactU
{
    partial class PeopleForm
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
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.peopleTitlelbl = new System.Windows.Forms.Label();
            this.txtBoxPeopleSearch = new System.Windows.Forms.TextBox();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEllipsis = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.Size = new System.Drawing.Size(331, 748);
            this.dataGridViewContacts.TabIndex = 0;
            // 
            // peopleTitlelbl
            // 
            this.peopleTitlelbl.AutoSize = true;
            this.peopleTitlelbl.Location = new System.Drawing.Point(13, 13);
            this.peopleTitlelbl.Name = "peopleTitlelbl";
            this.peopleTitlelbl.Size = new System.Drawing.Size(46, 13);
            this.peopleTitlelbl.TabIndex = 1;
            this.peopleTitlelbl.Text = "People";
            // 
            // txtBoxPeopleSearch
            // 
            this.txtBoxPeopleSearch.Location = new System.Drawing.Point(13, 114);
            this.txtBoxPeopleSearch.Name = "txtBoxPeopleSearch";
            this.txtBoxPeopleSearch.Size = new System.Drawing.Size(330, 20);
            this.txtBoxPeopleSearch.TabIndex = 2;
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblContactTitle.Location = new System.Drawing.Point(12, 91);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(81, 20);
            this.lblContactTitle.TabIndex = 3;
            this.lblContactTitle.Text = "Contacts";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 66);
            this.panel1.TabIndex = 5;
            // 
            // btnEllipsis
            // 
            this.btnEllipsis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipsis.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEllipsis.Image = global::ContactU.Properties.Resources.icons8_more_30px;
            this.btnEllipsis.Location = new System.Drawing.Point(301, 72);
            this.btnEllipsis.Name = "btnEllipsis";
            this.btnEllipsis.Size = new System.Drawing.Size(42, 36);
            this.btnEllipsis.TabIndex = 4;
            this.btnEllipsis.UseVisualStyleBackColor = true;
            // 
            // btnAddContact
            // 
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContact.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddContact.Image = global::ContactU.Properties.Resources.icons8_add_30px;
            this.btnAddContact.Location = new System.Drawing.Point(253, 72);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(42, 36);
            this.btnAddContact.TabIndex = 4;
            this.btnAddContact.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMinimize.Image = global::ContactU.Properties.Resources.icons8_minimize_window_30px;
            this.btnMinimize.Location = new System.Drawing.Point(230, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 36);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMaximize.Image = global::ContactU.Properties.Resources.icons8_maximize_window_30px;
            this.btnMaximize.Location = new System.Drawing.Point(266, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(42, 36);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Image = global::ContactU.Properties.Resources.icons8_macos_close_30px;
            this.btnExit.Location = new System.Drawing.Point(301, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(700, 900);
            this.Controls.Add(this.btnEllipsis);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lblContactTitle);
            this.Controls.Add(this.txtBoxPeopleSearch);
            this.Controls.Add(this.peopleTitlelbl);
            this.Controls.Add(this.dataGridViewContacts);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.Label peopleTitlelbl;
        private System.Windows.Forms.TextBox txtBoxPeopleSearch;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnEllipsis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnExit;
    }
}

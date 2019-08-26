using System;

namespace ContactU
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
            this.peopleTitlelbl = new System.Windows.Forms.Label();
            this.txtBoxPeopleSearch = new System.Windows.Forms.TextBox();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnEllipsis = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.txtBoxPeopleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxPeopleSearch.Location = new System.Drawing.Point(13, 114);
            this.txtBoxPeopleSearch.Name = "txtBoxPeopleSearch";
            this.txtBoxPeopleSearch.Size = new System.Drawing.Size(330, 20);
            this.txtBoxPeopleSearch.TabIndex = 2;
            this.txtBoxPeopleSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            this.txtBoxPeopleSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 141);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 747);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 100;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 100;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(106, 281);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(8, 8);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
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
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(362, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 785);
            this.panel2.TabIndex = 8;
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(700, 900);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEllipsis);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lblContactTitle);
            this.Controls.Add(this.txtBoxPeopleSearch);
            this.Controls.Add(this.peopleTitlelbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.Label peopleTitlelbl;
        private System.Windows.Forms.TextBox txtBoxPeopleSearch;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnEllipsis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel2;
    }
}


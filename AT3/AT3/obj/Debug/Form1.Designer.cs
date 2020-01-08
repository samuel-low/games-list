namespace AT3
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
            this.components = new System.ComponentModel.Container();
            this.gamesList = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.platformLabel = new System.Windows.Forms.Label();
            this.platformTxt = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.binSearchBtn = new System.Windows.Forms.Button();
            this.linSearchBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gamesList
            // 
            this.gamesList.FormattingEnabled = true;
            this.gamesList.ItemHeight = 15;
            this.gamesList.Location = new System.Drawing.Point(43, 37);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(347, 409);
            this.gamesList.TabIndex = 0;
            this.gamesList.Click += new System.EventHandler(this.gamesList_Click);
            this.gamesList.Enter += new System.EventHandler(this.gamesList_Enter);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(565, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(612, 70);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(116, 21);
            this.nameTxt.TabIndex = 2;
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(548, 106);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(58, 15);
            this.platformLabel.TabIndex = 3;
            this.platformLabel.Text = "Platform:";
            // 
            // platformTxt
            // 
            this.platformTxt.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformTxt.Location = new System.Drawing.Point(612, 106);
            this.platformTxt.Name = "platformTxt";
            this.platformTxt.Size = new System.Drawing.Size(116, 21);
            this.platformTxt.TabIndex = 4;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(564, 143);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(42, 15);
            this.genreLabel.TabIndex = 5;
            this.genreLabel.Text = "Genre:";
            // 
            // genreTxt
            // 
            this.genreTxt.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTxt.Location = new System.Drawing.Point(612, 143);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(116, 21);
            this.genreTxt.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(519, 435);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 27);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.ToolTips.SetToolTip(this.saveBtn, "Saves the list in a .dat file on the desktop.");
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.Location = new System.Drawing.Point(666, 435);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(87, 27);
            this.openBtn.TabIndex = 8;
            this.openBtn.Text = "Open";
            this.ToolTips.SetToolTip(this.openBtn, "Overwrites the current list with the data from the save file.");
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(531, 211);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 27);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.ToolTips.SetToolTip(this.addBtn, "Adds an entry to the games list.");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(666, 252);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.ToolTips.SetToolTip(this.deleteBtn, "Delete a selected entry from the games list.");
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(531, 254);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 25);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.ToolTips.SetToolTip(this.updateBtn, "Update the information of a selected game on the list.");
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(666, 299);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 27);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.ToolTips.SetToolTip(this.resetBtn, "Clears all entries on the game list.");
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // binSearchBtn
            // 
            this.binSearchBtn.Location = new System.Drawing.Point(490, 375);
            this.binSearchBtn.Name = "binSearchBtn";
            this.binSearchBtn.Size = new System.Drawing.Size(116, 27);
            this.binSearchBtn.TabIndex = 13;
            this.binSearchBtn.Text = "Binary Search";
            this.ToolTips.SetToolTip(this.binSearchBtn, "Finds the matching information of the name entered using a Binary search.");
            this.binSearchBtn.UseVisualStyleBackColor = true;
            this.binSearchBtn.Click += new System.EventHandler(this.binSearchBtn_Click);
            // 
            // linSearchBtn
            // 
            this.linSearchBtn.Location = new System.Drawing.Point(666, 375);
            this.linSearchBtn.Name = "linSearchBtn";
            this.linSearchBtn.Size = new System.Drawing.Size(128, 27);
            this.linSearchBtn.TabIndex = 14;
            this.linSearchBtn.Text = "Linear Search";
            this.ToolTips.SetToolTip(this.linSearchBtn, "Finds the matching information of the name entered using a Linear search.");
            this.linSearchBtn.UseVisualStyleBackColor = true;
            this.linSearchBtn.Click += new System.EventHandler(this.linSearchBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(531, 303);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 15;
            this.sortBtn.Text = "Sort";
            this.ToolTips.SetToolTip(this.sortBtn, "Orders all the entries in the game list alphabetically.");
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(666, 211);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 27);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 509);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.linSearchBtn);
            this.Controls.Add(this.binSearchBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.platformTxt);
            this.Controls.Add(this.platformLabel);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.gamesList);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Computer Games Collection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gamesList;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.TextBox platformTxt;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button binSearchBtn;
        private System.Windows.Forms.Button linSearchBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.Button clearBtn;
    }
}


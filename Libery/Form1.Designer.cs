namespace Libery
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TitleNew = new System.Windows.Forms.Label();
            this.AuthNew = new System.Windows.Forms.Label();
            this.NewPub = new System.Windows.Forms.Label();
            this.tBoxpub = new System.Windows.Forms.TextBox();
            this.tBoxAuth = new System.Windows.Forms.TextBox();
            this.tBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PubDB = new System.Windows.Forms.Label();
            this.AutDB = new System.Windows.Forms.Label();
            this.TitleDB = new System.Windows.Forms.Label();
            this.IdDB = new System.Windows.Forms.Label();
            this.UpdateBut = new System.Windows.Forms.LinkLabel();
            this.DeletBook = new System.Windows.Forms.LinkLabel();
            this.Upbut = new System.Windows.Forms.Button();
            this.UpAut = new System.Windows.Forms.TextBox();
            this.UpTit = new System.Windows.Forms.TextBox();
            this.UpPub = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchBut = new System.Windows.Forms.Button();
            this.FirstBut = new System.Windows.Forms.Button();
            this.LastBut = new System.Windows.Forms.Button();
            this.ResultLab = new System.Windows.Forms.Label();
            this.TitleLab = new System.Windows.Forms.Label();
            this.AuthLab = new System.Windows.Forms.Label();
            this.PubLab = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(33, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(144, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titile of Book";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(297, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(418, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publication ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(163, 309);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add New Book ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TitleNew
            // 
            this.TitleNew.AutoSize = true;
            this.TitleNew.Location = new System.Drawing.Point(196, 335);
            this.TitleNew.Name = "TitleNew";
            this.TitleNew.Size = new System.Drawing.Size(66, 13);
            this.TitleNew.TabIndex = 16;
            this.TitleNew.Text = "Title of book";
            this.TitleNew.Click += new System.EventHandler(this.TitleNew_Click);
            // 
            // AuthNew
            // 
            this.AuthNew.AutoSize = true;
            this.AuthNew.Location = new System.Drawing.Point(287, 335);
            this.AuthNew.Name = "AuthNew";
            this.AuthNew.Size = new System.Drawing.Size(40, 13);
            this.AuthNew.TabIndex = 17;
            this.AuthNew.Text = "Author";
            this.AuthNew.Click += new System.EventHandler(this.AuthNew_Click);
            // 
            // NewPub
            // 
            this.NewPub.AutoSize = true;
            this.NewPub.Location = new System.Drawing.Point(354, 335);
            this.NewPub.Name = "NewPub";
            this.NewPub.Size = new System.Drawing.Size(50, 13);
            this.NewPub.TabIndex = 18;
            this.NewPub.Text = "Publicton";
            this.NewPub.Click += new System.EventHandler(this.NewPub_Click);
            // 
            // tBoxpub
            // 
            this.tBoxpub.Location = new System.Drawing.Point(349, 375);
            this.tBoxpub.Name = "tBoxpub";
            this.tBoxpub.Size = new System.Drawing.Size(74, 20);
            this.tBoxpub.TabIndex = 19;
            this.tBoxpub.TextChanged += new System.EventHandler(this.tBoxpub_TextChanged);
            // 
            // tBoxAuth
            // 
            this.tBoxAuth.Location = new System.Drawing.Point(277, 375);
            this.tBoxAuth.Name = "tBoxAuth";
            this.tBoxAuth.Size = new System.Drawing.Size(64, 20);
            this.tBoxAuth.TabIndex = 20;
            this.tBoxAuth.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // tBoxTitle
            // 
            this.tBoxTitle.Location = new System.Drawing.Point(186, 375);
            this.tBoxTitle.Name = "tBoxTitle";
            this.tBoxTitle.Size = new System.Drawing.Size(85, 20);
            this.tBoxTitle.TabIndex = 21;
            this.tBoxTitle.TextChanged += new System.EventHandler(this.tBoxTitle_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(214, 420);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(128, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button2.Location = new System.Drawing.Point(367, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "NEXT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PubDB
            // 
            this.PubDB.AutoSize = true;
            this.PubDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PubDB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PubDB.Location = new System.Drawing.Point(431, 183);
            this.PubDB.Name = "PubDB";
            this.PubDB.Size = new System.Drawing.Size(59, 19);
            this.PubDB.TabIndex = 12;
            this.PubDB.Text = "label8";
            this.PubDB.Click += new System.EventHandler(this.PubDB_Click);
            // 
            // AutDB
            // 
            this.AutDB.AutoSize = true;
            this.AutDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutDB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AutDB.Location = new System.Drawing.Point(297, 183);
            this.AutDB.Name = "AutDB";
            this.AutDB.Size = new System.Drawing.Size(59, 19);
            this.AutDB.TabIndex = 11;
            this.AutDB.Text = "label7";
            this.AutDB.Click += new System.EventHandler(this.AutDB_Click);
            // 
            // TitleDB
            // 
            this.TitleDB.AutoSize = true;
            this.TitleDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TitleDB.Location = new System.Drawing.Point(150, 183);
            this.TitleDB.Name = "TitleDB";
            this.TitleDB.Size = new System.Drawing.Size(59, 19);
            this.TitleDB.TabIndex = 10;
            this.TitleDB.Text = "label6";
            this.TitleDB.Click += new System.EventHandler(this.label6_Click);
            // 
            // IdDB
            // 
            this.IdDB.AutoSize = true;
            this.IdDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdDB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.IdDB.Location = new System.Drawing.Point(33, 183);
            this.IdDB.Name = "IdDB";
            this.IdDB.Size = new System.Drawing.Size(59, 19);
            this.IdDB.TabIndex = 9;
            this.IdDB.Text = "label5";
            this.IdDB.Click += new System.EventHandler(this.IdDB_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.AutoSize = true;
            this.UpdateBut.Font = new System.Drawing.Font("Tahoma", 10F);
            this.UpdateBut.LinkColor = System.Drawing.Color.Blue;
            this.UpdateBut.Location = new System.Drawing.Point(294, 309);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(121, 17);
            this.UpdateBut.TabIndex = 25;
            this.UpdateBut.TabStop = true;
            this.UpdateBut.Text = "Update The Book?";
            this.UpdateBut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateBut_LinkClicked);
            // 
            // DeletBook
            // 
            this.DeletBook.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeletBook.AutoSize = true;
            this.DeletBook.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DeletBook.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.DeletBook.Location = new System.Drawing.Point(236, 270);
            this.DeletBook.Name = "DeletBook";
            this.DeletBook.Size = new System.Drawing.Size(108, 17);
            this.DeletBook.TabIndex = 26;
            this.DeletBook.TabStop = true;
            this.DeletBook.Text = "Delete The Book";
            this.DeletBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Upbut
            // 
            this.Upbut.Location = new System.Drawing.Point(314, 420);
            this.Upbut.Name = "Upbut";
            this.Upbut.Size = new System.Drawing.Size(75, 23);
            this.Upbut.TabIndex = 27;
            this.Upbut.Text = "UPDATE";
            this.Upbut.UseVisualStyleBackColor = true;
            this.Upbut.Click += new System.EventHandler(this.Upbut_Click);
            // 
            // UpAut
            // 
            this.UpAut.Location = new System.Drawing.Point(277, 351);
            this.UpAut.Name = "UpAut";
            this.UpAut.Size = new System.Drawing.Size(65, 20);
            this.UpAut.TabIndex = 28;
            this.UpAut.TextChanged += new System.EventHandler(this.UpAut_TextChanged);
            // 
            // UpTit
            // 
            this.UpTit.Location = new System.Drawing.Point(191, 351);
            this.UpTit.Name = "UpTit";
            this.UpTit.Size = new System.Drawing.Size(80, 20);
            this.UpTit.TabIndex = 29;
            this.UpTit.TextChanged += new System.EventHandler(this.UpTit_TextChanged);
            // 
            // UpPub
            // 
            this.UpPub.Location = new System.Drawing.Point(349, 351);
            this.UpPub.Name = "UpPub";
            this.UpPub.Size = new System.Drawing.Size(72, 20);
            this.UpPub.TabIndex = 30;
            this.UpPub.TextChanged += new System.EventHandler(this.textBox3_TextChanged_2);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(224, 41);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(114, 20);
            this.tbSearch.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(260, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 32;
            this.label5.Text = "Search";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SearchBut
            // 
            this.SearchBut.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SearchBut.Location = new System.Drawing.Point(344, 39);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(116, 22);
            this.SearchBut.TabIndex = 33;
            this.SearchBut.Text = "SEARCH by Name";
            this.SearchBut.UseVisualStyleBackColor = false;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // FirstBut
            // 
            this.FirstBut.BackColor = System.Drawing.Color.OliveDrab;
            this.FirstBut.ForeColor = System.Drawing.Color.White;
            this.FirstBut.Location = new System.Drawing.Point(56, 243);
            this.FirstBut.Name = "FirstBut";
            this.FirstBut.Size = new System.Drawing.Size(36, 23);
            this.FirstBut.TabIndex = 34;
            this.FirstBut.Text = "First";
            this.FirstBut.UseVisualStyleBackColor = false;
            this.FirstBut.Click += new System.EventHandler(this.FirstBut_Click);
            // 
            // LastBut
            // 
            this.LastBut.BackColor = System.Drawing.Color.OliveDrab;
            this.LastBut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LastBut.Location = new System.Drawing.Point(494, 246);
            this.LastBut.Name = "LastBut";
            this.LastBut.Size = new System.Drawing.Size(36, 23);
            this.LastBut.TabIndex = 35;
            this.LastBut.Text = "Last";
            this.LastBut.UseVisualStyleBackColor = false;
            this.LastBut.Click += new System.EventHandler(this.LastBut_Click);
            // 
            // ResultLab
            // 
            this.ResultLab.AutoSize = true;
            this.ResultLab.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ResultLab.Location = new System.Drawing.Point(75, 87);
            this.ResultLab.Name = "ResultLab";
            this.ResultLab.Size = new System.Drawing.Size(77, 17);
            this.ResultLab.TabIndex = 36;
            this.ResultLab.Text = "The Result:";
            // 
            // TitleLab
            // 
            this.TitleLab.AutoSize = true;
            this.TitleLab.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TitleLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TitleLab.Location = new System.Drawing.Point(177, 87);
            this.TitleLab.Name = "TitleLab";
            this.TitleLab.Size = new System.Drawing.Size(32, 17);
            this.TitleLab.TabIndex = 36;
            this.TitleLab.Text = "Title";
            // 
            // AuthLab
            // 
            this.AuthLab.AutoSize = true;
            this.AuthLab.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AuthLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AuthLab.Location = new System.Drawing.Point(290, 87);
            this.AuthLab.Name = "AuthLab";
            this.AuthLab.Size = new System.Drawing.Size(37, 17);
            this.AuthLab.TabIndex = 36;
            this.AuthLab.Text = "Auth";
            this.AuthLab.Click += new System.EventHandler(this.AuthLab_Click);
            // 
            // PubLab
            // 
            this.PubLab.AutoSize = true;
            this.PubLab.Font = new System.Drawing.Font("Tahoma", 10F);
            this.PubLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PubLab.Location = new System.Drawing.Point(417, 87);
            this.PubLab.Name = "PubLab";
            this.PubLab.Size = new System.Drawing.Size(32, 17);
            this.PubLab.TabIndex = 36;
            this.PubLab.Text = "pub";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(466, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 22);
            this.button3.TabIndex = 33;
            this.button3.Text = "SEARCH by ID";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(617, 512);
            this.Controls.Add(this.PubLab);
            this.Controls.Add(this.AuthLab);
            this.Controls.Add(this.TitleLab);
            this.Controls.Add(this.ResultLab);
            this.Controls.Add(this.LastBut);
            this.Controls.Add(this.FirstBut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.UpPub);
            this.Controls.Add(this.UpTit);
            this.Controls.Add(this.UpAut);
            this.Controls.Add(this.Upbut);
            this.Controls.Add(this.DeletBook);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tBoxTitle);
            this.Controls.Add(this.tBoxAuth);
            this.Controls.Add(this.tBoxpub);
            this.Controls.Add(this.NewPub);
            this.Controls.Add(this.AuthNew);
            this.Controls.Add(this.TitleNew);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.PubDB);
            this.Controls.Add(this.AutDB);
            this.Controls.Add(this.TitleDB);
            this.Controls.Add(this.IdDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LiberyForm";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label TitleNew;
        private System.Windows.Forms.Label AuthNew;
        private System.Windows.Forms.Label NewPub;
        private System.Windows.Forms.TextBox tBoxpub;
        private System.Windows.Forms.TextBox tBoxAuth;
        private System.Windows.Forms.TextBox tBoxTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PubDB;
        private System.Windows.Forms.Label AutDB;
        private System.Windows.Forms.Label TitleDB;
        private System.Windows.Forms.Label IdDB;
        private System.Windows.Forms.LinkLabel UpdateBut;
        private System.Windows.Forms.LinkLabel DeletBook;
        private System.Windows.Forms.Button Upbut;
        private System.Windows.Forms.TextBox UpAut;
        private System.Windows.Forms.TextBox UpTit;
        private System.Windows.Forms.TextBox UpPub;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.Button FirstBut;
        private System.Windows.Forms.Button LastBut;
        private System.Windows.Forms.Label ResultLab;
        private System.Windows.Forms.Label TitleLab;
        private System.Windows.Forms.Label AuthLab;
        private System.Windows.Forms.Label PubLab;
        private System.Windows.Forms.Button button3;
    }
}


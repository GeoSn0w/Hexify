namespace Hexify
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
            iTalk.ControlRenderer controlRenderer1 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable1 = new iTalk.MSColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dumpMeup = new System.Windows.Forms.SaveFileDialog();
            this.iconcreds = new iTalk.iTalk_Label();
            this.urlToME = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_ControlBox1 = new iTalk.iTalk_ControlBox();
            this.iTalk_Panel1 = new iTalk.iTalk_Panel();
            this.hexify = new iTalk.iTalk_Button_2();
            this.unhexify = new iTalk.iTalk_Button_1();
            this.stringFeed = new System.Windows.Forms.TextBox();
            this.righClick = new iTalk.iTalk_ContextMenuStrip();
            this.saveContentsToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iTalk_Panel1.SuspendLayout();
            this.righClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dumpMeup
            // 
            this.dumpMeup.FileName = "Give me a name";
            this.dumpMeup.Filter = "Text File |*.txt";
            this.dumpMeup.Title = "Save your artwork...";
            // 
            // iconcreds
            // 
            this.iconcreds.AutoSize = true;
            this.iconcreds.BackColor = System.Drawing.Color.Transparent;
            this.iconcreds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconcreds.ForeColor = System.Drawing.Color.White;
            this.iconcreds.Location = new System.Drawing.Point(698, 381);
            this.iconcreds.Name = "iconcreds";
            this.iconcreds.Size = new System.Drawing.Size(92, 21);
            this.iconcreds.TabIndex = 7;
            this.iconcreds.Text = "Icon Credits";
            this.iconcreds.Click += new System.EventHandler(this.iconcreds_Click);
            // 
            // urlToME
            // 
            this.urlToME.AutoSize = true;
            this.urlToME.BackColor = System.Drawing.Color.Transparent;
            this.urlToME.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlToME.ForeColor = System.Drawing.Color.White;
            this.urlToME.Location = new System.Drawing.Point(12, 381);
            this.urlToME.Name = "urlToME";
            this.urlToME.Size = new System.Drawing.Size(180, 21);
            this.urlToME.TabIndex = 6;
            this.urlToME.Text = "by GeoSn0w (@FCE365)";
            this.urlToME.Click += new System.EventHandler(this.urlToME_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.White;
            this.iTalk_Label1.Location = new System.Drawing.Point(50, 6);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(125, 40);
            this.iTalk_Label1.TabIndex = 4;
            this.iTalk_Label1.Text = "0xHexify";
            // 
            // iTalk_ControlBox1
            // 
            this.iTalk_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ControlBox1.Location = new System.Drawing.Point(714, 0);
            this.iTalk_ControlBox1.Name = "iTalk_ControlBox1";
            this.iTalk_ControlBox1.Size = new System.Drawing.Size(77, 19);
            this.iTalk_ControlBox1.TabIndex = 3;
            this.iTalk_ControlBox1.Text = "iTalk_ControlBox1";
            // 
            // iTalk_Panel1
            // 
            this.iTalk_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel1.Controls.Add(this.hexify);
            this.iTalk_Panel1.Controls.Add(this.unhexify);
            this.iTalk_Panel1.Controls.Add(this.stringFeed);
            this.iTalk_Panel1.Location = new System.Drawing.Point(12, 56);
            this.iTalk_Panel1.Name = "iTalk_Panel1";
            this.iTalk_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel1.Size = new System.Drawing.Size(778, 318);
            this.iTalk_Panel1.TabIndex = 2;
            this.iTalk_Panel1.Text = "iTalk_Panel1";
            // 
            // hexify
            // 
            this.hexify.BackColor = System.Drawing.Color.Transparent;
            this.hexify.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.hexify.ForeColor = System.Drawing.Color.White;
            this.hexify.Image = null;
            this.hexify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hexify.Location = new System.Drawing.Point(487, 250);
            this.hexify.Name = "hexify";
            this.hexify.Size = new System.Drawing.Size(283, 53);
            this.hexify.TabIndex = 2;
            this.hexify.Text = "Hexify";
            this.hexify.TextAlignment = System.Drawing.StringAlignment.Center;
            this.hexify.Click += new System.EventHandler(this.hexify_Click);
            // 
            // unhexify
            // 
            this.unhexify.BackColor = System.Drawing.Color.Transparent;
            this.unhexify.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unhexify.Image = null;
            this.unhexify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unhexify.Location = new System.Drawing.Point(8, 250);
            this.unhexify.Name = "unhexify";
            this.unhexify.Size = new System.Drawing.Size(283, 53);
            this.unhexify.TabIndex = 1;
            this.unhexify.Text = "Unhexify";
            this.unhexify.TextAlignment = System.Drawing.StringAlignment.Center;
            this.unhexify.Click += new System.EventHandler(this.unhexify_Click);
            // 
            // stringFeed
            // 
            this.stringFeed.AllowDrop = true;
            this.stringFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stringFeed.ContextMenuStrip = this.righClick;
            this.stringFeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringFeed.Location = new System.Drawing.Point(8, 8);
            this.stringFeed.Multiline = true;
            this.stringFeed.Name = "stringFeed";
            this.stringFeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stringFeed.Size = new System.Drawing.Size(762, 232);
            this.stringFeed.TabIndex = 0;
            this.stringFeed.Text = "Gimme hex, gimme file, gimme that which I desire!";
            this.stringFeed.Click += new System.EventHandler(this.stringFeed_Click);
            this.stringFeed.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.stringFeed.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // righClick
            // 
            this.righClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveContentsToFile,
            this.clearTextFieldToolStripMenuItem});
            this.righClick.Name = "righClick";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.righClick.Renderer = controlRenderer1;
            this.righClick.Size = new System.Drawing.Size(185, 48);
            // 
            // saveContentsToFile
            // 
            this.saveContentsToFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.saveContentsToFile.Name = "saveContentsToFile";
            this.saveContentsToFile.Size = new System.Drawing.Size(184, 22);
            this.saveContentsToFile.Text = "&Save Contents to File";
            this.saveContentsToFile.Click += new System.EventHandler(this.saveContentsToFile_Click);
            // 
            // clearTextFieldToolStripMenuItem
            // 
            this.clearTextFieldToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.clearTextFieldToolStripMenuItem.Name = "clearTextFieldToolStripMenuItem";
            this.clearTextFieldToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clearTextFieldToolStripMenuItem.Text = "&Clear Text field";
            this.clearTextFieldToolStripMenuItem.Click += new System.EventHandler(this.clearTextFieldToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hexify.Properties.Resources.update;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(802, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconcreds);
            this.Controls.Add(this.urlToME);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.iTalk_ControlBox1);
            this.Controls.Add(this.iTalk_Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexify";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.iTalk_Panel1.ResumeLayout(false);
            this.iTalk_Panel1.PerformLayout();
            this.righClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringFeed;
        private iTalk.iTalk_Panel iTalk_Panel1;
        private iTalk.iTalk_Button_1 unhexify;
        private iTalk.iTalk_ControlBox iTalk_ControlBox1;
        private iTalk.iTalk_Button_2 hexify;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_ContextMenuStrip righClick;
        private System.Windows.Forms.ToolStripMenuItem saveContentsToFile;
        private System.Windows.Forms.ToolStripMenuItem clearTextFieldToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dumpMeup;
        private iTalk.iTalk_Label urlToME;
        private iTalk.iTalk_Label iconcreds;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


﻿// // <copyright file="MainForm.Designer.cs" company="PublicDomain.com">
// //     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
// //     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// // </copyright>
// // <auto-generated />
namespace TaskKillerLite
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.mainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.countToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.closeGracefullyCheckBox = new System.Windows.Forms.CheckBox();
        	this.doubleClickCheckBox = new System.Windows.Forms.CheckBox();
        	this.processListView = new System.Windows.Forms.ListView();
        	this.idColumnHeader = new System.Windows.Forms.ColumnHeader();
        	this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
        	this.titleColumnHeader = new System.Windows.Forms.ColumnHeader();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.minimizeToolStripMenuItem,
        	        	        	this.fileToolStripMenuItem1,
        	        	        	this.optionsToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(281, 24);
        	this.mainMenuStrip.TabIndex = 25;
        	// 
        	// minimizeToolStripMenuItem
        	// 
        	this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        	this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
        	this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
        	this.minimizeToolStripMenuItem.Visible = false;
        	// 
        	// fileToolStripMenuItem1
        	// 
        	this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem,
        	        	        	this.toolStripSeparator1,
        	        	        	this.exitToolStripMenuItem1});
        	this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
        	this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem1.Text = "&File";
        	// 
        	// newToolStripMenuItem
        	// 
        	this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
        	this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        	this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.newToolStripMenuItem.Text = "&New";
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
        	// 
        	// exitToolStripMenuItem1
        	// 
        	this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
        	this.exitToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
        	this.exitToolStripMenuItem1.Text = "E&xit";
        	this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitToolStripMenuItem1Click);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.alwaysOnTopToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// alwaysOnTopToolStripMenuItem
        	// 
        	this.alwaysOnTopToolStripMenuItem.Checked = true;
        	this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        	this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// dailyReleasesPublicDomainDailycomToolStripMenuItem
        	// 
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Name = "dailyReleasesPublicDomainDailycomToolStripMenuItem";
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Text = "&Daily releases @ PublicDomainDaily.com";
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Click += new System.EventHandler(this.OnDailyReleasesPublicDomainDailycomToolStripMenuItemClick);
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.mainToolStripStatusLabel,
        	        	        	this.countToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 281);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(281, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 24;
        	// 
        	// mainToolStripStatusLabel
        	// 
        	this.mainToolStripStatusLabel.Name = "mainToolStripStatusLabel";
        	this.mainToolStripStatusLabel.Size = new System.Drawing.Size(113, 17);
        	this.mainToolStripStatusLabel.Text = "Captured processes:";
        	// 
        	// countToolStripStatusLabel
        	// 
        	this.countToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.countToolStripStatusLabel.Name = "countToolStripStatusLabel";
        	this.countToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.countToolStripStatusLabel.Text = "0";
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 2;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.Controls.Add(this.closeGracefullyCheckBox, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.doubleClickCheckBox, 1, 0);
        	this.tableLayoutPanel1.Controls.Add(this.processListView, 0, 1);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 2;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.28405F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.71595F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 257);
        	this.tableLayoutPanel1.TabIndex = 26;
        	// 
        	// closeGracefullyCheckBox
        	// 
        	this.closeGracefullyCheckBox.Checked = true;
        	this.closeGracefullyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.closeGracefullyCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
        	this.closeGracefullyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.closeGracefullyCheckBox.Location = new System.Drawing.Point(3, 3);
        	this.closeGracefullyCheckBox.Name = "closeGracefullyCheckBox";
        	this.closeGracefullyCheckBox.Size = new System.Drawing.Size(134, 23);
        	this.closeGracefullyCheckBox.TabIndex = 0;
        	this.closeGracefullyCheckBox.Text = "Close gracefully";
        	this.closeGracefullyCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.closeGracefullyCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// doubleClickCheckBox
        	// 
        	this.doubleClickCheckBox.Checked = true;
        	this.doubleClickCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.doubleClickCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.doubleClickCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.doubleClickCheckBox.Location = new System.Drawing.Point(143, 3);
        	this.doubleClickCheckBox.Name = "doubleClickCheckBox";
        	this.doubleClickCheckBox.Size = new System.Drawing.Size(135, 23);
        	this.doubleClickCheckBox.TabIndex = 1;
        	this.doubleClickCheckBox.Text = "Double click";
        	this.doubleClickCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.doubleClickCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// processListView
        	// 
        	this.processListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.idColumnHeader,
        	        	        	this.nameColumnHeader,
        	        	        	this.titleColumnHeader});
        	this.tableLayoutPanel1.SetColumnSpan(this.processListView, 2);
        	this.processListView.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.processListView.FullRowSelect = true;
        	this.processListView.Location = new System.Drawing.Point(3, 32);
        	this.processListView.Name = "processListView";
        	this.processListView.Size = new System.Drawing.Size(275, 222);
        	this.processListView.TabIndex = 2;
        	this.processListView.UseCompatibleStateImageBehavior = false;
        	this.processListView.View = System.Windows.Forms.View.Details;
        	this.processListView.Click += new System.EventHandler(this.OnProcessListViewClick);
        	this.processListView.DoubleClick += new System.EventHandler(this.OnProcessListViewDoubleClick);
        	// 
        	// idColumnHeader
        	// 
        	this.idColumnHeader.Text = "ID";
        	this.idColumnHeader.Width = 40;
        	// 
        	// nameColumnHeader
        	// 
        	this.nameColumnHeader.Text = "Name";
        	this.nameColumnHeader.Width = 100;
        	// 
        	// titleColumnHeader
        	// 
        	this.titleColumnHeader.Text = "Title";
        	this.titleColumnHeader.Width = 200;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(281, 303);
        	this.Controls.Add(this.tableLayoutPanel1);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Task Killer Lite";
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.CheckBox doubleClickCheckBox;
        private System.Windows.Forms.CheckBox closeGracefullyCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel countToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mainToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReleasesPublicDomainDailycomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}

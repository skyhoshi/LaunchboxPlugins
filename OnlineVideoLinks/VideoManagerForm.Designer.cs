﻿namespace OnlineVideoLinks
{
    partial class VideoManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoManagerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkMoreInfo = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTestNewVideo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVideoTitle = new System.Windows.Forms.TextBox();
            this.gridVideos = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Play = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGridError = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtStopTime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtStopTime);
            this.groupBox1.Controls.Add(this.txtStartTime);
            this.groupBox1.Controls.Add(this.linkMoreInfo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnTestNewVideo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddVideo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVideoPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVideoTitle);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new video";
            // 
            // linkMoreInfo
            // 
            this.linkMoreInfo.AutoSize = true;
            this.linkMoreInfo.Location = new System.Drawing.Point(350, 124);
            this.linkMoreInfo.Name = "linkMoreInfo";
            this.linkMoreInfo.Size = new System.Drawing.Size(67, 17);
            this.linkMoreInfo.TabIndex = 12;
            this.linkMoreInfo.TabStop = true;
            this.linkMoreInfo.Text = "More info";
            this.linkMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMoreInfo_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Supports YouTube, Steam videos, network paths, etc.";
            // 
            // btnTestNewVideo
            // 
            this.btnTestNewVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestNewVideo.Location = new System.Drawing.Point(536, 112);
            this.btnTestNewVideo.Name = "btnTestNewVideo";
            this.btnTestNewVideo.Size = new System.Drawing.Size(112, 29);
            this.btnTestNewVideo.TabIndex = 4;
            this.btnTestNewVideo.Text = "Test";
            this.btnTestNewVideo.UseVisualStyleBackColor = true;
            this.btnTestNewVideo.Click += new System.EventHandler(this.btnTestNewVideo_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Video stop time (s or mm:ss):";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Optional settings:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Video start time (s or mm:ss):";
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVideo.Location = new System.Drawing.Point(654, 112);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(112, 29);
            this.btnAddVideo.TabIndex = 5;
            this.btnAddVideo.Text = "Add video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "File path/URL:";
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideoPath.Location = new System.Drawing.Point(110, 70);
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(284, 22);
            this.txtVideoPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // txtVideoTitle
            // 
            this.txtVideoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideoTitle.Location = new System.Drawing.Point(110, 42);
            this.txtVideoTitle.Name = "txtVideoTitle";
            this.txtVideoTitle.Size = new System.Drawing.Size(284, 22);
            this.txtVideoTitle.TabIndex = 0;
            // 
            // gridVideos
            // 
            this.gridVideos.AllowUserToAddRows = false;
            this.gridVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.VideoPath,
            this.StartTime,
            this.StopTime,
            this.Delete,
            this.Play});
            this.gridVideos.Location = new System.Drawing.Point(13, 203);
            this.gridVideos.Name = "gridVideos";
            this.gridVideos.RowTemplate.Height = 24;
            this.gridVideos.Size = new System.Drawing.Size(772, 179);
            this.gridVideos.TabIndex = 100;
            this.gridVideos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVideos_CellContentClick);
            this.gridVideos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridVideos_CellValidating);
            this.gridVideos.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVideos_RowValidated);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // VideoPath
            // 
            this.VideoPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VideoPath.DataPropertyName = "VideoPath";
            this.VideoPath.HeaderText = "Video file path / URL";
            this.VideoPath.Name = "VideoPath";
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "Start (s)";
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 88;
            // 
            // StopTime
            // 
            this.StopTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StopTime.DataPropertyName = "StopTime";
            this.StopTime.HeaderText = "Stop (s)";
            this.StopTime.Name = "StopTime";
            this.StopTime.Width = 87;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // Play
            // 
            this.Play.HeaderText = "";
            this.Play.Name = "Play";
            this.Play.Text = "Play";
            this.Play.UseColumnTextForButtonValue = true;
            this.Play.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Videos for this game:";
            // 
            // lblGridError
            // 
            this.lblGridError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGridError.AutoSize = true;
            this.lblGridError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGridError.Location = new System.Drawing.Point(745, 400);
            this.lblGridError.Name = "lblGridError";
            this.lblGridError.Size = new System.Drawing.Size(40, 17);
            this.lblGridError.TabIndex = 3;
            this.lblGridError.Text = "Error";
            this.lblGridError.Visible = false;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAll.Location = new System.Drawing.Point(12, 394);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(112, 29);
            this.btnSaveAll.TabIndex = 6;
            this.btnSaveAll.Text = "OK";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(130, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(700, 41);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(66, 22);
            this.txtStartTime.TabIndex = 2;
            this.txtStartTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // txtStopTime
            // 
            this.txtStopTime.Location = new System.Drawing.Point(700, 70);
            this.txtStopTime.Name = "txtStopTime";
            this.txtStopTime.Size = new System.Drawing.Size(66, 22);
            this.txtStopTime.TabIndex = 3;
            this.txtStopTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // VideoManagerForm
            // 
            this.AcceptButton = this.btnSaveAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(797, 435);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.lblGridError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridVideos);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(815, 482);
            this.Name = "VideoManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameVideoManagerForm";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.VideoManagerForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.GameVideoManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVideoTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.DataGridView gridVideos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGridError;
        private System.Windows.Forms.Button btnTestNewVideo;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel linkMoreInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopTime;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Play;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtStopTime;
    }
}
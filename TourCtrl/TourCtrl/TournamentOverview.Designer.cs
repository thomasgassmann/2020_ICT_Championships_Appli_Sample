namespace TourCtrl
{
    partial class TournamentOverview
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTournamentTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGame = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.listParticipants = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btFillRandom = new System.Windows.Forms.Button();
            this.btAddParticipant = new System.Windows.Forms.Button();
            this.lbTournamentSizeCount = new System.Windows.Forms.Label();
            this.lbParticipantCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbParticipantTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1252, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTournamentTitle
            // 
            this.lbTournamentTitle.AutoSize = true;
            this.lbTournamentTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTournamentTitle.Location = new System.Drawing.Point(12, 200);
            this.lbTournamentTitle.Name = "lbTournamentTitle";
            this.lbTournamentTitle.Size = new System.Drawing.Size(174, 96);
            this.lbTournamentTitle.TabIndex = 1;
            this.lbTournamentTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lbGame
            // 
            this.lbGame.AutoSize = true;
            this.lbGame.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGame.Location = new System.Drawing.Point(12, 296);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(161, 65);
            this.lbGame.TabIndex = 1;
            this.lbGame.Text = "Game:";
            // 
            // btExport
            // 
            this.btExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExport.Location = new System.Drawing.Point(1115, 323);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(149, 34);
            this.btExport.TabIndex = 2;
            this.btExport.Text = "Export Data";
            this.btExport.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 364);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1252, 682);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btEdit);
            this.tabPage1.Controls.Add(this.btRemove);
            this.tabPage1.Controls.Add(this.listParticipants);
            this.tabPage1.Controls.Add(this.btFillRandom);
            this.tabPage1.Controls.Add(this.btAddParticipant);
            this.tabPage1.Controls.Add(this.lbTournamentSizeCount);
            this.tabPage1.Controls.Add(this.lbParticipantCount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbParticipantTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1244, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tournament Size";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(999, 597);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(112, 34);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(1117, 597);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(112, 34);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // listParticipants
            // 
            this.listParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listParticipants.HideSelection = false;
            this.listParticipants.Location = new System.Drawing.Point(16, 212);
            this.listParticipants.Name = "listParticipants";
            this.listParticipants.Size = new System.Drawing.Size(1213, 379);
            this.listParticipants.TabIndex = 5;
            this.listParticipants.UseCompatibleStateImageBehavior = false;
            this.listParticipants.View = System.Windows.Forms.View.Details;
            this.listParticipants.SelectedIndexChanged += new System.EventHandler(this.listParticipants_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 300;
            // 
            // btFillRandom
            // 
            this.btFillRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFillRandom.Location = new System.Drawing.Point(183, 597);
            this.btFillRandom.Name = "btFillRandom";
            this.btFillRandom.Size = new System.Drawing.Size(168, 34);
            this.btFillRandom.TabIndex = 4;
            this.btFillRandom.Text = "Fill Random";
            this.btFillRandom.UseVisualStyleBackColor = true;
            this.btFillRandom.Click += new System.EventHandler(this.btFillRandom_Click);
            // 
            // btAddParticipant
            // 
            this.btAddParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddParticipant.Location = new System.Drawing.Point(16, 597);
            this.btAddParticipant.Name = "btAddParticipant";
            this.btAddParticipant.Size = new System.Drawing.Size(161, 34);
            this.btAddParticipant.TabIndex = 4;
            this.btAddParticipant.Text = " + Participant";
            this.btAddParticipant.UseVisualStyleBackColor = true;
            this.btAddParticipant.Click += new System.EventHandler(this.btAddParticipant_Click);
            // 
            // lbTournamentSizeCount
            // 
            this.lbTournamentSizeCount.AutoSize = true;
            this.lbTournamentSizeCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTournamentSizeCount.Location = new System.Drawing.Point(824, 113);
            this.lbTournamentSizeCount.Name = "lbTournamentSizeCount";
            this.lbTournamentSizeCount.Size = new System.Drawing.Size(45, 54);
            this.lbTournamentSizeCount.TabIndex = 3;
            this.lbTournamentSizeCount.Text = "0";
            // 
            // lbParticipantCount
            // 
            this.lbParticipantCount.AutoSize = true;
            this.lbParticipantCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbParticipantCount.Location = new System.Drawing.Point(271, 104);
            this.lbParticipantCount.Name = "lbParticipantCount";
            this.lbParticipantCount.Size = new System.Drawing.Size(45, 54);
            this.lbParticipantCount.TabIndex = 2;
            this.lbParticipantCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tournament Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Participants";
            // 
            // lbParticipantTitle
            // 
            this.lbParticipantTitle.AutoSize = true;
            this.lbParticipantTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbParticipantTitle.Location = new System.Drawing.Point(16, 20);
            this.lbParticipantTitle.Name = "lbParticipantTitle";
            this.lbParticipantTitle.Size = new System.Drawing.Size(118, 65);
            this.lbParticipantTitle.TabIndex = 0;
            this.lbParticipantTitle.Text = "Title";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1244, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matches";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TournamentOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 1058);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.lbGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTournamentTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TournamentOverview";
            this.ShowIcon = false;
            this.Text = "TournamentOverview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTournamentTitle;
        private System.Windows.Forms.Label lbGame;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbParticipantTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbParticipantCount;
        private System.Windows.Forms.Label lbTournamentSizeCount;
        private System.Windows.Forms.Button btFillRandom;
        private System.Windows.Forms.Button btAddParticipant;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListView listParticipants;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
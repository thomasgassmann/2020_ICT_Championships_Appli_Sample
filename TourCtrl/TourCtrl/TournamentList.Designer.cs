namespace TourCtrl
{
    partial class TournamentList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listTournaments = new System.Windows.Forms.ListView();
            this.btView = new System.Windows.Forms.Button();
            this.btAddTournament = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1201, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listTournaments
            // 
            this.listTournaments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTournaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listTournaments.FullRowSelect = true;
            this.listTournaments.HideSelection = false;
            this.listTournaments.Location = new System.Drawing.Point(12, 203);
            this.listTournaments.Name = "listTournaments";
            this.listTournaments.Size = new System.Drawing.Size(1201, 489);
            this.listTournaments.TabIndex = 1;
            this.listTournaments.UseCompatibleStateImageBehavior = false;
            this.listTournaments.View = System.Windows.Forms.View.Details;
            this.listTournaments.SelectedIndexChanged += new System.EventHandler(this.listTournaments_SelectedIndexChanged);
            // 
            // btView
            // 
            this.btView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btView.Location = new System.Drawing.Point(12, 698);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(112, 34);
            this.btView.TabIndex = 2;
            this.btView.Text = "View";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btAddTournament
            // 
            this.btAddTournament.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddTournament.Location = new System.Drawing.Point(919, 698);
            this.btAddTournament.Name = "btAddTournament";
            this.btAddTournament.Size = new System.Drawing.Size(294, 34);
            this.btAddTournament.TabIndex = 3;
            this.btAddTournament.Text = "+ Tournament";
            this.btAddTournament.UseVisualStyleBackColor = true;
            this.btAddTournament.Click += new System.EventHandler(this.btAddTournament_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Game";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Winner";
            this.columnHeader3.Width = 120;
            // 
            // TournamentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 744);
            this.Controls.Add(this.btAddTournament);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.listTournaments);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TournamentList";
            this.ShowIcon = false;
            this.Text = "Tournament List";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listTournaments;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Button btAddTournament;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}


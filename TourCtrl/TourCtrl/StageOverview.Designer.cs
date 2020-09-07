namespace TourCtrl
{
    partial class StageOverview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStage = new System.Windows.Forms.Label();
            this.lbMatches = new System.Windows.Forms.Label();
            this.lbParticipants = new System.Windows.Forms.Label();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbStage
            // 
            this.lbStage.AutoSize = true;
            this.lbStage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStage.Location = new System.Drawing.Point(12, 13);
            this.lbStage.Name = "lbStage";
            this.lbStage.Size = new System.Drawing.Size(108, 48);
            this.lbStage.TabIndex = 0;
            this.lbStage.Text = "Stage";
            // 
            // lbMatches
            // 
            this.lbMatches.AutoSize = true;
            this.lbMatches.Location = new System.Drawing.Point(288, 26);
            this.lbMatches.Name = "lbMatches";
            this.lbMatches.Size = new System.Drawing.Size(93, 25);
            this.lbMatches.TabIndex = 1;
            this.lbMatches.Text = "0 Matches";
            // 
            // lbParticipants
            // 
            this.lbParticipants.AutoSize = true;
            this.lbParticipants.Location = new System.Drawing.Point(464, 26);
            this.lbParticipants.Name = "lbParticipants";
            this.lbParticipants.Size = new System.Drawing.Size(117, 25);
            this.lbParticipants.TabIndex = 1;
            this.lbParticipants.Text = "0 Participants";
            // 
            // layoutPanel
            // 
            this.layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutPanel.AutoScroll = true;
            this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutPanel.Location = new System.Drawing.Point(12, 86);
            this.layoutPanel.MinimumSize = new System.Drawing.Size(0, 500);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(858, 500);
            this.layoutPanel.TabIndex = 2;
            // 
            // StageOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.lbParticipants);
            this.Controls.Add(this.lbMatches);
            this.Controls.Add(this.lbStage);
            this.Name = "StageOverview";
            this.Size = new System.Drawing.Size(884, 635);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStage;
        private System.Windows.Forms.Label lbMatches;
        private System.Windows.Forms.Label lbParticipants;
        protected System.Windows.Forms.FlowLayoutPanel layoutPanel;
    }
}

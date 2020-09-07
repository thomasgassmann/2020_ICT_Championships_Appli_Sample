namespace TourCtrl
{
    partial class EditTournament
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
            this.tbGame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCreate = new System.Windows.Forms.Button();
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGame
            // 
            this.tbGame.Location = new System.Drawing.Point(128, 21);
            this.tbGame.Name = "tbGame";
            this.tbGame.Size = new System.Drawing.Size(500, 31);
            this.tbGame.TabIndex = 0;
            this.tbGame.TextChanged += new System.EventHandler(this.tbGame_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // btCreate
            // 
            this.btCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCreate.Location = new System.Drawing.Point(530, 253);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(112, 34);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            // 
            // cbGame
            // 
            this.cbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Location = new System.Drawing.Point(128, 58);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(500, 33);
            this.cbGame.TabIndex = 3;
            this.cbGame.SelectedIndexChanged += new System.EventHandler(this.cbGame_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(128, 97);
            this.numSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(500, 31);
            this.numSize.TabIndex = 5;
            this.numSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size";
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorMessage.Location = new System.Drawing.Point(13, 181);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(19, 25);
            this.lbErrorMessage.TabIndex = 7;
            this.lbErrorMessage.Text = "-";
            // 
            // EditTournament
            // 
            this.AcceptButton = this.btCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 299);
            this.Controls.Add(this.lbErrorMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGame);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTournament";
            this.ShowIcon = false;
            this.Text = "Create Tournament";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTournament_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.ComboBox cbGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbErrorMessage;
    }
}
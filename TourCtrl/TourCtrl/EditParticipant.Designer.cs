namespace TourCtrl
{
    partial class EditParticipant
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPlayer = new System.Windows.Forms.RadioButton();
            this.rbTeam = new System.Windows.Forms.RadioButton();
            this.cbTemporary = new System.Windows.Forms.CheckBox();
            this.lbError = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(144, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(487, 31);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // rbPlayer
            // 
            this.rbPlayer.AutoSize = true;
            this.rbPlayer.Location = new System.Drawing.Point(144, 83);
            this.rbPlayer.Name = "rbPlayer";
            this.rbPlayer.Size = new System.Drawing.Size(84, 29);
            this.rbPlayer.TabIndex = 3;
            this.rbPlayer.TabStop = true;
            this.rbPlayer.Text = "Player";
            this.rbPlayer.UseVisualStyleBackColor = true;
            // 
            // rbTeam
            // 
            this.rbTeam.AutoSize = true;
            this.rbTeam.Location = new System.Drawing.Point(291, 83);
            this.rbTeam.Name = "rbTeam";
            this.rbTeam.Size = new System.Drawing.Size(78, 29);
            this.rbTeam.TabIndex = 3;
            this.rbTeam.TabStop = true;
            this.rbTeam.Text = "Team";
            this.rbTeam.UseVisualStyleBackColor = true;
            // 
            // cbTemporary
            // 
            this.cbTemporary.AutoSize = true;
            this.cbTemporary.Location = new System.Drawing.Point(13, 142);
            this.cbTemporary.Name = "cbTemporary";
            this.cbTemporary.Size = new System.Drawing.Size(122, 29);
            this.cbTemporary.TabIndex = 4;
            this.cbTemporary.Text = "Temporary";
            this.cbTemporary.UseVisualStyleBackColor = true;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.DarkRed;
            this.lbError.Location = new System.Drawing.Point(12, 194);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(19, 25);
            this.lbError.TabIndex = 5;
            this.lbError.Text = "-";
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(519, 218);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 34);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(401, 218);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 34);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditParticipant
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(643, 264);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.cbTemporary);
            this.Controls.Add(this.rbTeam);
            this.Controls.Add(this.rbPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditParticipant";
            this.ShowIcon = false;
            this.Text = "f";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditParticipant_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPlayer;
        private System.Windows.Forms.RadioButton rbTeam;
        private System.Windows.Forms.CheckBox cbTemporary;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}
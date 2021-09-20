
namespace ChatApp
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.buttonSendComment = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.dataGridCommentHistory = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCommentHistory = new System.Windows.Forms.Label();
            this.dataGridChat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCommentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSendComment
            // 
            this.buttonSendComment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSendComment.Location = new System.Drawing.Point(713, 409);
            this.buttonSendComment.Name = "buttonSendComment";
            this.buttonSendComment.Size = new System.Drawing.Size(155, 29);
            this.buttonSendComment.TabIndex = 6;
            this.buttonSendComment.Text = "Send";
            this.buttonSendComment.UseVisualStyleBackColor = true;
            this.buttonSendComment.Click += new System.EventHandler(this.buttonSendComment_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComment.Location = new System.Drawing.Point(12, 409);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(695, 29);
            this.textBoxComment.TabIndex = 7;
            // 
            // dataGridCommentHistory
            // 
            this.dataGridCommentHistory.AllowUserToAddRows = false;
            this.dataGridCommentHistory.AllowUserToDeleteRows = false;
            this.dataGridCommentHistory.AllowUserToResizeColumns = false;
            this.dataGridCommentHistory.AllowUserToResizeRows = false;
            this.dataGridCommentHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCommentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCommentHistory.ColumnHeadersVisible = false;
            this.dataGridCommentHistory.Location = new System.Drawing.Point(713, 38);
            this.dataGridCommentHistory.Name = "dataGridCommentHistory";
            this.dataGridCommentHistory.RowTemplate.Height = 25;
            this.dataGridCommentHistory.Size = new System.Drawing.Size(303, 365);
            this.dataGridCommentHistory.TabIndex = 8;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(874, 409);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(142, 29);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCommentHistory
            // 
            this.labelCommentHistory.AutoSize = true;
            this.labelCommentHistory.BackColor = System.Drawing.Color.Transparent;
            this.labelCommentHistory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCommentHistory.Location = new System.Drawing.Point(713, 13);
            this.labelCommentHistory.Name = "labelCommentHistory";
            this.labelCommentHistory.Size = new System.Drawing.Size(128, 19);
            this.labelCommentHistory.TabIndex = 10;
            this.labelCommentHistory.Text = "Comment History";
            // 
            // dataGridChat
            // 
            this.dataGridChat.AllowUserToAddRows = false;
            this.dataGridChat.AllowUserToDeleteRows = false;
            this.dataGridChat.AllowUserToResizeColumns = false;
            this.dataGridChat.AllowUserToResizeRows = false;
            this.dataGridChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridChat.ColumnHeadersVisible = false;
            this.dataGridChat.Location = new System.Drawing.Point(12, 38);
            this.dataGridChat.Name = "dataGridChat";
            this.dataGridChat.RowTemplate.Height = 25;
            this.dataGridChat.Size = new System.Drawing.Size(695, 365);
            this.dataGridChat.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chat Room";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridChat);
            this.Controls.Add(this.labelCommentHistory);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridCommentHistory);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonSendComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCommentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.DataGridView dataGridCommentHistory;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCommentHistory;
        private System.Windows.Forms.DataGridView dataGridChat;
        private System.Windows.Forms.Label label1;
    }
}
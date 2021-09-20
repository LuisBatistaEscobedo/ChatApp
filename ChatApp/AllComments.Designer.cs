
namespace ChatApp
{
    partial class AllComments
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
            this.gridAllComments = new System.Windows.Forms.DataGridView();
            this.buttonAllCommentsExit = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllComments)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAllComments
            // 
            this.gridAllComments.AllowUserToAddRows = false;
            this.gridAllComments.AllowUserToDeleteRows = false;
            this.gridAllComments.AllowUserToResizeColumns = false;
            this.gridAllComments.AllowUserToResizeRows = false;
            this.gridAllComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllComments.Location = new System.Drawing.Point(12, 12);
            this.gridAllComments.Name = "gridAllComments";
            this.gridAllComments.RowTemplate.Height = 25;
            this.gridAllComments.Size = new System.Drawing.Size(780, 392);
            this.gridAllComments.TabIndex = 1;
            // 
            // buttonAllCommentsExit
            // 
            this.buttonAllCommentsExit.Location = new System.Drawing.Point(798, 41);
            this.buttonAllCommentsExit.Name = "buttonAllCommentsExit";
            this.buttonAllCommentsExit.Size = new System.Drawing.Size(96, 23);
            this.buttonAllCommentsExit.TabIndex = 6;
            this.buttonAllCommentsExit.Text = "Exit";
            this.buttonAllCommentsExit.UseVisualStyleBackColor = true;
            this.buttonAllCommentsExit.Click += new System.EventHandler(this.buttonAllCommentsExit_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(798, 12);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(96, 23);
            this.buttonDrop.TabIndex = 4;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // AllComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 416);
            this.Controls.Add(this.buttonAllCommentsExit);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.gridAllComments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllComments";
            this.Load += new System.EventHandler(this.AllComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllComments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAllComments;
        private System.Windows.Forms.Button buttonAllCommentsExit;
        private System.Windows.Forms.Button buttonDrop;
    }
}
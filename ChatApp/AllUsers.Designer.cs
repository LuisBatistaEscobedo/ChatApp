
namespace ChatApp
{
    partial class AllUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllUsers));
            this.gridAllUsers = new System.Windows.Forms.DataGridView();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.buttonStatusChange = new System.Windows.Forms.Button();
            this.buttonAllUsersExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAllUsers
            // 
            this.gridAllUsers.AllowUserToAddRows = false;
            this.gridAllUsers.AllowUserToDeleteRows = false;
            this.gridAllUsers.AllowUserToResizeColumns = false;
            this.gridAllUsers.AllowUserToResizeRows = false;
            this.gridAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllUsers.Location = new System.Drawing.Point(12, 12);
            this.gridAllUsers.Name = "gridAllUsers";
            this.gridAllUsers.RowTemplate.Height = 25;
            this.gridAllUsers.Size = new System.Drawing.Size(405, 318);
            this.gridAllUsers.TabIndex = 0;
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(423, 12);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(96, 23);
            this.buttonDrop.TabIndex = 1;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // buttonStatusChange
            // 
            this.buttonStatusChange.Location = new System.Drawing.Point(423, 41);
            this.buttonStatusChange.Name = "buttonStatusChange";
            this.buttonStatusChange.Size = new System.Drawing.Size(96, 23);
            this.buttonStatusChange.TabIndex = 2;
            this.buttonStatusChange.Text = "Status Change";
            this.buttonStatusChange.UseVisualStyleBackColor = true;
            this.buttonStatusChange.Click += new System.EventHandler(this.buttonStatusChange_Click);
            // 
            // buttonAllUsersExit
            // 
            this.buttonAllUsersExit.Location = new System.Drawing.Point(423, 70);
            this.buttonAllUsersExit.Name = "buttonAllUsersExit";
            this.buttonAllUsersExit.Size = new System.Drawing.Size(96, 23);
            this.buttonAllUsersExit.TabIndex = 3;
            this.buttonAllUsersExit.Text = "Exit";
            this.buttonAllUsersExit.UseVisualStyleBackColor = true;
            this.buttonAllUsersExit.Click += new System.EventHandler(this.buttonAllUsersExit_Click);
            // 
            // AllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 338);
            this.Controls.Add(this.buttonAllUsersExit);
            this.Controls.Add(this.buttonStatusChange);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.gridAllUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllUsers";
            this.Load += new System.EventHandler(this.AllUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAllUsers;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Button buttonStatusChange;
        private System.Windows.Forms.Button buttonAllUsersExit;
    }
}
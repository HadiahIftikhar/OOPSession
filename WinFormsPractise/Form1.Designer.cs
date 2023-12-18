namespace WinFormsPractise
{
    partial class Form1
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
            txtDeleteaccount = new Button();
            txtAdduser = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtupdateuser = new Button();
            label4 = new Label();
            GridViewUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // txtDeleteaccount
            // 
            txtDeleteaccount.Location = new Point(2, 152);
            txtDeleteaccount.Name = "txtDeleteaccount";
            txtDeleteaccount.Size = new Size(106, 23);
            txtDeleteaccount.TabIndex = 0;
            txtDeleteaccount.Text = "DeleteAccount";
            txtDeleteaccount.UseVisualStyleBackColor = true;
            txtDeleteaccount.UseWaitCursor = true;
            txtDeleteaccount.Click += txtAdduser_Click;
            // 
            // txtAdduser
            // 
            txtAdduser.BackColor = SystemColors.Control;
            txtAdduser.ForeColor = SystemColors.ActiveCaptionText;
            txtAdduser.Location = new Point(228, 152);
            txtAdduser.Name = "txtAdduser";
            txtAdduser.Size = new Size(106, 23);
            txtAdduser.TabIndex = 1;
            txtAdduser.Text = "AddAccount\r\n\r\n";
            txtAdduser.UseVisualStyleBackColor = false;
            txtAdduser.UseWaitCursor = true;
            txtAdduser.Click += txtDeleteuser_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 4;
            textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 5;
            textBox2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 6;
            textBox3.UseWaitCursor = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 7;
            label1.Text = "Account Number";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 61);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 8;
            label2.Text = "Account Holder Name";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 105);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "Balance";
            label3.UseWaitCursor = true;
            // 
            // txtupdateuser
            // 
            txtupdateuser.BackColor = SystemColors.Control;
            txtupdateuser.ForeColor = SystemColors.ActiveCaptionText;
            txtupdateuser.Location = new Point(114, 152);
            txtupdateuser.Name = "txtupdateuser";
            txtupdateuser.Size = new Size(106, 23);
            txtupdateuser.TabIndex = 10;
            txtupdateuser.Text = "UpdateAccount";
            txtupdateuser.UseVisualStyleBackColor = false;
            txtupdateuser.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(34, 187);
            label4.Name = "label4";
            label4.Size = new Size(268, 20);
            label4.TabIndex = 11;
            label4.Text = "All Accounts in the System";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // GridViewUsers
            // 
            GridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewUsers.Location = new Point(2, 219);
            GridViewUsers.Name = "GridViewUsers";
            GridViewUsers.RowTemplate.Height = 25;
            GridViewUsers.Size = new Size(332, 170);
            GridViewUsers.TabIndex = 12;
            GridViewUsers.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(335, 391);
            Controls.Add(GridViewUsers);
            Controls.Add(label4);
            Controls.Add(txtupdateuser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtAdduser);
            Controls.Add(txtDeleteaccount);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "First Page";
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtDeleteaccount;
        private Button txtAdduser;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button txtupdateuser;
        private Label label4;
        private DataGridView GridViewUsers;
    }
}
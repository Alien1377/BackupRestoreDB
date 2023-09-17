namespace BackupRestoreDB
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
            Btn_Backup = new Button();
            Btn_Restore = new Button();
            T_Server = new TextBox();
            label1 = new Label();
            label2 = new Label();
            T_DataBase = new TextBox();
            T_User = new TextBox();
            label3 = new Label();
            T_Message = new TextBox();
            SuspendLayout();
            // 
            // Btn_Backup
            // 
            Btn_Backup.Location = new Point(33, 321);
            Btn_Backup.Name = "Btn_Backup";
            Btn_Backup.Size = new Size(368, 45);
            Btn_Backup.TabIndex = 0;
            Btn_Backup.Text = "Backup";
            Btn_Backup.UseVisualStyleBackColor = true;
            Btn_Backup.Click += Btn_Backup_Click;
            // 
            // Btn_Restore
            // 
            Btn_Restore.Location = new Point(33, 391);
            Btn_Restore.Name = "Btn_Restore";
            Btn_Restore.Size = new Size(368, 45);
            Btn_Restore.TabIndex = 1;
            Btn_Restore.Text = "Restore";
            Btn_Restore.UseVisualStyleBackColor = true;
            Btn_Restore.Click += Btn_Restore_Click;
            // 
            // T_Server
            // 
            T_Server.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            T_Server.Location = new Point(33, 53);
            T_Server.Name = "T_Server";
            T_Server.Size = new Size(368, 30);
            T_Server.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 17);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 3;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 108);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 5;
            label2.Text = "DataBase";
            // 
            // T_DataBase
            // 
            T_DataBase.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            T_DataBase.Location = new Point(33, 144);
            T_DataBase.Name = "T_DataBase";
            T_DataBase.Size = new Size(368, 30);
            T_DataBase.TabIndex = 4;
            // 
            // T_User
            // 
            T_User.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            T_User.Location = new Point(33, 242);
            T_User.Name = "T_User";
            T_User.Size = new Size(368, 30);
            T_User.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 207);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 7;
            label3.Text = "User";
            // 
            // T_Message
            // 
            T_Message.Location = new Point(33, 461);
            T_Message.Multiline = true;
            T_Message.Name = "T_Message";
            T_Message.ReadOnly = true;
            T_Message.Size = new Size(368, 115);
            T_Message.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 588);
            Controls.Add(T_Message);
            Controls.Add(label3);
            Controls.Add(T_User);
            Controls.Add(label2);
            Controls.Add(T_DataBase);
            Controls.Add(label1);
            Controls.Add(T_Server);
            Controls.Add(Btn_Restore);
            Controls.Add(Btn_Backup);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Backup;
        private Button Btn_Restore;
        private TextBox T_Server;
        private Label label1;
        private Label label2;
        private TextBox T_DataBase;
        private TextBox T_User;
        private Label label3;
        private TextBox T_Message;
    }
}
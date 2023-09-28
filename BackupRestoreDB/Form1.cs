using System.Data.SqlClient;

namespace BackupRestoreDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetConnection()
        {
            return "Server=" + T_Server.Text + ";MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;";

            //return "Server=" + T_Server.Text + ";Database=" + T_DataBase.Text + ";MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        private void Btn_Backup_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnection()))
                using (SqlCommand command = connection.CreateCommand())
                {
                    string backupQuery = $"BACKUP DATABASE " + T_DataBase.Text + " TO DISK = 'C:\\Backup\\" + T_DataBase.Text + ".bak'";

                    connection.Open();

                    command.CommandText = backupQuery;
                    command.ExecuteNonQuery();

                    T_Message.Text = "Backup created successfully!";

                }
            }
            catch (Exception ex)
            {
                T_Message.Text = $"Error creating backup: {ex.Message}";
            }
        }

        private void Btn_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnection()))
                using (SqlCommand command = connection.CreateCommand())
                {
                    string restoreQuery =
                        //$@"IF DB_ID('" + T_DataBase.Text + "') IS NULL CREATE DATABASE " + T_DataBase.Text +
                        $" RESTORE DATABASE " + T_DataBase.Text + $" FROM DISK = 'C:\\Backup\\" + T_DataBase.Text + ".bak' WITH REPLACE, "
                        + $"MOVE '" + T_DataBase.Text + $"' TO 'C:\\Users\\" + T_User.Text + "\\" + T_DataBase.Text + ".mdf', " +
                        $"MOVE '" + T_DataBase.Text + $"_log' TO 'C:\\Users\\" + T_User.Text + "\\" + T_DataBase.Text + "_log.ldf';"
                        ;

                    connection.Open();

                    command.CommandText = restoreQuery;
                    command.ExecuteNonQuery();
                     
                    T_Message.Text = "Database restored successfully!";

                }
            }
            catch (Exception ex)
            {
                T_Message.Text = $"Error restoring database: {ex.Message}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(AppContext.BaseDirectory.Replace(@"\", @"\\") + "Backup\\");

            T_Server.Text = "(LocalDB)\\MSSQLLocalDB";

            T_DataBase.Text = "MedicalVideoRecorder";

            T_User.Text = "Alien";

            if (!Directory.Exists($"C:\\Backup"))
                Directory.CreateDirectory($"C:\\Backup");

        }
    }
}
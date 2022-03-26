using MySql.Data.MySqlClient;

namespace mCloudB.services.connectors
{
    internal class dbapp
    {
        public MySqlConnection conString;
        public MySqlCommand conCommand;

        public MySqlConnection ConString { get => conString; set => conString = value; }
        public MySqlCommand ConCommand { get => conCommand; set => conCommand = value; }

        public dbapp()
        {
            conString = new MySqlConnection(@"server=localhost;port=3306;database=myanledger;uid=root;pwd=");
            conCommand = conString.CreateCommand();
            conCommand.CommandType = System.Data.CommandType.Text;
        }
    }
}

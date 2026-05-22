using MySql.Data.MySqlClient;

namespace DentalClinic
{
    public class DBConnection
    {
        public MySqlConnection conn = new MySqlConnection(
            "Server=localhost;Port=3307;Database=clinic_system;User ID=root;Password=05050505He_;"
        );
    }
}
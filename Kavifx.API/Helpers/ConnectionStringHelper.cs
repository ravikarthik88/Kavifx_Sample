namespace Kavifx.API.Helpers
{
    public static class ConnectionStringHelper
    {
        public static string BuildConnectionString(IConfiguration config)
        {
            var host = config["mysql:DBHOST"] ?? "192.168.80.147";
            var port = config["mysql:PORT"] ?? "3306";
            var password = config["mysql:PASSWORD"] ?? "password";
            var userId = config["mysql:USERID"] ?? "root";
            var database = config["mysql:DATABASE"] ?? "AppDB";

            return $"server={host};port={port};userid={userId};pwd={password};database={database}";
        }
    }

}

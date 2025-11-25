namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType type)
        {
            if (type == DatabaseType.SqlServer)
            {
                return new SqlServerDatabase();
            }
            else if (type == DatabaseType.Oracle)
            {
                return new OracleDatabase();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(type), "Invalid type of database provided");
            }
            
        }
    }
}
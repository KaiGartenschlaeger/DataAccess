namespace System.Data
{
    public static class DataReaderExtensions
    {
        #region Methods

        public static string GetString(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetString(columnIndex);
            }

            return default(string);
        }

        public static byte? GetByte(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetByte(columnIndex);
            }

            return null;
        }

        public static int? GetInt32(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetInt32(columnIndex);
            }

            return null;
        }

        public static DateTime? GetDateTime(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetDateTime(columnIndex);
            }

            return null;
        }

        public static bool? GetBoolean(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetBoolean(columnIndex);
            }

            return null;
        }

        public static object GetValue(this IDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetValue(columnIndex);
            }

            return null;
        }

        #endregion
    }
}
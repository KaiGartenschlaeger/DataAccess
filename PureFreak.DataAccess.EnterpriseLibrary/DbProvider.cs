using Microsoft.Practices.EnterpriseLibrary.Data;
using System;

namespace PureFreak.DataAccess.EnterpriseLibrary
{
    public class DbProvider : DataProvider
    {
        #region Fields

        private Database _database;

        #endregion

        #region Constructor

        public DbProvider(string connectionStringName)
        {
            if (string.IsNullOrEmpty(connectionStringName))
            {
                throw new ArgumentException($"{nameof(connectionStringName)} cannot be empty");
            }

            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            _database = factory.Create(connectionStringName);
        }

        #endregion

        #region Methods

        public static DbProvider Create(string connectionStringName)
        {
            return new DbProvider(connectionStringName);
        }

        #endregion

        #region Properties

        public Database Database
        {
            get { return _database; }
        }

        #endregion
    }
}
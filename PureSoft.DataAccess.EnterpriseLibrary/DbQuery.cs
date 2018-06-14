using Microsoft.Practices.EnterpriseLibrary.Data;

namespace PureSoft.DataAccess.EnterpriseLibrary
{
    public abstract class DbQuery : DataQuery<DbProvider>
    {
        public DbQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbQuery<TOutput> : DataQuery<DbProvider, TOutput>
    {
        public DbQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbQuery<TInput, TOutput> : DataQuery<DbProvider, TInput, TOutput>
    {
        public DbQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbQuery<TInput1, TInput2, TOutput> : DataQuery<DbProvider, TInput1, TInput2, TOutput>
    {
        public DbQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbQuery<TInput1, TInput2, TInput3, TOutput> : DataQuery<DbProvider, TInput1, TInput2, TInput3, TOutput>
    {
        public DbQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbQuery<TInput1, TInput2, TInput3, TInput4, TOutput> : DataQuery<DbProvider, TInput1, TInput2, TInput3, TInput4, TOutput>
    {
        public DbQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbQuery<TInput1, TInput2, TInput3, TInput4, TInput5, TOutput> : DataQuery<DbProvider, TInput1, TInput2, TInput3, TInput4, TInput5, TOutput>
    {
        public DbQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }
}
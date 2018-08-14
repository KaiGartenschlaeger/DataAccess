using Microsoft.Practices.EnterpriseLibrary.Data;

namespace PureFreak.DataAccess.EnterpriseLibrary
{
    public abstract class DbInputQuery<TInput> : DataInputQuery<DbProvider, TInput>
    {
        public DbInputQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbInputQuery<TInput1, TInput2> : DataInputQuery<DbProvider, TInput1, TInput2>
    {
        public DbInputQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbInputQuery<TInput1, TInput2, TInput3> : DataInputQuery<DbProvider, TInput1, TInput2, TInput3>
    {
        public DbInputQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbInputQuery<TInput1, TInput2, TInput3, TInput4> : DataInputQuery<DbProvider, TInput1, TInput2, TInput3, TInput4>
    {
        public DbInputQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }

    public abstract class DbInputQuery<TInput1, TInput2, TInput3, TInput4, TInput5> : DataInputQuery<DbProvider, TInput1, TInput2, TInput3, TInput4, TInput5>
    {
        public DbInputQuery(DbProvider dataProvider)
            : base(dataProvider)
        {
        }

        public Database Database
        {
            get { return Provider.Database; }
        }
    }
}
namespace PureFreak.DataAccess
{
    public abstract class DataInputQuery<TDataProvider, TInput> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataInputQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract void Execute(TInput input);
    }

    public abstract class DataInputQuery<TDataProvider, TInput1, TInput2> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataInputQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract void Execute(TInput1 input, TInput2 input2);
    }

    public abstract class DataInputQuery<TDataProvider, TInput1, TInput2, TInput3> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataInputQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract void Execute(TInput1 input, TInput2 input2, TInput3 input3);
    }

    public abstract class DataInputQuery<TDataProvider, TInput1, TInput2, TInput3, TInput4> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataInputQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract void Execute(TInput1 input, TInput2 input2, TInput3 input3, TInput4 input4);
    }

    public abstract class DataInputQuery<TDataProvider, TInput1, TInput2, TInput3, TInput4, TInput5> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataInputQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract void Execute(TInput1 input, TInput2 input2, TInput3 input3, TInput4 input4, TInput5 input5);
    }
}
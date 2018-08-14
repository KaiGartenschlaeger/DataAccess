namespace PureFreak.DataAccess
{
    public abstract class DataQuery<TDataProvider> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract void Execute();
    }

    public abstract class DataQuery<TDataProvider, TOutput> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract TOutput Execute();
    }

    public abstract class DataQuery<TDataProvider, TInput, TOutput> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract TOutput Execute(TInput input);
    }

    public abstract class DataQuery<TDataProvider, TInput1, TInput2, TOutput> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract TOutput Execute(TInput1 input, TInput2 input2);
    }

    public abstract class DataQuery<TDataProvider, TInput1, TInput2, TInput3, TOutput> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract TOutput Execute(TInput1 input, TInput2 input2, TInput3 input3);
    }

    public abstract class DataQuery<TDataProvider, TInput1, TInput2, TInput3, TInput4, TOutput> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract TOutput Execute(TInput1 input, TInput2 input2, TInput3 input3, TInput4 input4);
    }

    public abstract class DataQuery<TDataProvider, TInput1, TInput2, TInput3, TInput4, TInput5, TOutput> : DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        public DataQuery(TDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        public abstract TOutput Execute(TInput1 input, TInput2 input2, TInput3 input3, TInput4 input4, TInput5 input5);
    }
}
using System;

namespace PureFreak.DataAccess
{
    public abstract class DataQueryBase<TDataProvider>
        where TDataProvider : DataProvider
    {
        #region Fields

        private readonly TDataProvider _dataProvider;

        #endregion

        #region Constructor

        public DataQueryBase(TDataProvider dataProvider)
        {
            if (dataProvider == null)
            {
                throw new ArgumentNullException(nameof(dataProvider));
            }

            _dataProvider = dataProvider;
        }

        #endregion

        #region Methods

        #endregion

        #region Properties

        protected TDataProvider Provider
        {
            get { return _dataProvider; }
        }

        #endregion
    }
}
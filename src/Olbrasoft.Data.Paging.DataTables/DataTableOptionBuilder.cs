﻿namespace Olbrasoft.Data.Paging.DataTables
{
    public class DataTableOptionBuilder : IDataTableOptionBuilder
    {
        public DataTableQueryOption BuildOption(DataTableModel model, string defaultColumnName)
        {
            var result = new DataTableQueryOption
            {
                Search = model.Search.Value,
                Direction = OrderDirection.Asc,
                Column = defaultColumnName
            };

            var page = 1;

            if (model.Start != 0)
            {
                page = model.Start / model.Length + 1;
            }

            result.Paging = new PageInfo(model.Length, page);

            if (model.Order != null)
            {
                // in this example we just default sort on the 1st column
                result.Column = model.Columns[model.Order[0].Column].Name;

                if (model.Order[0].Dir.ToString().ToLower() == nameof(OrderDirection.Desc).ToLower())
                {
                    result.Direction = OrderDirection.Desc;
                }
            }

            return result;
        }
    }
}
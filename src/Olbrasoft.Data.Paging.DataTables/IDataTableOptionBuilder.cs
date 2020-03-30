namespace Olbrasoft.Data.Paging.DataTables
{
    public interface IDataTableOptionBuilder
    {
        DataTableQueryOption BuildOption(DataTableModel model, string defaultColumnName);
    }
}
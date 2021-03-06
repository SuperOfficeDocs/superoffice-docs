//Explicit conversion class that converts the list to be converted to a data table.
public class CoreWebList<T> : List<T>
{
  //Variable declarations
  private static bool _enforceKeys;
  //Class Constructor
  public CoreWebList()
  {
    _enforceKeys = false;
  }
  
  //Get / Set method
  public bool DataTableEnforceKeys
  {
    get { return _enforceKeys; }
    set { _enforceKeys = value; }
  }
  
  //List to data table conversion method
  static explicit operator DataTable(CoreWebList<T> wblist)
  {
    DataTableConverter<T> converter = new DataTableConverter<T>(_enforceKeys);
    return converter.GetDataTable(wblist);
  }
}
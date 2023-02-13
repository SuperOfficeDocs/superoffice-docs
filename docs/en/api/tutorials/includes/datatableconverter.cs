//The class uses the System.Reflection namespace to query attributes at run-time
//and builds a builds a data table schema and fill it.
public class DataTableConverter<T>
{
  //Variable Declaration
  private bool _enforceKeys;

  //Class constructors
  public DataTableConverter() { }

  public DataTableConverter(bool enforceKeys)
  {
    _enforceKeys = enforceKeys;
  }
  public DataTable GetDataTable(List<T> listItems)
  {
    DataTable newDatTbl;
    // Build a table schema from the first element in the collection
    newDatTbl = this.ConstructDataTableSchema(listItems[0]);

    // Create a new row for every item in the collection and fill it.
    for (int i = 0; i < listItems.Count; i++)
    {
      DataRow newDataRow = newDatTbl.NewRow();
      Type newType = listItems[i].GetType();
      MemberInfo[] newMembers = newType.GetProperties();
      foreach (MemberInfo newMember in newMembers)
      {
        object[] mewAtts = newMember.GetCustomAttributes(true);
        if (mewAtts.Length != 0)
        {
          foreach (object mewAtt in mewAtts)
          {
            ConversionAttribute newConAtt = mewAtt as ConversionAttribute;
            if (newConAtt != null)
            {
              if (newConAtt.ConvertDataTable)
              {
                string[] newNameArr = newMember.Name.ToString().Split(Convert.ToChar(" "));
                PropertyInfo newPropInfo = newType.GetProperty(newNameArr[0]);
                Type newValType = newPropInfo.GetValue(listItems[i], null).GetType();
                newDataRow[newNameArr[0]] = newPropInfo.GetValue(listItems[i], null);
              }
            }
          }
        }
      }
      newDatTbl.Rows.Add(newDataRow);
    }
    return newDatTbl;
  }

  // This method reads the attributes of your container class via reflection in order to
  // build a schema for the DataTable that you will explicitly convert to.
  private DataTable ConstructDataTableSchema(T item)
  {
    string tblName = string.Empty;
    List<DataTableConverterContainer> schCon = new List<DataTableConverterContainer>();
    Type newType = item.GetType();
    MemberInfo[] newMemsInfo = newType.GetProperties();

    foreach (MemberInfo newMemInfo in newMemsInfo)
    {
      object[] newAtts = newMemInfo.GetCustomAttributes(true);
      if (newAtts.Length != 0)
      {
        foreach (object newAtt in newAtts)
        {
          ConversionAttribute newConAtt = newAtt as ConversionAttribute;
          if (newConAtt != null)
          {
            if (newConAtt.ConvertDataTable)
            {
              // The name of the container class is used to name your DataTable
              string[] newClsNameArr = newMemInfo.ReflectedType.ToString().Split(Convert.ToChar("."));
              tblName = newClsNameArr[newClsNameArr.Length - 1];
              string newName = newMemInfo.Name.ToString();
              PropertyInfo propInfo = newType.GetProperty(newName);
              Type NewValType = propInfo.GetValue(item, null).GetType();

              // Each property that is will be a column in our DataTable.
              schCon.Add(new DataTableConverterContainer(newName, NewValType, newConAtt.DBNull, newConAtt.KeyFields));
            }
          }
        }
      }
    }
    if (schCon.Count > 0)
    {
      DataTable newDataTbl = new DataTable(tblName);
      DataColumn[] newDataCol = new DataColumn[schCon.Count];

      // Counts the number of keys that will need to be created
      int numberOfKeys = 0;
      foreach (DataTableConverterContainer newContainer in schCon)
      {
        if (newContainer.CheckKey == true && _enforceKeys == true)
        {
           numberOfKeys = numberOfKeys + 1;
        }
      }

      // Builds the DataColumns for our DataTable
      DataColumn[] newKeyColArr = new DataColumn[numberOfKeys];
      int keyColIdx = 0;
      for (int i = 0; i < schCon.Count; i++)
      {
        newDataCol[i] = new DataColumn();
        newDataCol[i].DataType = schCon[i].PropType;
        newDataCol[i].ColumnName = schCon[i].PropName;
        newDataCol[i].AllowDBNull = schCon[i].CheckDbNull;
        newDataTbl.Columns.Add(newDataCol[i]);
        if (schCon[i].CheckKey == true && _enforceKeys == true)
        {
          newKeyColArr[keyColIdx] = newDataCol[i];
          keyColIdx = keyColIdx + 1;
        }
      }
      if (_enforceKeys)
      {
        newDataTbl.PrimaryKey = newKeyColArr;
      }
      return newDataTbl;
    }
    return null;
  }

  #region Internal Classes
  private class DataTableConverterContainer
  {
    //Internal class variables
    private string _propName;
    private Type _propType;
    private bool _DbNull;
    private bool _Key;

    //Internal Class Constructor
    internal DataTableConverterContainer(string propName, Type propType, bool DbNull, bool Key)
    {
      _propName = propName;
      _propType = propType;
      _DbNull = DbNull;
      _Key = Key;
    }

    //Get / Set methods
    public string PropName
    {
      get { return _propName; }
      set { _propName = value; }
    }

    public Type PropType
    {
      get { return _propType; }
      set { _propType = value; }
    }

    public bool CheckDbNull
    {
      get { return _DbNull; }
      set { _DbNull = value; }
    }

    public bool CheckKey
    {
      get { return _Key; }
      set { _Key = value; }
    }
  }
  #endregion
}
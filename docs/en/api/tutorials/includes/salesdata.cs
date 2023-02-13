//The Container class for the Sale information
public class SalesData
  {
  string _proName;
  string _SalAmnt;
  string _SalEarnPer;

  //Class constructor
  public SalesData(string proName, string salAmnt, string salEarnPer)
  {
    _ proName = proName;
    _SalAmnt = salAmnt;
    _SalEarnPer = salEarnPer;
  }

  //Conversion methods for each property 
  [Conversion(ConvertDataTable = true, KeyFields = true, DBNull = false)]
  public string ProName
  {
    get { return _ proName; }
    set { _ proName = value; }
  }
  
  [Conversion(ConvertDataTable = true, KeyFields = true, DBNull = false)]
  public string SalAmnt
  {
    get { return _SalAmnt; }
    set { _SalAmnt = value; }
  }
  
  [Conversion(ConvertDataTable = true, KeyFields = true, DBNull = false)]
  public string SalEarnPer
  {
    get { return _SalEarnPer; }
    set { _SalEarnPer = value; }
  }
}
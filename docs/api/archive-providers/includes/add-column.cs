[ArchiveExtenderExtender("MySaleTableExtender", typeof(SaleExtenderBase), int.MaxValue / 2)]
public class MySaleTablelSystem : TableExtenderBase<TableInfo>
{
  private ArchiveColumnInfo _colMySaleId = 
    new ArchiveColumnInfo("mySaleId", "My Sale Record Identifier", "My Sale Record Identifer Tooltip",
    Constants.DisplayTypes.Int, true, true, "5c", Constants.RestrictionTypes.Int);
  private ArchiveColumnInfo _colMySaleName = 
    new ArchiveColumnInfo("mySaleName", "My Sale Name", "My Sale Name Tooltip",
    Constants.DisplayTypes.String, true, true, "10%", Constants.RestrictionTypes.String);
  public MySaleTablelSystem()
  {
    // Uncomment following line to force restriction to invoke InnerModifyQuery
    // ForceRestriction = true;
  }
  protected override void InnerModifyQuery()
  {
    //RootQuery.Query.ReturnFields.Add(...)
  }
  protected override TableInfo SetJoin()
  {
    var parentSaleInfo = Parent.TableToExtend as SaleTableInfo;
    //... establish joins
    return parentSaleInfo;
  }
  protected override void InnerPopulateRowFromReader(SoDataReader reader, ArchiveRow row)
  {
    // use this overload to add columns to archiverow / output
  }
}
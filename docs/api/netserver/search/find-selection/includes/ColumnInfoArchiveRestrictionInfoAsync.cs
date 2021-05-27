private async void ColumnInfoArchiveRestrictionInfoAsync(Tenant tenant)
{
  // not important for the sake of this example
  var config = GetWebApiConfiguration(tenant); 

  var archiveAgent = new ArchiveAgent(config);
  var mdoAgent = new MDOAgent(config);

  // get available entities and columns (cache these in production!)

  MDOListItem[] entities = await archiveAgent.GetAvailableEntitiesAsync("ContactPersonDynamicSelectionV2", "");
  ArchiveColumnInfo[] columns = await archiveAgent.GetAvailableColumnsAsync("ContactPersonDynamicSelectionV2", "");

  // get companyId field

  ArchiveColumnInfo companyIdColumn = columns
      .Where(c => c.Name.Equals("contactId", StringComparison.OrdinalIgnoreCase))
      .Select(c => c).First(); // throw if not found

  // get all operators for the companyId column data type (cache these in production)

  MDOListItem[] operators = await mdoAgent.GetListAsync(
      "restrictionOperators", 
      true, 
      companyIdColumn.RestrictionType,
      false);

  // get just the equals operator

  MDOListItem equalsOperator = operators
      .Where(o => o.Name.Equals("Equals", StringComparison.OrdinalIgnoreCase))
      .Select(o => o).First(); // throw if not found

  // instantiate an ArchiveRestrictionInfo
  // set the ColumnInfo, set to active, and specify the criteria "contactId is 5"

  var restriction = new ArchiveRestrictionInfo()
  {
      ColumnInfo = companyIdColumn,
      IsActive = true,
      Name = companyIdColumn.Name,
      Operator = equalsOperator.Type, // "is"
      Values = new[] { "5" }
  };
}
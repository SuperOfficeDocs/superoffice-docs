private async Task<ArchiveRestrictionGroup[]> SetPersonSearchCriteria(
    ArchiveAgent archiveAgent,
    SelectionAgent selectionAgent,
    MDOAgent mdoAgent,
    SelectionForFind selectionForFind)
{
    // get archive provider columns

    ArchiveColumnInfo[] columns = await archiveAgent.GetAvailableColumnsAsync(
        selectionForFind.ProviderName,
        "");

    // get just the first and last name columns

    var firstNameColumn = columns.Where(c => c.Name == "firstName").Select(c => c).FirstOrDefault();
    var lastNameColumn = columns.Where(c => c.Name == "lastName").Select(c => c).FirstOrDefault();

    // get operator from the column datatype
    // both firstName and lastName are the same data type...so only get one.

    MDOListItem[] operators = await mdoAgent.GetListAsync(
        "restrictionOperators",
        true,
        firstNameColumn.RestrictionType,
        false);

    // get the "begins" operator

    MDOListItem beginsOperator = operators
        .Where(o => o.Type.Equals("begins", StringComparison.OrdinalIgnoreCase))
        .Select(o => o).FirstOrDefault(); // throw if not found

    // define the criteria

    var criteriaGroups = new ArchiveRestrictionGroup[]
    {
        new ArchiveRestrictionGroup()
        {
             Name = "0",
             Rank = 0,
             Restrictions = new ArchiveRestrictionInfo[]
             {
                new ArchiveRestrictionInfo()
                {
                    Name = firstNameColumn.Name,
                    Operator = beginsOperator.Type,
                    Values = new[] {"B"},
                    IsActive = true,
                    ColumnInfo = firstNameColumn
                }, // AND
                new ArchiveRestrictionInfo()
                {
                    Name = lastNameColumn.Name,
                    Operator = beginsOperator.Type,
                    Values = new[] {"Y"},
                    IsActive = true,
                    ColumnInfo = lastNameColumn
                }
             }
        }, // OR
        new ArchiveRestrictionGroup()
        {
            Name = "1",
             Rank = 1,
             Restrictions = new ArchiveRestrictionInfo[]
             {
                new ArchiveRestrictionInfo()
                {
                    Name = firstNameColumn.Name,
                    Operator = beginsOperator.Type,
                    Values = new[] {"R"},
                    IsActive = true,
                    ColumnInfo = firstNameColumn
                }, // AND
                new ArchiveRestrictionInfo()
                {
                    Name = lastNameColumn.Name,
                    Operator = beginsOperator.Type,
                    Values = new[] {"Y"},
                    IsActive = true,
                    ColumnInfo = lastNameColumn
                }
             }
        }
    };

    // set the criteria

    return await selectionAgent.SetDynamicSelectionCriteriaGroupsAsync(
        selectionForFind.SelectionId,
        criteriaGroups);
}
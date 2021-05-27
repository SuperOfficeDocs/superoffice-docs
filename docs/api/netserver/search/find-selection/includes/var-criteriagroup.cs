var criteriaGroup = new ArchiveRestrictionGroup()
{
    Name = "0",
    Rank = 0,
    Description = "Hidden Description",
    Restrictions = new []
    {
        new ArchiveRestrictionInfo()
        {
            Name = "name",
            Operator = "begins",
            Values = new[] { "Super" },
            IsActive = true,
            ColumnInfo = new ArchiveColumnInfo()
            {
                Name = "name",
                RestrictionType = "stringorPK",
                RestrictionListName = "locateContact_new",
                //... left out for brevity
            },
            InterOperator = InterRestrictionOperator.And
        },
        new ArchiveRestrictionInfo()
        {
            Name = "name",
            Operator = "begins",
            Values = new[] { "Duper" },
            IsActive = true,
            ColumnInfo = new ArchiveColumnInfo()
            {
                Name = "name",
                RestrictionType = "stringorPK",
                RestrictionListName = "locateContact_new",
                //... left out for brevity
            },
            InterOperator = InterRestrictionOperator.And
        }
    }
};
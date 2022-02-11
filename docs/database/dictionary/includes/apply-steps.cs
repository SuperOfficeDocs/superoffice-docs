private void ApplySteps()
{
  // populate database connection properties
  var ConnectionString = "Server=localhost;Database=SuperOffice81R;USER ID=crm7;Password=crm7myd";
  var Major = "MSSQL";
  var Minor = "14";
  var Prefix = "CRM7";
  // create connection to the database
  using (var connection = DbConnectionProvider.GetConnection(ConnectionString, Major, Minor))
  {
    // create a DatabaseManagement instance 
    using (var dbm = DatabaseManagement.CreateInstance(Prefix, connection))
    {
      // ensure this is a version 8.1 or higher database
      var dbState = dbm.InspectDatabase();
      if (dbState == DatabaseManagement.DatabaseContent.SuperOfficeCdd)
      {
        // get the database model - passed to DatabaseManagement for validation
        var model = dbm.ReadDatabaseModel();
        //prepare the list of DictionarySteps as a LinkedList
        var steps = new LinkedList<DictionaryStep>(new[] { new ExampleDictionaryStep.DemoClass1() });
        // apply the dictionary steps to the database model and physical database
        var result = dbm.ApplyDictionarySteps(steps, model);
      }
    }
  }
}
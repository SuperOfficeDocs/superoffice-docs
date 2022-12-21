// search for all companies where name begins with 'super'
var select = S.NewSelect<ContactTableInfo>(cti => cti.Name.Like("super%"));

// get all company id's from the search results 
var companyIds = select.Records(select.Table.ContactId).Select(r => r.Table.ContactId[r]).ToArray();

if (companyIds != null)
{
    // use BulkUpdateSystem.GetAvailableContactFields to get the Name FieldValueInfo
    var contactNameFieldValueInfo = BulkUpdateSystem.GetAvailableContactFields().Where(
        v => v.Key == BulkUpdateSystem.ContactFieldValueKeys.Name).FirstOrDefault();

    // use a set operation to update the field
    contactNameFieldValueInfo.CurrentOperationType = BulkUpdateSystem.OperationTypes.RegEx;
    
    // define the new value
    contactNameFieldValueInfo.Values = 
    new[]
    {
        "", // 0 Not Used
        "", // 1 Not Used
        "", // 2 Not Used
        "", // 3 Not Used
        @"super\s?office", // 4 RegEx (Locate)
        "SuperOffice",     // 5 Replace
        System.Text.RegularExpressions.RegexOptions.IgnoreCase.ToString(), // 6 RegexOptions
    };

    // instantiate a new BulkUpdate BackgroundJob
    BulkUpdateSystem.BackgroundJob updateJob = new BulkUpdateSystem.BackgroundJob(

    // define the target table name
    SuperOffice.CRM.Data.ContactTableInfo.DictionaryTableName,

    // set then FieldValueInfo
    new[] { contactNameFieldValueInfo },

    // set the company Ids that will be updated
    companyIds);

    // execute the job
    bool updateSuccess = updateJob.UpdateFieldsAsync();

    while (!updateJob.Done)
    {
        Thread.Sleep(500);
    }
}
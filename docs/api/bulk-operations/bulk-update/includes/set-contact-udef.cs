// search for all companies where name begins with 'super'
var select = S.NewSelect<ContactTableInfo>(cti => cti.Name.Like("super%"));

// get all company id's from the search results 
var companyIds = select.Records(select.Table.ContactId).Select(
                     r => r.Table.ContactId[r]).ToArray();

if (companyIds != null)
{

    // use BulkUpdateSystem.GetAvailableContactFields to get the Name FieldValueInfo
    var contactUdefFieldValueInfo = BulkUpdateSystem.GetAvailableContactFields()
            .Where(v => v.Key == "SuperOffice:1").FirstOrDefault();

    // use a set operation to update the field
    contactUdefFieldValueInfo.CurrentOperationType =
             BulkUpdateSystem.OperationTypes.SearchAndReplace;

    // define the new value
    contactUdefFieldValueInfo.Values =
    new[]
    {
            "",                     // Not Used
            "Stage One",            // Search Value
            "Stage Two",            // Replace With
            "IgnoreCase, WholeWord"  // Search Options
    };

    // instantiate a new BulkUpdate BackgroundJob
    BulkUpdateSystem.BackgroundJob updateJob = new BulkUpdateSystem.BackgroundJob(

    // define the target table name
    SuperOffice.CRM.Data.ContactTableInfo.DictionaryTableName,

    // set then FieldValueInfo
    new[] { contactUdefFieldValueInfo },

    // set the person Ids that will be updated
    companyIds);

    // execute the job
    bool updateSuccess = updateJob.UpdateFieldsAsync();

    while (!updateJob.Done)
    {
        Thread.Sleep(500);
    }
}
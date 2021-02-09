// search for all companies where name begins with 'super'
var select = S.NewSelect<ContactTableInfo>(cti => cti.Name.Like("super%"));

// get all company id's from the search results 
var companyIds = select.Records(select.Table.ContactId).Select(
                     r => r.Table.ContactId[r]).ToArray();

if (companyIds != null)
{

    // use BulkUpdateSystem.GetAvailableContactFields to get the Name FieldValueInfo
    var contactAddInterestsFieldValueInfo = BulkUpdateSystem.GetAvailableContactFields().Where(
            v => v.Key == BulkUpdateSystem.ContactFieldValueKeys.AddInterests).FirstOrDefault();

    // use a set operation to update the field
    contactAddInterestsFieldValueInfo.CurrentOperationType = BulkUpdateSystem.OperationTypes.AddItems;

    // define the new value
    contactAddInterestsFieldValueInfo.Values =
    new[]
    {
            "12", // 0 Interest ID 12
            "23", // 1 Interest ID 23
            "34", // 2 Interest ID 34
    };

    // instantiate a new BulkUpdate BackgroundJob
    BulkUpdateSystem.BackgroundJob updateJob = new BulkUpdateSystem.BackgroundJob(

    // define the target table name
    SuperOffice.CRM.Data.ContactTableInfo.DictionaryTableName,

    // set then FieldValueInfo
    new[] { contactAddInterestsFieldValueInfo },

    // set the person Ids that will be updated
    companyIds);

    // execute the job
    bool updateSuccess = updateJob.UpdateFieldsAsync();

    while (!updateJob.Done)
    {
        Thread.Sleep(500);
    }

}
// search for all companies with categoryId = 10
var select = S.NewSelect<ContactTableInfo>(cti => cti.CategoryIdx.Equal(10));

// get all company id's from the search results 
var companyIds = select.Records(select.Table.ContactId).Select(
                     r => r.Table.ContactId[r]).ToArray();

if (companyIds != null)
{

    // use GetAvailableContactFields to get the Category FieldValueInfo
    var contactUdefFieldValueInfo = BulkUpdateSystem.GetAvailableContactFields()
            .Where(v => v.Key == BulkUpdateSystem.ContactFieldValueKeys.Category)
            .FirstOrDefault();

    // use a SelectOne operation to update the field
    contactUdefFieldValueInfo.CurrentOperationType = BulkUpdateSystem.OperationTypes.SelectOne;

    // define the new value
    contactUdefFieldValueInfo.Values = 
    new[]
        {
            "15", // CategoryId
        };

    // instantiate a new BulkUpdate BackgroundJob
    BulkUpdateSystem.BackgroundJob updateJob = new BulkUpdateSystem.BackgroundJob(

    // define the target table name
    SuperOffice.CRM.Data.ContactTableInfo.DictionaryTableName,

    // set then FieldValueInfo
    new[] { contactUdefFieldValueInfo },

    // set the company Ids that will be updated
    companyIds);

    // execute the job
    bool updateSuccess = updateJob.UpdateFieldsAsync();

    while (!updateJob.Done)
    {
        Thread.Sleep(500);
    }
}
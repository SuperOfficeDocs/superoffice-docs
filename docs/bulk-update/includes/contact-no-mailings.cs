// search for all companies where NoMailing is Checked
var select = S.NewSelect<ContactTableInfo>(cti => cti.Nomailing.Equal(1));

// get all company id's from the search results 
var companyIds = select.Records(select.Table.ContactId).Select(
                     r => r.Table.ContactId[r]).ToArray();

if (companyIds != null)
{

    // use BulkUpdateSystem.GetAvailableContactFields to get the Name FieldValueInfo
    var contactUdefFieldValueInfo = BulkUpdateSystem.GetAvailableContactFields()
            .Where(v => v.Key == BulkUpdateSystem.ContactFieldValueKeys.ContactNoMail)
            .FirstOrDefault();

    // use a set operation to update the field
    contactUdefFieldValueInfo.CurrentOperationType =
             BulkUpdateSystem.OperationTypes.Set;

    // define the new value
    contactUdefFieldValueInfo.Values =
    new[]
    {
            "0", // NoMailing = Unchecked.
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
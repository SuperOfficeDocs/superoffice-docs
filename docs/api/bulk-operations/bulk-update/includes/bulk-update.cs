// search for all persons with title ‘Admin’
var selectPeople = S.NewSelect<PersonTableInfo>(pti => pti.Title.Equal("Admin"));

// get all personIds from the search results 
var personIds = selectPeople.Records(selectPeople.Table.PersonId).Select(r => new { PersonId = r.Table.PersonId[r] });

if (personIds != null)
{
    // use BulkUpdateSystem.GetAvailablePersonFields to get the Title FieldValueInfo
    var personTitleFieldValueInfo = BulkUpdateSystem.GetAvailablePersonFields()
            .Where(v => v.Key == BulkUpdateSystem.PersonFieldValueKeys.Title)
            .FirstOrDefault();

    // use a set operation to update the field
    personTitleFieldValueInfo.CurrentOperationType = BulkUpdateSystem.OperationTypes.Set;

    // define the new value
    personTitleFieldValueInfo.Values = new[] { "Administrator" };

    // instantiate a new BulkUpdate BackgroundJob
    BulkUpdateSystem.BackgroundJob updateJob = new BulkUpdateSystem.BackgroundJob(

    // define the target table name
    SuperOffice.CRM.Data.PersonTableInfo.DictionaryTableName,

    // set then FieldValueInfo
    new[] { personTitleFieldValueInfo },

    // set the person Ids that will be updated
    personIds.Select(p => p.PersonId).ToArray());

    // execute the job
    bool updateSuccess = updateJob.UpdateFieldsAsync();

    while (!updateJob.Done)
    {
        Thread.Sleep(500);
    }
}
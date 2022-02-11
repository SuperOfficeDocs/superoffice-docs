// search for all appointments where projectId = 121
var select = S.NewSelect<AppointmentTableInfo>(ati => ati.ProjectId.Equal(121));

// get all appointment id's from the search results 
var appointIds = select.Records(select.Table.AppointmentId).Select(
                     r => r.Table.AppointmentId[r]).ToArray();

if (appointIds != null)
{

// use BulkUpdateSystem.GetAvailableAppointmentFields to get the Done FieldValueInfo
    var appntFieldValueInfo = BulkUpdateSystem.GetAvailableAppointmentFields()
            .Where(v => v.Key == BulkUpdateSystem.AppointmentFieldValueKeys.Done)
            .FirstOrDefault();

    // use a Check operation to update the field
    appntFieldValueInfo.CurrentOperationType =
             BulkUpdateSystem.OperationTypes.Check;

    // define the new value
    appntFieldValueInfo.Values =
    new[]
    {
            "1", // 0 = NotStarted, 1 = Completed
    };

    // instantiate a new BulkUpdate BackgroundJob
    BulkUpdateSystem.BackgroundJob updateJob = new BulkUpdateSystem.BackgroundJob(

    // define the target table name
    SuperOffice.CRM.Data.AppointmentTableInfo.DictionaryTableName,

    // set then FieldValueInfo
    new[] { appntFieldValueInfo },

    // set the company Ids that will be updated
    appointIds);

    // execute the job
    bool updateSuccess = updateJob.UpdateFieldsAsync();

    while (!updateJob.Done)
    {
        Thread.Sleep(500);
    }
}
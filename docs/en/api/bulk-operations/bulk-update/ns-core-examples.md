---
title: Bulk update examples using NetServer Core API
uid: ns_core_examples
description: Bulk update examples using NetServer Core API
author: Tony Yates
date: 06.23.2017
keywords:
content_type: howto
category: api
topic: bulk update
deployment: online
platform: web
redirect_from: /en/api/netserver/bulk-operations/bulk-update/ns-core-examples
---

# Bulk update examples using NetServer Core API

Here are a few more examples of how to use bulk update.

## Contact Change Category

```csharp
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
```

## Contact No Mailings Checkbox

```csharp
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
```

## Contact Add Interests

```csharp
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
```

## Set Contact User-Defined Field

```csharp
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
```

## Appointment: complete all project appointments

```csharp
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
```

## Example using Web Services (courtesy of Matthijs Wagemakers)

```csharp
using (var bulkAgent = new BulkUpdateAgent())
{
    FieldValueInfo[] fields = bulkAgent.GetAvailableFields("­appointment");
    FieldValueInfo filteredField = fields.Where(x => x.Key == SuperOffice.CRM.BulkUpdate.Bul­kUpdateSystem.AppointmentF­ieldValueKeys.Done)
        .FirstOrDefault();
    filteredField.IsActive = true;
    filteredField.CurrentOperation­Type = SuperOffice.CRM.BulkUpdate.Bul­kUpdateSystem.OperationTyp­es.Check;
    filteredField.Values = new[] { "1" };

    int bulkId = bulkAgent.ExecuteByEntityIds(
        new[] { filteredField },
        "appointment",
        Guid.NewGuid().ToString(),        // must be unique for concurrent jobs
        string.Join(",", new[] { 2, 10 }))
        ;
}
```

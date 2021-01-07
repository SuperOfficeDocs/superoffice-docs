---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: using_bulk_update       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Practical details # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 23 Jun 2017
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Practical details

To use Bulk Update, a user be assigned a role that contains the functional right “Can bulk update”, or allow-bulk-edit. By default, only the roles User level 0 and User level 1 are assigned this functional right.

**This is a powerful tool that can cause a lot of damage if used improperly, and therefore should only be giving to advanced users.**

When a role is assigned the allow-bulk-update functional right, any member of that role will see the Bulk Update functionality in the SuperOffice client. The same is true to use the API, specifically for Adding interests which requires the additional allow-bulk-interest functional right. If the principal executing the code is not a member of that role, the field will not be available.

When it comes to using the bulk update API, there are three aspects to its orchestration:

* Define one or more entity identities to update.
* Define one or more fields of that entity to update.
* Define the action performed on each field.

**Bulk update orchestration:**

![x][img3]

Once the orchestration is defined, and the update is executed, it’s up to the API consumer to determine how the action results are monitors and or recorded.

There is a preference that determines whether to log the update or not.

In the Windows client, a user can click a button to view the results:

**Bulk Update Log:**

![x][img4]

The preference that enables the Bulk Update log is in the BulkUpdate section, has a “LogResultOfJob” prefkey, and has a prefvalue that is set to either true or false.

## Practical Code Example

Below is a basic example that searches for all persons with the title property equal to ‘Admin’ and changes each to ‘Administrator’.

The preference that enables the Bulk Update log is in the BulkUpdate section, has a “LogResultOfJob” prefkey, and has a prefvalue that is set to either true or false.

```csharp
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
```

The first two lines of code execute a NetServer OSQL query that gets all personIds where the person Title is equal to ‘Admin’. Next, it Checks to make sure the result is not null, indicating at least one person was returned by the query.

BulkUpdateSystem is a class that contains several useful methods for fetching all relevant FieldValueInfos supported by an entity.

The example above uses BulkUpdateSystem.GetAvailablePersonFields to obtain the field where the key equals ‘title’. This is somewhat foolish as there are constant values available for each entity field. I should of used BulkUpdateSystem.PersonFieldValueKeys.Title, and so I recommend that you use the constants in your code. There are constants for each entity and are defined in the following:

* BulkUpdateSystem.AppointmentFieldValueKeys
* BulkUpdateSystem.ContactFieldValueKeys
* BulkUpdateSystem.DocumentFieldValueKeys
* BulkUpdateSystem.PersonFieldValueKeys
* BulkUpdateSystem.ProjectFieldValueKeys
* BulkUpdateSystem.SaleFieldValueKeys
* BulkUpdateSystem.SelectionFieldValueKeys

As seen in the code, FieldValueInfo is a type used to refer to one entity field where the action and required parameter are specified.  The action is specified by setting the FieldValueInfo.Operation property. In this example, it is assigned the FieldValueInfo.Operation.Set constant, which is an operation that accepts one parameter ‘Administrator’. When executed, this operation will change the current ‘Admin’ value to ‘Administrator’.

An instance of the BulkUpdateSystem.BackgroundJob class is where all the magic happens. It is responsible for executing the bulk update operation, and requires the following three things:

* the table name of the target entity
* One or more FieldValueInfo’s that correspond to the target entity
* the entity ID values to update

The table name will always be one of the following constants:

* SuperOffice.CRM.Data.AppointmentTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.ContactTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.DocumentTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.PersonTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.SaleTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.SelectionTableInfo.DictionaryTableName

As mentioned in #2, the BackgroundJob constructor accepts an array of FieldValueInfos, and therefore it is possible to process more than one field in a single job. The only restriction is that all FieldValueInfo’s must be a field of the same table. You cannot, for example, pass in FieldValueInfos from both the Appointment and Contact table. They must all belong to one or the other.

Finally, the job is performed for each entity id by calling BackgroundJob.UpdateFieldsAsync.

<!-- Referenced images -->
[img3]: https://community.superoffice.com/globalassets/developer-club/articles/bulkupdate/image006.png
[img4]: https://community.superoffice.com/globalassets/developer-club/articles/bulkupdate/image008.jpg
---
title: Practical details - how to use Bulk Update API
uid: using_bulk_update
description: Practical details, requirements, configuration
author: Tony Yates
so.date: 06.23.2017
keywords: bulk update, FieldValueInfo, DictionaryTableName
so.topic: howto
so.envir: cloud
so.client: online
---

# Practical details - how to use Bulk Update API

To use the [Bulk Update API][1], a user must be assigned a role that contains the functional right *Can bulk update*, or *allow-bulk-edit*. By default, only the roles *User level 0* and *User level 1* are assigned this functional right.

> [!CAUTION]
> This is a powerful tool that can cause a lot of damage if used improperly, and therefore should only be given to advanced users.

When a role is assigned the *allow-bulk-update* functional right, any member of that role will see the bulk update functionality in the SuperOffice client. The same is true to use the API, specifically for adding interests, which requires the additional *allow-bulk-interest* functional right. If the principal executing the code is not a member of that role, the field will not be available.

When it comes to using the Bulk Update API, there are three aspects to its orchestration:

* Define one or more entity identities to update.
* Define one or more fields of that entity to update.
* Define the action performed on each field.

**Bulk update orchestration:**

![Bulk update orchestration diagram][img1]

Once the orchestration is defined, and the update is executed, it’s up to the API consumer to determine how the action results are monitored and or recorded.

There is a preference that determines whether to log the update or not.

In the Windows client, a user can click a button to view the results:

**Bulk update log:**

![Bulk update log -screenshot][img2]

The preference that enables the Bulk update log is in the BulkUpdate section, has a `LogResultOfJob` prefkey, and has a prefvalue that is set to either true or false.

## Practical code example

Below is a basic example that searches for all persons with the title property equal to *Admin* and changes each to *Administrator*.

The preference that enables the Bulk update log is in the BulkUpdate section, has a `LogResultOfJob` prefkey, and has a prefvalue that is set to either true or false.

[!code-csharp[example 1](includes/bulk-update.cs)]

The first two lines of code execute a NetServer OSQL query that gets all `personId`s where the person Title is equal to 'Admin'. Next, it checks to make sure the result is not null, indicating at least one person was returned by the query.

`BulkUpdateSystem` is a class that contains several useful methods for fetching all relevant `FieldValueInfos` supported by an entity.

The example above uses `BulkUpdateSystem.GetAvailablePersonFields` to obtain the field where the key equals *title*. This is somewhat foolish as there are constant values available for each entity field. I should of course have used `BulkUpdateSystem.PersonFieldValueKeys.Title`, and so I recommend that you use the constants in your code.

There are constants for each entity and are defined in the following:

* BulkUpdateSystem.AppointmentFieldValueKeys
* BulkUpdateSystem.ContactFieldValueKeys
* BulkUpdateSystem.DocumentFieldValueKeys
* BulkUpdateSystem.PersonFieldValueKeys
* BulkUpdateSystem.ProjectFieldValueKeys
* BulkUpdateSystem.SaleFieldValueKeys
* BulkUpdateSystem.SelectionFieldValueKeys

As seen in the code, `FieldValueInfo` is a type used to refer to one entity field where the action and required parameter are specified. The action is specified by setting the `FieldValueInfo.Operation` property. In this example, it is assigned the `FieldValueInfo.Operation.Set` constant, which is an operation that accepts one parameter *Administrator*. When executed, this operation will change the current *Admin* value to *Administrator’*.

An instance of the `BulkUpdateSystem.BackgroundJob` class is where all the magic happens. It is responsible for executing the bulk update operation, and requires the following three things:

* The table name of the target entity
* One or more `FieldValueInfo`s that correspond to the target entity
* The entity ID values to update

The table name will always be one of the following constants:

* SuperOffice.CRM.Data.AppointmentTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.ContactTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.DocumentTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.PersonTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.SaleTableInfo.DictionaryTableName
* SuperOffice.CRM.Data.SelectionTableInfo.DictionaryTableName

The `BackgroundJob` constructor accepts an array of `FieldValueInfos`, and therefore it is possible to process more than one field in a single job. The only restriction is that all `FieldValueInfos` must be a field of the same table. You cannot, for example, pass in `FieldValueInfos` from both the `appointment` and `contact` tables. They must all belong to one or the other.

Finally, the job is performed for each entity ID by calling `BackgroundJob.UpdateFieldsAsync`.

Continue reading: [Field value info][2]

<!-- Referenced links -->
[1]: index.md
[2]: field-value-info.md

<!-- Referenced images -->
[img1]: media/image006.png
[img2]: media/image008.jpg

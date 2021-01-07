---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: operations_and_values       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Operations and values # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 23 Jun 2017
keywords:
so.topic: concept          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Operations and values

Except for Toggle, every operation has a predefined list of parameter dependencies. For example, this means that when the `SearchAndReplace` operation is set, the `FieldValueInfo.Values` property is expected to contain at least three items, but can optionally contain up to 7 entries.

Each operation type has a [different number of required parameters][1].

One of the simplest operations `BulkUpdateSystem.OperationTypes.Toggle`, simply flips the current value from true to false, or 0 to 1, and vice versa. Therefore, it’s not necessary to add any values to the `FieldValueInfo.Values` property to successfully perform the operation.

## List of Operations

| OperationTypes | Description |
|---|---|
| SelectOne | One or two values expected for this operation. See tables below. |
| Clear | No values are used for this operation. Whatever value exists will be set to an empty string. |
| Set | One or two values expected for this operation. See tables below. |
| Check |One value is expected for this operation. | Check is used for mostly Boolean and short field types. Details of expected values is located in the entity tables below. |
| Toggle | No values are used for this operation. Boolean fields will be Set to this opposite Setting. Fields with number values are either 1 or 0 and will be swapped accordingly. |
| AddItems | Multiple values allowed. Values are added to the target. |
| RemoveItems | Multiple values allowed. Values are removed from the target. |
| Add | Two values expected. |
| Remove | One value expected. |
| ReplaceWith | Two values expected. Removes existing items and updates matching record. |
| SearchAndReplace | Finds all matches and replaces existing information. |
| RegEx | Uses in conjunction with SearchAndReplace, for advanced search scenarios. |

Most updates of existing values will only need one or two values.

The trickiest thing about bulk update is that, for different operations, which not only expect different numbers of parameters, the parameters must be passed in specific indexes within the Values array.

## Example

Using the Set operation as an example, only the first index of the array is expected to exist with a value to populate the field property. However, the SearchAndReplace operation expects the Values array to contain at least three but up to four indexes. Fields that accept the “Set, Clear, SearchAndReplace, RegEx” operation types, and perform a SeachAndReplace operation only use the second (\[1\]) and third (\[2\]) index for execution.

**Values array for: Set, Clear, SearchAndReplace, RegEx:**

![x][img5]

When used with a field that accepts the “Add, Remove, ReplaceWith, Clear, SearchAndReplace, RegEx” operation types, SearchAndReplace expects parameters to exist in third (\[2\]) and fourth (\[3\]) index.

**Values array for: Add, Remove, ReplaceWith, Clear, SearchAndReplace, RegEx:**

![x][img6]

There will be cases when some index values are populated but not used. Take the following code example, where a RegEx operation is performed. Notice that the first four indexes in the Values property are not used. For performing a RegEx operation, only the last three indexes are required.

```csharp
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
```

<!-- Referenced links -->
[1]: entities-field-types.md

<!-- Referenced images -->
[img5]: https://community.superoffice.com/globalassets/developer-club/articles/bulkupdate/image010.jpg
[img6]: https://community.superoffice.com/globalassets/developer-club/articles/bulkupdate/image012.jpg

---
title: How to Search using Find Selections
uid: selection_how_to_search
description: Details what new selections are, and how to work with them in code. 
author: {AnthonyYates}
keywords: Selection, Find, Search
so.topic: howto
so.envir: online, onsite
so.client: netserver
so.version: 9.2
---

# How to Search using Find Selections

> [!NOTE]
> The API details provided apply to SuperOffice v.9.2 and higher. Find searches do not yet support `custom entities` or `extra tables`. SOAP API access via the Services88 endpoints, therefore online Apps must request Services88 to use this API.

The first thing to understand is that search is based on a selection. However, a search doesn’t explicitly require a preexisting selection to perform a search. Using the API the same way the SuperOffice **Find** dialog works, implicitly creates a selection on a per-associate per-entity basis.

## Steps

The steps used to perform a search are:

1. Get the list of available search entities.
2. Determine which entity to base the search such as company, contact, sale, project, and so on.
3. Get the data source used to perform the search, the name of a dynamic selection archive provider.
4. Get the available data source columns, for specifying return fields and criteria.
5. Set the search criteria.
6. Perform the search.
7. Read the results.

## <a name="get-sr-find"></a>Get the search entities

The Find page dynamically displays all entities that support the new Find system.

![Find Dialog][img1]

> [!NOTE]
> Your Find options may not be the same as shown. Available entities depend on the current user's license.

To determine which entities are available, use the MDO endpoint to get a list of available entities using the `SelectionMemberTypeV2` MDOList provider.

### [REST](#tab/find-panel-1)

```http
GET /api/v1/MDOList/SelectionMemberTypeV2
Authorization: Bearer {access_token}
Content-Type: application/json
Accept: application/json
```

### [Agent](#tab/find-panel-2)

```http
POST /api/v1/Agents/MDO/GetList
Authorization: Bearer {access_token}
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8
{
  "Name": "selectionmembertypev2",
  "ForceFlatList": true,
  "AdditionalInfo": "",
  "OnlyHistory": false
}
```

### [WebApi Client](#tab/find-panel-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var mdoAgent = new MDOAgent(options);
MDOListItem[] findEntities = await mdoAgent.GetListAsync("selectionmembertypev2", true, string.Empty, false);
```

___

The result is an array of [MDOListItem][2] and contains the following details. Use the name of the `ExtraInfo` property to define the search entity.

### Results (some properties omitted for brevity)

| Id | Name                 | IconHint   | ExtraInfo   |
|----|----------------------|------------|-------------|
| 1  | [SR_FIND_COMPANY]    | Contact    | contact     |
| 2  | [SR_FIND_PERSON]     | Person     | person      |
| 3  | [SR_FIND_APPOINTMENT]| Appointment| appointment |
| 4  | [SR_FIND_SALE]       | Sale       | sale        |
| 5  | [SR_FIND_PROJECT]    | Project    | project     |
| 6  | [SR_FIND_SELECTION]  | Selection  | selection   |
| 7  | [SR_FIND_DOCUMENT]   | Document   | document    |
| 8  | [SR_FIND_QUOTELINE]  | Products   | QuoteLine   |
| 9  | [SR_FIND_TICKET]     | Ticket     | ticket      |

> [!NOTE]
> Use header options to specify an Accept-Language to replace the resource strings with localized labels.

<!--
| Id | Name | Tooltip | Deleted | Rank | Type | ChildItems | IconHint | ColorBlock | ExtraInfo | StyleHint | FullName | TableRight | FieldProperties |
|---|---|---|---|---|---|---|---|---|---|---|---|---|---|
| 5  | [SR_FIND_COMPANY] | [SR_FIND_COMPANY_TOOLTIP] | false   | 0    |      | []         | Contact  | 0          | contact   |           |          | null       | []              |
| 6  | [SR_FIND_PERSON]  | [SR_FIND_PERSON_TOOLTIP]  | false   | 0    |      | []         | Person   | 0          | person    |           |          | null       | []              |
| 6  | [SR_FIND_APPOINTMENT]  | [SR_FIND_APPOINTMENT_TOOLTIP]  | false   | 0    |      | []         | Appointment   | 0          | appointment    |           |          | null       | []              |
| 6  | [SR_FIND_SALE]  | [SR_FIND_SALE_TOOLTIP]  | false   | 0    |      | []         | Sale   | 0          | sale    |           |          | null       | []              |
| 6  | [SR_FIND_PROJECT]  | [SR_FIND_PROJECT_TOOLTIP]  | false   | 0    |      | []         | Project   | 0          | project    |           |          | null       | []              |
| 6  | [SR_FIND_SELECTION]  | [SR_FIND_SELECTION_TOOLTIP]  | false   | 0    |      | []         | Selection   | 0          | selection    |           |          | null       | []              |
| 6  | [SR_FIND_DOCUMENT]  | SR_FIND_DOCUMENT_TOOLTIP]  | false   | 0    |      | []         | Document   | 0          | document    |           |          | null       | []              |
| 6  | [SR_FIND_QUOTELINE]  | SR_FIND_QUOTELINE_TOOLTIP]  | false   | 0    |      | []         | Products   | 0          | QuoteLine    |           |          | null       | []              |
| 6  | [SR_FIND_TICKET]  | SR_FIND_TICKET_TOOLTIP]  | false   | 0    |      | []         | Ticket   | 0          | ticket    |           |          | null       | []              |
-->

## <a name="get-data-source"></a>Get the entity data source

You need 2 key pieces of information to get the data source, the archive provider and the selection ID. These are both available in a [SelectionForFind][3] instance. Use the ExtraInfo value from the previous results to get a SelectionForFind instance.

Use the `SelectionAgent.GetSelectionForFind(entityName, typicalSearchId)` method to obtain the SelectionForFind type for a particular entity.

The value of `typicalSearchId` determines some internal logic.

| TypicalSearchID | Description |
|:-:|---|
| -1 | Gets the default criteria for the current entity, and the `selectionId` of the working set is returned along with the `providerName`. |
| 0 | Gets the working set and doesn’t do anything else.|
| 1 or higher | Gets a selection with criteria set from the typical search of the given ID. |

### [RESTful Agent](#tab/get-archive-provider-1)

```http
POST /api/v1/Agents/Selection/GetSelectionForFind 
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json

{
  "EntityName": "contact",
  "TypicalSearchId": 0
}
```

<!-- POST https://sod.superoffice.com/Cust26759/api/v1/Agents/Selection/GetSelectionForFind -->

### [WebApi Client](#tab/get-archive-provider-2)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var selectionAgent = new SelectionAgent(options);

var entityName = "contact";
var typicalSearchId = 0;

SelectionForFind selectionForFind = await selectionAgent.GetSelectionForFind(entityName, typicalSearchId);
```

___

### SelectionForFind properties

| Property | Description |
|---|---|
| CanSaveAsSelection     | Indicates of selection entity can be saved as a selection. |
| FieldProperties        | Mapping field names to access rights. |
| FilterScreenHeading    | Heading used on the Find filter page in SuperOffice. |
| MainHeading            | Heading used on the Find front page in SuperOffice. |
| ProviderName           | The name of the main archive provider use with this selection entity type. |
| SelectionEntityHeading | The plural form of the entity name, used on the Selection **Details** tab. |
| SelectionId            | The selections primary key. |
| TableRight             | The carrier table rights. |

The `ProviderName` property is the name of the archive provider used to search. In this example, when contact is used as the entity name, the results return `ContactPersonDynamicSelectionV2` as the archive provider name.

The `SelectionId` indicates the selection's primary key for this associate/entity pair. The selection has a default list of criteria used to pre-populate a new selection of this entity type.

#### SelectionForFind result

```json
{
  "ProviderName": "ContactPersonDynamicSelectionV2",
  "SelectionId": 21,
  "CanSaveAsSelection": true,
  "MainHeading": "[SR_FIND_COMPANY]",
  "FilterScreenHeading": "[SR_FIND_COMPANY]",
  "SelectionEntityHeading": "[SR_COMPANY_AND_PERSON]",
  "TableRight": null,
  "FieldProperties": {}
}
```

> [!NOTE]
> The selection ID used here does not appear as an available Selection in SuperOffice. It's only used for `Find` purposes.

#### Provider names

All dynamic Find Selections use an archive provider whose name ends with the **V2** suffix. However, when using the Find API, do not rely on this list, instead use the API as shown to ensure you always get the correct provider.

* [AppointmentDynamicSelectionV2][6]
* [ContactPersonDynamicSelectionV2][5]
* [DocumentDynamicSelectionV2][8]
* [ProjectDynamicSelectionV2][9]
* [QuotelineDynamicSelectionV2][10]
* [SaleDynamicSelectionV2][11]
* [SelectionDynamicSelectionV2][12]
* [TicketDynamicSelectionV2][13]

These providers are exclusively used together with the new `CriteriaGroups` for specifying restrictions. Retrieve the `SelectionForFind` type, then use the provider name and selection ID to set the desired search criteria.

## Get the search columns

Search columns are used to define what field to select and specify the criteria for limiting the result set.

> [!TIP]
> Because these never change at runtime, make sure to use caching when able.

### Selection criteria

Just like a SQL SELECT statement, where there are any number of select fields and any number of WHERE clause criteria, selections use archive provider columns to determine select and criteria fields. A selection criterion is set using `CriteriaGroups`.

One `CriteriaGroup` is an **ArchiveRestrictionGroup** and contains an array of **ArchiveRestrictionInfo**, and each `ArchiveRestrictionInfo` is implicitly joined by an AND operator.

![CriteriaGroup][img2]

Take the following SQL, for example:

```sql
SELECT firstName, lastName 
FROM CONTACT AS C
WHERE (C.name LIKE 'Super%' AND C.business_idx = 2) 
   OR (C.name LIKE 'Duper%' AND C.category_idx = 12)
```

The first WHERE criteria `(C.name LIKE 'Super%' AND C.business_idx = 2)` is a criteria group, comprised of 2 distinct criteria. To build the equivalent into an `ArchiveRestrictionGroup`, it looks like this:

[!code-csharp[CS](includes/var-criteriagroup.cs)]

`CriteriaGroups` is an array of `ArchiveRestrictionGroup`, and each group is implicitly joined by an OR operator.

As seen in the example above, the `Name` and `Rank` share the same numerical value, represent the order they appear in SuperOffice. The `Name` and `Rank` for the next `ArchiveRestrictionGroup` in the array is 1, and any subsequent group would increment accordingly.

### Archive columns

To specify a field restriction you first need to get an [ArchiveColumnInfo][4] instance. While it's possible to lookup archive provider columns using the NetServer [documentation reference][5], it's recommended to get **and cache** the columns using the API. This is required to set the required information in an `ArchiveRestrictionInfo`.

#### Get archive provider columns

### [RESTful Agent](#tab/get-archive-provider-columns-1)

```http
POST /api/v1/Agents/Archive/GetAvailableColumns
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "ContactPersonDynamicSelectionV2",
  "Context": ""
}
```

### [WebApi Client](#tab/get-archive-provider-columns-2)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var archiveAgent = new ArchiveAgent(options);
var providerName = "ContactPersonDynamicSelectionV2";
ArchiveColumnInfo[] availableColumns = await archiveAgent.GetAvailableColumns(providerName, "");
```

___

#### Get archive provider column results

[!code-json[JSON](includes/get-archive-provider-columns-results.json)]

### Important ArchiveColumnInfo properties

| Property  | Description |
|---|---|
| CanOrderBy            | Determines whether this column be used for sorting. |
| CanRestrictBy         | Determines whether this column be used as a restriction. |
| Name                  | Unique identity of this column; the name to be used when requesting the column from a provider, setting restrictions or order by criteria. |
| RestrictionType       | The data type of the restriction; use this to retrieve the legal operators for the restriction. |
| RestrictionListName   | If the restriction data type is *list*, this property contains the name of the SoList so that choices can be shown. |
| IconHint              | Used to group with corresponding columns. |

### Get field operators by data type

A field operator determines what type of operation the criteria performs, such as comparison or range. Use the `RestrictionType` property to get the available operators for a given data type.

| Restriction type | Is list type |
|------------------|-----------|
| bool           | No  |
| date           | No  |
| datetime       | No  |
| decimal        | No  |
| int            | No  |
| positiveString | No  |
| string         | No  |
| stringorPK     | No  |
| associate      | Yes |
| ejUser         | Yes |
| intArray       | Yes |
| listAll        | Yes |
| listAny        | Yes |
| listInterest   | Yes |
| userGroup      | Yes |

### [REST](#tab/get-operators-1)

```http
GET /api/v1/MDOList/restrictionOperators/selectable?additional=positiveString 
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
Accept-Language: en

```

### [Agent](#tab/get-operators-2)

```http
POST /api/v1/Agents/MDO/GetList 
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8
Accept-Language: en

{
  "Name": "restrictionOperators",
  "ForceFlatList": true,
  "AdditionalInfo": "positiveString",
  "OnlyHistory": false
}

```

### [WebApi Client](#tab/get-operators-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);
// set Language options to en

// perform the request
var mdoAgent = new MDOAgent(options);
MDOListItem[] listItems = await mdoAgent.GetList("restrictionOperators","true","positiveString",false);
```

___

#### REST JSON results

[!code-json[JSON](includes/get-operators-results.json)]

Use the Type property to specify the ArchiveRestrictionInfo Operator property.

#### Example: Working with columns and operators (WebApi client)

[!code-csharp[cs](includes/columninfoarchiverestrictioninfoasync.cs)]

## Set search criteria

### Fetching and saving criteria

The new search routines introduce the concept of **criteria groups**, where all criteria in a group are connected by AND operators, and all groups in the array of CriteriaGroups are connected by OR operators.

![Selection CriteriaGroups][img3]

The main points to understand are:

1. Each `ArchiveRestrictionInfo` in an `ArchiveRestrictionGroup` is implicitly joined by an AND operator.
2. Each `ArchiveRestrictionGroup` is implicitly joined by an OR operator.

The grouping and use of the AND and OR operators as such means it’s simple to define, maintain and comprehend how groups of criteria are applied to search routines.

The database layout to support this has been in place for a long time and was used in an equivalent fashion for Saint Status definitions. There, each criteria group was in a separate tab in the user interface; in the new Find screen, criteria groups are instead stacked vertically.

![Selection CriteriaGroups][img4]

Selection criteria are fetched and stored using the `GetDynamicSelectionCriteriaGroups` and `SetDynamicSelectionCriteriaGroups` methods on the Selection agent. Using them will retrieve and save all groups, and avoid having to make assumptions about the StorageKey concept used in the Find agent methods.

This example demonstrates how to get existing CriteriaGroups for a given selection.

#### [REST](#tab/get-criteriagroups-1)

```http
GET /api/v1/Selection/28/CriteriaGroups
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
Accept-Language: en
```

#### [Agent](#tab/get-criteriagroups-2)

```http
POST /api/v1/Agents/Selection/GetDynamicSelectionCriteriaGroups
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8
Accept-Language: en

{
  "SelectionId": 28
}
```

#### [WebApi Client](#tab/get-criteriagroups-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);
// set Language options to en

// perform the request
var selectionAgent = new SelectionAgent(options);
ArchiveRestrictionGroup[] criteriaGroups = await selectionAgent.GetDynamicSelectionCriteriaGroups(28);
```

___

The following example demonstrates how to set the criteria for the personalized person entity. The criteria say to return all persons where the first name starts with B and ends with Y, or the first name starts with R and ends with Y.

The SQL equivalent is:

```sql
SELECT fName, lName
FROM Person
WHERE (fName LIKE 'B%' AND lName LIKE 'Y%')
   OR (fName LIKE 'R%' AND lName LIKE 'Y%')
```

This code sets the criteria for the personalized selection equal to the `SelectionForFind.SelectionId`. The `SetDynamicSelectionCriteriaGroups[Async]` method returns the criteria groups that were passed in.

### [REST](#tab/set-criteria-groups-1)

[!code-http[HTTP](includes/set-criteria-groups-rest.http)]

### [Agent](#tab/set-criteria-groups-2)

[!code-http[HTTP](includes/set-criteria-groups-agent.http)]

### [WebApi Client](#tab/set-criteria-groups-3)

[!code-csharp[CS](includes/set-criteria-groups-webapi.cs)]

___

## Perform the search

The search is performed using the Archive endpoint, which facilitates passing common parameters, including:

* Provider name
* Desired columns
* Sort order
* Restriction
* Entities
* Page
* Page size

The `selectionId` in these examples is obtained from the `SelectionForFind.SelectionId` property in previous snippets.

### [REST](#tab/perform-search-1)

```http
GET /api/v1/archive/ContactPersonDynamicSelectionV2?$select=firstName,lastName&$filter=selectionId = 34
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
```

### [RESTful Agent](#tab/perform-search-2)

```http
POST /api/v1/Agents/Archive/GetArchiveListByColumns
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8
Accept-Language: en

{
  "ProviderName": "ContactPersonDynamicSelectionV2",
  "Columns": [
    "firstName",
    "lastName"
  ],
  "SortOrder": [
    {
      "Name": "firstName",
      "Direction": "ASC"
    }
  ],
  "Restriction": [
    {
      "Name": "selectionId",
      "Operator": "=",
      "Values": [
        "34"
      ]
    }
  ],
  "Entities": [
    "person"
  ],
  "Page": 0,
  "PageSize": 100
}
```

### [WebClient API](#tab/perform-search-3)

```csharp
string searchEntity = "person";
string[] columns = new[] { "firstName", "lastName" };

SelectionForFind selectionForFind = await selectionAgent
    .GetSelectionForFindAsync(searchEntity, 0);

ArchiveListItem[] results = await archiveAgent.GetArchiveListByColumnsAsync(
    selectionForFind.ProviderName,
    columns,
    new[]
    {
        new ArchiveOrderByInfo() 
        {
            Name = columns[0], 
            Direction = OrderBySortType.ASC 
        }
    },
    new[]
    {
        new ArchiveRestrictionInfo()
        {
            Name = "selectionId",
            Operator = "=",
            Values = new [] { selectionForFind.SelectionId.ToString() }
        }
    },
    new[] { searchEntity },
    0,
    int.MaxValue);

foreach (var listItem in results)
{
    string column1 = listItem.ColumnData[columns[0]].DisplayValue;
    string column2 = listItem.ColumnData[columns[1]].DisplayValue;
    Console.WriteLine($"{column1} {column2}");
}
```

___

## Summary

This article has demonstrated how to search SuperOffice using the same routines used by SuperOffice Find. This way guarantees your applications receive the same results observed both in Selections and using the **Find** dialog.

<!-- Referenced links -->
[2]: ../../../api-reference/netserver/services/SuperOffice.CRM.Services.MDOListItem.yml
[3]: ../../../api-reference/netserver/services/SuperOffice.CRM.Services.SelectionForFind.yml
[4]: ../../../api-reference/netserver/core/SuperOffice.CRM.ArchiveLists.ArchiveColumnInfo.yml
[5]: ../../archive-providers/reference/contactpersondynamicselectionv2.md
[6]: ../../archive-providers/reference/appointmentdynamicselectionv2.md
[8]: ../../archive-providers/reference/documentdynamicselectionv2.md
[9]: ../../archive-providers/reference/projectdynamicselectionv2.md
[10]: ../../archive-providers/reference/quotelinedynamicselectionv2.md
[11]: ../../archive-providers/reference/saledynamicselectionv2.md
[12]: ../../archive-providers/reference/selectiondynamicselectionv2.md
[13]: ../../archive-providers/reference/ticketdynamicselectionv2.md

<!-- Referenced images -->
[img1]: media/selection-find-panel.png
[img2]: media/selection-criteria-group-conceptual.png
[img3]: media/selection-criteria-groups-conceptual.png
[img4]: media/selection-criteria-groups-actual.png

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: How to Search using Find Selections
description: Details what new selections are, and how to work with them in code. 
author: {AnthonyYates}             # Your GitHub alias.
keywords: Selection, Find, Search
so.topic: howto                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: online, onsite                    # cloud or onsite
so.client: netserver                        # online, web, or win
---

# How to Search using Find Selections

SuperOffice [Find](https://community.superoffice.com/en/customer/news/product/9-2-find-selection/) is a unification of the Find dialog and Selections; two legacy approaches to search for specific information. SuperOffice provides new APIs to perform searches, used by both Find and Selections.

> [!NOTE]
> The API details provided apply to SuperOffice v.9.2 and higher. Find searches do not yet support `custom entities` or `extra tables`.

## Getting started

The first thing to understand is that search is based on a selection. However, a search doesn’t explicitly require a preexisting selection to perform a search. Using the API the same way the SuperOffice Find dialog works, implicitly creates a selection on a per-associate per-entity basis.

The steps used to perform a search are:

1. Get the list of available search entities.
1. Determine which entity to base the search, i.e. company, contact, sale, project, etc.
1. Get the data source used to perform the search, the name of a dynamic selection archive provider.
1. Get the available data source columns, for specifying return fields and criteria.
1. Set the search criteria.
1. Perform the search.
1. Read the results.

## Get the search entities

The Find page dynamically displays all entities that support the new Find system.

![Find Dialog](media/selection-find-panel.png)

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

The results is an array of [MDOListItem](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/T_SuperOffice_CRM_Services_MDOListItem.htm) and contain the follow details. Use the name of the ExtraInfo property to define the search entity.

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

## Get the entity data source

You need two key pieces of information to get the data source, the archive provider and selection ID. These are both available in a [SelectionForFind](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/T_SuperOffice_CRM_Services_SelectionForFind.htm) instance. Use the ExtraInfo value from the previous results to get a SelectionForFind instance.

Use the `SelectionAgent.GetSelectionForFind(entityName, typicalSearchId)` method to obtain the SelectionForFind type for a particular entity.

The value of typicalSearchId determines some internal logic.

|TypicalSearchID | Description                                   |
|-----|-----------------------------------------------|
| -1  | Gets the default criteria for the current entity, and the selectionId of the working set is returned along with the providerName. |
| 0 | Gets the working set and doesn’t do anything else.|
| 1 or higher | Gets a selection with criteria set from the typical search of the given id. |

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

| Property Name         |                                 Description                                 |
|-----------------------|-----------------------------------------------------------------------------|
| CanSaveAsSelection    | Indicates of selection entity can be saved as a selection.                  |
| FilterScreenHeading   | Heading used on the Find filter page in SuperOffice.                        |
| MainHeading           | Heading used on the Find front page in SuperOffice.                         |
| `ProviderName`          | The name of the main archive provider use with this selection entity type.  |
| SelectionEntityHeading| The plural form of the entity name, used on the Selection details tab.      |
| `SelectionId`           | The selections primary key.                                                 |

The `ProviderName` property is the name of the archive provider used to search. In this example, when contact is used as the entity name, the results return `ContactPersonDynamicSelectionV2` as the archive provider name.

The `SelectionId` indicates the selection's primary key for this associate/entity pair. The selection has a default list of criteria used to pre-populate a new selection of this entity type.

#### SelectionForFind Result

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

All dynamic Find Selections use an archive provider whose name ends with the “V2” suffix. However, when using the Find API, do not rely on this list, instead use the API as shown to ensure you always get the correct provider.

* [AppointmentDynamicSelectionV2](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-AppointmentDynamicSelectionV2ArchiveProvider.htm) 
* [ContactPersonDynamicSelectionV2](https://community.superoffice.com/documentation/SDK/SO.NetServer.Data.Access/html/Reference-ArchiveProviders-ContactPersonDynamicSelectionV2ArchiveProvider.htm)
* [DocumentDynamicSelectionV2](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-DocumentDynamicSelectionV2ArchiveProvider.htm)
* [ProjectDynamicSelectionV2](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-ProjectDynamicSelectionV2ArchiveProvider.htm)
* [QuotelineDynamicSelectionV2](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-QuoteLineDynamicSelectionV2ArchiveProvider.htm)
* [SaleDynamicSelectionV2](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-SaleDynamicSelectionV2ArchiveProvider.htm)
* [SelectionDynamicSelectionV2](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-SelectionDynamicSelectionV2ArchiveProvider.htm)
* [TicketDynamicSelectionV2](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-TicketDynamicSelectionV2ArchiveProvider.htm)

These providers are exclusively used together with the new CriteriaGroups for specifying restrictions. Retrieve the `SelectionForFind` type, then use the provider name and selectionId to set the desired search criteria.

## Get the search columns

Search columns are used to define what field to select and specify the criteria for limiting the result set. Because these never change at runtime, make sure to use caching when able.

### Selection Criteria

Just like a SQL SELECT statement, where there are any number of select fields and any number of WHERE clause criteria, selections use archive provider columns to determine select and criteria fields. A selection criterion is set using `CriteriaGroups`.

One `CriteriaGroup` is an __ArchiveRestrictionGroup__ and contains an array of __ArchiveRestrictionInfo__, and each `ArchiveRestrictionInfo` is implicitly joined by an AND operator.

![CriteriaGroup](media/selection-criteria-group-conceptual.png)

Take the following SQL, for example:

```sql
SELECT firstName, lastName 
FROM CONTACT AS C
WHERE (C.name LIKE 'Super%' AND C.business_idx = 2) 
   OR (C.name LIKE 'Duper%' AND C.category_idx = 12)
```

The first WHERE criteria `(C.name LIKE 'Super%' AND C.business_idx = 2)` is a criteria group, comprised of two distinct criteria. To build the equivalent into an ArchiveRestrictionGroup, it looks like this:

```csharp
var criteriaGroup = new ArchiveRestrictionGroup()
{
    Name = "0",
    Rank = 0,
    Description = "Hidden Description",
    Restrictions = new []
    {
        new ArchiveRestrictionInfo()
        {
            Name = "name",
            Operator = "begins",
            Values = new[] { "Super" },
            IsActive = true,
            ColumnInfo = new ArchiveColumnInfo()
            {
                Name = "name",
                RestrictionType = "stringorPK",
                RestrictionListName = "locateContact_new",
                //... left out for brevity
            },
            InterOperator = InterRestrictionOperator.And
        },
        new ArchiveRestrictionInfo()
        {
            Name = "name",
            Operator = "begins",
            Values = new[] { "Duper" },
            IsActive = true,
            ColumnInfo = new ArchiveColumnInfo()
            {
                Name = "name",
                RestrictionType = "stringorPK",
                RestrictionListName = "locateContact_new",
                //... left out for brevity
            },
            InterOperator = InterRestrictionOperator.And
        }
    }
};

```

`CriteriaGroups` is an array of `ArchiveRestrictionGroup`, and each group is implicitly joined by an OR operator.

As seen in the example above, the Name and Rank share the same numerical value, represent the order they appear in SuperOffice. The Name and Rank for the next `ArchiveRestrictionGroup` in the array is 1, and any subsequent group would increment accordingly.

### Archive Columns

To specify a field restriction you first need to get an [ArchiveColumnInfo](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/T_SuperOffice_CRM_ArchiveLists_ArchiveColumnInfo.htm) instance. While it's possible to lookup archive provider columns using the NetServer [documentation reference](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-ContactPersonDynamicSelectionV2ArchiveProvider.htm), it's recommended to get **and cache** the columns using the API. This is required to set the required information in an ArchiveRestrictionInfo.

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

```json
[
  {
    "DisplayName": "Selection ID",
    "DisplayTooltip": "The database ID of the selection",
    "DisplayType": "int",
    "CanOrderBy": false,
    "Name": "selectionId",
    "CanRestrictBy": true,
    "RestrictionType": "int",
    "RestrictionListName": null,
    "IsVisible": false,
    "ExtraInfo": "",
    "Width": "8c",
    "IconHint": "",
    "HeadingIconHint": ""
  },
  {
    "DisplayName": "Company ID",
    "DisplayTooltip": "Database ID of company",
    "DisplayType": "int",
    "CanOrderBy": true,
    "Name": "contactId",
    "CanRestrictBy": true,
    "RestrictionType": "int",
    "RestrictionListName": null,
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "5c",
    "IconHint": "Contact",
    "HeadingIconHint": ""
  },
  {
    "DisplayName": "Company name",
    "DisplayTooltip": "",
    "DisplayType": "string",
    "CanOrderBy": true,
    "Name": "name",
    "CanRestrictBy": true,
    "RestrictionType": "stringorPK",
    "RestrictionListName": "locateContact_new",
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "25%",
    "IconHint": "Contact",
    "HeadingIconHint": ""
  },
  {
    "DisplayName": "Department",
    "DisplayTooltip": "",
    "DisplayType": "string",
    "CanOrderBy": true,
    "Name": "department",
    "CanRestrictBy": true,
    "RestrictionType": "string",
    "RestrictionListName": null,
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "25%",
    "IconHint": "Contact",
    "HeadingIconHint": ""
  },
  {
    "DisplayName": "Company",
    "DisplayTooltip": "Displays the company an activity is linked to",
    "DisplayType": "string",
    "CanOrderBy": true,
    "Name": "nameDepartment",
    "CanRestrictBy": false,
    "RestrictionType": null,
    "RestrictionListName": null,
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "25%",
    "IconHint": "Contact",
    "HeadingIconHint": ""
  },
  {
    "DisplayName": "Has note",
    "DisplayTooltip": "Displays an icon indicating if there is additional information available about the contact",
    "DisplayType": "icon",
    "CanOrderBy": true,
    "Name": "hasInfoText",
    "CanRestrictBy": true,
    "RestrictionType": "bool",
    "RestrictionListName": null,
    "IsVisible": true,
    "ExtraInfo": "",
    "Width": "2c",
    "IconHint": "Contact",
    "HeadingIconHint": "paperclip"
  },
  //... removed for brevity
]
```

### Important ArchiveColumnInfo properties

| Property Name         |                                 Description                                 |
|-----------------------|-----------------------------------------------------------------------------|
| CanOrderBy            | Determines whether this column be used for sorting.                         |
| CanRestrictBy         | Determines whether this column be used as a restriction.                    |
| Name                  | Unique identity of this column; the name to be used when requesting the column from a provider, setting restrictions or order by criteria. |
| RestrictionType       | The data type of the restriction; use this to retrieve the legal operators for the restriction.  |
| RestrictionListName   | If the restriction data type is 'list', this property contains the name of the SoList so that choices can be shown.      |
| IconHint              | Used to group with corresponding columns.                                   |

### Get field operators by data type

A field operator determines what type of operation the criteria performs, i.e. comparison or range. Use the RestrictionType property to get the available operators for a given data type.

|Restriction type | List Type |
|-----------------|-----------|
|bool             | No        |
|date             | No        |
|datetime         | No        |
|decimal          | No        |
|int              | No        |
|positiveString   | No        |
|string           | No        |
|stringorPK       | No        |
|associate        | Yes       |
|ejUser           | Yes       |
|intArray         | Yes       |
|listAll          | Yes       |
|listAny          | Yes       |
|listInterest     | Yes       |
|userGroup        | Yes       |

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

```json
[
  {
    "Id": 1,
    "Name": "Starts with",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 1,
    "Type": "begins",
    "ColorBlock": 0,
    "IconHint": "",
    "Selected": false,
    "LastChanged": "0001-01-01T00:00:00",
    "ChildItems": [],
    "ExtraInfo": "W",
    "StyleHint": "",
    "Hidden": false,
    "FullName": null,
    "TableRight": null,
    "FieldProperties": {}
  },
  {
    "Id": 2,
    "Name": "Contains",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 2,
    "Type": "contains",
    "ColorBlock": 0,
    "IconHint": "",
    "Selected": false,
    "LastChanged": "0001-01-01T00:00:00",
    "ChildItems": [],
    "ExtraInfo": "W",
    "StyleHint": "",
    "Hidden": false,
    "FullName": null,
    "TableRight": null,
    "FieldProperties": {}
  },
  {
    "Id": 3,
    "Name": "Ends with",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 3,
    "Type": "ends",
    "ColorBlock": 0,
    "IconHint": "",
    "Selected": false,
    "LastChanged": "0001-01-01T00:00:00",
    "ChildItems": [],
    "ExtraInfo": "W",
    "StyleHint": "",
    "Hidden": false,
    "FullName": null,
    "TableRight": null,
    "FieldProperties": {}
  },
  {
    "Id": 4,
    "Name": "Equals",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 4,
    "Type": "is",
    "ColorBlock": 0,
    "IconHint": "",
    "Selected": false,
    "LastChanged": "0001-01-01T00:00:00",
    "ChildItems": [],
    "ExtraInfo": "W",
    "StyleHint": "",
    "Hidden": false,
    "FullName": null,
    "TableRight": null,
    "FieldProperties": {}
  }
]
```

Use the Type property to specify the ArchiveRestrictionInfo Operator property.

#### Working with columns and operators example (WebApi Client)

```csharp
private async void ColumnInfoArchiveRestrictionInfoAsync(Tenant tenant)
{
  // not important for the sake of this example
  var config = GetWebApiConfiguration(tenant); 

  var archiveAgent = new ArchiveAgent(config);
  var mdoAgent = new MDOAgent(config);

  // get available entities and columns (cache these in production!)

  MDOListItem[] entities = await archiveAgent.GetAvailableEntitiesAsync("ContactPersonDynamicSelectionV2", "");
  ArchiveColumnInfo[] columns = await archiveAgent.GetAvailableColumnsAsync("ContactPersonDynamicSelectionV2", "");

  // get companyId field

  ArchiveColumnInfo companyIdColumn = columns
      .Where(c => c.Name.Equals("contactId", StringComparison.OrdinalIgnoreCase))
      .Select(c => c).First(); // throw if not found

  // get all operators for the companyId column data type (cache these in production)

  MDOListItem[] operators = await mdoAgent.GetListAsync(
      "restrictionOperators", 
      true, 
      companyIdColumn.RestrictionType,
      false);

  // get just the equals operator

  MDOListItem equalsOperator = operators
      .Where(o => o.Name.Equals("Equals", StringComparison.OrdinalIgnoreCase))
      .Select(o => o).First(); // throw if not found

  // instantiate an ArchiveRestrictionInfo
  // set the ColumnInfo, set to active, and specify the criteria "contactId is 5"

  var restriction = new ArchiveRestrictionInfo()
  {
      ColumnInfo = companyIdColumn,
      IsActive = true,
      Name = companyIdColumn.Name,
      Operator = equalsOperator.Type, // "is"
      Values = new[] { "5" }
  };
}
```

## Set search criteria

### Fetching and saving criteria

The new search routines introduce the concept of __criteria groups__, where all criteria in a group are connected by AND operators, and all groups in the array of CriteriaGroups are connected by OR operators.

![Selection CriteriaGroups](media/selection-criteria-groups-conceptual.png)

The main points to understand are:

1. Each `ArchiveRestrictionInfo` in an `ArchiveRestrictionGroup` is implicitly joined by an AND operator.
2. Each `ArchiveRestrictionGroup` is implicitly joined by an OR operator.

The grouping and use of the AND and OR operators as such means it’s simple to define, maintain and comprehend how groups of criteria are applied to search routines.

The database layout to support this has been in place for a long time and was used in an equivalent fashion for Saint Status definitions. There, each criteria group was in a separate tab in the user interface; in the new Find screen, criteria groups are instead stacked vertically.

![Selection CriteriaGroups](media/selection-criteria-groups-actual.png)

Selection criteria are fetched and stored using the `GetDynamicSelectionCriteriaGroups` and `SetDynamicSelectionCriteriaGroups` methods on the Selection agent. Using them will retrieve and save all groups, and avoid having to make assumptions about the StorageKey concept used in the Find agent methods.

This example demonstrates how to get existing CriteriaGroups for a given selection.

### [REST](#tab/get-criteriagroups-1)

```http
GET /api/v1/Selection/28/CriteriaGroups
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
Accept-Language: en

```

### [Agent](#tab/get-criteriagroups-2)

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

### [WebApi Client](#tab/get-criteriagroups-3)

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

The following example demonstrates how to set the criteria for the personalized person entity. The criteria says to return all persons where the first name starts with B and ends with Y, or the first name starts with R and ends with Y.

The SQL equivalent is:

```sql
SELECT fName, lName
FROM Person
WHERE (fName LIKE 'B%' AND lName LIKE 'Y%')
   OR (fName LIKE 'R%' AND lName LIKE 'Y%')
```

This code sets the criteria for the personalized selection equal the SelectionForFind.SelectionId. The `SetDynamicSelectionCriteriaGroups[Async]` method returns the criteria groups that were passed in.

### [REST](#tab/set-criteria-groups-1)

```http
PUT /api/v1/Selection/24/CriteriaGroups
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json

[
  {
    "Name": "0",
    "Description": "",
    "Rank": 0,
    "Restrictions": [
      {
        "Name": "firstName",
        "Operator": "begins",
        "Values": [
          "B"
        ],
        "DisplayValues": [
          "B"
        ],
        "ColumnInfo": {
          "DisplayName": "[SR_PERSONARCHIVE_FIRSTNAME]",
          "DisplayTooltip": "[SR_PERSONARCHIVE_FIRSTNAME_TOOLTIP]",
          "DisplayType": "string",
          "CanOrderBy": true,
          "Name": "firstName",
          "CanRestrictBy": true,
          "RestrictionType": "string",
          "RestrictionListName": null,
          "IsVisible": true,
          "ExtraInfo": "",
          "Width": "20%",
          "IconHint": "Person",
          "HeadingIconHint": ""
        },
        "IsActive": true,
        "SubRestrictions": null,
        "InterParenthesis": 0,
        "InterOperator": "And",
        "UniqueHash": 939057318
      },
      {
        "Name": "lastName",
        "Operator": "begins",
        "Values": [
          "Y"
        ],
        "DisplayValues": [
          "Y"
        ],
        "ColumnInfo": {
          "DisplayName": "[SR_PERSONARCHIVE_LASTNAME]",
          "DisplayTooltip": "[SR_PERSONARCHIVE_LASTNAME_TOOLTIP]",
          "DisplayType": "string",
          "CanOrderBy": true,
          "Name": "lastName",
          "CanRestrictBy": true,
          "RestrictionType": "string",
          "RestrictionListName": null,
          "IsVisible": true,
          "ExtraInfo": "",
          "Width": "20%",
          "IconHint": "Person",
          "HeadingIconHint": ""
        },
        "IsActive": true,
        "SubRestrictions": null,
        "InterParenthesis": 0,
        "InterOperator": "And",
        "UniqueHash": -588059390
      }
    ]
  },
  {
    "Name": "1",
    "Description": "",
    "Rank": 1,
    "Restrictions": [
      {
        "Name": "firstName",
        "Operator": "begins",
        "Values": [
          "R"
        ],
        "DisplayValues": [
          "R"
        ],
        "ColumnInfo": {
          "DisplayName": "[SR_PERSONARCHIVE_FIRSTNAME]",
          "DisplayTooltip": "[SR_PERSONARCHIVE_FIRSTNAME_TOOLTIP]",
          "DisplayType": "string",
          "CanOrderBy": true,
          "Name": "firstName",
          "CanRestrictBy": true,
          "RestrictionType": "string",
          "RestrictionListName": null,
          "IsVisible": true,
          "ExtraInfo": "",
          "Width": "20%",
          "IconHint": "Person",
          "HeadingIconHint": ""
        },
        "IsActive": true,
        "SubRestrictions": null,
        "InterParenthesis": 0,
        "InterOperator": "And",
        "UniqueHash": 939057318
      },
      {
        "Name": "lastName",
        "Operator": "begins",
        "Values": [
          "Y"
        ],
        "DisplayValues": [
          "Y"
        ],
        "ColumnInfo": {
          "DisplayName": "[SR_PERSONARCHIVE_LASTNAME]",
          "DisplayTooltip": "[SR_PERSONARCHIVE_LASTNAME_TOOLTIP]",
          "DisplayType": "string",
          "CanOrderBy": true,
          "Name": "lastName",
          "CanRestrictBy": true,
          "RestrictionType": "string",
          "RestrictionListName": null,
          "IsVisible": true,
          "ExtraInfo": "",
          "Width": "20%",
          "IconHint": "Person",
          "HeadingIconHint": ""
        },
        "IsActive": true,
        "SubRestrictions": null,
        "InterParenthesis": 0,
        "InterOperator": "And",
        "UniqueHash": -588059390
      }
    ]
  }
]

```

### [Agent](#tab/set-criteria-groups-2)

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteriaGroups
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8
Accept-Language: en

{
  "SelectionId": 24,
  "Criteria": [
    {
      "Name": "0",
      "Description": "",
      "Rank": 0,
      "Restrictions": [
        {
          "Name": "firstName",
          "Operator": "begins",
          "Values": [
            "B"
          ],
          "DisplayValues": [
            "B"
          ],
          "ColumnInfo": {
            "DisplayName": "[SR_PERSONARCHIVE_FIRSTNAME]",
            "DisplayTooltip": "[SR_PERSONARCHIVE_FIRSTNAME_TOOLTIP]",
            "DisplayType": "string",
            "CanOrderBy": true,
            "Name": "firstName",
            "CanRestrictBy": true,
            "RestrictionType": "string",
            "RestrictionListName": null,
            "IsVisible": true,
            "ExtraInfo": "",
            "Width": "20%",
            "IconHint": "Person",
            "HeadingIconHint": ""
          },
          "IsActive": true,
          "SubRestrictions": null,
          "InterParenthesis": 0,
          "InterOperator": "And",
          "UniqueHash": 939057318
        },
        {
          "Name": "lastName",
          "Operator": "begins",
          "Values": [
            "Y"
          ],
          "DisplayValues": [
            "Y"
          ],
          "ColumnInfo": {
            "DisplayName": "[SR_PERSONARCHIVE_LASTNAME]",
            "DisplayTooltip": "[SR_PERSONARCHIVE_LASTNAME_TOOLTIP]",
            "DisplayType": "string",
            "CanOrderBy": true,
            "Name": "lastName",
            "CanRestrictBy": true,
            "RestrictionType": "string",
            "RestrictionListName": null,
            "IsVisible": true,
            "ExtraInfo": "",
            "Width": "20%",
            "IconHint": "Person",
            "HeadingIconHint": ""
          },
          "IsActive": true,
          "SubRestrictions": null,
          "InterParenthesis": 0,
          "InterOperator": "And",
          "UniqueHash": -588059390
        }
      ]
    },
    {
      "Name": "1",
      "Description": "",
      "Rank": 1,
      "Restrictions": [
        {
          "Name": "firstName",
          "Operator": "begins",
          "Values": [
            "R"
          ],
          "DisplayValues": [
            "R"
          ],
          "ColumnInfo": {
            "DisplayName": "[SR_PERSONARCHIVE_FIRSTNAME]",
            "DisplayTooltip": "[SR_PERSONARCHIVE_FIRSTNAME_TOOLTIP]",
            "DisplayType": "string",
            "CanOrderBy": true,
            "Name": "firstName",
            "CanRestrictBy": true,
            "RestrictionType": "string",
            "RestrictionListName": null,
            "IsVisible": true,
            "ExtraInfo": "",
            "Width": "20%",
            "IconHint": "Person",
            "HeadingIconHint": ""
          },
          "IsActive": true,
          "SubRestrictions": null,
          "InterParenthesis": 0,
          "InterOperator": "And",
          "UniqueHash": 939057318
        },
        {
          "Name": "lastName",
          "Operator": "begins",
          "Values": [
            "Y"
          ],
          "DisplayValues": [
            "Y"
          ],
          "ColumnInfo": {
            "DisplayName": "[SR_PERSONARCHIVE_LASTNAME]",
            "DisplayTooltip": "[SR_PERSONARCHIVE_LASTNAME_TOOLTIP]",
            "DisplayType": "string",
            "CanOrderBy": true,
            "Name": "lastName",
            "CanRestrictBy": true,
            "RestrictionType": "string",
            "RestrictionListName": null,
            "IsVisible": true,
            "ExtraInfo": "",
            "Width": "20%",
            "IconHint": "Person",
            "HeadingIconHint": ""
          },
          "IsActive": true,
          "SubRestrictions": null,
          "InterParenthesis": 0,
          "InterOperator": "And",
          "UniqueHash": -588059390
        }
      ]
    }
  ]
}

```

### [WebApi Client](#tab/set-criteria-groups-3)

```csharp

private async Task<ArchiveRestrictionGroup[]> SetPersonSearchCriteria(
    ArchiveAgent archiveAgent,
    SelectionAgent selectionAgent,
    MDOAgent mdoAgent,
    SelectionForFind selectionForFind)
{
    // get archive provider columns

    ArchiveColumnInfo[] columns = await archiveAgent.GetAvailableColumnsAsync(
        selectionForFind.ProviderName,
        "");

    // get just the first and last name columns

    var firstNameColumn = columns.Where(c => c.Name == "firstName").Select(c => c).FirstOrDefault();
    var lastNameColumn = columns.Where(c => c.Name == "lastName").Select(c => c).FirstOrDefault();

    // get operator from the column datatype
    // both firstName and lastName are the same data type...so only get one.

    MDOListItem[] operators = await mdoAgent.GetListAsync(
        "restrictionOperators",
        true,
        firstNameColumn.RestrictionType,
        false);

    // get the "begins" operator

    MDOListItem beginsOperator = operators
        .Where(o => o.Type.Equals("begins", StringComparison.OrdinalIgnoreCase))
        .Select(o => o).FirstOrDefault(); // throw if not found

    // define the criteria

    var criteriaGroups = new ArchiveRestrictionGroup[]
    {
        new ArchiveRestrictionGroup()
        {
             Name = "0",
             Rank = 0,
             Restrictions = new ArchiveRestrictionInfo[]
             {
                new ArchiveRestrictionInfo()
                {
                    Name = firstNameColumn.Name,
                    Operator = beginsOperator.Type,
                    Values = new[] {"B"},
                    IsActive = true,
                    ColumnInfo = firstNameColumn
                }, // AND
                new ArchiveRestrictionInfo()
                {
                    Name = lastNameColumn.Name,
                    Operator = beginsOperator.Type,
                    Values = new[] {"Y"},
                    IsActive = true,
                    ColumnInfo = lastNameColumn
                }
             }
        }, // OR
        new ArchiveRestrictionGroup()
        {
            Name = "1",
             Rank = 1,
             Restrictions = new ArchiveRestrictionInfo[]
             {
                new ArchiveRestrictionInfo()
                {
                    Name = firstNameColumn.Name,
                    Operator = beginsOperator.Type,
                    Values = new[] {"R"},
                    IsActive = true,
                    ColumnInfo = firstNameColumn
                }, // AND
                new ArchiveRestrictionInfo()
                {
                    Name = lastNameColumn.Name,
                    Operator = beginsOperator.Type,
                    Values = new[] {"Y"},
                    IsActive = true,
                    ColumnInfo = lastNameColumn
                }
             }
        }
    };

    // set the criteria

    return await selectionAgent.SetDynamicSelectionCriteriaGroupsAsync(
        selectionForFind.SelectionId,
        criteriaGroups);
}

```

___

## Perform the search

The search is performed using the Archive endpoint, which facilitates passing common parameters, including:

* Provider Name
* Desired columns
* Sort Order
* Restriction
* Entities
* Page
* Page Size

The selectionId is these examples is obtained from the SelectionForFind.SelectionId property in previous snippets.

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

### [WebClient API ](#tab/perform-search-3)

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
            Values = new [] {  selectionForFind.SelectionId.ToString() }
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

This article has demonstrated how to search SuperOffice using the same routines used by SuperOffice Find. This way guarantees your applications receive the same results observed both in Selections and using the Find dialog.

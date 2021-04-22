---
title: How SuperOffice populates available columns popup 
description: Describes the technique used to populate the criteria dialog columns popup.
author: {AnthonyYates}
keywords: NewSelection, Selection, Find
so.topic: article
so.envir: cloud, onsite
so.client: web
---

## Archive Columns

### Column Names

While it's possible to lookup archive provider columns using the NetServer [documentation reference](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-ContactPersonDynamicSelectionV2ArchiveProvider.htm), it's recommended to get **and cache** the columns using the API.

There are three types of interesting archive provider information obtained using the following format:

`archive{Descriptor}:{archiveProviderName}`

| Descriptor         | Archive Information                                        | When to use                                                                  |
|--------------------|------------------------------------------------------------|------------------------------------------------------------------------------|
| RestrictionColumns | Archive restriction columns, used like WHERE clause fields | When defining what provider columns to use as restrictions in CriteriaGroups |
| Columns            | Archive columns, used like SELECT fields                   | When defining what provider columns to select from the Archive endpoint      |
| Entities           | Archive entities                                           | When defining what provider entity(ies) to select from the Archive endpoint  |

#### Get archive restriction columns

Not all archive provider columns are usable as criteria. Therefore, use this method to obtain just the columns that are used to specify criteria.

# [REST](#tab/get-archive-restriction-columns-1)

```http
GET /api/v1/MDOList/archiveRestrictionColumns:ContactPersonDynamicSelectionV2 HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json

```

# [Agent](#tab/get-archive-restriction-columns-2)

```http
POST /api/v1/Agents/MDO/GetList HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json

{
  "Name": "archiveRestrictionColumns:ContactPersonDynamicSelectionV2",
  "ForceFlatList": true,
  "AdditionalInfo": "",
  "OnlyHistory": false
}

```

# [WebApi Client](#tab/get-archive-restriction-columns-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var mdoAgent = new MDOAgent(options);
MDOListItem[] listItems = await mdoAgent.GetList("archiveRestrictionColumns:ContactPersonDynamicSelectionV2","true","",false);
```

___

#### Get archive RestrictionColmns result

Returned columns represent each primary entity and all of their available columns listed in the ChildItems property.

Property definitions are listed later in this section, however, note that the ExtraInfo property when selecting RestrictionColumns specified the field datatype. This is important because not all data types support the same operators. and ExtraInfo is used to obtain what operators are supported for the field.

![Selection Criteria](../media/selection-search-criteria.png)

#### JSON query results

```json
[
  {
    "Id": 10000,
    "Name": "Other",
    //... removed for brevity
  },
  {
    "Id": 10001,
    "Name": "Company",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 10001,
    "Type": "",
    "ChildItems": [
      {
        "Id": 4,
        "Name": "Company ID",
        "ToolTip": "Database ID of company",
        "Deleted": false,
        "Rank": 4,
        "Type": "contactId",
        "ChildItems": [],
        "IconHint": "Contact",
        "ColorBlock": 0,
        "ExtraInfo": "int",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      {
        "Id": 5,
        "Name": "Company name",
        "ToolTip": "",
        "Deleted": false,
        "Rank": 5,
        "Type": "name",
        "ChildItems": [],
        "IconHint": "Contact",
        "ColorBlock": 0,
        "ExtraInfo": "stringorPK",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      {
        "Id": 6,
        "Name": "Department",
        "ToolTip": "",
        "Deleted": false,
        "Rank": 6,
        "Type": "department",
        "ChildItems": [],
        "IconHint": "Contact",
        "ColorBlock": 0,
        "ExtraInfo": "string",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      //... cutoff for brevity
    ]
  },
  {
    "Id": 10002,
    "Name": "Sale",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 10002,
    "Type": "",
    "ChildItems": [
      {
        "Id": 131,
        "Name": "With status",
        "ToolTip": "",
        "Deleted": false,
        "Rank": 131,
        "Type": "saintSaleStatus",
        "ChildItems": [],
        "IconHint": "Sale",
        "ColorBlock": 0,
        "ExtraInfo": "listAny",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      {
        "Id": 132,
        "Name": "Amount class",
        "ToolTip": "",
        "Deleted": false,
        "Rank": 132,
        "Type": "saintAmountClass",
        "ChildItems": [],
        "IconHint": "Sale",
        "ColorBlock": 0,
        "ExtraInfo": "listAny",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      {
        "Id": 186,
        "Name": "Completed",
        "ToolTip": "Displays a checkbox showing if an appointment is completed",
        "Deleted": false,
        "Rank": 133,
        "Type": "sale/completed",
        "ChildItems": [],
        "IconHint": "Sale",
        "ColorBlock": 0,
        "ExtraInfo": "bool",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
       //... cutoff for brevity
    ]
  },
  //... cutoff contact, follow-up, document, project, request, relation
]
```


#### Get archive entities

Only one Find archive provider returns more than one entity, ContactPersonDynamicSelectionV2 - `contact` and `person`.

While this isn't important to establish the CriteriaGroups, these routines are used in the final step when calling the Archive endpoint to get the results.

# [REST](#tab/get-archive-entities-columns-1)

```http
GET /api/v1/MDOList/archiveEntities:ContactPersonDynamicSelectionV2 HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json

```

# [Agent](#tab/get-archive-entities-columns-2)

```http
POST /api/v1/Agents/MDO/GetList HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json

{
  "Name": "archiveEntities:ContactPersonDynamicSelectionV2",
  "ForceFlatList": true,
  "AdditionalInfo": "",
  "OnlyHistory": false
}

```

# [WebApi Client](#tab/get-archive-entities-columns-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var mdoAgent = new MDOAgent(options);
MDOListItem[] listItems = await mdoAgent.GetList("archiveEntities:ContactPersonDynamicSelectionV2","true","",false);
```

___

#### REST JSON results

```json
[
  {
    "Id": 1,
    "Name": "Company",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 1,
    "Type": "contact",
    "ChildItems": [],
    "IconHint": "",
    "ColorBlock": 0,
    "ExtraInfo": "",
    "StyleHint": "mandatory",
    "FullName": "",
    "TableRight": null,
    "FieldProperties": {}
  },
  {
    "Id": 2,
    "Name": "Contact",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 2,
    "Type": "person",
    "ChildItems": [],
    "IconHint": "",
    "ColorBlock": 0,
    "ExtraInfo": "",
    "StyleHint": "mandatory",
    "FullName": "",
    "TableRight": null,
    "FieldProperties": {}
  }
]
```

### Get archive columns

These columns are useful when specifying the desired columns when calling the Archive endpoint. The ExtraInfo property indicates whether a field can be used in the ORDER BY clause in an [ArchiveOrderByInfo](https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/T_SuperOffice_CRM_ArchiveLists_ArchiveOrderByInfo.htm).

# [REST](#tab/get-archive-columns-1)

```http
GET /api/v1/MDOList/archiveColumns:ContactPersonDynamicSelectionV2 HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
Accept-Language: en

```

# [Agent](#tab/get-archive-columns-2)

```http
POST /api/v1/Agents/MDO/GetList HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
Accept-Language: en

{
  "Name": "archiveColumns:ContactPersonDynamicSelectionV2",
  "ForceFlatList": true,
  "AdditionalInfo": "",
  "OnlyHistory": false
}

```

# [WebApi Client](#tab/get-archive-columns-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);
// set Language options to en

// perform the request
var mdoAgent = new MDOAgent(options);
MDOListItem[] listItems = await mdoAgent.GetList("archiveColumns:ContactPersonDynamicSelectionV2","true","",false);
```

___

Selecting archive columns as such is only necessary when defining SELECT columns towards the Archive endpoint.

#### JSON query results

```json
[
  {
    "Id": 10001,
    "Name": "Company",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 10001,
    "Type": "",
    "ChildItems": [
      {
        "Id": 2,
        "Name": "Company ID",
        "ToolTip": "Database ID of company",
        "Deleted": false,
        "Rank": 2,
        "Type": "contactId",
        "ChildItems": [],
        "IconHint": "Contact",
        "ColorBlock": 0,
        "ExtraInfo": "Y",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      {
        "Id": 3,
        "Name": "Company name",
        "ToolTip": "",
        "Deleted": false,
        "Rank": 3,
        "Type": "name",
        "ChildItems": [],
        "IconHint": "Contact",
        "ColorBlock": 0,
        "ExtraInfo": "Y",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      {
        "Id": 4,
        "Name": "Department",
        "ToolTip": "",
        "Deleted": false,
        "Rank": 4,
        "Type": "department",
        "ChildItems": [],
        "IconHint": "Contact",
        "ColorBlock": 0,
        "ExtraInfo": "Y",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      }
      //... cutoff for brevity
    ]
  },
  {
    "Id": 10002,
    "Name": "Relation",
    "ToolTip": "",
    "Deleted": false,
    "Rank": 10002,
    "Type": "",
    "ChildItems": [
      {
        "Id": 104,
        "Name": "Source - Company ID",
        "ToolTip": "Database ID of company",
        "Deleted": false,
        "Rank": 104,
        "Type": "sourceRelation/contactId",
        "ChildItems": [],
        "IconHint": "Relation",
        "ColorBlock": 0,
        "ExtraInfo": "Y",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      {
        "Id": 105,
        "Name": "Source - Company name",
        "ToolTip": "",
        "Deleted": false,
        "Rank": 105,
        "Type": "sourceRelation/name",
        "ChildItems": [],
        "IconHint": "Relation",
        "ColorBlock": 0,
        "ExtraInfo": "Y",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      },
      {
        "Id": 106,
        "Name": "Source - Department",
        "ToolTip": "",
        "Deleted": false,
        "Rank": 106,
        "Type": "sourceRelation/department",
        "ChildItems": [],
        "IconHint": "Relation",
        "ColorBlock": 0,
        "ExtraInfo": "Y",
        "StyleHint": "",
        "FullName": "",
        "TableRight": null,
        "FieldProperties": {}
      }
       //... cutoff for brevity
    ]
  },
  //... cutoff contact, sale, follow-up, document, project, request
]
```

Whether getting columns or entities, the result is an array of **`MDOListItem`**. The structures do differ slightly between columns and entities.

### Column results

| Property           |Description                                           |
|--------------------|------------------------------------------------------|
|ID                  | Arbitrary number, starts at 1                        |
|Name                | DisplayName of column                                |
|Tooltip             | DisplayTooltip of column                             |
|Rank                | Same as ID (items are already in rank order)         |
|Deleted             | always false                                         |
|Type                | the programmatic name of the column, like person/fullName |
|Color               | always 0                                             |
|IconHint            | iconhint from column                                 |
|StyleHint           | blank                                                |
|ExtraInfo           | When archiveColumns: list, an “Y” or “N” if OrderBy is supported.<br/>When archiveRestrictionColumns: list, the column RestrictionType |
|Selected            | true if the column is selected for display, i.e. there is a row in the superlistcolumnsize table |

#### Entity Results

| Property           |Description                                           |
|--------------------|------------------------------------------------------|
|ID                  | Arbitrary number, starts at 1                        |
|Name                | DisplayName of entity                                |
|Tooltip             | DisplayTooltip of entity                             |
|Rank                | Same as ID (items are already in rank order)         |
|Deleted             | always false                                         |
|Type                | the programmatic name of the entity, like retired    |
|Color               | always 0                                             |
|IconHint            | blank                                                |
|StyleHint           | blank if entity is optional, “mandatory” if the entity isn’t optional |
|ExtraInfo           | blank                                                |
|Selected            | true if the entity is selected for display, i.e. there is a row in the superlistcolumnsize table  with an e: prefix in the listOwner field |

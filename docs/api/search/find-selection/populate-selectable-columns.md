---
title: How SuperOffice populates available columns popup
uid: find_selection_archive_columns
description: Describes the technique used to populate the criteria dialog columns popup.
author: {AnthonyYates}
keywords: NewSelection, Selection, Find
so.topic: concept
so.envir: cloud, onsite
so.client: web
---

# Archive columns - column names

While it's possible to look up archive provider columns using the NetServer [documentation reference][1], it's recommended to get **and cache** the columns using the API.

There are 3 types of interesting archive information:

* Archive columns
* Archive restriction columns
* Archive entities

They are obtained using the following format:

`archive{Descriptor}:{archiveProviderName}`

| Descriptor | Archive information | When to use |
|---|---|---|
| RestrictionColumns | Archive restriction columns, used like WHERE clause fields | When defining what provider columns to use as restrictions in `CriteriaGroups` |
| Columns | Archive columns, used like SELECT fields | When defining what provider columns to select from the Archive endpoint |
| Entities | Archive entities | When defining what provider entities to select from the Archive endpoint |

## CriteriaGroups

New Selection introduces the concept of **criteria groups**, where the criteria within each group are connected by AND, and groups are connected by OR. The database layout to support this has been in place for a long time and was used in an equivalent fashion for Saint Status definitions. There, each criteria group was in a separate tab in the user interface; in the new **Filter** screen groups are stacked vertically instead.

APIs that only work with a simple `ArchiveRestrictionInfo[]` do not support the concept of multiple groups. Such methods will only return the first group, and on writing will delete any other groups. Examples are `GetDynamicSelectionCriteria` and `SetDynamicSelectionCriteria`; and similar methods in the Find agent. All these methods should be considered obsolete when applied to Selection and Find.

Selection criteria should be fetched and stored using the `GetDynamicSelectionCriteriaGroups` and `SetDynamicSelectionCriteriaGroups` methods on the Selection agent. Using them will retrieve and save all groups, and avoid having to make assumptions about the StorageKey concept used in the Find agent methods. Contrast the differences in the two calls (the ts.Key is a selection ID).

## Get archive columns

These columns are useful when specifying the desired columns when calling the Archive endpoint. The `ExtraInfo` property indicates whether a field can be used in the ORDER BY clause in an [ArchiveOrderByInfo][3].

### [REST](#tab/get-archive-columns-1)

```http
GET /api/v1/MDOList/archiveColumns:ContactPersonDynamicSelectionV2 HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
Accept-Language: en
```

### [Agent](#tab/get-archive-columns-2)

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

### [WebApi Client](#tab/get-archive-columns-3)

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

### JSON query results

[!code-json[JSON](includes/get-archive-columns-results.json)]

Whether getting columns or entities, the result is an array of `MDOListItem`. The structures do differ slightly between columns and entities.

## Get archive restriction columns

Not all archive provider columns can be used as criteria. Therefore, use this method to obtain just the columns that are used to specify criteria.

### [REST](#tab/get-archive-restriction-columns-1)

```http
GET /api/v1/MDOList/archiveRestrictionColumns:ContactPersonDynamicSelectionV2 HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
```

### [Agent](#tab/get-archive-restriction-columns-2)

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

### [WebApi Client](#tab/get-archive-restriction-columns-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var mdoAgent = new MDOAgent(options);
MDOListItem[] listItems = await mdoAgent.GetList("archiveRestrictionColumns:ContactPersonDynamicSelectionV2","true","",false);
```

___

### Get archive RestrictionColmns result

Returned columns represent each primary entity and all of their available columns listed in the `ChildItems` property.

Property definitions are listed later in this section, however, note that the `ExtraInfo` property when selecting `RestrictionColumns` specifies the field datatype. This is important because not all data types support the same operators, and `ExtraInfo` is used to obtain what operators are supported for the field.

![Selection criteria][img1]

### JSON query results

[!code-json[JSON](includes/get-archive-restriction-columns-results.json)]

## Get archive entities

Only one Find archive provider returns more than one entity, `ContactPersonDynamicSelectionV2` - `contact` and `person`.

While this isn't important to establish the `CriteriaGroups`, these routines are used in the final step when calling the Archive endpoint to get the results.

### [REST](#tab/get-archive-entities-columns-1)

```http
GET /api/v1/MDOList/archiveEntities:ContactPersonDynamicSelectionV2 HTTP/1.1
Authorization: Bearer {{token}}
Content-Type: application/json
Accept: application/json
```

### [Agent](#tab/get-archive-entities-columns-2)

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

### [WebApi Client](#tab/get-archive-entities-columns-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var mdoAgent = new MDOAgent(options);
MDOListItem[] listItems = await mdoAgent.GetList("archiveEntities:ContactPersonDynamicSelectionV2","true","",false);
```

___

### REST JSON results

[!code-json[JSON](includes/get-archive-entities-columns-results.json)]

## MDOListItem array

Whether getting columns or entities, the results an array of MDOListItem. The structures do differ slightly between columns and entities.

### Entity results

| Property | Description|
|---|---|
| ID        | An arbitrary number, starts at 1 |
| Name      | DisplayName of entity |
| Tooltip   | DisplayTooltip of entity |
| Rank      | Same as ID (items are already in rank order) |
| Deleted   | always false |
| Type      | the programmatic name of the entity, like retired |
| Color     | always 0 |
| IconHint  | blank |
| StyleHint | blank if entity is optional, "mandatory" if the entity isn’t optional |
| ExtraInfo | blank |
| Selected  | true if the entity is selected for display, meaning there is a row in the `superlistcolumnsize` table with an e: prefix in the `listOwner` field |

### Column results

| Property |Description |
|---|---|
| ID        | An arbitrary number, starts at 1 |
| Name      | DisplayName of column |
| Tooltip   | DisplayTooltip of column |
| Rank      | Same as ID (items are already in rank order) |
| Deleted   | always false |
| Type      | the programmatic name of the column, like person/fullName |
| Color     | always 0 |
| IconHint  | icon hint from column |
| StyleHint | blank |
| ExtraInfo | When `archiveColumns`: list, a "Y" or "N" if OrderBy is supported.<br/>When `archiveRestrictionColumns`: list, the column `RestrictionType` |
| Selected | true if the column is selected for display, meaning there is a row in the `superlistcolumnsize` table |

<!-- Referenced links -->
[1]: ../../archive-providers/reference/contactpersondynamicselectionv2.md
[2]: ../../../api-reference/netserver/core/superoffice.crm.archivelists.archiveorderbyinfo.yml

<!-- Referenced images -->
[img1]: ../media/selection-search-criteria.png

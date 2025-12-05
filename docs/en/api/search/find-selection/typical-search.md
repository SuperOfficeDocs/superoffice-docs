---
uid: api-selection-typical-search
title: Typical search
description: Details Find Selection Typical Search feature set.
keywords: Typical search, Selection, Find
author: AnthonyYates
date: 12.05.2025
version: 11
content_type: concept
platform: web
redirect_from: /en/api/netserver/search/find-selection/typical-search
---

<!-- markdownlint-disable-file MD051 -->
# Typical search

Typical searches are predefined searches included with SuperOffice CRM. They provide a starting point when users create selections or filter data. A typical search copies its criteria into the user’s working set, which the user can then edit without modifying the original definition.

## How typical searches work

Typical searches are stored as predefined selection templates. When the user chooses a typical search, its criteria replace the users current find criteria for the specified entity. If the user later decides to reset the criteria, they reset to the entity's default, not the typical search criteria that was copied.

## Updating typical searches

Typical searches are distributed as a JSON file stored in cloud storage. SuperOffice automatically updates the customer database when a newer version of the file is available. Updates may be triggered on a schedule or by manual requests from SuperOffice Operations Center.

## Data model

Typical searches use the same underlying search tables as other selection types, with an additional table that defines metadata for each typical search.

The 5 tables are:

* [SearchCriteria][1]
* [SearchCriteriaGroup][2]
* [SearchCriterion][3]
* [SearchCriterionValue][4]
* [TypicalSearch][5]

The TypicalSearch fields are:

| Name | Data type |
| --- | --- |
| Id | int |
| Title | string |
| Tooltip | string |
| IsEntityDefault | short |
| IncludePerson | short |
| VersionNumber | int |
| Source | string |

A full list of the table fields can be found at the database reference.

Multi-language strings are used for the typical search title and tooltip to support all the different languages in SuperOffice.  The target entity field indicates which table the typical search is a selection of.

SearchCriteria contain `typicalsearch` in the name column, as well as the typical search ID (ownerId). A reference to the search provider is listed in the name field.

The name field consists of 3 parts: a search provider, the owner type (Selection, TypicalSearch, Associate) and an ID.

Example: `findproject selection=65`

A high-level description of how the criteria are stored:

* One top level anchor/owner (SelectionCriteria)
* A grouping of a set of criteria (SearchCriteriaGroup) which can be used to create "OR" groups.
* The type of criteria to use for filtering (SearchCriterion).
* The filtering value of the criteria (SearchCriterionValue) as in "one of..." or "equals..."

## Interface/API Definitions

### Import

`TypicalSearchesImplementation.UpdateTypicalSearches(TypicalSearches config)`

If the input parameter is null, it searches the file system to locate updated json files and import the data to the database. If the input parameter contains a `TypicalSearches` carrier, the contained data is imported.

### Find provider

`SuperOffice.Services.MDOListImplementation.GetList( string name, bool forceFlatList, string additionalInfo, bool onlyHistory)`

This method retrieves the typical search titles, tooltips and their related IDs for in the Find panel. The name parameter for the TypicalSearchProvider is TypicalSearch and additional info correspond to the entity name.

### Get Typical Search items

For each **entity** it's possible to obtain the list of corresponding typical search items.

#### [REST](#tab/find-typical-1)

```http

GET /api/v1/MDOList/typicalSearch/selectable?additional=contact HTTP/1.1
Authorization: Bearer {access_token}
Content-Type: application/json
Accept: application/json
Accept-Language: en
```

#### [Agent](#tab/find-typical-2)

```http
POST /api/v1/Agents/MDO/GetList HTTP/1.1
Authorization: Bearer {access_token}
Content-Type: application/json
Accept: application/json

{
  "Name": "typicalSearch",
  "ForceFlatList": true,
  "AdditionalInfo": "contact",
  "OnlyHistory": false
}
```

#### [WebApi Client](#tab/find-typical-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var mdoAgent = new MDOAgent(options);
MDOListItem[] findEntities = await mdoAgent.GetListAsync("typicalSearch", true, "contact", false);
```

***

### Get archive provider for entity by typical search ID

Different typical search routines use different archive providers to perform the search. The following code demonstrates how to get the provider responsible for performing a typical search. There is no pure REST API to obtain this information. Use either the HTTP RPC Agent API or the WebApi client.

#### [Agent](#tab/find-archive-provider-1)

```http
POST /api/v1/Agents/Selection/GetSelectionForFind HTTP/1.1
Authorization: Bearer {access_token}
Content-Type: application/json
Accept: application/json

{
  "EntityName": "contact",
  "TypicalSearchId": 2
}
```

#### [WebApi Client](#tab/find-archive-provider-2)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

// perform the request
var agent = new SelectionAgent(options);
SelectionForFind selForFind = await agent.GetSelectionForFindAsync("contact", 2);
```

***

### Azure

SuperOffice.Services.TypicalSearchesImplementation.RequestLatestTypicalSearches(TypicalSearch optionalData)

Call this method to request an update to Azure Online for the typical searches.

**Continue reading:** [Details regarding export and import of typical search][6]

<!-- Referenced links -->
[1]: ../../../database/tables/searchcriteria.md
[2]: ../../../database/tables/searchcriteriagroup.md
[3]: ../../../database/tables/searchcriterion.md
[4]: ../../../database/tables/searchcriterionvalue.md
[5]: ../../../database/tables/typicalsearch.md
[6]: import-export-typical-search.md

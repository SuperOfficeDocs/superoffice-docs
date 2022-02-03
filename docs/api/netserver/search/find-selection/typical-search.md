---
title: Typical search
description: Details Find Selection Typical Seach feature set.
author: {AnthonyYates}
keywords: Typical search, Selection, Find
so.topic: article
# so.envir:
so.client: web
---

# Typical search

Typical searches are a set of predefined searches created by SuperOffice to enable the users to get started with search and selections more easily. If the user is unsure of where to start, typical searches can help the user getting started given a set of predefined searches.

## Non-goals

The following related problems will not be addressed in this design:

* How to create the files stored in the Online Template Library (this will initially be done manually). There will likely be one file with all templates specified in Json format
* How to update Updating Online Template Library files in the cloud.
* The implementation of AND/OR search criteria.

## TypicalSearch master installation

The source of the Typical Searches is the “ACME AS” installation in SOD, Cust21128. In this installation there is a Search Category called “Typical Search”, which is used to mark Dynamic Selections that are to be considered Typical Searches.

![Selection Typical Search][img1]

The intention is that Product Owners will be responsible for adding or changing these Selections in the ACME AS installation. Towards the end of a sprint someone (initially a developer) will then run the TypicalSearchExporter, a command-line utility that creates a file with all the searches. This file becomes part of the distributed fileset. Finally, an import/update function in the fileset updates the individual customer database.

## Proposed Design

The set of predefined typical searches created by SuperOffice will be stored in a cloud storage as a file with json file-format encoding. An update service (likely with different triggers/schedulers onsite and online) will update the typical searches with any new versions if found, by querying the central service for the json file. If a newer typical search version exists, the file will be downloaded and used to update the client’s database. This request will likely be sent once per day per customer onsite, may be different for online (on demand when file is updated or some scheduling algorithm).

It should also be possible to send a request for a customer from the SuperOffice Operations Center. This will allow for fast updates when new typical searches are available.  

The client will then be able to fetch the updated typical searches from the database when clicking the find-button.

After selecting a typical search, the related criteria will be copied to the users working set of criterias for the specified entity (the previous criterias are just deleted). Then the new/copied version will be fetched by the filter screen when the user is redirected there after selecting a typical search (clicking on the typical search link).

## Data Model

In the database, typical searches can be stored in a cluster of 5 tables. The tables are:

* TypicalSearch
* SearchCriteria
* SearchCriteraGroup
* SearchCriterion
* CriterionValue

The only new table is TypicalSearch, the other tables are used by the other searching functions in SuperOffice to store data regarding search criteria and search providers.

The TypicalSearch fields are:

|Name           |Data type|
|---------------|---------|
|Id             | int     |
|Title          | string  |
|Tooltip        | string  |
|IsEntityDefault| short   |
|IncludePerson  | short   |
|VersionNumber  | int     |
|Source         | string  |

Multi-language strings will be used for the typical search title and tooltip to support all the different languages in SuperOffice.  The target entity field indicates which table the typical search is a selection of.

SearchCriteria will contain `typicalsearch` in the name column, as well as the typical search id (ownerId). A reference to the search provider will be listed in the name field.

The name field consists of 3 parts: a search provider, the owner type (Selection, TypicalSearch, Associate) and an id.

Example: `findproject selection=65`

A high-level description of how the criteria are stored is with:

* One top level anchor/owner (SelectionCriteria)
* A grouping of a set of criteria (SearchCriteriaGroup) which can be used to create “OR” groups.
* The desired type of criteria desired to be used for filtering (SearchCriterion).
* The filtering value of the criteria (SearchCriterionValue) as in “one of...” or “equals...”

A full list of the table fields can be found at the following references:

* [SearchCriteria][1]
* [SearchCriteriaGroup][2]
* [SearchCriterion][3]
* [SearchCriterionValue][4]
* [TypicalSearch][5]

## Interface/API Definitions

### Import

`TypicalSearchesImplementation.UpdateTypicalSearches(TypicalSearches config)`

In version 1, if the input parameter is null, it will search the file system to locate updated json files and import the data to the database. If the input parameter contains a TypicalSearches carrier, then the contained data will be imported.

### Find provider

SuperOffice.Services.MDOListImplementation.GetList( string name, bool forceFlatList, string additionalInfo, bool onlyHistory)

This service method will be used to retrieve the typical search titles, tooltips and their related ids for in the Find panel for the SCIL MDOComponent. The name parameter for the TypicalSearchProvider is TypicalSearch and additional info correspond to the entity name.

### Get Typical Search items

For each _entity_ it’s possible to obtain the list of corresponding typical search items.

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

___

### Get archive provider for entity by typical search ID

Different typical search routines use different archive providers to perform the search. The following code demonstrates how to get the provider responsible for performing a typical search. There is no pure REST API to obtain this information. Use either the RESTful Agent API or the WebApi client.

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

___

### Azure

SuperOffice.Services.TypicalSearchesImplementation.RequestLatestTypicalSearches(TypicalSearch optionalData)
This service method will be used to request an update to Azure Online for the typical searches.

## Business Logic

When a user selects a typical search, their associate-owned temporary selection’s criteria is replaced with a copy of the typical search criteria. The user can edit these search criteria without making changes to the typical searches. If the user later decides to reset their associate-owned find criteria, it’s defaulted back to the default of that entity, not the typical search criteria that was copied.

## Impact (System)

The implementation of typical searches will increase traffic to Azure-services, and hopefully it will help reduce the number of unused, stored selection. We can limit traffic a lot by requesting only the header of the file, which could contain version information or last modified date or something.

## Alternatives

When resetting an associate-owned set of criteria that has been created from a set of typical search criteria to the default criteria; it’s possible to use the typical search criteria as the default. However, this idea has been rejected due to the potential confusion the user might experience, if they are expecting another set of criteria (the search provider’s default set of criteria for the current entity / typical search default criteria). Always resetting to a predefined typical search, default set of criteria is simpler.

When storing typical searches to the database it’s would be possible to use a selection type instead of a new table. However, storing the additionally needed data would be an issue. Creating a new table with the required fields can fulfil those needs.

**Continue reading:** [Details regarding export and import of typical search][6]

<!-- Referenced links -->
[1]: ../../../../../database/docs/tables/searchcriteria.md
[2]: ../../../../../database/docs/tables/searchcriteriagroup.md
[3]: ../../../../../database/docs/tables/searchcriterion.md
[4]: ../../../../../database/docs/tables/searchcriterionvalue.md
[5]: ../../../../../database/docs/tables/typicalsearch.md
[6]: import-export-typical-search.md

<!-- Referenced images -->
[img1]: ../media/selection-typical-search.png

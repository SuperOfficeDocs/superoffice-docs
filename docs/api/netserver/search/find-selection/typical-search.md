---
# Mandatory fields.
title: Typical Search                          # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Details Find Selection Typical Seach feature set.  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {AnthonyYates}             # Your GitHub alias.
keywords: Typical search, Selection, Find
so.topic: article                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
so.client: web                   # online, web, or win
---

# Typical Search

Typical searches are a set of predefined searches created by SuperOffice to enable the users to get started with search and selections more easily. If the user is unsure of where to start, typical searches can help the user getting started given a set of predefined searches.

## Terminology

|Name           | Description |
|---------------|------------------------------------------------------|
|Typical search | These are a set of predefined search templates created by SuperOffice to enable the users to get started with search and selections more easily.|
|Default criteria| Each entity has a predefined set of criteria that is retrieved when a criteria provider cannot find a user defined set of criteria or when you reset search criteria.|
|Last find criteria|The last find criteria are the last set of criteria specified by the user on the filter screen. There are separate sets of criteria saved for each entity.|
|Online Template Library|The online template library is the Azure-online-service that stores the latest typical searches to the clients. Database data will not be updated by priming (but likely on upgrade) as well as by some updating service.|

## Non-Goals

The following related problems will not be addressed in this design:

* How to create the files stored in the Online Template Library (this will initially be done manually). There will likely be one file with all templates specified in json format
* How to update Updating Online Template Library files in cloud.
* The implementation of AND/OR search criteria.

## TypicalSearch master installation

The source of the Typical Searches is the “ACME AS” installation in SOD, Cust21128. In this installation there is a Search Category called “Typical Search”, which is used to mark Dynamic Selections that are to be considered Typical Searches.

![Selection Typical Search](../media/selection-typical-search.png)

The intention is that Product Owners will be responsible for adding or changing these Selections in the ACME AS installation. Towards the end of a sprint someone (initially a developer) will then run the TypicalSearchExporter, a command-line utility that creates a file with all the searches. This file becomes part of the distributed fileset. Finally, an import/update function in the fileset updates the individual customer database.

## Proposed Design

The set of predefined typical searches created by SuperOffice will be stored in a cloud storage as a file with json file-format encoding. An update service (likely with different triggers/schedulers onsite and online) will update the typical searches with any new versions if found, by querying the central service for the json file. If a newer typical search version exists, the file will be downloaded and used to update the client’s database. This request will likely be sent once per day per customer onsite, may be different for online (on demand when file is updated or some scheduling algorithm).

It should also be possible to send a request for a customer from the SuperOffice Operations Center. This will allow for fast updates when new typical searches are available.  

The client will then be able to fetch the updated typical searches from the database when clicking the find-button.

After selecting a typical search, the related criteria will be copied to the users working set of criterias for the specified entity (the previous criterias are just deleted). Then the new/copied version will be fetched by the filter screen when the user is redirected there after selecting a typical search (clicking on the typical search link).

## Data Model

In the database, typical searches be stored in a cluster of 5 tables. The tables are:

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

* [SearchCriteria](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-SearchCriteria.htm)

* [SearchCriteriaGroup](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-SearchCriteriaGroup.htm)

* [SearchCriterion](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-SearchCriterion.htm)

* [SearchCriterionValue](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-SearchCriterionValue.htm)

* [TypicalSearch](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-TypicalSearch.htm)

## Interface/API Definitions

### Import

`TypicalSearchesImplementation.UpdateTypicalSearches(TypicalSearches config)`

In version 1, if the input parameter is null, it will search the file system to locate updated json files and import the data to the database. If the input parameter contains a TypicalSearches carrier, then the contained data will be imported.

### Find provider

SuperOffice.Services.MDOListImplementation.GetList( string name, bool forceFlatList, string additionalInfo, bool onlyHistory) 

This service method will be used to retrieve the typical search titles, tooltips and their related ids for in the Find panel for the SCIL MDOComponent. The name parameter for the TypicalSearchProvider is TypicalSearch and additional info correspond to the entity name. 

### Get Typical Search items

For each _entity_ it’s possible to obtain the list of corresponding typical search items. [Typical Search](./typical-search.md) is covered more in the Typical Search article.

# [REST](#tab/find-typical-1)
```http

GET /api/v1/MDOList/typicalSearch/selectable?additional=contact HTTP/1.1
Authorization: Bearer {access_token}
Content-Type: application/json
Accept: application/json
Accept-Language: en
```

# [Agent](#tab/find-typical-2)
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

# [WebApi Client](#tab/find-typical-3)
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

# [Agent](#tab/find-archive-provider-1)
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

# [WebApi Client](#tab/find-archive-provider-2)
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

## Details regarding export/import of typical search (below under construction)

### Export of typical searches from SOD site to json file

The typical search data that will be stored in customer's databases will be created on a SOD site. Each selection will be marked as a typical search by setting a search category to Typical Search.  

The exported typical search criteria data will be exported as ArchiveRestrictionGroups. These ArchiveRestrictionGroups will be mapped to the typicalsearch_id. The various id’s stored in the json file are only meant to show the relations between the tables. The id’s that will be generated in the customer’s database will not copy the id’s in the exported json file.  

### How are the typical searches numbered

For each new or changed typical searches, the version number is increased to the highest pre-existing version number (out of all typical searches) + 1. Note that changes to the criteria will also update the version number of the related typical search. 

__Example of how version numbers are increased:__

The initial, first week, SuperOffice adds 4 typical searches with the version number 1.

|Title  |VersionNumber    |
|-------|-----------------|
|My companies        |1   |
|My sales            |1   |
|My top 10 projects  |1   |
|My tickets          |1   |

The next week SuperOffice decides to update the sales typical search and add a typical search for appointments. In this case the typical search version number for the sales and appointments version number is to the highest existing version number in the database (1) plus 1.

|Title            |VersionNumber|
|--------------------------|----|
|My most loyal companies   |1   |
|My best sales             |2   |
|My top 10 projects        |1   |
|My tickets                |1   |
|My appointments           |2   |

The third week SuperOffice decides to update the companies and projects. Now the typical search version number for both companies and projects version number is increased to the highest existing version number in the database (2) plus 1.

|Title            |VersionNumber|
|--------------------------|----|
|My most loyal companies   |3   |
|My best sales             |2   |
|My top 10 projects        |3   |
|My tickets                |1   |
|My appointments           |2   |

### Requesting a typical search update

When a customer is checking if for an update of the typical searches, the customer sends the highest version number stored in their customer database. If any of the typical searches in the json file has a higher version number that the customers highest version number; then the customers typical searches will need an update. The typical search data in the json file will then be used to update the customers database.

### When the only change is a removed typical search

The MasterVersion number in the TypicalSearches carrier is incremented once per deleted typical search. It is stored in both the Master installation at Superoffice, and in each customer database. It is therefore possible to see that there has in fact been a change since the last import; and once all the typical searches in the carrier have been imported, whatever is left over will be deleted. This deletion can be inhibited by setting the DeleteLeftovers property to false, but Superoffice does not expect to use this feature.

### TypicalSearchExporter

This is a .NET Framework, command-line utility. It uses the OIDC authentication flow documented in https://community.superoffice.com/en/developer/create-apps/quickstart/create-native-app/ and allows anyone who has access to the site, to run it.

The utility uses ordinary NetServer API calls to list and retrieve all selections that are dynamic and marked with the Typical Search category, for the standard entities. Such selections should only refer to standard fields as criteria, never user-defined or extra-fields as those will not be present in the customer installation.

The selection name, entity, and long comment are exported. Owner, Category, Completed and Visible for are ignored (since they have no relevant match in a customer database). The selection name will become the TypicalSearch name. If it matches a resource in the Primer Data(8.5) product, module TypicalSearch, then the corresponding translations will be retrieved and exported as a multi-language string. Otherwise, the selection name is used as-is.

The data are exported using the service layer carriers __TypicalSearchConfiguration__ -> __TypicalSearch__ -> __ArchiveRestrictionGroup__ -> __ArchiveRestriction__. The final file format is JSON.

The TypicalSearch.Version number is assigned based on a global counter. The first selection is assigned version 1, the second gets 2, etc. In addition, the TypicalSearchExporter uses the ForeignKey feature to store the registered/last updated date together with the assigned version number, for each such selection, in the ACME AS installation. To detect changes in the criteria (which do not update the updated field of the selection itself), a SHA256 hash of all criteria/operators/values is also stored in the foreignkey. The foreignkey value itself is in JSON format.  

When an export is performed, if a selection has a newer updated date than the last (or a hash mismatch), the global version number counter is increased by one and that version number assigned to the selection (and saved in ForeignKey).

### Updating the customers database

When there has been an update to typical searches, it’s not necessarily the case that all typical searches are new or changed. There may have for example only been changes to one typical search. This one typical search will then have a higher version number than the customers highest typical search version number. However, all the other typical searches will not have changed. To find out what has changed, what is new and what is removed; we compare the customers typical searches with the latest typical searches.

Algorithm for determining what changes to make to the customers database

If the customers highest version number is lower than highest typical search version number from the json file; then we need to make some changes.

We make two list of the fields: version numbers, title and entity. One from the imported data and the other from the customers database.

The instances that exists in both lists: will remain unchanged.

The instances that share the same entity and title, but with great version number (imported > database): will lead to an update for the related typical search.

The instances that only exist in the database lists (no matching entity + title): will be deleted.

The instances that only in exist in the imported lists (no matching entity + title): will be added as new typical searches.

#### Pseudocode

```csharp
public void UpdateToLatestTypicalSearches()
{
    int currentVersion = GetHeighestVersionNumberFromDatabase();
    bool currentIsOld = AreThereNewerTypicalSearches(currentVersion);

    if (!currentIsOld)
        return;

    var importedData = GetTypicalSearchDataFromFile("C:\filepathOfJsonFile");

    List<TypicalSearchRow> toBeAdded = GetTypicalSearchRowsFromData(importedData);

    List<TypicalSearchRow> toBeDeleted = GetTypicalRowsFromDatabase();

    List<TypicalSearchRow> toBeUpdated = new List<TypicalSearchRow>();

    foreach (TypicalSearchRow newRow in toBeAdded)
    {
        foreach (TypicalSearchRow oldRow in toBeDeleted)
        {
            if (oldRow.Title ==  newRow.Title &&
                oldRow.Entity == newRow.Entity)
            {
                toBeAdded.Remove(newRow);
                toBeDeleted.Remove(oldRow);

                if (oldRow.VersionNumber != newRow.VersionNumber)
                {
                    TypicalSearchRow updatedRow = UpdateOldRowWithNewData(oldRow,newRow);

                    toBeUpdated.Add(updatedRow);
                }
                break;
            }  
        }
    }
    Database.Add(toBeAdded);
    Database.Remove(toBeDeleted);
    Database.Update(toBeUpdated);
}
```
---
title: Typical search - export and import
description: Details Find Selection Typical Seach feature set.
author: {AnthonyYates}
keywords: Typical search, Selection, Find
so.topic: article
# so.envir:
so.client: web
---

# Export and import of typical search

<!-- under construction -->

## Export of typical searches from SOD site to json file

The typical search data that will be stored in customer's databases will be created on a SOD site. Each selection will be marked as a typical search by setting a search category to Typical Search.

The exported typical search criteria data will be exported as ArchiveRestrictionGroups. These ArchiveRestrictionGroups will be mapped to the `Ntypicalsearch_id`. The various id’s stored in the json file are only meant to show the relations between the tables. The id’s that will be generated in the customer’s database will not copy the id’s in the exported json file.

## How are the typical searches numbered

For each new or changed typical searches, the version number is increased to the highest pre-existing version number (out of all typical searches) + 1. Note that changes to the criteria will also update the version number of the related typical search.

**Example of how version numbers are increased:**

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

## Requesting a typical search update

When a customer is checking if for an update of the typical searches, the customer sends the highest version number stored in their customer database. If any of the typical searches in the json file has a higher version number that the customers highest version number; then the customers typical searches will need an update. The typical search data in the json file will then be used to update the customers database.

## When the only change is a removed typical search

The MasterVersion number in the TypicalSearches carrier is incremented once per deleted typical search. It is stored in both the Master installation at Superoffice, and in each customer database. It is therefore possible to see that there has in fact been a change since the last import; and once all the typical searches in the carrier have been imported, whatever is left over will be deleted. This deletion can be inhibited by setting the DeleteLeftovers property to false, but Superoffice does not expect to use this feature.

## TypicalSearchExporter

This is a .NET Framework, command-line utility. It uses the [OIDC authentication flow][1] and allows anyone who has access to the site, to run it.

The utility uses ordinary NetServer API calls to list and retrieve all selections that are dynamic and marked with the Typical Search category, for the standard entities. Such selections should only refer to standard fields as criteria, never user-defined or extra-fields as those will not be present in the customer installation.

The selection name, entity, and long comment are exported. Owner, Category, Completed and Visible for are ignored (since they have no relevant match in a customer database). The selection name will become the TypicalSearch name. If it matches a resource in the Primer Data(8.5) product, module TypicalSearch, then the corresponding translations will be retrieved and exported as a multi-language string. Otherwise, the selection name is used as-is.

The data are exported using the service layer carriers **TypicalSearchConfiguration** -> **TypicalSearch** -> **ArchiveRestrictionGroup** -> **ArchiveRestriction**. The final file format is JSON.

The TypicalSearch.Version number is assigned based on a global counter. The first selection is assigned version 1, the second gets 2, etc. In addition, the TypicalSearchExporter uses the ForeignKey feature to store the registered/last updated date together with the assigned version number, for each such selection, in the ACME AS installation. To detect changes in the criteria (which do not update the updated field of the selection itself), a SHA256 hash of all criteria/operators/values is also stored in the foreignkey. The foreignkey value itself is in JSON format.  

When an export is performed, if a selection has a newer updated date than the last (or a hash mismatch), the global version number counter is increased by one and that version number assigned to the selection (and saved in ForeignKey).

## Updating the customers database

When there has been an update to typical searches, it’s not necessarily the case that all typical searches are new or changed. There may have for example only been changes to one typical search. This one typical search will then have a higher version number than the customers highest typical search version number. However, all the other typical searches will not have changed. To find out what has changed, what is new and what is removed; we compare the customers typical searches with the latest typical searches.

Algorithm for determining what changes to make to the customers database

If the customers highest version number is lower than highest typical search version number from the json file; then we need to make some changes.

We make two list of the fields: version numbers, title and entity. One from the imported data and the other from the customers database.

The instances that exists in both lists: will remain unchanged.

The instances that share the same entity and title, but with great version number (imported > database): will lead to an update for the related typical search.

The instances that only exist in the database lists (no matching entity + title): will be deleted.

The instances that only in exist in the imported lists (no matching entity + title): will be added as new typical searches.

### Pseudocode

[!code-csharp[cs](includes/updatetolatesttypicalsearches.cs)]

<!-- Referenced links -->

[1]: ../../../tutorials/native-app-quickstart.md

<!-- Referenced images -->

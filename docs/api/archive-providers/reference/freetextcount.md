---
uid: FreetextCount
title: FreetextCount
description: Archive provider for counts of freetext matches
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "FreetextCount"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "FreetextCount"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FreetextCountProvider">SuperOffice.CRM.ArchiveLists.FreetextCountProvider</see> inside NetServer's SODatabase assembly.

Archive provider for counts of freetext matches

The purpose if this provider is to provide simple counts of matches, grouped by owning entity. In the GUI,
this corresponds to the tabs in the freetext search result dialog, and the numbers on those tabs. To
get actual matches for a particular entity, use the corresponding FreetextSearchProvider, for instance,
the <see cref="T:SuperOffice.CRM.ArchiveLists.FreetextContactResultProvider" />.
<para />
The 'OwnerEntityName' column accepts a restriction in the form of an array of strings or table names. If
provided, this restriction will limit the entities searched. The <see cref="T:SuperOffice.CRM.Lists.FreetextSearchEntityProvider" />
is an MDO provider for supported entities.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"freetextcount"|Number of matches|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ownerEntityName|listAny|Owner: Owner (type) of freetext match| x |
|count| *None* |Count: Number of matches for a certain owner entity| x |
|entityLocalizedName| *None* |Owner: Owner of freetext match| x |
|searchwords|string|Search word: One or more words to be used in free text search|  |

## Sample

```http!
GET /api/v1/archive/FreetextCount?$select=count,entityLocalizedName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: FreetextCount
title: FreetextCount
description: Archive provider for counts of freetext matches
keywords: FreetextCount archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "FreetextCount"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FreetextCountProvider">SuperOffice.CRM.ArchiveLists.FreetextCountProvider</see> inside NetServer's SODatabase assembly.

Archive provider for counts of freetext matches

The purpose if this provider is to provide simple counts of matches, grouped by owning entity. In the GUI,
this corresponds to the tabs in the freetext search result dialog, and the numbers on those tabs. To
get actual matches for a particular entity, use the corresponding FreetextSearchProvider, for instance,
the <see cref="T:SuperOffice.CRM.ArchiveLists.FreetextContactResultProvider" />.


The 'OwnerEntityName' column accepts a restriction in the form of an array of strings or table names. If
provided, this restriction will limit the entities searched. The <see cref="T:SuperOffice.CRM.Lists.FreetextSearchEntityProvider" />
is an MDO provider for supported entities.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"freetextcount"|[[SR_FT_COUNTENTITY]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ownerEntityName|listAny|SR\_FT\_OWNERENTITY: SR\_FT\_OWNERENTITY\_TOOLTIP| x |
|count| *None* |SR\_FT\_OWNERCOUNT: SR\_FT\_OWNERCOUNT\_TOOLTIP| x |
|entityLocalizedName| *None* |SR\_FT\_OWNERLOCALIZEDENTITY: SR\_FT\_OWNERLOCALIZEDENTITY\_TOOLTIP| x |
|searchwords|string|SR\_FT\_SEARCHWORD: SR\_FT\_SEARCHWORD\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/FreetextCount?$select=ownerEntityName,count,entityLocalizedName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


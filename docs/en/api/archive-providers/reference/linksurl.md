---
uid: LinksURL
title: LinksURL
description: 
keywords: LinksURL archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "LinksURL"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksURLProvider">SuperOffice.CRM.ArchiveLists.LinksURLProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"url"|url|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|sourceAppointmentRestrictionId|int|SR\_RESTRICTION\_LINKAPPOINTMENTSOURCE: SR\_RESTRICTION\_LINKAPPOINTMENTSOURCE\_TOOLTIP|  |
|sourceSaleRestrictionId|int|SR\_RESTRICTION\_LINKSALESOURCE: SR\_RESTRICTION\_LINKSALESOURCE\_TOOLTIP|  |
|sourceDocumentRestrictionId|int|SR\_RESTRICTION\_LINKDOCUMENTSOURCE: SR\_RESTRICTION\_LINKDOCUMENTSOURCE\_TOOLTIP|  |
|sourceProjectRestrictionId|int|SR\_RESTRICTION\_LINKPROJECTSOURCE: SR\_RESTRICTION\_LINKPROJECTSOURCE\_TOOLTIP|  |
|sourcePersonRestrictionId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sourceContactRestrictionId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|sourceSelectionRestrictionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|linkId|int|SR\_RESTRICTION\_LINK: SR\_RESTRICTION\_LINK\_TOOLTIP|  |
|linkDescription|string|SR\_RESTRICTION\_LINKDESCRIPTION: SR\_RESTRICTION\_LINKDESCRIPTION\_TOOLTIP|  |
|URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|destinationURLRestrictionId|int|ADD LINK URL DESTINATION RESOURCE: ADD LINK URL DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/LinksURL?$select=sourceProjectRestrictionId,sourceSelectionRestrictionId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


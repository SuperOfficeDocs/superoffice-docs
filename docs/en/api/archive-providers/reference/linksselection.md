---
uid: LinksSelection
title: LinksSelection
description: 
keywords: LinksSelection archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "LinksSelection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksSelectionProvider">SuperOffice.CRM.ArchiveLists.LinksSelectionProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"Selection"|[[SR_SINGULAR_SELECTION]]|

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
|selectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP| x |
|name|stringorPK|SR\_SELECTION\_NAME: SR\_SELECTION\_NAME\_TOOLTIP| x |
|type|listAny|SR\_SEARCH\_CATEGORY: SR\_SEARCH\_CATEGORY\_TOOLTIP| x |
|kind|listAny|SR\_LABEL\_SELECTIONKIND: SR\_SEARCH\_KIND\_TOOLTIP| x |
|targetTableNumber|listAny|SR\_ARCHIVE\_SELECTION\_TYPE: SR\_ARCHIVE\_SELECTION\_TYPE\_TOOLTIP| x |
|associateId|associate|SR\_LIST\_ASSOCIATE: SR\_SEARCH\_OWNER\_TOOLTIP| x |
|combinationType|listAny|SR\_ARCHIVE\_SELECTION\_COMBINATION\_TYPE: SR\_ARCHIVE\_SELECTION\_COMBINATION\_TYPE\_TOOLTIP| x |
|done|bool|SR\_ARCHIVE\_SELECTION\_COMPLETED: SR\_ARCHIVE\_SELECTION\_COMPLETED\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|lastLoaded|date|SR\_SEL\_LASTLOADED: SR\_SEL\_LASTLOADED\_TOOLTIP| x |
|lastLoadedBy|associate|SR\_SEL\_LASTLOADEDBY: SR\_SEL\_LASTLOADEDBY\_TOOLTIP| x |
|lastLoadedByFullName|associate|SR\_SEL\_LASTLOADEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_SEL\_LASTLOADEDBY\_TOOLTIP| x |
|lastMembershipChange|date|SR\_SEL\_LASTMEMBERCHANGE: SR\_SEL\_LASTMEMBERCHANGE\_TOOLTIP| x |
|lastMembershipChangeBy|associate|SR\_SEL\_LASTMEMBERCHANGEBY: SR\_SEL\_LASTMEMBERCHANGEBY\_TOOLTIP| x |
|lastMembershipChangeByFullName|associate|SR\_SEL\_LASTMEMBERCHANGEBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_SEL\_LASTMEMBERCHANGEBY\_TOOLTIP| x |
|memberCount|int|SR\_SEL\_MEMBERCOUNT: SR\_SEL\_MEMBERCOUNT\_TOOLTIP| x |
|icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|completed|bool|SR\_ARCHIVE\_SELECTION\_COMPLETED: SR\_ARCHIVE\_SELECTION\_COMPLETED\_TOOLTIP| x |
|visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|destinationSelectionRestrictionId|int|ADD LINK Selection DESTINATION RESOURCE: ADD LINK Selection DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/LinksSelection?$select=name,updatedBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


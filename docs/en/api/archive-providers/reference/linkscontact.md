---
uid: LinksContact
title: LinksContact
description: 
keywords: LinksContact archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "LinksContact"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksContactProvider">SuperOffice.CRM.ArchiveLists.LinksContactProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"Contact"|[[SR_CONTACT]]|

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
|contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|name|stringorPK|SR\_COMPANY\_NAME| x |
|department|string|SR\_ARCHIVE\_DEPARTEMENT| x |
|nameDepartment|string|SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|associateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|category|listAny|SR\_ARCHIVE\_CATEGORY| x |
|categoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|companyCategoryRank|int|Category rank| x |
|business|listAny|SR\_ARCHIVE\_BUSINESS| x |
|country|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|countryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|number|string|SR\_ARCHIVE\_NUMBER| x |
|code|string|SR\_ARCHIVE\_CODE| x |
|orgnr|string|VAT No.| x |
|stop|bool|SR\_CC\_STOPX| x |
|contactNoMail|bool|SR\_NO\_MAIL\_COMPANY| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|contactSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|contactDeleted|bool|SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|deletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|forceCompany|bool|Dummy: Dummy|  |
|icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|completed|bool|SR\_ARCHIVE\_SELECTION\_COMPLETED: SR\_ARCHIVE\_SELECTION\_COMPLETED\_TOOLTIP| x |
|destinationContactRestrictionId|int|ADD LINK Contact DESTINATION RESOURCE: ADD LINK Contact DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/LinksContact?$select=hasInfoText,countryId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


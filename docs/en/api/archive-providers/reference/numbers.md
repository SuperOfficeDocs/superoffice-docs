---
uid: Numbers
title: Numbers
description: Archive provider for the list of numbers, for the number allocation system. Not be confused with table sequence numbers.
keywords: Numbers archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Numbers"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.NumbersProviderBase">SuperOffice.CRM.ArchiveLists.NumbersProviderBase</see> inside NetServer's SODatabase assembly.

Archive provider for the list of numbers, for the number allocation system. Not be confused with table sequence numbers.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"number"|number|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|RefCounts\_id|int|SR\_ASN\_LIST\_ID: SR\_ASN\_LIST\_ID\_TOOLTIP| x |
|fieldId|int|SR\_ASN\_LIST\_FIELD\_ID: SR\_ASN\_LIST\_FIELD\_ID\_TOOLTIP| x |
|icon|int|SR\_ASN\_LIST\_ICON: SR\_ASN\_LIST\_ICON\_TOOLTIP| x |
|recordId|int|SR\_ASN\_LIST\_RECORDID: SR\_ASN\_LIST\_RECORDID\_TOOLTIP| x |
|currentvalue|int|SR\_ASN\_LIST\_CURRENTVALUE: SR\_ASN\_LIST\_CURRENTVALUE\_TOOLTIP| x |
|travelprefix|int|SR\_ASN\_LIST\_TRAVELPREFIX: SR\_ASN\_LIST\_TRAVELPREFIX\_TOOLTIP| x |
|satprefix|int|SR\_ASN\_LIST\_SATPREFIX\_TOOLTIP| x |
|flags|int|SR\_ASN\_LIST\_FLAGS: SR\_ASN\_LIST\_FLAGS\_TOOLTIP| x |
|active|bool|SR\_ASN\_LIST\_ALLOC: SR\_ASN\_LIST\_ALLOC\_TOOLTIP| x |
|unique|bool|SR\_ASN\_LIST\_UNIQUE: SR\_ASN\_LIST\_UNIQUE\_TOOLTIP| x |
|readonly|bool|SR\_ASN\_LIST\_READONLY: SR\_ASN\_LIST\_READONLY\_TOOLTIP| x |
|blankallowed|bool|SR\_ASN\_LIST\_BLANKS: SR\_ASN\_LIST\_BLANKS\_TOOLTIP| x |
|name|string|SR\_ASN\_LIST\_COUNTER: SR\_ASN\_LIST\_COUNTER\_TOOLTIP| x |
|updated|date|SR\_ASN\_LIST\_LASTUSED: SR\_ASN\_LIST\_LASTUSED\_TOOLTIP| x |
|nextnum|int|SR\_ASN\_LIST\_NEXT: SR\_ASN\_LIST\_NEXT\_TOOLTIP| x |
|field|string|Field: Field Tooltip|  |
|updated\_associate/firstName|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|updated\_associate/lastName|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|updated\_associate/middleName|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|updated\_associate/fullName|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|updated\_associate/contactId|int|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|updated\_associate/personId|int|SR\_ASN\_LIST\_LASTUSEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|updated\_associate/mrMrs|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|updated\_associate/title|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|updated\_associate/associateDbId|associate|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|updated\_associate/contactName|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|updated\_associate/contactDepartment|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|updated\_associate/usergroup|userGroup|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|updated\_associate/usergroupId|int|SR\_ASN\_LIST\_LASTUSEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|updated\_associate/contactFullName|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|updated\_associate/contactCategory|listAny|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|updated\_associate/role|listAny|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|updated\_associate/assocName|associate|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|updated\_associate/assocTooltip|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|updated\_associate/assocType|listAny|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|updated\_associate/ejUserId|int|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|updated\_associate/simultaneousEjUser|bool|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|updated\_associate/ejDisplayName|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|updated\_associate/ejStatus|int|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|updated\_associate/credentialType| *None* |SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|updated\_associate/credentialDisplayValue| *None* |SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|updated\_associate/isActive|bool|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|updated\_associate/isActiveText|bool|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|updated\_associate/portraitThumbnail| *None* |SR\_ASN\_LIST\_LASTUSEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|updated\_associate/otherGroups|userGroup|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|updated\_associate/userName|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|updated\_associate/personEmail|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ARCHIVE\_EMAIL| x |
|updated\_associate/locationAddress|string|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|updated\_associate/isLocation|bool|SR\_ASN\_LIST\_LASTUSEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |

## Sample

```http!
GET /api/v1/archive/Numbers?$select=satprefix,updated_associate/ejDisplayName,field
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: SuperListColumnSize
title: SuperListColumnSize
description: 
keywords: SuperListColumnSize archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "SuperListColumnSize"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SuperListColumnSizeProvider">SuperOffice.CRM.ArchiveLists.SuperListColumnSizeProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"superListColumnSize"|superListColumnSize|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|superListColumnSize\_id|int|DB Id: Db Id of SuperListColumnSize row| x |
|assocId|associate|ID| x |
|listOwner|string|List owner: List owner tooltip| x |
|extraInfo|string|Extra info: Extra list owner context info...| x |
|columnKey|string|Column key: Unique key for column as supplied by provider metadata| x |
|columnSize|string|Size: Encoded column size| x |
|rank|int|Rank: Left to right order of active columns| x |
|orderByRank|int|Order by: If this column is used to order by, rank of sort order| x |
|orderByDirection|int|Asc/Desc: Asc/Desc order by direction if order by rank| x |
|registered|date|Registered date: Date &amp; time this record was created| x |
|updated|date|Updated date: Date &amp; time this record was last updated| x |
|ownerTable|int|Owner Table Id: Table Id of owner for a dynamic entity-bound configuration| x |
|ownerRecord|int|Owner Record Id: Record Id of owner for a dynamic entity-bound configuration| x |
|groupId|int|Group Id: Group Id tooltip| x |
|configurationName|string|Configuration name: User configuration name| x |
|associate/firstName|string|SR\_LIST\_ASSOCIATE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|associate/lastName|string|SR\_LIST\_ASSOCIATE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|associate/middleName|string|SR\_LIST\_ASSOCIATE - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|associate/fullName|string|SR\_LIST\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|associate/contactId|int|SR\_LIST\_ASSOCIATE - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|associate/personId|int|SR\_LIST\_ASSOCIATE - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|associate/mrMrs|string|SR\_LIST\_ASSOCIATE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|associate/title|string|SR\_LIST\_ASSOCIATE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|associate/associateDbId|associate|SR\_LIST\_ASSOCIATE - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|associate/contactName|string|SR\_LIST\_ASSOCIATE - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|associate/contactDepartment|string|SR\_LIST\_ASSOCIATE - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|associate/usergroup|userGroup|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|associate/usergroupId|int|SR\_LIST\_ASSOCIATE - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|associate/contactFullName|string|SR\_LIST\_ASSOCIATE - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|associate/contactCategory|listAny|SR\_LIST\_ASSOCIATE - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|associate/role|listAny|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|associate/assocName|associate|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|associate/assocTooltip|string|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|associate/assocType|listAny|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|associate/ejUserId|int|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|associate/simultaneousEjUser|bool|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|associate/ejDisplayName|string|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|associate/ejStatus|int|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|associate/credentialType| *None* |SR\_LIST\_ASSOCIATE - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|associate/credentialDisplayValue| *None* |SR\_LIST\_ASSOCIATE - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|associate/isActive|bool|SR\_LIST\_ASSOCIATE - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|associate/isActiveText|bool|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|associate/portraitThumbnail| *None* |SR\_LIST\_ASSOCIATE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|associate/otherGroups|userGroup|SR\_LIST\_ASSOCIATE - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|associate/userName|string|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|associate/personEmail|string|SR\_LIST\_ASSOCIATE - SR\_ARCHIVE\_EMAIL| x |
|associate/locationAddress|string|SR\_LIST\_ASSOCIATE - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|associate/isLocation|bool|SR\_LIST\_ASSOCIATE - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |

## Sample

```http!
GET /api/v1/archive/SuperListColumnSize?$select=configurationName,associate/associateDbId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


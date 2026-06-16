---
uid: SelectionDynamicSelectionV2
title: SelectionDynamicSelectionV2
description: Selection selection archive with OR-able selection groups. Each group is represented with the <see cref="T -SuperOffice.CRM.ArchiveLists.Archive.SelectionSelectionDynamicProviderSingleCriteriaGroup" />.
keywords: SelectionDynamicSelectionV2 archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "SelectionDynamicSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.SelectionSelectionDynamicProviderV2">SuperOffice.CRM.ArchiveLists.Archive.SelectionSelectionDynamicProviderV2</see> inside NetServer's SODatabase assembly.

Selection selection archive with OR-able selection groups. Each group is represented with the <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.SelectionSelectionDynamicProviderSingleCriteriaGroup" />.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"selection"|[[SR_SINGULAR_SELECTION]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|selectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|rowKind| *None* |SR\_SELECTION\_ROWKIND: SR\_SELECTION\_ROWKIND\_TOOLTIP|  |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
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
|visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|selectionAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|selectionAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|selectionAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|selectionAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|selectionAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|selectionAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|selectionAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|selectionAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|selectionAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|selectionAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|selectionAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|selectionAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|selectionAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|selectionAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|selectionAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|selectionAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|selectionAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|selectionAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|selectionAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|selectionAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|selectionAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|selectionAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|selectionAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|selectionAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|selectionAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|selectionAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|selectionAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|selectionAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|selectionAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|selectionAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|selectionAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|selectionAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|selectionAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |

## Sample

```http!
GET /api/v1/archive/SelectionDynamicSelectionV2?$select=lastLoadedByFullName,selectionAssociate/contactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


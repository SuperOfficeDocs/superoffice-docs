---
uid: SystemEvents
title: SystemEvents
description: Provider base for system events.
keywords: SystemEvents archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "SystemEvents"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SystemEventsProviderBase">SuperOffice.CRM.ArchiveLists.SystemEventsProviderBase</see> inside NetServer's SODatabase assembly.

Provider base for system events.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"systemevent"|systemevent|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|SystemEvent\_id|int|SR\_ADMIN\_SYSTEM\_ID: SR\_ADMIN\_SYSTEM\_ID\_TOOLTIP| x |
|scope|int|SR\_ADMIN\_SYSTEM\_SCOPE: SR\_ADMIN\_SYSTEM\_SCOPE\_TOOLTIP| x |
|type|string|SR\_ADMIN\_SYSTEM\_TYPE: SR\_ADMIN\_SYSTEM\_TYPE\_TOOLTIP| x |
|owner|int|SR\_ADMIN\_SYSTEM\_OWNER: SR\_ADMIN\_SYSTEM\_OWNER\_TOOLTIP| x |
|eventkey|string|SR\_ADMIN\_SYSTEM\_EVENTKEY: SR\_ADMIN\_SYSTEM\_EVENTKEY\_TOOLTIP| x |
|eventname|string|SR\_ADMIN\_SYSTEM\_EVENT: SR\_ADMIN\_SYSTEM\_EVENT\_TOOLTIP| x |
|status|string|SR\_ADMIN\_SYSTEM\_STATUS: SR\_ADMIN\_SYSTEM\_STATUS\_TOOLTIP| x |
|eventmess|string|SR\_ADMIN\_SYSTEM\_MESSAGE: SR\_ADMIN\_SYSTEM\_MESSAGE\_TOOLTIP| x |
|extrainfo|int|SR\_ADMIN\_SYSTEM\_EXTRAINFO: SR\_ADMIN\_SYSTEM\_EXTRAINFO\_TOOLTIP| x |
|eta|datetime|SR\_ADMIN\_SYSTEM\_FINISHED: SR\_ADMIN\_SYSTEM\_FINISHED\_TOOLTIP| x |
|registered|date|SR\_ADMIN\_SYSTEM\_ACTIVATED: SR\_ADMIN\_SYSTEM\_ACTIVATED\_TOOLTIP| x |
|updatedCount|int|SR\_ADMIN\_SYSTEM\_UPDATEDCOUNT: SR\_ADMIN\_SYSTEM\_UPDATEDCOUNT\_TOOLTIP| x |
|registered\_associate\_id/firstName|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|registered\_associate\_id/lastName|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|registered\_associate\_id/middleName|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|registered\_associate\_id/fullName|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|registered\_associate\_id/contactId|int|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|registered\_associate\_id/personId|int|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|registered\_associate\_id/mrMrs|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|registered\_associate\_id/title|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|registered\_associate\_id/associateDbId|associate|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|registered\_associate\_id/contactName|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|registered\_associate\_id/contactDepartment|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|registered\_associate\_id/usergroup|userGroup|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|registered\_associate\_id/usergroupId|int|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|registered\_associate\_id/contactFullName|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|registered\_associate\_id/contactCategory|listAny|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|registered\_associate\_id/role|listAny|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|registered\_associate\_id/assocName|associate|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|registered\_associate\_id/assocTooltip|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|registered\_associate\_id/assocType|listAny|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|registered\_associate\_id/ejUserId|int|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|registered\_associate\_id/simultaneousEjUser|bool|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|registered\_associate\_id/ejDisplayName|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|registered\_associate\_id/ejStatus|int|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|registered\_associate\_id/credentialType| *None* |SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|registered\_associate\_id/credentialDisplayValue| *None* |SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|registered\_associate\_id/isActive|bool|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|registered\_associate\_id/isActiveText|bool|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|registered\_associate\_id/portraitThumbnail| *None* |SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|registered\_associate\_id/otherGroups|userGroup|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|registered\_associate\_id/userName|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|registered\_associate\_id/personEmail|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ARCHIVE\_EMAIL| x |
|registered\_associate\_id/locationAddress|string|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|registered\_associate\_id/isLocation|bool|SR\_ADMIN\_SYSTEM\_ACTIVATED\_BY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |

## Sample

```http!
GET /api/v1/archive/SystemEvents?$select=registered_associate_id/lastName,registered_associate_id/contactName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: InternalUsers
title: InternalUsers
description: Concrete provider for Internal Users - our own employees. See <see cref="T -SuperOffice.CRM.ArchiveLists.UsersProviderBase" /> for
keywords: InternalUsers archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "InternalUsers"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.InternalUsersProvider">SuperOffice.CRM.ArchiveLists.InternalUsersProvider</see> inside NetServer's SODatabase assembly.

Concrete provider for Internal Users - our own employees. See <see cref="T:SuperOffice.CRM.ArchiveLists.UsersProviderBase" /> for
the actual functionality of the provider.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|[[SR_VFC_ALL]]|
|"superoffice_visible-for"|Confidential activities|
|"superoffice_superlicense-no-selection"|(No Selection)|
|"superoffice_ten-sales"|Sales Premium|
|"superoffice_ten-service"|Service Premium|
|"superoffice_ten-marketing"|Marketing Premium|
|"superoffice_ten-salesservicemarketing"|SalesPremiumServicePremiumMarketingPremium|
|"potential"|[[SR_USERS_POTENTIAL_USERS]]|
|"retired"|[[SR_ADMIN_RETIRED]]|
|"loggedOnWin"|[[SR_ADMIN_LOGGEDON]]|
|"expired"|[[SR_ADMIN_EXPIRED]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|userplan| *None* |SR\_ASSOC\_USERPLAN: SR\_ASSOC\_USERPLAN\_TOOLTIP|  |
|canLogin|bool|SR\_CAN\_USER\_LOG\_IN: SR\_CAN\_USER\_LOG\_IN|  |
|superoffice\_visible-for| *None* |Confidential activities: Enables the visible-for dropdown in the CRM client|  |
|superoffice\_superlicense-no-selection| *None* |No Selection: User Plan: License Not in Use.|  |
|superoffice\_ten-sales| *None* |Sales Premium: User Plan: Can edit Companies, Diary, Sales, Selections, Reports|  |
|superoffice\_ten-service| *None* |Service Premium: User Plan: Can edit Requests|  |
|superoffice\_ten-marketing| *None* |Marketing Premium: User Plan: Can send Mailings, Combined Selections|  |
|superoffice\_ten-salesservicemarketing| *None* |SalesPremiumServicePremiumMarketingPremium: User Plan: Can edit sales, requests, mailings.|  |
|firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |

## Sample

```http!
GET /api/v1/archive/InternalUsers?$select=contactId,usergroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


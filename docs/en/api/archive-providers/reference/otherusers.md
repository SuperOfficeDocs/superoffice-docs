---
uid: OtherUsers
title: OtherUsers
description: Concrete provider for 'Other' Users - System and Anonymous user accounts. See <see cref="T -SuperOffice.CRM.ArchiveLists.UsersProviderBase" /> for
keywords: OtherUsers archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "OtherUsers"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.OtherUsersProvider">SuperOffice.CRM.ArchiveLists.OtherUsersProvider</see> inside NetServer's SODatabase assembly.

Concrete provider for 'Other' Users - System and Anonymous user accounts. See <see cref="T:SuperOffice.CRM.ArchiveLists.UsersProviderBase" /> for
the actual functionality of the provider.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|[[SR_VFC_ALL]]|
|"superoffice_system-user-cal"|System user|
|"superoffice_visible-for"|Confidential activities|
|"superoffice_superlicense-no-selection"|(No Selection)|
|"superoffice_ten-sales"|Sales Premium|
|"superoffice_ten-service"|Service Premium|
|"superoffice_ten-marketing"|Marketing Premium|
|"superoffice_ten-salesservicemarketing"|SalesPremiumServicePremiumMarketingPremium|
|"expired"|[[SR_ADMIN_EXPIRED]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|userplan| *None* |SR\_ASSOC\_USERPLAN: SR\_ASSOC\_USERPLAN\_TOOLTIP|  |
|canLogin|bool|SR\_CAN\_USER\_LOG\_IN: SR\_CAN\_USER\_LOG\_IN|  |
|superoffice\_system-user-cal| *None* |System user: Allows log in to NetServer|  |
|superoffice\_visible-for| *None* |Confidential activities: Enables the visible-for dropdown in the CRM client|  |
|superoffice\_superlicense-no-selection| *None* |No Selection: User Plan: License Not in Use.|  |
|superoffice\_ten-sales| *None* |Sales Premium: User Plan: Can edit Companies, Diary, Sales, Selections, Reports|  |
|superoffice\_ten-service| *None* |Service Premium: User Plan: Can edit Requests|  |
|superoffice\_ten-marketing| *None* |Marketing Premium: User Plan: Can send Mailings, Combined Selections|  |
|superoffice\_ten-salesservicemarketing| *None* |SalesPremiumServicePremiumMarketingPremium: User Plan: Can edit sales, requests, mailings.|  |
|associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
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
GET /api/v1/archive/OtherUsers?$select=superoffice_ten-marketing,role
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


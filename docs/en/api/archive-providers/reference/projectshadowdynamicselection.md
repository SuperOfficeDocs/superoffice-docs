---
uid: ProjectShadowDynamicSelection
title: ProjectShadowDynamicSelection
description: Shadow contact provider for the dynamic Project provider.
keywords: ProjectShadowDynamicSelection archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ProjectShadowDynamicSelection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.ProjectShadowSelectionDynamicProvider">SuperOffice.CRM.ArchiveLists.Archive.ProjectShadowSelectionDynamicProvider</see> inside NetServer's SODatabase assembly.

Shadow contact provider for the dynamic Project provider.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"project"|[[SR_COMMON_PROJECT]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|selectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP| x |
|rowKind| *None* |SR\_SELECTION\_ROWKIND: SR\_SELECTION\_ROWKIND\_TOOLTIP|  |
|completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP| x |
|projectId|int|SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP| x |
|name|stringorPK|SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP| x |
|number|string|SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP| x |
|type|listAny|SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP| x |
|status|listAny|SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP| x |
|statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP| x |
|associateId|associate|SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|hasInfoText|bool|SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP| x |
|icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|description|string|SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|nextMilestone|date|SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP| x |
|endDate|date|SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP| x |
|imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|eventId|int|SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID| x |
|startDate|date|SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP| x |
|projectPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|projectPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|projectPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|projectEvent/isExternalEvent|bool|SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP| x |
|projectEvent/eventDate|date|SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP| x |
|projectEvent/hasSignOn|bool|SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP| x |
|projectEvent/hasSignOff|bool|SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP| x |
|projectUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|projectUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|projectAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|projectAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|projectAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|projectAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|projectAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|projectAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|projectAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|projectAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|projectAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|projectAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|projectAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|projectAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|projectAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|projectAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|projectAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|projectAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|projectAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|projectAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|projectAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|projectAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|projectAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|projectAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|projectAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|projectAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|projectUdef/SuperOffice:1|string|projectshorttext| x |
|projectUdef/SuperOffice:2|string|projectlongtext| x |
|projectUdef/SuperOffice:3|int|projectnumber| x |
|projectUdef/SuperOffice:4|date|projectdate| x |
|projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|NumberOfActivities|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|NumberOfActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|NumberOfNotCompletedActivities|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|NumberOfNotCompletedActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|LastActivity|date|SR\_ROU\_LAST\_ACTIVITY|  |
|LastCompletedActivity|date|SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|LastDoByActivity|date|SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|NumberOfSales|int|SR\_ROU\_NUMBER\_OF\_SALES|  |
|NumberOfSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|NumberOfNotCompletedSales|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|NumberOfNotCompletedSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|LastSale|date|SR\_ROU\_LAST\_SALE|  |
|LastCompletedSale|date|SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|LastDoBySale|date|SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|saintSaleStatus|listAny|SR\_WITH\_STATUS|  |
|saintAmountClass|listAny|SR\_AMOUNT\_CLASS|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saintActivityType|listAny|SR\_ARCHIVE\_SAINT\_TYPE|  |
|saintDirection|listAny|SR\_ARCHIVE\_DIRECTION|  |
|saintIntention|listAny|SR\_ACTIVITY\_INTENTION|  |
|saintTicketStatus|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|saintTicketCategory|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|sale/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|sale/icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|sale/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|sale/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|sale/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|sale/recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|sale/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|sale/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|sale/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|sale/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|sale/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|sale/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|sale/userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|sale/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|sale/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sale/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sale/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|sale/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sale/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sale/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|sale/currencyId|int|SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP| x |
|sale/currency|listAny|SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP| x |
|sale/credited|listAny|SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP| x |
|sale/lossReason|listAny|SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP| x |
|sale/source|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP| x |
|sale/competitor|listAny|SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP| x |
|sale/heading|stringorPK|SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP| x |
|sale/amount|decimal|SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|sale/amountWeighted|decimal|SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|sale/earning|decimal|SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP| x |
|sale/earningPercent|decimal|SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP| x |
|sale/probPercent|int|SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP| x |
|sale/originalStage|listAny|SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED| x |
|sale/stage|listAny|SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/saleStatus|listAny|SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP| x |
|sale/stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP| x |
|sale/saleType|listAny|SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|sale/saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|sale/stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/nextDueDate|date|SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP| x |
|sale/reopenDate|date|SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP| x |
|sale/stalledComment|listAny|SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP| x |
|sale/saleTypeCategory|listAny|SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT| x |
|sale/soldReason|listAny|SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP| x |
|sale/saleNumber|string|SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER| x |
|sale/hasStakeholders|bool|SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP| x |
|sale/stakeholdersEnabled|bool|SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP| x |
|sale/hasQuote|bool|SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP| x |
|sale/hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|sale/description|string|SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|sale/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|sale/createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|sale/amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|sale/amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|sale/daysInStage|int|SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP| x |
|sale/visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|sale/sale/textId|int|Text ID| x |
|sale/sale/description|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|sale/salePublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|sale/salePublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|sale/salePublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|sale/salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|sale/associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|sale/associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|sale/associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|sale/associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|sale/associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|sale/associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sale/associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|sale/associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|sale/associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|sale/associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|sale/associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|sale/associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|sale/associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|sale/associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|sale/associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|sale/associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|sale/associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|sale/associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|sale/associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|sale/associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|sale/associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|sale/associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|sale/associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|sale/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|sale/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|sale/associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|sale/associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|sale/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|sale/associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|sale/associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|sale/associate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|sale/associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|sale/saleUdef/SuperOffice:1|string|saleshorttext| x |
|sale/saleUdef/SuperOffice:2|string|salelongtext| x |
|sale/saleUdef/SuperOffice:3|int|salenumber| x |
|sale/saleUdef/SuperOffice:4|date|saledate| x |
|sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|sale/saleUdef/SuperOffice:6|bool|salecheckbox| x |
|sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|sale/saleUdef/SuperOffice:8|decimal|saledecimal| x |
|appointment/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|appointment/icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|appointment/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|appointment/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|appointment/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|appointment/recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|appointment/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|appointment/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|appointment/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|appointment/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|appointment/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|appointment/userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|appointment/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|appointment/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|appointment/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|appointment/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|appointment/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|appointment/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|appointment/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|appointment/appointmentId|int|SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP| x |
|appointment/endDate|date|SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP| x |
|appointment/priority|listAny|SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP| x |
|appointment/alarm|bool|SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP| x |
|appointment/isFree|bool|SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP| x |
|appointment/recurring|bool|SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP| x |
|appointment/booking|bool|SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP| x |
|appointment/intention|listAny|SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP| x |
|appointment/location|string|SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP| x |
|appointment/recurrenceRuleId|int|SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP| x |
|appointment/rawType|int|SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP| x |
|appointment/rawStatus|int|SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP| x |
|appointment/cautionWarning|listAny|SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP| x |
|appointment/visibleInDiary|bool|SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP| x |
|appointment/endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|appointment/suggestedAppointmentId|int|SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP| x |
|appointment/completedDate|date|SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP| x |
|appointment/isMilestone|bool|SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP| x |
|appointment/invitedPersonId|int|SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP| x |
|appointment/recordTypeText|listAny|SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|appointment/joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP| x |
|appointment/duration|timeSpan|SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|appointment/createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|appointment/visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|appointment/appointmentPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|appointment/appointmentPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|appointment/appointmentPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|appointment/appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|appointment/appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|appointment/appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|appointment/appointmentUdef/SuperOffice:3|int|followupnumber| x |
|appointment/appointmentUdef/SuperOffice:4|date|followupdate| x |
|appointment/appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|appointment/appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|appointment/appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|appointment/appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|appointment/associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|appointment/associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|appointment/associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|appointment/associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|appointment/associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointment/associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointment/associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|appointment/associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|appointment/associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|appointment/associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|appointment/associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|appointment/associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|appointment/associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|appointment/associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|appointment/associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|appointment/associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|appointment/associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|appointment/associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointment/associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|appointment/associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointment/associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointment/associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|appointment/associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointment/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|appointment/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|appointment/associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|appointment/associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|appointment/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointment/associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointment/associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|appointment/associate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|appointment/associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|appointment/associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|appointment/appointment/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/appointment/description|positiveString|SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointment/appointment/title|positiveString|SR\_TICKETARCHIVE\_TITLE| x |
|appointment/appointment/titleHtml| *None* |!!Title Html| x |
|appointment/appointment/agenda|positiveString|SR\_APPOINTMENT\_AGENDA| x |
|appointment/appointment/agendaHtml| *None* |!!Agenda Html| x |
|appointment/appointment/isConverted| *None* |!!Is Converted|  |
|appointment/appointment/textId|int|Text ID| x |
|appointment/appointment/internalNotes|positiveString|SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/appointment/internalNotesHtml|positiveString|!!Internal Notes Html| x |
|document/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|document/icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|document/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|document/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|document/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|document/recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|document/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|document/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|document/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|document/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|document/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|document/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|document/userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|document/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|document/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|document/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|document/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|document/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|document/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|document/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|document/documentId|int|SR\_DOCUMENT\_ID: SR\_DOCUMENT\_ID\_TOOLTIP| x |
|document/keywords|string|SR\_KEYWORDS| x |
|document/ourref|string|SR\_AA\_OURREF| x |
|document/yourref|string|SR\_ARCHIVE\_YOURREF| x |
|document/attention|string|SR\_ARCHIVE\_SALUTATION| x |
|document/subject|string|SR\_COMMON\_SUBJECT| x |
|document/name|string|SR\_FILENAME| x |
|document/mailMergeDraft|bool|SR\_MAILMERGEDRAFT: SR\_DOCUMENT\_MMD\_TOOLTIP| x |
|document/snum|int|SR\_ARCHIVE\_DOCUMENT\_SNUM: SR\_ARCHIVE\_DOCUMENT\_SNUM\_TOOLTIP| x |
|document/isReport|bool|SR\_DOCUMENTISREPORT: SR\_DOCUMENTISREPORT\_TOOLTIP|  |
|document/suggestedDocumentId|int|SR\_ARCHIVE\_SUGGESTEDDOCID: SR\_ARCHIVE\_SUGGESTEDDOCID\_TOOLTIP| x |
|document/isMail|bool|SR\_SINGULAR\_MAIL|  |
|document/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|document/visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|document/documentPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|document/documentPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|document/documentPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|document/documentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|document/associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|document/associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|document/associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|document/associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|document/associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|document/associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|document/associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|document/associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|document/associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|document/associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|document/associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|document/associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|document/associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|document/associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|document/associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|document/associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|document/associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|document/associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|document/associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|document/associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|document/associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|document/associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|document/associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|document/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|document/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|document/associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|document/associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|document/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|document/associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|document/associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|document/associate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|document/associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|document/associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|document/documentUdef/SuperOffice:1|string|documentshorttext| x |
|document/documentUdef/SuperOffice:2|string|documentlongtext| x |
|document/documentUdef/SuperOffice:3|int|documentnumber| x |
|document/documentUdef/SuperOffice:4|date|documentdate| x |
|document/documentUdef/SuperOffice:5|unlimitedDate|documentunlimiteddate| x |
|document/documentUdef/SuperOffice:6|bool|documentcheckbox| x |
|document/documentUdef/SuperOffice:7|listAny|documentdropdownlistbox| x |
|document/documentUdef/SuperOffice:8|decimal|documentdecimal| x |
|document/document/textId|int|Text ID| x |
|document/document/description|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|projectMember/projectMemberId|int|SR\_PM\_ID: SR\_PM\_ID\_TOOLTIP| x |
|projectMember/projectId|int|SR\_PROJECT\_ID: SR\_PROJECT\_ID| x |
|projectMember/contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|projectMember/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|projectMember/eventParticipantStatus|listAny|SR\_FIELD\_PROJECT\_MEMBER\_EVENT\_STATUS: SR\_FIELD\_PROJECT\_MEMBER\_EVENT\_STATUS| x |
|projectMember/function|listAny|SR\_PROJECTMEMBER\_FUNCTION: SR\_PROJECTMEMBERARCHIVE\_FUNCTION\_TOOLTIP| x |
|projectMember/hasInfoText|bool|SR\_PROJECTMEMBER\_HASINFO: SR\_PROJECTMEMBERARCHIVE\_HASINFO\_TOOLTIP| x |
|projectMember/registered|datetime|SR\_PROJECTMEMBER\_REGISTERED: SR\_REGISTEREDDATE\_TOOLTIP| x |
|projectMember/updated|datetime|SR\_PROJECTMEMBER\_UPDATED: SR\_UPDATEDDATE\_TOOLTIP| x |
|projectMember/textId|int|Text ID| x |
|projectMember/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMember/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|projectMember/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|projectMember/middleName|string|SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|projectMember/fullName|string|SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|projectMember/hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|projectMember/personHasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|projectMember/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMember/position|listAny|SR\_ARCHIVE\_POSITION| x |
|projectMember/personNumber|string|SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|projectMember/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|projectMember/personCountry|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|projectMember/personCountryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|projectMember/personNoMail|bool|SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|projectMember/rank|int|SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|projectMember/birthdate| *None* |SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|projectMember/associateType| *None* |SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|projectMember/useAsMailingAddress|bool|SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|projectMember/personSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|projectMember/retired|bool|SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|projectMember/birthYear|int|SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|projectMember/birthMonth|int|SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|projectMember/birthDay|int|SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|projectMember/kanaFirstName|string|SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|projectMember/kanaLastName|string|SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|projectMember/personUpdatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|projectMember/personUpdatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|projectMember/personUpdatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|projectMember/personRegisteredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|projectMember/personRegisteredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|projectMember/personRegisteredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|projectMember/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectMember/personActiveErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|projectMember/ticketPriority|listAny|SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|projectMember/supportLanguage|listAny|SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|projectMember/supportAssociate|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|projectMember/supportAssociateFullName|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|projectMember/personAssociateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|projectMember/personAssociateFullName|associate|SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|projectMember/personCategory|listAny|SR\_ARCHIVE\_CATEGORY| x |
|projectMember/personCategoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|projectMember/personCategoryRank|int|!!Category rank| x |
|projectMember/personBusiness|listAny|SR\_ARCHIVE\_BUSINESS| x |
|projectMember/leadStatus|listAny|SR\_LABEL\_LEADSTATUS| x |
|projectMember/leadstatusRank|int|!!Lead status RANK| x |
|projectMember/personDeletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|projectMember/hasCompany|bool|SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|projectMember/isProjectMember|bool|SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|projectMember/isStakeholder|bool|SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|projectMember/updatedByWorkflow|listAny|SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|projectMember/whenUpdatedByWorkflow|datetime|SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|projectMember/createdByForm|listAny|SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|projectMember/phone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/personDirectPhone/formattedNumber|string|SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/personDirectPhone/description|string|SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|projectMember/personMobilePhone/formattedNumber|string|SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/personMobilePhone/description|string|SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|projectMember/personPrivate/formattedNumber|string|SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/personPrivate/description|string|SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|projectMember/personPager/formattedNumber|string|SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/personPager/description|string|SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|projectMember/personDirectFax/formattedNumber|string|SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/personDirectFax/description|string|SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|projectMember/searchPhone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/searchPhone/description|string|SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|projectMember/personInfo/textId|int|Text ID| x |
|projectMember/personInfo/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|projectMember/email/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|projectMember/email/emailAddress|string|SR\_ARCHIVE\_EMAIL| x |
|projectMember/email/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|projectMember/email/emailId|int|ID| x |
|projectMember/email/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|projectMember/email/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|projectMember/email/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|projectMember/email/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|projectMember/personUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|projectMember/personUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|projectMember/personAddress/addressId|int|SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|projectMember/personAddress/line1|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|projectMember/personAddress/line2|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|projectMember/personAddress/line3|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|projectMember/personAddress/county|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|projectMember/personAddress/city|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|projectMember/personAddress/zip|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|projectMember/personAddress/state|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|projectMember/personAddress/wgs84latitude|decimal|SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|projectMember/personAddress/wgs84longitude|decimal|SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|projectMember/personAddress/formattedAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|projectMember/personAddress/formattedMultiLineAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|projectMember/restrictionAddress/addressId|int|SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|projectMember/restrictionAddress/line1|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|projectMember/restrictionAddress/line2|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|projectMember/restrictionAddress/line3|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|projectMember/restrictionAddress/county|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|projectMember/restrictionAddress/city|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|projectMember/restrictionAddress/zip|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|projectMember/restrictionAddress/state|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|projectMember/restrictionAddress/wgs84latitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|projectMember/restrictionAddress/wgs84longitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|projectMember/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|projectMember/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMember/personInterestIds|listInterest|SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|projectMember/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|projectMember/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|projectMember/personUdef/SuperOffice:3|int|contactnumber| x |
|projectMember/personUdef/SuperOffice:4|date|contactdate| x |
|projectMember/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|projectMember/personUdef/SuperOffice:6|bool|contactcheckbox| x |
|projectMember/personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|projectMember/personUdef/SuperOffice:8|decimal|contactdecimal| x |
|projectMember/personUdef/SuperOffice:9|string|page1saleonly| x |
|projectMember/personUdef/SuperOffice:10|string|page1marketingonly| x |
|projectMember/personUdef/SuperOffice:11|string|page1adminonly| x |
|projectMember/personExtra/x\_person\_integer|int|Extra Integer: Custom person integer| x |
|projectMember/personExtra/x\_person\_hidden\_integer|int|Extra hidden integer: Custom integer field that is hidden| x |
|projectMember/personExtra/x\_person\_float|decimal|Extra float: Custom float field| x |
|projectMember/personExtra/x\_person\_longtext|string|Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|projectMember/personExtra/x\_person\_date|date|Extra date: Custom date field on person. Default value = 28.03.2019| x |
|projectMember/personExtra/x\_person\_datetime|datetime|Extra DateTime: Custom person date and time field. No default| x |
|projectMember/personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default| x |
|projectMember/personExtra/x\_person\_boolean|bool|Extra Boolean: Custom boolean field on person. Default checked| x |
|projectMember/personExtra/x\_person\_timespan|timeSpan|Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|projectMember/personExtra/x\_person\_shorttext|string|Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|projectMember/personExtra/x\_person\_shorttext\_list|listAny|Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|projectMember/personExtra/x\_person\_user\_relation|associate|Extra user relation: Custom person-user relation field| x |
|projectMember/personExtra/x\_person\_category\_relation|listAny|Extra category relation: Custom person-category relation| x |
|projectMember/personExtra/x\_person\_priority\_relation|listAny|Extra priority relation: Custom person-priority relation| x |
|projectMember/personExtra/x\_person\_request\_relation|stringorPK|Extra request relation: Request relation on contact| x |
|projectMember/personExtra/x\_person\_appointment\_relation|stringorPK|Extra appointment relation: Appointment relation on person| x |
|projectMember/personExtra/x\_person\_contact\_relation|stringorPK|Extra company relation: Company relation on contact| x |
|projectMember/personExtra/y\_rental/id|int|Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|projectMember/personExtra/y\_rental/x\_start|date|Rental - Start rental: Start rental| x |
|projectMember/personExtra/y\_rental/x\_end|date|Rental - End: End| x |
|projectMember/personExtra/y\_rental/x\_amount|int|Rental - Amount: Number to rent. Default = 1| x |
|projectMember/personExtra/y\_rental/x\_contact|stringorPK|Rental - Renter: Company that rents equipment| x |
|projectMember/personExtra/y\_rental/y\_equipment/x\_name|string|Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|projectMember/personExtra/y\_car/id|int|Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|projectMember/personAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|projectMember/personAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|projectMember/personAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|projectMember/personAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|projectMember/personAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|projectMember/personAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectMember/personAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMember/personAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMember/personAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|projectMember/personAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|projectMember/personAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|projectMember/personAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMember/personAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMember/personAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|projectMember/personAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|projectMember/personAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|projectMember/personAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|projectMember/personAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|projectMember/personAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|projectMember/personAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|projectMember/personAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|projectMember/personAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|projectMember/personAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|projectMember/personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|projectMember/personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|projectMember/personAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|projectMember/personAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|projectMember/personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectMember/personAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|projectMember/personAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|projectMember/personAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|projectMember/personAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|projectMember/personAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|projectMember/correspondingAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|projectMember/correspondingAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|projectMember/correspondingAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|projectMember/correspondingAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|projectMember/correspondingAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|projectMember/correspondingAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectMember/correspondingAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMember/correspondingAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMember/correspondingAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|projectMember/correspondingAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|projectMember/correspondingAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|projectMember/correspondingAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMember/correspondingAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMember/correspondingAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|projectMember/correspondingAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|projectMember/correspondingAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|projectMember/correspondingAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|projectMember/correspondingAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|projectMember/correspondingAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|projectMember/correspondingAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|projectMember/correspondingAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|projectMember/correspondingAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|projectMember/correspondingAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|projectMember/correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|projectMember/correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|projectMember/correspondingAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|projectMember/correspondingAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|projectMember/correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectMember/correspondingAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|projectMember/correspondingAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|projectMember/correspondingAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMember/correspondingAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|projectMember/correspondingAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|projectMember/isMailingRecipient|bool|SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|projectMember/hasStoreConsent|bool|SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|projectMember/withdrawnStoreConsent|bool|SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|projectMember/hasEmarketingConsent|bool|SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|projectMember/withdrawnEmarketingConsent|bool|SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|projectMember/subscription|listAny|SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|projectMember/legalBaseStore|listAny|SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|projectMember/legalBaseEmarketing|listAny|SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|projectMember/consentSourceStore|listAny|SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|projectMember/consentSourceEmarketing|listAny|SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|projectMember/name|stringorPK|SR\_COMPANY\_NAME| x |
|projectMember/department|string|SR\_ARCHIVE\_DEPARTEMENT| x |
|projectMember/nameDepartment|string|SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|projectMember/associateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|projectMember/category|listAny|SR\_ARCHIVE\_CATEGORY| x |
|projectMember/categoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|projectMember/companyCategoryRank|int|Category rank| x |
|projectMember/business|listAny|SR\_ARCHIVE\_BUSINESS| x |
|projectMember/country|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|projectMember/countryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|projectMember/number|string|SR\_ARCHIVE\_NUMBER| x |
|projectMember/code|string|SR\_ARCHIVE\_CODE| x |
|projectMember/orgnr|string|VAT No.| x |
|projectMember/stop|bool|SR\_CC\_STOPX| x |
|projectMember/contactNoMail|bool|SR\_NO\_MAIL\_COMPANY| x |
|projectMember/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|projectMember/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|projectMember/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|projectMember/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|projectMember/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|projectMember/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|projectMember/contactSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|projectMember/contactDeleted|bool|SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|projectMember/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|projectMember/deletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|projectMember/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|projectMember/forceCompany|bool|Dummy: Dummy|  |
|projectMember/contactPhone/formattedNumber|string|SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/contactPhone/description|string|SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|projectMember/contactFax/formattedNumber|string|SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|projectMember/contactFax/description|string|SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|projectMember/contactEmail/emailProtocol|string|SR\_CRITERIONTYPE\_CONTACT - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|projectMember/contactEmail/emailAddress|string|SR\_CRITERIONTYPE\_CONTACT - SR\_ARCHIVE\_EMAIL| x |
|projectMember/contactEmail/emailDescription|string|SR\_CRITERIONTYPE\_CONTACT - SR\_ARCHIVE\_DESCRIPTION| x |
|projectMember/contactEmail/emailId|int|SR\_CRITERIONTYPE\_CONTACT - ID| x |
|projectMember/contactEmail/emailLastSent|datetime|SR\_CRITERIONTYPE\_CONTACT - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|projectMember/contactEmail/emailBounceCount|int|SR\_CRITERIONTYPE\_CONTACT - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|projectMember/contactEmail/emailLastBounce|datetime|SR\_CRITERIONTYPE\_CONTACT - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|projectMember/contactEmail/emailHasBounced|bool|SR\_CRITERIONTYPE\_CONTACT - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|projectMember/postAddress/addressId|int|SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|projectMember/postAddress/line1|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|projectMember/postAddress/line2|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|projectMember/postAddress/line3|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|projectMember/postAddress/county|string|SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|projectMember/postAddress/city|string|SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|projectMember/postAddress/zip|string|SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|projectMember/postAddress/state|string|SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|projectMember/postAddress/wgs84latitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|projectMember/postAddress/wgs84longitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|projectMember/postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|projectMember/postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|projectMember/streetAddress/addressId|int|SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|projectMember/streetAddress/line1|string|SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|projectMember/streetAddress/line2|string|SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|projectMember/streetAddress/line3|string|SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|projectMember/streetAddress/county|string|SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|projectMember/streetAddress/city|string|SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|projectMember/streetAddress/zip|string|SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|projectMember/streetAddress/state|string|SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|projectMember/streetAddress/wgs84latitude|decimal|SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|projectMember/streetAddress/wgs84longitude|decimal|SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|projectMember/streetAddress/formattedAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|projectMember/streetAddress/formattedMultiLineAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|projectMember/url/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|projectMember/url/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|projectMember/contactAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|projectMember/contactAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|projectMember/contactAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|projectMember/contactAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|projectMember/contactAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|projectMember/contactAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectMember/contactAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMember/contactAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMember/contactAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|projectMember/contactAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|projectMember/contactAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|projectMember/contactAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMember/contactAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMember/contactAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|projectMember/contactAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|projectMember/contactAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|projectMember/contactAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|projectMember/contactAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|projectMember/contactAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|projectMember/contactAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|projectMember/contactAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|projectMember/contactAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|projectMember/contactAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMember/contactAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|projectMember/contactAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|projectMember/contactAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|projectMember/contactAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|projectMember/contactAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectMember/contactAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|projectMember/contactAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|projectMember/contactAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|projectMember/contactAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|projectMember/contactAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|projectMember/contactInterestIds|listInterest|SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|projectMember/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|projectMember/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|projectMember/contactUdef/SuperOffice:3|int|companynumber| x |
|projectMember/contactUdef/SuperOffice:4|date|companydate| x |
|projectMember/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|projectMember/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|projectMember/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|projectMember/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|projectMember/contactUdef/SuperOffice:9|string|page1saleonly| x |
|projectMember/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|projectMember/contactUdef/SuperOffice:11|string|page1adminonly| x |
|projectMember/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|projectMember/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|projectMember/contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|projectMember/contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|projectMember/contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|projectMember/contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|projectMember/contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|projectMember/contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|projectMember/contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|projectMember/contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|projectMember/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|projectMember/contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|projectMember/contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|projectMember/contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|projectMember/contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|projectMember/contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|projectMember/contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|projectMember/contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
|projectMember/contactExtra/y\_organization/x\_name|string|Organization - Name: Name| x |
|projectMember/NumberOfActivities|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|projectMember/NumberOfActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMember/NumberOfNotCompletedActivities|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|projectMember/NumberOfNotCompletedActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMember/LastActivity|date|SR\_ROU\_LAST\_ACTIVITY|  |
|projectMember/LastCompletedActivity|date|SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|projectMember/LastDoByActivity|date|SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|projectMember/NumberOfSales|int|SR\_ROU\_NUMBER\_OF\_SALES|  |
|projectMember/NumberOfSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMember/NumberOfNotCompletedSales|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|projectMember/NumberOfNotCompletedSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMember/LastSale|date|SR\_ROU\_LAST\_SALE|  |
|projectMember/LastCompletedSale|date|SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|projectMember/LastDoBySale|date|SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|projectMember/NumberOfTickets|int|SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|projectMember/NumberOfTicketsInPeriod|int|SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMember/NumberOfNotCompletedTickets|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|projectMember/NumberOfNotCompletedTicketsInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMember/LastTicket|date|SR\_ROU\_LAST\_TICKET|  |
|projectMember/LastCompletedTicket|date|SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|projectMember/LastDoByTicket|date|SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|projectMember/SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|projectMember/SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
|projectMember/saintSaleStatus|listAny|SR\_WITH\_STATUS|  |
|projectMember/saintAmountClass|listAny|SR\_AMOUNT\_CLASS|  |
|projectMember/saintActivityType|listAny|SR\_ARCHIVE\_SAINT\_TYPE|  |
|projectMember/saintDirection|listAny|SR\_ARCHIVE\_DIRECTION|  |
|projectMember/saintIntention|listAny|SR\_ACTIVITY\_INTENTION|  |
|projectMember/saintTicketStatus|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|projectMember/saintTicketCategory|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|project/textId|int|Text ID| x |
|project/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/ProjectShadowDynamicSelection?$select=sale/amount,appointment/endTime,appointment/appointment/text,document/associate/lastName,projectMember/contactAssociate/simultaneousEjUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: SaleHistory
title: SaleHistory
description: Sale histories. Contains all changes to the sale records over time.
keywords: SaleHistory archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "SaleHistory"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SaleHistoryProvider">SuperOffice.CRM.ArchiveLists.SaleHistoryProvider</see> inside NetServer's SODatabase assembly.

Sale histories. Contains all changes to the sale records over time.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"sale"|[[SR_COMMON_SALE]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|currencyId|int|SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP| x |
|currency|listAny|SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP| x |
|credited|listAny|SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP| x |
|lossReason|listAny|SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP| x |
|source|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP| x |
|competitor|listAny|SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP| x |
|heading|stringorPK|SR\_COMMON\_SALE: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|amount|decimal|SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|amountWeighted|decimal|SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|earning|decimal|SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP| x |
|earningPercent|decimal|SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP| x |
|probPercent|int|SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP| x |
|stageWhenClosed|listAny|SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED|  |
|stage|listAny|SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|saleStatus|listAny|SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP| x |
|saleType|listAny|SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|nextDueDate|date|SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP| x |
|reopenDate|date|SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP| x |
|stalledComment|listAny|SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP| x |
|soldReason|listAny|SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP| x |
|saleNumber|string|SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER| x |
|visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|associate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|person/personId|int|SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|person/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|person/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|person/middleName|string|SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|person/fullName|string|SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|person/contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|person/hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|person/hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|person/personHasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|person/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|person/position|listAny|SR\_ARCHIVE\_POSITION| x |
|person/personNumber|string|SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|person/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|person/personCountry|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|person/personCountryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|person/personNoMail|bool|SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|person/rank|int|SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|person/birthdate| *None* |SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|person/associateType| *None* |SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|person/useAsMailingAddress|bool|SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|person/personSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|person/retired|bool|SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/birthYear|int|SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|person/birthMonth|int|SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|person/birthDay|int|SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|person/kanaFirstName|string|SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|person/kanaLastName|string|SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|person/personUpdatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|person/personUpdatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|person/personUpdatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|person/personRegisteredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|person/personRegisteredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|person/personRegisteredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|person/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|person/personActiveErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|person/ticketPriority|listAny|SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|person/supportLanguage|listAny|SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|person/supportAssociate|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|person/supportAssociateFullName|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|person/personAssociateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|person/personAssociateFullName|associate|SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|person/personCategory|listAny|SR\_ARCHIVE\_CATEGORY| x |
|person/personCategoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|person/personCategoryRank|int|!!Category rank| x |
|person/personBusiness|listAny|SR\_ARCHIVE\_BUSINESS| x |
|person/leadStatus|listAny|SR\_LABEL\_LEADSTATUS| x |
|person/leadstatusRank|int|!!Lead status RANK| x |
|person/personDeletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|person/hasCompany|bool|SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|person/isProjectMember|bool|SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|person/isStakeholder|bool|SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|person/updatedByWorkflow|listAny|SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|person/whenUpdatedByWorkflow|datetime|SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|person/createdByForm|listAny|SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|contact/contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|contact/name|stringorPK|SR\_COMPANY\_NAME| x |
|contact/department|string|SR\_ARCHIVE\_DEPARTEMENT| x |
|contact/nameDepartment|string|SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|contact/hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|contact/hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|contact/associateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|contact/category|listAny|SR\_ARCHIVE\_CATEGORY| x |
|contact/categoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|contact/companyCategoryRank|int|Category rank| x |
|contact/business|listAny|SR\_ARCHIVE\_BUSINESS| x |
|contact/country|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|contact/countryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|contact/number|string|SR\_ARCHIVE\_NUMBER| x |
|contact/code|string|SR\_ARCHIVE\_CODE| x |
|contact/orgnr|string|VAT No.| x |
|contact/stop|bool|SR\_CC\_STOPX| x |
|contact/contactNoMail|bool|SR\_NO\_MAIL\_COMPANY| x |
|contact/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|contact/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|contact/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|contact/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|contact/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|contact/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|contact/contactSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|contact/contactDeleted|bool|SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|contact/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|contact/deletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|contact/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|contact/forceCompany|bool|Dummy: Dummy|  |
|project/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP| x |
|project/projectId|int|SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP| x |
|project/name|stringorPK|SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP| x |
|project/number|string|SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP| x |
|project/type|listAny|SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP| x |
|project/status|listAny|SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP| x |
|project/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP| x |
|project/associateId|associate|SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|project/hasInfoText|bool|SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP| x |
|project/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|project/text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|project/description|string|SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION| x |
|project/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|project/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|project/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|project/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|project/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|project/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|project/hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|project/nextMilestone|date|SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP| x |
|project/endDate|date|SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP| x |
|project/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|project/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|project/eventId|int|SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID| x |
|project/startDate|date|SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP| x |
|project/project/textId|int|Text ID| x |
|project/project/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/SaleHistory?$select=personId,person/retired,project/eventId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


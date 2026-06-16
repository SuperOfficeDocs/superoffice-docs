---
uid: SaleTypeQuoteAttachment
title: SaleTypeQuoteAttachment
description: This is the archive Provider for the Product Archive is SoAdmin.
keywords: SaleTypeQuoteAttachment archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "SaleTypeQuoteAttachment"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SaleTypeQuoteAttachmentProvider">SuperOffice.CRM.ArchiveLists.SaleTypeQuoteAttachmentProvider</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the Product Archive is SoAdmin.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"saleTypeQuoteAttachment"|[[SR_AA_DOCUMENTS]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|defaultIncluded|bool|SR\_DEFAULT\_INCLUDED: SR\_DEFAULT\_INCLUDED\_TOOLTIP| x |
|saleTypeId|int|SR\_SALE\_TYPE\_ID: SR\_SALE\_TYPE\_ID\_TOOLTIP| x |
|saleTypeQuoteAttachmentId|int|SR\_SALETYPEQUOTEATTACHMENT\_ID: SR\_SALETYPEQUOTEATTACHMENT\_ID\_TOOLTIP| x |
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

## Sample

```http!
GET /api/v1/archive/SaleTypeQuoteAttachment?$select=document/yourref,document/associate/firstName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


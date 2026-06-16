---
uid: SaleSelectionCombined
title: SaleSelectionCombined
description: Implementation of the provider for the combined selection
keywords: SaleSelectionCombined archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "SaleSelectionCombined"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.SaleSelectionCombinedProvider">SuperOffice.CRM.ArchiveLists.Archive.SaleSelectionCombinedProvider</see> inside NetServer's SODatabase assembly.

Implementation of the provider for the combined selection

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
|heading|stringorPK|SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP| x |
|amount|decimal|SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|amountWeighted|decimal|SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|earning|decimal|SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP| x |
|earningPercent|decimal|SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP| x |
|probPercent|int|SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP| x |
|originalStage|listAny|SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED| x |
|stage|listAny|SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|saleStatus|listAny|SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP| x |
|stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP| x |
|saleType|listAny|SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|nextDueDate|date|SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP| x |
|reopenDate|date|SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP| x |
|stalledComment|listAny|SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP| x |
|saleTypeCategory|listAny|SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT| x |
|soldReason|listAny|SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP| x |
|saleNumber|string|SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER| x |
|hasStakeholders|bool|SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP| x |
|stakeholdersEnabled|bool|SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP| x |
|hasQuote|bool|SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP| x |
|hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|description|string|SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|daysInStage|int|SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP| x |
|visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|sale/textId|int|Text ID| x |
|sale/description|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|salePublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|salePublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|salePublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|person/phone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personDirectPhone/formattedNumber|string|SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personDirectPhone/description|string|SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|person/personMobilePhone/formattedNumber|string|SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personMobilePhone/description|string|SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|person/personPrivate/formattedNumber|string|SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personPrivate/description|string|SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|person/personPager/formattedNumber|string|SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personPager/description|string|SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|person/personDirectFax/formattedNumber|string|SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personDirectFax/description|string|SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|person/searchPhone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/searchPhone/description|string|SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|person/personInfo/textId|int|Text ID| x |
|person/personInfo/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|person/email/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|person/email/emailAddress|string|SR\_ARCHIVE\_EMAIL| x |
|person/email/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|person/email/emailId|int|ID| x |
|person/email/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|person/email/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|person/email/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|person/email/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|person/personUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|person/personUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|person/personAddress/addressId|int|SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|person/personAddress/line1|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|person/personAddress/line2|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|person/personAddress/line3|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|person/personAddress/county|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|person/personAddress/city|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|person/personAddress/zip|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|person/personAddress/state|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|person/personAddress/wgs84latitude|decimal|SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|person/personAddress/wgs84longitude|decimal|SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|person/personAddress/formattedAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|person/personAddress/formattedMultiLineAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/addressId|int|SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|person/restrictionAddress/line1|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|person/restrictionAddress/line2|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|person/restrictionAddress/line3|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|person/restrictionAddress/county|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|person/restrictionAddress/city|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|person/restrictionAddress/zip|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|person/restrictionAddress/state|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|person/restrictionAddress/wgs84latitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|person/restrictionAddress/wgs84longitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|person/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|person/personInterestIds|listInterest|SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|person/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|person/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|person/personUdef/SuperOffice:3|int|contactnumber| x |
|person/personUdef/SuperOffice:4|date|contactdate| x |
|person/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|person/personUdef/SuperOffice:6|bool|contactcheckbox| x |
|person/personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|person/personUdef/SuperOffice:8|decimal|contactdecimal| x |
|person/personUdef/SuperOffice:9|string|page1saleonly| x |
|person/personUdef/SuperOffice:10|string|page1marketingonly| x |
|person/personUdef/SuperOffice:11|string|page1adminonly| x |
|person/personExtra/x\_person\_integer|int|Extra Integer: Custom person integer| x |
|person/personExtra/x\_person\_hidden\_integer|int|Extra hidden integer: Custom integer field that is hidden| x |
|person/personExtra/x\_person\_float|decimal|Extra float: Custom float field| x |
|person/personExtra/x\_person\_longtext|string|Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|person/personExtra/x\_person\_date|date|Extra date: Custom date field on person. Default value = 28.03.2019| x |
|person/personExtra/x\_person\_datetime|datetime|Extra DateTime: Custom person date and time field. No default| x |
|person/personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default| x |
|person/personExtra/x\_person\_boolean|bool|Extra Boolean: Custom boolean field on person. Default checked| x |
|person/personExtra/x\_person\_timespan|timeSpan|Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|person/personExtra/x\_person\_shorttext|string|Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|person/personExtra/x\_person\_shorttext\_list|listAny|Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|person/personExtra/x\_person\_user\_relation|associate|Extra user relation: Custom person-user relation field| x |
|person/personExtra/x\_person\_category\_relation|listAny|Extra category relation: Custom person-category relation| x |
|person/personExtra/x\_person\_priority\_relation|listAny|Extra priority relation: Custom person-priority relation| x |
|person/personExtra/x\_person\_request\_relation|stringorPK|Extra request relation: Request relation on contact| x |
|person/personExtra/x\_person\_appointment\_relation|stringorPK|Extra appointment relation: Appointment relation on person| x |
|person/personExtra/x\_person\_contact\_relation|stringorPK|Extra company relation: Company relation on contact| x |
|person/personExtra/y\_rental/id|int|Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|person/personExtra/y\_rental/x\_start|date|Rental - Start rental: Start rental| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/personExtra/y\_rental/x\_end|date|Rental - End: End| x |
|person/personExtra/y\_rental/x\_amount|int|Rental - Amount: Number to rent. Default = 1| x |
|person/personExtra/y\_rental/x\_contact|stringorPK|Rental - Renter: Company that rents equipment| x |
|person/personExtra/y\_rental/y\_equipment/x\_name|string|Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|person/personExtra/y\_car/id|int|Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|person/personAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|person/personAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|person/personAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|person/personAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|person/personAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|person/personAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|person/personAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|person/personAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|person/personAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|person/personAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|person/personAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|person/personAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|person/personAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|person/personAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|person/personAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|person/personAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|person/personAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|person/personAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|person/personAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|person/personAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|person/personAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|person/personAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|person/personAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|person/personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|person/personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|person/personAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|person/personAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|person/personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|person/personAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|person/personAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|person/personAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|person/personAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|person/personAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|person/correspondingAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|person/correspondingAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|person/correspondingAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|person/correspondingAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|person/correspondingAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|person/correspondingAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|person/correspondingAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|person/correspondingAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|person/correspondingAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|person/correspondingAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|person/correspondingAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|person/correspondingAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|person/correspondingAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|person/correspondingAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|person/correspondingAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|person/correspondingAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|person/correspondingAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|person/correspondingAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|person/correspondingAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|person/correspondingAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|person/correspondingAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|person/correspondingAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|person/correspondingAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|person/correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|person/correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|person/correspondingAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|person/correspondingAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|person/correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|person/correspondingAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|person/correspondingAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|person/correspondingAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|person/correspondingAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|person/correspondingAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|person/isMailingRecipient|bool|SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|person/hasStoreConsent|bool|SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/withdrawnStoreConsent|bool|SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/hasEmarketingConsent|bool|SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/withdrawnEmarketingConsent|bool|SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/subscription|listAny|SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|person/legalBaseStore|listAny|SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|person/legalBaseEmarketing|listAny|SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|person/consentSourceStore|listAny|SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|person/consentSourceEmarketing|listAny|SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|contact/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|contact/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|contact/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|contact/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|contact/contactSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|contact/contactDeleted|bool|SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|contact/phone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contact/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|contact/deletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|contact/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|contact/forceCompany|bool|Dummy: Dummy|  |
|contact/contactPhone/formattedNumber|string|SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contact/contactPhone/description|string|SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|contact/contactFax/formattedNumber|string|SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contact/contactFax/description|string|SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|contact/searchPhone/formattedNumber|string|SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contact/searchPhone/description|string|SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|contact/email/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|contact/email/emailAddress|string|SR\_ARCHIVE\_EMAIL| x |
|contact/email/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|contact/email/emailId|int|ID| x |
|contact/email/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|contact/email/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|contact/email/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|contact/email/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|contact/postAddress/addressId|int|SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|contact/postAddress/line1|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|contact/postAddress/line2|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|contact/postAddress/line3|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|contact/postAddress/county|string|SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|contact/postAddress/city|string|SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|contact/postAddress/zip|string|SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|contact/postAddress/state|string|SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|contact/postAddress/wgs84latitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|contact/postAddress/wgs84longitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|contact/postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/addressId|int|SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|contact/streetAddress/line1|string|SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|contact/streetAddress/line2|string|SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|contact/streetAddress/line3|string|SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|contact/streetAddress/county|string|SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|contact/streetAddress/city|string|SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|contact/streetAddress/zip|string|SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|contact/streetAddress/state|string|SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|contact/streetAddress/wgs84latitude|decimal|SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|contact/streetAddress/wgs84longitude|decimal|SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|contact/streetAddress/formattedAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/formattedMultiLineAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/addressId|int|SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|contact/restrictionAddress/line1|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|contact/restrictionAddress/line2|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|contact/restrictionAddress/line3|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|contact/restrictionAddress/county|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|contact/restrictionAddress/city|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|contact/restrictionAddress/zip|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|contact/restrictionAddress/state|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|contact/restrictionAddress/wgs84latitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|contact/restrictionAddress/wgs84longitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|contact/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|contact/url/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|contact/url/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|contact/contactAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|contact/contactAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|contact/contactAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|contact/contactAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|contact/contactAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|contact/contactAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|contact/contactAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contact/contactAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contact/contactAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|contact/contactAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|contact/contactAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|contact/contactAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contact/contactAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contact/contactAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|contact/contactAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|contact/contactAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|contact/contactAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|contact/contactAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|contact/contactAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|contact/contactAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|contact/contactAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|contact/contactAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|contact/contactAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|contact/contactAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|contact/contactAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|contact/contactAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|contact/contactAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|contact/contactAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contact/contactAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|contact/contactAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|contact/contactAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|contact/contactAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|contact/contactAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|contact/contactInterestIds|listInterest|SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/contactUdef/SuperOffice:3|int|companynumber| x |
|contact/contactUdef/SuperOffice:4|date|companydate| x |
|contact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|contact/contactUdef/SuperOffice:6|bool|companycheckbox| x |
|contact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|contact/contactUdef/SuperOffice:8|decimal|companydecimal| x |
|contact/contactUdef/SuperOffice:9|string|page1saleonly| x |
|contact/contactUdef/SuperOffice:10|string|page1marketingonly| x |
|contact/contactUdef/SuperOffice:11|string|page1adminonly| x |
|contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|contact/contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|contact/contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|contact/contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|contact/contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|contact/contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|contact/contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|contact/contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|contact/contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|contact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|contact/contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|contact/contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|contact/contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|contact/contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|contact/contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|contact/contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
|contact/contactExtra/y\_organization/x\_name|string|Organization - Name: Name| x |
|contact/NumberOfActivities|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|contact/NumberOfActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|contact/NumberOfNotCompletedActivities|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|contact/NumberOfNotCompletedActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|contact/LastActivity|date|SR\_ROU\_LAST\_ACTIVITY|  |
|contact/LastCompletedActivity|date|SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|contact/LastDoByActivity|date|SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|contact/NumberOfSales|int|SR\_ROU\_NUMBER\_OF\_SALES|  |
|contact/NumberOfSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|contact/NumberOfNotCompletedSales|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|contact/NumberOfNotCompletedSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|contact/LastSale|date|SR\_ROU\_LAST\_SALE|  |
|contact/LastCompletedSale|date|SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|contact/LastDoBySale|date|SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|contact/NumberOfTickets|int|SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|contact/NumberOfTicketsInPeriod|int|SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|contact/NumberOfNotCompletedTickets|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|contact/NumberOfNotCompletedTicketsInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|contact/LastTicket|date|SR\_ROU\_LAST\_TICKET|  |
|contact/LastCompletedTicket|date|SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|contact/LastDoByTicket|date|SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|contact/SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|contact/SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
|contact/saintSaleStatus|listAny|SR\_WITH\_STATUS|  |
|contact/saintAmountClass|listAny|SR\_AMOUNT\_CLASS|  |
|contact/saintActivityType|listAny|SR\_ARCHIVE\_SAINT\_TYPE|  |
|contact/saintDirection|listAny|SR\_ARCHIVE\_DIRECTION|  |
|contact/saintIntention|listAny|SR\_ACTIVITY\_INTENTION|  |
|contact/saintTicketStatus|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|contact/saintTicketCategory|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
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
|saleUdef/SuperOffice:1|string|saleshorttext| x |
|saleUdef/SuperOffice:2|string|salelongtext| x |
|saleUdef/SuperOffice:3|int|salenumber| x |
|saleUdef/SuperOffice:4|date|saledate| x |
|saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|saleUdef/SuperOffice:6|bool|salecheckbox| x |
|saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|saleUdef/SuperOffice:8|decimal|saledecimal| x |
|appointment/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|project/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|project/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|project/eventId|int|SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID| x |
|project/startDate|date|SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP| x |
|project/projectPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|project/projectPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|project/projectPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|project/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|project/projectEvent/isExternalEvent|bool|SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP| x |
|project/projectEvent/eventDate|date|SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP| x |
|project/projectEvent/hasSignOn|bool|SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP| x |
|project/projectEvent/hasSignOff|bool|SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP| x |
|project/projectUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|project/projectUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|project/projectAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|project/projectAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|project/projectAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|project/projectAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|project/projectAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|project/projectAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|project/projectAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|project/projectAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|project/projectAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|project/projectAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|project/projectAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|project/projectAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|project/projectAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|project/projectAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|project/projectAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|project/projectAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|project/projectAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|project/projectAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|project/projectAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|project/projectAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|project/projectAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|project/projectAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|project/projectAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|project/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|project/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|project/projectAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|project/projectAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|project/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|project/projectAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|project/projectAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|project/projectAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|project/projectAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|project/projectAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|project/projectUdef/SuperOffice:1|string|projectshorttext| x |
|project/projectUdef/SuperOffice:2|string|projectlongtext| x |
|project/projectUdef/SuperOffice:3|int|projectnumber| x |
|project/projectUdef/SuperOffice:4|date|projectdate| x |
|project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|project/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|project/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|project/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|project/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|project/NumberOfActivities|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|project/NumberOfActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|project/NumberOfNotCompletedActivities|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|project/NumberOfNotCompletedActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|project/LastActivity|date|SR\_ROU\_LAST\_ACTIVITY|  |
|project/LastCompletedActivity|date|SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|project/LastDoByActivity|date|SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|project/NumberOfSales|int|SR\_ROU\_NUMBER\_OF\_SALES|  |
|project/NumberOfSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|project/NumberOfNotCompletedSales|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|project/NumberOfNotCompletedSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|project/LastSale|date|SR\_ROU\_LAST\_SALE|  |
|project/LastCompletedSale|date|SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|project/LastDoBySale|date|SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|project/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|project/saintSaleStatus|listAny|SR\_WITH\_STATUS|  |
|project/saintAmountClass|listAny|SR\_AMOUNT\_CLASS|  |
|project/saintActivityType|listAny|SR\_ARCHIVE\_SAINT\_TYPE|  |
|project/saintDirection|listAny|SR\_ARCHIVE\_DIRECTION|  |
|project/saintIntention|listAny|SR\_ACTIVITY\_INTENTION|  |
|project/saintTicketStatus|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|project/saintTicketCategory|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|project/project/textId|int|Text ID| x |
|project/project/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|saleStakeholder/saleStakeholderId|int|SR\_STAKEHOLDER - SR\_STAKEHOLDER\_ID: SR\_STAKEHOLDER\_ID\_TOOLTIP| x |
|saleStakeholder/saleId|int|SR\_STAKEHOLDER - SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|saleStakeholder/comment|string|SR\_STAKEHOLDER - SR\_STAKEHOLDERS\_ROLE\_COMMENT\_TEXT: SR\_STAKEHOLDERS\_ROLE\_COMMENT\_TEXT| x |
|saleStakeholder/salesRoleId|listAny|SR\_STAKEHOLDER - SR\_STAKEHOLDERS\_ROLE: SR\_STAKEHOLDERS\_ROLE| x |
|saleStakeholder/hasInfoText|bool|SR\_STAKEHOLDER - SR\_STAKEHOLDERS\_ROLE\_COMMENT: SR\_STAKEHOLDERS\_ROLE\_COMMENT| x |
|saleStakeholder/person/personId|int|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|saleStakeholder/person/firstName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|saleStakeholder/person/lastName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|saleStakeholder/person/middleName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|saleStakeholder/person/fullName|string|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|saleStakeholder/person/contactId|int|SR\_STAKEHOLDER - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|saleStakeholder/person/hasInfoText|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|saleStakeholder/person/hasInterests|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|saleStakeholder/person/personHasInterests|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|saleStakeholder/person/mrMrs|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|saleStakeholder/person/position|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_POSITION| x |
|saleStakeholder/person/personNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|saleStakeholder/person/title|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|saleStakeholder/person/personCountry|listAny|SR\_STAKEHOLDER - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/personCountryId|int|SR\_STAKEHOLDER - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|saleStakeholder/person/personNoMail|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|saleStakeholder/person/rank|int|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|saleStakeholder/person/birthdate| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|saleStakeholder/person/associateType| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|saleStakeholder/person/useAsMailingAddress|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|saleStakeholder/person/personSource|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|saleStakeholder/person/retired|bool|SR\_STAKEHOLDER - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|saleStakeholder/person/birthYear|int|SR\_STAKEHOLDER - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|saleStakeholder/person/birthMonth|int|SR\_STAKEHOLDER - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|saleStakeholder/person/birthDay|int|SR\_STAKEHOLDER - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|saleStakeholder/person/kanaFirstName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|saleStakeholder/person/kanaLastName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|saleStakeholder/person/personUpdatedBy|associate|SR\_STAKEHOLDER - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|saleStakeholder/person/personUpdatedByFullName|associate|SR\_STAKEHOLDER - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|saleStakeholder/person/personUpdatedDate|date|SR\_STAKEHOLDER - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|saleStakeholder/person/personRegisteredBy|associate|SR\_STAKEHOLDER - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|saleStakeholder/person/personRegisteredByFullName|associate|SR\_STAKEHOLDER - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|saleStakeholder/person/personRegisteredDate|date|SR\_STAKEHOLDER - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|saleStakeholder/person/portraitThumbnail| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|saleStakeholder/person/personActiveErpLinks|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|saleStakeholder/person/ticketPriority|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|saleStakeholder/person/supportLanguage|listAny|SR\_STAKEHOLDER - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|saleStakeholder/person/supportAssociate|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|saleStakeholder/person/supportAssociateFullName|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|saleStakeholder/person/personAssociateId|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|saleStakeholder/person/personAssociateFullName|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|saleStakeholder/person/personCategory|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY| x |
|saleStakeholder/person/personCategoryGroup|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|saleStakeholder/person/personCategoryRank|int|SR\_STAKEHOLDER - !!Category rank| x |
|saleStakeholder/person/personBusiness|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_BUSINESS| x |
|saleStakeholder/person/leadStatus|listAny|SR\_STAKEHOLDER - SR\_LABEL\_LEADSTATUS| x |
|saleStakeholder/person/leadstatusRank|int|SR\_STAKEHOLDER - !!Lead status RANK| x |
|saleStakeholder/person/personDeletedDate|datetime|SR\_STAKEHOLDER - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|saleStakeholder/person/hasCompany|bool|SR\_STAKEHOLDER - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|saleStakeholder/person/isProjectMember|bool|SR\_STAKEHOLDER - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|saleStakeholder/person/isStakeholder|bool|SR\_STAKEHOLDER - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|saleStakeholder/person/updatedByWorkflow|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|saleStakeholder/person/whenUpdatedByWorkflow|datetime|SR\_STAKEHOLDER - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|saleStakeholder/person/createdByForm|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|saleStakeholder/person/phone/formattedNumber|string|SR\_STAKEHOLDER - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personDirectPhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personDirectPhone/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/person/personMobilePhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personMobilePhone/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/person/personPrivate/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personPrivate/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/person/personPager/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personPager/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/person/personDirectFax/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personDirectFax/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/person/searchPhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/searchPhone/description|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/person/personInfo/textId|int|SR\_STAKEHOLDER - Text ID| x |
|saleStakeholder/person/personInfo/infoText|positiveString|SR\_STAKEHOLDER - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|saleStakeholder/person/email/emailProtocol|string|SR\_STAKEHOLDER - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|saleStakeholder/person/email/emailAddress|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL| x |
|saleStakeholder/person/email/emailDescription|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION| x |
|saleStakeholder/person/email/emailId|int|SR\_STAKEHOLDER - ID| x |
|saleStakeholder/person/email/emailLastSent|datetime|SR\_STAKEHOLDER - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|saleStakeholder/person/email/emailBounceCount|int|SR\_STAKEHOLDER - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|saleStakeholder/person/email/emailLastBounce|datetime|SR\_STAKEHOLDER - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|saleStakeholder/person/email/emailHasBounced|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|saleStakeholder/person/personUrl/URLAddress|string|SR\_STAKEHOLDER - SR\_PROJECTARCHIVE\_URL| x |
|saleStakeholder/person/personUrl/URLDescription|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION| x |
|saleStakeholder/person/personAddress/addressId|int|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|saleStakeholder/person/personAddress/line1|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|saleStakeholder/person/personAddress/line2|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|saleStakeholder/person/personAddress/line3|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|saleStakeholder/person/personAddress/county|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|saleStakeholder/person/personAddress/city|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|saleStakeholder/person/personAddress/zip|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|saleStakeholder/person/personAddress/state|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|saleStakeholder/person/personAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|saleStakeholder/person/personAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|saleStakeholder/person/personAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/addressId|int|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|saleStakeholder/person/restrictionAddress/line1|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|saleStakeholder/person/restrictionAddress/line2|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|saleStakeholder/person/restrictionAddress/line3|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|saleStakeholder/person/restrictionAddress/county|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|saleStakeholder/person/restrictionAddress/city|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|saleStakeholder/person/restrictionAddress/zip|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|saleStakeholder/person/restrictionAddress/state|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|saleStakeholder/person/restrictionAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|saleStakeholder/person/restrictionAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|saleStakeholder/person/restrictionAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personInterestIds|listInterest|SR\_STAKEHOLDER - SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|saleStakeholder/person/personUdef/SuperOffice:1|string|SR\_STAKEHOLDER - contactshorttext: tooltipshorttext| x |
|saleStakeholder/person/personUdef/SuperOffice:2|string|SR\_STAKEHOLDER - contactlongtext: tooltiplongtext| x |
|saleStakeholder/person/personUdef/SuperOffice:3|int|SR\_STAKEHOLDER - contactnumber| x |
|saleStakeholder/person/personUdef/SuperOffice:4|date|SR\_STAKEHOLDER - contactdate| x |
|saleStakeholder/person/personUdef/SuperOffice:5|unlimitedDate|SR\_STAKEHOLDER - contactunlimiteddate: tooltipunlimiteddate| x |
|saleStakeholder/person/personUdef/SuperOffice:6|bool|SR\_STAKEHOLDER - contactcheckbox| x |
|saleStakeholder/person/personUdef/SuperOffice:7|listAny|SR\_STAKEHOLDER - contactdropdownlistbox| x |
|saleStakeholder/person/personUdef/SuperOffice:8|decimal|SR\_STAKEHOLDER - contactdecimal| x |
|saleStakeholder/person/personUdef/SuperOffice:9|string|SR\_STAKEHOLDER - page1saleonly| x |
|saleStakeholder/person/personUdef/SuperOffice:10|string|SR\_STAKEHOLDER - page1marketingonly| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/personUdef/SuperOffice:11|string|SR\_STAKEHOLDER - page1adminonly| x |
|saleStakeholder/person/personExtra/x\_person\_integer|int|SR\_STAKEHOLDER - Extra Integer: Custom person integer| x |
|saleStakeholder/person/personExtra/x\_person\_hidden\_integer|int|SR\_STAKEHOLDER - Extra hidden integer: Custom integer field that is hidden| x |
|saleStakeholder/person/personExtra/x\_person\_float|decimal|SR\_STAKEHOLDER - Extra float: Custom float field| x |
|saleStakeholder/person/personExtra/x\_person\_longtext|string|SR\_STAKEHOLDER - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|saleStakeholder/person/personExtra/x\_person\_date|date|SR\_STAKEHOLDER - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|saleStakeholder/person/personExtra/x\_person\_datetime|datetime|SR\_STAKEHOLDER - Extra DateTime: Custom person date and time field. No default| x |
|saleStakeholder/person/personExtra/x\_person\_time| *None* |SR\_STAKEHOLDER - Extra time: Custom time field on person. Current time as default| x |
|saleStakeholder/person/personExtra/x\_person\_boolean|bool|SR\_STAKEHOLDER - Extra Boolean: Custom boolean field on person. Default checked| x |
|saleStakeholder/person/personExtra/x\_person\_timespan|timeSpan|SR\_STAKEHOLDER - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|saleStakeholder/person/personExtra/x\_person\_shorttext|string|SR\_STAKEHOLDER - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|saleStakeholder/person/personExtra/x\_person\_shorttext\_list|listAny|SR\_STAKEHOLDER - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|saleStakeholder/person/personExtra/x\_person\_user\_relation|associate|SR\_STAKEHOLDER - Extra user relation: Custom person-user relation field| x |
|saleStakeholder/person/personExtra/x\_person\_category\_relation|listAny|SR\_STAKEHOLDER - Extra category relation: Custom person-category relation| x |
|saleStakeholder/person/personExtra/x\_person\_priority\_relation|listAny|SR\_STAKEHOLDER - Extra priority relation: Custom person-priority relation| x |
|saleStakeholder/person/personExtra/x\_person\_request\_relation|stringorPK|SR\_STAKEHOLDER - Extra request relation: Request relation on contact| x |
|saleStakeholder/person/personExtra/x\_person\_appointment\_relation|stringorPK|SR\_STAKEHOLDER - Extra appointment relation: Appointment relation on person| x |
|saleStakeholder/person/personExtra/x\_person\_contact\_relation|stringorPK|SR\_STAKEHOLDER - Extra company relation: Company relation on contact| x |
|saleStakeholder/person/personExtra/y\_rental/id|int|SR\_STAKEHOLDER - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|saleStakeholder/person/personExtra/y\_rental/x\_start|date|SR\_STAKEHOLDER - Rental - Start rental: Start rental| x |
|saleStakeholder/person/personExtra/y\_rental/x\_end|date|SR\_STAKEHOLDER - Rental - End: End| x |
|saleStakeholder/person/personExtra/y\_rental/x\_amount|int|SR\_STAKEHOLDER - Rental - Amount: Number to rent. Default = 1| x |
|saleStakeholder/person/personExtra/y\_rental/x\_contact|stringorPK|SR\_STAKEHOLDER - Rental - Renter: Company that rents equipment| x |
|saleStakeholder/person/personExtra/y\_rental/y\_equipment/x\_name|string|SR\_STAKEHOLDER - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|saleStakeholder/person/personExtra/y\_car/id|int|SR\_STAKEHOLDER - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|saleStakeholder/person/personAssociate/firstName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/lastName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/middleName|string|SR\_STAKEHOLDER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/fullName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/contactId|int|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/personId|int|SR\_STAKEHOLDER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/mrMrs|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/title|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/associateDbId|associate|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|saleStakeholder/person/personAssociate/contactName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/contactDepartment|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/usergroup|userGroup|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/usergroupId|int|SR\_STAKEHOLDER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/contactFullName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/contactCategory|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|saleStakeholder/person/personAssociate/role|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|saleStakeholder/person/personAssociate/assocName|associate|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|saleStakeholder/person/personAssociate/assocTooltip|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|saleStakeholder/person/personAssociate/assocType|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/ejUserId|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|saleStakeholder/person/personAssociate/simultaneousEjUser|bool|SR\_STAKEHOLDER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/ejDisplayName|string|SR\_STAKEHOLDER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|saleStakeholder/person/personAssociate/ejStatus|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|saleStakeholder/person/personAssociate/credentialType| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/credentialDisplayValue| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/isActive|bool|SR\_STAKEHOLDER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/isActiveText|bool|SR\_STAKEHOLDER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/portraitThumbnail| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|saleStakeholder/person/personAssociate/otherGroups|userGroup|SR\_STAKEHOLDER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|saleStakeholder/person/personAssociate/userName|string|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|saleStakeholder/person/personAssociate/personEmail|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL| x |
|saleStakeholder/person/personAssociate/locationAddress|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|saleStakeholder/person/personAssociate/isLocation|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|saleStakeholder/person/correspondingAssociate/firstName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/lastName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/middleName|string|SR\_STAKEHOLDER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/fullName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/contactId|int|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/personId|int|SR\_STAKEHOLDER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/mrMrs|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/title|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/associateDbId|associate|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|saleStakeholder/person/correspondingAssociate/contactName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/contactDepartment|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/usergroup|userGroup|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/usergroupId|int|SR\_STAKEHOLDER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/contactFullName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/contactCategory|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|saleStakeholder/person/correspondingAssociate/role|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|saleStakeholder/person/correspondingAssociate/assocName|associate|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|saleStakeholder/person/correspondingAssociate/assocTooltip|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|saleStakeholder/person/correspondingAssociate/assocType|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/ejUserId|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|saleStakeholder/person/correspondingAssociate/simultaneousEjUser|bool|SR\_STAKEHOLDER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/ejDisplayName|string|SR\_STAKEHOLDER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|saleStakeholder/person/correspondingAssociate/ejStatus|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|saleStakeholder/person/correspondingAssociate/credentialType| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/credentialDisplayValue| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/isActive|bool|SR\_STAKEHOLDER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/isActiveText|bool|SR\_STAKEHOLDER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/portraitThumbnail| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|saleStakeholder/person/correspondingAssociate/otherGroups|userGroup|SR\_STAKEHOLDER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|saleStakeholder/person/correspondingAssociate/userName|string|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|saleStakeholder/person/correspondingAssociate/personEmail|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL| x |
|saleStakeholder/person/correspondingAssociate/locationAddress|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|saleStakeholder/person/correspondingAssociate/isLocation|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|saleStakeholder/person/isMailingRecipient|bool|SR\_STAKEHOLDER - SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|saleStakeholder/person/hasStoreConsent|bool|SR\_STAKEHOLDER - SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/withdrawnStoreConsent|bool|SR\_STAKEHOLDER - SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/hasEmarketingConsent|bool|SR\_STAKEHOLDER - SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/withdrawnEmarketingConsent|bool|SR\_STAKEHOLDER - SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/subscription|listAny|SR\_STAKEHOLDER - SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|saleStakeholder/person/legalBaseStore|listAny|SR\_STAKEHOLDER - SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|saleStakeholder/person/legalBaseEmarketing|listAny|SR\_STAKEHOLDER - SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|saleStakeholder/person/consentSourceStore|listAny|SR\_STAKEHOLDER - SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/consentSourceEmarketing|listAny|SR\_STAKEHOLDER - SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|saleStakeholder/contact/contactId|int|SR\_STAKEHOLDER - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|saleStakeholder/contact/name|stringorPK|SR\_STAKEHOLDER - SR\_COMPANY\_NAME| x |
|saleStakeholder/contact/department|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DEPARTEMENT| x |
|saleStakeholder/contact/nameDepartment|string|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|saleStakeholder/contact/hasInfoText|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|saleStakeholder/contact/hasInterests|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|saleStakeholder/contact/associateId|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|saleStakeholder/contact/category|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY| x |
|saleStakeholder/contact/categoryGroup|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|saleStakeholder/contact/companyCategoryRank|int|SR\_STAKEHOLDER - Category rank| x |
|saleStakeholder/contact/business|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_BUSINESS| x |
|saleStakeholder/contact/country|listAny|SR\_STAKEHOLDER - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|saleStakeholder/contact/countryId|int|SR\_STAKEHOLDER - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|saleStakeholder/contact/number|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_NUMBER| x |
|saleStakeholder/contact/code|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_CODE| x |
|saleStakeholder/contact/orgnr|string|SR\_STAKEHOLDER - VAT No.| x |
|saleStakeholder/contact/stop|bool|SR\_STAKEHOLDER - SR\_CC\_STOPX| x |
|saleStakeholder/contact/contactNoMail|bool|SR\_STAKEHOLDER - SR\_NO\_MAIL\_COMPANY| x |
|saleStakeholder/contact/updatedBy|associate|SR\_STAKEHOLDER - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|saleStakeholder/contact/updatedByFullName|associate|SR\_STAKEHOLDER - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|saleStakeholder/contact/updatedDate|date|SR\_STAKEHOLDER - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|saleStakeholder/contact/registeredBy|associate|SR\_STAKEHOLDER - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|saleStakeholder/contact/registeredByFullName|associate|SR\_STAKEHOLDER - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|saleStakeholder/contact/registeredDate|date|SR\_STAKEHOLDER - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|saleStakeholder/contact/contactSource|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|saleStakeholder/contact/contactDeleted|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|saleStakeholder/contact/phone/formattedNumber|string|SR\_STAKEHOLDER - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/contact/activeErpLinks|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|saleStakeholder/contact/deletedDate|datetime|SR\_STAKEHOLDER - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|saleStakeholder/contact/mainContact| *None* |SR\_STAKEHOLDER - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|saleStakeholder/contact/forceCompany|bool|SR\_STAKEHOLDER - Dummy: Dummy|  |
|saleStakeholder/contact/contactPhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/contact/contactPhone/description|string|SR\_STAKEHOLDER - SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/contact/contactFax/formattedNumber|string|SR\_STAKEHOLDER - SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/contact/contactFax/description|string|SR\_STAKEHOLDER - SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/contact/searchPhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/contact/searchPhone/description|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|saleStakeholder/contact/email/emailProtocol|string|SR\_STAKEHOLDER - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|saleStakeholder/contact/email/emailAddress|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL| x |
|saleStakeholder/contact/email/emailDescription|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION| x |
|saleStakeholder/contact/email/emailId|int|SR\_STAKEHOLDER - ID| x |
|saleStakeholder/contact/email/emailLastSent|datetime|SR\_STAKEHOLDER - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|saleStakeholder/contact/email/emailBounceCount|int|SR\_STAKEHOLDER - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|saleStakeholder/contact/email/emailLastBounce|datetime|SR\_STAKEHOLDER - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|saleStakeholder/contact/email/emailHasBounced|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/addressId|int|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/line1|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/line2|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/line3|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/county|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/city|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/zip|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/state|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|saleStakeholder/contact/postAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|saleStakeholder/contact/postAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|saleStakeholder/contact/postAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/postAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/addressId|int|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|saleStakeholder/contact/streetAddress/line1|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|saleStakeholder/contact/streetAddress/line2|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|saleStakeholder/contact/streetAddress/line3|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|saleStakeholder/contact/streetAddress/county|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|saleStakeholder/contact/streetAddress/city|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|saleStakeholder/contact/streetAddress/zip|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|saleStakeholder/contact/streetAddress/state|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|saleStakeholder/contact/streetAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|saleStakeholder/contact/streetAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|saleStakeholder/contact/streetAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/addressId|int|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|saleStakeholder/contact/restrictionAddress/line1|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|saleStakeholder/contact/restrictionAddress/line2|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|saleStakeholder/contact/restrictionAddress/line3|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|saleStakeholder/contact/restrictionAddress/county|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|saleStakeholder/contact/restrictionAddress/city|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|saleStakeholder/contact/restrictionAddress/zip|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|saleStakeholder/contact/restrictionAddress/state|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|saleStakeholder/contact/restrictionAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|saleStakeholder/contact/restrictionAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|saleStakeholder/contact/restrictionAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/url/URLAddress|string|SR\_STAKEHOLDER - SR\_PROJECTARCHIVE\_URL| x |
|saleStakeholder/contact/url/URLDescription|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION| x |
|saleStakeholder/contact/contactAssociate/firstName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/lastName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/middleName|string|SR\_STAKEHOLDER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/fullName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/contactId|int|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/personId|int|SR\_STAKEHOLDER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/mrMrs|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/title|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/associateDbId|associate|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|saleStakeholder/contact/contactAssociate/contactName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/contactDepartment|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/usergroup|userGroup|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/usergroupId|int|SR\_STAKEHOLDER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/contactFullName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/contactCategory|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|saleStakeholder/contact/contactAssociate/role|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/contact/contactAssociate/assocName|associate|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|saleStakeholder/contact/contactAssociate/assocTooltip|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|saleStakeholder/contact/contactAssociate/assocType|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/ejUserId|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|saleStakeholder/contact/contactAssociate/simultaneousEjUser|bool|SR\_STAKEHOLDER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/ejDisplayName|string|SR\_STAKEHOLDER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|saleStakeholder/contact/contactAssociate/ejStatus|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|saleStakeholder/contact/contactAssociate/credentialType| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/credentialDisplayValue| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/isActive|bool|SR\_STAKEHOLDER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/isActiveText|bool|SR\_STAKEHOLDER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/portraitThumbnail| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|saleStakeholder/contact/contactAssociate/otherGroups|userGroup|SR\_STAKEHOLDER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|saleStakeholder/contact/contactAssociate/userName|string|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|saleStakeholder/contact/contactAssociate/personEmail|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL| x |
|saleStakeholder/contact/contactAssociate/locationAddress|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|saleStakeholder/contact/contactAssociate/isLocation|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|saleStakeholder/contact/contactInterestIds|listInterest|SR\_STAKEHOLDER - SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|saleStakeholder/contact/contactUdef/SuperOffice:1|string|SR\_STAKEHOLDER - companyshorttext: tooltipshorttext| x |
|saleStakeholder/contact/contactUdef/SuperOffice:2|string|SR\_STAKEHOLDER - companylongtext: tooltiplongtext| x |
|saleStakeholder/contact/contactUdef/SuperOffice:3|int|SR\_STAKEHOLDER - companynumber| x |
|saleStakeholder/contact/contactUdef/SuperOffice:4|date|SR\_STAKEHOLDER - companydate| x |
|saleStakeholder/contact/contactUdef/SuperOffice:5|unlimitedDate|SR\_STAKEHOLDER - companyunlimiteddate: tooltipunlimiteddate| x |
|saleStakeholder/contact/contactUdef/SuperOffice:6|bool|SR\_STAKEHOLDER - companycheckbox| x |
|saleStakeholder/contact/contactUdef/SuperOffice:7|listAny|SR\_STAKEHOLDER - companydropdownlistbox| x |
|saleStakeholder/contact/contactUdef/SuperOffice:8|decimal|SR\_STAKEHOLDER - companydecimal| x |
|saleStakeholder/contact/contactUdef/SuperOffice:9|string|SR\_STAKEHOLDER - page1saleonly| x |
|saleStakeholder/contact/contactUdef/SuperOffice:10|string|SR\_STAKEHOLDER - page1marketingonly| x |
|saleStakeholder/contact/contactUdef/SuperOffice:11|string|SR\_STAKEHOLDER - page1adminonly| x |
|saleStakeholder/contact/contactUdef/SuperOffice:12|listAny|SR\_STAKEHOLDER - Udlist one: Static tooltip for udlist one| x |
|saleStakeholder/contact/contactUdef/SuperOffice:13|listAny|SR\_STAKEHOLDER - Udlist two: Static tooltip for udlist two| x |
|saleStakeholder/contact/contactExtra/x\_contact\_integer|int|SR\_STAKEHOLDER - Extra Integer: Custom integer field| x |
|saleStakeholder/contact/contactExtra/x\_contact\_hidden\_integer|int|SR\_STAKEHOLDER - Extra hidden integer: Custom integer field - hidden| x |
|saleStakeholder/contact/contactExtra/x\_contact\_default\_integer|int|SR\_STAKEHOLDER - Extra Default Integer: Custom integer field with default value 123.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_float|decimal|SR\_STAKEHOLDER - Extra Float: Custom float field with 3 decimals| x |
|saleStakeholder/contact/contactExtra/x\_contact\_longtext|string|SR\_STAKEHOLDER - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|saleStakeholder/contact/contactExtra/x\_contact\_dropdown|listAny|SR\_STAKEHOLDER - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_date|date|SR\_STAKEHOLDER - Extra date: Custom date field. User current as default.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_datetime|datetime|SR\_STAKEHOLDER - Extra DateTime: Custom Date Time field. No default value. External| x |
|saleStakeholder/contact/contactExtra/x\_contact\_time| *None* |SR\_STAKEHOLDER - Extra time: Custom time field.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_boolean|bool|SR\_STAKEHOLDER - Extra boolean: Custom boolean field.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_timespan|timeSpan|SR\_STAKEHOLDER - Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|saleStakeholder/contact/contactExtra/x\_contact\_shorttext|string|SR\_STAKEHOLDER - Extra short text: Custom short text field. Keep HTML tags.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_short\_dropdown|listAny|SR\_STAKEHOLDER - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|saleStakeholder/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|SR\_STAKEHOLDER - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|saleStakeholder/contact/contactExtra/x\_contact\_request\_relation|stringorPK|SR\_STAKEHOLDER - Extra Request relation: Request relation on company| x |
|saleStakeholder/contact/contactExtra/x\_contact\_contact|stringorPK|SR\_STAKEHOLDER - Extra contact relation: Contact relation on company| x |
|saleStakeholder/contact/contactExtra/y\_organization/x\_name|string|SR\_STAKEHOLDER - Organization - Name: Name| x |
|saleStakeholder/contact/NumberOfActivities|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|saleStakeholder/contact/NumberOfActivitiesInPeriod|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|saleStakeholder/contact/NumberOfNotCompletedActivities|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|saleStakeholder/contact/NumberOfNotCompletedActivitiesInPeriod|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|saleStakeholder/contact/LastActivity|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_ACTIVITY|  |
|saleStakeholder/contact/LastCompletedActivity|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|saleStakeholder/contact/LastDoByActivity|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|saleStakeholder/contact/NumberOfSales|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_SALES|  |
|saleStakeholder/contact/NumberOfSalesInPeriod|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|saleStakeholder/contact/NumberOfNotCompletedSales|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|saleStakeholder/contact/NumberOfNotCompletedSalesInPeriod|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|saleStakeholder/contact/LastSale|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_SALE|  |
|saleStakeholder/contact/LastCompletedSale|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|saleStakeholder/contact/LastDoBySale|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|saleStakeholder/contact/NumberOfTickets|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|saleStakeholder/contact/NumberOfTicketsInPeriod|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|saleStakeholder/contact/NumberOfNotCompletedTickets|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|saleStakeholder/contact/NumberOfNotCompletedTicketsInPeriod|int|SR\_STAKEHOLDER - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|saleStakeholder/contact/LastTicket|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_TICKET|  |
|saleStakeholder/contact/LastCompletedTicket|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|saleStakeholder/contact/LastDoByTicket|date|SR\_STAKEHOLDER - SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|saleStakeholder/contact/SaintStatus1|saintStatus|SR\_STAKEHOLDER - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|saleStakeholder/contact/SaintStatus2|saintStatus|SR\_STAKEHOLDER - C-company: Kundens navn starter med bokstaven C|  |
|saleStakeholder/contact/saintSaleStatus|listAny|SR\_STAKEHOLDER - SR\_WITH\_STATUS|  |
|saleStakeholder/contact/saintAmountClass|listAny|SR\_STAKEHOLDER - SR\_AMOUNT\_CLASS|  |
|saleStakeholder/contact/saintActivityType|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_SAINT\_TYPE|  |
|saleStakeholder/contact/saintDirection|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_DIRECTION|  |
|saleStakeholder/contact/saintIntention|listAny|SR\_STAKEHOLDER - SR\_ACTIVITY\_INTENTION|  |
|saleStakeholder/contact/saintTicketStatus|listAny|SR\_STAKEHOLDER - SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|saleStakeholder/contact/saintTicketCategory|listAny|SR\_STAKEHOLDER - SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|quote/quoteId|int|SR\_QUOTE\_QUOTE\_ID: SR\_QUOTE\_QUOTE\_ID\_TOOLTIP| x |
|quote/poNumber|string|SR\_QUOTE\_QUOTE\_PONUMBER: SR\_QUOTE\_QUOTE\_PONUMBER\_TOOLTIP| x |
|quote/orderComment|string|SR\_QUOTE\_QUOTE\_ORDERCOMMENT: SR\_QUOTE\_QUOTE\_ORDERCOMMENT\_TOOLTIP| x |
|quote/connectionId|int|SR\_QUOTE\_CONNECTIONID: SR\_QUOTE\_CONNECTIONID\_TOOLTIP| x |
|quote/registeredDate|date|SR\_QUOTE\_QUOTE\_REGISTERED: SR\_QUOTE\_QUOTE\_REGISTERED\_TOOLTIP| x |
|quote/version/quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP| x |
|quote/version/description|string|SR\_QUOTE\_QUOTEVERSION\_DESCRIPTION: SR\_QUOTE\_QUOTEVERSION\_DESCRIPTION\_TOOLTIP| x |
|quote/version/number|string|SR\_QUOTE\_QUOTEVERSION\_NUMBER: SR\_QUOTE\_QUOTEVERSION\_NUMBER\_TOOLTIP| x |
|quote/version/sent|date|SR\_QUOTE\_QUOTEVERSION\_SENT: SR\_QUOTE\_QUOTEVERSION\_SENT\_TOOLTIP| x |
|quote/version/expiration|date|SR\_QUOTE\_QUOTEVERSION\_EXPIRATION: SR\_QUOTE\_QUOTEVERSION\_EXPIRATION\_TOOLTIP| x |
|quote/version/state|listAny|SR\_QUOTE\_QUOTEVERSION\_STATE: SR\_QUOTE\_QUOTEVERSION\_STATE\_TOOLTIP| x |
|quote/version/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|quote/version/reason|string|SR\_QUOTE\_QUOTELINE\_QUOTEREASON: SR\_QUOTE\_QUOTELINE\_QUOTEREASON\_TOOLTIP| x |
|quote/version/paymentTerms|listExternal|SR\_QUOTE\_QUOTEVERSION\_PAYMENTTERMS: SR\_QUOTE\_QUOTEVERSION\_PAYMENTTERMS\_TOOLTIP|  |
|quote/version/paymentType|listExternal|SR\_QUOTE\_QUOTEVERSION\_PAYMENTTYPE: SR\_QUOTE\_QUOTEVERSION\_PAYMENTTYPE\_TOOLTIP|  |
|quote/version/deliveryTerms|listExternal|SR\_QUOTE\_QUOTEVERSION\_DELIVERYTERMS: SR\_QUOTE\_QUOTEVERSION\_DELIVERYTERMS\_TOOLTIP|  |
|quote/version/deliveryType|listExternal|SR\_QUOTE\_QUOTEVERSION\_DELIVERYTYPE: SR\_QUOTE\_QUOTEVERSION\_DELIVERYTYPE\_TOOLTIP|  |
|quote/version/approvedBy|associate|SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY\_TOOLTIP| x |
|quote/version/approvalRegisteredBy|associate|SR\_QUOTE\_QUOTEVERSION\_APPROVALREGISTEREDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVALREGISTEREDBY\_TOOLTIP| x |
|quote/version/approvedText|string|SR\_QUOTE\_QUOTEVERSION\_APPROVEDTEXT: SR\_QUOTE\_QUOTEVERSION\_APPROVEDTEXT\_TOOLTIP| x |
|quote/version/approvedDate|date|SR\_QUOTE\_QUOTEVERSION\_APPROVEDDATE: SR\_QUOTE\_QUOTEVERSION\_APPROVEDDATE\_TOOLTIP| x |
|quote/version/extraField1|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD1: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD1\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|quote/version/extraField2|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD2: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD2\_TOOLTIP| x |
|quote/version/extraField3|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD3: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD3\_TOOLTIP| x |
|quote/version/extraField4|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD4: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD4\_TOOLTIP| x |
|quote/version/extraField5|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD5: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD5\_TOOLTIP| x |
|quote/version/alternative/quoteAlternativeId|int|SR\_QUOTE\_QUOTEALTERNATIVE\_ID: SR\_QUOTE\_QUOTEALTERNATIVE\_ID\_TOOLTIP| x |
|quote/version/alternative/quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP| x |
|quote/version/alternative/name|string|SR\_QUOTE\_QUOTEALTERNATIVE\_NAME: SR\_QUOTE\_QUOTEALTERNATIVE\_NAME\_TOOLTIP| x |
|quote/version/alternative/description|string|SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION: SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION\_TOOLTIP| x |
|quote/version/alternative/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|quote/version/alternative/reason|string|SR\_QUOTE\_QUOTELINE\_QUOTEREASON: SR\_QUOTE\_QUOTELINE\_QUOTEREASON\_TOOLTIP| x |
|quote/version/alternative/erpDiscountPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTPERCENT\_TOOLTIP| x |
|quote/version/alternative/erpDiscountAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTAMOUNT\_TOOLTIP| x |
|quote/version/alternative/discountPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTPERCENT\_TOOLTIP| x |
|quote/version/alternative/discountAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTAMOUNT\_TOOLTIP| x |
|quote/version/alternative/vatInfo|string|SR\_QUOTE\_QUOTEALTERNATIVE\_VATINFO: SR\_QUOTE\_QUOTEALTERNATIVE\_VATINFO\_TOOLTIP| x |
|quote/version/alternative/vat|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_VAT: SR\_QUOTE\_QUOTEALTERNATIVE\_VAT\_TOOLTIP| x |
|quote/version/alternative/earningPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSPERCENT\_TOOLTIP| x |
|quote/version/alternative/earningAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSAMOUNT\_TOOLTIP| x |
|quote/version/alternative/totalPrice|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTAL: SR\_QUOTE\_QUOTEALTERNATIVE\_TOTAL\_TOOLTIP| x |
|quote/version/alternative/extraField1|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD1: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD1\_TOOLTIP| x |
|quote/version/alternative/extraField2|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD2: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD2\_TOOLTIP| x |
|quote/version/alternative/extraField3|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD3: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD3\_TOOLTIP| x |
|quote/version/alternative/extraField4|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD4: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD4\_TOOLTIP| x |
|quote/version/alternative/extraField5|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD5: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD5\_TOOLTIP| x |
|quote/version/alternative/alternativeOrdering|int|SR\_QUOTE\_QUOTEALTERNATIVE\_ID: SR\_QUOTE\_QUOTEALTERNATIVE\_ID\_TOOLTIP| x |
|quote/version/alternative/subTotal|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_SUBTOTAL: SR\_QUOTE\_QUOTEALTERNATIVE\_SUBTOTAL\_TOOLTIP| x |
|quote/version/alternative/totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ALTTOTINCVAT: SR\_QUOTE\_QUOTEALTERNATIVE\_ALTTOTINCVAT\_TOOLTIP| x |
|quote/version/alternative/vatAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ALTVATAMT: SR\_QUOTE\_QUOTEALTERNATIVE\_ALTVATAMT\_TOOLTIP| x |
|quote/version/alternative/quoteline/quoteLineId|int|SR\_QUOTE\_QUOTELINE\_QUOTELINEID: SR\_QUOTE\_QUOTELINE\_QUOTELINEID\_TOOLTIP| x |
|quote/version/alternative/quoteline/quoteAlternativeId|int|SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID: SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID\_TOOLTIP| x |
|quote/version/alternative/quoteline/erpProductKey|string|SR\_QUOTE\_QUOTELINE\_PRODUCTKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTKEY\_TOOLTIP| x |
|quote/version/alternative/quoteline/rank|int|SR\_QUOTE\_QUOTELINE\_RANK: SR\_QUOTE\_QUOTELINE\_RANK\_TOOLTIP| x |
|quote/version/alternative/quoteline/quantity|decimal|SR\_QUOTE\_QUOTELINE\_QUANTITY: SR\_QUOTE\_QUOTELINE\_QUANTITY\_TOOLTIP| x |
|quote/version/alternative/quoteline/name|string|SR\_QUOTE\_QUOTELINE\_NAME: SR\_QUOTE\_QUOTELINE\_NAME\_TOOLTIP| x |
|quote/version/alternative/quoteline/description|string|SR\_QUOTE\_QUOTELINE\_DESCRIPTION: SR\_QUOTE\_QUOTELINE\_DESCRIPTION\_TOOLTIP| x |
|quote/version/alternative/quoteline/code|string|SR\_QUOTE\_QUOTELINE\_CODE: SR\_QUOTE\_QUOTELINE\_CODE\_TOOLTIP| x |
|quote/version/alternative/quoteline/quantityUnit|string|SR\_QUOTE\_QUOTELINE\_UNIT: SR\_QUOTE\_QUOTELINE\_UNIT\_TOOLTIP| x |
|quote/version/alternative/quoteline/priceUnit|string|SR\_QUOTE\_QUOTELINE\_PRICEUNIT: SR\_QUOTE\_QUOTELINE\_PRICEUNIT\_TOOLTIP| x |
|quote/version/alternative/quoteline/url|string|SR\_QUOTE\_QUOTELINE\_URL: SR\_QUOTE\_QUOTELINE\_URL\_TOOLTIP| x |
|quote/version/alternative/quoteline/subscriptionUnit|string|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT\_TOOLTIP| x |
|quote/version/alternative/quoteline/subscriptionQuantity|decimal|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY\_TOOLTIP| x |
|quote/version/alternative/quoteline/UnitListPriceSubscriptionQuantity| *None* |SR\_SUBSCRIPTIONLISTPRICE: SR\_SUBSCRIPTIONLISTPRICE\_TOOLTIP|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionUnit| *None* |SR\_PRICESUBUNIT: SR\_PRICESUBUNIT\_TOOLTIP|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionQuantityUnit| *None* |SR\_EXPANDEDUNIT: SR\_EXPANDEDUNIT\_TOOLTIP|  |
|quote/version/alternative/quoteline/vatInfo|string|SR\_QUOTE\_QUOTELINE\_VATINFO: SR\_QUOTE\_QUOTELINE\_VATINFO\_TOOLTIP| x |
|quote/version/alternative/quoteline/vat|decimal|SR\_QUOTE\_QUOTELINE\_VAT: SR\_QUOTE\_QUOTELINE\_VAT\_TOOLTIP| x |
|quote/version/alternative/quoteline/unitCost|decimal|SR\_QUOTE\_QUOTELINE\_UNITCOST: SR\_QUOTE\_QUOTELINE\_UNITCOST\_TOOLTIP| x |
|quote/version/alternative/quoteline/unitMinimumPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE: SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE\_TOOLTIP| x |
|quote/version/alternative/quoteline/unitListPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE: SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE\_TOOLTIP| x |
|quote/version/alternative/quoteline/totalPrice|decimal|SR\_QUOTE\_QUOTELINE\_TOTALPRICE: SR\_QUOTE\_QUOTELINE\_TOTALPRICE\_TOOLTIP| x |
|quote/version/alternative/quoteline/totalCost|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTALCOST|  |
|quote/version/alternative/quoteline/quoteLineThumbnail| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|quote/version/alternative/quoteline/quoteLineThumbnailLarge| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|quote/version/alternative/quoteline/discountAmount|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT\_TOOLTIP| x |
|quote/version/alternative/quoteline/discountPercent|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT\_TOOLTIP| x |
|quote/version/alternative/quoteline/earningAmount|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT: SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT\_TOOLTIP| x |
|quote/version/alternative/quoteline/earningPercent|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT: SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT\_TOOLTIP| x |
|quote/version/alternative/quoteline/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|quote/version/alternative/quoteline/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|quote/version/alternative/quoteline/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|quote/version/alternative/quoteline/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|quote/version/alternative/quoteline/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|quote/version/alternative/quoteline/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|quote/version/alternative/quoteline/productCategoryKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY\_TOOLTIP|  |
|quote/version/alternative/quoteline/productFamilyKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY\_TOOLTIP|  |
|quote/version/alternative/quoteline/productTypeKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY\_TOOLTIP|  |
|quote/version/alternative/quoteline/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|quote/version/alternative/quoteline/subTotal|decimal|SR\_QUOTE\_QUOTELINE\_SUBTOTAL: SR\_QUOTE\_QUOTELINE\_SUBTOTAL\_TOOLTIP| x |
|quote/version/alternative/quoteline/vatAmount|decimal|SR\_QUOTE\_QUOTELINE\_VATAMNT: SR\_QUOTE\_QUOTELINE\_VATAMNT\_TOOLTIP| x |
|quote/version/alternative/quoteline/totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCVAT: SR\_QUOTE\_QUOTELINE\_TOTINCVAT\_TOOLTIP| x |
|quote/version/alternative/quoteline/totalPriceWithAlternativeDiscount|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS: SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS\_TOOLTIP| x |
|selectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|selectionMemberId|int|SR\_SELECTIONMEMBER\_ID: SR\_SELECTIONMEMBER\_ID\_TOOLTIP|  |
|rowKind| *None* |SR\_SELECTION\_ROWKIND: SR\_SELECTION\_ROWKIND\_TOOLTIP|  |
|targetTableNumber|int|TargetTableNumber: TargetTableNumber| x |
|targetRecordId|int|TargetRecordId: TargetRecordId| x |

## Sample

```http!
GET /api/v1/archive/SaleSelectionCombined?$select=person/restrictionAddress/formattedAddress,person/correspondingAssociate/mrMrs,person/correspondingAssociate/ejUserId,contact/contactId,contact/orgnr
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


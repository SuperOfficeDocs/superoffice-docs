---
uid: Favourites
title: Favourites
description: Archive provider for the list of favourites
keywords: Favourites archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Favourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FavouritesProvider">SuperOffice.CRM.ArchiveLists.FavouritesProvider</see> inside NetServer's SODatabase assembly.

Archive provider for the list of favourites

## Supported Entities
| Name | Description |
| ---- | ----- |
|"sale"|[[SR_FAVOURITE_SALE]]|
|"contact"|[[SR_FAVOURITE_COMPANY]]|
|"person"|[[SR_FAVOURITE_PERSON]]|
|"project"|[[SR_FAVOURITE_PROJECT]]|
|"selection"|[[SR_FAVOURITE_SELECTION]]|
|"mailing"|[[SR_FAVOURITE_MAILING]]|
|"document"|[[SR_FAVOURITE_DOCUMENT]]|
|"appointment"|[[SR_FAVOURITE_APPOINTMENT]]|
|"ticket"|[[SR_FAVOURITE_TICKET]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|text|positiveString|SR\_SINGULAR\_FAVOURITE: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|currencyId| *None* |SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP|  |
|currency| *None* |SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP|  |
|credited| *None* |SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP|  |
|lossReason| *None* |SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP|  |
|source| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP|  |
|competitor| *None* |SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP|  |
|heading| *None* |SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP|  |
|amount| *None* |SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|amountWeighted| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|earning| *None* |SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP|  |
|earningPercent| *None* |SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP|  |
|probPercent| *None* |SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP|  |
|originalStage| *None* |SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED|  |
|stage| *None* |SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|saleStatus| *None* |SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP|  |
|stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP|  |
|saleType| *None* |SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|nextDueDate| *None* |SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP|  |
|reopenDate| *None* |SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP|  |
|stalledComment| *None* |SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP|  |
|saleTypeCategory| *None* |SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT|  |
|soldReason| *None* |SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP|  |
|saleNumber| *None* |SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER|  |
|hasStakeholders| *None* |SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP|  |
|stakeholdersEnabled| *None* |SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP|  |
|hasQuote| *None* |SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP|  |
|hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|description| *None* |SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|daysInStage| *None* |SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP|  |
|entityIcon| *None* |SR\_FAVOURITE\_ITEMICON: SR\_FAVOURITE\_ITEMICON| x |
|favouriteAssociateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|sale/textId| *None* |Text ID|  |
|sale/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|salePublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|salePublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|salePublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|saleUdef/SuperOffice:2| *None* |salelongtext|  |
|saleUdef/SuperOffice:3| *None* |salenumber|  |
|saleUdef/SuperOffice:4| *None* |saledate|  |
|saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|saleUdef/SuperOffice:8| *None* |saledecimal|  |
|name| *None* |SR\_COMPANY\_NAME|  |
|department| *None* |SR\_ARCHIVE\_DEPARTEMENT|  |
|nameDepartment| *None* |SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|hasInfoText| *None* |SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|hasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|category| *None* |SR\_ARCHIVE\_CATEGORY|  |
|categoryGroup| *None* |SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|companyCategoryRank| *None* |Category rank|  |
|business| *None* |SR\_ARCHIVE\_BUSINESS|  |
|country| *None* |SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|countryId| *None* |SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|number| *None* |SR\_ARCHIVE\_NUMBER|  |
|code| *None* |SR\_ARCHIVE\_CODE|  |
|orgnr| *None* |VAT No.|  |
|stop| *None* |SR\_CC\_STOPX|  |
|contactNoMail| *None* |SR\_NO\_MAIL\_COMPANY|  |
|contactSource| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|contactDeleted| *None* |SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|phone/formattedNumber| *None* |SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|deletedDate| *None* |SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|forceCompany| *None* |Dummy: Dummy|  |
|contactPhone/formattedNumber| *None* |SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contactPhone/description| *None* |SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|contactFax/formattedNumber| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contactFax/description| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|searchPhone/formattedNumber| *None* |SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|searchPhone/description| *None* |SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|email/emailProtocol| *None* |SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|email/emailAddress| *None* |SR\_ARCHIVE\_EMAIL|  |
|email/emailDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|email/emailId| *None* |ID|  |
|email/emailLastSent| *None* |SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|email/emailBounceCount| *None* |SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|email/emailLastBounce| *None* |SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|email/emailHasBounced| *None* |SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|postAddress/addressId| *None* |SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|postAddress/line1| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|postAddress/line2| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|postAddress/line3| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|postAddress/county| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|postAddress/city| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|postAddress/zip| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|postAddress/state| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|postAddress/wgs84latitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|postAddress/wgs84longitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|streetAddress/addressId| *None* |SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|streetAddress/line1| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|streetAddress/line2| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|streetAddress/line3| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|streetAddress/county| *None* |SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|streetAddress/city| *None* |SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|streetAddress/zip| *None* |SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|streetAddress/state| *None* |SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|streetAddress/wgs84latitude| *None* |SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|streetAddress/wgs84longitude| *None* |SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|streetAddress/formattedAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|streetAddress/formattedMultiLineAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/addressId| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|restrictionAddress/line1| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|restrictionAddress/line2| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|restrictionAddress/line3| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|restrictionAddress/county| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|restrictionAddress/city| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|restrictionAddress/zip| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|restrictionAddress/state| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|restrictionAddress/wgs84latitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|restrictionAddress/wgs84longitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|url/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|url/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|contactAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|contactAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|contactAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|contactAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|contactAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|contactAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|contactAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|contactAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|contactAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|contactAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|contactAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|contactAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|contactAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|contactAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|contactAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|contactAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|contactAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|contactAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|contactAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|contactAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|contactAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|contactAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|contactAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|contactAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|contactAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|contactAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|contactAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contactAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|contactAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|contactAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|contactAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|contactAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|contactInterestIds| *None* |SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|contactUdef/SuperOffice:3| *None* |companynumber|  |
|contactUdef/SuperOffice:4| *None* |companydate|  |
|contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|contactUdef/SuperOffice:8| *None* |companydecimal|  |
|contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|contactExtra/x\_contact\_integer| *None* |Extra Integer: Custom integer field|  |
|contactExtra/x\_contact\_hidden\_integer| *None* |Extra hidden integer: Custom integer field - hidden|  |
|contactExtra/x\_contact\_default\_integer| *None* |Extra Default Integer: Custom integer field with default value 123.|  |
|contactExtra/x\_contact\_float| *None* |Extra Float: Custom float field with 3 decimals|  |
|contactExtra/x\_contact\_longtext| *None* |Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|contactExtra/x\_contact\_dropdown| *None* |Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|contactExtra/x\_contact\_date| *None* |Extra date: Custom date field. User current as default.|  |
|contactExtra/x\_contact\_datetime| *None* |Extra DateTime: Custom Date Time field. No default value. External|  |
|contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.|  |
|contactExtra/x\_contact\_boolean| *None* |Extra boolean: Custom boolean field.|  |
|contactExtra/x\_contact\_timespan| *None* |Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|contactExtra/x\_contact\_shorttext| *None* |Extra short text: Custom short text field. Keep HTML tags.|  |
|contactExtra/x\_contact\_short\_dropdown| *None* |Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|contactExtra/x\_contact\_contact\_relation| *None* |Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|contactExtra/x\_contact\_request\_relation| *None* |Extra Request relation: Request relation on company|  |
|contactExtra/x\_contact\_contact| *None* |Extra contact relation: Contact relation on company|  |
|contactExtra/y\_organization/x\_name| *None* |Organization - Name: Name|  |
|NumberOfActivities| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|NumberOfActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|NumberOfNotCompletedActivities| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|LastActivity| *None* |SR\_ROU\_LAST\_ACTIVITY|  |
|LastCompletedActivity| *None* |SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|LastDoByActivity| *None* |SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|NumberOfSales| *None* |SR\_ROU\_NUMBER\_OF\_SALES|  |
|NumberOfSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|NumberOfNotCompletedSales| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|NumberOfNotCompletedSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|LastSale| *None* |SR\_ROU\_LAST\_SALE|  |
|LastCompletedSale| *None* |SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|LastDoBySale| *None* |SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|NumberOfTickets| *None* |SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|NumberOfTicketsInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|NumberOfNotCompletedTickets| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|NumberOfNotCompletedTicketsInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|LastTicket| *None* |SR\_ROU\_LAST\_TICKET|  |
|LastCompletedTicket| *None* |SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|LastDoByTicket| *None* |SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|SaintStatus1| *None* |Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|SaintStatus2| *None* |C-company: Kundens navn starter med bokstaven C|  |
|saintSaleStatus| *None* |SR\_WITH\_STATUS|  |
|saintAmountClass| *None* |SR\_AMOUNT\_CLASS|  |
|saintActivityType| *None* |SR\_ARCHIVE\_SAINT\_TYPE|  |
|saintDirection| *None* |SR\_ARCHIVE\_DIRECTION|  |
|saintIntention| *None* |SR\_ACTIVITY\_INTENTION|  |
|saintTicketStatus| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|saintTicketCategory| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|middleName| *None* |SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|fullName| *None* |SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|fullNameWithContact| *None* |SR\_PERSON\_NAMEWITHCONT: SR\_PERSON\_NAMEWITHCONT\_TOOLTIP|  |
|personHasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|position| *None* |SR\_ARCHIVE\_POSITION|  |
|personNumber| *None* |SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|personCountry| *None* |SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|personCountryId| *None* |SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|personNoMail| *None* |SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|rank| *None* |SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|birthdate| *None* |SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|associateType| *None* |SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|useAsMailingAddress| *None* |SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|personSource| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|retired| *None* |SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|birthYear| *None* |SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|birthMonth| *None* |SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|birthDay| *None* |SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|kanaFirstName| *None* |SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|kanaLastName| *None* |SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|personUpdatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personUpdatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personUpdatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|personRegisteredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personRegisteredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personRegisteredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personActiveErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|ticketPriority| *None* |SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|supportLanguage| *None* |SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|supportAssociate| *None* |SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|supportAssociateFullName| *None* |SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|personAssociateId| *None* |SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personAssociateFullName| *None* |SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personCategory| *None* |SR\_ARCHIVE\_CATEGORY|  |
|personCategoryGroup| *None* |SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|personCategoryRank| *None* |!!Category rank|  |
|personBusiness| *None* |SR\_ARCHIVE\_BUSINESS|  |
|leadStatus| *None* |SR\_LABEL\_LEADSTATUS|  |
|leadstatusRank| *None* |!!Lead status RANK|  |
|personDeletedDate| *None* |SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|hasCompany| *None* |SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|isProjectMember| *None* |SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|isStakeholder| *None* |SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|updatedByWorkflow| *None* |SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|whenUpdatedByWorkflow| *None* |SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|createdByForm| *None* |SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|favouritePersonAssociateId| *None* |SR\_FIELD\_PERSON\_ASSOCIATE\_ID\_NAME: SR\_FIELD\_PERSON\_ASSOCIATE\_ID\_TOOLTIP|  |
|emailAddress| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|personDirectPhone/formattedNumber| *None* |SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personDirectPhone/description| *None* |SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|personMobilePhone/formattedNumber| *None* |SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personMobilePhone/description| *None* |SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|personPrivate/formattedNumber| *None* |SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personPrivate/description| *None* |SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|personPager/formattedNumber| *None* |SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personPager/description| *None* |SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|personDirectFax/formattedNumber| *None* |SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personDirectFax/description| *None* |SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|personInfo/textId| *None* |Text ID|  |
|personInfo/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|personUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|personUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|personAddress/addressId| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|personAddress/line1| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|personAddress/line2| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|personAddress/line3| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|personAddress/county| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|personAddress/city| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|personAddress/zip| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|personAddress/state| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|personAddress/wgs84latitude| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|personAddress/wgs84longitude| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|personAddress/formattedAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|personAddress/formattedMultiLineAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|personInterestIds| *None* |SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|personUdef/SuperOffice:1| *None* |contactshorttext: tooltipshorttext|  |
|personUdef/SuperOffice:2| *None* |contactlongtext: tooltiplongtext|  |
|personUdef/SuperOffice:3| *None* |contactnumber|  |
|personUdef/SuperOffice:4| *None* |contactdate|  |
|personUdef/SuperOffice:5| *None* |contactunlimiteddate: tooltipunlimiteddate|  |
|personUdef/SuperOffice:6| *None* |contactcheckbox|  |
|personUdef/SuperOffice:7| *None* |contactdropdownlistbox|  |
|personUdef/SuperOffice:8| *None* |contactdecimal|  |
|personUdef/SuperOffice:9| *None* |page1saleonly|  |
|personUdef/SuperOffice:10| *None* |page1marketingonly|  |
|personUdef/SuperOffice:11| *None* |page1adminonly|  |
|personExtra/x\_person\_integer| *None* |Extra Integer: Custom person integer|  |
|personExtra/x\_person\_hidden\_integer| *None* |Extra hidden integer: Custom integer field that is hidden|  |
|personExtra/x\_person\_float| *None* |Extra float: Custom float field|  |
|personExtra/x\_person\_longtext| *None* |Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|personExtra/x\_person\_date| *None* |Extra date: Custom date field on person. Default value = 28.03.2019|  |
|personExtra/x\_person\_datetime| *None* |Extra DateTime: Custom person date and time field. No default|  |
|personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default|  |
|personExtra/x\_person\_boolean| *None* |Extra Boolean: Custom boolean field on person. Default checked|  |
|personExtra/x\_person\_timespan| *None* |Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|personExtra/x\_person\_shorttext| *None* |Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|personExtra/x\_person\_shorttext\_list| *None* |Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|personExtra/x\_person\_user\_relation| *None* |Extra user relation: Custom person-user relation field|  |
|personExtra/x\_person\_category\_relation| *None* |Extra category relation: Custom person-category relation|  |
|personExtra/x\_person\_priority\_relation| *None* |Extra priority relation: Custom person-priority relation|  |
|personExtra/x\_person\_request\_relation| *None* |Extra request relation: Request relation on contact|  |
|personExtra/x\_person\_appointment\_relation| *None* |Extra appointment relation: Appointment relation on person|  |
|personExtra/x\_person\_contact\_relation| *None* |Extra company relation: Company relation on contact|  |
|personExtra/y\_rental/id| *None* |Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)|  |
|personExtra/y\_rental/x\_start| *None* |Rental - Start rental: Start rental|  |
|personExtra/y\_rental/x\_end| *None* |Rental - End: End|  |
|personExtra/y\_rental/x\_amount| *None* |Rental - Amount: Number to rent. Default = 1|  |
|personExtra/y\_rental/x\_contact| *None* |Rental - Renter: Company that rents equipment|  |
|personExtra/y\_rental/y\_equipment/x\_name| *None* |Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|personExtra/y\_car/id| *None* |Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)|  |
|personAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|personAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|personAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|personAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|personAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|personAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|personAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|personAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|personAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|personAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|personAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|personAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|personAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|personAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|personAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|personAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|personAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|personAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|personAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|personAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|personAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|personAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|personAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|personAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|personAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|personAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|personAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|correspondingAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|correspondingAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|correspondingAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|correspondingAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|correspondingAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|correspondingAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|correspondingAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|correspondingAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|correspondingAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|correspondingAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|correspondingAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|correspondingAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|correspondingAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|correspondingAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|correspondingAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|correspondingAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|correspondingAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|correspondingAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|correspondingAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|correspondingAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|correspondingAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|correspondingAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|correspondingAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|correspondingAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|correspondingAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|correspondingAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|correspondingAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|correspondingAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|correspondingAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|correspondingAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|isMailingRecipient| *None* |SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient|  |
|hasStoreConsent| *None* |SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|withdrawnStoreConsent| *None* |SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|hasEmarketingConsent| *None* |SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|withdrawnEmarketingConsent| *None* |SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|subscription| *None* |SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP|  |
|legalBaseStore| *None* |SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|legalBaseEmarketing| *None* |SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|consentSourceStore| *None* |SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|consentSourceEmarketing| *None* |SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|status| *None* |SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP|  |
|statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP|  |
|nextMilestone| *None* |SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP|  |
|endDate| *None* |SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP|  |
|imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|eventId| *None* |SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID|  |
|startDate| *None* |SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP|  |
|project/textId| *None* |Text ID|  |
|project/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|selectionId| *None* |SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|kind| *None* |SR\_LABEL\_SELECTIONKIND: SR\_SEARCH\_KIND\_TOOLTIP|  |
|targetTableNumber| *None* |SR\_ARCHIVE\_SELECTION\_TYPE: SR\_ARCHIVE\_SELECTION\_TYPE\_TOOLTIP|  |
|combinationType| *None* |SR\_ARCHIVE\_SELECTION\_COMBINATION\_TYPE: SR\_ARCHIVE\_SELECTION\_COMBINATION\_TYPE\_TOOLTIP|  |
|done| *None* |SR\_ARCHIVE\_SELECTION\_COMPLETED: SR\_ARCHIVE\_SELECTION\_COMPLETED\_TOOLTIP|  |
|lastLoaded| *None* |SR\_SEL\_LASTLOADED: SR\_SEL\_LASTLOADED\_TOOLTIP|  |
|lastLoadedBy| *None* |SR\_SEL\_LASTLOADEDBY: SR\_SEL\_LASTLOADEDBY\_TOOLTIP|  |
|lastLoadedByFullName| *None* |SR\_SEL\_LASTLOADEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_SEL\_LASTLOADEDBY\_TOOLTIP|  |
|lastMembershipChange| *None* |SR\_SEL\_LASTMEMBERCHANGE: SR\_SEL\_LASTMEMBERCHANGE\_TOOLTIP|  |
|lastMembershipChangeBy| *None* |SR\_SEL\_LASTMEMBERCHANGEBY: SR\_SEL\_LASTMEMBERCHANGEBY\_TOOLTIP|  |
|lastMembershipChangeByFullName| *None* |SR\_SEL\_LASTMEMBERCHANGEBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_SEL\_LASTMEMBERCHANGEBY\_TOOLTIP|  |
|memberCount| *None* |SR\_SEL\_MEMBERCOUNT: SR\_SEL\_MEMBERCOUNT\_TOOLTIP|  |
|selectionAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|selectionAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|selectionAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|selectionAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|selectionAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|selectionAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|selectionAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|selectionAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|selectionAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|selectionAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|selectionAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|selectionAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|selectionAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|selectionAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|selectionAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|selectionAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|selectionAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|selectionAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|selectionAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|selectionAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|selectionAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|selectionAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|selectionAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|selectionAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|selectionAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|selectionAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|selectionAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|selectionAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|selectionAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|selectionAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|selectionAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|selectionAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|selectionAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|mailingId| *None* |SR\_ARCHIVE\_MAILING\_ID: SR\_ARCHIVE\_MAILING\_ID\_TOOLTIP|  |
|mailingSelectionId| *None* |SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|mailingDescription| *None* |SR\_ARCHIVE\_MAILING\_NAME: SR\_ARCHIVE\_MAILING\_NAME\_TOOLTIP|  |
|mailingSent| *None* |SR\_ARCHIVE\_MAILING\_SENT: SR\_ARCHIVE\_MAILING\_SENT\_TOOLTIP|  |
|mailingSimpleStatus| *None* |SR\_ARCHIVE\_MAILING\_STATUS: SR\_ARCHIVE\_MAILING\_STATUS|  |
|mailingEndDate| *None* |SR\_ARCHIVE\_MAILING\_END\_DATE: SR\_ARCHIVE\_MAILING\_END\_DATE\_TOOLTIP|  |
|mailingType| *None* |SR\_ARCHIVE\_MAILING\_TYPE: SR\_ARCHIVE\_MAILING\_TYPE\_TOOLTIP|  |
|mailingSubscriptionType| *None* |SR\_ARCHIVE\_MAILING\_SUBSCRIPTION\_TYPE: SR\_ARCHIVE\_MAILING\_SUBSCRIPTION\_TYPE\_TOOLTIP|  |
|mailingSentTo| *None* |SR\_ARCHIVE\_MAILING\_SENTTO: SR\_ARCHIVE\_MAILING\_SENTTO\_TOOLTIP|  |
|mailingOwner| *None* |SR\_ARCHIVE\_MAILING\_OWNER: SR\_ARCHIVE\_MAILING\_OWNER\_TOOLTIP|  |
|mailingFrom| *None* |SR\_ARCHIVE\_MAILING\_FROM: SR\_ARCHIVE\_MAILING\_FROM\_TOOLTIP|  |
|mailingReplyTo| *None* |SR\_ARCHIVE\_MAILING\_REPLY\_TO: SR\_ARCHIVE\_MAILING\_REPLY\_TO|  |
|mailingSentCount| *None* |SR\_ARCHIVE\_MAILING\_SENT\_COUNT: SR\_ARCHIVE\_MAILING\_SENT\_COUNT\_TOOLTIP|  |
|mailingOpenRate| *None* |SR\_ARCHIVE\_MAILING\_OPEN\_RATE: SR\_ARCHIVE\_MAILING\_OPEN\_RATE\_TOOLTIP|  |
|mailingClickRate| *None* |SR\_ARCHIVE\_MAILING\_CLICK\_THROUGH\_RATE: SR\_ARCHIVE\_MAILING\_CLICK\_THROUGH\_RATE\_TOOLTIP|  |
|mailingBounceRate| *None* |SR\_ARCHIVE\_MAILING\_BOUNCE\_RATE: SR\_ARCHIVE\_MAILING\_BOUNCE\_RATE\_TOOLTIP|  |
|mailingDeleted| *None* |SR\_LISTITEMARCHIVE\_DELETED: SR\_LISTITEMARCHIVE\_DELETED\_TOOLTIP|  |
|recipientStatus| *None* |SR\_ARCHIVE\_RECIPIENT\_STATUS: SR\_ARCHIVE\_RECIPIENT\_STATUS\_TOOLTIP|  |
|recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP|  |
|project/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP|  |
|project/projectId| *None* |SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP|  |
|project/name| *None* |SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP|  |
|project/number| *None* |SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP|  |
|project/type| *None* |SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP|  |
|project/status| *None* |SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP|  |
|project/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP|  |
|project/associateId| *None* |SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|project/hasInfoText| *None* |SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP|  |
|project/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|project/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|project/description| *None* |SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION|  |
|project/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|project/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|project/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|project/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|project/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|project/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|project/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|project/nextMilestone| *None* |SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP|  |
|project/endDate| *None* |SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP|  |
|project/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|project/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|project/eventId| *None* |SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID|  |
|project/startDate| *None* |SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP|  |
|project/projectPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|project/projectPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|project/projectPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|project/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|project/projectEvent/isExternalEvent| *None* |SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP|  |
|project/projectEvent/eventDate| *None* |SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP|  |
|project/projectEvent/hasSignOn| *None* |SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP|  |
|project/projectEvent/hasSignOff| *None* |SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP|  |
|project/projectUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|project/projectUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|project/projectAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|project/projectAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|project/projectAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|project/projectAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|project/projectAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|project/projectAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|project/projectAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|project/projectAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|project/projectAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|project/projectAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|project/projectAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|project/projectAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|project/projectAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|project/projectAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|project/projectAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|project/projectAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|project/projectAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|project/projectAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|project/projectAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|project/projectAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|project/projectAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|project/projectAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|project/projectAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|project/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|project/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|project/projectAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|project/projectAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|project/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|project/projectAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|project/projectAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|project/projectAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|project/projectAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|project/projectAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|project/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|project/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|project/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|project/projectUdef/SuperOffice:4| *None* |projectdate|  |
|project/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|project/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|project/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|project/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|project/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|project/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
|project/NumberOfActivities| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|project/NumberOfActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|project/NumberOfNotCompletedActivities| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|project/NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|project/LastActivity| *None* |SR\_ROU\_LAST\_ACTIVITY|  |
|project/LastCompletedActivity| *None* |SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|project/LastDoByActivity| *None* |SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|project/NumberOfSales| *None* |SR\_ROU\_NUMBER\_OF\_SALES|  |
|project/NumberOfSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|project/NumberOfNotCompletedSales| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|project/NumberOfNotCompletedSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|project/LastSale| *None* |SR\_ROU\_LAST\_SALE|  |
|project/LastCompletedSale| *None* |SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|project/LastDoBySale| *None* |SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|project/SaintStatus3| *None* |Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|project/saintSaleStatus| *None* |SR\_WITH\_STATUS|  |
|project/saintAmountClass| *None* |SR\_AMOUNT\_CLASS|  |
|project/saintActivityType| *None* |SR\_ARCHIVE\_SAINT\_TYPE|  |
|project/saintDirection| *None* |SR\_ARCHIVE\_DIRECTION|  |
|project/saintIntention| *None* |SR\_ACTIVITY\_INTENTION|  |
|project/saintTicketStatus| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|project/saintTicketCategory| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|project/project/textId| *None* |Text ID|  |
|project/project/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|documentId| *None* |SR\_DOCUMENT\_ID: SR\_DOCUMENT\_ID\_TOOLTIP|  |
|keywords| *None* |SR\_KEYWORDS|  |
|ourref| *None* |SR\_AA\_OURREF|  |
|yourref| *None* |SR\_ARCHIVE\_YOURREF|  |
|attention| *None* |SR\_ARCHIVE\_SALUTATION|  |
|subject| *None* |SR\_COMMON\_SUBJECT|  |
|mailMergeDraft| *None* |SR\_MAILMERGEDRAFT: SR\_DOCUMENT\_MMD\_TOOLTIP|  |
|snum| *None* |SR\_ARCHIVE\_DOCUMENT\_SNUM: SR\_ARCHIVE\_DOCUMENT\_SNUM\_TOOLTIP|  |
|isReport| *None* |SR\_DOCUMENTISREPORT: SR\_DOCUMENTISREPORT\_TOOLTIP|  |
|suggestedDocumentId| *None* |SR\_ARCHIVE\_SUGGESTEDDOCID: SR\_ARCHIVE\_SUGGESTEDDOCID\_TOOLTIP|  |
|isMail| *None* |SR\_SINGULAR\_MAIL|  |
|documentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|documentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|documentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|documentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|documentUdef/SuperOffice:1| *None* |documentshorttext|  |
|documentUdef/SuperOffice:2| *None* |documentlongtext|  |
|documentUdef/SuperOffice:3| *None* |documentnumber|  |
|documentUdef/SuperOffice:4| *None* |documentdate|  |
|documentUdef/SuperOffice:5| *None* |documentunlimiteddate|  |
|documentUdef/SuperOffice:6| *None* |documentcheckbox|  |
|documentUdef/SuperOffice:7| *None* |documentdropdownlistbox|  |
|documentUdef/SuperOffice:8| *None* |documentdecimal|  |
|document/textId| *None* |Text ID|  |
|document/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentId| *None* |SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP|  |
|priority| *None* |SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP|  |
|alarm| *None* |SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP|  |
|isFree| *None* |SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP|  |
|recurring| *None* |SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP|  |
|booking| *None* |SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP|  |
|intention| *None* |SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP|  |
|location| *None* |SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP|  |
|recurrenceRuleId| *None* |SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP|  |
|rawType| *None* |SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP|  |
|rawStatus| *None* |SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP|  |
|cautionWarning| *None* |SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP|  |
|visibleInDiary| *None* |SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP|  |
|endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|suggestedAppointmentId| *None* |SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP|  |
|completedDate| *None* |SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP|  |
|isMilestone| *None* |SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP|  |
|invitedPersonId| *None* |SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP|  |
|joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP|  |
|duration| *None* |SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|appointmentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|appointmentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|appointmentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|appointmentUdef/SuperOffice:1| *None* |followupshorttext|  |
|appointmentUdef/SuperOffice:2| *None* |followuplongtext|  |
|appointmentUdef/SuperOffice:3| *None* |followupnumber|  |
|appointmentUdef/SuperOffice:4| *None* |followupdate|  |
|appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate|  |
|appointmentUdef/SuperOffice:6| *None* |followupcheckbox|  |
|appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox|  |
|appointmentUdef/SuperOffice:8| *None* |followupdecimal|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/description| *None* |SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/title| *None* |SR\_TICKETARCHIVE\_TITLE|  |
|appointment/titleHtml| *None* |!!Title Html|  |
|appointment/agenda| *None* |SR\_APPOINTMENT\_AGENDA|  |
|appointment/agendaHtml| *None* |!!Agenda Html|  |
|appointment/isConverted| *None* |!!Is Converted|  |
|appointment/textId| *None* |Text ID|  |
|appointment/internalNotes| *None* |SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/internalNotesHtml| *None* |!!Internal Notes Html|  |
|ticketStatusId| *None* |SR\_TICKET\_STATUS\_ID: SR\_TICKET\_STATUS|  |
|priorityId| *None* |SR\_TICKET\_PRIORITY\_ID: SR\_TICKET\_PRIORITY\_ID\_TOOLTIP|  |
|categoryId| *None* |SR\_TICKET\_CATEGORY\_ID: SR\_TICKET\_CATEGORY\_ID\_TOOLTIP|  |
|ticketTypeName| *None* |SR\_TICKETARCHIVE\_TICKET\_TYPE: SR\_TICKETARCHIVE\_TICKET\_TYPE\_TOOLTIP|  |
|ticketStatusName| *None* |SR\_TICKETARCHIVE\_TICKETSTATUS: SR\_TICKETARCHIVE\_TICKETSTATUS\_TOOLTIP|  |
|categoryFullName| *None* |SR\_TICKETARCHIVE\_EJCATEGORY: SR\_TICKETARCHIVE\_EJCATEGORY\_TOOLTIP|  |
|priorityName| *None* |SR\_TICKETARCHIVE\_PRIORITY: SR\_TICKETARCHIVE\_PRIORITY\_TOOLTIP|  |
|ownedBy| *None* |SR\_TICKETARCHIVE\_OWNEDBY: SR\_TICKETARCHIVE\_OWNEDBY\_TOOLTIP|  |
|ticketId| *None* |SR\_TICKETARCHIVE\_TICKETID: SR\_TICKETARCHIVE\_TICKETID\_TOOLTIP|  |
|createdAt| *None* |SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP|  |
|createdDate| *None* |SR\_TICKETARCHIVE\_CREATEDDATE: SR\_TICKETARCHIVE\_CREATEDDATE|  |
|lastChanged| *None* |SR\_TICKETARCHIVE\_LASTCHANGED: SR\_TICKETARCHIVE\_LASTCHANGED\_TOOLTIP|  |
|author| *None* |SR\_TICKETARCHIVE\_AUTHOR: SR\_TICKETARCHIVE\_AUTHOR\_TOOLTIP|  |
|readByOwner| *None* |SR\_TICKETARCHIVE\_READBYOWNER: SR\_TICKETARCHIVE\_READBYOWNER\_TOOLTIP|  |
|firstReadByOwner| *None* |SR\_TICKETARCHIVE\_FIRSTREADBYOWNER: SR\_TICKETARCHIVE\_FIRSTREADBYOWNER\_TOOLTIP|  |
|firstReadByUser| *None* |SR\_TICKETARCHVE\_FIRSTREADBYUSER: SR\_TICKETARCHVE\_FIRSTREADBYUSER\_TOOLTIP|  |
|readByCustomer| *None* |SR\_TICKETARCHIVE\_READBYCUSTOMER: SR\_TICKETARCHIVE\_READBYCUSTOMER\_TOOLTIP|  |
|origin| *None* |SR\_TICKETARCHIVE\_ORIGIN: SR\_TICKETARCHIVE\_ORIGIN|  |
|slevel| *None* |SR\_TICKETARCHIVE\_SLEVEL: SR\_TICKETARCHIVE\_SLEVEL|  |
|numberOfMessages| *None* |SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES: SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES|  |
|numberOfReplies| *None* |SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES: SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES|  |
|connectId| *None* |SR\_TICKETARCHIVE\_CONNECTID: SR\_TICKETARCHIVE\_CONNECTID|  |
|readStatus| *None* |SR\_TICKETARCHIVE\_READSTATUS: SR\_TICKETARCHIVE\_READSTATUS|  |
|realTimeSpentQueue| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE|  |
|realTimeSpentExternally| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL|  |
|realTimeSpentInternally| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL|  |
|timeSpentQueue| *None* |SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE|  |
|timeSpentExternally| *None* |SR\_TICKETARCHIVE\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_TIME\_EXTERNAL|  |
|timeSpentInternally| *None* |SR\_TICKETARCHIVE\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_TIME\_INTERNAL|  |
|timeSpent| *None* |SR\_TICKETARCHIVE\_TIME\_SPENT: SR\_TICKETARCHIVE\_TIME\_SPENT|  |
|timeToReply| *None* |SR\_TICKETARCHIVE\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_TIME\_TO\_REPLY|  |
|timeToClose| *None* |SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE|  |
|realTimeToReply| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY|  |
|realTimeToClose| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE|  |
|repliedAt| *None* |SR\_TICKETARCHIVE\_REPLIED\_AT: SR\_TICKETARCHIVE\_REPLIED\_AT|  |
|closedAt| *None* |SR\_TICKETARCHIVE\_CLOSED\_AT: SR\_TICKETARCHIVE\_CLOSED\_AT|  |
|activated| *None* |SR\_TICKETARCHIVE\_POSTPONED\_TO: SR\_TICKETARCHIVE\_POSTPONED\_TO|  |
|deadline| *None* |SR\_TICKETARCHIVE\_DEADLINE: SR\_TICKETARCHIVE\_DEADLINE|  |
|has\_attachment| *None* |SR\_TICKETARCHIVE\_HAS\_ATTACHMENT: SR\_INBOX\_ATTACHMENT\_TOOLTIP|  |
|tags| *None* |SR\_TICKETARCHIVE\_TAGS: SR\_TICKETARCHIVE\_TAGS\_TOOLTIP|  |
|createdBy| *None* |SR\_TICKETARCHIVE\_CREATEDBY: SR\_TICKETARCHIVE\_CREATEDBY|  |
|content| *None* |SR\_ARCHIVE\_CONTENT: SR\_ARCHIVE\_CONTENT\_TOOLTIP|  |
|messageLanguage| *None* |SR\_TICKETARCHIVE\_LANGUAGE: SR\_TICKETARCHIVE\_LANGUAGE\_TOOLTIP|  |
|sentimentScore| *None* |SR\_TICKETARCHIVE\_SENTIMENT: SR\_TICKETARCHIVE\_SENTIMENT\_TOOLTIP|  |
|sentimentConfidence| *None* |SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE: SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE|  |
|suggestedCategory| *None* |SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY: SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY\_TOOLTIP|  |
|createdBy/firstName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|createdBy/lastName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|createdBy/middleName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|createdBy/fullName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|createdBy/contactId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|createdBy/personId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|createdBy/mrMrs| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|createdBy/title| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|createdBy/associateDbId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|createdBy/contactName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|createdBy/contactDepartment| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|createdBy/usergroup| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|createdBy/usergroupId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|createdBy/contactFullName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|createdBy/contactCategory| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|createdBy/role| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|createdBy/assocName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|createdBy/assocTooltip| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|createdBy/assocType| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|createdBy/ejUserId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|createdBy/simultaneousEjUser| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|createdBy/ejDisplayName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|createdBy/ejStatus| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|createdBy/credentialType| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|createdBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|createdBy/isActive| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|createdBy/isActiveText| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|createdBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|createdBy/otherGroups| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|createdBy/userName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|createdBy/personEmail| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_EMAIL|  |
|createdBy/locationAddress| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|createdBy/isLocation| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|ownedBy/firstName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|ownedBy/lastName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|ownedBy/middleName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|ownedBy/fullName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|ownedBy/contactId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ownedBy/personId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ownedBy/mrMrs| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|ownedBy/title| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|ownedBy/associateDbId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|ownedBy/contactName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|ownedBy/contactDepartment| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ownedBy/usergroup| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|ownedBy/usergroupId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|ownedBy/contactFullName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|ownedBy/contactCategory| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|ownedBy/role| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|ownedBy/assocName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|ownedBy/assocTooltip| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ownedBy/assocType| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|ownedBy/ejUserId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|ownedBy/simultaneousEjUser| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ownedBy/ejDisplayName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|ownedBy/ejStatus| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ownedBy/credentialType| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|ownedBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|ownedBy/isActive| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|ownedBy/isActiveText| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|ownedBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ownedBy/otherGroups| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ownedBy/userName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|ownedBy/personEmail| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_EMAIL|  |
|ownedBy/locationAddress| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|ownedBy/isLocation| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|ticketStatus/ticketStatusId| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_ID: SR\_TICKETARCHIVE\_TICKETSTATUS\_ID\_TOOLTIP|  |
|ticketStatus/name| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME: SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME\_TOOLTIP|  |
|ticketStatus/rank| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK: SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK\_TOOLTIP|  |
|ticketPriority/ticketPriorityId| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_ID: SR\_TICKETARCHIVE\_PRIORITY\_ID\_TOOLTIP|  |
|ticketPriority/name| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_NAME: SR\_TICKETARCHIVE\_PRIORITY\_NAME\_TOOLTIP|  |
|ticketPriority/rank| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_RANK: SR\_TICKETARCHIVE\_PRIORITY\_RANK\_TOOLTIP|  |
|extra/x\_ticket\_integer| *None* |Extra integer: Custom ticket integer. Default 123. External. Show in properties|  |
|extra/x\_ticket\_float| *None* |Extra float: Custom float on Request. 2 decimal places|  |
|extra/x\_ticket\_longtext| *None* |Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props|  |
|extra/x\_ticket\_date| *None* |Extra date: Custom date field on Request. No default value|  |
|extra/x\_ticket\_datetime| *None* |Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request|  |
|extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.|  |
|extra/x\_ticket\_boolean| *None* |Extra boolean: Custom boolean on Ticket.|  |
|extra/x\_ticket\_timespan| *None* |Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props|  |
|extra/x\_ticket\_short\_text| *None* |Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request|  |
|extra/x\_ticket\_shorttext\_list| *None* |Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot|  |
|extra/x\_ticket\_timestamp| *None* |Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field|  |
|extra/x\_ticket\_project\_relation| *None* |Extra project: Custom project relation on Request|  |
|extra/x\_ticket\_faq| *None* |Extra FAQ Relation: Extra FAQ Relation|  |
|extra/x\_ticket\_category\_relation| *None* |Extra category relation: Category relation on request|  |
|extra/y\_equipment/x\_name| *None* |Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|extra/y\_car/id| *None* |Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)|  |

## Sample

```http!
GET /api/v1/archive/Favourites?$select=restrictionAddress/addressId,contactExtra/x_contact_longtext,personAddress/line3,personAddress/formattedAddress,personExtra/x_person_longtext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


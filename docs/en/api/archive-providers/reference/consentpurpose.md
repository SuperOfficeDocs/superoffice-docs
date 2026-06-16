---
uid: ConsentPurpose
title: ConsentPurpose
description: This is the archive Consent Purpose Provider for GDPR Admin
keywords: ConsentPurpose archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ConsentPurpose"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ConsentPurposeProvider">SuperOffice.CRM.ArchiveLists.ConsentPurposeProvider</see> inside NetServer's SODatabase assembly.

This is the archive Consent Purpose Provider for GDPR Admin
and for GDPR relations to person, if you join and restrict on person

## Supported Entities
| Name | Description |
| ---- | ----- |
|"consentPurpose"|[[SR_CONSENT_PURPOSE]]|
|"deletedConsentPurpose"|[[SR_ARCHIVE_DELETED]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|consentPurposeId|int|SR\_CONSENT\_PURPOSE\_ID: SR\_CONSENT\_PURPOSE\_ID\_TOOLTIP| x |
|active|bool|SR\_CONSENT\_PURPOSE\_ACTIVE: SR\_CONSENT\_PURPOSE\_ACTIVE\_TOOLTIP| x |
|key|string|SR\_CONSENT\_PURPOSE\_KEY: SR\_CONSENT\_PURPOSE\_KEY\_TOOLTIP| x |
|name|string|SR\_CONSENT\_PURPOSE\_NAME: SR\_CONSENT\_PURPOSE\_NAME\_TOOLTIP| x |
|tooltip|string|SR\_LISTITEMARCHIVE\_TOOLTIP: SR\_CONSENT\_PURPOSE\_DESCRIPTION\_TOOLTIP| x |
|privacyStatementDescription|string|SR\_CONSENT\_PURPOSE\_PRIV\_DESC: SR\_CONSENT\_PURPOSE\_PRIV\_DESC\_TOOLTIP| x |
|privacyStatementUrl|string|SR\_CONSENT\_PURPOSE\_PRIV\_URL: SR\_CONSENT\_PURPOSE\_PRIV\_URL\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|rank|int|Rank| x |
|consentPerson/consentPersonId|int|SR\_CONSENT\_PERSON\_ID: SR\_CONSENT\_PERSON\_ID\_TOOLTIP| x |
|consentPerson/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|consentPerson/active|bool|SR\_CONSENT\_PERSON\_ACTIVE: SR\_CONSENT\_PERSON\_ACTIVE\_TOOLTIP| x |
|consentPerson/legalBase|listAny|SR\_LEGALBASE: SR\_LEGALBASE\_TOOLTIP| x |
|consentPerson/consentSource|listAny|SR\_CONSENTSOURCE: SR\_CONSENTSOURCE\_TOOLTIP| x |
|consentPerson/comment|string|SR\_CONSENT\_COMMENT: SR\_CONSENT\_COMMENT\_TOOLTIP| x |
|consentPerson/hasComment|bool|SR\_CONSENT\_HAS\_COMMENT: SR\_CONSENT\_HAS\_COMMENT\_TOOLTIP| x |
|consentPerson/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|consentPerson/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|consentPerson/person/personId|int|SR\_PERSON - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|consentPerson/person/firstName|string|SR\_PERSON - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|consentPerson/person/lastName|string|SR\_PERSON - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|consentPerson/person/middleName|string|SR\_PERSON - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|consentPerson/person/fullName|string|SR\_PERSON - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|consentPerson/person/contactId|int|SR\_PERSON - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|consentPerson/person/hasInfoText|bool|SR\_PERSON - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|consentPerson/person/hasInterests|bool|SR\_PERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|consentPerson/person/personHasInterests|bool|SR\_PERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|consentPerson/person/mrMrs|string|SR\_PERSON - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|consentPerson/person/position|listAny|SR\_PERSON - SR\_ARCHIVE\_POSITION| x |
|consentPerson/person/personNumber|string|SR\_PERSON - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|consentPerson/person/title|string|SR\_PERSON - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|consentPerson/person/personCountry|listAny|SR\_PERSON - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|consentPerson/person/personCountryId|int|SR\_PERSON - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|consentPerson/person/personNoMail|bool|SR\_PERSON - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|consentPerson/person/rank|int|SR\_PERSON - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|consentPerson/person/birthdate| *None* |SR\_PERSON - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|consentPerson/person/associateType| *None* |SR\_PERSON - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|consentPerson/person/useAsMailingAddress|bool|SR\_PERSON - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|consentPerson/person/personSource|listAny|SR\_PERSON - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|consentPerson/person/retired|bool|SR\_PERSON - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|consentPerson/person/birthYear|int|SR\_PERSON - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|consentPerson/person/birthMonth|int|SR\_PERSON - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|consentPerson/person/birthDay|int|SR\_PERSON - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|consentPerson/person/kanaFirstName|string|SR\_PERSON - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|consentPerson/person/kanaLastName|string|SR\_PERSON - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|consentPerson/person/personUpdatedBy|associate|SR\_PERSON - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|consentPerson/person/personUpdatedByFullName|associate|SR\_PERSON - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|consentPerson/person/personUpdatedDate|date|SR\_PERSON - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|consentPerson/person/personRegisteredBy|associate|SR\_PERSON - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|consentPerson/person/personRegisteredByFullName|associate|SR\_PERSON - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|consentPerson/person/personRegisteredDate|date|SR\_PERSON - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|consentPerson/person/portraitThumbnail| *None* |SR\_PERSON - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|consentPerson/person/personActiveErpLinks|bool|SR\_PERSON - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|consentPerson/person/ticketPriority|listAny|SR\_PERSON - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|consentPerson/person/supportLanguage|listAny|SR\_PERSON - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|consentPerson/person/supportAssociate|associate|SR\_PERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|consentPerson/person/supportAssociateFullName|associate|SR\_PERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|consentPerson/person/personAssociateId|associate|SR\_PERSON - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|consentPerson/person/personAssociateFullName|associate|SR\_PERSON - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|consentPerson/person/personCategory|listAny|SR\_PERSON - SR\_ARCHIVE\_CATEGORY| x |
|consentPerson/person/personCategoryGroup|listAny|SR\_PERSON - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|consentPerson/person/personCategoryRank|int|SR\_PERSON - !!Category rank| x |
|consentPerson/person/personBusiness|listAny|SR\_PERSON - SR\_ARCHIVE\_BUSINESS| x |
|consentPerson/person/leadStatus|listAny|SR\_PERSON - SR\_LABEL\_LEADSTATUS| x |
|consentPerson/person/leadstatusRank|int|SR\_PERSON - !!Lead status RANK| x |
|consentPerson/person/personDeletedDate|datetime|SR\_PERSON - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|consentPerson/person/hasCompany|bool|SR\_PERSON - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|consentPerson/person/isProjectMember|bool|SR\_PERSON - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|consentPerson/person/isStakeholder|bool|SR\_PERSON - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|consentPerson/person/updatedByWorkflow|listAny|SR\_PERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|consentPerson/person/whenUpdatedByWorkflow|datetime|SR\_PERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|consentPerson/person/createdByForm|listAny|SR\_PERSON - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|consentPerson/person/phone/formattedNumber|string|SR\_PERSON - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|consentPerson/person/personDirectPhone/formattedNumber|string|SR\_PERSON - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|consentPerson/person/personDirectPhone/description|string|SR\_PERSON - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|consentPerson/person/personMobilePhone/formattedNumber|string|SR\_PERSON - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|consentPerson/person/personMobilePhone/description|string|SR\_PERSON - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|consentPerson/person/personPrivate/formattedNumber|string|SR\_PERSON - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|consentPerson/person/personPrivate/description|string|SR\_PERSON - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|consentPerson/person/personPager/formattedNumber|string|SR\_PERSON - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|consentPerson/person/personPager/description|string|SR\_PERSON - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|consentPerson/person/personDirectFax/formattedNumber|string|SR\_PERSON - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|consentPerson/person/personDirectFax/description|string|SR\_PERSON - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|consentPerson/person/personInfo/textId|int|SR\_PERSON - Text ID| x |
|consentPerson/person/personInfo/infoText|positiveString|SR\_PERSON - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|consentPerson/person/email/emailProtocol|string|SR\_PERSON - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|consentPerson/person/email/emailAddress|string|SR\_PERSON - SR\_ARCHIVE\_EMAIL| x |
|consentPerson/person/email/emailDescription|string|SR\_PERSON - SR\_ARCHIVE\_DESCRIPTION| x |
|consentPerson/person/email/emailId|int|SR\_PERSON - ID| x |
|consentPerson/person/email/emailLastSent|datetime|SR\_PERSON - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|consentPerson/person/email/emailBounceCount|int|SR\_PERSON - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|consentPerson/person/email/emailLastBounce|datetime|SR\_PERSON - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|consentPerson/person/email/emailHasBounced|bool|SR\_PERSON - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|consentPerson/person/personUrl/URLAddress|string|SR\_PERSON - SR\_PROJECTARCHIVE\_URL| x |
|consentPerson/person/personUrl/URLDescription|string|SR\_PERSON - SR\_ARCHIVE\_DESCRIPTION| x |
|consentPerson/person/personAddress/addressId|int|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|consentPerson/person/personAddress/line1|string|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|consentPerson/person/personAddress/line2|string|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|consentPerson/person/personAddress/line3|string|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|consentPerson/person/personAddress/county|string|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|consentPerson/person/personAddress/city|string|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|consentPerson/person/personAddress/zip|string|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|consentPerson/person/personAddress/state|string|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|consentPerson/person/personAddress/wgs84latitude|decimal|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|consentPerson/person/personAddress/wgs84longitude|decimal|SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|consentPerson/person/personAddress/formattedAddress| *None* |SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|consentPerson/person/personAddress/formattedMultiLineAddress| *None* |SR\_PERSON - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|consentPerson/person/personUdef/SuperOffice:1|string|SR\_PERSON - contactshorttext: tooltipshorttext| x |
|consentPerson/person/personUdef/SuperOffice:2|string|SR\_PERSON - contactlongtext: tooltiplongtext| x |
|consentPerson/person/personUdef/SuperOffice:3|int|SR\_PERSON - contactnumber| x |
|consentPerson/person/personUdef/SuperOffice:4|date|SR\_PERSON - contactdate| x |
|consentPerson/person/personUdef/SuperOffice:5|unlimitedDate|SR\_PERSON - contactunlimiteddate: tooltipunlimiteddate| x |
|consentPerson/person/personUdef/SuperOffice:6|bool|SR\_PERSON - contactcheckbox| x |
|consentPerson/person/personUdef/SuperOffice:7|listAny|SR\_PERSON - contactdropdownlistbox| x |
|consentPerson/person/personUdef/SuperOffice:8|decimal|SR\_PERSON - contactdecimal| x |
|consentPerson/person/personUdef/SuperOffice:9|string|SR\_PERSON - page1saleonly| x |
|consentPerson/person/personUdef/SuperOffice:10|string|SR\_PERSON - page1marketingonly| x |
|consentPerson/person/personUdef/SuperOffice:11|string|SR\_PERSON - page1adminonly| x |
|consentPerson/person/personExtra/x\_person\_integer|int|SR\_PERSON - Extra Integer: Custom person integer| x |
|consentPerson/person/personExtra/x\_person\_hidden\_integer|int|SR\_PERSON - Extra hidden integer: Custom integer field that is hidden| x |
|consentPerson/person/personExtra/x\_person\_float|decimal|SR\_PERSON - Extra float: Custom float field| x |
|consentPerson/person/personExtra/x\_person\_longtext|string|SR\_PERSON - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|consentPerson/person/personExtra/x\_person\_date|date|SR\_PERSON - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|consentPerson/person/personExtra/x\_person\_datetime|datetime|SR\_PERSON - Extra DateTime: Custom person date and time field. No default| x |
|consentPerson/person/personExtra/x\_person\_time| *None* |SR\_PERSON - Extra time: Custom time field on person. Current time as default| x |
|consentPerson/person/personExtra/x\_person\_boolean|bool|SR\_PERSON - Extra Boolean: Custom boolean field on person. Default checked| x |
|consentPerson/person/personExtra/x\_person\_timespan|timeSpan|SR\_PERSON - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|consentPerson/person/personExtra/x\_person\_shorttext|string|SR\_PERSON - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|consentPerson/person/personExtra/x\_person\_shorttext\_list|listAny|SR\_PERSON - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|consentPerson/person/personExtra/x\_person\_user\_relation|associate|SR\_PERSON - Extra user relation: Custom person-user relation field| x |
|consentPerson/person/personExtra/x\_person\_category\_relation|listAny|SR\_PERSON - Extra category relation: Custom person-category relation| x |
|consentPerson/person/personExtra/x\_person\_priority\_relation|listAny|SR\_PERSON - Extra priority relation: Custom person-priority relation| x |
|consentPerson/person/personExtra/x\_person\_request\_relation|stringorPK|SR\_PERSON - Extra request relation: Request relation on contact| x |
|consentPerson/person/personExtra/x\_person\_appointment\_relation|stringorPK|SR\_PERSON - Extra appointment relation: Appointment relation on person| x |
|consentPerson/person/personExtra/x\_person\_contact\_relation|stringorPK|SR\_PERSON - Extra company relation: Company relation on contact| x |
|consentPerson/person/personExtra/y\_rental/id|int|SR\_PERSON - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|consentPerson/person/personExtra/y\_rental/x\_start|date|SR\_PERSON - Rental - Start rental: Start rental| x |
|consentPerson/person/personExtra/y\_rental/x\_end|date|SR\_PERSON - Rental - End: End| x |
|consentPerson/person/personExtra/y\_rental/x\_amount|int|SR\_PERSON - Rental - Amount: Number to rent. Default = 1| x |
|consentPerson/person/personExtra/y\_rental/x\_contact|stringorPK|SR\_PERSON - Rental - Renter: Company that rents equipment| x |
|consentPerson/person/personExtra/y\_rental/y\_equipment/x\_name|string|SR\_PERSON - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|consentPerson/person/personExtra/y\_car/id|int|SR\_PERSON - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|consentPerson/consentPurpose/consentPurposeId|int|SR\_CONSENTPURPOSE - SR\_CONSENT\_PURPOSE\_ID: SR\_CONSENT\_PURPOSE\_ID\_TOOLTIP| x |
|consentPerson/consentPurpose/active|bool|SR\_CONSENTPURPOSE - SR\_CONSENT\_PURPOSE\_ACTIVE: SR\_CONSENT\_PURPOSE\_ACTIVE\_TOOLTIP| x |
|consentPerson/consentPurpose/key|string|SR\_CONSENTPURPOSE - SR\_CONSENT\_PURPOSE\_KEY: SR\_CONSENT\_PURPOSE\_KEY\_TOOLTIP| x |
|consentPerson/consentPurpose/name|string|SR\_CONSENTPURPOSE - SR\_CONSENT\_PURPOSE\_NAME: SR\_CONSENT\_PURPOSE\_NAME\_TOOLTIP| x |
|consentPerson/consentPurpose/tooltip|string|SR\_CONSENTPURPOSE - SR\_LISTITEMARCHIVE\_TOOLTIP: SR\_CONSENT\_PURPOSE\_DESCRIPTION\_TOOLTIP| x |
|consentPerson/consentPurpose/privacyStatementDescription|string|SR\_CONSENTPURPOSE - SR\_CONSENT\_PURPOSE\_PRIV\_DESC: SR\_CONSENT\_PURPOSE\_PRIV\_DESC\_TOOLTIP| x |
|consentPerson/consentPurpose/privacyStatementUrl|string|SR\_CONSENTPURPOSE - SR\_CONSENT\_PURPOSE\_PRIV\_URL: SR\_CONSENT\_PURPOSE\_PRIV\_URL\_TOOLTIP| x |
|consentPerson/consentPurpose/updatedBy|associate|SR\_CONSENTPURPOSE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|consentPerson/consentPurpose/updatedDate|date|SR\_CONSENTPURPOSE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|consentPerson/consentPurpose/rank|int|SR\_CONSENTPURPOSE - Rank| x |

## Sample

```http!
GET /api/v1/archive/ConsentPurpose?$select=consentPerson/person/personNoMail,consentPerson/person/birthDay,consentPerson/person/personRegisteredBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


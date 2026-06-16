---
uid: PersonRelation
title: PersonRelation
description: Data provider class for the 'Relation' archive under the person card. This class combines output from
keywords: PersonRelation archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "PersonRelation"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.PersonRelation">SuperOffice.CRM.ArchiveLists.PersonRelation</see> inside NetServer's SODatabase assembly.

Data provider class for the 'Relation' archive under the person card. This class combines output from
the eight basic sub-providers (CC, PC, PP and CP plus their reversed cousins) into one data stream.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"relation"|Relation|
|"retired"|[[SR_PA_RETIRED_PERSONS]]|
|"stop"|[[SR_RELATIONARCHIVE_STOPPEDCONTACTS]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|relationName|string|SR\_RELATION\_RAWNAME: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|relationComment|string|SR\_RELATION\_COMMENT: SR\_RELATION\_COMMENT\_TOOLTIP| x |
|reversedName|string|SR\_ADMIN\_RELATION\_PASSIVE\_LEAD: SR\_REVERSED\_RELATION\_TOOLTIP| x |
|processedName| *None* |SR\_RA\_HASRELATION: SR\_RA\_HASRELATION\_TOOLTIP|  |
|relationId|int|SR\_RELATION\_ID: SR\_RELATION\_ID\_TOOLTIP| x |
|relationDefinitionId|int|SR\_RELATION\_DEFINITION\_ID: SR\_RELATION\_DEFINITION\_ID\_TOOLTIP| x |
|direction|int|SR\_ARCHIVE\_DIRECTION: SR\_RELATION\_DIRECTION\_TOOLTIP| x |
|associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|source/personId| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|source/firstName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|source/lastName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|source/middleName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|source/fullName| *None* |SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|source/fullNameWithContact| *None* |SR\_RELATION\_SOURCE - SR\_PERSON\_NAMEWITHCONT: SR\_PERSON\_NAMEWITHCONT\_TOOLTIP|  |
|source/contactId|int|SR\_RELATION\_SOURCE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|source/hasInfoText|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|source/hasInterests|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|source/personHasInterests| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|source/mrMrs| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|source/position| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_POSITION|  |
|source/personNumber| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|source/title| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|source/personCountry| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|source/personCountryId| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|source/personNoMail| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|source/rank| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|source/birthdate| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|source/associateType| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|source/useAsMailingAddress| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|source/personSource| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|source/retired| *None* |SR\_RELATION\_SOURCE - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|source/birthYear| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|source/birthMonth| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|source/birthDay| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|source/kanaFirstName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|source/kanaLastName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|source/personUpdatedBy| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|source/personUpdatedByFullName| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|source/personUpdatedDate| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|source/personRegisteredBy| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|source/personRegisteredByFullName| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|source/personRegisteredDate| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|source/portraitThumbnail| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|source/personActiveErpLinks| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|source/ticketPriority| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|source/supportLanguage| *None* |SR\_RELATION\_SOURCE - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|source/supportAssociate| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|source/supportAssociateFullName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|source/personAssociateId| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|source/personAssociateFullName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|source/personCategory| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY|  |
|source/personCategoryGroup| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|source/personCategoryRank| *None* |SR\_RELATION\_SOURCE - !!Category rank|  |
|source/personBusiness| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BUSINESS|  |
|source/leadStatus| *None* |SR\_RELATION\_SOURCE - SR\_LABEL\_LEADSTATUS|  |
|source/leadstatusRank| *None* |SR\_RELATION\_SOURCE - !!Lead status RANK|  |
|source/personDeletedDate| *None* |SR\_RELATION\_SOURCE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|source/hasCompany| *None* |SR\_RELATION\_SOURCE - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|source/isProjectMember| *None* |SR\_RELATION\_SOURCE - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|source/isStakeholder| *None* |SR\_RELATION\_SOURCE - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|source/updatedByWorkflow| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|source/whenUpdatedByWorkflow| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|source/createdByForm| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|source/phone/formattedNumber|string|SR\_RELATION\_SOURCE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/restrictionContactId|int|SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|source/restrictionPersonId| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|source/who| *None* |SR\_RELATION\_SOURCE - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|source/personDirectPhone/formattedNumber| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/personDirectPhone/description| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|source/personMobilePhone/formattedNumber| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/personMobilePhone/description| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|source/personPrivate/formattedNumber| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/personPrivate/description| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|source/personPager/formattedNumber| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/personPager/description| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|source/personDirectFax/formattedNumber| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/personDirectFax/description| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|source/name|stringorPK|SR\_RELATION\_SOURCE - SR\_COMPANY\_NAME| x |
|source/department|string|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DEPARTEMENT| x |
|source/nameDepartment|string|SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|source/associateId|associate|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|source/category|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY| x |
|source/categoryGroup|listAny|SR\_RELATION\_SOURCE - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|source/companyCategoryRank|int|SR\_RELATION\_SOURCE - Category rank| x |
|source/business|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BUSINESS| x |
|source/country|listAny|SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|source/countryId|int|SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|source/number|string|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_NUMBER| x |
|source/code|string|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CODE| x |
|source/orgnr|string|SR\_RELATION\_SOURCE - VAT No.| x |
|source/stop|bool|SR\_RELATION\_SOURCE - SR\_CC\_STOPX| x |
|source/contactNoMail|bool|SR\_RELATION\_SOURCE - SR\_NO\_MAIL\_COMPANY| x |
|source/updatedBy|associate|SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|source/updatedByFullName|associate|SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|source/updatedDate|date|SR\_RELATION\_SOURCE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|source/registeredBy|associate|SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|source/registeredByFullName|associate|SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|source/registeredDate|date|SR\_RELATION\_SOURCE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|source/contactSource|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|source/contactDeleted|bool|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|source/activeErpLinks|bool|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|source/deletedDate|datetime|SR\_RELATION\_SOURCE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|source/mainContact| *None* |SR\_RELATION\_SOURCE - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|source/forceCompany|bool|SR\_RELATION\_SOURCE - Dummy: Dummy|  |
|source/contactPhone/formattedNumber|string|SR\_RELATION\_SOURCE - SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/contactPhone/description|string|SR\_RELATION\_SOURCE - SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|target/contactId|int|SR\_RELATION\_TARGET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|target/name|stringorPK|SR\_RELATION\_TARGET - SR\_COMPANY\_NAME| x |
|target/department|string|SR\_RELATION\_TARGET - SR\_ARCHIVE\_DEPARTEMENT| x |
|target/nameDepartment|string|SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|target/hasInfoText|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|target/hasInterests|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|target/associateId|associate|SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|target/category|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY| x |
|target/categoryGroup|listAny|SR\_RELATION\_TARGET - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|target/companyCategoryRank|int|SR\_RELATION\_TARGET - Category rank| x |
|target/business|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_BUSINESS| x |
|target/country|listAny|SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|target/countryId|int|SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|target/number|string|SR\_RELATION\_TARGET - SR\_ARCHIVE\_NUMBER| x |
|target/code|string|SR\_RELATION\_TARGET - SR\_ARCHIVE\_CODE| x |
|target/orgnr|string|SR\_RELATION\_TARGET - VAT No.| x |
|target/stop|bool|SR\_RELATION\_TARGET - SR\_CC\_STOPX| x |
|target/contactNoMail|bool|SR\_RELATION\_TARGET - SR\_NO\_MAIL\_COMPANY| x |
|target/updatedBy|associate|SR\_RELATION\_TARGET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|target/updatedByFullName|associate|SR\_RELATION\_TARGET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|target/updatedDate|date|SR\_RELATION\_TARGET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|target/registeredBy|associate|SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|target/registeredByFullName|associate|SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|target/registeredDate|date|SR\_RELATION\_TARGET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|target/contactSource|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|target/contactDeleted|bool|SR\_RELATION\_TARGET - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|target/phone/formattedNumber|string|SR\_RELATION\_TARGET - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/activeErpLinks|bool|SR\_RELATION\_TARGET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|target/deletedDate|datetime|SR\_RELATION\_TARGET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|target/mainContact| *None* |SR\_RELATION\_TARGET - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|target/forceCompany|bool|SR\_RELATION\_TARGET - Dummy: Dummy|  |
|target/restrictionContactId|int|SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|target/who| *None* |SR\_RELATION\_TARGET - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|target/contactPhone/formattedNumber|string|SR\_RELATION\_TARGET - SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/contactPhone/description|string|SR\_RELATION\_TARGET - SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|target/contactFax/formattedNumber| *None* |SR\_RELATION\_TARGET - SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/contactFax/description| *None* |SR\_RELATION\_TARGET - SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|target/searchPhone/formattedNumber| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/searchPhone/description| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|target/email/emailProtocol| *None* |SR\_RELATION\_TARGET - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|target/email/emailAddress| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_EMAIL|  |
|target/email/emailDescription| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_DESCRIPTION|  |
|target/email/emailId| *None* |SR\_RELATION\_TARGET - ID|  |
|target/email/emailLastSent| *None* |SR\_RELATION\_TARGET - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|target/email/emailBounceCount| *None* |SR\_RELATION\_TARGET - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|target/email/emailLastBounce| *None* |SR\_RELATION\_TARGET - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|target/email/emailHasBounced| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|target/postAddress/addressId| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|target/postAddress/line1| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|target/postAddress/line2| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|target/postAddress/line3| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|target/postAddress/county| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|target/postAddress/city| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|target/postAddress/zip| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|target/postAddress/state| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|target/postAddress/wgs84latitude| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|target/postAddress/wgs84longitude| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|target/postAddress/formattedAddress| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|target/postAddress/formattedMultiLineAddress| *None* |SR\_RELATION\_TARGET - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|target/streetAddress/addressId| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|target/streetAddress/line1| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|target/streetAddress/line2| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|target/streetAddress/line3| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|target/streetAddress/county| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|target/streetAddress/city| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|target/streetAddress/zip| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|target/streetAddress/state| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|target/streetAddress/wgs84latitude| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|target/streetAddress/wgs84longitude| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|target/streetAddress/formattedAddress| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|target/streetAddress/formattedMultiLineAddress| *None* |SR\_RELATION\_TARGET - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|target/restrictionAddress/addressId| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|target/restrictionAddress/line1| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|target/restrictionAddress/line2| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|target/restrictionAddress/line3| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|target/restrictionAddress/county| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|target/restrictionAddress/city| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|target/restrictionAddress/zip| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|target/restrictionAddress/state| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|target/restrictionAddress/wgs84latitude| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|target/restrictionAddress/wgs84longitude| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|target/restrictionAddress/formattedAddress| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|target/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|target/url/URLAddress| *None* |SR\_RELATION\_TARGET - SR\_PROJECTARCHIVE\_URL|  |
|target/url/URLDescription| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_DESCRIPTION|  |
|target/contactAssociate/firstName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|target/contactAssociate/lastName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|target/contactAssociate/middleName| *None* |SR\_RELATION\_TARGET - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|target/contactAssociate/fullName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|target/contactAssociate/contactId| *None* |SR\_RELATION\_TARGET - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|target/contactAssociate/personId| *None* |SR\_RELATION\_TARGET - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|target/contactAssociate/mrMrs| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|target/contactAssociate/title| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|target/contactAssociate/associateDbId| *None* |SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|target/contactAssociate/contactName| *None* |SR\_RELATION\_TARGET - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|target/contactAssociate/contactDepartment| *None* |SR\_RELATION\_TARGET - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|target/contactAssociate/usergroup| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|target/contactAssociate/usergroupId| *None* |SR\_RELATION\_TARGET - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|target/contactAssociate/contactFullName| *None* |SR\_RELATION\_TARGET - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|target/contactAssociate/contactCategory| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|target/contactAssociate/role| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|target/contactAssociate/assocName| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|target/contactAssociate/assocTooltip| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|target/contactAssociate/assocType| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|target/contactAssociate/ejUserId| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|target/contactAssociate/simultaneousEjUser| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|target/contactAssociate/ejDisplayName| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|target/contactAssociate/ejStatus| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|target/contactAssociate/credentialType| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|target/contactAssociate/credentialDisplayValue| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|target/contactAssociate/isActive| *None* |SR\_RELATION\_TARGET - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|target/contactAssociate/isActiveText| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|target/contactAssociate/portraitThumbnail| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|target/contactAssociate/otherGroups| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|target/contactAssociate/userName| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|target/contactAssociate/personEmail| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_EMAIL|  |
|target/contactAssociate/locationAddress| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|target/contactAssociate/isLocation| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|target/contactInterestIds| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|target/contactUdef/SuperOffice:1| *None* |SR\_RELATION\_TARGET - companyshorttext: tooltipshorttext|  |
|target/contactUdef/SuperOffice:2| *None* |SR\_RELATION\_TARGET - companylongtext: tooltiplongtext|  |
|target/contactUdef/SuperOffice:3| *None* |SR\_RELATION\_TARGET - companynumber|  |
|target/contactUdef/SuperOffice:4| *None* |SR\_RELATION\_TARGET - companydate|  |
|target/contactUdef/SuperOffice:5| *None* |SR\_RELATION\_TARGET - companyunlimiteddate: tooltipunlimiteddate|  |
|target/contactUdef/SuperOffice:6| *None* |SR\_RELATION\_TARGET - companycheckbox|  |
|target/contactUdef/SuperOffice:7| *None* |SR\_RELATION\_TARGET - companydropdownlistbox|  |
|target/contactUdef/SuperOffice:8| *None* |SR\_RELATION\_TARGET - companydecimal|  |
|target/contactUdef/SuperOffice:9| *None* |SR\_RELATION\_TARGET - page1saleonly|  |
|target/contactUdef/SuperOffice:10| *None* |SR\_RELATION\_TARGET - page1marketingonly|  |
|target/contactUdef/SuperOffice:11| *None* |SR\_RELATION\_TARGET - page1adminonly|  |
|target/contactUdef/SuperOffice:12| *None* |SR\_RELATION\_TARGET - Udlist one: Static tooltip for udlist one|  |
|target/contactUdef/SuperOffice:13| *None* |SR\_RELATION\_TARGET - Udlist two: Static tooltip for udlist two|  |
|target/contactExtra/x\_contact\_integer| *None* |SR\_RELATION\_TARGET - Extra Integer: Custom integer field|  |
|target/contactExtra/x\_contact\_hidden\_integer| *None* |SR\_RELATION\_TARGET - Extra hidden integer: Custom integer field - hidden|  |
|target/contactExtra/x\_contact\_default\_integer| *None* |SR\_RELATION\_TARGET - Extra Default Integer: Custom integer field with default value 123.|  |
|target/contactExtra/x\_contact\_float| *None* |SR\_RELATION\_TARGET - Extra Float: Custom float field with 3 decimals|  |
|target/contactExtra/x\_contact\_longtext| *None* |SR\_RELATION\_TARGET - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|target/contactExtra/x\_contact\_dropdown| *None* |SR\_RELATION\_TARGET - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|target/contactExtra/x\_contact\_date| *None* |SR\_RELATION\_TARGET - Extra date: Custom date field. User current as default.|  |
|target/contactExtra/x\_contact\_datetime| *None* |SR\_RELATION\_TARGET - Extra DateTime: Custom Date Time field. No default value. External|  |
|target/contactExtra/x\_contact\_time| *None* |SR\_RELATION\_TARGET - Extra time: Custom time field.|  |
|target/contactExtra/x\_contact\_boolean| *None* |SR\_RELATION\_TARGET - Extra boolean: Custom boolean field.|  |
|target/contactExtra/x\_contact\_timespan| *None* |SR\_RELATION\_TARGET - Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|target/contactExtra/x\_contact\_shorttext| *None* |SR\_RELATION\_TARGET - Extra short text: Custom short text field. Keep HTML tags.|  |
|target/contactExtra/x\_contact\_short\_dropdown| *None* |SR\_RELATION\_TARGET - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|target/contactExtra/x\_contact\_contact\_relation| *None* |SR\_RELATION\_TARGET - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|target/contactExtra/x\_contact\_request\_relation| *None* |SR\_RELATION\_TARGET - Extra Request relation: Request relation on company|  |
|target/contactExtra/x\_contact\_contact| *None* |SR\_RELATION\_TARGET - Extra contact relation: Contact relation on company|  |
|target/contactExtra/y\_organization/x\_name| *None* |SR\_RELATION\_TARGET - Organization - Name: Name|  |
|target/NumberOfActivities| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|target/NumberOfActivitiesInPeriod| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|target/NumberOfNotCompletedActivities| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|target/NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|target/LastActivity| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_ACTIVITY|  |
|target/LastCompletedActivity| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|target/LastDoByActivity| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|target/NumberOfSales| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_SALES|  |
|target/NumberOfSalesInPeriod| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|target/NumberOfNotCompletedSales| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|target/NumberOfNotCompletedSalesInPeriod| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|target/LastSale| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_SALE|  |
|target/LastCompletedSale| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|target/LastDoBySale| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|target/NumberOfTickets| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|target/NumberOfTicketsInPeriod| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|target/NumberOfNotCompletedTickets| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|target/NumberOfNotCompletedTicketsInPeriod| *None* |SR\_RELATION\_TARGET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|target/LastTicket| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_TICKET|  |
|target/LastCompletedTicket| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|target/LastDoByTicket| *None* |SR\_RELATION\_TARGET - SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|target/SaintStatus1| *None* |SR\_RELATION\_TARGET - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|target/SaintStatus2| *None* |SR\_RELATION\_TARGET - C-company: Kundens navn starter med bokstaven C|  |
|target/saintSaleStatus| *None* |SR\_RELATION\_TARGET - SR\_WITH\_STATUS|  |
|target/saintAmountClass| *None* |SR\_RELATION\_TARGET - SR\_AMOUNT\_CLASS|  |
|target/saintActivityType| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SAINT\_TYPE|  |
|target/saintDirection| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_DIRECTION|  |
|target/saintIntention| *None* |SR\_RELATION\_TARGET - SR\_ACTIVITY\_INTENTION|  |
|target/saintTicketStatus| *None* |SR\_RELATION\_TARGET - SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|target/saintTicketCategory| *None* |SR\_RELATION\_TARGET - SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|target/personId| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|target/firstName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|target/lastName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|target/middleName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|target/fullName| *None* |SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|target/fullNameWithContact| *None* |SR\_RELATION\_TARGET - SR\_PERSON\_NAMEWITHCONT: SR\_PERSON\_NAMEWITHCONT\_TOOLTIP|  |
|target/personHasInterests| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|target/mrMrs| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|target/position| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_POSITION|  |
|target/personNumber| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|target/title| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|target/personCountry| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|target/personCountryId| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|target/personNoMail| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|target/rank| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|target/birthdate| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|target/associateType| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|target/useAsMailingAddress| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|target/personSource| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|target/retired| *None* |SR\_RELATION\_TARGET - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|target/birthYear| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|target/birthMonth| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|target/birthDay| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|target/kanaFirstName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|target/kanaLastName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|target/personUpdatedBy| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|target/personUpdatedByFullName| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|target/personUpdatedDate| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|target/personRegisteredBy| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|target/personRegisteredByFullName| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|target/personRegisteredDate| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|target/portraitThumbnail| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|target/personActiveErpLinks| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|target/ticketPriority| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|target/supportLanguage| *None* |SR\_RELATION\_TARGET - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|target/supportAssociate| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|target/supportAssociateFullName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|target/personAssociateId| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|target/personAssociateFullName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|target/personCategory| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY|  |
|target/personCategoryGroup| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|target/personCategoryRank| *None* |SR\_RELATION\_TARGET - !!Category rank|  |
|target/personBusiness| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BUSINESS|  |
|target/leadStatus| *None* |SR\_RELATION\_TARGET - SR\_LABEL\_LEADSTATUS|  |
|target/leadstatusRank| *None* |SR\_RELATION\_TARGET - !!Lead status RANK|  |
|target/personDeletedDate| *None* |SR\_RELATION\_TARGET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|target/hasCompany| *None* |SR\_RELATION\_TARGET - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|target/isProjectMember| *None* |SR\_RELATION\_TARGET - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|target/isStakeholder| *None* |SR\_RELATION\_TARGET - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|target/updatedByWorkflow| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|target/whenUpdatedByWorkflow| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|target/createdByForm| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|target/restrictionPersonId| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|target/personDirectPhone/formattedNumber| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/personDirectPhone/description| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|target/personMobilePhone/formattedNumber| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/personMobilePhone/description| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|target/personPrivate/formattedNumber| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/personPrivate/description| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|target/personPager/formattedNumber| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/personPager/description| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|target/personDirectFax/formattedNumber| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|target/personDirectFax/description| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|source/contactFax/formattedNumber| *None* |SR\_RELATION\_SOURCE - SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/contactFax/description| *None* |SR\_RELATION\_SOURCE - SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|source/searchPhone/formattedNumber| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|source/searchPhone/description| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|source/email/emailProtocol| *None* |SR\_RELATION\_SOURCE - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|source/email/emailAddress| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_EMAIL|  |
|source/email/emailDescription| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DESCRIPTION|  |
|source/email/emailId| *None* |SR\_RELATION\_SOURCE - ID|  |
|source/email/emailLastSent| *None* |SR\_RELATION\_SOURCE - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|source/email/emailBounceCount| *None* |SR\_RELATION\_SOURCE - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|source/email/emailLastBounce| *None* |SR\_RELATION\_SOURCE - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|source/email/emailHasBounced| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|source/postAddress/addressId| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|source/postAddress/line1| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|source/postAddress/line2| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|source/postAddress/line3| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|source/postAddress/county| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|source/postAddress/city| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|source/postAddress/zip| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|source/postAddress/state| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|source/postAddress/wgs84latitude| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|source/postAddress/wgs84longitude| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|source/postAddress/formattedAddress| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|source/postAddress/formattedMultiLineAddress| *None* |SR\_RELATION\_SOURCE - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|source/streetAddress/addressId| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|source/streetAddress/line1| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|source/streetAddress/line2| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|source/streetAddress/line3| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|source/streetAddress/county| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|source/streetAddress/city| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|source/streetAddress/zip| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|source/streetAddress/state| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|source/streetAddress/wgs84latitude| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|source/streetAddress/wgs84longitude| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|source/streetAddress/formattedAddress| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|source/streetAddress/formattedMultiLineAddress| *None* |SR\_RELATION\_SOURCE - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|source/restrictionAddress/addressId| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|source/restrictionAddress/line1| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|source/restrictionAddress/line2| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|source/restrictionAddress/line3| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|source/restrictionAddress/county| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|source/restrictionAddress/city| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|source/restrictionAddress/zip| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|source/restrictionAddress/state| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|source/restrictionAddress/wgs84latitude| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|source/restrictionAddress/wgs84longitude| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|source/restrictionAddress/formattedAddress| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|source/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|source/url/URLAddress| *None* |SR\_RELATION\_SOURCE - SR\_PROJECTARCHIVE\_URL|  |
|source/url/URLDescription| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DESCRIPTION|  |
|source/contactAssociate/firstName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|source/contactAssociate/lastName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|source/contactAssociate/middleName| *None* |SR\_RELATION\_SOURCE - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|source/contactAssociate/fullName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|source/contactAssociate/contactId| *None* |SR\_RELATION\_SOURCE - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|source/contactAssociate/personId| *None* |SR\_RELATION\_SOURCE - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|source/contactAssociate/mrMrs| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|source/contactAssociate/title| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|source/contactAssociate/associateDbId| *None* |SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|source/contactAssociate/contactName| *None* |SR\_RELATION\_SOURCE - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|source/contactAssociate/contactDepartment| *None* |SR\_RELATION\_SOURCE - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|source/contactAssociate/usergroup| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|source/contactAssociate/usergroupId| *None* |SR\_RELATION\_SOURCE - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|source/contactAssociate/contactFullName| *None* |SR\_RELATION\_SOURCE - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|source/contactAssociate/contactCategory| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|source/contactAssociate/role| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|source/contactAssociate/assocName| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|source/contactAssociate/assocTooltip| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|source/contactAssociate/assocType| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|source/contactAssociate/ejUserId| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|source/contactAssociate/simultaneousEjUser| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|source/contactAssociate/ejDisplayName| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|source/contactAssociate/ejStatus| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|source/contactAssociate/credentialType| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|source/contactAssociate/credentialDisplayValue| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|source/contactAssociate/isActive| *None* |SR\_RELATION\_SOURCE - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|source/contactAssociate/isActiveText| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|source/contactAssociate/portraitThumbnail| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|source/contactAssociate/otherGroups| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|source/contactAssociate/userName| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|source/contactAssociate/personEmail| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_EMAIL|  |
|source/contactAssociate/locationAddress| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|source/contactAssociate/isLocation| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|source/contactInterestIds| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|source/contactUdef/SuperOffice:1| *None* |SR\_RELATION\_SOURCE - companyshorttext: tooltipshorttext|  |
|source/contactUdef/SuperOffice:2| *None* |SR\_RELATION\_SOURCE - companylongtext: tooltiplongtext|  |
|source/contactUdef/SuperOffice:3| *None* |SR\_RELATION\_SOURCE - companynumber|  |
|source/contactUdef/SuperOffice:4| *None* |SR\_RELATION\_SOURCE - companydate|  |
|source/contactUdef/SuperOffice:5| *None* |SR\_RELATION\_SOURCE - companyunlimiteddate: tooltipunlimiteddate|  |
|source/contactUdef/SuperOffice:6| *None* |SR\_RELATION\_SOURCE - companycheckbox|  |
|source/contactUdef/SuperOffice:7| *None* |SR\_RELATION\_SOURCE - companydropdownlistbox|  |
|source/contactUdef/SuperOffice:8| *None* |SR\_RELATION\_SOURCE - companydecimal|  |
|source/contactUdef/SuperOffice:9| *None* |SR\_RELATION\_SOURCE - page1saleonly|  |
|source/contactUdef/SuperOffice:10| *None* |SR\_RELATION\_SOURCE - page1marketingonly|  |
|source/contactUdef/SuperOffice:11| *None* |SR\_RELATION\_SOURCE - page1adminonly|  |
|source/contactUdef/SuperOffice:12| *None* |SR\_RELATION\_SOURCE - Udlist one: Static tooltip for udlist one|  |
|source/contactUdef/SuperOffice:13| *None* |SR\_RELATION\_SOURCE - Udlist two: Static tooltip for udlist two|  |
|source/contactExtra/x\_contact\_integer| *None* |SR\_RELATION\_SOURCE - Extra Integer: Custom integer field|  |
|source/contactExtra/x\_contact\_hidden\_integer| *None* |SR\_RELATION\_SOURCE - Extra hidden integer: Custom integer field - hidden|  |
|source/contactExtra/x\_contact\_default\_integer| *None* |SR\_RELATION\_SOURCE - Extra Default Integer: Custom integer field with default value 123.|  |
|source/contactExtra/x\_contact\_float| *None* |SR\_RELATION\_SOURCE - Extra Float: Custom float field with 3 decimals|  |
|source/contactExtra/x\_contact\_longtext| *None* |SR\_RELATION\_SOURCE - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|source/contactExtra/x\_contact\_dropdown| *None* |SR\_RELATION\_SOURCE - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|source/contactExtra/x\_contact\_date| *None* |SR\_RELATION\_SOURCE - Extra date: Custom date field. User current as default.|  |
|source/contactExtra/x\_contact\_datetime| *None* |SR\_RELATION\_SOURCE - Extra DateTime: Custom Date Time field. No default value. External|  |
|source/contactExtra/x\_contact\_time| *None* |SR\_RELATION\_SOURCE - Extra time: Custom time field.|  |
|source/contactExtra/x\_contact\_boolean| *None* |SR\_RELATION\_SOURCE - Extra boolean: Custom boolean field.|  |
|source/contactExtra/x\_contact\_timespan| *None* |SR\_RELATION\_SOURCE - Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|source/contactExtra/x\_contact\_shorttext| *None* |SR\_RELATION\_SOURCE - Extra short text: Custom short text field. Keep HTML tags.|  |
|source/contactExtra/x\_contact\_short\_dropdown| *None* |SR\_RELATION\_SOURCE - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|source/contactExtra/x\_contact\_contact\_relation| *None* |SR\_RELATION\_SOURCE - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|source/contactExtra/x\_contact\_request\_relation| *None* |SR\_RELATION\_SOURCE - Extra Request relation: Request relation on company|  |
|source/contactExtra/x\_contact\_contact| *None* |SR\_RELATION\_SOURCE - Extra contact relation: Contact relation on company|  |
|source/contactExtra/y\_organization/x\_name| *None* |SR\_RELATION\_SOURCE - Organization - Name: Name|  |
|source/NumberOfActivities| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|source/NumberOfActivitiesInPeriod| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|source/NumberOfNotCompletedActivities| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|source/NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|source/LastActivity| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_ACTIVITY|  |
|source/LastCompletedActivity| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|source/LastDoByActivity| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|source/NumberOfSales| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_SALES|  |
|source/NumberOfSalesInPeriod| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|source/NumberOfNotCompletedSales| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|source/NumberOfNotCompletedSalesInPeriod| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|source/LastSale| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_SALE|  |
|source/LastCompletedSale| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|source/LastDoBySale| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|source/NumberOfTickets| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|source/NumberOfTicketsInPeriod| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|source/NumberOfNotCompletedTickets| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|source/NumberOfNotCompletedTicketsInPeriod| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|source/LastTicket| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_TICKET|  |
|source/LastCompletedTicket| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|source/LastDoByTicket| *None* |SR\_RELATION\_SOURCE - SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|source/SaintStatus1| *None* |SR\_RELATION\_SOURCE - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|source/SaintStatus2| *None* |SR\_RELATION\_SOURCE - C-company: Kundens navn starter med bokstaven C|  |
|source/saintSaleStatus| *None* |SR\_RELATION\_SOURCE - SR\_WITH\_STATUS|  |
|source/saintAmountClass| *None* |SR\_RELATION\_SOURCE - SR\_AMOUNT\_CLASS|  |
|source/saintActivityType| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SAINT\_TYPE|  |
|source/saintDirection| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DIRECTION|  |
|source/saintIntention| *None* |SR\_RELATION\_SOURCE - SR\_ACTIVITY\_INTENTION|  |
|source/saintTicketStatus| *None* |SR\_RELATION\_SOURCE - SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|source/saintTicketCategory| *None* |SR\_RELATION\_SOURCE - SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |

## Sample

```http!
GET /api/v1/archive/PersonRelation?$select=source/country,isLocation,source/email/emailId,source/NumberOfNotCompletedActivities
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


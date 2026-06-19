---
uid: EmailAddress
title: EmailAddress
description: Special purpose archive provider used to search for email addresses.
keywords: EmailAddress archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "EmailAddress"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EMailAddressProvider">SuperOffice.CRM.ArchiveLists.EMailAddressProvider</see> inside NetServer's SODatabase assembly.

Special purpose archive provider used to search for email addresses.

This provider combines two subchannels, one for Person and one for Contact related addresses.
Each channel will match on either the email address itself, or some relevant naming information
(such as contact name or person name or whatever).


The resulting rows will have entity names reflecting the type of match, but the primary key will always be
the email_id.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"email"|email|
|"person"|[[SR_PL_PERSONS]]|
|"contact"|[[SR_SINGULAR_CONTACT]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|emailMatch|string|emailMatch: Restriction only: (partial) email / person / contact to match|  |
|emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|emailAddress|string|SR\_ARCHIVE\_EMAIL| x |
|emailDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|emailId|int|ID| x |
|emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|personId| *None* |SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|middleName| *None* |SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|fullName| *None* |SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|fullNameWithContact| *None* |SR\_PERSON\_NAMEWITHCONT: SR\_PERSON\_NAMEWITHCONT\_TOOLTIP|  |
|contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
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
|phone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|who| *None* |SR\_CONTACTSELECTIONARCHIVE\_PERSONFULLNAME: SR\_CONTACTSELECTIONARCHIVE\_PERSONFULLNAME\_TOOLTIP| x |
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
|personContact/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|personContact/name| *None* |SR\_COMPANY\_NAME|  |
|personContact/department| *None* |SR\_ARCHIVE\_DEPARTEMENT|  |
|personContact/nameDepartment| *None* |SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|personContact/hasInfoText| *None* |SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|personContact/hasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|personContact/associateId| *None* |SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personContact/category| *None* |SR\_ARCHIVE\_CATEGORY|  |
|personContact/categoryGroup| *None* |SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personContact/companyCategoryRank| *None* |Category rank|  |
|personContact/business| *None* |SR\_ARCHIVE\_BUSINESS|  |
|personContact/country| *None* |SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|personContact/countryId| *None* |SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|personContact/number| *None* |SR\_ARCHIVE\_NUMBER|  |
|personContact/code| *None* |SR\_ARCHIVE\_CODE|  |
|personContact/orgnr| *None* |VAT No.|  |
|personContact/stop| *None* |SR\_CC\_STOPX|  |
|personContact/contactNoMail| *None* |SR\_NO\_MAIL\_COMPANY|  |
|personContact/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personContact/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personContact/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|personContact/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personContact/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personContact/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|personContact/contactSource| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|personContact/contactDeleted| *None* |SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|personContact/phone/formattedNumber| *None* |SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personContact/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|personContact/deletedDate| *None* |SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|personContact/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|personContact/forceCompany| *None* |Dummy: Dummy|  |
|personContact/contactPhone/formattedNumber| *None* |SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personContact/contactPhone/description| *None* |SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|personContact/postAddress/addressId| *None* |SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|personContact/postAddress/line1| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|personContact/postAddress/line2| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|personContact/postAddress/line3| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|personContact/postAddress/county| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|personContact/postAddress/city| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|personContact/postAddress/zip| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|personContact/postAddress/state| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|personContact/postAddress/wgs84latitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|personContact/postAddress/wgs84longitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|personContact/postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|personContact/postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|personContact/streetAddress/addressId| *None* |SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|personContact/streetAddress/line1| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|personContact/streetAddress/line2| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|personContact/streetAddress/line3| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|personContact/streetAddress/county| *None* |SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|personContact/streetAddress/city| *None* |SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|personContact/streetAddress/zip| *None* |SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|personContact/streetAddress/state| *None* |SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|personContact/streetAddress/wgs84latitude| *None* |SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|personContact/streetAddress/wgs84longitude| *None* |SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|personContact/streetAddress/formattedAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|personContact/streetAddress/formattedMultiLineAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionAddress/addressId| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|personContact/restrictionAddress/line1| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|personContact/restrictionAddress/line2| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|personContact/restrictionAddress/line3| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|personContact/restrictionAddress/county| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|personContact/restrictionAddress/city| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|personContact/restrictionAddress/zip| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|personContact/restrictionAddress/state| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|personContact/restrictionAddress/wgs84latitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|personContact/restrictionAddress/wgs84longitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|personContact/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|personContact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|name| *None* |SR\_COMPANY\_NAME|  |
|department| *None* |SR\_ARCHIVE\_DEPARTEMENT|  |
|nameDepartment| *None* |SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|associateId| *None* |SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
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
|updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|contactSource| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|contactDeleted| *None* |SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|restrictionPostalAddress/addressId| *None* |SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|restrictionPostalAddress/line1| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|restrictionPostalAddress/line2| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|restrictionPostalAddress/line3| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|restrictionPostalAddress/county| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|restrictionPostalAddress/city| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|restrictionPostalAddress/zip| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|restrictionPostalAddress/state| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|restrictionPostalAddress/wgs84latitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|restrictionPostalAddress/wgs84longitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|restrictionPostalAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|restrictionPostalAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
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
|contactSupportAssociate/firstName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|contactSupportAssociate/lastName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|contactSupportAssociate/middleName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|contactSupportAssociate/fullName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|contactSupportAssociate/contactId| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|contactSupportAssociate/personId| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|contactSupportAssociate/mrMrs| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|contactSupportAssociate/title| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|contactSupportAssociate/associateDbId| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|contactSupportAssociate/contactName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|contactSupportAssociate/contactDepartment| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|contactSupportAssociate/usergroup| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|contactSupportAssociate/usergroupId| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|contactSupportAssociate/contactFullName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|contactSupportAssociate/contactCategory| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|contactSupportAssociate/role| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactSupportAssociate/assocName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|contactSupportAssociate/assocTooltip| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|contactSupportAssociate/assocType| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|contactSupportAssociate/ejUserId| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|contactSupportAssociate/simultaneousEjUser| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|contactSupportAssociate/ejDisplayName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|contactSupportAssociate/ejStatus| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|contactSupportAssociate/credentialType| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|contactSupportAssociate/credentialDisplayValue| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|contactSupportAssociate/isActive| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|contactSupportAssociate/isActiveText| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|contactSupportAssociate/portraitThumbnail| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contactSupportAssociate/otherGroups| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|contactSupportAssociate/userName| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|contactSupportAssociate/personEmail| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_EMAIL|  |
|contactSupportAssociate/locationAddress| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|contactSupportAssociate/isLocation| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|contactSupportPerson/personId| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|contactSupportPerson/firstName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|contactSupportPerson/lastName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|contactSupportPerson/middleName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|contactSupportPerson/fullName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|contactSupportPerson/contactId| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|contactSupportPerson/hasInfoText| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|contactSupportPerson/hasInterests| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|contactSupportPerson/personHasInterests| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|contactSupportPerson/mrMrs| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|contactSupportPerson/position| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_POSITION|  |
|contactSupportPerson/personNumber| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|contactSupportPerson/title| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|contactSupportPerson/personCountry| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|contactSupportPerson/personCountryId| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|contactSupportPerson/personNoMail| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|contactSupportPerson/rank| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|contactSupportPerson/birthdate| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|contactSupportPerson/associateType| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|contactSupportPerson/useAsMailingAddress| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|contactSupportPerson/personSource| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|contactSupportPerson/retired| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|contactSupportPerson/birthYear| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|contactSupportPerson/birthMonth| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|contactSupportPerson/birthDay| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|contactSupportPerson/kanaFirstName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|contactSupportPerson/kanaLastName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|contactSupportPerson/personUpdatedBy| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|contactSupportPerson/personUpdatedByFullName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|contactSupportPerson/personUpdatedDate| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|contactSupportPerson/personRegisteredBy| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|contactSupportPerson/personRegisteredByFullName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|contactSupportPerson/personRegisteredDate| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|contactSupportPerson/portraitThumbnail| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contactSupportPerson/personActiveErpLinks| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|contactSupportPerson/ticketPriority| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|contactSupportPerson/supportLanguage| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|contactSupportPerson/supportAssociate| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|contactSupportPerson/supportAssociateFullName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|contactSupportPerson/personAssociateId| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|contactSupportPerson/personAssociateFullName| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|contactSupportPerson/personCategory| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_CATEGORY|  |
|contactSupportPerson/personCategoryGroup| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|contactSupportPerson/personCategoryRank| *None* |SR\_ARCHIVE\_SUPPORTPERSON - !!Category rank|  |
|contactSupportPerson/personBusiness| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BUSINESS|  |
|contactSupportPerson/leadStatus| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_LABEL\_LEADSTATUS|  |
|contactSupportPerson/leadstatusRank| *None* |SR\_ARCHIVE\_SUPPORTPERSON - !!Lead status RANK|  |
|contactSupportPerson/personDeletedDate| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|contactSupportPerson/hasCompany| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|contactSupportPerson/isProjectMember| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|contactSupportPerson/isStakeholder| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|contactSupportPerson/updatedByWorkflow| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|contactSupportPerson/whenUpdatedByWorkflow| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|contactSupportPerson/createdByForm| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|contactSupportPerson/who| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONTACTSELECTIONARCHIVE\_PERSONFULLNAME: SR\_CONTACTSELECTIONARCHIVE\_PERSONFULLNAME\_TOOLTIP|  |
|contactSupportPerson/personInfo/textId| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Text ID|  |
|contactSupportPerson/personInfo/infoText| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|contactSupportPerson/personUdef/SuperOffice:1| *None* |SR\_ARCHIVE\_SUPPORTPERSON - contactshorttext: tooltipshorttext|  |
|contactSupportPerson/personUdef/SuperOffice:2| *None* |SR\_ARCHIVE\_SUPPORTPERSON - contactlongtext: tooltiplongtext|  |
|contactSupportPerson/personUdef/SuperOffice:3| *None* |SR\_ARCHIVE\_SUPPORTPERSON - contactnumber|  |
|contactSupportPerson/personUdef/SuperOffice:4| *None* |SR\_ARCHIVE\_SUPPORTPERSON - contactdate|  |
|contactSupportPerson/personUdef/SuperOffice:5| *None* |SR\_ARCHIVE\_SUPPORTPERSON - contactunlimiteddate: tooltipunlimiteddate|  |
|contactSupportPerson/personUdef/SuperOffice:6| *None* |SR\_ARCHIVE\_SUPPORTPERSON - contactcheckbox|  |
|contactSupportPerson/personUdef/SuperOffice:7| *None* |SR\_ARCHIVE\_SUPPORTPERSON - contactdropdownlistbox|  |
|contactSupportPerson/personUdef/SuperOffice:8| *None* |SR\_ARCHIVE\_SUPPORTPERSON - contactdecimal|  |
|contactSupportPerson/personUdef/SuperOffice:9| *None* |SR\_ARCHIVE\_SUPPORTPERSON - page1saleonly|  |
|contactSupportPerson/personUdef/SuperOffice:10| *None* |SR\_ARCHIVE\_SUPPORTPERSON - page1marketingonly|  |
|contactSupportPerson/personUdef/SuperOffice:11| *None* |SR\_ARCHIVE\_SUPPORTPERSON - page1adminonly|  |
|contactSupportPerson/personExtra/x\_person\_integer| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra Integer: Custom person integer|  |
|contactSupportPerson/personExtra/x\_person\_hidden\_integer| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra hidden integer: Custom integer field that is hidden|  |
|contactSupportPerson/personExtra/x\_person\_float| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra float: Custom float field|  |
|contactSupportPerson/personExtra/x\_person\_longtext| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|contactSupportPerson/personExtra/x\_person\_date| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra date: Custom date field on person. Default value = 28.03.2019|  |
|contactSupportPerson/personExtra/x\_person\_datetime| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra DateTime: Custom person date and time field. No default|  |
|contactSupportPerson/personExtra/x\_person\_time| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra time: Custom time field on person. Current time as default|  |
|contactSupportPerson/personExtra/x\_person\_boolean| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra Boolean: Custom boolean field on person. Default checked|  |
|contactSupportPerson/personExtra/x\_person\_timespan| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|contactSupportPerson/personExtra/x\_person\_shorttext| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|contactSupportPerson/personExtra/x\_person\_shorttext\_list| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|contactSupportPerson/personExtra/x\_person\_user\_relation| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra user relation: Custom person-user relation field|  |
|contactSupportPerson/personExtra/x\_person\_category\_relation| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra category relation: Custom person-category relation|  |
|contactSupportPerson/personExtra/x\_person\_priority\_relation| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra priority relation: Custom person-priority relation|  |
|contactSupportPerson/personExtra/x\_person\_request\_relation| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra request relation: Request relation on contact|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactSupportPerson/personExtra/x\_person\_appointment\_relation| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra appointment relation: Appointment relation on person|  |
|contactSupportPerson/personExtra/x\_person\_contact\_relation| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra company relation: Company relation on contact|  |
|contactSupportPerson/personExtra/y\_rental/id| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)|  |
|contactSupportPerson/personExtra/y\_rental/x\_start| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Rental - Start rental: Start rental|  |
|contactSupportPerson/personExtra/y\_rental/x\_end| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Rental - End: End|  |
|contactSupportPerson/personExtra/y\_rental/x\_amount| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Rental - Amount: Number to rent. Default = 1|  |
|contactSupportPerson/personExtra/y\_rental/x\_contact| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Rental - Renter: Company that rents equipment|  |
|contactSupportPerson/personExtra/y\_rental/y\_equipment/x\_name| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|contactSupportPerson/personExtra/y\_car/id| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)|  |
|contactSupportPerson/isMailingRecipient| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient|  |
|contactSupportPerson/hasStoreConsent| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/withdrawnStoreConsent| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/hasEmarketingConsent| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/withdrawnEmarketingConsent| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/subscription| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP|  |
|contactSupportPerson/legalBaseStore| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/legalBaseEmarketing| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/consentSourceStore| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/consentSourceEmarketing| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
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
|selectionMemberId| *None* |SR\_SELECTIONMEMBER\_ID: SR\_SELECTIONMEMBER\_ID\_TOOLTIP|  |
|selectionIdRequest| *None* |SR\_RESTRICTION\_SELECTIONID: SR\_RESTRICTION\_SELECTIONID\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/EmailAddress?$select=personCategoryGroup,createdByForm,category,updatedDate,postAddress/line2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


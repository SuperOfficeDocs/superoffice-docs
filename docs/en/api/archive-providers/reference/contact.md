---
uid: Contact
title: Contact
description: Contact provider for general use
keywords: Contact archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Contact"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ContactProvider">SuperOffice.CRM.ArchiveLists.ContactProvider</see> inside NetServer's SODatabase assembly.

Contact provider for general use

## Supported Entities
| Name | Description |
| ---- | ----- |
|"contact"|[[SR_PL_CONTACTS]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|name|stringorPK|SR\_COMPANY\_NAME| x |
|department|string|SR\_ARCHIVE\_DEPARTEMENT| x |
|nameDepartment|string|SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|associateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|category|listAny|SR\_ARCHIVE\_CATEGORY| x |
|categoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|companyCategoryRank|int|Category rank| x |
|business|listAny|SR\_ARCHIVE\_BUSINESS| x |
|country|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|countryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|number|string|SR\_ARCHIVE\_NUMBER| x |
|code|string|SR\_ARCHIVE\_CODE| x |
|orgnr|string|VAT No.| x |
|stop|bool|SR\_CC\_STOPX| x |
|contactNoMail|bool|SR\_NO\_MAIL\_COMPANY| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|contactSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|contactDeleted|bool|SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|phone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|deletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|forceCompany|bool|Dummy: Dummy|  |
|contactPhone/formattedNumber|string|SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contactPhone/description|string|SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|contactFax/formattedNumber|string|SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contactFax/description|string|SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|searchPhone/formattedNumber|string|SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|searchPhone/description|string|SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|email/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|email/emailAddress|string|SR\_ARCHIVE\_EMAIL| x |
|email/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|email/emailId|int|ID| x |
|email/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|email/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|email/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|email/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|postAddress/addressId|int|SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|postAddress/line1|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|postAddress/line2|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|postAddress/line3|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|postAddress/county|string|SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|postAddress/city|string|SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|postAddress/zip|string|SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|postAddress/state|string|SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|postAddress/wgs84latitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|postAddress/wgs84longitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|restrictionPostalAddress/addressId|int|SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|restrictionPostalAddress/line1|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|restrictionPostalAddress/line2|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|restrictionPostalAddress/line3|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|restrictionPostalAddress/county|string|SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|restrictionPostalAddress/city|string|SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|restrictionPostalAddress/zip|string|SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|restrictionPostalAddress/state|string|SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|restrictionPostalAddress/wgs84latitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|restrictionPostalAddress/wgs84longitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|restrictionPostalAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|restrictionPostalAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|streetAddress/addressId|int|SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|streetAddress/line1|string|SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|streetAddress/line2|string|SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|streetAddress/line3|string|SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|streetAddress/county|string|SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|streetAddress/city|string|SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|streetAddress/zip|string|SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|streetAddress/state|string|SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|streetAddress/wgs84latitude|decimal|SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|streetAddress/wgs84longitude|decimal|SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|streetAddress/formattedAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|streetAddress/formattedMultiLineAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/addressId|int|SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|restrictionAddress/line1|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|restrictionAddress/line2|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|restrictionAddress/line3|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|restrictionAddress/county|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|restrictionAddress/city|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|restrictionAddress/zip|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|restrictionAddress/state|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|restrictionAddress/wgs84latitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|restrictionAddress/wgs84longitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|url/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|url/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|contactAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|contactAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|contactAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|contactAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|contactAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|contactAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contactAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contactAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|contactAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|contactAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|contactAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contactAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contactAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|contactAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|contactAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|contactAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|contactAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|contactAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|contactAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|contactAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|contactAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|contactAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|contactAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|contactAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|contactAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|contactAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|contactAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contactAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|contactAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|contactAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|contactAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|contactAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|contactSupportAssociate/firstName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|contactSupportAssociate/lastName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|contactSupportAssociate/middleName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|contactSupportAssociate/fullName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|contactSupportAssociate/contactId|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|contactSupportAssociate/personId|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|contactSupportAssociate/mrMrs|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contactSupportAssociate/title|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contactSupportAssociate/associateDbId|associate|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|contactSupportAssociate/contactName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|contactSupportAssociate/contactDepartment|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|contactSupportAssociate/usergroup|userGroup|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contactSupportAssociate/usergroupId|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contactSupportAssociate/contactFullName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|contactSupportAssociate/contactCategory|listAny|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|contactSupportAssociate/role|listAny|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|contactSupportAssociate/assocName|associate|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|contactSupportAssociate/assocTooltip|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|contactSupportAssociate/assocType|listAny|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|contactSupportAssociate/ejUserId|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|contactSupportAssociate/simultaneousEjUser|bool|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|contactSupportAssociate/ejDisplayName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|contactSupportAssociate/ejStatus|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|contactSupportAssociate/credentialType| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|contactSupportAssociate/credentialDisplayValue| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|contactSupportAssociate/isActive|bool|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|contactSupportAssociate/isActiveText|bool|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|contactSupportAssociate/portraitThumbnail| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contactSupportAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|contactSupportAssociate/userName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|contactSupportAssociate/personEmail|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_EMAIL| x |
|contactSupportAssociate/locationAddress|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|contactSupportAssociate/isLocation|bool|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|contactSupportPerson/personId|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|contactSupportPerson/firstName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|contactSupportPerson/lastName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|contactSupportPerson/middleName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|contactSupportPerson/fullName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|contactSupportPerson/contactId|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|contactSupportPerson/hasInfoText|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|contactSupportPerson/hasInterests|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|contactSupportPerson/personHasInterests|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|contactSupportPerson/mrMrs|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contactSupportPerson/position|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_POSITION| x |
|contactSupportPerson/personNumber|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|contactSupportPerson/title|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|contactSupportPerson/personCountry|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|contactSupportPerson/personCountryId|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|contactSupportPerson/personNoMail|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|contactSupportPerson/rank|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|contactSupportPerson/birthdate| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|contactSupportPerson/associateType| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|contactSupportPerson/useAsMailingAddress|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|contactSupportPerson/personSource|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|contactSupportPerson/retired|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|contactSupportPerson/birthYear|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|contactSupportPerson/birthMonth|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|contactSupportPerson/birthDay|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|contactSupportPerson/kanaFirstName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|contactSupportPerson/kanaLastName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|contactSupportPerson/personUpdatedBy|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|contactSupportPerson/personUpdatedByFullName|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|contactSupportPerson/personUpdatedDate|date|SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|contactSupportPerson/personRegisteredBy|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|contactSupportPerson/personRegisteredByFullName|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|contactSupportPerson/personRegisteredDate|date|SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|contactSupportPerson/portraitThumbnail| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contactSupportPerson/personActiveErpLinks|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|contactSupportPerson/ticketPriority|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactSupportPerson/supportLanguage|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|contactSupportPerson/supportAssociate|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|contactSupportPerson/supportAssociateFullName|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|contactSupportPerson/personAssociateId|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|contactSupportPerson/personAssociateFullName|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|contactSupportPerson/personCategory|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_CATEGORY| x |
|contactSupportPerson/personCategoryGroup|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|contactSupportPerson/personCategoryRank|int|SR\_ARCHIVE\_SUPPORTPERSON - !!Category rank| x |
|contactSupportPerson/personBusiness|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BUSINESS| x |
|contactSupportPerson/leadStatus|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_LABEL\_LEADSTATUS| x |
|contactSupportPerson/leadstatusRank|int|SR\_ARCHIVE\_SUPPORTPERSON - !!Lead status RANK| x |
|contactSupportPerson/personDeletedDate|datetime|SR\_ARCHIVE\_SUPPORTPERSON - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|contactSupportPerson/hasCompany|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|contactSupportPerson/isProjectMember|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|contactSupportPerson/isStakeholder|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|contactSupportPerson/updatedByWorkflow|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|contactSupportPerson/whenUpdatedByWorkflow|datetime|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|contactSupportPerson/createdByForm|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|contactSupportPerson/who| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONTACTSELECTIONARCHIVE\_PERSONFULLNAME: SR\_CONTACTSELECTIONARCHIVE\_PERSONFULLNAME\_TOOLTIP| x |
|contactSupportPerson/personInfo/textId|int|SR\_ARCHIVE\_SUPPORTPERSON - Text ID| x |
|contactSupportPerson/personInfo/infoText|positiveString|SR\_ARCHIVE\_SUPPORTPERSON - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|contactSupportPerson/personUdef/SuperOffice:1|string|SR\_ARCHIVE\_SUPPORTPERSON - contactshorttext: tooltipshorttext| x |
|contactSupportPerson/personUdef/SuperOffice:2|string|SR\_ARCHIVE\_SUPPORTPERSON - contactlongtext: tooltiplongtext| x |
|contactSupportPerson/personUdef/SuperOffice:3|int|SR\_ARCHIVE\_SUPPORTPERSON - contactnumber| x |
|contactSupportPerson/personUdef/SuperOffice:4|date|SR\_ARCHIVE\_SUPPORTPERSON - contactdate| x |
|contactSupportPerson/personUdef/SuperOffice:5|unlimitedDate|SR\_ARCHIVE\_SUPPORTPERSON - contactunlimiteddate: tooltipunlimiteddate| x |
|contactSupportPerson/personUdef/SuperOffice:6|bool|SR\_ARCHIVE\_SUPPORTPERSON - contactcheckbox| x |
|contactSupportPerson/personUdef/SuperOffice:7|listAny|SR\_ARCHIVE\_SUPPORTPERSON - contactdropdownlistbox| x |
|contactSupportPerson/personUdef/SuperOffice:8|decimal|SR\_ARCHIVE\_SUPPORTPERSON - contactdecimal| x |
|contactSupportPerson/personUdef/SuperOffice:9|string|SR\_ARCHIVE\_SUPPORTPERSON - page1saleonly| x |
|contactSupportPerson/personUdef/SuperOffice:10|string|SR\_ARCHIVE\_SUPPORTPERSON - page1marketingonly| x |
|contactSupportPerson/personUdef/SuperOffice:11|string|SR\_ARCHIVE\_SUPPORTPERSON - page1adminonly| x |
|contactSupportPerson/personExtra/x\_person\_integer|int|SR\_ARCHIVE\_SUPPORTPERSON - Extra Integer: Custom person integer| x |
|contactSupportPerson/personExtra/x\_person\_hidden\_integer|int|SR\_ARCHIVE\_SUPPORTPERSON - Extra hidden integer: Custom integer field that is hidden| x |
|contactSupportPerson/personExtra/x\_person\_float|decimal|SR\_ARCHIVE\_SUPPORTPERSON - Extra float: Custom float field| x |
|contactSupportPerson/personExtra/x\_person\_longtext|string|SR\_ARCHIVE\_SUPPORTPERSON - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|contactSupportPerson/personExtra/x\_person\_date|date|SR\_ARCHIVE\_SUPPORTPERSON - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|contactSupportPerson/personExtra/x\_person\_datetime|datetime|SR\_ARCHIVE\_SUPPORTPERSON - Extra DateTime: Custom person date and time field. No default| x |
|contactSupportPerson/personExtra/x\_person\_time| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra time: Custom time field on person. Current time as default| x |
|contactSupportPerson/personExtra/x\_person\_boolean|bool|SR\_ARCHIVE\_SUPPORTPERSON - Extra Boolean: Custom boolean field on person. Default checked| x |
|contactSupportPerson/personExtra/x\_person\_timespan|timeSpan|SR\_ARCHIVE\_SUPPORTPERSON - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|contactSupportPerson/personExtra/x\_person\_shorttext|string|SR\_ARCHIVE\_SUPPORTPERSON - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|contactSupportPerson/personExtra/x\_person\_shorttext\_list|listAny|SR\_ARCHIVE\_SUPPORTPERSON - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|contactSupportPerson/personExtra/x\_person\_user\_relation|associate|SR\_ARCHIVE\_SUPPORTPERSON - Extra user relation: Custom person-user relation field| x |
|contactSupportPerson/personExtra/x\_person\_category\_relation|listAny|SR\_ARCHIVE\_SUPPORTPERSON - Extra category relation: Custom person-category relation| x |
|contactSupportPerson/personExtra/x\_person\_priority\_relation|listAny|SR\_ARCHIVE\_SUPPORTPERSON - Extra priority relation: Custom person-priority relation| x |
|contactSupportPerson/personExtra/x\_person\_request\_relation|stringorPK|SR\_ARCHIVE\_SUPPORTPERSON - Extra request relation: Request relation on contact| x |
|contactSupportPerson/personExtra/x\_person\_appointment\_relation|stringorPK|SR\_ARCHIVE\_SUPPORTPERSON - Extra appointment relation: Appointment relation on person| x |
|contactSupportPerson/personExtra/x\_person\_contact\_relation|stringorPK|SR\_ARCHIVE\_SUPPORTPERSON - Extra company relation: Company relation on contact| x |
|contactSupportPerson/personExtra/y\_rental/id|int|SR\_ARCHIVE\_SUPPORTPERSON - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|contactSupportPerson/personExtra/y\_rental/x\_start|date|SR\_ARCHIVE\_SUPPORTPERSON - Rental - Start rental: Start rental| x |
|contactSupportPerson/personExtra/y\_rental/x\_end|date|SR\_ARCHIVE\_SUPPORTPERSON - Rental - End: End| x |
|contactSupportPerson/personExtra/y\_rental/x\_amount|int|SR\_ARCHIVE\_SUPPORTPERSON - Rental - Amount: Number to rent. Default = 1| x |
|contactSupportPerson/personExtra/y\_rental/x\_contact|stringorPK|SR\_ARCHIVE\_SUPPORTPERSON - Rental - Renter: Company that rents equipment| x |
|contactSupportPerson/personExtra/y\_rental/y\_equipment/x\_name|string|SR\_ARCHIVE\_SUPPORTPERSON - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|contactSupportPerson/personExtra/y\_car/id|int|SR\_ARCHIVE\_SUPPORTPERSON - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|contactSupportPerson/isMailingRecipient|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|contactSupportPerson/hasStoreConsent|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/withdrawnStoreConsent|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contactSupportPerson/hasEmarketingConsent|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/withdrawnEmarketingConsent|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contactSupportPerson/subscription|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|contactSupportPerson/legalBaseStore|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|contactSupportPerson/legalBaseEmarketing|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contactSupportPerson/consentSourceStore|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|contactSupportPerson/consentSourceEmarketing|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contactInterestIds|listInterest|SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
|contactUdef/SuperOffice:3|int|companynumber| x |
|contactUdef/SuperOffice:4|date|companydate| x |
|contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x |
|contactUdef/SuperOffice:6|bool|companycheckbox| x |
|contactUdef/SuperOffice:7|listAny|companydropdownlistbox| x |
|contactUdef/SuperOffice:8|decimal|companydecimal| x |
|contactUdef/SuperOffice:9|string|page1saleonly| x |
|contactUdef/SuperOffice:10|string|page1marketingonly| x |
|contactUdef/SuperOffice:11|string|page1adminonly| x |
|contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one| x |
|contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two| x |
|contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field| x |
|contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden| x |
|contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.| x |
|contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals| x |
|contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.| x |
|contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External| x |
|contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.| x |
|contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.| x |
|contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.| x |
|contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company| x |
|contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company| x |
|contactExtra/y\_organization/x\_name|string|Organization - Name: Name| x |
|NumberOfActivities|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|NumberOfActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|NumberOfNotCompletedActivities|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|NumberOfTickets|int|SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|NumberOfTicketsInPeriod|int|SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|NumberOfNotCompletedTickets|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|NumberOfNotCompletedTicketsInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|LastTicket|date|SR\_ROU\_LAST\_TICKET|  |
|LastCompletedTicket|date|SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|LastDoByTicket|date|SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|SaintStatus1|saintStatus|Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|SaintStatus2|saintStatus|C-company: Kundens navn starter med bokstaven C|  |
|saintSaleStatus|listAny|SR\_WITH\_STATUS|  |
|saintAmountClass|listAny|SR\_AMOUNT\_CLASS|  |
|saintActivityType|listAny|SR\_ARCHIVE\_SAINT\_TYPE|  |
|saintDirection|listAny|SR\_ARCHIVE\_DIRECTION|  |
|saintIntention|listAny|SR\_ACTIVITY\_INTENTION|  |
|saintTicketStatus|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|saintTicketCategory|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|selectionMemberId|int|SR\_SELECTIONMEMBER\_ID: SR\_SELECTIONMEMBER\_ID\_TOOLTIP|  |
|selectionIdRequest|int|SR\_RESTRICTION\_SELECTIONID: SR\_RESTRICTION\_SELECTIONID\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/Contact?$select=contactSupportPerson/personUpdatedDate,NumberOfTicketsInPeriod,contactAssociate/usergroupId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


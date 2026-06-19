---
uid: MailingsSelectionV2
title: MailingsSelectionV2
description: This is the archive Provider for the Selection Mailings archive.
keywords: MailingsSelectionV2 archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "MailingsSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.MailingsSelectionProviderV2">SuperOffice.CRM.ArchiveLists.Archive.MailingsSelectionProviderV2</see> inside NetServer's SODatabase assembly.

This is the archive Provider for the Selection Mailings archive.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"mailings"|[[SR_SINGULAR_MAILING]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|mailingId|int|SR\_ARCHIVE\_MAILING\_ID: SR\_ARCHIVE\_MAILING\_ID\_TOOLTIP| x |
|mailingSelectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP| x |
|mailingDescription|string|SR\_ARCHIVE\_MAILING\_NAME: SR\_ARCHIVE\_MAILING\_NAME\_TOOLTIP| x |
|mailingSent|listAny|SR\_ARCHIVE\_MAILING\_SENT: SR\_ARCHIVE\_MAILING\_SENT\_TOOLTIP| x |
|mailingSimpleStatus|listAny|SR\_ARCHIVE\_MAILING\_STATUS: SR\_ARCHIVE\_MAILING\_STATUS| x |
|mailingEndDate|date|SR\_ARCHIVE\_MAILING\_END\_DATE: SR\_ARCHIVE\_MAILING\_END\_DATE\_TOOLTIP| x |
|mailingType|listAny|SR\_ARCHIVE\_MAILING\_TYPE: SR\_ARCHIVE\_MAILING\_TYPE\_TOOLTIP| x |
|mailingSubscriptionType|listAny|SR\_ARCHIVE\_MAILING\_SUBSCRIPTION\_TYPE: SR\_ARCHIVE\_MAILING\_SUBSCRIPTION\_TYPE\_TOOLTIP| x |
|mailingSentTo|int|SR\_ARCHIVE\_MAILING\_SENTTO: SR\_ARCHIVE\_MAILING\_SENTTO\_TOOLTIP| x |
|mailingOwner|associate|SR\_ARCHIVE\_MAILING\_OWNER: SR\_ARCHIVE\_MAILING\_OWNER\_TOOLTIP| x |
|mailingFrom|string|SR\_ARCHIVE\_MAILING\_FROM: SR\_ARCHIVE\_MAILING\_FROM\_TOOLTIP| x |
|mailingReplyTo|string|SR\_ARCHIVE\_MAILING\_REPLY\_TO: SR\_ARCHIVE\_MAILING\_REPLY\_TO| x |
|mailingSentCount|int|SR\_ARCHIVE\_MAILING\_SENT\_COUNT: SR\_ARCHIVE\_MAILING\_SENT\_COUNT\_TOOLTIP| x |
|mailingOpenRate|decimal|SR\_ARCHIVE\_MAILING\_OPEN\_RATE: SR\_ARCHIVE\_MAILING\_OPEN\_RATE\_TOOLTIP| x |
|mailingClickRate|decimal|SR\_ARCHIVE\_MAILING\_CLICK\_THROUGH\_RATE: SR\_ARCHIVE\_MAILING\_CLICK\_THROUGH\_RATE\_TOOLTIP| x |
|mailingBounceRate|decimal|SR\_ARCHIVE\_MAILING\_BOUNCE\_RATE: SR\_ARCHIVE\_MAILING\_BOUNCE\_RATE\_TOOLTIP| x |
|mailingDeleted|bool|SR\_LISTITEMARCHIVE\_DELETED: SR\_LISTITEMARCHIVE\_DELETED\_TOOLTIP|  |
|recipientStatus|listAny|SR\_ARCHIVE\_RECIPIENT\_STATUS: SR\_ARCHIVE\_RECIPIENT\_STATUS\_TOOLTIP|  |
|icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|mailingAddr/mailingAddrId|int|!!!Mailing addr Id: !!!Mailing addr Id Tooltip| x |
|mailingAddr/contact/contactId|int|SR\_SINGULAR\_COMPANY - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|mailingAddr/contact/name|stringorPK|SR\_SINGULAR\_COMPANY - SR\_COMPANY\_NAME| x |
|mailingAddr/contact/department|string|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_DEPARTEMENT| x |
|mailingAddr/contact/nameDepartment|string|SR\_SINGULAR\_COMPANY - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|mailingAddr/contact/hasInfoText|bool|SR\_SINGULAR\_COMPANY - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|mailingAddr/contact/hasInterests|bool|SR\_SINGULAR\_COMPANY - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|mailingAddr/contact/associateId|associate|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|mailingAddr/contact/category|listAny|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_CATEGORY| x |
|mailingAddr/contact/categoryGroup|listAny|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|mailingAddr/contact/companyCategoryRank|int|SR\_SINGULAR\_COMPANY - Category rank| x |
|mailingAddr/contact/business|listAny|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_BUSINESS| x |
|mailingAddr/contact/country|listAny|SR\_SINGULAR\_COMPANY - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|mailingAddr/contact/countryId|int|SR\_SINGULAR\_COMPANY - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|mailingAddr/contact/number|string|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_NUMBER| x |
|mailingAddr/contact/code|string|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_CODE| x |
|mailingAddr/contact/orgnr|string|SR\_SINGULAR\_COMPANY - VAT No.| x |
|mailingAddr/contact/stop|bool|SR\_SINGULAR\_COMPANY - SR\_CC\_STOPX| x |
|mailingAddr/contact/contactNoMail|bool|SR\_SINGULAR\_COMPANY - SR\_NO\_MAIL\_COMPANY| x |
|mailingAddr/contact/updatedBy|associate|SR\_SINGULAR\_COMPANY - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|mailingAddr/contact/updatedByFullName|associate|SR\_SINGULAR\_COMPANY - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|mailingAddr/contact/updatedDate|date|SR\_SINGULAR\_COMPANY - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|mailingAddr/contact/registeredBy|associate|SR\_SINGULAR\_COMPANY - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|mailingAddr/contact/registeredByFullName|associate|SR\_SINGULAR\_COMPANY - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|mailingAddr/contact/registeredDate|date|SR\_SINGULAR\_COMPANY - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|mailingAddr/contact/contactSource|listAny|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|mailingAddr/contact/contactDeleted|bool|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|mailingAddr/contact/phone/formattedNumber|string|SR\_SINGULAR\_COMPANY - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/contact/activeErpLinks|bool|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|mailingAddr/contact/deletedDate|datetime|SR\_SINGULAR\_COMPANY - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|mailingAddr/contact/mainContact| *None* |SR\_SINGULAR\_COMPANY - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|mailingAddr/contact/forceCompany|bool|SR\_SINGULAR\_COMPANY - Dummy: Dummy|  |
|mailingAddr/contact/contactPhone/formattedNumber|string|SR\_SINGULAR\_COMPANY - SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/contact/contactPhone/description|string|SR\_SINGULAR\_COMPANY - SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/contact/contactFax/formattedNumber|string|SR\_SINGULAR\_COMPANY - SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/contact/contactFax/description|string|SR\_SINGULAR\_COMPANY - SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/contact/searchPhone/formattedNumber|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/contact/searchPhone/description|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/contact/email/emailProtocol|string|SR\_SINGULAR\_COMPANY - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|mailingAddr/contact/email/emailAddress|string|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_EMAIL| x |
|mailingAddr/contact/email/emailDescription|string|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_DESCRIPTION| x |
|mailingAddr/contact/email/emailId|int|SR\_SINGULAR\_COMPANY - ID| x |
|mailingAddr/contact/email/emailLastSent|datetime|SR\_SINGULAR\_COMPANY - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|mailingAddr/contact/email/emailBounceCount|int|SR\_SINGULAR\_COMPANY - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|mailingAddr/contact/email/emailLastBounce|datetime|SR\_SINGULAR\_COMPANY - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|mailingAddr/contact/email/emailHasBounced|bool|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|mailingAddr/contact/postAddress/addressId|int|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|mailingAddr/contact/postAddress/line1|string|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|mailingAddr/contact/postAddress/line2|string|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|mailingAddr/contact/postAddress/line3|string|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|mailingAddr/contact/postAddress/county|string|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|mailingAddr/contact/postAddress/city|string|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|mailingAddr/contact/postAddress/zip|string|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|mailingAddr/contact/postAddress/state|string|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|mailingAddr/contact/postAddress/wgs84latitude|decimal|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|mailingAddr/contact/postAddress/wgs84longitude|decimal|SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|mailingAddr/contact/postAddress/formattedAddress| *None* |SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/postAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_COMPANY - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/streetAddress/addressId|int|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|mailingAddr/contact/streetAddress/line1|string|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|mailingAddr/contact/streetAddress/line2|string|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|mailingAddr/contact/streetAddress/line3|string|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|mailingAddr/contact/streetAddress/county|string|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|mailingAddr/contact/streetAddress/city|string|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|mailingAddr/contact/streetAddress/zip|string|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|mailingAddr/contact/streetAddress/state|string|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/contact/streetAddress/wgs84latitude|decimal|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|mailingAddr/contact/streetAddress/wgs84longitude|decimal|SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|mailingAddr/contact/streetAddress/formattedAddress| *None* |SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/streetAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_COMPANY - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/restrictionAddress/addressId|int|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|mailingAddr/contact/restrictionAddress/line1|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|mailingAddr/contact/restrictionAddress/line2|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|mailingAddr/contact/restrictionAddress/line3|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|mailingAddr/contact/restrictionAddress/county|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|mailingAddr/contact/restrictionAddress/city|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|mailingAddr/contact/restrictionAddress/zip|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|mailingAddr/contact/restrictionAddress/state|string|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|mailingAddr/contact/restrictionAddress/wgs84latitude|decimal|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|mailingAddr/contact/restrictionAddress/wgs84longitude|decimal|SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|mailingAddr/contact/restrictionAddress/formattedAddress| *None* |SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_COMPANY - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/contact/url/URLAddress|string|SR\_SINGULAR\_COMPANY - SR\_PROJECTARCHIVE\_URL| x |
|mailingAddr/contact/url/URLDescription|string|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_DESCRIPTION| x |
|mailingAddr/contact/contactAssociate/firstName|string|SR\_SINGULAR\_COMPANY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/lastName|string|SR\_SINGULAR\_COMPANY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/middleName|string|SR\_SINGULAR\_COMPANY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/fullName|string|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/contactId|int|SR\_SINGULAR\_COMPANY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|mailingAddr/contact/contactAssociate/personId|int|SR\_SINGULAR\_COMPANY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|mailingAddr/contact/contactAssociate/mrMrs|string|SR\_SINGULAR\_COMPANY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/title|string|SR\_SINGULAR\_COMPANY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/associateDbId|associate|SR\_SINGULAR\_COMPANY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|mailingAddr/contact/contactAssociate/contactName|string|SR\_SINGULAR\_COMPANY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/contactDepartment|string|SR\_SINGULAR\_COMPANY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/usergroup|userGroup|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/usergroupId|int|SR\_SINGULAR\_COMPANY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/contactFullName|string|SR\_SINGULAR\_COMPANY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/contactCategory|listAny|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|mailingAddr/contact/contactAssociate/role|listAny|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|mailingAddr/contact/contactAssociate/assocName|associate|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|mailingAddr/contact/contactAssociate/assocTooltip|string|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|mailingAddr/contact/contactAssociate/assocType|listAny|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/ejUserId|int|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|mailingAddr/contact/contactAssociate/simultaneousEjUser|bool|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|mailingAddr/contact/contactAssociate/ejDisplayName|string|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|mailingAddr/contact/contactAssociate/ejStatus|int|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|mailingAddr/contact/contactAssociate/credentialType| *None* |SR\_SINGULAR\_COMPANY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/credentialDisplayValue| *None* |SR\_SINGULAR\_COMPANY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/isActive|bool|SR\_SINGULAR\_COMPANY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/isActiveText|bool|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/portraitThumbnail| *None* |SR\_SINGULAR\_COMPANY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|mailingAddr/contact/contactAssociate/otherGroups|userGroup|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|mailingAddr/contact/contactAssociate/userName|string|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|mailingAddr/contact/contactAssociate/personEmail|string|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_EMAIL| x |
|mailingAddr/contact/contactAssociate/locationAddress|string|SR\_SINGULAR\_COMPANY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|mailingAddr/contact/contactAssociate/isLocation|bool|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|mailingAddr/contact/contactInterestIds|listInterest|SR\_SINGULAR\_COMPANY - SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|mailingAddr/contact/contactUdef/SuperOffice:1|string|SR\_SINGULAR\_COMPANY - companyshorttext: tooltipshorttext| x |
|mailingAddr/contact/contactUdef/SuperOffice:2|string|SR\_SINGULAR\_COMPANY - companylongtext: tooltiplongtext| x |
|mailingAddr/contact/contactUdef/SuperOffice:3|int|SR\_SINGULAR\_COMPANY - companynumber| x |
|mailingAddr/contact/contactUdef/SuperOffice:4|date|SR\_SINGULAR\_COMPANY - companydate| x |
|mailingAddr/contact/contactUdef/SuperOffice:5|unlimitedDate|SR\_SINGULAR\_COMPANY - companyunlimiteddate: tooltipunlimiteddate| x |
|mailingAddr/contact/contactUdef/SuperOffice:6|bool|SR\_SINGULAR\_COMPANY - companycheckbox| x |
|mailingAddr/contact/contactUdef/SuperOffice:7|listAny|SR\_SINGULAR\_COMPANY - companydropdownlistbox| x |
|mailingAddr/contact/contactUdef/SuperOffice:8|decimal|SR\_SINGULAR\_COMPANY - companydecimal| x |
|mailingAddr/contact/contactUdef/SuperOffice:9|string|SR\_SINGULAR\_COMPANY - page1saleonly| x |
|mailingAddr/contact/contactUdef/SuperOffice:10|string|SR\_SINGULAR\_COMPANY - page1marketingonly| x |
|mailingAddr/contact/contactUdef/SuperOffice:11|string|SR\_SINGULAR\_COMPANY - page1adminonly| x |
|mailingAddr/contact/contactUdef/SuperOffice:12|listAny|SR\_SINGULAR\_COMPANY - Udlist one: Static tooltip for udlist one| x |
|mailingAddr/contact/contactUdef/SuperOffice:13|listAny|SR\_SINGULAR\_COMPANY - Udlist two: Static tooltip for udlist two| x |
|mailingAddr/contact/contactExtra/x\_contact\_integer|int|SR\_SINGULAR\_COMPANY - Extra Integer: Custom integer field| x |
|mailingAddr/contact/contactExtra/x\_contact\_hidden\_integer|int|SR\_SINGULAR\_COMPANY - Extra hidden integer: Custom integer field - hidden| x |
|mailingAddr/contact/contactExtra/x\_contact\_default\_integer|int|SR\_SINGULAR\_COMPANY - Extra Default Integer: Custom integer field with default value 123.| x |
|mailingAddr/contact/contactExtra/x\_contact\_float|decimal|SR\_SINGULAR\_COMPANY - Extra Float: Custom float field with 3 decimals| x |
|mailingAddr/contact/contactExtra/x\_contact\_longtext|string|SR\_SINGULAR\_COMPANY - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|mailingAddr/contact/contactExtra/x\_contact\_dropdown|listAny|SR\_SINGULAR\_COMPANY - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|mailingAddr/contact/contactExtra/x\_contact\_date|date|SR\_SINGULAR\_COMPANY - Extra date: Custom date field. User current as default.| x |
|mailingAddr/contact/contactExtra/x\_contact\_datetime|datetime|SR\_SINGULAR\_COMPANY - Extra DateTime: Custom Date Time field. No default value. External| x |
|mailingAddr/contact/contactExtra/x\_contact\_time| *None* |SR\_SINGULAR\_COMPANY - Extra time: Custom time field.| x |
|mailingAddr/contact/contactExtra/x\_contact\_boolean|bool|SR\_SINGULAR\_COMPANY - Extra boolean: Custom boolean field.| x |
|mailingAddr/contact/contactExtra/x\_contact\_timespan|timeSpan|SR\_SINGULAR\_COMPANY - Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|mailingAddr/contact/contactExtra/x\_contact\_shorttext|string|SR\_SINGULAR\_COMPANY - Extra short text: Custom short text field. Keep HTML tags.| x |
|mailingAddr/contact/contactExtra/x\_contact\_short\_dropdown|listAny|SR\_SINGULAR\_COMPANY - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|mailingAddr/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|SR\_SINGULAR\_COMPANY - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |
|mailingAddr/contact/contactExtra/x\_contact\_request\_relation|stringorPK|SR\_SINGULAR\_COMPANY - Extra Request relation: Request relation on company| x |
|mailingAddr/contact/contactExtra/x\_contact\_contact|stringorPK|SR\_SINGULAR\_COMPANY - Extra contact relation: Contact relation on company| x |
|mailingAddr/contact/contactExtra/y\_organization/x\_name|string|SR\_SINGULAR\_COMPANY - Organization - Name: Name| x |
|mailingAddr/contact/NumberOfActivities|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|mailingAddr/contact/NumberOfActivitiesInPeriod|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|mailingAddr/contact/NumberOfNotCompletedActivities|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|mailingAddr/contact/NumberOfNotCompletedActivitiesInPeriod|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|mailingAddr/contact/LastActivity|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_ACTIVITY|  |
|mailingAddr/contact/LastCompletedActivity|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|mailingAddr/contact/LastDoByActivity|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|mailingAddr/contact/NumberOfSales|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_SALES|  |
|mailingAddr/contact/NumberOfSalesInPeriod|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|mailingAddr/contact/NumberOfNotCompletedSales|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|mailingAddr/contact/NumberOfNotCompletedSalesInPeriod|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|mailingAddr/contact/LastSale|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_SALE|  |
|mailingAddr/contact/LastCompletedSale|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|mailingAddr/contact/LastDoBySale|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|mailingAddr/contact/NumberOfTickets|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|mailingAddr/contact/NumberOfTicketsInPeriod|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|mailingAddr/contact/NumberOfNotCompletedTickets|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|mailingAddr/contact/NumberOfNotCompletedTicketsInPeriod|int|SR\_SINGULAR\_COMPANY - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/contact/LastTicket|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_TICKET|  |
|mailingAddr/contact/LastCompletedTicket|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|mailingAddr/contact/LastDoByTicket|date|SR\_SINGULAR\_COMPANY - SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|mailingAddr/contact/SaintStatus1|saintStatus|SR\_SINGULAR\_COMPANY - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|mailingAddr/contact/SaintStatus2|saintStatus|SR\_SINGULAR\_COMPANY - C-company: Kundens navn starter med bokstaven C|  |
|mailingAddr/contact/saintSaleStatus|listAny|SR\_SINGULAR\_COMPANY - SR\_WITH\_STATUS|  |
|mailingAddr/contact/saintAmountClass|listAny|SR\_SINGULAR\_COMPANY - SR\_AMOUNT\_CLASS|  |
|mailingAddr/contact/saintActivityType|listAny|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_SAINT\_TYPE|  |
|mailingAddr/contact/saintDirection|listAny|SR\_SINGULAR\_COMPANY - SR\_ARCHIVE\_DIRECTION|  |
|mailingAddr/contact/saintIntention|listAny|SR\_SINGULAR\_COMPANY - SR\_ACTIVITY\_INTENTION|  |
|mailingAddr/contact/saintTicketStatus|listAny|SR\_SINGULAR\_COMPANY - SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|mailingAddr/contact/saintTicketCategory|listAny|SR\_SINGULAR\_COMPANY - SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|mailingAddr/person/personId|int|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|mailingAddr/person/firstName|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|mailingAddr/person/lastName|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|mailingAddr/person/middleName|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|mailingAddr/person/fullName|string|SR\_SINGULAR\_CONTACT - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|mailingAddr/person/contactId|int|SR\_SINGULAR\_CONTACT - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|mailingAddr/person/hasInfoText|bool|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|mailingAddr/person/hasInterests|bool|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|mailingAddr/person/personHasInterests|bool|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|mailingAddr/person/mrMrs|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|mailingAddr/person/position|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_POSITION| x |
|mailingAddr/person/personNumber|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|mailingAddr/person/title|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|mailingAddr/person/personCountry|listAny|SR\_SINGULAR\_CONTACT - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|mailingAddr/person/personCountryId|int|SR\_SINGULAR\_CONTACT - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|mailingAddr/person/personNoMail|bool|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|mailingAddr/person/rank|int|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|mailingAddr/person/birthdate| *None* |SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|mailingAddr/person/associateType| *None* |SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|mailingAddr/person/useAsMailingAddress|bool|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|mailingAddr/person/personSource|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|mailingAddr/person/retired|bool|SR\_SINGULAR\_CONTACT - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|mailingAddr/person/birthYear|int|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|mailingAddr/person/birthMonth|int|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|mailingAddr/person/birthDay|int|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|mailingAddr/person/kanaFirstName|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|mailingAddr/person/kanaLastName|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|mailingAddr/person/personUpdatedBy|associate|SR\_SINGULAR\_CONTACT - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|mailingAddr/person/personUpdatedByFullName|associate|SR\_SINGULAR\_CONTACT - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|mailingAddr/person/personUpdatedDate|date|SR\_SINGULAR\_CONTACT - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|mailingAddr/person/personRegisteredBy|associate|SR\_SINGULAR\_CONTACT - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|mailingAddr/person/personRegisteredByFullName|associate|SR\_SINGULAR\_CONTACT - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|mailingAddr/person/personRegisteredDate|date|SR\_SINGULAR\_CONTACT - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|mailingAddr/person/portraitThumbnail| *None* |SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|mailingAddr/person/personActiveErpLinks|bool|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|mailingAddr/person/ticketPriority|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|mailingAddr/person/supportLanguage|listAny|SR\_SINGULAR\_CONTACT - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|mailingAddr/person/supportAssociate|associate|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|mailingAddr/person/supportAssociateFullName|associate|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|mailingAddr/person/personAssociateId|associate|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|mailingAddr/person/personAssociateFullName|associate|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|mailingAddr/person/personCategory|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_CATEGORY| x |
|mailingAddr/person/personCategoryGroup|listAny|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|mailingAddr/person/personCategoryRank|int|SR\_SINGULAR\_CONTACT - !!Category rank| x |
|mailingAddr/person/personBusiness|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_BUSINESS| x |
|mailingAddr/person/leadStatus|listAny|SR\_SINGULAR\_CONTACT - SR\_LABEL\_LEADSTATUS| x |
|mailingAddr/person/leadstatusRank|int|SR\_SINGULAR\_CONTACT - !!Lead status RANK| x |
|mailingAddr/person/personDeletedDate|datetime|SR\_SINGULAR\_CONTACT - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|mailingAddr/person/hasCompany|bool|SR\_SINGULAR\_CONTACT - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|mailingAddr/person/isProjectMember|bool|SR\_SINGULAR\_CONTACT - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|mailingAddr/person/isStakeholder|bool|SR\_SINGULAR\_CONTACT - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|mailingAddr/person/updatedByWorkflow|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|mailingAddr/person/whenUpdatedByWorkflow|datetime|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|mailingAddr/person/createdByForm|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|mailingAddr/person/phone/formattedNumber|string|SR\_SINGULAR\_CONTACT - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/person/personDirectPhone/formattedNumber|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/person/personDirectPhone/description|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/person/personMobilePhone/formattedNumber|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/person/personMobilePhone/description|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/person/personPrivate/formattedNumber|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/person/personPrivate/description|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/person/personPager/formattedNumber|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/person/personPager/description|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/person/personDirectFax/formattedNumber|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/person/personDirectFax/description|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/person/searchPhone/formattedNumber|string|SR\_SINGULAR\_CONTACT - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|mailingAddr/person/searchPhone/description|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|mailingAddr/person/personInfo/textId|int|SR\_SINGULAR\_CONTACT - Text ID| x |
|mailingAddr/person/personInfo/infoText|positiveString|SR\_SINGULAR\_CONTACT - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|mailingAddr/person/email/emailProtocol|string|SR\_SINGULAR\_CONTACT - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|mailingAddr/person/email/emailAddress|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_EMAIL| x |
|mailingAddr/person/email/emailDescription|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_DESCRIPTION| x |
|mailingAddr/person/email/emailId|int|SR\_SINGULAR\_CONTACT - ID| x |
|mailingAddr/person/email/emailLastSent|datetime|SR\_SINGULAR\_CONTACT - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|mailingAddr/person/email/emailBounceCount|int|SR\_SINGULAR\_CONTACT - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|mailingAddr/person/email/emailLastBounce|datetime|SR\_SINGULAR\_CONTACT - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|mailingAddr/person/email/emailHasBounced|bool|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|mailingAddr/person/personUrl/URLAddress|string|SR\_SINGULAR\_CONTACT - SR\_PROJECTARCHIVE\_URL| x |
|mailingAddr/person/personUrl/URLDescription|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_DESCRIPTION| x |
|mailingAddr/person/personAddress/addressId|int|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|mailingAddr/person/personAddress/line1|string|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|mailingAddr/person/personAddress/line2|string|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|mailingAddr/person/personAddress/line3|string|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|mailingAddr/person/personAddress/county|string|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|mailingAddr/person/personAddress/city|string|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|mailingAddr/person/personAddress/zip|string|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|mailingAddr/person/personAddress/state|string|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|mailingAddr/person/personAddress/wgs84latitude|decimal|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/person/personAddress/wgs84longitude|decimal|SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|mailingAddr/person/personAddress/formattedAddress| *None* |SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/personAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_CONTACT - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/restrictionAddress/addressId|int|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|mailingAddr/person/restrictionAddress/line1|string|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|mailingAddr/person/restrictionAddress/line2|string|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|mailingAddr/person/restrictionAddress/line3|string|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|mailingAddr/person/restrictionAddress/county|string|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|mailingAddr/person/restrictionAddress/city|string|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|mailingAddr/person/restrictionAddress/zip|string|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|mailingAddr/person/restrictionAddress/state|string|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|mailingAddr/person/restrictionAddress/wgs84latitude|decimal|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|mailingAddr/person/restrictionAddress/wgs84longitude|decimal|SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|mailingAddr/person/restrictionAddress/formattedAddress| *None* |SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_SINGULAR\_CONTACT - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|mailingAddr/person/personInterestIds|listInterest|SR\_SINGULAR\_CONTACT - SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|mailingAddr/person/personUdef/SuperOffice:1|string|SR\_SINGULAR\_CONTACT - contactshorttext: tooltipshorttext| x |
|mailingAddr/person/personUdef/SuperOffice:2|string|SR\_SINGULAR\_CONTACT - contactlongtext: tooltiplongtext| x |
|mailingAddr/person/personUdef/SuperOffice:3|int|SR\_SINGULAR\_CONTACT - contactnumber| x |
|mailingAddr/person/personUdef/SuperOffice:4|date|SR\_SINGULAR\_CONTACT - contactdate| x |
|mailingAddr/person/personUdef/SuperOffice:5|unlimitedDate|SR\_SINGULAR\_CONTACT - contactunlimiteddate: tooltipunlimiteddate| x |
|mailingAddr/person/personUdef/SuperOffice:6|bool|SR\_SINGULAR\_CONTACT - contactcheckbox| x |
|mailingAddr/person/personUdef/SuperOffice:7|listAny|SR\_SINGULAR\_CONTACT - contactdropdownlistbox| x |
|mailingAddr/person/personUdef/SuperOffice:8|decimal|SR\_SINGULAR\_CONTACT - contactdecimal| x |
|mailingAddr/person/personUdef/SuperOffice:9|string|SR\_SINGULAR\_CONTACT - page1saleonly| x |
|mailingAddr/person/personUdef/SuperOffice:10|string|SR\_SINGULAR\_CONTACT - page1marketingonly| x |
|mailingAddr/person/personUdef/SuperOffice:11|string|SR\_SINGULAR\_CONTACT - page1adminonly| x |
|mailingAddr/person/personExtra/x\_person\_integer|int|SR\_SINGULAR\_CONTACT - Extra Integer: Custom person integer| x |
|mailingAddr/person/personExtra/x\_person\_hidden\_integer|int|SR\_SINGULAR\_CONTACT - Extra hidden integer: Custom integer field that is hidden| x |
|mailingAddr/person/personExtra/x\_person\_float|decimal|SR\_SINGULAR\_CONTACT - Extra float: Custom float field| x |
|mailingAddr/person/personExtra/x\_person\_longtext|string|SR\_SINGULAR\_CONTACT - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|mailingAddr/person/personExtra/x\_person\_date|date|SR\_SINGULAR\_CONTACT - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|mailingAddr/person/personExtra/x\_person\_datetime|datetime|SR\_SINGULAR\_CONTACT - Extra DateTime: Custom person date and time field. No default| x |
|mailingAddr/person/personExtra/x\_person\_time| *None* |SR\_SINGULAR\_CONTACT - Extra time: Custom time field on person. Current time as default| x |
|mailingAddr/person/personExtra/x\_person\_boolean|bool|SR\_SINGULAR\_CONTACT - Extra Boolean: Custom boolean field on person. Default checked| x |
|mailingAddr/person/personExtra/x\_person\_timespan|timeSpan|SR\_SINGULAR\_CONTACT - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|mailingAddr/person/personExtra/x\_person\_shorttext|string|SR\_SINGULAR\_CONTACT - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|mailingAddr/person/personExtra/x\_person\_shorttext\_list|listAny|SR\_SINGULAR\_CONTACT - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|mailingAddr/person/personExtra/x\_person\_user\_relation|associate|SR\_SINGULAR\_CONTACT - Extra user relation: Custom person-user relation field| x |
|mailingAddr/person/personExtra/x\_person\_category\_relation|listAny|SR\_SINGULAR\_CONTACT - Extra category relation: Custom person-category relation| x |
|mailingAddr/person/personExtra/x\_person\_priority\_relation|listAny|SR\_SINGULAR\_CONTACT - Extra priority relation: Custom person-priority relation| x |
|mailingAddr/person/personExtra/x\_person\_request\_relation|stringorPK|SR\_SINGULAR\_CONTACT - Extra request relation: Request relation on contact| x |
|mailingAddr/person/personExtra/x\_person\_appointment\_relation|stringorPK|SR\_SINGULAR\_CONTACT - Extra appointment relation: Appointment relation on person| x |
|mailingAddr/person/personExtra/x\_person\_contact\_relation|stringorPK|SR\_SINGULAR\_CONTACT - Extra company relation: Company relation on contact| x |
|mailingAddr/person/personExtra/y\_rental/id|int|SR\_SINGULAR\_CONTACT - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|mailingAddr/person/personExtra/y\_rental/x\_start|date|SR\_SINGULAR\_CONTACT - Rental - Start rental: Start rental| x |
|mailingAddr/person/personExtra/y\_rental/x\_end|date|SR\_SINGULAR\_CONTACT - Rental - End: End| x |
|mailingAddr/person/personExtra/y\_rental/x\_amount|int|SR\_SINGULAR\_CONTACT - Rental - Amount: Number to rent. Default = 1| x |
|mailingAddr/person/personExtra/y\_rental/x\_contact|stringorPK|SR\_SINGULAR\_CONTACT - Rental - Renter: Company that rents equipment| x |
|mailingAddr/person/personExtra/y\_rental/y\_equipment/x\_name|string|SR\_SINGULAR\_CONTACT - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|mailingAddr/person/personExtra/y\_car/id|int|SR\_SINGULAR\_CONTACT - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|mailingAddr/person/personAssociate/firstName|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|mailingAddr/person/personAssociate/lastName|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|mailingAddr/person/personAssociate/middleName|string|SR\_SINGULAR\_CONTACT - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|mailingAddr/person/personAssociate/fullName|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|mailingAddr/person/personAssociate/contactId|int|SR\_SINGULAR\_CONTACT - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|mailingAddr/person/personAssociate/personId|int|SR\_SINGULAR\_CONTACT - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|mailingAddr/person/personAssociate/mrMrs|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|mailingAddr/person/personAssociate/title|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|mailingAddr/person/personAssociate/associateDbId|associate|SR\_SINGULAR\_CONTACT - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|mailingAddr/person/personAssociate/contactName|string|SR\_SINGULAR\_CONTACT - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|mailingAddr/person/personAssociate/contactDepartment|string|SR\_SINGULAR\_CONTACT - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|mailingAddr/person/personAssociate/usergroup|userGroup|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|mailingAddr/person/personAssociate/usergroupId|int|SR\_SINGULAR\_CONTACT - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|mailingAddr/person/personAssociate/contactFullName|string|SR\_SINGULAR\_CONTACT - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|mailingAddr/person/personAssociate/contactCategory|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|mailingAddr/person/personAssociate/role|listAny|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|mailingAddr/person/personAssociate/assocName|associate|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|mailingAddr/person/personAssociate/assocTooltip|string|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|mailingAddr/person/personAssociate/assocType|listAny|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|mailingAddr/person/personAssociate/ejUserId|int|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|mailingAddr/person/personAssociate/simultaneousEjUser|bool|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|mailingAddr/person/personAssociate/ejDisplayName|string|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|mailingAddr/person/personAssociate/ejStatus|int|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|mailingAddr/person/personAssociate/credentialType| *None* |SR\_SINGULAR\_CONTACT - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|mailingAddr/person/personAssociate/credentialDisplayValue| *None* |SR\_SINGULAR\_CONTACT - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|mailingAddr/person/personAssociate/isActive|bool|SR\_SINGULAR\_CONTACT - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|mailingAddr/person/personAssociate/isActiveText|bool|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|mailingAddr/person/personAssociate/portraitThumbnail| *None* |SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|mailingAddr/person/personAssociate/otherGroups|userGroup|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|mailingAddr/person/personAssociate/userName|string|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|mailingAddr/person/personAssociate/personEmail|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_EMAIL| x |
|mailingAddr/person/personAssociate/locationAddress|string|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|mailingAddr/person/personAssociate/isLocation|bool|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|mailingAddr/person/correspondingAssociate/firstName|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/lastName|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/middleName|string|SR\_SINGULAR\_CONTACT - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/fullName|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/contactId|int|SR\_SINGULAR\_CONTACT - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|mailingAddr/person/correspondingAssociate/personId|int|SR\_SINGULAR\_CONTACT - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|mailingAddr/person/correspondingAssociate/mrMrs|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/title|string|SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/associateDbId|associate|SR\_SINGULAR\_CONTACT - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|mailingAddr/person/correspondingAssociate/contactName|string|SR\_SINGULAR\_CONTACT - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/contactDepartment|string|SR\_SINGULAR\_CONTACT - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/usergroup|userGroup|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/usergroupId|int|SR\_SINGULAR\_CONTACT - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/contactFullName|string|SR\_SINGULAR\_CONTACT - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/contactCategory|listAny|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|mailingAddr/person/correspondingAssociate/role|listAny|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|mailingAddr/person/correspondingAssociate/assocName|associate|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|mailingAddr/person/correspondingAssociate/assocTooltip|string|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|mailingAddr/person/correspondingAssociate/assocType|listAny|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/ejUserId|int|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|mailingAddr/person/correspondingAssociate/simultaneousEjUser|bool|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|mailingAddr/person/correspondingAssociate/ejDisplayName|string|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|mailingAddr/person/correspondingAssociate/ejStatus|int|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|mailingAddr/person/correspondingAssociate/credentialType| *None* |SR\_SINGULAR\_CONTACT - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/credentialDisplayValue| *None* |SR\_SINGULAR\_CONTACT - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/isActive|bool|SR\_SINGULAR\_CONTACT - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/isActiveText|bool|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/portraitThumbnail| *None* |SR\_SINGULAR\_CONTACT - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|mailingAddr/person/correspondingAssociate/otherGroups|userGroup|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|mailingAddr/person/correspondingAssociate/userName|string|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|mailingAddr/person/correspondingAssociate/personEmail|string|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_EMAIL| x |
|mailingAddr/person/correspondingAssociate/locationAddress|string|SR\_SINGULAR\_CONTACT - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|mailingAddr/person/correspondingAssociate/isLocation|bool|SR\_SINGULAR\_CONTACT - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|mailingAddr/person/isMailingRecipient|bool|SR\_SINGULAR\_CONTACT - SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|mailingAddr/person/hasStoreConsent|bool|SR\_SINGULAR\_CONTACT - SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|mailingAddr/person/withdrawnStoreConsent|bool|SR\_SINGULAR\_CONTACT - SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|mailingAddr/person/hasEmarketingConsent|bool|SR\_SINGULAR\_CONTACT - SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|mailingAddr/person/withdrawnEmarketingConsent|bool|SR\_SINGULAR\_CONTACT - SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|mailingAddr/person/subscription|listAny|SR\_SINGULAR\_CONTACT - SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|mailingAddr/person/legalBaseStore|listAny|SR\_SINGULAR\_CONTACT - SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|mailingAddr/person/legalBaseEmarketing|listAny|SR\_SINGULAR\_CONTACT - SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|mailingAddr/person/consentSourceStore|listAny|SR\_SINGULAR\_CONTACT - SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|mailingAddr/person/consentSourceEmarketing|listAny|SR\_SINGULAR\_CONTACT - SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
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
|emailFlow/emailFlowId|int|SR\_ARCHIVE\_EMAILFLOW\_ID: SR\_ARCHIVE\_EMAILFLOW\_ID\_TOOLTIP| x |
|emailFlow/emailFlowHierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|emailFlow/shipmentType|listAny|SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE: SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE\_TOOLTIP| x |
|emailFlow/overrideConsentSubscription|bool|SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION: SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION\_TOOLTIP| x |
|emailFlow/thumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|emailFlow/mediumThumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|emailFlow/workflowId|int|SR\_ARCHIVE\_WORKFLOW\_ID: SR\_ARCHIVE\_WORKFLOW\_ID\_TOOLTIP| x |
|emailFlow/workflowName|string|SR\_ARCHIVE\_WORKFLOW\_NAME: SR\_ARCHIVE\_WORKFLOW\_NAME\_TOOLTIP| x |
|emailFlow/workflowDescription|string|SR\_ARCHIVE\_WORKFLOW\_DESC: SR\_ARCHIVE\_WORKFLOW\_DESC\_TOOLTIP| x |
|emailFlow/workflowDefinitionStatus|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|emailFlow/workflowDefinitionStatusId|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|emailFlow/jumpToFinish|bool|SR\_ARCHIVE\_WORKFLOW\_JUMP\_TO\_FINISH: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_JUMP\_TO\_FINISH\_TOOLTIP| x |
|emailFlow/startOnlyOnce|bool|SR\_ARCHIVE\_WORKFLOW\_START\_ONLY\_ONCE: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_START\_ONLY\_ONCE\_TOOLTIP| x |
|emailFlow/workflowEnrolledCount| *None* |SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowInProgressCount| *None* |SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT: SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT\_TOOLTIP|  |
|emailFlow/workflowCompletedCount| *None* |SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowSucceededCount| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowSuccessRate| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE: SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE\_TOOLTIP|  |
|emailFlow/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|emailFlow/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|emailFlow/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|emailFlow/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|emailFlow/workflowAssociate/firstName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|emailFlow/workflowAssociate/lastName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|emailFlow/workflowAssociate/middleName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|emailFlow/workflowAssociate/fullName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|emailFlow/workflowAssociate/contactId|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|emailFlow/workflowAssociate/personId|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|emailFlow/workflowAssociate/mrMrs|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|emailFlow/workflowAssociate/title|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|emailFlow/workflowAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|emailFlow/workflowAssociate/contactName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|emailFlow/workflowAssociate/contactDepartment|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|emailFlow/workflowAssociate/usergroup|userGroup|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|emailFlow/workflowAssociate/usergroupId|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|emailFlow/workflowAssociate/contactFullName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|emailFlow/workflowAssociate/contactCategory|listAny|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|emailFlow/workflowAssociate/role|listAny|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|emailFlow/workflowAssociate/assocName|associate|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|emailFlow/workflowAssociate/assocTooltip|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|emailFlow/workflowAssociate/assocType|listAny|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|emailFlow/workflowAssociate/ejUserId|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|emailFlow/workflowAssociate/simultaneousEjUser|bool|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|emailFlow/workflowAssociate/ejDisplayName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|emailFlow/workflowAssociate/ejStatus|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|emailFlow/workflowAssociate/credentialType| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|emailFlow/workflowAssociate/credentialDisplayValue| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|emailFlow/workflowAssociate/isActive|bool|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|emailFlow/workflowAssociate/isActiveText|bool|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|emailFlow/workflowAssociate/portraitThumbnail| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|emailFlow/workflowAssociate/otherGroups|userGroup|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|emailFlow/workflowAssociate/userName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|emailFlow/workflowAssociate/personEmail|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_EMAIL| x |
|emailFlow/workflowAssociate/locationAddress|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|emailFlow/workflowAssociate/isLocation|bool|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|emailFlow/hierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|emailFlow/hierarchyFullname|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|emailFlow/hierarchyName|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|emailFlow/hierarchyParentId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|emailFlow/hierarchyFullpathIds| *None* |SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS: SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS\_TOOLTIP|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|selectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|selectionMemberId| *None* |SR\_SELECTIONMEMBER\_ID: SR\_SELECTIONMEMBER\_ID\_TOOLTIP|  |
|rowKind| *None* |SR\_SELECTION\_ROWKIND: SR\_SELECTION\_ROWKIND\_TOOLTIP|  |
|targetTableNumber| *None* |TargetTableNumber: TargetTableNumber| x |
|targetRecordId| *None* |TargetRecordId: TargetRecordId| x |

## Sample

```http!
GET /api/v1/archive/MailingsSelectionV2?$select=mailingAddr/contact/associateId,mailingAddr/contact/restrictionAddress/line2,mailingAddr/contact/contactExtra/x_contact_boolean,mailingAddr/person/legalBaseEmarketing,associate/usergroupId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


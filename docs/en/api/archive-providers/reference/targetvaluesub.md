---
uid: TargetValueSub
title: TargetValueSub
description: Archive of TargetValue - used by .
keywords: TargetValueSub archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "TargetValueSub"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TargetValueSubProvider">SuperOffice.CRM.ArchiveLists.TargetValueSubProvider</see> inside NetServer's SODatabase assembly.

Archive of TargetValue - used by .

## Supported Entities
| Name | Description |
| ---- | ----- |
|"targetValue"|targetValue|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|targetValue|int|!!Target value: !!Target value|  |
|targetPeriodNumber|int|!!TargetPeriodNumber: !!TargetPeriodNumber|  |
|targetAssociate|associate|!!TargetAssociate: !!TargetAssociate|  |
|targetContactId|int|!!TargetContact: !!TargetContact|  |
|targetUserGroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|targetYear|int|!!TargetYear: !!TargetYear|  |
|targetCurrency|listAny|SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP|  |
|targetPeriod|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|targetPeriodType|int|targetPeriodType: targetPeriodType|  |
|targetAssignmentId|int|targetAssignmentId: targetAssignmentId|  |
|targetDimensionEntityType|listAny|!!targetDimensionEntityType: !!targetDimensionEntityType|  |
|targetDimensionMeasurementUnit|listAny|!!targetDimensionMeasurementUnit: !!targetDimensionMeasurementUnit|  |
|targetDimensionListField|string|!!targetDimensionListField: !!targetDimensionListField|  |
|targetAssignmentDimensionItemId|intArray|!!targetAssignmentDimensionItemId: !!targetAssignmentDimensionItemId|  |
|targetDimensionTargetTypeName|listAny|!!targetDimensionTargetTypeName: !!targetDimensionTargetTypeName|  |
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

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/postAddress/county|string|SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|contact/postAddress/city|string|SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|contact/postAddress/zip|string|SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|contact/postAddress/state|string|SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|contact/postAddress/wgs84latitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|contact/postAddress/wgs84longitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|contact/postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionPostalAddress/addressId|int|SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|contact/restrictionPostalAddress/line1|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|contact/restrictionPostalAddress/line2|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|contact/restrictionPostalAddress/line3|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|contact/restrictionPostalAddress/county|string|SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|contact/restrictionPostalAddress/city|string|SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|contact/restrictionPostalAddress/zip|string|SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|contact/restrictionPostalAddress/state|string|SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|contact/restrictionPostalAddress/wgs84latitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|contact/restrictionPostalAddress/wgs84longitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|contact/restrictionPostalAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionPostalAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
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
|contact/contactSupportAssociate/firstName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|contact/contactSupportAssociate/lastName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|contact/contactSupportAssociate/middleName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|contact/contactSupportAssociate/fullName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|contact/contactSupportAssociate/contactId|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|contact/contactSupportAssociate/personId|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|contact/contactSupportAssociate/mrMrs|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contact/contactSupportAssociate/title|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contact/contactSupportAssociate/associateDbId|associate|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|contact/contactSupportAssociate/contactName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|contact/contactSupportAssociate/contactDepartment|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|contact/contactSupportAssociate/usergroup|userGroup|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contact/contactSupportAssociate/usergroupId|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contact/contactSupportAssociate/contactFullName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|contact/contactSupportAssociate/contactCategory|listAny|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|contact/contactSupportAssociate/role|listAny|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|contact/contactSupportAssociate/assocName|associate|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|contact/contactSupportAssociate/assocTooltip|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|contact/contactSupportAssociate/assocType|listAny|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|contact/contactSupportAssociate/ejUserId|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|contact/contactSupportAssociate/simultaneousEjUser|bool|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/contactSupportAssociate/ejDisplayName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|contact/contactSupportAssociate/ejStatus|int|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|contact/contactSupportAssociate/credentialType| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|contact/contactSupportAssociate/credentialDisplayValue| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|contact/contactSupportAssociate/isActive|bool|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|contact/contactSupportAssociate/isActiveText|bool|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|contact/contactSupportAssociate/portraitThumbnail| *None* |SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contact/contactSupportAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|contact/contactSupportAssociate/userName|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|contact/contactSupportAssociate/personEmail|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_EMAIL| x |
|contact/contactSupportAssociate/locationAddress|string|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|contact/contactSupportAssociate/isLocation|bool|SR\_ARCHIVE\_OURSUPPORTCONTACT - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|contact/contactSupportPerson/personId|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|contact/contactSupportPerson/firstName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|contact/contactSupportPerson/lastName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|contact/contactSupportPerson/middleName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|contact/contactSupportPerson/fullName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|contact/contactSupportPerson/contactId|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|contact/contactSupportPerson/hasInfoText|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|contact/contactSupportPerson/hasInterests|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|contact/contactSupportPerson/personHasInterests|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|contact/contactSupportPerson/mrMrs|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contact/contactSupportPerson/position|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_POSITION| x |
|contact/contactSupportPerson/personNumber|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|contact/contactSupportPerson/title|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|contact/contactSupportPerson/personCountry|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|contact/contactSupportPerson/personCountryId|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|contact/contactSupportPerson/personNoMail|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|contact/contactSupportPerson/rank|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|contact/contactSupportPerson/birthdate| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|contact/contactSupportPerson/associateType| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|contact/contactSupportPerson/useAsMailingAddress|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|contact/contactSupportPerson/personSource|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|contact/contactSupportPerson/retired|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|contact/contactSupportPerson/birthYear|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|contact/contactSupportPerson/birthMonth|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|contact/contactSupportPerson/birthDay|int|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|contact/contactSupportPerson/kanaFirstName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|contact/contactSupportPerson/kanaLastName|string|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|contact/contactSupportPerson/personUpdatedBy|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|contact/contactSupportPerson/personUpdatedByFullName|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|contact/contactSupportPerson/personUpdatedDate|date|SR\_ARCHIVE\_SUPPORTPERSON - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|contact/contactSupportPerson/personRegisteredBy|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|contact/contactSupportPerson/personRegisteredByFullName|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|contact/contactSupportPerson/personRegisteredDate|date|SR\_ARCHIVE\_SUPPORTPERSON - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|contact/contactSupportPerson/portraitThumbnail| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contact/contactSupportPerson/personActiveErpLinks|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|contact/contactSupportPerson/ticketPriority|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|contact/contactSupportPerson/supportLanguage|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|contact/contactSupportPerson/supportAssociate|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|contact/contactSupportPerson/supportAssociateFullName|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|contact/contactSupportPerson/personAssociateId|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|contact/contactSupportPerson/personAssociateFullName|associate|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|contact/contactSupportPerson/personCategory|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_CATEGORY| x |
|contact/contactSupportPerson/personCategoryGroup|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|contact/contactSupportPerson/personCategoryRank|int|SR\_ARCHIVE\_SUPPORTPERSON - !!Category rank| x |
|contact/contactSupportPerson/personBusiness|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_BUSINESS| x |
|contact/contactSupportPerson/leadStatus|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_LABEL\_LEADSTATUS| x |
|contact/contactSupportPerson/leadstatusRank|int|SR\_ARCHIVE\_SUPPORTPERSON - !!Lead status RANK| x |
|contact/contactSupportPerson/personDeletedDate|datetime|SR\_ARCHIVE\_SUPPORTPERSON - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|contact/contactSupportPerson/hasCompany|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|contact/contactSupportPerson/isProjectMember|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|contact/contactSupportPerson/isStakeholder|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|contact/contactSupportPerson/updatedByWorkflow|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|contact/contactSupportPerson/whenUpdatedByWorkflow|datetime|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|contact/contactSupportPerson/createdByForm|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|contact/contactSupportPerson/who| *None* |SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONTACTSELECTIONARCHIVE\_PERSONFULLNAME: SR\_CONTACTSELECTIONARCHIVE\_PERSONFULLNAME\_TOOLTIP| x |
|contact/contactSupportPerson/personInfo/textId|int|SR\_ARCHIVE\_SUPPORTPERSON - Text ID| x |
|contact/contactSupportPerson/personInfo/infoText|positiveString|SR\_ARCHIVE\_SUPPORTPERSON - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|contact/contactSupportPerson/personUdef/SuperOffice:1|string|SR\_ARCHIVE\_SUPPORTPERSON - contactshorttext: tooltipshorttext| x |
|contact/contactSupportPerson/personUdef/SuperOffice:2|string|SR\_ARCHIVE\_SUPPORTPERSON - contactlongtext: tooltiplongtext| x |
|contact/contactSupportPerson/personUdef/SuperOffice:3|int|SR\_ARCHIVE\_SUPPORTPERSON - contactnumber| x |
|contact/contactSupportPerson/personUdef/SuperOffice:4|date|SR\_ARCHIVE\_SUPPORTPERSON - contactdate| x |
|contact/contactSupportPerson/personUdef/SuperOffice:5|unlimitedDate|SR\_ARCHIVE\_SUPPORTPERSON - contactunlimiteddate: tooltipunlimiteddate| x |
|contact/contactSupportPerson/personUdef/SuperOffice:6|bool|SR\_ARCHIVE\_SUPPORTPERSON - contactcheckbox| x |
|contact/contactSupportPerson/personUdef/SuperOffice:7|listAny|SR\_ARCHIVE\_SUPPORTPERSON - contactdropdownlistbox| x |
|contact/contactSupportPerson/personUdef/SuperOffice:8|decimal|SR\_ARCHIVE\_SUPPORTPERSON - contactdecimal| x |
|contact/contactSupportPerson/personUdef/SuperOffice:9|string|SR\_ARCHIVE\_SUPPORTPERSON - page1saleonly| x |
|contact/contactSupportPerson/personUdef/SuperOffice:10|string|SR\_ARCHIVE\_SUPPORTPERSON - page1marketingonly| x |
|contact/contactSupportPerson/personUdef/SuperOffice:11|string|SR\_ARCHIVE\_SUPPORTPERSON - page1adminonly| x |
|contact/contactSupportPerson/personExtra/x\_person\_integer|int|SR\_ARCHIVE\_SUPPORTPERSON - Extra Integer: Custom person integer| x |
|contact/contactSupportPerson/personExtra/x\_person\_hidden\_integer|int|SR\_ARCHIVE\_SUPPORTPERSON - Extra hidden integer: Custom integer field that is hidden| x |
|contact/contactSupportPerson/personExtra/x\_person\_float|decimal|SR\_ARCHIVE\_SUPPORTPERSON - Extra float: Custom float field| x |
|contact/contactSupportPerson/personExtra/x\_person\_longtext|string|SR\_ARCHIVE\_SUPPORTPERSON - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|contact/contactSupportPerson/personExtra/x\_person\_date|date|SR\_ARCHIVE\_SUPPORTPERSON - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|contact/contactSupportPerson/personExtra/x\_person\_datetime|datetime|SR\_ARCHIVE\_SUPPORTPERSON - Extra DateTime: Custom person date and time field. No default| x |
|contact/contactSupportPerson/personExtra/x\_person\_time| *None* |SR\_ARCHIVE\_SUPPORTPERSON - Extra time: Custom time field on person. Current time as default| x |
|contact/contactSupportPerson/personExtra/x\_person\_boolean|bool|SR\_ARCHIVE\_SUPPORTPERSON - Extra Boolean: Custom boolean field on person. Default checked| x |
|contact/contactSupportPerson/personExtra/x\_person\_timespan|timeSpan|SR\_ARCHIVE\_SUPPORTPERSON - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|contact/contactSupportPerson/personExtra/x\_person\_shorttext|string|SR\_ARCHIVE\_SUPPORTPERSON - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|contact/contactSupportPerson/personExtra/x\_person\_shorttext\_list|listAny|SR\_ARCHIVE\_SUPPORTPERSON - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|contact/contactSupportPerson/personExtra/x\_person\_user\_relation|associate|SR\_ARCHIVE\_SUPPORTPERSON - Extra user relation: Custom person-user relation field| x |
|contact/contactSupportPerson/personExtra/x\_person\_category\_relation|listAny|SR\_ARCHIVE\_SUPPORTPERSON - Extra category relation: Custom person-category relation| x |
|contact/contactSupportPerson/personExtra/x\_person\_priority\_relation|listAny|SR\_ARCHIVE\_SUPPORTPERSON - Extra priority relation: Custom person-priority relation| x |
|contact/contactSupportPerson/personExtra/x\_person\_request\_relation|stringorPK|SR\_ARCHIVE\_SUPPORTPERSON - Extra request relation: Request relation on contact| x |
|contact/contactSupportPerson/personExtra/x\_person\_appointment\_relation|stringorPK|SR\_ARCHIVE\_SUPPORTPERSON - Extra appointment relation: Appointment relation on person| x |
|contact/contactSupportPerson/personExtra/x\_person\_contact\_relation|stringorPK|SR\_ARCHIVE\_SUPPORTPERSON - Extra company relation: Company relation on contact| x |
|contact/contactSupportPerson/personExtra/y\_rental/id|int|SR\_ARCHIVE\_SUPPORTPERSON - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|contact/contactSupportPerson/personExtra/y\_rental/x\_start|date|SR\_ARCHIVE\_SUPPORTPERSON - Rental - Start rental: Start rental| x |
|contact/contactSupportPerson/personExtra/y\_rental/x\_end|date|SR\_ARCHIVE\_SUPPORTPERSON - Rental - End: End| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/contactSupportPerson/personExtra/y\_rental/x\_amount|int|SR\_ARCHIVE\_SUPPORTPERSON - Rental - Amount: Number to rent. Default = 1| x |
|contact/contactSupportPerson/personExtra/y\_rental/x\_contact|stringorPK|SR\_ARCHIVE\_SUPPORTPERSON - Rental - Renter: Company that rents equipment| x |
|contact/contactSupportPerson/personExtra/y\_rental/y\_equipment/x\_name|string|SR\_ARCHIVE\_SUPPORTPERSON - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|contact/contactSupportPerson/personExtra/y\_car/id|int|SR\_ARCHIVE\_SUPPORTPERSON - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|contact/contactSupportPerson/isMailingRecipient|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|contact/contactSupportPerson/hasStoreConsent|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contact/contactSupportPerson/withdrawnStoreConsent|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|contact/contactSupportPerson/hasEmarketingConsent|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contact/contactSupportPerson/withdrawnEmarketingConsent|bool|SR\_ARCHIVE\_SUPPORTPERSON - SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|contact/contactSupportPerson/subscription|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|contact/contactSupportPerson/legalBaseStore|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|contact/contactSupportPerson/legalBaseEmarketing|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contact/contactSupportPerson/consentSourceStore|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|contact/contactSupportPerson/consentSourceEmarketing|listAny|SR\_ARCHIVE\_SUPPORTPERSON - SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|contact/contactInterestIds|listInterest|SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext| x |
|contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext| x |
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
|contact/selectionMemberId|int|SR\_SELECTIONMEMBER\_ID: SR\_SELECTIONMEMBER\_ID\_TOOLTIP|  |
|contact/selectionIdRequest|int|SR\_RESTRICTION\_SELECTIONID: SR\_RESTRICTION\_SELECTIONID\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/TargetValueSub?$select=contact/streetAddress/addressId,contact/contactSupportAssociate/role,contact/contactSupportPerson/whenUpdatedByWorkflow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


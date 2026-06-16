---
uid: SaleGuide
title: SaleGuide
description: Provider for the Sale Guide, common to both Appointment and Document guide items and instances
keywords: SaleGuide archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "SaleGuide"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SaleGuideProvider">SuperOffice.CRM.ArchiveLists.SaleGuideProvider</see> inside NetServer's SODatabase assembly.

Provider for the Sale Guide, common to both Appointment and Document guide items and instances

This provider is a trivial aggregation of the Appointment and Document providers

## Supported Entities
| Name | Description |
| ---- | ----- |
|"suggestedAppointment"|[[SR_ARCHIVE_SALEGUIDEAPPNT_DESC]]|
|"appointment"|[[SR_AA_FOLLOWUPS]]|
|"suggestedDocument"|[[SR_ARCHIVE_SALEGUIDEDOC_DESC]]|
|"document"|[[SR_AA_DOCUMENTS]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|stageName|string|SR\_ARCHIVE\_STAGENAME: SR\_ARCHIVE\_STAGENAME\_TOOLTIP| x |
|stageId|int|SR\_ARCHIVE\_STAGEID: SR\_ARCHIVE\_STAGEID\_TOOLTIP| x |
|stageOrderBy|int|SR\_ARCHIVE\_STAGEORDERBY: SR\_ARCHIVE\_STAGEORDERBY\_TOOLTIP| x |
|suggestedItemId|int|SR\_ARCHIVE\_SUGGESTEDITEMID: SR\_ARCHIVE\_SUGGESTEDITEMID\_TOOLTIP| x |
|suggestedItemText|string|SR\_ARCHIVE\_SUGGESTEDITEMTEXT: SR\_ARCHIVE\_SUGGESTEDITEMTEXT\_TOOLTIP| x |
|suggestedItemOrderBy|int|SR\_ARCHIVE\_SUGGESTEDITEMORDERBY: SR\_ARCHIVE\_SUGGESTEDITEMORDERBY\_TOOLTIP| x |
|suggestedItemTooltip|string|SR\_ARCHIVE\_SUGGESTEDITEM\_TOOLTIP: SR\_ARCHIVE\_SUGGESTEDITEM\_TOOLTIP\_TOOLTIP| x |
|instanceItemId| *None* |SR\_ARCHIVE\_INSTANCEITEMID: SR\_ARCHIVE\_INSTANCEITEMID\_TOOLTIP|  |
|instanceItemText| *None* |SR\_ARCHIVE\_INSTANCEITEMTEXT: SR\_ARCHIVE\_INSTANCEITEMTEXT\_TOOLTIP|  |
|hasInstance| *None* |SR\_ARCHIVE\_HASINSTANCE: SR\_ARCHIVE\_HASINSTANCE\_TOOLTIP|  |
|deleted|bool|SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED\_TOOLTIP| x |
|isMilestone| *None* |SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP|  |
|appointmentInstance/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|appointmentInstance/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|appointmentInstance/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|appointmentInstance/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|appointmentInstance/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|appointmentInstance/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|appointmentInstance/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|appointmentInstance/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointmentInstance/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|appointmentInstance/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|appointmentInstance/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|appointmentInstance/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|appointmentInstance/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|appointmentInstance/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|appointmentInstance/appointmentId| *None* |SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP|  |
|appointmentInstance/endDate| *None* |SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP|  |
|appointmentInstance/priority| *None* |SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP|  |
|appointmentInstance/alarm| *None* |SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP|  |
|appointmentInstance/isFree| *None* |SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP|  |
|appointmentInstance/recurring| *None* |SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP|  |
|appointmentInstance/booking| *None* |SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP|  |
|appointmentInstance/intention| *None* |SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP|  |
|appointmentInstance/location| *None* |SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP|  |
|appointmentInstance/recurrenceRuleId| *None* |SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP|  |
|appointmentInstance/rawType| *None* |SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP|  |
|appointmentInstance/rawStatus| *None* |SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP|  |
|appointmentInstance/cautionWarning| *None* |SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP|  |
|appointmentInstance/visibleInDiary| *None* |SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP|  |
|appointmentInstance/endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|appointmentInstance/suggestedAppointmentId| *None* |SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP|  |
|appointmentInstance/completedDate| *None* |SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP|  |
|appointmentInstance/isMilestone| *None* |SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP|  |
|appointmentInstance/invitedPersonId| *None* |SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP|  |
|appointmentInstance/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP|  |
|appointmentInstance/joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP|  |
|appointmentInstance/duration| *None* |SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|appointmentInstance/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|appointmentInstance/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|appointmentInstance/appointmentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|appointmentInstance/appointmentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|appointmentInstance/appointmentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|appointmentInstance/appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|appointmentInstance/contact/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/contact/name| *None* |SR\_COMPANY\_NAME|  |
|appointmentInstance/contact/department| *None* |SR\_ARCHIVE\_DEPARTEMENT|  |
|appointmentInstance/contact/nameDepartment| *None* |SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|appointmentInstance/contact/hasInfoText| *None* |SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|appointmentInstance/contact/hasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|appointmentInstance/contact/associateId| *None* |SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|appointmentInstance/contact/category| *None* |SR\_ARCHIVE\_CATEGORY|  |
|appointmentInstance/contact/categoryGroup| *None* |SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|appointmentInstance/contact/companyCategoryRank| *None* |Category rank|  |
|appointmentInstance/contact/business| *None* |SR\_ARCHIVE\_BUSINESS|  |
|appointmentInstance/contact/country| *None* |SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|appointmentInstance/contact/countryId| *None* |SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|appointmentInstance/contact/number| *None* |SR\_ARCHIVE\_NUMBER|  |
|appointmentInstance/contact/code| *None* |SR\_ARCHIVE\_CODE|  |
|appointmentInstance/contact/orgnr| *None* |VAT No.|  |
|appointmentInstance/contact/stop| *None* |SR\_CC\_STOPX|  |
|appointmentInstance/contact/contactNoMail| *None* |SR\_NO\_MAIL\_COMPANY|  |
|appointmentInstance/contact/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/contact/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/contact/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|appointmentInstance/contact/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/contact/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/contact/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|appointmentInstance/contact/contactSource| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|appointmentInstance/contact/contactDeleted| *None* |SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|appointmentInstance/contact/phone/formattedNumber| *None* |SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/contact/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|appointmentInstance/contact/deletedDate| *None* |SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|appointmentInstance/contact/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|appointmentInstance/contact/forceCompany| *None* |Dummy: Dummy|  |
|appointmentInstance/contact/contactPhone/formattedNumber| *None* |SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/contact/contactPhone/description| *None* |SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointmentInstance/contact/contactFax/formattedNumber| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/contact/contactFax/description| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|appointmentInstance/contact/searchPhone/formattedNumber| *None* |SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/contact/searchPhone/description| *None* |SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|appointmentInstance/contact/email/emailProtocol| *None* |SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|appointmentInstance/contact/email/emailAddress| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointmentInstance/contact/email/emailDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|appointmentInstance/contact/email/emailId| *None* |ID|  |
|appointmentInstance/contact/email/emailLastSent| *None* |SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|appointmentInstance/contact/email/emailBounceCount| *None* |SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|appointmentInstance/contact/email/emailLastBounce| *None* |SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|appointmentInstance/contact/email/emailHasBounced| *None* |SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/addressId| *None* |SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/line1| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/line2| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/line3| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/county| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/city| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/zip| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/state| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|appointmentInstance/contact/postAddress/wgs84latitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|appointmentInstance/contact/postAddress/wgs84longitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|appointmentInstance/contact/postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/streetAddress/addressId| *None* |SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|appointmentInstance/contact/streetAddress/line1| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|appointmentInstance/contact/streetAddress/line2| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|appointmentInstance/contact/streetAddress/line3| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|appointmentInstance/contact/streetAddress/county| *None* |SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|appointmentInstance/contact/streetAddress/city| *None* |SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|appointmentInstance/contact/streetAddress/zip| *None* |SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|appointmentInstance/contact/streetAddress/state| *None* |SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|appointmentInstance/contact/streetAddress/wgs84latitude| *None* |SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|appointmentInstance/contact/streetAddress/wgs84longitude| *None* |SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|appointmentInstance/contact/streetAddress/formattedAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/streetAddress/formattedMultiLineAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/restrictionAddress/addressId| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|appointmentInstance/contact/restrictionAddress/line1| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|appointmentInstance/contact/restrictionAddress/line2| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|appointmentInstance/contact/restrictionAddress/line3| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|appointmentInstance/contact/restrictionAddress/county| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|appointmentInstance/contact/restrictionAddress/city| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|appointmentInstance/contact/restrictionAddress/zip| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|appointmentInstance/contact/restrictionAddress/state| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|appointmentInstance/contact/restrictionAddress/wgs84latitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|appointmentInstance/contact/restrictionAddress/wgs84longitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|appointmentInstance/contact/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/contact/url/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|appointmentInstance/contact/url/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|appointmentInstance/contact/contactAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|appointmentInstance/contact/contactAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|appointmentInstance/contact/contactAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|appointmentInstance/contact/contactAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|appointmentInstance/contact/contactAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointmentInstance/contact/contactAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointmentInstance/contact/contactAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|appointmentInstance/contact/contactAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointmentInstance/contact/contactAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointmentInstance/contact/contactAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointmentInstance/contact/contactAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|appointmentInstance/contact/contactAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointmentInstance/contact/contactAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|appointmentInstance/contact/contactAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|appointmentInstance/contact/contactInterestIds| *None* |SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|appointmentInstance/contact/contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|appointmentInstance/contact/contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|appointmentInstance/contact/contactUdef/SuperOffice:3| *None* |companynumber|  |
|appointmentInstance/contact/contactUdef/SuperOffice:4| *None* |companydate|  |
|appointmentInstance/contact/contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|appointmentInstance/contact/contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|appointmentInstance/contact/contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|appointmentInstance/contact/contactUdef/SuperOffice:8| *None* |companydecimal|  |
|appointmentInstance/contact/contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|appointmentInstance/contact/contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|appointmentInstance/contact/contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|appointmentInstance/contact/contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|appointmentInstance/contact/contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|appointmentInstance/contact/contactExtra/x\_contact\_integer| *None* |Extra Integer: Custom integer field|  |
|appointmentInstance/contact/contactExtra/x\_contact\_hidden\_integer| *None* |Extra hidden integer: Custom integer field - hidden|  |
|appointmentInstance/contact/contactExtra/x\_contact\_default\_integer| *None* |Extra Default Integer: Custom integer field with default value 123.|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointmentInstance/contact/contactExtra/x\_contact\_float| *None* |Extra Float: Custom float field with 3 decimals|  |
|appointmentInstance/contact/contactExtra/x\_contact\_longtext| *None* |Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|appointmentInstance/contact/contactExtra/x\_contact\_dropdown| *None* |Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|appointmentInstance/contact/contactExtra/x\_contact\_date| *None* |Extra date: Custom date field. User current as default.|  |
|appointmentInstance/contact/contactExtra/x\_contact\_datetime| *None* |Extra DateTime: Custom Date Time field. No default value. External|  |
|appointmentInstance/contact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.|  |
|appointmentInstance/contact/contactExtra/x\_contact\_boolean| *None* |Extra boolean: Custom boolean field.|  |
|appointmentInstance/contact/contactExtra/x\_contact\_timespan| *None* |Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|appointmentInstance/contact/contactExtra/x\_contact\_shorttext| *None* |Extra short text: Custom short text field. Keep HTML tags.|  |
|appointmentInstance/contact/contactExtra/x\_contact\_short\_dropdown| *None* |Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|appointmentInstance/contact/contactExtra/x\_contact\_contact\_relation| *None* |Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|appointmentInstance/contact/contactExtra/x\_contact\_request\_relation| *None* |Extra Request relation: Request relation on company|  |
|appointmentInstance/contact/contactExtra/x\_contact\_contact| *None* |Extra contact relation: Contact relation on company|  |
|appointmentInstance/contact/contactExtra/y\_organization/x\_name| *None* |Organization - Name: Name|  |
|appointmentInstance/contact/NumberOfActivities| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|appointmentInstance/contact/NumberOfActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/contact/NumberOfNotCompletedActivities| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|appointmentInstance/contact/NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/contact/LastActivity| *None* |SR\_ROU\_LAST\_ACTIVITY|  |
|appointmentInstance/contact/LastCompletedActivity| *None* |SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|appointmentInstance/contact/LastDoByActivity| *None* |SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|appointmentInstance/contact/NumberOfSales| *None* |SR\_ROU\_NUMBER\_OF\_SALES|  |
|appointmentInstance/contact/NumberOfSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/contact/NumberOfNotCompletedSales| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|appointmentInstance/contact/NumberOfNotCompletedSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/contact/LastSale| *None* |SR\_ROU\_LAST\_SALE|  |
|appointmentInstance/contact/LastCompletedSale| *None* |SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|appointmentInstance/contact/LastDoBySale| *None* |SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|appointmentInstance/contact/NumberOfTickets| *None* |SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|appointmentInstance/contact/NumberOfTicketsInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/contact/NumberOfNotCompletedTickets| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|appointmentInstance/contact/NumberOfNotCompletedTicketsInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/contact/LastTicket| *None* |SR\_ROU\_LAST\_TICKET|  |
|appointmentInstance/contact/LastCompletedTicket| *None* |SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|appointmentInstance/contact/LastDoByTicket| *None* |SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|appointmentInstance/contact/SaintStatus1| *None* |Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|appointmentInstance/contact/SaintStatus2| *None* |C-company: Kundens navn starter med bokstaven C|  |
|appointmentInstance/contact/saintSaleStatus| *None* |SR\_WITH\_STATUS|  |
|appointmentInstance/contact/saintAmountClass| *None* |SR\_AMOUNT\_CLASS|  |
|appointmentInstance/contact/saintActivityType| *None* |SR\_ARCHIVE\_SAINT\_TYPE|  |
|appointmentInstance/contact/saintDirection| *None* |SR\_ARCHIVE\_DIRECTION|  |
|appointmentInstance/contact/saintIntention| *None* |SR\_ACTIVITY\_INTENTION|  |
|appointmentInstance/contact/saintTicketStatus| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|appointmentInstance/contact/saintTicketCategory| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|appointmentInstance/person/personId| *None* |SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|appointmentInstance/person/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|appointmentInstance/person/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|appointmentInstance/person/middleName| *None* |SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|appointmentInstance/person/fullName| *None* |SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|appointmentInstance/person/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/person/hasInfoText| *None* |SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|appointmentInstance/person/hasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|appointmentInstance/person/personHasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|appointmentInstance/person/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/person/position| *None* |SR\_ARCHIVE\_POSITION|  |
|appointmentInstance/person/personNumber| *None* |SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|appointmentInstance/person/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|appointmentInstance/person/personCountry| *None* |SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|appointmentInstance/person/personCountryId| *None* |SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|appointmentInstance/person/personNoMail| *None* |SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|appointmentInstance/person/rank| *None* |SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|appointmentInstance/person/birthdate| *None* |SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|appointmentInstance/person/associateType| *None* |SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|appointmentInstance/person/useAsMailingAddress| *None* |SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|appointmentInstance/person/personSource| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|appointmentInstance/person/retired| *None* |SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|appointmentInstance/person/birthYear| *None* |SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|appointmentInstance/person/birthMonth| *None* |SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|appointmentInstance/person/birthDay| *None* |SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|appointmentInstance/person/kanaFirstName| *None* |SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|appointmentInstance/person/kanaLastName| *None* |SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|appointmentInstance/person/personUpdatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/person/personUpdatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/person/personUpdatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|appointmentInstance/person/personRegisteredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/person/personRegisteredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/person/personRegisteredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|appointmentInstance/person/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointmentInstance/person/personActiveErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|appointmentInstance/person/ticketPriority| *None* |SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|appointmentInstance/person/supportLanguage| *None* |SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|appointmentInstance/person/supportAssociate| *None* |SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|appointmentInstance/person/supportAssociateFullName| *None* |SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|appointmentInstance/person/personAssociateId| *None* |SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|appointmentInstance/person/personAssociateFullName| *None* |SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|appointmentInstance/person/personCategory| *None* |SR\_ARCHIVE\_CATEGORY|  |
|appointmentInstance/person/personCategoryGroup| *None* |SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|appointmentInstance/person/personCategoryRank| *None* |!!Category rank|  |
|appointmentInstance/person/personBusiness| *None* |SR\_ARCHIVE\_BUSINESS|  |
|appointmentInstance/person/leadStatus| *None* |SR\_LABEL\_LEADSTATUS|  |
|appointmentInstance/person/leadstatusRank| *None* |!!Lead status RANK|  |
|appointmentInstance/person/personDeletedDate| *None* |SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|appointmentInstance/person/hasCompany| *None* |SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|appointmentInstance/person/isProjectMember| *None* |SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|appointmentInstance/person/isStakeholder| *None* |SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|appointmentInstance/person/updatedByWorkflow| *None* |SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|appointmentInstance/person/whenUpdatedByWorkflow| *None* |SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|appointmentInstance/person/createdByForm| *None* |SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|appointmentInstance/person/phone/formattedNumber| *None* |SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/person/personDirectPhone/formattedNumber| *None* |SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointmentInstance/person/personDirectPhone/description| *None* |SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|appointmentInstance/person/personMobilePhone/formattedNumber| *None* |SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/person/personMobilePhone/description| *None* |SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|appointmentInstance/person/personPrivate/formattedNumber| *None* |SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/person/personPrivate/description| *None* |SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|appointmentInstance/person/personPager/formattedNumber| *None* |SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/person/personPager/description| *None* |SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|appointmentInstance/person/personDirectFax/formattedNumber| *None* |SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/person/personDirectFax/description| *None* |SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|appointmentInstance/person/searchPhone/formattedNumber| *None* |SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|appointmentInstance/person/searchPhone/description| *None* |SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|appointmentInstance/person/personInfo/textId| *None* |Text ID|  |
|appointmentInstance/person/personInfo/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/person/email/emailProtocol| *None* |SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|appointmentInstance/person/email/emailAddress| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointmentInstance/person/email/emailDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|appointmentInstance/person/email/emailId| *None* |ID|  |
|appointmentInstance/person/email/emailLastSent| *None* |SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|appointmentInstance/person/email/emailBounceCount| *None* |SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|appointmentInstance/person/email/emailLastBounce| *None* |SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|appointmentInstance/person/email/emailHasBounced| *None* |SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|appointmentInstance/person/personUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|appointmentInstance/person/personUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|appointmentInstance/person/personAddress/addressId| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|appointmentInstance/person/personAddress/line1| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|appointmentInstance/person/personAddress/line2| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|appointmentInstance/person/personAddress/line3| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|appointmentInstance/person/personAddress/county| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|appointmentInstance/person/personAddress/city| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|appointmentInstance/person/personAddress/zip| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|appointmentInstance/person/personAddress/state| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|appointmentInstance/person/personAddress/wgs84latitude| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|appointmentInstance/person/personAddress/wgs84longitude| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|appointmentInstance/person/personAddress/formattedAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/personAddress/formattedMultiLineAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/restrictionAddress/addressId| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|appointmentInstance/person/restrictionAddress/line1| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|appointmentInstance/person/restrictionAddress/line2| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|appointmentInstance/person/restrictionAddress/line3| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|appointmentInstance/person/restrictionAddress/county| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|appointmentInstance/person/restrictionAddress/city| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|appointmentInstance/person/restrictionAddress/zip| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|appointmentInstance/person/restrictionAddress/state| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|appointmentInstance/person/restrictionAddress/wgs84latitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|appointmentInstance/person/restrictionAddress/wgs84longitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|appointmentInstance/person/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|appointmentInstance/person/personInterestIds| *None* |SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|appointmentInstance/person/personUdef/SuperOffice:1| *None* |contactshorttext: tooltipshorttext|  |
|appointmentInstance/person/personUdef/SuperOffice:2| *None* |contactlongtext: tooltiplongtext|  |
|appointmentInstance/person/personUdef/SuperOffice:3| *None* |contactnumber|  |
|appointmentInstance/person/personUdef/SuperOffice:4| *None* |contactdate|  |
|appointmentInstance/person/personUdef/SuperOffice:5| *None* |contactunlimiteddate: tooltipunlimiteddate|  |
|appointmentInstance/person/personUdef/SuperOffice:6| *None* |contactcheckbox|  |
|appointmentInstance/person/personUdef/SuperOffice:7| *None* |contactdropdownlistbox|  |
|appointmentInstance/person/personUdef/SuperOffice:8| *None* |contactdecimal|  |
|appointmentInstance/person/personUdef/SuperOffice:9| *None* |page1saleonly|  |
|appointmentInstance/person/personUdef/SuperOffice:10| *None* |page1marketingonly|  |
|appointmentInstance/person/personUdef/SuperOffice:11| *None* |page1adminonly|  |
|appointmentInstance/person/personExtra/x\_person\_integer| *None* |Extra Integer: Custom person integer|  |
|appointmentInstance/person/personExtra/x\_person\_hidden\_integer| *None* |Extra hidden integer: Custom integer field that is hidden|  |
|appointmentInstance/person/personExtra/x\_person\_float| *None* |Extra float: Custom float field|  |
|appointmentInstance/person/personExtra/x\_person\_longtext| *None* |Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|appointmentInstance/person/personExtra/x\_person\_date| *None* |Extra date: Custom date field on person. Default value = 28.03.2019|  |
|appointmentInstance/person/personExtra/x\_person\_datetime| *None* |Extra DateTime: Custom person date and time field. No default|  |
|appointmentInstance/person/personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default|  |
|appointmentInstance/person/personExtra/x\_person\_boolean| *None* |Extra Boolean: Custom boolean field on person. Default checked|  |
|appointmentInstance/person/personExtra/x\_person\_timespan| *None* |Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|appointmentInstance/person/personExtra/x\_person\_shorttext| *None* |Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|appointmentInstance/person/personExtra/x\_person\_shorttext\_list| *None* |Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|appointmentInstance/person/personExtra/x\_person\_user\_relation| *None* |Extra user relation: Custom person-user relation field|  |
|appointmentInstance/person/personExtra/x\_person\_category\_relation| *None* |Extra category relation: Custom person-category relation|  |
|appointmentInstance/person/personExtra/x\_person\_priority\_relation| *None* |Extra priority relation: Custom person-priority relation|  |
|appointmentInstance/person/personExtra/x\_person\_request\_relation| *None* |Extra request relation: Request relation on contact|  |
|appointmentInstance/person/personExtra/x\_person\_appointment\_relation| *None* |Extra appointment relation: Appointment relation on person|  |
|appointmentInstance/person/personExtra/x\_person\_contact\_relation| *None* |Extra company relation: Company relation on contact|  |
|appointmentInstance/person/personExtra/y\_rental/id| *None* |Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)|  |
|appointmentInstance/person/personExtra/y\_rental/x\_start| *None* |Rental - Start rental: Start rental|  |
|appointmentInstance/person/personExtra/y\_rental/x\_end| *None* |Rental - End: End|  |
|appointmentInstance/person/personExtra/y\_rental/x\_amount| *None* |Rental - Amount: Number to rent. Default = 1|  |
|appointmentInstance/person/personExtra/y\_rental/x\_contact| *None* |Rental - Renter: Company that rents equipment|  |
|appointmentInstance/person/personExtra/y\_rental/y\_equipment/x\_name| *None* |Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|appointmentInstance/person/personExtra/y\_car/id| *None* |Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)|  |
|appointmentInstance/person/personAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|appointmentInstance/person/personAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|appointmentInstance/person/personAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|appointmentInstance/person/personAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointmentInstance/person/personAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointmentInstance/person/personAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointmentInstance/person/personAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|appointmentInstance/person/personAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointmentInstance/person/personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointmentInstance/person/personAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointmentInstance/person/personAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|appointmentInstance/person/personAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointmentInstance/person/personAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|appointmentInstance/person/personAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|appointmentInstance/person/correspondingAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|appointmentInstance/person/correspondingAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|appointmentInstance/person/correspondingAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|appointmentInstance/person/correspondingAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|appointmentInstance/person/correspondingAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointmentInstance/person/correspondingAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointmentInstance/person/correspondingAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|appointmentInstance/person/correspondingAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointmentInstance/person/correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointmentInstance/person/correspondingAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointmentInstance/person/correspondingAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|appointmentInstance/person/correspondingAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointmentInstance/person/correspondingAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|appointmentInstance/person/correspondingAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|appointmentInstance/person/isMailingRecipient| *None* |SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient|  |
|appointmentInstance/person/hasStoreConsent| *None* |SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/withdrawnStoreConsent| *None* |SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/hasEmarketingConsent| *None* |SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/person/withdrawnEmarketingConsent| *None* |SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/person/subscription| *None* |SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP|  |
|appointmentInstance/person/legalBaseStore| *None* |SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/legalBaseEmarketing| *None* |SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/person/consentSourceStore| *None* |SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|appointmentInstance/person/consentSourceEmarketing| *None* |SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentInstance/appointmentUdef/SuperOffice:1| *None* |followupshorttext|  |
|appointmentInstance/appointmentUdef/SuperOffice:2| *None* |followuplongtext|  |
|appointmentInstance/appointmentUdef/SuperOffice:3| *None* |followupnumber|  |
|appointmentInstance/appointmentUdef/SuperOffice:4| *None* |followupdate|  |
|appointmentInstance/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate|  |
|appointmentInstance/appointmentUdef/SuperOffice:6| *None* |followupcheckbox|  |
|appointmentInstance/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox|  |
|appointmentInstance/appointmentUdef/SuperOffice:8| *None* |followupdecimal|  |
|appointmentInstance/project/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP|  |
|appointmentInstance/project/projectId| *None* |SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP|  |
|appointmentInstance/project/name| *None* |SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP|  |
|appointmentInstance/project/number| *None* |SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP|  |
|appointmentInstance/project/type| *None* |SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP|  |
|appointmentInstance/project/status| *None* |SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP|  |
|appointmentInstance/project/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP|  |
|appointmentInstance/project/associateId| *None* |SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|appointmentInstance/project/hasInfoText| *None* |SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP|  |
|appointmentInstance/project/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|appointmentInstance/project/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/project/description| *None* |SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION|  |
|appointmentInstance/project/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/project/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/project/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|appointmentInstance/project/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/project/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/project/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|appointmentInstance/project/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|appointmentInstance/project/nextMilestone| *None* |SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP|  |
|appointmentInstance/project/endDate| *None* |SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP|  |
|appointmentInstance/project/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|appointmentInstance/project/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|appointmentInstance/project/eventId| *None* |SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID|  |
|appointmentInstance/project/startDate| *None* |SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP|  |
|appointmentInstance/project/projectPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|appointmentInstance/project/projectPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|appointmentInstance/project/projectPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|appointmentInstance/project/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|appointmentInstance/project/projectEvent/isExternalEvent| *None* |SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP|  |
|appointmentInstance/project/projectEvent/eventDate| *None* |SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP|  |
|appointmentInstance/project/projectEvent/hasSignOn| *None* |SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP|  |
|appointmentInstance/project/projectEvent/hasSignOff| *None* |SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointmentInstance/project/projectUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|appointmentInstance/project/projectUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|appointmentInstance/project/projectAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|appointmentInstance/project/projectAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|appointmentInstance/project/projectAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|appointmentInstance/project/projectAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|appointmentInstance/project/projectAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointmentInstance/project/projectAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointmentInstance/project/projectAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|appointmentInstance/project/projectAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointmentInstance/project/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointmentInstance/project/projectAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointmentInstance/project/projectAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|appointmentInstance/project/projectAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointmentInstance/project/projectAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|appointmentInstance/project/projectAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|appointmentInstance/project/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|appointmentInstance/project/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|appointmentInstance/project/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|appointmentInstance/project/projectUdef/SuperOffice:4| *None* |projectdate|  |
|appointmentInstance/project/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|appointmentInstance/project/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|appointmentInstance/project/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|appointmentInstance/project/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|appointmentInstance/project/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|appointmentInstance/project/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
|appointmentInstance/project/NumberOfActivities| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|appointmentInstance/project/NumberOfActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/project/NumberOfNotCompletedActivities| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|appointmentInstance/project/NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/project/LastActivity| *None* |SR\_ROU\_LAST\_ACTIVITY|  |
|appointmentInstance/project/LastCompletedActivity| *None* |SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|appointmentInstance/project/LastDoByActivity| *None* |SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|appointmentInstance/project/NumberOfSales| *None* |SR\_ROU\_NUMBER\_OF\_SALES|  |
|appointmentInstance/project/NumberOfSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/project/NumberOfNotCompletedSales| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|appointmentInstance/project/NumberOfNotCompletedSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|appointmentInstance/project/LastSale| *None* |SR\_ROU\_LAST\_SALE|  |
|appointmentInstance/project/LastCompletedSale| *None* |SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|appointmentInstance/project/LastDoBySale| *None* |SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|appointmentInstance/project/SaintStatus3| *None* |Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|appointmentInstance/project/saintSaleStatus| *None* |SR\_WITH\_STATUS|  |
|appointmentInstance/project/saintAmountClass| *None* |SR\_AMOUNT\_CLASS|  |
|appointmentInstance/project/saintActivityType| *None* |SR\_ARCHIVE\_SAINT\_TYPE|  |
|appointmentInstance/project/saintDirection| *None* |SR\_ARCHIVE\_DIRECTION|  |
|appointmentInstance/project/saintIntention| *None* |SR\_ACTIVITY\_INTENTION|  |
|appointmentInstance/project/saintTicketStatus| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|appointmentInstance/project/saintTicketCategory| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|appointmentInstance/project/project/textId| *None* |Text ID|  |
|appointmentInstance/project/project/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/sale/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|appointmentInstance/sale/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|appointmentInstance/sale/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|appointmentInstance/sale/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|appointmentInstance/sale/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|appointmentInstance/sale/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|appointmentInstance/sale/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/sale/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|appointmentInstance/sale/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/sale/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointmentInstance/sale/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|appointmentInstance/sale/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|appointmentInstance/sale/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|appointmentInstance/sale/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|appointmentInstance/sale/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/sale/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointmentInstance/sale/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|appointmentInstance/sale/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/sale/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointmentInstance/sale/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|appointmentInstance/sale/currencyId| *None* |SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP|  |
|appointmentInstance/sale/currency| *None* |SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP|  |
|appointmentInstance/sale/credited| *None* |SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP|  |
|appointmentInstance/sale/lossReason| *None* |SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP|  |
|appointmentInstance/sale/source| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP|  |
|appointmentInstance/sale/competitor| *None* |SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP|  |
|appointmentInstance/sale/heading| *None* |SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP|  |
|appointmentInstance/sale/amount| *None* |SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|appointmentInstance/sale/amountWeighted| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|appointmentInstance/sale/earning| *None* |SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP|  |
|appointmentInstance/sale/earningPercent| *None* |SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointmentInstance/sale/probPercent| *None* |SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP|  |
|appointmentInstance/sale/originalStage| *None* |SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED|  |
|appointmentInstance/sale/stage| *None* |SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|appointmentInstance/sale/stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|appointmentInstance/sale/saleStatus| *None* |SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP|  |
|appointmentInstance/sale/stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP|  |
|appointmentInstance/sale/saleType| *None* |SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|appointmentInstance/sale/saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|appointmentInstance/sale/stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|appointmentInstance/sale/nextDueDate| *None* |SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP|  |
|appointmentInstance/sale/reopenDate| *None* |SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP|  |
|appointmentInstance/sale/stalledComment| *None* |SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP|  |
|appointmentInstance/sale/saleTypeCategory| *None* |SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT|  |
|appointmentInstance/sale/soldReason| *None* |SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP|  |
|appointmentInstance/sale/saleNumber| *None* |SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER|  |
|appointmentInstance/sale/hasStakeholders| *None* |SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP|  |
|appointmentInstance/sale/stakeholdersEnabled| *None* |SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP|  |
|appointmentInstance/sale/hasQuote| *None* |SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP|  |
|appointmentInstance/sale/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|appointmentInstance/sale/description| *None* |SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|appointmentInstance/sale/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|appointmentInstance/sale/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|appointmentInstance/sale/amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|appointmentInstance/sale/amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|appointmentInstance/sale/daysInStage| *None* |SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP|  |
|appointmentInstance/sale/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|appointmentInstance/sale/sale/textId| *None* |Text ID|  |
|appointmentInstance/sale/sale/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/sale/salePublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|appointmentInstance/sale/salePublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|appointmentInstance/sale/salePublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|appointmentInstance/sale/salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|appointmentInstance/sale/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|appointmentInstance/sale/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|appointmentInstance/sale/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|appointmentInstance/sale/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|appointmentInstance/sale/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/sale/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointmentInstance/sale/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/sale/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/sale/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|appointmentInstance/sale/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|appointmentInstance/sale/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|appointmentInstance/sale/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/sale/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/sale/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|appointmentInstance/sale/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|appointmentInstance/sale/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|appointmentInstance/sale/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|appointmentInstance/sale/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointmentInstance/sale/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|appointmentInstance/sale/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointmentInstance/sale/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointmentInstance/sale/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|appointmentInstance/sale/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointmentInstance/sale/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|appointmentInstance/sale/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|appointmentInstance/sale/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|appointmentInstance/sale/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|appointmentInstance/sale/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointmentInstance/sale/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointmentInstance/sale/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|appointmentInstance/sale/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointmentInstance/sale/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|appointmentInstance/sale/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|appointmentInstance/sale/saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|appointmentInstance/sale/saleUdef/SuperOffice:2| *None* |salelongtext|  |
|appointmentInstance/sale/saleUdef/SuperOffice:3| *None* |salenumber|  |
|appointmentInstance/sale/saleUdef/SuperOffice:4| *None* |saledate|  |
|appointmentInstance/sale/saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|appointmentInstance/sale/saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|appointmentInstance/sale/saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|appointmentInstance/sale/saleUdef/SuperOffice:8| *None* |saledecimal|  |
|appointmentInstance/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|appointmentInstance/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|appointmentInstance/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|appointmentInstance/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|appointmentInstance/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointmentInstance/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointmentInstance/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointmentInstance/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|appointmentInstance/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|appointmentInstance/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|appointmentInstance/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointmentInstance/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|appointmentInstance/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|appointmentInstance/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|appointmentInstance/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|appointmentInstance/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointmentInstance/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|appointmentInstance/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointmentInstance/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointmentInstance/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|appointmentInstance/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointmentInstance/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|appointmentInstance/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|appointmentInstance/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|appointmentInstance/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointmentInstance/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointmentInstance/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointmentInstance/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|appointmentInstance/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointmentInstance/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|appointmentInstance/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|appointmentInstance/appointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/appointment/description| *None* |SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/appointment/title| *None* |SR\_TICKETARCHIVE\_TITLE|  |
|appointmentInstance/appointment/titleHtml| *None* |!!Title Html|  |
|appointmentInstance/appointment/agenda| *None* |SR\_APPOINTMENT\_AGENDA|  |
|appointmentInstance/appointment/agendaHtml| *None* |!!Agenda Html|  |
|appointmentInstance/appointment/isConverted| *None* |!!Is Converted|  |
|appointmentInstance/appointment/textId| *None* |Text ID|  |
|appointmentInstance/appointment/internalNotes| *None* |SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointmentInstance/appointment/internalNotesHtml| *None* |!!Internal Notes Html|  |
|documentInstance/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|documentInstance/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|documentInstance/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|documentInstance/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|documentInstance/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|documentInstance/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|documentInstance/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|documentInstance/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|documentInstance/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|documentInstance/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|documentInstance/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|documentInstance/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|documentInstance/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|documentInstance/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|documentInstance/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|documentInstance/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|documentInstance/documentId| *None* |SR\_DOCUMENT\_ID: SR\_DOCUMENT\_ID\_TOOLTIP|  |
|documentInstance/keywords| *None* |SR\_KEYWORDS|  |
|documentInstance/ourref| *None* |SR\_AA\_OURREF|  |
|documentInstance/yourref| *None* |SR\_ARCHIVE\_YOURREF|  |
|documentInstance/attention| *None* |SR\_ARCHIVE\_SALUTATION|  |
|documentInstance/subject| *None* |SR\_COMMON\_SUBJECT|  |
|documentInstance/name| *None* |SR\_FILENAME|  |
|documentInstance/mailMergeDraft| *None* |SR\_MAILMERGEDRAFT: SR\_DOCUMENT\_MMD\_TOOLTIP|  |
|documentInstance/snum| *None* |SR\_ARCHIVE\_DOCUMENT\_SNUM: SR\_ARCHIVE\_DOCUMENT\_SNUM\_TOOLTIP|  |
|documentInstance/isReport| *None* |SR\_DOCUMENTISREPORT: SR\_DOCUMENTISREPORT\_TOOLTIP|  |
|documentInstance/suggestedDocumentId| *None* |SR\_ARCHIVE\_SUGGESTEDDOCID: SR\_ARCHIVE\_SUGGESTEDDOCID\_TOOLTIP|  |
|documentInstance/isMail| *None* |SR\_SINGULAR\_MAIL|  |
|documentInstance/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP|  |
|documentInstance/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|documentInstance/documentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|documentInstance/documentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|documentInstance/documentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|documentInstance/documentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|documentInstance/person/personId| *None* |SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|documentInstance/person/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|documentInstance/person/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|documentInstance/person/middleName| *None* |SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|documentInstance/person/fullName| *None* |SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|documentInstance/person/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|documentInstance/person/hasInfoText| *None* |SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|documentInstance/person/hasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|documentInstance/person/personHasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|documentInstance/person/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/person/position| *None* |SR\_ARCHIVE\_POSITION|  |
|documentInstance/person/personNumber| *None* |SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|documentInstance/person/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|documentInstance/person/personCountry| *None* |SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|documentInstance/person/personCountryId| *None* |SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|documentInstance/person/personNoMail| *None* |SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|documentInstance/person/rank| *None* |SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|documentInstance/person/birthdate| *None* |SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|documentInstance/person/associateType| *None* |SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|documentInstance/person/useAsMailingAddress| *None* |SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|documentInstance/person/personSource| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|documentInstance/person/retired| *None* |SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|documentInstance/person/birthYear| *None* |SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|documentInstance/person/birthMonth| *None* |SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|documentInstance/person/birthDay| *None* |SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|documentInstance/person/kanaFirstName| *None* |SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|documentInstance/person/kanaLastName| *None* |SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|documentInstance/person/personUpdatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/person/personUpdatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/person/personUpdatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|documentInstance/person/personRegisteredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/person/personRegisteredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/person/personRegisteredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|documentInstance/person/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|documentInstance/person/personActiveErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|documentInstance/person/ticketPriority| *None* |SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|documentInstance/person/supportLanguage| *None* |SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|documentInstance/person/supportAssociate| *None* |SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|documentInstance/person/supportAssociateFullName| *None* |SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|documentInstance/person/personAssociateId| *None* |SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|documentInstance/person/personAssociateFullName| *None* |SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|documentInstance/person/personCategory| *None* |SR\_ARCHIVE\_CATEGORY|  |
|documentInstance/person/personCategoryGroup| *None* |SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|documentInstance/person/personCategoryRank| *None* |!!Category rank|  |
|documentInstance/person/personBusiness| *None* |SR\_ARCHIVE\_BUSINESS|  |
|documentInstance/person/leadStatus| *None* |SR\_LABEL\_LEADSTATUS|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|documentInstance/person/leadstatusRank| *None* |!!Lead status RANK|  |
|documentInstance/person/personDeletedDate| *None* |SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|documentInstance/person/hasCompany| *None* |SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|documentInstance/person/isProjectMember| *None* |SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|documentInstance/person/isStakeholder| *None* |SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|documentInstance/person/updatedByWorkflow| *None* |SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|documentInstance/person/whenUpdatedByWorkflow| *None* |SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|documentInstance/person/createdByForm| *None* |SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|documentInstance/person/phone/formattedNumber| *None* |SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/person/personDirectPhone/formattedNumber| *None* |SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/person/personDirectPhone/description| *None* |SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/person/personMobilePhone/formattedNumber| *None* |SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/person/personMobilePhone/description| *None* |SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/person/personPrivate/formattedNumber| *None* |SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/person/personPrivate/description| *None* |SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/person/personPager/formattedNumber| *None* |SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/person/personPager/description| *None* |SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/person/personDirectFax/formattedNumber| *None* |SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/person/personDirectFax/description| *None* |SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/person/searchPhone/formattedNumber| *None* |SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/person/searchPhone/description| *None* |SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/person/personInfo/textId| *None* |Text ID|  |
|documentInstance/person/personInfo/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|documentInstance/person/email/emailProtocol| *None* |SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|documentInstance/person/email/emailAddress| *None* |SR\_ARCHIVE\_EMAIL|  |
|documentInstance/person/email/emailDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|documentInstance/person/email/emailId| *None* |ID|  |
|documentInstance/person/email/emailLastSent| *None* |SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|documentInstance/person/email/emailBounceCount| *None* |SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|documentInstance/person/email/emailLastBounce| *None* |SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|documentInstance/person/email/emailHasBounced| *None* |SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|documentInstance/person/personUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|documentInstance/person/personUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|documentInstance/person/personAddress/addressId| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|documentInstance/person/personAddress/line1| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|documentInstance/person/personAddress/line2| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|documentInstance/person/personAddress/line3| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|documentInstance/person/personAddress/county| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|documentInstance/person/personAddress/city| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|documentInstance/person/personAddress/zip| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|documentInstance/person/personAddress/state| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|documentInstance/person/personAddress/wgs84latitude| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|documentInstance/person/personAddress/wgs84longitude| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|documentInstance/person/personAddress/formattedAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|documentInstance/person/personAddress/formattedMultiLineAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|documentInstance/person/restrictionAddress/addressId| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|documentInstance/person/restrictionAddress/line1| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|documentInstance/person/restrictionAddress/line2| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|documentInstance/person/restrictionAddress/line3| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|documentInstance/person/restrictionAddress/county| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|documentInstance/person/restrictionAddress/city| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|documentInstance/person/restrictionAddress/zip| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|documentInstance/person/restrictionAddress/state| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|documentInstance/person/restrictionAddress/wgs84latitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|documentInstance/person/restrictionAddress/wgs84longitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|documentInstance/person/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|documentInstance/person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|documentInstance/person/personInterestIds| *None* |SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|documentInstance/person/personUdef/SuperOffice:1| *None* |contactshorttext: tooltipshorttext|  |
|documentInstance/person/personUdef/SuperOffice:2| *None* |contactlongtext: tooltiplongtext|  |
|documentInstance/person/personUdef/SuperOffice:3| *None* |contactnumber|  |
|documentInstance/person/personUdef/SuperOffice:4| *None* |contactdate|  |
|documentInstance/person/personUdef/SuperOffice:5| *None* |contactunlimiteddate: tooltipunlimiteddate|  |
|documentInstance/person/personUdef/SuperOffice:6| *None* |contactcheckbox|  |
|documentInstance/person/personUdef/SuperOffice:7| *None* |contactdropdownlistbox|  |
|documentInstance/person/personUdef/SuperOffice:8| *None* |contactdecimal|  |
|documentInstance/person/personUdef/SuperOffice:9| *None* |page1saleonly|  |
|documentInstance/person/personUdef/SuperOffice:10| *None* |page1marketingonly|  |
|documentInstance/person/personUdef/SuperOffice:11| *None* |page1adminonly|  |
|documentInstance/person/personExtra/x\_person\_integer| *None* |Extra Integer: Custom person integer|  |
|documentInstance/person/personExtra/x\_person\_hidden\_integer| *None* |Extra hidden integer: Custom integer field that is hidden|  |
|documentInstance/person/personExtra/x\_person\_float| *None* |Extra float: Custom float field|  |
|documentInstance/person/personExtra/x\_person\_longtext| *None* |Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|documentInstance/person/personExtra/x\_person\_date| *None* |Extra date: Custom date field on person. Default value = 28.03.2019|  |
|documentInstance/person/personExtra/x\_person\_datetime| *None* |Extra DateTime: Custom person date and time field. No default|  |
|documentInstance/person/personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default|  |
|documentInstance/person/personExtra/x\_person\_boolean| *None* |Extra Boolean: Custom boolean field on person. Default checked|  |
|documentInstance/person/personExtra/x\_person\_timespan| *None* |Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|documentInstance/person/personExtra/x\_person\_shorttext| *None* |Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|documentInstance/person/personExtra/x\_person\_shorttext\_list| *None* |Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|documentInstance/person/personExtra/x\_person\_user\_relation| *None* |Extra user relation: Custom person-user relation field|  |
|documentInstance/person/personExtra/x\_person\_category\_relation| *None* |Extra category relation: Custom person-category relation|  |
|documentInstance/person/personExtra/x\_person\_priority\_relation| *None* |Extra priority relation: Custom person-priority relation|  |
|documentInstance/person/personExtra/x\_person\_request\_relation| *None* |Extra request relation: Request relation on contact|  |
|documentInstance/person/personExtra/x\_person\_appointment\_relation| *None* |Extra appointment relation: Appointment relation on person|  |
|documentInstance/person/personExtra/x\_person\_contact\_relation| *None* |Extra company relation: Company relation on contact|  |
|documentInstance/person/personExtra/y\_rental/id| *None* |Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)|  |
|documentInstance/person/personExtra/y\_rental/x\_start| *None* |Rental - Start rental: Start rental|  |
|documentInstance/person/personExtra/y\_rental/x\_end| *None* |Rental - End: End|  |
|documentInstance/person/personExtra/y\_rental/x\_amount| *None* |Rental - Amount: Number to rent. Default = 1|  |
|documentInstance/person/personExtra/y\_rental/x\_contact| *None* |Rental - Renter: Company that rents equipment|  |
|documentInstance/person/personExtra/y\_rental/y\_equipment/x\_name| *None* |Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|documentInstance/person/personExtra/y\_car/id| *None* |Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)|  |
|documentInstance/person/personAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|documentInstance/person/personAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|documentInstance/person/personAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|documentInstance/person/personAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|documentInstance/person/personAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|documentInstance/person/personAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|documentInstance/person/personAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|documentInstance/person/personAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/person/personAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|documentInstance/person/personAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|documentInstance/person/personAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|documentInstance/person/personAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/person/personAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/person/personAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|documentInstance/person/personAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|documentInstance/person/personAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|documentInstance/person/personAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|documentInstance/person/personAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|documentInstance/person/personAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|documentInstance/person/personAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|documentInstance/person/personAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|documentInstance/person/personAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|documentInstance/person/personAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|documentInstance/person/personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|documentInstance/person/personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|documentInstance/person/personAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|documentInstance/person/personAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|documentInstance/person/personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|documentInstance/person/personAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|documentInstance/person/personAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|documentInstance/person/personAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|documentInstance/person/personAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|documentInstance/person/personAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|documentInstance/person/correspondingAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|documentInstance/person/correspondingAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|documentInstance/person/correspondingAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|documentInstance/person/correspondingAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|documentInstance/person/correspondingAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|documentInstance/person/correspondingAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|documentInstance/person/correspondingAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|documentInstance/person/correspondingAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|documentInstance/person/correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|documentInstance/person/correspondingAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|documentInstance/person/correspondingAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|documentInstance/person/correspondingAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|documentInstance/person/correspondingAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|documentInstance/person/correspondingAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|documentInstance/person/isMailingRecipient| *None* |SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient|  |
|documentInstance/person/hasStoreConsent| *None* |SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|documentInstance/person/withdrawnStoreConsent| *None* |SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|documentInstance/person/hasEmarketingConsent| *None* |SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|documentInstance/person/withdrawnEmarketingConsent| *None* |SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|documentInstance/person/subscription| *None* |SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP|  |
|documentInstance/person/legalBaseStore| *None* |SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|documentInstance/person/legalBaseEmarketing| *None* |SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|documentInstance/person/consentSourceStore| *None* |SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|documentInstance/person/consentSourceEmarketing| *None* |SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|documentInstance/contact/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|documentInstance/contact/name| *None* |SR\_COMPANY\_NAME|  |
|documentInstance/contact/department| *None* |SR\_ARCHIVE\_DEPARTEMENT|  |
|documentInstance/contact/nameDepartment| *None* |SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|documentInstance/contact/hasInfoText| *None* |SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|documentInstance/contact/hasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|documentInstance/contact/associateId| *None* |SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|documentInstance/contact/category| *None* |SR\_ARCHIVE\_CATEGORY|  |
|documentInstance/contact/categoryGroup| *None* |SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|documentInstance/contact/companyCategoryRank| *None* |Category rank|  |
|documentInstance/contact/business| *None* |SR\_ARCHIVE\_BUSINESS|  |
|documentInstance/contact/country| *None* |SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|documentInstance/contact/countryId| *None* |SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|documentInstance/contact/number| *None* |SR\_ARCHIVE\_NUMBER|  |
|documentInstance/contact/code| *None* |SR\_ARCHIVE\_CODE|  |
|documentInstance/contact/orgnr| *None* |VAT No.|  |
|documentInstance/contact/stop| *None* |SR\_CC\_STOPX|  |
|documentInstance/contact/contactNoMail| *None* |SR\_NO\_MAIL\_COMPANY|  |
|documentInstance/contact/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/contact/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/contact/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|documentInstance/contact/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/contact/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/contact/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|documentInstance/contact/contactSource| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|documentInstance/contact/contactDeleted| *None* |SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|documentInstance/contact/phone/formattedNumber| *None* |SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/contact/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|documentInstance/contact/deletedDate| *None* |SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|documentInstance/contact/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|documentInstance/contact/forceCompany| *None* |Dummy: Dummy|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|documentInstance/contact/contactPhone/formattedNumber| *None* |SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/contact/contactPhone/description| *None* |SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/contact/contactFax/formattedNumber| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/contact/contactFax/description| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/contact/searchPhone/formattedNumber| *None* |SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|documentInstance/contact/searchPhone/description| *None* |SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|documentInstance/contact/email/emailProtocol| *None* |SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|documentInstance/contact/email/emailAddress| *None* |SR\_ARCHIVE\_EMAIL|  |
|documentInstance/contact/email/emailDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|documentInstance/contact/email/emailId| *None* |ID|  |
|documentInstance/contact/email/emailLastSent| *None* |SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|documentInstance/contact/email/emailBounceCount| *None* |SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|documentInstance/contact/email/emailLastBounce| *None* |SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|documentInstance/contact/email/emailHasBounced| *None* |SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|documentInstance/contact/postAddress/addressId| *None* |SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|documentInstance/contact/postAddress/line1| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|documentInstance/contact/postAddress/line2| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|documentInstance/contact/postAddress/line3| *None* |SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|documentInstance/contact/postAddress/county| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|documentInstance/contact/postAddress/city| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|documentInstance/contact/postAddress/zip| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|documentInstance/contact/postAddress/state| *None* |SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|documentInstance/contact/postAddress/wgs84latitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|documentInstance/contact/postAddress/wgs84longitude| *None* |SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|documentInstance/contact/postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/streetAddress/addressId| *None* |SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|documentInstance/contact/streetAddress/line1| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|documentInstance/contact/streetAddress/line2| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|documentInstance/contact/streetAddress/line3| *None* |SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|documentInstance/contact/streetAddress/county| *None* |SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|documentInstance/contact/streetAddress/city| *None* |SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|documentInstance/contact/streetAddress/zip| *None* |SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|documentInstance/contact/streetAddress/state| *None* |SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|documentInstance/contact/streetAddress/wgs84latitude| *None* |SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|documentInstance/contact/streetAddress/wgs84longitude| *None* |SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|documentInstance/contact/streetAddress/formattedAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/streetAddress/formattedMultiLineAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/restrictionAddress/addressId| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|documentInstance/contact/restrictionAddress/line1| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|documentInstance/contact/restrictionAddress/line2| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|documentInstance/contact/restrictionAddress/line3| *None* |SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|documentInstance/contact/restrictionAddress/county| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|documentInstance/contact/restrictionAddress/city| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|documentInstance/contact/restrictionAddress/zip| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|documentInstance/contact/restrictionAddress/state| *None* |SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|documentInstance/contact/restrictionAddress/wgs84latitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|documentInstance/contact/restrictionAddress/wgs84longitude| *None* |SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|documentInstance/contact/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|documentInstance/contact/url/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|documentInstance/contact/url/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|documentInstance/contact/contactAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|documentInstance/contact/contactAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|documentInstance/contact/contactAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|documentInstance/contact/contactAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|documentInstance/contact/contactAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|documentInstance/contact/contactAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|documentInstance/contact/contactAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|documentInstance/contact/contactAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|documentInstance/contact/contactAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|documentInstance/contact/contactAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|documentInstance/contact/contactAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|documentInstance/contact/contactAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|documentInstance/contact/contactAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|documentInstance/contact/contactAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|documentInstance/contact/contactInterestIds| *None* |SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|documentInstance/contact/contactUdef/SuperOffice:1| *None* |companyshorttext: tooltipshorttext|  |
|documentInstance/contact/contactUdef/SuperOffice:2| *None* |companylongtext: tooltiplongtext|  |
|documentInstance/contact/contactUdef/SuperOffice:3| *None* |companynumber|  |
|documentInstance/contact/contactUdef/SuperOffice:4| *None* |companydate|  |
|documentInstance/contact/contactUdef/SuperOffice:5| *None* |companyunlimiteddate: tooltipunlimiteddate|  |
|documentInstance/contact/contactUdef/SuperOffice:6| *None* |companycheckbox|  |
|documentInstance/contact/contactUdef/SuperOffice:7| *None* |companydropdownlistbox|  |
|documentInstance/contact/contactUdef/SuperOffice:8| *None* |companydecimal|  |
|documentInstance/contact/contactUdef/SuperOffice:9| *None* |page1saleonly|  |
|documentInstance/contact/contactUdef/SuperOffice:10| *None* |page1marketingonly|  |
|documentInstance/contact/contactUdef/SuperOffice:11| *None* |page1adminonly|  |
|documentInstance/contact/contactUdef/SuperOffice:12| *None* |Udlist one: Static tooltip for udlist one|  |
|documentInstance/contact/contactUdef/SuperOffice:13| *None* |Udlist two: Static tooltip for udlist two|  |
|documentInstance/contact/contactExtra/x\_contact\_integer| *None* |Extra Integer: Custom integer field|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|documentInstance/contact/contactExtra/x\_contact\_hidden\_integer| *None* |Extra hidden integer: Custom integer field - hidden|  |
|documentInstance/contact/contactExtra/x\_contact\_default\_integer| *None* |Extra Default Integer: Custom integer field with default value 123.|  |
|documentInstance/contact/contactExtra/x\_contact\_float| *None* |Extra Float: Custom float field with 3 decimals|  |
|documentInstance/contact/contactExtra/x\_contact\_longtext| *None* |Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|documentInstance/contact/contactExtra/x\_contact\_dropdown| *None* |Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|documentInstance/contact/contactExtra/x\_contact\_date| *None* |Extra date: Custom date field. User current as default.|  |
|documentInstance/contact/contactExtra/x\_contact\_datetime| *None* |Extra DateTime: Custom Date Time field. No default value. External|  |
|documentInstance/contact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.|  |
|documentInstance/contact/contactExtra/x\_contact\_boolean| *None* |Extra boolean: Custom boolean field.|  |
|documentInstance/contact/contactExtra/x\_contact\_timespan| *None* |Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|documentInstance/contact/contactExtra/x\_contact\_shorttext| *None* |Extra short text: Custom short text field. Keep HTML tags.|  |
|documentInstance/contact/contactExtra/x\_contact\_short\_dropdown| *None* |Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|documentInstance/contact/contactExtra/x\_contact\_contact\_relation| *None* |Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|documentInstance/contact/contactExtra/x\_contact\_request\_relation| *None* |Extra Request relation: Request relation on company|  |
|documentInstance/contact/contactExtra/x\_contact\_contact| *None* |Extra contact relation: Contact relation on company|  |
|documentInstance/contact/contactExtra/y\_organization/x\_name| *None* |Organization - Name: Name|  |
|documentInstance/contact/NumberOfActivities| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|documentInstance/contact/NumberOfActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/contact/NumberOfNotCompletedActivities| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|documentInstance/contact/NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/contact/LastActivity| *None* |SR\_ROU\_LAST\_ACTIVITY|  |
|documentInstance/contact/LastCompletedActivity| *None* |SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|documentInstance/contact/LastDoByActivity| *None* |SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|documentInstance/contact/NumberOfSales| *None* |SR\_ROU\_NUMBER\_OF\_SALES|  |
|documentInstance/contact/NumberOfSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/contact/NumberOfNotCompletedSales| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|documentInstance/contact/NumberOfNotCompletedSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/contact/LastSale| *None* |SR\_ROU\_LAST\_SALE|  |
|documentInstance/contact/LastCompletedSale| *None* |SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|documentInstance/contact/LastDoBySale| *None* |SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|documentInstance/contact/NumberOfTickets| *None* |SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|documentInstance/contact/NumberOfTicketsInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/contact/NumberOfNotCompletedTickets| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|documentInstance/contact/NumberOfNotCompletedTicketsInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/contact/LastTicket| *None* |SR\_ROU\_LAST\_TICKET|  |
|documentInstance/contact/LastCompletedTicket| *None* |SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|documentInstance/contact/LastDoByTicket| *None* |SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|documentInstance/contact/SaintStatus1| *None* |Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|documentInstance/contact/SaintStatus2| *None* |C-company: Kundens navn starter med bokstaven C|  |
|documentInstance/contact/saintSaleStatus| *None* |SR\_WITH\_STATUS|  |
|documentInstance/contact/saintAmountClass| *None* |SR\_AMOUNT\_CLASS|  |
|documentInstance/contact/saintActivityType| *None* |SR\_ARCHIVE\_SAINT\_TYPE|  |
|documentInstance/contact/saintDirection| *None* |SR\_ARCHIVE\_DIRECTION|  |
|documentInstance/contact/saintIntention| *None* |SR\_ACTIVITY\_INTENTION|  |
|documentInstance/contact/saintTicketStatus| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|documentInstance/contact/saintTicketCategory| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|documentInstance/project/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP|  |
|documentInstance/project/projectId| *None* |SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP|  |
|documentInstance/project/name| *None* |SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP|  |
|documentInstance/project/number| *None* |SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP|  |
|documentInstance/project/type| *None* |SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP|  |
|documentInstance/project/status| *None* |SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP|  |
|documentInstance/project/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP|  |
|documentInstance/project/associateId| *None* |SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|documentInstance/project/hasInfoText| *None* |SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP|  |
|documentInstance/project/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|documentInstance/project/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|documentInstance/project/description| *None* |SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION|  |
|documentInstance/project/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/project/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/project/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|documentInstance/project/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/project/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/project/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|documentInstance/project/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|documentInstance/project/nextMilestone| *None* |SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP|  |
|documentInstance/project/endDate| *None* |SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP|  |
|documentInstance/project/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|documentInstance/project/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|documentInstance/project/eventId| *None* |SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID|  |
|documentInstance/project/startDate| *None* |SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP|  |
|documentInstance/project/projectPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|documentInstance/project/projectPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|documentInstance/project/projectPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|documentInstance/project/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|documentInstance/project/projectEvent/isExternalEvent| *None* |SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP|  |
|documentInstance/project/projectEvent/eventDate| *None* |SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP|  |
|documentInstance/project/projectEvent/hasSignOn| *None* |SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP|  |
|documentInstance/project/projectEvent/hasSignOff| *None* |SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP|  |
|documentInstance/project/projectUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|documentInstance/project/projectUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|documentInstance/project/projectAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|documentInstance/project/projectAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|documentInstance/project/projectAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|documentInstance/project/projectAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|documentInstance/project/projectAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|documentInstance/project/projectAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|documentInstance/project/projectAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/project/projectAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/project/projectAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|documentInstance/project/projectAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|documentInstance/project/projectAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|documentInstance/project/projectAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/project/projectAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/project/projectAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|documentInstance/project/projectAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|documentInstance/project/projectAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|documentInstance/project/projectAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|documentInstance/project/projectAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|documentInstance/project/projectAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|documentInstance/project/projectAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|documentInstance/project/projectAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|documentInstance/project/projectAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|documentInstance/project/projectAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|documentInstance/project/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|documentInstance/project/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|documentInstance/project/projectAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|documentInstance/project/projectAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|documentInstance/project/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|documentInstance/project/projectAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|documentInstance/project/projectAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|documentInstance/project/projectAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|documentInstance/project/projectAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|documentInstance/project/projectAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|documentInstance/project/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|documentInstance/project/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|documentInstance/project/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|documentInstance/project/projectUdef/SuperOffice:4| *None* |projectdate|  |
|documentInstance/project/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|documentInstance/project/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|documentInstance/project/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|documentInstance/project/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|documentInstance/project/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|documentInstance/project/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
|documentInstance/project/NumberOfActivities| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|documentInstance/project/NumberOfActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/project/NumberOfNotCompletedActivities| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|documentInstance/project/NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/project/LastActivity| *None* |SR\_ROU\_LAST\_ACTIVITY|  |
|documentInstance/project/LastCompletedActivity| *None* |SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|documentInstance/project/LastDoByActivity| *None* |SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|documentInstance/project/NumberOfSales| *None* |SR\_ROU\_NUMBER\_OF\_SALES|  |
|documentInstance/project/NumberOfSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/project/NumberOfNotCompletedSales| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|documentInstance/project/NumberOfNotCompletedSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|documentInstance/project/LastSale| *None* |SR\_ROU\_LAST\_SALE|  |
|documentInstance/project/LastCompletedSale| *None* |SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|documentInstance/project/LastDoBySale| *None* |SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|documentInstance/project/SaintStatus3| *None* |Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|documentInstance/project/saintSaleStatus| *None* |SR\_WITH\_STATUS|  |
|documentInstance/project/saintAmountClass| *None* |SR\_AMOUNT\_CLASS|  |
|documentInstance/project/saintActivityType| *None* |SR\_ARCHIVE\_SAINT\_TYPE|  |
|documentInstance/project/saintDirection| *None* |SR\_ARCHIVE\_DIRECTION|  |
|documentInstance/project/saintIntention| *None* |SR\_ACTIVITY\_INTENTION|  |
|documentInstance/project/saintTicketStatus| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|documentInstance/project/saintTicketCategory| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|documentInstance/project/project/textId| *None* |Text ID|  |
|documentInstance/project/project/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|documentInstance/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|documentInstance/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|documentInstance/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|documentInstance/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|documentInstance/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|documentInstance/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|documentInstance/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|documentInstance/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|documentInstance/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|documentInstance/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|documentInstance/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|documentInstance/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|documentInstance/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|documentInstance/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|documentInstance/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|documentInstance/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|documentInstance/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|documentInstance/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|documentInstance/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|documentInstance/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|documentInstance/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|documentInstance/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|documentInstance/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|documentInstance/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|documentInstance/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|documentInstance/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|documentInstance/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|documentInstance/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|documentInstance/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|documentInstance/documentUdef/SuperOffice:1| *None* |documentshorttext|  |
|documentInstance/documentUdef/SuperOffice:2| *None* |documentlongtext|  |
|documentInstance/documentUdef/SuperOffice:3| *None* |documentnumber|  |
|documentInstance/documentUdef/SuperOffice:4| *None* |documentdate|  |
|documentInstance/documentUdef/SuperOffice:5| *None* |documentunlimiteddate|  |
|documentInstance/documentUdef/SuperOffice:6| *None* |documentcheckbox|  |
|documentInstance/documentUdef/SuperOffice:7| *None* |documentdropdownlistbox|  |
|documentInstance/documentUdef/SuperOffice:8| *None* |documentdecimal|  |
|documentInstance/sale/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|documentInstance/sale/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|documentInstance/sale/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|documentInstance/sale/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|documentInstance/sale/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|documentInstance/sale/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|documentInstance/sale/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|documentInstance/sale/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|documentInstance/sale/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|documentInstance/sale/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|documentInstance/sale/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|documentInstance/sale/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|documentInstance/sale/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|documentInstance/sale/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|documentInstance/sale/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/sale/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|documentInstance/sale/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|documentInstance/sale/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/sale/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|documentInstance/sale/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|documentInstance/sale/currencyId| *None* |SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP|  |
|documentInstance/sale/currency| *None* |SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP|  |
|documentInstance/sale/credited| *None* |SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP|  |
|documentInstance/sale/lossReason| *None* |SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP|  |
|documentInstance/sale/source| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP|  |
|documentInstance/sale/competitor| *None* |SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP|  |
|documentInstance/sale/heading| *None* |SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP|  |
|documentInstance/sale/amount| *None* |SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|documentInstance/sale/amountWeighted| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|documentInstance/sale/earning| *None* |SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP|  |
|documentInstance/sale/earningPercent| *None* |SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP|  |
|documentInstance/sale/probPercent| *None* |SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP|  |
|documentInstance/sale/originalStage| *None* |SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED|  |
|documentInstance/sale/stage| *None* |SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|documentInstance/sale/stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|documentInstance/sale/saleStatus| *None* |SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP|  |
|documentInstance/sale/stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP|  |
|documentInstance/sale/saleType| *None* |SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|documentInstance/sale/saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|documentInstance/sale/stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|documentInstance/sale/nextDueDate| *None* |SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP|  |
|documentInstance/sale/reopenDate| *None* |SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP|  |
|documentInstance/sale/stalledComment| *None* |SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP|  |
|documentInstance/sale/saleTypeCategory| *None* |SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT|  |
|documentInstance/sale/soldReason| *None* |SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP|  |
|documentInstance/sale/saleNumber| *None* |SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER|  |
|documentInstance/sale/hasStakeholders| *None* |SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP|  |
|documentInstance/sale/stakeholdersEnabled| *None* |SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP|  |
|documentInstance/sale/hasQuote| *None* |SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP|  |
|documentInstance/sale/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|documentInstance/sale/description| *None* |SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|documentInstance/sale/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|documentInstance/sale/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|documentInstance/sale/amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|documentInstance/sale/amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|documentInstance/sale/daysInStage| *None* |SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP|  |
|documentInstance/sale/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|documentInstance/sale/sale/textId| *None* |Text ID|  |
|documentInstance/sale/sale/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|documentInstance/sale/salePublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|documentInstance/sale/salePublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|documentInstance/sale/salePublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|documentInstance/sale/salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|documentInstance/sale/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|documentInstance/sale/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|documentInstance/sale/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|documentInstance/sale/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|documentInstance/sale/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|documentInstance/sale/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|documentInstance/sale/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/sale/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|documentInstance/sale/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|documentInstance/sale/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|documentInstance/sale/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|documentInstance/sale/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/sale/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|documentInstance/sale/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|documentInstance/sale/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|documentInstance/sale/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|documentInstance/sale/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|documentInstance/sale/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|documentInstance/sale/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|documentInstance/sale/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|documentInstance/sale/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|documentInstance/sale/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|documentInstance/sale/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|documentInstance/sale/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|documentInstance/sale/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|documentInstance/sale/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|documentInstance/sale/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|documentInstance/sale/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|documentInstance/sale/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|documentInstance/sale/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|documentInstance/sale/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|documentInstance/sale/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|documentInstance/sale/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|documentInstance/sale/saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|documentInstance/sale/saleUdef/SuperOffice:2| *None* |salelongtext|  |
|documentInstance/sale/saleUdef/SuperOffice:3| *None* |salenumber|  |
|documentInstance/sale/saleUdef/SuperOffice:4| *None* |saledate|  |
|documentInstance/sale/saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|documentInstance/sale/saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|documentInstance/sale/saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|documentInstance/sale/saleUdef/SuperOffice:8| *None* |saledecimal|  |
|documentInstance/document/textId| *None* |Text ID|  |
|documentInstance/document/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/SaleGuide?$select=stageName,appointmentInstance/contact/registeredBy,appointmentInstance/contact/restrictionAddress/wgs84latitude,appointmentInstance/contact/NumberOfTickets,appointmentInstance/project/projectAssociate/contactDepartment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


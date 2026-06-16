---
uid: Links
title: Links
description: 
keywords: Links archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Links"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksProvider">SuperOffice.CRM.ArchiveLists.LinksProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"appointment"|[[SR_AA_FOLLOWUPS]]|
|"sale"|[[SR_AA_SALES]]|
|"project"|[[SR_PROJECT]]|
|"document"|[[SR_AA_DOCUMENTS]]|
|"url"|url|
|"person"|[[SR_PERSON]]|
|"Contact"|[[SR_CONTACT]]|
|"Selection"|[[SR_SINGULAR_SELECTION]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|sourceAppointmentRestrictionId|int|SR\_RESTRICTION\_LINKAPPOINTMENTSOURCE: SR\_RESTRICTION\_LINKAPPOINTMENTSOURCE\_TOOLTIP|  |
|sourceSaleRestrictionId|int|SR\_RESTRICTION\_LINKSALESOURCE: SR\_RESTRICTION\_LINKSALESOURCE\_TOOLTIP|  |
|sourceDocumentRestrictionId|int|SR\_RESTRICTION\_LINKDOCUMENTSOURCE: SR\_RESTRICTION\_LINKDOCUMENTSOURCE\_TOOLTIP|  |
|sourceProjectRestrictionId|int|SR\_RESTRICTION\_LINKPROJECTSOURCE: SR\_RESTRICTION\_LINKPROJECTSOURCE\_TOOLTIP|  |
|sourcePersonRestrictionId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sourceContactRestrictionId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|sourceSelectionRestrictionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|linkId|int|SR\_RESTRICTION\_LINK: SR\_RESTRICTION\_LINK\_TOOLTIP|  |
|linkDescription|string|SR\_RESTRICTION\_LINKDESCRIPTION: SR\_RESTRICTION\_LINKDESCRIPTION\_TOOLTIP|  |
|completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|appointmentId|int|SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP|  |
|endDate|date|SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP|  |
|priority|listAny|SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP|  |
|alarm|bool|SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP|  |
|isFree|bool|SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP|  |
|recurring|bool|SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP|  |
|booking|bool|SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP|  |
|intention|listAny|SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP|  |
|location|string|SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP|  |
|recurrenceRuleId|int|SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP|  |
|rawType|int|SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP|  |
|rawStatus|int|SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP|  |
|cautionWarning|listAny|SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP|  |
|visibleInDiary|bool|SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP|  |
|endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|suggestedAppointmentId|int|SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP|  |
|completedDate|date|SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP|  |
|isMilestone|bool|SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP|  |
|invitedPersonId|int|SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP|  |
|recordTypeText|listAny|SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP|  |
|joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP|  |
|duration|timeSpan|SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|appointmentPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|appointmentPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|appointmentPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|contact/contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|contact/name|stringorPK|SR\_COMPANY\_NAME|  |
|contact/department|string|SR\_ARCHIVE\_DEPARTEMENT|  |
|contact/nameDepartment|string|SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|contact/hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|contact/hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|contact/associateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|contact/category|listAny|SR\_ARCHIVE\_CATEGORY|  |
|contact/categoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|contact/companyCategoryRank|int|Category rank|  |
|contact/business|listAny|SR\_ARCHIVE\_BUSINESS|  |
|contact/country|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|contact/countryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|contact/number|string|SR\_ARCHIVE\_NUMBER|  |
|contact/code|string|SR\_ARCHIVE\_CODE|  |
|contact/orgnr|string|VAT No.|  |
|contact/stop|bool|SR\_CC\_STOPX|  |
|contact/contactNoMail|bool|SR\_NO\_MAIL\_COMPANY|  |
|contact/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|contact/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|contact/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|contact/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|contact/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|contact/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|contact/contactSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|contact/contactDeleted|bool|SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|contact/phone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contact/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|contact/deletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|contact/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|contact/forceCompany|bool|Dummy: Dummy|  |
|contact/contactPhone/formattedNumber|string|SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contact/contactPhone/description|string|SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|contact/contactFax/formattedNumber|string|SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contact/contactFax/description|string|SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|contact/searchPhone/formattedNumber|string|SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contact/searchPhone/description|string|SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|contact/email/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|contact/email/emailAddress|string|SR\_ARCHIVE\_EMAIL|  |
|contact/email/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/email/emailId|int|ID|  |
|contact/email/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|contact/email/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|contact/email/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|contact/email/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|contact/postAddress/addressId|int|SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|contact/postAddress/line1|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|contact/postAddress/line2|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|contact/postAddress/line3|string|SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|contact/postAddress/county|string|SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|contact/postAddress/city|string|SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|contact/postAddress/zip|string|SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|contact/postAddress/state|string|SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|contact/postAddress/wgs84latitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|contact/postAddress/wgs84longitude|decimal|SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|contact/postAddress/formattedAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|contact/postAddress/formattedMultiLineAddress| *None* |SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/addressId|int|SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|contact/streetAddress/line1|string|SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|contact/streetAddress/line2|string|SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|contact/streetAddress/line3|string|SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|contact/streetAddress/county|string|SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|contact/streetAddress/city|string|SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|contact/streetAddress/zip|string|SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|contact/streetAddress/state|string|SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|contact/streetAddress/wgs84latitude|decimal|SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|contact/streetAddress/wgs84longitude|decimal|SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|contact/streetAddress/formattedAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|contact/streetAddress/formattedMultiLineAddress| *None* |SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/addressId|int|SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|contact/restrictionAddress/line1|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|contact/restrictionAddress/line2|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|contact/restrictionAddress/line3|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|contact/restrictionAddress/county|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|contact/restrictionAddress/city|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|contact/restrictionAddress/zip|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|contact/restrictionAddress/state|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|contact/restrictionAddress/wgs84latitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|contact/restrictionAddress/wgs84longitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|contact/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|contact/url/URLAddress|string|SR\_PROJECTARCHIVE\_URL|  |
|contact/url/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|contact/contactAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|contact/contactAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|contact/contactAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|contact/contactAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|contact/contactAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|contact/contactAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|contact/contactAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|contact/contactAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|contact/contactAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|contact/contactAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|contact/contactAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|contact/contactAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|contact/contactAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|contact/contactAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|contact/contactAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|contact/contactAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|contact/contactAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|contact/contactAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|contact/contactAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|contact/contactAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|contact/contactAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|contact/contactAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|contact/contactAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|contact/contactAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|contact/contactAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|contact/contactAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|contact/contactAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|contact/contactAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|contact/contactAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|contact/contactAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|contact/contactAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL|  |
|contact/contactAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|contact/contactAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|contact/contactInterestIds|listInterest|SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|contact/contactUdef/SuperOffice:1|string|companyshorttext: tooltipshorttext|  |
|contact/contactUdef/SuperOffice:2|string|companylongtext: tooltiplongtext|  |
|contact/contactUdef/SuperOffice:3|int|companynumber|  |
|contact/contactUdef/SuperOffice:4|date|companydate|  |
|contact/contactUdef/SuperOffice:5|unlimitedDate|companyunlimiteddate: tooltipunlimiteddate|  |
|contact/contactUdef/SuperOffice:6|bool|companycheckbox|  |
|contact/contactUdef/SuperOffice:7|listAny|companydropdownlistbox|  |
|contact/contactUdef/SuperOffice:8|decimal|companydecimal|  |
|contact/contactUdef/SuperOffice:9|string|page1saleonly|  |
|contact/contactUdef/SuperOffice:10|string|page1marketingonly|  |
|contact/contactUdef/SuperOffice:11|string|page1adminonly|  |
|contact/contactUdef/SuperOffice:12|listAny|Udlist one: Static tooltip for udlist one|  |
|contact/contactUdef/SuperOffice:13|listAny|Udlist two: Static tooltip for udlist two|  |
|contact/contactExtra/x\_contact\_integer|int|Extra Integer: Custom integer field|  |
|contact/contactExtra/x\_contact\_hidden\_integer|int|Extra hidden integer: Custom integer field - hidden|  |
|contact/contactExtra/x\_contact\_default\_integer|int|Extra Default Integer: Custom integer field with default value 123.|  |
|contact/contactExtra/x\_contact\_float|decimal|Extra Float: Custom float field with 3 decimals|  |
|contact/contactExtra/x\_contact\_longtext|string|Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|contact/contactExtra/x\_contact\_dropdown|listAny|Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|contact/contactExtra/x\_contact\_date|date|Extra date: Custom date field. User current as default.|  |
|contact/contactExtra/x\_contact\_datetime|datetime|Extra DateTime: Custom Date Time field. No default value. External|  |
|contact/contactExtra/x\_contact\_time| *None* |Extra time: Custom time field.|  |
|contact/contactExtra/x\_contact\_boolean|bool|Extra boolean: Custom boolean field.|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/contactExtra/x\_contact\_timespan|timeSpan|Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|contact/contactExtra/x\_contact\_shorttext|string|Extra short text: Custom short text field. Keep HTML tags.|  |
|contact/contactExtra/x\_contact\_short\_dropdown|listAny|Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|contact/contactExtra/x\_contact\_contact\_relation|stringorPK|Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|contact/contactExtra/x\_contact\_request\_relation|stringorPK|Extra Request relation: Request relation on company|  |
|contact/contactExtra/x\_contact\_contact|stringorPK|Extra contact relation: Contact relation on company|  |
|contact/contactExtra/y\_organization/x\_name|string|Organization - Name: Name|  |
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
|person/personId|int|SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|person/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|person/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|person/middleName|string|SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|person/fullName|string|SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|person/contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|person/hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|person/hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|person/personHasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|person/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|person/position|listAny|SR\_ARCHIVE\_POSITION|  |
|person/personNumber|string|SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|person/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|person/personCountry|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|person/personCountryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|person/personNoMail|bool|SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|person/rank|int|SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|person/birthdate| *None* |SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|person/associateType| *None* |SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|person/useAsMailingAddress|bool|SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|person/personSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|person/retired|bool|SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|person/birthYear|int|SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|person/birthMonth|int|SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|person/birthDay|int|SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|person/kanaFirstName|string|SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|person/kanaLastName|string|SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|person/personUpdatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|person/personUpdatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|person/personUpdatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|person/personRegisteredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|person/personRegisteredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|person/personRegisteredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|person/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|person/personActiveErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|person/ticketPriority|listAny|SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|person/supportLanguage|listAny|SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|person/supportAssociate|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|person/supportAssociateFullName|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|person/personAssociateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|person/personAssociateFullName|associate|SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|person/personCategory|listAny|SR\_ARCHIVE\_CATEGORY|  |
|person/personCategoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|person/personCategoryRank|int|!!Category rank|  |
|person/personBusiness|listAny|SR\_ARCHIVE\_BUSINESS|  |
|person/leadStatus|listAny|SR\_LABEL\_LEADSTATUS|  |
|person/leadstatusRank|int|!!Lead status RANK|  |
|person/personDeletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|person/hasCompany|bool|SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|person/isProjectMember|bool|SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|person/isStakeholder|bool|SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|person/updatedByWorkflow|listAny|SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|person/whenUpdatedByWorkflow|datetime|SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|person/createdByForm|listAny|SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|person/phone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personDirectPhone/formattedNumber|string|SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personDirectPhone/description|string|SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|person/personMobilePhone/formattedNumber|string|SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personMobilePhone/description|string|SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|person/personPrivate/formattedNumber|string|SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personPrivate/description|string|SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|person/personPager/formattedNumber|string|SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personPager/description|string|SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/personDirectFax/formattedNumber|string|SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/personDirectFax/description|string|SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|person/searchPhone/formattedNumber|string|SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|person/searchPhone/description|string|SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|person/personInfo/textId|int|Text ID|  |
|person/personInfo/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|person/email/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|person/email/emailAddress|string|SR\_ARCHIVE\_EMAIL|  |
|person/email/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|person/email/emailId|int|ID|  |
|person/email/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|person/email/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|person/email/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|person/email/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|person/personUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL|  |
|person/personUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|person/personAddress/addressId|int|SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|person/personAddress/line1|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|person/personAddress/line2|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|person/personAddress/line3|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|person/personAddress/county|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|person/personAddress/city|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|person/personAddress/zip|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|person/personAddress/state|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|person/personAddress/wgs84latitude|decimal|SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|person/personAddress/wgs84longitude|decimal|SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|person/personAddress/formattedAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|person/personAddress/formattedMultiLineAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/addressId|int|SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|person/restrictionAddress/line1|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|person/restrictionAddress/line2|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|person/restrictionAddress/line3|string|SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|person/restrictionAddress/county|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|person/restrictionAddress/city|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|person/restrictionAddress/zip|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|person/restrictionAddress/state|string|SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|person/restrictionAddress/wgs84latitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|person/restrictionAddress/wgs84longitude|decimal|SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|person/restrictionAddress/formattedAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|person/personInterestIds|listInterest|SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|person/personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext|  |
|person/personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext|  |
|person/personUdef/SuperOffice:3|int|contactnumber|  |
|person/personUdef/SuperOffice:4|date|contactdate|  |
|person/personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate|  |
|person/personUdef/SuperOffice:6|bool|contactcheckbox|  |
|person/personUdef/SuperOffice:7|listAny|contactdropdownlistbox|  |
|person/personUdef/SuperOffice:8|decimal|contactdecimal|  |
|person/personUdef/SuperOffice:9|string|page1saleonly|  |
|person/personUdef/SuperOffice:10|string|page1marketingonly|  |
|person/personUdef/SuperOffice:11|string|page1adminonly|  |
|person/personExtra/x\_person\_integer|int|Extra Integer: Custom person integer|  |
|person/personExtra/x\_person\_hidden\_integer|int|Extra hidden integer: Custom integer field that is hidden|  |
|person/personExtra/x\_person\_float|decimal|Extra float: Custom float field|  |
|person/personExtra/x\_person\_longtext|string|Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|person/personExtra/x\_person\_date|date|Extra date: Custom date field on person. Default value = 28.03.2019|  |
|person/personExtra/x\_person\_datetime|datetime|Extra DateTime: Custom person date and time field. No default|  |
|person/personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default|  |
|person/personExtra/x\_person\_boolean|bool|Extra Boolean: Custom boolean field on person. Default checked|  |
|person/personExtra/x\_person\_timespan|timeSpan|Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|person/personExtra/x\_person\_shorttext|string|Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|person/personExtra/x\_person\_shorttext\_list|listAny|Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|person/personExtra/x\_person\_user\_relation|associate|Extra user relation: Custom person-user relation field|  |
|person/personExtra/x\_person\_category\_relation|listAny|Extra category relation: Custom person-category relation|  |
|person/personExtra/x\_person\_priority\_relation|listAny|Extra priority relation: Custom person-priority relation|  |
|person/personExtra/x\_person\_request\_relation|stringorPK|Extra request relation: Request relation on contact|  |
|person/personExtra/x\_person\_appointment\_relation|stringorPK|Extra appointment relation: Appointment relation on person|  |
|person/personExtra/x\_person\_contact\_relation|stringorPK|Extra company relation: Company relation on contact|  |
|person/personExtra/y\_rental/id|int|Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)|  |
|person/personExtra/y\_rental/x\_start|date|Rental - Start rental: Start rental|  |
|person/personExtra/y\_rental/x\_end|date|Rental - End: End|  |
|person/personExtra/y\_rental/x\_amount|int|Rental - Amount: Number to rent. Default = 1|  |
|person/personExtra/y\_rental/x\_contact|stringorPK|Rental - Renter: Company that rents equipment|  |
|person/personExtra/y\_rental/y\_equipment/x\_name|string|Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|person/personExtra/y\_car/id|int|Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)|  |
|person/personAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|person/personAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|person/personAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|person/personAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|person/personAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|person/personAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|person/personAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|person/personAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|person/personAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|person/personAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|person/personAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|person/personAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|person/personAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|person/personAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|person/personAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|person/personAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|person/personAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|person/personAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|person/personAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|person/personAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|person/personAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|person/personAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|person/personAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|person/personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|person/personAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|person/personAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|person/personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|person/personAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|person/personAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|person/personAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL|  |
|person/personAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|person/personAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|person/correspondingAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|person/correspondingAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|person/correspondingAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|person/correspondingAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|person/correspondingAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|person/correspondingAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|person/correspondingAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|person/correspondingAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|person/correspondingAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|person/correspondingAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|person/correspondingAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|person/correspondingAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|person/correspondingAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|person/correspondingAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|person/correspondingAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|person/correspondingAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|person/correspondingAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|person/correspondingAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|person/correspondingAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|person/correspondingAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|person/correspondingAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|person/correspondingAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|person/correspondingAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|person/correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|person/correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|person/correspondingAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|person/correspondingAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|person/correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|person/correspondingAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|person/correspondingAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|person/correspondingAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL|  |
|person/correspondingAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|person/correspondingAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|person/isMailingRecipient|bool|SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient|  |
|person/hasStoreConsent|bool|SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/withdrawnStoreConsent|bool|SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/hasEmarketingConsent|bool|SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/withdrawnEmarketingConsent|bool|SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/subscription|listAny|SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP|  |
|person/legalBaseStore|listAny|SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/legalBaseEmarketing|listAny|SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|person/consentSourceStore|listAny|SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|person/consentSourceEmarketing|listAny|SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|appointmentUdef/SuperOffice:1|string|followupshorttext|  |
|appointmentUdef/SuperOffice:2|string|followuplongtext|  |
|appointmentUdef/SuperOffice:3|int|followupnumber|  |
|appointmentUdef/SuperOffice:4|date|followupdate|  |
|appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate|  |
|appointmentUdef/SuperOffice:6|bool|followupcheckbox|  |
|appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox|  |
|appointmentUdef/SuperOffice:8|decimal|followupdecimal|  |
|project/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP|  |
|project/projectId|int|SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP|  |
|project/name|stringorPK|SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP|  |
|project/number|string|SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP|  |
|project/type|listAny|SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP|  |
|project/status|listAny|SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP|  |
|project/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP|  |
|project/associateId|associate|SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|project/hasInfoText|bool|SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP|  |
|project/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|project/text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|project/description|string|SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION|  |
|project/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|project/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|project/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|project/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|project/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|project/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|project/hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|project/nextMilestone|date|SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP|  |
|project/endDate|date|SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP|  |
|project/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|project/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|project/eventId|int|SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID|  |
|project/startDate|date|SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP|  |
|project/projectPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|project/projectPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|project/projectPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|project/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|project/projectEvent/isExternalEvent|bool|SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP|  |
|project/projectEvent/eventDate|date|SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP|  |
|project/projectEvent/hasSignOn|bool|SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP|  |
|project/projectEvent/hasSignOff|bool|SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP|  |
|project/projectUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL|  |
|project/projectUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|project/projectAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|project/projectAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|project/projectAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|project/projectAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|project/projectAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|project/projectAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|project/projectAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|project/projectAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|project/projectAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|project/projectAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|project/projectAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|project/projectAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|project/projectAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|project/projectAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|project/projectAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|project/projectAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|project/projectAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|project/projectAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|project/projectAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|project/projectAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|project/projectAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|project/projectAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|project/projectAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|project/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|project/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|project/projectAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|project/projectAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|project/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|project/projectAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|project/projectAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|project/projectAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL|  |
|project/projectAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|project/projectAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|project/projectUdef/SuperOffice:1|string|projectshorttext|  |
|project/projectUdef/SuperOffice:2|string|projectlongtext|  |
|project/projectUdef/SuperOffice:3|int|projectnumber|  |
|project/projectUdef/SuperOffice:4|date|projectdate|  |
|project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate|  |
|project/projectUdef/SuperOffice:6|bool|projectcheckbox|  |
|project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox|  |
|project/projectUdef/SuperOffice:8|decimal|projectdecimal|  |
|project/projectUdef/SuperOffice:9|int|page1saleandmarketing|  |
|project/projectUdef/SuperOffice:10|int|page1saleandadmin|  |
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
|project/project/textId|int|Text ID|  |
|project/project/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|sale/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|sale/icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|sale/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|sale/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|sale/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|sale/recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|sale/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|sale/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|sale/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|sale/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sale/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|sale/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|sale/userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|sale/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|sale/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|sale/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|sale/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|sale/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|sale/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|sale/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|sale/currencyId|int|SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP|  |
|sale/currency|listAny|SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP|  |
|sale/credited|listAny|SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP|  |
|sale/lossReason|listAny|SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP|  |
|sale/source|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP|  |
|sale/competitor|listAny|SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP|  |
|sale/heading|stringorPK|SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP|  |
|sale/amount|decimal|SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|sale/amountWeighted|decimal|SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|sale/earning|decimal|SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP|  |
|sale/earningPercent|decimal|SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP|  |
|sale/probPercent|int|SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP|  |
|sale/originalStage|listAny|SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED|  |
|sale/stage|listAny|SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|sale/stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|sale/saleStatus|listAny|SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP|  |
|sale/stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP|  |
|sale/saleType|listAny|SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|sale/stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|sale/nextDueDate|date|SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP|  |
|sale/reopenDate|date|SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP|  |
|sale/stalledComment|listAny|SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP|  |
|sale/saleTypeCategory|listAny|SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT|  |
|sale/soldReason|listAny|SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP|  |
|sale/saleNumber|string|SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER|  |
|sale/hasStakeholders|bool|SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP|  |
|sale/stakeholdersEnabled|bool|SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP|  |
|sale/hasQuote|bool|SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP|  |
|sale/hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|sale/description|string|SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|sale/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|sale/createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|sale/amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|sale/amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|sale/daysInStage|int|SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP|  |
|sale/visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|sale/sale/textId|int|Text ID|  |
|sale/sale/description|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|sale/salePublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|sale/salePublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|sale/salePublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|sale/salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|sale/associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|sale/associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|sale/associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|sale/associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|sale/associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|sale/associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sale/associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|sale/associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|sale/associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|sale/associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|sale/associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|sale/associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|sale/associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|sale/associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|sale/associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|sale/associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|sale/associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|sale/associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|sale/associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|sale/associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|sale/associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|sale/associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|sale/associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|sale/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|sale/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|sale/associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|sale/associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|sale/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|sale/associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|sale/associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|sale/associate/personEmail|string|SR\_ARCHIVE\_EMAIL|  |
|sale/associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|sale/associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|sale/saleUdef/SuperOffice:1|string|saleshorttext|  |
|sale/saleUdef/SuperOffice:2|string|salelongtext|  |
|sale/saleUdef/SuperOffice:3|int|salenumber|  |
|sale/saleUdef/SuperOffice:4|date|saledate|  |
|sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate|  |
|sale/saleUdef/SuperOffice:6|bool|salecheckbox|  |
|sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox|  |
|sale/saleUdef/SuperOffice:8|decimal|saledecimal|  |
|associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|associate/personEmail|string|SR\_ARCHIVE\_EMAIL|  |
|associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|appointment/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointment/description|positiveString|SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/title|positiveString|SR\_TICKETARCHIVE\_TITLE|  |
|appointment/titleHtml| *None* |!!Title Html|  |
|appointment/agenda|positiveString|SR\_APPOINTMENT\_AGENDA|  |
|appointment/agendaHtml| *None* |!!Agenda Html|  |
|appointment/isConverted| *None* |!!Is Converted|  |
|appointment/textId|int|Text ID|  |
|appointment/internalNotes|positiveString|SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/internalNotesHtml|positiveString|!!Internal Notes Html|  |
|destinationAppointmentRestrictionId|int|SR\_RESTRICTION\_LINKAPPOINTMENTDESTINATION: SR\_RESTRICTION\_LINKAPPOINTMENTDESTINATION\_TOOLTIP|  |
|currencyId|int|SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP|  |
|currency|listAny|SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP|  |
|credited|listAny|SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP|  |
|lossReason|listAny|SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP|  |
|source|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP|  |
|competitor|listAny|SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP|  |
|heading|stringorPK|SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP|  |
|amount|decimal|SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|amountWeighted|decimal|SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|earning|decimal|SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP|  |
|earningPercent|decimal|SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP|  |
|probPercent|int|SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP|  |
|originalStage|listAny|SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED|  |
|stage|listAny|SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|saleStatus|listAny|SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP|  |
|stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP|  |
|saleType|listAny|SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|nextDueDate|date|SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP|  |
|reopenDate|date|SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP|  |
|stalledComment|listAny|SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP|  |
|saleTypeCategory|listAny|SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT|  |
|soldReason|listAny|SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP|  |
|saleNumber|string|SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER|  |
|hasStakeholders|bool|SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP|  |
|stakeholdersEnabled|bool|SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP|  |
|hasQuote|bool|SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP|  |
|hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|description|string|SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|daysInStage|int|SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP|  |
|sale/textId|int|Text ID|  |
|salePublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|salePublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|salePublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|saleUdef/SuperOffice:1|string|saleshorttext|  |
|saleUdef/SuperOffice:2|string|salelongtext|  |
|saleUdef/SuperOffice:3|int|salenumber|  |
|saleUdef/SuperOffice:4|date|saledate|  |
|saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate|  |
|saleUdef/SuperOffice:6|bool|salecheckbox|  |
|saleUdef/SuperOffice:7|listAny|saledropdownlistbox|  |
|saleUdef/SuperOffice:8|decimal|saledecimal|  |
|saleStakeholder/saleStakeholderId|int|SR\_STAKEHOLDER - SR\_STAKEHOLDER\_ID: SR\_STAKEHOLDER\_ID\_TOOLTIP|  |
|saleStakeholder/saleId|int|SR\_STAKEHOLDER - SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|saleStakeholder/comment|string|SR\_STAKEHOLDER - SR\_STAKEHOLDERS\_ROLE\_COMMENT\_TEXT: SR\_STAKEHOLDERS\_ROLE\_COMMENT\_TEXT|  |
|saleStakeholder/salesRoleId|listAny|SR\_STAKEHOLDER - SR\_STAKEHOLDERS\_ROLE: SR\_STAKEHOLDERS\_ROLE|  |
|saleStakeholder/hasInfoText|bool|SR\_STAKEHOLDER - SR\_STAKEHOLDERS\_ROLE\_COMMENT: SR\_STAKEHOLDERS\_ROLE\_COMMENT|  |
|saleStakeholder/person/personId|int|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|saleStakeholder/person/firstName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|saleStakeholder/person/lastName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|saleStakeholder/person/middleName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|saleStakeholder/person/fullName|string|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|saleStakeholder/person/contactId|int|SR\_STAKEHOLDER - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|saleStakeholder/person/hasInfoText|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|saleStakeholder/person/hasInterests|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|saleStakeholder/person/personHasInterests|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|saleStakeholder/person/mrMrs|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|saleStakeholder/person/position|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_POSITION|  |
|saleStakeholder/person/personNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|saleStakeholder/person/title|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|saleStakeholder/person/personCountry|listAny|SR\_STAKEHOLDER - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|saleStakeholder/person/personCountryId|int|SR\_STAKEHOLDER - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|saleStakeholder/person/personNoMail|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|saleStakeholder/person/rank|int|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|saleStakeholder/person/birthdate| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|saleStakeholder/person/associateType| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|saleStakeholder/person/useAsMailingAddress|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|saleStakeholder/person/personSource|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|saleStakeholder/person/retired|bool|SR\_STAKEHOLDER - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|saleStakeholder/person/birthYear|int|SR\_STAKEHOLDER - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|saleStakeholder/person/birthMonth|int|SR\_STAKEHOLDER - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|saleStakeholder/person/birthDay|int|SR\_STAKEHOLDER - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|saleStakeholder/person/kanaFirstName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|saleStakeholder/person/kanaLastName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|saleStakeholder/person/personUpdatedBy|associate|SR\_STAKEHOLDER - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|saleStakeholder/person/personUpdatedByFullName|associate|SR\_STAKEHOLDER - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|saleStakeholder/person/personUpdatedDate|date|SR\_STAKEHOLDER - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|saleStakeholder/person/personRegisteredBy|associate|SR\_STAKEHOLDER - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|saleStakeholder/person/personRegisteredByFullName|associate|SR\_STAKEHOLDER - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|saleStakeholder/person/personRegisteredDate|date|SR\_STAKEHOLDER - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|saleStakeholder/person/portraitThumbnail| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|saleStakeholder/person/personActiveErpLinks|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|saleStakeholder/person/ticketPriority|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|saleStakeholder/person/supportLanguage|listAny|SR\_STAKEHOLDER - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/supportAssociate|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|saleStakeholder/person/supportAssociateFullName|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|saleStakeholder/person/personAssociateId|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|saleStakeholder/person/personAssociateFullName|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|saleStakeholder/person/personCategory|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY|  |
|saleStakeholder/person/personCategoryGroup|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|saleStakeholder/person/personCategoryRank|int|SR\_STAKEHOLDER - !!Category rank|  |
|saleStakeholder/person/personBusiness|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_BUSINESS|  |
|saleStakeholder/person/leadStatus|listAny|SR\_STAKEHOLDER - SR\_LABEL\_LEADSTATUS|  |
|saleStakeholder/person/leadstatusRank|int|SR\_STAKEHOLDER - !!Lead status RANK|  |
|saleStakeholder/person/personDeletedDate|datetime|SR\_STAKEHOLDER - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|saleStakeholder/person/hasCompany|bool|SR\_STAKEHOLDER - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|saleStakeholder/person/isProjectMember|bool|SR\_STAKEHOLDER - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|saleStakeholder/person/isStakeholder|bool|SR\_STAKEHOLDER - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|saleStakeholder/person/updatedByWorkflow|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|saleStakeholder/person/whenUpdatedByWorkflow|datetime|SR\_STAKEHOLDER - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|saleStakeholder/person/createdByForm|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|saleStakeholder/person/phone/formattedNumber|string|SR\_STAKEHOLDER - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personDirectPhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personDirectPhone/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/person/personMobilePhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personMobilePhone/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/person/personPrivate/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personPrivate/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/person/personPager/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personPager/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/person/personDirectFax/formattedNumber|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/personDirectFax/description|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/person/searchPhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/person/searchPhone/description|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/person/personInfo/textId|int|SR\_STAKEHOLDER - Text ID|  |
|saleStakeholder/person/personInfo/infoText|positiveString|SR\_STAKEHOLDER - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|saleStakeholder/person/email/emailProtocol|string|SR\_STAKEHOLDER - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|saleStakeholder/person/email/emailAddress|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL|  |
|saleStakeholder/person/email/emailDescription|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION|  |
|saleStakeholder/person/email/emailId|int|SR\_STAKEHOLDER - ID|  |
|saleStakeholder/person/email/emailLastSent|datetime|SR\_STAKEHOLDER - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|saleStakeholder/person/email/emailBounceCount|int|SR\_STAKEHOLDER - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|saleStakeholder/person/email/emailLastBounce|datetime|SR\_STAKEHOLDER - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|saleStakeholder/person/email/emailHasBounced|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|saleStakeholder/person/personUrl/URLAddress|string|SR\_STAKEHOLDER - SR\_PROJECTARCHIVE\_URL|  |
|saleStakeholder/person/personUrl/URLDescription|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION|  |
|saleStakeholder/person/personAddress/addressId|int|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|saleStakeholder/person/personAddress/line1|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|saleStakeholder/person/personAddress/line2|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|saleStakeholder/person/personAddress/line3|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|saleStakeholder/person/personAddress/county|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|saleStakeholder/person/personAddress/city|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|saleStakeholder/person/personAddress/zip|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|saleStakeholder/person/personAddress/state|string|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|saleStakeholder/person/personAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|saleStakeholder/person/personAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|saleStakeholder/person/personAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/addressId|int|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|saleStakeholder/person/restrictionAddress/line1|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|saleStakeholder/person/restrictionAddress/line2|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|saleStakeholder/person/restrictionAddress/line3|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|saleStakeholder/person/restrictionAddress/county|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|saleStakeholder/person/restrictionAddress/city|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|saleStakeholder/person/restrictionAddress/zip|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|saleStakeholder/person/restrictionAddress/state|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|saleStakeholder/person/restrictionAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|saleStakeholder/person/restrictionAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|saleStakeholder/person/restrictionAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/person/personInterestIds|listInterest|SR\_STAKEHOLDER - SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|saleStakeholder/person/personUdef/SuperOffice:1|string|SR\_STAKEHOLDER - contactshorttext: tooltipshorttext|  |
|saleStakeholder/person/personUdef/SuperOffice:2|string|SR\_STAKEHOLDER - contactlongtext: tooltiplongtext|  |
|saleStakeholder/person/personUdef/SuperOffice:3|int|SR\_STAKEHOLDER - contactnumber|  |
|saleStakeholder/person/personUdef/SuperOffice:4|date|SR\_STAKEHOLDER - contactdate|  |
|saleStakeholder/person/personUdef/SuperOffice:5|unlimitedDate|SR\_STAKEHOLDER - contactunlimiteddate: tooltipunlimiteddate|  |
|saleStakeholder/person/personUdef/SuperOffice:6|bool|SR\_STAKEHOLDER - contactcheckbox|  |
|saleStakeholder/person/personUdef/SuperOffice:7|listAny|SR\_STAKEHOLDER - contactdropdownlistbox|  |
|saleStakeholder/person/personUdef/SuperOffice:8|decimal|SR\_STAKEHOLDER - contactdecimal|  |
|saleStakeholder/person/personUdef/SuperOffice:9|string|SR\_STAKEHOLDER - page1saleonly|  |
|saleStakeholder/person/personUdef/SuperOffice:10|string|SR\_STAKEHOLDER - page1marketingonly|  |
|saleStakeholder/person/personUdef/SuperOffice:11|string|SR\_STAKEHOLDER - page1adminonly|  |
|saleStakeholder/person/personExtra/x\_person\_integer|int|SR\_STAKEHOLDER - Extra Integer: Custom person integer|  |
|saleStakeholder/person/personExtra/x\_person\_hidden\_integer|int|SR\_STAKEHOLDER - Extra hidden integer: Custom integer field that is hidden|  |
|saleStakeholder/person/personExtra/x\_person\_float|decimal|SR\_STAKEHOLDER - Extra float: Custom float field|  |
|saleStakeholder/person/personExtra/x\_person\_longtext|string|SR\_STAKEHOLDER - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'|  |
|saleStakeholder/person/personExtra/x\_person\_date|date|SR\_STAKEHOLDER - Extra date: Custom date field on person. Default value = 28.03.2019|  |
|saleStakeholder/person/personExtra/x\_person\_datetime|datetime|SR\_STAKEHOLDER - Extra DateTime: Custom person date and time field. No default|  |
|saleStakeholder/person/personExtra/x\_person\_time| *None* |SR\_STAKEHOLDER - Extra time: Custom time field on person. Current time as default|  |
|saleStakeholder/person/personExtra/x\_person\_boolean|bool|SR\_STAKEHOLDER - Extra Boolean: Custom boolean field on person. Default checked|  |
|saleStakeholder/person/personExtra/x\_person\_timespan|timeSpan|SR\_STAKEHOLDER - Extra timespan: Custom timespan on person. Minutes only in 15 units|  |
|saleStakeholder/person/personExtra/x\_person\_shorttext|string|SR\_STAKEHOLDER - Extra short text: Custom short text on person. With index. Do not keep HTML tags|  |
|saleStakeholder/person/personExtra/x\_person\_shorttext\_list|listAny|SR\_STAKEHOLDER - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent|  |
|saleStakeholder/person/personExtra/x\_person\_user\_relation|associate|SR\_STAKEHOLDER - Extra user relation: Custom person-user relation field|  |
|saleStakeholder/person/personExtra/x\_person\_category\_relation|listAny|SR\_STAKEHOLDER - Extra category relation: Custom person-category relation|  |
|saleStakeholder/person/personExtra/x\_person\_priority\_relation|listAny|SR\_STAKEHOLDER - Extra priority relation: Custom person-priority relation|  |
|saleStakeholder/person/personExtra/x\_person\_request\_relation|stringorPK|SR\_STAKEHOLDER - Extra request relation: Request relation on contact|  |
|saleStakeholder/person/personExtra/x\_person\_appointment\_relation|stringorPK|SR\_STAKEHOLDER - Extra appointment relation: Appointment relation on person|  |
|saleStakeholder/person/personExtra/x\_person\_contact\_relation|stringorPK|SR\_STAKEHOLDER - Extra company relation: Company relation on contact|  |
|saleStakeholder/person/personExtra/y\_rental/id|int|SR\_STAKEHOLDER - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)|  |
|saleStakeholder/person/personExtra/y\_rental/x\_start|date|SR\_STAKEHOLDER - Rental - Start rental: Start rental|  |
|saleStakeholder/person/personExtra/y\_rental/x\_end|date|SR\_STAKEHOLDER - Rental - End: End|  |
|saleStakeholder/person/personExtra/y\_rental/x\_amount|int|SR\_STAKEHOLDER - Rental - Amount: Number to rent. Default = 1|  |
|saleStakeholder/person/personExtra/y\_rental/x\_contact|stringorPK|SR\_STAKEHOLDER - Rental - Renter: Company that rents equipment|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/person/personExtra/y\_rental/y\_equipment/x\_name|string|SR\_STAKEHOLDER - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|saleStakeholder/person/personExtra/y\_car/id|int|SR\_STAKEHOLDER - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)|  |
|saleStakeholder/person/personAssociate/firstName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/lastName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/middleName|string|SR\_STAKEHOLDER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/fullName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/contactId|int|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/personId|int|SR\_STAKEHOLDER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/mrMrs|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/title|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/associateDbId|associate|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|saleStakeholder/person/personAssociate/contactName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/contactDepartment|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/usergroup|userGroup|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/usergroupId|int|SR\_STAKEHOLDER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/contactFullName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/contactCategory|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|saleStakeholder/person/personAssociate/role|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|saleStakeholder/person/personAssociate/assocName|associate|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|saleStakeholder/person/personAssociate/assocTooltip|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|saleStakeholder/person/personAssociate/assocType|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/ejUserId|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|saleStakeholder/person/personAssociate/simultaneousEjUser|bool|SR\_STAKEHOLDER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/ejDisplayName|string|SR\_STAKEHOLDER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|saleStakeholder/person/personAssociate/ejStatus|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|saleStakeholder/person/personAssociate/credentialType| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/credentialDisplayValue| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/isActive|bool|SR\_STAKEHOLDER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/isActiveText|bool|SR\_STAKEHOLDER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/portraitThumbnail| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|saleStakeholder/person/personAssociate/otherGroups|userGroup|SR\_STAKEHOLDER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|saleStakeholder/person/personAssociate/userName|string|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|saleStakeholder/person/personAssociate/personEmail|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL|  |
|saleStakeholder/person/personAssociate/locationAddress|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|saleStakeholder/person/personAssociate/isLocation|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|saleStakeholder/person/correspondingAssociate/firstName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/lastName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/middleName|string|SR\_STAKEHOLDER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/fullName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/contactId|int|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/personId|int|SR\_STAKEHOLDER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/mrMrs|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/title|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/associateDbId|associate|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|saleStakeholder/person/correspondingAssociate/contactName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/contactDepartment|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/usergroup|userGroup|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/usergroupId|int|SR\_STAKEHOLDER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/contactFullName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/contactCategory|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|saleStakeholder/person/correspondingAssociate/role|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|saleStakeholder/person/correspondingAssociate/assocName|associate|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|saleStakeholder/person/correspondingAssociate/assocTooltip|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|saleStakeholder/person/correspondingAssociate/assocType|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/ejUserId|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|saleStakeholder/person/correspondingAssociate/simultaneousEjUser|bool|SR\_STAKEHOLDER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/ejDisplayName|string|SR\_STAKEHOLDER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|saleStakeholder/person/correspondingAssociate/ejStatus|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|saleStakeholder/person/correspondingAssociate/credentialType| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/credentialDisplayValue| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/isActive|bool|SR\_STAKEHOLDER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/isActiveText|bool|SR\_STAKEHOLDER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/portraitThumbnail| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|saleStakeholder/person/correspondingAssociate/otherGroups|userGroup|SR\_STAKEHOLDER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|saleStakeholder/person/correspondingAssociate/userName|string|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|saleStakeholder/person/correspondingAssociate/personEmail|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL|  |
|saleStakeholder/person/correspondingAssociate/locationAddress|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|saleStakeholder/person/correspondingAssociate/isLocation|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|saleStakeholder/person/isMailingRecipient|bool|SR\_STAKEHOLDER - SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient|  |
|saleStakeholder/person/hasStoreConsent|bool|SR\_STAKEHOLDER - SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/withdrawnStoreConsent|bool|SR\_STAKEHOLDER - SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/hasEmarketingConsent|bool|SR\_STAKEHOLDER - SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/withdrawnEmarketingConsent|bool|SR\_STAKEHOLDER - SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/subscription|listAny|SR\_STAKEHOLDER - SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP|  |
|saleStakeholder/person/legalBaseStore|listAny|SR\_STAKEHOLDER - SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/legalBaseEmarketing|listAny|SR\_STAKEHOLDER - SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/person/consentSourceStore|listAny|SR\_STAKEHOLDER - SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|saleStakeholder/person/consentSourceEmarketing|listAny|SR\_STAKEHOLDER - SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|saleStakeholder/contact/contactId|int|SR\_STAKEHOLDER - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|saleStakeholder/contact/name|stringorPK|SR\_STAKEHOLDER - SR\_COMPANY\_NAME|  |
|saleStakeholder/contact/department|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DEPARTEMENT|  |
|saleStakeholder/contact/nameDepartment|string|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|saleStakeholder/contact/hasInfoText|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|saleStakeholder/contact/hasInterests|bool|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|saleStakeholder/contact/associateId|associate|SR\_STAKEHOLDER - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|saleStakeholder/contact/category|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY|  |
|saleStakeholder/contact/categoryGroup|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|saleStakeholder/contact/companyCategoryRank|int|SR\_STAKEHOLDER - Category rank|  |
|saleStakeholder/contact/business|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_BUSINESS|  |
|saleStakeholder/contact/country|listAny|SR\_STAKEHOLDER - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|saleStakeholder/contact/countryId|int|SR\_STAKEHOLDER - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|saleStakeholder/contact/number|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_NUMBER|  |
|saleStakeholder/contact/code|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_CODE|  |
|saleStakeholder/contact/orgnr|string|SR\_STAKEHOLDER - VAT No.|  |
|saleStakeholder/contact/stop|bool|SR\_STAKEHOLDER - SR\_CC\_STOPX|  |
|saleStakeholder/contact/contactNoMail|bool|SR\_STAKEHOLDER - SR\_NO\_MAIL\_COMPANY|  |
|saleStakeholder/contact/updatedBy|associate|SR\_STAKEHOLDER - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|saleStakeholder/contact/updatedByFullName|associate|SR\_STAKEHOLDER - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|saleStakeholder/contact/updatedDate|date|SR\_STAKEHOLDER - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|saleStakeholder/contact/registeredBy|associate|SR\_STAKEHOLDER - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/contact/registeredByFullName|associate|SR\_STAKEHOLDER - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|saleStakeholder/contact/registeredDate|date|SR\_STAKEHOLDER - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|saleStakeholder/contact/contactSource|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|saleStakeholder/contact/contactDeleted|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|saleStakeholder/contact/phone/formattedNumber|string|SR\_STAKEHOLDER - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/contact/activeErpLinks|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|saleStakeholder/contact/deletedDate|datetime|SR\_STAKEHOLDER - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|saleStakeholder/contact/mainContact| *None* |SR\_STAKEHOLDER - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|saleStakeholder/contact/forceCompany|bool|SR\_STAKEHOLDER - Dummy: Dummy|  |
|saleStakeholder/contact/contactPhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/contact/contactPhone/description|string|SR\_STAKEHOLDER - SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/contact/contactFax/formattedNumber|string|SR\_STAKEHOLDER - SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/contact/contactFax/description|string|SR\_STAKEHOLDER - SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/contact/searchPhone/formattedNumber|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|saleStakeholder/contact/searchPhone/description|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|saleStakeholder/contact/email/emailProtocol|string|SR\_STAKEHOLDER - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|saleStakeholder/contact/email/emailAddress|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL|  |
|saleStakeholder/contact/email/emailDescription|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION|  |
|saleStakeholder/contact/email/emailId|int|SR\_STAKEHOLDER - ID|  |
|saleStakeholder/contact/email/emailLastSent|datetime|SR\_STAKEHOLDER - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|saleStakeholder/contact/email/emailBounceCount|int|SR\_STAKEHOLDER - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|saleStakeholder/contact/email/emailLastBounce|datetime|SR\_STAKEHOLDER - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|saleStakeholder/contact/email/emailHasBounced|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/addressId|int|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/line1|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/line2|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/line3|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/county|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/city|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/zip|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/state|string|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|saleStakeholder/contact/postAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|saleStakeholder/contact/postAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|saleStakeholder/contact/postAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/postAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/addressId|int|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|saleStakeholder/contact/streetAddress/line1|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|saleStakeholder/contact/streetAddress/line2|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|saleStakeholder/contact/streetAddress/line3|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|saleStakeholder/contact/streetAddress/county|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|saleStakeholder/contact/streetAddress/city|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|saleStakeholder/contact/streetAddress/zip|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|saleStakeholder/contact/streetAddress/state|string|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|saleStakeholder/contact/streetAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|saleStakeholder/contact/streetAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|saleStakeholder/contact/streetAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/streetAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/addressId|int|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP|  |
|saleStakeholder/contact/restrictionAddress/line1|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP|  |
|saleStakeholder/contact/restrictionAddress/line2|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP|  |
|saleStakeholder/contact/restrictionAddress/line3|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP|  |
|saleStakeholder/contact/restrictionAddress/county|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP|  |
|saleStakeholder/contact/restrictionAddress/city|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP|  |
|saleStakeholder/contact/restrictionAddress/zip|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP|  |
|saleStakeholder/contact/restrictionAddress/state|string|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP|  |
|saleStakeholder/contact/restrictionAddress/wgs84latitude|decimal|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE|  |
|saleStakeholder/contact/restrictionAddress/wgs84longitude|decimal|SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE|  |
|saleStakeholder/contact/restrictionAddress/formattedAddress| *None* |SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_STAKEHOLDER - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|saleStakeholder/contact/url/URLAddress|string|SR\_STAKEHOLDER - SR\_PROJECTARCHIVE\_URL|  |
|saleStakeholder/contact/url/URLDescription|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_DESCRIPTION|  |
|saleStakeholder/contact/contactAssociate/firstName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/lastName|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/middleName|string|SR\_STAKEHOLDER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/fullName|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/contactId|int|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/personId|int|SR\_STAKEHOLDER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/mrMrs|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/title|string|SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/associateDbId|associate|SR\_STAKEHOLDER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|saleStakeholder/contact/contactAssociate/contactName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/contactDepartment|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/usergroup|userGroup|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/usergroupId|int|SR\_STAKEHOLDER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/contactFullName|string|SR\_STAKEHOLDER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/contactCategory|listAny|SR\_STAKEHOLDER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|saleStakeholder/contact/contactAssociate/role|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|saleStakeholder/contact/contactAssociate/assocName|associate|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|saleStakeholder/contact/contactAssociate/assocTooltip|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|saleStakeholder/contact/contactAssociate/assocType|listAny|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/ejUserId|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|saleStakeholder/contact/contactAssociate/simultaneousEjUser|bool|SR\_STAKEHOLDER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/ejDisplayName|string|SR\_STAKEHOLDER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|saleStakeholder/contact/contactAssociate/ejStatus|int|SR\_STAKEHOLDER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|saleStakeholder/contact/contactAssociate/credentialType| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/credentialDisplayValue| *None* |SR\_STAKEHOLDER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/isActive|bool|SR\_STAKEHOLDER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/isActiveText|bool|SR\_STAKEHOLDER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/portraitThumbnail| *None* |SR\_STAKEHOLDER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|saleStakeholder/contact/contactAssociate/otherGroups|userGroup|SR\_STAKEHOLDER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|saleStakeholder/contact/contactAssociate/userName|string|SR\_STAKEHOLDER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|saleStakeholder/contact/contactAssociate/personEmail|string|SR\_STAKEHOLDER - SR\_ARCHIVE\_EMAIL|  |
|saleStakeholder/contact/contactAssociate/locationAddress|string|SR\_STAKEHOLDER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|saleStakeholder/contact/contactAssociate/isLocation|bool|SR\_STAKEHOLDER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|saleStakeholder/contact/contactInterestIds|listInterest|SR\_STAKEHOLDER - SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|saleStakeholder/contact/contactUdef/SuperOffice:1|string|SR\_STAKEHOLDER - companyshorttext: tooltipshorttext|  |
|saleStakeholder/contact/contactUdef/SuperOffice:2|string|SR\_STAKEHOLDER - companylongtext: tooltiplongtext|  |
|saleStakeholder/contact/contactUdef/SuperOffice:3|int|SR\_STAKEHOLDER - companynumber|  |
|saleStakeholder/contact/contactUdef/SuperOffice:4|date|SR\_STAKEHOLDER - companydate|  |
|saleStakeholder/contact/contactUdef/SuperOffice:5|unlimitedDate|SR\_STAKEHOLDER - companyunlimiteddate: tooltipunlimiteddate|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|saleStakeholder/contact/contactUdef/SuperOffice:6|bool|SR\_STAKEHOLDER - companycheckbox|  |
|saleStakeholder/contact/contactUdef/SuperOffice:7|listAny|SR\_STAKEHOLDER - companydropdownlistbox|  |
|saleStakeholder/contact/contactUdef/SuperOffice:8|decimal|SR\_STAKEHOLDER - companydecimal|  |
|saleStakeholder/contact/contactUdef/SuperOffice:9|string|SR\_STAKEHOLDER - page1saleonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:10|string|SR\_STAKEHOLDER - page1marketingonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:11|string|SR\_STAKEHOLDER - page1adminonly|  |
|saleStakeholder/contact/contactUdef/SuperOffice:12|listAny|SR\_STAKEHOLDER - Udlist one: Static tooltip for udlist one|  |
|saleStakeholder/contact/contactUdef/SuperOffice:13|listAny|SR\_STAKEHOLDER - Udlist two: Static tooltip for udlist two|  |
|saleStakeholder/contact/contactExtra/x\_contact\_integer|int|SR\_STAKEHOLDER - Extra Integer: Custom integer field|  |
|saleStakeholder/contact/contactExtra/x\_contact\_hidden\_integer|int|SR\_STAKEHOLDER - Extra hidden integer: Custom integer field - hidden|  |
|saleStakeholder/contact/contactExtra/x\_contact\_default\_integer|int|SR\_STAKEHOLDER - Extra Default Integer: Custom integer field with default value 123.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_float|decimal|SR\_STAKEHOLDER - Extra Float: Custom float field with 3 decimals|  |
|saleStakeholder/contact/contactExtra/x\_contact\_longtext|string|SR\_STAKEHOLDER - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor|  |
|saleStakeholder/contact/contactExtra/x\_contact\_dropdown|listAny|SR\_STAKEHOLDER - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_date|date|SR\_STAKEHOLDER - Extra date: Custom date field. User current as default.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_datetime|datetime|SR\_STAKEHOLDER - Extra DateTime: Custom Date Time field. No default value. External|  |
|saleStakeholder/contact/contactExtra/x\_contact\_time| *None* |SR\_STAKEHOLDER - Extra time: Custom time field.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_boolean|bool|SR\_STAKEHOLDER - Extra boolean: Custom boolean field.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_timespan|timeSpan|SR\_STAKEHOLDER - Extra timespan: Custom timespan field. Hours and minutes in 10 units|  |
|saleStakeholder/contact/contactExtra/x\_contact\_shorttext|string|SR\_STAKEHOLDER - Extra short text: Custom short text field. Keep HTML tags.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_short\_dropdown|listAny|SR\_STAKEHOLDER - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.|  |
|saleStakeholder/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|SR\_STAKEHOLDER - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons|  |
|saleStakeholder/contact/contactExtra/x\_contact\_request\_relation|stringorPK|SR\_STAKEHOLDER - Extra Request relation: Request relation on company|  |
|saleStakeholder/contact/contactExtra/x\_contact\_contact|stringorPK|SR\_STAKEHOLDER - Extra contact relation: Contact relation on company|  |
|saleStakeholder/contact/contactExtra/y\_organization/x\_name|string|SR\_STAKEHOLDER - Organization - Name: Name|  |
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
|quote/quoteId|int|SR\_QUOTE\_QUOTE\_ID: SR\_QUOTE\_QUOTE\_ID\_TOOLTIP|  |
|quote/poNumber|string|SR\_QUOTE\_QUOTE\_PONUMBER: SR\_QUOTE\_QUOTE\_PONUMBER\_TOOLTIP|  |
|quote/orderComment|string|SR\_QUOTE\_QUOTE\_ORDERCOMMENT: SR\_QUOTE\_QUOTE\_ORDERCOMMENT\_TOOLTIP|  |
|quote/connectionId|int|SR\_QUOTE\_CONNECTIONID: SR\_QUOTE\_CONNECTIONID\_TOOLTIP|  |
|quote/registeredDate|date|SR\_QUOTE\_QUOTE\_REGISTERED: SR\_QUOTE\_QUOTE\_REGISTERED\_TOOLTIP|  |
|quote/version/quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP|  |
|quote/version/description|string|SR\_QUOTE\_QUOTEVERSION\_DESCRIPTION: SR\_QUOTE\_QUOTEVERSION\_DESCRIPTION\_TOOLTIP|  |
|quote/version/number|string|SR\_QUOTE\_QUOTEVERSION\_NUMBER: SR\_QUOTE\_QUOTEVERSION\_NUMBER\_TOOLTIP|  |
|quote/version/sent|date|SR\_QUOTE\_QUOTEVERSION\_SENT: SR\_QUOTE\_QUOTEVERSION\_SENT\_TOOLTIP|  |
|quote/version/expiration|date|SR\_QUOTE\_QUOTEVERSION\_EXPIRATION: SR\_QUOTE\_QUOTEVERSION\_EXPIRATION\_TOOLTIP|  |
|quote/version/state|listAny|SR\_QUOTE\_QUOTEVERSION\_STATE: SR\_QUOTE\_QUOTEVERSION\_STATE\_TOOLTIP|  |
|quote/version/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP|  |
|quote/version/reason|string|SR\_QUOTE\_QUOTELINE\_QUOTEREASON: SR\_QUOTE\_QUOTELINE\_QUOTEREASON\_TOOLTIP|  |
|quote/version/paymentTerms|listExternal|SR\_QUOTE\_QUOTEVERSION\_PAYMENTTERMS: SR\_QUOTE\_QUOTEVERSION\_PAYMENTTERMS\_TOOLTIP|  |
|quote/version/paymentType|listExternal|SR\_QUOTE\_QUOTEVERSION\_PAYMENTTYPE: SR\_QUOTE\_QUOTEVERSION\_PAYMENTTYPE\_TOOLTIP|  |
|quote/version/deliveryTerms|listExternal|SR\_QUOTE\_QUOTEVERSION\_DELIVERYTERMS: SR\_QUOTE\_QUOTEVERSION\_DELIVERYTERMS\_TOOLTIP|  |
|quote/version/deliveryType|listExternal|SR\_QUOTE\_QUOTEVERSION\_DELIVERYTYPE: SR\_QUOTE\_QUOTEVERSION\_DELIVERYTYPE\_TOOLTIP|  |
|quote/version/approvedBy|associate|SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY\_TOOLTIP|  |
|quote/version/approvalRegisteredBy|associate|SR\_QUOTE\_QUOTEVERSION\_APPROVALREGISTEREDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVALREGISTEREDBY\_TOOLTIP|  |
|quote/version/approvedText|string|SR\_QUOTE\_QUOTEVERSION\_APPROVEDTEXT: SR\_QUOTE\_QUOTEVERSION\_APPROVEDTEXT\_TOOLTIP|  |
|quote/version/approvedDate|date|SR\_QUOTE\_QUOTEVERSION\_APPROVEDDATE: SR\_QUOTE\_QUOTEVERSION\_APPROVEDDATE\_TOOLTIP|  |
|quote/version/extraField1|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD1: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD1\_TOOLTIP|  |
|quote/version/extraField2|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD2: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD2\_TOOLTIP|  |
|quote/version/extraField3|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD3: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD3\_TOOLTIP|  |
|quote/version/extraField4|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD4: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD4\_TOOLTIP|  |
|quote/version/extraField5|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD5: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD5\_TOOLTIP|  |
|quote/version/alternative/quoteAlternativeId|int|SR\_QUOTE\_QUOTEALTERNATIVE\_ID: SR\_QUOTE\_QUOTEALTERNATIVE\_ID\_TOOLTIP|  |
|quote/version/alternative/quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP|  |
|quote/version/alternative/name|string|SR\_QUOTE\_QUOTEALTERNATIVE\_NAME: SR\_QUOTE\_QUOTEALTERNATIVE\_NAME\_TOOLTIP|  |
|quote/version/alternative/description|string|SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION: SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION\_TOOLTIP|  |
|quote/version/alternative/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP|  |
|quote/version/alternative/reason|string|SR\_QUOTE\_QUOTELINE\_QUOTEREASON: SR\_QUOTE\_QUOTELINE\_QUOTEREASON\_TOOLTIP|  |
|quote/version/alternative/erpDiscountPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTPERCENT\_TOOLTIP|  |
|quote/version/alternative/erpDiscountAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTAMOUNT\_TOOLTIP|  |
|quote/version/alternative/discountPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTPERCENT\_TOOLTIP|  |
|quote/version/alternative/discountAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTAMOUNT\_TOOLTIP|  |
|quote/version/alternative/vatInfo|string|SR\_QUOTE\_QUOTEALTERNATIVE\_VATINFO: SR\_QUOTE\_QUOTEALTERNATIVE\_VATINFO\_TOOLTIP|  |
|quote/version/alternative/vat|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_VAT: SR\_QUOTE\_QUOTEALTERNATIVE\_VAT\_TOOLTIP|  |
|quote/version/alternative/earningPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSPERCENT\_TOOLTIP|  |
|quote/version/alternative/earningAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSAMOUNT\_TOOLTIP|  |
|quote/version/alternative/totalPrice|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTAL: SR\_QUOTE\_QUOTEALTERNATIVE\_TOTAL\_TOOLTIP|  |
|quote/version/alternative/extraField1|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD1: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD1\_TOOLTIP|  |
|quote/version/alternative/extraField2|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD2: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD2\_TOOLTIP|  |
|quote/version/alternative/extraField3|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD3: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD3\_TOOLTIP|  |
|quote/version/alternative/extraField4|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD4: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD4\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|quote/version/alternative/extraField5|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD5: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD5\_TOOLTIP|  |
|quote/version/alternative/alternativeOrdering|int|SR\_QUOTE\_QUOTEALTERNATIVE\_ID: SR\_QUOTE\_QUOTEALTERNATIVE\_ID\_TOOLTIP|  |
|quote/version/alternative/subTotal|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_SUBTOTAL: SR\_QUOTE\_QUOTEALTERNATIVE\_SUBTOTAL\_TOOLTIP|  |
|quote/version/alternative/totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ALTTOTINCVAT: SR\_QUOTE\_QUOTEALTERNATIVE\_ALTTOTINCVAT\_TOOLTIP|  |
|quote/version/alternative/vatAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ALTVATAMT: SR\_QUOTE\_QUOTEALTERNATIVE\_ALTVATAMT\_TOOLTIP|  |
|quote/version/alternative/quoteline/quoteLineId|int|SR\_QUOTE\_QUOTELINE\_QUOTELINEID: SR\_QUOTE\_QUOTELINE\_QUOTELINEID\_TOOLTIP|  |
|quote/version/alternative/quoteline/quoteAlternativeId|int|SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID: SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID\_TOOLTIP|  |
|quote/version/alternative/quoteline/erpProductKey|string|SR\_QUOTE\_QUOTELINE\_PRODUCTKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTKEY\_TOOLTIP|  |
|quote/version/alternative/quoteline/rank|int|SR\_QUOTE\_QUOTELINE\_RANK: SR\_QUOTE\_QUOTELINE\_RANK\_TOOLTIP|  |
|quote/version/alternative/quoteline/quantity|decimal|SR\_QUOTE\_QUOTELINE\_QUANTITY: SR\_QUOTE\_QUOTELINE\_QUANTITY\_TOOLTIP|  |
|quote/version/alternative/quoteline/name|string|SR\_QUOTE\_QUOTELINE\_NAME: SR\_QUOTE\_QUOTELINE\_NAME\_TOOLTIP|  |
|quote/version/alternative/quoteline/description|string|SR\_QUOTE\_QUOTELINE\_DESCRIPTION: SR\_QUOTE\_QUOTELINE\_DESCRIPTION\_TOOLTIP|  |
|quote/version/alternative/quoteline/code|string|SR\_QUOTE\_QUOTELINE\_CODE: SR\_QUOTE\_QUOTELINE\_CODE\_TOOLTIP|  |
|quote/version/alternative/quoteline/quantityUnit|string|SR\_QUOTE\_QUOTELINE\_UNIT: SR\_QUOTE\_QUOTELINE\_UNIT\_TOOLTIP|  |
|quote/version/alternative/quoteline/priceUnit|string|SR\_QUOTE\_QUOTELINE\_PRICEUNIT: SR\_QUOTE\_QUOTELINE\_PRICEUNIT\_TOOLTIP|  |
|quote/version/alternative/quoteline/url|string|SR\_QUOTE\_QUOTELINE\_URL: SR\_QUOTE\_QUOTELINE\_URL\_TOOLTIP|  |
|quote/version/alternative/quoteline/subscriptionUnit|string|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT\_TOOLTIP|  |
|quote/version/alternative/quoteline/subscriptionQuantity|decimal|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY\_TOOLTIP|  |
|quote/version/alternative/quoteline/UnitListPriceSubscriptionQuantity| *None* |SR\_SUBSCRIPTIONLISTPRICE: SR\_SUBSCRIPTIONLISTPRICE\_TOOLTIP|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionUnit| *None* |SR\_PRICESUBUNIT: SR\_PRICESUBUNIT\_TOOLTIP|  |
|quote/version/alternative/quoteline/PriceUnitSubscriptionQuantityUnit| *None* |SR\_EXPANDEDUNIT: SR\_EXPANDEDUNIT\_TOOLTIP|  |
|quote/version/alternative/quoteline/vatInfo|string|SR\_QUOTE\_QUOTELINE\_VATINFO: SR\_QUOTE\_QUOTELINE\_VATINFO\_TOOLTIP|  |
|quote/version/alternative/quoteline/vat|decimal|SR\_QUOTE\_QUOTELINE\_VAT: SR\_QUOTE\_QUOTELINE\_VAT\_TOOLTIP|  |
|quote/version/alternative/quoteline/unitCost|decimal|SR\_QUOTE\_QUOTELINE\_UNITCOST: SR\_QUOTE\_QUOTELINE\_UNITCOST\_TOOLTIP|  |
|quote/version/alternative/quoteline/unitMinimumPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE: SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE\_TOOLTIP|  |
|quote/version/alternative/quoteline/unitListPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE: SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE\_TOOLTIP|  |
|quote/version/alternative/quoteline/totalPrice|decimal|SR\_QUOTE\_QUOTELINE\_TOTALPRICE: SR\_QUOTE\_QUOTELINE\_TOTALPRICE\_TOOLTIP|  |
|quote/version/alternative/quoteline/totalCost|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTALCOST|  |
|quote/version/alternative/quoteline/quoteLineThumbnail| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|quote/version/alternative/quoteline/quoteLineThumbnailLarge| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|quote/version/alternative/quoteline/discountAmount|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT\_TOOLTIP|  |
|quote/version/alternative/quoteline/discountPercent|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT\_TOOLTIP|  |
|quote/version/alternative/quoteline/earningAmount|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT: SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT\_TOOLTIP|  |
|quote/version/alternative/quoteline/earningPercent|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT: SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT\_TOOLTIP|  |
|quote/version/alternative/quoteline/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|quote/version/alternative/quoteline/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|quote/version/alternative/quoteline/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|quote/version/alternative/quoteline/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|quote/version/alternative/quoteline/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|quote/version/alternative/quoteline/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|quote/version/alternative/quoteline/productCategoryKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY\_TOOLTIP|  |
|quote/version/alternative/quoteline/productFamilyKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY\_TOOLTIP|  |
|quote/version/alternative/quoteline/productTypeKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY\_TOOLTIP|  |
|quote/version/alternative/quoteline/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP|  |
|quote/version/alternative/quoteline/subTotal|decimal|SR\_QUOTE\_QUOTELINE\_SUBTOTAL: SR\_QUOTE\_QUOTELINE\_SUBTOTAL\_TOOLTIP|  |
|quote/version/alternative/quoteline/vatAmount|decimal|SR\_QUOTE\_QUOTELINE\_VATAMNT: SR\_QUOTE\_QUOTELINE\_VATAMNT\_TOOLTIP|  |
|quote/version/alternative/quoteline/totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCVAT: SR\_QUOTE\_QUOTELINE\_TOTINCVAT\_TOOLTIP|  |
|quote/version/alternative/quoteline/totalPriceWithAlternativeDiscount|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS: SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS\_TOOLTIP|  |
|destinationSaleRestrictionId|int|SR\_RESTRICTION\_LINKSALEDESTINATION: SR\_RESTRICTION\_LINKSALEDESTINATION\_TOOLTIP|  |
|name|stringorPK|SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP|  |
|number|string|SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP|  |
|status|listAny|SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP|  |
|statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP|  |
|hasInfoText|bool|SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP|  |
|nextMilestone|date|SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP|  |
|imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|eventId|int|SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID|  |
|startDate|date|SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP|  |
|projectPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|projectPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|projectPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|projectEvent/isExternalEvent|bool|SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP|  |
|projectEvent/eventDate|date|SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP|  |
|projectEvent/hasSignOn|bool|SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP|  |
|projectEvent/hasSignOff|bool|SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP|  |
|projectUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL|  |
|projectUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|projectAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|projectAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|projectAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|projectAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|projectAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|projectAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|projectAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|projectAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|projectAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|projectAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|projectAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|projectAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|projectAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|projectAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|projectAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|projectAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|projectAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|projectAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|projectAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|projectAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|projectAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|projectAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|projectAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|projectAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|projectAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|projectAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL|  |
|projectAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|projectUdef/SuperOffice:1|string|projectshorttext|  |
|projectUdef/SuperOffice:2|string|projectlongtext|  |
|projectUdef/SuperOffice:3|int|projectnumber|  |
|projectUdef/SuperOffice:4|date|projectdate|  |
|projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate|  |
|projectUdef/SuperOffice:6|bool|projectcheckbox|  |
|projectUdef/SuperOffice:7|listAny|projectdropdownlistbox|  |
|projectUdef/SuperOffice:8|decimal|projectdecimal|  |
|projectUdef/SuperOffice:9|int|page1saleandmarketing|  |
|projectUdef/SuperOffice:10|int|page1saleandadmin|  |
|NumberOfActivities|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|NumberOfActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|NumberOfNotCompletedActivities|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
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
|SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|saintSaleStatus|listAny|SR\_WITH\_STATUS|  |
|saintAmountClass|listAny|SR\_AMOUNT\_CLASS|  |
|saintActivityType|listAny|SR\_ARCHIVE\_SAINT\_TYPE|  |
|saintDirection|listAny|SR\_ARCHIVE\_DIRECTION|  |
|saintIntention|listAny|SR\_ACTIVITY\_INTENTION|  |
|saintTicketStatus|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|saintTicketCategory|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|project/textId|int|Text ID|  |
|project/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|destinationProjectRestrictionId|int|ADD LINK PROJECT DESTINATION RESOURCE: ADD LINK PROJECT DESTINATION TOOLTIP RESOURCE|  |
|documentId|int|SR\_DOCUMENT\_ID: SR\_DOCUMENT\_ID\_TOOLTIP|  |
|keywords|string|SR\_KEYWORDS|  |
|ourref|string|SR\_AA\_OURREF|  |
|yourref|string|SR\_ARCHIVE\_YOURREF|  |
|attention|string|SR\_ARCHIVE\_SALUTATION|  |
|subject|string|SR\_COMMON\_SUBJECT|  |
|mailMergeDraft|bool|SR\_MAILMERGEDRAFT: SR\_DOCUMENT\_MMD\_TOOLTIP|  |
|snum|int|SR\_ARCHIVE\_DOCUMENT\_SNUM: SR\_ARCHIVE\_DOCUMENT\_SNUM\_TOOLTIP|  |
|isReport|bool|SR\_DOCUMENTISREPORT: SR\_DOCUMENTISREPORT\_TOOLTIP|  |
|suggestedDocumentId|int|SR\_ARCHIVE\_SUGGESTEDDOCID: SR\_ARCHIVE\_SUGGESTEDDOCID\_TOOLTIP|  |
|isMail|bool|SR\_SINGULAR\_MAIL|  |
|documentPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|documentPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|documentPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|documentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|documentUdef/SuperOffice:1|string|documentshorttext|  |
|documentUdef/SuperOffice:2|string|documentlongtext|  |
|documentUdef/SuperOffice:3|int|documentnumber|  |
|documentUdef/SuperOffice:4|date|documentdate|  |
|documentUdef/SuperOffice:5|unlimitedDate|documentunlimiteddate|  |
|documentUdef/SuperOffice:6|bool|documentcheckbox|  |
|documentUdef/SuperOffice:7|listAny|documentdropdownlistbox|  |
|documentUdef/SuperOffice:8|decimal|documentdecimal|  |
|destinationDocumentRestrictionId|int|SR\_RESTRICTION\_LINKDOCUMENTDESTINATION: SR\_RESTRICTION\_LINKDOCUMENTDESTINATION\_TOOLTIP|  |
|document/textId|int|Text ID|  |
|document/description|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|URLAddress|string|SR\_PROJECTARCHIVE\_URL|  |
|URLDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|destinationURLRestrictionId|int|ADD LINK URL DESTINATION RESOURCE: ADD LINK URL DESTINATION TOOLTIP RESOURCE|  |
|firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|middleName|string|SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|fullName|string|SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|personHasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|position|listAny|SR\_ARCHIVE\_POSITION|  |
|personNumber|string|SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|personCountry|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|personCountryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|personNoMail|bool|SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|rank|int|SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|birthdate| *None* |SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|associateType| *None* |SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|useAsMailingAddress|bool|SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|personSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|retired|bool|SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|birthYear|int|SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|birthMonth|int|SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|birthDay|int|SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|kanaFirstName|string|SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|kanaLastName|string|SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|personUpdatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personUpdatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personUpdatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|personRegisteredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personRegisteredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personRegisteredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personActiveErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|ticketPriority|listAny|SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|supportLanguage|listAny|SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|supportAssociate|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|supportAssociateFullName|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|personAssociateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personAssociateFullName|associate|SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personCategory|listAny|SR\_ARCHIVE\_CATEGORY|  |
|personCategoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|personCategoryRank|int|!!Category rank|  |
|personBusiness|listAny|SR\_ARCHIVE\_BUSINESS|  |
|leadStatus|listAny|SR\_LABEL\_LEADSTATUS|  |
|leadstatusRank|int|!!Lead status RANK|  |
|personDeletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|hasCompany|bool|SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|isProjectMember|bool|SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|isStakeholder|bool|SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|updatedByWorkflow|listAny|SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|whenUpdatedByWorkflow|datetime|SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|createdByForm|listAny|SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|destinationPersonRestrictionId|int|ADD LINK Person DESTINATION RESOURCE: ADD LINK Person DESTINATION TOOLTIP RESOURCE|  |
|department|string|SR\_ARCHIVE\_DEPARTEMENT|  |
|nameDepartment|string|SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|category|listAny|SR\_ARCHIVE\_CATEGORY|  |
|categoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|companyCategoryRank|int|Category rank|  |
|business|listAny|SR\_ARCHIVE\_BUSINESS|  |
|country|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|countryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|code|string|SR\_ARCHIVE\_CODE|  |
|orgnr|string|VAT No.|  |
|stop|bool|SR\_CC\_STOPX|  |
|contactNoMail|bool|SR\_NO\_MAIL\_COMPANY|  |
|contactSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|contactDeleted|bool|SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|deletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|forceCompany|bool|Dummy: Dummy|  |
|destinationContactRestrictionId|int|ADD LINK Contact DESTINATION RESOURCE: ADD LINK Contact DESTINATION TOOLTIP RESOURCE|  |
|selectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|kind|listAny|SR\_LABEL\_SELECTIONKIND: SR\_SEARCH\_KIND\_TOOLTIP|  |
|targetTableNumber|listAny|SR\_ARCHIVE\_SELECTION\_TYPE: SR\_ARCHIVE\_SELECTION\_TYPE\_TOOLTIP|  |
|combinationType|listAny|SR\_ARCHIVE\_SELECTION\_COMBINATION\_TYPE: SR\_ARCHIVE\_SELECTION\_COMBINATION\_TYPE\_TOOLTIP|  |
|done|bool|SR\_ARCHIVE\_SELECTION\_COMPLETED: SR\_ARCHIVE\_SELECTION\_COMPLETED\_TOOLTIP|  |
|lastLoaded|date|SR\_SEL\_LASTLOADED: SR\_SEL\_LASTLOADED\_TOOLTIP|  |
|lastLoadedBy|associate|SR\_SEL\_LASTLOADEDBY: SR\_SEL\_LASTLOADEDBY\_TOOLTIP|  |
|lastLoadedByFullName|associate|SR\_SEL\_LASTLOADEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_SEL\_LASTLOADEDBY\_TOOLTIP|  |
|lastMembershipChange|date|SR\_SEL\_LASTMEMBERCHANGE: SR\_SEL\_LASTMEMBERCHANGE\_TOOLTIP|  |
|lastMembershipChangeBy|associate|SR\_SEL\_LASTMEMBERCHANGEBY: SR\_SEL\_LASTMEMBERCHANGEBY\_TOOLTIP|  |
|lastMembershipChangeByFullName|associate|SR\_SEL\_LASTMEMBERCHANGEBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_SEL\_LASTMEMBERCHANGEBY\_TOOLTIP|  |
|memberCount|int|SR\_SEL\_MEMBERCOUNT: SR\_SEL\_MEMBERCOUNT\_TOOLTIP|  |
|destinationSelectionRestrictionId|int|ADD LINK Selection DESTINATION RESOURCE: ADD LINK Selection DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/Links?$select=contact/postAddress/wgs84longitude,contact/contactExtra/x_contact_date,contact/contactExtra/x_contact_shorttext,person/personRegisteredByFullName,person/personDirectPhone/formattedNumber
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


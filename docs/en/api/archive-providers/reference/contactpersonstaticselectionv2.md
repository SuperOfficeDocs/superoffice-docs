---
uid: ContactPersonStaticSelectionV2
title: ContactPersonStaticSelectionV2
description: 
keywords: ContactPersonStaticSelectionV2 archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ContactPersonStaticSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionStaticProviderV2">SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionStaticProviderV2</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"staticContact"|[[SR_ENTITY_STATICCONTACT]]|
|"staticPerson"|[[SR_ENTITY_STATICPERSON]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|selectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP|  |
|rowKind| *None* |SR\_SELECTION\_ROWKIND: SR\_SELECTION\_ROWKIND\_TOOLTIP|  |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|selectionMemberId| *None* |SR\_SELECTIONMEMBER\_ID: SR\_SELECTIONMEMBER\_ID\_TOOLTIP|  |
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
|who| *None* |SR\_CONTACTSELECTIONARCHIVE\_CONTACTNAME: SR\_CONTACTSELECTIONARCHIVE\_CONTACTNAME\_TOOLTIP| x |
|contactPhone/formattedNumber|string|SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contactPhone/description|string|SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|contactFax/formattedNumber| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|contactFax/description| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|searchPhone/formattedNumber| *None* |SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|searchPhone/description| *None* |SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
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
|contactAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|contactAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|contactAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|contactAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|contactAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contactAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|contactAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|contactAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|sourceRelation/contactId| *None* |SR\_RELATION\_SOURCE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|sourceRelation/name| *None* |SR\_RELATION\_SOURCE - SR\_COMPANY\_NAME| x |
|sourceRelation/department| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DEPARTEMENT| x |
|sourceRelation/nameDepartment| *None* |SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|sourceRelation/hasInfoText| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|sourceRelation/hasInterests| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|sourceRelation/associateId| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|sourceRelation/category| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY| x |
|sourceRelation/categoryGroup| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|sourceRelation/companyCategoryRank| *None* |SR\_RELATION\_SOURCE - Category rank| x |
|sourceRelation/business| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BUSINESS| x |
|sourceRelation/country| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|sourceRelation/countryId| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|sourceRelation/number| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_NUMBER| x |
|sourceRelation/code| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CODE| x |
|sourceRelation/orgnr| *None* |SR\_RELATION\_SOURCE - VAT No.| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sourceRelation/stop| *None* |SR\_RELATION\_SOURCE - SR\_CC\_STOPX| x |
|sourceRelation/contactNoMail| *None* |SR\_RELATION\_SOURCE - SR\_NO\_MAIL\_COMPANY| x |
|sourceRelation/updatedBy| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sourceRelation/updatedByFullName| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sourceRelation/updatedDate| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|sourceRelation/registeredBy| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sourceRelation/registeredByFullName| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sourceRelation/registeredDate| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|sourceRelation/contactSource| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|sourceRelation/contactDeleted| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|sourceRelation/activeErpLinks| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|sourceRelation/deletedDate| *None* |SR\_RELATION\_SOURCE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|sourceRelation/mainContact| *None* |SR\_RELATION\_SOURCE - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|sourceRelation/forceCompany| *None* |SR\_RELATION\_SOURCE - Dummy: Dummy|  |
|sourceRelation/restrictionContactId| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|sourceRelation/who| *None* |SR\_RELATION\_SOURCE - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|sourceRelation/csRelation| *None* |SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_COMPANY\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|targetRelation/contactId| *None* |SR\_RELATION\_TARGET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|targetRelation/name| *None* |SR\_RELATION\_TARGET - SR\_COMPANY\_NAME| x |
|targetRelation/department| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_DEPARTEMENT| x |
|targetRelation/nameDepartment| *None* |SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|targetRelation/hasInfoText| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|targetRelation/hasInterests| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|targetRelation/associateId| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|targetRelation/category| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY| x |
|targetRelation/categoryGroup| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|targetRelation/companyCategoryRank| *None* |SR\_RELATION\_TARGET - Category rank| x |
|targetRelation/business| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BUSINESS| x |
|targetRelation/country| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|targetRelation/countryId| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|targetRelation/number| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_NUMBER| x |
|targetRelation/code| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CODE| x |
|targetRelation/orgnr| *None* |SR\_RELATION\_TARGET - VAT No.| x |
|targetRelation/stop| *None* |SR\_RELATION\_TARGET - SR\_CC\_STOPX| x |
|targetRelation/contactNoMail| *None* |SR\_RELATION\_TARGET - SR\_NO\_MAIL\_COMPANY| x |
|targetRelation/updatedBy| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|targetRelation/updatedByFullName| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|targetRelation/updatedDate| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|targetRelation/registeredBy| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|targetRelation/registeredByFullName| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|targetRelation/registeredDate| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|targetRelation/contactSource| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|targetRelation/contactDeleted| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|targetRelation/activeErpLinks| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|targetRelation/deletedDate| *None* |SR\_RELATION\_TARGET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|targetRelation/mainContact| *None* |SR\_RELATION\_TARGET - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|targetRelation/forceCompany| *None* |SR\_RELATION\_TARGET - Dummy: Dummy|  |
|targetRelation/restrictionContactId| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|targetRelation/who| *None* |SR\_RELATION\_TARGET - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|targetRelation/csRelation| *None* |SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_COMPANY\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|sourceRelation/contactPersonRelation| *None* |SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_COMPANY\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|targetRelation/personContactRelation| *None* |SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_PERSON\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|sale/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|sale/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|sale/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|sale/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|sale/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|sale/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|sale/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|sale/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|sale/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|sale/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|sale/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|sale/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|sale/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|sale/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|sale/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sale/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sale/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|sale/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sale/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sale/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|sale/currencyId| *None* |SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP| x |
|sale/currency| *None* |SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP| x |
|sale/credited| *None* |SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP| x |
|sale/lossReason| *None* |SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP| x |
|sale/source| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP| x |
|sale/competitor| *None* |SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP| x |
|sale/heading| *None* |SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP| x |
|sale/amount| *None* |SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|sale/amountWeighted| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|sale/earning| *None* |SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP| x |
|sale/earningPercent| *None* |SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP| x |
|sale/probPercent| *None* |SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP| x |
|sale/originalStage| *None* |SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED| x |
|sale/stage| *None* |SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/saleStatus| *None* |SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP| x |
|sale/stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP| x |
|sale/saleType| *None* |SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|sale/saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|sale/stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/nextDueDate| *None* |SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP| x |
|sale/reopenDate| *None* |SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP| x |
|sale/stalledComment| *None* |SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP| x |
|sale/saleTypeCategory| *None* |SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT| x |
|sale/soldReason| *None* |SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP| x |
|sale/saleNumber| *None* |SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER| x |
|sale/hasStakeholders| *None* |SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP| x |
|sale/stakeholdersEnabled| *None* |SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/hasQuote| *None* |SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP| x |
|sale/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|sale/description| *None* |SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|sale/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|sale/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|sale/amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|sale/amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|sale/daysInStage| *None* |SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP| x |
|sale/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|sale/sale/textId| *None* |Text ID| x |
|sale/sale/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|sale/salePublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|sale/salePublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|sale/salePublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|sale/salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|sale/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|sale/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|sale/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|sale/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|sale/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|sale/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sale/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|sale/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|sale/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|sale/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|sale/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|sale/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|sale/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|sale/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|sale/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|sale/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|sale/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|sale/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|sale/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|sale/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|sale/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|sale/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|sale/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|sale/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|sale/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|sale/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|sale/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|sale/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|sale/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|sale/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|sale/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL| x |
|sale/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|sale/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|sale/saleUdef/SuperOffice:1| *None* |saleshorttext| x |
|sale/saleUdef/SuperOffice:2| *None* |salelongtext| x |
|sale/saleUdef/SuperOffice:3| *None* |salenumber| x |
|sale/saleUdef/SuperOffice:4| *None* |saledate| x |
|sale/saleUdef/SuperOffice:5| *None* |saleunlimiteddate| x |
|sale/saleUdef/SuperOffice:6| *None* |salecheckbox| x |
|sale/saleUdef/SuperOffice:7| *None* |saledropdownlistbox| x |
|sale/saleUdef/SuperOffice:8| *None* |saledecimal| x |
|appointment/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|appointment/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|appointment/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|appointment/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|appointment/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|appointment/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|appointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|appointment/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|appointment/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|appointment/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|appointment/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|appointment/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|appointment/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|appointment/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|appointment/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|appointment/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|appointment/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|appointment/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|appointment/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|appointment/appointmentId| *None* |SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP| x |
|appointment/endDate| *None* |SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP| x |
|appointment/priority| *None* |SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP| x |
|appointment/alarm| *None* |SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP| x |
|appointment/isFree| *None* |SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP| x |
|appointment/recurring| *None* |SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP| x |
|appointment/booking| *None* |SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP| x |
|appointment/intention| *None* |SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP| x |
|appointment/location| *None* |SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP| x |
|appointment/recurrenceRuleId| *None* |SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP| x |
|appointment/rawType| *None* |SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP| x |
|appointment/rawStatus| *None* |SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP| x |
|appointment/cautionWarning| *None* |SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP| x |
|appointment/visibleInDiary| *None* |SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP| x |
|appointment/endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|appointment/suggestedAppointmentId| *None* |SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP| x |
|appointment/completedDate| *None* |SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP| x |
|appointment/isMilestone| *None* |SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP| x |
|appointment/invitedPersonId| *None* |SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP| x |
|appointment/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|appointment/joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP| x |
|appointment/duration| *None* |SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|appointment/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|appointment/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointment/appointmentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|appointment/appointmentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|appointment/appointmentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|appointment/appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|appointment/appointmentUdef/SuperOffice:1| *None* |followupshorttext| x |
|appointment/appointmentUdef/SuperOffice:2| *None* |followuplongtext| x |
|appointment/appointmentUdef/SuperOffice:3| *None* |followupnumber| x |
|appointment/appointmentUdef/SuperOffice:4| *None* |followupdate| x |
|appointment/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate| x |
|appointment/appointmentUdef/SuperOffice:6| *None* |followupcheckbox| x |
|appointment/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox| x |
|appointment/appointmentUdef/SuperOffice:8| *None* |followupdecimal| x |
|appointment/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|appointment/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|appointment/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|appointment/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|appointment/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointment/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointment/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|appointment/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|appointment/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|appointment/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|appointment/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|appointment/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|appointment/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|appointment/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|appointment/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|appointment/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|appointment/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|appointment/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointment/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|appointment/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointment/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointment/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|appointment/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointment/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|appointment/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|appointment/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|appointment/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|appointment/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointment/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointment/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|appointment/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL| x |
|appointment/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|appointment/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|appointment/appointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/appointment/description| *None* |SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/appointment/title| *None* |SR\_TICKETARCHIVE\_TITLE| x |
|appointment/appointment/titleHtml| *None* |!!Title Html| x |
|appointment/appointment/agenda| *None* |SR\_APPOINTMENT\_AGENDA| x |
|appointment/appointment/agendaHtml| *None* |!!Agenda Html| x |
|appointment/appointment/isConverted| *None* |!!Is Converted|  |
|appointment/appointment/textId| *None* |Text ID| x |
|appointment/appointment/internalNotes| *None* |SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/appointment/internalNotesHtml| *None* |!!Internal Notes Html| x |
|document/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|document/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|document/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|document/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|document/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|document/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|document/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|document/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|document/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|document/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|document/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|document/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|document/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|document/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|document/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|document/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|document/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|document/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|document/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|document/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|document/documentId| *None* |SR\_DOCUMENT\_ID: SR\_DOCUMENT\_ID\_TOOLTIP| x |
|document/keywords| *None* |SR\_KEYWORDS| x |
|document/ourref| *None* |SR\_AA\_OURREF| x |
|document/yourref| *None* |SR\_ARCHIVE\_YOURREF| x |
|document/attention| *None* |SR\_ARCHIVE\_SALUTATION| x |
|document/subject| *None* |SR\_COMMON\_SUBJECT| x |
|document/name| *None* |SR\_FILENAME| x |
|document/mailMergeDraft| *None* |SR\_MAILMERGEDRAFT: SR\_DOCUMENT\_MMD\_TOOLTIP| x |
|document/snum| *None* |SR\_ARCHIVE\_DOCUMENT\_SNUM: SR\_ARCHIVE\_DOCUMENT\_SNUM\_TOOLTIP| x |
|document/isReport| *None* |SR\_DOCUMENTISREPORT: SR\_DOCUMENTISREPORT\_TOOLTIP|  |
|document/suggestedDocumentId| *None* |SR\_ARCHIVE\_SUGGESTEDDOCID: SR\_ARCHIVE\_SUGGESTEDDOCID\_TOOLTIP| x |
|document/isMail| *None* |SR\_SINGULAR\_MAIL|  |
|document/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|document/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|document/documentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|document/documentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|document/documentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|document/documentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|document/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|document/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|document/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|document/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|document/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|document/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|document/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|document/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|document/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|document/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|document/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|document/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|document/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|document/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|document/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|document/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|document/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|document/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|document/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|document/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|document/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|document/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|document/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|document/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|document/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|document/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|document/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|document/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|document/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|document/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|document/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL| x |
|document/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|document/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|document/documentUdef/SuperOffice:1| *None* |documentshorttext| x |
|document/documentUdef/SuperOffice:2| *None* |documentlongtext| x |
|document/documentUdef/SuperOffice:3| *None* |documentnumber| x |
|document/documentUdef/SuperOffice:4| *None* |documentdate| x |
|document/documentUdef/SuperOffice:5| *None* |documentunlimiteddate| x |
|document/documentUdef/SuperOffice:6| *None* |documentcheckbox| x |
|document/documentUdef/SuperOffice:7| *None* |documentdropdownlistbox| x |
|document/documentUdef/SuperOffice:8| *None* |documentdecimal| x |
|document/document/textId| *None* |Text ID| x |
|document/document/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personId|int|SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|middleName|string|SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|fullName|string|SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|personHasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|position|listAny|SR\_ARCHIVE\_POSITION| x |
|personNumber|string|SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|personCountry|listAny|SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|personCountryId|int|SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|personNoMail|bool|SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|rank|int|SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|birthdate| *None* |SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|associateType| *None* |SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|useAsMailingAddress|bool|SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|personSource|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|retired|bool|SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|birthYear|int|SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|birthMonth|int|SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|birthDay|int|SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|kanaFirstName|string|SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|kanaLastName|string|SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|personUpdatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personUpdatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personUpdatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|personRegisteredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personRegisteredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personRegisteredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personActiveErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|ticketPriority|listAny|SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|supportLanguage|listAny|SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|supportAssociate|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|supportAssociateFullName|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personAssociateId|associate|SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personAssociateFullName|associate|SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personCategory|listAny|SR\_ARCHIVE\_CATEGORY| x |
|personCategoryGroup|listAny|SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|personCategoryRank|int|!!Category rank| x |
|personBusiness|listAny|SR\_ARCHIVE\_BUSINESS| x |
|leadStatus|listAny|SR\_LABEL\_LEADSTATUS| x |
|leadstatusRank|int|!!Lead status RANK| x |
|personDeletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|hasCompany|bool|SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|isProjectMember|bool|SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|isStakeholder|bool|SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|updatedByWorkflow|listAny|SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|whenUpdatedByWorkflow|datetime|SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|createdByForm|listAny|SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|personInfo/textId|int|Text ID| x |
|personInfo/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personUdef/SuperOffice:1|string|contactshorttext: tooltipshorttext| x |
|personUdef/SuperOffice:2|string|contactlongtext: tooltiplongtext| x |
|personUdef/SuperOffice:3|int|contactnumber| x |
|personUdef/SuperOffice:4|date|contactdate| x |
|personUdef/SuperOffice:5|unlimitedDate|contactunlimiteddate: tooltipunlimiteddate| x |
|personUdef/SuperOffice:6|bool|contactcheckbox| x |
|personUdef/SuperOffice:7|listAny|contactdropdownlistbox| x |
|personUdef/SuperOffice:8|decimal|contactdecimal| x |
|personUdef/SuperOffice:9|string|page1saleonly| x |
|personUdef/SuperOffice:10|string|page1marketingonly| x |
|personUdef/SuperOffice:11|string|page1adminonly| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personExtra/x\_person\_integer|int|Extra Integer: Custom person integer| x |
|personExtra/x\_person\_hidden\_integer|int|Extra hidden integer: Custom integer field that is hidden| x |
|personExtra/x\_person\_float|decimal|Extra float: Custom float field| x |
|personExtra/x\_person\_longtext|string|Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|personExtra/x\_person\_date|date|Extra date: Custom date field on person. Default value = 28.03.2019| x |
|personExtra/x\_person\_datetime|datetime|Extra DateTime: Custom person date and time field. No default| x |
|personExtra/x\_person\_time| *None* |Extra time: Custom time field on person. Current time as default| x |
|personExtra/x\_person\_boolean|bool|Extra Boolean: Custom boolean field on person. Default checked| x |
|personExtra/x\_person\_timespan|timeSpan|Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|personExtra/x\_person\_shorttext|string|Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|personExtra/x\_person\_shorttext\_list|listAny|Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|personExtra/x\_person\_user\_relation|associate|Extra user relation: Custom person-user relation field| x |
|personExtra/x\_person\_category\_relation|listAny|Extra category relation: Custom person-category relation| x |
|personExtra/x\_person\_priority\_relation|listAny|Extra priority relation: Custom person-priority relation| x |
|personExtra/x\_person\_request\_relation|stringorPK|Extra request relation: Request relation on contact| x |
|personExtra/x\_person\_appointment\_relation|stringorPK|Extra appointment relation: Appointment relation on person| x |
|personExtra/x\_person\_contact\_relation|stringorPK|Extra company relation: Company relation on contact| x |
|personExtra/y\_rental/id|int|Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|personExtra/y\_rental/x\_start|date|Rental - Start rental: Start rental| x |
|personExtra/y\_rental/x\_end|date|Rental - End: End| x |
|personExtra/y\_rental/x\_amount|int|Rental - Amount: Number to rent. Default = 1| x |
|personExtra/y\_rental/x\_contact|stringorPK|Rental - Renter: Company that rents equipment| x |
|personExtra/y\_rental/y\_equipment/x\_name|string|Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|personExtra/y\_car/id|int|Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|isMailingRecipient|bool|SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|hasStoreConsent|bool|SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|withdrawnStoreConsent|bool|SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|hasEmarketingConsent|bool|SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|withdrawnEmarketingConsent|bool|SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|subscription|listAny|SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|legalBaseStore|listAny|SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|legalBaseEmarketing|listAny|SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|consentSourceStore|listAny|SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|consentSourceEmarketing|listAny|SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|fullNameWithContact| *None* |SR\_PERSON\_NAMEWITHCONT: SR\_PERSON\_NAMEWITHCONT\_TOOLTIP| x |
|personDirectPhone/formattedNumber| *None* |SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personDirectPhone/description| *None* |SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personMobilePhone/formattedNumber| *None* |SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personMobilePhone/description| *None* |SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personPrivate/formattedNumber| *None* |SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personPrivate/description| *None* |SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personPager/formattedNumber| *None* |SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personPager/description| *None* |SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personDirectFax/formattedNumber| *None* |SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personDirectFax/description| *None* |SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personEmail/emailProtocol| *None* |SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|personEmail/emailAddress| *None* |SR\_ARCHIVE\_EMAIL| x |
|personEmail/emailDescription| *None* |SR\_ARCHIVE\_DESCRIPTION| x |
|personEmail/emailId| *None* |ID| x |
|personEmail/emailLastSent| *None* |SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|personEmail/emailBounceCount| *None* |SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|personEmail/emailLastBounce| *None* |SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|personEmail/emailHasBounced| *None* |SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|personUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL| x |
|personUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION| x |
|personAddress/addressId| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|personAddress/line1| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|personAddress/line2| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|personAddress/line3| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|personAddress/county| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|personAddress/city| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|personAddress/zip| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|personAddress/state| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|personAddress/wgs84latitude| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|personAddress/wgs84longitude| *None* |SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|personAddress/formattedAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|personAddress/formattedMultiLineAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|personInterestIds| *None* |SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|personSourceRelation/personId| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|personSourceRelation/firstName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|personSourceRelation/lastName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|personSourceRelation/middleName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|personSourceRelation/fullName| *None* |SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|personSourceRelation/contactId| *None* |SR\_RELATION\_SOURCE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personSourceRelation/hasInfoText| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|personSourceRelation/hasInterests| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|personSourceRelation/personHasInterests| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|personSourceRelation/mrMrs| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personSourceRelation/position| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_POSITION| x |
|personSourceRelation/personNumber| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|personSourceRelation/title| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|personSourceRelation/personCountry| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|personSourceRelation/personCountryId| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|personSourceRelation/personNoMail| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|personSourceRelation/rank| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|personSourceRelation/birthdate| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|personSourceRelation/associateType| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|personSourceRelation/useAsMailingAddress| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|personSourceRelation/personSource| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|personSourceRelation/retired| *None* |SR\_RELATION\_SOURCE - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|personSourceRelation/birthYear| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|personSourceRelation/birthMonth| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|personSourceRelation/birthDay| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|personSourceRelation/kanaFirstName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|personSourceRelation/kanaLastName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|personSourceRelation/personUpdatedBy| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personSourceRelation/personUpdatedByFullName| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personSourceRelation/personUpdatedDate| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|personSourceRelation/personRegisteredBy| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personSourceRelation/personRegisteredByFullName| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personSourceRelation/personRegisteredDate| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|personSourceRelation/portraitThumbnail| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personSourceRelation/personActiveErpLinks| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|personSourceRelation/ticketPriority| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|personSourceRelation/supportLanguage| *None* |SR\_RELATION\_SOURCE - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|personSourceRelation/supportAssociate| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personSourceRelation/supportAssociateFullName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personSourceRelation/personAssociateId| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personSourceRelation/personAssociateFullName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personSourceRelation/personCategory| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY| x |
|personSourceRelation/personCategoryGroup| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|personSourceRelation/personCategoryRank| *None* |SR\_RELATION\_SOURCE - !!Category rank| x |
|personSourceRelation/personBusiness| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BUSINESS| x |
|personSourceRelation/leadStatus| *None* |SR\_RELATION\_SOURCE - SR\_LABEL\_LEADSTATUS| x |
|personSourceRelation/leadstatusRank| *None* |SR\_RELATION\_SOURCE - !!Lead status RANK| x |
|personSourceRelation/personDeletedDate| *None* |SR\_RELATION\_SOURCE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|personSourceRelation/hasCompany| *None* |SR\_RELATION\_SOURCE - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|personSourceRelation/isProjectMember| *None* |SR\_RELATION\_SOURCE - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|personSourceRelation/isStakeholder| *None* |SR\_RELATION\_SOURCE - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|personSourceRelation/updatedByWorkflow| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|personSourceRelation/whenUpdatedByWorkflow| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|personSourceRelation/createdByForm| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|personSourceRelation/restrictionContactId| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personSourceRelation/restrictionPersonId| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personSourceRelation/who| *None* |SR\_RELATION\_SOURCE - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|personSourceRelation/personPersonRelation| *None* |SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_PERSON\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|personTargetRelation/personId| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|personTargetRelation/firstName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|personTargetRelation/lastName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|personTargetRelation/middleName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|personTargetRelation/fullName| *None* |SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|personTargetRelation/contactId| *None* |SR\_RELATION\_TARGET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personTargetRelation/hasInfoText| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|personTargetRelation/hasInterests| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|personTargetRelation/personHasInterests| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|personTargetRelation/mrMrs| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personTargetRelation/position| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_POSITION| x |
|personTargetRelation/personNumber| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|personTargetRelation/title| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|personTargetRelation/personCountry| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|personTargetRelation/personCountryId| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|personTargetRelation/personNoMail| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|personTargetRelation/rank| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|personTargetRelation/birthdate| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|personTargetRelation/associateType| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|personTargetRelation/useAsMailingAddress| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|personTargetRelation/personSource| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|personTargetRelation/retired| *None* |SR\_RELATION\_TARGET - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|personTargetRelation/birthYear| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|personTargetRelation/birthMonth| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|personTargetRelation/birthDay| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|personTargetRelation/kanaFirstName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|personTargetRelation/kanaLastName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|personTargetRelation/personUpdatedBy| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personTargetRelation/personUpdatedByFullName| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personTargetRelation/personUpdatedDate| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|personTargetRelation/personRegisteredBy| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personTargetRelation/personRegisteredByFullName| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personTargetRelation/personRegisteredDate| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|personTargetRelation/portraitThumbnail| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personTargetRelation/personActiveErpLinks| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|personTargetRelation/ticketPriority| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|personTargetRelation/supportLanguage| *None* |SR\_RELATION\_TARGET - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|personTargetRelation/supportAssociate| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personTargetRelation/supportAssociateFullName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personTargetRelation/personAssociateId| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personTargetRelation/personAssociateFullName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personTargetRelation/personCategory| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY| x |
|personTargetRelation/personCategoryGroup| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|personTargetRelation/personCategoryRank| *None* |SR\_RELATION\_TARGET - !!Category rank| x |
|personTargetRelation/personBusiness| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BUSINESS| x |
|personTargetRelation/leadStatus| *None* |SR\_RELATION\_TARGET - SR\_LABEL\_LEADSTATUS| x |
|personTargetRelation/leadstatusRank| *None* |SR\_RELATION\_TARGET - !!Lead status RANK| x |
|personTargetRelation/personDeletedDate| *None* |SR\_RELATION\_TARGET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|personTargetRelation/hasCompany| *None* |SR\_RELATION\_TARGET - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|personTargetRelation/isProjectMember| *None* |SR\_RELATION\_TARGET - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|personTargetRelation/isStakeholder| *None* |SR\_RELATION\_TARGET - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|personTargetRelation/updatedByWorkflow| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|personTargetRelation/whenUpdatedByWorkflow| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|personTargetRelation/createdByForm| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|personTargetRelation/restrictionContactId| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personTargetRelation/restrictionPersonId| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personTargetRelation/who| *None* |SR\_RELATION\_TARGET - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|personTargetRelation/personPersonRelation| *None* |SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_PERSON\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|personSourceRelation/personContactRelation| *None* |SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_PERSON\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|personTargetRelation/contactPersonRelation| *None* |SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_COMPANY\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|personAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|personAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|personAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|personAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|personAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|personAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|personAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|personAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|personAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|personAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|personAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|personAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|personAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|personAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|personAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|personAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|personAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|personAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|personAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|personAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|personAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|personAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|personAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL| x |
|personAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|personAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|correspondingAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|correspondingAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|correspondingAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|correspondingAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|correspondingAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|correspondingAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|correspondingAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|correspondingAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|correspondingAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|correspondingAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|correspondingAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|correspondingAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|correspondingAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|correspondingAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|correspondingAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|correspondingAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|correspondingAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|correspondingAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|correspondingAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|correspondingAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|correspondingAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|correspondingAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|correspondingAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|correspondingAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|correspondingAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|correspondingAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|correspondingAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|correspondingAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL| x |
|correspondingAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|correspondingAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|request/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|request/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|request/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|request/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|request/ticketStatusId| *None* |SR\_TICKET\_STATUS\_ID: SR\_TICKET\_STATUS| x |
|request/priorityId| *None* |SR\_TICKET\_PRIORITY\_ID: SR\_TICKET\_PRIORITY\_ID\_TOOLTIP| x |
|request/categoryId| *None* |SR\_TICKET\_CATEGORY\_ID: SR\_TICKET\_CATEGORY\_ID\_TOOLTIP| x |
|request/ticketTypeName| *None* |SR\_TICKETARCHIVE\_TICKET\_TYPE: SR\_TICKETARCHIVE\_TICKET\_TYPE\_TOOLTIP| x |
|request/ticketStatusName| *None* |SR\_TICKETARCHIVE\_TICKETSTATUS: SR\_TICKETARCHIVE\_TICKETSTATUS\_TOOLTIP| x |
|request/categoryFullName| *None* |SR\_TICKETARCHIVE\_EJCATEGORY: SR\_TICKETARCHIVE\_EJCATEGORY\_TOOLTIP| x |
|request/priorityName| *None* |SR\_TICKETARCHIVE\_PRIORITY: SR\_TICKETARCHIVE\_PRIORITY\_TOOLTIP| x |
|request/ownedBy| *None* |SR\_TICKETARCHIVE\_OWNEDBY: SR\_TICKETARCHIVE\_OWNEDBY\_TOOLTIP| x |
|request/ticketId| *None* |SR\_TICKETARCHIVE\_TICKETID: SR\_TICKETARCHIVE\_TICKETID\_TOOLTIP| x |
|request/title| *None* |SR\_TICKETARCHIVE\_TITLE: SR\_TICKETARCHIVE\_TITLE\_TOOLTIP| x |
|request/createdAt| *None* |SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP| x |
|request/createdDate| *None* |SR\_TICKETARCHIVE\_CREATEDDATE: SR\_TICKETARCHIVE\_CREATEDDATE| x |
|request/lastChanged| *None* |SR\_TICKETARCHIVE\_LASTCHANGED: SR\_TICKETARCHIVE\_LASTCHANGED\_TOOLTIP| x |
|request/author| *None* |SR\_TICKETARCHIVE\_AUTHOR: SR\_TICKETARCHIVE\_AUTHOR\_TOOLTIP| x |
|request/readByOwner| *None* |SR\_TICKETARCHIVE\_READBYOWNER: SR\_TICKETARCHIVE\_READBYOWNER\_TOOLTIP| x |
|request/firstReadByOwner| *None* |SR\_TICKETARCHIVE\_FIRSTREADBYOWNER: SR\_TICKETARCHIVE\_FIRSTREADBYOWNER\_TOOLTIP| x |
|request/firstReadByUser| *None* |SR\_TICKETARCHVE\_FIRSTREADBYUSER: SR\_TICKETARCHVE\_FIRSTREADBYUSER\_TOOLTIP| x |
|request/readByCustomer| *None* |SR\_TICKETARCHIVE\_READBYCUSTOMER: SR\_TICKETARCHIVE\_READBYCUSTOMER\_TOOLTIP| x |
|request/status| *None* |SR\_TICKETARCHIVE\_INTERNAL\_STATUS: SR\_TICKETARCHIVE\_INTERNAL\_STATUS\_TOOLTIP| x |
|request/origin| *None* |SR\_TICKETARCHIVE\_ORIGIN: SR\_TICKETARCHIVE\_ORIGIN| x |
|request/slevel| *None* |SR\_TICKETARCHIVE\_SLEVEL: SR\_TICKETARCHIVE\_SLEVEL| x |
|request/numberOfMessages| *None* |SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES: SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES| x |
|request/numberOfReplies| *None* |SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES: SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES| x |
|request/connectId| *None* |SR\_TICKETARCHIVE\_CONNECTID: SR\_TICKETARCHIVE\_CONNECTID| x |
|request/readStatus| *None* |SR\_TICKETARCHIVE\_READSTATUS: SR\_TICKETARCHIVE\_READSTATUS| x |
|request/realTimeSpentQueue| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE| x |
|request/realTimeSpentExternally| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL| x |
|request/realTimeSpentInternally| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL| x |
|request/timeSpentQueue| *None* |SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE| x |
|request/timeSpentExternally| *None* |SR\_TICKETARCHIVE\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_TIME\_EXTERNAL| x |
|request/timeSpentInternally| *None* |SR\_TICKETARCHIVE\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_TIME\_INTERNAL| x |
|request/timeSpent| *None* |SR\_TICKETARCHIVE\_TIME\_SPENT: SR\_TICKETARCHIVE\_TIME\_SPENT| x |
|request/timeToReply| *None* |SR\_TICKETARCHIVE\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_TIME\_TO\_REPLY| x |
|request/timeToClose| *None* |SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE| x |
|request/realTimeToReply| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY| x |
|request/realTimeToClose| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE| x |
|request/repliedAt| *None* |SR\_TICKETARCHIVE\_REPLIED\_AT: SR\_TICKETARCHIVE\_REPLIED\_AT| x |
|request/closedAt| *None* |SR\_TICKETARCHIVE\_CLOSED\_AT: SR\_TICKETARCHIVE\_CLOSED\_AT| x |
|request/activated| *None* |SR\_TICKETARCHIVE\_POSTPONED\_TO: SR\_TICKETARCHIVE\_POSTPONED\_TO| x |
|request/deadline| *None* |SR\_TICKETARCHIVE\_DEADLINE: SR\_TICKETARCHIVE\_DEADLINE| x |
|request/has\_attachment| *None* |SR\_TICKETARCHIVE\_HAS\_ATTACHMENT: SR\_INBOX\_ATTACHMENT\_TOOLTIP| x |
|request/tags| *None* |SR\_TICKETARCHIVE\_TAGS: SR\_TICKETARCHIVE\_TAGS\_TOOLTIP| x |
|request/createdBy| *None* |SR\_TICKETARCHIVE\_CREATEDBY: SR\_TICKETARCHIVE\_CREATEDBY| x |
|request/content| *None* |SR\_ARCHIVE\_CONTENT: SR\_ARCHIVE\_CONTENT\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|request/messageLanguage| *None* |SR\_TICKETARCHIVE\_LANGUAGE: SR\_TICKETARCHIVE\_LANGUAGE\_TOOLTIP|  |
|request/sentimentScore| *None* |SR\_TICKETARCHIVE\_SENTIMENT: SR\_TICKETARCHIVE\_SENTIMENT\_TOOLTIP|  |
|request/sentimentConfidence| *None* |SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE: SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE| x |
|request/suggestedCategory| *None* |SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY: SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY\_TOOLTIP|  |
|request/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|request/createdBy/firstName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|request/createdBy/lastName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|request/createdBy/middleName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|request/createdBy/fullName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|request/createdBy/contactId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|request/createdBy/personId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|request/createdBy/mrMrs| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|request/createdBy/title| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|request/createdBy/associateDbId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|request/createdBy/contactName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|request/createdBy/contactDepartment| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|request/createdBy/usergroup| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|request/createdBy/usergroupId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|request/createdBy/contactFullName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|request/createdBy/contactCategory| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|request/createdBy/role| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|request/createdBy/assocName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|request/createdBy/assocTooltip| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|request/createdBy/assocType| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|request/createdBy/ejUserId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|request/createdBy/simultaneousEjUser| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|request/createdBy/ejDisplayName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|request/createdBy/ejStatus| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|request/createdBy/credentialType| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|request/createdBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|request/createdBy/isActive| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|request/createdBy/isActiveText| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|request/createdBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|request/createdBy/otherGroups| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|request/createdBy/userName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|request/createdBy/personEmail| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_EMAIL| x |
|request/createdBy/locationAddress| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|request/createdBy/isLocation| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|request/ownedBy/firstName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|request/ownedBy/lastName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|request/ownedBy/middleName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|request/ownedBy/fullName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|request/ownedBy/contactId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|request/ownedBy/personId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|request/ownedBy/mrMrs| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|request/ownedBy/title| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|request/ownedBy/associateDbId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|request/ownedBy/contactName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|request/ownedBy/contactDepartment| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|request/ownedBy/usergroup| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|request/ownedBy/usergroupId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|request/ownedBy/contactFullName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|request/ownedBy/contactCategory| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|request/ownedBy/role| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|request/ownedBy/assocName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|request/ownedBy/assocTooltip| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|request/ownedBy/assocType| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|request/ownedBy/ejUserId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|request/ownedBy/simultaneousEjUser| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|request/ownedBy/ejDisplayName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|request/ownedBy/ejStatus| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|request/ownedBy/credentialType| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|request/ownedBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|request/ownedBy/isActive| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|request/ownedBy/isActiveText| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|request/ownedBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|request/ownedBy/otherGroups| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|request/ownedBy/userName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|request/ownedBy/personEmail| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_EMAIL| x |
|request/ownedBy/locationAddress| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|request/ownedBy/isLocation| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|request/ticketStatus/ticketStatusId| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_ID: SR\_TICKETARCHIVE\_TICKETSTATUS\_ID\_TOOLTIP| x |
|request/ticketStatus/name| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME: SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME\_TOOLTIP| x |
|request/ticketStatus/rank| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK: SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK\_TOOLTIP| x |
|request/ticketPriority/ticketPriorityId| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_ID: SR\_TICKETARCHIVE\_PRIORITY\_ID\_TOOLTIP| x |
|request/ticketPriority/name| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_NAME: SR\_TICKETARCHIVE\_PRIORITY\_NAME\_TOOLTIP| x |
|request/ticketPriority/rank| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_RANK: SR\_TICKETARCHIVE\_PRIORITY\_RANK\_TOOLTIP| x |
|request/extra/x\_ticket\_integer| *None* |Extra integer: Custom ticket integer. Default 123. External. Show in properties| x |
|request/extra/x\_ticket\_float| *None* |Extra float: Custom float on Request. 2 decimal places| x |
|request/extra/x\_ticket\_longtext| *None* |Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props| x |
|request/extra/x\_ticket\_date| *None* |Extra date: Custom date field on Request. No default value| x |
|request/extra/x\_ticket\_datetime| *None* |Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request| x |
|request/extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.| x |
|request/extra/x\_ticket\_boolean| *None* |Extra boolean: Custom boolean on Ticket.| x |
|request/extra/x\_ticket\_timespan| *None* |Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props| x |
|request/extra/x\_ticket\_short\_text| *None* |Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request| x |
|request/extra/x\_ticket\_shorttext\_list| *None* |Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot| x |
|request/extra/x\_ticket\_timestamp| *None* |Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field| x |
|request/extra/x\_ticket\_project\_relation| *None* |Extra project: Custom project relation on Request| x |
|request/extra/x\_ticket\_faq| *None* |Extra FAQ Relation: Extra FAQ Relation| x |
|request/extra/x\_ticket\_category\_relation| *None* |Extra category relation: Category relation on request| x |
|request/extra/y\_equipment/x\_name| *None* |Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|request/extra/y\_car/id| *None* |Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|projectMembers/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP| x |
|projectMembers/projectId| *None* |SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP| x |
|projectMembers/name| *None* |SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP| x |
|projectMembers/number| *None* |SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP| x |
|projectMembers/type| *None* |SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP| x |
|projectMembers/status| *None* |SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP| x |
|projectMembers/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMembers/associateId| *None* |SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|projectMembers/hasInfoText| *None* |SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP| x |
|projectMembers/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|projectMembers/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|projectMembers/description| *None* |SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION| x |
|projectMembers/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|projectMembers/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|projectMembers/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|projectMembers/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|projectMembers/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|projectMembers/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|projectMembers/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|projectMembers/nextMilestone| *None* |SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP| x |
|projectMembers/endDate| *None* |SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP| x |
|projectMembers/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|projectMembers/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|projectMembers/eventId| *None* |SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID| x |
|projectMembers/startDate| *None* |SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP| x |
|projectMembers/function| *None* |SR\_PROJECTMEMBERARCHIVE\_FUNCTION: SR\_PROJECTMEMBERARCHIVE\_FUNCTION\_TOOLTIP| x |
|projectMembers/eventParticipantStatus| *None* |SR\_FIELD\_PROJECT\_MEMBER\_EVENT\_STATUS: SR\_FIELD\_PROJECT\_MEMBER\_EVENT\_STATUS| x |
|projectMembers/projectPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|projectMembers/projectPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|projectMembers/projectPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|projectMembers/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|projectMembers/projectEvent/isExternalEvent| *None* |SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP| x |
|projectMembers/projectEvent/eventDate| *None* |SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP| x |
|projectMembers/projectEvent/hasSignOn| *None* |SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP| x |
|projectMembers/projectEvent/hasSignOff| *None* |SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP| x |
|projectMembers/projectUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL| x |
|projectMembers/projectUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION| x |
|projectMembers/projectAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|projectMembers/projectAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|projectMembers/projectAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|projectMembers/projectAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|projectMembers/projectAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|projectMembers/projectAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectMembers/projectAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMembers/projectAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMembers/projectAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|projectMembers/projectAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|projectMembers/projectAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|projectMembers/projectAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMembers/projectAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMembers/projectAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|projectMembers/projectAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|projectMembers/projectAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|projectMembers/projectAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|projectMembers/projectAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|projectMembers/projectAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|projectMembers/projectAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|projectMembers/projectAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|projectMembers/projectAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|projectMembers/projectAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|projectMembers/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|projectMembers/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|projectMembers/projectAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|projectMembers/projectAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|projectMembers/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectMembers/projectAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|projectMembers/projectAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|projectMembers/projectAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL| x |
|projectMembers/projectAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|projectMembers/projectAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|projectMembers/projectUdef/SuperOffice:1| *None* |projectshorttext| x |
|projectMembers/projectUdef/SuperOffice:2| *None* |projectlongtext| x |
|projectMembers/projectUdef/SuperOffice:3| *None* |projectnumber| x |
|projectMembers/projectUdef/SuperOffice:4| *None* |projectdate| x |
|projectMembers/projectUdef/SuperOffice:5| *None* |projectunlimiteddate| x |
|projectMembers/projectUdef/SuperOffice:6| *None* |projectcheckbox| x |
|projectMembers/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox| x |
|projectMembers/projectUdef/SuperOffice:8| *None* |projectdecimal| x |
|projectMembers/projectUdef/SuperOffice:9| *None* |page1saleandmarketing| x |
|projectMembers/projectUdef/SuperOffice:10| *None* |page1saleandadmin| x |
|projectMembers/NumberOfActivities| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|projectMembers/NumberOfActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMembers/NumberOfNotCompletedActivities| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|projectMembers/NumberOfNotCompletedActivitiesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMembers/LastActivity| *None* |SR\_ROU\_LAST\_ACTIVITY|  |
|projectMembers/LastCompletedActivity| *None* |SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|projectMembers/LastDoByActivity| *None* |SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|projectMembers/NumberOfSales| *None* |SR\_ROU\_NUMBER\_OF\_SALES|  |
|projectMembers/NumberOfSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMembers/NumberOfNotCompletedSales| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|projectMembers/NumberOfNotCompletedSalesInPeriod| *None* |SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMembers/LastSale| *None* |SR\_ROU\_LAST\_SALE|  |
|projectMembers/LastCompletedSale| *None* |SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|projectMembers/LastDoBySale| *None* |SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|projectMembers/SaintStatus3| *None* |Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|projectMembers/saintSaleStatus| *None* |SR\_WITH\_STATUS|  |
|projectMembers/saintAmountClass| *None* |SR\_AMOUNT\_CLASS|  |
|projectMembers/saintActivityType| *None* |SR\_ARCHIVE\_SAINT\_TYPE|  |
|projectMembers/saintDirection| *None* |SR\_ARCHIVE\_DIRECTION|  |
|projectMembers/saintIntention| *None* |SR\_ACTIVITY\_INTENTION|  |
|projectMembers/saintTicketStatus| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|projectMembers/saintTicketCategory| *None* |SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|projectMembers/project/textId| *None* |Text ID| x |
|projectMembers/project/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|personAppointment/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|personAppointment/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAppointment/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|personAppointment/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|personAppointment/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|personAppointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|personAppointment/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personAppointment/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|personAppointment/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|personAppointment/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|personAppointment/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|personAppointment/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|personAppointment/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personAppointment/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personAppointment/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|personAppointment/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personAppointment/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personAppointment/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|personAppointment/appointmentId| *None* |SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP| x |
|personAppointment/endDate| *None* |SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP| x |
|personAppointment/priority| *None* |SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP| x |
|personAppointment/alarm| *None* |SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP| x |
|personAppointment/isFree| *None* |SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP| x |
|personAppointment/recurring| *None* |SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP| x |
|personAppointment/booking| *None* |SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP| x |
|personAppointment/intention| *None* |SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP| x |
|personAppointment/location| *None* |SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP| x |
|personAppointment/recurrenceRuleId| *None* |SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP| x |
|personAppointment/rawType| *None* |SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP| x |
|personAppointment/rawStatus| *None* |SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP| x |
|personAppointment/cautionWarning| *None* |SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP| x |
|personAppointment/visibleInDiary| *None* |SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP| x |
|personAppointment/endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|personAppointment/suggestedAppointmentId| *None* |SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP| x |
|personAppointment/completedDate| *None* |SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP| x |
|personAppointment/isMilestone| *None* |SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP| x |
|personAppointment/invitedPersonId| *None* |SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP| x |
|personAppointment/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|personAppointment/joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP| x |
|personAppointment/duration| *None* |SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|personAppointment/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|personAppointment/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|personAppointment/appointmentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|personAppointment/appointmentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|personAppointment/appointmentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|personAppointment/appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|personAppointment/appointmentUdef/SuperOffice:1| *None* |followupshorttext| x |
|personAppointment/appointmentUdef/SuperOffice:2| *None* |followuplongtext| x |
|personAppointment/appointmentUdef/SuperOffice:3| *None* |followupnumber| x |
|personAppointment/appointmentUdef/SuperOffice:4| *None* |followupdate| x |
|personAppointment/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate| x |
|personAppointment/appointmentUdef/SuperOffice:6| *None* |followupcheckbox| x |
|personAppointment/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox| x |
|personAppointment/appointmentUdef/SuperOffice:8| *None* |followupdecimal| x |
|personAppointment/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|personAppointment/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|personAppointment/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|personAppointment/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|personAppointment/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personAppointment/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|personAppointment/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personAppointment/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personAppointment/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|personAppointment/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|personAppointment/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|personAppointment/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|personAppointment/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|personAppointment/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|personAppointment/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|personAppointment/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|personAppointment/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|personAppointment/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|personAppointment/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|personAppointment/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|personAppointment/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|personAppointment/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|personAppointment/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|personAppointment/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|personAppointment/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|personAppointment/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|personAppointment/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|personAppointment/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personAppointment/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|personAppointment/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|personAppointment/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL| x |
|personAppointment/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|personAppointment/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|personAppointment/appointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/appointment/description| *None* |SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/appointment/title| *None* |SR\_TICKETARCHIVE\_TITLE| x |
|personAppointment/appointment/titleHtml| *None* |!!Title Html| x |
|personAppointment/appointment/agenda| *None* |SR\_APPOINTMENT\_AGENDA| x |
|personAppointment/appointment/agendaHtml| *None* |!!Agenda Html| x |
|personAppointment/appointment/isConverted| *None* |!!Is Converted|  |
|personAppointment/appointment/textId| *None* |Text ID| x |
|personAppointment/appointment/internalNotes| *None* |SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/appointment/internalNotesHtml| *None* |!!Internal Notes Html| x |

## Sample

```http!
GET /api/v1/archive/ContactPersonStaticSelectionV2?$select=saintDirection,sale/lossReason,appointment/cautionWarning,appointment/appointmentUdef/SuperOffice:4,document/associate/usergroupId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


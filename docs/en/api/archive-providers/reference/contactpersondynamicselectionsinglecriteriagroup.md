---
uid: ContactPersonDynamicSelectionSingleCriteriaGroup
title: ContactPersonDynamicSelectionSingleCriteriaGroup
description: Contact + Person selection archive using the selectionId as criterionmapping.
keywords: ContactPersonDynamicSelectionSingleCriteriaGroup archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ContactPersonDynamicSelectionSingleCriteriaGroup"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionDynamicProviderSingleCriteriaGroup">SuperOffice.CRM.ArchiveLists.Archive.ContactPersonSelectionDynamicProviderSingleCriteriaGroup</see> inside NetServer's SODatabase assembly.

Contact + Person selection archive using the selectionId as criterionmapping.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"contact"|[[SR_SINGULAR_COMPANY]]|
|"person"|[[SR_SINGULAR_PERSON]]|

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
|who| *None* |SR\_CONTACTSELECTIONARCHIVE\_CONTACTNAME: SR\_CONTACTSELECTIONARCHIVE\_CONTACTNAME\_TOOLTIP| x |
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
|contactAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|contactAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|contactAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
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
|sourceRelation/contactId|int|SR\_RELATION\_SOURCE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|sourceRelation/name|stringorPK|SR\_RELATION\_SOURCE - SR\_COMPANY\_NAME| x |
|sourceRelation/department|string|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DEPARTEMENT| x |
|sourceRelation/nameDepartment|string|SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|sourceRelation/hasInfoText|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|sourceRelation/hasInterests|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|sourceRelation/associateId|associate|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|sourceRelation/category|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY| x |
|sourceRelation/categoryGroup|listAny|SR\_RELATION\_SOURCE - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|sourceRelation/companyCategoryRank|int|SR\_RELATION\_SOURCE - Category rank| x |
|sourceRelation/business|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BUSINESS| x |
|sourceRelation/country|listAny|SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|sourceRelation/countryId|int|SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|sourceRelation/number|string|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_NUMBER| x |
|sourceRelation/code|string|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CODE| x |
|sourceRelation/orgnr|string|SR\_RELATION\_SOURCE - VAT No.| x |
|sourceRelation/stop|bool|SR\_RELATION\_SOURCE - SR\_CC\_STOPX| x |
|sourceRelation/contactNoMail|bool|SR\_RELATION\_SOURCE - SR\_NO\_MAIL\_COMPANY| x |
|sourceRelation/updatedBy|associate|SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sourceRelation/updatedByFullName|associate|SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sourceRelation/updatedDate|date|SR\_RELATION\_SOURCE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|sourceRelation/registeredBy|associate|SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sourceRelation/registeredByFullName|associate|SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sourceRelation/registeredDate|date|SR\_RELATION\_SOURCE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|sourceRelation/contactSource|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|sourceRelation/contactDeleted|bool|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|sourceRelation/activeErpLinks|bool|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|sourceRelation/deletedDate|datetime|SR\_RELATION\_SOURCE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|sourceRelation/mainContact| *None* |SR\_RELATION\_SOURCE - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|sourceRelation/forceCompany|bool|SR\_RELATION\_SOURCE - Dummy: Dummy|  |
|sourceRelation/restrictionContactId|int|SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|sourceRelation/who| *None* |SR\_RELATION\_SOURCE - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|sourceRelation/csRelation|listAny|SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_COMPANY\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|targetRelation/contactId|int|SR\_RELATION\_TARGET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|targetRelation/name|stringorPK|SR\_RELATION\_TARGET - SR\_COMPANY\_NAME| x |
|targetRelation/department|string|SR\_RELATION\_TARGET - SR\_ARCHIVE\_DEPARTEMENT| x |
|targetRelation/nameDepartment|string|SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|targetRelation/hasInfoText|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|targetRelation/hasInterests|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|targetRelation/associateId|associate|SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|targetRelation/category|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY| x |
|targetRelation/categoryGroup|listAny|SR\_RELATION\_TARGET - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|targetRelation/companyCategoryRank|int|SR\_RELATION\_TARGET - Category rank| x |
|targetRelation/business|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_BUSINESS| x |
|targetRelation/country|listAny|SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|targetRelation/countryId|int|SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|targetRelation/number|string|SR\_RELATION\_TARGET - SR\_ARCHIVE\_NUMBER| x |
|targetRelation/code|string|SR\_RELATION\_TARGET - SR\_ARCHIVE\_CODE| x |
|targetRelation/orgnr|string|SR\_RELATION\_TARGET - VAT No.| x |
|targetRelation/stop|bool|SR\_RELATION\_TARGET - SR\_CC\_STOPX| x |
|targetRelation/contactNoMail|bool|SR\_RELATION\_TARGET - SR\_NO\_MAIL\_COMPANY| x |
|targetRelation/updatedBy|associate|SR\_RELATION\_TARGET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|targetRelation/updatedByFullName|associate|SR\_RELATION\_TARGET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|targetRelation/updatedDate|date|SR\_RELATION\_TARGET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|targetRelation/registeredBy|associate|SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|targetRelation/registeredByFullName|associate|SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|targetRelation/registeredDate|date|SR\_RELATION\_TARGET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|targetRelation/contactSource|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|targetRelation/contactDeleted|bool|SR\_RELATION\_TARGET - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|targetRelation/activeErpLinks|bool|SR\_RELATION\_TARGET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|targetRelation/deletedDate|datetime|SR\_RELATION\_TARGET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|targetRelation/mainContact| *None* |SR\_RELATION\_TARGET - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|targetRelation/forceCompany|bool|SR\_RELATION\_TARGET - Dummy: Dummy|  |
|targetRelation/restrictionContactId|int|SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|targetRelation/who| *None* |SR\_RELATION\_TARGET - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|targetRelation/csRelation|listAny|SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_COMPANY\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|sourceRelation/contactPersonRelation|listAny|SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_COMPANY\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|targetRelation/personContactRelation|listAny|SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_PERSON\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|sale/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|sale/icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|sale/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|sale/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|sale/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|sale/recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|sale/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|sale/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|sale/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|sale/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|sale/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|sale/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|sale/userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|sale/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|sale/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sale/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sale/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|sale/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sale/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sale/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|sale/currencyId|int|SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP| x |
|sale/currency|listAny|SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP| x |
|sale/credited|listAny|SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP| x |
|sale/lossReason|listAny|SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP| x |
|sale/source|listAny|SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP| x |
|sale/competitor|listAny|SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP| x |
|sale/heading|stringorPK|SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP| x |
|sale/amount|decimal|SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|sale/amountWeighted|decimal|SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|sale/earning|decimal|SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP| x |
|sale/earningPercent|decimal|SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP| x |
|sale/probPercent|int|SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP| x |
|sale/originalStage|listAny|SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED| x |
|sale/stage|listAny|SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/saleStatus|listAny|SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP| x |
|sale/stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP| x |
|sale/saleType|listAny|SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|sale/saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|sale/stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|sale/nextDueDate|date|SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP| x |
|sale/reopenDate|date|SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP| x |
|sale/stalledComment|listAny|SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP| x |
|sale/saleTypeCategory|listAny|SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT| x |
|sale/soldReason|listAny|SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP| x |
|sale/saleNumber|string|SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER| x |
|sale/hasStakeholders|bool|SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP| x |
|sale/stakeholdersEnabled|bool|SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP| x |
|sale/hasQuote|bool|SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP| x |
|sale/hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|sale/description|string|SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|sale/createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|sale/amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|sale/amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|sale/daysInStage|int|SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP| x |
|sale/visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|sale/sale/textId|int|Text ID| x |
|sale/sale/description|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|sale/salePublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|sale/salePublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|sale/salePublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|sale/salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|sale/associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|sale/associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|sale/associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|sale/associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|sale/associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|sale/associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sale/associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|sale/associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|sale/associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|sale/associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|sale/associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|sale/associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|sale/associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|sale/associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|sale/associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|sale/associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|sale/associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|sale/associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|sale/associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|sale/associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|sale/associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|sale/associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|sale/associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|sale/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|sale/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|sale/associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|sale/associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|sale/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|sale/associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|sale/associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|sale/associate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|sale/associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|sale/associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|sale/saleUdef/SuperOffice:1|string|saleshorttext| x |
|sale/saleUdef/SuperOffice:2|string|salelongtext| x |
|sale/saleUdef/SuperOffice:3|int|salenumber| x |
|sale/saleUdef/SuperOffice:4|date|saledate| x |
|sale/saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|sale/saleUdef/SuperOffice:6|bool|salecheckbox| x |
|sale/saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|sale/saleUdef/SuperOffice:8|decimal|saledecimal| x |
|appointment/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|appointment/icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|appointment/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|appointment/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|appointment/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|appointment/recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|appointment/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|appointment/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|appointment/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|appointment/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|appointment/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|appointment/userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|appointment/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|appointment/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|appointment/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|appointment/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|appointment/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|appointment/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|appointment/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|appointment/appointmentId|int|SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP| x |
|appointment/endDate|date|SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP| x |
|appointment/priority|listAny|SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP| x |
|appointment/alarm|bool|SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP| x |
|appointment/isFree|bool|SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP| x |
|appointment/recurring|bool|SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP| x |
|appointment/booking|bool|SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP| x |
|appointment/intention|listAny|SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP| x |
|appointment/location|string|SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP| x |
|appointment/recurrenceRuleId|int|SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP| x |
|appointment/rawType|int|SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP| x |
|appointment/rawStatus|int|SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP| x |
|appointment/cautionWarning|listAny|SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP| x |
|appointment/visibleInDiary|bool|SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP| x |
|appointment/endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|appointment/suggestedAppointmentId|int|SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP| x |
|appointment/completedDate|date|SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP| x |
|appointment/isMilestone|bool|SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP| x |
|appointment/invitedPersonId|int|SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP| x |
|appointment/recordTypeText|listAny|SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|appointment/joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP| x |
|appointment/duration|timeSpan|SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|appointment/createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|appointment/visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|appointment/appointmentPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|appointment/appointmentPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|appointment/appointmentPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointment/appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|appointment/appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|appointment/appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|appointment/appointmentUdef/SuperOffice:3|int|followupnumber| x |
|appointment/appointmentUdef/SuperOffice:4|date|followupdate| x |
|appointment/appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|appointment/appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|appointment/appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|appointment/appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|appointment/associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|appointment/associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|appointment/associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|appointment/associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|appointment/associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointment/associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointment/associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|appointment/associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|appointment/associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|appointment/associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|appointment/associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|appointment/associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|appointment/associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|appointment/associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|appointment/associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|appointment/associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|appointment/associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|appointment/associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointment/associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|appointment/associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointment/associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointment/associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|appointment/associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointment/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|appointment/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|appointment/associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|appointment/associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|appointment/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointment/associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointment/associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|appointment/associate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|appointment/associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|appointment/associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|appointment/appointment/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/appointment/description|positiveString|SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/appointment/title|positiveString|SR\_TICKETARCHIVE\_TITLE| x |
|appointment/appointment/titleHtml| *None* |!!Title Html| x |
|appointment/appointment/agenda|positiveString|SR\_APPOINTMENT\_AGENDA| x |
|appointment/appointment/agendaHtml| *None* |!!Agenda Html| x |
|appointment/appointment/isConverted| *None* |!!Is Converted|  |
|appointment/appointment/textId|int|Text ID| x |
|appointment/appointment/internalNotes|positiveString|SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|appointment/appointment/internalNotesHtml|positiveString|!!Internal Notes Html| x |
|document/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|document/icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|document/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|document/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|document/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|document/recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|document/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|document/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|document/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|document/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|document/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|document/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|document/userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|document/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|document/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|document/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|document/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|document/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|document/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|document/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|document/documentId|int|SR\_DOCUMENT\_ID: SR\_DOCUMENT\_ID\_TOOLTIP| x |
|document/keywords|string|SR\_KEYWORDS| x |
|document/ourref|string|SR\_AA\_OURREF| x |
|document/yourref|string|SR\_ARCHIVE\_YOURREF| x |
|document/attention|string|SR\_ARCHIVE\_SALUTATION| x |
|document/subject|string|SR\_COMMON\_SUBJECT| x |
|document/name|string|SR\_FILENAME| x |
|document/mailMergeDraft|bool|SR\_MAILMERGEDRAFT: SR\_DOCUMENT\_MMD\_TOOLTIP| x |
|document/snum|int|SR\_ARCHIVE\_DOCUMENT\_SNUM: SR\_ARCHIVE\_DOCUMENT\_SNUM\_TOOLTIP| x |
|document/isReport|bool|SR\_DOCUMENTISREPORT: SR\_DOCUMENTISREPORT\_TOOLTIP|  |
|document/suggestedDocumentId|int|SR\_ARCHIVE\_SUGGESTEDDOCID: SR\_ARCHIVE\_SUGGESTEDDOCID\_TOOLTIP| x |
|document/isMail|bool|SR\_SINGULAR\_MAIL|  |
|document/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|document/visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|document/documentPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|document/documentPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|document/documentPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|document/documentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|document/associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|document/associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|document/associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|document/associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|document/associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|document/associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|document/associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|document/associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|document/associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|document/associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|document/associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|document/associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|document/associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|document/associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|document/associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|document/associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|document/associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|document/associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|document/associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|document/associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|document/associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|document/associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|document/associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|document/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|document/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|document/associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|document/associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|document/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|document/associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|document/associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|document/associate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|document/associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|document/associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|document/documentUdef/SuperOffice:1|string|documentshorttext| x |
|document/documentUdef/SuperOffice:2|string|documentlongtext| x |
|document/documentUdef/SuperOffice:3|int|documentnumber| x |
|document/documentUdef/SuperOffice:4|date|documentdate| x |
|document/documentUdef/SuperOffice:5|unlimitedDate|documentunlimiteddate| x |
|document/documentUdef/SuperOffice:6|bool|documentcheckbox| x |
|document/documentUdef/SuperOffice:7|listAny|documentdropdownlistbox| x |
|document/documentUdef/SuperOffice:8|decimal|documentdecimal| x |
|document/document/textId|int|Text ID| x |
|document/document/description|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
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
|includePersonRestriction|string|SR\_FIND\_CONT\_ONLY\_MAIN\_PERS: SR\_RESTRICTION\_INCLUDEMP\_TOOLTIP|  |
|includePersonWithNoDMRestriction|bool|SR\_FIND\_PERS\_EXC\_NODM: SR\_RESTRICTION\_NODMTOOLTIP|  |
|personDirectPhone/formattedNumber|string|SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personDirectPhone/description|string|SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personMobilePhone/formattedNumber|string|SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personMobilePhone/description|string|SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personPrivate/formattedNumber|string|SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personPrivate/description|string|SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personPager/formattedNumber|string|SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personPager/description|string|SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personDirectFax/formattedNumber|string|SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|personDirectFax/description|string|SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|personInfo/textId|int|Text ID| x |
|personInfo/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personEmail/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|personEmail/emailAddress|string|SR\_ARCHIVE\_EMAIL| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personEmail/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|personEmail/emailId|int|ID| x |
|personEmail/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|personEmail/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|personEmail/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|personEmail/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|personUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|personUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|personAddress/addressId|int|SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|personAddress/line1|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|personAddress/line2|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|personAddress/line3|string|SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|personAddress/county|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|personAddress/city|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|personAddress/zip|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|personAddress/state|string|SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|personAddress/wgs84latitude|decimal|SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|personAddress/wgs84longitude|decimal|SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|personAddress/formattedAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|personAddress/formattedMultiLineAddress| *None* |SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|personInterestIds|listInterest|SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
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
|personSourceRelation/personId|int|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|personSourceRelation/firstName|string|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|personSourceRelation/lastName|string|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|personSourceRelation/middleName|string|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|personSourceRelation/fullName|string|SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|personSourceRelation/contactId|int|SR\_RELATION\_SOURCE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personSourceRelation/hasInfoText|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|personSourceRelation/hasInterests|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|personSourceRelation/personHasInterests|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|personSourceRelation/mrMrs|string|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personSourceRelation/position|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_POSITION| x |
|personSourceRelation/personNumber|string|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|personSourceRelation/title|string|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|personSourceRelation/personCountry|listAny|SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|personSourceRelation/personCountryId|int|SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|personSourceRelation/personNoMail|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|personSourceRelation/rank|int|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|personSourceRelation/birthdate| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|personSourceRelation/associateType| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|personSourceRelation/useAsMailingAddress|bool|SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|personSourceRelation/personSource|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|personSourceRelation/retired|bool|SR\_RELATION\_SOURCE - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|personSourceRelation/birthYear|int|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|personSourceRelation/birthMonth|int|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|personSourceRelation/birthDay|int|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|personSourceRelation/kanaFirstName|string|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|personSourceRelation/kanaLastName|string|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|personSourceRelation/personUpdatedBy|associate|SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personSourceRelation/personUpdatedByFullName|associate|SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personSourceRelation/personUpdatedDate|date|SR\_RELATION\_SOURCE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|personSourceRelation/personRegisteredBy|associate|SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personSourceRelation/personRegisteredByFullName|associate|SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personSourceRelation/personRegisteredDate|date|SR\_RELATION\_SOURCE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|personSourceRelation/portraitThumbnail| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personSourceRelation/personActiveErpLinks|bool|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|personSourceRelation/ticketPriority|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|personSourceRelation/supportLanguage|listAny|SR\_RELATION\_SOURCE - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|personSourceRelation/supportAssociate|associate|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personSourceRelation/supportAssociateFullName|associate|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personSourceRelation/personAssociateId|associate|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personSourceRelation/personAssociateFullName|associate|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personSourceRelation/personCategory|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY| x |
|personSourceRelation/personCategoryGroup|listAny|SR\_RELATION\_SOURCE - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|personSourceRelation/personCategoryRank|int|SR\_RELATION\_SOURCE - !!Category rank| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personSourceRelation/personBusiness|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BUSINESS| x |
|personSourceRelation/leadStatus|listAny|SR\_RELATION\_SOURCE - SR\_LABEL\_LEADSTATUS| x |
|personSourceRelation/leadstatusRank|int|SR\_RELATION\_SOURCE - !!Lead status RANK| x |
|personSourceRelation/personDeletedDate|datetime|SR\_RELATION\_SOURCE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|personSourceRelation/hasCompany|bool|SR\_RELATION\_SOURCE - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|personSourceRelation/isProjectMember|bool|SR\_RELATION\_SOURCE - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|personSourceRelation/isStakeholder|bool|SR\_RELATION\_SOURCE - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|personSourceRelation/updatedByWorkflow|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|personSourceRelation/whenUpdatedByWorkflow|datetime|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|personSourceRelation/createdByForm|listAny|SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|personSourceRelation/restrictionContactId|int|SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personSourceRelation/restrictionPersonId|int|SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personSourceRelation/who| *None* |SR\_RELATION\_SOURCE - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|personSourceRelation/personPersonRelation|listAny|SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_PERSON\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|personTargetRelation/personId|int|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|personTargetRelation/firstName|string|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|personTargetRelation/lastName|string|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|personTargetRelation/middleName|string|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|personTargetRelation/fullName|string|SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|personTargetRelation/contactId|int|SR\_RELATION\_TARGET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personTargetRelation/hasInfoText|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|personTargetRelation/hasInterests|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|personTargetRelation/personHasInterests|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|personTargetRelation/mrMrs|string|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personTargetRelation/position|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_POSITION| x |
|personTargetRelation/personNumber|string|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|personTargetRelation/title|string|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|personTargetRelation/personCountry|listAny|SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|personTargetRelation/personCountryId|int|SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|personTargetRelation/personNoMail|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|personTargetRelation/rank|int|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|personTargetRelation/birthdate| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|personTargetRelation/associateType| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|personTargetRelation/useAsMailingAddress|bool|SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|personTargetRelation/personSource|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|personTargetRelation/retired|bool|SR\_RELATION\_TARGET - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|personTargetRelation/birthYear|int|SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|personTargetRelation/birthMonth|int|SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|personTargetRelation/birthDay|int|SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|personTargetRelation/kanaFirstName|string|SR\_RELATION\_TARGET - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|personTargetRelation/kanaLastName|string|SR\_RELATION\_TARGET - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|personTargetRelation/personUpdatedBy|associate|SR\_RELATION\_TARGET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personTargetRelation/personUpdatedByFullName|associate|SR\_RELATION\_TARGET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personTargetRelation/personUpdatedDate|date|SR\_RELATION\_TARGET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|personTargetRelation/personRegisteredBy|associate|SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personTargetRelation/personRegisteredByFullName|associate|SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personTargetRelation/personRegisteredDate|date|SR\_RELATION\_TARGET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|personTargetRelation/portraitThumbnail| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personTargetRelation/personActiveErpLinks|bool|SR\_RELATION\_TARGET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|personTargetRelation/ticketPriority|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|personTargetRelation/supportLanguage|listAny|SR\_RELATION\_TARGET - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|personTargetRelation/supportAssociate|associate|SR\_RELATION\_TARGET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personTargetRelation/supportAssociateFullName|associate|SR\_RELATION\_TARGET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|personTargetRelation/personAssociateId|associate|SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personTargetRelation/personAssociateFullName|associate|SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|personTargetRelation/personCategory|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY| x |
|personTargetRelation/personCategoryGroup|listAny|SR\_RELATION\_TARGET - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|personTargetRelation/personCategoryRank|int|SR\_RELATION\_TARGET - !!Category rank| x |
|personTargetRelation/personBusiness|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_BUSINESS| x |
|personTargetRelation/leadStatus|listAny|SR\_RELATION\_TARGET - SR\_LABEL\_LEADSTATUS| x |
|personTargetRelation/leadstatusRank|int|SR\_RELATION\_TARGET - !!Lead status RANK| x |
|personTargetRelation/personDeletedDate|datetime|SR\_RELATION\_TARGET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|personTargetRelation/hasCompany|bool|SR\_RELATION\_TARGET - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|personTargetRelation/isProjectMember|bool|SR\_RELATION\_TARGET - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|personTargetRelation/isStakeholder|bool|SR\_RELATION\_TARGET - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|personTargetRelation/updatedByWorkflow|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|personTargetRelation/whenUpdatedByWorkflow|datetime|SR\_RELATION\_TARGET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|personTargetRelation/createdByForm|listAny|SR\_RELATION\_TARGET - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|personTargetRelation/restrictionContactId|int|SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personTargetRelation/restrictionPersonId|int|SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personTargetRelation/who| *None* |SR\_RELATION\_TARGET - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP| x |
|personTargetRelation/personPersonRelation|listAny|SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_PERSON\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|personSourceRelation/personContactRelation|listAny|SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_PERSON\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|personTargetRelation/contactPersonRelation|listAny|SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_COMPANY\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP| x |
|personAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|personAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|personAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|personAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|personAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|personAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|personAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|personAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|personAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|personAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|personAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|personAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|personAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|personAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|personAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|personAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|personAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|personAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|personAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|personAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|personAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|personAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|personAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|personAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|personAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|correspondingAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|correspondingAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|correspondingAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|correspondingAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|correspondingAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|correspondingAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|correspondingAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|correspondingAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|correspondingAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|correspondingAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|correspondingAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|correspondingAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|correspondingAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|correspondingAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|correspondingAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|correspondingAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|correspondingAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|correspondingAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|correspondingAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|correspondingAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|correspondingAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|correspondingAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|correspondingAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|correspondingAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|correspondingAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|correspondingAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|correspondingAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|correspondingAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|correspondingAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|correspondingAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
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
|request/contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|request/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|request/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|request/projectId|int|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|request/ticketStatusId|int|SR\_TICKET\_STATUS\_ID: SR\_TICKET\_STATUS| x |
|request/priorityId|int|SR\_TICKET\_PRIORITY\_ID: SR\_TICKET\_PRIORITY\_ID\_TOOLTIP| x |
|request/categoryId|int|SR\_TICKET\_CATEGORY\_ID: SR\_TICKET\_CATEGORY\_ID\_TOOLTIP| x |
|request/ticketTypeName|listAny|SR\_TICKETARCHIVE\_TICKET\_TYPE: SR\_TICKETARCHIVE\_TICKET\_TYPE\_TOOLTIP| x |
|request/ticketStatusName|listAny|SR\_TICKETARCHIVE\_TICKETSTATUS: SR\_TICKETARCHIVE\_TICKETSTATUS\_TOOLTIP| x |
|request/categoryFullName|ejCategory|SR\_TICKETARCHIVE\_EJCATEGORY: SR\_TICKETARCHIVE\_EJCATEGORY\_TOOLTIP| x |
|request/priorityName|listAny|SR\_TICKETARCHIVE\_PRIORITY: SR\_TICKETARCHIVE\_PRIORITY\_TOOLTIP| x |
|request/ownedBy|ejUser|SR\_TICKETARCHIVE\_OWNEDBY: SR\_TICKETARCHIVE\_OWNEDBY\_TOOLTIP| x |
|request/ticketId|int|SR\_TICKETARCHIVE\_TICKETID: SR\_TICKETARCHIVE\_TICKETID\_TOOLTIP| x |
|request/title|string|SR\_TICKETARCHIVE\_TITLE: SR\_TICKETARCHIVE\_TITLE\_TOOLTIP| x |
|request/createdAt|datetime|SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP| x |
|request/createdDate|date|SR\_TICKETARCHIVE\_CREATEDDATE: SR\_TICKETARCHIVE\_CREATEDDATE| x |
|request/lastChanged|datetime|SR\_TICKETARCHIVE\_LASTCHANGED: SR\_TICKETARCHIVE\_LASTCHANGED\_TOOLTIP| x |
|request/author|string|SR\_TICKETARCHIVE\_AUTHOR: SR\_TICKETARCHIVE\_AUTHOR\_TOOLTIP| x |
|request/readByOwner|datetime|SR\_TICKETARCHIVE\_READBYOWNER: SR\_TICKETARCHIVE\_READBYOWNER\_TOOLTIP| x |
|request/firstReadByOwner|datetime|SR\_TICKETARCHIVE\_FIRSTREADBYOWNER: SR\_TICKETARCHIVE\_FIRSTREADBYOWNER\_TOOLTIP| x |
|request/firstReadByUser|datetime|SR\_TICKETARCHVE\_FIRSTREADBYUSER: SR\_TICKETARCHVE\_FIRSTREADBYUSER\_TOOLTIP| x |
|request/readByCustomer|datetime|SR\_TICKETARCHIVE\_READBYCUSTOMER: SR\_TICKETARCHIVE\_READBYCUSTOMER\_TOOLTIP| x |
|request/status|listAny|SR\_TICKETARCHIVE\_INTERNAL\_STATUS: SR\_TICKETARCHIVE\_INTERNAL\_STATUS\_TOOLTIP| x |
|request/origin|listAny|SR\_TICKETARCHIVE\_ORIGIN: SR\_TICKETARCHIVE\_ORIGIN| x |
|request/slevel|listAny|SR\_TICKETARCHIVE\_SLEVEL: SR\_TICKETARCHIVE\_SLEVEL| x |
|request/numberOfMessages|int|SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES: SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES| x |
|request/numberOfReplies|int|SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES: SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES| x |
|request/connectId|int|SR\_TICKETARCHIVE\_CONNECTID: SR\_TICKETARCHIVE\_CONNECTID| x |
|request/readStatus|listAny|SR\_TICKETARCHIVE\_READSTATUS: SR\_TICKETARCHIVE\_READSTATUS| x |
|request/realTimeSpentQueue|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE| x |
|request/realTimeSpentExternally|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL| x |
|request/realTimeSpentInternally|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL| x |
|request/timeSpentQueue|timeSpan|SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE| x |
|request/timeSpentExternally|timeSpan|SR\_TICKETARCHIVE\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_TIME\_EXTERNAL| x |
|request/timeSpentInternally|timeSpan|SR\_TICKETARCHIVE\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_TIME\_INTERNAL| x |
|request/timeSpent|timeSpan|SR\_TICKETARCHIVE\_TIME\_SPENT: SR\_TICKETARCHIVE\_TIME\_SPENT| x |
|request/timeToReply|timeSpan|SR\_TICKETARCHIVE\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_TIME\_TO\_REPLY| x |
|request/timeToClose|timeSpan|SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE| x |
|request/realTimeToReply|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY| x |
|request/realTimeToClose|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE| x |
|request/repliedAt|datetime|SR\_TICKETARCHIVE\_REPLIED\_AT: SR\_TICKETARCHIVE\_REPLIED\_AT| x |
|request/closedAt|datetime|SR\_TICKETARCHIVE\_CLOSED\_AT: SR\_TICKETARCHIVE\_CLOSED\_AT| x |
|request/activated|datetime|SR\_TICKETARCHIVE\_POSTPONED\_TO: SR\_TICKETARCHIVE\_POSTPONED\_TO| x |
|request/deadline|datetime|SR\_TICKETARCHIVE\_DEADLINE: SR\_TICKETARCHIVE\_DEADLINE| x |
|request/has\_attachment|bool|SR\_TICKETARCHIVE\_HAS\_ATTACHMENT: SR\_INBOX\_ATTACHMENT\_TOOLTIP| x |
|request/tags|intArray|SR\_TICKETARCHIVE\_TAGS: SR\_TICKETARCHIVE\_TAGS\_TOOLTIP| x |
|request/createdBy|ejUser|SR\_TICKETARCHIVE\_CREATEDBY: SR\_TICKETARCHIVE\_CREATEDBY| x |
|request/content|string|SR\_ARCHIVE\_CONTENT: SR\_ARCHIVE\_CONTENT\_TOOLTIP| x |
|request/messageLanguage|listAny|SR\_TICKETARCHIVE\_LANGUAGE: SR\_TICKETARCHIVE\_LANGUAGE\_TOOLTIP|  |
|request/sentimentScore|listAny|SR\_TICKETARCHIVE\_SENTIMENT: SR\_TICKETARCHIVE\_SENTIMENT\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|request/sentimentConfidence|int|SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE: SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE| x |
|request/suggestedCategory|listAny|SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY: SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY\_TOOLTIP|  |
|request/createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|request/createdBy/firstName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|request/createdBy/lastName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|request/createdBy/middleName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|request/createdBy/fullName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|request/createdBy/contactId|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|request/createdBy/personId|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|request/createdBy/mrMrs|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|request/createdBy/title|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|request/createdBy/associateDbId|associate|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|request/createdBy/contactName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|request/createdBy/contactDepartment|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|request/createdBy/usergroup|userGroup|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|request/createdBy/usergroupId|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|request/createdBy/contactFullName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|request/createdBy/contactCategory|listAny|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|request/createdBy/role|listAny|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|request/createdBy/assocName|associate|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|request/createdBy/assocTooltip|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|request/createdBy/assocType|listAny|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|request/createdBy/ejUserId|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|request/createdBy/simultaneousEjUser|bool|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|request/createdBy/ejDisplayName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|request/createdBy/ejStatus|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|request/createdBy/credentialType| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|request/createdBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|request/createdBy/isActive|bool|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|request/createdBy/isActiveText|bool|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|request/createdBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|request/createdBy/otherGroups|userGroup|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|request/createdBy/userName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|request/createdBy/personEmail|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_EMAIL| x |
|request/createdBy/locationAddress|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|request/createdBy/isLocation|bool|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|request/ownedBy/firstName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|request/ownedBy/lastName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|request/ownedBy/middleName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|request/ownedBy/fullName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|request/ownedBy/contactId|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|request/ownedBy/personId|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|request/ownedBy/mrMrs|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|request/ownedBy/title|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|request/ownedBy/associateDbId|associate|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|request/ownedBy/contactName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|request/ownedBy/contactDepartment|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|request/ownedBy/usergroup|userGroup|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|request/ownedBy/usergroupId|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|request/ownedBy/contactFullName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|request/ownedBy/contactCategory|listAny|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|request/ownedBy/role|listAny|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|request/ownedBy/assocName|associate|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|request/ownedBy/assocTooltip|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|request/ownedBy/assocType|listAny|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|request/ownedBy/ejUserId|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|request/ownedBy/simultaneousEjUser|bool|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|request/ownedBy/ejDisplayName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|request/ownedBy/ejStatus|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|request/ownedBy/credentialType| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|request/ownedBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|request/ownedBy/isActive|bool|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|request/ownedBy/isActiveText|bool|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|request/ownedBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|request/ownedBy/otherGroups|userGroup|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|request/ownedBy/userName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|request/ownedBy/personEmail|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_EMAIL| x |
|request/ownedBy/locationAddress|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|request/ownedBy/isLocation|bool|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|request/ticketStatus/ticketStatusId|int|SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_ID: SR\_TICKETARCHIVE\_TICKETSTATUS\_ID\_TOOLTIP| x |
|request/ticketStatus/name|string|SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME: SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME\_TOOLTIP| x |
|request/ticketStatus/rank|int|SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK: SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK\_TOOLTIP| x |
|request/ticketPriority/ticketPriorityId|int|SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_ID: SR\_TICKETARCHIVE\_PRIORITY\_ID\_TOOLTIP| x |
|request/ticketPriority/name|string|SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_NAME: SR\_TICKETARCHIVE\_PRIORITY\_NAME\_TOOLTIP| x |
|request/ticketPriority/rank|int|SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_RANK: SR\_TICKETARCHIVE\_PRIORITY\_RANK\_TOOLTIP| x |
|request/extra/x\_ticket\_integer|int|Extra integer: Custom ticket integer. Default 123. External. Show in properties| x |
|request/extra/x\_ticket\_float|decimal|Extra float: Custom float on Request. 2 decimal places| x |
|request/extra/x\_ticket\_longtext|string|Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props| x |
|request/extra/x\_ticket\_date|date|Extra date: Custom date field on Request. No default value| x |
|request/extra/x\_ticket\_datetime|datetime|Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request| x |
|request/extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.| x |
|request/extra/x\_ticket\_boolean|bool|Extra boolean: Custom boolean on Ticket.| x |
|request/extra/x\_ticket\_timespan|timeSpan|Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props| x |
|request/extra/x\_ticket\_short\_text|string|Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request| x |
|request/extra/x\_ticket\_shorttext\_list|listAny|Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot| x |
|request/extra/x\_ticket\_timestamp|datetime|Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field| x |
|request/extra/x\_ticket\_project\_relation|stringorPK|Extra project: Custom project relation on Request| x |
|request/extra/x\_ticket\_faq|stringorPK|Extra FAQ Relation: Extra FAQ Relation| x |
|request/extra/x\_ticket\_category\_relation|listAny|Extra category relation: Category relation on request| x |
|request/extra/y\_equipment/x\_name|string|Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|request/extra/y\_car/id|int|Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|projectMembers/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP| x |
|projectMembers/projectId|int|SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP| x |
|projectMembers/name|stringorPK|SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP| x |
|projectMembers/number|string|SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP| x |
|projectMembers/type|listAny|SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP| x |
|projectMembers/status|listAny|SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP| x |
|projectMembers/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP| x |
|projectMembers/associateId|associate|SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|projectMembers/hasInfoText|bool|SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMembers/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|projectMembers/text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|projectMembers/description|string|SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION| x |
|projectMembers/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|projectMembers/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|projectMembers/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|projectMembers/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|projectMembers/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|projectMembers/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|projectMembers/hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|projectMembers/nextMilestone|date|SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP| x |
|projectMembers/endDate|date|SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP| x |
|projectMembers/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|projectMembers/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|projectMembers/eventId|int|SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID| x |
|projectMembers/startDate|date|SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP| x |
|projectMembers/function|listAny|SR\_PROJECTMEMBERARCHIVE\_FUNCTION: SR\_PROJECTMEMBERARCHIVE\_FUNCTION\_TOOLTIP| x |
|projectMembers/eventParticipantStatus|listAny|SR\_FIELD\_PROJECT\_MEMBER\_EVENT\_STATUS: SR\_FIELD\_PROJECT\_MEMBER\_EVENT\_STATUS| x |
|projectMembers/projectPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|projectMembers/projectPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|projectMembers/projectPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|projectMembers/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|projectMembers/projectEvent/isExternalEvent|bool|SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP| x |
|projectMembers/projectEvent/eventDate|date|SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP| x |
|projectMembers/projectEvent/hasSignOn|bool|SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP| x |
|projectMembers/projectEvent/hasSignOff|bool|SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP| x |
|projectMembers/projectUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|projectMembers/projectUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|projectMembers/projectAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|projectMembers/projectAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|projectMembers/projectAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|projectMembers/projectAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|projectMembers/projectAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|projectMembers/projectAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectMembers/projectAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMembers/projectAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|projectMembers/projectAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|projectMembers/projectAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|projectMembers/projectAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|projectMembers/projectAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMembers/projectAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|projectMembers/projectAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|projectMembers/projectAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|projectMembers/projectAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|projectMembers/projectAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|projectMembers/projectAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|projectMembers/projectAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|projectMembers/projectAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|projectMembers/projectAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|projectMembers/projectAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|projectMembers/projectAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|projectMembers/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|projectMembers/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|projectMembers/projectAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|projectMembers/projectAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|projectMembers/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectMembers/projectAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|projectMembers/projectAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|projectMembers/projectAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|projectMembers/projectAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|projectMembers/projectAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|projectMembers/projectUdef/SuperOffice:1|string|projectshorttext| x |
|projectMembers/projectUdef/SuperOffice:2|string|projectlongtext| x |
|projectMembers/projectUdef/SuperOffice:3|int|projectnumber| x |
|projectMembers/projectUdef/SuperOffice:4|date|projectdate| x |
|projectMembers/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|projectMembers/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|projectMembers/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|projectMembers/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|projectMembers/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|projectMembers/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|projectMembers/NumberOfActivities|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|projectMembers/NumberOfActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMembers/NumberOfNotCompletedActivities|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|projectMembers/NumberOfNotCompletedActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMembers/LastActivity|date|SR\_ROU\_LAST\_ACTIVITY|  |
|projectMembers/LastCompletedActivity|date|SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|projectMembers/LastDoByActivity|date|SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|projectMembers/NumberOfSales|int|SR\_ROU\_NUMBER\_OF\_SALES|  |
|projectMembers/NumberOfSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMembers/NumberOfNotCompletedSales|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|projectMembers/NumberOfNotCompletedSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|projectMembers/LastSale|date|SR\_ROU\_LAST\_SALE|  |
|projectMembers/LastCompletedSale|date|SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|projectMembers/LastDoBySale|date|SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|projectMembers/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|projectMembers/saintSaleStatus|listAny|SR\_WITH\_STATUS|  |
|projectMembers/saintAmountClass|listAny|SR\_AMOUNT\_CLASS|  |
|projectMembers/saintActivityType|listAny|SR\_ARCHIVE\_SAINT\_TYPE|  |
|projectMembers/saintDirection|listAny|SR\_ARCHIVE\_DIRECTION|  |
|projectMembers/saintIntention|listAny|SR\_ACTIVITY\_INTENTION|  |
|projectMembers/saintTicketStatus|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|projectMembers/saintTicketCategory|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|projectMembers/project/textId|int|Text ID| x |
|projectMembers/project/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|personAppointment/icon|listAny|SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|personAppointment/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|personAppointment/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|personAppointment/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAppointment/recordType|string|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|personAppointment/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|personAppointment/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personAppointment/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|personAppointment/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|personAppointment/saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|personAppointment/userGroup|userGroup|SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|personAppointment/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|personAppointment/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personAppointment/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|personAppointment/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|personAppointment/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personAppointment/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|personAppointment/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|personAppointment/appointmentId|int|SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP| x |
|personAppointment/endDate|date|SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP| x |
|personAppointment/priority|listAny|SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP| x |
|personAppointment/alarm|bool|SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP| x |
|personAppointment/isFree|bool|SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP| x |
|personAppointment/recurring|bool|SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP| x |
|personAppointment/booking|bool|SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP| x |
|personAppointment/intention|listAny|SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP| x |
|personAppointment/location|string|SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP| x |
|personAppointment/recurrenceRuleId|int|SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP| x |
|personAppointment/rawType|int|SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP| x |
|personAppointment/rawStatus|int|SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP| x |
|personAppointment/cautionWarning|listAny|SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP| x |
|personAppointment/visibleInDiary|bool|SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP| x |
|personAppointment/endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|personAppointment/suggestedAppointmentId|int|SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP| x |
|personAppointment/completedDate|date|SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP| x |
|personAppointment/isMilestone|bool|SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP| x |
|personAppointment/invitedPersonId|int|SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP| x |
|personAppointment/recordTypeText|listAny|SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|personAppointment/joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP| x |
|personAppointment/duration|timeSpan|SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|personAppointment/createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|personAppointment/visibleFor|listAny|SR\_ARCHIVE\_VISIBLE\_FOR|  |
|personAppointment/appointmentPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|personAppointment/appointmentPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|personAppointment/appointmentPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|personAppointment/appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|personAppointment/appointmentUdef/SuperOffice:1|string|followupshorttext| x |
|personAppointment/appointmentUdef/SuperOffice:2|string|followuplongtext| x |
|personAppointment/appointmentUdef/SuperOffice:3|int|followupnumber| x |
|personAppointment/appointmentUdef/SuperOffice:4|date|followupdate| x |
|personAppointment/appointmentUdef/SuperOffice:5|unlimitedDate|followupunlimiteddate| x |
|personAppointment/appointmentUdef/SuperOffice:6|bool|followupcheckbox| x |
|personAppointment/appointmentUdef/SuperOffice:7|listAny|followupdropdownlistbox| x |
|personAppointment/appointmentUdef/SuperOffice:8|decimal|followupdecimal| x |
|personAppointment/associate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|personAppointment/associate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|personAppointment/associate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|personAppointment/associate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|personAppointment/associate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personAppointment/associate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|personAppointment/associate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personAppointment/associate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|personAppointment/associate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|personAppointment/associate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|personAppointment/associate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|personAppointment/associate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|personAppointment/associate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|personAppointment/associate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|personAppointment/associate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|personAppointment/associate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|personAppointment/associate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|personAppointment/associate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|personAppointment/associate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|personAppointment/associate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|personAppointment/associate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|personAppointment/associate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|personAppointment/associate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|personAppointment/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|personAppointment/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|personAppointment/associate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|personAppointment/associate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|personAppointment/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personAppointment/associate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|personAppointment/associate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|personAppointment/associate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|personAppointment/associate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|personAppointment/associate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|personAppointment/appointment/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/appointment/description|positiveString|SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/appointment/title|positiveString|SR\_TICKETARCHIVE\_TITLE| x |
|personAppointment/appointment/titleHtml| *None* |!!Title Html| x |
|personAppointment/appointment/agenda|positiveString|SR\_APPOINTMENT\_AGENDA| x |
|personAppointment/appointment/agendaHtml| *None* |!!Agenda Html| x |
|personAppointment/appointment/isConverted| *None* |!!Is Converted|  |
|personAppointment/appointment/textId|int|Text ID| x |
|personAppointment/appointment/internalNotes|positiveString|SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|personAppointment/appointment/internalNotesHtml|positiveString|!!Internal Notes Html| x |
|fullNameWithContact| *None* |SR\_PERSON\_NAMEWITHCONT: SR\_PERSON\_NAMEWITHCONT\_TOOLTIP| x |
|selectionMemberId|int|SR\_SELECTIONMEMBER\_ID: SR\_SELECTIONMEMBER\_ID\_TOOLTIP|  |
|selectionIdRequest|int|SR\_RESTRICTION\_SELECTIONID: SR\_RESTRICTION\_SELECTIONID\_TOOLTIP|  |
|linkClicked/linkId|int|SR\_RESTRICTION\_LINK: SR\_RESTRICTION\_LINK|  |
|linkClicked/shipmentId|int|SR\_ARCHIVE\_MAILING\_ID: SR\_ARCHIVE\_MAILING\_ID\_TOOLTIP|  |
|formSubmission/formSubmissionId|int|SR\_FORMSUBMISSIONARCHIVE\_SUBMISSIONID: SR\_FORMSUBMISSIONARCHIVE\_SUBMISSIONID\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|formSubmission/formSubmissionFormId|int|SR\_FORMSUBMISSIONARCHIVE\_FORMID: SR\_FORMSUBMISSIONARCHIVE\_FORMID\_TOOLTIP| x |
|formSubmission/formSubmissionName|string|SR\_FORMS\_FORM: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|formSubmission/formSubmissionStatus|listAny|SR\_FORMSUBMISSION\_STATUS: SR\_FORMSUBMISSION\_STATUS\_TOOLTIP| x |
|formSubmission/formSubmissionEmail|string|SR\_FORMSUBMISSION\_EMAIL: SR\_FORMSUBMISSION\_EMAIL\_TOOLTIP| x |
|formSubmission/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|formSubmission/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|formSubmission/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|formSubmission/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|formSubmission/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|formSubmission/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|formSubmission/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|formSubmission/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|formSubmission/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|formSubmission/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|formSubmission/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|formSubmission/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|formSubmission/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|workflowInstance/workflowInstanceId|int|SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_ID: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_ID\_TOOLTIP| x |
|workflowInstance/workflowInstanceStatus|listAny|SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_STATUS: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_STATUS\_TOOLTIP| x |
|workflowInstance/workflowInstanceWaitUntil|date|SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_WAITUNTIL: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_WAITUNTIL\_TOOLTIP| x |
|workflowInstance/workflowInstanceStepStarted|date|SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_STEPSTARTED: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_STEPSTARTED\_TOOLTIP| x |
|workflowInstance/workflowInstanceCurrentStepDescription| *None* |SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_CURRENTSTEPDESCRIPTION: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_CURRENTSTEPDESCRIPTION\_TOOLTIP|  |
|workflowInstance/workflowInstanceCurrentStepId| *None* |!!workflowInstanceCurrentStepId: !!workflowInstanceCurrentStepId\_TOOLTIP|  |
|workflowInstance/workflowInstanceLastCommunicationStepDescription| *None* |SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_LASTCOMMUNICATIONSTEPDESCRIPTION: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_LASTCOMMUNICATIONSTEPDESCRIPTION\_TOOLTIP|  |
|workflowInstance/workflowInstanceDropoutReason| *None* |SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_DROPOUTREASON: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_DROPOUTREASON\_TOOLTIP|  |
|workflowInstance/workflowInstanceLastCommunicationBounceInfo| *None* |SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_LASTCOMMUNICATIONBOUNCEINFO: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_LASTCOMMUNICATIONBOUNCEINFO\_TOOLTIP|  |
|workflowInstance/workflowInstanceLastCommunicationTime|datetime|SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_LASTCOMMUNICATIONTIME: SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_LASTCOMMUNICATIONTIME\_TOOLTIP| x |
|workflowInstance/workflowInstanceLastCommunicationStatus|listAny|SR\_ARCHIVE\_EMAILFLOW\_INSTANCE\_RESPONSELASTEMAIL: SR\_ARCHIVE\_RECIPIENT\_STATUS\_TOOLTIP| x |
|workflowInstance/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|workflowInstance/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|workflowInstance/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|workflowInstance/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|workflowInstance/emailFlow/emailFlowId|int|SR\_ARCHIVE\_EMAILFLOW\_ID: SR\_ARCHIVE\_EMAILFLOW\_ID\_TOOLTIP| x |
|workflowInstance/emailFlow/emailFlowHierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|workflowInstance/emailFlow/shipmentType|listAny|SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE: SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE\_TOOLTIP| x |
|workflowInstance/emailFlow/overrideConsentSubscription|bool|SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION: SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION\_TOOLTIP| x |
|workflowInstance/emailFlow/thumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|workflowInstance/emailFlow/mediumThumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|workflowInstance/emailFlow/workflowId|int|SR\_ARCHIVE\_WORKFLOW\_ID: SR\_ARCHIVE\_WORKFLOW\_ID\_TOOLTIP| x |
|workflowInstance/emailFlow/workflowName|string|SR\_ARCHIVE\_WORKFLOW\_NAME: SR\_ARCHIVE\_WORKFLOW\_NAME\_TOOLTIP| x |
|workflowInstance/emailFlow/workflowDescription|string|SR\_ARCHIVE\_WORKFLOW\_DESC: SR\_ARCHIVE\_WORKFLOW\_DESC\_TOOLTIP| x |
|workflowInstance/emailFlow/workflowDefinitionStatus|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|workflowInstance/emailFlow/workflowDefinitionStatusId|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|workflowInstance/emailFlow/jumpToFinish|bool|SR\_ARCHIVE\_WORKFLOW\_JUMP\_TO\_FINISH: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_JUMP\_TO\_FINISH\_TOOLTIP| x |
|workflowInstance/emailFlow/startOnlyOnce|bool|SR\_ARCHIVE\_WORKFLOW\_START\_ONLY\_ONCE: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_START\_ONLY\_ONCE\_TOOLTIP| x |
|workflowInstance/emailFlow/workflowEnrolledCount| *None* |SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT\_TOOLTIP|  |
|workflowInstance/emailFlow/workflowInProgressCount| *None* |SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT: SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT\_TOOLTIP|  |
|workflowInstance/emailFlow/workflowCompletedCount| *None* |SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT\_TOOLTIP|  |
|workflowInstance/emailFlow/workflowSucceededCount| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT\_TOOLTIP|  |
|workflowInstance/emailFlow/workflowSuccessRate| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE: SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE\_TOOLTIP|  |
|workflowInstance/emailFlow/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|workflowInstance/emailFlow/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|workflowInstance/emailFlow/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|workflowInstance/emailFlow/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|chatSession/chatSessionId|int|SR\_CHATARCHIVE\_SESSIONID: SR\_CHATARCHIVE\_SESSIONID\_TOOLTIP| x |
|chatSession/firstMessage|string|SR\_CHATARCHIVE\_FIRSTMESSAGE: SR\_CHATARCHIVE\_FIRSTMESSAGE\_TOOLTIP| x |
|chatSession/lastMessage|string|SR\_CHATARCHIVE\_LASTMESSAGE: SR\_CHATARCHIVE\_LASTMESSAGE\_TOOLTIP| x |
|chatSession/whenRequested|datetime|SR\_CHATARCHIVE\_WHENREQUESTED: SR\_CHATARCHIVE\_WHENREQUESTED\_TOOLTIP| x |
|chatSession/whenStarted|datetime|SR\_CHATARCHIVE\_WHENSTARTED: SR\_CHATARCHIVE\_WHENSTARTED\_TOOLTIP| x |
|chatSession/whenEnded|datetime|SR\_CHATARCHIVE\_WHENENDED: SR\_CHATARCHIVE\_WHENENDED\_TOOLTIP| x |
|chatSession/duration|timeSpan|SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|chatSession/timeInQueue|timeSpan|SR\_CHATARCHIVE\_TIMINQUEUE: SR\_CHATARCHIVE\_TIMINQUEUE\_TOOLTIP| x |
|chatSession/queueLength|int|SR\_CHATARCHIVE\_QUEUE\_LENGTH: SR\_CHATARCHIVE\_QUEUE\_LENGTH\_TOOLTIP| x |
|chatSession/rating|int|SR\_CHATARCHIVE\_RATING: SR\_CHATARCHIVE\_RATING\_TOOLTIP| x |
|chatSession/agent|ejUser|SR\_CHAT\_AGENT: SR\_CHAT\_AGENT\_TOOLTIP| x |
|chatSession/status|listAny|SR\_CHAT\_STATUS: SR\_CHAT\_STATUS\_TOOLTIP| x |
|chatSession/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|chatSession/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|chatSession/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|chatSession/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|chatSession/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|chatSession/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|chatSession/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|chatSession/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|chatSession/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|chatSession/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|chatSession/chatTopic/chatTopicId|int|SR\_CHATARCHIVE\_CHANNEL\_ID: SR\_CHATARCHIVE\_CHANNEL\_ID\_TOOLTIP| x |
|chatSession/chatTopic/name|string|SR\_CHATARCHIVE\_CHANNEL\_NAME: SR\_CHATARCHIVE\_CHANNEL\_NAME| x |
|chatSession/chatTopic/description|string|SR\_CHATARCHIVE\_CHANNEL\_DESCRIPTION: SR\_CHATARCHIVE\_CHANNEL\_DESCRIPTION\_TOOLTIP| x |
|chatSession/chatTopic/badgeHeader|string|SR\_CHATARCHIVE\_CHANNEL\_BADGEHEADER: SR\_CHATARCHIVE\_CHANNEL\_BADGEHEADER\_TOOLTIP| x |
|sale/quote/quoteId|int|SR\_QUOTE\_QUOTE\_ID: SR\_QUOTE\_QUOTE\_ID\_TOOLTIP| x |
|sale/quote/poNumber|string|SR\_QUOTE\_QUOTE\_PONUMBER: SR\_QUOTE\_QUOTE\_PONUMBER\_TOOLTIP| x |
|sale/quote/orderComment|string|SR\_QUOTE\_QUOTE\_ORDERCOMMENT: SR\_QUOTE\_QUOTE\_ORDERCOMMENT\_TOOLTIP| x |
|sale/quote/connectionId|int|SR\_QUOTE\_CONNECTIONID: SR\_QUOTE\_CONNECTIONID\_TOOLTIP| x |
|sale/quote/registeredDate|date|SR\_QUOTE\_QUOTE\_REGISTERED: SR\_QUOTE\_QUOTE\_REGISTERED\_TOOLTIP| x |
|sale/quote/version/quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP| x |
|sale/quote/version/description|string|SR\_QUOTE\_QUOTEVERSION\_DESCRIPTION: SR\_QUOTE\_QUOTEVERSION\_DESCRIPTION\_TOOLTIP| x |
|sale/quote/version/number|string|SR\_QUOTE\_QUOTEVERSION\_NUMBER: SR\_QUOTE\_QUOTEVERSION\_NUMBER\_TOOLTIP| x |
|sale/quote/version/sent|date|SR\_QUOTE\_QUOTEVERSION\_SENT: SR\_QUOTE\_QUOTEVERSION\_SENT\_TOOLTIP| x |
|sale/quote/version/expiration|date|SR\_QUOTE\_QUOTEVERSION\_EXPIRATION: SR\_QUOTE\_QUOTEVERSION\_EXPIRATION\_TOOLTIP| x |
|sale/quote/version/state|listAny|SR\_QUOTE\_QUOTEVERSION\_STATE: SR\_QUOTE\_QUOTEVERSION\_STATE\_TOOLTIP| x |
|sale/quote/version/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|sale/quote/version/reason|string|SR\_QUOTE\_QUOTELINE\_QUOTEREASON: SR\_QUOTE\_QUOTELINE\_QUOTEREASON\_TOOLTIP| x |
|sale/quote/version/paymentTerms|listExternal|SR\_QUOTE\_QUOTEVERSION\_PAYMENTTERMS: SR\_QUOTE\_QUOTEVERSION\_PAYMENTTERMS\_TOOLTIP|  |
|sale/quote/version/paymentType|listExternal|SR\_QUOTE\_QUOTEVERSION\_PAYMENTTYPE: SR\_QUOTE\_QUOTEVERSION\_PAYMENTTYPE\_TOOLTIP|  |
|sale/quote/version/deliveryTerms|listExternal|SR\_QUOTE\_QUOTEVERSION\_DELIVERYTERMS: SR\_QUOTE\_QUOTEVERSION\_DELIVERYTERMS\_TOOLTIP|  |
|sale/quote/version/deliveryType|listExternal|SR\_QUOTE\_QUOTEVERSION\_DELIVERYTYPE: SR\_QUOTE\_QUOTEVERSION\_DELIVERYTYPE\_TOOLTIP|  |
|sale/quote/version/approvedBy|associate|SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY\_TOOLTIP| x |
|sale/quote/version/approvalRegisteredBy|associate|SR\_QUOTE\_QUOTEVERSION\_APPROVALREGISTEREDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVALREGISTEREDBY\_TOOLTIP| x |
|sale/quote/version/approvedText|string|SR\_QUOTE\_QUOTEVERSION\_APPROVEDTEXT: SR\_QUOTE\_QUOTEVERSION\_APPROVEDTEXT\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/quote/version/approvedDate|date|SR\_QUOTE\_QUOTEVERSION\_APPROVEDDATE: SR\_QUOTE\_QUOTEVERSION\_APPROVEDDATE\_TOOLTIP| x |
|sale/quote/version/extraField1|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD1: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD1\_TOOLTIP| x |
|sale/quote/version/extraField2|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD2: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD2\_TOOLTIP| x |
|sale/quote/version/extraField3|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD3: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD3\_TOOLTIP| x |
|sale/quote/version/extraField4|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD4: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD4\_TOOLTIP| x |
|sale/quote/version/extraField5|string|SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD5: SR\_QUOTE\_QUOTEVERSION\_EXTRAFIELD5\_TOOLTIP| x |
|sale/quote/version/alternative/quoteAlternativeId|int|SR\_QUOTE\_QUOTEALTERNATIVE\_ID: SR\_QUOTE\_QUOTEALTERNATIVE\_ID\_TOOLTIP| x |
|sale/quote/version/alternative/quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP| x |
|sale/quote/version/alternative/name|string|SR\_QUOTE\_QUOTEALTERNATIVE\_NAME: SR\_QUOTE\_QUOTEALTERNATIVE\_NAME\_TOOLTIP| x |
|sale/quote/version/alternative/description|string|SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION: SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION\_TOOLTIP| x |
|sale/quote/version/alternative/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|sale/quote/version/alternative/reason|string|SR\_QUOTE\_QUOTELINE\_QUOTEREASON: SR\_QUOTE\_QUOTELINE\_QUOTEREASON\_TOOLTIP| x |
|sale/quote/version/alternative/erpDiscountPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTPERCENT\_TOOLTIP| x |
|sale/quote/version/alternative/erpDiscountAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_ERPDISCOUNTAMOUNT\_TOOLTIP| x |
|sale/quote/version/alternative/discountPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTPERCENT\_TOOLTIP| x |
|sale/quote/version/alternative/discountAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_DISCOUNTAMOUNT\_TOOLTIP| x |
|sale/quote/version/alternative/vatInfo|string|SR\_QUOTE\_QUOTEALTERNATIVE\_VATINFO: SR\_QUOTE\_QUOTEALTERNATIVE\_VATINFO\_TOOLTIP| x |
|sale/quote/version/alternative/vat|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_VAT: SR\_QUOTE\_QUOTEALTERNATIVE\_VAT\_TOOLTIP| x |
|sale/quote/version/alternative/earningPercent|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSPERCENT: SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSPERCENT\_TOOLTIP| x |
|sale/quote/version/alternative/earningAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSAMOUNT: SR\_QUOTE\_QUOTEALTERNATIVE\_EARNINGSAMOUNT\_TOOLTIP| x |
|sale/quote/version/alternative/totalPrice|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTAL: SR\_QUOTE\_QUOTEALTERNATIVE\_TOTAL\_TOOLTIP| x |
|sale/quote/version/alternative/extraField1|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD1: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD1\_TOOLTIP| x |
|sale/quote/version/alternative/extraField2|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD2: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD2\_TOOLTIP| x |
|sale/quote/version/alternative/extraField3|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD3: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD3\_TOOLTIP| x |
|sale/quote/version/alternative/extraField4|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD4: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD4\_TOOLTIP| x |
|sale/quote/version/alternative/extraField5|string|SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD5: SR\_QUOTE\_QUOTEALTERNATIVE\_EXTRAFIELD5\_TOOLTIP| x |
|sale/quote/version/alternative/alternativeOrdering|int|SR\_QUOTE\_QUOTEALTERNATIVE\_ID: SR\_QUOTE\_QUOTEALTERNATIVE\_ID\_TOOLTIP| x |
|sale/quote/version/alternative/subTotal|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_SUBTOTAL: SR\_QUOTE\_QUOTEALTERNATIVE\_SUBTOTAL\_TOOLTIP| x |
|sale/quote/version/alternative/totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ALTTOTINCVAT: SR\_QUOTE\_QUOTEALTERNATIVE\_ALTTOTINCVAT\_TOOLTIP| x |
|sale/quote/version/alternative/vatAmount|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_ALTVATAMT: SR\_QUOTE\_QUOTEALTERNATIVE\_ALTVATAMT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/quoteLineId|int|SR\_QUOTE\_QUOTELINE\_QUOTELINEID: SR\_QUOTE\_QUOTELINE\_QUOTELINEID\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/quoteAlternativeId|int|SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID: SR\_QUOTE\_QUOTELINE\_QUOTEALTERNATIVEID\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/erpProductKey|string|SR\_QUOTE\_QUOTELINE\_PRODUCTKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTKEY\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/rank|int|SR\_QUOTE\_QUOTELINE\_RANK: SR\_QUOTE\_QUOTELINE\_RANK\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/quantity|decimal|SR\_QUOTE\_QUOTELINE\_QUANTITY: SR\_QUOTE\_QUOTELINE\_QUANTITY\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/name|string|SR\_QUOTE\_QUOTELINE\_NAME: SR\_QUOTE\_QUOTELINE\_NAME\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/description|string|SR\_QUOTE\_QUOTELINE\_DESCRIPTION: SR\_QUOTE\_QUOTELINE\_DESCRIPTION\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/code|string|SR\_QUOTE\_QUOTELINE\_CODE: SR\_QUOTE\_QUOTELINE\_CODE\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/quantityUnit|string|SR\_QUOTE\_QUOTELINE\_UNIT: SR\_QUOTE\_QUOTELINE\_UNIT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/priceUnit|string|SR\_QUOTE\_QUOTELINE\_PRICEUNIT: SR\_QUOTE\_QUOTELINE\_PRICEUNIT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/url|string|SR\_QUOTE\_QUOTELINE\_URL: SR\_QUOTE\_QUOTELINE\_URL\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/subscriptionUnit|string|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONUNIT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/subscriptionQuantity|decimal|SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY: SR\_QUOTE\_QUOTELINE\_SUBSCRIPTIONQUANTITY\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/UnitListPriceSubscriptionQuantity| *None* |SR\_SUBSCRIPTIONLISTPRICE: SR\_SUBSCRIPTIONLISTPRICE\_TOOLTIP|  |
|sale/quote/version/alternative/quoteline/PriceUnitSubscriptionUnit| *None* |SR\_PRICESUBUNIT: SR\_PRICESUBUNIT\_TOOLTIP|  |
|sale/quote/version/alternative/quoteline/PriceUnitSubscriptionQuantityUnit| *None* |SR\_EXPANDEDUNIT: SR\_EXPANDEDUNIT\_TOOLTIP|  |
|sale/quote/version/alternative/quoteline/vatInfo|string|SR\_QUOTE\_QUOTELINE\_VATINFO: SR\_QUOTE\_QUOTELINE\_VATINFO\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/vat|decimal|SR\_QUOTE\_QUOTELINE\_VAT: SR\_QUOTE\_QUOTELINE\_VAT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/unitCost|decimal|SR\_QUOTE\_QUOTELINE\_UNITCOST: SR\_QUOTE\_QUOTELINE\_UNITCOST\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/unitMinimumPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE: SR\_QUOTE\_QUOTELINE\_UNITMINIMUMPRICE\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/unitListPrice|decimal|SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE: SR\_QUOTE\_QUOTELINE\_UNITLISTPRICE\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/totalPrice|decimal|SR\_QUOTE\_QUOTELINE\_TOTALPRICE: SR\_QUOTE\_QUOTELINE\_TOTALPRICE\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/totalCost|decimal|SR\_QUOTE\_QUOTEALTERNATIVE\_TOTALCOST|  |
|sale/quote/version/alternative/quoteline/quoteLineThumbnail| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|sale/quote/version/alternative/quoteline/quoteLineThumbnailLarge| *None* |SR\_QUOTE\_QUOTELINE\_THUMBNAIL: SR\_QUOTE\_QUOTELINE\_THUMBNAIL\_TOOLTIP|  |
|sale/quote/version/alternative/quoteline/discountAmount|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT: SR\_QUOTE\_QUOTELINE\_DISCOUNTAMOUNT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/discountPercent|decimal|SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT: SR\_QUOTE\_QUOTELINE\_DISCOUNTPERCENT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/earningAmount|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT: SR\_QUOTE\_QUOTELINE\_EARNINGAMOUNT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/earningPercent|decimal|SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT: SR\_QUOTE\_QUOTELINE\_EARNINGPERCENT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/productCategoryKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTCATEGORYKEY\_TOOLTIP|  |
|sale/quote/version/alternative/quoteline/productFamilyKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTFAMILYKEY\_TOOLTIP|  |
|sale/quote/version/alternative/quoteline/productTypeKey|listExternal|SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY: SR\_QUOTE\_QUOTELINE\_PRODUCTTYPEKEY\_TOOLTIP|  |
|sale/quote/version/alternative/quoteline/status|listAny|SR\_QUOTE\_QUOTELINE\_QUOTESTATUS: SR\_QUOTE\_QUOTELINE\_QUOTESTATUS\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/subTotal|decimal|SR\_QUOTE\_QUOTELINE\_SUBTOTAL: SR\_QUOTE\_QUOTELINE\_SUBTOTAL\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/vatAmount|decimal|SR\_QUOTE\_QUOTELINE\_VATAMNT: SR\_QUOTE\_QUOTELINE\_VATAMNT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/totalPriceIncVAT|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCVAT: SR\_QUOTE\_QUOTELINE\_TOTINCVAT\_TOOLTIP| x |
|sale/quote/version/alternative/quoteline/totalPriceWithAlternativeDiscount|decimal|SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS: SR\_QUOTE\_QUOTELINE\_TOTINCALTDIS\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/ContactPersonDynamicSelectionSingleCriteriaGroup?$select=contactPhone/description,sale/associate/locationAddress,appointment/associate/middleName,personExtra/x_person_category_relation,personSourceRelation/createdByForm
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


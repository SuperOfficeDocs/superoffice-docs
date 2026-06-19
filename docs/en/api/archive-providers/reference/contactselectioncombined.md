---
uid: ContactSelectionCombined
title: ContactSelectionCombined
description: Implementation of the provider for the combined selection
keywords: ContactSelectionCombined archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ContactSelectionCombined"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SelectionCombinedProvider">SuperOffice.CRM.ArchiveLists.SelectionCombinedProvider</see> inside NetServer's SODatabase assembly.

Implementation of the provider for the combined selection

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
|contactFax/description| *None* |SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
|searchPhone/formattedNumber| *None* |SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|searchPhone/description| *None* |SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP|  |
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
|sourceRelation/contactId| *None* |SR\_RELATION\_SOURCE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|sourceRelation/name| *None* |SR\_RELATION\_SOURCE - SR\_COMPANY\_NAME|  |
|sourceRelation/department| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DEPARTEMENT|  |
|sourceRelation/nameDepartment| *None* |SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|sourceRelation/hasInfoText| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|sourceRelation/hasInterests| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|sourceRelation/associateId| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|sourceRelation/category| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY|  |
|sourceRelation/categoryGroup| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|sourceRelation/companyCategoryRank| *None* |SR\_RELATION\_SOURCE - Category rank|  |
|sourceRelation/business| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BUSINESS|  |
|sourceRelation/country| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|sourceRelation/countryId| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|sourceRelation/number| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_NUMBER|  |
|sourceRelation/code| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CODE|  |
|sourceRelation/orgnr| *None* |SR\_RELATION\_SOURCE - VAT No.|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sourceRelation/stop| *None* |SR\_RELATION\_SOURCE - SR\_CC\_STOPX|  |
|sourceRelation/contactNoMail| *None* |SR\_RELATION\_SOURCE - SR\_NO\_MAIL\_COMPANY|  |
|sourceRelation/updatedBy| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|sourceRelation/updatedByFullName| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|sourceRelation/updatedDate| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|sourceRelation/registeredBy| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|sourceRelation/registeredByFullName| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|sourceRelation/registeredDate| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|sourceRelation/contactSource| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|sourceRelation/contactDeleted| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|sourceRelation/activeErpLinks| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|sourceRelation/deletedDate| *None* |SR\_RELATION\_SOURCE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|sourceRelation/mainContact| *None* |SR\_RELATION\_SOURCE - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|sourceRelation/forceCompany| *None* |SR\_RELATION\_SOURCE - Dummy: Dummy|  |
|sourceRelation/restrictionContactId| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|sourceRelation/who| *None* |SR\_RELATION\_SOURCE - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP|  |
|sourceRelation/csRelation| *None* |SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_COMPANY\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP|  |
|targetRelation/contactId| *None* |SR\_RELATION\_TARGET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|targetRelation/name| *None* |SR\_RELATION\_TARGET - SR\_COMPANY\_NAME|  |
|targetRelation/department| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_DEPARTEMENT|  |
|targetRelation/nameDepartment| *None* |SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|targetRelation/hasInfoText| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|targetRelation/hasInterests| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|targetRelation/associateId| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|targetRelation/category| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY|  |
|targetRelation/categoryGroup| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|targetRelation/companyCategoryRank| *None* |SR\_RELATION\_TARGET - Category rank|  |
|targetRelation/business| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BUSINESS|  |
|targetRelation/country| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP|  |
|targetRelation/countryId| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|targetRelation/number| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_NUMBER|  |
|targetRelation/code| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CODE|  |
|targetRelation/orgnr| *None* |SR\_RELATION\_TARGET - VAT No.|  |
|targetRelation/stop| *None* |SR\_RELATION\_TARGET - SR\_CC\_STOPX|  |
|targetRelation/contactNoMail| *None* |SR\_RELATION\_TARGET - SR\_NO\_MAIL\_COMPANY|  |
|targetRelation/updatedBy| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|targetRelation/updatedByFullName| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|targetRelation/updatedDate| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|targetRelation/registeredBy| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|targetRelation/registeredByFullName| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|targetRelation/registeredDate| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|targetRelation/contactSource| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)|  |
|targetRelation/contactDeleted| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED|  |
|targetRelation/activeErpLinks| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|targetRelation/deletedDate| *None* |SR\_RELATION\_TARGET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|targetRelation/mainContact| *None* |SR\_RELATION\_TARGET - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|targetRelation/forceCompany| *None* |SR\_RELATION\_TARGET - Dummy: Dummy|  |
|targetRelation/restrictionContactId| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|targetRelation/who| *None* |SR\_RELATION\_TARGET - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP|  |
|targetRelation/csRelation| *None* |SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_COMPANY\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP|  |
|sourceRelation/contactPersonRelation| *None* |SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_COMPANY\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP|  |
|targetRelation/personContactRelation| *None* |SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_PERSON\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP|  |
|sale/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|sale/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|sale/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|sale/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|sale/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|sale/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|sale/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|sale/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|sale/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|sale/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sale/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|sale/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|sale/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|sale/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|sale/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|sale/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|sale/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|sale/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|sale/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|sale/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|sale/currencyId| *None* |SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP|  |
|sale/currency| *None* |SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP|  |
|sale/credited| *None* |SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP|  |
|sale/lossReason| *None* |SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP|  |
|sale/source| *None* |SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP|  |
|sale/competitor| *None* |SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP|  |
|sale/heading| *None* |SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP|  |
|sale/amount| *None* |SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|sale/amountWeighted| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|sale/earning| *None* |SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP|  |
|sale/earningPercent| *None* |SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP|  |
|sale/probPercent| *None* |SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP|  |
|sale/originalStage| *None* |SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED|  |
|sale/stage| *None* |SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|sale/stageName| *None* |SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|sale/saleStatus| *None* |SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP|  |
|sale/stageRank| *None* |SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP|  |
|sale/saleType| *None* |SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|sale/saleTypeId| *None* |SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP|  |
|sale/stageId| *None* |SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP|  |
|sale/nextDueDate| *None* |SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP|  |
|sale/reopenDate| *None* |SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP|  |
|sale/stalledComment| *None* |SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP|  |
|sale/saleTypeCategory| *None* |SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT|  |
|sale/soldReason| *None* |SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP|  |
|sale/saleNumber| *None* |SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER|  |
|sale/hasStakeholders| *None* |SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP|  |
|sale/stakeholdersEnabled| *None* |SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|sale/hasQuote| *None* |SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP|  |
|sale/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|sale/description| *None* |SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |
|sale/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|sale/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|sale/amountInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP|  |
|sale/amountWeightedInBaseCurrency| *None* |SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP|  |
|sale/daysInStage| *None* |SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP|  |
|sale/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|sale/sale/textId| *None* |Text ID|  |
|sale/sale/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|sale/salePublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|sale/salePublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|sale/salePublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|sale/salePublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|sale/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|sale/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|sale/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|sale/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|sale/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|sale/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|sale/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|sale/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|sale/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|sale/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|sale/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|sale/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|sale/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|sale/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|sale/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|sale/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|sale/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|sale/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|sale/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|sale/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|sale/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|sale/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|sale/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|sale/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|sale/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|sale/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|sale/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|sale/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|sale/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|sale/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|sale/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|sale/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|sale/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|sale/saleUdef/SuperOffice:1| *None* |saleshorttext|  |
|sale/saleUdef/SuperOffice:2| *None* |salelongtext|  |
|sale/saleUdef/SuperOffice:3| *None* |salenumber|  |
|sale/saleUdef/SuperOffice:4| *None* |saledate|  |
|sale/saleUdef/SuperOffice:5| *None* |saleunlimiteddate|  |
|sale/saleUdef/SuperOffice:6| *None* |salecheckbox|  |
|sale/saleUdef/SuperOffice:7| *None* |saledropdownlistbox|  |
|sale/saleUdef/SuperOffice:8| *None* |saledecimal|  |
|appointment/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|appointment/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|appointment/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|appointment/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|appointment/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|appointment/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|appointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|appointment/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|appointment/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointment/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|appointment/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|appointment/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|appointment/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|appointment/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointment/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|appointment/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|appointment/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointment/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|appointment/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|appointment/appointmentId| *None* |SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP|  |
|appointment/endDate| *None* |SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP|  |
|appointment/priority| *None* |SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP|  |
|appointment/alarm| *None* |SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP|  |
|appointment/isFree| *None* |SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP|  |
|appointment/recurring| *None* |SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP|  |
|appointment/booking| *None* |SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP|  |
|appointment/intention| *None* |SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP|  |
|appointment/location| *None* |SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP|  |
|appointment/recurrenceRuleId| *None* |SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP|  |
|appointment/rawType| *None* |SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP|  |
|appointment/rawStatus| *None* |SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP|  |
|appointment/cautionWarning| *None* |SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP|  |
|appointment/visibleInDiary| *None* |SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP|  |
|appointment/endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|appointment/suggestedAppointmentId| *None* |SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP|  |
|appointment/completedDate| *None* |SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP|  |
|appointment/isMilestone| *None* |SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP|  |
|appointment/invitedPersonId| *None* |SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP|  |
|appointment/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP|  |
|appointment/joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP|  |
|appointment/duration| *None* |SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|appointment/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|appointment/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|appointment/appointmentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|appointment/appointmentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|appointment/appointmentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|appointment/appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|appointment/appointmentUdef/SuperOffice:1| *None* |followupshorttext|  |
|appointment/appointmentUdef/SuperOffice:2| *None* |followuplongtext|  |
|appointment/appointmentUdef/SuperOffice:3| *None* |followupnumber|  |
|appointment/appointmentUdef/SuperOffice:4| *None* |followupdate|  |
|appointment/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate|  |
|appointment/appointmentUdef/SuperOffice:6| *None* |followupcheckbox|  |
|appointment/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox|  |
|appointment/appointmentUdef/SuperOffice:8| *None* |followupdecimal|  |
|appointment/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|appointment/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|appointment/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|appointment/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|appointment/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|appointment/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|appointment/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointment/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|appointment/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|appointment/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|appointment/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|appointment/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointment/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|appointment/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|appointment/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|appointment/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|appointment/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|appointment/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|appointment/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|appointment/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|appointment/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|appointment/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|appointment/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|appointment/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|appointment/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|appointment/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|appointment/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|appointment/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|appointment/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|appointment/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|appointment/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|appointment/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|appointment/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|appointment/appointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/appointment/description| *None* |SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/appointment/title| *None* |SR\_TICKETARCHIVE\_TITLE|  |
|appointment/appointment/titleHtml| *None* |!!Title Html|  |
|appointment/appointment/agenda| *None* |SR\_APPOINTMENT\_AGENDA|  |
|appointment/appointment/agendaHtml| *None* |!!Agenda Html|  |
|appointment/appointment/isConverted| *None* |!!Is Converted|  |
|appointment/appointment/textId| *None* |Text ID|  |
|appointment/appointment/internalNotes| *None* |SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|appointment/appointment/internalNotesHtml| *None* |!!Internal Notes Html|  |
|document/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|document/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|document/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |
|document/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|document/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|document/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|document/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|document/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|document/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|document/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|document/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|document/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|document/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|document/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|document/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|document/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|document/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|document/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|document/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|document/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|document/documentId| *None* |SR\_DOCUMENT\_ID: SR\_DOCUMENT\_ID\_TOOLTIP|  |
|document/keywords| *None* |SR\_KEYWORDS|  |
|document/ourref| *None* |SR\_AA\_OURREF|  |
|document/yourref| *None* |SR\_ARCHIVE\_YOURREF|  |
|document/attention| *None* |SR\_ARCHIVE\_SALUTATION|  |
|document/subject| *None* |SR\_COMMON\_SUBJECT|  |
|document/name| *None* |SR\_FILENAME|  |
|document/mailMergeDraft| *None* |SR\_MAILMERGEDRAFT: SR\_DOCUMENT\_MMD\_TOOLTIP|  |
|document/snum| *None* |SR\_ARCHIVE\_DOCUMENT\_SNUM: SR\_ARCHIVE\_DOCUMENT\_SNUM\_TOOLTIP|  |
|document/isReport| *None* |SR\_DOCUMENTISREPORT: SR\_DOCUMENTISREPORT\_TOOLTIP|  |
|document/suggestedDocumentId| *None* |SR\_ARCHIVE\_SUGGESTEDDOCID: SR\_ARCHIVE\_SUGGESTEDDOCID\_TOOLTIP|  |
|document/isMail| *None* |SR\_SINGULAR\_MAIL|  |
|document/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP|  |
|document/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|document/documentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|document/documentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|document/documentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|document/documentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|document/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|document/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|document/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|document/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|document/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|document/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|document/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|document/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|document/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|document/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|document/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|document/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|document/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|document/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|document/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|document/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|document/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|document/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|document/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|document/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|document/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|document/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|document/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|document/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|document/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|document/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|document/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|document/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|document/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|document/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|document/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|document/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|document/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|document/documentUdef/SuperOffice:1| *None* |documentshorttext|  |
|document/documentUdef/SuperOffice:2| *None* |documentlongtext|  |
|document/documentUdef/SuperOffice:3| *None* |documentnumber|  |
|document/documentUdef/SuperOffice:4| *None* |documentdate|  |
|document/documentUdef/SuperOffice:5| *None* |documentunlimiteddate|  |
|document/documentUdef/SuperOffice:6| *None* |documentcheckbox|  |
|document/documentUdef/SuperOffice:7| *None* |documentdropdownlistbox|  |
|document/documentUdef/SuperOffice:8| *None* |documentdecimal|  |
|document/document/textId| *None* |Text ID|  |
|document/document/description| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
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
|fullNameWithContact| *None* |SR\_PERSON\_NAMEWITHCONT: SR\_PERSON\_NAMEWITHCONT\_TOOLTIP|  |
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
|personEmail/emailProtocol| *None* |SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|personEmail/emailAddress| *None* |SR\_ARCHIVE\_EMAIL|  |
|personEmail/emailDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|personEmail/emailId| *None* |ID|  |
|personEmail/emailLastSent| *None* |SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|personEmail/emailBounceCount| *None* |SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|personEmail/emailLastBounce| *None* |SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|personEmail/emailHasBounced| *None* |SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|personUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|personUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
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
|personInterestIds| *None* |SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|personSourceRelation/personId| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|personSourceRelation/firstName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|personSourceRelation/lastName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|personSourceRelation/middleName| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|personSourceRelation/fullName| *None* |SR\_RELATION\_SOURCE - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|personSourceRelation/contactId| *None* |SR\_RELATION\_SOURCE - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|personSourceRelation/hasInfoText| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|personSourceRelation/hasInterests| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|personSourceRelation/personHasInterests| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|personSourceRelation/mrMrs| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|personSourceRelation/position| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_POSITION|  |
|personSourceRelation/personNumber| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|personSourceRelation/title| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|personSourceRelation/personCountry| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|personSourceRelation/personCountryId| *None* |SR\_RELATION\_SOURCE - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|personSourceRelation/personNoMail| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|personSourceRelation/rank| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|personSourceRelation/birthdate| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|personSourceRelation/associateType| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|personSourceRelation/useAsMailingAddress| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|personSourceRelation/personSource| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|personSourceRelation/retired| *None* |SR\_RELATION\_SOURCE - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|personSourceRelation/birthYear| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|personSourceRelation/birthMonth| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|personSourceRelation/birthDay| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|personSourceRelation/kanaFirstName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|personSourceRelation/kanaLastName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|personSourceRelation/personUpdatedBy| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personSourceRelation/personUpdatedByFullName| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personSourceRelation/personUpdatedDate| *None* |SR\_RELATION\_SOURCE - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|personSourceRelation/personRegisteredBy| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personSourceRelation/personRegisteredByFullName| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personSourceRelation/personRegisteredDate| *None* |SR\_RELATION\_SOURCE - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|personSourceRelation/portraitThumbnail| *None* |SR\_RELATION\_SOURCE - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personSourceRelation/personActiveErpLinks| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|personSourceRelation/ticketPriority| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|personSourceRelation/supportLanguage| *None* |SR\_RELATION\_SOURCE - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|personSourceRelation/supportAssociate| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|personSourceRelation/supportAssociateFullName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|personSourceRelation/personAssociateId| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personSourceRelation/personAssociateFullName| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personSourceRelation/personCategory| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CATEGORY|  |
|personSourceRelation/personCategoryGroup| *None* |SR\_RELATION\_SOURCE - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|personSourceRelation/personCategoryRank| *None* |SR\_RELATION\_SOURCE - !!Category rank|  |
|personSourceRelation/personBusiness| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_BUSINESS|  |
|personSourceRelation/leadStatus| *None* |SR\_RELATION\_SOURCE - SR\_LABEL\_LEADSTATUS|  |
|personSourceRelation/leadstatusRank| *None* |SR\_RELATION\_SOURCE - !!Lead status RANK|  |
|personSourceRelation/personDeletedDate| *None* |SR\_RELATION\_SOURCE - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|personSourceRelation/hasCompany| *None* |SR\_RELATION\_SOURCE - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|personSourceRelation/isProjectMember| *None* |SR\_RELATION\_SOURCE - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|personSourceRelation/isStakeholder| *None* |SR\_RELATION\_SOURCE - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|personSourceRelation/updatedByWorkflow| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|personSourceRelation/whenUpdatedByWorkflow| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|personSourceRelation/createdByForm| *None* |SR\_RELATION\_SOURCE - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|personSourceRelation/restrictionContactId| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personSourceRelation/restrictionPersonId| *None* |SR\_RELATION\_SOURCE - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personSourceRelation/who| *None* |SR\_RELATION\_SOURCE - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP|  |
|personSourceRelation/personPersonRelation| *None* |SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_PERSON\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP|  |
|personTargetRelation/personId| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP|  |
|personTargetRelation/firstName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|personTargetRelation/lastName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|personTargetRelation/middleName| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|personTargetRelation/fullName| *None* |SR\_RELATION\_TARGET - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|personTargetRelation/contactId| *None* |SR\_RELATION\_TARGET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|personTargetRelation/hasInfoText| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|personTargetRelation/hasInterests| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|personTargetRelation/personHasInterests| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|personTargetRelation/mrMrs| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|personTargetRelation/position| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_POSITION|  |
|personTargetRelation/personNumber| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
|personTargetRelation/title| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP|  |
|personTargetRelation/personCountry| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP|  |
|personTargetRelation/personCountryId| *None* |SR\_RELATION\_TARGET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP|  |
|personTargetRelation/personNoMail| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP|  |
|personTargetRelation/rank| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP|  |
|personTargetRelation/birthdate| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|personTargetRelation/associateType| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|personTargetRelation/useAsMailingAddress| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP|  |
|personTargetRelation/personSource| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)|  |
|personTargetRelation/retired| *None* |SR\_RELATION\_TARGET - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP|  |
|personTargetRelation/birthYear| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP|  |
|personTargetRelation/birthMonth| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP|  |
|personTargetRelation/birthDay| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP|  |
|personTargetRelation/kanaFirstName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP|  |
|personTargetRelation/kanaLastName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP|  |
|personTargetRelation/personUpdatedBy| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personTargetRelation/personUpdatedByFullName| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personTargetRelation/personUpdatedDate| *None* |SR\_RELATION\_TARGET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|personTargetRelation/personRegisteredBy| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personTargetRelation/personRegisteredByFullName| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personTargetRelation/personRegisteredDate| *None* |SR\_RELATION\_TARGET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|personTargetRelation/portraitThumbnail| *None* |SR\_RELATION\_TARGET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personTargetRelation/personActiveErpLinks| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|personTargetRelation/ticketPriority| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|personTargetRelation/supportLanguage| *None* |SR\_RELATION\_TARGET - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|personTargetRelation/supportAssociate| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|personTargetRelation/supportAssociateFullName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
|personTargetRelation/personAssociateId| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personTargetRelation/personAssociateFullName| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personTargetRelation/personCategory| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CATEGORY|  |
|personTargetRelation/personCategoryGroup| *None* |SR\_RELATION\_TARGET - SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
|personTargetRelation/personCategoryRank| *None* |SR\_RELATION\_TARGET - !!Category rank|  |
|personTargetRelation/personBusiness| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_BUSINESS|  |
|personTargetRelation/leadStatus| *None* |SR\_RELATION\_TARGET - SR\_LABEL\_LEADSTATUS|  |
|personTargetRelation/leadstatusRank| *None* |SR\_RELATION\_TARGET - !!Lead status RANK|  |
|personTargetRelation/personDeletedDate| *None* |SR\_RELATION\_TARGET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|personTargetRelation/hasCompany| *None* |SR\_RELATION\_TARGET - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP|  |
|personTargetRelation/isProjectMember| *None* |SR\_RELATION\_TARGET - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP|  |
|personTargetRelation/isStakeholder| *None* |SR\_RELATION\_TARGET - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP|  |
|personTargetRelation/updatedByWorkflow| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW|  |
|personTargetRelation/whenUpdatedByWorkflow| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN|  |
|personTargetRelation/createdByForm| *None* |SR\_RELATION\_TARGET - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM|  |
|personTargetRelation/restrictionContactId| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personTargetRelation/restrictionPersonId| *None* |SR\_RELATION\_TARGET - SR\_RESTRICTION\_RELATIONCONTACT: SR\_RESTRICTION\_RELATIONCONTACT\_TOOLTIP|  |
|personTargetRelation/who| *None* |SR\_RELATION\_TARGET - SR\_RELATION\_FULLNAME: SR\_RELATION\_FULLNAME\_TOOLTIP|  |
|personTargetRelation/personPersonRelation| *None* |SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_PERSON\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP|  |
|personSourceRelation/personContactRelation| *None* |SR\_RELATION\_SOURCE - SR\_CRITERIONTYPE\_PERSON\_COMPANY\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP|  |
|personTargetRelation/contactPersonRelation| *None* |SR\_RELATION\_TARGET - SR\_CRITERIONTYPE\_COMPANY\_PERSON\_RELATION: SR\_RELATION\_RAWNAME\_TOOLTIP|  |
|personAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|personAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|personAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|personAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|personAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|personAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|personAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|personAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|personAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|personAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|personAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|personAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|personAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|personAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|personAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|personAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|personAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|personAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|personAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|personAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|personAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|personAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|personAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|personAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|personAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|personAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|personAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|personAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|personAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|personAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|correspondingAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|correspondingAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|correspondingAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|correspondingAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|correspondingAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|correspondingAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|correspondingAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|correspondingAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|correspondingAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|correspondingAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|correspondingAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|correspondingAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|correspondingAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|correspondingAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|correspondingAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|correspondingAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|correspondingAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|correspondingAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|correspondingAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|correspondingAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|correspondingAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|correspondingAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|correspondingAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|correspondingAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|correspondingAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|correspondingAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|correspondingAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|correspondingAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|correspondingAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|correspondingAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|correspondingAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|correspondingAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|correspondingAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|request/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|request/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|request/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|request/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|request/ticketStatusId| *None* |SR\_TICKET\_STATUS\_ID: SR\_TICKET\_STATUS|  |
|request/priorityId| *None* |SR\_TICKET\_PRIORITY\_ID: SR\_TICKET\_PRIORITY\_ID\_TOOLTIP|  |
|request/categoryId| *None* |SR\_TICKET\_CATEGORY\_ID: SR\_TICKET\_CATEGORY\_ID\_TOOLTIP|  |
|request/ticketTypeName| *None* |SR\_TICKETARCHIVE\_TICKET\_TYPE: SR\_TICKETARCHIVE\_TICKET\_TYPE\_TOOLTIP|  |
|request/ticketStatusName| *None* |SR\_TICKETARCHIVE\_TICKETSTATUS: SR\_TICKETARCHIVE\_TICKETSTATUS\_TOOLTIP|  |
|request/categoryFullName| *None* |SR\_TICKETARCHIVE\_EJCATEGORY: SR\_TICKETARCHIVE\_EJCATEGORY\_TOOLTIP|  |
|request/priorityName| *None* |SR\_TICKETARCHIVE\_PRIORITY: SR\_TICKETARCHIVE\_PRIORITY\_TOOLTIP|  |
|request/ownedBy| *None* |SR\_TICKETARCHIVE\_OWNEDBY: SR\_TICKETARCHIVE\_OWNEDBY\_TOOLTIP|  |
|request/ticketId| *None* |SR\_TICKETARCHIVE\_TICKETID: SR\_TICKETARCHIVE\_TICKETID\_TOOLTIP|  |
|request/title| *None* |SR\_TICKETARCHIVE\_TITLE: SR\_TICKETARCHIVE\_TITLE\_TOOLTIP|  |
|request/createdAt| *None* |SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP|  |
|request/createdDate| *None* |SR\_TICKETARCHIVE\_CREATEDDATE: SR\_TICKETARCHIVE\_CREATEDDATE|  |
|request/lastChanged| *None* |SR\_TICKETARCHIVE\_LASTCHANGED: SR\_TICKETARCHIVE\_LASTCHANGED\_TOOLTIP|  |
|request/author| *None* |SR\_TICKETARCHIVE\_AUTHOR: SR\_TICKETARCHIVE\_AUTHOR\_TOOLTIP|  |
|request/readByOwner| *None* |SR\_TICKETARCHIVE\_READBYOWNER: SR\_TICKETARCHIVE\_READBYOWNER\_TOOLTIP|  |
|request/firstReadByOwner| *None* |SR\_TICKETARCHIVE\_FIRSTREADBYOWNER: SR\_TICKETARCHIVE\_FIRSTREADBYOWNER\_TOOLTIP|  |
|request/firstReadByUser| *None* |SR\_TICKETARCHVE\_FIRSTREADBYUSER: SR\_TICKETARCHVE\_FIRSTREADBYUSER\_TOOLTIP|  |
|request/readByCustomer| *None* |SR\_TICKETARCHIVE\_READBYCUSTOMER: SR\_TICKETARCHIVE\_READBYCUSTOMER\_TOOLTIP|  |
|request/status| *None* |SR\_TICKETARCHIVE\_INTERNAL\_STATUS: SR\_TICKETARCHIVE\_INTERNAL\_STATUS\_TOOLTIP|  |
|request/origin| *None* |SR\_TICKETARCHIVE\_ORIGIN: SR\_TICKETARCHIVE\_ORIGIN|  |
|request/slevel| *None* |SR\_TICKETARCHIVE\_SLEVEL: SR\_TICKETARCHIVE\_SLEVEL|  |
|request/numberOfMessages| *None* |SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES: SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES|  |
|request/numberOfReplies| *None* |SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES: SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES|  |
|request/connectId| *None* |SR\_TICKETARCHIVE\_CONNECTID: SR\_TICKETARCHIVE\_CONNECTID|  |
|request/readStatus| *None* |SR\_TICKETARCHIVE\_READSTATUS: SR\_TICKETARCHIVE\_READSTATUS|  |
|request/realTimeSpentQueue| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE|  |
|request/realTimeSpentExternally| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL|  |
|request/realTimeSpentInternally| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL|  |
|request/timeSpentQueue| *None* |SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE|  |
|request/timeSpentExternally| *None* |SR\_TICKETARCHIVE\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_TIME\_EXTERNAL|  |
|request/timeSpentInternally| *None* |SR\_TICKETARCHIVE\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_TIME\_INTERNAL|  |
|request/timeSpent| *None* |SR\_TICKETARCHIVE\_TIME\_SPENT: SR\_TICKETARCHIVE\_TIME\_SPENT|  |
|request/timeToReply| *None* |SR\_TICKETARCHIVE\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_TIME\_TO\_REPLY|  |
|request/timeToClose| *None* |SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE|  |
|request/realTimeToReply| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY|  |
|request/realTimeToClose| *None* |SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE|  |
|request/repliedAt| *None* |SR\_TICKETARCHIVE\_REPLIED\_AT: SR\_TICKETARCHIVE\_REPLIED\_AT|  |
|request/closedAt| *None* |SR\_TICKETARCHIVE\_CLOSED\_AT: SR\_TICKETARCHIVE\_CLOSED\_AT|  |
|request/activated| *None* |SR\_TICKETARCHIVE\_POSTPONED\_TO: SR\_TICKETARCHIVE\_POSTPONED\_TO|  |
|request/deadline| *None* |SR\_TICKETARCHIVE\_DEADLINE: SR\_TICKETARCHIVE\_DEADLINE|  |
|request/has\_attachment| *None* |SR\_TICKETARCHIVE\_HAS\_ATTACHMENT: SR\_INBOX\_ATTACHMENT\_TOOLTIP|  |
|request/tags| *None* |SR\_TICKETARCHIVE\_TAGS: SR\_TICKETARCHIVE\_TAGS\_TOOLTIP|  |
|request/createdBy| *None* |SR\_TICKETARCHIVE\_CREATEDBY: SR\_TICKETARCHIVE\_CREATEDBY|  |
|request/content| *None* |SR\_ARCHIVE\_CONTENT: SR\_ARCHIVE\_CONTENT\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|request/messageLanguage| *None* |SR\_TICKETARCHIVE\_LANGUAGE: SR\_TICKETARCHIVE\_LANGUAGE\_TOOLTIP|  |
|request/sentimentScore| *None* |SR\_TICKETARCHIVE\_SENTIMENT: SR\_TICKETARCHIVE\_SENTIMENT\_TOOLTIP|  |
|request/sentimentConfidence| *None* |SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE: SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE|  |
|request/suggestedCategory| *None* |SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY: SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY\_TOOLTIP|  |
|request/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|request/createdBy/firstName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|request/createdBy/lastName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|request/createdBy/middleName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|request/createdBy/fullName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|request/createdBy/contactId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|request/createdBy/personId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|request/createdBy/mrMrs| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|request/createdBy/title| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|request/createdBy/associateDbId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|request/createdBy/contactName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|request/createdBy/contactDepartment| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|request/createdBy/usergroup| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|request/createdBy/usergroupId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|request/createdBy/contactFullName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|request/createdBy/contactCategory| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|request/createdBy/role| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|request/createdBy/assocName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|request/createdBy/assocTooltip| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|request/createdBy/assocType| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|request/createdBy/ejUserId| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|request/createdBy/simultaneousEjUser| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|request/createdBy/ejDisplayName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|request/createdBy/ejStatus| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|request/createdBy/credentialType| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|request/createdBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|request/createdBy/isActive| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|request/createdBy/isActiveText| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|request/createdBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|request/createdBy/otherGroups| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|request/createdBy/userName| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|request/createdBy/personEmail| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_EMAIL|  |
|request/createdBy/locationAddress| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|request/createdBy/isLocation| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|request/ownedBy/firstName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|request/ownedBy/lastName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|request/ownedBy/middleName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|request/ownedBy/fullName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|request/ownedBy/contactId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|request/ownedBy/personId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|request/ownedBy/mrMrs| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|request/ownedBy/title| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|request/ownedBy/associateDbId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|request/ownedBy/contactName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|request/ownedBy/contactDepartment| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|request/ownedBy/usergroup| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|request/ownedBy/usergroupId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|request/ownedBy/contactFullName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|request/ownedBy/contactCategory| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|request/ownedBy/role| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|request/ownedBy/assocName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|request/ownedBy/assocTooltip| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|request/ownedBy/assocType| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|request/ownedBy/ejUserId| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|request/ownedBy/simultaneousEjUser| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|request/ownedBy/ejDisplayName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|request/ownedBy/ejStatus| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|request/ownedBy/credentialType| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|request/ownedBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|request/ownedBy/isActive| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|request/ownedBy/isActiveText| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|request/ownedBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|request/ownedBy/otherGroups| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|request/ownedBy/userName| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|request/ownedBy/personEmail| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_EMAIL|  |
|request/ownedBy/locationAddress| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|request/ownedBy/isLocation| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|request/ticketStatus/ticketStatusId| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_ID: SR\_TICKETARCHIVE\_TICKETSTATUS\_ID\_TOOLTIP|  |
|request/ticketStatus/name| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME: SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME\_TOOLTIP|  |
|request/ticketStatus/rank| *None* |SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK: SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK\_TOOLTIP|  |
|request/ticketPriority/ticketPriorityId| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_ID: SR\_TICKETARCHIVE\_PRIORITY\_ID\_TOOLTIP|  |
|request/ticketPriority/name| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_NAME: SR\_TICKETARCHIVE\_PRIORITY\_NAME\_TOOLTIP|  |
|request/ticketPriority/rank| *None* |SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_RANK: SR\_TICKETARCHIVE\_PRIORITY\_RANK\_TOOLTIP|  |
|request/extra/x\_ticket\_integer| *None* |Extra integer: Custom ticket integer. Default 123. External. Show in properties|  |
|request/extra/x\_ticket\_float| *None* |Extra float: Custom float on Request. 2 decimal places|  |
|request/extra/x\_ticket\_longtext| *None* |Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props|  |
|request/extra/x\_ticket\_date| *None* |Extra date: Custom date field on Request. No default value|  |
|request/extra/x\_ticket\_datetime| *None* |Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request|  |
|request/extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.|  |
|request/extra/x\_ticket\_boolean| *None* |Extra boolean: Custom boolean on Ticket.|  |
|request/extra/x\_ticket\_timespan| *None* |Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props|  |
|request/extra/x\_ticket\_short\_text| *None* |Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request|  |
|request/extra/x\_ticket\_shorttext\_list| *None* |Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot|  |
|request/extra/x\_ticket\_timestamp| *None* |Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field|  |
|request/extra/x\_ticket\_project\_relation| *None* |Extra project: Custom project relation on Request|  |
|request/extra/x\_ticket\_faq| *None* |Extra FAQ Relation: Extra FAQ Relation|  |
|request/extra/x\_ticket\_category\_relation| *None* |Extra category relation: Category relation on request|  |
|request/extra/y\_equipment/x\_name| *None* |Equipment - Name: Equpment name custom field. Cannot be null., show in table|  |
|request/extra/y\_car/id| *None* |Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)|  |
|projectMembers/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP|  |
|projectMembers/projectId| *None* |SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP|  |
|projectMembers/name| *None* |SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP|  |
|projectMembers/number| *None* |SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP|  |
|projectMembers/type| *None* |SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP|  |
|projectMembers/status| *None* |SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP|  |
|projectMembers/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|projectMembers/associateId| *None* |SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|projectMembers/hasInfoText| *None* |SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP|  |
|projectMembers/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|projectMembers/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|projectMembers/description| *None* |SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION|  |
|projectMembers/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|projectMembers/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|projectMembers/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|projectMembers/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|projectMembers/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|projectMembers/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|projectMembers/hasGuide| *None* |SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP|  |
|projectMembers/nextMilestone| *None* |SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP|  |
|projectMembers/endDate| *None* |SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP|  |
|projectMembers/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|projectMembers/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|projectMembers/eventId| *None* |SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID|  |
|projectMembers/startDate| *None* |SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP|  |
|projectMembers/function| *None* |SR\_PROJECTMEMBERARCHIVE\_FUNCTION: SR\_PROJECTMEMBERARCHIVE\_FUNCTION\_TOOLTIP|  |
|projectMembers/eventParticipantStatus| *None* |SR\_FIELD\_PROJECT\_MEMBER\_EVENT\_STATUS: SR\_FIELD\_PROJECT\_MEMBER\_EVENT\_STATUS|  |
|projectMembers/projectPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|projectMembers/projectPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|projectMembers/projectPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|projectMembers/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|projectMembers/projectEvent/isExternalEvent| *None* |SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP|  |
|projectMembers/projectEvent/eventDate| *None* |SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP|  |
|projectMembers/projectEvent/hasSignOn| *None* |SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP|  |
|projectMembers/projectEvent/hasSignOff| *None* |SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP|  |
|projectMembers/projectUrl/URLAddress| *None* |SR\_PROJECTARCHIVE\_URL|  |
|projectMembers/projectUrl/URLDescription| *None* |SR\_ARCHIVE\_DESCRIPTION|  |
|projectMembers/projectAssociate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|projectMembers/projectAssociate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|projectMembers/projectAssociate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|projectMembers/projectAssociate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|projectMembers/projectAssociate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|projectMembers/projectAssociate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|projectMembers/projectAssociate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|projectMembers/projectAssociate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|projectMembers/projectAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|projectMembers/projectAssociate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|projectMembers/projectAssociate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|projectMembers/projectAssociate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|projectMembers/projectAssociate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|projectMembers/projectAssociate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|projectMembers/projectAssociate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|projectMembers/projectAssociate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|projectMembers/projectAssociate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|projectMembers/projectAssociate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|projectMembers/projectAssociate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|projectMembers/projectAssociate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|projectMembers/projectAssociate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|projectMembers/projectAssociate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|projectMembers/projectAssociate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|projectMembers/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|projectMembers/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|projectMembers/projectAssociate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|projectMembers/projectAssociate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|projectMembers/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|projectMembers/projectAssociate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|projectMembers/projectAssociate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|projectMembers/projectAssociate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|projectMembers/projectAssociate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|projectMembers/projectAssociate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|projectMembers/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|projectMembers/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|projectMembers/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|projectMembers/projectUdef/SuperOffice:4| *None* |projectdate|  |
|projectMembers/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|projectMembers/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|projectMembers/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|projectMembers/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|projectMembers/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|projectMembers/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
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
|projectMembers/project/textId| *None* |Text ID|  |
|projectMembers/project/infoText| *None* |SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|personAppointment/completed| *None* |SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP|  |
|personAppointment/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP|  |
|personAppointment/date| *None* |SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|personAppointment/time| *None* |SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|personAppointment/type| *None* |SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP|  |
|personAppointment/recordType| *None* |SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|personAppointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|personAppointment/associateId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP|  |
|personAppointment/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|personAppointment/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|personAppointment/projectId| *None* |SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP|  |
|personAppointment/saleId| *None* |SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP|  |
|personAppointment/userGroup| *None* |SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP|  |
|personAppointment/who| *None* |SR\_WHO: SR\_WHO\_TOOLTIP|  |
|personAppointment/updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personAppointment/updatedByFullName| *None* |SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP|  |
|personAppointment/updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|personAppointment/registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personAppointment/registeredByFullName| *None* |SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|personAppointment/registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|personAppointment/appointmentId| *None* |SR\_ACTIVITYARCHIVE\_RECORDID: SR\_ACTIVITYARCHIVE\_RECORDID\_TOOLTIP|  |
|personAppointment/endDate| *None* |SR\_ACTIVITYARCHIVE\_ENDDATE: SR\_ACTIVITYARCHIVE\_ENDDATE\_TOOLTIP|  |
|personAppointment/priority| *None* |SR\_DIARYARCHIVE\_PRIORITY: SR\_DIARYARCHIVE\_PRIORITY\_TOOLTIP|  |
|personAppointment/alarm| *None* |SR\_DIARYARCHIVE\_ALARM: SR\_DIARYARCHIVE\_ALARM\_TOOLTIP|  |
|personAppointment/isFree| *None* |SR\_DIARYARCHIVE\_ISFREE: SR\_DIARYARCHIVE\_ISFREE\_TOOLTIP|  |
|personAppointment/recurring| *None* |SR\_DIARYARCHIVE\_RECURRING: SR\_DIARYARCHIVE\_RECURRING\_TOOLTIP|  |
|personAppointment/booking| *None* |SR\_DIARYARCHIVE\_BOOKING: SR\_DIARYARCHIVE\_BOOKING\_TOOLTIP|  |
|personAppointment/intention| *None* |SR\_DIARYARCHIVE\_INTENTION: SR\_DIARYARCHIVE\_INTENTION\_TOOLTIP|  |
|personAppointment/location| *None* |SR\_ACTIVITYARCHIVE\_LOCATION: SR\_ACTIVITYARCHIVE\_LOCATION\_TOOLTIP|  |
|personAppointment/recurrenceRuleId| *None* |SR\_DIARYARCHIVE\_RRID: SR\_DIARYARCHIVE\_RRID\_TOOLTIP|  |
|personAppointment/rawType| *None* |SR\_DIARYARCHIVE\_RAWTYPE: SR\_DIARYARCHIVE\_RAWTYPE\_TOOLTIP|  |
|personAppointment/rawStatus| *None* |SR\_DIARYARCHIVE\_RAWSTATUS: SR\_DIARYARCHIVE\_RAWSTATUS\_TOOLTIP|  |
|personAppointment/cautionWarning| *None* |SR\_ACTIVITYARCHIVE\_CAUTIONWARNING: SR\_ACTIVITYARCHIVE\_CAUTIONWARNING\_TOOLTIP|  |
|personAppointment/visibleInDiary| *None* |SR\_FINDACTIVITY\_SKIPTENT: SR\_FINDACTIVITY\_SKIPTENT\_TOOLTIP|  |
|personAppointment/endTime| *None* |SR\_ACTIVITYARCHIVE\_ENDTIME: SR\_ACTIVITYARCHIVE\_ENDTIME\_TOOLTIP|  |
|personAppointment/suggestedAppointmentId| *None* |SR\_ARCHIVE\_SUGGESTEDAPPNTID: SR\_ARCHIVE\_SUGGESTEDAPPNTID\_TOOLTIP|  |
|personAppointment/completedDate| *None* |SR\_ACTIVITYARCHIVE\_COMPLETEDDATE: SR\_ACTIVITYARCHIVE\_COMPLETEDDATE\_TOOLTIP|  |
|personAppointment/isMilestone| *None* |SR\_ARCHIVE\_MILESTONE: SR\_ARCHIVE\_MILESTONE\_TOOLTIP|  |
|personAppointment/invitedPersonId| *None* |SR\_ACTIVITYARCHIVE\_INVITEDPERSONID: SR\_ACTIVITYARCHIVE\_INVITEDPERSONID\_TOOLTIP|  |
|personAppointment/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP|  |
|personAppointment/joinVideomeetUrl| *None* |SR\_ACTIVITYARCHIVE\_VIDEOMEETURL: SR\_ACTIVITYARCHIVE\_VIDEOMEETURL\_TOOLTIP|  |
|personAppointment/duration| *None* |SR\_CHATARCHIVE\_DURATION: SR\_CHATARCHIVE\_DURATION\_TOOLTIP|  |
|personAppointment/createdByWorkflow| *None* |SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP|  |
|personAppointment/visibleFor| *None* |SR\_ARCHIVE\_VISIBLE\_FOR|  |
|personAppointment/appointmentPublish/isPublished| *None* |SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP|  |
|personAppointment/appointmentPublish/publishedFrom| *None* |SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP|  |
|personAppointment/appointmentPublish/publishedTo| *None* |SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP|  |
|personAppointment/appointmentPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|personAppointment/appointmentUdef/SuperOffice:1| *None* |followupshorttext|  |
|personAppointment/appointmentUdef/SuperOffice:2| *None* |followuplongtext|  |
|personAppointment/appointmentUdef/SuperOffice:3| *None* |followupnumber|  |
|personAppointment/appointmentUdef/SuperOffice:4| *None* |followupdate|  |
|personAppointment/appointmentUdef/SuperOffice:5| *None* |followupunlimiteddate|  |
|personAppointment/appointmentUdef/SuperOffice:6| *None* |followupcheckbox|  |
|personAppointment/appointmentUdef/SuperOffice:7| *None* |followupdropdownlistbox|  |
|personAppointment/appointmentUdef/SuperOffice:8| *None* |followupdecimal|  |
|personAppointment/associate/firstName| *None* |SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|personAppointment/associate/lastName| *None* |SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|personAppointment/associate/middleName| *None* |SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|personAppointment/associate/fullName| *None* |SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|personAppointment/associate/contactId| *None* |SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personAppointment/associate/personId| *None* |SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|personAppointment/associate/mrMrs| *None* |SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|personAppointment/associate/title| *None* |SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|personAppointment/associate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|personAppointment/associate/contactName| *None* |SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|personAppointment/associate/contactDepartment| *None* |SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|personAppointment/associate/usergroup| *None* |SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|personAppointment/associate/usergroupId| *None* |SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|personAppointment/associate/contactFullName| *None* |SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|personAppointment/associate/contactCategory| *None* |SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|personAppointment/associate/role| *None* |SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|personAppointment/associate/assocName| *None* |SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|personAppointment/associate/assocTooltip| *None* |SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|personAppointment/associate/assocType| *None* |SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|personAppointment/associate/ejUserId| *None* |SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|personAppointment/associate/simultaneousEjUser| *None* |SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|personAppointment/associate/ejDisplayName| *None* |SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|personAppointment/associate/ejStatus| *None* |SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|personAppointment/associate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|personAppointment/associate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|personAppointment/associate/isActive| *None* |SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|personAppointment/associate/isActiveText| *None* |SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|personAppointment/associate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|personAppointment/associate/otherGroups| *None* |SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|personAppointment/associate/userName| *None* |SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|personAppointment/associate/personEmail| *None* |SR\_ARCHIVE\_EMAIL|  |
|personAppointment/associate/locationAddress| *None* |SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|personAppointment/associate/isLocation| *None* |SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|personAppointment/appointment/text| *None* |SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|personAppointment/appointment/description| *None* |SR\_DIARYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|personAppointment/appointment/title| *None* |SR\_TICKETARCHIVE\_TITLE|  |
|personAppointment/appointment/titleHtml| *None* |!!Title Html|  |
|personAppointment/appointment/agenda| *None* |SR\_APPOINTMENT\_AGENDA|  |
|personAppointment/appointment/agendaHtml| *None* |!!Agenda Html|  |
|personAppointment/appointment/isConverted| *None* |!!Is Converted|  |
|personAppointment/appointment/textId| *None* |Text ID|  |
|personAppointment/appointment/internalNotes| *None* |SR\_APPOINTMENT\_INTERNAL\_NOTES: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP|  |
|personAppointment/appointment/internalNotesHtml| *None* |!!Internal Notes Html|  |

## Sample

```http!
GET /api/v1/archive/ContactSelectionCombined?$select=contactExtra/y_organization/x_name,sale/earningPercent,personUdef/SuperOffice:7,personPrivate/formattedNumber,personSourceRelation/supportAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


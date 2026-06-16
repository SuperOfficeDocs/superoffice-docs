---
uid: LinksPerson
title: LinksPerson
description: 
keywords: LinksPerson archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "LinksPerson"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksPersonProvider">SuperOffice.CRM.ArchiveLists.LinksPersonProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"person"|[[SR_PERSON]]|

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
|personId|int|SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|middleName|string|SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|fullName|string|SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
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
|icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
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
|contact/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|contact/deletedDate|datetime|SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contact/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|contact/forceCompany|bool|Dummy: Dummy|  |
|destinationPersonRestrictionId|int|ADD LINK Person DESTINATION RESOURCE: ADD LINK Person DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/LinksPerson?$select=rank,contact/updatedByFullName,birthMonth
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


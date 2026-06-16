---
uid: ParticipantsWithConflictRemoval
title: ParticipantsWithConflictRemoval
description: Archive provider that wraps the <see cref="T -SuperOffice.CRM.ArchiveLists.ParticipantsProvider" />, and adds a pseudo entity used to hide associates with conflicts.
keywords: ParticipantsWithConflictRemoval archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ParticipantsWithConflictRemoval"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ParticipantsWithConflictRemovalProvider">SuperOffice.CRM.ArchiveLists.ParticipantsWithConflictRemovalProvider</see> inside NetServer's SODatabase assembly.

Archive provider that wraps the <see cref="T:SuperOffice.CRM.ArchiveLists.ParticipantsProvider" />, and adds a pseudo entity used to hide associates with conflicts.

This provider is used by the Assign To dialog, where an associate list with conflict markers is shown. This list has a checkbox
with the text 'hide conflicts', and its effect is to remove from the list those that do have a conflict.


This class implements the functionality by wrapping the existing participants provider, adds an optional entity to get
the checkbox, and performs filtering if the entity is chosen. It also ensures that the relevant column is ordered from the
inner participants provider, so that the conflict checking is performed.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"associate"|[[SR_LIST_ASSOCIATE]]|
|"resource"|[[SR_FT_RESOURCE]]|
|"externalPerson"|[[SR_USERS_EXTERNAL_PERSONS]]|
|"emailParticipant"|Email Participant|
|"hideConflict"|[[SR_HIDE_CONFLICT]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ownerAssociateIdInformation|associate|SR\_BOOKING\_OWNER: SR\_BOOKING\_OWNER\_TOOLTIP|  |
|inhibitConflictsInformation|bool|SR\_INHIBIT\_CONFLICTS: SR\_INHIBIT\_CONFLICTS\_TOOLTIP|  |
|startTimeInformation|datetime|SR\_STARTTIME\_INFORMATION: SR\_STARTTIME\_INFORMATION\_TOOLTIP|  |
|endTimeInformation|datetime|SR\_ENDTIME\_INFORMATION: SR\_ENDTIME\_INFORMATION\_TOOLTIP|  |
|startTimeUtcInformation|datetime|SR\_STARTTIME\_INFORMATION: SR\_STARTTIME\_INFORMATION\_TOOLTIP|  |
|endTimeUtcInformation|datetime|SR\_ENDTIME\_INFORMATION: SR\_ENDTIME\_INFORMATION\_TOOLTIP|  |
|dateInformation|date|SR\_DATE\_INFORMATION: SR\_DATE\_INFORMATION\_TOOLTIP|  |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|icon| *None* |SR\_BOOKING\_TYPEICON: SR\_BOOKING\_TYPEICON\_TOOLTIP|  |
|sendEmail| *None* |SR\_BOOKING\_MAILICON: SR\_BOOKING\_MAILICON\_TOOLTIP|  |
|seen| *None* |SR\_BOOKING\_SEENICON: SR\_BOOKING\_SEENICON\_TOOLTIP|  |
|status| *None* |SR\_BOOKING\_CONFLICT: SR\_BOOKING\_CONFLICT\_TOOLTIP|  |
|participantAssociateId| *None* |SR\_PARTASSOCIATEID: SR\_PARTASSOCIATEID\_TOOLTIP|  |
|participantPersonId| *None* |SR\_PARTPERSONID: SR\_PARTPERSONID\_TOOLTIP|  |
|rejectReason| *None* |SR\_FIELD\_APPOINTMENT\_REJECT\_REASON\_NAME: SR\_FIELD\_APPOINTMENT\_REJECT\_REASON\_TOOLTIP|  |
|associateEmailsInformation|int|SR\_INFORMATION\_BOOKINGEMAILS: SR\_INFORMATION\_BOOKINGEMAILS\_TOOLTIP|  |
|appointmentRestrictionId|int|SR\_RESTRICTION\_BOOKINGAPPOINTMENT: SR\_RESTRICTION\_BOOKINGAPPOINTMENT\_TOOLTIP|  |
|firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|personEmail|string|SR\_ARCHIVE\_EMAIL|  |
|locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|personEmailsInformation|int|SR\_INFORMATION\_BOOKINGEMAILS: SR\_INFORMATION\_BOOKINGEMAILS\_TOOLTIP|  |
|fullNameWithContact| *None* |SR\_PERSON\_NAMEWITHCONT: SR\_PERSON\_NAMEWITHCONT\_TOOLTIP|  |
|hasInfoText|bool|SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|hasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|personHasInterests|bool|SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|position|listAny|SR\_ARCHIVE\_POSITION|  |
|personNumber|string|SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP|  |
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
|personActiveErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|ticketPriority|listAny|SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP|  |
|supportLanguage|listAny|SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP|  |
|supportAssociate|associate|SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP|  |
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
|email/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|email/emailAddress|string|SR\_ARCHIVE\_EMAIL|  |
|email/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|email/emailId|int|ID|  |
|email/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|email/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|email/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|email/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|personUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL|  |
|personUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|personContact/contactId| *None* |SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP|  |
|personContact/name| *None* |SR\_COMPANY\_NAME|  |
|personContact/department| *None* |SR\_ARCHIVE\_DEPARTEMENT|  |
|personContact/nameDepartment| *None* |SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP|  |
|personContact/hasInfoText| *None* |SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP|  |
|personContact/hasInterests| *None* |SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP|  |
|personContact/associateId| *None* |SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP|  |
|personContact/category| *None* |SR\_ARCHIVE\_CATEGORY|  |
|personContact/categoryGroup| *None* |SR\_ADMIN\_LISTS\_CATEGORYGROUP|  |
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
|personContact/activeErpLinks| *None* |SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP|  |
|personContact/deletedDate| *None* |SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|personContact/mainContact| *None* |SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP|  |
|personContact/forceCompany| *None* |Dummy: Dummy|  |
|personContact/email/emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|personContact/email/emailAddress|string|SR\_ARCHIVE\_EMAIL|  |
|personContact/email/emailDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|personContact/email/emailId|int|ID|  |
|personContact/email/emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|personContact/email/emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|personContact/email/emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|personContact/email/emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|emailProtocol|string|SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP|  |
|emailAddress|string|SR\_ARCHIVE\_EMAIL|  |
|emailDescription|string|SR\_ARCHIVE\_DESCRIPTION|  |
|emailId|int|ID|  |
|emailLastSent|datetime|SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP|  |
|emailBounceCount|int|SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP|  |
|emailLastBounce|datetime|SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP|  |
|emailHasBounced|bool|SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP|  |
|associateRestrictionId|int|SR\_RESTRICTION\_BOOKINGASSOCIATE: SR\_RESTRICTION\_BOOKINGASSOCIATE\_TOOLTIP|  |
|groupRestrictionId|int|SR\_RESTRICTION\_BOOKINGGROUP: SR\_RESTRICTION\_BOOKINGGROUP\_TOOLTIP|  |
|resourceRestrictionId|int|SR\_RESTRICTION\_BOOKINGRESOURCE: SR\_RESTRICTION\_BOOKINGRESOURCE\_TOOLTIP|  |
|externalPersonRestrictionId|int|SR\_RESTRICTION\_BOOKINGPERSON: SR\_RESTRICTION\_BOOKINGPERSON\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/ParticipantsWithConflictRemoval?$select=contactDepartment,isStakeholder,fullNameWithContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


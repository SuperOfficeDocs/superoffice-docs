---
uid: ticketfavourites
title: ticketfavourites
description: 
keywords: ticketfavourites archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ticketfavourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TicketFavouritesProvider">SuperOffice.CRM.ArchiveLists.TicketFavouritesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ticket"|[[SR_FAVOURITE_TICKET]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|projectId|int|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|ticketStatusId|int|SR\_TICKET\_STATUS\_ID: SR\_TICKET\_STATUS| x |
|priorityId|int|SR\_TICKET\_PRIORITY\_ID: SR\_TICKET\_PRIORITY\_ID\_TOOLTIP| x |
|categoryId|int|SR\_TICKET\_CATEGORY\_ID: SR\_TICKET\_CATEGORY\_ID\_TOOLTIP| x |
|ticketTypeName|listAny|SR\_TICKETARCHIVE\_TICKET\_TYPE: SR\_TICKETARCHIVE\_TICKET\_TYPE\_TOOLTIP| x |
|ticketStatusName|listAny|SR\_TICKETARCHIVE\_TICKETSTATUS: SR\_TICKETARCHIVE\_TICKETSTATUS\_TOOLTIP| x |
|categoryFullName|ejCategory|SR\_TICKETARCHIVE\_EJCATEGORY: SR\_TICKETARCHIVE\_EJCATEGORY\_TOOLTIP| x |
|priorityName|listAny|SR\_TICKETARCHIVE\_PRIORITY: SR\_TICKETARCHIVE\_PRIORITY\_TOOLTIP| x |
|ownedBy|ejUser|SR\_TICKETARCHIVE\_OWNEDBY: SR\_TICKETARCHIVE\_OWNEDBY\_TOOLTIP| x |
|ticketId|int|SR\_TICKETARCHIVE\_TICKETID: SR\_TICKETARCHIVE\_TICKETID\_TOOLTIP| x |
|title|string|SR\_TICKETARCHIVE\_TITLE: SR\_TICKETARCHIVE\_TITLE\_TOOLTIP| x |
|createdAt|datetime|SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP| x |
|createdDate|date|SR\_TICKETARCHIVE\_CREATEDDATE: SR\_TICKETARCHIVE\_CREATEDDATE| x |
|lastChanged|datetime|SR\_TICKETARCHIVE\_LASTCHANGED: SR\_TICKETARCHIVE\_LASTCHANGED\_TOOLTIP| x |
|author|string|SR\_TICKETARCHIVE\_AUTHOR: SR\_TICKETARCHIVE\_AUTHOR\_TOOLTIP| x |
|readByOwner|datetime|SR\_TICKETARCHIVE\_READBYOWNER: SR\_TICKETARCHIVE\_READBYOWNER\_TOOLTIP| x |
|firstReadByOwner|datetime|SR\_TICKETARCHIVE\_FIRSTREADBYOWNER: SR\_TICKETARCHIVE\_FIRSTREADBYOWNER\_TOOLTIP| x |
|firstReadByUser|datetime|SR\_TICKETARCHVE\_FIRSTREADBYUSER: SR\_TICKETARCHVE\_FIRSTREADBYUSER\_TOOLTIP| x |
|readByCustomer|datetime|SR\_TICKETARCHIVE\_READBYCUSTOMER: SR\_TICKETARCHIVE\_READBYCUSTOMER\_TOOLTIP| x |
|status|listAny|SR\_TICKETARCHIVE\_INTERNAL\_STATUS: SR\_TICKETARCHIVE\_INTERNAL\_STATUS\_TOOLTIP| x |
|origin|listAny|SR\_TICKETARCHIVE\_ORIGIN: SR\_TICKETARCHIVE\_ORIGIN| x |
|slevel|listAny|SR\_TICKETARCHIVE\_SLEVEL: SR\_TICKETARCHIVE\_SLEVEL| x |
|numberOfMessages|int|SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES: SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES| x |
|numberOfReplies|int|SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES: SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES| x |
|connectId|int|SR\_TICKETARCHIVE\_CONNECTID: SR\_TICKETARCHIVE\_CONNECTID| x |
|readStatus|listAny|SR\_TICKETARCHIVE\_READSTATUS: SR\_TICKETARCHIVE\_READSTATUS| x |
|realTimeSpentQueue|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE| x |
|realTimeSpentExternally|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL| x |
|realTimeSpentInternally|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL| x |
|timeSpentQueue|timeSpan|SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE| x |
|timeSpentExternally|timeSpan|SR\_TICKETARCHIVE\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_TIME\_EXTERNAL| x |
|timeSpentInternally|timeSpan|SR\_TICKETARCHIVE\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_TIME\_INTERNAL| x |
|timeSpent|timeSpan|SR\_TICKETARCHIVE\_TIME\_SPENT: SR\_TICKETARCHIVE\_TIME\_SPENT| x |
|timeToReply|timeSpan|SR\_TICKETARCHIVE\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_TIME\_TO\_REPLY| x |
|timeToClose|timeSpan|SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE| x |
|realTimeToReply|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY| x |
|realTimeToClose|timeSpan|SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE| x |
|repliedAt|datetime|SR\_TICKETARCHIVE\_REPLIED\_AT: SR\_TICKETARCHIVE\_REPLIED\_AT| x |
|closedAt|datetime|SR\_TICKETARCHIVE\_CLOSED\_AT: SR\_TICKETARCHIVE\_CLOSED\_AT| x |
|activated|datetime|SR\_TICKETARCHIVE\_POSTPONED\_TO: SR\_TICKETARCHIVE\_POSTPONED\_TO| x |
|deadline|datetime|SR\_TICKETARCHIVE\_DEADLINE: SR\_TICKETARCHIVE\_DEADLINE| x |
|has\_attachment|bool|SR\_TICKETARCHIVE\_HAS\_ATTACHMENT: SR\_INBOX\_ATTACHMENT\_TOOLTIP| x |
|tags|intArray|SR\_TICKETARCHIVE\_TAGS: SR\_TICKETARCHIVE\_TAGS\_TOOLTIP| x |
|createdBy|ejUser|SR\_TICKETARCHIVE\_CREATEDBY: SR\_TICKETARCHIVE\_CREATEDBY| x |
|content|string|SR\_ARCHIVE\_CONTENT: SR\_ARCHIVE\_CONTENT\_TOOLTIP| x |
|messageLanguage|listAny|SR\_TICKETARCHIVE\_LANGUAGE: SR\_TICKETARCHIVE\_LANGUAGE\_TOOLTIP|  |
|sentimentScore|listAny|SR\_TICKETARCHIVE\_SENTIMENT: SR\_TICKETARCHIVE\_SENTIMENT\_TOOLTIP|  |
|sentimentConfidence|int|SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE: SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE| x |
|suggestedCategory|listAny|SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY: SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY\_TOOLTIP|  |
|createdByWorkflow|listAny|SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|entityIcon| *None* |SR\_FAVOURITE\_ITEMICON: SR\_FAVOURITE\_ITEMICON| x |
|icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|text|positiveString|SR\_SINGULAR\_FAVOURITE: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|favouriteAssociateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|createdBy/firstName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|createdBy/lastName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|createdBy/middleName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|createdBy/fullName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|createdBy/contactId|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|createdBy/personId|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|createdBy/mrMrs|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|createdBy/title|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|createdBy/associateDbId|associate|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|createdBy/contactName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|createdBy/contactDepartment|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|createdBy/usergroup|userGroup|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|createdBy/usergroupId|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|createdBy/contactFullName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|createdBy/contactCategory|listAny|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|createdBy/role|listAny|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|createdBy/assocName|associate|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|createdBy/assocTooltip|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|createdBy/assocType|listAny|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|createdBy/ejUserId|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|createdBy/simultaneousEjUser|bool|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|createdBy/ejDisplayName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|createdBy/ejStatus|int|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|createdBy/credentialType| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|createdBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|createdBy/isActive|bool|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|createdBy/isActiveText|bool|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|createdBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|createdBy/otherGroups|userGroup|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|createdBy/userName|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|createdBy/personEmail|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_EMAIL| x |
|createdBy/locationAddress|string|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|createdBy/isLocation|bool|SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ownedBy/firstName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ownedBy/lastName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ownedBy/middleName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ownedBy/fullName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ownedBy/contactId|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ownedBy/personId|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ownedBy/mrMrs|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ownedBy/title|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ownedBy/associateDbId|associate|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|ownedBy/contactName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|ownedBy/contactDepartment|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|ownedBy/usergroup|userGroup|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ownedBy/usergroupId|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ownedBy/contactFullName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|ownedBy/contactCategory|listAny|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|ownedBy/role|listAny|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|ownedBy/assocName|associate|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|ownedBy/assocTooltip|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ownedBy/assocType|listAny|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ownedBy/ejUserId|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|ownedBy/simultaneousEjUser|bool|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ownedBy/ejDisplayName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ownedBy/ejStatus|int|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ownedBy/credentialType| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|ownedBy/credentialDisplayValue| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|ownedBy/isActive|bool|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|ownedBy/isActiveText|bool|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|ownedBy/portraitThumbnail| *None* |SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ownedBy/otherGroups|userGroup|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ownedBy/userName|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|ownedBy/personEmail|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_EMAIL| x |
|ownedBy/locationAddress|string|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|ownedBy/isLocation|bool|SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ticketStatus/ticketStatusId|int|SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_ID: SR\_TICKETARCHIVE\_TICKETSTATUS\_ID\_TOOLTIP| x |
|ticketStatus/name|string|SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME: SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME\_TOOLTIP| x |
|ticketStatus/rank|int|SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK: SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK\_TOOLTIP| x |
|ticketPriority/ticketPriorityId|int|SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_ID: SR\_TICKETARCHIVE\_PRIORITY\_ID\_TOOLTIP| x |
|ticketPriority/name|string|SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_NAME: SR\_TICKETARCHIVE\_PRIORITY\_NAME\_TOOLTIP| x |
|ticketPriority/rank|int|SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_RANK: SR\_TICKETARCHIVE\_PRIORITY\_RANK\_TOOLTIP| x |
|extra/x\_ticket\_integer|int|Extra integer: Custom ticket integer. Default 123. External. Show in properties| x |
|extra/x\_ticket\_float|decimal|Extra float: Custom float on Request. 2 decimal places| x |
|extra/x\_ticket\_longtext|string|Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props| x |
|extra/x\_ticket\_date|date|Extra date: Custom date field on Request. No default value| x |
|extra/x\_ticket\_datetime|datetime|Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request| x |
|extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.| x |
|extra/x\_ticket\_boolean|bool|Extra boolean: Custom boolean on Ticket.| x |
|extra/x\_ticket\_timespan|timeSpan|Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props| x |
|extra/x\_ticket\_short\_text|string|Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request| x |
|extra/x\_ticket\_shorttext\_list|listAny|Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot| x |
|extra/x\_ticket\_timestamp|datetime|Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field| x |
|extra/x\_ticket\_project\_relation|stringorPK|Extra project: Custom project relation on Request| x |
|extra/x\_ticket\_faq|stringorPK|Extra FAQ Relation: Extra FAQ Relation| x |
|extra/x\_ticket\_category\_relation|listAny|Extra category relation: Category relation on request| x |
|extra/y\_equipment/x\_name|string|Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|extra/y\_car/id|int|Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |

## Sample

```http!
GET /api/v1/archive/ticketfavourites?$select=timeToClose,ownedBy/lastName,content
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


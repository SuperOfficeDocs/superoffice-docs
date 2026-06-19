---
uid: TicketMessage
title: TicketMessage
description: Messages on support tickets. Messages are typically e-mail messages with attachments, but not always.
keywords: TicketMessage archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "TicketMessage"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TicketMessageProvider">SuperOffice.CRM.ArchiveLists.TicketMessageProvider</see> inside NetServer's SODatabase assembly.

Messages on support tickets. Messages are typically e-mail messages with attachments, but not always.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ticketmessage"|Ticket Message|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|searchTitle|string|SR\_TICKETARCHIVE\_TITLE| x |
|header|string|Header| x |
|ticketId|int|TicketId| x |
|ticketMessageId|int|TicketMessageId| x |
|author|string|SR\_TICKETARCHIVE\_AUTHOR: SR\_TICKETARCHIVE\_AUTHOR\_TOOLTIP| x |
|createdAt|datetime|SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP| x |
|body|string|TextBody|  |
|htmlBody|string|HtmlBody|  |
|messageId|string|MessageId| x |
|debugInfo|string|DebugInfo|  |
|important|bool|Important?| x |
|slevel|listAny|SLevel| x |
|timeSpent|int|TimeSpent: Time in minutes.| x |
|ticket/contactId|int|SR\_SINGUALR\_TICKET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|ticket/personId|int|SR\_SINGUALR\_TICKET - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|ticket/saleId|int|SR\_SINGUALR\_TICKET - SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|ticket/projectId|int|SR\_SINGUALR\_TICKET - SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|ticket/ticketStatusId|int|SR\_SINGUALR\_TICKET - SR\_TICKET\_STATUS\_ID: SR\_TICKET\_STATUS| x |
|ticket/priorityId|int|SR\_SINGUALR\_TICKET - SR\_TICKET\_PRIORITY\_ID: SR\_TICKET\_PRIORITY\_ID\_TOOLTIP| x |
|ticket/categoryId|int|SR\_SINGUALR\_TICKET - SR\_TICKET\_CATEGORY\_ID: SR\_TICKET\_CATEGORY\_ID\_TOOLTIP| x |
|ticket/ticketTypeName|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TICKET\_TYPE: SR\_TICKETARCHIVE\_TICKET\_TYPE\_TOOLTIP| x |
|ticket/ticketStatusName|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TICKETSTATUS: SR\_TICKETARCHIVE\_TICKETSTATUS\_TOOLTIP| x |
|ticket/categoryFullName|ejCategory|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_EJCATEGORY: SR\_TICKETARCHIVE\_EJCATEGORY\_TOOLTIP| x |
|ticket/priorityName|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_PRIORITY: SR\_TICKETARCHIVE\_PRIORITY\_TOOLTIP| x |
|ticket/ownedBy|ejUser|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY: SR\_TICKETARCHIVE\_OWNEDBY\_TOOLTIP| x |
|ticket/ticketId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TICKETID: SR\_TICKETARCHIVE\_TICKETID\_TOOLTIP| x |
|ticket/title|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TITLE: SR\_TICKETARCHIVE\_TITLE\_TOOLTIP| x |
|ticket/createdAt|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDAT: SR\_TICKETARCHIVE\_CREATEDAT\_TOOLTIP| x |
|ticket/createdDate|date|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDDATE: SR\_TICKETARCHIVE\_CREATEDDATE| x |
|ticket/lastChanged|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_LASTCHANGED: SR\_TICKETARCHIVE\_LASTCHANGED\_TOOLTIP| x |
|ticket/author|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_AUTHOR: SR\_TICKETARCHIVE\_AUTHOR\_TOOLTIP| x |
|ticket/readByOwner|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_READBYOWNER: SR\_TICKETARCHIVE\_READBYOWNER\_TOOLTIP| x |
|ticket/firstReadByOwner|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_FIRSTREADBYOWNER: SR\_TICKETARCHIVE\_FIRSTREADBYOWNER\_TOOLTIP| x |
|ticket/firstReadByUser|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHVE\_FIRSTREADBYUSER: SR\_TICKETARCHVE\_FIRSTREADBYUSER\_TOOLTIP| x |
|ticket/readByCustomer|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_READBYCUSTOMER: SR\_TICKETARCHIVE\_READBYCUSTOMER\_TOOLTIP| x |
|ticket/status|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_INTERNAL\_STATUS: SR\_TICKETARCHIVE\_INTERNAL\_STATUS\_TOOLTIP| x |
|ticket/origin|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_ORIGIN: SR\_TICKETARCHIVE\_ORIGIN| x |
|ticket/slevel|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_SLEVEL: SR\_TICKETARCHIVE\_SLEVEL| x |
|ticket/numberOfMessages|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES: SR\_TICKETARCHIVE\_NUMBER\_OF\_MESSAGES| x |
|ticket/numberOfReplies|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES: SR\_TICKETARCHIVE\_NUMBER\_OF\_REPLIES| x |
|ticket/connectId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CONNECTID: SR\_TICKETARCHIVE\_CONNECTID| x |
|ticket/readStatus|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_READSTATUS: SR\_TICKETARCHIVE\_READSTATUS| x |
|ticket/realTimeSpentQueue|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_REAL\_TIME\_IN\_QUEUE| x |
|ticket/realTimeSpentExternally|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_EXTERNAL| x |
|ticket/realTimeSpentInternally|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_REAL\_TIME\_INTERNAL| x |
|ticket/timeSpentQueue|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE: SR\_TICKETARCHIVE\_TIME\_IN\_QUEUE| x |
|ticket/timeSpentExternally|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TIME\_EXTERNAL: SR\_TICKETARCHIVE\_TIME\_EXTERNAL| x |
|ticket/timeSpentInternally|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TIME\_INTERNAL: SR\_TICKETARCHIVE\_TIME\_INTERNAL| x |
|ticket/timeSpent|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TIME\_SPENT: SR\_TICKETARCHIVE\_TIME\_SPENT| x |
|ticket/timeToReply|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_TIME\_TO\_REPLY| x |
|ticket/timeToClose|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_TIME\_TO\_CLOSE| x |
|ticket/realTimeToReply|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_REPLY| x |
|ticket/realTimeToClose|timeSpan|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE: SR\_TICKETARCHIVE\_REAL\_TIME\_TO\_CLOSE| x |
|ticket/repliedAt|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_REPLIED\_AT: SR\_TICKETARCHIVE\_REPLIED\_AT| x |
|ticket/closedAt|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CLOSED\_AT: SR\_TICKETARCHIVE\_CLOSED\_AT| x |
|ticket/activated|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_POSTPONED\_TO: SR\_TICKETARCHIVE\_POSTPONED\_TO| x |
|ticket/deadline|datetime|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_DEADLINE: SR\_TICKETARCHIVE\_DEADLINE| x |
|ticket/has\_attachment|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_HAS\_ATTACHMENT: SR\_INBOX\_ATTACHMENT\_TOOLTIP| x |
|ticket/tags|intArray|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_TAGS: SR\_TICKETARCHIVE\_TAGS\_TOOLTIP| x |
|ticket/createdBy|ejUser|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY: SR\_TICKETARCHIVE\_CREATEDBY| x |
|ticket/content|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CONTENT: SR\_ARCHIVE\_CONTENT\_TOOLTIP| x |
|ticket/messageLanguage|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_LANGUAGE: SR\_TICKETARCHIVE\_LANGUAGE\_TOOLTIP|  |
|ticket/sentimentScore|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_SENTIMENT: SR\_TICKETARCHIVE\_SENTIMENT\_TOOLTIP|  |
|ticket/sentimentConfidence|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE: SR\_TICKETARCHIVE\_SENTIMENT\_CONFIDENCE| x |
|ticket/suggestedCategory|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY: SR\_TICKETARCHIVE\_SUGGESTED\_CATEGORY\_TOOLTIP|  |
|ticket/createdByWorkflow|listAny|SR\_SINGUALR\_TICKET - SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|ticket/createdBy/firstName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ticket/createdBy/lastName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ticket/createdBy/middleName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ticket/createdBy/fullName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ticket/createdBy/contactId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ticket/createdBy/personId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ticket/createdBy/mrMrs|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/createdBy/title|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/createdBy/associateDbId|associate|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|ticket/createdBy/contactName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|ticket/createdBy/contactDepartment|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|ticket/createdBy/usergroup|userGroup|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/createdBy/usergroupId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/createdBy/contactFullName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|ticket/createdBy/contactCategory|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|ticket/createdBy/role|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|ticket/createdBy/assocName|associate|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|ticket/createdBy/assocTooltip|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ticket/createdBy/assocType|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ticket/createdBy/ejUserId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|ticket/createdBy/simultaneousEjUser|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ticket/createdBy/ejDisplayName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ticket/createdBy/ejStatus|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ticket/createdBy/credentialType| *None* |SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|ticket/createdBy/credentialDisplayValue| *None* |SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|ticket/createdBy/isActive|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|ticket/createdBy/isActiveText|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|ticket/createdBy/portraitThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ticket/createdBy/otherGroups|userGroup|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ticket/createdBy/userName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|ticket/createdBy/personEmail|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_EMAIL| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/createdBy/locationAddress|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|ticket/createdBy/isLocation|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_CREATEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ticket/ownedBy/firstName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ticket/ownedBy/lastName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ticket/ownedBy/middleName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ticket/ownedBy/fullName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ticket/ownedBy/contactId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ticket/ownedBy/personId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ticket/ownedBy/mrMrs|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/ownedBy/title|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/ownedBy/associateDbId|associate|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|ticket/ownedBy/contactName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|ticket/ownedBy/contactDepartment|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|ticket/ownedBy/usergroup|userGroup|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/ownedBy/usergroupId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/ownedBy/contactFullName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|ticket/ownedBy/contactCategory|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|ticket/ownedBy/role|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|ticket/ownedBy/assocName|associate|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|ticket/ownedBy/assocTooltip|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ticket/ownedBy/assocType|listAny|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ticket/ownedBy/ejUserId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|ticket/ownedBy/simultaneousEjUser|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ticket/ownedBy/ejDisplayName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ticket/ownedBy/ejStatus|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ticket/ownedBy/credentialType| *None* |SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|ticket/ownedBy/credentialDisplayValue| *None* |SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|ticket/ownedBy/isActive|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|ticket/ownedBy/isActiveText|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|ticket/ownedBy/portraitThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ticket/ownedBy/otherGroups|userGroup|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ticket/ownedBy/userName|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|ticket/ownedBy/personEmail|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_EMAIL| x |
|ticket/ownedBy/locationAddress|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|ticket/ownedBy/isLocation|bool|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_OWNEDBY - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ticket/ticketStatus/ticketStatusId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_ID: SR\_TICKETARCHIVE\_TICKETSTATUS\_ID\_TOOLTIP| x |
|ticket/ticketStatus/name|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME: SR\_TICKETARCHIVE\_TICKETSTATUS\_NAME\_TOOLTIP| x |
|ticket/ticketStatus/rank|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_STATUS - SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK: SR\_TICKETARCHIVE\_TICKETSTATUS\_RANK\_TOOLTIP| x |
|ticket/ticketPriority/ticketPriorityId|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_ID: SR\_TICKETARCHIVE\_PRIORITY\_ID\_TOOLTIP| x |
|ticket/ticketPriority/name|string|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_NAME: SR\_TICKETARCHIVE\_PRIORITY\_NAME\_TOOLTIP| x |
|ticket/ticketPriority/rank|int|SR\_SINGUALR\_TICKET - SR\_TICKETARCHIVE\_PRIORITY - SR\_TICKETARCHIVE\_PRIORITY\_RANK: SR\_TICKETARCHIVE\_PRIORITY\_RANK\_TOOLTIP| x |
|ticket/person/personId|int|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|ticket/person/firstName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ticket/person/lastName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ticket/person/middleName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ticket/person/fullName|string|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|ticket/person/contactId|int|SR\_SINGUALR\_TICKET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|ticket/person/hasInfoText|bool|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|ticket/person/hasInterests|bool|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|ticket/person/personHasInterests|bool|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|ticket/person/mrMrs|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/person/position|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_POSITION| x |
|ticket/person/personNumber|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|ticket/person/title|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|ticket/person/personCountry|listAny|SR\_SINGUALR\_TICKET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|ticket/person/personCountryId|int|SR\_SINGUALR\_TICKET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|ticket/person/personNoMail|bool|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|ticket/person/rank|int|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|ticket/person/birthdate| *None* |SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|ticket/person/associateType| *None* |SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|ticket/person/useAsMailingAddress|bool|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|ticket/person/personSource|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|ticket/person/retired|bool|SR\_SINGUALR\_TICKET - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|ticket/person/birthYear|int|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|ticket/person/birthMonth|int|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|ticket/person/birthDay|int|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|ticket/person/kanaFirstName|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|ticket/person/kanaLastName|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|ticket/person/personUpdatedBy|associate|SR\_SINGUALR\_TICKET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|ticket/person/personUpdatedByFullName|associate|SR\_SINGUALR\_TICKET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|ticket/person/personUpdatedDate|date|SR\_SINGUALR\_TICKET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|ticket/person/personRegisteredBy|associate|SR\_SINGUALR\_TICKET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|ticket/person/personRegisteredByFullName|associate|SR\_SINGUALR\_TICKET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|ticket/person/personRegisteredDate|date|SR\_SINGUALR\_TICKET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|ticket/person/portraitThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ticket/person/personActiveErpLinks|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|ticket/person/ticketPriority|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|ticket/person/supportLanguage|listAny|SR\_SINGUALR\_TICKET - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|ticket/person/supportAssociate|associate|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|ticket/person/supportAssociateFullName|associate|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|ticket/person/personAssociateId|associate|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|ticket/person/personAssociateFullName|associate|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|ticket/person/personCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CATEGORY| x |
|ticket/person/personCategoryGroup|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|ticket/person/personCategoryRank|int|SR\_SINGUALR\_TICKET - !!Category rank| x |
|ticket/person/personBusiness|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_BUSINESS| x |
|ticket/person/leadStatus|listAny|SR\_SINGUALR\_TICKET - SR\_LABEL\_LEADSTATUS| x |
|ticket/person/leadstatusRank|int|SR\_SINGUALR\_TICKET - !!Lead status RANK| x |
|ticket/person/personDeletedDate|datetime|SR\_SINGUALR\_TICKET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|ticket/person/hasCompany|bool|SR\_SINGUALR\_TICKET - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|ticket/person/isProjectMember|bool|SR\_SINGUALR\_TICKET - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|ticket/person/isStakeholder|bool|SR\_SINGUALR\_TICKET - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|ticket/person/updatedByWorkflow|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|ticket/person/whenUpdatedByWorkflow|datetime|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|ticket/person/createdByForm|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|ticket/person/phone/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/person/personDirectPhone/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/person/personDirectPhone/description|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_DIRECTPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|ticket/person/personMobilePhone/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/person/personMobilePhone/description|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MOBILEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/person/personPrivate/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/person/personPrivate/description|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_PRIVATEPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|ticket/person/personPager/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/person/personPager/description|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_OTHERPHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|ticket/person/personDirectFax/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/person/personDirectFax/description|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_DIRECTFAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|ticket/person/searchPhone/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/person/searchPhone/description|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|ticket/person/personInfo/textId|int|SR\_SINGUALR\_TICKET - Text ID| x |
|ticket/person/personInfo/infoText|positiveString|SR\_SINGUALR\_TICKET - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|ticket/person/email/emailProtocol|string|SR\_SINGUALR\_TICKET - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|ticket/person/email/emailAddress|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_EMAIL| x |
|ticket/person/email/emailDescription|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DESCRIPTION| x |
|ticket/person/email/emailId|int|SR\_SINGUALR\_TICKET - ID| x |
|ticket/person/email/emailLastSent|datetime|SR\_SINGUALR\_TICKET - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|ticket/person/email/emailBounceCount|int|SR\_SINGUALR\_TICKET - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|ticket/person/email/emailLastBounce|datetime|SR\_SINGUALR\_TICKET - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |
|ticket/person/email/emailHasBounced|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|ticket/person/personUrl/URLAddress|string|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_URL| x |
|ticket/person/personUrl/URLDescription|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DESCRIPTION| x |
|ticket/person/personAddress/addressId|int|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|ticket/person/personAddress/line1|string|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|ticket/person/personAddress/line2|string|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|ticket/person/personAddress/line3|string|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|ticket/person/personAddress/county|string|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|ticket/person/personAddress/city|string|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|ticket/person/personAddress/zip|string|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|ticket/person/personAddress/state|string|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|ticket/person/personAddress/wgs84latitude|decimal|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|ticket/person/personAddress/wgs84longitude|decimal|SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|ticket/person/personAddress/formattedAddress| *None* |SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|ticket/person/personAddress/formattedMultiLineAddress| *None* |SR\_SINGUALR\_TICKET - SR\_PREFIX\_PERSONADDRESS - {formattedAddress}: {formattedAddress}|  |
|ticket/person/restrictionAddress/addressId|int|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|ticket/person/restrictionAddress/line1|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|ticket/person/restrictionAddress/line2|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|ticket/person/restrictionAddress/line3|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|ticket/person/restrictionAddress/county|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|ticket/person/restrictionAddress/city|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|ticket/person/restrictionAddress/zip|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|ticket/person/restrictionAddress/state|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|ticket/person/restrictionAddress/wgs84latitude|decimal|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|ticket/person/restrictionAddress/wgs84longitude|decimal|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|ticket/person/restrictionAddress/formattedAddress| *None* |SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|ticket/person/restrictionAddress/formattedMultiLineAddress| *None* |SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|ticket/person/personInterestIds|listInterest|SR\_SINGUALR\_TICKET - SR\_SEARCH\_PERSON\_INTEREST: SR\_SEARCH\_CRITERION\_PERSON\_INTERESTS\_TOOLTIP|  |
|ticket/person/personUdef/SuperOffice:1|string|SR\_SINGUALR\_TICKET - contactshorttext: tooltipshorttext| x |
|ticket/person/personUdef/SuperOffice:2|string|SR\_SINGUALR\_TICKET - contactlongtext: tooltiplongtext| x |
|ticket/person/personUdef/SuperOffice:3|int|SR\_SINGUALR\_TICKET - contactnumber| x |
|ticket/person/personUdef/SuperOffice:4|date|SR\_SINGUALR\_TICKET - contactdate| x |
|ticket/person/personUdef/SuperOffice:5|unlimitedDate|SR\_SINGUALR\_TICKET - contactunlimiteddate: tooltipunlimiteddate| x |
|ticket/person/personUdef/SuperOffice:6|bool|SR\_SINGUALR\_TICKET - contactcheckbox| x |
|ticket/person/personUdef/SuperOffice:7|listAny|SR\_SINGUALR\_TICKET - contactdropdownlistbox| x |
|ticket/person/personUdef/SuperOffice:8|decimal|SR\_SINGUALR\_TICKET - contactdecimal| x |
|ticket/person/personUdef/SuperOffice:9|string|SR\_SINGUALR\_TICKET - page1saleonly| x |
|ticket/person/personUdef/SuperOffice:10|string|SR\_SINGUALR\_TICKET - page1marketingonly| x |
|ticket/person/personUdef/SuperOffice:11|string|SR\_SINGUALR\_TICKET - page1adminonly| x |
|ticket/person/personExtra/x\_person\_integer|int|SR\_SINGUALR\_TICKET - Extra Integer: Custom person integer| x |
|ticket/person/personExtra/x\_person\_hidden\_integer|int|SR\_SINGUALR\_TICKET - Extra hidden integer: Custom integer field that is hidden| x |
|ticket/person/personExtra/x\_person\_float|decimal|SR\_SINGUALR\_TICKET - Extra float: Custom float field| x |
|ticket/person/personExtra/x\_person\_longtext|string|SR\_SINGUALR\_TICKET - Extra Long Text: Custom long text field on person, keep HTML tags. Simple input, not text area. Default value = 'Hello there'| x |
|ticket/person/personExtra/x\_person\_date|date|SR\_SINGUALR\_TICKET - Extra date: Custom date field on person. Default value = 28.03.2019| x |
|ticket/person/personExtra/x\_person\_datetime|datetime|SR\_SINGUALR\_TICKET - Extra DateTime: Custom person date and time field. No default| x |
|ticket/person/personExtra/x\_person\_time| *None* |SR\_SINGUALR\_TICKET - Extra time: Custom time field on person. Current time as default| x |
|ticket/person/personExtra/x\_person\_boolean|bool|SR\_SINGUALR\_TICKET - Extra Boolean: Custom boolean field on person. Default checked| x |
|ticket/person/personExtra/x\_person\_timespan|timeSpan|SR\_SINGUALR\_TICKET - Extra timespan: Custom timespan on person. Minutes only in 15 units| x |
|ticket/person/personExtra/x\_person\_shorttext|string|SR\_SINGUALR\_TICKET - Extra short text: Custom short text on person. With index. Do not keep HTML tags| x |
|ticket/person/personExtra/x\_person\_shorttext\_list|listAny|SR\_SINGUALR\_TICKET - Extra short dropdown: Custom Short text dropdown field on person: black, white, transparent| x |
|ticket/person/personExtra/x\_person\_user\_relation|associate|SR\_SINGUALR\_TICKET - Extra user relation: Custom person-user relation field| x |
|ticket/person/personExtra/x\_person\_category\_relation|listAny|SR\_SINGUALR\_TICKET - Extra category relation: Custom person-category relation| x |
|ticket/person/personExtra/x\_person\_priority\_relation|listAny|SR\_SINGUALR\_TICKET - Extra priority relation: Custom person-priority relation| x |
|ticket/person/personExtra/x\_person\_request\_relation|stringorPK|SR\_SINGUALR\_TICKET - Extra request relation: Request relation on contact| x |
|ticket/person/personExtra/x\_person\_appointment\_relation|stringorPK|SR\_SINGUALR\_TICKET - Extra appointment relation: Appointment relation on person| x |
|ticket/person/personExtra/x\_person\_contact\_relation|stringorPK|SR\_SINGUALR\_TICKET - Extra company relation: Company relation on contact| x |
|ticket/person/personExtra/y\_rental/id|int|SR\_SINGUALR\_TICKET - Rental - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_rental)| x |
|ticket/person/personExtra/y\_rental/x\_start|date|SR\_SINGUALR\_TICKET - Rental - Start rental: Start rental| x |
|ticket/person/personExtra/y\_rental/x\_end|date|SR\_SINGUALR\_TICKET - Rental - End: End| x |
|ticket/person/personExtra/y\_rental/x\_amount|int|SR\_SINGUALR\_TICKET - Rental - Amount: Number to rent. Default = 1| x |
|ticket/person/personExtra/y\_rental/x\_contact|stringorPK|SR\_SINGUALR\_TICKET - Rental - Renter: Company that rents equipment| x |
|ticket/person/personExtra/y\_rental/y\_equipment/x\_name|string|SR\_SINGUALR\_TICKET - Rental - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|ticket/person/personExtra/y\_car/id|int|SR\_SINGUALR\_TICKET - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|ticket/person/personAssociate/firstName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ticket/person/personAssociate/lastName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ticket/person/personAssociate/middleName|string|SR\_SINGUALR\_TICKET - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ticket/person/personAssociate/fullName|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ticket/person/personAssociate/contactId|int|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ticket/person/personAssociate/personId|int|SR\_SINGUALR\_TICKET - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ticket/person/personAssociate/mrMrs|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/person/personAssociate/title|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/person/personAssociate/associateDbId|associate|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|ticket/person/personAssociate/contactName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|ticket/person/personAssociate/contactDepartment|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|ticket/person/personAssociate/usergroup|userGroup|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/person/personAssociate/usergroupId|int|SR\_SINGUALR\_TICKET - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/person/personAssociate/contactFullName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|ticket/person/personAssociate/contactCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|ticket/person/personAssociate/role|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|ticket/person/personAssociate/assocName|associate|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|ticket/person/personAssociate/assocTooltip|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ticket/person/personAssociate/assocType|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ticket/person/personAssociate/ejUserId|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/person/personAssociate/simultaneousEjUser|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ticket/person/personAssociate/ejDisplayName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ticket/person/personAssociate/ejStatus|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ticket/person/personAssociate/credentialType| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|ticket/person/personAssociate/credentialDisplayValue| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|ticket/person/personAssociate/isActive|bool|SR\_SINGUALR\_TICKET - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|ticket/person/personAssociate/isActiveText|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|ticket/person/personAssociate/portraitThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ticket/person/personAssociate/otherGroups|userGroup|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ticket/person/personAssociate/userName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|ticket/person/personAssociate/personEmail|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_EMAIL| x |
|ticket/person/personAssociate/locationAddress|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|ticket/person/personAssociate/isLocation|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ticket/person/correspondingAssociate/firstName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ticket/person/correspondingAssociate/lastName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ticket/person/correspondingAssociate/middleName|string|SR\_SINGUALR\_TICKET - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ticket/person/correspondingAssociate/fullName|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ticket/person/correspondingAssociate/contactId|int|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ticket/person/correspondingAssociate/personId|int|SR\_SINGUALR\_TICKET - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ticket/person/correspondingAssociate/mrMrs|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/person/correspondingAssociate/title|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/person/correspondingAssociate/associateDbId|associate|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|ticket/person/correspondingAssociate/contactName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|ticket/person/correspondingAssociate/contactDepartment|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|ticket/person/correspondingAssociate/usergroup|userGroup|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/person/correspondingAssociate/usergroupId|int|SR\_SINGUALR\_TICKET - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/person/correspondingAssociate/contactFullName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|ticket/person/correspondingAssociate/contactCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|ticket/person/correspondingAssociate/role|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|ticket/person/correspondingAssociate/assocName|associate|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|ticket/person/correspondingAssociate/assocTooltip|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ticket/person/correspondingAssociate/assocType|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ticket/person/correspondingAssociate/ejUserId|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|ticket/person/correspondingAssociate/simultaneousEjUser|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ticket/person/correspondingAssociate/ejDisplayName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ticket/person/correspondingAssociate/ejStatus|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ticket/person/correspondingAssociate/credentialType| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|ticket/person/correspondingAssociate/credentialDisplayValue| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|ticket/person/correspondingAssociate/isActive|bool|SR\_SINGUALR\_TICKET - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|ticket/person/correspondingAssociate/isActiveText|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|ticket/person/correspondingAssociate/portraitThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ticket/person/correspondingAssociate/otherGroups|userGroup|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ticket/person/correspondingAssociate/userName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|ticket/person/correspondingAssociate/personEmail|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_EMAIL| x |
|ticket/person/correspondingAssociate/locationAddress|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|ticket/person/correspondingAssociate/isLocation|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ticket/person/isMailingRecipient|bool|SR\_SINGUALR\_TICKET - SR\_DASHBOARD\_MAILINGS\_RECIPIENT: isMailingRecipient| x |
|ticket/person/hasStoreConsent|bool|SR\_SINGUALR\_TICKET - SR\_TOOLTIP\_CONSENTHAS - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|ticket/person/withdrawnStoreConsent|bool|SR\_SINGUALR\_TICKET - SR\_TOOLTIP\_CONSENTWITHDRAWN - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.|  |
|ticket/person/hasEmarketingConsent|bool|SR\_SINGUALR\_TICKET - SR\_TOOLTIP\_CONSENTHAS - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|ticket/person/withdrawnEmarketingConsent|bool|SR\_SINGUALR\_TICKET - SR\_TOOLTIP\_CONSENTWITHDRAWN - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.|  |
|ticket/person/subscription|listAny|SR\_SINGUALR\_TICKET - SR\_SUBSCRIPTION: SR\_SUBSCRIPTION\_TOOLTIP| x |
|ticket/person/legalBaseStore|listAny|SR\_SINGUALR\_TICKET - SR\_LEGALBASE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|ticket/person/legalBaseEmarketing|listAny|SR\_SINGUALR\_TICKET - SR\_LEGALBASE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|ticket/person/consentSourceStore|listAny|SR\_SINGUALR\_TICKET - SR\_CONSENTSOURCE - Sales and service: The purpose to store data about this contact is to sell to and/or provide services to this contact. This purpose is usually used when storing contacts who are defined as potential or existing customers.| x |
|ticket/person/consentSourceEmarketing|listAny|SR\_SINGUALR\_TICKET - SR\_CONSENTSOURCE - E-marketing: The purpose is to gain the explicit consent to communicate electronically (bulk e-mail) on topics related to our products and services. This might include newsletters, invitations and product-related content. The subscription system is used to refine the individual marketing choices this contact makes.| x |
|ticket/contact/contactId|int|SR\_SINGUALR\_TICKET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|ticket/contact/name|stringorPK|SR\_SINGUALR\_TICKET - SR\_COMPANY\_NAME| x |
|ticket/contact/department|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DEPARTEMENT| x |
|ticket/contact/nameDepartment|string|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|ticket/contact/hasInfoText|bool|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|ticket/contact/hasInterests|bool|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|ticket/contact/associateId|associate|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|ticket/contact/category|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CATEGORY| x |
|ticket/contact/categoryGroup|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|ticket/contact/companyCategoryRank|int|SR\_SINGUALR\_TICKET - Category rank| x |
|ticket/contact/business|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_BUSINESS| x |
|ticket/contact/country|listAny|SR\_SINGUALR\_TICKET - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTRY\_TOOLTIP| x |
|ticket/contact/countryId|int|SR\_SINGUALR\_TICKET - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|ticket/contact/number|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_NUMBER| x |
|ticket/contact/code|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CODE| x |
|ticket/contact/orgnr|string|SR\_SINGUALR\_TICKET - VAT No.| x |
|ticket/contact/stop|bool|SR\_SINGUALR\_TICKET - SR\_CC\_STOPX| x |
|ticket/contact/contactNoMail|bool|SR\_SINGUALR\_TICKET - SR\_NO\_MAIL\_COMPANY| x |
|ticket/contact/updatedBy|associate|SR\_SINGUALR\_TICKET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|ticket/contact/updatedByFullName|associate|SR\_SINGUALR\_TICKET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|ticket/contact/updatedDate|date|SR\_SINGUALR\_TICKET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|ticket/contact/registeredBy|associate|SR\_SINGUALR\_TICKET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|ticket/contact/registeredByFullName|associate|SR\_SINGUALR\_TICKET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|ticket/contact/registeredDate|date|SR\_SINGUALR\_TICKET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|ticket/contact/contactSource|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_COMPANY)| x |
|ticket/contact/contactDeleted|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DELETED: SR\_ARCHIVE\_DELETED| x |
|ticket/contact/phone/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/contact/activeErpLinks|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|ticket/contact/deletedDate|datetime|SR\_SINGUALR\_TICKET - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|ticket/contact/mainContact| *None* |SR\_SINGUALR\_TICKET - SR\_COMPANY\_MAIN\_CONTACT: SR\_COMPANY\_MAIN\_CONTACT\_TOOLTIP| x |
|ticket/contact/forceCompany|bool|SR\_SINGUALR\_TICKET - Dummy: Dummy|  |
|ticket/contact/contactPhone/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_CONTACTARCHIVE\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/contact/contactPhone/description|string|SR\_SINGUALR\_TICKET - SR\_CONTACTARCHIVE\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|ticket/contact/contactFax/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_CONTACTARCHIVE\_FAX - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/contact/contactFax/description|string|SR\_SINGUALR\_TICKET - SR\_CONTACTARCHIVE\_FAX - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|ticket/contact/searchPhone/formattedNumber|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_PHONE - SR\_CC\_PHONE: SR\_ARCHIVE\_PHONE\_TOOLTIP|  |
|ticket/contact/searchPhone/description|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_PHONE - SR\_ARCHIVE\_DESCRIPTION: SR\_PHONE\_DESC\_TOOLTIP| x |
|ticket/contact/email/emailProtocol|string|SR\_SINGUALR\_TICKET - SR\_EMAIL\_PROTOCOL: SR\_EMAIL\_PROTOCOL\_TOOLTIP| x |
|ticket/contact/email/emailAddress|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_EMAIL| x |
|ticket/contact/email/emailDescription|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DESCRIPTION| x |
|ticket/contact/email/emailId|int|SR\_SINGUALR\_TICKET - ID| x |
|ticket/contact/email/emailLastSent|datetime|SR\_SINGUALR\_TICKET - SR\_EMAIL\_LAST\_SENT: SR\_EMAIL\_LAST\_SENT\_TOOLTIP| x |
|ticket/contact/email/emailBounceCount|int|SR\_SINGUALR\_TICKET - SR\_EMAIL\_BOUNCE\_COUNT: SR\_EMAIL\_BOUNCE\_COUNT\_TOOLTIP| x |
|ticket/contact/email/emailLastBounce|datetime|SR\_SINGUALR\_TICKET - SR\_EMAIL\_LAST\_BOUNCE: SR\_EMAIL\_LAST\_BOUNCE\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/contact/email/emailHasBounced|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_HASBOUNCED: SR\_ARCHIVE\_HASBOUNCED\_TOOLTIP| x |
|ticket/contact/postAddress/addressId|int|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|ticket/contact/postAddress/line1|string|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|ticket/contact/postAddress/line2|string|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|ticket/contact/postAddress/line3|string|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|ticket/contact/postAddress/county|string|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|ticket/contact/postAddress/city|string|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|ticket/contact/postAddress/zip|string|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|ticket/contact/postAddress/state|string|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|ticket/contact/postAddress/wgs84latitude|decimal|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|ticket/contact/postAddress/wgs84longitude|decimal|SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|ticket/contact/postAddress/formattedAddress| *None* |SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/postAddress/formattedMultiLineAddress| *None* |SR\_SINGUALR\_TICKET - SR\_AL\_POSTAL - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/streetAddress/addressId|int|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|ticket/contact/streetAddress/line1|string|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|ticket/contact/streetAddress/line2|string|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|ticket/contact/streetAddress/line3|string|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|ticket/contact/streetAddress/county|string|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|ticket/contact/streetAddress/city|string|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|ticket/contact/streetAddress/zip|string|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|ticket/contact/streetAddress/state|string|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|ticket/contact/streetAddress/wgs84latitude|decimal|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|ticket/contact/streetAddress/wgs84longitude|decimal|SR\_SINGUALR\_TICKET - SR\_AL\_STREET - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|ticket/contact/streetAddress/formattedAddress| *None* |SR\_SINGUALR\_TICKET - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/streetAddress/formattedMultiLineAddress| *None* |SR\_SINGUALR\_TICKET - SR\_AL\_STREET - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/restrictionAddress/addressId|int|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_ADDRESS\_ID: SR\_ADDRESS\_ID\_TOOLTIP| x |
|ticket/contact/restrictionAddress/line1|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS1: SR\_ADDRESS\_LINE1\_TOOLTIP| x |
|ticket/contact/restrictionAddress/line2|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS2: SR\_ADDRESS\_LINE2\_TOOLTIP| x |
|ticket/contact/restrictionAddress/line3|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_AL\_ADDRESS3: SR\_ADDRESS\_LINE3\_TOOLTIP| x |
|ticket/contact/restrictionAddress/county|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_COUNTY: SR\_SEARCH\_CRITERION\_CONTACT\_COUNTY\_TOOLTIP| x |
|ticket/contact/restrictionAddress/city|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_CITY: SR\_SEARCH\_CRITERION\_CONTACT\_CITY\_TOOLTIP| x |
|ticket/contact/restrictionAddress/zip|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_ZIP: SR\_SEARCH\_CRITERION\_CONTACT\_ZIP\_TOOLTIP| x |
|ticket/contact/restrictionAddress/state|string|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_SEARCH\_STATE: SR\_SEARCH\_CRITERION\_CONTACT\_STATE\_TOOLTIP| x |
|ticket/contact/restrictionAddress/wgs84latitude|decimal|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LATITUDE| x |
|ticket/contact/restrictionAddress/wgs84longitude|decimal|SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE: SR\_ADMIN\_IMPORT\_COLUMN\_WGS84LONGITUDE| x |
|ticket/contact/restrictionAddress/formattedAddress| *None* |SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/restrictionAddress/formattedMultiLineAddress| *None* |SR\_SINGUALR\_TICKET - SR\_RESTRICTION\_ADDRESS - {formattedAddress}: {formattedAddress}|  |
|ticket/contact/url/URLAddress|string|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_URL| x |
|ticket/contact/url/URLDescription|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DESCRIPTION| x |
|ticket/contact/contactAssociate/firstName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ticket/contact/contactAssociate/lastName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ticket/contact/contactAssociate/middleName|string|SR\_SINGUALR\_TICKET - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ticket/contact/contactAssociate/fullName|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ticket/contact/contactAssociate/contactId|int|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ticket/contact/contactAssociate/personId|int|SR\_SINGUALR\_TICKET - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ticket/contact/contactAssociate/mrMrs|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/contact/contactAssociate/title|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/contact/contactAssociate/associateDbId|associate|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|ticket/contact/contactAssociate/contactName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|ticket/contact/contactAssociate/contactDepartment|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|ticket/contact/contactAssociate/usergroup|userGroup|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/contact/contactAssociate/usergroupId|int|SR\_SINGUALR\_TICKET - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/contact/contactAssociate/contactFullName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|ticket/contact/contactAssociate/contactCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|ticket/contact/contactAssociate/role|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|ticket/contact/contactAssociate/assocName|associate|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|ticket/contact/contactAssociate/assocTooltip|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ticket/contact/contactAssociate/assocType|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ticket/contact/contactAssociate/ejUserId|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|ticket/contact/contactAssociate/simultaneousEjUser|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ticket/contact/contactAssociate/ejDisplayName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ticket/contact/contactAssociate/ejStatus|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ticket/contact/contactAssociate/credentialType| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|ticket/contact/contactAssociate/credentialDisplayValue| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|ticket/contact/contactAssociate/isActive|bool|SR\_SINGUALR\_TICKET - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|ticket/contact/contactAssociate/isActiveText|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|ticket/contact/contactAssociate/portraitThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ticket/contact/contactAssociate/otherGroups|userGroup|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ticket/contact/contactAssociate/userName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|ticket/contact/contactAssociate/personEmail|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_EMAIL| x |
|ticket/contact/contactAssociate/locationAddress|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|ticket/contact/contactAssociate/isLocation|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ticket/contact/contactInterestIds|listInterest|SR\_SINGUALR\_TICKET - SR\_SEARCH\_CONTACT\_INTEREST: SR\_SEARCH\_CRITERION\_CONTACT\_INTEREST\_TOOLTIP|  |
|ticket/contact/contactUdef/SuperOffice:1|string|SR\_SINGUALR\_TICKET - companyshorttext: tooltipshorttext| x |
|ticket/contact/contactUdef/SuperOffice:2|string|SR\_SINGUALR\_TICKET - companylongtext: tooltiplongtext| x |
|ticket/contact/contactUdef/SuperOffice:3|int|SR\_SINGUALR\_TICKET - companynumber| x |
|ticket/contact/contactUdef/SuperOffice:4|date|SR\_SINGUALR\_TICKET - companydate| x |
|ticket/contact/contactUdef/SuperOffice:5|unlimitedDate|SR\_SINGUALR\_TICKET - companyunlimiteddate: tooltipunlimiteddate| x |
|ticket/contact/contactUdef/SuperOffice:6|bool|SR\_SINGUALR\_TICKET - companycheckbox| x |
|ticket/contact/contactUdef/SuperOffice:7|listAny|SR\_SINGUALR\_TICKET - companydropdownlistbox| x |
|ticket/contact/contactUdef/SuperOffice:8|decimal|SR\_SINGUALR\_TICKET - companydecimal| x |
|ticket/contact/contactUdef/SuperOffice:9|string|SR\_SINGUALR\_TICKET - page1saleonly| x |
|ticket/contact/contactUdef/SuperOffice:10|string|SR\_SINGUALR\_TICKET - page1marketingonly| x |
|ticket/contact/contactUdef/SuperOffice:11|string|SR\_SINGUALR\_TICKET - page1adminonly| x |
|ticket/contact/contactUdef/SuperOffice:12|listAny|SR\_SINGUALR\_TICKET - Udlist one: Static tooltip for udlist one| x |
|ticket/contact/contactUdef/SuperOffice:13|listAny|SR\_SINGUALR\_TICKET - Udlist two: Static tooltip for udlist two| x |
|ticket/contact/contactExtra/x\_contact\_integer|int|SR\_SINGUALR\_TICKET - Extra Integer: Custom integer field| x |
|ticket/contact/contactExtra/x\_contact\_hidden\_integer|int|SR\_SINGUALR\_TICKET - Extra hidden integer: Custom integer field - hidden| x |
|ticket/contact/contactExtra/x\_contact\_default\_integer|int|SR\_SINGUALR\_TICKET - Extra Default Integer: Custom integer field with default value 123.| x |
|ticket/contact/contactExtra/x\_contact\_float|decimal|SR\_SINGUALR\_TICKET - Extra Float: Custom float field with 3 decimals| x |
|ticket/contact/contactExtra/x\_contact\_longtext|string|SR\_SINGUALR\_TICKET - Extra LongText: Custom long text field. DO not keep HTML. 3 Line text area editor| x |
|ticket/contact/contactExtra/x\_contact\_dropdown|listAny|SR\_SINGUALR\_TICKET - Extra Long Dropdown: Custom long text field with dropdown: Volvo, Saab, etc.| x |
|ticket/contact/contactExtra/x\_contact\_date|date|SR\_SINGUALR\_TICKET - Extra date: Custom date field. User current as default.| x |
|ticket/contact/contactExtra/x\_contact\_datetime|datetime|SR\_SINGUALR\_TICKET - Extra DateTime: Custom Date Time field. No default value. External| x |
|ticket/contact/contactExtra/x\_contact\_time| *None* |SR\_SINGUALR\_TICKET - Extra time: Custom time field.| x |
|ticket/contact/contactExtra/x\_contact\_boolean|bool|SR\_SINGUALR\_TICKET - Extra boolean: Custom boolean field.| x |
|ticket/contact/contactExtra/x\_contact\_timespan|timeSpan|SR\_SINGUALR\_TICKET - Extra timespan: Custom timespan field. Hours and minutes in 10 units| x |
|ticket/contact/contactExtra/x\_contact\_shorttext|string|SR\_SINGUALR\_TICKET - Extra short text: Custom short text field. Keep HTML tags.| x |
|ticket/contact/contactExtra/x\_contact\_short\_dropdown|listAny|SR\_SINGUALR\_TICKET - Extra short dropdown: Custom short text with dropdown list. Red, Green or Blue or Purple. External.| x |
|ticket/contact/contactExtra/x\_contact\_contact\_relation|stringorPK|SR\_SINGUALR\_TICKET - Extra Company: Custom company relation. Do not show one-to-many relations. Show function buttons| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/contact/contactExtra/x\_contact\_request\_relation|stringorPK|SR\_SINGUALR\_TICKET - Extra Request relation: Request relation on company| x |
|ticket/contact/contactExtra/x\_contact\_contact|stringorPK|SR\_SINGUALR\_TICKET - Extra contact relation: Contact relation on company| x |
|ticket/contact/contactExtra/y\_organization/x\_name|string|SR\_SINGUALR\_TICKET - Organization - Name: Name| x |
|ticket/contact/NumberOfActivities|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|ticket/contact/NumberOfActivitiesInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/contact/NumberOfNotCompletedActivities|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|ticket/contact/NumberOfNotCompletedActivitiesInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/contact/LastActivity|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_ACTIVITY|  |
|ticket/contact/LastCompletedActivity|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|ticket/contact/LastDoByActivity|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|ticket/contact/NumberOfSales|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_SALES|  |
|ticket/contact/NumberOfSalesInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/contact/NumberOfNotCompletedSales|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|ticket/contact/NumberOfNotCompletedSalesInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/contact/LastSale|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_SALE|  |
|ticket/contact/LastCompletedSale|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|ticket/contact/LastDoBySale|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|ticket/contact/NumberOfTickets|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_TICKETS|  |
|ticket/contact/NumberOfTicketsInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/contact/NumberOfNotCompletedTickets|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS|  |
|ticket/contact/NumberOfNotCompletedTicketsInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_TICKETS\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/contact/LastTicket|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_TICKET|  |
|ticket/contact/LastCompletedTicket|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_COMPLETED\_TICKET|  |
|ticket/contact/LastDoByTicket|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_INCOMPLETE\_TICKET|  |
|ticket/contact/SaintStatus1|saintStatus|SR\_SINGUALR\_TICKET - Neglected customer: Denne kunden har det vært 0 salgsaktiviteter på i perioden.|  |
|ticket/contact/SaintStatus2|saintStatus|SR\_SINGUALR\_TICKET - C-company: Kundens navn starter med bokstaven C|  |
|ticket/contact/saintSaleStatus|listAny|SR\_SINGUALR\_TICKET - SR\_WITH\_STATUS|  |
|ticket/contact/saintAmountClass|listAny|SR\_SINGUALR\_TICKET - SR\_AMOUNT\_CLASS|  |
|ticket/contact/saintActivityType|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SAINT\_TYPE|  |
|ticket/contact/saintDirection|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DIRECTION|  |
|ticket/contact/saintIntention|listAny|SR\_SINGUALR\_TICKET - SR\_ACTIVITY\_INTENTION|  |
|ticket/contact/saintTicketStatus|listAny|SR\_SINGUALR\_TICKET - SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|ticket/contact/saintTicketCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|ticket/extra/x\_ticket\_integer|int|SR\_SINGUALR\_TICKET - Extra integer: Custom ticket integer. Default 123. External. Show in properties| x |
|ticket/extra/x\_ticket\_float|decimal|SR\_SINGUALR\_TICKET - Extra float: Custom float on Request. 2 decimal places| x |
|ticket/extra/x\_ticket\_longtext|string|SR\_SINGUALR\_TICKET - Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props| x |
|ticket/extra/x\_ticket\_date|date|SR\_SINGUALR\_TICKET - Extra date: Custom date field on Request. No default value| x |
|ticket/extra/x\_ticket\_datetime|datetime|SR\_SINGUALR\_TICKET - Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request| x |
|ticket/extra/x\_ticket\_time| *None* |SR\_SINGUALR\_TICKET - Extra time: Custom time field on Request. Default = 13min Display for new.| x |
|ticket/extra/x\_ticket\_boolean|bool|SR\_SINGUALR\_TICKET - Extra boolean: Custom boolean on Ticket.| x |
|ticket/extra/x\_ticket\_timespan|timeSpan|SR\_SINGUALR\_TICKET - Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props| x |
|ticket/extra/x\_ticket\_short\_text|string|SR\_SINGUALR\_TICKET - Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request| x |
|ticket/extra/x\_ticket\_shorttext\_list|listAny|SR\_SINGUALR\_TICKET - Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot| x |
|ticket/extra/x\_ticket\_timestamp|datetime|SR\_SINGUALR\_TICKET - Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field| x |
|ticket/extra/x\_ticket\_project\_relation|stringorPK|SR\_SINGUALR\_TICKET - Extra project: Custom project relation on Request| x |
|ticket/extra/x\_ticket\_faq|stringorPK|SR\_SINGUALR\_TICKET - Extra FAQ Relation: Extra FAQ Relation| x |
|ticket/extra/x\_ticket\_category\_relation|listAny|SR\_SINGUALR\_TICKET - Extra category relation: Category relation on request| x |
|ticket/extra/y\_equipment/x\_name|string|SR\_SINGUALR\_TICKET - Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|ticket/extra/y\_car/id|int|SR\_SINGUALR\_TICKET - Car - id: SR\_ARCHIVEROW\_PRIMARYKEY\_TOOLTIP (y\_car)| x |
|ticket/sale/completed|bool|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_ISDONE: SR\_ACTIVITYARCHIVE\_ISDONE\_TOOLTIP| x |
|ticket/sale/icon|listAny|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|ticket/sale/date|date|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|ticket/sale/time| *None* |SR\_SINGUALR\_TICKET - SR\_INVITE\_TIME: SR\_INVITE\_TIME|  |
|ticket/sale/type|listAny|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|ticket/sale/recordType|string|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP| x |
|ticket/sale/text|positiveString|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|ticket/sale/associateId|associate|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|ticket/sale/contactId|listAny|SR\_SINGUALR\_TICKET - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|ticket/sale/personId|listAny|SR\_SINGUALR\_TICKET - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|ticket/sale/projectId|listAny|SR\_SINGUALR\_TICKET - SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|ticket/sale/saleId|int|SR\_SINGUALR\_TICKET - SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|ticket/sale/userGroup|userGroup|SR\_SINGUALR\_TICKET - SR\_FT\_USERGROUP: SR\_USERGROUP\_TOOLTIP| x |
|ticket/sale/who| *None* |SR\_SINGUALR\_TICKET - SR\_WHO: SR\_WHO\_TOOLTIP|  |
|ticket/sale/updatedBy|associate|SR\_SINGUALR\_TICKET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|ticket/sale/updatedByFullName|associate|SR\_SINGUALR\_TICKET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|ticket/sale/updatedDate|date|SR\_SINGUALR\_TICKET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|ticket/sale/registeredBy|associate|SR\_SINGUALR\_TICKET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|ticket/sale/registeredByFullName|associate|SR\_SINGUALR\_TICKET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|ticket/sale/registeredDate|date|SR\_SINGUALR\_TICKET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|ticket/sale/currencyId|int|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_CURRENCY\_ID: SR\_ARCHIVE\_SALE\_CURRENCY\_ID\_TOOLTIP| x |
|ticket/sale/currency|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_CURRENCY: SR\_SALE\_CURRENCY\_TOOLTIP| x |
|ticket/sale/credited|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_CREDITED: SR\_SALE\_CREDITED\_TOOLTIP| x |
|ticket/sale/lossReason|listAny|SR\_SINGUALR\_TICKET - SR\_SALE\_REASON\_LOST: SR\_SALE\_LOSSREASON\_TOOLTIP| x |
|ticket/sale/source|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_SOURCE: SR\_SALE\_SOURCE\_TOOLTIP| x |
|ticket/sale/competitor|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_COMPETITOR: SR\_SALE\_COMPETITOR\_TOOLTIP| x |
|ticket/sale/heading|stringorPK|SR\_SINGUALR\_TICKET - SR\_COMMON\_SALE: SR\_ARCHIVE\_SALE\_NAME\_TOOLTIP| x |
|ticket/sale/amount|decimal|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_AMOUNT: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|ticket/sale/amountWeighted|decimal|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|ticket/sale/earning|decimal|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_EARNING: SR\_EARNING\_AMOUNT\_TOOLTIP| x |
|ticket/sale/earningPercent|decimal|SR\_SINGUALR\_TICKET - SR\_SDLG\_EARNINGP: SR\_SALE\_EARNINGPCT\_TOOLTIP| x |
|ticket/sale/probPercent|int|SR\_SINGUALR\_TICKET - SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE: SR\_LIST\_PROBABILITY\_AS\_PERCENTAGE\_TOOLTIP| x |
|ticket/sale/originalStage|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED: SR\_ARCHIVE\_SALE\_STAGE\_WHEN\_CLOSED| x |
|ticket/sale/stage|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_STAGE: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|ticket/sale/stageName| *None* |SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_STAGE\_NAME: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|ticket/sale/saleStatus|listAny|SR\_SINGUALR\_TICKET - SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP| x |
|ticket/sale/stageRank| *None* |SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_STAGE\_RANK: SR\_ARCHIVE\_SALE\_STAGE\_RANK\_TOOLTIP| x |
|ticket/sale/saleType|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALETYPE: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|ticket/sale/saleTypeId| *None* |SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALETYPE\_ID: SR\_ARCHIVE\_SALETYPE\_TOOLTIP| x |
|ticket/sale/stageId| *None* |SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_STAGE\_ID: SR\_ARCHIVE\_SALE\_STAGE\_TOOLTIP| x |
|ticket/sale/nextDueDate|date|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_NEXTDUEDATE: SR\_ARCHIVE\_NEXTDUEDATE\_TOOLTIP| x |
|ticket/sale/reopenDate|date|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_REOPENDATE: SR\_ARCHIVE\_SALE\_REOPENDATE\_TOOLTIP| x |
|ticket/sale/stalledComment|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_STALLEDCOMMENT: SR\_ARCHIVE\_STALLEDCOMMENT\_TOOLTIP| x |
|ticket/sale/saleTypeCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_SALE\_CAT: SR\_ADMIN\_LIST\_SALE\_CAT| x |
|ticket/sale/soldReason|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_REASON\_SOLD: SR\_ARCHIVE\_REASON\_SOLD\_TOOLTIP| x |
|ticket/sale/saleNumber|string|SR\_SINGUALR\_TICKET - SR\_SALESARCHIVE\_NUMBER: SR\_SALESARCHIVE\_NUMBER| x |
|ticket/sale/hasStakeholders|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_HAS\_STAKEHOLDERS: SR\_ARCHIVE\_HAS\_STAKEHOLDERS\_TOOLTIP| x |
|ticket/sale/stakeholdersEnabled|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED: SR\_ARCHIVE\_STAKEHOLDERS\_ENABLED\_TOOLTIP| x |
|ticket/sale/hasQuote|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_HAS\_QUOTE: SR\_ARCHIVE\_HAS\_QUOTE\_TOOLTIP| x |
|ticket/sale/hasGuide|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|ticket/sale/description|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALEDESCRIPTION: SR\_ARCHIVE\_SALEDESCRIPTION\_TOOLTIP|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/sale/activeErpLinks|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|ticket/sale/createdByWorkflow|listAny|SR\_SINGUALR\_TICKET - SR\_CREATED\_BY\_WORKFLOW: SR\_CREATED\_BY\_WORKFLOW\_TOOLTIP| x |
|ticket/sale/amountInBaseCurrency| *None* |SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_AMOUNT (BaseCurrency: SR\_SALE\_AMOUNT\_TOOLTIP| x |
|ticket/sale/amountWeightedInBaseCurrency| *None* |SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT (BaseCurrency: SR\_ARCHIVE\_SALE\_WEIGHTEDAMOUNT\_TOOLTIP| x |
|ticket/sale/daysInStage|int|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE: SR\_ARCHIVE\_SALE\_DAYS\_IN\_STAGE\_TOOLTIP| x |
|ticket/sale/visibleFor|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_VISIBLE\_FOR|  |
|ticket/sale/sale/textId|int|SR\_SINGUALR\_TICKET - Text ID| x |
|ticket/sale/sale/description|positiveString|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|ticket/sale/salePublish/isPublished|bool|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|ticket/sale/salePublish/publishedFrom|date|SR\_SINGUALR\_TICKET - SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|ticket/sale/salePublish/publishedTo|date|SR\_SINGUALR\_TICKET - SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|ticket/sale/salePublish/publishedBy| *None* |SR\_SINGUALR\_TICKET - SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|ticket/sale/associate/firstName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ticket/sale/associate/lastName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ticket/sale/associate/middleName|string|SR\_SINGUALR\_TICKET - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ticket/sale/associate/fullName|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ticket/sale/associate/contactId|int|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ticket/sale/associate/personId|int|SR\_SINGUALR\_TICKET - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ticket/sale/associate/mrMrs|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/sale/associate/title|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/sale/associate/associateDbId|associate|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|ticket/sale/associate/contactName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|ticket/sale/associate/contactDepartment|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|ticket/sale/associate/usergroup|userGroup|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/sale/associate/usergroupId|int|SR\_SINGUALR\_TICKET - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/sale/associate/contactFullName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|ticket/sale/associate/contactCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|ticket/sale/associate/role|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|ticket/sale/associate/assocName|associate|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|ticket/sale/associate/assocTooltip|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ticket/sale/associate/assocType|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ticket/sale/associate/ejUserId|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|ticket/sale/associate/simultaneousEjUser|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ticket/sale/associate/ejDisplayName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ticket/sale/associate/ejStatus|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ticket/sale/associate/credentialType| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|ticket/sale/associate/credentialDisplayValue| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|ticket/sale/associate/isActive|bool|SR\_SINGUALR\_TICKET - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|ticket/sale/associate/isActiveText|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|ticket/sale/associate/portraitThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ticket/sale/associate/otherGroups|userGroup|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ticket/sale/associate/userName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|ticket/sale/associate/personEmail|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_EMAIL| x |
|ticket/sale/associate/locationAddress|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|ticket/sale/associate/isLocation|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ticket/sale/saleUdef/SuperOffice:1|string|SR\_SINGUALR\_TICKET - saleshorttext| x |
|ticket/sale/saleUdef/SuperOffice:2|string|SR\_SINGUALR\_TICKET - salelongtext| x |
|ticket/sale/saleUdef/SuperOffice:3|int|SR\_SINGUALR\_TICKET - salenumber| x |
|ticket/sale/saleUdef/SuperOffice:4|date|SR\_SINGUALR\_TICKET - saledate| x |
|ticket/sale/saleUdef/SuperOffice:5|unlimitedDate|SR\_SINGUALR\_TICKET - saleunlimiteddate| x |
|ticket/sale/saleUdef/SuperOffice:6|bool|SR\_SINGUALR\_TICKET - salecheckbox| x |
|ticket/sale/saleUdef/SuperOffice:7|listAny|SR\_SINGUALR\_TICKET - saledropdownlistbox| x |
|ticket/sale/saleUdef/SuperOffice:8|decimal|SR\_SINGUALR\_TICKET - saledecimal| x |
|ticket/project/completed|bool|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP| x |
|ticket/project/projectId|int|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP| x |
|ticket/project/name|stringorPK|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP| x |
|ticket/project/number|string|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP| x |
|ticket/project/type|listAny|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP| x |
|ticket/project/status|listAny|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP| x |
|ticket/project/statusRank| *None* |SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP| x |
|ticket/project/associateId|associate|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|ticket/project/hasInfoText|bool|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP| x |
|ticket/project/icon| *None* |SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|ticket/project/text|string|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|ticket/project/description|string|SR\_SINGUALR\_TICKET - SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION| x |
|ticket/project/updatedBy|associate|SR\_SINGUALR\_TICKET - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|ticket/project/updatedByFullName|associate|SR\_SINGUALR\_TICKET - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|ticket/project/updatedDate|date|SR\_SINGUALR\_TICKET - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|ticket/project/registeredBy|associate|SR\_SINGUALR\_TICKET - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|ticket/project/registeredByFullName|associate|SR\_SINGUALR\_TICKET - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|ticket/project/registeredDate|date|SR\_SINGUALR\_TICKET - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|ticket/project/hasGuide|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|ticket/project/nextMilestone|date|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP| x |
|ticket/project/endDate|date|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP| x |
|ticket/project/imageThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|ticket/project/activeErpLinks|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|ticket/project/eventId|int|SR\_SINGUALR\_TICKET - SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID| x |
|ticket/project/startDate|date|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP| x |
|ticket/project/projectPublish/isPublished|bool|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|ticket/project/projectPublish/publishedFrom|date|SR\_SINGUALR\_TICKET - SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|ticket/project/projectPublish/publishedTo|date|SR\_SINGUALR\_TICKET - SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|ticket/project/projectPublish/publishedBy| *None* |SR\_SINGUALR\_TICKET - SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|ticket/project/projectEvent/isExternalEvent|bool|SR\_SINGUALR\_TICKET - SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP| x |
|ticket/project/projectEvent/eventDate|date|SR\_SINGUALR\_TICKET - SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP| x |
|ticket/project/projectEvent/hasSignOn|bool|SR\_SINGUALR\_TICKET - SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP| x |
|ticket/project/projectEvent/hasSignOff|bool|SR\_SINGUALR\_TICKET - SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP| x |
|ticket/project/projectUrl/URLAddress|string|SR\_SINGUALR\_TICKET - SR\_PROJECTARCHIVE\_URL| x |
|ticket/project/projectUrl/URLDescription|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DESCRIPTION| x |
|ticket/project/projectAssociate/firstName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|ticket/project/projectAssociate/lastName|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|ticket/project/projectAssociate/middleName|string|SR\_SINGUALR\_TICKET - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|ticket/project/projectAssociate/fullName|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|ticket/project/projectAssociate/contactId|int|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|ticket/project/projectAssociate/personId|int|SR\_SINGUALR\_TICKET - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|ticket/project/projectAssociate/mrMrs|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/project/projectAssociate/title|string|SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|ticket/project/projectAssociate/associateDbId|associate|SR\_SINGUALR\_TICKET - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|ticket/project/projectAssociate/contactName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|ticket/project/projectAssociate/contactDepartment|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|ticket/project/projectAssociate/usergroup|userGroup|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ticket/project/projectAssociate/usergroupId|int|SR\_SINGUALR\_TICKET - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|ticket/project/projectAssociate/contactFullName|string|SR\_SINGUALR\_TICKET - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|ticket/project/projectAssociate/contactCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|ticket/project/projectAssociate/role|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|ticket/project/projectAssociate/assocName|associate|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|ticket/project/projectAssociate/assocTooltip|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|ticket/project/projectAssociate/assocType|listAny|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|ticket/project/projectAssociate/ejUserId|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|ticket/project/projectAssociate/simultaneousEjUser|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|ticket/project/projectAssociate/ejDisplayName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|ticket/project/projectAssociate/ejStatus|int|SR\_SINGUALR\_TICKET - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|ticket/project/projectAssociate/credentialType| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|ticket/project/projectAssociate/credentialDisplayValue| *None* |SR\_SINGUALR\_TICKET - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|ticket/project/projectAssociate/isActive|bool|SR\_SINGUALR\_TICKET - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|ticket/project/projectAssociate/isActiveText|bool|SR\_SINGUALR\_TICKET - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|ticket/project/projectAssociate/portraitThumbnail| *None* |SR\_SINGUALR\_TICKET - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|ticket/project/projectAssociate/otherGroups|userGroup|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|ticket/project/projectAssociate/userName|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|ticket/project/projectAssociate/personEmail|string|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_EMAIL| x |
|ticket/project/projectAssociate/locationAddress|string|SR\_SINGUALR\_TICKET - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|ticket/project/projectAssociate/isLocation|bool|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|ticket/project/projectUdef/SuperOffice:1|string|SR\_SINGUALR\_TICKET - projectshorttext| x |
|ticket/project/projectUdef/SuperOffice:2|string|SR\_SINGUALR\_TICKET - projectlongtext| x |
|ticket/project/projectUdef/SuperOffice:3|int|SR\_SINGUALR\_TICKET - projectnumber| x |
|ticket/project/projectUdef/SuperOffice:4|date|SR\_SINGUALR\_TICKET - projectdate| x |
|ticket/project/projectUdef/SuperOffice:5|unlimitedDate|SR\_SINGUALR\_TICKET - projectunlimiteddate| x |
|ticket/project/projectUdef/SuperOffice:6|bool|SR\_SINGUALR\_TICKET - projectcheckbox| x |
|ticket/project/projectUdef/SuperOffice:7|listAny|SR\_SINGUALR\_TICKET - projectdropdownlistbox| x |
|ticket/project/projectUdef/SuperOffice:8|decimal|SR\_SINGUALR\_TICKET - projectdecimal| x |
|ticket/project/projectUdef/SuperOffice:9|int|SR\_SINGUALR\_TICKET - page1saleandmarketing| x |
|ticket/project/projectUdef/SuperOffice:10|int|SR\_SINGUALR\_TICKET - page1saleandadmin| x |
|ticket/project/NumberOfActivities|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|ticket/project/NumberOfActivitiesInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/project/NumberOfNotCompletedActivities|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|ticket/project/NumberOfNotCompletedActivitiesInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/project/LastActivity|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_ACTIVITY|  |
|ticket/project/LastCompletedActivity|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|ticket/project/LastDoByActivity|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|ticket/project/NumberOfSales|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_SALES|  |
|ticket/project/NumberOfSalesInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/project/NumberOfNotCompletedSales|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|ticket/project/NumberOfNotCompletedSalesInPeriod|int|SR\_SINGUALR\_TICKET - SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|ticket/project/LastSale|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_SALE|  |
|ticket/project/LastCompletedSale|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|ticket/project/LastDoBySale|date|SR\_SINGUALR\_TICKET - SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|ticket/project/SaintStatus3|saintStatus|SR\_SINGUALR\_TICKET - Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|ticket/project/saintSaleStatus|listAny|SR\_SINGUALR\_TICKET - SR\_WITH\_STATUS|  |
|ticket/project/saintAmountClass|listAny|SR\_SINGUALR\_TICKET - SR\_AMOUNT\_CLASS|  |
|ticket/project/saintActivityType|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_SAINT\_TYPE|  |
|ticket/project/saintDirection|listAny|SR\_SINGUALR\_TICKET - SR\_ARCHIVE\_DIRECTION|  |
|ticket/project/saintIntention|listAny|SR\_SINGUALR\_TICKET - SR\_ACTIVITY\_INTENTION|  |
|ticket/project/saintTicketStatus|listAny|SR\_SINGUALR\_TICKET - SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|ticket/project/saintTicketCategory|listAny|SR\_SINGUALR\_TICKET - SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|ticket/project/project/textId|int|SR\_SINGUALR\_TICKET - Text ID| x |
|ticket/project/project/infoText|positiveString|SR\_SINGUALR\_TICKET - SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|person/personId|int|SR\_PERSON - SR\_PERSONARCHIVE\_RECORDID: SR\_PERSONARCHIVE\_RECORDID\_TOOLTIP| x |
|person/firstName|string|SR\_PERSON - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|person/lastName|string|SR\_PERSON - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|person/middleName|string|SR\_PERSON - SR\_PERSONARCHIVE\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|person/fullName|string|SR\_PERSON - SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|person/contactId|int|SR\_PERSON - SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|person/hasInfoText|bool|SR\_PERSON - SR\_PERSONARCHIVE\_HASINFO: SR\_PERSONARCHIVE\_HASINFO\_TOOLTIP| x |
|person/hasInterests|bool|SR\_PERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|person/personHasInterests|bool|SR\_PERSON - SR\_PERSONARCHIVE\_HASINTERESTS: SR\_PERSONARCHIVE\_HASINTERESTS\_TOOLTIP| x |
|person/mrMrs|string|SR\_PERSON - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|person/position|listAny|SR\_PERSON - SR\_ARCHIVE\_POSITION| x |
|person/personNumber|string|SR\_PERSON - SR\_PERSONARCHIVE\_NUMBER: SR\_PERSONARCHIVE\_NUMBER\_TOOLTIP| x |
|person/title|string|SR\_PERSON - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_JOBTITLE\_TOOLTIP| x |
|person/personCountry|listAny|SR\_PERSON - SR\_SEARCH\_COUNTRY: SR\_SEARCH\_COUNTRY\_TOOLTIP| x |
|person/personCountryId|int|SR\_PERSON - SR\_SEARCH\_COUNTRYID: SR\_SEARCH\_COUNTRYID\_TOOLTIP| x |
|person/personNoMail|bool|SR\_PERSON - SR\_PERSONARCHIVE\_NOMAILINGS: SR\_PERSONARCHIVE\_NOMAILINGS\_TOOLTIP| x |
|person/rank|int|SR\_PERSON - SR\_PERSONARCHIVE\_RANK: SR\_PERSONARCHIVE\_RANK\_TOOLTIP| x |
|person/birthdate| *None* |SR\_PERSON - SR\_PERSONARCHIVE\_BIRTHDATE: SR\_PERSONARCHIVE\_BIRTHDATE\_TOOLTIP|  |
|person/associateType| *None* |SR\_PERSON - SR\_PERSONARCHIVE\_ASSOCIATETYPE: SR\_PERSONARCHIVE\_ASSOCIATETYPE\_TOOLTIP|  |
|person/useAsMailingAddress|bool|SR\_PERSON - SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS: SR\_PERSONARCHIVE\_USE\_AS\_MAILINGADDRESS\_TOOLTIP| x |
|person/personSource|listAny|SR\_PERSON - SR\_ARCHIVE\_SALE\_SOURCE: SR\_ARCHIVE\_SALE\_SOURCE (SR\_SINGULAR\_CONTACT)| x |
|person/retired|bool|SR\_PERSON - SR\_PDLG\_RETIRED: SR\_RETIRED\_TOOLTIP| x |
|person/birthYear|int|SR\_PERSON - SR\_ARCHIVE\_BIRTHYEAR: SR\_ARCHIVE\_BIRTHYEAR\_TOOLTIP| x |
|person/birthMonth|int|SR\_PERSON - SR\_ARCHIVE\_BIRTHMONTH: SR\_ARCHIVE\_BIRTHMONTH\_TOOLTIP| x |
|person/birthDay|int|SR\_PERSON - SR\_ARCHIVE\_BIRTHDAY: SR\_ARCHIVE\_BIRTHDAY\_TOOLTIP| x |
|person/kanaFirstName|string|SR\_PERSON - SR\_ARCHIVE\_KANAFIRST: SR\_ARCHIVE\_KANAFIRST\_TOOLTIP| x |
|person/kanaLastName|string|SR\_PERSON - SR\_ARCHIVE\_KANALAST: SR\_ARCHIVE\_KANALAST\_TOOLTIP| x |
|person/personUpdatedBy|associate|SR\_PERSON - SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|person/personUpdatedByFullName|associate|SR\_PERSON - SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|person/personUpdatedDate|date|SR\_PERSON - SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|person/personRegisteredBy|associate|SR\_PERSON - SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|person/personRegisteredByFullName|associate|SR\_PERSON - SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|person/personRegisteredDate|date|SR\_PERSON - SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|person/portraitThumbnail| *None* |SR\_PERSON - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|person/personActiveErpLinks|bool|SR\_PERSON - SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|person/ticketPriority|listAny|SR\_PERSON - SR\_ARCHIVE\_TICKET\_PRIORITY: SR\_ARCHIVE\_TICKET\_PRIORITY\_TOOLTIP| x |
|person/supportLanguage|listAny|SR\_PERSON - SR\_FIELD\_PERSON\_SUPPORT\_LANGUAGE\_ID\_NAME: SR\_ARCHIVE\_SUPPORT\_LANGUAGE\_TOOLTIP| x |
|person/supportAssociate|associate|SR\_PERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|person/supportAssociateFullName|associate|SR\_PERSON - SR\_ARCHIVE\_SUPPORT\_ASSOCIATE - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_SUPPORT\_ASSOCIATE\_TOOLTIP| x |
|person/personAssociateId|associate|SR\_PERSON - SR\_ARCHIVE\_OUR\_CONTACT: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|person/personAssociateFullName|associate|SR\_PERSON - SR\_ARCHIVE\_OUR\_CONTACT - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_OUR\_CONTACT\_TOOLTIP| x |
|person/personCategory|listAny|SR\_PERSON - SR\_ARCHIVE\_CATEGORY| x |
|person/personCategoryGroup|listAny|SR\_PERSON - SR\_ADMIN\_LISTS\_CATEGORYGROUP| x |
|person/personCategoryRank|int|SR\_PERSON - !!Category rank| x |
|person/personBusiness|listAny|SR\_PERSON - SR\_ARCHIVE\_BUSINESS| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|person/leadStatus|listAny|SR\_PERSON - SR\_LABEL\_LEADSTATUS| x |
|person/leadstatusRank|int|SR\_PERSON - !!Lead status RANK| x |
|person/personDeletedDate|datetime|SR\_PERSON - SR\_DELETEDDATE: SR\_DELETEDDATE\_TOOLTIP|  |
|person/hasCompany|bool|SR\_PERSON - SR\_HAS\_COMPANY: SR\_HAS\_COMPANY\_TOOLTIP| x |
|person/isProjectMember|bool|SR\_PERSON - SR\_IS\_PROJECT\_MEMBER: SR\_IS\_PROJECT\_MEMBER\_TOOLTIP| x |
|person/isStakeholder|bool|SR\_PERSON - SR\_IS\_STAKEHOLDER: SR\_IS\_STAKEHOLDER\_TOOLTIP| x |
|person/updatedByWorkflow|listAny|SR\_PERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW: SR\_ARCHIVE\_UPDATED\_BY\_FLOW| x |
|person/whenUpdatedByWorkflow|datetime|SR\_PERSON - SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN: SR\_ARCHIVE\_UPDATED\_BY\_FLOW\_WHEN| x |
|person/createdByForm|listAny|SR\_PERSON - SR\_ARCHIVE\_CREATED\_BY\_FORM: SR\_ARCHIVE\_CREATED\_BY\_FORM| x |
|ticketMessageExtra/x\_message\_integer|int|Extra integer: Custom integer on message. Hidden. Default 123| x |
|ticketMessageExtra/x\_message\_float|decimal|Extra float: Custom float on message. Hidden| x |
|ticketMessageExtra/x\_message\_longtext|string|Extra long text: Custom long text on Message. Hidden, do not keep HTML| x |
|ticketMessageExtra/x\_message\_date|date|Extra date: Custom date field on message. Hidden.| x |
|ticketMessageExtra/x\_message\_datetime|datetime|Extra DateTime: Custom datetime on message. Hidden. Use current as default| x |
|ticketMessageExtra/x\_message\_time| *None* |Extra Time: Custom time field on message. Hidden| x |
|ticketMessageExtra/x\_message\_boolean|bool|Extra Boolean: Custom boolean field on message. Hidden| x |
|ticketMessageExtra/x\_message\_timespan|timeSpan|Extra timespan: Custom timespan field on message. Hidden| x |
|ticketMessageExtra/x\_message\_short\_text|string|Extra short text: Custom short text field. Hidden.| x |
|ticketMessageExtra/x\_message\_sale\_relation|stringorPK|Extra sale relation: Custom sale relation field. Hidden| x |

## Sample

```http!
GET /api/v1/archive/TicketMessage?$select=ticket/createdBy/mrMrs,ticket/ownedBy/mrMrs,ticket/person/personExtra/y_rental/x_amount,ticket/person/personAssociate/firstName,ticket/contact/contactAssociate/isLocation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


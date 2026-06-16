---
uid: EmailFlowEmailContent
title: EmailFlowEmailContent
description: Email flow message content.
keywords: EmailFlowEmailContent archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "EmailFlowEmailContent"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowSMessageContentProvider">SuperOffice.CRM.ArchiveLists.EmailFlowSMessageContentProvider</see> inside NetServer's SODatabase assembly.

Email flow message content.
Lists all email flow message content

## Supported Entities
| Name | Description |
| ---- | ----- |
|"SMessage"|SMessage|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|shipmentMessageId|int|SR\_LISTITEMARCHIVE\_ID: SR\_LISTITEMARCHIVE\_ID\_TOOLTIP| x |
|shipmentMessagePictureFolderId|int|SR\_FORMS\_FOLDER: SR\_FORMS\_FOLDER| x |
|shipmentMessageThumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|shipmentMessageSubject|string|SR\_COMMON\_SUBJECT: SR\_COMMON\_SUBJECT| x |
|shipmentMessageDescription|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION| x |
|nameOrDescription|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|emailFlow/emailFlowId|int|SR\_ARCHIVE\_EMAILFLOW\_ID: SR\_ARCHIVE\_EMAILFLOW\_ID\_TOOLTIP| x |
|emailFlow/emailFlowHierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|emailFlow/shipmentType|listAny|SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE: SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE\_TOOLTIP| x |
|emailFlow/overrideConsentSubscription|bool|SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION: SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION\_TOOLTIP| x |
|emailFlow/thumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|emailFlow/mediumThumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|emailFlow/workflowId|int|SR\_ARCHIVE\_WORKFLOW\_ID: SR\_ARCHIVE\_WORKFLOW\_ID\_TOOLTIP| x |
|emailFlow/workflowName|string|SR\_ARCHIVE\_WORKFLOW\_NAME: SR\_ARCHIVE\_WORKFLOW\_NAME\_TOOLTIP| x |
|emailFlow/workflowDescription|string|SR\_ARCHIVE\_WORKFLOW\_DESC: SR\_ARCHIVE\_WORKFLOW\_DESC\_TOOLTIP| x |
|emailFlow/workflowDefinitionStatus|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|emailFlow/workflowDefinitionStatusId|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|emailFlow/jumpToFinish|bool|SR\_ARCHIVE\_WORKFLOW\_JUMP\_TO\_FINISH: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_JUMP\_TO\_FINISH\_TOOLTIP| x |
|emailFlow/startOnlyOnce|bool|SR\_ARCHIVE\_WORKFLOW\_START\_ONLY\_ONCE: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_START\_ONLY\_ONCE\_TOOLTIP| x |
|emailFlow/workflowEnrolledCount| *None* |SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowInProgressCount| *None* |SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT: SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT\_TOOLTIP|  |
|emailFlow/workflowCompletedCount| *None* |SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowSucceededCount| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowSuccessRate| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE: SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE\_TOOLTIP|  |
|emailFlow/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|emailFlow/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|emailFlow/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|emailFlow/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|shipment/mailingId|int|SR\_ARCHIVE\_MAILING\_ID: SR\_ARCHIVE\_MAILING\_ID\_TOOLTIP| x |
|shipment/mailingSelectionId|int|SR\_SELECTION\_ID: SR\_SELECTION\_ID\_TOOLTIP| x |
|shipment/mailingDescription|string|SR\_ARCHIVE\_MAILING\_NAME: SR\_ARCHIVE\_MAILING\_NAME\_TOOLTIP| x |
|shipment/mailingSent|listAny|SR\_ARCHIVE\_MAILING\_SENT: SR\_ARCHIVE\_MAILING\_SENT\_TOOLTIP| x |
|shipment/mailingSimpleStatus|listAny|SR\_ARCHIVE\_MAILING\_STATUS: SR\_ARCHIVE\_MAILING\_STATUS| x |
|shipment/mailingEndDate|date|SR\_ARCHIVE\_MAILING\_END\_DATE: SR\_ARCHIVE\_MAILING\_END\_DATE\_TOOLTIP| x |
|shipment/mailingType|listAny|SR\_ARCHIVE\_MAILING\_TYPE: SR\_ARCHIVE\_MAILING\_TYPE\_TOOLTIP| x |
|shipment/mailingSubscriptionType|listAny|SR\_ARCHIVE\_MAILING\_SUBSCRIPTION\_TYPE: SR\_ARCHIVE\_MAILING\_SUBSCRIPTION\_TYPE\_TOOLTIP| x |
|shipment/mailingSentTo|int|SR\_ARCHIVE\_MAILING\_SENTTO: SR\_ARCHIVE\_MAILING\_SENTTO\_TOOLTIP| x |
|shipment/mailingOwner|associate|SR\_ARCHIVE\_MAILING\_OWNER: SR\_ARCHIVE\_MAILING\_OWNER\_TOOLTIP| x |
|shipment/mailingFrom|string|SR\_ARCHIVE\_MAILING\_FROM: SR\_ARCHIVE\_MAILING\_FROM\_TOOLTIP| x |
|shipment/mailingReplyTo|string|SR\_ARCHIVE\_MAILING\_REPLY\_TO: SR\_ARCHIVE\_MAILING\_REPLY\_TO| x |
|shipment/mailingSentCount|int|SR\_ARCHIVE\_MAILING\_SENT\_COUNT: SR\_ARCHIVE\_MAILING\_SENT\_COUNT\_TOOLTIP| x |
|shipment/mailingOpenRate|decimal|SR\_ARCHIVE\_MAILING\_OPEN\_RATE: SR\_ARCHIVE\_MAILING\_OPEN\_RATE\_TOOLTIP| x |
|shipment/mailingClickRate|decimal|SR\_ARCHIVE\_MAILING\_CLICK\_THROUGH\_RATE: SR\_ARCHIVE\_MAILING\_CLICK\_THROUGH\_RATE\_TOOLTIP| x |
|shipment/mailingBounceRate|decimal|SR\_ARCHIVE\_MAILING\_BOUNCE\_RATE: SR\_ARCHIVE\_MAILING\_BOUNCE\_RATE\_TOOLTIP| x |
|shipment/mailingDeleted|bool|SR\_LISTITEMARCHIVE\_DELETED: SR\_LISTITEMARCHIVE\_DELETED\_TOOLTIP|  |
|shipment/recipientStatus|listAny|SR\_ARCHIVE\_RECIPIENT\_STATUS: SR\_ARCHIVE\_RECIPIENT\_STATUS\_TOOLTIP|  |
|shipment/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|shipment/date|date|SR\_ACTIVITYARCHIVE\_STARTDATE: SR\_ACTIVITYARCHIVE\_STARTDATE\_TOOLTIP| x |
|shipment/type|listAny|SR\_ACTIVITYARCHIVE\_TYPE: SR\_ACTIVITYARCHIVE\_TYPE\_TOOLTIP| x |
|shipment/text|positiveString|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|shipment/associateId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID: SR\_ACTIVITYARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|shipment/contactId|listAny|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|shipment/personId|listAny|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|shipment/projectId|listAny|SR\_PROJECT\_ID: SR\_PROJECT\_ID\_TOOLTIP| x |
|shipment/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|shipment/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|shipment/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|shipment/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|shipment/recordTypeText| *None* |SR\_ARCHIVE\_RECORDTYPETEXT: SR\_ARCHIVE\_RECORDTYPETEXT\_TOOLTIP| x |
|shipment/emailFlow/emailFlowId|int|SR\_ARCHIVE\_EMAILFLOW\_ID: SR\_ARCHIVE\_EMAILFLOW\_ID\_TOOLTIP| x |
|shipment/emailFlow/emailFlowHierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|shipment/emailFlow/shipmentType|listAny|SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE: SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE\_TOOLTIP| x |
|shipment/emailFlow/overrideConsentSubscription|bool|SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION: SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION\_TOOLTIP| x |
|shipment/emailFlow/thumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|shipment/emailFlow/mediumThumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|shipment/emailFlow/workflowId|int|SR\_ARCHIVE\_WORKFLOW\_ID: SR\_ARCHIVE\_WORKFLOW\_ID\_TOOLTIP| x |
|shipment/emailFlow/workflowName|string|SR\_ARCHIVE\_WORKFLOW\_NAME: SR\_ARCHIVE\_WORKFLOW\_NAME\_TOOLTIP| x |
|shipment/emailFlow/workflowDescription|string|SR\_ARCHIVE\_WORKFLOW\_DESC: SR\_ARCHIVE\_WORKFLOW\_DESC\_TOOLTIP| x |
|shipment/emailFlow/workflowDefinitionStatus|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|shipment/emailFlow/workflowDefinitionStatusId|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|shipment/emailFlow/jumpToFinish|bool|SR\_ARCHIVE\_WORKFLOW\_JUMP\_TO\_FINISH: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_JUMP\_TO\_FINISH\_TOOLTIP| x |
|shipment/emailFlow/startOnlyOnce|bool|SR\_ARCHIVE\_WORKFLOW\_START\_ONLY\_ONCE: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_START\_ONLY\_ONCE\_TOOLTIP| x |
|shipment/emailFlow/workflowEnrolledCount| *None* |SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT\_TOOLTIP|  |
|shipment/emailFlow/workflowInProgressCount| *None* |SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT: SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT\_TOOLTIP|  |
|shipment/emailFlow/workflowCompletedCount| *None* |SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT\_TOOLTIP|  |
|shipment/emailFlow/workflowSucceededCount| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT\_TOOLTIP|  |
|shipment/emailFlow/workflowSuccessRate| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE: SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE\_TOOLTIP|  |
|shipment/emailFlow/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|shipment/emailFlow/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|shipment/emailFlow/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|shipment/emailFlow/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/firstName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/lastName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/middleName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/fullName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/contactId|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|shipment/emailFlow/workflowAssociate/personId|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|shipment/emailFlow/workflowAssociate/mrMrs|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/title|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|shipment/emailFlow/workflowAssociate/contactName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/contactDepartment|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/usergroup|userGroup|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/emailFlow/workflowAssociate/usergroupId|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/contactFullName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/contactCategory|listAny|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|shipment/emailFlow/workflowAssociate/role|listAny|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|shipment/emailFlow/workflowAssociate/assocName|associate|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|shipment/emailFlow/workflowAssociate/assocTooltip|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|shipment/emailFlow/workflowAssociate/assocType|listAny|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/ejUserId|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|shipment/emailFlow/workflowAssociate/simultaneousEjUser|bool|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|shipment/emailFlow/workflowAssociate/ejDisplayName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|shipment/emailFlow/workflowAssociate/ejStatus|int|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|shipment/emailFlow/workflowAssociate/credentialType| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/credentialDisplayValue| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/isActive|bool|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/isActiveText|bool|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/portraitThumbnail| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|shipment/emailFlow/workflowAssociate/otherGroups|userGroup|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|shipment/emailFlow/workflowAssociate/userName|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|shipment/emailFlow/workflowAssociate/personEmail|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_EMAIL| x |
|shipment/emailFlow/workflowAssociate/locationAddress|string|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|shipment/emailFlow/workflowAssociate/isLocation|bool|SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|shipment/emailFlow/hierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|shipment/emailFlow/hierarchyFullname|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|shipment/emailFlow/hierarchyName|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|shipment/emailFlow/hierarchyParentId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|shipment/emailFlow/hierarchyFullpathIds| *None* |SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS: SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS\_TOOLTIP|  |
|shipment/project/completed|bool|SR\_ACTIVITYARCHIVE\_ISDONE: SR\_PROJECTARCHIVE\_COMPLETED\_TOOLTIP| x |
|shipment/project/projectId|int|SR\_PROJECTARCHIVE\_RECORDID: SR\_PROJECTARCHIVE\_RECORDID\_TOOLTIP| x |
|shipment/project/name|stringorPK|SR\_PROJECTARCHIVE\_NAME: SR\_PROJECTARCHIVE\_NAME\_TOOLTIP| x |
|shipment/project/number|string|SR\_PROJECTARCHIVE\_NUMBER: SR\_PROJECTARCHIVE\_NUMBER\_TOOLTIP| x |
|shipment/project/type|listAny|SR\_PROJECTARCHIVE\_TYPE: SR\_PROJECTARCHIVE\_TYPE\_TOOLTIP| x |
|shipment/project/status|listAny|SR\_PROJECTARCHIVE\_STATUS: SR\_PROJECTARCHIVE\_STATUS\_TOOLTIP| x |
|shipment/project/statusRank| *None* |SR\_PROJECTARCHIVE\_STATUS\_RANK: SR\_PROJECTARCHIVE\_STATUS\_RANK\_TOOLTIP| x |
|shipment/project/associateId|associate|SR\_PROJECTARCHIVE\_ASSOCIATEID: SR\_PROJECTARCHIVE\_ASSOCIATEID\_TOOLTIP| x |
|shipment/project/hasInfoText|bool|SR\_PROJECTARCHIVE\_HASINFO: SR\_PROJECTARCHIVE\_HASINFO\_TOOLTIP| x |
|shipment/project/icon| *None* |SR\_ACTIVITYARCHIVE\_CATEGORY: SR\_ACTIVITYARCHIVE\_CATEGORY\_TOOLTIP| x |
|shipment/project/text|string|SR\_ACTIVITYARCHIVE\_DESCRIPTION: SR\_ACTIVITYARCHIVE\_DESCRIPTION\_TOOLTIP| x |
|shipment/project/description|string|SR\_LABEL\_DESCRIPTION: SR\_LABEL\_DESCRIPTION| x |
|shipment/project/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|shipment/project/updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|shipment/project/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|shipment/project/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|shipment/project/registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|shipment/project/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|shipment/project/hasGuide|bool|SR\_ARCHIVE\_HAS\_GUIDE: SR\_ARCHIVE\_HAS\_GUIDE\_TOOLTIP| x |
|shipment/project/nextMilestone|date|SR\_ARCHIVE\_NEXTMILESTONE: SR\_ARCHIVE\_NEXTMILESTONE\_TOOLTIP| x |
|shipment/project/endDate|date|SR\_ARCHIVE\_ENDDATE: SR\_ARCHIVE\_ENDDATE\_TOOLTIP| x |
|shipment/project/imageThumbnail| *None* |SR\_PROJECTARCHIVE\_THUMBNAIL: SR\_PROJECTARCHIVE\_THUMBNAIL\_TOOLTIP|  |
|shipment/project/activeErpLinks|bool|SR\_ARCHIVE\_ACTIVEERPLINKS: SR\_ARCHIVE\_ACTIVEERPLINKS\_TOOLTIP| x |
|shipment/project/eventId|int|SR\_FIELD\_PROJECT\_EVENT\_ID: SR\_FIELD\_PROJECT\_EVENT\_ID| x |
|shipment/project/startDate|date|SR\_ARCHIVE\_STARTDATE: SR\_ARCHIVE\_STARTDATE\_TOOLTIP| x |
|shipment/project/projectPublish/isPublished|bool|SR\_PROJECTARCHIVE\_ISPUBLISHED: SR\_ARCHIVE\_ISPUBLISHED\_TOOLTIP| x |
|shipment/project/projectPublish/publishedFrom|date|SR\_FROM\_DATE: SR\_PUBLISHED\_FROM\_DATE\_TOOLTIP| x |
|shipment/project/projectPublish/publishedTo|date|SR\_TO\_DATE: SR\_PUBLISHED\_TO\_DATE\_TOOLTIP| x |
|shipment/project/projectPublish/publishedBy| *None* |SR\_PUBLISHED\_BY: SR\_PUBLISHED\_BY|  |
|shipment/project/projectEvent/isExternalEvent|bool|SR\_EXTERNAL\_EVENT: SR\_EXTERNAL\_EVENT\_TOOLTIP| x |
|shipment/project/projectEvent/eventDate|date|SR\_PROJECT\_EVENT\_DATE: SR\_PUBLISHED\_EVENT\_DATE\_TOOLTIP| x |
|shipment/project/projectEvent/hasSignOn|bool|SR\_EVENT\_HASSIGNON: SR\_EVENT\_HASSIGNON\_TOOLTIP| x |
|shipment/project/projectEvent/hasSignOff|bool|SR\_EVENT\_HASSIGNOFF: SR\_EVENT\_HASSIGNOFF\_TOOLTIP| x |
|shipment/project/projectUrl/URLAddress|string|SR\_PROJECTARCHIVE\_URL| x |
|shipment/project/projectUrl/URLDescription|string|SR\_ARCHIVE\_DESCRIPTION| x |
|shipment/project/projectAssociate/firstName|string|SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP| x |
|shipment/project/projectAssociate/lastName|string|SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP| x |
|shipment/project/projectAssociate/middleName|string|SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP| x |
|shipment/project/projectAssociate/fullName|string|SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP| x |
|shipment/project/projectAssociate/contactId|int|SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|shipment/project/projectAssociate/personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|shipment/project/projectAssociate/mrMrs|string|SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|shipment/project/projectAssociate/title|string|SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP| x |
|shipment/project/projectAssociate/associateDbId|associate|SR\_ACTIVITYARCHIVE\_ASSOCIATEID| x |
|shipment/project/projectAssociate/contactName|string|SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP| x |
|shipment/project/projectAssociate/contactDepartment|string|SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP| x |
|shipment/project/projectAssociate/usergroup|userGroup|SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|shipment/project/projectAssociate/usergroupId|int|SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP| x |
|shipment/project/projectAssociate/contactFullName|string|SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP| x |
|shipment/project/projectAssociate/contactCategory|listAny|SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY| x |
|shipment/project/projectAssociate/role|listAny|SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE| x |
|shipment/project/projectAssociate/assocName|associate|SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID| x |
|shipment/project/projectAssociate/assocTooltip|string|SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|shipment/project/projectAssociate/assocType|listAny|SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP| x |
|shipment/project/projectAssociate/ejUserId|int|SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|shipment/project/projectAssociate/simultaneousEjUser|bool|SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|shipment/project/projectAssociate/ejDisplayName|string|SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8| x |
|shipment/project/projectAssociate/ejStatus|int|SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|shipment/project/projectAssociate/credentialType| *None* |SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP| x |
|shipment/project/projectAssociate/credentialDisplayValue| *None* |SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP| x |
|shipment/project/projectAssociate/isActive|bool|SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP| x |
|shipment/project/projectAssociate/isActiveText|bool|SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP| x |
|shipment/project/projectAssociate/portraitThumbnail| *None* |SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|shipment/project/projectAssociate/otherGroups|userGroup|SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|shipment/project/projectAssociate/userName|string|SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP| x |
|shipment/project/projectAssociate/personEmail|string|SR\_ARCHIVE\_EMAIL| x |
|shipment/project/projectAssociate/locationAddress|string|SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION| x |
|shipment/project/projectAssociate/isLocation|bool|SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION| x |
|shipment/project/projectUdef/SuperOffice:1|string|projectshorttext| x |
|shipment/project/projectUdef/SuperOffice:2|string|projectlongtext| x |
|shipment/project/projectUdef/SuperOffice:3|int|projectnumber| x |
|shipment/project/projectUdef/SuperOffice:4|date|projectdate| x |
|shipment/project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|shipment/project/projectUdef/SuperOffice:6|bool|projectcheckbox| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|shipment/project/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|shipment/project/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|shipment/project/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|shipment/project/NumberOfActivities|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES|  |
|shipment/project/NumberOfActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|shipment/project/NumberOfNotCompletedActivities|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES|  |
|shipment/project/NumberOfNotCompletedActivitiesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_ACTIVITIES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|shipment/project/LastActivity|date|SR\_ROU\_LAST\_ACTIVITY|  |
|shipment/project/LastCompletedActivity|date|SR\_ROU\_LAST\_COMPLETED\_ACTIVITY|  |
|shipment/project/LastDoByActivity|date|SR\_ROU\_LAST\_INCOMPLETE\_ACTIVITY|  |
|shipment/project/NumberOfSales|int|SR\_ROU\_NUMBER\_OF\_SALES|  |
|shipment/project/NumberOfSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|shipment/project/NumberOfNotCompletedSales|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES|  |
|shipment/project/NumberOfNotCompletedSalesInPeriod|int|SR\_ROU\_NUMBER\_OF\_NOT\_COMPLETED\_SALES\_IN\_PERIOD 90 SR\_ROU\_DAYS|  |
|shipment/project/LastSale|date|SR\_ROU\_LAST\_SALE|  |
|shipment/project/LastCompletedSale|date|SR\_ROU\_LAST\_COMPLETED\_SALE|  |
|shipment/project/LastDoBySale|date|SR\_ROU\_LAST\_INCOMPLETE\_SALE|  |
|shipment/project/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|shipment/project/saintSaleStatus|listAny|SR\_WITH\_STATUS|  |
|shipment/project/saintAmountClass|listAny|SR\_AMOUNT\_CLASS|  |
|shipment/project/saintActivityType|listAny|SR\_ARCHIVE\_SAINT\_TYPE|  |
|shipment/project/saintDirection|listAny|SR\_ARCHIVE\_DIRECTION|  |
|shipment/project/saintIntention|listAny|SR\_ACTIVITY\_INTENTION|  |
|shipment/project/saintTicketStatus|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_STATUS|  |
|shipment/project/saintTicketCategory|listAny|SR\_ARHCIVE\_SAINT\_TICKET\_CATEGORY|  |
|shipment/project/project/textId|int|Text ID| x |
|shipment/project/project/infoText|positiveString|SR\_SINGULAR\_INFO: SR\_DIARYARCHIVE\_DESCRIPTION\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/EmailFlowEmailContent?$select=shipment/emailFlow/workflowDefinitionStatusId,shipment/emailFlow/workflowAssociate/isActiveText
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


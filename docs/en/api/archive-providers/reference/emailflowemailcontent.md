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
|shipmentMessageId|int|ID: ID| x |
|shipmentMessagePictureFolderId|int|Folder: Folder| x |
|shipmentMessageThumbnail| *None* |Thumbnail|  |
|shipmentMessageSubject|string|Subject: Subject| x |
|shipmentMessageDescription|string|Description : Description| x |
|nameOrDescription|string|Description : Description| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|emailFlow/emailFlowId|int|E-mail flow ID: The database ID of the e-mail flow| x |
|emailFlow/emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|emailFlow/shipmentType|listAny|Mailing type: Mailing type this e-mail flow represents| x |
|emailFlow/overrideConsentSubscription|bool|Override consent: Should consent subscriptions be overridden for this flow?| x |
|emailFlow/thumbnail| *None* |Thumbnail|  |
|emailFlow/mediumThumbnail| *None* |Thumbnail|  |
|emailFlow/workflowId|int|Flow id: Id of a flow definition| x |
|emailFlow/workflowName|string|Name: Name of the flow definition| x |
|emailFlow/workflowDescription|string|Description: Description of flow definition| x |
|emailFlow/workflowDefinitionStatus|listAny|Status: Status of the flow definition| x |
|emailFlow/workflowDefinitionStatusId|listAny|Status: Status of the flow definition| x |
|emailFlow/jumpToFinish|bool|Jump to finish: Should participant jump to finish when the goals are met?| x |
|emailFlow/startOnlyOnce|bool|Start only once: Should the participant enter the flow only once?| x |
|emailFlow/workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this flow?|  |
|emailFlow/workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|emailFlow/workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|emailFlow/workflowSucceededCount| *None* |Succeeded: How many participants have successfully completed the flow (goal criteria met)?|  |
|emailFlow/workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|emailFlow/updatedBy|associate|Updated by: The user who last updated the data| x |
|emailFlow/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|emailFlow/registeredBy|associate|Registered by: The user who registered the data| x |
|emailFlow/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|shipment/mailingId|int|ID: Displays the ID of the mailing| x |
|shipment/mailingSelectionId|int|Selection ID: The database ID of the selection| x |
|shipment/mailingDescription|string|Name: Displays the name of the mailing| x |
|shipment/mailingSent|listAny|Sent: Displays the sent status of the mailing| x |
|shipment/mailingSimpleStatus|listAny|Status: Status| x |
|shipment/mailingEndDate|date|Date sent: Displays the date when the mailing was sent (completed)| x |
|shipment/mailingType|listAny|Type: Display the type of the mailing| x |
|shipment/mailingSubscriptionType|listAny|Subscription type: The subscription type for a mailing| x |
|shipment/mailingSentTo|int|Sent to: Displays to whom the mailing was sent| x |
|shipment/mailingOwner|associate|Owner: Displays the owner of the mailing| x |
|shipment/mailingFrom|string|From: Mailing from| x |
|shipment/mailingReplyTo|string|To: To| x |
|shipment/mailingSentCount|int|Number sent: Number of sent mailings| x |
|shipment/mailingOpenRate|decimal|Open rate: The open rate for a mailing| x |
|shipment/mailingClickRate|decimal|Click-through rate: Mailing click-through rate| x |
|shipment/mailingBounceRate|decimal|Bounce rate: Mailing bounce rate| x |
|shipment/mailingDeleted|bool|Deleted: Deleted|  |
|shipment/recipientStatus|listAny|Recipient status: Status of mailing recipient|  |
|shipment/icon| *None* |Category: Displays the icon for an activity type| x |
|shipment/date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|shipment/type|listAny|Type: Displays the type of an activity| x |
|shipment/text|positiveString|Text: Displays a descriptive text for the item| x |
|shipment/associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|shipment/contactId|listAny|Company ID: Database ID of company| x |
|shipment/personId|listAny|Contact ID: Database ID of the contact row| x |
|shipment/projectId|listAny|Project ID: Database ID of project record| x |
|shipment/updatedBy|associate|Updated by: The user who last updated the data| x |
|shipment/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|shipment/registeredBy|associate|Registered by: The user who registered the data| x |
|shipment/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|shipment/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|shipment/emailFlow/emailFlowId|int|E-mail flow ID: The database ID of the e-mail flow| x |
|shipment/emailFlow/emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|shipment/emailFlow/shipmentType|listAny|Mailing type: Mailing type this e-mail flow represents| x |
|shipment/emailFlow/overrideConsentSubscription|bool|Override consent: Should consent subscriptions be overridden for this flow?| x |
|shipment/emailFlow/thumbnail| *None* |Thumbnail|  |
|shipment/emailFlow/mediumThumbnail| *None* |Thumbnail|  |
|shipment/emailFlow/workflowId|int|Flow id: Id of a flow definition| x |
|shipment/emailFlow/workflowName|string|Name: Name of the flow definition| x |
|shipment/emailFlow/workflowDescription|string|Description: Description of flow definition| x |
|shipment/emailFlow/workflowDefinitionStatus|listAny|Status: Status of the flow definition| x |
|shipment/emailFlow/workflowDefinitionStatusId|listAny|Status: Status of the flow definition| x |
|shipment/emailFlow/jumpToFinish|bool|Jump to finish: Should participant jump to finish when the goals are met?| x |
|shipment/emailFlow/startOnlyOnce|bool|Start only once: Should the participant enter the flow only once?| x |
|shipment/emailFlow/workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this flow?|  |
|shipment/emailFlow/workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|shipment/emailFlow/workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|shipment/emailFlow/workflowSucceededCount| *None* |Succeeded: How many participants have successfully completed the flow (goal criteria met)?|  |
|shipment/emailFlow/workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|shipment/emailFlow/updatedBy|associate|Updated by: The user who last updated the data| x |
|shipment/emailFlow/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|shipment/emailFlow/registeredBy|associate|Registered by: The user who registered the data| x |
|shipment/emailFlow/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|shipment/emailFlow/workflowAssociate/firstName|string|Owner - First name: Displays the contact's first name| x |
|shipment/emailFlow/workflowAssociate/lastName|string|Owner - Last name: Displays the contact's last name| x |
|shipment/emailFlow/workflowAssociate/middleName|string|Owner - Middle Name: Displays the contact's middle name.| x |
|shipment/emailFlow/workflowAssociate/fullName|string|Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|shipment/emailFlow/workflowAssociate/contactId|int|Owner - Company ID: Database ID of the company the user belongs to|  |
|shipment/emailFlow/workflowAssociate/personId|int|Owner - Contact ID: Database ID of the contact row|  |
|shipment/emailFlow/workflowAssociate/mrMrs|string|Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/emailFlow/workflowAssociate/title|string|Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/emailFlow/workflowAssociate/associateDbId|associate|Owner - ID| x |
|shipment/emailFlow/workflowAssociate/contactName|string|Owner - Owning company: Name of the company the user belongs to| x |
|shipment/emailFlow/workflowAssociate/contactDepartment|string|Owner - Owning department: Name of the department at the company the user belongs to| x |
|shipment/emailFlow/workflowAssociate/usergroup|userGroup|Owner - Primary group: The user's primary user group| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/emailFlow/workflowAssociate/usergroupId|int|Owner - Group ID: The user's primary user group| x |
|shipment/emailFlow/workflowAssociate/contactFullName|string|Owner - Owner: Name and department of the company the user belongs to| x |
|shipment/emailFlow/workflowAssociate/contactCategory|listAny|Owner - Category: Category| x |
|shipment/emailFlow/workflowAssociate/role|listAny|Owner - Role: Role| x |
|shipment/emailFlow/workflowAssociate/assocName|associate|Owner - User ID: User ID| x |
|shipment/emailFlow/workflowAssociate/assocTooltip|string|Owner - Description: Description|  |
|shipment/emailFlow/workflowAssociate/assocType|listAny|Owner - Type: Type of user: associate, external user, system user, anonymous account| x |
|shipment/emailFlow/workflowAssociate/ejUserId|int|Owner - Service user ID: The database ID of a Service user|  |
|shipment/emailFlow/workflowAssociate/simultaneousEjUser|bool|Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/emailFlow/workflowAssociate/ejDisplayName|string|Owner - Nickname: User's nickname in Service| x |
|shipment/emailFlow/workflowAssociate/ejStatus|int|Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/emailFlow/workflowAssociate/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in| x |
|shipment/emailFlow/workflowAssociate/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|shipment/emailFlow/workflowAssociate/isActive|bool|Owner - Active: Is this user active, and should be able to log in?| x |
|shipment/emailFlow/workflowAssociate/isActiveText|bool|Owner - Active status: Is this user active, and should be able to log in?| x |
|shipment/emailFlow/workflowAssociate/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|shipment/emailFlow/workflowAssociate/otherGroups|userGroup|Owner - Other groups: Other groups|  |
|shipment/emailFlow/workflowAssociate/userName|string|Owner - User name: User name| x |
|shipment/emailFlow/workflowAssociate/personEmail|string|Owner - E-mail| x |
|shipment/emailFlow/workflowAssociate/locationAddress|string|Owner - Location: Location| x |
|shipment/emailFlow/workflowAssociate/isLocation|bool|Owner - Is a location: Is a location| x |
|shipment/emailFlow/hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|shipment/emailFlow/hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|shipment/emailFlow/hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|shipment/emailFlow/hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|shipment/emailFlow/hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |
|shipment/project/completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|shipment/project/projectId|int|DB ID: Displays the database ID for a project row| x |
|shipment/project/name|stringorPK|Project name: Displays the Project's name| x |
|shipment/project/number|string|Number: Displays the project's number| x |
|shipment/project/type|listAny|Project type: Displays the project's type| x |
|shipment/project/status|listAny|Status: Displays the project's status| x |
|shipment/project/statusRank| *None* |Status rank: Rank of the project status in the status list| x |
|shipment/project/associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|shipment/project/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|shipment/project/icon| *None* |Category: Displays the icon for an activity type| x |
|shipment/project/text|string|Text: Displays a descriptive text for the item| x |
|shipment/project/description|string|Description : Description| x |
|shipment/project/updatedBy|associate|Updated by: The user who last updated the data| x |
|shipment/project/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|shipment/project/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|shipment/project/registeredBy|associate|Registered by: The user who registered the data| x |
|shipment/project/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|shipment/project/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|shipment/project/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|shipment/project/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|shipment/project/endDate|date|End date: End date of project| x |
|shipment/project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|shipment/project/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|shipment/project/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|shipment/project/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|shipment/project/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|shipment/project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|shipment/project/projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|shipment/project/projectEvent/eventDate|date|Event date: Event date| x |
|shipment/project/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|shipment/project/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|shipment/project/projectUrl/URLAddress|string|URL| x |
|shipment/project/projectUrl/URLDescription|string|Description| x |
|shipment/project/projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|shipment/project/projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|shipment/project/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|shipment/project/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|shipment/project/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|shipment/project/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|shipment/project/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/project/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|shipment/project/projectAssociate/associateDbId|associate|ID| x |
|shipment/project/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|shipment/project/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|shipment/project/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|shipment/project/projectAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|shipment/project/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|shipment/project/projectAssociate/contactCategory|listAny|Category: Category| x |
|shipment/project/projectAssociate/role|listAny|Role : Role| x |
|shipment/project/projectAssociate/assocName|associate|User ID : User ID| x |
|shipment/project/projectAssociate/assocTooltip|string|Description : Description|  |
|shipment/project/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|shipment/project/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|shipment/project/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/project/projectAssociate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|shipment/project/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|shipment/project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|shipment/project/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|shipment/project/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|shipment/project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|shipment/project/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|shipment/project/projectAssociate/userName|string|User name: User name| x |
|shipment/project/projectAssociate/personEmail|string|E-mail| x |
|shipment/project/projectAssociate/locationAddress|string|Location: Location| x |
|shipment/project/projectAssociate/isLocation|bool|Is a location: Is a location| x |
|shipment/project/projectUdef/SuperOffice:1|string|projectshorttext| x |
|shipment/project/projectUdef/SuperOffice:2|string|projectlongtext| x |
|shipment/project/projectUdef/SuperOffice:3|int|projectnumber| x |
|shipment/project/projectUdef/SuperOffice:4|date|projectdate| x |
|shipment/project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|shipment/project/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|shipment/project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|shipment/project/projectUdef/SuperOffice:8|decimal|projectdecimal| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/project/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|shipment/project/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|shipment/project/NumberOfActivities|int|Number of activities|  |
|shipment/project/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|shipment/project/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|shipment/project/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|shipment/project/LastActivity|date|Date of last activity|  |
|shipment/project/LastCompletedActivity|date|Date of last completed activity|  |
|shipment/project/LastDoByActivity|date|Date of last non-completed activity|  |
|shipment/project/NumberOfSales|int|Number of sales|  |
|shipment/project/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|shipment/project/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|shipment/project/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|shipment/project/LastSale|date|Date of last sale|  |
|shipment/project/LastCompletedSale|date|Date of last completed sale|  |
|shipment/project/LastDoBySale|date|Date of last non-completed sale|  |
|shipment/project/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|shipment/project/saintSaleStatus|listAny|With status|  |
|shipment/project/saintAmountClass|listAny|Amount class|  |
|shipment/project/saintActivityType|listAny|SAINT type|  |
|shipment/project/saintDirection|listAny|Direction|  |
|shipment/project/saintIntention|listAny|Intention|  |
|shipment/project/saintTicketStatus|listAny|Status|  |
|shipment/project/saintTicketCategory|listAny|Category|  |
|shipment/project/project/textId|int|Text ID| x |
|shipment/project/project/infoText|positiveString|Information: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/EmailFlowEmailContent?$select=shipment/project/type,shipment/project/projectAssociate/credentialType,shipment/project/NumberOfNotCompletedSales
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


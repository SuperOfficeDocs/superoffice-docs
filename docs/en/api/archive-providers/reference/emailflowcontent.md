---
uid: EmailFlowContent
title: EmailFlowContent
description: Archive of Email flow content.
keywords: EmailFlowContent archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "EmailFlowContent"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowContentProvider">SuperOffice.CRM.ArchiveLists.EmailFlowContentProvider</see> inside NetServer's SODatabase assembly.

Archive of Email flow content.
Lists all email flow content

## Supported Entities
| Name | Description |
| ---- | ----- |
|"SMessage"|SMessage|
|"Form"|Form|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|contentId|int|ID: ID| x |
|shipmentMessagePictureFolderId| *None* |Folder: Folder|  |
|contentThumbnail| *None* |Thumbnail|  |
|shipmentMessageSubject| *None* |Subject: Subject|  |
|shipmentMessageDescription| *None* |Description : Description|  |
|nameOrDescription| *None* |Description : Description|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy| *None* |Registered by: The user who registered the data|  |
|registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
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
|shipment/mailingId| *None* |ID: Displays the ID of the mailing|  |
|shipment/mailingSelectionId| *None* |Selection ID: The database ID of the selection|  |
|shipment/mailingSent| *None* |Sent: Displays the sent status of the mailing|  |
|shipment/mailingSimpleStatus| *None* |Status: Status|  |
|shipment/mailingEndDate| *None* |Date sent: Displays the date when the mailing was sent (completed)|  |
|shipment/mailingType| *None* |Type: Display the type of the mailing|  |
|shipment/mailingSubscriptionType| *None* |Subscription type: The subscription type for a mailing|  |
|shipment/mailingSentTo| *None* |Sent to: Displays to whom the mailing was sent|  |
|shipment/mailingOwner| *None* |Owner: Displays the owner of the mailing|  |
|shipment/mailingFrom| *None* |From: Mailing from|  |
|shipment/mailingReplyTo| *None* |To: To|  |
|shipment/mailingSentCount| *None* |Number sent: Number of sent mailings|  |
|shipment/mailingOpenRate| *None* |Open rate: The open rate for a mailing|  |
|shipment/mailingClickRate| *None* |Click-through rate: Mailing click-through rate|  |
|shipment/mailingBounceRate| *None* |Bounce rate: Mailing bounce rate|  |
|shipment/mailingDeleted| *None* |Deleted: Deleted|  |
|shipment/recipientStatus| *None* |Recipient status: Status of mailing recipient|  |
|shipment/icon| *None* |Category: Displays the icon for an activity type|  |
|shipment/date| *None* |Date: Displays start date of a follow-up / sale date of a sale|  |
|shipment/type| *None* |Type: Displays the type of an activity|  |
|shipment/text| *None* |Text: Displays a descriptive text for the item|  |
|shipment/associateId| *None* |ID: Displays the login ID of the associate who owns the activity.|  |
|shipment/contactId| *None* |Company ID: Database ID of company|  |
|shipment/personId| *None* |Contact ID: Database ID of the contact row|  |
|shipment/projectId| *None* |Project ID: Database ID of project record|  |
|shipment/updatedBy| *None* |Updated by: The user who last updated the data|  |
|shipment/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|shipment/recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)|  |
|shipment/emailFlow/emailFlowId| *None* |E-mail flow ID: The database ID of the e-mail flow|  |
|shipment/emailFlow/emailFlowHierarchyId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|shipment/emailFlow/shipmentType| *None* |Mailing type: Mailing type this e-mail flow represents|  |
|shipment/emailFlow/overrideConsentSubscription| *None* |Override consent: Should consent subscriptions be overridden for this flow?|  |
|shipment/emailFlow/thumbnail| *None* |Thumbnail|  |
|shipment/emailFlow/mediumThumbnail| *None* |Thumbnail|  |
|shipment/emailFlow/workflowId| *None* |Flow id: Id of a flow definition|  |
|shipment/emailFlow/workflowName| *None* |Name: Name of the flow definition|  |
|shipment/emailFlow/workflowDescription| *None* |Description: Description of flow definition|  |
|shipment/emailFlow/workflowDefinitionStatus| *None* |Status: Status of the flow definition|  |
|shipment/emailFlow/workflowDefinitionStatusId| *None* |Status: Status of the flow definition|  |
|shipment/emailFlow/jumpToFinish| *None* |Jump to finish: Should participant jump to finish when the goals are met?|  |
|shipment/emailFlow/startOnlyOnce| *None* |Start only once: Should the participant enter the flow only once?|  |
|shipment/emailFlow/workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this flow?|  |
|shipment/emailFlow/workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|shipment/emailFlow/workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|shipment/emailFlow/workflowSucceededCount| *None* |Succeeded: How many participants have successfully completed the flow (goal criteria met)?|  |
|shipment/emailFlow/workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|shipment/emailFlow/updatedBy| *None* |Updated by: The user who last updated the data|  |
|shipment/emailFlow/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|shipment/emailFlow/registeredBy| *None* |Registered by: The user who registered the data|  |
|shipment/emailFlow/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|shipment/emailFlow/workflowAssociate/firstName| *None* |Owner - First name: Displays the contact's first name|  |
|shipment/emailFlow/workflowAssociate/lastName| *None* |Owner - Last name: Displays the contact's last name|  |
|shipment/emailFlow/workflowAssociate/middleName| *None* |Owner - Middle Name: Displays the contact's middle name.|  |
|shipment/emailFlow/workflowAssociate/fullName| *None* |Owner - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|shipment/emailFlow/workflowAssociate/contactId| *None* |Owner - Company ID: Database ID of the company the user belongs to|  |
|shipment/emailFlow/workflowAssociate/personId| *None* |Owner - Contact ID: Database ID of the contact row|  |
|shipment/emailFlow/workflowAssociate/mrMrs| *None* |Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|shipment/emailFlow/workflowAssociate/title| *None* |Owner - Title: Displays whether the contact is addressed as Mr or Ms|  |
|shipment/emailFlow/workflowAssociate/associateDbId| *None* |Owner - ID|  |
|shipment/emailFlow/workflowAssociate/contactName| *None* |Owner - Owning company: Name of the company the user belongs to|  |
|shipment/emailFlow/workflowAssociate/contactDepartment| *None* |Owner - Owning department: Name of the department at the company the user belongs to|  |
|shipment/emailFlow/workflowAssociate/usergroup| *None* |Owner - Primary group: The user's primary user group|  |
|shipment/emailFlow/workflowAssociate/usergroupId| *None* |Owner - Group ID: The user's primary user group|  |
|shipment/emailFlow/workflowAssociate/contactFullName| *None* |Owner - Owner: Name and department of the company the user belongs to|  |
|shipment/emailFlow/workflowAssociate/contactCategory| *None* |Owner - Category: Category|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/emailFlow/workflowAssociate/role| *None* |Owner - Role: Role|  |
|shipment/emailFlow/workflowAssociate/assocName| *None* |Owner - User ID: User ID|  |
|shipment/emailFlow/workflowAssociate/assocTooltip| *None* |Owner - Description: Description|  |
|shipment/emailFlow/workflowAssociate/assocType| *None* |Owner - Type: Type of user: associate, external user, system user, anonymous account|  |
|shipment/emailFlow/workflowAssociate/ejUserId| *None* |Owner - Service user ID: The database ID of a Service user|  |
|shipment/emailFlow/workflowAssociate/simultaneousEjUser| *None* |Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/emailFlow/workflowAssociate/ejDisplayName| *None* |Owner - Nickname: User's nickname in Service|  |
|shipment/emailFlow/workflowAssociate/ejStatus| *None* |Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/emailFlow/workflowAssociate/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in|  |
|shipment/emailFlow/workflowAssociate/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|shipment/emailFlow/workflowAssociate/isActive| *None* |Owner - Active: Is this user active, and should be able to log in?|  |
|shipment/emailFlow/workflowAssociate/isActiveText| *None* |Owner - Active status: Is this user active, and should be able to log in?|  |
|shipment/emailFlow/workflowAssociate/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|shipment/emailFlow/workflowAssociate/otherGroups| *None* |Owner - Other groups: Other groups|  |
|shipment/emailFlow/workflowAssociate/userName| *None* |Owner - User name: User name|  |
|shipment/emailFlow/workflowAssociate/personEmail| *None* |Owner - E-mail|  |
|shipment/emailFlow/workflowAssociate/locationAddress| *None* |Owner - Location: Location|  |
|shipment/emailFlow/workflowAssociate/isLocation| *None* |Owner - Is a location: Is a location|  |
|shipment/emailFlow/hierarchyId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|shipment/emailFlow/hierarchyFullname| *None* |Hierarchy name: The full name/path from table hierarchy|  |
|shipment/emailFlow/hierarchyName| *None* |Hierarchy name: The full name/path from table hierarchy|  |
|shipment/emailFlow/hierarchyParentId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|shipment/emailFlow/hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |
|shipment/project/completed| *None* |Completed: Displays a check mark indicating if the project has been completed.|  |
|shipment/project/projectId| *None* |DB ID: Displays the database ID for a project row|  |
|shipment/project/name| *None* |Project name: Displays the Project's name|  |
|shipment/project/number| *None* |Number: Displays the project's number|  |
|shipment/project/type| *None* |Project type: Displays the project's type|  |
|shipment/project/status| *None* |Status: Displays the project's status|  |
|shipment/project/statusRank| *None* |Status rank: Rank of the project status in the status list|  |
|shipment/project/associateId| *None* |ID: Displays login ID of the associate who owns the project|  |
|shipment/project/hasInfoText| *None* |Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.|  |
|shipment/project/icon| *None* |Category: Displays the icon for an activity type|  |
|shipment/project/text| *None* |Text: Displays a descriptive text for the item|  |
|shipment/project/description| *None* |Description : Description|  |
|shipment/project/updatedBy| *None* |Updated by: The user who last updated the data|  |
|shipment/project/updatedByFullName| *None* |Updated by - Full name: The user who last updated the data|  |
|shipment/project/updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|shipment/project/registeredBy| *None* |Registered by: The user who registered the data|  |
|shipment/project/registeredByFullName| *None* |Registered by - Full name: The user who registered the data|  |
|shipment/project/registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|shipment/project/hasGuide| *None* |Guided: Does this sale have a Sales Guide|  |
|shipment/project/nextMilestone| *None* |Next milestone: Date of next non-completed activity that is marked as a milestone|  |
|shipment/project/endDate| *None* |End date: End date of project|  |
|shipment/project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|shipment/project/activeErpLinks| *None* |ERP connected: Is there an active ERP Sync?|  |
|shipment/project/projectPublish/isPublished| *None* |Published: Displays an icon indicating if the project or sale has been published|  |
|shipment/project/projectPublish/publishedFrom| *None* |From date: Start date for publishing. The record will not be visible prior to this date|  |
|shipment/project/projectPublish/publishedTo| *None* |To date: End date for publishing. The record will not be visible after this date|  |
|shipment/project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|shipment/project/projectEvent/isExternalEvent| *None* |Event: Is this an external event|  |
|shipment/project/projectEvent/eventDate| *None* |Event date: Event date|  |
|shipment/project/projectEvent/hasSignOn| *None* |Sign On: Does this event have the Sign On function enabled|  |
|shipment/project/projectEvent/hasSignOff| *None* |Sign Off: Does this event have the Sign Off function enabled|  |
|shipment/project/projectUrl/URLAddress| *None* |URL|  |
|shipment/project/projectUrl/URLDescription| *None* |Description|  |
|shipment/project/projectAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|shipment/project/projectAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|shipment/project/projectAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|shipment/project/projectAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|shipment/project/projectAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|shipment/project/projectAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|shipment/project/projectAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|shipment/project/projectAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|shipment/project/projectAssociate/associateDbId| *None* |ID|  |
|shipment/project/projectAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|shipment/project/projectAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|shipment/project/projectAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|shipment/project/projectAssociate/usergroupId| *None* |Group ID: The user's primary user group|  |
|shipment/project/projectAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|shipment/project/projectAssociate/contactCategory| *None* |Category: Category|  |
|shipment/project/projectAssociate/role| *None* |Role : Role|  |
|shipment/project/projectAssociate/assocName| *None* |User ID : User ID|  |
|shipment/project/projectAssociate/assocTooltip| *None* |Description : Description|  |
|shipment/project/projectAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|shipment/project/projectAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|shipment/project/projectAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|shipment/project/projectAssociate/ejDisplayName| *None* |Nickname: User's nickname in Service|  |
|shipment/project/projectAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|shipment/project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|shipment/project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|shipment/project/projectAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|shipment/project/projectAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|shipment/project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|shipment/project/projectAssociate/otherGroups| *None* |Other groups: Other groups|  |
|shipment/project/projectAssociate/userName| *None* |User name: User name|  |
|shipment/project/projectAssociate/personEmail| *None* |E-mail|  |
|shipment/project/projectAssociate/locationAddress| *None* |Location: Location|  |
|shipment/project/projectAssociate/isLocation| *None* |Is a location: Is a location|  |
|shipment/project/projectUdef/SuperOffice:1| *None* |projectshorttext|  |
|shipment/project/projectUdef/SuperOffice:2| *None* |projectlongtext|  |
|shipment/project/projectUdef/SuperOffice:3| *None* |projectnumber|  |
|shipment/project/projectUdef/SuperOffice:4| *None* |projectdate|  |
|shipment/project/projectUdef/SuperOffice:5| *None* |projectunlimiteddate|  |
|shipment/project/projectUdef/SuperOffice:6| *None* |projectcheckbox|  |
|shipment/project/projectUdef/SuperOffice:7| *None* |projectdropdownlistbox|  |
|shipment/project/projectUdef/SuperOffice:8| *None* |projectdecimal|  |
|shipment/project/projectUdef/SuperOffice:9| *None* |page1saleandmarketing|  |
|shipment/project/projectUdef/SuperOffice:10| *None* |page1saleandadmin|  |
|shipment/project/NumberOfActivities| *None* |Number of activities|  |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|shipment/project/NumberOfActivitiesInPeriod| *None* |Number of activities in last 90 days|  |
|shipment/project/NumberOfNotCompletedActivities| *None* |Number of non-completed activities|  |
|shipment/project/NumberOfNotCompletedActivitiesInPeriod| *None* |Number of non-completed activities in last 90 days|  |
|shipment/project/LastActivity| *None* |Date of last activity|  |
|shipment/project/LastCompletedActivity| *None* |Date of last completed activity|  |
|shipment/project/LastDoByActivity| *None* |Date of last non-completed activity|  |
|shipment/project/NumberOfSales| *None* |Number of sales|  |
|shipment/project/NumberOfSalesInPeriod| *None* |Number of sales in last 90 days|  |
|shipment/project/NumberOfNotCompletedSales| *None* |Number of non-completed sales|  |
|shipment/project/NumberOfNotCompletedSalesInPeriod| *None* |Number of non-completed sales in last 90 days|  |
|shipment/project/LastSale| *None* |Date of last sale|  |
|shipment/project/LastCompletedSale| *None* |Date of last completed sale|  |
|shipment/project/LastDoBySale| *None* |Date of last non-completed sale|  |
|shipment/project/SaintStatus3| *None* |Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|shipment/project/saintSaleStatus| *None* |With status|  |
|shipment/project/saintAmountClass| *None* |Amount class|  |
|shipment/project/saintActivityType| *None* |SAINT type|  |
|shipment/project/saintDirection| *None* |Direction|  |
|shipment/project/saintIntention| *None* |Intention|  |
|shipment/project/saintTicketStatus| *None* |Status|  |
|shipment/project/saintTicketCategory| *None* |Category|  |
|shipment/project/project/textId| *None* |Text ID|  |
|shipment/project/project/infoText| *None* |Information: Displays the text entered in the description field|  |
|contentDescription| *None* |Description: Form description|  |
|contentIcon| *None* |Icon: Icon| x |
|contentType| *None* |Type : Type| x |

## Sample

```http!
GET /api/v1/archive/EmailFlowContent?$select=emailFlow/mediumThumbnail,shipment/emailFlow/thumbnail,shipment/emailFlow/workflowEnrolledCount
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: mailingfavourites
title: mailingfavourites
description: 
keywords: mailingfavourites archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "mailingfavourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.MailingFavouritesProvider">SuperOffice.CRM.ArchiveLists.MailingFavouritesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"mailing"|Favourite mailing|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|mailingId|int|ID: Displays the ID of the mailing| x |
|mailingSelectionId|int|Selection ID: The database ID of the selection| x |
|mailingDescription|string|Name: Displays the name of the mailing| x |
|mailingSent|listAny|Sent: Displays the sent status of the mailing| x |
|mailingSimpleStatus|listAny|Status: Status| x |
|mailingEndDate|date|Date sent: Displays the date when the mailing was sent (completed)| x |
|mailingType|listAny|Type: Display the type of the mailing| x |
|mailingSubscriptionType|listAny|Subscription type: The subscription type for a mailing| x |
|mailingSentTo|int|Sent to: Displays to whom the mailing was sent| x |
|mailingOwner|associate|Owner: Displays the owner of the mailing| x |
|mailingFrom|string|From: Mailing from| x |
|mailingReplyTo|string|To: To| x |
|mailingSentCount|int|Number sent: Number of sent mailings| x |
|mailingOpenRate|decimal|Open rate: The open rate for a mailing| x |
|mailingClickRate|decimal|Click-through rate: Mailing click-through rate| x |
|mailingBounceRate|decimal|Bounce rate: Mailing bounce rate| x |
|mailingDeleted|bool|Deleted: Deleted|  |
|recipientStatus|listAny|Recipient status: Status of mailing recipient|  |
|icon| *None* |Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|type|listAny|Type: Displays the type of an activity| x |
|text|positiveString|Favourite: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|contactId|listAny|Company ID: Database ID of company| x |
|personId|listAny|Contact ID: Database ID of the contact row| x |
|projectId|listAny|Project ID: Database ID of project record| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|entityIcon| *None* |Row specific icon: Row specific icon| x |
|favouriteAssociateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|project/completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|project/projectId|int|DB ID: Displays the database ID for a project row| x |
|project/name|stringorPK|Project name: Displays the Project's name| x |
|project/number|string|Number: Displays the project's number| x |
|project/type|listAny|Project type: Displays the project's type| x |
|project/status|listAny|Status: Displays the project's status| x |
|project/statusRank| *None* |Status rank: Rank of the project status in the status list| x |
|project/associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|project/hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|project/icon| *None* |Category: Displays the icon for an activity type| x |
|project/text|string|Text: Displays a descriptive text for the item| x |
|project/description|string|Description : Description| x |
|project/updatedBy|associate|Updated by: The user who last updated the data| x |
|project/updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|project/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|project/registeredBy|associate|Registered by: The user who registered the data| x |
|project/registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|project/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|project/hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|project/nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|project/endDate|date|End date: End date of project| x |
|project/imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|project/activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|project/projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|project/projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|project/projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|project/projectPublish/publishedBy| *None* |Published by: Published by|  |
|project/projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|project/projectEvent/eventDate|date|Event date: Event date| x |
|project/projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|project/projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|project/projectUrl/URLAddress|string|URL| x |
|project/projectUrl/URLDescription|string|Description| x |
|project/projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|project/projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|project/projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|project/projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|project/projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|project/projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|project/projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/associateDbId|associate|ID| x |
|project/projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|project/projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|project/projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|project/projectAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|project/projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|project/projectAssociate/contactCategory|listAny|Category: Category| x |
|project/projectAssociate/role|listAny|Role : Role| x |
|project/projectAssociate/assocName|associate|User ID : User ID| x |
|project/projectAssociate/assocTooltip|string|Description : Description|  |
|project/projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|project/projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|project/projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|project/projectAssociate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|project/projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|project/projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|project/projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|project/projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|project/projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|project/projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|project/projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|project/projectAssociate/userName|string|User name: User name| x |
|project/projectAssociate/personEmail|string|E-mail| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|project/projectAssociate/locationAddress|string|Location: Location| x |
|project/projectAssociate/isLocation|bool|Is a location: Is a location| x |
|project/projectUdef/SuperOffice:1|string|projectshorttext| x |
|project/projectUdef/SuperOffice:2|string|projectlongtext| x |
|project/projectUdef/SuperOffice:3|int|projectnumber| x |
|project/projectUdef/SuperOffice:4|date|projectdate| x |
|project/projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|project/projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|project/projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|project/projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|project/projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|project/projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|project/NumberOfActivities|int|Number of activities|  |
|project/NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|project/NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|project/NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|project/LastActivity|date|Date of last activity|  |
|project/LastCompletedActivity|date|Date of last completed activity|  |
|project/LastDoByActivity|date|Date of last non-completed activity|  |
|project/NumberOfSales|int|Number of sales|  |
|project/NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|project/NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|project/NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|project/LastSale|date|Date of last sale|  |
|project/LastCompletedSale|date|Date of last completed sale|  |
|project/LastDoBySale|date|Date of last non-completed sale|  |
|project/SaintStatus3|saintStatus|Not completed activites with intention sale: Number of not completed activities for intention sale > 0.|  |
|project/saintSaleStatus|listAny|With status|  |
|project/saintAmountClass|listAny|Amount class|  |
|project/saintActivityType|listAny|SAINT type|  |
|project/saintDirection|listAny|Direction|  |
|project/saintIntention|listAny|Intention|  |
|project/saintTicketStatus|listAny|Status|  |
|project/saintTicketCategory|listAny|Category|  |
|project/project/textId|int|Text ID| x |
|project/project/infoText|positiveString|Information: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/mailingfavourites?$select=project/description,project/projectUdef/SuperOffice:4,project/text
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


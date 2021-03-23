---
uid: simpleshipment
title: simpleshipment
description: Archive provider for the list of mailings
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "simpleshipment"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "simpleshipment"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SimpleShipmentProvider">SuperOffice.CRM.ArchiveLists.SimpleShipmentProvider</see> inside NetServer's SODatabase assembly.

Archive provider for the list of mailings

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|All|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|mailingId|int|ID: Displays the ID of the mailing| x |
|selectionId|int|Selection ID: The database ID of the selection| x |
|mailingDescription|string|Name: Displays the name of the mailing| x |
|mailingSent|string|Sent: Displays the sent status of the mailing| x |
|mailingEndDate|date|Date: Displays the date of the mailing| x |
|mailingType|listAny|Type: Display the type of the mailing| x |
|mailingSentTo|int|Sent to: Displays to whom the mailing was sent| x |
|mailingOwner|associate|Owner: Displays the owner of the mailing| x |
|mailingDeleted|int|Deleted: Deleted|  |
|recipientStatus|int|Reception status: Status of mailing reception|  |
|icon| *None* |Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|type|listAny|Type: Displays the type of an activity| x |
|text|positiveString|Text: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|contactId|listAny|Company ID: Database ID of company| x |
|personId|listAny|Contact ID: Database ID of the contact row| x |
|projectId|listAny|Project ID: Database ID of project record| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|recordTypeText| *None* |Activity type: The type of the activity (appointment, phone call, etc)| x |
|associate/firstName|string|Associate - First name: Displays the contact's first name| x |
|associate/lastName|string|Associate - Last name: Displays the contact's last name| x |
|associate/middleName|string|Associate - Middle Name: Displays the contact's middle name.| x |
|associate/fullName|string|Associate - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|associate/contactId|int|Associate - Company ID: Database ID of the company the user belongs to|  |
|associate/personId|int|Associate - Contact ID: Database ID of the contact row|  |
|associate/mrMrs|string|Associate - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|associate/title|string|Associate - Title: Displays whether the contact is addressed as Mr or Ms| x |
|associate/associateDbId|associate|Associate - ID| x |
|associate/contactName|string|Associate - Owning company: Name of the company the user belongs to| x |
|associate/contactDepartment|string|Associate - Owning department: Name of the department at the company the user belongs to| x |
|associate/usergroup|userGroup|Associate - Primary group: The user's primary user group| x |
|associate/contactFullName|string|Associate - Owner: Name and department of the company the user belongs to| x |
|associate/contactCategory|listAny|Associate - Category: Category| x |
|associate/role|listAny|Associate - Role: Role| x |
|associate/assocName|associate|Associate - User ID: User ID| x |
|associate/assocTooltip|string|Associate - Description: Description|  |
|associate/assocType|listAny|Associate - Type: Type of user: associate, external user, system user, anonymous account| x |
|associate/ejUserId|int|Associate - Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser|bool|Associate - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName|string|Associate - Nick name: User's nick name in Service| x |
|associate/ejStatus|int|Associate - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Associate - Auth. type: What type of credentials to use when this user logs in| x |
|associate/credentialDisplayValue| *None* |Associate - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|associate/isActive|bool|Associate - Active: Is this user active, and should be able to log in?| x |
|associate/isActiveText|bool|Associate - Active status: Is this user active, and should be able to log in?| x |
|associate/portraitThumbnail| *None* |Associate - Person image: Person image|  |
|associate/otherGroups|userGroup|Associate - Other groups: Other groups|  |
|associate/userName|string|Associate - User name: User name| x |
|associate/personEmail|string|Associate - E-mail| x |
|project/completed|bool|Project - Completed: Displays a check mark indicating if the project has been completed.| x |
|project/projectId|int|Project - DB ID: Displays the database ID for a project row| x |
|project/name|stringorPK|Project - Project name: Displays the Project's name| x |
|project/number|string|Project - Number: Displays the project's number| x |
|project/type|listAny|Project - Project type: Displays the project's type| x |
|project/status|listAny|Project - Status: Displays the project's status| x |
|project/associateId|associate|Project - ID: Displays login ID of the associate who owns the project| x |
|project/hasInfoText|bool|Project - Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|project/icon| *None* |Project - Category: Displays the icon for an activity type| x |
|project/text|string|Project - Text: Displays a descriptive text for the item| x |
|project/description|string|Project - Description: Description| x |
|project/updatedBy|associate|Project - Updated by: The user who last updated the data| x |
|project/updatedDate|date|Project - Updated: The date/time the data was last updated in UTC.| x |
|project/registeredBy|associate|Project - Registered by: The user who registered the data| x |
|project/registeredDate|date|Project - Registered date: The date/time the data was registered in UTC.| x |
|project/hasGuide|bool|Project - Guided: Does this sale have a Sales Guide| x |
|project/nextMilestone|date|Project - Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|project/endDate|date|Project - End date: End date of project| x |
|project/imageThumbnail| *None* |Project - Thumbnail: Scaled-down image of project image|  |
|project/activeErpLinks|bool|Project - ERP connected: Is there an active ERP Sync?| x |
|project/projectPublish/isPublished|bool|Project - Published: Displays an icon indicating if the project or sale has been published| x |
|project/projectPublish/publishedFrom|date|Project - From date: Start date for publishing. The record will not be visible prior to this date| x |
|project/projectPublish/publishedTo|date|Project - To date: End date for publishing. The record will not be visible after this date| x |
|project/projectPublish/publishedBy| *None* |Project - Published by: Published by|  |
|project/projectEvent/isExternalEvent|bool|Project - Event: Is this an external event| x |
|project/projectEvent/eventDate|date|Project - Event date: Event date| x |
|project/projectEvent/hasSignOn|bool|Project - Sign On: Does this event have the Sign On function enabled| x |
|project/projectEvent/hasSignOff|bool|Project - Sign Off: Does this event have the Sign Off function enabled| x |
|project/projectUrl/URLAddress|string|Project - URL| x |
|project/projectUrl/URLDescription|string|Project - Description| x |
|project/projectAssociate/firstName|string|Project - First name: Displays the contact's first name| x |
|project/projectAssociate/lastName|string|Project - Last name: Displays the contact's last name| x |
|project/projectAssociate/middleName|string|Project - Middle Name: Displays the contact's middle name.| x |
|project/projectAssociate/fullName|string|Project - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|project/projectAssociate/contactId|int|Project - Company ID: Database ID of the company the user belongs to|  |
|project/projectAssociate/personId|int|Project - Contact ID: Database ID of the contact row|  |
|project/projectAssociate/mrMrs|string|Project - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/title|string|Project - Title: Displays whether the contact is addressed as Mr or Ms| x |
|project/projectAssociate/associateDbId|associate|Project - ID| x |
|project/projectAssociate/contactName|string|Project - Owning company: Name of the company the user belongs to| x |
|project/projectAssociate/contactDepartment|string|Project - Owning department: Name of the department at the company the user belongs to| x |
|project/projectAssociate/usergroup|userGroup|Project - Primary group: The user's primary user group| x |
|project/projectAssociate/contactFullName|string|Project - Owner: Name and department of the company the user belongs to| x |
|project/projectAssociate/contactCategory|listAny|Project - Category: Category| x |
|project/projectAssociate/role|listAny|Project - Role: Role| x |
|project/projectAssociate/assocName|associate|Project - User ID: User ID| x |
|project/projectAssociate/assocTooltip|string|Project - Description: Description|  |
|project/projectAssociate/assocType|listAny|Project - Type: Type of user: associate, external user, system user, anonymous account| x |
|project/projectAssociate/ejUserId|int|Project - Service user ID: The database ID of a Service user|  |
|project/projectAssociate/simultaneousEjUser|bool|Project - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|project/projectAssociate/ejDisplayName|string|Project - Nick name: User's nick name in Service| x |
|project/projectAssociate/ejStatus|int|Project - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|project/projectAssociate/credentialType| *None* |Project - Auth. type: What type of credentials to use when this user logs in| x |
|project/projectAssociate/credentialDisplayValue| *None* |Project - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|project/projectAssociate/isActive|bool|Project - Active: Is this user active, and should be able to log in?| x |
|project/projectAssociate/isActiveText|bool|Project - Active status: Is this user active, and should be able to log in?| x |
|project/projectAssociate/portraitThumbnail| *None* |Project - Person image: Person image|  |
|project/projectAssociate/otherGroups|userGroup|Project - Other groups: Other groups|  |
|project/projectAssociate/userName|string|Project - User name: User name| x |
|project/projectAssociate/personEmail|string|Project - E-mail| x |
|project/projectUdef/SuperOffice:1|string|Project - projectshorttext| x |
|project/projectUdef/SuperOffice:2|string|Project - projectlongtext| x |
|project/projectUdef/SuperOffice:3|int|Project - projectnumber| x |
|project/projectUdef/SuperOffice:4|date|Project - projectdate| x |
|project/projectUdef/SuperOffice:5|unlimitedDate|Project - projectunlimiteddate| x |
|project/projectUdef/SuperOffice:6|bool|Project - projectcheckbox| x |
|project/projectUdef/SuperOffice:7|listAny|Project - projectdropdownlistbox| x |
|project/projectUdef/SuperOffice:8|decimal|Project - projectdecimal| x |
|project/projectUdef/SuperOffice:9|int|Project - page1saleandmarketing| x |
|project/projectUdef/SuperOffice:10|int|Project - page1saleandadmin| x |
|project/NumberOfActivities|int|Project - Number of activities|  |
|project/NumberOfActivitiesInPeriod|int|Project - Number of activities in last 90 days|  |
|project/NumberOfNotCompletedActivities|int|Project - Number of non-completed activities|  |
|project/NumberOfNotCompletedActivitiesInPeriod|int|Project - Number of non-completed activities in last 90 days|  |
|project/LastActivity|date|Project - Date of last activity|  |
|project/LastCompletedActivity|date|Project - Date of last completed activity|  |
|project/LastDoByActivity|date|Project - Date of last non-completed activity|  |
|project/NumberOfSales|int|Project - Number of sales|  |
|project/NumberOfSalesInPeriod|int|Project - Number of sales in last 90 days|  |
|project/NumberOfNotCompletedSales|int|Project - Number of non-completed sales|  |
|project/NumberOfNotCompletedSalesInPeriod|int|Project - Number of non-completed sales in last 90 days|  |
|project/LastSale|date|Project - Date of last sale|  |
|project/LastCompletedSale|date|Project - Date of last completed sale|  |
|project/LastDoBySale|date|Project - Date of last non-completed sale|  |
|project/SaintStatus3|saintStatus|Project - Not completed activites with intention sale|  |
|project/saintSaleStatus|listAny|Project - With status|  |
|project/saintAmountClass|listAny|Project - Amount class|  |
|project/saintActivityType|listAny|Project - SAINT type|  |
|project/saintDirection|listAny|Project - Direction|  |
|project/saintIntention|listAny|Project - Intention|  |
|project/saintTicketStatus|listAny|Project - Status|  |
|project/saintTicketCategory|listAny|Project - Category|  |
|project/project/textId|int|Project - Text ID| x |
|project/project/infoText|positiveString|Project - Information: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/simpleshipment?$select=project/updatedDate,associate/isActive,project/activeErpLinks
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


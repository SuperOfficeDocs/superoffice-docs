---
uid: PersonProjects
title: PersonProjects
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "PersonProjects"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.PersonProjectsProvider">SuperOffice.CRM.ArchiveLists.PersonProjectsProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"project"|Projects|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|completed|bool|Completed: Displays a check mark indicating if the project has been completed.| x |
|projectId|int|DB ID: Displays the database ID for a project row| x |
|name|stringorPK|Project name: Displays the Project's name| x |
|number|string|Number: Displays the project's number| x |
|type|listAny|Project type: Displays the project's type| x |
|status|listAny|Status: Displays the project's status| x |
|associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|text|string|Text: Displays a descriptive text for the item| x |
|description|string|Description : Description| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|endDate|date|End date: End date of project| x |
|imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|personId|int|Contact ID: Database ID of the contact row| x |
|projectPublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|projectPublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|projectPublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|projectPublish/publishedBy| *None* |Published by: Published by|  |
|projectEvent/isExternalEvent|bool|Event: Is this an external event| x |
|projectEvent/eventDate|date|Event date: Event date| x |
|projectEvent/hasSignOn|bool|Sign On: Does this event have the Sign On function enabled| x |
|projectEvent/hasSignOff|bool|Sign Off: Does this event have the Sign Off function enabled| x |
|projectUrl/URLAddress|string|URL| x |
|projectUrl/URLDescription|string|Description| x |
|projectAssociate/firstName|string|First name: Displays the contact's first name| x |
|projectAssociate/lastName|string|Last name: Displays the contact's last name| x |
|projectAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|projectAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|projectAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|projectAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|projectAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|projectAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|projectAssociate/associateDbId|associate|ID| x |
|projectAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|projectAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|projectAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|projectAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|projectAssociate/contactCategory|listAny|Category: Category| x |
|projectAssociate/role|listAny|Role : Role| x |
|projectAssociate/assocName|associate|User ID : User ID| x |
|projectAssociate/assocTooltip|string|Description : Description|  |
|projectAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|projectAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|projectAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|projectAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|projectAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|projectAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|projectAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|projectAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|projectAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|projectAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|projectAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|projectAssociate/userName|string|User name: User name| x |
|projectAssociate/personEmail|string|E-mail| x |
|projectUdef/SuperOffice:1|string|projectshorttext| x |
|projectUdef/SuperOffice:2|string|projectlongtext| x |
|projectUdef/SuperOffice:3|int|projectnumber| x |
|projectUdef/SuperOffice:4|date|projectdate| x |
|projectUdef/SuperOffice:5|unlimitedDate|projectunlimiteddate| x |
|projectUdef/SuperOffice:6|bool|projectcheckbox| x |
|projectUdef/SuperOffice:7|listAny|projectdropdownlistbox| x |
|projectUdef/SuperOffice:8|decimal|projectdecimal| x |
|projectUdef/SuperOffice:9|int|page1saleandmarketing| x |
|projectUdef/SuperOffice:10|int|page1saleandadmin| x |
|NumberOfActivities|int|Number of activities|  |
|NumberOfActivitiesInPeriod|int|Number of activities in last 90 days|  |
|NumberOfNotCompletedActivities|int|Number of non-completed activities|  |
|NumberOfNotCompletedActivitiesInPeriod|int|Number of non-completed activities in last 90 days|  |
|LastActivity|date|Date of last activity|  |
|LastCompletedActivity|date|Date of last completed activity|  |
|LastDoByActivity|date|Date of last non-completed activity|  |
|NumberOfSales|int|Number of sales|  |
|NumberOfSalesInPeriod|int|Number of sales in last 90 days|  |
|NumberOfNotCompletedSales|int|Number of non-completed sales|  |
|NumberOfNotCompletedSalesInPeriod|int|Number of non-completed sales in last 90 days|  |
|LastSale|date|Date of last sale|  |
|LastCompletedSale|date|Date of last completed sale|  |
|LastDoBySale|date|Date of last non-completed sale|  |
|SaintStatus3|saintStatus|Not completed activites with intention sale|  |
|saintSaleStatus|listAny|With status|  |
|saintAmountClass|listAny|Amount class|  |
|saintActivityType|listAny|SAINT type|  |
|saintDirection|listAny|Direction|  |
|saintIntention|listAny|Intention|  |
|saintTicketStatus|listAny|Status|  |
|saintTicketCategory|listAny|Category|  |
|project/textId|int|Text ID| x |
|project/infoText|positiveString|Information: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/PersonProjects?$select=projectUrl/URLDescription,projectAssociate/assocName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: AssociateProjects
title: AssociateProjects
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "AssociateProjects"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "AssociateProjects"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.AssociateProjectsProvider">SuperOffice.CRM.ArchiveLists.AssociateProjectsProvider</see> inside NetServer's SODatabase assembly.

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
|project/textId|int|Text ID| x |
|project/infoText|positiveString|Information: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/AssociateProjects?$select=updatedDate,projectPublish/isPublished
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


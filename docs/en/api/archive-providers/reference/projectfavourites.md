---
uid: projectfavourites
title: projectfavourites
description: 
keywords: projectfavourites archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "projectfavourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ProjectFavouritesProvider">SuperOffice.CRM.ArchiveLists.ProjectFavouritesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"project"|Favourite project|

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
|statusRank| *None* |Status rank: Rank of the project status in the status list| x |
|associateId|associate|ID: Displays login ID of the associate who owns the project| x |
|hasInfoText|bool|Info: Displays an icon indicating if the project has a description text. The text itself will be displayed in a tooltip.| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|text|positiveString|Favourite: Displays a descriptive text for the item| x |
|description|string|Description : Description| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|nextMilestone|date|Next milestone: Date of next non-completed activity that is marked as a milestone| x |
|endDate|date|End date: End date of project| x |
|imageThumbnail| *None* |Thumbnail: Scaled-down image of project image|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|entityIcon| *None* |Row specific icon: Row specific icon| x |
|favouriteAssociateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|project/textId|int|Text ID| x |
|project/infoText|positiveString|Information: Displays the text entered in the description field| x |

## Sample

```http!
GET /api/v1/archive/projectfavourites?$select=associateId,updatedBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


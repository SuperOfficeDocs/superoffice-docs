---
uid: LinksSelection
title: LinksSelection
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "LinksSelection"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "LinksSelection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksSelectionProvider">SuperOffice.CRM.ArchiveLists.LinksSelectionProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"Selection"|Selection|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|sourceAppointmentRestrictionId|int|Source follow-up ID: Unique ID of follow-up to fetch link data for|  |
|sourceSaleRestrictionId|int|Source sale ID: Unique ID of sale to fetch link data for|  |
|sourceDocumentRestrictionId|int|Source document ID: Unique ID of document to fetch link data for|  |
|sourceProjectRestrictionId|int|Source project ID: Unique ID of project there is a link from|  |
|sourcePersonRestrictionId|int|Contact ID: Database ID of the contact row|  |
|sourceContactRestrictionId|int|Company ID: Database ID of company|  |
|sourceSelectionRestrictionId|int|Selection ID: The database ID of the selection|  |
|linkId|int|Link ID: Unique ID of relation between linked entities|  |
|linkDescription|string|Link description: A description of the relation between linked entities|  |
|selectionId|int|Selection ID: The database ID of the selection| x |
|name|stringorPK|Selection name: The name of the selection| x |
|type|listAny|Category: The type of selection| x |
|kind|listAny|Selection is : The kind of selection (static, dynamic or combined)| x |
|targetTableNumber|listAny|Selection of: Displays what the selection consists of| x |
|associateId|associate|Associate: The employee who owns the selection| x |
|combinationType|listAny|Combination type: Displays the combination type for a selection| x |
|done|bool|Completed: Shows whether the selection has been completed| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|lastLoaded|date|Viewed: When was the result list for the selection last shown| x |
|lastLoadedBy|associate|Viewed by: Who was the last person to show the result list for the selection| x |
|lastMembershipChange|date|Members changed: When was the result list for the selection last changed, for instance due to a change in the criteria| x |
|lastMembershipChangeBy|associate|Members changed by: Who was the last person to change the result list for the selection, for instance by changing the criteria| x |
|memberCount|int|Members: How many members were in the selection, the last time all were fetched. May be imprecise/outdated.| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|text|string|Text: Displays a descriptive text for the item| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|completed|bool|Completed: Shows whether the selection has been completed| x |
|visibleFor|listAny|Visible for|  |
|destinationSelectionRestrictionId|int|ADD LINK Selection DESTINATION RESOURCE: ADD LINK Selection DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/LinksSelection?$select=linkId,kind,selectionId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


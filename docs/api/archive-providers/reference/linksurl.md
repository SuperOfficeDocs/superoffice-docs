---
uid: LinksURL
title: LinksURL
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

# "LinksURL"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksURLProvider">SuperOffice.CRM.ArchiveLists.LinksURLProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"url"|[url]|

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
|URLAddress|string|URL| x |
|URLDescription|string|Description| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|text|string|Text: Displays a descriptive text for the item| x |
|destinationURLRestrictionId|int|ADD LINK URL DESTINATION RESOURCE: ADD LINK URL DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/LinksURL?$select=sourceProjectRestrictionId,sourceSelectionRestrictionId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


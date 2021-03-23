---
uid: LinksContact
title: LinksContact
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "LinksContact"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "LinksContact"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.LinksContactProvider">SuperOffice.CRM.ArchiveLists.LinksContactProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"Contact"|Company|

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
|contactId|int|Company ID: Database ID of company| x |
|name|stringorPK|Company name| x |
|department|string|Department| x |
|nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|hasInfoText|bool|Has note: Displays an icon indicating if there is additional information available about the contact| x |
|hasInterests|bool|Has interests: Displays an Icon indicating if the contact has active interests| x |
|associateId|associate|Our contact: Displays our contact| x |
|category|listAny|Category| x |
|business|listAny|Business| x |
|country|listAny|Country: This criterion corresponds to the Country field on the Company card.| x |
|number|string|Number| x |
|code|string|Code| x |
|orgnr|string|VAT No.| x |
|stop|bool|Stop| x |
|contactNoMail|bool|No mailings (company| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|contactSource|listAny|Source: Source (Company)| x |
|contactDeleted|bool|Deleted: Deleted| x |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|deletedDate|datetime|Deleted date: Deleted date|  |
|mainContact| *None* |Main contact: Main contact for this company| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|text|string|Text: Displays a descriptive text for the item| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|type|listAny|Type: Displays the type of an activity| x |
|completed|bool|Completed: Shows whether the selection has been completed| x |
|destinationContactRestrictionId|int|ADD LINK Contact DESTINATION RESOURCE: ADD LINK Contact DESTINATION TOOLTIP RESOURCE|  |

## Sample

```http!
GET /api/v1/archive/LinksContact?$select=department,country
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


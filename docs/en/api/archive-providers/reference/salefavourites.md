---
uid: salefavourites
title: salefavourites
description: 
keywords: salefavourites archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "salefavourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SaleFavouritesProvider">SuperOffice.CRM.ArchiveLists.SaleFavouritesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"sale"|Favourite sale|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|completed|bool|Completed: Displays a checkbox showing if an appointment is completed| x |
|icon|listAny|Category: Displays the icon for an activity type| x |
|date|date|Date: Displays start date of a follow-up / sale date of a sale| x |
|time| *None* |Time: Time|  |
|type|listAny|Type: Displays the type of an activity| x |
|recordType|string|Record type : Shows the record type| x |
|text|positiveString|Favourite: Displays a descriptive text for the item| x |
|associateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|contactId|listAny|Company ID: Database ID of company| x |
|personId|listAny|Contact ID: Database ID of the contact row| x |
|projectId|listAny|Project ID: Database ID of project record| x |
|saleId|int|Sale ID: The database ID of the sale record| x |
|userGroup|userGroup|User group : The user group that owns the record| x |
|who| *None* |Who: Contact and/or company|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|currencyId|int|Currency ID: The currency list item ID| x |
|currency|listAny|Currency: The currency of the sale| x |
|credited|listAny|Credited: The user to be credited with the sale| x |
|lossReason|listAny|Reason (lost: The reason for losing the sale| x |
|source|listAny|Source: The source (lead) of the sale| x |
|competitor|listAny|Competitor: The competitor who won the sale| x |
|heading|stringorPK|Sale: The name of the sale| x |
|amount|decimal|Amount: The gross sales total| x |
|amountWeighted|decimal|Weighted amount: Virtual field calculated from amount * probability percent.| x |
|earning|decimal|Profit: Gross profit (gross sales total - cost) for the sale| x |
|earningPercent|decimal|Profit as % : The profit as a percentage of the gross sales total| x |
|probPercent|int|Probability as %: Probability as %| x |
|originalStage|listAny|Stage when closed: Stage when closed| x |
|stage|listAny|Stage: Displays the stage of the sale| x |
|stageName| *None* |Stage name: Displays the stage of the sale| x |
|saleStatus|listAny|Status: The status of the sale - open, lost or sold| x |
|stageRank| *None* |Stage rank: Rank of the sale stage in the stage list| x |
|saleType|listAny|Sale type: Sale type, from list| x |
|saleTypeId| *None* |Sale type ID: Sale type, from list| x |
|stageId| *None* |Sale stage ID: Displays the stage of the sale| x |
|nextDueDate|date|Next activity: Date for next activity for a sale, updated live from the sale's activities| x |
|reopenDate|date|Reopen date: Displays the reopen date for the sale| x |
|stalledComment|listAny|Reason (stalled: The reason the sale has been stalled| x |
|saleTypeCategory|listAny|Sale type category: Sale type category| x |
|soldReason|listAny|Reason (sold: Reason (sold)| x |
|saleNumber|string|Number: Number| x |
|hasStakeholders|bool|Has stakeholders: Does this sale have stakeholders| x |
|stakeholdersEnabled|bool|Stakeholders enabled: Does this sale have stakeholders enabled| x |
|hasQuote|bool|Has quote?: Does the sale have a quote attached?| x |
|hasGuide|bool|Guided: Does this sale have a Sales Guide| x |
|description|string|Description: The long description field on Sale|  |
|activeErpLinks|bool|ERP connected: Is there an active ERP Sync?| x |
|createdByWorkflow|listAny|Created by flow: Created by flow| x |
|amountInBaseCurrency| *None* |Amount (BaseCurrency: The gross sales total| x |
|amountWeightedInBaseCurrency| *None* |Weighted amount (BaseCurrency: Virtual field calculated from amount * probability percent.| x |
|daysInStage| *None* |Days in stage: Total number of days in this stage| x |
|entityIcon| *None* |Row specific icon: Row specific icon| x |
|favouriteAssociateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|visibleFor|listAny|Visible for|  |
|sale/textId|int|Text ID| x |
|sale/description|positiveString|Text: Displays the text entered in the description field| x |
|salePublish/isPublished|bool|Published: Displays an icon indicating if the project or sale has been published| x |
|salePublish/publishedFrom|date|From date: Start date for publishing. The record will not be visible prior to this date| x |
|salePublish/publishedTo|date|To date: End date for publishing. The record will not be visible after this date| x |
|salePublish/publishedBy| *None* |Published by: Published by|  |
|associate/firstName|string|First name: Displays the contact's first name| x |
|associate/lastName|string|Last name: Displays the contact's last name| x |
|associate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|associate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|associate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|associate/personId|int|Contact ID: Database ID of the contact row|  |
|associate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|associate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|associate/associateDbId|associate|ID| x |
|associate/contactName|string|Owning company: Name of the company the user belongs to| x |
|associate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|associate/usergroup|userGroup|Primary group: The user's primary user group| x |
|associate/usergroupId|int|Group ID: The user's primary user group| x |
|associate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|associate/contactCategory|listAny|Category: Category| x |
|associate/role|listAny|Role : Role| x |
|associate/assocName|associate|User ID : User ID| x |
|associate/assocTooltip|string|Description : Description|  |
|associate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|associate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName|string|Nickname: User's nickname in Service| x |
|associate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|associate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|associate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|associate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|associate/portraitThumbnail| *None* |Person image: Person image|  |
|associate/otherGroups|userGroup|Other groups: Other groups|  |
|associate/userName|string|User name: User name| x |
|associate/personEmail|string|E-mail| x |
|associate/locationAddress|string|Location: Location| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|associate/isLocation|bool|Is a location: Is a location| x |
|saleUdef/SuperOffice:1|string|saleshorttext| x |
|saleUdef/SuperOffice:2|string|salelongtext| x |
|saleUdef/SuperOffice:3|int|salenumber| x |
|saleUdef/SuperOffice:4|date|saledate| x |
|saleUdef/SuperOffice:5|unlimitedDate|saleunlimiteddate| x |
|saleUdef/SuperOffice:6|bool|salecheckbox| x |
|saleUdef/SuperOffice:7|listAny|saledropdownlistbox| x |
|saleUdef/SuperOffice:8|decimal|saledecimal| x |

## Sample

```http!
GET /api/v1/archive/salefavourites?$select=stageId,stageName,createdByWorkflow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


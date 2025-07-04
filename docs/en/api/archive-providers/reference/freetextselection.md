---
uid: FreetextSelection
title: FreetextSelection
description: Archive provider for freetext search on the Selection entity.
keywords: FreetextSelection archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "FreetextSelection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.FreetextSelectionResultProvider">SuperOffice.CRM.ArchiveLists.FreetextSelectionResultProvider</see> inside NetServer's SODatabase assembly.

Archive provider for freetext search on the Selection entity.


Use the 'searchwords' restriction with one or more words to specify what to search for. The operator is ignored,
the freetext search will apply the 'begins' operator to each word and 'AND' between them.


It is possible to combine freetext search words with other restrictions and criteria native to the entity and
its standard subproviders. Note however that this is not the same search as provided by the 'Find' providers, since
they apply various special rules not present here.


Freetext search will limit the number of hits to the first 1000. This clipping is applied before any other criteria,
as well as before any ORDER BY, are applied.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"selection"|Selection|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|searchwords|string|Search word: One or more words to be used in free text search|  |
|selectionId|int|Selection ID: The database ID of the selection| x |
|name|stringorPK|Selection name: The name of the selection| x |
|type|listAny|Category: The type of selection| x |
|kind|listAny|Selection is : The kind of selection (static, dynamic or combined)| x |
|targetTableNumber|listAny|Selection of: Displays what the selection consists of| x |
|associateId|associate|Associate: The employee who owns the selection| x |
|combinationType|listAny|Combination type: Displays the combination type for a selection| x |
|done|bool|Completed: Shows whether the selection has been completed| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredByFullName|associate|Registered by - Full name: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|lastLoaded|date|Last used: When was the result list for the selection last shown| x |
|lastLoadedBy|associate|Last used by: Who was the last person to show the result list for the selection| x |
|lastLoadedByFullName|associate|Last used by - Full name: Who was the last person to show the result list for the selection| x |
|lastMembershipChange|date|Members changed: When was the result list for the selection last changed, for instance due to a change in the criteria| x |
|lastMembershipChangeBy|associate|Members changed by: Who was the last person to change the result list for the selection, for instance by changing the criteria| x |
|lastMembershipChangeByFullName|associate|Members changed by - Full name: Who was the last person to change the result list for the selection, for instance by changing the criteria| x |
|memberCount|int|Members: How many members were in the selection, the last time all were fetched. May be imprecise/outdated.| x |
|visibleFor|listAny|Visible for|  |
|selectionAssociate/firstName|string|First name: Displays the contact's first name| x |
|selectionAssociate/lastName|string|Last name: Displays the contact's last name| x |
|selectionAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|selectionAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|selectionAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|selectionAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|selectionAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|selectionAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|selectionAssociate/associateDbId|associate|ID| x |
|selectionAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|selectionAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|selectionAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|selectionAssociate/usergroupId|int|Group ID: The user's primary user group| x |
|selectionAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|selectionAssociate/contactCategory|listAny|Category: Category| x |
|selectionAssociate/role|listAny|Role : Role| x |
|selectionAssociate/assocName|associate|User ID : User ID| x |
|selectionAssociate/assocTooltip|string|Description : Description|  |
|selectionAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|selectionAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|selectionAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|selectionAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|selectionAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|selectionAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|selectionAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|selectionAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|selectionAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|selectionAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|selectionAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|selectionAssociate/userName|string|User name: User name| x |
|selectionAssociate/personEmail|string|E-mail| x |
|selectionAssociate/locationAddress|string|Location: Location| x |
|selectionAssociate/isLocation|bool|Is a location: Is a location| x |

## Sample

```http!
GET /api/v1/archive/FreetextSelection?$select=done,lastLoadedByFullName,selectionAssociate/contactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


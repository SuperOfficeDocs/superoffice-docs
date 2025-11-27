---
uid: EmailFlows
title: EmailFlows
description: Archive of Email flows.
keywords: EmailFlows archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "EmailFlows"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowProvider">SuperOffice.CRM.ArchiveLists.EmailFlowProvider</see> inside NetServer's SODatabase assembly.

Archive of Email flows.
Lists all email flows

## Supported Entities
| Name | Description |
| ---- | ----- |
|"emailflow"|emailflow|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|emailFlowId|int|E-mail flow ID: The database ID of the e-mail flow| x |
|emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|shipmentType|listAny|Mailing type: Mailing type this e-mail flow represents| x |
|overrideConsentSubscription|bool|Override consent: Should consent subscriptions be overridden for this flow?| x |
|thumbnail| *None* |Thumbnail|  |
|mediumThumbnail| *None* |Thumbnail|  |
|workflowId|int|Flow id: Id of a flow definition| x |
|workflowName|string|Name: Name of the flow definition| x |
|workflowDescription|string|Description: Description of flow definition| x |
|workflowDefinitionStatus|listAny|Status: Status of the flow definition| x |
|workflowDefinitionStatusId|listAny|Status: Status of the flow definition| x |
|jumpToFinish|bool|Jump to finish: Should participant jump to finish when the goals are met?| x |
|startOnlyOnce|bool|Start only once: Should the participant enter the flow only once?| x |
|workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this flow?|  |
|workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|workflowSucceededCount| *None* |Succeeded: How many participants have successfully completed the flow (goal criteria met)?|  |
|workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|workflowAssociate/firstName|string|Owner - First name: Displays the contact's first name| x |
|workflowAssociate/lastName|string|Owner - Last name: Displays the contact's last name| x |
|workflowAssociate/middleName|string|Owner - Middle Name: Displays the contact's middle name.| x |
|workflowAssociate/fullName|string|Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|workflowAssociate/contactId|int|Owner - Company ID: Database ID of the company the user belongs to|  |
|workflowAssociate/personId|int|Owner - Contact ID: Database ID of the contact row|  |
|workflowAssociate/mrMrs|string|Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|workflowAssociate/title|string|Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |
|workflowAssociate/associateDbId|associate|Owner - ID| x |
|workflowAssociate/contactName|string|Owner - Owning company: Name of the company the user belongs to| x |
|workflowAssociate/contactDepartment|string|Owner - Owning department: Name of the department at the company the user belongs to| x |
|workflowAssociate/usergroup|userGroup|Owner - Primary group: The user's primary user group| x |
|workflowAssociate/usergroupId|int|Owner - Group ID: The user's primary user group| x |
|workflowAssociate/contactFullName|string|Owner - Owner: Name and department of the company the user belongs to| x |
|workflowAssociate/contactCategory|listAny|Owner - Category: Category| x |
|workflowAssociate/role|listAny|Owner - Role: Role| x |
|workflowAssociate/assocName|associate|Owner - User ID: User ID| x |
|workflowAssociate/assocTooltip|string|Owner - Description: Description|  |
|workflowAssociate/assocType|listAny|Owner - Type: Type of user: associate, external user, system user, anonymous account| x |
|workflowAssociate/ejUserId|int|Owner - Service user ID: The database ID of a Service user|  |
|workflowAssociate/simultaneousEjUser|bool|Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|workflowAssociate/ejDisplayName|string|Owner - Nickname: User's nickname in Service| x |
|workflowAssociate/ejStatus|int|Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|workflowAssociate/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in| x |
|workflowAssociate/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|workflowAssociate/isActive|bool|Owner - Active: Is this user active, and should be able to log in?| x |
|workflowAssociate/isActiveText|bool|Owner - Active status: Is this user active, and should be able to log in?| x |
|workflowAssociate/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|workflowAssociate/otherGroups|userGroup|Owner - Other groups: Other groups|  |
|workflowAssociate/userName|string|Owner - User name: User name| x |
|workflowAssociate/personEmail|string|Owner - E-mail| x |
|workflowAssociate/locationAddress|string|Owner - Location: Location| x |
|workflowAssociate/isLocation|bool|Owner - Is a location: Is a location| x |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |

## Sample

```http!
GET /api/v1/archive/EmailFlows?$select=workflowAssociate/ejDisplayName,updatedBy,workflowAssociate/title
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


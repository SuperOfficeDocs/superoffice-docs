---
uid: EmailFlowsAndFolders
title: EmailFlowsAndFolders
description: Archive of EmailFlows and Folders.
keywords: EmailFlowsAndFolders archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "EmailFlowsAndFolders"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowsAndFoldersProvider">SuperOffice.CRM.ArchiveLists.EmailFlowsAndFoldersProvider</see> inside NetServer's SODatabase assembly.

Archive of EmailFlows and Folders.
Combines all EmailFlows and EmailFlowFolders in one archive together.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"emailflow"|emailflow|
|"emailflowfolder"|emailflowfolder|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|emailFlowId| *None* |E-mail flow ID: The database ID of the e-mail flow|  |
|emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|shipmentType| *None* |Mailing type: Mailing type this e-mail flow represents|  |
|overrideConsentSubscription| *None* |Override consent: Should consent subscriptions be overridden for this flow?|  |
|thumbnail| *None* |Thumbnail|  |
|mediumThumbnail| *None* |Thumbnail|  |
|workflowId| *None* |Flow id: Id of a flow definition|  |
|name|string|Name: Name of the flow definition| x |
|workflowDescription| *None* |Description: Description of flow definition|  |
|workflowDefinitionStatus| *None* |Status: Status of the flow definition|  |
|workflowDefinitionStatusId| *None* |Status: Status of the flow definition|  |
|jumpToFinish| *None* |Jump to finish: Should participant jump to finish when the goals are met?|  |
|startOnlyOnce| *None* |Start only once: Should the participant enter the flow only once?|  |
|workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this flow?|  |
|workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|workflowSucceededCount| *None* |Succeeded: How many participants have successfully completed the flow (goal criteria met)?|  |
|workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|updatedBy| *None* |Updated by: The user who last updated the data|  |
|updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|registeredBy| *None* |Registered by: The user who registered the data|  |
|registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|workflowAssociate/firstName| *None* |Owner - First name: Displays the contact's first name|  |
|workflowAssociate/lastName| *None* |Owner - Last name: Displays the contact's last name|  |
|workflowAssociate/middleName| *None* |Owner - Middle Name: Displays the contact's middle name.|  |
|workflowAssociate/fullName| *None* |Owner - Full name: Displays full name of user (first, middle, last - according to settings)|  |
|workflowAssociate/contactId| *None* |Owner - Company ID: Database ID of the company the user belongs to|  |
|workflowAssociate/personId| *None* |Owner - Contact ID: Database ID of the contact row|  |
|workflowAssociate/mrMrs| *None* |Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|workflowAssociate/title| *None* |Owner - Title: Displays whether the contact is addressed as Mr or Ms|  |
|workflowAssociate/associateDbId| *None* |Owner - ID|  |
|workflowAssociate/contactName| *None* |Owner - Owning company: Name of the company the user belongs to|  |
|workflowAssociate/contactDepartment| *None* |Owner - Owning department: Name of the department at the company the user belongs to|  |
|workflowAssociate/usergroup| *None* |Owner - Primary group: The user's primary user group|  |
|workflowAssociate/usergroupId| *None* |Owner - Group ID: The user's primary user group|  |
|workflowAssociate/contactFullName| *None* |Owner - Owner: Name and department of the company the user belongs to|  |
|workflowAssociate/contactCategory| *None* |Owner - Category: Category|  |
|workflowAssociate/role| *None* |Owner - Role: Role|  |
|workflowAssociate/assocName| *None* |Owner - User ID: User ID|  |
|workflowAssociate/assocTooltip| *None* |Owner - Description: Description|  |
|workflowAssociate/assocType| *None* |Owner - Type: Type of user: associate, external user, system user, anonymous account|  |
|workflowAssociate/ejUserId| *None* |Owner - Service user ID: The database ID of a Service user|  |
|workflowAssociate/simultaneousEjUser| *None* |Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|workflowAssociate/ejDisplayName| *None* |Owner - Nickname: User's nickname in Service|  |
|workflowAssociate/ejStatus| *None* |Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|workflowAssociate/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in|  |
|workflowAssociate/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|workflowAssociate/isActive| *None* |Owner - Active: Is this user active, and should be able to log in?|  |
|workflowAssociate/isActiveText| *None* |Owner - Active status: Is this user active, and should be able to log in?|  |
|workflowAssociate/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|workflowAssociate/otherGroups| *None* |Owner - Other groups: Other groups|  |
|workflowAssociate/userName| *None* |Owner - User name: User name|  |
|workflowAssociate/personEmail| *None* |Owner - E-mail|  |
|workflowAssociate/locationAddress| *None* |Owner - Location: Location|  |
|workflowAssociate/isLocation| *None* |Owner - Is a location: Is a location|  |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName| *None* |Hierarchy name: The full name/path from table hierarchy|  |
|hierarchyParentId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |

## Sample

```http!
GET /api/v1/archive/EmailFlowsAndFolders?$select=workflowAssociate/ejDisplayName,updatedBy,workflowAssociate/title
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


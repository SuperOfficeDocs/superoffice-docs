---
uid: EmailFlowsAndFolders
title: EmailFlowsAndFolders
description: Archive of EmailFlows and Folders.
keywords: EmailFlowsAndFolders archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "EmailFlowsAndFolders"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowsAndFoldersProvider">SuperOffice.CRM.ArchiveLists.EmailFlowsAndFoldersProvider</see> inside NetServer's SODatabase assembly.

Archive of EmailFlows and Folders.
Combines all EmailFlows and EmailFlowFolders in one archive together.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"emailflow"|[emailflow]|
|"emailflowfolder"|[emailflowfolder]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|emailFlowId| *None* |Email flow Id: The database Id of the email flow|  |
|emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|shipmentType| *None* |Mailing type: Mailing type this e-mail flow represents|  |
|overrideConsentSubscription| *None* |Override consent: Should consent subscriptions be overridden for this workflow?|  |
|thumbnail| *None* |Thumbnail|  |
|updatedBy| *None* |Updated by: The user who last updated the data|  |
|updatedDate| *None* |Updated: The date/time the data was last updated in UTC.|  |
|registeredBy| *None* |Registered by: The user who registered the data|  |
|registeredDate| *None* |Registered date: The date/time the data was registered in UTC.|  |
|workflowId| *None* |Workflow id: Id of a worflow definition|  |
|name|string|Name: Name of the workflow definition| x |
|workflowDescription| *None* |Description: Description of the workflow definition|  |
|workflowDefinitionStatus| *None* |E-mail flow status: Status of the workflow definition|  |
|jumpToFinish| *None* |Jump to finish: Should participant jump to finish when the goals are met?|  |
|startOnlyOnce| *None* |Start only once: Should the participant enter the workflow only once?|  |
|workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this workflow|  |
|workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|workflowSucceededCount| *None* |Succeeded: How many participants has successfully finished the workflow (goals criteria met)|  |
|workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|workflowAssociate/firstName| *None* |First name: Displays the contact's first name|  |
|workflowAssociate/lastName| *None* |Last name: Displays the contact's last name|  |
|workflowAssociate/middleName| *None* |Middle Name : Displays the contact's middle name.|  |
|workflowAssociate/fullName| *None* |Full name: Displays full name of user (first, middle, last - according to settings)|  |
|workflowAssociate/contactId| *None* |Company ID: Database ID of the company the user belongs to|  |
|workflowAssociate/personId| *None* |Contact ID: Database ID of the contact row|  |
|workflowAssociate/mrMrs| *None* |Mr/Ms: Displays whether the contact is addressed as Mr or Ms|  |
|workflowAssociate/title| *None* |Title: Displays whether the contact is addressed as Mr or Ms|  |
|workflowAssociate/associateDbId| *None* |ID|  |
|workflowAssociate/contactName| *None* |Owning company: Name of the company the user belongs to|  |
|workflowAssociate/contactDepartment| *None* |Owning department: Name of the department at the company the user belongs to|  |
|workflowAssociate/usergroup| *None* |Primary group: The user's primary user group|  |
|workflowAssociate/contactFullName| *None* |Owner: Name and department of the company the user belongs to|  |
|workflowAssociate/contactCategory| *None* |Category: Category|  |
|workflowAssociate/role| *None* |Role : Role|  |
|workflowAssociate/assocName| *None* |User ID : User ID|  |
|workflowAssociate/assocTooltip| *None* |Description : Description|  |
|workflowAssociate/assocType| *None* |Type: Type of user: associate, external user, system user, anonymous account|  |
|workflowAssociate/ejUserId| *None* |Service user ID: The database ID of a Service user|  |
|workflowAssociate/simultaneousEjUser| *None* |Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|workflowAssociate/ejDisplayName| *None* |Nick name: User's nick name in Service|  |
|workflowAssociate/ejStatus| *None* |Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|workflowAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in|  |
|workflowAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in|  |
|workflowAssociate/isActive| *None* |Active: Is this user active, and should be able to log in?|  |
|workflowAssociate/isActiveText| *None* |Active status: Is this user active, and should be able to log in?|  |
|workflowAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|workflowAssociate/otherGroups| *None* |Other groups: Other groups|  |
|workflowAssociate/userName| *None* |User name: User name|  |
|workflowAssociate/personEmail| *None* |E-mail|  |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName| *None* |Hierarchy name: The full name/path from table hierarchy|  |
|hierarchyParentId| *None* |Hierarchy ID: Foreign key to hierarchy table|  |
|hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |

## Sample

```http!
GET /api/v1/archive/EmailFlowsAndFolders?$select=workflowAssociate/assocTooltip,workflowAssociate/credentialType,workflowCompletedCount
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


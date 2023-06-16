---
uid: EmailFlows
title: EmailFlows
description: Archive of Email flows.
keywords: EmailFlows archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "EmailFlows"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowProvider">SuperOffice.CRM.ArchiveLists.EmailFlowProvider</see> inside NetServer's SODatabase assembly.

Archive of Email flows.
Lists all email flows

## Supported Entities
| Name | Description |
| ---- | ----- |
|"emailflow"|[emailflow]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|emailFlowId|int|Email flow Id: The database Id of the email flow| x |
|emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|shipmentType|listAny|Mailing type: Mailing type this e-mail flow represents| x |
|overrideConsentSubscription|bool|Override consent: Should consent subscriptions be overridden for this workflow?| x |
|thumbnail| *None* |Thumbnail|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|workflowId|int|Workflow id: Id of a worflow definition| x |
|workflowName|string|Name: Name of the workflow definition| x |
|workflowDescription|string|Description: Description of the workflow definition| x |
|workflowDefinitionStatus|listAny|Status: Status of the workflow definition| x |
|jumpToFinish|bool|Jump to finish: Should participant jump to finish when the goals are met?| x |
|startOnlyOnce|bool|Start only once: Should the participant enter the workflow only once?| x |
|workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this workflow|  |
|workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|workflowSucceededCount| *None* |Succeeded: How many participants has successfully finished the workflow (goals criteria met)|  |
|workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|workflowAssociate/firstName|string|First name: Displays the contact's first name| x |
|workflowAssociate/lastName|string|Last name: Displays the contact's last name| x |
|workflowAssociate/middleName|string|Middle Name : Displays the contact's middle name.| x |
|workflowAssociate/fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|workflowAssociate/contactId|int|Company ID: Database ID of the company the user belongs to|  |
|workflowAssociate/personId|int|Contact ID: Database ID of the contact row|  |
|workflowAssociate/mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|workflowAssociate/title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|workflowAssociate/associateDbId|associate|ID| x |
|workflowAssociate/contactName|string|Owning company: Name of the company the user belongs to| x |
|workflowAssociate/contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|workflowAssociate/usergroup|userGroup|Primary group: The user's primary user group| x |
|workflowAssociate/contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|workflowAssociate/contactCategory|listAny|Category: Category| x |
|workflowAssociate/role|listAny|Role : Role| x |
|workflowAssociate/assocName|associate|User ID : User ID| x |
|workflowAssociate/assocTooltip|string|Description : Description|  |
|workflowAssociate/assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|workflowAssociate/ejUserId|int|Service user ID: The database ID of a Service user|  |
|workflowAssociate/simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|workflowAssociate/ejDisplayName|string|Nick name: User's nick name in Service| x |
|workflowAssociate/ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|workflowAssociate/credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|workflowAssociate/credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|workflowAssociate/isActive|bool|Active: Is this user active, and should be able to log in?| x |
|workflowAssociate/isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|workflowAssociate/portraitThumbnail| *None* |Person image: Person image|  |
|workflowAssociate/otherGroups|userGroup|Other groups: Other groups|  |
|workflowAssociate/userName|string|User name: User name| x |
|workflowAssociate/personEmail|string|E-mail| x |
|hierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullname|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyName|string|Hierarchy name: The full name/path from table hierarchy| x |
|hierarchyParentId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|hierarchyFullpathIds| *None* |Folder path IDs: An integer array of nodes leading to a hierarchy/folder item, in root => leaf order|  |

## Sample

```http!
GET /api/v1/archive/EmailFlows?$select=workflowName,workflowCompletedCount,workflowAssociate/mrMrs
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


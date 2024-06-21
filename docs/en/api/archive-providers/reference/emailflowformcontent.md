---
uid: EmailFlowFormContent
title: EmailFlowFormContent
description: Email flow form content.
keywords: EmailFlowFormContent archive provider
generated: true
topic: reference
envir: onsite, online
---

# "EmailFlowFormContent"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowFormContentProvider">SuperOffice.CRM.ArchiveLists.EmailFlowFormContentProvider</see> inside NetServer's SODatabase assembly.

Email flow form content.
Lists all email flow form content

## Supported Entities
| Name | Description |
| ---- | ----- |
|"Form"|[Form]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|formId|int|ID: Form ID| x |
|formName|string|Name: Form name| x |
|formDescription|string|Description: Form description| x |
|formThumbnail| *None* |Thumbnail: Form thumbnail|  |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|emailFlow/emailFlowId|int|Email flow Id: The database Id of the email flow| x |
|emailFlow/emailFlowHierarchyId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|emailFlow/shipmentType|listAny|Mailing type: Mailing type this e-mail flow represents| x |
|emailFlow/overrideConsentSubscription|bool|Override consent: Should consent subscriptions be overridden for this workflow?| x |
|emailFlow/thumbnail| *None* |Thumbnail|  |
|emailFlow/mediumThumbnail| *None* |Thumbnail|  |
|emailFlow/workflowId|int|Workflow id: Id of a worflow definition| x |
|emailFlow/workflowName|string|Name: Name of the workflow definition| x |
|emailFlow/workflowDescription|string|Description: Description of the workflow definition| x |
|emailFlow/workflowDefinitionStatus|listAny|Status: Status of the workflow definition| x |
|emailFlow/jumpToFinish|bool|Jump to finish: Should participant jump to finish when the goals are met?| x |
|emailFlow/startOnlyOnce|bool|Start only once: Should the participant enter the workflow only once?| x |
|emailFlow/workflowEnrolledCount| *None* |Enrolled: How many times has a participant entered this workflow|  |
|emailFlow/workflowInProgressCount| *None* |In progress: How many participants are in progress|  |
|emailFlow/workflowCompletedCount| *None* |Completed: How many participants are completed|  |
|emailFlow/workflowSucceededCount| *None* |Succeeded: How many participants has successfully finished the workflow (goals criteria met)|  |
|emailFlow/workflowSuccessRate| *None* |Success rate: Success rate, based on goals criteria met|  |
|emailFlow/updatedBy|associate|Updated by: The user who last updated the data| x |
|emailFlow/updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|emailFlow/registeredBy|associate|Registered by: The user who registered the data| x |
|emailFlow/registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/EmailFlowFormContent?$select=emailFlow/thumbnail,emailFlow/emailFlowId,emailFlow/mediumThumbnail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


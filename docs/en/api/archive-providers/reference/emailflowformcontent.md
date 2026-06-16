---
uid: EmailFlowFormContent
title: EmailFlowFormContent
description: Email flow form content.
keywords: EmailFlowFormContent archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "EmailFlowFormContent"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowFormContentProvider">SuperOffice.CRM.ArchiveLists.EmailFlowFormContentProvider</see> inside NetServer's SODatabase assembly.

Email flow form content.
Lists all email flow form content

## Supported Entities
| Name | Description |
| ---- | ----- |
|"Form"|Form|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|formId|int|SR\_FORMARCHIVE\_FORMID: SR\_FORMARCHIVE\_FORMID\_TOOLTIP| x |
|formName|string|SR\_FORMARCHIVE\_FORMNAME: SR\_FORMARCHIVE\_FORMNAME\_TOOLTIP| x |
|formDescription|string|SR\_FORMARCHIVE\_FORMDESCRIPTION: SR\_FORMARCHIVE\_FORMDESCRIPTION\_TOOLTIP| x |
|formThumbnail| *None* |SR\_FORMARCHIVE\_FORMTHUMBNAIL: SR\_FORMARCHIVE\_FORMTHUMBNAIL\_TOOLTIP|  |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|emailFlow/emailFlowId|int|SR\_ARCHIVE\_EMAILFLOW\_ID: SR\_ARCHIVE\_EMAILFLOW\_ID\_TOOLTIP| x |
|emailFlow/emailFlowHierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|emailFlow/shipmentType|listAny|SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE: SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE\_TOOLTIP| x |
|emailFlow/overrideConsentSubscription|bool|SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION: SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION\_TOOLTIP| x |
|emailFlow/thumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|emailFlow/mediumThumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|emailFlow/workflowId|int|SR\_ARCHIVE\_WORKFLOW\_ID: SR\_ARCHIVE\_WORKFLOW\_ID\_TOOLTIP| x |
|emailFlow/workflowName|string|SR\_ARCHIVE\_WORKFLOW\_NAME: SR\_ARCHIVE\_WORKFLOW\_NAME\_TOOLTIP| x |
|emailFlow/workflowDescription|string|SR\_ARCHIVE\_WORKFLOW\_DESC: SR\_ARCHIVE\_WORKFLOW\_DESC\_TOOLTIP| x |
|emailFlow/workflowDefinitionStatus|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|emailFlow/workflowDefinitionStatusId|listAny|SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP| x |
|emailFlow/jumpToFinish|bool|SR\_ARCHIVE\_WORKFLOW\_JUMP\_TO\_FINISH: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_JUMP\_TO\_FINISH\_TOOLTIP| x |
|emailFlow/startOnlyOnce|bool|SR\_ARCHIVE\_WORKFLOW\_START\_ONLY\_ONCE: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_START\_ONLY\_ONCE\_TOOLTIP| x |
|emailFlow/workflowEnrolledCount| *None* |SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowInProgressCount| *None* |SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT: SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT\_TOOLTIP|  |
|emailFlow/workflowCompletedCount| *None* |SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowSucceededCount| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT\_TOOLTIP|  |
|emailFlow/workflowSuccessRate| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE: SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE\_TOOLTIP|  |
|emailFlow/updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|emailFlow/updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|emailFlow/registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|emailFlow/registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/EmailFlowFormContent?$select=emailFlow/emailFlowId,emailFlow/workflowId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


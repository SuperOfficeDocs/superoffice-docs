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
|emailFlowId| *None* |SR\_ARCHIVE\_EMAILFLOW\_ID: SR\_ARCHIVE\_EMAILFLOW\_ID\_TOOLTIP|  |
|emailFlowHierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|shipmentType| *None* |SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE: SR\_ARCHIVE\_EMAILFLOW\_MAILING\_TYPE\_TOOLTIP|  |
|overrideConsentSubscription| *None* |SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION: SR\_ARCHIVE\_EMAILFLOW\_OVERRIDE\_CONSENT\_SUBSCRIPTION\_TOOLTIP|  |
|thumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|mediumThumbnail| *None* |SR\_ARCHIVE\_EMAILFLOW\_THUMBNAIL|  |
|workflowId| *None* |SR\_ARCHIVE\_WORKFLOW\_ID: SR\_ARCHIVE\_WORKFLOW\_ID\_TOOLTIP|  |
|name|string|SR\_ARCHIVE\_WORKFLOW\_NAME: SR\_ARCHIVE\_WORKFLOW\_NAME\_TOOLTIP| x |
|workflowDescription| *None* |SR\_ARCHIVE\_WORKFLOW\_DESC: SR\_ARCHIVE\_WORKFLOW\_DESC\_TOOLTIP|  |
|workflowDefinitionStatus| *None* |SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP|  |
|workflowDefinitionStatusId| *None* |SR\_ARCHIVE\_WORKFLOW\_DEFINITION\_STATUS: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_STATUS\_TOOLTIP|  |
|jumpToFinish| *None* |SR\_ARCHIVE\_WORKFLOW\_JUMP\_TO\_FINISH: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_JUMP\_TO\_FINISH\_TOOLTIP|  |
|startOnlyOnce| *None* |SR\_ARCHIVE\_WORKFLOW\_START\_ONLY\_ONCE: SR\_ARCHIVE\_WORKFLOW\_\_DEFINITION\_START\_ONLY\_ONCE\_TOOLTIP|  |
|workflowEnrolledCount| *None* |SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_ENROLLED\_COUNT\_TOOLTIP|  |
|workflowInProgressCount| *None* |SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT: SR\_ARCHIVE\_WORKFLOW\_IN\_PROGRESS\_COUNT\_TOOLTIP|  |
|workflowCompletedCount| *None* |SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_COMPLETED\_COUNT\_TOOLTIP|  |
|workflowSucceededCount| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT: SR\_ARCHIVE\_WORKFLOW\_SUCCEEDED\_COUNT\_TOOLTIP|  |
|workflowSuccessRate| *None* |SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE: SR\_ARCHIVE\_WORKFLOW\_SUCCESS\_RATE\_TOOLTIP|  |
|updatedBy| *None* |SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP|  |
|updatedDate| *None* |SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP|  |
|registeredBy| *None* |SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP|  |
|registeredDate| *None* |SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP|  |
|workflowAssociate/firstName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_FIRSTNAME: SR\_PERSONARCHIVE\_FIRSTNAME\_TOOLTIP|  |
|workflowAssociate/lastName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_LASTNAME: SR\_PERSONARCHIVE\_LASTNAME\_TOOLTIP|  |
|workflowAssociate/middleName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_LABEL\_MIDDLENAME: SR\_PERSONARCHIVE\_MIDDLENAME\_TOOLTIP|  |
|workflowAssociate/fullName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_ARCHIVE\_ASSOC\_FULLNAME\_TOOLTIP|  |
|workflowAssociate/contactId| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_ID: SR\_ASSOCCONTACT\_ID\_TOOLTIP|  |
|workflowAssociate/personId| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP|  |
|workflowAssociate/mrMrs| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_MRMSS: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|workflowAssociate/title| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_JOBTITLE: SR\_PERSONARCHIVE\_MRMSS\_TOOLTIP|  |
|workflowAssociate/associateDbId| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ACTIVITYARCHIVE\_ASSOCIATEID|  |
|workflowAssociate/contactName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_NAME: SR\_ASSOCCONTACT\_NAME\_TOOLTIP|  |
|workflowAssociate/contactDepartment| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_DEPT: SR\_ASSOCCONTACT\_DEPT\_TOOLTIP|  |
|workflowAssociate/usergroup| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_LIST\_GROUP: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|workflowAssociate/usergroupId| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_FIELD\_PERSON\_GROUP\_ID\_NAME: SR\_ADMIN\_USERS\_LIST\_GROUP\_TOOLTIP|  |
|workflowAssociate/contactFullName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASSOCCONTACT\_NAMEDEPT: SR\_ASSOCCONTACT\_NAMEDEPT\_TOOLTIP|  |
|workflowAssociate/contactCategory| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_CATEGORY: SR\_ARCHIVE\_CATEGORY|  |
|workflowAssociate/role| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_ROLE: SR\_ADMIN\_USERS\_ROLE|  |
|workflowAssociate/assocName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_ID: SR\_ADMIN\_USERS\_ID|  |
|workflowAssociate/assocTooltip| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_LIST\_DESCRIPTION: SR\_ADMIN\_LIST\_DESCRIPTION|  |
|workflowAssociate/assocType| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_LIST\_TYPE: SR\_ADMIN\_USERS\_LIST\_TYPE\_TOOLTIP|  |
|workflowAssociate/ejUserId| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJUSERID\_8: SR\_ADMIN\_EJUSERID\_TOOLTIP\_8|  |
|workflowAssociate/simultaneousEjUser| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_SIMEJUSER\_8: SR\_ADMIN\_SIMEJUSER\_TOOLTIP|  |
|workflowAssociate/ejDisplayName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJDISPLAYNAME\_8: SR\_ADMIN\_EJDISPLAYNAME\_TOOLTIP\_8|  |
|workflowAssociate/ejStatus| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_EJSTATUS\_8: SR\_ADMIN\_EJSTATUS\_TOOLTIP\_8|  |
|workflowAssociate/credentialType| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_CREDTYPE: SR\_ADMIN\_CREDTYPE\_TOOLTIP|  |
|workflowAssociate/credentialDisplayValue| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_CREDVALUE: SR\_ADMIN\_CREDVALUE\_TOOLTIP|  |
|workflowAssociate/isActive| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ASOWW\_ACTIVE: SR\_ASOWW\_ACTIVE\_TOOLTIP|  |
|workflowAssociate/isActiveText| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_ACTIVESTATUS: SR\_ADMIN\_ACTIVESTATUS\_TOOLTIP|  |
|workflowAssociate/portraitThumbnail| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_PERSONARCHIVE\_THUMBNAIL: SR\_PERSONARCHIVE\_THUMBNAIL|  |
|workflowAssociate/otherGroups| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_OTHERGROUPS: SR\_ARCHIVE\_OTHERGROUPS|  |
|workflowAssociate/userName| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_USERS\_NAME: SR\_ADMIN\_USERS\_NAME\_TOOLTIP|  |
|workflowAssociate/personEmail| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_EMAIL|  |
|workflowAssociate/locationAddress| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ADMIN\_LIST\_LOCATION: SR\_ADMIN\_LIST\_LOCATION|  |
|workflowAssociate/isLocation| *None* |SR\_ACTIVITYARCHIVE\_OWNER - SR\_ARCHIVE\_ISLOCATION: SR\_ARCHIVE\_ISLOCATION|  |
|hierarchyId|int|SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP| x |
|hierarchyFullname|string|SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP| x |
|hierarchyName| *None* |SR\_HIERARCHY\_FULLNAME: SR\_HIERARCHY\_FULLNAME\_TOOLTIP|  |
|hierarchyParentId| *None* |SR\_HIERARCHY\_ID: SR\_HIERARCHY\_ID\_TOOLTIP|  |
|hierarchyFullpathIds| *None* |SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS: SR\_ARCHIVE\_HIERARCHY\_FULLPATHIDS\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/EmailFlowsAndFolders?$select=workflowAssociate/contactId,updatedBy,workflowAssociate/title
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


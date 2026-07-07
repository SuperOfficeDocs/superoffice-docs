---
uid: MailingFolders
title: MailingFolders
description: Archive of mailing folders. Lists all rows of s_picture_folder where
keywords: MailingFolders archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "MailingFolders"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.MailingFolderProvider">SuperOffice.CRM.ArchiveLists.MailingFolderProvider</see> inside NetServer's SODatabase assembly.

Archive of mailing folders. Lists all rows of s_picture_folder where
folder_type = shipmentFolder. Mirrors <see cref="T:SuperOffice.CRM.ArchiveLists.EmailFlowFolderProvider" />.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"mailingfolder"|mailingfolder|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|folderId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|parentFolderId|int|Hierarchy ID: Foreign key to hierarchy table| x |
|folderName|string|Hierarchy name: The full name/path from table hierarchy| x |
|thumbnail| *None* |Thumbnail|  |

## Sample

```http!
GET /api/v1/archive/MailingFolders?$select=folderId,parentFolderId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


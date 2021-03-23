---
uid: ShadowSelection
title: ShadowSelection
description: Universal shadow selection dispatcher: Retrieve the contactId and/or personId of all contact/person shadow members of any selection
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ShadowSelection"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ShadowSelection"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ShadowSelectionProvider">SuperOffice.CRM.ArchiveLists.ShadowSelectionProvider</see> inside NetServer's SODatabase assembly.

Universal shadow selection dispatcher: Retrieve the contactId and/or personId of all contact/person shadow members of any selection

This class abstracts the differences between the various selection kinds (contact, sale, ...) with regard to contact and
person id. You can give any selectionId to this provider, and it will reply with a list of contact and person ids; either
pulled from the actual selection (if it's a contact selection) or its shadow.
<para />
Only the two ID columns are available. The row type is fixed (contact or person), and the column names are also fixed.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"contact"|[Contact]|
|"person"|[Person]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|contactId| *None* |Contact ID: Contact (company) ID|  |
|personId| *None* |Person ID: Person ID|  |
|selectionId|int|Selection ID: Selection ID|  |

## Sample

```http!
GET /api/v1/archive/ShadowSelection?$select=
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


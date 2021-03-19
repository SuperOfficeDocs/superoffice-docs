---
uid: TemplateLanguage
title: TemplateLanguage
description: Archive Provider for retriving the registered languages for a given document template.
The provider will use the document plugin to get the languages registered.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "TemplateLanguage"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive___ListItems.TemplateLanguageProvider">SuperOffice.CRM.ArchiveLists.Archive___ListItems.TemplateLanguageProvider</see> inside NetServer's SODatabase assembly.

Archive Provider for retriving the registered languages for a given document template.
The provider will use the document plugin to get the languages registered.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"templatelanguage"|[(templatelanguage)]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|id| *None* |id|  |
|name| *None* |name|  |

## Sample

```http!
GET /api/v1/archive/TemplateLanguage?$select=
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


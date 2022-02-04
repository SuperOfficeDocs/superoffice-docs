---
uid: ModuleLicense
title: ModuleLicense
description: Simple provider for module licences. This provider will return a flat list with
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ModuleLicense"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ModuleLicense"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ModuleLicenceProvider">SuperOffice.CRM.ModuleLicenceProvider</see> inside NetServer's SODatabase assembly.

Simple provider for module licences. This provider will return a flat list with
one entity for system-level licences, one for site (database)-level licences, and
one for user (associate)-level licences. It does not check codekey or other
security items.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"systemLicense"|[systemLicense]|
|"siteLicense"|[siteLicense]|
|"userLicense"|[userLicense]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|moduleLicenseId|int|id| x |
|moduleName|string|moduleName| x |
|moduleDesc|string|moduleDesc| x |
|licenseType|int|licenseType| x |
|licenseNumber|int|licenseNumber| x |
|allowedAssocs|int|allowedAssocs| x |
|extraFlags|int|extraFlags| x |
|graceTo|date|graceTo| x |
|maintenanceTo|date|maintenanceTo| x |

## Sample

```http!
GET /api/v1/archive/ModuleLicense?$select=moduleName,licenseType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


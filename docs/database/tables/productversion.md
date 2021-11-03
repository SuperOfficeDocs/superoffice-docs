---
uid: table-ProductVersion
title: ProductVersion table
description: Version information for code modules. Owner + code module must be unique
so.generated: true
keywords:
  - "database"
  - "ProductVersion"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ProductVersion Table (240)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ProductVersion\_id|Primary key|PK| |
|ownerName|Owner of code module|String(254)| |
|codeName|The name of the code module, which is not the same as a license module|String(254)| |
|version|The version string, formatted as the code module would like to. Keybase will have to understand these strings if they are relevant to the licenses issued.|String(254)| |
|comment|Possible comment string added by code|String(254)| |
|updatePath|Path MSI or other files, that contain the installation for this version; used for auto-update|String(1023)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductVersion table relationship diagram](./media/ProductVersion.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ProductVersion\_id |PK |Clustered, Unique |
|ownerName, codeName, version |String(254), String(254), String(254) |Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.


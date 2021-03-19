---
uid: ejscript
title: ejscript table
description: ejscript
so.generated: true
keywords:
  - "database"
  - "ejscript"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Ejscript Table (377)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|hierarchy\_id|The script is inside this hierarchy folder|FK [hierarchy](hierarchy.md)| |
|description|A description of this script|String(255)|&#x25CF;|
|include\_id|A unique name used for including this script in another|String(255)| |
|access\_key|Access key used to run this script on the customer pages|String(255)|&#x25CF;|
|body|The script|Clob|&#x25CF;|
|html\_output|True if this script will return HTML output|Bool| |
|long\_description|Optional description of what this script is used for.|String(2047)|&#x25CF;|
|extra\_menus\_id|Optional id of related extra menu pointing to this script|FK [extra_menus](extra_menus.md)|&#x25CF;|
|unique\_identifier|Global unique identifier, accross customers/tenants|String(64)| |
|registered|Registered when|UtcDateTime|&#x25CF;|
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)|&#x25CF;|
|updated|Last updated when|UtcDateTime|&#x25CF;|
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)|&#x25CF;|
|updatedCount|Number of updates made to this record|UShort| |


![ejscript table relationship diagram](media\ejscript.png)

[!include[details](./includes/ejscript.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|hierarchy\_id |FK |Index |
|include\_id |String(255) |Index |
|unique\_identifier |String(64) |Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.


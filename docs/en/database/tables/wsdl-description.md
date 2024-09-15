---
uid: table-wsdl_description
title: wsdl_description table
description: Soap wsdl files
so.generated: true
keywords: database table wsdl_description
so.topic: reference
so.envir: onsite, online
---

# wsdl\_description Table (357)

Soap wsdl files

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|name|The name of the wsdl file, same as used in the import statements in the wsdl file|String(255)| |
|body|The content of the wsdl file|Clob|&#x25CF;|


![wsdl_description table relationship diagram](./media/wsdl_description.png)

[!include[details](./includes/wsdl-description.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.


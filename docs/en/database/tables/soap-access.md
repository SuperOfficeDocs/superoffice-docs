---
uid: table-soap_access
title: soap_access table
description: Table that contains constraints on the access to the soap interface
so.generated: true
keywords: database table soap_access
so.topic: reference
so.envir: onsite, online
---

# soap\_access Table (362)

Table that contains constraints on the access to the soap interface

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|address\_from|IP address range from address|String(255)|&#x25CF;|
|address\_to|IP address range to address|String(255)|&#x25CF;|
|type|Type: customer, ticket, admin etc|Int|&#x25CF;|


![soap_access table relationship diagram](./media/soap_access.png)

[!include[details](./includes/soap-access.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.


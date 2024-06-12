---
uid: table-login
title: login table
description: This table contains entries for the user sessions. 
so.generated: true
keywords: database table login
so.topic: reference
so.envir: onsite, online
---

# login Table (297)

This table contains entries for the user sessions. 

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|user\_id|The id of the user this entry references.|FK [ejuser](ejuser.md)| |
|session\_key|A random 32 characters value used as authentication key for the session.|String(32)| |
|remote\_addr|The IP address of the client for this session.|String(64)|&#x25CF;|
|remote\_host|The hostname (depending on whether reverse lookup is enabled in httpd) or IP address of the client for this session.|String(64)|&#x25CF;|
|logged\_in|When this session started.|DateTime|&#x25CF;|
|idle|The last time this session was active.|DateTime|&#x25CF;|
|status|The status (enum) for this session.|Int| |
|origin|1=soap call, 2=web pages|Int| |
|error\_message|Stores the last error message recorded on this session|String(255)|&#x25CF;|
|authentication\_type|The authentication type (enum) for this session.|authentication_type|&#x25CF;|
|active\_menu|The currently active (open) left-menu for this session.|Int|&#x25CF;|
|ns\_secret|Netserver login secret.|String(2000)|&#x25CF;|
|flags|Bitmask of flags for a service login session|Enum [LoginFlags](enums/loginflags.md)|&#x25CF;|


![login table relationship diagram](./media/login.png)

[!include[details](./includes/login.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|user\_id |FK |Index |
|session\_key |String(32) |Index |
|status |Int |Index |
|origin |Int |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |
|[extra\_tables\_result](extra-tables-result.md)  |Result set of executed search in ejournal extra tables |
|[invoice\_sum](invoice-sum.md)  |This table is used temporarily when listing invoice statistics. It is used because we need to sort balances from both customers and companies. |
|[session\_object](session-object.md)  |Generic session object, accessible from ejscript etc, typically xml or name=value syntax, may be stored over several rows if big |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.


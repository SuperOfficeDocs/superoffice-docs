---
uid: table-ext_datasource
title: ext_datasource table
description: This table contains external datasources, used for databaseintegration of customers and companies.
so.generated: true
keywords: database table ext_datasource
so.topic: reference
so.envir: onsite, online
---

# ext\_datasource Table (317)

This table contains external datasources, used for databaseintegration of customers and companies.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|name|An alias for this datasource.|String(64)|&#x25CF;|
|datatype|An enum indicating the type/protocol for this datasource.|String(32)|&#x25CF;|
|database\_type|The database type (DbType).|Int|&#x25CF;|
|dbname|The name used for accessing the datasource.|String(32)|&#x25CF;|
|hostname|The hostname for accessing the datasource.|String(255)|&#x25CF;|
|port|The port used for accessing the datasource.|Int|&#x25CF;|
|path|Path to the datasource.|String(255)|&#x25CF;|
|username|The username used for authenticating against the datasource.|String(64)|&#x25CF;|
|password|The poassword used for authenticating against the datasource.|String(64)|&#x25CF;|
|flags|Bitmask of flags.|Int|&#x25CF;|
|next\_update|Next time the update process starts|DateTime|&#x25CF;|
|update\_interval|Number of hours between each database update|Int|&#x25CF;|
|update\_customer\_count|Number of customers updated so far|Int|&#x25CF;|
|update\_company\_count|Number of companies updated so far|Int|&#x25CF;|
|update\_lock|Lock to make sure not 2 updates are done simultaniously|DateTime|&#x25CF;|
|last\_update|When did the last update occur?.|DateTime|&#x25CF;|
|update\_completion\_time|The last update completion time in minutes.|Int|&#x25CF;|
|update\_error\_message|The last error message from datasource update.|Clob|&#x25CF;|
|last\_access|The last time this datasource was accessed.|DateTime|&#x25CF;|
|sql\_init|The SQL init used for configure the server before fetching external data.|Clob|&#x25CF;|
|unix\_socket|Unix socket used with Mysql connections on Linux|String(255)|&#x25CF;|


![ext_datasource table relationship diagram](./media/ext_datasource.png)

[!include[details](./includes/ext-datasource.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[ext\_table](ext-table.md)  |This table contains entries used for mapping an external table to an internal table (customer or cust_company) for database integration. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.


---
uid: table-ext_table
title: ext_table table
description: This table contains entries used for mapping an external table to an internal table (customer or cust_company) for database integration.
so.generated: true
keywords: database table ext_table
so.topic: reference
so.envir: onsite, online
---

# ext\_table Table (318)

This table contains entries used for mapping an external table to an internal table (customer or cust_company) for database integration.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ext\_datasource|The reference to the associated datasource.|FK [ext_datasource](ext-datasource.md)|&#x25CF;|
|parent\_table|The reference to the parent table.|FK [ext_table](ext-table.md)|&#x25CF;|
|child\_table|The reference to the child table.|FK [ext_table](ext-table.md)|&#x25CF;|
|name|The name for this field|String(64)|&#x25CF;|
|target|Enum indicating the target table (customer or cust_company).|Int|&#x25CF;|
|priority|TODO: depreciated?|Int|&#x25CF;|
|ldap\_search\_base2|LDAP search base, multiple search bases are seperated by new line|Clob|&#x25CF;|
|ldap\_search\_filter|LDAP search query|String(255)|&#x25CF;|
|ldap\_search\_result|Select which data to return from LDAP|String(255)|&#x25CF;|
|sql\_query|The SQL query used for fetching the external data.|Clob|&#x25CF;|
|sql\_query2|The SQL query used for fetching the external data. Part 2|Clob|&#x25CF;|
|primary\_key|The name of the primary key. TODO: depreciated?|String(64)|&#x25CF;|
|sql\_limit|Used for LIMIT optimiziation of the search query|Int|&#x25CF;|


![ext_table table relationship diagram](./media/ext_table.png)

[!include[details](./includes/ext-table.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ext\_datasource |FK |Index |
|parent\_table |FK |Index |
|child\_table |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ext\_datasource](ext-datasource.md)  |This table contains external datasources, used for databaseintegration of customers and companies. |
|[ext\_field](ext-field.md)  |This table contains entries mapping an external field to an internal field. Used for database integration. |
|[ext\_table](ext-table.md)  |This table contains entries used for mapping an external table to an internal table (customer or cust_company) for database integration. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.


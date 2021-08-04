---
uid: table-extra-tables
title: extra\_tables table
description: This table contains entries for the extra tables in the system.
so.generated: true
keywords:
  - "database"
  - "extra_tables"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# extra\_tables Table (305)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|table\_name|The database name of this extra table.|String(64)|&#x25CF;|
|name|The name of this extra table.|String(128)|&#x25CF;|
|search\_header|The header when searching this table.|String(255)|&#x25CF;|
|view\_entry\_header|The header when viewing entries in this table.|String(255)|&#x25CF;|
|new\_entry\_header|The header when creating a new entry in this table.|String(255)|&#x25CF;|
|edit\_entry\_header|The header when editing an entry in this table.|String(255)|&#x25CF;|
|hierarchy\_id|This extra table is inside this hierarchy folder|FK [hierarchy](hierarchy.md)| |
|sort\_order|The default sort_order for this extra table.|String(255)|&#x25CF;|
|display\_field|The default field to display for this extra table.|FK [extra-fields](extra-fields.md)|&#x25CF;|
|flags|Bitmap for flags for this entry.|UInt|&#x25CF;|
|parent\_field|If this table is hierarchically organized, then this field can contain a field which is a parent-field, creating a hierarchy.|FK [extra-tables](extra-tables.md)|&#x25CF;|
|fullname\_field|If this table is hierarchically organized, then this field can contain a field which will be assigned a fullname, such as &amp;apos;Support/Hardware/Keyboards&amp;apos;.|FK [extra-tables](extra-tables.md)|&#x25CF;|
|screen\_chooser\_entry|The screen chooser to use for this extra table when viewing an entry.|FK [screen-chooser](screen-chooser.md)|&#x25CF;|
|screen\_chooser\_all|The screen chooser to use for this extra table when viewing the table.|FK [screen-chooser](screen-chooser.md)|&#x25CF;|
|screen\_chooser\_edit|The screen chooser to use for this extra table when editing the table.|FK [screen-chooser](screen-chooser.md)|&#x25CF;|
|description|Optional description of what this table is used for|String(2047)|&#x25CF;|


![extra_tables table relationship diagram](./media/extra_tables.png)

[!include[details](./includes/extra-tables.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|hierarchy\_id |FK |Index |
|display\_field |FK |Index |
|parent\_field |FK |Index |
|fullname\_field |FK |Index |
|screen\_chooser\_entry |FK |Index |
|screen\_chooser\_all |FK |Index |
|screen\_chooser\_edit |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.


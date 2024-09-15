---
uid: table-ejsel_ejsel
title: ejsel_ejsel table
description: This table defines sources for complex selections in a many/many relationship
so.generated: true
keywords: database table ejsel_ejsel
so.topic: reference
so.envir: onsite, online
---

# ejsel\_ejsel Table (392)

This table defines sources for complex selections in a many/many relationship

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|parent|The id of the selection for which this item is a source|FK [ejselection](ejselection.md)| |
|child|The id of the child item selection|FK [ejselection](ejselection.md)| |
|operation|The operation to be performed when this source is added to the selection|Int| |
|order\_pos|The order in which the operations are performed|Int| |


![ejsel_ejsel table relationship diagram](./media/ejsel_ejsel.png)

[!include[details](./includes/ejsel-ejsel.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|parent |FK |Index |
|child |FK |Index |
|operation |Int |Index |
|order\_pos |Int |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ejselection](ejselection.md)  |This table stores selections, dynamic groups. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.


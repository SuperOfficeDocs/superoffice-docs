---
uid: table-message_customers
title: message_customers table
description: This table contains all cutomers who are involved in a message
so.generated: true
keywords: database table message_customers
so.topic: reference
so.envir: onsite, online
---

# message\_customers Table (260)

This table contains all cutomers who are involved in a message

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|message\_id|The id of the message the customer is involved in|FK [ej_message](ej-message.md)| |
|customer\_id|The id of the customer who has received this message, or another message in this ticket|FK [person](person.md)| |
|email|The email-adresse used in this message|String(255)|&#x25CF;|


![message_customers table relationship diagram](./media/message_customers.png)

[!include[details](./includes/message-customers.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|message\_id |FK |Index |
|customer\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ej\_message](ej-message.md)  |This table contains the messages listed under tickets. |
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.


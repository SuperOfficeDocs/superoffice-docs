---
uid: table-email_account
title: email_account table
description: Email account information
so.generated: true
keywords:
  - "database"
  - "email_account"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# email\_account Table (480)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|email\_account\_id|Primary key|PK| |
|email\_address|The From-address|String(255)|&#x25CF;|
|associate\_id|Associate who owns this email account|FK [associate](associate.md)|&#x25CF;|
|incoming\_auth|Incoming server (imap) authentication |FK [service_auth](service-auth.md)|&#x25CF;|
|outgoing\_auth|Outgoing server (smtp) authentication |FK [service_auth](service-auth.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|default|True if this account is the default account for the associate who owns it|Bool|&#x25CF;|
|account\_status|The status of this email account|Enum [EmailAccountStatus](enums/emailaccountstatus.md)|&#x25CF;|
|encryptedCheck|Encrypted hash checksum|String(254)| |
|error\_count|How many failures since reset|Int|&#x25CF;|
|error\_reason|Reason for last failure if available|String(254)| |


![email_account table relationship diagram](./media/email_account.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|email\_account\_id |PK |Clustered, Unique |
|email\_address |String(255) |Unique |
|associate\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.


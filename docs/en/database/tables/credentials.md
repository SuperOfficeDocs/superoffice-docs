---
uid: table-Credentials
title: Credentials table
description: Alternative credentials
so.generated: true
keywords: database table Credentials
so.topic: reference
so.envir: onsite, online
---

# Credentials Table (250)

Alternative credentials

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Credentials\_id|Primary key|PK| |
|associateId|Associate that these credentials iare an alternative identification for|FK [associate](associate.md)| |
|credentialType|What type of credentials is this|String(254)| |
|searchName|Searchable (plaintext) representation of credentials|String(254)| |
|secret|Encrypted secret|String(2000)| |
|validFrom|Start of validity for these credentials|DateTime| |
|validTo|End of validity for these credentials|DateTime| |
|isActive|What kind of usage are these credentials for; see enum CredentialUsage for details|Enum [CredentialUsage](enums/credentialusage.md)| |
|encryptedCheck|Encrypted checksum; tampering will block system usage|String(254)| |
|lastUsedDate|When were these credentials last used for login|DateTime|&#x25CF;|
|lastusedInfo|Provider-specific usage information, for instance an IP adrdess or other location|String(254)|&#x25CF;|
|comment|Free text comment|String(254)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|personId|Associates&apos; person; or just the person, if this points to a potential associate (created on-demand on first login)|FK [person](person.md)|&#x25CF;|
|extraId|Spare field, used at the plugins discretion|Id|&#x25CF;|
|displayType|Lead-text used in GUI, originally from plugin. Used as fallback when plugins are missing|String(254)|&#x25CF;|
|displayName|Friendly name of credentials (searchname could be a SID, this should be a real name)|String(254)|&#x25CF;|


![Credentials table relationship diagram](./media/Credentials.png)

[!include[details](./includes/credentials.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Credentials\_id |PK |Clustered, Unique |
|searchName |String(254) |Index |
|credentialType, personId |String(254), FK |Index |
|credentialType, searchName |String(254), String(254) |Unique |
|credentialType, isActive, Credentials\_id, validFrom, validTo |String(254), Enum, PK, DateTime, DateTime |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |


## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.


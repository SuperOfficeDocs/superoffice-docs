---
uid: table-travelcurrent
title: travelcurrent table
description: Information about this database and its place in the hierarchy
so.generated: true
keywords: database table travelcurrent
so.topic: reference
so.envir: onsite, online
---

# travelcurrent Table (32)

Information about this database and its place in the hierarchy

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|travelcurrent\_id|Primary key|PK| |
|systemlevel|10 = central, 9 = first child, 8 = second-generation child|UShort|&#x25CF;|
|current\_id|Central=0, Departm.=H01000000-H7F000000, Travel=assoc_id|FK [associate](associate.md)|&#x25CF;|
|central\_id|ID of parent database (from its current_id)|FK [associate](associate.md)|&#x25CF;|
|area\_id|Area ID this database represents|Id|&#x25CF;|
|central\_generatedtime|When was the central database generated|DateTime|&#x25CF;|
|current\_generatedtime|When was this database generated|DateTime|&#x25CF;|
|last\_recordtime|Timestamp of last traveltranslog record received from the parent of this database|DateTime|&#x25CF;|
|last\_recordnumber|Traveltranslog record ID of last record this database has received from its parent|FK [traveltransactionlog](traveltransactionlog.md)|&#x25CF;|
|first\_recordnumber|First traveltranslog record in parent that was transmitted to this database|FK [traveltransactionlog](traveltransactionlog.md)|&#x25CF;|
|last\_playbacktime|Datetamp of when we last read a file from our parent|DateTime|&#x25CF;|
|last\_playbacknumber|File number of last file read from our parent|Id|&#x25CF;|
|databasetype|Default database type for prototypes made from this database, unless the Area record says something else|UShort|&#x25CF;|
|dbTag|128-bit database tag (in hex) of this database|String(39)| |
|parentDbTag|128-bit database tag (in hex) of this database&apos;s parent database|String(39)| |
|centralDbTag|128-bit database tag (in hex) of the central database|String(39)| |
|encryptedComm|Use encrypted communication back to parent: 0 = no, 1 = serial no as key, 2 = target db tag as key (secure but lots of hassle for support)|Enum [TravelEncryptionOwn](enums/travelencryptionown.md)|&#x25CF;|
|defaultMakeReturn|Default value for the &apos;make return log&apos; checkbox, based on last answer|UShort|&#x25CF;|
|adminLogin|Encrypted string containing user name &amp; password of DB user who has create/delete user authority for this database|String(127)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![travelcurrent table relationship diagram](./media/travelcurrent.png)

[!include[details](./includes/travelcurrent.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|travelcurrent\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[traveltransactionlog](traveltransactionlog.md)  |Log of all updates made to the database, that need to be replicated. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.


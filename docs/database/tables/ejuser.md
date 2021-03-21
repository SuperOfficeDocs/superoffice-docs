---
uid: table-ejuser
title: ejuser table
description: This table contains entries for the users of the system.
so.generated: true
keywords:
  - "database"
  - "ejuser"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ejuser Table (299)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|loginname|The unique loginname for this user.|String(63)| |
|usergroup|The group this user is member of |FK [hierarchy](hierarchy.md)| |
|username|The unique username for this user.|String(63)| |
|password|The encrypted password for this user.|String(127)|&#x25CF;|
|firstname|The firstname for this user.|String(127)|&#x25CF;|
|middlename|The middlename for this user.|String(127)|&#x25CF;|
|lastname|The lastname for this user.|String(127)|&#x25CF;|
|email|The email address for this user.|String(255)| |
|access\_level|The access level for this user.|Int|&#x25CF;|
|status|The status (enum) for this user.|status|&#x25CF;|
|signature|The users signature.|Clob|&#x25CF;|
|notify\_mask|A bitmask indicating to which extent the user should recieve pop-up warnings for various events.|Int|&#x25CF;|
|email\_mask|A bitmask indicated to which extent the user should recieve email warnings for various events.|Int|&#x25CF;|
|sms\_mask|A bitmask indicated to which extent the user should recieve sms warnings for various events.|Int|&#x25CF;|
|language|A string indicating the user&amp;apos;s language (&amp;apos;no&amp;apos; or &amp;apos;en&amp;apos;).|String(5)|&#x25CF;|
|dictionary|A string indicating the user&amp;apos;s prefered dictionary language (&amp;apos;no&amp;apos; or &amp;apos;en&amp;apos;).|String(5)|&#x25CF;|
|default\_category|The default category for this user when posting tickets and use_last_category is false. |FK [ej-category](ej-category.md)| |
|textareasize|Size of textarea for each user, example &amp;apos;80x40&amp;apos;|String(31)|&#x25CF;|
|flags|A bitmask indicating flags for this entry.|Int|&#x25CF;|
|last\_category|The last chosen category for this user when posting tickets.|FK [ej-category](ej-category.md)|&#x25CF;|
|profile\_id|Reference to the profile connected to this ejuser|FK [profile](profile.md)|&#x25CF;|
|hidden\_bag\_bitset|Each character represent a bit to set a HtmlBagHideable to default open or closed (1=open 0=closed)|String(255)|&#x25CF;|
|notify\_external\_lock|A datetime lock to make sure notifications are only displayed by one notifcation system (ejournal or external programs)|DateTime|&#x25CF;|
|notify\_external\_source|A name (id) of the external notifications system (ejournal or external programs)|String(255)|&#x25CF;|
|login\_attempts|The number of times the user has attempted to login with the wrong password|Int|&#x25CF;|
|last\_login\_attempt|The last time the user tried to log in without success|DateTime|&#x25CF;|
|idle\_time|Number of seconds the user has been idle. Updated by TrayIcon or simular external programs.|Int| |
|default\_user|The default user to set on new tickets in this category (1=automatically, 2=unasigned, 3=the owner|Int|&#x25CF;|
|sms|The SMS number for this user|String(64)|&#x25CF;|
|new\_gui|Whether to use the new gui or not|Bool| |
|dbi\_agent\_id|Integration agent (eJournal)|FK [dbi-agent](dbi-agent.md)| |
|dbi\_key|The primary key for the integrated entry in the external datasource.|String(255)| |
|dbi\_last\_syncronized|Last external syncronization.|DateTime| |
|dbi\_last\_modified|When the entry was last modified.|DateTime| |
|minute\_offset|Offset in hours between server and ejuser timezone.|Int| |
|date\_format|The preferred format of dates and datetimes (enum) for this user.|date-format| |
|simultaneous\_login|A boolean telling if the user is counted as one of the simultaneous ones, or one who alway may log in|Bool| |
|picture\_id|The attachment.id this reference is connected to.|FK [attachment](attachment.md)|&#x25CF;|
|not\_present|Comment to add for user when status is not present.|String(255)|&#x25CF;|
|default\_status\_new\_ticket|Default status on new requests.|FK [ticket-status](ticket-status.md)|&#x25CF;|
|default\_status\_add\_message|Default status on add message.|FK [ticket-status](ticket-status.md)|&#x25CF;|
|num\_expanded\_messages|The number of expanded messages in show-ticket view.|Int| |
|date\_format\_string|Chosen date format as a string for this user|String(64)|&#x25CF;|
|time\_format\_string|Chosen time format as a string for this user|String(64)|&#x25CF;|
|date\_format\_long\_string|Chosen date format for lists as a string for this user|String(64)|&#x25CF;|
|chat\_status|Various chat statuses for an agent|Enum [chatstatus](enums/chatstatus.md)|&#x25CF;|


![ejuser table relationship diagram](./media/ejuser.png)

[!include[details](./includes/ejuser.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|loginname |String(63) |Index |
|usergroup |FK |Index |
|username |String(63) |Index |
|email |String(255) |Index |
|default\_category |FK |Index |
|last\_category |FK |Index |
|profile\_id |FK |Index |
|dbi\_agent\_id |FK |Index |
|dbi\_key |String(255) |Index |
|dbi\_last\_syncronized |DateTime |Index |
|dbi\_last\_modified |DateTime |Index |
|picture\_id |FK |Index |
|default\_status\_new\_ticket |FK |Index |
|default\_status\_add\_message |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.


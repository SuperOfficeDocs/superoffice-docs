---
title: System
uid: pref_system
description: Preference section System
author: SuperOffice Product and Engineering
date: 12.10.2024
keywords: database
topic: reference
---

# Preference section System

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='System'
```

`System` contains important preferences. Changing these is usually done through the admin tool.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AllowCentralLogin | Travel users allowed to log into the central database | No | List | Admin, Admin users, Wizard |
| AllowForcedLogin | Allow users to log on to the system even if they are already logged in on another computer | No | Bool | Admin, Admin users, Wizard |
| BaseCurrencyId | Base currency for your system. This is a common currency for column calculations and so on. | | ListTableRef | Admin, Admin users, Wizard |
| CurrentUdefVersioncontact | The current version number for user-defined fields in the Company screen | | Number | Wizard |
| CurrentUdefVersionperson | The current version number for user-defined fields in the Contact dialog | | Number | Wizard |
| CurrentUdefVersionproject | The current version number for user-defined fields in the Project screen | | Number | Wizard |
| CurrentUdefVersionsale | The current version number for user-defined fields in the Sale dialog | | Number | Wizard |
| DefaultDocPlugin | Default document management system to be used by SuperOffice. | | List | Admin, Crm, Admin users, Wizard |
| EnableCurrency | Allow sales to be recorded in another currency | | Bool | Admin, Crm, Admin users, Wizard |
| MailMergeMoreTimeNeeded | Increases the time available to SuperOffice to complete a mail merge (mass mailing) operation. This time should be increased if you get empty or incomplete documents printed. | | List | Admin, Crm, Admin users, Wizard |
| NotesIniPath | Sets the path to the Notes.ini file | | Text | Wizard |
| OurCurrencyId | Default currency for new sales | | ListTableRef | Admin, Crm, Admin users, Wizard |
| OwnCountry | Which country you are currently located in. This affects phone number prefixes and the suggested country when entering a new company. | | ListTableRef | Admin, Crm, Admin users, Wizard |
| ReplicateSelection | Replicates selection members to Travel and satellite databases. After changing this preference you need to regenerate satellites and create new prototypes. This will reduce performance. | No | Bool | Admin, Admin users, Wizard |

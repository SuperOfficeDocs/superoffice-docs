---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_system       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section System # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section System

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='System'
```

System contains important preferences. Changing these is usually done through the admin tool.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AllowCentralLogin | Travel users allowed to log into the central database | No | List | Admin, Admin users, Wizard |
| AllowForcedLogin | Allow users to log on to the system even if they are already logged in on another computer | No | Bool | Admin, Admin users, Wizard || BaseCurrencyId | Base currency for your system. This is a common currency for reports etc. | | ListTableRef | Admin, Admin users, Wizard |
| CurrentUdefVersioncontact | The current version number for user-defined fields in the Company screen | | Number | Wizard |
| CurrentUdefVersionperson | The current version number for user-defined fields in the Contact dialog | | Number | Wizard |
| CurrentUdefVersionproject | The current version number for user-defined fields in the Project screen | | Number | Wizard |
| CurrentUdefVersionsale | The current version number for user-defined fields in the Sale dialog | | Number | Wizard |
| DefaultDocPlugin | Default document management system to be used by SuperOffice. | | List | Admin, Crm, Admin users, Wizard |
| EnableCurrency | Allow sales to be recorded in another currency | | Bool | Admin, Crm, Admin users, Wizard |
| MailMergeMoreTimeNeeded | Increases the time available to SuperOffice to complete a mail merge (mass mailing) operation. This time should be increased if you get empty or incomplete documents printed. | | List | Admin, Crm, Admin users, Wizard |
| NotesIniPath | Sets the path to the Notes.ini file | | Text | Wizard |
| NotesSODbName | The name of the database in SuperOffice where Lotus Notes e-mail is saved | SOCONFIG\\SoMailArchive.nsf | Text | Admin, Admin users, Wizard |
| OurCurrencyId | Default currency for new sales | | ListTableRef | Admin, Crm, Admin users, Wizard |
| OwnCountry | Which country you are currently located in. This affects phone number prefixes and the suggested country when entering a new company. | | ListTableRef | Admin, Crm, Admin users, Wizard |
| PreferredNotesDocServer | Preferred server name of the Lotus Notes document server | | Text | Admin, Admin users, Wizard |
| PreferredNotesMailServer | Preferred e-mail server name for Lotus Notes | | Text | Admin, Admin users, Wizard |
| ReplicateSelection | Replicates selection members to Travel and satellite databases. After changing this preference you need to regenerate satellites and create new prototypes. This will reduce performance. | No | Bool | Admin, Admin users, Wizard |

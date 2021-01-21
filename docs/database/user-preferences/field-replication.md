---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_fieldreplication       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section FieldReplication # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section FieldReplication

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='FieldReplication'
```

Enables replication of user-defined fields at field level instead of record level. This ensures that field changes for the customer are retained, but may affect the performance of the replication process. This will affect the size of UP/DWN files and how conflicts are handled by the travel system.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| udcontactlarge | Enables replication at field-level for user-defined fields of the large strings on the **Company** card | | Bool| Admin, Admin users, Wizard |
| udcontactsmall | Enables replication at field-level of user-defined fields on the **Company** card. | NO | Bool| Admin, Admin users, Wizard |
| udpersonlarge | Enables replication at field-level for user-defined fields of the large strings on the **Person** card | | Bool|  Admin, Admin users, Wizard |
| udpersonsmall | Enables replication at field-level of user-defined fields in the **Contact** dialog. | NO | Bool| Admin, Admin users, Wizard |
| udprojectlarge | Enables replication at field level for user-defined fields of the large strings on the **Project** card | | Bool|  Admin, Admin users, Wizard |
| udprojectsmall | Enable replication at field level for user-defined fields on the **Project** card. | NO | Bool | Admin, Admin users, Wizard |
| udsalelarge | Enables replication at field level for user-defined fields of the large strings on the sale dialog | | Bool | Admin, Admin users, Wizard |
| udsalesmall | Enables replication at field level for user-defined fields in the **Sale** dialog. | NO | Bool | Admin, Admin users, Wizard*

> [!NOTE]
> Activating **udcontactsmall**, **udpersonsmall**, **udprojectsmall**, or **udsalesmall** may affect the speed at which UP and DWN files are read and written.

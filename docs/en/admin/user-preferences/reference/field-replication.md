---
title: FieldReplication
uid: pref_fieldreplication
description: Preference section FieldReplication
author: SuperOffice Product and Engineering
keywords: database
topic: reference
---

# Preference section FieldReplication

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='FieldReplication'
```

Enables replication of user-defined fields at field level instead of at record level. This ensures that field changes for the customer are retained, but may affect the performance of the replication process. This will affect the size of UP/DWN files and how conflicts are handled by the travel system.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| udcontactlarge | Enables replication at field-level for user-defined fields of the large strings on the **Company** card | | Bool| Admin, Admin users, Wizard |
| udcontactsmall | Enables replication at field-level of user-defined fields on the **Company** card. | NO | Bool| Admin, Admin users, Wizard |
| udpersonlarge | Enables replication at field-level for user-defined fields of the large strings on the **Person** card | | Bool|  Admin, Admin users, Wizard |
| udpersonsmall | Enables replication at field-level of user-defined fields in the **Contact** dialog. | NO | Bool| Admin, Admin users, Wizard |
| udprojectlarge | Enables replication at field level for user-defined fields of the large strings on the **Project** card | | Bool|  Admin, Admin users, Wizard |
| udprojectsmall | Enable replication at field level for user-defined fields on the **Project** card. | NO | Bool | Admin, Admin users, Wizard |
| udsalelarge | Enables replication at field level for user-defined fields of the large strings on the sale dialog | | Bool | Admin, Admin users, Wizard |
| udsalesmall | Enables replication at field level for user-defined fields in the **Sale** dialog. | NO | Bool | Admin, Admin users, Wizard |

> [!NOTE]
> Activating **udcontactsmall**, **udpersonsmall**, **udprojectsmall**, or **udsalesmall** may affect the speed at which UP and DWN files are read and written.

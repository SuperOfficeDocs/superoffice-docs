---
title: AppointmentDialog
uid: pref_appointmentdialog
description: Preference section AppointmentDialog
author: SuperOffice Product and Engineering
keywords: database
topic: reference
redirect_from: /en/admin/user-preferences/reference/index
---

# Preference section AppointmentDialog

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='AppointmentDialog'
```

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AppointmentDialogExpanded | Preference used to remember the setup/state of the **Filter** dialog | | Bool | Wizard |

> [!NOTE]
> **Follow-up** dialog pertains to SuperOffice 5. It is obsolete in version 6.

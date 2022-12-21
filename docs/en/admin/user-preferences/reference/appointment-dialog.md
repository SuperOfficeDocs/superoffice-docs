---
title: AppointmentDialog
uid: pref_appointmentdialog
description: Preference section AppointmentDialog
author: {github-id}
keywords: database
so.topic: reference
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

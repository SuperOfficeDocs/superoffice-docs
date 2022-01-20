---
title: Pocket Tasks
uid: pref_pockettasks
description: Preference section Pocket Tasks
author: {github-id}
keywords: database
so.topic: reference
---

# Preference section Pocket Tasks

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='PocketTasks'
```

Global preferences for Mobile CRM.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AutoLogoutTime | Time in minutes the application can be kept idle in the background before an automatic loggout is performed. Default value = 0, means no timeout.  | 0 | Number | Wizard, Admin |
| DisableAutoLogin | Prevent Mobile CRM client from logging in automatically on startup. | No | Bool | Wizard, Admin|
| EnableCRMScript | Activate / deactivate execution of CRMScript from Mobile CRM. | Yes | Bool | Wizard, Admin |


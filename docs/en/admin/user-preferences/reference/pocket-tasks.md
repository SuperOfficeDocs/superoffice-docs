---
title: PocketTasks
uid: pref_pockettasks
description: Preference section Pocket Tasks
author: {github-id}
keywords: database
so.topic: reference
so.version: 10.0.3
so.date: 01.20.2022
---

# Preference section PocketTasks

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='PocketTasks'
```

Global preferences for Mobile CRM.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AutoLogoutTime | Time in minutes the application can be kept idle in the background before an automatic logout is performed. | 0 (no timeout) | Number | Wizard, Admin |
| DisableAutoLogin | Prevent Mobile CRM client from logging in automatically on startup. | NO | Bool | Wizard, Admin|
| EnableCRMScript | Activate / deactivate execution of CRMScript from Mobile CRM. | YES | Bool | Wizard, Admin |

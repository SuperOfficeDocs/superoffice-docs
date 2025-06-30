---
title: FieldLabels
uid: pref_fieldlabels
description: Preference section FieldLabels
author: SuperOffice Product and Engineering
keywords: database
topic: reference
---

# Preference section FieldLabels

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='FieldLabels'
```

Field labels are turned on/off using preferences, but the actual labels are stored in the LocaleText table.

| Preference | Description | Control type | Access |
|---|---|---|---|
| LastLanguage | Last-used language for field labels | Number | Wizard |
| ShowCustomFieldLabels | Enabling this setting will allow you to edit field labels in the system | Bool | Wizard |

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_fieldlabels       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section FieldLabels # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section FieldLabels

[!include[SQL](./includes/to-view-pref.md)]

```sql
SELECT * FROM UserPreference WHERE prefsection='FieldLabels'
```

Field labels are turned on/off using preferences, but the actual labels are stored in the LocaleText table.

| Preference | Description | Control type | Access |
|---|---|---|---|
| LastLanguage | Last-used language for field labels | Number | Wizard |
| ShowCustomFieldLabels | Enabling this setting will allow you to edit field labels in the system | Bool | Wizard |

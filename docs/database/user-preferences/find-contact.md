---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_findcontact       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section FindContact # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section FindContact

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='FindContact'
```

Finds companies dialog.

| Preference | Description | Control type | Access |
|---|---|---|---|
| Code | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| Email | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| Expanded | [!include[pref](./includes/pref-filter.md)] | Bool | Wizard |
| FirstName | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| LastName | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| Name | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| Number | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| OrgNr | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| Phone | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| SearchType | [!include[pref](./includes/pref-filter.md)] | Number | Wizard |

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_filter       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Filter # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Filter

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Filter'
```

Filter dialog settings

| Preference | Description | Control type | Access |
|---|---|---|---|
| All | [!include[pref](./includes/pref-filter.md)] | Bool | Wizard |
| Associate | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| DaysAfter | [!include[pref](./includes/pref-filter.md)] | Number | Wizard |
| DaysBefore | [!include[pref](./includes/pref-filter.md)] | Number | Wizard |
| Group | [!include[pref](./includes/pref-filter.md)] | Text | Wizard |
| NumAssociates | [!include[pref](./includes/pref-filter.md)] | Number | Wizard |
| NumGroups | [!include[pref](./includes/pref-filter.md)] | Number | Wizard |

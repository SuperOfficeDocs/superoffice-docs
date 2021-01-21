---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_scripting       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Scripting # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Scripting

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Scripting'
```

| Preference | Description | Control type | Access |
|---|---|---|---|
| EnablePersonalScripts | Enable personal scripts | Number | Admin, Admin users, Wizard |
| EnableScripting | Enables scripting | Number | Admin, Admin users, Wizard |

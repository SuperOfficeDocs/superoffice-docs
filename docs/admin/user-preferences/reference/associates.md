---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_associates       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Associates # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Associates

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Associates'
```

Associate preferences like which radiobutton did I select the last time I used this dialog/control
or which item did I select last time I used this drop-down list.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AssocSubListWeb | Preference used to remember what sublist in the associate selector that was last used<br>-2 = All users<br>-1 = History<br>>0 = ID of department | | Number | crm |
| ResourceSubListWeb | Preference used to remember the setup/state of the Filter dialog<br>-2 = All resources<br>-1 = History<br>>0 = ID of resource heading | | Number | crm |
| AssocHomeCountry | Home country of associate if it differ from company | | | |

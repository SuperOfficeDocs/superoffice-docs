---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_phone       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Phone # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Phone

[!include[SQL](./includes/to-view-pref.md)]

```sql
SELECT * FROM UserPreference WHERE prefsection='Phone'
```

| Preference | Description | Control type | Access |
|---|---|---|---|
| Phone DdeData | DDE Data | Text | Wizard |
| DdeItem | DDE Item | Text | Wizard |
| DdeService | DDE Service | Text | Wizard |
| DdeTopic | DDE Topic | Text | Wizard |
| DdeType | DDE Type | List | Wizard |
| DialType | Dial type | List | Wizard |
| FormatNumber | Formats number | Bool | Wizard |
| LocalAreaCode | Local area code | Text | Wizard |
| LongDistancePrefix | Long distance prefix | Text | Wizard |
| Postfix | Suffix - e.g. Command to reset your modem | Text | Wizard |
| Prefix | Prefix - e.g. Dial 0 to get an outside line | Text | Wizard |
| ProgDir | Program folder | Text | Wizard |
| ProgFile | Program file | Text | Wizard |
| ProgParam | Program parameter - passed on command line to progfile. | Text | Wizard |

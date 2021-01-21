---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_freetext       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Freetext # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Freetext

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Freetext'
```

Freetext search settings. These are usually edited in the admin tool.

| Preference | Description | Control type | Access |
|---|---|---|---|
| AutoEnableTravel | Automatically enables free-text search on Travel databases. This will increase the size of local databases and the time required to generate prototypes | Bool| Wizard |
| Enabled | Enables freetext search | Bool|  Wizard |
| MaxSuggestWords | Maximum number of different words to be suggested as stopwords in stopword maintenance | Number| Admin, Admin users, Wizard |
| MultiWordFTHitLimit | Maximum number of hits returned by a multi-word free-text search<br>0 = no limit | Number|  Admin, Admin users, Wizard |
| MultiWordFTOperator | Criteria for free-text search on multiple words<br>1 = contains<br>2 = starts with<br>3 = exact match | List|  Wizard |
| SingleWordFTHitLimit | Max. number of hits returned by a single-word free-text search<br>0 = no limit | Number|  Admin, Admin users, Wizard |
| SingleWordFTOperator | Criteria for free-text search on a single word<br>1 = contains<br>2 = starts with<br>3 = exact match | List|  Wizard |

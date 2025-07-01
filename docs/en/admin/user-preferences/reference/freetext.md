---
title: Freetext
uid: pref_freetext
description: Preference section Freetext
author: SuperOffice Product and Engineering
keywords: database
topic: reference
---

# Preference section Freetext

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Freetext'
```

Free-text search settings. These are usually edited in the admin tool.

| Preference | Description | Control type | Access |
|---|---|---|---|
| AutoEnableTravel | Automatically enables free-text search on Travel databases. This will increase the size of local databases and the time required to generate prototypes | Bool| Wizard |
| Enabled | Enables free.text search | Bool|  Wizard |
| MaxSuggestWords | Maximum number of different words to be suggested as stopwords in stopword maintenance | Number| Admin, Admin users, Wizard |
| MultiWordFTHitLimit | Maximum number of hits returned by a multi-word free-text search<br>0 = no limit | Number|  Admin, Admin users, Wizard |
| MultiWordFTOperator | Criteria for free-text search on multiple words<br>1 = contains<br>2 = starts with<br>3 = exact match | List|  Wizard |
| SingleWordFTHitLimit | Max. number of hits returned by a single-word free-text search<br>0 = no limit | Number|  Admin, Admin users, Wizard |
| SingleWordFTOperator | Criteria for free-text search on a single word<br>1 = contains<br>2 = starts with<br>3 = exact match | List|  Wizard |

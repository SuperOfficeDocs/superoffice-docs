---
title: Associates
uid: pref_associates
description: Preference section Associates
author: SuperOffice Product and Engineering
keywords: database
topic: reference
---

# Preference section Associates

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Associates'
```

Associate preferences like which radio-button did I select the last time I used this dialog/control
or which item did I select last time I used this drop-down list.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AssocSubListWeb | Preference used to remember what sublist in the associate selector that was last used<br>-2 = All users<br>-1 = History<br>>0 = ID of department | | Number | crm |
| ResourceSubListWeb | Preference used to remember the setup/state of the Filter dialog<br>-2 = All resources<br>-1 = History<br>>0 = ID of resource heading | | Number | crm |
| AssocHomeCountry | Home country of associate if it differs from company | | | |

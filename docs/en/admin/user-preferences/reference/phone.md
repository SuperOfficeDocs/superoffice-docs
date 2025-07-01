---
title: Phone
uid: pref_phone
description: Preference section Phone
author: SuperOffice Product and Engineering
keywords: database
topic: reference
---

# Preference section Phone

[!include[SQL](./includes/to-view-pref.md)]

```SQL
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

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_diaryview       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section DiaryView # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section DiaryView

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='DiaryView'
```

Diary preferences control the calendar display in the diary panel.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AllDayEndTime | End time for an all-day appointment | | Date | Admin, Crm, Admin users, Wizard |
| AllDayStartTime | Start time for an all-day appointment | | Date | Admin, Crm, Admin users, Wizard |
| DefaultAlarmTime | Default number of minutes before a follow-up alarm is triggered | | Number | Admin, Crm, Admin users, Wizard |
| DiaryStartTime | Specifies the time your calendar starts in the morning.<br>Use a number to indicate the whole hour. | 8<br>(your calendar will start at 08:00) | Number | Admin, Admin users, Wizard |
| DiaryViewAssociates | A comma-separated list of the associates and resources to display in the group view | | Text | Wizard |
| DiaryViewNumAssociates | Number of columns to display in the group view | | Number | Wizard |
| DiaryViewSubList | Preference used to remember the setup/state of the Filter dialog | | Number | Wizard |
| DiaryViewShowUserGroup | Preference used to remember the current diary view | | Text | |
| LunchEndTime | End time for your lunch-break | | Date | Admin, Crm, Admin users, Wizard |
| LunchStartTime | Start time for your lunch-break | | Date | Admin, Crm, Admin users, Wizard |
| SecretaryMode | Keeps the current diary owner in all panels | NO | Bool | Admin, Crm, Admin users, Wizard |
| SilentAfter | The alarm can be silenced after a given number of minutes to avoid unnecessary office disruption when you are away. | | Number | Admin, Crm, Admin users, Wizard |

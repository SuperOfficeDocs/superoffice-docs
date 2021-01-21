---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_visual       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Visual # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Visual

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Visual'
```

Visual effects - these don't affect the functionality of the client, but how information is presented to the user in the client.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AcademicTitle | Use academic title for persons. | NO | Bool | Admin, Admin users, Wizard |
| AnimatePanels | Enables animation when switching screens | | Bool | Wizard |
| CalendarPos | Where should the calendar appear.<br>0 = at the top of the Navigator<br>1 = in the top right-hand corner. | 1 | Bool | Wizard |
| FilterCompletedFromTodo | Filter: Removes completed activities from the checklist | | Bool | Admin, Crm, Admin users, Wizard |
| FilterShowRedLimit | Percentage below which 'Shows x out of y' is red in archives | 10 | Number | Admin, Crm, Admin users, Wizard |
| FilterShowYellowLimit | Percentage below which 'Shows x out of y' is yellow in archives | 40 | Number | Admin, Crm, Admin users, Wizard |
| FrameType | Which frame type to use in edit fields | | Text | Wizard |
| HistorySize | The maximum number of elements in a history list | | Number | Admin, Crm, Admin users, Wizard |
| JpegQuality | Quality parameter for JPEG compression of stored images, from 0 to 100; 100 is best,<br>Setting high values will result in sharper images, at the cost of storage space in the database and loading times. | 40 | Number | Admin, Crm, Admin users, Wizard |
| MonitorLight | Status images are processed to make them seem transparent. This parameter controls how much the light level is increased from a normalized starting point. Higher values will result in lighter images, possibly resulting in loss of detail. |80 | Number | Admin, Admin users, Wizard |
| ShowNotepad | Should the Notepad be displayed when SuperOffice is started? | NO | Bool | Admin, Admin users, Wizard |
| SundayFirstDay | Display Sunday as the first day of the week in the calendar and diary. | NO<br>(Monday will be used as the first day of the week) | Bool | Admin, Crm, Admin users, Wizard |
| Tooltips | Turn tooltips on or off | | Bool | Admin, Crm, Admin users, Wizard |

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_netservices       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
uid: prefNetServices
description: Preference section 'NetServices' # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section: NetServices

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='NetServices'
```

SuperOffice web services settings are used by the web-panel to automatically display information from SuperOffice when the user logs on.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| ELearningUrl | URL to E-learning | | Text | Admin, Admin users, Wizard |
| EnableNetServicesOnCentral | Make web services available on your central and satellite databases. | YES | Bool | Admin, Admin users, Wizard |
| EnableNetServicesOnTravel | Make web services available on your Travel databases. | YES | Bool | Admin, Admin users, Wizard |
| LastPage | Last page read | | Number | Wizard |
| NewsURL | News URL | | Text | Wizard |
| NextCheck | Next date SuperOffice should check for news on web services (yyyy-mm-dd) | | Text | Wizard |
| PageURL | Page URL | | Text | Wizard |
| SeenTeaserDlg | The user has read the teaser from web services. | | Bool | Wizard |
| ShowOnStartup | Show news from SuperOffice web services on startup. | YES | Bool | Admin, Admin users, Wizard |
| StatusCheckTimeout | Timeout for reading status from web services in seconds. | 60 | Number | Admin, Admin users, Wizard |
| StatusURL | Status URL | | Text | Wizard |
| TeaserURL | Teaser URL | | Text | Wizard |
| UserPassportId | The Microsoft Passport ID of this associate (not the email address) | | Text | Admin, Admin users, Wizard |

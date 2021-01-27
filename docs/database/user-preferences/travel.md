---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_travel       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Travel # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Travel

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Travel'
```

Travel preferences affect how the Travel Gateway works, and how travel is shown to the user.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| AdvancedTravelMenu | Should the Travel icon/menu display the advanced Travel options | | Bool | Wizard |
| EnableTravel | Is Travel enabled? | Bool | Wizard |
| FlushAfterReadAll | If Yes, the Travel Gateway will force a refresh on all clients after the Read update from all users event has been executed. | YES | Bool | Admin, Admin users, Wizard |
| GWSilent | Should progress dialogs be displayed when Travel Gateway is executing activities? | NO | Bool | Admin, Admin users, Wizard |
| OfferBlockCentralLogin | Allows Remote Travel users to prevent SuperOffice from trying to perform a Central update even if the central database is available when SuperOffice is started while the Remote Travel user is travelling. | NO | Bool | Admin, Admin users, Wizard |
| RemoteTravelClient | Program file used to synchronize between a local Remote Travel user and the central document archive. | SORT.EXE | Text | Admin, Crm, Admin users, Wizard |
| RemoteTravelServer | Name of the EXE file used as your Remote Travel Server. | SORTS.EXE | Text | Admin, Admin users, Wizard |
| TravelAsMenu | Should the Navigator display a Travel icon for users allowed to use Travel? | | Bool | Admin, Crm, Admin users, Wizard |
| EnableStats | Enable logging of usage patterns in SuperOffice. These logs may be subsequently used as background information for improvements to the product and for enhanced user training. | YES | Bool | Wizard |

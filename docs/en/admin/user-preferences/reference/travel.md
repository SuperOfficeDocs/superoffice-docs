---
title: Travel
uid: pref_travel
description: Preference section Travel
author: SuperOffice Product and Engineering
keywords: database
topic: reference
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
| EnableTravel | Is Travel enabled? | | Bool | Wizard |
| FlushAfterReadAll | If Yes, the Travel Gateway will force a refresh on all clients after the Read update from all users event has been executed. | YES | Bool | Admin, Admin users, Wizard |
| GWSilent | Should progress dialogs be displayed when Travel Gateway is executing activities? | NO | Bool | Admin, Admin users, Wizard |
| OfferBlockCentralLogin | Allows Remote Travel users to prevent SuperOffice from trying to perform a Central update even if the central database is available when SuperOffice is started while the Remote Travel user is travelling. | NO | Bool | Admin, Admin users, Wizard |
| RemoteTravelClient | Program file used to synchronize between a local Remote Travel user and the central document archive. | SORT.EXE | Text | Admin, Crm, Admin users, Wizard |
| RemoteTravelServer | Name of the EXE file used as your Remote Travel Server. | SORTS.EXE | Text | Admin, Admin users, Wizard |
| TravelAsMenu | Should the Navigator display a Travel icon for users allowed to use Travel? | | Bool | Admin, Crm, Admin users, Wizard |
| EnableStats | Enable logging of usage patterns in SuperOffice. These logs may be subsequently used as background information for improvements to the product and for enhanced user training. | YES | Bool | Wizard |

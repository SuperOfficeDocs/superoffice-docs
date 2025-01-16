---
uid: help-en-system-events
title: System events
description: System events
author: SuperOffice RnD
date: 06.29.2022
keywords: event
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# System events

The following types of events are started from the various screens in Settings and maintenance:

* **UDefRebuild**, of which there are several types: the layout of user-defined fields is being updated and the user-defined fields cannot be accessed while the event is in progress.

    > [!NOTE]
    > You must not cancel this event from the **System notifications** list.

* **FreetextRebuild**: the freetext index is being generated and users can not use the free-text while generation is in progress.

* **PrototypeRebuild**: a Travel prototype is being generated. The Travel functions cannot be accessed while this event is in progress.

    > [!NOTE]
    > In cases of emergency you can cancel both **FreetextRebuild** and **PrototypeRebuild** from the **System notifications** list.

* **ROURebuild**: counters or status monitors are being regenerated. Status images, the **Statistics** tab and counters are unavailable while the event is underway. (Status monitors require a [separate license][2].)

You can start the following types of event from the Licences screen **Status** tab:

* **No Login**: Select this event to prevent login during server or database upgrades, scheduled maintenance, and so on.
* **No Freetext**: Select this event to limit the size of the outgoing Travel database.
* **No Travel**: Select this event to deactivate Travel. This can be useful just before major system upgrades, to avoid synchronization issues for returning Travel users.
* **Message of the day**: Select this event to create important messages that are displayed to everyone who logs in to SuperOffice CRM (and, after a few minutes, the message is also shown to anyone already logged in).

[!include[Terminate events](includes/note-terminate-event.md)]

## What would you like to do now?

* [Add system events][1]

<!-- Referenced links -->
[1]: add-system-event.md
[2]: https://docs.superoffice.com/en/admin/license/index.html

<!-- Referenced images -->

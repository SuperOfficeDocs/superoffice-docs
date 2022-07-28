---
uid: help-en-system-events
title: System events
description: System events
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# System events

In the **System notifications** list in the **Status** tab in the **Licences** screen, you can keep track of events which are active in the system.

The **System events** tab consists of two parts:

* **Events**. <!-- Fix reuse ID=a1 -->
    Under **System notifications** you will find the following columns:

    Event
    Shows the name of the event.
    Status
    Shows the status of the event.
    Message
    Shows the description of the event.
    Activated
    Shows when the event was initiated.
    Activated by
    Shows who initiated the event (user ID and portrait).
    Finished
    Shows when the event is expected to finish.

    > [!NOTE]
    > Events are not terminated automatically. You need to remove them from the **System events** tab to terminate them.

    Type
    Shows whether the event applies to the whole system.
* **Description**, which shows detailed information about the event currently selected under **Events**.

The following types of events are started from the various screens in Settings and maintenance:

* **UDefRebuild**, of which there are several types: the layout of user-defined fields is being updated and the user-defined fields in SuperOffice CRM cannot be accessed while the event is in progress.

    > [!NOTE]
    > You must not cancel this event from the **System notifications** list.

* **FreetextRebuild**: the freetext index is being generated and freetext searching cannot be performed in SuperOffice CRM while generation is in progress.

* **PrototypeRebuild**: a Travel prototype is being generated. The Travel functions cannot be accessed while this event is in progress.

    > [!NOTE]
    > In cases of emergency you can cancel both **FreetextRebuild** and **PrototypeRebuild** from the **System notifications** list.

<!-- -->

* **ROURebuild**: counters or status monitors are being regenerated. Status images, the **Statistics** tab and counters are unavailable while the event is underway. (Status monitors require a separate licence. See [Licences][2].)

You can start the following types of event from the **Status** tab:

* **No Login**: Select this event to prevent login during server or database upgrades, scheduled maintenance etc.
* **No Freetext**: Select this event to limit the size of the outgoing Travel database.
* **No Travel**: Select this event to deactivate Travel. This can be useful just before major system upgrades, to avoid synchronisation issues for returning Travel users.
* **Message of the day**: Select this event to create important messages that are displayed to everyone who logs in to SuperOffice CRM (and, after a few minutes, the message is also shown to anyone already logged in).

## What would you like to do now?

* [Add system events][1]

<!-- Referenced links -->
[1]: Adding-system-events.md
[2]: ../licenses/Licences-screen.md

<!-- Referenced images -->


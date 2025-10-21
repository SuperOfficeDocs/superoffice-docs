---
uid: help-en-system-event-add
title: Adding system events
description: Adding system events
keywords: add system event, system event, system notification
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /en/admin/learn/system-events
  - /en/admin/learn/add-system-events
language: en
---

# Add system events (Onsite)

You can initiate some system events from **System notifications** list in the **Status** tab.

## Steps

1. Open the Licences screen.

2. Select the **Status** tab.

3. Click the **Add** button below **System notifications**.

4. In the **Add event** dialog, choose a [system event type](#types) from the **Event type** list box.

5. Specify the date and time when you expect the event to finish in the **Finished** fields.

    > [!NOTE]
    > Events are not terminated automatically. You must remove them from the **System events** tab to terminate them.

6. Enter more detailed information about the event in the **Description** field.

    > [!NOTE]
    > If you add an event of the type **Message of the Day** (message to all users), it is the text in the **Description** field which is sent to users, together with the expected completion time.

7. Click **Save** to create the event. It is displayed in the **System Notifications** list in the **Status** tab.

> [!TIP]
> To edit an event, double-click it in the list.
>
> To delete an event, select it in the list an click the **Delete** button.

## <a id="types"></a>Types

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

<!-- Referenced links -->
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->

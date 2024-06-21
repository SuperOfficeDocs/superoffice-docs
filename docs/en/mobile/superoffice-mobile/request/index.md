---
uid: mobile-crm-request
title: Request
description: Learn about working with requests in SuperOffice Mobile CRM.
author: Bergfrid Dias
date: 08.03.2023
keywords: mobile, request, ticket, Service
topic: reference
version: 10
language: en
client: mobile
---

# Request ![icon][img11]

Mobile CRM gives you access to the most essential features of SuperOffice on a smartphone and tablet. Handling customer requests in the Mobile CRM app allows you to stay in control of customer service no matter where you are.

> [!NOTE]
> The **Requests** tab is shown only if your company has a Service or complete license.
> Individual users may view request info without a service user plan if their role and the request's category permits, but then may not reply or perform other actions.

Watch the video [request handling][10] to learn how to handle customer service requests in Mobile CRM (video length – 1:31).

## Tabs in the main Request screen

| Icon | Tab | Description |
|:-:|---|---|
| ![icon][img19] | Search | Search field (by ID or title) and history list. |
| ![icon][img18] | Favorites | Requests marked as a favorite (yellow star). |
| ![icon][img7] | Open requests | Your own or a colleague's. |
| ![icon][img8] | Unassigned requests | |
| ![icon][img9] | Selections | A list of selections of type request. |

## Request information

**Header:**

* Icon (request image or placeholder)
* Status
* Request title
* Customer name - company (click to navigate)

Icons in the action bar: Reply, Add comment, Call (the customer connected to the request), Messages, Details

![Mobile CRM: Request -app-screen][img1]

The **Task** menu lets you take pictures and add them as attachments to a message, change request status, set the owner, and reply to and add comments to the request.

## Where can I find requests?

* The main **Requests** screen
* Tab in Contact screen
* Tab in Sale screen
* Tab in Project screen

When viewing a contact, sale, or project, the **Requests** tab shows open requests linked to a specific item.

In lists, you will typically see ID, title, created at, status, and category for each request. The sort order is *created at - descending*.

## View your open requests

1. Go to **Requests** ![icon][img10].

2. Check that your name appears at the top.

    If another person's name is shown in red, this means that you are looking at another person's requests. Select the person's name and switch to your own open requests.

3. Select a request from the list.

4. Optionally, filter internal messages (show/hide) from the **Task** menu.

5. Switch between viewing request details and messages.

    * Tap ![icon][img4] to switch to messages.
    * Tap ![icon][img5] to switch to details.

    [!include[Configure visible fields](../includes/tip-visible-fields.md)]

## View someone else's requests

Need to keep an eye on your direct reports or wonder about what your colleagues are up to?

1. In the **Requests** screen, select the **Open requests** tab.
1. Select the name just below the row of tabs.
1. On the **Set owner** page, select a person from the history list or search for an associate. Their name is now shown in red above the list of requests.
1. Explore their open requests as described above.

> [!NOTE]
> When you open another person's requests, only information that you have the rights to see is shown.

## Notifications

You can get notifications on your device for different events:

* New request
* New request message
* Request activated
* Request escalation

### In Notification Centre (iOS) / Notification drawer (Android)

![SuperOffice Mobile CRM request notifications -app-screen][img20]

Click the notification to open the request in Mobile CRM.

> [!TIP]
> Switch on and off push notifications for specific request events in Mobile CRM > **Settings** > **Notifications**.

### In Mobile CRM Notification screen

1. In the navigator, select **Notifications**.
2. Select the **Requests** tab.
3. Open the **Task** menu to filter which types of notifications you see. Unread notifications are bold.
4. Tap a request to open it.

## Related content

* [New request][1]
* [Update request properties (details)][2]
* [Add comment (internal message)][4]
* [Reply / reply all][3]
* [Forward][5]
* [Manage notifications][6]
* [About reply templates][11]
* [Introduction to request management][12]

<!-- Referenced links -->
[1]: create.md
[2]: update.md
[3]: respond.md#reply
[4]: respond.md#comment
[5]: respond.md#forward
[6]: ../settings.md
[10]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/service--reqeusts/request-handling-mobile-crm.mp4
[11]: ../../../request/reply-templates/learn/index.md
[12]: ../../../request/learn/index.md

<!-- Referenced images -->
[img1]: media/request-header.png
[img4]: ../../../../../common/icons/mobile/messages.png
[img5]: ../../../../../common/icons/mobile/details.png
[img7]: ../../../../../common/icons/mobile/request-myopen-h32.png
[img8]: ../../../../../common/icons/mobile/request-unassigned-h32.png
[img9]: ../../../../../common/icons/mobile/request-selection-h32.png
[img10]: ../../../../../common/icons/mobile/request-header.png
[img11]: ../../../../../common/icons/mobile/ticket.png
[img18]: ../../../../../common/icons/mobile/star-h32.png
[img19]: ../../../../../common/icons/mobile/search-h32.png
[img20]: ../../../../../release-notes/mobile/media/mobile-request-notifications.png

---
uid: mobile-crm-request
title: Request
description: Learn about working with requests in SuperOffice Mobile CRM.
keywords: mobile, request, ticket, Service, customer
author: Bergfrid Dias
date: 06.10.2025
version: 11.1
content_type: concept
platform: mobile
language: en
---

# Requests <i class="ph ph-ticket" aria-hidden="true"></i>

From the **Requests** screen, you can follow up on customer tickets and collaborate with your team while on the go.

> [!NOTE]
> The **Requests** screen is available only if your company has a Service or Complete license.
> Some users may be able to view requests without a service user plan, depending on their role and the request category. These users cannot reply or take action on the request.

## Tabs in the main Requests screen

| Tab | Description |
|---|---|
| Search | Search field for ID or title, with history list. |
| Favorites | Requests marked with a yellow star. |
| Open requests | Your assigned requests, or another user's. |
| Unassigned requests | Open requests without an owner. |
| Selections | Requests from predefined selections. |

## Where to find requests

You can access requests from the following locations:

* The main **Requests** screen. Lists typically show:
  * Request icon and status badge
  * Title
  * Customer name
  * Created date and time
  * Request ID

* The **Requests** section in a company, contact, sale, or project screen, which shows open requests linked to that record.

![Mobile CRM: Unassigned requests list with icons and badges -app-screen][img2]![Mobile CRM: requests section on a company card -app-screen][img1]

## Request header

* Icon (request type)
* Status badge (for example, *In queue* or *Closed*)
* Title
* Category
* Customer name - company (tap to open)
* **Edit** (<i class="ph ph-pencil-simple" aria-label="Pencil icon"></i>) and **Task** (<i class="ph ph-dots-three-circle-vertical" aria-label="Three vertical dots"></i>) buttons
* Action bar: Reply, Comment, Call

![Mobile CRM: Request header showing title, actions, and details -app-screen][img3]

## View your open requests

1. Go to **Requests**.
1. Ensure your name appears at the top.
    * If another person's name is shown, tap it to switch back to your own queue.
1. Tap a request to view its details and messages.
    * Tap <i class="ph ph-caret-right" aria-label="Chevron"></i> to expand the <i class="ph ph-list-bullets" aria-hidden="true"></i> **Details** section and view all fields.
    * Scroll down to view the message thread. Tap the **Filter** icon (<i class="ph ph-funnel" aria-hidden="true"></i>) to show or hide internal and flagged messages.
1. Use the action bar to reply, comment, or call the customer.
    * More options are available from the Task menu (<i class="ph ph-dots-three-circle-vertical" aria-true="true"></i>).

## View another user's requests

1. In the **Open requests** tab, tap the name in the **View** box.
1. Select a person from the list or use the search field.
    * Their name appears in red above the list.
1. View their requests as described above.

![Mobile CRM: Viewing another user's open requests -app-screen][img4]

> [!NOTE]
> You will only see information you have access to in the selected requests.

## Notifications

You can receive notifications about requests both on your device and in the app.

### In Notification Centre (iOS) or Notification Drawer (Android)

Mobile CRM supports push notifications for events such as:

* New request
* New message
* Request activated
* Request escalation

Tap the notification to open the request in Mobile CRM.

> [!TIP]
> Go to **Settings** > **Notifications** to [turn request notifications on or off by event type][6].

### In the in-app Notification screen

1. Tap <i class="ph ph-bell" aria-label="Bell icon"></i> in the app header.
1. Select the **Requests** tab.
    * Unread items appear in bold.
1. Tap the **Filter** icon (<i class="ph ph-funnel" aria-hidden="true"></i>) to filter notification types.
1. Tap a request to open it.

![Mobile CRM: Filter notifications for requests in Mobile CRM -app-screen][img5]

## Related content

* [Create request][1]
* [Update request properties][2]
* [Reply or add comment][3]
* [Forward a request][5]
* [Introduction to request management][12]

<!-- Referenced links -->
[1]: create.md
[2]: update.md
[3]: respond.md#reply
[5]: respond.md#forward
[6]: ../settings.md
[12]: ../../../request/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/mobile/company-requests.png
[img2]: ../../../../media/loc/en/mobile/unassigned-requests.png
[img3]: ../../../../media/loc/en/mobile/request-dx.png
[img4]: ../../../../media/loc/en/mobile/view-requests-not-own.png
[img5]: ../../../../media/loc/en/mobile/filter-request-notifications.png

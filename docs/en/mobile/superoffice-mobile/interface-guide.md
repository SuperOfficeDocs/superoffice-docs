---
uid: mobile-crm-interface-guide
title: Mobile CRM interface guide
description: Learn how to use the navigation wheel, action bar, and other core features in SuperOffice Mobile CRM.
keywords: mobile interface, menu, navigation, navigation wheel, thumb wheel, fan menu, action bar, user interface, UI
author: Bergfrid Dias
date: 06.10.2025
version: 11.1
content_type: reference
platform: mobile
language: en
index: true
---

# Interface guide

Welcome to the new SuperOffice Mobile CRM experience. This page walks you through the essential elements of the user interface: how to navigate, act on data, and customize what you see.

## Navigation wheel <i class="ph ph-list" aria-label="Main menu"></i>

Tap the **Menu** button in the bottom center of the screen to open the navigation wheel (navigator). This gives you access to the main screens in Mobile CRM.

![Mobile CRM: Navigation wheel -app-screen][img2]

| Icon | Screen | Description |
|:-:|---|---|
| <i class="ph ph-calendar" aria-label="Diary icon"></i> | Diary | View your calendar, create follow-ups, and check availability. |
| <i class="ph ph-buildings" aria-label="Company icon"></i> | Companies | Browse and manage company cards. |
| <i class="ph ph-currency-circle-dollar" aria-label="Sale icon"></i> | Sales | Track deals, update sales stages, and add new opportunities. |
| <i class="ph ph-clipboard-text" aria-label="Project icon"></i> | Projects | Manage project information and change status. |
| <i class="ph ph-ticket" aria-label="Request icon"></i> | Requests | Handle customer service tickets (coming soon). |
| <i class="ph ph-gauge" aria-label="Dashboard icon"></i> | Dashboards | Access your dashboards and drill down on metrics. |
| <i class="ph ph-gear" aria-label="Gear icon"></i> | Settings | Access app settings like email, notifications, caller ID, and sync. |
| <i class="ph ph-user-circle" aria-label="Contact icon"></i> | Contacts | View and update contact records. |

## App header and notifications <i class="ph ph-bell" aria-hidden="true"></i>

The main screens in Mobile CRM share the same header layout:

* **Logo** (top left)
* **Screen name** (centered)
* **Notifications** bell icon (top right)

If the bell icon shows a number in a red circle, you have pending invitations, requests, or quote approval. Tap the bell to open the Notifications screen and view recent alerts.

## Tabs

Most screens contain horizontal tabs, such as **Upcoming**, **Week**, or **Favorites**, depending on the context. The selected tab is highlighted.

## Action bar

The action bar appears near the top of each item screen, just below the header area with the title and star icon. It gives you quick access to key actions such as calling, emailing, or updating the status.

![Mobile CRM: Action bar -app-screen][img3]

The available buttons depend on the type of item you're viewing (contact, sale, request, and so on).

Common actions include:

| Action | Description |
|---|---|
| Call | Choose a phone number and start a call (can be logged as an activity in SuperOffice). |
| SMS | Send a text message to the person. |
| Email | Open the email client with the selected recipient. |
| Map | Open the address in your device's map app (uses the visiting address if set; otherwise, postal address). |
| Website | Visit the contact's or company's website. |
| Reply | Reply to the customer or sender. |
| Comment | Add an internal note to a request (opens the Message screen).|
| Update stage/status | Change the sales stage or project status. |

## Task menu <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>

When viewing a contact, follow-up, request, or other item, tap the **Task** icon near the top right (next to the star) to access additional options specific to that item.

Examples include:

* Add or remove image
* Copy to your device's contact list
* Delete appointment
* Forward request

These actions complement the 3 buttons in the action bar.

## Swipe actions

You can swipe left on most items in a list to reveal quick actions. The available buttons depend on the item type:

* <i class="ph ph-pencil-simple" aria-label="pencil icon"></i> Edit: open in edit mode
* <i class="ph ph-list" aria-label="hamburger menu"></i> Menu: open task menu for more options
* <i class="ph ph-star" aria-label="star icon"></i> Favorite: toggle favorite status
* <i class="ph ph-phone" aria-label="phone icon"></i> Call (contacts and companies only)
* <i class="ph ph-check-circle" aria-label="checkmark"></i> Mark as complete (follow-ups only)

## Create new (+)

Tap the green **+** button in the lower-right corner to create a new item. What you can create depends on which screen you're on:

* Diary: New appointment, phone call, or task
* Companies: New company
  * Company card: New contact, appointment, task, document, or sale
* Projects: New project
  * Project card: New appointment, task, document, or sale
* Sales: New sale
  * Sale card: New appointment, task, or document
* Contacts: New contact
  * Contact card: New appointment, task, sale, or request

![Mobile CRM: + button on a screen -app-screen][img4]

## Edit mode vs. view mode

When viewing an item (such as a contact card), you're in **view mode**, meant for browsing information and taking action.

To make changes, tap the **Edit** button (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) in the upper-right corner. This switches you to **edit mode**, where you can update details (if you have permission). Changes are saved only when you tap **Save**.

For documents and emails, edit mode lets you update metadata, such as title or type, not the file content itself.

## Search <i class="ph ph-magnifying-glass" aria-hidden="true"></i>

Each main screen has a **Search** tab where you can look up names, titles, phone numbers, or IDs—depending on the type of record.

To search:

1. Tap the **Search** tab.
1. Enter your search term.
1. Tap a result to open the record.

## Favorites <i class="ph ph-star" aria-hidden="true"></i>

Favorites help you quickly access important records—contacts, companies, sales, and projects.

### Add or remove a favorite

* On any card (such as a contact or sale), tap the **star icon** in the top-right corner to mark the item as a favorite. A filled star means it's already favorited.

* Tap the star again to remove it.

> [!TIP]
> In a list view, you can also swipe left on a record, tap <i class="ph ph-list" aria-label="menu"></i>, and choose **Add favorite** or **Remove favorite**, depending on the current status.

### View your favorites

1. Go to the relevant screen (Contacts, Companies, Projects, Sales).
2. Tap the **Favorites** tab to see all your favorited items of that type.

![Mobile CRM: Favorites tab -app-screen][img5]

## Pull to refresh

Mobile CRM auto-syncs in the background. If you want to refresh manually:

1. Pull down from the top of a list or screen.
2. A spinner appears, and your content refreshes.

To refresh everything, go to **Settings** > **Refresh all data**.

## <a id="visible-fields"></a>Configure visible fields

In sections like **Details**, you can customize which fields are shown and in what order.

1. Tap the arrow (<i class="ph ph-caret-right" aria-label="Chevron"></i>) in the **Details** section to expand it.
2. Tap the **cogwheel** (<i class="ph ph-gear" aria-hidden="true"></i>) that appears in the upper-right corner of the section.
3. Use toggles to show or hide fields.
4. Drag fields to reorder them.
5. Tap **Save**.

## Dark mode

Mobile CRM supports dark mode, but does not currently switch automatically when your device changes appearance. **Close and relaunch the app** to apply the new theme.

![Mobile CRM: Dark mode -app-screen][img1]

## Related content

* [About Mobile CRM][1]
* [Install and log in][2]
* [Settings][3]

<!-- Referenced links -->
[1]: index.md
[2]: login.md
[3]: settings.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/mobile/companies-dark-mode.png
[img2]: ../../../media/loc/en/mobile/thumb-wheel.png
[img3]: ../../../media/loc/en/mobile/action-bar.png
[img4]: ../../../media/loc/en/mobile/green-add-button.png
[img5]: ../../../media/loc/en/mobile/list-of-favorites.png

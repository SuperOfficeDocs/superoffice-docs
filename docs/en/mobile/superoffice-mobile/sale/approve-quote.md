---
uid: mobile-crm-sale-approve-quote
title: Approve sale
description: How to approve or reject a quote for a sale in SuperOffice Mobile CRM.
keywords: quote, approve, sale
author: Bergfrid Dias
date: 06.10.2025
version: 11.1
content_type: howto
platform: mobile
language: en
---

# Approve sale

> [!NOTE]
> This feature requires SuperOffice 10.1.5 or newer and Mobile CRM 10.2.2 or newer.

When working with sales and quotes, you may sometimes apply a higher discount rate that requires approval. Mobile CRM allows you to handle quote approvals seamlessly, whether you're a sales rep or a manager.

![Mobile CRM: Quote pending approval -app-screen][img1]![Mobile CRM: Quote approved -app-screen][img3]

## Sales rep

You cannot send a quote if it has warnings, errors, or needs approval. The **Send** button (in SuperOffice CRM) appears dimmed until all issues are resolved.

If approval is required, the quote gets the status **Needs approval**.

1. In Mobile CRM, check your push notification settings and make sure **Quote approval response** is on. You will be notified as soon as the quote is approved (or rejected).

## Manager: Approve or deny a quote

Managers can review and respond to approval requests directly from Mobile CRM.

1. Ensure your **push notification settings** are enabled for **Quote approval request**.
1. When you receive a notification, tap it to open the **sale** in Mobile CRM.
1. Review the quote details.
1. Tap **Approve** or **Reject**.

![Mobile CRM: Quote approval -app-screen][img2]

## Enable push notifications for quote approval

1. Tap <i class="ph ph-list" aria-label="Main menu"></i> in the bottom center of the screen and select **Settings**.
1. Select **Notifications**.
1. At the bottom of the list, toggle:
    * **Quote approval request:** For managers to receive approval requests.
    * **Quote approval response:** For sales reps to receive responses.

## Related content

* [Update a sale][1]
* [Working with quotes][2]

<!-- Referenced links -->
[1]: update.md
[2]: ../../../sale/learn/quote/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/mobile/quote-approval-pending.png
[img2]: ../../../../media/loc/en/mobile/quote-notification.png
[img3]: ../../../../media/loc/en/mobile/quote-approved.png

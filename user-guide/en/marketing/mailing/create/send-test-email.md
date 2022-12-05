---
uid: help-en-mailing-send-test
title: Test mailing by sending a test email
description: Test mailing by sending a test email
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Send a test email

> [!NOTE]
> This topic is only relevant for email mailings and form responses (not for documents or SMS).

When you create a new mailing, you can also do a few tests to check that the mailing is working properly and that the layout looks OK.

In the **Content** step you can send a test email.

1. Go to the **Content** step.
2. Click the **Send test** button in the lower left corner.
3. Enter an email address. You can add multiple email addresses by using ; as separator.
4. Click **OK**. The email is sent to the specified addresses.

## What should I test?

When you are testing a mailing, it is important to check the following:

* That template variables are replaced with customer data. This means, for example, that you see "Hi John" and not "Hi **\[\[customer.firstname\]\]**".
* That links work and point to the correct pages.
* That clicks on links are registered in SuperOffice Marketing.
* That the opening of messages is registered in SuperOffice Marketing.
* That images are correctly displayed.
* That the layout of messages looks good.
* That the messages are up-to-date (dates/years, names, version numbers, and so on) and do not contain spelling mistakes/typos.
* That the mailing is [legible on a smart phone or tablet][1].

## Reset counters after testing

When you have sent a test mailing, you need to reset the counters for the link(s) in the message. Otherwise, the list will display both your own and others' clicking of links done during testing.

1. Go to the links **Tracked links** tab
2. Click the menu button ( ![icon][img1] ) next to the relevant link and select **Reset**. The **Clicks** column is set to **0**. Data about which customers have clicked the link are also removed.

<!-- Referenced links -->
[1]: ../../editor/drag-and-drop/customize-for-mobile.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png

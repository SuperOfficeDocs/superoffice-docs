---
uid: help-en-test-mailing
title: test mailing
description: test mailing
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Test mailing

> [!NOTE]
> This topic is only relevant for e-mail mailings and form responses (not for documents or SMS).

When you create a new mailing, you can also do a few tests to check that the mailing is working properly and that the layout looks OK.

## Send a test e-mail

In the **Content** step you can send a test e-mail.

In order to do this:

1. Go to the **Content** step.
2. Click the **Send test** button in the lower left corner.
3. Enter an e-mail address. You can add multiple e-mail addresses by using ; as separator.
4. Click **OK**. The e-mail is sent to the specified address(es).

See [What should I test?](test_mailing.md#What_should_I_test_) below for a list of what you should check in the mailing.

## Preview the mailing

When you have added recipients to the **Recipients** list, you can preview the mailing as it will look for one of the recipients.

> [!NOTE]
> The mailing will NOT be sent to the recipient.

In order to do this:

1. Click a recipient in the **Recipients** list.
2. Click the **Preview** button. The **Preview** window displays the mailing as it will look for the selected recipient. Any template variables have been replaced by actual contact data (name, company etc.).
3. Click links to check that they work, but remember to reset them if they are tracked. See [Reset counters after testing](Reset_counters_after_testing.md).
4. Click ![icon](../media/btn_Cancel.png) to close the **Preview** window.

## What should I test?

When you are testing a mailing, it is important to check the following:

* That template variables are replaced with customer data. This means, for example, that you see "Hi John" and not "Hi **\[\[customer.firstname\]\]**".
* That links work and point to the correct pages.
* That clicks on links are registered in SuperOffice Marketing.
* That the opening of messages is registered in SuperOffice Marketing.
* That images are correctly displayed.
* That the layout of messages looks good.
* That the messages are up-to-date (dates/years, names, version numbers, etc.) and do not contain spelling mistakes/typos.
* That the mailing is legible on a smart phone or tablet. See [Customise the message for display on mobile devices](Customise_the_message_for_display_on_mobile_devices.md).

> [!NOTE]
> You need to remember to reset the counters after you have clicked links. See [Reset counters for links](Work_with_tracked_links_after_the_mailing.md#ResetCountersForLinks).

Click **Next** to go to **Step 4: Recipients**. You can still go back to the **Content** step to make additional changes to the message. This step is not relevant for form responses.

> [!TIP]
> Click the **Save + close** button to save the mailing and close it. You can continue working on the mailing later.

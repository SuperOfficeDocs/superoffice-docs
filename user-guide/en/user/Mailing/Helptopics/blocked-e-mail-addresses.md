---
uid: help-en-blocked-e-mail-addresses
title: Blocked e-mail addresses
description: Blocked e-mail addresses
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Blocked e-mail addresses

In the **Blocked e-mail addresses** tab, you can handle bounced e-mails and [spam complaints](Blocked-e-mail-addresses.md#Spam-complaints).

## Blocked e-mail addresses

E-mail addresses that have been returned due to permanent errors or have <!-- Fix reuse ID=a2 -->(If an e-mail bounces more then 5 times, it is automatically blocked. You can adjust this setting in the global preference **Number of accepted bounces before email address is disabled** in SuperOffice Settings and Maintenance.), will be automatically blocked and will also be skipped in future mailings. All blocked e-mail addresses from all mailings are archived in the **Blocked e-mail addresses** tab. <!-- Fix reuse ID=a1 -->

E-mails may be returned due to e-mail address errors, spam filters, Internet problems or inboxes being full. Some of these problems may be temporary (delivery delays, e-mail server temporarily unavailable etc.), while others are permanent (wrong address, unknown domain etc.). Temporarily failing e-mail addresses are not blocked, and they are not skipped in the next mailing.

> [!NOTE]
> To prevent misspelled or invalid e-mail addresses, SuperOffice validates e-mail addresses received through Chat and Forms. The validation is performed using DNS lookup and controlling basic e-mail syntax.

The **Blocked e-mail addresses** tab provides an excellent overview of e-mail addresses that need to be "cleaned".

> [!TIP]
> Click a column to access sorting and grouping functions.

To fix a single e-mail address, select it in the list and click **Open** in the side-panel to edit the contact. Go to the **Details** tab. A warning icon (![icon](../media/warning-asterisk-red.png))next to the e-mail address indicates a problem. Hold the mouse-pointer over the icon to view the cause of the problem.

> [!TIP]
> You can also work with blocked e-mails and bounces for individual mailings. See [Manage bounces](Manage-bounces.md).

## Working with blocked email addresses (bounces)

To handle multiple email addresses, you have a number of options in the **Actions** button.

[!include[How to handle bounces](../../includes/bounce-options.md)]

## Spam complaints

The **Spam complaints** tab displays any recipients that have reported an e-mail mailing as spam or junk. A spam complaint normally indicates that a recipient has not approved of receiving this type of e-mail from you.

> [!NOTE]
> A spam complaint results in an automated removal of eMarketing consent.

<!-- Fix reuse ID=a3 -->

People click the spam (or junk) buttons for various reasons. They may for some reason be confused about who you are, or why you are e-mailing them. In some cases people report spam because they cannot find the unsubscribe link.

If a recipient is using Mailgun, any e-mail reported as spam will be added to the "suppressed" list. This means that our users will no longer be able to send e-mails to that person. This means no mailing and no response to ongoing requests, which may lead to serious issues.

To avoid spam complaints, try to look into the following:

* Is there a specific mailing or mailing type that our subscribers are reacting to?
* Who reported the mailing as spam?
* Does your mailing not look like the newsletter they subscribe to?
* Can the mailing content be misinterpreted?
* Is it not obvious that the mailing is from you?
* Did you send the mailing to a large list of unknown e-mail addresses (not registered in SuperOffice)?

**Export**

You can export the list for further processing.

1. Select the e-mail addresses you want to export.
2. Select **Actions** &gt; **Export**.
3. Select an export format. The export file displays in the bottom of you browser. It can also be found in you downloads folder.

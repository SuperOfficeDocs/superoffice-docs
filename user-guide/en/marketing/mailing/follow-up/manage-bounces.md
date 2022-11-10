---
uid: help-en-blocked-email-addresses
title: Blocked e-mail addresses
description: Blocked e-mail addresses
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Manage bounces

You can manage bounces and blocked emails for individual mailings as well as for ALL mailings.

## Why are emails returned?

Emails may be returned due to e-mail address errors, spam filters, Internet problems or inboxes being full. Some of these problems may be temporary (delivery delays, email server temporarily unavailable etc.), while others are permanent (wrong address, unknown domain etc.). Temporarily failing email addresses are not blocked, and they are not skipped in the next mailing.

> [!NOTE]
> To prevent misspelled or invalid email addresses, SuperOffice validates email addresses received through Chat and Forms. The validation is performed using DNS lookup and controlling basic email syntax.

## To fix a single email address

1. Select the email in the list and click **Open** in the side-panel to edit the contact.
2. Go to the **Details** tab.
3. A warning icon (![icon][img1]) next to the e-mail address indicates a problem. Hold the mouse-pointer over the icon to view the cause of the problem.

> [!TIP]
> Click a column to access sorting and grouping functions.

## Blocked email addresses

Email addresses that have been returned due to permanent errors or have bounced several times will be automatically blocked and will also be skipped in future mailings.

> [!NOTE]
> If an email bounces more then 5 times, it is automatically blocked. You can adjust this setting in the global preference **Number of accepted bounces before email address is disabled** in SuperOffice Settings and Maintenance.

All blocked email addresses from all mailings are archived in the **Blocked e-mail addresses** tab. This tab provides an excellent overview of email addresses that need to be cleaned.

> [!TIP]
> Click a column to access sorting and grouping functions.

## Bounce options

To handle multiple email addresses, you have a number of options in the **Actions** button.

### Export

1. Select the email addresses you want to export.
2. Select **Actions** > **Export**.
3. Select an export format. The export file displays in the bottom of you browser. It can also be found in you downloads folder.

### Add to new selection

1. Select the email addresses you want to add to a new selection.
2. Select **Actions** > **Add to new selection**.
3. Enter the name of the new selection and click **OK**. A new static selection is created with the selected email addresses.

### Add to new project

1. Select the email addresses you want to add to a new project.
2. Select **Actions** > **Add to new project**.
3. Enter the name of the new project and click **OK**. A new project is created with the selected email addresses.

### Add to existing selection

1. Select the email addresses you want to add to an existing selection.
2. Select **Actions** > **Add to existing selection**.
3. Start typing in the search field to find the relevant selection.
4. In the list of results, click the selection you want to use.
5. Click **OK**. The selected email addresses are added to the selection.

### Add to existing project

1. Select the email addresses you want to add to an existing project.
2. Select **Actions** > **Add to existing project**.
3. Start typing in the search field to find the relevant project.
4. In the list of results, click the project you want to use.
5. Click **OK**. The selected email addresses are added to the project

### Delete selected email addresses

Use this option to permanently delete email addresses from the database.

1. Select the email addresses you want to delete.
2. Select **Actions** > **Delete selected email addresses**.
3. Click **OK** to confirm.

### Clear bounce-flag

Use this option to remove email addresses from the list, so they can be used in mailings. This may be relevant if bounces are due to wrong configuration or temporary technical reasons, or if you know that these email addresses are correct and want to try sending a second time.

1. Select the email addresses that you want to clear of bounce-flags.
2. Select **Actions** > **Clear bounce-flag**.
3. Click **OK** to confirm.

### Set as former employee

Use this option to set a contact as a former employee.

1. Select the email addresses you want to delete.
2. Select **Actions** > **Set as former employee**.
3. Click **OK** to confirm.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../../common/icons/warning.png

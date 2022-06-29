---
uid: help-en-step-4--recipients---sms
title: Step 4  Recipients - SMS
description: Step 4  Recipients - SMS
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Step 4: Recipients - SMS

In the fourth step, **Recipients**, you must select the recipients of the mailing. You can add recipients from a number of sources, as described below. In addition, you can set various mailing options here and also preview the mailing.

> [!NOTE]
> When you add recipients, only contacts with a valid e-mail address (or mobile phone number, in the case of SMS mailings) will be added to the **Recipients** list.

## Add recipients from selections and projects

You can add recipients from selections (from both SuperOffice CRM and SuperOffice Service) and projects (from SuperOffice CRM).

To do this:

1. Under **Add recipients**, click **Selection** or **Project**.
2. Click in the field below and start typing the name of the selection or project you want to add. As you type, a dynamic list displays the matches.
3. Click a selection or a project in the list.
4. Click ![icon](../media/btn_Add.png). The selection or project is added to the **Recipient sources** list, and the **Recipients** list is updated.
5. Repeat steps 1 through 4 to add more selections or projects.

> [!NOTE]
> If you selected a selection under **Archive mailing** in **Setup** (step 1), this selection is listed under **Recipient sources**. You can delete this selection if necessary.

## Add contacts from SuperOffice

You can add individual contacts from SuperOffice. To do this:

1. Under **Add recipients**, click **Contact**.
2. Click in the field below and start typing the name of the contact you want to add, in the field below. You can also enter a company name to display all contacts for a company.
3. Select the contact you want from the list that appears.
4. Click ![icon](../media/btn_Add.png). The contact is added to the **Recipient sources** list, and the **Recipients** list is updated.
5. Repeat steps 2-5 to add more contacts. Additional contacts will be added to the same row in the **Recipient sources** list, and the number of contacts will display in the **Name** column.

## Import a list of recipients (contacts) from an external file

You can import recipients from an [external comma-separated file](Create_address_list.md) (.txt, .csv or similar).

> [!NOTE]
> When you import a list of names and e-mail addresses, SuperOffice Marketing will try to locate the imported recipients in the SuperOffice database. If matches are found, the recipients' companies will be listed in the **Company** column in the **Recipients** list. Any names/e-mail addresses that are **not** found in SuperOfffice, will be filtered out and not included in the mailing. This is due to GDPR regulations.

To do this:

1. Click **Select file**.
2. Locate the relevant file (.txt, .csv or similar text format).
3. Click ![icon](../media/btn_Add.png). The list is added to the **Recipient sources** list, and the **Recipients** list is updated.
4. Repeat steps 2-4 to add more recipients. Additional recipients will be added to the same row in the **Recipient sources** list. The total number of recipients will display in the **Name** column.

<!-- Fix reuse ID=a1 -->

Imported recipients that ARE NOT found in the SuperOffice database, will only consist of a name and an e-mail address (or just an e-mail address). This means that only the template variables **\[\[customer.name\]\]** and/or **\[\[customer.email\]\]** will work for these recipients. To avoid empty variables in your mailings, make sure to [preview the mailing](test_mailing.md) first.

## Recipient options

Under **Options** in the lower part of the **Recipients** screen, you can select various alternatives for the mailing:

* **Override consent and subscription**: Select this option to also send the mailing to contacts who have not given their consent to receiving e-marketing or are not subscribing to this mailing type. These contacts are listed with the status **No consent** in the **Recipients** list.

* **Only one message per e-mail address**: Select this option to remove duplicate e-mail addresses in the recipient list (indicated by **Duplicate** in the **Status** column). This will update the **Recipients** list.

* **Update recipient list when sending**: Select this option to automatically update the recipients list before sending the mailing. See **Update recipients list** below.



## Preview the mailing

When you have added recipients to the **Recipients** list, you can preview the mailing as it will look for one of the recipients.

> [!NOTE]
> The mailing will NOT be sent to the recipient.

In order to do this:

1. Click a recipient in the **Recipients** list.
2. Click the **Preview** button. The **Preview** window displays the mailing as it will look for the selected recipient. Any template variables have been replaced by actual contact data (name, company etc.).
3. Click links to check that they work, but remember to reset them if they are tracked. See [Reset counters after testing](Reset_counters_after_testing.md).
4. Click ![icon](../media/btn_Cancel.png) to close the **Preview** window.

## Review and update the Recipients list

When you add selections, projects, contacts and import lists, the **Recipients** list is automatically updated. If you have checked the option **Update recipient list when sending**, the projects and selections will be checked before sending the mailing, in case contacts have been added, removed or edited.

In addition, you can click the **Update list** button below the **Recipients** list to update the list manually. You should do this if it's been a while since you added the recipients. Some of the contacts on the list might have changed their consent in the mean time.

> [!NOTE]
> The list only displays the first 50 recipients. Click **Load all** at the bottom of the list to display all recipients.

Click **Next** to go to [Step 5: Confirm](Step_5__Confirm_-_SMS.md). You can still revisit the **Recipients** step to edit the recipients list.

> [!TIP]
> Click the **Save + close** button to save the mailing and close it. You can continue working on the mailing later.

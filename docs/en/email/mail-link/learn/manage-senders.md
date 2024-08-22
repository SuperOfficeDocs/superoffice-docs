---
uid: help-en-mail-link-senders
title: Manage senders
description: Manage senders
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link
topic: howto, sender
language: en
---

# Manage senders

When you archive an email or an attachment, SuperOffice CRM performs a search to see if the sender matches any of the recorded companies or contacts.

## Searching for the sender of an email

You can use the **Search for sender** button to search for the precise email address of the sender in your [preferred SuperOffice client][4].

1. Select the email in the mail client inbox (you can select only one) whose sender you'd like to search for in SuperOffice.

2. Click the **Search for sender** button.

3. What happens next, depends on whether the sender is found in SuperOffice:
    * If the email address is found on a company/contact, the company/contact opens in SuperOffice.
    * If the email address is registered on more than one company/contact, a dialog will appear, listing the alternatives and allowing you to choose one.
    * If the email address is not registered in SuperOffice, you may add it.
    * SuperOffice CRM only: If the sender of the selected email is marked as a former employee, the company/contact will still open, but the sender is not shown in SuperOffice CRM unless you have chosen to show former employees.

## Handle email from a sender with several listings

If the sender is listed multiple times in SuperOffice CRM, a dialog will appear informing you of this and allowing you to select the correct entry.

## Handle an email from a sender not listed in SuperOffice

If the sender is not listed in SuperOffice CRM at all, you may add their email address to SuperOffice CRM.

1. Do one of the following:
    * [Archive the email on companies/contacts][1]
    * [Archive the email as activity][2]
    * [Archive attachments][3]

2. If the sender of the email or attachment is not listed in SuperOffice CRM, a warning will appear at the top of the dialog for archiving email when you attempt to archive: "This sender's email address is not recognized. Click here to update SuperOffice with this email address". Click the warning.

3. In the **Save email address** dialog, select one of the following radio buttons:
    * **Create new contact**: Click this option to [add the email address to a new contact](#new-contact).
    * **Add email address to existing contact**: Click this option to [add the email address to an existing contact](#existing-contact).

4. Click **OK**. The contact and their email address is displayed on the **Contacts** section tab of the specified company card.

> [!NOTE]
> If you attempt to archive more than one email at a time, you will be prompted for each sender not listed in SuperOffice CRM.

## <a id="new-contact"></a>Add an email address to a new contact

1. Open the **Save email address** dialog.

2. Select the **Create new contact** option.

3. In the **Company** field, select the company to save the new contact in. You may search for a company by starting to type the company name and then select from the matches that appear.

4. Enter the required information about the contact, such as name, email address, and phone number.

5. Click **OK**. The contact and their email address is displayed on the **Contacts** section tab of the specified company card.

## <a id="existing-contact"></a>Add an email address to an existing contact

1. Open the **Save email address** dialog.

2. Select the **Add email address to existing contact** option.

3. In the **Company** field, select the company you want to register the email address under. You may search for a company by starting to type the company name and then select from the matches that appear.

4. In the **Contact** field, choose from the contacts recorded for the active company.

5. Check the **Set as primary email address for this contact** box if the contact has more than one email address and you would like this one to be used as their default address.

6. Click **OK**. The contact and their email address is displayed on the **Contacts** section tab of the specified company card.

## Not adding an email address to SuperOffice

It is possible to archive an email/attachment or search for a sender without adding the email address to SuperOffice CRM.

If you do not want to add the email address to SuperOffice CRM, simply do not click the warning in the **Archive email** dialog.

<!-- Referenced links -->

[1]: archive-on-contact.md
[2]: archive-as-activity.md
[3]: archive-attachment.md
[4]: settings/superoffice-account.md

<!-- Referenced images -->

---
uid: help-en-section-tab-contacts
title: Contacts tab
description: Learn how to manage and interact with contact information linked to companies using the Contacts tab in SuperOffice CRM. Efficiently track personnel data and maintain communication records for seamless customer relations.
keywords: contacts tab, section tab, contact archive, enable middle name
author: Bergfrid Skaara Dias
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Contacts tab

The **Contacts** section tab in SuperOffice CRM allows users to view and manage all [contacts][1] linked to a specific company. This tab helps users keep track of relationships between the company and its employees or other relevant contacts. By providing an organized list of all associated individuals, it facilitates easy access to personnel information, making it simple to maintain detailed communication records. The **Contacts** section tab is available only on the [Company screen][9].

![Contacts section in company -screenshot][img1]

## <a id="columns"></a>Contacts tab columns overview

The **Contacts** section tab contains the following columns to display key information about each person:

| Column | Description |
|---|---|
| Info | Displays a paperclip icon (<i class="ph ph-paperclip" aria-hidden="true"></i>) if the **Note** tab in the Contact card has a note. Hover over the icon to view it. |
| Interests | Displays a dot if the contact has interests. Hover over the icon to see the interests. |
| Mr/Ms | Indicates the appropriate way of addressing the contact. |
| First name / Middle name / Last name | The full name of the contact. The middle name usage can be configured in **Settings and maintenance**. |
| Title | Displays the contact's professional title or role within the company. |
| Mobile phone | The contact's mobile phone number. |
| Email | The contact's email address. Click the email to [open a new message][7] in your preferred email program. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## View contacts in the Contacts section tab

1. Go to the relevant **Company** screen.

1. Click on the **Contacts** tab to see all contacts linked to the company.

1. Double-click a contact in the list to open the Contact screen for more detailed information.

### Include former employees

To include people who have left the company, check the **Former employees** option. Former employees are shown in a different color in the list, as well as in the **Project members** section tab in the Project screen and in member lists on the Selection screen.

## Create a new contact

1. Click **Add** to [create a new contact][2] linked to the company.

1. Fill out the necessary information, and click **Save**.

## Edit contact information

1. Double-click the contact you wish to [edit][3].

1. In the Contact card, make the desired changes.

1. Click **Save** to confirm your updates.

## Edit contact interests

1. Double-click the contact's name to open the Contact card.

1. Go to the **Interests** tab to update the interests linked to the contact.

## Merge or move contacts

* To merge contacts, follow the steps in [merging contacts][5].

* To move a contact to another company, follow the steps in [moving contacts][4].

## Enable middle name support

You can enable the use of middle names in Settings and maintenance by following these steps:

1. Go to Settings and maintenance.

1. Go to **Preference** > **Global preferences** > **Functions**.

1. Select **Enable middle name**.

If this preference is enabled, the first part of the last name will be used as the middle name (but it is not sorted on). If not enabled, you can enter a middle name in the First name field, which will then be treated as a second first name.

## Related content

* [Create new contacts][2]
* [Delete contacts][6]
* [Configure columns in section tabs][8]

<!-- Referenced links -->
[1]: ../../contact/learn/index.md
[2]: ../../contact/learn/create.md
[3]: ../../contact/learn/edit.md
[4]: ../../contact/learn/move.md
[5]: ../../contact/learn/merge-contacts.md
[6]: ../../contact/learn/delete.md
[7]: ../../contact/learn/send-email.md
[8]: configure-columns.md
[9]: ../../company/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/contacts-detail.png

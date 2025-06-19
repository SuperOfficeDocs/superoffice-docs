---
uid: help-en-email-outlook-add-crm-data-to-event
title: Add CRM data to Outlook event
description: Add CRM data to Outlook event
keywords: SuperOffice for Outlook, Outlook, email, event, calendar, CRM data, SOFO
author: Erik Lebiko, Bergfrid Dias
date: 10.29.2024
version_sofo: 2024.8.12
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Add CRM data to Outlook event

## New event

1. Select **New event** in Outlook.

1. [Open SuperOffice for Outlook][1] (if not pinned)​.

1. Add persons to the **Invite attendees** field in Outlook.

    ![SuperOffice for Outlook, add CRM data to event -screenshot][img1]

    If the email or contact is stored in SuperOffice, their contact information will appear, and the **Company** and **Contact** fields will auto-fill. You can hover over the contact and click **Open in CRM** to view detailed information in SuperOffice CRM.

    You can also **invite contacts from SuperOffice** for added convenience.

1. Adjust the event details as needed.

1. Press **Save** to finalize the event.

## Existing event

1. Open an existing event in Outlook.

1. [Open SuperOffice for Outlook][1] (if not pinned)​.

    * If SuperOffice CRM data exists for the attendees, it will be displayed.
    * If no data exists, the add-in will attempt to find the organizer in SuperOffice CRM.

1. Follow the same steps as outlined above to modify or save the event.

> [!NOTE]
> You need [Synchronizer for SuperOffice][2] for this functionality. Calendar events synced from SuperOffice CRM are view-only in Outlook, but you can still view contact information.

## Additional information

To view sales, projects, or activities related to a contact, follow these steps:

1. In the SuperOffice sidebar, navigate to the **Action** or **People** tab and select the contact's name.
2. You will see vital details about the contact, including their requests, sales, and follow-ups.

<!-- Referenced links -->
[1]: get.md#open
[2]: https://appstore.superoffice.com/infobridge-software-b-v-/synchronizer-for-superoffice

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/outlook-calendar-event.png

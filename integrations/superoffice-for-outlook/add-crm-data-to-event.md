---
uid: sofo-add-crm-data-to-event
title: Add CRM data to Outlook event
description: How to add CRM data to meetings and appointments in Outlook using SuperOffice for Outlook
keywords: SuperOffice for Outlook, Outlook, email, event, calendar, CRM data, SOFO
author: Erik Lebiko, Bergfrid Dias, Andrea Schilde
date: 16.06.2026
version_sofo: 2026.6.3
content_type: howto
category: integration
topic: SuperOffice for Outlook
audience: person
audience_tooltip: SuperOffice CRM
language: en
index: true
redirect_from: 
  - /en/email/superoffice-for-outlook/learn/add-crm-data-to-event
  - /da/email/superoffice-for-outlook/learn/add-crm-data-to-event
  - /de/email/superoffice-for-outlook/learn/add-crm-data-to-event
  - /nl/email/superoffice-for-outlook/learn/add-crm-data-to-event
  - /no/email/superoffice-for-outlook/learn/add-crm-data-to-event
  - /sv/email/superoffice-for-outlook/learn/add-crm-data-to-event
---

# Add CRM data to Outlook event

Use SuperOffice for Outlook to add CRM data to meetings and appointments in Outlook.

> [!NOTE]
> You need [Synchronizer for SuperOffice][2] for this functionality.

## New event

1. Select **New event** in Outlook.

1. [Open SuperOffice for Outlook][1]

1. Add persons to the **Invite attendees** field in Outlook.

    ![SuperOffice for Outlook, add CRM data to event -screenshot][img1]

    * If the email or contact is stored in SuperOffice, their contact information will appear, and the **Company** and **Contact** fields will auto-fill.
    * If a contact is found but the **Contact** field is not auto-filled, multiple contacts with the same email exist in SuperOffice. Click **Select Contact** and choose the correct contact.
    * If no contact is found, you can add a new contact to SuperOffice: Select **Click to add new contact** and enter the required details.

1. Adjust the event details as needed.

1. Press **Save** to finalize the event.

## Existing event

1. Open an existing event in Outlook.

1. [Open SuperOffice for Outlook][1]

1. If SuperOffice CRM data exists for the attendees, it is displayed.

    * If a contact is found but the **Contact** field is not auto-filled, multiple contacts with the same email exist in SuperOffice. Click **Select Contact** and choose the correct contact.
    * If no contact is found, you can add a new contact to SuperOffice: Select **Click to add new contact** and enter the required details.

1. If no data exists, the add-in attempts to find the organizer in SuperOffice CRM.

1. Follow the same steps as for a new event to modify or save the event.

## Additional information

### View contact details

To view additional CRM data:

1. In the SuperOffice panel, locate the contact.
1. Hover over the contact and select **Open in CRM**.

SuperOffice CRM opens with detailed information about the contact.

### Meetings created in SuperOffice

Calendar events created in SuperOffice and synchronized to Outlook are view-only in Outlook.

* These events may contain information indicating they originate from SuperOffice.
* Editing or deleting must be done in SuperOffice.
* You do not need to press **Save**, as the event is already stored in SuperOffice.

### Shared mailbox calendars

You can also work with calendar events from shared mailboxes in Outlook.

1. Open the event from the shared mailbox.
1. [Open SuperOffice for Outlook][1].
1. Add or update CRM data.
1. Press **Save**.

### Type

You can use the **Type** field to set the meeting type.

* This value is saved with the event and synchronized to SuperOffice.
* It can be used to categorize meetings for reporting and filtering.

### Notes

* Calendar events synchronized from SuperOffice are view-only in Outlook, but CRM information is still available.
* Contact matching is based on participants and organizer.

<!-- Referenced links -->
[1]: get.md#open
[2]: https://appstore.superoffice.com/infobridge-software-b-v-/synchronizer-for-superoffice

<!-- Referenced images -->
[img1]: media/outlook-calendar-event.png

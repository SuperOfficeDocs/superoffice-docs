---
uid: help-en-invitation-add-attendee
title: Add attendees and resources to follow-up
description: This how-to guide will show how you to add attendees to a follow-up.
keywords: invite contact, invite associate, add attendee, add resource, meeting, invitation, participant, attendee, diary, follow-up
author: Bergfrid Dias
date: 01.13.2025
version: 10.5
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Add attendees and resources to follow-up

When you create a follow-up that concerns other people, you can add them as attendees to the follow-up. You can also book your organization's conference rooms and equipment. People who are available as attendees are defined in Settings and maintenance.

## Steps

> [!NOTE]
> Only the owner of the follow-up can add (and remove) attendees.

1. [Open or create a follow-up][3].

1. Click the **Invite** button. This expands the dialog.

    ![Follow-up dialog, Invite button -screenshot][img14]

    ![Follow-up dialog, expanded -screenshot][img15]

1. Click the **Add attendees** box. Then choose one or more persons from the list.

    * Start typing to search for a person throughout SuperOffice.
    * Select a person from the history list (<i class="ph ph-clock" aria-hidden="true"></i>) or your favorites (<i class="ph ph-star" aria-hidden="true"></i>).
    * Click <i class="ph ph-users" aria-label="Group icon"></i> to search for an associate or <i class="ph ph-buildings" aria-label="Company icon"></i> to select persons linked to a company.
    * You can also select sale stakeholders (<i class="ph ph-currency-circle-dollar" aria-hidden="true"></i>) and project members (<i class="ph ph-clipboard-text" aria-hidden="true"></i>).

    ![Follow-up dialog, select attendees -screenshot][img17]

    > [!TIP]
    > To invite someone not registered in SuperOffice, enter their full email address

    ![Follow-up dialog, attendees added -screenshot][img16]

    If an attendee is unavailable, an exclamation mark is shown next to their name. Choose one of the suggested time slots or click **Check availability** to find a better time.

1. Optionally, add locations, rooms, and/or resources.

1. Optionally, select **Send email invitation to attendees**. (This changes the **Save** button to **Save and send**.)

1. Click **Save** to save all changes.

### <a id="availability"></a>Scheduling assistant

The scheduling assistant is part of the **Follow-up** dialog. The detailed calendar shows the availability of each internal attendant (associate). The top-most row shows the accumulated availability. The availability of external attendees and email attendees is unknown.

![Follow-up dialog, scheduling assistant -screenshot][img18]

1. In the **Follow-up** dialog, click **Check availability.**

1. Click and drag the pointer left or right to select a meeting time. For example, from 1:30 to 3 PM, as shown in green in this screenshot. Use the scrollbar to move between days.

    Alternatively, update the selected date and time at the top of the dialog.

1. Optionally, add or remove attendees and resources. Consider adjusting the time again if there is a conflict.

1. Click **OK** when you are done.
1. Click **Save** to save all changes.

### <a id="preview"></a>Preview and update invitation email

When you click **Save and send**, a preview of the email is shown based on the title and agenda. Any internal notes added to the follow-up are excluded.

![Follow-up dialog, preview email invitation -screenshot][img13]

1. Update the subject and body of the email as needed. Use the rich-text toolbar in the footer to style your invitation.

    > [!NOTE]
    > Any changes made in the preview are **not** saved back to the follow-up.

1. When you are ready, click **Send**.

## What happens next

1. When you save the follow-up, the invitees [receives a notification][5].

2. If a person declines the invitation, you get an **Invitation declined** notification. Click **Got it** to acknowledge.

3. Optionally, find a new suitable time and reschedule the follow-up.

### How do I specify that an external contact has accepted or declined the invitation?

External attendees are notified via email (if you selected this option). Invitation emails sent to external contacts contain an iCal file (.ics) with the invitation data. When an external contact responds to your invitation, the [status][1] is automatically updated in SuperOffice.

To manually accept or decline an invitation on behalf of someone, select their name in the list and click the **Toggle Status** button one time to insert a green tick to show that the invitation was accepted, or click twice to insert a red cross for a declined invitation.

## Troubleshooting

### Why does nothing happen when I click Email Invitation?

If the contact you selected does not have a valid email address recorded in SuperOffice CRM, nothing will happen when you click **Email Invitation**.

### Why is the Email Invitation button disabled?

Using the SuperOffice Inbox: If you have not entered the requisite information in the **Log in** screen, which is displayed the first time you click the **Inbox** button in SuperOffice CRM, the **Email Invitation** button is disabled.

## Related content

* [Create a follow-up][3]
* [Join a video meeting][4]

<!-- Referenced links -->
[1]: index.md#status
[3]: ../create-follow-up.md
[4]: ../video-meetings.md
[5]: accept-decline.md

<!-- Referenced images -->
[img13]: ../../../../media/loc/en/diary/preview-invitation.png
[img14]: ../../../../media/loc/en/diary/invite.png
[img15]: ../../../../media/loc/en/diary/large-follow-up-dialog.png
[img16]: ../../../../media/loc/en/diary/attendees-added.png
[img17]: ../../../../media/loc/en/diary/follow-up-attendees.png
[img18]: ../../../../media/loc/en/diary/schedule-associate-ext-email.png

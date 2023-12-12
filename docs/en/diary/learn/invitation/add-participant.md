---
uid: help-en-invitation-add-participant
title: Add participants to follow-ups
description: This how-to guide will show how you to add participants to a follow-up.
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: diary, follow-up, meeting, invitation, participant, attendee
so.topic: howto
language: en
---

# Add participants and resources to follow-ups

When you create a follow-up that concerns other people, you can add them as participants to the follow-up. You can also book your organization's conference rooms and equipment. People who are available as participants are defined in Settings and maintenance.

Watch the video for [Add participants to a meeting][15].

## Steps

> [!NOTE]
> Only the owner of the follow-up can add (and remove) attendees.

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/participants)

1. [Open or create a follow-up][3].

    > [!NOTE]
    > If you have the overview of other users or resources open, they are automatically entered as participants in the **Participants** tab. Otherwise select them manually as described below.

2. Open the **Participants** tab and click **Add** in the footer.

3. In the **Invitation** dialog, select where you want to get the participants from. Choose between **Associates**, **Company/contact**, **Project**, **Selection**, and **Resource**.

4. In the list box immediately below the **Select from** field, select the user group, company, contact, project, selection or resource you want to get the participants from. The contents of this list box will vary depending on what you selected above.
    * If you selected **Associates** or **Resource** in step 3, you can choose **All** in the list box to display the associates or resources in all groups.
    * If you selected **Company/contact**, **Project**, or **Selection** in step 3, you can search for the required company, contact, project, or selection from this field.

5. After you select the required source, a list of all available entries for this source is displayed. Select the users or resources to include in the follow-up and click the arrow button to the right of the list ![icon][img2]. They are then displayed on the right side of the window. You can also select users and resources individually by double-clicking them.

    > [!NOTE]
    > If any of the people are busy at the time you specified, their name is shown in red, so you can easily see if you should find a different time for the follow-up. You can still invite them to this new meeting, and their entry will then be shown in red with the word "CONFLICT" in the dialog for follow-ups.

6. Click the **Email Invitation** button to activate email invitations for all participants in the list (except yourself). The ![icon][img1] icon to the left of the participant's name means that an email invitation to the follow-up will be sent to this participant. Click the ![icon][img1] icon next to a participant's name to disable email invitation for this participant. The ![icon][img1] icon changes to inactive ![icon][img3] and the participant will then not receive an invitation by email.

    Invitation emails sent to external contacts will contain an iCal file (.ics) with the invitation data. When they respond to your invitation, the status will automatically be updated in SuperOffice. The follow-up is shown on the **Activities** section tab for the company.

7. Click **OK** to close the **Invitation** dialog. The selected participants and resources will now be visible in the **Participants** tab. You can click the**Email Invitation** button and the ![icon][img1] icon to activate/deactivate email invitations, similar to the previous step.
    If any of the contacts you selected do not have a valid email address recorded in SuperOffice CRM, the ![icon][img1] icon changes to inactive ![icon][img3] in the **Participants** tab.

    > [!NOTE]
    > If you selected users or resources by mistake, select them in the rightmost list and click **Delete** to remove them.

8. After choosing participants and resources, click **Save** to save your selections or **Cancel** to exit the dialog without saving.

### [New (from version 10.2.11 pilot)](#tab/attendees)

1. [Open or create a follow-up][3].

1. Click the **Invite** button. This expands the dialog.

    ![Follow-up dialog, Invite button -screenshot][img14]

    ![Follow-up dialog, expanded -screenshot][img15]

1. Click the **Add attendees** box. Then choose one or more persons from the list.

    * Start typing to search for a person throughout SuperOffice.
    * Select a person from the history list ![icon][img4] or your favorites ![icon][img5].
    * Click ![icon][img6] to search for an associate or ![icon][img7] to select persons linked to a company.
    * You can also select sale stakeholders ![icon][img8] and project members ![icon][img9].

    ![Follow-up dialog, select attendees -screenshot][img17]

    > [!TIP]
    > To invite someone not registered in SuperOffice, enter their full email address

    ![Follow-up dialog, attendees added -screenshot][img16]

    If an attendee is unavailable, an exclamation mark is shown next to their name. Choose one of the suggested time slots or click **Check availability** to find a better time.

1. Optionally, add locations, rooms, and/or resources.

1. Optionally, select **Send email invitation to attendees**. (This changes the **Save** button to **Save and send**.)

1. Click **Save** to save all changes.

***
<!-- markdownlint-restore -->

### <a id="availability" />Scheduling assistant (available only in pilot)

The scheduling assistant is part of the new **Follow-up** dialog. The detailed calendar shows the availability of each internal attendant (associate). The top-most row shows the accumulated availability. The availability of external attendees and email attendees is unknown.

![Follow-up dialog, scheduling assistant -screenshot][img18]

1. In the **Follow-up** dialog, click **Check availability.**

1. Click and drag the pointer left or right to select a meeting time. For example, from 1:30 to 3 PM, as shown in green in this screenshot. Use the scrollbar to move between days.

    Alternatively, update the selected date and time at the top of the dialog.

1. Optionally, add or remove attendees and resources. Consider adjusting the time again if there is a conflict.

1. Click **OK** when you are done.
1. Click **Save** to save all changes.

### <a id="preview" />Preview and update invitation email (available only in pilot)

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

External participants are notified via email (if you selected this option). Invitation emails sent to external contacts contain an iCal file (.ics) with the invitation data. When an external contact responds to your invitation, the [status][1] is automatically updated in SuperOffice.

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
[15]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/diary--appointments/add-contact-to-appointment.mp4

<!-- Referenced images -->
[img1]: ../../../../../common/icons/pref-email.png
[img2]: ../../../../media/icons/arrow-right.png
[img3]: ../../../../media/icons/email-inactive.png
[img4]: ../../../../../common/icons/history-icon.png
[img5]: ../../../../../common/icons/favourite-icon.png
[img6]: ../../../../../common/icons/personblack.png
[img7]: ../../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../../common/icons/sale.png
[img9]: ../../../../../common/icons/singlecolour/project.png
[img13]: ../../../../media/loc/en/diary/preview-invitation.png
[img14]: ../../../../media/loc/en/diary/invite.png
[img15]: ../../../../media/loc/en/diary/large-follow-up-dialog.png
[img16]: ../../../../media/loc/en/diary/attendees-added.png
[img17]: ../../../../media/loc/en/diary/follow-up-attendees.png
[img18]: ../../../../media/loc/en/diary/schedule-associate-ext-email.png

---
uid: help-en-invitation-add-participant
title: Add participants to follow-ups
description: Add participants to follow-ups
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Add participants and resources to follow-ups

When you create a follow-up that concerns other people, you can add them as participants to the follow-up. You can also book your organisation’s conference rooms and equipment. People who are available as participants are defined in SuperOffice Settings and maintenance.

1. Open the **Appointment**, **Task** or **Phone Call** dialog and enter the required information. [!include[See Appointment dialog](../../includes/see-apt-dialog.md)]

2. Open the **Participants** tab and click **Add** at the bottom left of the window. The **Invitation** dialog opens.

    > [!NOTE]
    > If you have the overviews of other users or resources open, they are automatically entered as participants in the **Participants** tab. Otherwise select them manually as described below.

3. In the **Select from** field, you select where you want to get the participants from. Choose between **Associates**, **Company/contact**, **Project**, **Selection** and **Resource**.

4. In the list box immediately below the **Select from** field, select the user group, company, contact, project, selection or resource you want to get the participants from. The contents of this list box will vary depending on what you selected above.
    * If you selected **Associates** or **Resource** in step 3, you can choose **All** in the list box to display the associates or resources in all groups.
    * If you selected **Company/contact**, **Project** or **Selection** in step 3, you can search for the required company, contact, project or selection from this field.

5. Once you have selected the required source, a list of all available entries for this source is displayed. Select the users or resources to include in the follow-up and click the arrow button to the right of the list ( ![icon][img2] ). They are then displayed on the right-hand side of the window. You can also select users and resources individually by double-clicking them.

    > [!NOTE]
    > If any of the people are busy at the time you have specified, their name is shown in red, so you can easily see if you should find a different time for the follow-up. You can still invite them to this new appointment, and their entry will then be shown in red with the word "CONFLICT" in the dialog for follow-ups.

6. Click the **Email Invitation** button to activate email invitations for all participants in the list (except yourself). The ![icon][img1] icon to the left of the participant's name means that this participant will be sent an email invitation to the follow-up. Click the ![icon][img1] icon next to a participant's name to disable email invitation for this participant. The ![icon][img1] icon changes to inactive ( ![icon][img3] ) and the participant will then not receive an invitation by email.

7. Click **OK** to close the **Invitation** dialog. The selected participants and resources will now be visible in the **Participants** tab. You can click the**Email Invitation** button and the ![icon][img1] icon to activate/deactivate email invitations, similar to the previous step.
    If any of the contacts you have selected do not have a valid email address recorded in SuperOffice CRM, the ![icon][img1] icon changes to inactive ( ![icon][img3] ) in the **Participants** tab.

    > [!NOTE]
    > If you have selected users or resources in error, remove them by selecting them in the right-hand list and clicking the **Delete** button.

8. When you have finished choosing participants and resources, click **Save** to save your selections or **Cancel** to exit the dialog without saving.

## Troubleshooting

### Why does nothing happen when I click Email Invitation?

If the contact you have selected does not have a valid email address recorded in SuperOffice CRM, nothing will happen when you click **Email Invitation**.

### Why is the Email Invitation button disabled?

Using the SuperOffice Inbox: If you have not entered the requisite information in the **Log in** screen, which is displayed the first time you click the **Inbox** button in SuperOffice CRM, the **Email Invitation** button is disabled.

### How do I specify that an external contact has accepted or declined the invitation?

External participants will be notified via email (if you have selected this alternative in the invitation dialog). Invitation emails sent to external contacts will contain an iCal file (.ics) with the invitation data. When they respond to your invitation, the [status][1] will automatically be updated in SuperOffice.

To manually accept or decline an invitation on behalf of someone, select the name in the list and click the **Toggle Status** button once to insert a green tick to show that the invitation was accepted, or click twice to insert a red cross for a declined invitation.

<!-- Referenced links -->
[1]: index.md#status

<!-- Referenced images -->
[img1]: ../../../../common/icons/pref-email.png
[img2]: ../../../media/icons/arrow-right.png
[img3]: ../../../media/icons/type-epost-inactive.bmp

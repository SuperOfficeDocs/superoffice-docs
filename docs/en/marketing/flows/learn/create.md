---
uid: help-en-flow-create
title: Create a new flow
description: How to create new flow and define flow setting in SuperOffice Marketing
keywords: flow, marketing automation, new flow, flow setting
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.25.2024
so.version: 10.3.5
so.topic: howto
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Create a new flow

## Steps

1. Select **Marketing** in the Navigator.
1. Go to the **Flows** tab.
1. If required, click **Add folder** to [create a folder for the flow][8].
1. Click the **Flow** button below **Create new** on the right side of the screen.
1. In the **Flow editor** dialog, enter a descriptive **Flow name**.
1. [Fill in the fields](#fields) as described below. Remember to click **Save** regularly to save your work. The flow will not be auto-saved.
1. [Define flow start trigger and filter.](#trigger)
1. [Add steps.](#add-step)
1. Specify what happens when the flow finishes.
1. Click **Save** when you are done.

![Set properties for new flow -screenshot][img1]

After designing a flow and saving it, the **Flow editor** closes, and the flow chart is shown in the **View flow** screen. The new flow has status **Not running** until a flow administrator manually starts it by toggling Running = true.

## <a id="fields" />Filling in flow fields

### Settings (for flow)

| Setting | Description |
|---|---|
| Name | A descriptive label. |
| Description | Explain the purpose of the flow. This text is visible internally only.|
| Timezone | Required to limit the sending timeframe. |
| Owner | Associate creating the flow |
| Visible for | Access to the flow (owner, owner's group, all). Level of access also controlled by functional rights​. |
| Folder | The location of the flow. |

### Email (settings)

Common email settings for all the emails in the flow​.

| Setting | Description |
|---|---|
| Subscription type | Set on flow level (instead of individually on each email step). Ensures all emails within a flow have the same subscription type. |
| From, from name, from address | Same sender on all email steps within the flow. In the **From** list, select **Always use** and enter the sender's email address in the field below to use the same sender for all mailings. You can also choose a sales contact or support contact as the sender, if one is defined for this recipient. Enter an email address to be used if no sales contact or support contact is available. If your admin has activated the [global email validation preference][12], select the domain you want to send from in the drop-down list. |
| Reply to | The same options as above. In addition, you can select **Use "From" as reply address**. Any replies will then be sent to the sender. |
| Only send emails and SMS within a specific timeframe | Limits the sending timeframe. Participants wait in this step until the allowed timeframe starts​. Select between Workday (Mon-Fri) and Weekday (Mon-Sun). Specify time. Requires that timezone is set. ​|
| Use Google Analytics | Enables Google Analytics tracking for all emails in a flow. When checked, you can set source and campaign. |

> [!TIP]
> Timing affects email open rate and interaction. Use the **timeframe** setting to maximize reader interaction and to not disturb your subscribers during night-time.

![Set common email settings for new flow -screenshot][img2]

### Success criteria (optional)

Success criteria define [what success means for a flow][7].

1. Select **Success criteria** from the left menu.
1. Click **Add success criteria** and choose an option.
1. Optionally select **Participant is moved directly to Finish step when the success criteria is met**.

    * If checked: The participant's status changes to *Finished with success** and they exit from any other actions later in the flow.

    * If not checked: The participant's status remains *Active* and they continue to follow the flow. When they reach the **Finish** step, their status changes to *Finished with success*. Use this option if success rate is used primarily for statistics, and you want the participant to complete all the steps even if success is reached.

![Set success criteria for new flow -screenshot][img3]

## <a id="trigger" />Define flow start trigger and filters

The **Trigger** step is automatically added as the starting point for any flow. It determines who the flow is relevant for. Triggers are only activated for running or paused flows.

> [!NOTE]
> It *is* possible to create a flow without any automated trigger - by using the contact task menu or a selection task.​ We will discuss this special case in another topic.

1. Select **Steps** from the left menu.
1. Click the **Trigger** step in the flowchart.
1. In the trigger settings on the right side, click **Add trigger** and choose an option.
1. Enter the required settings for the selected trigger.
1. Optionally, specify additional qualification criteria.
1. Optionally select **A contact person can only start this flow once**. If a flow is triggered a second time on the same contact, this setting ensures they do not re-enrolled.

![Add trigger for new flow -screenshot][img5]

| Trigger | Description |
|---|---|
| Contact created | When a new contact is registered, independent of source (except import). |
| Contact update | When a contact is updated, independent of what is updated (except import and bulk update). |
| Order placed | When an order is placed on an existing sale registered on the contact. |
| Sale created | When a sale is registered on the contact. |
| Sale sold | When a sale on the contact is set to sold. |
| Sale lost | When a sale on the contact is set to lost. |
| Added to project | When contact is added as project member. |
| Request created | When a request is created on the contact (independent of source). |
| Form submitted | When a form (submitted by a contact) is **processed** (a manual step could be involved before the contact ends up in the flow​​). |
| Link clicked | When a contact clicks a tracked link. |
| Chat ended | When a chat with the contact ends. |

**Note:**

* If you choose *form submitted* or *link clicked*, pay attention if you see a warning icon. Forms and tracked links might have actions too.
* To add contacts created or updated by an import, a manual step adding imported contacts from selection to a flow is required.
* When triggering on contact updated, we know the current value of the contact fields, we do not know which field was updated or what value a field had before the update.

### Add contact filter (optional)

**Filters** are additional rules applied to all suggested participants (automatically and manually added).​ Use the contact filter to select specific contacts for your flow. For example, set the filter to *contact category = prospect* to trigger a flow only for prospects, not existing customers, who fill out a form on your website. This allows you to tailor content to different user groups.

> [!NOTE]
> Filters apply only when **identifying flow participants**. In an ongoing flow, contacts may be removed if they fulfill the success criteria.

1. Select the contact field you want to filter on.
1. [Select values for the criterion][13] in the various fields on the line (similar to in the Find screen).
1. Click **Add** to set additional criteria (adds a new line).

![Add contact filter on trigger of new flow -screenshot][img6]

### Exclusion list (optional)

The exclusion list **prevents selected contacts from being added to the flow**. Use a [static selection][14] to handle exceptions, such as:

* Prevent specific customers from receiving general mass emails.
* Send reminders, but not to those already signed up.

## <a id="add-step"/>Add step

1. Select **Steps** from the left menu.
1. Chose a step and drag it to where you wish to add it in the flowchart.
1. The step menu changes to **step settings**. [Available settings][9] depend on the step's type.

    * [Send message][3]
    * Flow control
    * [Update participant][4]
    * [Create activity][5]

Click the X in the step settings header to return to the step menu.

### The first step

When you open the **Steps** tab for the first time, you will see something like this:

![Flow steps -screenshot][img4]

* A flowchart with a **Trigger**, a **placeholder** for adding a step, and a **Finish** step (in the center).
* A list of available step types (to the right).

## Flow control

Most steps represent an action pertaining to the participant. For example, update contact interest. Flow-control steps are different - they pertain to **timing** and **segmentation**.

Without flow control, a person would move from action to action until they drop out or reach the end. For example, they would be flooded with the entire onboarding program in a single day. Or receive all newsletters at once.

In addition, everyone enrolled would go through exactly the same steps. Which might be what you want in a simple flow. But by setting conditions to what happens next, you can for example send a newsletter in the contact's preferred language, or send a feedback survey only to those who attended the webinar.

**Options:**

* Wait time
* Wait for action
* [Split][1]

> [!NOTE]
> Participants are stamped with a **wait until** when they arrive a wait step​. If the next step is an email or SMS, and a limited time frame is defined in email settings, the total waiting time might be longer than what's set in the step.

### Wait time

Use a time-based waiting step to wait a specific amount of days before sending the next email/SMS, or to wait until a specific date for specific occasions or actions. For example, to send reminders 1 week, 1 day, and 1 hour before a webinar.

1. Drag the **Wait time** box from the step menu and drop it into an available slot in the flowchart.
1. Set the condition. Do one of the following:

    * Select **Number of days/hours after previous step** and then select number and unit.
    * Or, select **Until specific date/time** and then pick a date from the calendar.

Active flow participants stay at this step before continuing to the next step according to defined rule.

![Flow step wait time -screenshot][img7]

## Wait for action

Use an action-based waiting step to wait for the participant to do something (submit a form or click a link).

1. Drag the **Wait for action** box from the step menu and drop it into an available slot in the flowchart.

1. Click **Add action** and select which action to wait for.

1. From the list, select the name of the link or form to wait for.

1. Specify how long you are willing to wait for any action (a timeout). The default maximum waiting time is 7 days. If you uncheck this setting, participants who do not respond will be stalled at this step forever.

1. Optionally, select **Exit flow if no actions within max waiting time**. Participants who do not respond will leave the flow with status "drop out". You may choose to move them to another flow and/or add them to a static selection.

![Flow step wait for action -screenshot][img8]

> [!TIP]
> You can wait for more than one action within a single step. The first-occurring action (form submission, link click, or timeout) moves the participant further down the flow. Simply repeat steps 2 and 3 above.

## What would you like to do now?

* [Move, duplicate, or remove step][2]
* [Define flow actions][3]
* [Split flow][1]
* [Start flow][6]

<!-- Referenced links -->
[1]: split.md
[2]: update.md
[3]: define-flow-actions.md
[4]: define-flow-actions.md#update
[5]: define-flow-actions.md#create
[6]: run-pause-end.md
[7]: index.md#success
[9]: step-settings.md
[8]: ../../learn/create-folder.md
[12]: ../../../admin/lists/learn/add-items-to-mailing-domain.md
[13]: ../../../search-options/learn/search-criteria.md
[14]: ../../../search-options/selection/learn/static-selections.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-settings.png
[img2]: ../../../../media/loc/en/marketing/flow-email-settings.png
[img3]: ../../../../media/loc/en/marketing/flow-success-form-submission.png
[img4]: ../../../../media/loc/en/marketing/flow-steps-initial.png
[img5]: ../../../../media/loc/en/marketing/trigger-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/flow-trigger-filter-contact.png
[img7]: ../../../../media/loc/en/marketing/flow-wait-time.png
[img8]: ../../../../media/loc/en/marketing/flow-wait-action.png

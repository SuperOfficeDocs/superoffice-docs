---
uid: help-en-flow-update
title: Update flow
description: Update flow
keywords: flow, marketing automation, edit flow
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.30.2024
so.version: 10.3.5
so.topic: howto
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Update flow

It is useful to start with a simple flow and extend it after monitoring the performance. You might also want to update a flow while designing it. For example, you wish to add successful participants to a selection, but need to create the selection before you can choose it.

To make changes:

1. [Pause the flow][1].
1. Click **Edit**.
1. Make the necessary changes.
1. Click **Save**.
1. Re-start the flow.

> [!NOTE]
> The changes you make to a step affect only new participants and active participants who have not yet reached that step.

## Update flow settings, success criteria, and/or trigger

Same as when [creating a flow][2].

## Add step

Same as when [creating a flow][3].

## Update step settings

1. Click a step in the flowchart to open the step settings.
1. Depending on the step's type, you can:

    * Update properties of new activities.
    * Add email content and/or attachments.
    * Extend or shorten waiting time.
    * Add or remove actions.
    * Select a static selection, project, or flow to transfer the participant to.
    * Change the order of branches, rename branches, add a branch.
    * Update conditions in a split.

1. Click **Save**.

You might find these resources useful:

* [List of available settings for each step][6].
* [Split flow][5]
* [Wait time and wait for action][4]
* [Add content][7]
* [Create activity][9]
* [Update contact][8]
* [Create selection][11]
* [Create form][10]

## Move, duplicate, or remove step

* **Move:** Click a step and drag it to a new location.
* **Duplicate:** Point to a step and click the **Duplicate** icon ![icon][img11]. This create a new step based on the current one and adds it as the next step. Use this option to reuse a step in the same flow.
* **Remove:** Point to a step and click the red X. This removes the step from the flow (but not its content).

> [!NOTE]
> When you duplicate an email step, the Flow editor also creates a **copy of the email content**. You can edit this piece of new flow content independent of the email content in the step that was duplicated.
>
> When you remove an email steps, only the step is removed from the flow. The email content is not removed or deleted.

## Delete flow

[See *Run, pause, and end flow*.][1]

## Troubleshooting

There are a few limitation when you edit a flow after it has run to protect active participants (in other words: to prevent you from making a mess).

### Cannot edit flow

* You cannot edit a running flow. Pause the flow and try again.
* If the **Edit** button is still grayed-out, you do not have the required functional right 'Flow administrator'.

### Cannot move or remove step

* You cannot move or remove a **Split** step after starting a flow (even if you pause).
* You cannot move or remove a **Wait time** or **Wait for action** step if there are active participants in the step.

### Cannot remove branch

Once the flow is started, you can change the order of branches (except 'Everyone else'). However, because participants might be on that branch, you cannot delete the branch.

<!-- Referenced links -->
[1]: run-pause-end.md
[2]: create.md
[3]: create.md#add-step
[4]: create.md#wait
[5]: split.md
[6]: step-settings.md
[7]: content.md
[8]: define-flow-actions.md#update
[9]: define-flow-actions.md#create
[10]: ../../forms/learn/create.md
[11]: ../../../search-options/selection/learn/create/tutorial.yml

<!-- Referenced images -->
[img11]: ../../../../../common/icons/duplicate-icon.png

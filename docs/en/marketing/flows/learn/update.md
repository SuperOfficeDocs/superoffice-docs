---
uid: help-en-flow-update
title: Update flow
description: Update flow
keywords: flow, marketing automation, edit flow
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Update flow

It is useful to start with a simple flow and extend it after monitoring the performance. You might also want to update a flow while designing it.

To make changes:

1. [Pause the flow][1].
1. Click **Edit** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>).
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
* **Duplicate:** Point to a step and click the **Duplicate** icon (<i class="ph ph-copy" aria-hidden="true"></i>). This create a new step based on the current one and adds it as the next step. Use this option to reuse a step in the same flow.
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

* You cannot move or remove a **Wait time**, **Wait for action**, or **Split** step if there are active participants in the step.

Go to the **Participants** tab and check the **Current step** column to find a suitable time to pause and update the flow control step.

### Cannot remove branch

* You cannot remove the 'Everyone else' branch.
* You cannot remove a branch if there are active participants on it.

Go to the **Flow** tab to check if there are anyone on the branch. If yes, go to the **Participants** tab for details. How to handle these participants is up to you. A few options to consider:

* Add participants to a static selection to follow up later.
* Add participants to the flow's exclusion list.
* Remove participants from the flow using the **Task** menu (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>).
* Wait for the branch to "drain". You might need to update the condition of the branch to prevent new participants from entering.

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
[11]: ../../../search-options/selection/learn/create.md

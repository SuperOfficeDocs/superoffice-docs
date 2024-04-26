---
uid: help-en-flow-update
title: Update flow
description: Update flow
keywords: flow, marketing automation, edit flow
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.16.2024
so.version: 10.3.5
so.topic: howto
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Update flow

It is useful to start with a simple flow and extend it after monitoring the performance.

1. [Pause the flow][1].
1. Click **Edit**.
1. Make the necessary changes.
1. Click **Save**.
1. Re-start the flow.

> [!NOTE]
> The changes you make to a step affect only new participants and active participants who have not yet reached that step.

## Update settings, success criteria, and/or trigger

Same as when [creating a flow][2].

## Add step

Same as when [creating a flow][3].

## Update step

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
[3]: create.md#add

<!-- Referenced images -->
[img11]: ../../../../../common/icons/duplicate-icon.png

---
uid: help-en-flow-run-pause-end
title: Run, pause, and end flow
description: How to run, pause, resume, end, and delete a SuperOffice Marketing automation flow.
keywords: flow, automation, run flow, running, pause flow, resume flow, end flow, delete flow, flow status
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

# Run, pause, and end flow

## <a id="status"></a>Flow status

* **Not running:** Represents a new flow that has not been started (or an ended flow). Triggers are not activated.

* **Running:** No changes are permitted while the flow is in progress. Automated triggers are activated, and participants are added to the flow.

* **Paused:** Triggers remain activated. Participants are added to the flow, but they await movement to the first step. Existing participants remain on their current step when the flow is paused. This status is used when making changes or improvements to a flow.

![Marketing flows with different status and stats -screenshot][img1]

## Start flow for the 1st time

To start a new flow:

1. Go to **Marketing** > **Flows**.
1. Select the flow you wish to start.
1. In the header, toggle the switch to **ON**. The status changes to **Running**.

This activates the flow's triggers. New participants are added to the flow's participant list based on these triggers. Flow participants will progress through the flow, actions will be executed until they meet the flow's success criteria, reach the finish step, or drop out.

## Pause flow

To temporarily halt a running flow:

1. Open the flow you wish to pause.
1. In the header, toggle the switch to **OFF**. The status changes to **Paused**.

* This action freezes the current status for all participants, who remain at their current step.
* **Triggers remain active**, causing the participant list to continue growing. New participants enroll but are placed in a queue.
* The **Edit** button (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) is accessible, allowing flow administrators to make updates to the flow (with some limitations).

## Resume flow (paused > running)

To restart a paused flow, toggle the switch to **ON** in the **View flow** screen.

* All participants will continue from the step they were at when the flow was paused.
* Participants who enrolled and were queued during pause will move to the first step.
* Any changes made to the flow will apply to a participant if they have not yet progressed beyond the relevant step.

## End flow

To end the flow:

1. Open the flow.
1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **End flow**.

* The flow's status changes to **Not running**.
* All triggers for this flow are deactivated and enrollment ceases. No new participants will be added to the flow.
* Active participants get status = *Cancelled*. They will not complete the flow.

> [!CAUTION]
> This task should be used only for flows that are no longer relevant. Ending a flow is not intended for making smaller adjustments - use pause instead. **Cancelled participants will not continue the flow if you decide to run it again.**

If flow is started again after ending it, only new participants go through the flow, old participants keep status Cancelled.

## <a id="delete"></a>Delete flow

1. Pause the flow. The flow's status changes to **Paused**.
1. End the flow. The status changes to **Not running**.
1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Delete flow**.
1. Confirm the action.

This option is available both in the **View flow** screen and in the overview of all flows.

## Troubleshooting

### Unable to run flow

All required settings must be valid before the flow can run. For example, a flow with an email step cannot run if email settings such as from address or reply address are missing. Look for the warning icon - the tooltip describes the problem.

### Unable to delete flow

You cannot delete a running flow. First, pause the flow. Then, end the flow so the status changes to **Not running**. After that, click <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Delete flow**.

## Related content

* [Update flow][1]

<!-- Referenced links -->
[1]: update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-status.png

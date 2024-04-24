---
uid: help-en-flow-run-pause-end
title: Run, pause, and end flow
description: How to run, pause, resume, end, and delete a SuperOffice Marketing automation flow.
keywords: flow, automation, run flow, running, pause flow, resume flow, end flow, delete flow, flow status
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.22.2024
so.version: 10.3.5
so.topic: howto
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Run, pause, and end flow

## <a id="status" />Flow status

* **Not running:** A new flow that has not been started (or an ended flow). Triggers are not activated​.
* **Running:** No changes are allowed as long as the flow is running. Automated triggers are activated, participants will be added to the flow​.
* **Paused:** Triggers still activated, participants added to flow, but waiting to be moved to first step. Existing participants paused on the step where they are when paused.​ Used when changing or improving a flow.

## Start flow for the 1st time

To start a new flow:

1. Go to **Marketing** > **Flows**.
1. Select the flow you wish to start.
1. In the header, switch **ON** the toggle. The status changes to **Running**

This enables the flow's triggers. Based on triggers, new participants are added to the flow's participant list. Flow participants will follow the flow, actions will be performed until the flow participants meet flow success criteria, reaches the finish step, or drops out.

## Pause flow

To pause a running flow, switch **OFF** the toggle in the **View flow** screen. The status changes to **Paused**.

* This freezes the current status for all participants, who remain at the step they are currently at.
* Triggers remain active! Therefore, the list of participants keeps growing. New participants enroll, but wait in a queue.
* The **Edit** button is available, and flow administrators can update the flow (with some limitations).

## Resume flow (paused > running)

To resume a paused flow, switch **ON** the toggle in the **View flow** screen.

* All participants continue from the step they were at when flow was paused.
* Participants enrolled and queued during pause move to the first step.
* Changes done to the flow apply to a participant if they have not yet passed the relevant step.

## End flow

1. Select **Task** > **End flow**. The flow's status changes to **Not running**.

* All triggers for this flow are deactivated and enrollment stops. No new participants will be added to the flow.
* Active participants get status = Cancelled. They will not complete the flow.

> [!CAUTION]
> This task should be used only for flows that are no longer relevant. Ending a flow is not intended for making smaller adjustments - use pause instead. **Cancelled participants will not continue the flow if you decide to run it again.**

If flow is started again after ending it, only new participants go through the flow, old participants keep status Cancelled.

## <a id="delete" />Delete flow

1. Pause the flow.
1. Select **Task** > **Delete flow**.
1. Confirm the action.

## Troubleshooting

### Unable to run flow

All required settings must be valid before the flow can run. For example, a flow with an email step cannot run if email settings such as from address or reply address are missing. Look for the warning icon - the tooltip describes the problem.

### Unable to delete flow

You cannot delete a running flow. First, pause the flow and then select **Task** > **Delete flow**.

## Related content

* [Update flow][1]

<!-- Referenced links -->
[1]: update.md

<!-- Referenced images -->

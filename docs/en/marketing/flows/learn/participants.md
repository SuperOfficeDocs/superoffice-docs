---
uid: help-en-flow-participants
title: Flow participants
description: A complete view of all participants within the flow.
keywords: Marketing, flow, participant, enroll, participant status
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

# Flow participants

## Steps

To view the list of participants for a specific flow:

1. Go to **Marketing** > **Flows**.
1. Click to select a flow.
1. Select the **Participants** tab.
1. Optionally, choose what to group the list on.

![The flow participants list -screenshot][img1]

Use the cogwheel (<i class="ph ph-gear" aria-hidden="true"></i>) in the list's header to customize the columns.

![The flow participants list, customize columns -screenshot][img2]

## Participant status

| Status | Description |
|---|---|
| Active | Participant is active in the flow​. |
| Finished | Participant finished all steps in the flow​. |
| Finished with success | Participant finished the flow and fulfilled the success criterion. Included in the flows success rate​. |
| Dropped out | Participant dropped out, always with a specified drop-out reason. |
| Cancelled | Participant will not complete the flow because an admin ended the flow. |

## <a id="logic"></a>Enrollment and progression through the flow

Before each step, SuperOffice CRM re-assess whether the participant can progress.

For all step types:

1. Is the participant's status *Active*?
1. Does the participant meet the defined success criterion?
1. Is the contact marked as a former employee?
1. Is the contact added to the exclusion list?

​Additional for email step:​

1. Is their consent valid?​
1. Is the contact subscribed to the flow subscription type?
1. Does contact have registered email address?​
1. Is the email address already active within the flow?​
1. Is the email address unblocked?​

Additional for SMS step:​

1. Does the contact have a registered mobile phone for SMS?

### How does success criteria affect enrollment

* Contacts that already meet the success criteria will still be added to the flow and counted as successes. Their progression through the flow steps depends on the configuration.

* Contacts that meet the success criteria after completing a flow will not be included in the flow's success rate, as it occurred after their active participation.

### Which branch will a participant follow?

In a split, participants follow the first (leftmost) branch where they meet the specified conditions.

## Tasks

* Add to selection: Includes the participant to a static selection.
* Add to flow: Indicates that this contact is proposed for enrollment in another flow.
* Remove from flow: Removes all record of the contact's participation in the current flow.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-participants.png
[img2]: ../../../../media/loc/en/marketing/flow-participant-columns.png

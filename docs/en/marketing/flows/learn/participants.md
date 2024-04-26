---
uid: help-en-flow-participants
title: Flow participants
description: Flow participants
keywords: Marketing, flow
author: Bergfrid Dias, Trude Lien Smedbråten
so.date: 04.22.2024
so.version: 10.3.5
so.topic: howto
language: en
so.audience: person
so.audience.tooltip: SuperOffice Marketing
so.pilot: yes
---

# Flow participants

A complete view of all participants within the flow.

## Steps

To view the list of participants for a specific flow:

1. Go to **Marketing** > **Flows**.
1. Click to select a flow.
1. Select the **Participants** tab.
1. Optionally, choose what to group the list on.

Available info:

* Their email address
* What company they belong to
* When they were added as participant
* Current status and current step
* The last sending they received, date for last sending, and the status on last sending

## Participant status

* Active: Participant is active in the flow​
* Finished: Participant finished all steps in the flow​.
* Finished with success: Participant finished the flow and fulfilled the success criterion. Included in the flows success rate​.
* Dropped out: Participant dropped out, always with a specified drop-out reason.
* Cancelled

## Tasks

* Add to selection
* Add to flow: suggest that this contact is enrolled in another flow.
* Remove from flow: Leaves no trace of the contact being registered as participant in the current flow.

## <a id="logic" />Enrollment and progression through the flow

* Contacts already fulfilling the success criteria will still be added to the flow, and still counted as success. They may or may not go through the flow steps depending on configuration.​
* Contacts fulfilling the success criteria after they have finished a flow will not be included in the flow success rate, as it did not happen while the contact was an active participant.

In a split, contacts follow the first branch where they meet the specified conditions (the first branch from left).

For all step types:​

1. Is participant status Active?​
1. Does participant meet the defined success criteria?​
1. Is contact marked as former employee?​
1. Is contact added to exclusion list?​

​Additional for email step:​

1. Is consent valid?​
1. Does contact subscribe to flow subscription type?​
1. Does contact have registered email address?​
1. Is the email address already active within the flow?​
1. Is the email address unblocked?​

Additional for SMS step:​

1. SMS step: Does contact have a registered mobile phone?​

<!-- Referenced links -->

<!-- Referenced images -->

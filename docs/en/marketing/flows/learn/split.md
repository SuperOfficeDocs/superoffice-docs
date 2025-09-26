---
uid: help-en-flow-split
title: Flow control - split
description: Flow control - split
keywords: flow, automation, branch, split
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

# Flow control - split

A split step divides the flow's participants into 2 or more branches based on one or more conditions. This lets you use alternative paths, treating participants different based on contact data or engagement.

You can differentiate based on:

* Company/contact data
* Form submission
* Form data
* Link click (tracked)
* Membership in project
* Membership in static selection

## How it works

When the participant arrives at the split, the step criteria for the **left-most** branch is evaluated first. They can follow only one path. If there is a match, they move to the next step of that branch. Then the next branch condition is checked, and so on. All splits have a branch for everyone not meeting any of the conditions.​

## Steps

1. Drag the **Split** box from the step menu and drop it into an available slot in the flowchart.
1. Enter a descriptive **title**.

    > [!TIP]
    > Descriptive title and branch names makes the flow easier to read​.

1. Choose what to base the split on. Some options require you to provide additional details here.
1. Name the new branch.
1. Set branch-specific criteria. Options depend on what you based the split on.
1. Optionally, add more branches and repeat steps 4-5.
1. Choose whether participants matching no criteria should exit the flow.
1. Continue adding steps to each branch.

Everyone else continue:

![Marketing automation: split flow based on contact data -screenshot][img1]

Everyone else exit:

![Marketing automation: split flow based on contact data -screenshot][img2]

> [!NOTE]
> You cannot delete the "everyone else" branch.

### Split based on contact data

When you choose to split participants based on contact data, you can select from the contact and company criteria available in **Find Contact**.

* For each branch, [select values for the criterion][11] in the various fields on the line (similar to in the Find screen). Click **Add** to insert more criteria.

![Marketing automation: split flow based on company data -screenshot][img3]

### Split based on link clicked

When selected, a field for specifying which email shows up.

* E-mail: Choose **Any email** or a specific mailing.
* For each branch, select which [tracked link][7] the participant must click to enter this branch.

![Marketing automation: split flow based on link clicked -screenshot][img4]

### Split based on form submitted yes/no

When selected, a field for specifying which form shows up.

* Form: Choose a specific form.

![Marketing automation: split flow based on form submitted -screenshot][img5]

> [!NOTE]
> This split is independent of what form data was submitted. There are no branch-specific settings. Since this is a yes/no test, you cannot add more branches.

### Split based on form data

This condition is a variant of the submission-based split with additional data criteria applied to the branch.

When selected, a field for specifying which form shows up.

* Form: Choose a specific form.
* For each branch, select values for the criterion in the various fields on the line (similar to in the Find screen). Available criteria depend on the selected form's fields. Click **Add** to insert more criteria.

![Marketing automation: split flow based on form data (contact me) -screenshot][img6]

> [!NOTE]
> In this scenario, **everyone else** means both participants who do not submit the form *and* submitters who do not meet the additional criteria on any of the other branches.

### Split based on project membership

* For each branch, select which project the participant must be a member of.

![Marketing automation: split flow based on project membership -screenshot][img7]

### Split based on static selection

Similar to split based on project membership.

## Success criteria used as early exit condition

Success criteria can also be used as an early exit condition in the flow, eliminating the need for branching. Before any action is performed on a participant in a flow step, the participant's status is re-evaluated. This re-evaluation considers the success criteria. If a participant meets the success criteria, their status is updated to *Finished with success*, or they continue as *Active* if they are to complete the flow. At the finish step, participants who have met the success criteria are given the status *Finished with success*.

<!-- Referenced links -->
[7]: ../../tracked-links/learn/index.md
[11]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/split-flow-contact-data-no-exit.png
[img2]: ../../../../media/loc/en/marketing/split-flow-contact-data-yes-exit.png
[img3]: ../../../../media/loc/en/marketing/split-flow-company-data-dropdown.png
[img4]: ../../../../media/loc/en/marketing/split-flow-link-clicked.png
[img5]: ../../../../media/loc/en/marketing/split-flow-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/split-flow-form-data-contact-me.png
[img7]: ../../../../media/loc/en/marketing/split-flow-project-member.png

---
uid: help-en-define-link-actions
title: Define automatic link actions
description: In this how-to guide, you will learn how to use links in mailings to automate actions.
keywords: link action, tracked link, call-to-action
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: en
---

# Define automatic link actions

Updating 500 contact cards manually is time-consuming and unnecessary. Automated link actions can streamline this process.

Here is how automated link actions work:

* A recipient's click on a call-to-action link can automatically add them to a selection or a project in SuperOffice CRM.
* SuperOffice CRM can automatically update relevant information, like interests, on the contact's card.

Automation saves time otherwise spent on handling responses. When a reader clicks a link in your mailing, the system performs the link actions for you!

You can leverage the gathered information in several ways:

* Generate a selection based on who clicked a specific link, and send a targeted reply to this group with a custom message.
* Schedule follow-up activities for your team members to personally engage with respondents.
* Create requests for your customer service team to address and investigate.

![Define your link actions -screenshot][img3]

## Available actions

Based on your mailing's goal and call-to-action, you can update your database. This information can improve segmentation or help follow up with interested individuals. You can select more than one action for a tracked link.

| Tab | Action |
|---|---|
| [Response](#response) | Add landing page or custom text, or open a form. |
| [Set field](#set-field) | Add a value to an [extrafield][5] for customer contacts. |
| [Interests](#interests) | Update interests. |
| [Selection/Project](#selection) | Add/remove customer contact from a selection or project. |
| [Follow-up](#follow-up) | Create a follow-up (to-do or meeting) in SuperOffice CRM. |
| [Request](#request) | Create a new request. |
| [Script](#script) | Execute a script. |

> [!NOTE]
> When updating a tracked link, keep in mind that it might be used by multiple mailings and/or automated flows. You should make sure there are no duplicate or conflicting actions.

## <a id="response"></a>Response

Select what should happen when the recipient clicks the link.

* **Redirect to new web page**: Enter the URL in the provided field.
* Or, **Show custom text**: Enter the text to display. Click <i class="ph ph-text-a-underline" aria-hidden="true"></i> to show the rich-text toolbar.
* Or, **Open form**: Choose the form's name. Optionally, select fields to pre-fill with known contact information.

## <a id="set-field"></a>Set field

In the **Set field** tab, you can set a value to be added to an extrafield when the recipient clicks the link. This records additional customer information.

Select a field and enter a value.

## <a id="interests"></a>Interests

Specify that a link click should alter the contact's interests. For instance, add the "Product news" interest if the "Yes, please keep me informed about new products" link is clicked, or remove it if the "Unsubscribe" link is clicked.

* **Set interest**: choose an interest to be added for the contacts when they click the link.
* **Remove interest** choose an interest to be removed for the contacts when they click the link.

[How to create a newsletter sign-up form][1]

## <a id="selection"></a>Selection/Project

Specify that link-clicking recipients will be added to or removed from selections or projects. Start typing a name to initiate a quick search.

## <a id="follow-up"></a>Follow-up (meeting/to-do)

In the **Follow-up** tab, set a link click to generate meetings or to-dos in SuperOffice CRM. Choose the follow-up type, provide a description, link it to a project, select the task type, assign responsibility, and set the duration.
Activate this function by selecting **Follow-up**.

[How to create a follow-up][4]

> [!TIP]
> As description, enter which mailing it relates to, which link the recipient clicked, and possibly how the to-do or meeting should be followed up.
>
> When setting **Created by** or **Default recipient** you can click the **Select active user** button (<i class="ph ph-user-circle" aria-hidden="true"></i>) to choose yourself.

## <a id="request"></a>Request

In the **Request** tab, set a link click to create a Service request. Check the box to register a new request, provide a title, select the priority and category, and choose the owner. You can also select **Automatically assigned** or **Unassigned**.

[How to create a request][3]

## <a id="script"></a>Script

In the **Script** tab, choose a script or macro to run when the link is clicked. Activate this function by selecting **Execute script**, then choose the required script from the list.

Variables available in the script include custId, linkId, shipmentId, linkUrl, linkHits, and returnUrl.

[How to create or edit a CRMScript][6]

<!-- Referenced links -->
[1]: ../../forms/learn/tutorial-sign-up.md
[3]: ../../../request/learn/create.md
[4]: ../../../diary/learn/create-follow-up.md
[5]: ../../../custom-objects/learn/extra-field.md
[6]: ../../../customization/macros-and-scripts/admin/create-script.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png

---
uid: help-en-define-link-actions
title: Define link actions
description: Define link actions
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Define link actions

[!include[Requirement](../includes/req-marketing.md)]

In SuperOffice Marketing you can add actions to your links. These actions are triggered when the recipient clicks a link.

Click here to go to the relevant topic:

| Tab | Action |
|---|---|
| Response | Add landing page or custom text. |
| Set field | Add a value to an extra field for customer contacts |
| Interests | Update interests. |
| Selection/Project] | Add/remove customer contact from a selection/project. |
| Follow-up] | Create a follow-up (task or appointment) in SuperOffice CRM. |
| Request | Create a new request. |
| Script | Execute a script. |

## Response

* **Redirect to new web page**: Select this option to redirect the recipients to a web page when they click the link. Enter the URL in the **URL to new page** field.

* **Show custom text**: Select this option if you want custom text to be displayed when the recipient clicks the link. Enter the text in the field below.

## Set field

In the **Set field** tab, you can specify that a value should be added to an extra field when the recipient clicks the link. This can be useful if you want to record extra information about customers who click the link. Select a field in the **Set extra field** list box and enter a value in the **Value** field.

## Interests

Here you can specify that a link click should add or remove interests for the contact. For example, you could add the "Product news" interest if the recipient clicks the "Yes, please keep me informed about new products" link. Alternatively, you could remove the "Product news" interest if the user clicks the "Unsubscribe" link in a newsletter.

* In the **Set interest** list box, you can choose an interest to be added for the contacts if they click the link.
* In the **Remove interest** list box, you can choose an interest to be removed for the contacts if they click the link.

See also [Clear interests in SuperOffice CRM][1].

## Selection/Project

Here you can specify that recipients who click the link will be added to or removed from selections in SuperOffice Service or selections or projects in SuperOffice CRM. Type the beginning of a name to start the quick search.

## Follow-up (task/appointment)

In the **Follow-up** tab, you can specify that a link click should generate tasks or appointments in SuperOffice CRM.

1. Check **Follow-up** to activate this function.
2. **Task/Appointment**: Choose if you want to create a task or an appointment in SuperOffice CRM.
3. **Description**: Enter a description of the task/appointment. For example, which mailing it relates to, which link the recipient clicked, and possibly how the task/appointment should be followed up.
4. **Project**: Here you select a project which the task/appointment should be linked to. Type the beginning of a name to start the quick search.
5. **Task**: Select the required task or appointment type.
6. **Created by**: Select which user should be responsible for the task/appointment, or click the **Select active user** button ![icon][img1] to choose yourself.
7. **Assign to Our contact if available**: Check here if the task/appointment should be assigned to "our contact" for the recipient (the person who looks after this customer).
8. **Default recipient**: Select a default recipient whom the task/appointment should be assigned to, or click the **Select active user** button ![icon][img1] to choose yourself.
9. **Duration**: Click the **Select time span** button ![icon][img2] next to this field to set the duration of the task/appointment.

## Request

In the **Request** tab, you can specify that a SuperOffice Service request should be created for contacts who click a link.md)]

1. **Create new request**: Check here to register a new request when the customer clicks the link.
2. **Title**: Enter the title you want to give the new request.
3. **Priority**: Select the priority the request will have.
4. **Category**: Select the required category.
5. **Owner**: Select the owner you want for the new request. You can also select **Automatically assigned** or **Unassigned**.

## Script

In the **Script** tab, you can choose a script or macro to be run when the recipient clicks the link.

1. Select **Execute script** to activate this function.
2. Click the **Script** list and select the required script from the list that appears. The following variables are available in the script: custId, linkId, shipmentId, linkUrl and linkHits. You can also use the returnUrl variable to override the specified link URL.

<!-- Referenced links -->
[1]: ../mailing/create/add-unsubscribe-link.md#clear-interests-in-superoffice-crm

<!-- Referenced images -->
[img1]: ../../../../common/icons/nav-contact.png
[img2]: ../../../../common/icons/pref-diary.png

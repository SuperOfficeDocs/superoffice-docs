---
uid: help-en-define-link-actions
title: Define link actions
description: In this how-to guide, you will learn how to use links in mailings to automate actions.
keywords: Marketing
author: SuperOffice RnD
so.date: 02.14.2024
so.version: 10
so.topic: howto
language: en
so.audience: user
so.audience.tooltip: SuperOffice Marketing
---

# Use links to automate different actions

[!include[Requirement](includes/req-marketing.md)]

You can speed up your work by processing the responses you get from a mailing with automated link actions.

Imagine that your mailing is a great success. Over 500 people opened your message and clicked the links you included. The task ahead of you is to process all these responses from your recipients. Think about the amount of time this would take if you had to do it manually.

In SuperOffice Marketing you can add actions to your links. These actions are triggered when the recipient clicks a link.

![Define your link actions -screenshot][img3]

| Tab | Action |
|---|---|
| Response | Add landing page or custom text. |
| Set field | Add a value to an extra field for customer contacts |
| Interests | Update interests. |
| Selection/Project | Add/remove customer contact from a selection or project. |
| Follow-up | Create a follow-up (to-do or meeting) in SuperOffice CRM. |
| Request | Create a new request. |
| Script | Execute a script. |

## Response

* **Redirect to new web page**: Select this option to redirect the recipients to a web page when they click the link. Enter the URL in the **URL to new page** field.

* **Show custom text**: Select this option if you want custom text to be displayed when the recipient clicks the link. Enter the text in the field below.

## Update your database

Depending on the goal and the call-to-action you use in your mailing you can update information in your database. When a person clicks the link in your mailing, SuperOffice CRM will do one of the following:

* Give a custom response or redirect to web page
* Add a contact to a specific project or a selection
* Update a contact's interest
* Add information to a field in the Contact card
* Create a follow-up activity for a contact
* Create a customer service request for a contact
* Execute a script

Some of this information will help you segment your database even better, while other information will help you follow up on people that have shown an interest in your message.

## Set field

In the **Set field** tab, you can specify that a value should be added to an extra field when the recipient clicks the link. This can be useful if you want to record extra information about customers who click the link.

Select a field in the **Set extra field** list box and enter a value in the **Value** field.

## <a id="interests" />Interests

Here you can specify that a link click should add or remove interests for the contact. For example, you could add the "Product news" interest if the recipient clicks the "Yes, please keep me informed about new products" link. Alternatively, you could remove the "Product news" interest if the user clicks the "Unsubscribe" link in a newsletter.

* In the **Set interest** list box, you can choose an interest to be added for the contacts if they click the link.

* In the **Remove interest** list box, you can choose an interest to be removed for the contacts if they click the link.

[How to create a newsletter sign-up form][1]

## Selection/Project

Here you can specify that recipients who click the link will be added to or removed from selections or projects. Type the beginning of a name to start the quick search.

## Follow-up (meeting/to-do)

In the **Follow-up** tab, you can specify that a link click should generate meetings or to-dos in SuperOffice CRM.

1. Check **Follow-up** to activate this function.

2. **Task/Appointment**: Choose which type of follow-up to create.

3. **Description**: Enter a description of the follow-up. For example, which mailing it relates to, which link the recipient clicked, and possibly how the to-do or meeting should be followed up.

4. **Project**: Here you select a project which the follow-up should be linked to. Type the beginning of a name to start the quick search.

5. **Task**: Select the required task or follow-up type.

6. **Created by**: Select which user should be responsible for the follow-up, or click the **Select active user** button ![icon][img1] to choose yourself.

7. **Assign to Our contact if available**: Check here if the follow-up should be assigned to "our contact" for the recipient (the person who looks after this customer).

8. **Default recipient**: Select a default recipient whom the follow-up should be assigned to, or click the **Select active user** button ![icon][img1] to choose yourself.

9. **Duration**: Click the **Select time span** button ![icon][img2] next to this field to set the duration of the follow-up.

## Request

In the **Request** tab, you can specify that a SuperOffice Service request should be created for contacts who click a link.md.

1. **Create new request**: Check here to register a new request when the customer clicks the link.
2. **Title**: Enter the title you want to give the new request.
3. **Priority**: Select the priority the request will have.
4. **Category**: Select the required category.
5. **Owner**: Select the owner you want for the new request. You can also select **Automatically assigned** or **Unassigned**.

## Script

In the **Script** tab, you can choose a script or macro to be run when the recipient clicks the link.

1. Select **Execute script** to activate this function.
2. Click the **Script** list and select the required script from the list that appears. The following variables are available in the script: custId, linkId, shipmentId, linkUrl and linkHits. You can also use the returnUrl variable to override the specified link URL.

## Example

Manually updating 500 contact cards will take time and is really unnecessary. Instead, let us automate this process by using automated link actions.

Examples of automated link actions in use:

* When a recipient clicks on your call-to-action link, SuperOffice CRM automatically adds them to a selection or a project.

* Alternatively, SuperOffice CRM automatically updates relevant information, such as interests, on the contact's card.

By automating these tasks, you save a lot of time you would otherwise spend on handling responses. When the reader clicks a link in your mailing, the system performs the link actions for you!

You can use the information you have gathered in this mailing in a number of ways:

* Automatically generate a selection based on people who clicked a specific link. Then, send a targeted follow-up mailing to this particular group with a tailored message.

* Add follow-up activities to your team members' diaries so that they could personally follow up on contacts that have responded.

* Generate service requests for your customer service team to pick up on and investigate the matter.

<!-- Referenced links -->
[1]: ../../forms/learn/examples.md#newsletter-sign-up

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-contact.png
[img2]: ../../../../../common/icons/pref-diary.png
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png

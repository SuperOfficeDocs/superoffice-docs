---
uid: help-en-add-unsubscribe-link
title: Add an unsubscribe link
description: Add an unsubscribe link
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Add subscription links

When you send a newsletter, for example, you must give the recipients the option of unsubscribing or changing their subscription preferences. You can do this by inserting a link for the recipients to click. Such links are normally placed at the bottom of a message.

In order to do this:

1. Go to the contents of the message and edit a paragraph (see [Edit a paragraph](Edit-paragraph.md)) to open the editing view.  
    Or click the **Add a new paragraph** ( ![icon](../media/btn-editor-newpara.jpg) ) button to add a paragraph at the bottom.
2. Select the **Body** tab.
3. Position the mouse pointer where you wish to insert the link.
4. Click the ![icon](../media/btn-link.png)**Subscription links** button in the toolbar. The **Add (un)subscription link** dialog opens.
5. Change the text in the **Link label** field, if required; for example, to "Click here to unsubscribe" or "Click here to manage your subscriptions".
6. In the **Add (un)subscription link** field, select one of the following options:
    * **Manage subscriptions**: Inserts a link to a web page where the recipients can select which mailing types they want to receive. The link is valid for 21 days by default.
    * **Unsubscribe from this type of mailing**: Inserts a link to unsubscribe to this mailing type. The recipient will still receive mailings of other types. The mailing type is selected in [Step 1: Setup](../step-1-setup-email.md).
7. Click **OK**. The link is inserted in the message.

## What happens now?

Based on the feedback from the recipients, the subscription preferences are updated on the **Interests** tab on the contact card in SuperOffice CRM.

> [!NOTE]
> This means that the customer no longer receives this mailing type from SuperOffice Marketing, regardless of which recipient list is used for the mailing. This may be not what you want for future marketing purposes. For more about alternative unsubscription methods, see [Examples of the use of trackable links](../Examples-of-use-of-trackable-links.md).  
You do, however, have the possibility to override "no consent / no subscription" settings, from **Options** in the lower part of the **Recipients** screen (see [Step 4: Recipients](../Step-4-Recipients-email.md)).

## Clear interests in SuperOffice CRM

In SuperOffice CRM, you can register interests (such as "Monthly newsletter") to contacts. These interests can be used as a basis for various kinds of mailings. Instead of using unsubscribe as described above, you can easily clear a particular interest, such as monthly newsletter, from customers who do not want to receive it.

You do this by creating a link that removes the interest in question from recipients who click the link. The same method can be used to register interests. See [Update interest](../Define-link-actions.md#update-interest).

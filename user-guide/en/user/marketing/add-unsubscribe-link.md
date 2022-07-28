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

When you send a newsletter, for example, you must give the recipients the option of unsubscribing or changing their subscription preferences. You can do this by inserting a link for the recipients to click. Such links are normally placed at the bottom of a message (in the footer).

[!include[To do this](../../includes/to-do-this.md)]

1. Go to the contents of the message and click the section where you want to insert the link..  
    or  
    Go to the **Blocks** section and click and drag a footer to the bottom of the message.

2. Type and select the text which the recipient has to click, for example "Click here to unsubscribe" or "Click here to manage your subscriptions".

3. Click the **Insert/edit link** button (![icon][img1])in the toolbar..

4. Click **Special links** and select one of the following options:
    * **Manage subscriptions**: Inserts a link to a web page where the recipients can select which mailing types they want to receive. The link is valid for 21 days by default.
    * **Unsubscribe from this type of mailing**: Inserts a link to unsubscribe to this mailing type. The recipient will still receive mailings of other types. The mailing type is selected in [Step 1: Setup][1].

5. Click **Save**. The link is inserted in the message.

## What happens now?

Based on the feedback from the recipients, the subscription preferences are updated on the **Interests** tab on the contact card in SuperOffice CRM.

> [!NOTE]
> This means that the customer no longer receives this mailing type from SuperOffice Marketing, regardless of which recipient list is used for the mailing. This may be not what you want for future marketing purposes. For more about alternative unsubscription methods, see [Examples of the use of trackable links][2].
>
> You do, however, have the possibility to override "no consent / no subscription" settings, from **Options** in the lower part of the **Recipients** screen (see [Step 4: Recipients][3]).

## Clear interests in SuperOffice CRM

In SuperOffice CRM, you can register interests (such as "Monthly newsletter") to contacts. These interests can be used as a basis for various kinds of mailings. Instead of using unsubscribe as described above, you can easily clear a particular interest, such as monthly newsletter, from customers who do not want to receive it.

You do this by creating a link that removes the interest in question from recipients who click the link. The same method can be used to register interests. See [Update interest][4].

<!-- Referenced links -->
[1]: step-1-setup-email.md
[2]: Examples-of-use-of-trackable-links.md
[3]: Step-4-Recipients-email.md
[4]: Define-link-actions.md#interests

<!-- Referenced images -->
[img1]: media/newbtn-link.png

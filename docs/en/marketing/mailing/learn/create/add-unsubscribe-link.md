---
uid: help-en-mailing-add-unsubscribe-link
title: Add an unsubscribe link
description: When you send a mailing, it is required to give recipients the option of unsubscribing. Learn how you can add an unsubscribe link to your mailing in this how-to guide.
author: SuperOffice RnD
so.date: 02.16.2023
keywords: marketing
so.topic: howto
language: en
---

# Add subscription links

When you send a newsletter, for example, you must give the recipients the option of unsubscribing or changing their subscription preferences. To do this, insert a link for the recipients to click. Such links are normally placed at the bottom of a message (in the footer).

The unsubscribe link is normally placed at the bottom of a message. If you use one of our mailing templates, this link is already added.

You decide where this unsubscribe link appears and its phrasing, as well as what clicking on this link does. For example, you may simply take the viewer to their "unsubscribe" page where they can manage their preferences, or they can automatically be opted out from all your mailings.

![From the Insert/edit link symbol, click Special links and add your unsubscribe link -screenshot][img4]

## In the drag and drop editor

1. Go to the contents of the message and click the section where you want to insert the link.
    or
    Go to the **Blocks** section and click and drag a footer to the bottom of the message.

2. Type and select the text which the recipient has to click, for example "Click here to unsubscribe" or "Click here to manage your subscriptions".

3. Click the **Insert/edit link** button (![icon][img3]) in the toolbar.

4. Click **Special links** and select one of the following options:
    * **Manage subscriptions**: Inserts a link to a web page where the recipients can select which mailing types they want to receive. The link is valid for 21 days by default.
    * **Unsubscribe from this type of mailing**: Inserts a link to unsubscribe to this mailing type. The recipient will still receive mailings of other types. The mailing type is selected in Step 1: Setup.

5. Click **Save**. The link is inserted in the message.

## In the old editor

1. Go to the contents of the message and [edit a paragraph][1] to open the editing view.
    Or click the ![icon][img1] **Add a new paragraph** button to add a paragraph at the bottom.
2. Select the **Body** tab.
3. Position the mouse pointer where you wish to insert the link.
4. Click the ![icon][img2] **Subscription links** button in the toolbar.
5. In the **Add (un)subscription link** dialog, change the text in the **Link label** field, if required; for example, to "Click here to unsubscribe" or "Click here to manage your subscriptions".
6. In the **Add (un)subscription link** field, select one of the following options:
    * **Manage subscriptions**: Inserts a link to a web page where the recipients can select which mailing types they want to receive. The link is valid for 21 days by default.
    * **Unsubscribe from this type of mailing**: Inserts a link to unsubscribe to this mailing type. The recipient will still receive mailings of other types. The mailing type is selected in Step 1: Setup.
7. Click **OK**. The link is inserted in the message.

## What happens now?

Based on the feedback from the recipients, the subscription preferences are updated on the **Interests** tab on the contact card in SuperOffice CRM.

> [!NOTE]
> This means that the customer no longer receives this mailing type from SuperOffice Marketing, regardless of which recipient list is used for the mailing. This may be not what you want for future marketing. [What are my alternatives?][2].
>
> You do, however, have the possibility to override "no consent / no subscription" settings, from **Options** in the lower part of the **Recipients** screen (see Step 4: Recipients).

## <a id="clear-interests" />Clear interests in SuperOffice CRM

In SuperOffice CRM, you can register interests (such as "Monthly newsletter") to contacts. These interests can be used as a basis for various kinds of mailings. Instead of using unsubscribe, you can easily clear a particular interest, such as monthly newsletter, from customers who do not want to receive it.

You do this by [creating a link that removes the interest][4] in question from recipients who click the link. The same method can be used to register interests.

<!-- Referenced links -->
[1]: ../../../learn/edit-paragraph.md
[2]: ../../../tracked-links/learn/examples.md
[4]: ../../../tracked-links/learn/define-link-actions.md#interests

<!-- Referenced images -->
[img3]: ../../../../../media/icons/marketing-and-forms/link.png
[img1]: ../../../../../media/icons/marketing-and-forms/new-para.jpg
[img2]: ../../../../../media/icons/marketing-and-forms/link.png
[img4]: media/insert-edit-link-unsubscribe-mailing.png

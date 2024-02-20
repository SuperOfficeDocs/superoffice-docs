---
uid: help-en-mailing-tracked-links
title: Tracked links
description: A link that you include in a mailing can be used to track responses from your customers and prospects. When your mailing's recipients click on the link an action is being triggered. 
keywords: Marketing
author: SuperOffice RnD
so.date: 02.14.2024
so.version: 10
so.topic: howto
language: en
so.audience: user
so.audience.tooltip: SuperOffice Marketing
---

# Tracked links

[!include[Requirement](includes/req-marketing.md)]

The goal of your newsletter or email campaign will determine what links you should use. Each goal will have its own call-to-action to trigger a response from the recipient that you want to track. This way you can follow up on your recipients after you have received all the results.

For example, clicking on a link may open a new website or update your recipient's Contact card. The action can also add a [Service request][8]. The use of links is only available for users who subscribe to the Marketing plan.

Before you start the actual mailing, you can set up the links you will frequently use in your mailings. After you set them up, you can use them again and again which will help you save time. Most common links to use are, for example:

* Unsubscribe pages
* Contact forms
* Social media channels

![In the Link properties screen you can add links you want to track -screenshot][img4]

You can include links (URLs) in a message and track them. In other words, you can see how many recipients have clicked them.

The URLs must be unique for each recipient, so that you can be sure it was different recipients who clicked the links and not the same one who clicked several times. In addition, the URLs must point at the SuperOffice server, so that they can be counted before they are redirected to the destination URL. The program arranges all this automatically when you select which URLs in the message you want to track.

## Examples of use

Trackable links can be used in a variety of interesting ways:

* **Response**: Each recipient who clicks a link, such as a new product page, is recorded in the system. This allows you to gauge the interest among all recipients across multiple mailings.

* **Prospect list**: If you are launching a new product, recipients can register their interest in the product by clicking the "Send me more info" link. Those who click the link can be added to a [static selection][9], which sales staff can use to manage further contact with these customers.

* **Follow-ups for salespersons in SuperOffice CRM**: One alternative to the prospect list in the example above is to generate a to-do or meeting for salespersons / customer contacts for each link click. A click on the "Contact me" link could, for example, generate a follow-up in SuperOffice CRM of type "Phone out" for the contact for that customer. In addition, the follow-up can be linked to a project in SuperOffice CRM, such as a marketing campaign.

* **Unsubscribe**: In the content editor, you can [insert a link for unsubscribing][4] from a specific mailing type. This means that the customer no longer receives this mailing type from SuperOffice Marketing, regardless of which recipient list is used for the mailing.

    An alternative to this unsubscribe link is to let the customer unsubscribe from individual recipient lists, such as the "Product A newsletter" list, so that they will still receive mailings from other recipient lists.

    You do this by adding a link (for example "Click here if you no longer wish to receive our newsletters"), which the customer can click to remove himself/herself from the recipient list. The customer is then removed from the selection you used as a basis for the mailing.

    If a newsletter is sent only to contacts with the "Newsletter" interest, you can define that this interest should be removed for recipients who click the link.

    > [!TIP]
    > To monitor who cancels their subscription, you can also ensure that those who click the link are also added to a separate selection named, for example, "Newsletter 2014 – cancelled subscriptions". It is possible to add multiple actions to the same link.

* **Individual follow-up**: You have just released a major update to your product. Not all your customers have an in-house IT department to deal with the update, so you add a link that the customer can click to book a consultant. A new request is then registered in SuperOffice Service for each customer who clicks the link. The request is allocated to the "Consultant" category, with the head of the consultancy department set as the owner. The customer is also sent feedback that they will be contacted by a consultant.

> [!NOTE]
> These examples work equally well for ordinary links, but in that case only the clicks for the individual mailing are recorded.

## The Tracked links tab

In the **Tracked links** tab you have the following options:

| Icon | Option | Read more |
|:-:|---|---|
| ![icon][img2] | Add | [Create a new link][1] |
| ![icon][img3] | Add folder | [Create a folder][5] for your links |
| Link | Click a link to open the **View link** screen. | [Work with tracked links after the mailing][2] |
| ![icon][img1] | Menu | Click the button next to a link to access the more options. |

Menu options:

* **View**. [How to work with tracked links after the mailing][2].
* **Edit**. [How to create tracked links][1].
* **Reset**. [How to reset counters for links][2].
* **Move to folder**. Used to move the link to another folder.
* **Delete**. Deletes the link.

## Which links am I tracking?

To [view all the links in a mailing][4], open the mailing in view mode and select the **Tracked links** tab.

## <a id="google" />Google Analytics

When setting up a mailing, you have the option of using Google Analytics as the tracking system. The setup in mailings allows you to define a more accurate tracking of emails using the provided fields, which results in more detailed Google Channel reports.

Google Analytics is the most popular digital analytics software available. By tracking how website visitors find and use your website, the service provides your company with useful insights that help you improve the success of your online marketing strategies.

By default, Google Analytics does not identify visitors coming from specific mailings. You have to add a tag to the links in your email to be able to:

* Identify which links your recipients have clicked,
* See which website pages they visited after they landed on your website.

When you add a link to your website in your mailing without a tag, you can see that your visitors come from a mailing, but you will not know which specific mailing. As a result, you are left in the dark about how the recipients of specific mailings behave on your website.

The Google Analytics feature in SuperOffice Marketing identifies your mailings in the reports. By adding a unique tag to all the links you use in your mailing, Google Analytics will recognize your mailing as the source where the website visitors come from. Google Analytics also gives you insight into the visitors' path through your website.

**Medium**: "Email" is the pre-defined medium in automated UTM tags. This means that tracked links in mailings sent from SuperOffice can be found in Google Channel reports under "Emails" (as opposed to "other").

**Source** and **Campaign**: These fields identify this specific mailing as the source, and allows for a more accurate tracking and reporting in Google.

## Related content

* [Include links you want to track][3]
* [Add subscription links][4]
* [Tutorial - simple Google Analytics email tracking][6]
* [Define link actions][7]

<!-- Referenced links -->
[1]: create-links.md
[7]: define-link-actions.md
[2]: explore-clicks.md
[3]: ../../editor/learn/add-tracked-link-to-msg.md
[4]: ../../editor/learn/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[8]: ../../../request/learn/index.md
[9]: ../../../search-options/selection/learn/static-selections.md
[6]: ga-tutorial.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/btn-add.png
[img3]: ../../../../../common/icons/folder.png
[img4]: ../../../../media/loc/en/marketing/link-properties.png

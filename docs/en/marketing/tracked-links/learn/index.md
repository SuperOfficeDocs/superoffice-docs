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

For example, clicking on a link may open a new website or update your recipient's Contact card. The action can also add a service request in Service and in the Request section tab on the Contact card. The use of links is only available for users who subscribe to the Marketing plan.

Before you start the actual mailing, you can set up the links you will frequently use in your mailings. After you set them up, you can use them again and again which will help you save time. Most common links to use are, for example:

* Unsubscribe pages
* Contact forms
* Social media channels

![In the Link properties screen you can add links you want to track -screenshot][img4]

You can include links (URLs) in a message and track them. In other words, you can see how many recipients have clicked them.

The URLs must be unique for each recipient, so that you can be sure it was different recipients who clicked the links and not the same one who clicked several times. In addition, the URLs must point at the SuperOffice server, so that they can be counted before they are redirected to the destination URL. The program arranges all this automatically when you select which URLs in the message you want to track.

In the **Tracked links** tab you have the following options:

| Icon | Option | Read more |
|---|---|---|
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
* [Simple Google Analytics email tracking][6] - blog
* [Define link actions][7]

<!-- Referenced links -->
[1]: create-links.md
[7]: define-link-actions.md
[2]: explore-clicks.md
[3]: ../../editor/learn/add-tracked-link-to-msg.md
[4]: ../../editor/learn/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[6]: https://community.superoffice.com/en/technical/blogs/archive/simple-google-analytics-email-tracking/

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/btn-add.png
[img3]: ../../../../../common/icons/folder.png
[img4]: ../../../../media/loc/en/marketing/link-properties.png

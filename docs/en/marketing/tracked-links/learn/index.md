---
uid: help-en-mailing-tracked-links
title: Tracked links
description: A link that you include in a mailing can be used to track responses from your customers and prospects. When your mailing's recipients click on the link an action is being triggered.
keywords: Marketing, mailing, tracked link, Google Analytics
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: concept
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: en
redirect_from: /en/marketing/tracked-links/learn/examples
---

# Tracked links

The links you use in your newsletter or email campaign are determined by your goals. Each goal has a unique call-to-action that prompts a response from the recipient, which you can track. This allows you to follow up with your recipients once you have gathered all the results.

For instance, a link click could open a new website or update a recipient's Contact card. It could also add a [Service request][8].

You can set up frequently used links even before creating content. This allows you to reuse these links, saving time. Commonly used links include:

* Unsubscribe pages
* Contact forms
* Social media channels

![Link properties screen where you can add trackable links -screenshot][img4]

Each recipient must have a unique URL to ensure that different recipients clicked the links, not the same recipient multiple times. Furthermore, the URLs must redirect to the SuperOffice server first for counting before redirecting to the destination URL. This is automatically arranged when you select the URLs in the message to track.

## <a id="ex"></a>Use cases

Trackable links can be utilized in various ways:

* **Response tracking**: Record each recipient's click on a link, such as a new product page, to measure interest across multiple mailings.

* **Prospect list**: For a new product launch, recipients can express interest by clicking the "Send me more info" link. Clickers can be added to a [static selection][9] for further contact management.

* **CRM follow-ups**: Instead of a prospect list, generate a to-do or meeting for each link click and assign it to a salespersons or customer contact. For example, a "Contact me" link click could generate a "Phone out" follow-up.

* **Unsubscribe**: Insert an [unsubscribe link][4] in the content editor to stop a specific mailing type. Alternatively, let customers unsubscribe from individual recipient lists.

    Add a link (for example, "Click here if you no longer wish to receive our newsletters") to remove customers from the recipient list. If a newsletter is sent only to contacts with the "Newsletter" interest, this interest can be removed for link clickers.

    > [!TIP]
    > Monitor subscription cancellations by adding link clickers to a separate selection, for example, "Newsletter 2024 – cancelled subscriptions". Multiple actions can be added to the same link.

* **Book consultant**: For a major product update, add a link for customers to book a consultant. Each link click registers a new Service request, allocated to the "Consultant" category. The customer receives feedback that they will be contacted by a consultant.

> [!NOTE]
> These examples work equally well for ordinary links, but in that case only the clicks for the individual mailing are recorded.

## Which links am I tracking?

To view all the links in a mailing, open the mailing in view mode and select the **Tracked links** tab.

## The Tracked links tab

In the **Tracked links** tab you have the following options:

| Icon | Option | Read more |
|:-:|---|---|
| <i class="ph ph-plus" aria-label="Plus"></i> | Add | [Create a new link][1], [Define link actions][7] |
| <i class="ph ph-folder" aria-label="Folder"></i> | Add folder | [Create a folder][5] for your links |
| Link | Click a link to open the **View link** screen. | [Work with tracked links after the mailing][2] |
| <i class="ph ph-list" aria-label="Task menu"></i> | Menu | Click the button next to a link to access the more options. |

Menu options:

* **[View][2]**
* **[Edit][1]**
* **[Reset][10]** (click counters)
* **Move to folder** (moves the link to another folder)
* **Delete**

## <a id="google"></a>Google Analytics

When setting up a mailing, you can opt for Google Analytics for more accurate email tracking, leading to detailed Google Channel reports.

Google Analytics, a popular digital analytics software, tracks how visitors find and use your website, providing valuable insights to enhance your online marketing strategies.

By default, Google Analytics does not identify visitors from specific mailings. To do so, you need to add a tag to your email links. This allows you to:

* Identify clicked links by recipients
* Track the website pages they visited post-click

Without a tag, you can see visitors from a mailing, but not from a specific one, leaving you uninformed about the behavior of specific mailing recipients on your website.

The Google Analytics feature in SuperOffice Marketing identifies your mailings in the reports. By adding a unique tag to your mailing links, Google Analytics recognizes your mailing as the visitor source and provides insight into the visitor's website journey.

**Medium**: "Email" is the pre-defined medium in automated UTM tags, meaning tracked links in SuperOffice mailings appear under "Emails" in Google Channel reports (as opposed to "other").

**Source** and **Campaign**: These fields identify the specific mailing as the source, enabling more accurate tracking and reporting in Google.

## Related content

* [Include links you want to track][3]
* [Add subscription links][4]
* [Tutorial - simple Google Analytics email tracking][6]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[7]: define-link-actions.md
[6]: ga-tutorial.md
[10]: reset-counter.md
[3]: ../../editor/learn/add-tracked-link-to-msg.md
[4]: ../../editor/learn/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[8]: ../../../request/learn/index.md
[9]: ../../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/link-properties.png

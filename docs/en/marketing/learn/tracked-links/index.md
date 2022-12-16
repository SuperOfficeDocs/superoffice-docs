---
uid: help-en-mailing-tracked-links
title: Tracked links
description: Tracked links
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Tracked links

[!include[Requirement](../includes/req-marketing.md)]

You can include links (URLs) in a message and track them. In other words, you can see how many recipients have clicked them.

The URLs must be unique for each recipient, so that you can be sure it was different recipients who clicked the links and not the same one who clicked several times. In addition, the URLs must point at the SuperOffice server, so that they can be counted before they are redirected to the destination URL. The program arranges all this automatically when you select which URLs in the message you want to track.

In the **Tracked links** tab you have the following options:

| Icon | Option | Read more |
|---|---|---|
| ![icon][img2] | Add | [Create a new link][1] |
| ![icon][img3] | Add folder | [Create a folder][19] for your links |
| Link | Click a link to open the **View link** screen. | [Work with tracked links after the mailing][2] |
| ![icon][img1] | Menu | Click the button next to a link to access the more options. |

Menu options:

* **View**. [How to work with tracked links after the mailing][2].
* **Edit**. [How to create tracked links][1].
* **Reset**. [How to reset counters for links][2].
* **Move to folder**. Click here to move the link to another folder.
* **Delete**. Click here to delete the link.

## Which links am I tracking?

To [view all the links in a mailing][4], open the mailing in view mode and select the **Tracked links** tab.

## <a id="google" />Google Analytics

When setting up a mailing, you have the option of using Google Analytics as the tracking system. The setup in mailings allows you to define a more accurate tracking of emails using the provided fields, which results in more detailed Google Channel reports.

**Medium**: "Email" is the pre-defined medium in automated UTM tags. This means that tracked links in mailings sent from SuperOffice can be found in Google Channel reports under "Emails" (as opposed to "other").

**Source** and **Campaign**: These fields identify this specific mailing as the source, and allows for a more accurate tracking and reporting in Google.

## Related content

* [Include links you want to track][3]
* [Add subscription links][4]
* [Simple Google Analytics email tracking][5]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[3]: add-tracked-link-to-msg.md
[4]: ../mailing/create/add-unsubscribe-link.md
[5]: https://community.superoffice.com/en/technical/blogs/archive/simple-google-analytics-email-tracking/
[19]: ../create-folder.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/btn-add.png
[img3]: ../../../../../common/icons/folder.png

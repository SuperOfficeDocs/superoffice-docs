---
uid: help-en-mailing
title: Work with mailings
description: Work with mailings
keywords: Marketing
author: SuperOffice RnD
so.date: 02.12.2024
so.version: 10
so.topic: concept
language: en
so.audience: user
so.audience.tooltip: SuperOffice Marketing
---

# Work with mailings

A mailing is usually handled in two steps:

* [Preparing and sending the mailing][1]
* [Following up the completed mailing](#after)

## Mailing types

* Email
* SMS
* Document
* Form response

> [!NOTE]
> Email mailings and form responses are the most feature-rich of these mailing types. Features such as [tracked links][7] and [subscription links][6] are not available in SMS mailings and document mailings.

## Define your goal

To ensure that your mailing is a success, you need, first and foremost, to reach out to the right people. The more you can narrow down your target group, the higher your chances are that the right message will reach the right person.

What do you want to achieve with your mailing? Do you want to:

* Get more leads?
* Sell more new products or services to your existing customers?
* Improve customer loyalty and retain customers?
* Inform of new developments, milestones or propositions?

SuperOffice CRM offers many ways of how to create a solid [target list][8]. You can use selections, projects or a single contact saved in the system. Any contacts that are not yet available in SuperOffice CRM database, can be added by importing an Excel list, provided that you have their consent to be sent marketing messages by your company.

You can also build a mailing list with the help of [online web forms][5]. Not only can you capture new leads among the visitors to your website who fill out a web form, but you can also use web forms to invite people to subscribe or sign up for different mailings.

Find out more information on how to [create and use web forms in Marketing][4].

## Recipients

You can add recipients from multiple sources.

> [!NOTE]
> When you add recipients, only contacts with a valid email address (or mobile phone number, in the case of SMS mailings) are added to the **Recipients** list.

Imported recipients that ARE NOT found in the SuperOffice database, will only consist of a name and an email address (or just an email address). This means that only the placeholders **\[\[customer.name\]\]** and/or **\[\[customer.email\]\]** will work for these recipients. To avoid empty variables in your mailings, make sure to [preview the mailing][3] first.

## Linking mailings to selections or projects

Mailings can be associated with a selection or project in SuperOffice CRM, providing an organized record of all related mailings. These mailings are cataloged under the **Mailings** tab in **Selections**, and the **Activities** tab in **Projects**.

> [!NOTE]
> Adding a selection or project automatically includes its contacts as mailing recipients. If both a selection and a project are added, only the selection's contacts are included.

For instance, if multiple mailings are sent to promote an event, they can be grouped under a selection named "Event 2024", providing a comprehensive list of all event-related mailings. Similarly, creating a project for your event allows you to track all associated mailings under the **Activities** tab.

## <a id="after" />How can I follow up mailings?

After your mailing is sent, it is always exciting to see how well your mailing has performed. To see if all your hard work has paid off. It is also a great opportunity to check and improve the quality of the information registered in your CRM database.

* [View the statistics][2] of the mailing and get information about any problems that occurred.
* [Add recipients to selections and projects][12] for further processing.
* [Check and correct the addresses of undelivered mails][11].
* See [who clicked the trackable links][14] you inserted in the message.
* Manage email addresses that were returned due to permanent errors or [bounced][13] several times.

<!-- Referenced links -->
[1]: create/index.md
[3]: create/send-test-email.md
[2]: view-statistics.md
[4]: ../../forms/learn/create.md
[6]: ../../editor/learn/add-unsubscribe-link.md
[8]: ../../recipients/learn/index.md
[11]: ../../recipients/learn/look-at-recipient-list.md
[12]: ../../recipients/learn/look-at-recipient-list.md#add-recipients
[13]: ../../recipients/learn/manage-bounces.md
[14]: ../../tracked-links/learn/explore-clicks.md
[7]: ../../tracked-links/learn/index.md
[5]: https://www.superoffice.co.uk/resources/articles/integrated-web-forms/

<!-- Referenced images -->
---
uid: help-en-marketing-best-practices
title: Best practices
description: Best practices
keywords: Marketing
author: Bergfrid Dias, Jeanette Small Strøm
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /en/marketing/learn/customize-for-mobile
language: en
---

# Best practices

* Use standard fonts for the best legibility with any email client or web browser.
* To avoid empty variables in your mailings, make sure to [preview the mailing][4] first.

## Checklist for marketing campaign

* Obtain explicit consent from your existing and potential contacts to receive marketing communication from your company. One way of asking for a permission is via mailings or web forms. Seeking permission and storing a record of it are the cornerstones of the GDPR.

* [Document any consents you obtain][5] regarding the lawful storage of personal data and sending e-marketing messages.

* Offer a simple and straight-forward way for your contacts to opt-out of your email marketing campaigns, by including clearly visible [unsubscribe links][3] in your mailings. Another way to make sure you contact only the people that want to hear from you is by creating a subscription management centre where data subjects can choose the content they want to receive.

* Obtain re-permissions from your existing customer base. This means that if you are not sure whether or not you have the necessary permissions, and if you have not provided your contacts with the possibility to opt-out, it may be necessary to obtain re-permissions. Sending a "re-permission" campaign is also a great away to update your existing records.

## Create relevant messages that resonate with your audience

Crafting a good message that is relevant to your audience is where it should all start. It is simple as that. Think about your own email inbox: you already have a lot to read, things to get done, so would you read messages that do not seem relevant? Probably not, right? So, start with that.

**Do:**

* **Create messages that are relevant to your audience**, that they will find valuable and useful. One of the best ways to increase deliverability in your email marketing is having good engagement with your audience. Email clients give points to senders whose emails get open, read, and replied, so make sure you are sending a message with your audience in mind.

* **Test your emails**. See them in different email clients, such as Outlook and Gmail, open them in your mobile phone and computer, make sure the images are looking good, and that the links all work. There are also a number of email testing solutions out there that can aid you, such as [Mailtrap][10] or [Putsmail][11].

* **Make it super easy to [unsubscribe][3]**. No one wants to lose subscribers, but if someone does not want to receive your emails anymore, they should be able to find that option easily. If not, people may be tempted to report you as SPAM, which will be way worse.

* **Make sure people recognize you**. When people look at your email in their inbox, they should immediately recognize it is from your company. Again, be real with your audience. Why would they open a message from someone they do not know?

**Avoid:**

* **Avoid using just images**. One big-image email can be considered SPAM. Other email solutions – like Outlook - may block images at first, so your message will be lost.

* **Avoid looking (and sounding) like SPAM**. Expressions like "Earn money quickly", "Cash bonus" or "Risk-free investment" will make your email look suspicious. Avoid these spam-trigger words. Treat your email like a conversation with your audience, be real with them.

Having the right message will take you far, but to make sure you are hitting the spot, you also need to send to the right people.

## Take care of your subscriber list

Getting a good reputation as an email sender is also about taking care of your subscriber lists. This means first making sure **information about your contacts is updated**. Having a lot of [bounces][2] (those returned emails of people who do not work at a company anymore or have changed addressed) can really jeopardize your reputation, making you a candidate for the SPAM folder.

It also means making sure people are interested in your messages. If a large part of your audience does not open or engage with your messages for a long time, it may be time to try some different approach with them. As you know, **engagement is a key factor in deliverability**, so make sure to check inactive users that have not opened your emails in a while.

**Segmenting your audience to send more targeted emails** is a good way to get that right message to the right people. In SuperOffice, you can use [selections][1] to target specific groups such as people from a specific country, or that have been in touch with your company recently. That way you can create even more relevant messages that will get your reader's attention.

## Make sure all wheels are turning behind-the-scenes

A lot in email deliverability is related **to creating that right experience** for your audience. Being relevant, making sure people are interested, taking care of the subscriber list are major aspects of what makes a campaign successful or not.

But there are some parts that are more behind-the-scenes. Technical aspects such as **domain reputation and authentication** are an equally important part of this puzzle. In the end, it all needs to work together to ensure email deliveries are spot on.

One of the most important aspects of these technical parts is the **[SPF record in your domain][7]**. If you are unfamiliar with this term, it will be helpful to understand what it is and the reason why it is important to set up.

## Use email domain validation

Hopefully, you are already using the flexible options to personalize and specify the From and Reply to fields when you set up a mailing in SuperOffice. This is great when you want to add custom text like **< Jeanette from SuperOffice >** to be displayed as the sender. Or if you are sending an email on behalf of your colleague or boss.

But if you add an un-validated or misspelled email address, that might hurt your email deliverability.

Administrators can [add validated domain][6] in Settings and maintenance to make sure users select the correct and authenticated domain

Content authors will see a message if they are using an un-validated email address in the From field, as a reminder to use authenticated domains. This will also help avoiding spelling mistakes in the email sending domain

## Automation

* Specify a maximum waiting time to avoid participants remaining active in a flow forever.​

* Update participants with new information during the flow​. For example, set a new interest or a new category as the contact is maturing; add and remove them from lists​.

* To avoid duplicate or conflicting actions: Include all actions one place, either in the form or in the flow.

* You can achieve the same experience by having a split in one flow or arrange the communication in two different flows.​ Whether to split or define several flows depends on the scenario, and what outcome you would like to track. ​The more two communication tracks have in common, the more effective it is for the user to arrange it within the same flow.​

## <a id="mobile"></a>Customize the message for display on mobile devices

The message is automatically customized for display on smaller screens.

When editing, click **Mobile** (<i class="ph ph-device-mobile" aria-hidden="true"></i>) in the global menu to see what the appearance is like on a smart phone. You can also click a section in the message and click **Mobile** under **Content** in the side-panel.

To adjust mobile-specific settings for a message, select a section in the message and click **Mobile** in the side-panel. You can now define the formatting for displaying the message on mobile devices, and also select which elements (such as images) to exclude from mobile devices.

<!-- Referenced links -->
[1]: ../recipients/learn/index.md#selections
[2]: ../recipients/learn/manage-bounces.md
[3]: ../editor/learn/add-unsubscribe-link.md
[4]: ../mailing/learn/create/send-test-email.md
[5]: ../../security/privacy/admin/add-legal-base.md
[6]: ../mailing/admin/add-domain.md
[7]: ../../../en/email/mailgun/spf/index.md
[10]: https://mailtrap.io/
[11]: https://putsmail.com/

<!-- Referenced images -->

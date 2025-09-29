---
uid: help-en-mailing-manage-subscriptions
title: Manage email subscriptions
description: SuperOffice CRM's Subscription Management features empower your contacts to specify the content they wish to receive. This is tied to Consent Management
keywords: mailing, consent, subscription, GDPR, privacy
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
---

# Manage email subscriptions

SuperOffice CRM's Subscription Management features empower your contacts to specify the content they wish to receive. This is tied to Consent Management, as some jurisdictions require documented consent before e-marketing mailings can be sent.

These features prevent the sending of e-marketing messages to those who have not consented, ensuring that your contacts maintain control over their email subscriptions. From the moment they are added to your SuperOffice database, contacts can specify their mailing preferences. They can also adjust these preferences via the unsubscribe link in each email.

By enabling customers to manage their subscriptions, you can enhance your mailing open rates and boost your marketing success.

## Interests in SuperOffice CRM

You can register interests (such as "Monthly newsletter") to contacts that can be used as a basis for various mailings. Instead of using unsubscribe, you can [create a link that removes the interest][5] from customers who do not want to receive it. The same method can be used to register interests.

## Your target list

When you [create your target list][1] for your next mailing, you can make a selection based on the subscription type you are going to use. By doing this, SuperOffice CRM will only add contacts who have said "yes" to this type of subscription.

## Choose subscription type for mailing

Creating a target list in SuperOffice CRM offers multiple methods, which may not always involve using a subscription type as a selection criterion. This can lead to inadvertently including contacts who have declined your mailings.

To avoid this, the Mailing Wizard in Step 1: Setup prompts you to specify the subscription type for your mailing.

![Choose what type of mailing you are sending out in the setup step. -screenshot][img1]

Once you have set your mailing type, SuperOffice CRM verifies the consent of each added recipient.

In Step 4: Recipients, you can view who has given consent. If the E-Marketing Privacy feature is enabled, SuperOffice CRM automatically excludes recipients without opt-in e-marketing consent and active subscriptions.

> [!TIP]
> An **Override Consent and Subscription** checkbox is available for crucial mailings to all contacts.

![When you have added recipients to the mailing list, you cans e weather or not they have given consent to that type of mailing. -screenshot][img2]

If E-Marketing Privacy is OFF, SuperOffice CRM will ignore consents and subscription preferences during mailings. Administrator rights are required to enable the E-marketing Privacy feature.

![In Settings and maintenance you can switch on the e-marketing privacy feature. -screenshot][img3]

## Use the unsubscribe link

People may change their preferences for the emails they receive. To accommodate this, all SuperOffice CRM mailing templates include an unsubscribe link.

> [!TIP]
> For sending a Manage Subscription email to a contact, see [Send Privacy Email][3].

This link directs recipients to their subscription preferences page, where they can choose the types of mailings they wish to receive. Any changes made are instantly saved upon confirmation.

![Select the mailings you would like to receive on the subscription preferences page. -screenshot][img4]

This ensures that customers control their mailing preferences, and you only send mailings to interested parties. By using SuperOffice CRM, you respect your contacts' communication preferences and can comply with GDPR rules, avoiding potential fines of up to €20,000,000.

## Related content

* [GDPR and privacy][2]
* [SuperOffice privacy statement][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../security/privacy/learn/index.md
[3]: ../../../security/privacy/learn/send-privacy-confirmation-email.md
[4]: https://www.superoffice.com/company/privacy/
[5]: ../../tracked-links/learn/define-link-actions.md#interests

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/setup-type-drop-down.png
[img2]: ../../../../media/loc/en/marketing/recipients-content-status.png
[img3]: ../../../../media/loc/en/marketing/e-marketing-privacy-feature.png
[img4]: ../../../../media/loc/en/marketing/subscription-preferences-page.png

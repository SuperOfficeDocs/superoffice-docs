---
uid: help-en-mailing-manage-subscriptions
title: WManage email subscriptions
description: The Subscription management features in SuperOffice CRM allow you to document what type of content your contacts want to receive from you.
author: SuperOffice RnD
so.date: 02.16.2023
keywords: marketing
so.topic: howto
language: en
---

# Manage email subscriptions

The Subscription management features in SuperOffice CRM allow you to document what type of content your contacts want to receive from you.

These features are linked to **Consent management** because in some countries you are also required to document a person's consent before you can send them e-marketing mailings.

The **Subscription management** features will help you avoid sending e-marketing messages to anyone who has not given their consent.

This functionality ensures that all the contact people in your CRM database are in control of their email subscriptions at all time. From the moment you add them to your SuperOffice database, they can tell you which mailings they wish to receive. Every time your contacts receive your mailings, they can change their subscription preferences using the unsubscribe link in the email.

The fact that your customers are able to manage their own subscriptions will positively affect the opening rates of your mailings and increase the overall success of your marketing efforts.

## Your target list

When you [create your target list][1] for your next mailing, you can make a selection based on the subscription type you're going to use. By doing this, SuperOffice CRM will only add contacts who have said "yes" to this type of subscription.

## Choose a subscription type

There are multiple ways of creating your target list using a selection. This means that you might not always use a subscription type as a selection criterion. When you do this, it is easy to lose sight of the fact that you have added the people who said "no" to receiving your mailings to your target list.

To prevent you from sending mailings to people who do not want to receive them, SuperOffice CRM can help you by filtering out the people who have not given you their consent.

When you create a new mailing, the mailing wizard will ask you to add the subscription type you wish to send in Step 1: Setup.

![Choose what type of mailing you are sending out in the setup step. -screenshot][img1]

After you have added your mailing type, SuperOffice CRM will check every contact you add as a recipient to see whether they have given you their consent to send them this mailing.

In Step 4 of the Mailing wizard, called Recipients, you can see exactly who has and who hasn't given you their consent. When the feature E-Marketing privacy is turned on, SuperOffice CRM automatically filters out all recipients who haven't opted-in based on their e-marketing consent and active subscriptions.

> [!TIP]
> You do have a check box to Override consent and subscription, if the mailing is very important to send out to all contacts.

![When you have added recipients to the mailing list, you cans e weather or not they have given consent to that type of mailing. -screenshot][img2]

If the E-Marketing privacy feature is turned OFF, this means that SuperOffice CRM will disregard consents and subscription preferences when sending your mailings. To turn on the E-marketing privacy feature you need the administrator's rights.

To learn more, watch the video on how you can set up the privacy settings for GDPR in SuperOffice CRM.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://youtu.be/1e0ZIUwX3IY?list=PL9fefjwA0X290ZZ8bMUHWh_d6s3Y2P0Jr]

![In Settings and maintenance you can switch on the e-marketing privacy feature. -screenshot][img3]

## Use the unsubscribe link

Sometimes, people change their mind about what emails they want to receive. When this happens, they should have the option to opt-out from the type of mailing you have sent them. Therefore, all SuperOffice CRM mailing templates come with an unsubscribe link.

> [!TIP]
> To send the email for Manage subscription to a contact, see Send privacy email.

Clicking this link will take your recipients to their subscription preferences page, where they can select the type of mailings they want to receive. The changes your contacts make are saved as soon as they confirm the new settings.

![Select the mailings you would like to receive on the subscription preferences page. -screenshot][img4]

Your customer is in control of the mailings they receive and you can make sure you only send your mailings to the people who are interested.

With SuperOffice CRM, you will respect your contacts' communication preferences and can make sure you operate within the rules of the GDPR. This way, you will never risk getting a €20,000,000 fine.

## Related

* [GDPR and privacy][2]
* [Send privacy email][3]
* GDPR privacy settings in Settings and maintenance
* [SuperOffice privacy statement][4]

<!-- Referenced links -->
[1]: create/target-list.md
[2]: ../../../security/privacy/learn/index.md
[3]: ../../../security/privacy/learn/send-privacy-confirmation-email.md
[4]: https://www.superoffice.com/company/privacy/

<!-- Referenced images -->
[img1]: media/setup-type-drop-down.png
[img2]: media/recipients-content-status.png
[img3]: media/e-marketing-privacy-feature.png
[img4]: media/subscription-preferences-page.png

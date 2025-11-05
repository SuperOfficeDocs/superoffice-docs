---
uid: zapier-find-contact-action
title: Set SuperOffice CRM Contact find action
description: How to use SuperOffice find contact action with Zapier
keywords: Find contact, new Zap, Zapier find action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Find a SuperOffice CRM Contact action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Find contact**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

    ![Fill out your action -screenshot][img5]

1. Choose your **Search Criteria** from the available options.

    ![Choose your search criteria -screenshot][img6]
    
1. Set your **Search Value**.

    ![Set your search value -screenshot][img7]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Contact id**, **Our contact id**, **Our contact**, **Mr/Mrs**, **First name**, **Middle name**, **Last name**, **Full name**, **Title**, **Created date**, **Created by**, **Updated date**, **Updated by**, **Note**, **Company id**, **Company name**, **Home address 1**, **Home address 2**, **Home address 3**, **Home city**, **Home State**, **Home county**, **Home zip code**, **Birthdate**, **E-mail**, **Private phone**, **Direct faxes**, **Mobile phone**, **Direct phone**, **Other phone**, **Chat**, **Internet Phones**, **Position id**, **Position**, **Number**, **Web site**, **Category id**, **Category**, **Business id**, **Business**, **Country id**, **Country**, **Service priority**, **Our service contact**, **Our service contact id**, **Academic title**, **Use as postal address**, **Preferred language**, **Former employee**, **Self URL**, **Person interests**, **E-marketing subscription types**, **Consent Sales And Service Purpose**, **Consent Sales And Service Legal Basis**, **Consent Sales And Service Source**, **Consent Sales And Service Comment**, **Zap Search Was Found Status**.

    ![Zapier: Verify -screenshot][img8]

## Related content

* [Create Contact Action][1]
* [Update Contact Action][2]
* [New Contact Trigger][3]
* [Contact Changed Trigger][4]
* [Create a Zap with SuperOffice CRM][5]

<!-- Referenced links -->
[1]: ../create/create-contact.md
[2]: ../update/update-contact.md
[3]: ../../triggers/new/new-contact.md
[4]: ../../triggers/changed/contact-changed.md
[5]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/search/search-contact/search-contact-action.png
[img5]: ../../media/actions/search/search-contact/search-contact-window.png
[img6]: ../../media/actions/search/search-contact/search-criteria-contact-window.png
[img7]: ../../media/actions/search/search-contact/search-value-contact-window.png
[img8]: ../../media/actions/search/search-contact/search-contact-output.png

---
uid: zapier-update-contact
title: Update SuperOffice CRM contact
description: How to update SuperOffice contact with Zapier
keywords: Update contact, new Zap, Zapier update action
author: miguellemos95
date: 10.29.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Update SuperOffice CRM contact

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Update Contact**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

1. Fill out the mandatory fields **Contact id** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Check that the action works by clicking **Test step**.

1. If the above steps were configured correctly, the response should consist of **Contact id**, **Our contact id**, **Our contact**, **Mr/Mrs**, **First name**, **Middle name**, **Last name**, **Full name**, **Title**, **Created date**, **Created by**, **Updated date**, **Updated by**, **Note**, **Company id**, **Company name**, **Home address 1**, **Home address 2**, **Home address 3**, **Home city**, **Home State**, **Home county**, **Home zip code**, **Birthdate**, **E-mail**, **Private phone**, **Direct faxes**, **Mobile phone**, **Direct phone**, **Other phone**, **Chat**, **Internet Phones**, **Position id**, **Position**, **Number**, **Web site**, **Category id**, **Category**, **Business id**, **Business**, **Country id**, **Country**, **Service priority**, **Our service contact**, **Our service contact id**, **Academic title**, **Use as postal address**, **Preferred language**, **Former employee**, **Self URL**, **Person interests**, **E-marketing subscription types**, **Consent Sales And Service Purpose**, **Consent Sales And Service Legal Basis**, **Consent Sales And Service Source**, **Consent Sales And Service Comment**

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Update contact][1]
* [Create a Zap with SuperOffice CRM][2]

<!-- Referenced links -->
[1]: update-contact.md
[2]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img1]: ../../media/create-zap.png
[img2]: ../../media/new-zap-window.png
[img3]: ../../media/search-superoffice-in-zapier.png
[img4]: ../../media/update/update-contact/update-contact-action.png
[img5]: ../../media/update/update-contact/update-contact-window.png
[img6]: ../../media/update/update-contact/update-contact-output.png

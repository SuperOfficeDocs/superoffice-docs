---
uid: zapier-update-company-action
title: Set SuperOffice CRM Company update action
description: How to use SuperOffice update company action with Zapier
keywords: Update company, new Zap, Zapier update action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Update a SuperOffice CRM Company action

[!include[note](../includes/note.md)]

## Steps

[!include[create zap step](../includes/create-zap-intro.md)]

1. [!include[click trigger step](includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Update Company**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](includes/go-to-conf-step.md)]

1. Fill out the mandatory fields **Company ID** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. [!include[check action works step](includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Company id**, **Company**, **Department**, **Category id**, **Category**, **Business id**, **Business**, **Our contact id**, **Our contact**, **Country id**, **Country**, **Number**, **Created date**, **Created by**, **Updated date**, **Updated by**, **Address 1**, **Address 2**, **Address 3**, **City**, **State**, **County**, **Zip code / postal code**, **Postal address 1**, **Postal address 2**, **Postal address 3**, **Postal city**, **Postal state**, **Postal county**, **Postal zip code / postal code**, **Note**, **E-mail**, **Phone**, **Fax**, **Web site**, **Interests**, **Code**, **VAT No**, **Stop**, **No Mailings**, **Self URL**

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Find Company Action][1]
* [Create Company Action][2]
* [New Company Trigger][3]
* [Company Changed Trigger][4]
* [Create a Zap with SuperOffice CRM][5]

<!-- Referenced links -->
[1]: search-company.md
[2]: create-company.md
[3]: ../triggers/new-company.md
[4]: ../triggers/company-changed.md
[5]: ../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../media/new-zap-window.png
[img3]: ../media/search-superoffice-in-zapier.png
[img4]: ../media/update-company-action.png
[img5]: ../media/update-company-window.png
[img6]: ../media/update-company-output.png

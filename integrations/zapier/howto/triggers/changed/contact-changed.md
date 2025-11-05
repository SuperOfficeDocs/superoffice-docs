---
uid: zapier-contact-changed-trigger
title: Set SuperOffice CRM Contact changed trigger
description: How to use SuperOffice contact change trigger with Zapier
keywords: Contact changed, new Zap, Zapier change trigger
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create a SuperOffice CRM Contact changed trigger

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. Click **Trigger** step to open a window for selecting the application to use.

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[search for so](../includes/search-for-so.md)]

1. A side menu will open, in the **Trigger event** section, select **Contact Changed**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your trigger -screenshot][img4]

1. [!include[test](../includes/test.md)]

    ![Test your trigger -screenshot][img5]

1. [!include[action](../includes/action.md)]

1. If the above steps were configured correctly, the action you chosen should be executed properly when the **Trigger event Contact Changed** is executed in SuperOffice CRM.

## Related content

* [Create Contact Action][1]
* [Update Contact Action][2]
* [New Contact Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: ../../actions/create/create-contact.md
[2]: ../../actions/update/update-contact.md
[3]: ../../triggers/new/new-contact.md
[4]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img4]: ../../media/triggers/contact-changed/contact-changed-action.png
[img5]: ../../media/triggers/contact-changed/contact-changed-output.png

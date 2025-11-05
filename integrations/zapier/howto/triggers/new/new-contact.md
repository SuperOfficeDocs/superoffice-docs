---
uid: zapier-new-contact-trigger
title: Set SuperOffice CRM new Contact trigger
description: How to use SuperOffice new contact trigger with Zapier
keywords: New contact, new Zap, Zapier new trigger
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Update SuperOffice CRM contact

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. Click **Trigger** step to open a window for selecting the application to use.

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[search for so](../includes/search-for-so.md)]

1. A side menu will open, in the **Trigger event** section, select **New Contact**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your trigger -screenshot][img4]

1. [!include[test](../includes/test.md)]

    ![Test your trigger -screenshot][img5]

1. [!include[action](../includes/action.md)]

1. If the above steps were configured correctly, the action you chosen should be executed properly when the **Trigger event New Contact** is executed in SuperOffice CRM.

## Related content

* [Create Contact Action][1]
* [Update Contact Action][2]
* [Contact Changed Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: ../../actions/create/create-contact.md
[2]: ../../actions/update/update-contact.md
[3]: ../../triggers/changed/contact-changed.md
[4]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img4]: ../../media/triggers/new-contact/new-contact-action.png
[img5]: ../../media/triggers/new-contact/new-contact-output.png

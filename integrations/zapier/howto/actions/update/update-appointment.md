---
uid: zapier-update-appointment-action
title: Set SuperOffice CRM Appointment update action
description: How to use SuperOffice update appointment action with Zapier
keywords: Update appointment, new Zap, Zapier update action
author: so-matas
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Update a SuperOffice CRM Appointment action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Update Appointment**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

1. Fill out the mandatory fields and optionally other fields and click **Continue**.

    ![Fill out your action -screenshot][img5]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Appointment id**, **Contact id**, **Person if**, **Project id**, **Sale id**, **Start date & time**, **End date & time**, **Type**, **Description**, **Location**, **All day event**, **Owner**, **Priority**, **Completed**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Create Appointment Action][1]
* [New Appointment Trigger][2]
* [Appointment Changed Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: ../create/create-appointment.md
[2]: ../../triggers/new/new-appointment.md
[3]: ../../triggers/changed/appointment-changed.md
[4]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/update/update-appointment/update-appointment-action.png
[img5]: ../../media/actions/update/update-appointment/update-appointment-window.png
[img6]: ../../media/actions/update/update-appointment/update-appointment-output.png

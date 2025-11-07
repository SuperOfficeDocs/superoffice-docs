---
uid: zapier-create-appointment-action
title: Set SuperOffice CRM Appointment create action
description: How to use SuperOffice create appointment action with Zapier
keywords: Create appointment, new Zap, Zapier create action
author: so-matas
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create a SuperOffice CRM Appointment action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create a trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select an action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Appointment**, then click the **Account** section and login using a SuperOffice account.

    ![Set up an action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

1. Fill out the mandatory fields and optionally other fields and click **Continue**.

    ![Fill out an action -screenshot][img5]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Appointment id**, **Contact id**, **Person if**, **Project id**, **Sale id**, **Start date & time**, **End date & time**, **Type**, **Description**, **Location**, **All day event**, **Owner**, **Priority**, **Completed**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Update Appointment Action][1]
* [New Appointment Trigger][2]
* [Appointment Changed Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: ../update/update-appointment.md
[2]: ../../triggers/new/new-appointment.md
[3]: ../../triggers/changed/appointment-changed.md
[4]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/new-zap-window.png
[img3]: ../../media/search-superoffice-in-zapier.png
[img4]: ../../media/create-appointment-action.png
[img5]: ../../media/create-appointment-window.png
[img6]: ../../media/create-appointment-output.png
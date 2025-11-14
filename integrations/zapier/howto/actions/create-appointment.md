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

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Create Appointment**

    ![Set up an action -screenshot][img4]

1. Click **Continue**.

1. Fill out the mandatory fields and optionally other fields and click **Continue**.

    ![Fill out an action -screenshot][img5]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Appointment id**, **Contact id**, **Person if**, **Project id**, **Sale id**, **Start date & time**, **End date & time**, **Type**, **Description**, **Location**, **All day event**, **Owner**, **Priority**, **Completed**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Update Appointment Action][1]
* [New Appointment Trigger][2]
* [Appointment Changed Trigger][3]
* [Create a SuperOffice CRM action - detailed steps][4]

<!-- Referenced links -->
[1]: update-appointment.md
[2]: ../triggers/new.md
[3]: ../triggers/changed.md
[4]: index.md

<!-- Referenced images -->
[img4]: media/create-appointment-action.png
[img5]: media/create-appointment-window.png
[img6]: media/create-appointment-output.png

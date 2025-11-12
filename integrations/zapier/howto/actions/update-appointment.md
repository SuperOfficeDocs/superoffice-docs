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
redirect_from: /integrations/zapier/howto/appointment-updated-action
---

# Update a SuperOffice CRM Appointment action

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Update Appointment**

    ![Set up an action -screenshot][img4]

1. Click **Continue**.

1. Fill out the mandatory fields as **Appointment ID** and optionally other fields and click **Continue**.

    ![Fill out your action -screenshot][img5]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Appointment ID**, **Is Main**, **Company ID**, **Company Name**, **Contact ID**, **Contact Name**, **Owner ID**, **Owner**, **Project ID**, **Project Name**, **Sale ID**, **Sale Title**, **Updated By**, **Updated Date**, **Created By**, **Created Date**, **Start Date & Time**, **End Date & Time**, **Is All Day Event?**, **Location**, **Description**, **Priority**, **Visible For**, **Type**, **Type ID**, **Is Completed**, **Alarm Lead Time**, **Has Alarm**, **Is Free**, **Is Milestone** and **Self URL***.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Create Appointment Action][1]
* [New Appointment Trigger][2]
* [Appointment Changed Trigger][3]
* [Create a SuperOffice CRM action - detailed steps][4]

<!-- Referenced links -->
[1]: create-appointment.md
[2]: ../triggers/new.md
[3]: ../triggers/changed.md
[4]: index.md

<!-- Referenced images -->
[img4]: media/update-appointment-action.png
[img5]: media/update-appointment-window.png
[img6]: media/update-appointment-output.png

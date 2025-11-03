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

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Update Appointment**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

1. Fill out the mandatory fields and optionally other fields and click **Continue**.

    ![Fill out your action -screenshot][img5]

1. Check that the action works by clicking **Test step**.

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
[img1]: ../../media/common/create-zap.png
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/update/update-appointment/update-appointment-action.png
[img5]: ../../media/actions/update/update-appointment/update-appointment-window.png
[img6]: ../../media/actions/update/update-appointment/update-appointment-output.png

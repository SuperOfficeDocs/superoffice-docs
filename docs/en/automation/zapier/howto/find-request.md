---
uid: zapier-retrieve-requests
title: Connect account
description: How to retrieve SuperOffice requests/tickets with Zapier
author: Matas Šamšūra
date: 09.09.2025
keywords: Zapier
content_type: howto
language: en
platform: Zapier
---

# Retrieve SuperOffice CRM requests with Zapier

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click on **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

2. Create your **Trigger**n by clicking on it. It can be an action in Google sheets or another action in external systems or a part of SuperOffice

    ![Zapier: Create your trigger -screenshot][img2]

3. Click on **Action**. You will be taken to a windows from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img2]

4. A side menu will open, in the **Action event** section, select **Find Request**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

5. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

6. Fill out the mandatory fields **Search Criteria** and **Search Value** and optionally other fields.

    ![Fill out your action -screenshot][img5]

7. Check that the action works by clicking **Test step**.

9. If the above steps were configured correctly, the response should consist of **Request id**, **Title**, **Author**, **Contact id**, **Company name**, **Owner id**, **Owner**, **Category id**, **Category**, **Priority id**, **Priority**, **Status**, **Access level for request**, **Origin**, **Created by id**, **Created by**, **Replied at**, **Closed at**, **Deadline**, **Self URL**

    ![Zapier: Verify -screenshot][img6]

> [!NOTE]
> Breaking change: As of version **3.5**, requests contain **Message** field, which contains **Id**, **Body**, **HtmlBody**, **Attachments** and **CustomFields** fields.


[img1]:<img width="1320" height="117" alt="create-zap" src="https://github.com/user-attachments/assets/5be506dc-03e8-425b-a907-30d235bff676" />

[img2]:<img width="814" height="571" alt="new-zap-window" src="https://github.com/user-attachments/assets/66ce321b-753e-4b4f-95db-41049f0970d8" />

[img3]:<img width="596" height="543" alt="search-superoffice-in-zapier" src="https://github.com/user-attachments/assets/2e0dd6f3-f286-4253-8552-517f862efbb7" />

[img4]:<img width="699" height="538" alt="search-for-create-request-action" src="https://github.com/user-attachments/assets/cb0f3ec6-c820-4c22-8197-c67ae2b71062" />

[img5]:<img width="359" height="356" alt="find-request-window" src="https://github.com/user-attachments/assets/23efb004-f467-4d2e-a4ab-3c35e47d5482" />

[img6]:<img width="325" height="802" alt="retrieved-request" src="https://github.com/user-attachments/assets/024819df-fecc-4b15-b857-43f4fd5167dc" />

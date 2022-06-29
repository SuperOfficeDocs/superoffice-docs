---
uid: help-en-admin-listpriorities-editalert-newalert
title: admin listPriorities editAlert newAlert
description: admin listPriorities editAlert newAlert
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create escalation levels

To create a new escalation level:

1. Select ![icon](../media/globalmenu_settings_small.png)&gt; **Priorities**. The **Priorities** screen appears.

2. Click the **New escalation level** button. This takes you to the **Escalation level properties** screen.

3. In the **Actions** tab, enter the following information:
    * **Priority**: In this list box, you choose the priority you want to link the escalation level to.
    * **Level**: In this list box, you select the position this escalation level will have in the escalation chain.
    * **Occurs after**: Click ![icon](../media/calendar.png), and define the delay before this level is enabled. If the priority has been defined to have its escalation comply with the time frame, that will affect the time entered here. A priority with a time frame of Monday to Friday, 09.00 to 17.00 and first escalation level after 2 hours, would, for example, be escalated at 10.00 on Monday, if the request was registered at 16.00 on the preceding Friday.
    * **Reassign to**: If you want the request to be forwarded to another user when this escalation level occurs, check here. Then select the user you require in the list.
    * **Run script**: If you want a script to be run when this escalation level occurs, check here. Then select the script you require in the list.

4. In the **Send reply template by e-mail to** tab, you can enter the following information:
    * **Contact**: If you check here, the reply template specified in the field to the right is sent to the contact for the request when this escalation level occurs. Select the required reply template in the list.
    * **Request owner**: If you check here, the reply template specified in the field to the right is sent to the owner of the request when this escalation level occurs. Select the required reply template in the list.
    * **Category administrator**: If you check here, the reply template specified in the field to the right is sent to the category administrator when this escalation level occurs. Select the required reply template in the list.
    * **Others**: If you check here, the reply template specified in the field to the right is sent to the e-mail address(es) entered in the field below. Select the required reply template in the list.
    * **E-mail address**: Here you enter the e-mail address which the reply template in the **Others** field is to be sent to. You can enter several addresses by separating them with commas.

5. In the **Send reply template by SMS to** tab, you can enter the following information:

    * **Contact**: If you check here, the reply template specified in the field to the right is sent to the contact for the request when this escalation level occurs. Select the required reply template in the list.
    * **Request owner**: If you check here, the reply template specified in the field to the right is sent to the owner of the request when this escalation level occurs. Select the required reply template in the list.
    * **Category administrator**: If you check here, the reply template specified in the field to the right is sent to the category administrator when this escalation level occurs. Select the required reply template in the list.
    * **Others**: If you check here, the reply template specified in the field to the right is sent to the mobile phone number(s) entered in the field below. Select the required reply template in the list.
    * **Mobile phone number**: Here you enter the mobile phone number which the reply template in the **Others** field is to be sent to. You can enter several numbers by separating them with commas.

    > [!NOTE]
    > If the **Send reply template by SMS to** tab is not displayed, this means that SMS has not been enabled for the licence you are using. Contact your system administrator for more information.

6. Click **OK**. The escalation level is created, and is displayed under the selected priority, in the **Priorities** screen.

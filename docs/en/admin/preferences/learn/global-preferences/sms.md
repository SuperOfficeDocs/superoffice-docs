---
uid: help-en-service-settings-system-sms
title: SMS
description: SMS
author: SuperOffice RnD
so.date: 03.27.2023
keywords: Service, settings
so.topic: help
so.user: admin
so.user.tooltip: Settings and maintenance
language: en
---

# SMS configuration in Global preferences

Go to ![icon][img1] **Preferences** in the navigator and select the tab **Global Preferences**. The section for **SMS configuration** contains options for configuring SMS solutions in SuperOffice.

## General fields

[!include[Settings for mailings - SMS](../../../../marketing/learn/includes/mailing-settings-sms.md)]

### Testing the SMS settings

To test the settings, enter a mobile phone number and some text, and then click **Test**.

## Fields available for Original Intelecom (ONSITE only)

* **SMS endpoint**: This field should contain code that allows SuperOffice Service to recognize an incoming SMS.
* **Use web service**: If checked, SMSes are sent via a web service instead of by email. This is the preferred method because it offers more functionality. It requires that any firewall allows outgoing traffic to SMS gateways.
* **Delivery report**: If checked, delivery confirmation is supported for SMSes in SuperOffice Service. This means you can see if an SMS was delivered to the relevant mobile phone. This also requires configuration from the provider's side.
* **Service ID**: Service ID for the SMS service. Provided by SuperOffice AS.
* **User name**: Here you enter the user name provided to you by Intelecom.
* **Password**: Here you enter the password provided to you by Intelecom.
* **SMS priority**: Here you enter 1, 2 or 3. The number specifies how quickly the SMSes are sent out.

## Fields available for Original PsWinCom (ONSITE only)

* **SMS endpoint**: This field should contain code that allows SuperOffice Service to recognize an incoming SMS.
* **User name**: Here you enter the user name provided to you by PsWinCom.
* **Password**: Here you enter the password provided to you by PsWinCom.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/nav-admin-preferences-active.png

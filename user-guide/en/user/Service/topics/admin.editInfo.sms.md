---
uid: help-en-admin-editinfo-sms
title: admin editInfo sms
description: admin editInfo sms
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# SMS

The **SMS** tab in the **System** screen contains options for configuring SMS solutions in SuperOffice Service.

## General fields

[!include[Settings for mailings - SMS](../../includes/mailing-settings-sms.md)]

## Testing the SMS settings

To test the settings, enter a mobile phone number and some text, and then click **Send test**.

## Fields available for Original Intelecom ![icon](../../media/OnPremises.png)

* **SMS endpoint**: This field should contain code that allows SuperOffice Service to recognise an incoming SMS.
* **Use webservice**: If you check here, SMSes will be sent via a web service instead of by e-mail. This is the preferred method since it offers more functionality. It requires that any firewall allows outgoing traffic to SMS gateways.
* **Delivery report**: If you check this option, delivery confirmation will be supported for SMSes in SuperOffice Service. This means you will be able to see if an SMS was delivered to the relevant mobile phone. This also requires configuration from the provider's side.
* **Service ID**: Service ID for the SMS service. Provided by SuperOffice AS.
* **User name**: Here you enter the user name provided to you by Intelecom.
* **Password**: Here you enter the password provided to you by Intelecom.
* **SMS priority**: Here you enter 1, 2 or 3. The number specifies how quickly the SMSes are sent out.

## Fields available for Original PsWinCom ![icon](../../media/OnPremises.png)

* **SMS endpoint**: This field should contain code that allows SuperOffice Service to recognise an incoming SMS.
* **User name**: Here you enter the user name provided to you by PsWinCom.
* **Password**: Here you enter the password provided to you by PsWinCom.

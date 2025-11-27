---
uid: sms-connector-config
title: Configure outgoing SMS connector
description: How to set up an SMS connector for SuperOffice.
keywords: SMS connector, SMS plugin, Compaya, CM, Intelecom, Link Mobility, PSWinCom, SMSTeknik, Twilio, TxtLocal
author: digitalidiina
date: 10.07.2025
version: 11.5
content_type: howto
category: Marketing
topic: SMS
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: 
  - /en/service/sms/cm
  - /en/service/sms/compaya
  - /en/service/sms/intelecom
  - /en/service/sms/linkmobility
  - /en/service/sms/smsteknik
  - /en/service/sms/twilio
  - /en/service/sms/txtlocal
language: en
---

# Configure outgoing SMS connector

This page describes how to set up an SMS connector for SuperOffice.

## Pre-requisites

You need an **account with the SMS provider** to obtain a username and password to connect to their service.

**Supported connectors:**

* [CM][1]
* [Compaya][2]
* [Intelecom][3]
* [Link Mobility (PSWinCom)][4]
* [SMSTeknik][5]
* [Twilio][6]
* [TxtLocal][7]

## Steps

1. Select **Marketing** in the navigator.

1. Go to the **Mailings** tab.

1. Click the **Settings** button in the lower-right corner.

1. Choose your SMS provider from the **Module** list.

1. Enter default country code and sender.

1. In the **Plugin configuration** box, add the following provider-specific settings. Then click **OK**.

<!-- markdownlint-disable-file MD051 -->
### [CM](#tab/cm)

```text
cm_serviceId =
cm_username =
cm_password =
```

![CM SMS plugin configuration -screenshot][img1]

### [Compaya](#tab/compaya)

```text
compaya_username =
compaya_password =
```

![Compaya SMS plugin configuration -screenshot][img2]

### [Intelecom](#tab/intelecom)

```text
intele_serviceId =
intele_username =
intele_password =
```

![Intelecom SMS plugin configuration -screenshot][img3]

### [Link Mobility (PSWinCom)](#tab/linkmobility)

```text
pswin_username =
pswin_password =
```

![Link Mobility PSWinCom SMS plugin configuration -screenshot][img4]

### [SMSTeknik](#tab/smsteknik)

```text
smsteknik_serviceId =
smsteknik_username =
smsteknik_password =
```

![SMSTeknik SMS plugin configuration -screenshot][img5]

### [Twilio](#tab/twilio)

```text
twilio_account_sid =
twilio_auth_token =
```

![Twilio SMS plugin configuration -screenshot][img6]

### [TxtLocal](#tab/txtlocal)

```text
txtlocal_username =
txtlocal_password =
```

![TxtLocal SMS plugin configuration -screenshot][img7]

***

> [!NOTE]
> In the legacy Service client, go to **System** > **SMS** to find the settings.

## Testing the service

To test that the service is set up correctly, you can create a new request, add an SMS recipient and wait for the SMS service to send the message (within a minute or 2).

It is also possible to test using a simple CRMScript that connects directly to the SMS service using NetServer.

```crmscript
NSMessagingAgent agent;
NSOutgoingMessage[] messages;
NSOutgoingMessage msg;
msg.SetTo("+47xxxxxxxx");
msg.SetFrom("MyCompany");
msg.SetContent("Hi friend! How are you?");
messages.pushBack(msg);

NSMessageDeliveryStatus[] receipts = agent.SendMessages("MySmsPluginName", messages);
```

This method of sending will not create any entries in the [SMS outbox][8], and the SMS is sent immediately to NetServer, not when [ejournalcron.exe][9] runs (usually once every minute).

<!-- Referenced links -->
[1]: https://www.cmtelecom.com/products/messaging/sms
[2]: http://www.compaya.dk/
[3]: https://www.intele.com/contact-centre-solution/sms/
[4]: https://www.linkmobility.com/products/link-sms-gateway/
[5]: http://www3.smsteknik.se/tj%C3%A4nster/sms-gateway
[6]: https://www.twilio.com/sms
[7]: http://www.textlocal.com/
[8]: ../../../email/admin/mailbox/index.md#sms-out
[9]: ../../../service/automated-tasks/ejournalcron.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/sms-settings-cm.png
[img2]: ../../../../media/loc/en/marketing/sms-settings-compaya.png
[img3]: ../../../../media/loc/en/marketing/sms-settings-intelecom.png
[img4]: ../../../../media/loc/en/marketing/sms-settings-pswincom.png
[img5]: ../../../../media/loc/en/marketing/sms-settings-smsteknik.png
[img6]: ../../../../media/loc/en/marketing/sms-settings-twilio.png
[img7]: ../../../../media/loc/en/marketing/sms-settings-txtlocal.png

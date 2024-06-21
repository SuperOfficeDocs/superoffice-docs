---
title: SMS plugins
uid: service_sms
description: NetServer SMS plugins for SuperOffice Service
author: {github-id}
keywords:
topic: concept
---

# SMS plugins

## Customer Service settings for NetServer SMS plugins

You could use the Messaging agent with [CRMScript][3] to send SMS from your scripts using your plugin (or any other plugin), without changing any settings in Customer Service, but if you want Customer Service to use your SMS plugin for any SMS sent during request handling and notifications, you need to set it up.

The following information applies to all SMS plugins.

## Add an SMS inbox for incoming SMS

You can do this in Settings/E-mail/New SMS mailbox. This is where settings like the category for incoming SMS messages are configured. This must be set up even though the plugin only supports outgoing SMS.

![x -screenshot][img1]

![x -screenshot][img2]

## From SuperOffice 8.0 SR3

We have made this easier to set up you no longer need to change the config file but just edit settings inside Sales & Marketing under **Mailings > Settings** or in **Service under System > SMS**

## SuperOffice versions up to 8.0 SR2

In Settings/System/SMS tab, set SMS provider to **NetServer plugins** and select your plugin in NetServer module settings.

![x -screenshot][img3]

Configure a sender as well. The sender can be whatever the SMS provider allows, like your company name, a short number, or an international telephone number.

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

This method of sending will not create any entries in the **Settings/E-mail/SMS outbox** pane, and the SMS will be sent immediately to NetServer and not when [ejournalcron.exe][2] runs (usually once every minute).

## How to use

[Read more about how to use the SMS plugins][1]

## Available plugins

* [CM][4]
* [Compaya][5]
* [Intelcom][6]
* [Link Mobility][7]
* [SMSTeknik][8]
* [Twilio][9]
* [TxtLocal][10]

<!-- Referenced links -->
[1]: ../../admin/preferences/learn/global-preferences/sms.md
[2]: ../automated-tasks/ejournalcron.md
[3]: ../../automation/crmscript/index.yml
[4]: cm.md
[5]: compaya.md
[6]: intelecom.md
[7]: linkmobility.md
[8]: smsteknik.md
[9]: twilio.md
[10]: txtlocal.md

<!-- Referenced images -->
[img1]: media/newsmsinbox.png
[img2]: media/smsinboxsettings.png
[img3]: media/netserverpluginsms.png

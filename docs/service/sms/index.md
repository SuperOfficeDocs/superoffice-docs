---
title: sms       
description:                    
author: {github-id}             # Your GitHub alias.
keywords:
---

# SMS plugins

## Customer Service settings for NetServer SMS plugins

You could use the Messaging agent with CRMScript to send SMS from your scripts using your plugin (or any other plugin), without changing any settings in Customer Service, but if you want Customer Service to use your SMS plugin for any SMS sent during request handling and notifications, you need to set it up.

The following information applies to all SMS plugins.

## Add an SMS inbox for incoming SMS

You can do this in Settings/E-mail/New SMS mailbox. This is where settings like category for incoming SMS messages are configured. This must be set up even though the plugin only supports outgoing SMS.

![x][1]

![x][2]

## From SuperOffice 8.0 SR3

We have made this easier to set up you no longer need to change the config file but just edit settings inside Sales & Marketing under **Mailings > Settings** or in **Service under System > SMS**

## SuperOffice versions up to 8.0 SR2

In Settings/System/SMS tab, set SMS provider to “NetServer plugins” and select your plugin in NetServer module settings.

![x][3]

Configure a sender as well. The sender can be whatever the SMS provider allows, like your company name, a short number, or an international telephone number.

## Testing the service

To test that the service is set up correctly, you can create a new request, add an SMS recipient and wait for the SMS service to send the message (within a minute or two).

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

This method of sending will not create any entries in the Settings/E-mail/SMS outbox pane, and the SMS will be sent immediately to NetServer and not when ejournalcron.exe runs (usually once every minute).

## How to use

You may read more about how to use the SMS plugins in the [help file][4]. The information in the help file applies to all SMS plugins.

<!-- Referenced links -->
[1]: media/newsmsinbox.png
[2]: media/smsinboxsettings.png
[3]: media/netserverpluginsms.png
[4]: https://community.superoffice.com/Documentation/Help/en/CRM/8.0/UserHelp/index.htm#t=_top%2FWelcome_to_Help_for_SuperOffice.htm&ux=search&rhsearch=sms

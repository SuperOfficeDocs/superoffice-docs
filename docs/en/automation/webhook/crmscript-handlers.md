---
title: CRMScript event handlers
uid: webhooks_crmscript_event_handlers
description: CRMScript hooks
author:
date:
keywords: automation
topic: reference
version: 9.2.7648
# envir:
# client:
---

# CRMScript webhooks event handlers

Webhooks can also target CRMScripts, not just URLs on the internet. The webhook will call your CRMScript directly, passing the ID and changed values to the script as parameters.

First you need to create a CRMScript to handle the event:

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("PrimaryKey");
String param2 = getVariable("Event");
String param3 = getVariable("Changes.name");
print("Params: " + param1 + " " + param2);
print("Name = " + param3 );
```

Save the script with a unique include name, `ScriptHook1`.

![include-name][include-img]

We then need to create a hook that will call this script:

<!-- markdownlint-disable MD051 -->
## [CRMScript API](#tab/Webhook-CRMScript)

## Create a webhook using CRMScript

This CRMScript will create a webhook that when triggered, calls a CRMScript with Include name `ScriptHook1`.

```crmscript
#setLanguageLevel 3;

/*
 * Create a new webhook to subscribe to person events.
 */

String targetCrmScript = "ScriptHook1";
String[] events = String("contact.created,contact.changed").split(",");

NSWebhookAgent webhookAgent;
NSWebhook webhook = webhookAgent.CreateDefaultWebhook();
webhook.SetEvents(events);
webhook.SetName("CRMScript webhook handler");
webhook.SetType("crmscript");
webhook.SetTargetUrl(targetCrmScript);
webhook.SetState(1)                      // Set it as active!

webhook = webhookAgent.SaveWebhook(webhook);

printLine("Webhook succeeded with ID: " + webhook.GetWebhookId().toString());
```

## [REST API](#tab/Webhook-REST)

## Create a webhook using the REST API

This CRMScript will create a webhook that when triggered, calls a CRMScript with Include name `ScriptHook1`.

This example uses an online OAuth Bearer token for authorization. See the [API Authentication][1] section for alternative options.

``` json
POST /api/v1/Webhook
Content-Type: application/json
Authorization: Bearer {{token}}

{
  "Name": "CRMScript webhook handler",
  "Events": [
        "contact.created",
        "contact.changed"
    ],
  "Type": "crmscript",
  "TargetUrl": "ScriptHook1",
  "State": "Active"
}
```

***
<!-- markdownlint-restore -->

The webhook must have a name, a list of events to subscribe to and must be set to `crmscript`.

This example above adds a webhook that will call the `ScriptHook1` script whenever a new contact is created or changed. The script is identified using the unique *include name* as the `TargetUrl` value.

Unlike webhooks of type *webhook*, a *CRMScript* webhook gets the values of the changed fields, not just the names of the changed fields as parameters.

Parameters passed to the CRMScript:

* ChangedByAssociateId
* Changes.(fieldname)
* ContextIdentifier
* Entity
* Event
* EventId
* PrimaryKey
* Timestamp
* any properties defined on the webhook

CRMScript hooks are run in the background, without access to the user interface. They do not block the user's action, so they are low-impact from the end-users perspective. They may run some time after the triggering event since webhooks are dispatched on a background thread.

## Get all webhooks with CRMScript

> [!NOTE]
> Applications in SuperOffice CRM Online can only see the webhooks they themselves create. Therefore, when you call `GetAllWebhooks` in CRMScript, you will only see the webhooks created by CRMScript in Service.

```crmscript
#setLanguageLevel 3;

NSWebhookAgent webhookAgent;
NSWebhook[] webhooks = webhookAgent.GetAllWebhooks("","",0);

for(Integer i = 0; i < webhooks.length(); i++) {
  Integer state = webhooks[i].GetState();
  printLine("Name: " + webhooks[i].GetName());
  printLine("ID: " + webhooks[i].GetWebhookId().toString());
  printLine("State: " + state.toString());
  printLine("Secret: " + webhooks[i].GetSecret());
  printLine("TargetUrl: " + webhooks[i].GetTargetUrl());
  printLine("Registered By: " + webhooks[i].GetRegisteredAssociate().GetName());
  printLine("Registered Date: " + webhooks[i].GetRegistered().toString());
  printLine("Updated By: " + webhooks[i].GetUpdatedAssociate().GetName());
  printLine("Updated Date: " + webhooks[i].GetUpdated().toString());
  printLine("Type: " + webhooks[i].GetType());
  printLine("Events:");
  String[] events = webhooks[i].GetEvents();
  for(Integer i = 0; i < events.length(); i++) {
    printLine("-  " + events[i]);
  }

  // delete when not needed
  //webhookAgent.DeleteWebhook(webhooks[i].GetWebhookId());
  printLine("****************************************************************");
}
```

<!-- referenced links -->

[1]: ../../api/authentication/overview.md

<!-- referenced images -->

[include-img]: media/webhook-include-name.png

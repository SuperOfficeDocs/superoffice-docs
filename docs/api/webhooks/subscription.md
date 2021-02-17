---
# Mandatory fields.
title: webhook_subscription       
description: Webhook subscription 
author: Tony Yates
so.date: 04.06.2018
keywords: automation
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Webhook subscription

Webhook subscriptions are created using SuperOffice NetServer core and NetServer web services - both SOAP and REST APIs.

Below I will demonstrate how to create a webhook using both NetServer core and web services.

## NetServer Core

There are 2 distinct ways to create webhooks using NetServer core, and there is a difference in behavior between them.

There are the traditional Row classes `SuperOffice.CRM.Rows.WebhookRow`, and then there is the `SuperOffice.CRM.Webhooks.WebhookManager`.

The key difference is when using `WebhookManager`, the `TargetURL` is pre-checked before saving, by sending out a test webhook payload, and is expected to send a 200 OK response. If the `TargetURL` fails to respond, the save operation will fail.

Creating webhooks via the SOAP or REST APIs, NetServer uses the `WebhookManager`, therefore the `TargetURL` must already exist and respond accordingly.

```csharp
// SuperOffice.CRM.Rows: no verification check for TargetUrl

var name      = "Tonys Contact Handler";
var events    = "contact.created,contact.changed,contact.deleted";
var targetUrl = "https://www.myserver.com/superoffice/webhookhandler";
var secret    = "Something Super Secret";
var type      = "webhook";
var state     = SuperOffice.Data.WebhookState.Active;

var webHookRow = WebhookRow.CreateNew();

webHookRow.SetDefaults();
webHookRow.Name      = name;
webHookRow.Events    = events;
webHookRow.TargetUrl = targetUrl;
webHookRow.Secret    = secret;
webHookRow.State     = state;
webHookRow.Type      = type;

webHookRow.Save();


// SuperOffice.CRM.Webhooks.WebhookManager: verifies the existence of the TargetUrl

var webhookManager = WebhookManager.GetCurrent();
var webhook        = new Webhook(0, name, targetUrl, events, secret);
webhookManager.SaveWebhook(webhook);
```

## NetServer SOAP Web Services

`SuperOffice.CRM.Services.WebhookAgent` is used to manage webhooks. Using `WebhookAgent.CreateDefaultWebhook` will automatically set the `Type` and `State` to *webhook* and *Active*, respectively. The webhook will also contain two default Events, *contact.created* and *contact.deleted*. These are easy to replace, but nice to have for testing purposes.

Use the `WebhookAgent.SaveWebhook` method to save or update a webhook.

```csharp
using (var wa = new WebhookAgent())
{
  // defines two default events contact.created & contact.deleted
  var wh = wa.CreateDefaultWebhook(); 

    wh.Name      = "Tonys Contact Handler";
    wh.Events    = new [] { "contact.created", "contact.changed", "contact.deleted" };
    wh.TargetUrl = "https://www.myserver.com/superoffice/webhookhandler";
    wh.Secret    = "Something Super Secret";

    wh = wa.SaveWebhook(wh);
}
```

### WebhookAgent methods

The `WebhookAgent` has methods to get an existing webhook by ID `GetWebhook(int id)`, and a delete method to permanently remove a webhook, `DeleteWebhook(int id)`. 

The table below lists all available `WebhookAgent` Methods.

| Method Name | Description |
|---|---|
| CreateDefaultWebhook() | Returns new Webhook with default values. |
| DeleteWebhook(id) | Deletes the webhook. |
| GetLastError(id) | Return the most recent error message received when calling this webhook. |
| GetAllWebhooks(string, string webhookState) | Returns all webhooks, according to filter criteria. |
| GetWebhook(id) | Gets a Webhook by ID. |
| SignalWebhook(string, int, StringObjectDictionary) | Signal webhooks that an event has occurred. All webhooks listening for the event will be notified. |
| TestWebhook(webhook) | Pings a webhook with a ‘test’ event, returns SUCCESS(true) or FAILURE(false) + the response from the webhook target. |

## NetServer REST web services

NetServer REST APIs are an abstraction over the NetServer SOAP API, and therefore has the same behavior.

### Create

To create a new webhook, you can either build the JSON structure yourself, or issue a GET request the `api/v1/Webhook/default` URL and get the structure pre-populated with the defaults.

```json
{
"WebhookId": 0,
"Name": null,
"Events": [
  "contact.created",
  "contact.deleted"
],
"TargetUrl": null,
"Secret": null,
"State": "Active",
"Type": "webhook",
"Headers": null,
"Properties": null,
"Registered": "0001-01-01T00:00:00",
"RegisteredAssociate": null,
"Updated": "0001-01-01T00:00:00",
"UpdatedAssociate": null
}
```

### Save

Save: **POST api/v1/Webhook**

```json
{
  "Name": "Tonys Contact Handler",
  "Events": [
        "contact.created",
        "contact.changed",
        "contact.deleted"
    ],
  "TargetUrl": "https://www.myserver.com/superoffice/webhookhandler",
  "Secret": "Something Super Secret",
  "State": "Active",
  "Type": "webhook"
}
```

### Available REST URLs

| Verb | URL |
|---|---|
| GET | api/v1/Webhook/default |
| GET | api/v1/Webhook/{id} |
| GET | api/v1/Webhook/{webhookId}/LastError |
| GET | api/v1/Webhook?nameFilter={nameFilter}&eventFilter={eventFilter}&statusFilter={statusFilter} |
| POST | api/v1/Webhook |
| POST | api/v1/Webhook/Test |
| POST | api/v1/Webhook/{eventName}/{primaryKey} |
| PUT | api/v1/Webhook/{id} |
| DELETE | api/v1/Webhook/{id} |

**POST api/v1/Webhook** will register a new webhook definition.

**POST api/v1/Webhook/Test** will check that the webhook definition is OK, and verify that the target URL responds to a test POST with 200 OK.

**POST api/v1/Webhook/foo.bar/123** will signal that the event 'foo.bar' has happened to id 123. Any webhooks registered for the event 'foo.bar' will be notified. You can add additional details (like field changes) in the body of the POST.

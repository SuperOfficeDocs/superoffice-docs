---
uid: webhook_subscription
title: Webhook subscription
description: "How to create a webhook using both NetServer core and web services."
author: AnthonyYates
date: 04.06.2018
keywords: automation
topic: howto
---

# Webhook subscription

Webhook subscriptions are created using SuperOffice NetServer core and NetServer web services - both SOAP and REST APIs.

Below I will demonstrate how to create a webhook using both NetServer web services and core.

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
"ErrorsEmail": null,
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

#### Create state change webhook

This is a multi-step process. First create the webhook, then subscribe to the state change events.

1. `Create a new webhook` by issuing a GET request the `api/v1/Webhook/default` URL and get the structure pre-populated with the defaults.

2. `Save the webhook` using the POST `api/v1/Webhook` URL.

3. `Get the webhook ID` from the response.

4. `Create a new webhook subscription`, same as #1, but this time use the webhook ID to set the webhook state events.

5. `Save the webhook subscription` using the POST `api/v1/Webhook` URL.

Assuming webhook ID is `123`:

```json
{
"WebhookId": 0,
"Name": null,
"Events": [
  "webhook123.started",
  "webhook123.stopped",
  "webhook123.errors"
],
"ErrorsEmail": "username@domain.com",
"TargetUrl": "https://www.myserver.com/webhookhandler",
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
  "Name": "Contact Handler",
  "Events": [
        "contact.created",
        "contact.changed",
        "contact.deleted"
    ],
  "TargetUrl": "https://www.myserver.com/superoffice/webhookhandler",
  "Secret": "Something Super Secret",
  "State": "Active",
  "ErrorsEmail": "username@domain.com",
  "Type": "webhook"
}
```

### REST URL tips

**POST api/v1/Webhook** will register a new webhook definition.

**POST api/v1/Webhook/Test** will check that the webhook definition is OK, and verify that the target URL responds to a test POST with 200 OK.

**POST api/v1/Webhook/foo.bar/123** will signal that the event 'foo.bar' has happened to id 123. Any webhooks registered for the event 'foo.bar' will be notified. You can add additional details (like field changes) in the body of the POST.

See the [RESTful WebAPI documentation][1] for more details.

## NetServer SOAP Web Services

`SuperOffice.CRM.Services.WebhookAgent` is used to manage webhooks. Using `WebhookAgent.CreateDefaultWebhook` will automatically set the `Type` and `State` to *webhook* and *Active*, respectively. The webhook will also contain two default Events, *contact.created* and *contact.deleted*. These are easy to replace, but nice to have for testing purposes.

Use the `WebhookAgent.SaveWebhook` method to save or update a webhook.

```csharp
using (var wa = new WebhookAgent())
{
  // defines two default events contact.created & contact.deleted
  var wh = wa.CreateDefaultWebhook(); 

    wh.Name      = "Contact Handler";
    wh.Events    = new [] { "contact.created", "contact.changed", "contact.deleted" };
    wh.TargetUrl = "https://www.myserver.com/superoffice/webhookhandler";
    wh.Secret    = "Something Super Secret";
    wh.ErrorsEmail = "username@domain.com";

    wh = wa.SaveWebhook(wh);
}
```

### WebhookAgent methods

The `WebhookAgent` has methods to get an existing webhook by ID `GetWebhook(int id)`, and a delete method to permanently remove a webhook, `DeleteWebhook(int id)`.

The [HTTP RPC Agents API][2] and [SOAP API][3] contains all available `WebhookAgent` Methods.

## NetServer Core

There are 2 distinct ways to create webhooks using NetServer core, and there is a difference in behavior between them.

There are the traditional Row classes `SuperOffice.CRM.Rows.WebhookRow`, and then there is the `SuperOffice.CRM.Webhooks.WebhookManager`.

The key difference is when using `WebhookManager`, the `TargetURL` is pre-checked before saving, by sending out a test webhook payload, and is expected to send a 200 OK response. If the `TargetURL` fails to respond, the save operation will fail.

Creating webhooks via the SOAP or REST APIs, NetServer uses the `WebhookManager`, therefore the `TargetURL` must already exist and respond accordingly.

```csharp
// SuperOffice.CRM.Rows: no verification check for TargetUrl

var name        = "Contact Handler";
var events      = "contact.created,contact.changed,contact.deleted";
var targetUrl   = "https://www.myserver.com/superoffice/webhookhandler";
var secret      = "Something Super Secret";
var type        = "webhook";
var state       = "Active";
var errorsEmail = "username@domain.com";

var webHookRow = WebhookRow.CreateNew();

webHookRow.SetDefaults();
webHookRow.Name        = name;
webHookRow.Events      = events;
webHookRow.TargetUrl   = targetUrl;
webHookRow.Secret      = secret;
webHookRow.State       = state;
webHookRow.Type        = type;
webhookRow.ErrorsEmail = errorEmail;
webHookRow.Save();


// SuperOffice.CRM.Webhooks.WebhookManager: verifies the existence of the TargetUrl

var webhookManager = WebhookManager.GetCurrent();
var webhook        = new Webhook(0, name, targetUrl, events, secret);
webhookManager.SaveWebhook(webhook);
```

<!-- Referenced links -->
[1]: ../../api/reference/restful/rest/Webhook/index.md
[2]: ../../api/reference/restful/agent/Webhook_Agent/index.md
[3]: ../../api/reference/soap/Services88/Webhook/index.md

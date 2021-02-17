---
title: webhook       
description: SuperOffice Webhooks
author: Tony Yates
so.date: 04.06.2018
keywords: automation
---

# SuperOffice Webhooks

No longer must integrations poll SuperOffice and ask for the latest changes. SuperOffice Webhooks actively send messages to subscribers when events occur in SuperOffice and provide an opportunity for applications to react accordingly.

Webhooks are a means to broadcast events that happen inside SuperOffice as they occur. A webhook payload includes information that describes what has changed and is broadcast to all applications that have subscribed to a corresponding event.

The webhook workflow begins with applications subscribing to interesting events. The way an application does this is by adding one or more webhook definitions in SuperOffice.

For example, the Partner Application registers an interest in `contact.created` events with SuperOffice. From then on, whenever a contact record is created, SuperOffice will notify the Partner Application that the event has occurred. The Partner Application can then update its own state, get more information, or just log the information.

Let's start by looking at a webhook definition - what the Partner Application uses to register its interest in events with SuperOffice.

![x][img1]

## Webhook definition

A webhook subscription contains the following properties:

| Property name | Description |
|---|---|
| Name | A name to distinguish events from one another. |
| Events | An array of `entity.event` names. |
| TargetURL | Defines a URL where webhook payloads are sent. Must be HTTPS and must respond to POST |
| Secret | Optional shared secret. Used for creating a SHA256 HMAC if set. |
| State | Unknown = 0, Active = 1, Stopped = 2, TooManyErrors = 3 |
| Type | Name of webhook plugin that handles dispatching this webhook: "webhook", "crmscript", etc. |
| Headers | Hook-specific custom headers to be added to the webhook payload. |
| Properties | Hook-specific data properties to be added to the webhook payload. |

While a webhook `name` need not be unique, it should be unique enough to distinguish it from others and describe its purpose.

The `Events` property is an array of one or more event names the subscriber is subscribing to. The format of a single event name is `<entity>.<event>`, where *entity* is one of the [available entities][1], and the event is one of *created*, *changed* or *deleted*.

`TargetURL` defines where to send the POST request containing the webhook payload. The webhook payload contains all relevant information needed by subscribers to take action. The Target URL must be HTTPS, and it must respond to a POST request with a 200 OK response. The HTTPS certificate must be valid. If the certificate is not valid (i.e. self-signed, expired, not valid for host-name, revoked, etc), then the webhook will be rejected.

When security is important, which should be always, a webhook definition specifies a shared secret that both the sender and receiver use to validate a webhook payload. When an event notification is sent, the webhook payload is hashed and base64 encoded and the resulting value is added to a header in the POST request. The header key is `X-SuperOffice-Signature`. It’s up to the subscriber to [validate the header value][4].

The `state` of a webhook is by default **Active** but can be set to **Stopped**. If the sender does not receive a successful 200 response from the server after seven attempts, SuperOffice will set the state of the webhook to **TooManyErrors**.

A webhook `Type` must match the plugin responsible for dispatching notifications. As of this writing, the only supported value is "webhook".

Webhook `Headers` are any additional header values SuperOffice appends to a request sent with each notification. Headers are a simple "string":"string" value.

Webhook `Properties` are any additional values SuperOffice should append to each request sent with each notification. Properties are a "string": {object} value.

## Learn more about the SuperOffice Webhooks API

> [!NOTE]
> Applies to Web client and NetServer Services only (onsite & online).

* [Event details][1]
* [Webhook subscription][2]
* [Webhook notification][3]
* [Webhook secrets][4]

<!-- Referenced links -->
[1]: event-details.md
[2]: subscription.md
[3]: notification.md
[4]: security.md

<!-- Referenced images -->
[img1]: media/webhook-subscribe-notification.png

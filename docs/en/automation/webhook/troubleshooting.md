---
uid: webhook-troubleshooting
title: Webhook troubleshooting
description: "How to troubleshoot webhooks errors."
author: AnthonyYates
date: 06.05.2023
keywords: automation
topic: howto
audience: api
audience_tooltip: Troubleshooting webhooks
---

# Troubleshooting webhooks

As developers, it's important to ensure the seamless operation of our applications, and troubleshooting issues is a key part of that process. Lets focus on troubleshooting webhooks, essential components that enable real-time data exchange between applications.

When things go awry, and your application doesn't seem to be receiving webhook notifications, it's time to put your detective hat on. Here's a systematic guide to help you inspect and diagnose the problem.

> [!TIP]
> There are two solutions for receiving notifications when a webhook state
> changes or errors occur.
>
> * Use the `ErrorsEmail` property to receive an email notification.
> * Subscribe to the `webhook{webhookId}.errors` event. [See details][1].
>
> It is recommended with the latter method that you use the a different webhook URL than your other webhooks.

## Checking webhook status

First and foremost, check the status of your webhooks. This can be accomplished by calling one of the following APIs:

- `/api/v1/Webhook` (RESTful REST API)
- `/api/v1/Agents/Webhook/GetAllWebhooks` (HTTP RPC Agent API)
- `WebhookAgent.GetAllWebhooks` (Proxy Clients)
- `NSWebhookAgent.GetAllWebhooks` (CRMScript)

These endpoints will return the details of your webhooks, including a key property, `State`, which indicates the current status of the webhook. There are four possible states:

1. Unknown
2. Active
3. Stopped
4. TooManyErrors

If the `State` property indicates that the webhook is `Active`, it means the webhook should be operational. If the state is `Stopped`, inspect the `UpdatedAssociate` property to identify who or what caused the webhook to stop. This information can guide you in seeking further assistance or explanations.

## Evaluating errors

In case the `State` is marked as `TooManyErrors`, you'll need to dig a little deeper to identify the cause of these errors. You can use the dynamic archive provider to fetch the statistics and error messages related to your webhooks:

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/Archive/dynamic?$select=webhook_usage.webhook_usage_id,webhook_usage.total_calls,webhook_usage.total_errors,webhook_usage.consecutive_errors,webhook_usage.last_error
Authorization: Bearer {{token}}
Accept: application/json
```

In this request, the webhook_usage_id corresponds to the Webhook.WebhookId identifier. This means that you can find detailed information about a specific webhook using its WebhookId as the filter criterion:

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/Archive/dynamic?$select=webhook_usage.total_calls,webhook_usage.total_errors,webhook_usage.consecutive_errors,webhook_usage.last_error&$filter=webhook_usage.webhook_usage_id eq {{webhook_id}}
Authorization: Bearer {{token}}
Accept: application/json
```

The response will contain the following information:

- `total_calls`: The total number of calls made to the webhook
- `total_errors`: The total number of errors encountered by the webhook
- `consecutive_errors`: The number of consecutive errors encountered by the webhook
- `last_error`: The last error encountered by the webhook

This request will return information about the specific webhook, such as the total number of calls made, the total number of errors, the number of consecutive errors, and the most recent error. This detailed insight can help identify recurring or critical issues that might be causing the webhook to fail.

## Unresolved issues

In some cases, the webhook may be in an Active state, without any errors, yet you suspect it's not delivering notifications as expected. If this happens, please let us know by sending an email to appdev at superoffice dot com. It could indicate a more complex issue requiring further investigation.

To summarize, troubleshooting webhooks requires understanding their current status and digging deeper into the error messages if necessary. Equipped with the right endpoints, you can systematically diagnose and resolve issues, ensuring the smooth operation of your application.

[1]: subscription.md#create-state-change-webhook

---
title: POST Agents/Webhook/DeleteWebhook
uid: v1WebhookAgent_DeleteWebhook
generated: true
content_type: reference
---

# POST Agents/Webhook/DeleteWebhook

```http
POST /api/v1/Agents/Webhook/DeleteWebhook
```

Deletes the Webhook


NsApiSlow threshold: 2000 ms.


## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| webhookId | int32 | **Required** The identity of the Webhook |

```http
POST /api/v1/Agents/Webhook/DeleteWebhook?webhookId=523
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/agent/request/v1WebhookAgent_DeleteWebhook.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1WebhookAgent_DeleteWebhook.md)]
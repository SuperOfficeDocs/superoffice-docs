---
title: POST Agents/Webhook/DeleteWebhook
id: v1WebhookAgent_DeleteWebhook
---

# POST Agents/Webhook/DeleteWebhook

```http
POST /api/v1/Agents/Webhook/DeleteWebhook
```

Deletes the Webhook



## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| WebhookId | int32 | **Required** The id of the Webhook to be deleted. |

```http
POST /api/v1/Agents/Webhook/DeleteWebhook?WebhookId=120
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |
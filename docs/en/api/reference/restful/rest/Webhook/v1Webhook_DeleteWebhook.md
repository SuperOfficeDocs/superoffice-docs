---
title: DEL Webhook/{id}
uid: v1Webhook_DeleteWebhook
generated: true
content_type: reference
---

# DEL Webhook/{id}

```http
DELETE /api/v1/Webhook/{id}
```

Deletes the Webhook


## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered. Calls the Webhook agent service DeleteWebhook.
NsApiSlow threshold: 2000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Webhook to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

Webhook deleted.

| Response | Description |
|----------------|-------------|
| 204 | Webhook deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1Webhook_DeleteWebhook.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1Webhook_DeleteWebhook.md)]
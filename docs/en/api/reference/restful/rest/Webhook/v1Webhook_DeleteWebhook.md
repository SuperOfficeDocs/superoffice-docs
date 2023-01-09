---
title: DEL Webhook/{id}
uid: v1Webhook_DeleteWebhook
---

# DEL Webhook/{id}

```http
DELETE /api/v1/Webhook/{id}
```

Deletes the Webhook


## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered. Calls the Webhook agent service DeleteWebhook.





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

### Response body: RecurrenceInfo


## Sample request

```http!
DELETE /api/v1/Webhook/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 204 Webhook deleted.
Content-Type: application/json; charset=utf-8

null
```
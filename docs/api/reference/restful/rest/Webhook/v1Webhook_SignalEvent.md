---
title: POST Webhook/{eventName}/{primaryKey}
id: v1Webhook_SignalEvent
---

# POST Webhook/{eventName}/{primaryKey}

```http
POST /api/v1/Webhook/{eventName}/{primaryKey}
```

Signal webhooks that an event has occurred.

All webhooks listening for the event will be notified.


## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.




| Path Part | Type | Description |
|-----------|------|-------------|
| eventName | string | Name of event to fire. 'entity.verb' For example: 'window.closed', 'button.clicked'. **Required** |
| primaryKey | int32 | (Optional) Id of entity that is firing event. Can be 0 if not used. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: data  

Event data. Not all the data values may be posted to the webhook, depending in webhook type: { 'windowName': 'foo', 'widgets': 123 } 



## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |
---
title: POST Agents/Pocket/SetPushNotificationTagsForUser
uid: v1PocketAgent_SetPushNotificationTagsForUser
generated: true
content_type: reference
---

# POST Agents/Pocket/SetPushNotificationTagsForUser

```http
POST /api/v1/Agents/Pocket/SetPushNotificationTagsForUser
```

Specify what kind of notification events a user should receive push notifications for.


This will update all registerred devices for this user.
NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Pocket/SetPushNotificationTagsForUser?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

AssociateId, Tags 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer |  |
| Tags | String |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/agent/request/v1PocketAgent_SetPushNotificationTagsForUser.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1PocketAgent_SetPushNotificationTagsForUser.md)]
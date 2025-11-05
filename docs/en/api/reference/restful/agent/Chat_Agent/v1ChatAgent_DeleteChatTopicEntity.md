---
title: POST Agents/Chat/DeleteChatTopicEntity
uid: v1ChatAgent_DeleteChatTopicEntity
generated: true
content_type: reference
---

# POST Agents/Chat/DeleteChatTopicEntity

```http
POST /api/v1/Agents/Chat/DeleteChatTopicEntity
```

Deletes the ChatTopicEntity


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| chatTopicEntityId | int32 | **Required** The identity of the ChatTopicEntity |

```http
POST /api/v1/Agents/Chat/DeleteChatTopicEntity?chatTopicEntityId=668
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

```http!
POST /api/v1/Agents/Chat/DeleteChatTopicEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
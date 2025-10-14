---
title: POST Agents/Configuration/DeleteDiaryViewEntity
uid: v1ConfigurationAgent_DeleteDiaryViewEntity
generated: true
content_type: reference
---

# POST Agents/Configuration/DeleteDiaryViewEntity

```http
POST /api/v1/Agents/Configuration/DeleteDiaryViewEntity
```

Deletes the DiaryViewEntity


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| diaryViewEntityId | int32 | **Required** The identity of the DiaryViewEntity |

```http
POST /api/v1/Agents/Configuration/DeleteDiaryViewEntity?diaryViewEntityId=553
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
POST /api/v1/Agents/Configuration/DeleteDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
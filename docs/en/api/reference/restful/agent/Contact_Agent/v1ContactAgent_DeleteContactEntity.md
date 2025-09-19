---
title: POST Agents/Contact/DeleteContactEntity
uid: v1ContactAgent_DeleteContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/DeleteContactEntity

```http
POST /api/v1/Agents/Contact/DeleteContactEntity
```

Deletes the ContactEntity.


This table supports Soft Delete; records will be marked as deleted and disappear from the GUI and API results, but will not be physically deleted by this (and any other) method.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The identity of the ContactEntity |

```http
POST /api/v1/Agents/Contact/DeleteContactEntity?contactEntityId=719
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
POST /api/v1/Agents/Contact/DeleteContactEntity
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
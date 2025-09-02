---
title: POST Agents/Person/DeletePersonEntity
uid: v1PersonAgent_DeletePersonEntity
generated: true
content_type: reference
---

# POST Agents/Person/DeletePersonEntity

```http
POST /api/v1/Agents/Person/DeletePersonEntity
```

Deletes the PersonEntity.


This table supports Soft Delete; records will be marked as deleted and disappear from the GUI and API results, but will not be physically deleted by this (and any other) method.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The identity of the PersonEntity |

```http
POST /api/v1/Agents/Person/DeletePersonEntity?personEntityId=993
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
POST /api/v1/Agents/Person/DeletePersonEntity
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
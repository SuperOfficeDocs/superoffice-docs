---
title: POST Agents/Person/DeletePersonEntity
uid: v1PersonAgent_DeletePersonEntity
generated: true
---

# POST Agents/Person/DeletePersonEntity

```http
POST /api/v1/Agents/Person/DeletePersonEntity
```

Deletes the PersonEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| PersonEntityId | int32 | **Required** The id of the PersonEntity to be deleted. |

```http
POST /api/v1/Agents/Person/DeletePersonEntity?PersonEntityId=819
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
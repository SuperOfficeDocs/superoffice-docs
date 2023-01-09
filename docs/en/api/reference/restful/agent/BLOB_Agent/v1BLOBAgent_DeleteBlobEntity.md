---
title: POST Agents/BLOB/DeleteBlobEntity
uid: v1BLOBAgent_DeleteBlobEntity
---

# POST Agents/BLOB/DeleteBlobEntity

```http
POST /api/v1/Agents/BLOB/DeleteBlobEntity
```

Deletes the BlobEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| BlobEntityId | int32 | **Required** The id of the BlobEntity to be deleted. |

```http
POST /api/v1/Agents/BLOB/DeleteBlobEntity?BlobEntityId=956
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

### Response body: TableRight


## Sample request

```http!
POST /api/v1/Agents/BLOB/DeleteBlobEntity
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
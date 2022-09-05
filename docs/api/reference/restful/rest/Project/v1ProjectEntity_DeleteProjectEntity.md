---
title: DEL Project/{id}
uid: v1ProjectEntity_DeleteProjectEntity
---

# DEL Project/{id}

```http
DELETE /api/v1/Project/{id}
```

Deletes the ProjectEntity


Calls the Project agent service DeleteProjectEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

ProjectEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | ProjectEntity deleted. |
| 412 | Delete aborted because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: 


## Sample request

```http!
DELETE /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 ProjectEntity deleted.
Content-Type: application/json; charset=utf-8

null
```
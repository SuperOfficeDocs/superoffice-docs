---
title: POST Project/{id}/MergeTo/{id}
uid: v1ProjectEntity_Merge
generated: true
---

# POST Project/{id}/MergeTo/{id}

```http
POST /api/v1/Project/{sourceProjectId}/MergeTo/{destinationProjectId}
```

Merge two projects into one, removing the source project in the process






| Path Part | Type | Description |
|-----------|------|-------------|
| sourceProjectId | int32 | Id of source project for merge. This project is removed after the merge is completed. **Required** |
| destinationProjectId | int32 | Id of destination project to merge to. This project is updated with info from the source. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| replaceEmptyFieldsOnDestination | bool |  Fill in empty fields on destination from source? |

```http
POST /api/v1/Project/{sourceProjectId}/MergeTo/{destinationProjectId}?replaceEmptyFieldsOnDestination=True
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
POST /api/v1/Project/{sourceProjectId}/MergeTo/{destinationProjectId}
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
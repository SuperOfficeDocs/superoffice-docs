---
title: DEL List/{udListDefinitionName}/Items/{id}
uid: v1ListItemEntity_DeleteFromListName
generated: true
---

# DEL List/{udListDefinitionName}/Items/{id}

```http
DELETE /api/v1/List/{udListDefinitionName}/Items/{id}
```

Delete a list item from the specified list defintion






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The identity of the list item to delete **Required** |
| udListDefinitionName | string | The name of the list definition, indicating which list to delete the items from. **Required** |



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
DELETE /api/v1/List/{udListDefinitionName}/Items/{id}
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
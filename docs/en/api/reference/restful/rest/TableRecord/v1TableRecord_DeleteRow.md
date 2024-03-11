---
title: DEL Table/{tableName}/{id}
uid: v1TableRecord_DeleteRow
generated: true
---

# DEL Table/{tableName}/{id}

```http
DELETE /api/v1/Table/{tableName}/{id}
```

Delete a row from a table






| Path Part | Type | Description |
|-----------|------|-------------|
| tableName | string | The name of the table to delete from; in the current release this must be an 'extratable'. Use the database name, on the form y_aTable **Required** |
| id | int32 | The id of the row to delete **Required** |



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
DELETE /api/v1/Table/{tableName}/{id}
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
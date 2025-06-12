---
title: PUT Table/{tableName}/{id}
uid: v1TableRecord_UpdateRow
generated: true
---

# PUT Table/{tableName}/{id}

```http
PUT /api/v1/Table/{tableName}/{id}
```

Update a row in a table






| Path Part | Type | Description |
|-----------|------|-------------|
| tableName | string | The name of the table to update; in the current release this must be an 'extratable'. Use the database name, on the form y_aTable **Required** |
| id | int32 | The id of the row to update **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: values 

A StringDictionary with the values to update. You do not need to specify all the values in the table. The omitted ones will remain unchanged 


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: TimeZoneData


## Sample request

```http!
PUT /api/v1/Table/{tableName}/{id}
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
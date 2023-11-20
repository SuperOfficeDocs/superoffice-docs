---
title: GET Table/{tableName}/{id}
uid: v1TableRecord_ReadRow
generated: true
---

# GET Table/{tableName}/{id}

```http
GET /api/v1/Table/{tableName}/{id}
```

Read a row from a table






| Path Part | Type | Description |
|-----------|------|-------------|
| tableName | string | The name of the table to fetch; in the current release this must be an 'extratable'. Use the database name, on the form y_aTable **Required** |
| id | int32 | The id of the row to fetch **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 404 | Not Found. |

### Response body: TableRecord

| Property Name | Type |  Description |
|----------------|------|--------------|
| Values | object | Values for the row, where the first string is the column name (e.g. x_number), and the second string is the value formatted as a DB-value, e.g. [I:42] |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Table/{tableName}/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Values": {
    "Values1": "sunt",
    "Values2": "natus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 568
    }
  }
}
```
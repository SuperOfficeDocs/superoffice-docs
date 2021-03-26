---
title: GET Table/{tableName}/{id}
id: v1TableRecord_ReadRow
---

# GET Table/{tableName}/{id}

```http
GET /api/v1/Table/{tableName}/{id}
```

Read a row from a table



## Online Restricted: ## The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.




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


## Response: object

The extra table entity contains meta data for an extra table (not implemented yet)



Carrier object for TableRecord.
Services for the TableRecord Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDatabaseTableAgent">DatabaseTable Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Values | object | Values for the row, where the first string is the column name (e.g. x_number), and the second string is the value formatted as a DB-value, e.g. [I:42] |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Table/{tableName}/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Values": {
    "Values1": "error",
    "Values2": "quae"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 247
    }
  }
}
```
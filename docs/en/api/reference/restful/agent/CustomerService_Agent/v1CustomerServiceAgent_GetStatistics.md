---
title: POST Agents/CustomerService/GetStatistics
uid: v1CustomerServiceAgent_GetStatistics
generated: true
---

# POST Agents/CustomerService/GetStatistics

```http
POST /api/v1/Agents/CustomerService/GetStatistics
```

Returns the calculated results for the required statistics for the Customer Service Status Page







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetStatistics?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

Functions 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Functions | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Label | string | The label for the data set |
| Values | array | Values in this set |
| Description | string | Tooltip for data value |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/GetStatistics
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Functions": [
    "nostrum",
    "ad"
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Label": "et",
    "Values": [
      {
        "Label": "ab",
        "Value": 7305.3539999999994,
        "Description": "Triple-buffered foreground middleware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 163
          }
        }
      },
      {
        "Label": "ab",
        "Value": 7305.3539999999994,
        "Description": "Triple-buffered foreground middleware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 163
          }
        }
      }
    ],
    "Description": "Balanced demand-driven synergy",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 248
      }
    }
  },
  {
    "Label": "et",
    "Values": [
      {
        "Label": "ab",
        "Value": 7305.3539999999994,
        "Description": "Triple-buffered foreground middleware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 163
          }
        }
      },
      {
        "Label": "ab",
        "Value": 7305.3539999999994,
        "Description": "Triple-buffered foreground middleware",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 163
          }
        }
      }
    ],
    "Description": "Balanced demand-driven synergy",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 248
      }
    }
  }
]
```
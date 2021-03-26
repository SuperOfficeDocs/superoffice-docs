---
title: POST Agents/Import/PreviewImport
id: v1ImportAgent_PreviewImport
---

# POST Agents/Import/PreviewImport

```http
POST /api/v1/Agents/Import/PreviewImport
```

Preview the import







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Import/PreviewImport?$select=name,department,category/id
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

ImportLines, ColumnDefinition, Culture, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ImportLines | array |  |
| ColumnDefinition | array |  |
| Culture | string |  |
| Context | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Values | array | An array of the values that will be imported on the entity |
| Selected | bool | True if the entity shall be imported, false if the entity shall be ignored |
| Operation | string | Which operation will be used? This is a read-only property |
| Type | string | Which entity type will be created? This is a read-only property |
| ExternalKey | string | Optional external primary key for the row |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Import/PreviewImport
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ImportLines": [
    {
      "Values": [
        "ipsa",
        "quaerat"
      ],
      "Selected": false,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "cum"
    },
    {
      "Values": [
        "ipsa",
        "quaerat"
      ],
      "Selected": false,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "cum"
    }
  ],
  "ColumnDefinition": [
    "nesciunt",
    "veniam"
  ],
  "Culture": "soluta",
  "Context": "voluptas"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Values": [
      "aliquid",
      "nihil"
    ],
    "Selected": false,
    "Operation": "ContactAdded",
    "Type": "Contact",
    "ExternalKey": "consequatur",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "drive front-end supply-chains"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 322
      }
    }
  }
]
```
---
title: GetDeliveryTerms
id: v1ListAgent_GetDeliveryTerms
---

# GetDeliveryTerms

```http
POST /api/v1/Agents/List/GetDeliveryTerms
```

Returns all DeliveryTerms in SuperOffice db.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetDeliveryTerms?$select=name,department,category/id
```


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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The List Item Id |
| Value | string | The List Item Value |
| Tooltip | string | The List Item Tooltip |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/GetDeliveryTerms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 832,
    "Value": "consequatur",
    "Tooltip": "mollitia",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "extend cross-media synergies"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "visualize B2C technologies"
        },
        "FieldType": "System.String",
        "FieldLength": 993
      }
    }
  },
  {
    "Id": 832,
    "Value": "consequatur",
    "Tooltip": "mollitia",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "extend cross-media synergies"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "visualize B2C technologies"
        },
        "FieldType": "System.String",
        "FieldLength": 993
      }
    }
  }
]
```
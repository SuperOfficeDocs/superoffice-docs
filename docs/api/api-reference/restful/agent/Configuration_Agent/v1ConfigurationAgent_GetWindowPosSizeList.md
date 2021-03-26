---
title: POST Agents/Configuration/GetWindowPosSizeList
id: v1ConfigurationAgent_GetWindowPosSizeList
---

# POST Agents/Configuration/GetWindowPosSizeList

```http
POST /api/v1/Agents/Configuration/GetWindowPosSizeList
```

Gets an array of WindowPosSize objects.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetWindowPosSizeList?$select=name,department,category/id
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

## Request Body: windowPosSizeIds  

The primary keys. 



## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| OwnerWindow | string |  |
| PersonId | int32 |  |
| AssociateId | int32 |  |
| ExtraId | int32 |  |
| ExtraInfo | string |  |
| Height | int32 |  |
| LeftX | int32 |  |
| State | string |  |
| UpperY | int32 |  |
| Width | int32 |  |
| WindowPosSizeId | int32 |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Configuration/GetWindowPosSizeList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "OwnerWindow": "sit",
    "PersonId": 890,
    "AssociateId": 871,
    "ExtraId": 501,
    "ExtraInfo": "rerum",
    "Height": 314,
    "LeftX": 548,
    "State": "Maximized",
    "UpperY": 309,
    "Width": 635,
    "WindowPosSizeId": 917,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark back-end solutions"
        },
        "FieldType": "System.String",
        "FieldLength": 541
      }
    }
  }
]
```
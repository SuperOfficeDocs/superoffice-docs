---
title: POST Agents/Configuration/SaveWindowPosSizes
uid: v1ConfigurationAgent_SaveWindowPosSizes
generated: true
---

# POST Agents/Configuration/SaveWindowPosSizes

```http
POST /api/v1/Agents/Configuration/SaveWindowPosSizes
```

Saves a set of window and dialog position and size settings.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/SaveWindowPosSizes?$select=name,department,category/id
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

WindowPosSizes 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WindowPosSizes | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Configuration/SaveWindowPosSizes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WindowPosSizes": [
    {
      "OwnerWindow": "occaecati",
      "PersonId": 743,
      "AssociateId": 439,
      "ExtraId": 576,
      "ExtraInfo": "ut",
      "Height": 839,
      "LeftX": 781,
      "State": "Maximized",
      "UpperY": 785,
      "Width": 438,
      "WindowPosSizeId": 222
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "OwnerWindow": "fugit",
    "PersonId": 627,
    "AssociateId": 674,
    "ExtraId": 3,
    "ExtraInfo": "ut",
    "Height": 508,
    "LeftX": 142,
    "State": "Maximized",
    "UpperY": 610,
    "Width": 792,
    "WindowPosSizeId": 688,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 56
      }
    }
  }
]
```
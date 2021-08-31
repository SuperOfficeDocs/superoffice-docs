---
title: InitializeTimeZoneData
id: v1TimeZoneAgent_InitializeTimeZoneData
---

# InitializeTimeZoneData

```http
POST /api/v1/Agents/TimeZone/InitializeTimeZoneData
```

Initalizes the TimeZoneData







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/TimeZone/InitializeTimeZoneData?$select=name,department,category/id
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
| TZLocationID | int32 |  |
| Name | string |  |
| TZLocationCode | string |  |
| TZLocationCities | string |  |
| IsoNumber | int32 |  |
| TimeZoneSTDRules | object |  |
| TimeZoneDSTRules | object |  |

## Sample Request

```http!
POST /api/v1/Agents/TimeZone/InitializeTimeZoneData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TZLocationID": 245,
    "Name": "McDermott, Rolfson and Hilpert",
    "TZLocationCode": "sit",
    "TZLocationCities": "omnis",
    "IsoNumber": 115,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 736,
        "StartMonth": 771,
        "EndDay": 895,
        "EndMonth": 613,
        "TZOffset": 475,
        "StartRulePattern": "omnis",
        "EndRulePattern": "et"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 537,
        "StartMonth": 173,
        "EndDay": 608,
        "EndMonth": 943,
        "TZOffset": 364,
        "StartRulePattern": "facilis",
        "EndRulePattern": "quo"
      }
    }
  }
]
```
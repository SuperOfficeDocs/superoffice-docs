---
title: POST Agents/TimeZone/InitializeTimeZoneData
uid: v1TimeZoneAgent_InitializeTimeZoneData
generated: true
---

# POST Agents/TimeZone/InitializeTimeZoneData

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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| TZLocationID | int32 | Timezone location ID - primary key. |
| Name | string | Name associated with the location: Country name + region name, Norway, United States - Alaska |
| TZLocationCode | string | Code associated with location: UTC, AR-NQ, AU-QLD, PF2A Not the an ISO country code. Unique. |
| TZLocationCities | string | Cities associated with location: Oslo, London, Rio de Janeiro |
| IsoNumber | int32 | Country ISO code associated with location: 578 |
| TimeZoneSTDRules | object | Dictionary of standard rules |
| TimeZoneDSTRules | object | Dictionary of Daylight saving time rules |

## Sample request

```http!
POST /api/v1/Agents/TimeZone/InitializeTimeZoneData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TZLocationID": 884,
    "Name": "Lebsack, Larson and Gleason",
    "TZLocationCode": "iste",
    "TZLocationCities": "voluptatem",
    "IsoNumber": 906,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 535,
        "StartMonth": 970,
        "EndDay": 501,
        "EndMonth": 557,
        "TZOffset": 701,
        "StartRulePattern": "dolorem",
        "EndRulePattern": "similique"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 44,
        "StartMonth": 168,
        "EndDay": 887,
        "EndMonth": 941,
        "TZOffset": 847,
        "StartRulePattern": "aut",
        "EndRulePattern": "vel"
      }
    }
  }
]
```
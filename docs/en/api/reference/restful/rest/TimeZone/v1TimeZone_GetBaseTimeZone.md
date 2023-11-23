---
title: GET TimeZone/base
uid: v1TimeZone_GetBaseTimeZone
generated: true
---

# GET TimeZone/base

```http
GET /api/v1/TimeZone/base
```

Base Time Zone info.


This is the time zone used internally for storing data.







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

### Response body: TimeZoneData

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
GET /api/v1/TimeZone/base
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TZLocationID": 538,
  "Name": "Stehr, Schmeler and Paucek",
  "TZLocationCode": "repellendus",
  "TZLocationCities": "dolor",
  "IsoNumber": 712,
  "TimeZoneSTDRules": {
    "fieldName": {
      "StartDay": 175,
      "StartMonth": 924,
      "EndDay": 524,
      "EndMonth": 609,
      "TZOffset": 494,
      "StartRulePattern": "et",
      "EndRulePattern": "deleniti"
    }
  },
  "TimeZoneDSTRules": {
    "fieldName": {
      "StartDay": 477,
      "StartMonth": 748,
      "EndDay": 505,
      "EndMonth": 679,
      "TZOffset": 823,
      "StartRulePattern": "minus",
      "EndRulePattern": "laboriosam"
    }
  }
}
```
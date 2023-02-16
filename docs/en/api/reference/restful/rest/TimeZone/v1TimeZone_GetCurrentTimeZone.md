---
title: GET TimeZone/current
uid: v1TimeZone_GetCurrentTimeZone
---

# GET TimeZone/current

```http
GET /api/v1/TimeZone/current
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

### Response body: RecurrenceInfo

| Property Name | Type |  Description |
|----------------|------|--------------|
| TZLocationID | int32 |  |
| Name | string |  |
| TZLocationCode | string |  |
| TZLocationCities | string |  |
| IsoNumber | int32 |  |
| TimeZoneSTDRules | object |  |
| TimeZoneDSTRules | object |  |

## Sample request

```http!
GET /api/v1/TimeZone/current
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TZLocationID": 880,
  "Name": "Dietrich, Friesen and Gaylord",
  "TZLocationCode": "iusto",
  "TZLocationCities": "ipsum",
  "IsoNumber": 6,
  "TimeZoneSTDRules": {
    "fieldName": {
      "StartDay": 677,
      "StartMonth": 64,
      "EndDay": 1000,
      "EndMonth": 931,
      "TZOffset": 798,
      "StartRulePattern": "optio",
      "EndRulePattern": "numquam"
    }
  },
  "TimeZoneDSTRules": {
    "fieldName": {
      "StartDay": 485,
      "StartMonth": 51,
      "EndDay": 591,
      "EndMonth": 54,
      "TZOffset": 632,
      "StartRulePattern": "eaque",
      "EndRulePattern": "porro"
    }
  }
}
```
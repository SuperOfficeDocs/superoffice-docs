```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TZLocationID": 85,
    "Name": "Central European Time",
    "TZLocationCode": "Europe/Oslo",
    "TZLocationCities": "Oslo, Stockholm, Copenhagen, Berlin, Paris",
    "IsoNumber": 578,
    "TimeZoneSTDRules": {
      "fieldName": {
        "StartDay": 1,
        "StartMonth": 1,
        "EndDay": 31,
        "EndMonth": 12,
        "TZOffset": 60,
        "StartRulePattern": "StandardTime",
        "EndRulePattern": "StandardTime"
      }
    },
    "TimeZoneDSTRules": {
      "fieldName": {
        "StartDay": 25,
        "StartMonth": 3,
        "EndDay": 29,
        "EndMonth": 10,
        "TZOffset": 120,
        "StartRulePattern": "LastSundayInMarch",
        "EndRulePattern": "LastSundayInOctober"
      }
    }
  }
]
```

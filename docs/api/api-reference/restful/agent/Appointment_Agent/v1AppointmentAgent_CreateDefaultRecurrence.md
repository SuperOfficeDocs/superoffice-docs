---
title: POST Agents/Appointment/CreateDefaultRecurrence
id: v1AppointmentAgent_CreateDefaultRecurrence
---

# POST Agents/Appointment/CreateDefaultRecurrence

```http
POST /api/v1/Agents/Appointment/CreateDefaultRecurrence
```

Creates a RecurrenceInfo object populated with the default values for the specific type.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultRecurrence?$select=name,department,category/id
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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| RecurrenceId | int32 |  |
| StartDate | date-time |  |
| EndDate | date-time |  |
| RecurrenceCounter | int32 |  |
| RecurrenceEndType | string |  |
| Pattern | string |  |
| DayPattern |  |  |
| WeekPattern |  |  |
| MonthPattern |  |  |
| YearPattern |  |  |
| Dates | array |  |
| IsRecurrence | bool |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/CreateDefaultRecurrence
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RecurrenceId": 515,
  "StartDate": "2021-03-02T18:28:48.0578499+01:00",
  "EndDate": "2014-01-09T18:28:48.0578499+01:00",
  "RecurrenceCounter": 707,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": {
    "Pattern": "EveryCyclicDay",
    "Cycle": 206
  },
  "WeekPattern": {
    "Weekdays": "Friday",
    "Cycle": 77
  },
  "MonthPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 671,
    "Day": 371,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "YearPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 961,
    "Day": 929,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "Dates": [
    {
      "Date": "2010-07-27T18:28:48.0578499+02:00",
      "IsConflict": true,
      "Description": "Quality-focused multi-tasking superstructure",
      "DescriptionStyleHint": "Upgradable maximized infrastructure",
      "Tooltip": "non"
    },
    {
      "Date": "2010-07-27T18:28:48.0578499+02:00",
      "IsConflict": true,
      "Description": "Quality-focused multi-tasking superstructure",
      "DescriptionStyleHint": "Upgradable maximized infrastructure",
      "Tooltip": "non"
    }
  ],
  "IsRecurrence": false
}
```
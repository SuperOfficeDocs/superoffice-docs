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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RecurrenceId": 397,
  "StartDate": "2008-11-04T16:48:28.5844487+01:00",
  "EndDate": "2007-09-18T16:48:28.5844487+02:00",
  "RecurrenceCounter": 240,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": {
    "Pattern": "EveryCyclicDay",
    "Cycle": 491
  },
  "WeekPattern": {
    "Weekdays": "Friday",
    "Cycle": 526
  },
  "MonthPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 353,
    "Day": 567,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "YearPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 747,
    "Day": 97,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "Dates": [
    {
      "Date": "2004-02-21T16:48:28.5844487+01:00",
      "IsConflict": true,
      "Description": "Reduced local groupware",
      "DescriptionStyleHint": "Centralized cohesive capability",
      "Tooltip": "cupiditate"
    },
    {
      "Date": "2004-02-21T16:48:28.5844487+01:00",
      "IsConflict": true,
      "Description": "Reduced local groupware",
      "DescriptionStyleHint": "Centralized cohesive capability",
      "Tooltip": "cupiditate"
    }
  ],
  "IsRecurrence": true
}
```
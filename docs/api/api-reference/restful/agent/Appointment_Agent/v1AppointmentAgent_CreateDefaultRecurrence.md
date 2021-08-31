---
title: CreateDefaultRecurrence
id: v1AppointmentAgent_CreateDefaultRecurrence
---

# CreateDefaultRecurrence

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
  "RecurrenceId": 724,
  "StartDate": "2017-05-30T14:58:03.2025678+02:00",
  "EndDate": "1999-01-26T14:58:03.2025678+01:00",
  "RecurrenceCounter": 817,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": {
    "Pattern": "EveryCyclicDay",
    "Cycle": 769
  },
  "WeekPattern": {
    "Weekdays": "Friday",
    "Cycle": 453
  },
  "MonthPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 311,
    "Day": 552,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "YearPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 144,
    "Day": 607,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "Dates": [
    {
      "Date": "2021-01-28T14:58:03.2025678+01:00",
      "IsConflict": false,
      "Description": "User-friendly maximized flexibility",
      "DescriptionStyleHint": "Decentralized homogeneous focus group",
      "Tooltip": "ipsa"
    },
    {
      "Date": "2021-01-28T14:58:03.2025678+01:00",
      "IsConflict": false,
      "Description": "User-friendly maximized flexibility",
      "DescriptionStyleHint": "Decentralized homogeneous focus group",
      "Tooltip": "ipsa"
    }
  ],
  "IsRecurrence": false
}
```
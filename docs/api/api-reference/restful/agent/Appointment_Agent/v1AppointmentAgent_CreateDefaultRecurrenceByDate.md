---
title: CreateDefaultRecurrenceByDate
id: v1AppointmentAgent_CreateDefaultRecurrenceByDate
---

# CreateDefaultRecurrenceByDate

```http
POST /api/v1/Agents/Appointment/CreateDefaultRecurrenceByDate
```

Creates a RecurrenceInfo object populated with the default values for the specific type.

Using startDate as start date for the recurreing pattern.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultRecurrenceByDate?$select=name,department,category/id
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

StartDate 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StartDate | date-time |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultRecurrenceByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StartDate": "2019-06-06T14:58:02.9475409+02:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RecurrenceId": 401,
  "StartDate": "2014-01-22T14:58:02.9485416+01:00",
  "EndDate": "2000-11-09T14:58:02.9485416+01:00",
  "RecurrenceCounter": 48,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": {
    "Pattern": "EveryCyclicDay",
    "Cycle": 838
  },
  "WeekPattern": {
    "Weekdays": "Friday",
    "Cycle": 7
  },
  "MonthPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 136,
    "Day": 247,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "YearPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 473,
    "Day": 744,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "Dates": [
    {
      "Date": "2017-04-12T14:58:02.9485416+02:00",
      "IsConflict": true,
      "Description": "Optional web-enabled website",
      "DescriptionStyleHint": "Open-source 6th generation secured line",
      "Tooltip": "est"
    },
    {
      "Date": "2017-04-12T14:58:02.9485416+02:00",
      "IsConflict": true,
      "Description": "Optional web-enabled website",
      "DescriptionStyleHint": "Open-source 6th generation secured line",
      "Tooltip": "est"
    }
  ],
  "IsRecurrence": true
}
```
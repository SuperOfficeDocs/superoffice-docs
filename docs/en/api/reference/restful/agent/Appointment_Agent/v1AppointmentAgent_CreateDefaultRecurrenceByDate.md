---
title: POST Agents/Appointment/CreateDefaultRecurrenceByDate
uid: v1AppointmentAgent_CreateDefaultRecurrenceByDate
generated: true
---

# POST Agents/Appointment/CreateDefaultRecurrenceByDate

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
| StartDate | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RecurrenceInfo

| Property Name | Type |  Description |
|----------------|------|--------------|
| RecurrenceId | int32 | The recurrence rule id |
| StartDate | date-time | Start date of the repetition pattern |
| EndDate | date-time | End date of the repetition pattern Only used when the end is calculated from a end date. {SuperOffice.Data.RecurrenceEndType.EndDate} |
| RecurrenceCounter | int32 | Number of recurrences Only used when the end is calculated from a number of repetitions. {SuperOffice.Data.RecurrenceEndType.Counter} |
| RecurrenceEndType | string | Type defining how the end of the recurrence sequence should be calculated |
| Pattern | string | The recurrence pattern (Daily, Weekly, Monthly, Yearly, Custom) |
| DayPattern | RecurrenceDayPattern | Pattern describing a daily recurrence Only set when the recurrence pattern i daily. {SuperOffice.Data.RecurrencePattern.Daily} |
| WeekPattern | RecurrenceWeekPattern | Pattern describing a daily recurrence Only set when the recurrence pattern i weekly. {SuperOffice.Data.RecurrencePattern.Weekly} |
| MonthPattern | RecurrenceMonthPattern | Pattern describing a daily recurrence Only set when the recurrence pattern i monthly. {SuperOffice.Data.RecurrencePattern.Monthly} |
| YearPattern | RecurrenceYearPattern | Pattern describing a daily recurrence Only set when the recurrence pattern i yearly. {SuperOffice.Data.RecurrencePattern.Yearly} |
| Dates | array | List of all dates where this recurrence occurs |
| IsRecurrence | bool | Get a or set IsRecurrence, indicating if this is a repeating appointment or not. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/CreateDefaultRecurrenceByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StartDate": "2019-11-26T03:45:22.8892174+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RecurrenceId": 566,
  "StartDate": "2020-02-19T03:45:22.8892174+01:00",
  "EndDate": "2006-12-06T03:45:22.8892174+01:00",
  "RecurrenceCounter": 222,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": null,
  "WeekPattern": null,
  "MonthPattern": null,
  "YearPattern": null,
  "Dates": [
    {
      "Date": "2010-12-15T03:45:22.8892174+01:00",
      "IsConflict": false,
      "Description": "Cloned human-resource model",
      "DescriptionStyleHint": "Centralized static installation",
      "Tooltip": "velit"
    },
    {
      "Date": "2010-12-15T03:45:22.8892174+01:00",
      "IsConflict": false,
      "Description": "Cloned human-resource model",
      "DescriptionStyleHint": "Centralized static installation",
      "Tooltip": "velit"
    }
  ],
  "IsRecurrence": true
}
```
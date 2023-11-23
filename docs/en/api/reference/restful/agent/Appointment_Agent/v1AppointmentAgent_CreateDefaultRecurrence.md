---
title: POST Agents/Appointment/CreateDefaultRecurrence
uid: v1AppointmentAgent_CreateDefaultRecurrence
generated: true
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
POST /api/v1/Agents/Appointment/CreateDefaultRecurrence
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RecurrenceId": 357,
  "StartDate": "2011-06-01T13:38:12.9521841+02:00",
  "EndDate": "2022-02-12T13:38:12.9521841+01:00",
  "RecurrenceCounter": 892,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": null,
  "WeekPattern": null,
  "MonthPattern": null,
  "YearPattern": null,
  "Dates": [
    {
      "Date": "1999-04-28T13:38:12.9521841+02:00",
      "IsConflict": false,
      "Description": "Decentralized bandwidth-monitored parallelism",
      "DescriptionStyleHint": "Operative radical support",
      "Tooltip": "consequatur"
    },
    {
      "Date": "1999-04-28T13:38:12.9521841+02:00",
      "IsConflict": false,
      "Description": "Decentralized bandwidth-monitored parallelism",
      "DescriptionStyleHint": "Operative radical support",
      "Tooltip": "consequatur"
    }
  ],
  "IsRecurrence": false
}
```
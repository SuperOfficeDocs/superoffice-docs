---
title: POST Agents/Appointment/CreateDefaultRecurrenceByDate
uid: v1AppointmentAgent_CreateDefaultRecurrenceByDate
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

### Response body: TableRight

| Property Name | Type |  Description |
|----------------|------|--------------|
| RecurrenceId | int32 |  |
| StartDate | date-time |  |
| EndDate | date-time |  |
| RecurrenceCounter | int32 |  |
| RecurrenceEndType | string |  |
| Pattern | string |  |
| DayPattern | TableRight |  |
| WeekPattern | TableRight |  |
| MonthPattern | TableRight |  |
| YearPattern | TableRight |  |
| Dates | array |  |
| IsRecurrence | bool |  |

## Sample request

```http!
POST /api/v1/Agents/Appointment/CreateDefaultRecurrenceByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartDate": "2004-09-28T14:19:02.6177097+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RecurrenceId": 335,
  "StartDate": "2007-11-04T14:19:02.6177097+01:00",
  "EndDate": "1999-01-25T14:19:02.6177097+01:00",
  "RecurrenceCounter": 844,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": null,
  "WeekPattern": null,
  "MonthPattern": null,
  "YearPattern": null,
  "Dates": [
    {
      "Date": "1999-12-12T14:19:02.6177097+01:00",
      "IsConflict": true,
      "Description": "Object-based upward-trending function",
      "DescriptionStyleHint": "Front-line neutral contingency",
      "Tooltip": "ipsa"
    },
    {
      "Date": "1999-12-12T14:19:02.6177097+01:00",
      "IsConflict": true,
      "Description": "Object-based upward-trending function",
      "DescriptionStyleHint": "Front-line neutral contingency",
      "Tooltip": "ipsa"
    }
  ],
  "IsRecurrence": true
}
```
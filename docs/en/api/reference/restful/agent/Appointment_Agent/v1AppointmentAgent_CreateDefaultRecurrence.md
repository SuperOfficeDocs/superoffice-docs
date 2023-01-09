---
title: POST Agents/Appointment/CreateDefaultRecurrence
uid: v1AppointmentAgent_CreateDefaultRecurrence
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
  "RecurrenceId": 918,
  "StartDate": "1998-01-20T17:37:16.4172411+01:00",
  "EndDate": "2001-05-25T17:37:16.4172411+02:00",
  "RecurrenceCounter": 167,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": null,
  "WeekPattern": null,
  "MonthPattern": null,
  "YearPattern": null,
  "Dates": [
    {
      "Date": "1998-09-23T17:37:16.4172411+02:00",
      "IsConflict": false,
      "Description": "User-centric secondary implementation",
      "DescriptionStyleHint": "Phased solution-oriented methodology",
      "Tooltip": "reprehenderit"
    },
    {
      "Date": "1998-09-23T17:37:16.4172411+02:00",
      "IsConflict": false,
      "Description": "User-centric secondary implementation",
      "DescriptionStyleHint": "Phased solution-oriented methodology",
      "Tooltip": "reprehenderit"
    }
  ],
  "IsRecurrence": true
}
```
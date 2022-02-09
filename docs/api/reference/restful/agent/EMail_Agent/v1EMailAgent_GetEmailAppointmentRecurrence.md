---
title: POST Agents/EMail/GetEmailAppointmentRecurrence
id: v1EMailAgent_GetEmailAppointmentRecurrence
---

# POST Agents/EMail/GetEmailAppointmentRecurrence

```http
POST /api/v1/Agents/EMail/GetEmailAppointmentRecurrence
```

Get recurrence data contained in the email iCal attachment



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEmailAppointmentRecurrence?$select=name,department,category/id
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

MailItemId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MailItemId | int32 |  |


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
POST /api/v1/Agents/EMail/GetEmailAppointmentRecurrence
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MailItemId": 466
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RecurrenceId": 879,
  "StartDate": "1999-07-02T18:28:49.0139564+02:00",
  "EndDate": "2018-03-12T18:28:49.0139564+01:00",
  "RecurrenceCounter": 539,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": {
    "Pattern": "EveryCyclicDay",
    "Cycle": 846
  },
  "WeekPattern": {
    "Weekdays": "Friday",
    "Cycle": 225
  },
  "MonthPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 917,
    "Day": 952,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "YearPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 128,
    "Day": 311,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "Dates": [
    {
      "Date": "2003-04-10T18:28:49.0139564+02:00",
      "IsConflict": true,
      "Description": "Operative composite help-desk",
      "DescriptionStyleHint": "Phased demand-driven frame",
      "Tooltip": "saepe"
    },
    {
      "Date": "2003-04-10T18:28:49.0139564+02:00",
      "IsConflict": true,
      "Description": "Operative composite help-desk",
      "DescriptionStyleHint": "Phased demand-driven frame",
      "Tooltip": "saepe"
    }
  ],
  "IsRecurrence": false
}
```
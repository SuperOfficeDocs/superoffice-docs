---
title: GET List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_GetTicketPriorityEntity
generated: true
---

# GET List/TicketPriority/Items/{id}

```http
GET /api/v1/List/TicketPriority/Items/{id}
```

Gets a TicketPriorityEntity list item.


Calls the List agent service GetTicketPriorityEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketPriority to return. **Required** |



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
| 404 | Not Found. |

### Response body: TicketPriorityEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | int32 | The primary key (auto-incremented) |
| Name | string | The name of the priority. |
| Status | string | The status (normal/deleted) of the priority. |
| Flags | string | A bitmask of flags. |
| SortOrder | int32 | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | string | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | string | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | string | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | string | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | string | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | string | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | int32 | Deadline to add if escalated (minutes) |
| MonStart | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | date-time | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | date-time | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | date-time | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | date-time | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | date-time | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | date-time | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | date-time | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | date-time | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | date-time | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | date-time | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | date-time | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | date-time | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime. Exception - it IS possible to include a year here, for dates that should not repeat every year |
| EscalationLevels | array | Escalation levels bound to the parent priority |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 734,
  "Name": "Spencer-Romaguera",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 977,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 95,
  "MonStart": "2011-01-05T14:13:50.3064464+01:00",
  "MonStop": "2005-10-22T14:13:50.3064464+02:00",
  "TueStart": "2001-06-29T14:13:50.3064464+02:00",
  "TueStop": "2002-06-26T14:13:50.3064464+02:00",
  "WedStart": "2021-09-06T14:13:50.3064464+02:00",
  "WedStop": "2015-07-25T14:13:50.3064464+02:00",
  "ThuStart": "2018-06-19T14:13:50.3064464+02:00",
  "ThuStop": "2011-08-18T14:13:50.3064464+02:00",
  "FriStart": "2003-11-19T14:13:50.3064464+01:00",
  "FriStop": "2021-03-05T14:13:50.3064464+01:00",
  "SatStart": "2000-09-08T14:13:50.3064464+02:00",
  "SatStop": "2016-04-25T14:13:50.3064464+02:00",
  "SunStart": "1998-05-27T14:13:50.3064464+02:00",
  "SunStop": "2009-06-05T14:13:50.3064464+02:00",
  "NonDates": [
    "sapiente",
    "doloremque"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 319,
      "AlertLevel": 482,
      "AlertTimeout": 593,
      "Action": 860,
      "DelegateTo": 236,
      "ScriptId": 79,
      "EmailTo": "lisette@torphy.com",
      "SmsTo": "veritatis",
      "ReplyTemplateIdCustomer": 867,
      "ReplyTemplateIdUser": 659,
      "ReplyTemplateIdCatmast": 876,
      "ReplyTemplateIdEmail": 521,
      "RtiCustomerSms": 128,
      "ReplyTemplateIdUserSms": 338,
      "ReplyTemplateIdCatmastSms": 956,
      "ReplyTemplateIdSms": 164,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 225
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 484
    }
  }
}
```
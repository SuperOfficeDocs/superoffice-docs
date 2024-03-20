---
title: POST Agents/List/CreateDefaultTicketPriorityEntity
uid: v1ListAgent_CreateDefaultTicketPriorityEntity
generated: true
---

# POST Agents/List/CreateDefaultTicketPriorityEntity

```http
POST /api/v1/Agents/List/CreateDefaultTicketPriorityEntity
```

Set default values into a new TicketPriorityEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/List/CreateDefaultTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 427,
  "Name": "Bergstrom, Zieme and Bogan",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 866,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 445,
  "MonStart": "2017-04-20T12:19:45.5703411+02:00",
  "MonStop": "2017-08-11T12:19:45.5703411+02:00",
  "TueStart": "1998-10-15T12:19:45.5703411+02:00",
  "TueStop": "2018-01-25T12:19:45.5703411+01:00",
  "WedStart": "2007-08-01T12:19:45.5703411+02:00",
  "WedStop": "2000-05-03T12:19:45.5703411+02:00",
  "ThuStart": "2017-04-16T12:19:45.5703411+02:00",
  "ThuStop": "2000-12-19T12:19:45.5703411+01:00",
  "FriStart": "2006-02-08T12:19:45.5703411+01:00",
  "FriStop": "2008-01-11T12:19:45.5703411+01:00",
  "SatStart": "2010-08-15T12:19:45.5703411+02:00",
  "SatStop": "2001-01-23T12:19:45.5703411+01:00",
  "SunStart": "2017-03-09T12:19:45.5703411+01:00",
  "SunStop": "2002-04-16T12:19:45.5703411+02:00",
  "NonDates": [
    "odit",
    "fugiat"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 202,
      "AlertLevel": 229,
      "AlertTimeout": 895,
      "Action": 182,
      "DelegateTo": 572,
      "ScriptId": 948,
      "EmailTo": "henderson_koelpin@smitham.name",
      "SmsTo": "esse",
      "ReplyTemplateIdCustomer": 350,
      "ReplyTemplateIdUser": 396,
      "ReplyTemplateIdCatmast": 11,
      "ReplyTemplateIdEmail": 665,
      "RtiCustomerSms": 179,
      "ReplyTemplateIdUserSms": 760,
      "ReplyTemplateIdCatmastSms": 393,
      "ReplyTemplateIdSms": 294,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 208
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 168
    }
  }
}
```
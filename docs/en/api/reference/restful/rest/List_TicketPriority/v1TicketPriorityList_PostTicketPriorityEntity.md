---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
generated: true
---

# POST List/TicketPriority/Items

```http
POST /api/v1/List/TicketPriority/Items
```

Create a new TicketPriorityEntity list item


Calls the List agent service SaveTicketPriorityEntity.







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

## Request Body: newEntity 

The TicketPriorityEntity to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | Integer | The primary key (auto-incremented) |
| Name | String | The name of the priority. |
| Status | String | The status (normal/deleted) of the priority. |
| Flags | String | A bitmask of flags. |
| SortOrder | Integer | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | String | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | String | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | String | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | String | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | String | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | String | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | Integer | Deadline to add if escalated (minutes) |
| MonStart | String | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | String | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | String | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | String | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | String | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | String | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | String | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | String | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | String | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | String | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | String | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | String | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | String | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | String | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | Array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime. Exception - it IS possible to include a year here, for dates that should not repeat every year |
| EscalationLevels | Array | Escalation levels bound to the parent priority |

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
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 143,
  "Name": "Ullrich-Lakin",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 841,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 993,
  "MonStart": "2023-05-12T14:32:12.9741031+02:00",
  "MonStop": "2017-07-23T14:32:12.9741031+02:00",
  "TueStart": "2002-07-06T14:32:12.9741031+02:00",
  "TueStop": "2017-07-29T14:32:12.9741031+02:00",
  "WedStart": "1998-06-30T14:32:12.9741031+02:00",
  "WedStop": "1998-04-19T14:32:12.9741031+02:00",
  "ThuStart": "2011-10-30T14:32:12.9741031+01:00",
  "ThuStop": "2011-04-03T14:32:12.9741031+02:00",
  "FriStart": "2007-06-29T14:32:12.9741031+02:00",
  "FriStop": "2021-09-29T14:32:12.9741031+02:00",
  "SatStart": "2019-04-04T14:32:12.9741031+02:00",
  "SatStop": "2020-12-24T14:32:12.9741031+01:00",
  "SunStart": "2012-03-13T14:32:12.9741031+01:00",
  "SunStop": "2015-06-14T14:32:12.9741031+02:00",
  "NonDates": [
    "nesciunt",
    "possimus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 638,
      "AlertLevel": 340,
      "AlertTimeout": 661,
      "Action": 160,
      "DelegateTo": 597,
      "ScriptId": 317,
      "EmailTo": "emilie@hodkiewicz.co.uk",
      "SmsTo": "modi",
      "ReplyTemplateIdCustomer": 515,
      "ReplyTemplateIdUser": 76,
      "ReplyTemplateIdCatmast": 968,
      "ReplyTemplateIdEmail": 913,
      "RtiCustomerSms": 552,
      "ReplyTemplateIdUserSms": 686,
      "ReplyTemplateIdCatmastSms": 453,
      "ReplyTemplateIdSms": 283
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 404,
  "Name": "Jacobs, O'Kon and Metz",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 151,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 477,
  "MonStart": "2022-03-15T14:32:12.9741031+01:00",
  "MonStop": "2013-09-01T14:32:12.9741031+02:00",
  "TueStart": "2018-03-20T14:32:12.9741031+01:00",
  "TueStop": "2018-01-21T14:32:12.9741031+01:00",
  "WedStart": "2004-08-03T14:32:12.9741031+02:00",
  "WedStop": "2007-06-14T14:32:12.9741031+02:00",
  "ThuStart": "2000-05-19T14:32:12.9741031+02:00",
  "ThuStop": "2012-04-12T14:32:12.9741031+02:00",
  "FriStart": "2021-09-24T14:32:12.9741031+02:00",
  "FriStop": "2002-04-19T14:32:12.9741031+02:00",
  "SatStart": "2006-01-16T14:32:12.9741031+01:00",
  "SatStop": "2010-01-08T14:32:12.9741031+01:00",
  "SunStart": "2024-04-22T14:32:12.9741031+02:00",
  "SunStop": "2021-12-10T14:32:12.9741031+01:00",
  "NonDates": [
    "provident",
    "eos"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 629,
      "AlertLevel": 558,
      "AlertTimeout": 233,
      "Action": 947,
      "DelegateTo": 264,
      "ScriptId": 161,
      "EmailTo": "al@schimmel.info",
      "SmsTo": "debitis",
      "ReplyTemplateIdCustomer": 614,
      "ReplyTemplateIdUser": 681,
      "ReplyTemplateIdCatmast": 808,
      "ReplyTemplateIdEmail": 711,
      "RtiCustomerSms": 151,
      "ReplyTemplateIdUserSms": 700,
      "ReplyTemplateIdCatmastSms": 420,
      "ReplyTemplateIdSms": 261,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 472
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 878
    }
  }
}
```
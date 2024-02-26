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
  "TicketPriorityId": 138,
  "Name": "Wyman, Dicki and Kuhn",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 437,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 953,
  "MonStart": "2001-11-29T10:30:33.2897031+01:00",
  "MonStop": "2021-09-09T10:30:33.2897031+02:00",
  "TueStart": "2008-06-12T10:30:33.2897031+02:00",
  "TueStop": "2006-11-15T10:30:33.2897031+01:00",
  "WedStart": "1997-08-05T10:30:33.2897031+02:00",
  "WedStop": "2011-07-09T10:30:33.2897031+02:00",
  "ThuStart": "2014-01-28T10:30:33.2897031+01:00",
  "ThuStop": "2014-06-11T10:30:33.2897031+02:00",
  "FriStart": "1998-03-17T10:30:33.2897031+01:00",
  "FriStop": "2018-11-26T10:30:33.2897031+01:00",
  "SatStart": "2011-11-19T10:30:33.2897031+01:00",
  "SatStop": "2022-02-01T10:30:33.2897031+01:00",
  "SunStart": "2016-10-09T10:30:33.2897031+02:00",
  "SunStop": "2008-06-19T10:30:33.2897031+02:00",
  "NonDates": [
    "sed",
    "rem"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 954,
      "AlertLevel": 761,
      "AlertTimeout": 687,
      "Action": 978,
      "DelegateTo": 150,
      "ScriptId": 77,
      "EmailTo": "mandy.von@russel.biz",
      "SmsTo": "suscipit",
      "ReplyTemplateIdCustomer": 608,
      "ReplyTemplateIdUser": 964,
      "ReplyTemplateIdCatmast": 941,
      "ReplyTemplateIdEmail": 252,
      "RtiCustomerSms": 416,
      "ReplyTemplateIdUserSms": 390,
      "ReplyTemplateIdCatmastSms": 306,
      "ReplyTemplateIdSms": 685
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 944,
  "Name": "Schmidt-Parisian",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 27,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 480,
  "MonStart": "2020-07-17T10:30:33.2897031+02:00",
  "MonStop": "2005-03-20T10:30:33.2897031+01:00",
  "TueStart": "2017-08-27T10:30:33.2897031+02:00",
  "TueStop": "1997-09-06T10:30:33.2897031+02:00",
  "WedStart": "2001-07-30T10:30:33.2897031+02:00",
  "WedStop": "2001-04-20T10:30:33.2897031+02:00",
  "ThuStart": "2019-10-17T10:30:33.2897031+02:00",
  "ThuStop": "1997-02-08T10:30:33.2897031+01:00",
  "FriStart": "2019-01-10T10:30:33.2897031+01:00",
  "FriStop": "2003-12-08T10:30:33.2897031+01:00",
  "SatStart": "2016-04-10T10:30:33.2897031+02:00",
  "SatStop": "2004-09-26T10:30:33.2897031+02:00",
  "SunStart": "2015-02-02T10:30:33.2897031+01:00",
  "SunStop": "2002-11-26T10:30:33.2897031+01:00",
  "NonDates": [
    "eos",
    "qui"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 677,
      "AlertLevel": 844,
      "AlertTimeout": 92,
      "Action": 106,
      "DelegateTo": 767,
      "ScriptId": 221,
      "EmailTo": "jared.boyer@gaylord.ca",
      "SmsTo": "voluptatem",
      "ReplyTemplateIdCustomer": 98,
      "ReplyTemplateIdUser": 938,
      "ReplyTemplateIdCatmast": 677,
      "ReplyTemplateIdEmail": 605,
      "RtiCustomerSms": 679,
      "ReplyTemplateIdUserSms": 823,
      "ReplyTemplateIdCatmastSms": 239,
      "ReplyTemplateIdSms": 13,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 327
    }
  }
}
```
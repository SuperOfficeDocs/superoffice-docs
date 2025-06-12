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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 292,
  "Name": "Tromp Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 672,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 70,
  "MonStart": "2003-08-20T17:54:09.148042+02:00",
  "MonStop": "2023-03-10T17:54:09.148042+01:00",
  "TueStart": "2004-05-14T17:54:09.148042+02:00",
  "TueStop": "2005-06-25T17:54:09.148042+02:00",
  "WedStart": "2015-08-06T17:54:09.148042+02:00",
  "WedStop": "2009-08-20T17:54:09.148042+02:00",
  "ThuStart": "2012-10-28T17:54:09.148042+01:00",
  "ThuStop": "2011-03-07T17:54:09.148042+01:00",
  "FriStart": "2013-02-08T17:54:09.148042+01:00",
  "FriStop": "2006-11-26T17:54:09.148042+01:00",
  "SatStart": "2004-07-26T17:54:09.148042+02:00",
  "SatStop": "2002-03-03T17:54:09.148042+01:00",
  "SunStart": "2024-03-31T17:54:09.148042+02:00",
  "SunStop": "2021-07-27T17:54:09.148042+02:00",
  "NonDates": [
    "laboriosam",
    "eum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 687,
      "AlertLevel": 594,
      "AlertTimeout": 125,
      "Action": 686,
      "DelegateTo": 321,
      "ScriptId": 12,
      "EmailTo": "meredith.haag@breitenberg.info",
      "SmsTo": "quo",
      "ReplyTemplateIdCustomer": 887,
      "ReplyTemplateIdUser": 579,
      "ReplyTemplateIdCatmast": 284,
      "ReplyTemplateIdEmail": 555,
      "RtiCustomerSms": 545,
      "ReplyTemplateIdUserSms": 757,
      "ReplyTemplateIdCatmastSms": 445,
      "ReplyTemplateIdSms": 250
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 538,
  "Name": "Pacocha, Grant and Daugherty",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 139,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 730,
  "MonStart": "2001-05-29T17:54:09.148042+02:00",
  "MonStop": "2005-05-21T17:54:09.148042+02:00",
  "TueStart": "2010-02-16T17:54:09.148042+01:00",
  "TueStop": "2007-08-20T17:54:09.148042+02:00",
  "WedStart": "2019-03-23T17:54:09.148042+01:00",
  "WedStop": "2021-05-02T17:54:09.148042+02:00",
  "ThuStart": "1998-05-10T17:54:09.148042+02:00",
  "ThuStop": "2019-10-14T17:54:09.148042+02:00",
  "FriStart": "2006-07-10T17:54:09.148042+02:00",
  "FriStop": "2013-12-22T17:54:09.148042+01:00",
  "SatStart": "2013-12-03T17:54:09.148042+01:00",
  "SatStop": "2005-01-08T17:54:09.148042+01:00",
  "SunStart": "2016-04-15T17:54:09.148042+02:00",
  "SunStop": "2012-10-07T17:54:09.148042+02:00",
  "NonDates": [
    "quaerat",
    "pariatur"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 669,
      "AlertLevel": 389,
      "AlertTimeout": 287,
      "Action": 544,
      "DelegateTo": 623,
      "ScriptId": 790,
      "EmailTo": "maude_waelchi@bechtelar.ca",
      "SmsTo": "dolorem",
      "ReplyTemplateIdCustomer": 550,
      "ReplyTemplateIdUser": 588,
      "ReplyTemplateIdCatmast": 831,
      "ReplyTemplateIdEmail": 560,
      "RtiCustomerSms": 637,
      "ReplyTemplateIdUserSms": 993,
      "ReplyTemplateIdCatmastSms": 900,
      "ReplyTemplateIdSms": 880,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 15
    }
  }
}
```
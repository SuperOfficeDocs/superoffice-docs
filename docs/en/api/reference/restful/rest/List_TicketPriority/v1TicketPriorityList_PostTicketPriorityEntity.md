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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 800,
  "Name": "Beatty Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 810,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 617,
  "MonStart": "1999-04-22T04:22:36.2528386+02:00",
  "MonStop": "2010-12-13T04:22:36.2528386+01:00",
  "TueStart": "1997-07-03T04:22:36.2528386+02:00",
  "TueStop": "2016-04-25T04:22:36.2528386+02:00",
  "WedStart": "2006-09-19T04:22:36.2528386+02:00",
  "WedStop": "2005-02-27T04:22:36.2528386+01:00",
  "ThuStart": "2015-11-07T04:22:36.2528386+01:00",
  "ThuStop": "2017-02-11T04:22:36.2528386+01:00",
  "FriStart": "2017-01-18T04:22:36.2528386+01:00",
  "FriStop": "2003-07-03T04:22:36.2528386+02:00",
  "SatStart": "2016-08-24T04:22:36.2528386+02:00",
  "SatStop": "2022-06-15T04:22:36.2528386+02:00",
  "SunStart": "2018-04-14T04:22:36.2528386+02:00",
  "SunStop": "2024-04-13T04:22:36.2528386+02:00",
  "NonDates": [
    "veniam",
    "ex"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 588,
      "AlertLevel": 671,
      "AlertTimeout": 465,
      "Action": 761,
      "DelegateTo": 743,
      "ScriptId": 307,
      "EmailTo": "hailie.mann@wiegand.com",
      "SmsTo": "deserunt",
      "ReplyTemplateIdCustomer": 852,
      "ReplyTemplateIdUser": 155,
      "ReplyTemplateIdCatmast": 345,
      "ReplyTemplateIdEmail": 751,
      "RtiCustomerSms": 509,
      "ReplyTemplateIdUserSms": 222,
      "ReplyTemplateIdCatmastSms": 125,
      "ReplyTemplateIdSms": 426
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 237,
  "Name": "Connelly-Farrell",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 540,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 231,
  "MonStart": "2023-02-24T04:22:36.2528386+01:00",
  "MonStop": "2009-08-11T04:22:36.2528386+02:00",
  "TueStart": "1998-11-23T04:22:36.2528386+01:00",
  "TueStop": "2005-05-04T04:22:36.2528386+02:00",
  "WedStart": "2014-11-24T04:22:36.2528386+01:00",
  "WedStop": "2016-02-23T04:22:36.2528386+01:00",
  "ThuStart": "2020-03-03T04:22:36.2528386+01:00",
  "ThuStop": "2021-07-09T04:22:36.2528386+02:00",
  "FriStart": "2022-03-06T04:22:36.2528386+01:00",
  "FriStop": "2015-11-09T04:22:36.2528386+01:00",
  "SatStart": "2006-09-04T04:22:36.2528386+02:00",
  "SatStop": "2006-11-24T04:22:36.2528386+01:00",
  "SunStart": "2023-02-02T04:22:36.2528386+01:00",
  "SunStop": "2018-03-01T04:22:36.2528386+01:00",
  "NonDates": [
    "ut",
    "quo"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 229,
      "AlertLevel": 193,
      "AlertTimeout": 518,
      "Action": 491,
      "DelegateTo": 542,
      "ScriptId": 101,
      "EmailTo": "ralph@bogan.uk",
      "SmsTo": "molestias",
      "ReplyTemplateIdCustomer": 723,
      "ReplyTemplateIdUser": 887,
      "ReplyTemplateIdCatmast": 530,
      "ReplyTemplateIdEmail": 194,
      "RtiCustomerSms": 929,
      "ReplyTemplateIdUserSms": 164,
      "ReplyTemplateIdCatmastSms": 606,
      "ReplyTemplateIdSms": 501,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 329
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 246
    }
  }
}
```
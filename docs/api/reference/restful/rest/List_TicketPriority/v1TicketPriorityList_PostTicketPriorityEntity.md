---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 652,
  "Name": "Beatty-Walsh",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 611,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 69,
  "MonStart": "1999-03-26T11:10:54.6829307+01:00",
  "MonStop": "2017-12-06T11:10:54.6829307+01:00",
  "TueStart": "2001-12-05T11:10:54.6829307+01:00",
  "TueStop": "2005-12-26T11:10:54.6829307+01:00",
  "WedStart": "2022-03-27T11:10:54.6829307+02:00",
  "WedStop": "2021-02-05T11:10:54.6829307+01:00",
  "ThuStart": "2004-04-17T11:10:54.6829307+02:00",
  "ThuStop": "2007-05-22T11:10:54.6829307+02:00",
  "FriStart": "1997-06-27T11:10:54.6829307+02:00",
  "FriStop": "2016-05-06T11:10:54.6829307+02:00",
  "SatStart": "2008-05-21T11:10:54.6829307+02:00",
  "SatStop": "2001-05-29T11:10:54.6829307+02:00",
  "SunStart": "2017-09-30T11:10:54.6829307+02:00",
  "SunStop": "2012-12-11T11:10:54.6829307+01:00",
  "NonDates": [
    "voluptatibus",
    "adipisci"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 636,
      "AlertLevel": 394,
      "AlertTimeout": 611,
      "Action": 880,
      "DelegateTo": 372,
      "ScriptId": 881,
      "EmailTo": "julian@treutel.uk",
      "SmsTo": "praesentium",
      "ReplyTemplateIdCustomer": 512,
      "ReplyTemplateIdUser": 238,
      "ReplyTemplateIdCatmast": 713,
      "ReplyTemplateIdEmail": 653,
      "RtiCustomerSms": 546,
      "ReplyTemplateIdUserSms": 981,
      "ReplyTemplateIdCatmastSms": 260,
      "ReplyTemplateIdSms": 816
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 921,
  "Name": "Erdman, Krajcik and Lind",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 702,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 950,
  "MonStart": "2009-06-19T11:10:54.6839295+02:00",
  "MonStop": "1998-02-04T11:10:54.6839295+01:00",
  "TueStart": "2017-03-17T11:10:54.6839295+01:00",
  "TueStop": "2016-05-15T11:10:54.6839295+02:00",
  "WedStart": "2005-06-09T11:10:54.6839295+02:00",
  "WedStop": "2020-04-14T11:10:54.6839295+02:00",
  "ThuStart": "2008-03-27T11:10:54.6839295+01:00",
  "ThuStop": "2002-05-14T11:10:54.6839295+02:00",
  "FriStart": "2015-07-02T11:10:54.6839295+02:00",
  "FriStop": "1997-08-20T11:10:54.6839295+02:00",
  "SatStart": "2011-02-16T11:10:54.6839295+01:00",
  "SatStop": "2005-11-12T11:10:54.6839295+01:00",
  "SunStart": "2009-06-11T11:10:54.6839295+02:00",
  "SunStop": "2017-02-16T11:10:54.6839295+01:00",
  "NonDates": [
    "maiores",
    "sapiente"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 137,
      "AlertLevel": 879,
      "AlertTimeout": 120,
      "Action": 27,
      "DelegateTo": 670,
      "ScriptId": 760,
      "EmailTo": "araceli_hermiston@morar.name",
      "SmsTo": "ut",
      "ReplyTemplateIdCustomer": 403,
      "ReplyTemplateIdUser": 175,
      "ReplyTemplateIdCatmast": 159,
      "ReplyTemplateIdEmail": 971,
      "RtiCustomerSms": 602,
      "ReplyTemplateIdUserSms": 733,
      "ReplyTemplateIdCatmastSms": 739,
      "ReplyTemplateIdSms": 835,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 21
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 81
    }
  }
}
```

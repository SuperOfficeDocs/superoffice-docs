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
  "TicketPriorityId": 183,
  "Name": "Bechtelar-Homenick",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 35,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 331,
  "MonStart": "2019-01-22T13:13:33.6828687+01:00",
  "MonStop": "2005-03-16T13:13:33.6828687+01:00",
  "TueStart": "2020-08-02T13:13:33.6828687+02:00",
  "TueStop": "2024-06-10T13:13:33.6828687+02:00",
  "WedStart": "2007-06-22T13:13:33.6828687+02:00",
  "WedStop": "2024-02-27T13:13:33.6828687+01:00",
  "ThuStart": "2010-12-02T13:13:33.6828687+01:00",
  "ThuStop": "2013-02-03T13:13:33.6828687+01:00",
  "FriStart": "2022-11-10T13:13:33.6828687+01:00",
  "FriStop": "2009-01-15T13:13:33.6828687+01:00",
  "SatStart": "2019-05-22T13:13:33.6828687+02:00",
  "SatStop": "2000-03-01T13:13:33.6828687+01:00",
  "SunStart": "2016-06-30T13:13:33.6828687+02:00",
  "SunStop": "2003-10-01T13:13:33.6828687+02:00",
  "NonDates": [
    "fuga",
    "quod"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 888,
      "AlertLevel": 314,
      "AlertTimeout": 448,
      "Action": 682,
      "DelegateTo": 62,
      "ScriptId": 244,
      "EmailTo": "mckenzie_bergnaum@wittingstiedemann.biz",
      "SmsTo": "sunt",
      "ReplyTemplateIdCustomer": 93,
      "ReplyTemplateIdUser": 691,
      "ReplyTemplateIdCatmast": 725,
      "ReplyTemplateIdEmail": 631,
      "RtiCustomerSms": 885,
      "ReplyTemplateIdUserSms": 107,
      "ReplyTemplateIdCatmastSms": 633,
      "ReplyTemplateIdSms": 502
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 645,
  "Name": "Rogahn LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 702,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 264,
  "MonStart": "2017-12-30T13:13:33.6828687+01:00",
  "MonStop": "2018-02-12T13:13:33.6828687+01:00",
  "TueStart": "2016-12-18T13:13:33.6828687+01:00",
  "TueStop": "2006-12-12T13:13:33.6828687+01:00",
  "WedStart": "2007-10-27T13:13:33.6828687+02:00",
  "WedStop": "2002-04-26T13:13:33.6828687+02:00",
  "ThuStart": "2002-06-28T13:13:33.6828687+02:00",
  "ThuStop": "2004-02-18T13:13:33.6828687+01:00",
  "FriStart": "2008-11-06T13:13:33.6828687+01:00",
  "FriStop": "2011-09-23T13:13:33.6828687+02:00",
  "SatStart": "2017-03-13T13:13:33.6828687+01:00",
  "SatStop": "2015-05-09T13:13:33.6828687+02:00",
  "SunStart": "2005-02-13T13:13:33.6828687+01:00",
  "SunStop": "2001-01-30T13:13:33.6828687+01:00",
  "NonDates": [
    "quia",
    "suscipit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 240,
      "AlertLevel": 134,
      "AlertTimeout": 600,
      "Action": 403,
      "DelegateTo": 538,
      "ScriptId": 237,
      "EmailTo": "emmy.kris@bartell.info",
      "SmsTo": "blanditiis",
      "ReplyTemplateIdCustomer": 953,
      "ReplyTemplateIdUser": 28,
      "ReplyTemplateIdCatmast": 329,
      "ReplyTemplateIdEmail": 178,
      "RtiCustomerSms": 971,
      "ReplyTemplateIdUserSms": 757,
      "ReplyTemplateIdCatmastSms": 552,
      "ReplyTemplateIdSms": 122,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 422
    }
  }
}
```
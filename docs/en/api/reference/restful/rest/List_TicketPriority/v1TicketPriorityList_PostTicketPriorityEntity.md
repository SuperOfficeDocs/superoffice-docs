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
  "TicketPriorityId": 128,
  "Name": "Schoen-Swaniawski",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 298,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 908,
  "MonStart": "2009-03-25T03:45:29.2484114+01:00",
  "MonStop": "2017-04-02T03:45:29.2484114+02:00",
  "TueStart": "2017-07-09T03:45:29.2484114+02:00",
  "TueStop": "2024-12-17T03:45:29.2484114+01:00",
  "WedStart": "2021-12-23T03:45:29.2484114+01:00",
  "WedStop": "1999-11-15T03:45:29.2484114+01:00",
  "ThuStart": "2014-09-21T03:45:29.2484114+02:00",
  "ThuStop": "2014-07-04T03:45:29.2484114+02:00",
  "FriStart": "2022-06-14T03:45:29.2484114+02:00",
  "FriStop": "2014-05-22T03:45:29.2484114+02:00",
  "SatStart": "2003-04-27T03:45:29.2484114+02:00",
  "SatStop": "2013-05-15T03:45:29.2484114+02:00",
  "SunStart": "2007-02-09T03:45:29.2484114+01:00",
  "SunStop": "2013-06-13T03:45:29.2484114+02:00",
  "NonDates": [
    "corrupti",
    "quaerat"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 91,
      "AlertLevel": 801,
      "AlertTimeout": 936,
      "Action": 667,
      "DelegateTo": 834,
      "ScriptId": 612,
      "EmailTo": "tate@oconnell.uk",
      "SmsTo": "vel",
      "ReplyTemplateIdCustomer": 604,
      "ReplyTemplateIdUser": 768,
      "ReplyTemplateIdCatmast": 770,
      "ReplyTemplateIdEmail": 920,
      "RtiCustomerSms": 550,
      "ReplyTemplateIdUserSms": 214,
      "ReplyTemplateIdCatmastSms": 324,
      "ReplyTemplateIdSms": 400
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 46,
  "Name": "Weissnat LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 185,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 930,
  "MonStart": "1999-10-17T03:45:29.2484114+02:00",
  "MonStop": "2012-03-11T03:45:29.2484114+01:00",
  "TueStart": "2003-05-06T03:45:29.2484114+02:00",
  "TueStop": "2007-02-18T03:45:29.2484114+01:00",
  "WedStart": "2024-04-15T03:45:29.2484114+02:00",
  "WedStop": "1998-05-18T03:45:29.2484114+02:00",
  "ThuStart": "2010-06-22T03:45:29.2484114+02:00",
  "ThuStop": "2011-03-13T03:45:29.2484114+01:00",
  "FriStart": "2011-06-19T03:45:29.2484114+02:00",
  "FriStop": "2019-09-11T03:45:29.2484114+02:00",
  "SatStart": "2002-06-28T03:45:29.2484114+02:00",
  "SatStop": "2003-12-02T03:45:29.2484114+01:00",
  "SunStart": "2021-12-15T03:45:29.2484114+01:00",
  "SunStop": "2016-11-16T03:45:29.2484114+01:00",
  "NonDates": [
    "deserunt",
    "rerum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 455,
      "AlertLevel": 897,
      "AlertTimeout": 634,
      "Action": 73,
      "DelegateTo": 191,
      "ScriptId": 914,
      "EmailTo": "ferne.kuvalis@weimann.co.uk",
      "SmsTo": "provident",
      "ReplyTemplateIdCustomer": 62,
      "ReplyTemplateIdUser": 701,
      "ReplyTemplateIdCatmast": 932,
      "ReplyTemplateIdEmail": 355,
      "RtiCustomerSms": 29,
      "ReplyTemplateIdUserSms": 682,
      "ReplyTemplateIdCatmastSms": 527,
      "ReplyTemplateIdSms": 690,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 196
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 237
    }
  }
}
```
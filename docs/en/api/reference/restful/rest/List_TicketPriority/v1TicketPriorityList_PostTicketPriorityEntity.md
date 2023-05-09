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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 967,
  "Name": "Nicolas-Mueller",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 595,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 284,
  "MonStart": "1998-05-04T03:51:35.0051461+02:00",
  "MonStop": "2013-04-19T03:51:35.0051461+02:00",
  "TueStart": "2006-01-07T03:51:35.0051461+01:00",
  "TueStop": "2011-09-27T03:51:35.0051461+02:00",
  "WedStart": "2006-06-21T03:51:35.0051461+02:00",
  "WedStop": "2010-10-11T03:51:35.0051461+02:00",
  "ThuStart": "1997-05-25T03:51:35.0051461+02:00",
  "ThuStop": "2022-02-04T03:51:35.0051461+01:00",
  "FriStart": "2016-02-02T03:51:35.0051461+01:00",
  "FriStop": "2017-11-10T03:51:35.0051461+01:00",
  "SatStart": "2020-01-23T03:51:35.0051461+01:00",
  "SatStop": "1999-11-16T03:51:35.0051461+01:00",
  "SunStart": "2001-11-15T03:51:35.0051461+01:00",
  "SunStop": "2014-12-09T03:51:35.0051461+01:00",
  "NonDates": [
    "officiis",
    "reprehenderit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 870,
      "AlertLevel": 349,
      "AlertTimeout": 677,
      "Action": 303,
      "DelegateTo": 419,
      "ScriptId": 897,
      "EmailTo": "velva@gleichner.info",
      "SmsTo": "delectus",
      "ReplyTemplateIdCustomer": 720,
      "ReplyTemplateIdUser": 310,
      "ReplyTemplateIdCatmast": 786,
      "ReplyTemplateIdEmail": 358,
      "RtiCustomerSms": 464,
      "ReplyTemplateIdUserSms": 403,
      "ReplyTemplateIdCatmastSms": 101,
      "ReplyTemplateIdSms": 907
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 173,
  "Name": "Russel, Ritchie and Dooley",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 787,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 476,
  "MonStart": "2020-07-15T03:51:35.0051461+02:00",
  "MonStop": "1997-09-14T03:51:35.0051461+02:00",
  "TueStart": "2012-01-11T03:51:35.0051461+01:00",
  "TueStop": "2019-08-17T03:51:35.0051461+02:00",
  "WedStart": "2009-06-25T03:51:35.0051461+02:00",
  "WedStop": "1996-11-23T03:51:35.0051461+01:00",
  "ThuStart": "2020-11-07T03:51:35.0051461+01:00",
  "ThuStop": "2009-01-10T03:51:35.0051461+01:00",
  "FriStart": "2021-11-13T03:51:35.0051461+01:00",
  "FriStop": "2014-01-05T03:51:35.0051461+01:00",
  "SatStart": "2019-04-12T03:51:35.0051461+02:00",
  "SatStop": "2023-04-27T03:51:35.0051461+02:00",
  "SunStart": "2008-12-13T03:51:35.0051461+01:00",
  "SunStop": "2010-08-28T03:51:35.0051461+02:00",
  "NonDates": [
    "laudantium",
    "earum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 616,
      "AlertLevel": 591,
      "AlertTimeout": 162,
      "Action": 983,
      "DelegateTo": 199,
      "ScriptId": 250,
      "EmailTo": "gabe@kertzmannlueilwitz.name",
      "SmsTo": "molestiae",
      "ReplyTemplateIdCustomer": 283,
      "ReplyTemplateIdUser": 520,
      "ReplyTemplateIdCatmast": 919,
      "ReplyTemplateIdEmail": 116,
      "RtiCustomerSms": 359,
      "ReplyTemplateIdUserSms": 374,
      "ReplyTemplateIdCatmastSms": 104,
      "ReplyTemplateIdSms": 896,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 869
    }
  }
}
```
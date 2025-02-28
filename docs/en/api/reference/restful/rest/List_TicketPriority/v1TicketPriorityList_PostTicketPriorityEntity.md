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
  "TicketPriorityId": 239,
  "Name": "Kirlin-O'Reilly",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 754,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 923,
  "MonStart": "2007-01-11T12:01:33.6832402+01:00",
  "MonStop": "2012-03-17T12:01:33.6832402+01:00",
  "TueStart": "2006-10-14T12:01:33.6832402+02:00",
  "TueStop": "2024-11-09T12:01:33.6832402+01:00",
  "WedStart": "2019-08-21T12:01:33.6832402+02:00",
  "WedStop": "2000-08-01T12:01:33.6832402+02:00",
  "ThuStart": "2021-10-04T12:01:33.6832402+02:00",
  "ThuStop": "2016-11-23T12:01:33.6832402+01:00",
  "FriStart": "2009-05-26T12:01:33.6832402+02:00",
  "FriStop": "2019-07-09T12:01:33.6832402+02:00",
  "SatStart": "2023-02-26T12:01:33.6832402+01:00",
  "SatStop": "1998-03-08T12:01:33.6832402+01:00",
  "SunStart": "2005-11-14T12:01:33.6832402+01:00",
  "SunStop": "2021-05-04T12:01:33.6832402+02:00",
  "NonDates": [
    "sint",
    "laudantium"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 925,
      "AlertLevel": 374,
      "AlertTimeout": 126,
      "Action": 228,
      "DelegateTo": 92,
      "ScriptId": 906,
      "EmailTo": "elise_kub@schultz.name",
      "SmsTo": "praesentium",
      "ReplyTemplateIdCustomer": 228,
      "ReplyTemplateIdUser": 572,
      "ReplyTemplateIdCatmast": 649,
      "ReplyTemplateIdEmail": 168,
      "RtiCustomerSms": 782,
      "ReplyTemplateIdUserSms": 937,
      "ReplyTemplateIdCatmastSms": 729,
      "ReplyTemplateIdSms": 538
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 241,
  "Name": "Kutch, Doyle and Brekke",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 287,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 279,
  "MonStart": "1998-08-23T12:01:33.6832402+02:00",
  "MonStop": "2023-08-15T12:01:33.6832402+02:00",
  "TueStart": "2021-08-09T12:01:33.6832402+02:00",
  "TueStop": "2003-05-21T12:01:33.6832402+02:00",
  "WedStart": "2014-07-22T12:01:33.6832402+02:00",
  "WedStop": "2014-11-20T12:01:33.6832402+01:00",
  "ThuStart": "2015-01-03T12:01:33.6832402+01:00",
  "ThuStop": "2005-09-28T12:01:33.6832402+02:00",
  "FriStart": "2019-10-09T12:01:33.6832402+02:00",
  "FriStop": "2012-03-09T12:01:33.6832402+01:00",
  "SatStart": "2020-04-22T12:01:33.6832402+02:00",
  "SatStop": "1997-12-06T12:01:33.6832402+01:00",
  "SunStart": "2014-07-16T12:01:33.6832402+02:00",
  "SunStop": "2010-01-21T12:01:33.6832402+01:00",
  "NonDates": [
    "omnis",
    "sit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 627,
      "AlertLevel": 765,
      "AlertTimeout": 918,
      "Action": 272,
      "DelegateTo": 904,
      "ScriptId": 736,
      "EmailTo": "leanne@heidenreichpowlowski.biz",
      "SmsTo": "cupiditate",
      "ReplyTemplateIdCustomer": 99,
      "ReplyTemplateIdUser": 163,
      "ReplyTemplateIdCatmast": 276,
      "ReplyTemplateIdEmail": 66,
      "RtiCustomerSms": 703,
      "ReplyTemplateIdUserSms": 737,
      "ReplyTemplateIdCatmastSms": 881,
      "ReplyTemplateIdSms": 823,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 965
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 68
    }
  }
}
```
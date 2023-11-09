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
  "TicketPriorityId": 592,
  "Name": "Lind-Hills",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 727,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 185,
  "MonStart": "2011-10-20T11:06:43.1159494+02:00",
  "MonStop": "2017-02-05T11:06:43.1159494+01:00",
  "TueStart": "2013-09-05T11:06:43.1159494+02:00",
  "TueStop": "2018-03-09T11:06:43.1159494+01:00",
  "WedStart": "2013-10-24T11:06:43.1159494+02:00",
  "WedStop": "2000-02-02T11:06:43.1159494+01:00",
  "ThuStart": "2003-05-10T11:06:43.1159494+02:00",
  "ThuStop": "2018-07-13T11:06:43.1159494+02:00",
  "FriStart": "1999-11-01T11:06:43.1159494+01:00",
  "FriStop": "2009-09-28T11:06:43.1159494+02:00",
  "SatStart": "2000-08-08T11:06:43.1159494+02:00",
  "SatStop": "2007-09-07T11:06:43.1159494+02:00",
  "SunStart": "2009-03-08T11:06:43.1159494+01:00",
  "SunStop": "2013-04-12T11:06:43.1159494+02:00",
  "NonDates": [
    "voluptate",
    "ullam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 429,
      "AlertLevel": 955,
      "AlertTimeout": 952,
      "Action": 776,
      "DelegateTo": 482,
      "ScriptId": 571,
      "EmailTo": "shirley_wolf@hesselhettinger.name",
      "SmsTo": "fugiat",
      "ReplyTemplateIdCustomer": 174,
      "ReplyTemplateIdUser": 204,
      "ReplyTemplateIdCatmast": 556,
      "ReplyTemplateIdEmail": 170,
      "RtiCustomerSms": 977,
      "ReplyTemplateIdUserSms": 288,
      "ReplyTemplateIdCatmastSms": 939,
      "ReplyTemplateIdSms": 180
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 420,
  "Name": "Jones-Veum",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 275,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 896,
  "MonStart": "2013-06-09T11:06:43.1159494+02:00",
  "MonStop": "2017-11-11T11:06:43.1159494+01:00",
  "TueStart": "2009-11-22T11:06:43.1159494+01:00",
  "TueStop": "2008-11-18T11:06:43.1159494+01:00",
  "WedStart": "2021-01-15T11:06:43.1159494+01:00",
  "WedStop": "2006-06-30T11:06:43.1159494+02:00",
  "ThuStart": "2000-12-24T11:06:43.1159494+01:00",
  "ThuStop": "2013-03-12T11:06:43.1159494+01:00",
  "FriStart": "2015-03-07T11:06:43.1159494+01:00",
  "FriStop": "2003-06-18T11:06:43.1159494+02:00",
  "SatStart": "2013-06-26T11:06:43.1159494+02:00",
  "SatStop": "2009-06-12T11:06:43.1159494+02:00",
  "SunStart": "2010-10-10T11:06:43.1159494+02:00",
  "SunStop": "2018-05-25T11:06:43.1159494+02:00",
  "NonDates": [
    "quia",
    "facilis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 27,
      "AlertLevel": 894,
      "AlertTimeout": 363,
      "Action": 310,
      "DelegateTo": 172,
      "ScriptId": 912,
      "EmailTo": "darlene@bernhard.info",
      "SmsTo": "qui",
      "ReplyTemplateIdCustomer": 382,
      "ReplyTemplateIdUser": 227,
      "ReplyTemplateIdCatmast": 290,
      "ReplyTemplateIdEmail": 851,
      "RtiCustomerSms": 777,
      "ReplyTemplateIdUserSms": 761,
      "ReplyTemplateIdCatmastSms": 747,
      "ReplyTemplateIdSms": 713,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 14
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 524
    }
  }
}
```
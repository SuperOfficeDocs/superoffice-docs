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
  "TicketPriorityId": 838,
  "Name": "Kling LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 223,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 667,
  "MonStart": "2002-05-01T13:14:10.1191693+02:00",
  "MonStop": "2014-01-23T13:14:10.1191693+01:00",
  "TueStart": "2000-09-21T13:14:10.1191693+02:00",
  "TueStop": "2010-01-02T13:14:10.1191693+01:00",
  "WedStart": "2001-06-02T13:14:10.1191693+02:00",
  "WedStop": "1997-11-30T13:14:10.1191693+01:00",
  "ThuStart": "2011-09-10T13:14:10.1191693+02:00",
  "ThuStop": "2002-10-02T13:14:10.1191693+02:00",
  "FriStart": "2014-12-03T13:14:10.1191693+01:00",
  "FriStop": "2023-01-18T13:14:10.1191693+01:00",
  "SatStart": "2008-03-26T13:14:10.1191693+01:00",
  "SatStop": "2015-06-08T13:14:10.1191693+02:00",
  "SunStart": "2008-04-29T13:14:10.1191693+02:00",
  "SunStop": "2017-06-21T13:14:10.1191693+02:00",
  "NonDates": [
    "at",
    "quidem"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 932,
      "AlertLevel": 481,
      "AlertTimeout": 315,
      "Action": 653,
      "DelegateTo": 919,
      "ScriptId": 579,
      "EmailTo": "akeem_konopelski@maggiohyatt.co.uk",
      "SmsTo": "pariatur",
      "ReplyTemplateIdCustomer": 85,
      "ReplyTemplateIdUser": 698,
      "ReplyTemplateIdCatmast": 753,
      "ReplyTemplateIdEmail": 673,
      "RtiCustomerSms": 392,
      "ReplyTemplateIdUserSms": 714,
      "ReplyTemplateIdCatmastSms": 782,
      "ReplyTemplateIdSms": 48
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 623,
  "Name": "Stark, Zieme and Feeney",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 46,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 299,
  "MonStart": "2008-08-16T13:14:10.1191693+02:00",
  "MonStop": "2020-02-16T13:14:10.1191693+01:00",
  "TueStart": "2002-09-26T13:14:10.1191693+02:00",
  "TueStop": "2005-07-06T13:14:10.1191693+02:00",
  "WedStart": "2016-11-22T13:14:10.1191693+01:00",
  "WedStop": "2013-04-29T13:14:10.1191693+02:00",
  "ThuStart": "2004-02-13T13:14:10.1191693+01:00",
  "ThuStop": "2023-10-07T13:14:10.1191693+02:00",
  "FriStart": "2002-03-25T13:14:10.1191693+01:00",
  "FriStop": "2016-01-15T13:14:10.1191693+01:00",
  "SatStart": "2014-10-17T13:14:10.1191693+02:00",
  "SatStop": "1997-12-29T13:14:10.1191693+01:00",
  "SunStart": "2002-06-15T13:14:10.1191693+02:00",
  "SunStop": "2018-10-29T13:14:10.1191693+01:00",
  "NonDates": [
    "doloribus",
    "illum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 656,
      "AlertLevel": 268,
      "AlertTimeout": 331,
      "Action": 796,
      "DelegateTo": 990,
      "ScriptId": 377,
      "EmailTo": "heaven_oconnell@hauck.biz",
      "SmsTo": "ut",
      "ReplyTemplateIdCustomer": 102,
      "ReplyTemplateIdUser": 315,
      "ReplyTemplateIdCatmast": 733,
      "ReplyTemplateIdEmail": 670,
      "RtiCustomerSms": 840,
      "ReplyTemplateIdUserSms": 184,
      "ReplyTemplateIdCatmastSms": 112,
      "ReplyTemplateIdSms": 549,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 103
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 978
    }
  }
}
```
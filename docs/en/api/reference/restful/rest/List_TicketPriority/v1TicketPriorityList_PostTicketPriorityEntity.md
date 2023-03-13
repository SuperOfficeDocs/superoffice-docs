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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 737,
  "Name": "Gusikowski LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 384,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 334,
  "MonStart": "2002-01-21T14:19:11.660135+01:00",
  "MonStop": "2020-05-05T14:19:11.660135+02:00",
  "TueStart": "2000-07-20T14:19:11.660135+02:00",
  "TueStop": "2011-04-07T14:19:11.660135+02:00",
  "WedStart": "2015-09-24T14:19:11.660135+02:00",
  "WedStop": "1996-08-07T14:19:11.660135+02:00",
  "ThuStart": "1996-03-06T14:19:11.660135+01:00",
  "ThuStop": "2012-12-02T14:19:11.660135+01:00",
  "FriStart": "2013-10-13T14:19:11.660135+02:00",
  "FriStop": "2001-10-20T14:19:11.660135+02:00",
  "SatStart": "2000-04-13T14:19:11.660135+02:00",
  "SatStop": "2004-01-03T14:19:11.660135+01:00",
  "SunStart": "2005-11-05T14:19:11.660135+01:00",
  "SunStop": "2010-11-07T14:19:11.660135+01:00",
  "NonDates": [
    "earum",
    "sint"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 248,
      "AlertLevel": 708,
      "AlertTimeout": 701,
      "Action": 710,
      "DelegateTo": 985,
      "ScriptId": 759,
      "EmailTo": "alexandrea.schulist@willmsdoyle.biz",
      "SmsTo": "cumque",
      "ReplyTemplateIdCustomer": 654,
      "ReplyTemplateIdUser": 271,
      "ReplyTemplateIdCatmast": 916,
      "ReplyTemplateIdEmail": 965,
      "RtiCustomerSms": 717,
      "ReplyTemplateIdUserSms": 788,
      "ReplyTemplateIdCatmastSms": 562,
      "ReplyTemplateIdSms": 894
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 872,
  "Name": "Sporer, Doyle and Halvorson",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 993,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 337,
  "MonStart": "2007-09-23T14:19:11.660135+02:00",
  "MonStop": "2017-02-14T14:19:11.660135+01:00",
  "TueStart": "2018-01-22T14:19:11.660135+01:00",
  "TueStop": "1997-04-25T14:19:11.660135+02:00",
  "WedStart": "2003-12-05T14:19:11.660135+01:00",
  "WedStop": "2015-11-27T14:19:11.660135+01:00",
  "ThuStart": "2007-03-28T14:19:11.660135+02:00",
  "ThuStop": "2013-08-16T14:19:11.660135+02:00",
  "FriStart": "2001-03-19T14:19:11.660135+01:00",
  "FriStop": "1996-09-06T14:19:11.660135+02:00",
  "SatStart": "2017-04-02T14:19:11.660135+02:00",
  "SatStop": "1995-11-26T14:19:11.660135+01:00",
  "SunStart": "2012-12-03T14:19:11.660135+01:00",
  "SunStop": "2016-11-05T14:19:11.660135+01:00",
  "NonDates": [
    "minus",
    "explicabo"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 433,
      "AlertLevel": 15,
      "AlertTimeout": 649,
      "Action": 465,
      "DelegateTo": 754,
      "ScriptId": 28,
      "EmailTo": "ramona.pfeffer@pourosbarrows.co.uk",
      "SmsTo": "necessitatibus",
      "ReplyTemplateIdCustomer": 654,
      "ReplyTemplateIdUser": 356,
      "ReplyTemplateIdCatmast": 768,
      "ReplyTemplateIdEmail": 298,
      "RtiCustomerSms": 317,
      "ReplyTemplateIdUserSms": 746,
      "ReplyTemplateIdCatmastSms": 917,
      "ReplyTemplateIdSms": 491,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 142
    }
  }
}
```
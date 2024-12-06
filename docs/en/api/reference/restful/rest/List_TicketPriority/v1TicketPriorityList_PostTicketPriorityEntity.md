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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 859,
  "Name": "Satterfield LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 323,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 541,
  "MonStart": "2019-05-25T10:18:01.1918781+02:00",
  "MonStop": "2022-07-05T10:18:01.1918781+02:00",
  "TueStart": "2002-08-18T10:18:01.1918781+02:00",
  "TueStop": "2020-05-09T10:18:01.1918781+02:00",
  "WedStart": "2023-03-20T10:18:01.1918781+01:00",
  "WedStop": "2007-06-26T10:18:01.1918781+02:00",
  "ThuStart": "2010-02-28T10:18:01.1918781+01:00",
  "ThuStop": "2008-11-09T10:18:01.1918781+01:00",
  "FriStart": "2003-08-01T10:18:01.1918781+02:00",
  "FriStop": "2017-01-23T10:18:01.1918781+01:00",
  "SatStart": "2005-02-14T10:18:01.1918781+01:00",
  "SatStop": "2022-01-17T10:18:01.1918781+01:00",
  "SunStart": "2003-06-17T10:18:01.1918781+02:00",
  "SunStop": "2017-06-15T10:18:01.1918781+02:00",
  "NonDates": [
    "non",
    "et"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 257,
      "AlertLevel": 100,
      "AlertTimeout": 482,
      "Action": 843,
      "DelegateTo": 263,
      "ScriptId": 651,
      "EmailTo": "samir@swift.biz",
      "SmsTo": "veniam",
      "ReplyTemplateIdCustomer": 970,
      "ReplyTemplateIdUser": 709,
      "ReplyTemplateIdCatmast": 205,
      "ReplyTemplateIdEmail": 968,
      "RtiCustomerSms": 288,
      "ReplyTemplateIdUserSms": 816,
      "ReplyTemplateIdCatmastSms": 391,
      "ReplyTemplateIdSms": 494
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 965,
  "Name": "Fay, McDermott and Cremin",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 279,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 47,
  "MonStart": "2023-02-15T10:18:01.1918781+01:00",
  "MonStop": "2008-11-30T10:18:01.1918781+01:00",
  "TueStart": "2010-07-27T10:18:01.1918781+02:00",
  "TueStop": "2014-05-27T10:18:01.1918781+02:00",
  "WedStart": "2022-01-14T10:18:01.1918781+01:00",
  "WedStop": "2003-11-21T10:18:01.1918781+01:00",
  "ThuStart": "2011-05-06T10:18:01.1918781+02:00",
  "ThuStop": "2023-04-06T10:18:01.1918781+02:00",
  "FriStart": "2001-09-16T10:18:01.1918781+02:00",
  "FriStop": "2007-10-03T10:18:01.1918781+02:00",
  "SatStart": "1999-05-09T10:18:01.1918781+02:00",
  "SatStop": "2003-10-01T10:18:01.1918781+02:00",
  "SunStart": "2019-06-06T10:18:01.1918781+02:00",
  "SunStop": "1998-12-27T10:18:01.1918781+01:00",
  "NonDates": [
    "quas",
    "quia"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 176,
      "AlertLevel": 749,
      "AlertTimeout": 860,
      "Action": 639,
      "DelegateTo": 914,
      "ScriptId": 250,
      "EmailTo": "westley@gusikowskiflatley.ca",
      "SmsTo": "est",
      "ReplyTemplateIdCustomer": 1002,
      "ReplyTemplateIdUser": 28,
      "ReplyTemplateIdCatmast": 838,
      "ReplyTemplateIdEmail": 571,
      "RtiCustomerSms": 227,
      "ReplyTemplateIdUserSms": 931,
      "ReplyTemplateIdCatmastSms": 364,
      "ReplyTemplateIdSms": 773,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 654
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 315
    }
  }
}
```
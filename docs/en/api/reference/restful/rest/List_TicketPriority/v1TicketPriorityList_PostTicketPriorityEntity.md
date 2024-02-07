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
  "TicketPriorityId": 783,
  "Name": "Emmerich Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 887,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 87,
  "MonStart": "2013-09-24T16:55:31.1328188+02:00",
  "MonStop": "2012-06-07T16:55:31.1328188+02:00",
  "TueStart": "2013-08-20T16:55:31.1328188+02:00",
  "TueStop": "2007-01-06T16:55:31.1328188+01:00",
  "WedStart": "2017-10-02T16:55:31.1328188+02:00",
  "WedStop": "2018-01-26T16:55:31.1328188+01:00",
  "ThuStart": "2000-04-17T16:55:31.1328188+02:00",
  "ThuStop": "2013-02-20T16:55:31.1328188+01:00",
  "FriStart": "2015-06-29T16:55:31.1328188+02:00",
  "FriStop": "2010-06-11T16:55:31.1328188+02:00",
  "SatStart": "2004-05-09T16:55:31.1328188+02:00",
  "SatStop": "2001-02-28T16:55:31.1328188+01:00",
  "SunStart": "2012-07-10T16:55:31.1328188+02:00",
  "SunStop": "2017-01-28T16:55:31.1328188+01:00",
  "NonDates": [
    "eveniet",
    "nihil"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 952,
      "AlertLevel": 300,
      "AlertTimeout": 253,
      "Action": 17,
      "DelegateTo": 735,
      "ScriptId": 473,
      "EmailTo": "rico_jakubowski@pollich.co.uk",
      "SmsTo": "aspernatur",
      "ReplyTemplateIdCustomer": 139,
      "ReplyTemplateIdUser": 568,
      "ReplyTemplateIdCatmast": 561,
      "ReplyTemplateIdEmail": 445,
      "RtiCustomerSms": 418,
      "ReplyTemplateIdUserSms": 282,
      "ReplyTemplateIdCatmastSms": 296,
      "ReplyTemplateIdSms": 926
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 219,
  "Name": "Lesch Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 567,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 495,
  "MonStart": "2005-10-07T16:55:31.1337951+02:00",
  "MonStop": "1999-04-17T16:55:31.1337951+02:00",
  "TueStart": "2003-11-29T16:55:31.1337951+01:00",
  "TueStop": "2024-01-11T16:55:31.1337951+01:00",
  "WedStart": "2020-11-15T16:55:31.1337951+01:00",
  "WedStop": "1999-12-27T16:55:31.1337951+01:00",
  "ThuStart": "2017-08-26T16:55:31.1337951+02:00",
  "ThuStop": "2007-01-14T16:55:31.1337951+01:00",
  "FriStart": "2010-04-22T16:55:31.1337951+02:00",
  "FriStop": "2003-11-29T16:55:31.1337951+01:00",
  "SatStart": "2006-09-19T16:55:31.1337951+02:00",
  "SatStop": "2016-05-13T16:55:31.1337951+02:00",
  "SunStart": "2016-03-13T16:55:31.1337951+01:00",
  "SunStop": "2004-11-07T16:55:31.1337951+01:00",
  "NonDates": [
    "et",
    "adipisci"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 785,
      "AlertLevel": 269,
      "AlertTimeout": 887,
      "Action": 611,
      "DelegateTo": 534,
      "ScriptId": 379,
      "EmailTo": "katlyn@vonoconner.com",
      "SmsTo": "praesentium",
      "ReplyTemplateIdCustomer": 546,
      "ReplyTemplateIdUser": 501,
      "ReplyTemplateIdCatmast": 456,
      "ReplyTemplateIdEmail": 617,
      "RtiCustomerSms": 465,
      "ReplyTemplateIdUserSms": 532,
      "ReplyTemplateIdCatmastSms": 636,
      "ReplyTemplateIdSms": 982,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 260
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 830
    }
  }
}
```
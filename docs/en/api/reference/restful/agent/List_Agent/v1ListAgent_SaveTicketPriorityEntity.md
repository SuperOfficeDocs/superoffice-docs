---
title: POST Agents/List/SaveTicketPriorityEntity
uid: v1ListAgent_SaveTicketPriorityEntity
---

# POST Agents/List/SaveTicketPriorityEntity

```http
POST /api/v1/Agents/List/SaveTicketPriorityEntity
```

Updates the existing TicketPriorityEntity or creates a new TicketPriorityEntity if the id parameter is empty








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

## Request Body: entity 

The TicketPriorityEntity to be saved. 

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 16,
  "Name": "Ledner Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 148,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 12,
  "MonStart": "2018-04-09T17:37:18.2942432+02:00",
  "MonStop": "1998-10-17T17:37:18.2942432+02:00",
  "TueStart": "1998-11-25T17:37:18.2942432+01:00",
  "TueStop": "1995-09-29T17:37:18.2942432+02:00",
  "WedStart": "2000-06-11T17:37:18.2942432+02:00",
  "WedStop": "2001-06-26T17:37:18.2942432+02:00",
  "ThuStart": "2015-07-10T17:37:18.2942432+02:00",
  "ThuStop": "2013-04-09T17:37:18.2942432+02:00",
  "FriStart": "2005-05-21T17:37:18.2942432+02:00",
  "FriStop": "2008-07-19T17:37:18.2942432+02:00",
  "SatStart": "1999-09-29T17:37:18.2942432+02:00",
  "SatStop": "2013-03-03T17:37:18.2942432+01:00",
  "SunStart": "1999-10-10T17:37:18.2942432+02:00",
  "SunStop": "2016-12-19T17:37:18.2942432+01:00",
  "NonDates": [
    "voluptate",
    "possimus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 225,
      "AlertLevel": 316,
      "AlertTimeout": 772,
      "Action": 953,
      "DelegateTo": 469,
      "ScriptId": 284,
      "EmailTo": "emmanuel@emmerich.co.uk",
      "SmsTo": "aut",
      "ReplyTemplateIdCustomer": 267,
      "ReplyTemplateIdUser": 881,
      "ReplyTemplateIdCatmast": 635,
      "ReplyTemplateIdEmail": 83,
      "RtiCustomerSms": 788,
      "ReplyTemplateIdUserSms": 66,
      "ReplyTemplateIdCatmastSms": 147,
      "ReplyTemplateIdSms": 557
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 340,
  "Name": "Bins, Wehner and Kunze",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 800,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 512,
  "MonStart": "2000-03-30T17:37:18.2942432+02:00",
  "MonStop": "2013-03-22T17:37:18.2942432+01:00",
  "TueStart": "1996-12-03T17:37:18.2942432+01:00",
  "TueStop": "2015-06-17T17:37:18.2942432+02:00",
  "WedStart": "1996-10-29T17:37:18.2942432+01:00",
  "WedStop": "2011-05-20T17:37:18.2942432+02:00",
  "ThuStart": "2006-02-01T17:37:18.2942432+01:00",
  "ThuStop": "1997-08-26T17:37:18.2942432+02:00",
  "FriStart": "2012-12-09T17:37:18.2942432+01:00",
  "FriStop": "2013-04-26T17:37:18.2942432+02:00",
  "SatStart": "2003-11-16T17:37:18.2942432+01:00",
  "SatStop": "2003-07-21T17:37:18.2942432+02:00",
  "SunStart": "2009-01-20T17:37:18.2942432+01:00",
  "SunStop": "2016-04-17T17:37:18.2942432+02:00",
  "NonDates": [
    "sed",
    "dolores"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 434,
      "AlertLevel": 933,
      "AlertTimeout": 623,
      "Action": 102,
      "DelegateTo": 666,
      "ScriptId": 428,
      "EmailTo": "oswald.jewess@rogahnroberts.us",
      "SmsTo": "sit",
      "ReplyTemplateIdCustomer": 650,
      "ReplyTemplateIdUser": 340,
      "ReplyTemplateIdCatmast": 222,
      "ReplyTemplateIdEmail": 648,
      "RtiCustomerSms": 427,
      "ReplyTemplateIdUserSms": 323,
      "ReplyTemplateIdCatmastSms": 351,
      "ReplyTemplateIdSms": 850,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 339
    }
  }
}
```
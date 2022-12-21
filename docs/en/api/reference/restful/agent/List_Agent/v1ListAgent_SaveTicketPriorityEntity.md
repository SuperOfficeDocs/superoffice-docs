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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 146,
  "Name": "Schamberger Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 706,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 253,
  "MonStart": "2011-03-12T02:49:44.6860468+01:00",
  "MonStop": "2009-04-08T02:49:44.6860468+02:00",
  "TueStart": "2004-09-24T02:49:44.6860468+02:00",
  "TueStop": "2018-08-12T02:49:44.6860468+02:00",
  "WedStart": "2010-10-11T02:49:44.6860468+02:00",
  "WedStop": "2009-06-26T02:49:44.6860468+02:00",
  "ThuStart": "1999-06-13T02:49:44.6860468+02:00",
  "ThuStop": "2004-09-27T02:49:44.6860468+02:00",
  "FriStart": "2015-09-28T02:49:44.6860468+02:00",
  "FriStop": "2008-02-01T02:49:44.6860468+01:00",
  "SatStart": "1998-10-31T02:49:44.6860468+01:00",
  "SatStop": "2014-03-27T02:49:44.6860468+01:00",
  "SunStart": "2000-07-31T02:49:44.6860468+02:00",
  "SunStop": "2016-12-09T02:49:44.6860468+01:00",
  "NonDates": [
    "quo",
    "consequuntur"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 639,
      "AlertLevel": 967,
      "AlertTimeout": 715,
      "Action": 243,
      "DelegateTo": 929,
      "ScriptId": 323,
      "EmailTo": "kattie.jones@kuhn.com",
      "SmsTo": "sed",
      "ReplyTemplateIdCustomer": 571,
      "ReplyTemplateIdUser": 199,
      "ReplyTemplateIdCatmast": 466,
      "ReplyTemplateIdEmail": 359,
      "RtiCustomerSms": 505,
      "ReplyTemplateIdUserSms": 445,
      "ReplyTemplateIdCatmastSms": 470,
      "ReplyTemplateIdSms": 484
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 354,
  "Name": "Sporer-Dach",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 692,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 818,
  "MonStart": "2022-05-06T02:49:44.6860468+02:00",
  "MonStop": "2005-10-22T02:49:44.6860468+02:00",
  "TueStart": "2013-03-23T02:49:44.6860468+01:00",
  "TueStop": "2000-01-04T02:49:44.6860468+01:00",
  "WedStart": "2011-11-05T02:49:44.6860468+01:00",
  "WedStop": "2017-05-19T02:49:44.6860468+02:00",
  "ThuStart": "2005-06-22T02:49:44.6860468+02:00",
  "ThuStop": "2017-02-03T02:49:44.6860468+01:00",
  "FriStart": "2014-01-03T02:49:44.6860468+01:00",
  "FriStop": "2009-03-24T02:49:44.6860468+01:00",
  "SatStart": "2008-01-28T02:49:44.6860468+01:00",
  "SatStop": "2012-02-04T02:49:44.6860468+01:00",
  "SunStart": "2006-12-29T02:49:44.6860468+01:00",
  "SunStop": "2022-02-15T02:49:44.6860468+01:00",
  "NonDates": [
    "eos",
    "nobis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 804,
      "AlertLevel": 384,
      "AlertTimeout": 595,
      "Action": 604,
      "DelegateTo": 356,
      "ScriptId": 668,
      "EmailTo": "keely@wehner.name",
      "SmsTo": "illum",
      "ReplyTemplateIdCustomer": 694,
      "ReplyTemplateIdUser": 432,
      "ReplyTemplateIdCatmast": 742,
      "ReplyTemplateIdEmail": 765,
      "RtiCustomerSms": 609,
      "ReplyTemplateIdUserSms": 751,
      "ReplyTemplateIdCatmastSms": 656,
      "ReplyTemplateIdSms": 832,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 57
    }
  }
}
```
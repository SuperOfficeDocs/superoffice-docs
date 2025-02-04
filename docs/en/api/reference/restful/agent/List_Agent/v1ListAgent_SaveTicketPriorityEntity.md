---
title: POST Agents/List/SaveTicketPriorityEntity
uid: v1ListAgent_SaveTicketPriorityEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 557,
  "Name": "Lind Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 154,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 436,
  "MonStart": "1999-01-09T13:13:23.3364181+01:00",
  "MonStop": "2019-09-29T13:13:23.3364181+02:00",
  "TueStart": "2004-11-08T13:13:23.3364181+01:00",
  "TueStop": "1998-04-07T13:13:23.3364181+02:00",
  "WedStart": "2013-10-29T13:13:23.3364181+01:00",
  "WedStop": "2006-09-13T13:13:23.3364181+02:00",
  "ThuStart": "2010-07-16T13:13:23.3364181+02:00",
  "ThuStop": "2014-12-03T13:13:23.3364181+01:00",
  "FriStart": "2020-01-30T13:13:23.3364181+01:00",
  "FriStop": "2020-04-16T13:13:23.3364181+02:00",
  "SatStart": "2004-10-01T13:13:23.3364181+02:00",
  "SatStop": "2008-04-18T13:13:23.3364181+02:00",
  "SunStart": "2016-12-13T13:13:23.3364181+01:00",
  "SunStop": "2021-06-09T13:13:23.3364181+02:00",
  "NonDates": [
    "harum",
    "quis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 606,
      "AlertLevel": 959,
      "AlertTimeout": 929,
      "Action": 417,
      "DelegateTo": 344,
      "ScriptId": 131,
      "EmailTo": "camryn.hills@toydaniel.name",
      "SmsTo": "debitis",
      "ReplyTemplateIdCustomer": 650,
      "ReplyTemplateIdUser": 676,
      "ReplyTemplateIdCatmast": 139,
      "ReplyTemplateIdEmail": 550,
      "RtiCustomerSms": 647,
      "ReplyTemplateIdUserSms": 897,
      "ReplyTemplateIdCatmastSms": 413,
      "ReplyTemplateIdSms": 280
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 410,
  "Name": "Blanda, Padberg and Smitham",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 338,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 231,
  "MonStart": "1999-02-07T13:13:23.3364181+01:00",
  "MonStop": "2020-03-14T13:13:23.3364181+01:00",
  "TueStart": "2001-10-02T13:13:23.3364181+02:00",
  "TueStop": "2023-04-22T13:13:23.3364181+02:00",
  "WedStart": "2017-06-25T13:13:23.3364181+02:00",
  "WedStop": "2009-03-14T13:13:23.3364181+01:00",
  "ThuStart": "2013-10-04T13:13:23.3364181+02:00",
  "ThuStop": "2009-04-03T13:13:23.3364181+02:00",
  "FriStart": "2004-08-07T13:13:23.3364181+02:00",
  "FriStop": "2000-07-03T13:13:23.3364181+02:00",
  "SatStart": "2017-03-10T13:13:23.3364181+01:00",
  "SatStop": "2000-05-07T13:13:23.3364181+02:00",
  "SunStart": "2017-12-25T13:13:23.3364181+01:00",
  "SunStop": "2020-01-08T13:13:23.3364181+01:00",
  "NonDates": [
    "nobis",
    "accusamus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 115,
      "AlertLevel": 700,
      "AlertTimeout": 57,
      "Action": 408,
      "DelegateTo": 377,
      "ScriptId": 651,
      "EmailTo": "ora@harber.com",
      "SmsTo": "enim",
      "ReplyTemplateIdCustomer": 188,
      "ReplyTemplateIdUser": 399,
      "ReplyTemplateIdCatmast": 894,
      "ReplyTemplateIdEmail": 349,
      "RtiCustomerSms": 894,
      "ReplyTemplateIdUserSms": 987,
      "ReplyTemplateIdCatmastSms": 930,
      "ReplyTemplateIdSms": 808,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 337
    }
  }
}
```
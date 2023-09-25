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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 689,
  "Name": "Hilll-Hane",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 289,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 396,
  "MonStart": "1996-06-11T03:24:47.908255+02:00",
  "MonStop": "2019-01-14T03:24:47.908255+01:00",
  "TueStart": "2007-10-12T03:24:47.908255+02:00",
  "TueStop": "2002-04-10T03:24:47.908255+02:00",
  "WedStart": "2013-11-22T03:24:47.908255+01:00",
  "WedStop": "2003-04-09T03:24:47.908255+02:00",
  "ThuStart": "1998-03-09T03:24:47.908255+01:00",
  "ThuStop": "2013-12-13T03:24:47.908255+01:00",
  "FriStart": "2001-04-22T03:24:47.908255+02:00",
  "FriStop": "2001-06-19T03:24:47.908255+02:00",
  "SatStart": "1998-08-01T03:24:47.908255+02:00",
  "SatStop": "2012-09-18T03:24:47.908255+02:00",
  "SunStart": "2017-10-21T03:24:47.908255+02:00",
  "SunStop": "2004-03-06T03:24:47.908255+01:00",
  "NonDates": [
    "est",
    "dolor"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 966,
      "AlertLevel": 332,
      "AlertTimeout": 161,
      "Action": 369,
      "DelegateTo": 138,
      "ScriptId": 816,
      "EmailTo": "robb_walker@klocko.biz",
      "SmsTo": "pariatur",
      "ReplyTemplateIdCustomer": 361,
      "ReplyTemplateIdUser": 574,
      "ReplyTemplateIdCatmast": 738,
      "ReplyTemplateIdEmail": 16,
      "RtiCustomerSms": 128,
      "ReplyTemplateIdUserSms": 2,
      "ReplyTemplateIdCatmastSms": 542,
      "ReplyTemplateIdSms": 101
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 317,
  "Name": "Nitzsche, Cruickshank and Kris",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 587,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 407,
  "MonStart": "2012-02-28T03:24:47.908255+01:00",
  "MonStop": "2022-10-09T03:24:47.908255+02:00",
  "TueStart": "1999-04-19T03:24:47.908255+02:00",
  "TueStop": "1998-11-09T03:24:47.908255+01:00",
  "WedStart": "2015-05-26T03:24:47.908255+02:00",
  "WedStop": "2002-01-07T03:24:47.908255+01:00",
  "ThuStart": "2015-10-24T03:24:47.908255+02:00",
  "ThuStop": "2020-05-27T03:24:47.908255+02:00",
  "FriStart": "2013-04-08T03:24:47.908255+02:00",
  "FriStop": "2015-04-14T03:24:47.908255+02:00",
  "SatStart": "2000-11-18T03:24:47.908255+01:00",
  "SatStop": "2004-08-23T03:24:47.908255+02:00",
  "SunStart": "2012-06-08T03:24:47.908255+02:00",
  "SunStop": "2019-02-26T03:24:47.908255+01:00",
  "NonDates": [
    "culpa",
    "sunt"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 179,
      "AlertLevel": 577,
      "AlertTimeout": 135,
      "Action": 356,
      "DelegateTo": 682,
      "ScriptId": 1002,
      "EmailTo": "abdul_hegmann@beierklocko.biz",
      "SmsTo": "voluptas",
      "ReplyTemplateIdCustomer": 673,
      "ReplyTemplateIdUser": 837,
      "ReplyTemplateIdCatmast": 370,
      "ReplyTemplateIdEmail": 184,
      "RtiCustomerSms": 9,
      "ReplyTemplateIdUserSms": 567,
      "ReplyTemplateIdCatmastSms": 645,
      "ReplyTemplateIdSms": 21,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 926
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 312
    }
  }
}
```
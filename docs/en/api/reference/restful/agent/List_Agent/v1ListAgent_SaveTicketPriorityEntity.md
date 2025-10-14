---
title: POST Agents/List/SaveTicketPriorityEntity
uid: v1ListAgent_SaveTicketPriorityEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveTicketPriorityEntity

```http
POST /api/v1/Agents/List/SaveTicketPriorityEntity
```

Updates the existing TicketPriorityEntity or creates a new TicketPriorityEntity if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: ticketPriorityEntity 

The TicketPriorityEntity that is saved 

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
  "TicketPriorityId": 870,
  "Name": "Macejkovic LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 917,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 626,
  "MonStart": "2001-11-27T03:40:47.0311652+01:00",
  "MonStop": "2008-03-16T03:40:47.0311652+01:00",
  "TueStart": "2024-12-08T03:40:47.0311652+01:00",
  "TueStop": "2018-09-02T03:40:47.0311652+02:00",
  "WedStart": "2003-04-07T03:40:47.0311652+02:00",
  "WedStop": "2025-09-01T03:40:47.0311652+02:00",
  "ThuStart": "2012-11-26T03:40:47.0311652+01:00",
  "ThuStop": "2019-02-26T03:40:47.0311652+01:00",
  "FriStart": "2017-05-17T03:40:47.0311652+02:00",
  "FriStop": "2011-01-09T03:40:47.0311652+01:00",
  "SatStart": "2016-07-19T03:40:47.0311652+02:00",
  "SatStop": "2009-04-11T03:40:47.0311652+02:00",
  "SunStart": "1999-10-24T03:40:47.0311652+02:00",
  "SunStop": "2006-08-10T03:40:47.0311652+02:00",
  "NonDates": [
    "rerum",
    "omnis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 456,
      "AlertLevel": 280,
      "AlertTimeout": 372,
      "Action": 450,
      "DelegateTo": 981,
      "ScriptId": 28,
      "EmailTo": "alexys.schumm@boehm.us",
      "SmsTo": "beatae",
      "ReplyTemplateIdCustomer": 552,
      "ReplyTemplateIdUser": 33,
      "ReplyTemplateIdCatmast": 438,
      "ReplyTemplateIdEmail": 803,
      "RtiCustomerSms": 457,
      "ReplyTemplateIdUserSms": 6,
      "ReplyTemplateIdCatmastSms": 961,
      "ReplyTemplateIdSms": 382
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 154,
  "Name": "Altenwerth, Shanahan and Wyman",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 922,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 236,
  "MonStart": "2020-07-22T03:40:47.0311652+02:00",
  "MonStop": "2022-09-28T03:40:47.0311652+02:00",
  "TueStart": "2001-06-12T03:40:47.0311652+02:00",
  "TueStop": "2021-12-04T03:40:47.0311652+01:00",
  "WedStart": "2000-05-30T03:40:47.0311652+02:00",
  "WedStop": "2019-08-31T03:40:47.0311652+02:00",
  "ThuStart": "2011-10-25T03:40:47.0311652+02:00",
  "ThuStop": "2001-09-17T03:40:47.0311652+02:00",
  "FriStart": "2021-12-07T03:40:47.0311652+01:00",
  "FriStop": "2023-09-25T03:40:47.0311652+02:00",
  "SatStart": "2020-11-28T03:40:47.0311652+01:00",
  "SatStop": "2002-10-23T03:40:47.0311652+02:00",
  "SunStart": "2022-04-05T03:40:47.0311652+02:00",
  "SunStop": "2017-01-08T03:40:47.0311652+01:00",
  "NonDates": [
    "corporis",
    "temporibus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 605,
      "AlertLevel": 330,
      "AlertTimeout": 813,
      "Action": 881,
      "DelegateTo": 612,
      "ScriptId": 548,
      "EmailTo": "maximo@osinski.ca",
      "SmsTo": "optio",
      "ReplyTemplateIdCustomer": 997,
      "ReplyTemplateIdUser": 791,
      "ReplyTemplateIdCatmast": 617,
      "ReplyTemplateIdEmail": 82,
      "RtiCustomerSms": 872,
      "ReplyTemplateIdUserSms": 553,
      "ReplyTemplateIdCatmastSms": 171,
      "ReplyTemplateIdSms": 115,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 800
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 912
    }
  }
}
```
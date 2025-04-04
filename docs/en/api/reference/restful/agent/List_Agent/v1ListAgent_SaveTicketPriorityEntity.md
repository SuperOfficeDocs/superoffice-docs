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
  "TicketPriorityId": 834,
  "Name": "Armstrong LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 718,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 697,
  "MonStart": "1998-05-05T13:14:00.6731283+02:00",
  "MonStop": "2020-10-06T13:14:00.6731283+02:00",
  "TueStart": "2021-08-30T13:14:00.6731283+02:00",
  "TueStop": "2006-03-24T13:14:00.6731283+01:00",
  "WedStart": "1999-09-27T13:14:00.6731283+02:00",
  "WedStop": "2005-05-12T13:14:00.6731283+02:00",
  "ThuStart": "1998-08-28T13:14:00.6731283+02:00",
  "ThuStop": "2010-02-02T13:14:00.6731283+01:00",
  "FriStart": "2024-12-08T13:14:00.6731283+01:00",
  "FriStop": "2023-12-25T13:14:00.6731283+01:00",
  "SatStart": "2008-10-30T13:14:00.6731283+01:00",
  "SatStop": "2025-02-28T13:14:00.6731283+01:00",
  "SunStart": "2011-01-27T13:14:00.6731283+01:00",
  "SunStop": "2017-02-08T13:14:00.6731283+01:00",
  "NonDates": [
    "est",
    "eligendi"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 772,
      "AlertLevel": 745,
      "AlertTimeout": 473,
      "Action": 118,
      "DelegateTo": 589,
      "ScriptId": 174,
      "EmailTo": "effie@raynor.ca",
      "SmsTo": "eligendi",
      "ReplyTemplateIdCustomer": 864,
      "ReplyTemplateIdUser": 747,
      "ReplyTemplateIdCatmast": 235,
      "ReplyTemplateIdEmail": 87,
      "RtiCustomerSms": 456,
      "ReplyTemplateIdUserSms": 806,
      "ReplyTemplateIdCatmastSms": 193,
      "ReplyTemplateIdSms": 912
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 992,
  "Name": "Hackett-McLaughlin",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 79,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 496,
  "MonStart": "2013-12-24T13:14:00.6731283+01:00",
  "MonStop": "2012-10-22T13:14:00.6731283+02:00",
  "TueStart": "2014-01-25T13:14:00.6731283+01:00",
  "TueStop": "2023-12-31T13:14:00.6731283+01:00",
  "WedStart": "2009-06-14T13:14:00.6731283+02:00",
  "WedStop": "2017-10-06T13:14:00.6731283+02:00",
  "ThuStart": "2021-03-20T13:14:00.6731283+01:00",
  "ThuStop": "2007-09-04T13:14:00.6731283+02:00",
  "FriStart": "1998-04-23T13:14:00.6731283+02:00",
  "FriStop": "2023-06-15T13:14:00.6731283+02:00",
  "SatStart": "2018-04-04T13:14:00.6731283+02:00",
  "SatStop": "2024-10-25T13:14:00.6731283+02:00",
  "SunStart": "2005-03-04T13:14:00.6731283+01:00",
  "SunStop": "2014-07-10T13:14:00.6731283+02:00",
  "NonDates": [
    "voluptas",
    "assumenda"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 452,
      "AlertLevel": 402,
      "AlertTimeout": 812,
      "Action": 631,
      "DelegateTo": 570,
      "ScriptId": 407,
      "EmailTo": "chelsie@parker.biz",
      "SmsTo": "ipsa",
      "ReplyTemplateIdCustomer": 947,
      "ReplyTemplateIdUser": 832,
      "ReplyTemplateIdCatmast": 68,
      "ReplyTemplateIdEmail": 507,
      "RtiCustomerSms": 751,
      "ReplyTemplateIdUserSms": 14,
      "ReplyTemplateIdCatmastSms": 989,
      "ReplyTemplateIdSms": 131,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 180
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 858
    }
  }
}
```
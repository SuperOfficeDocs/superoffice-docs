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
  "TicketPriorityId": 847,
  "Name": "Hackett-Glover",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 156,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 588,
  "MonStart": "2007-03-09T11:22:38.5396587+01:00",
  "MonStop": "2020-08-20T11:22:38.5396587+02:00",
  "TueStart": "2013-01-17T11:22:38.5396587+01:00",
  "TueStop": "2015-06-01T11:22:38.5396587+02:00",
  "WedStart": "1997-12-26T11:22:38.5396587+01:00",
  "WedStop": "1997-11-24T11:22:38.5396587+01:00",
  "ThuStart": "2012-10-19T11:22:38.5396587+02:00",
  "ThuStop": "2022-02-05T11:22:38.5396587+01:00",
  "FriStart": "2021-02-18T11:22:38.5396587+01:00",
  "FriStop": "2000-06-23T11:22:38.5396587+02:00",
  "SatStart": "2008-01-01T11:22:38.5396587+01:00",
  "SatStop": "2001-06-21T11:22:38.5396587+02:00",
  "SunStart": "2004-07-28T11:22:38.5396587+02:00",
  "SunStop": "1995-11-24T11:22:38.5396587+01:00",
  "NonDates": [
    "dolorem",
    "et"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 554,
      "AlertLevel": 699,
      "AlertTimeout": 148,
      "Action": 639,
      "DelegateTo": 908,
      "ScriptId": 82,
      "EmailTo": "zachary@roberts.info",
      "SmsTo": "quia",
      "ReplyTemplateIdCustomer": 209,
      "ReplyTemplateIdUser": 652,
      "ReplyTemplateIdCatmast": 600,
      "ReplyTemplateIdEmail": 156,
      "RtiCustomerSms": 150,
      "ReplyTemplateIdUserSms": 232,
      "ReplyTemplateIdCatmastSms": 732,
      "ReplyTemplateIdSms": 29
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 805,
  "Name": "VonRueden-O'Connell",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 161,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 506,
  "MonStart": "1999-09-20T11:22:38.5396587+02:00",
  "MonStop": "1996-05-23T11:22:38.5396587+02:00",
  "TueStart": "2003-01-10T11:22:38.5396587+01:00",
  "TueStop": "2016-12-02T11:22:38.5396587+01:00",
  "WedStart": "2018-12-16T11:22:38.5396587+01:00",
  "WedStop": "2021-05-20T11:22:38.5396587+02:00",
  "ThuStart": "2002-09-30T11:22:38.5396587+02:00",
  "ThuStop": "2002-08-27T11:22:38.5396587+02:00",
  "FriStart": "2002-12-14T11:22:38.5396587+01:00",
  "FriStop": "2006-01-14T11:22:38.5396587+01:00",
  "SatStart": "2013-04-23T11:22:38.5396587+02:00",
  "SatStop": "2019-02-11T11:22:38.5396587+01:00",
  "SunStart": "2006-02-18T11:22:38.5396587+01:00",
  "SunStop": "2005-04-07T11:22:38.5396587+02:00",
  "NonDates": [
    "eum",
    "rem"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 987,
      "AlertLevel": 295,
      "AlertTimeout": 426,
      "Action": 594,
      "DelegateTo": 263,
      "ScriptId": 23,
      "EmailTo": "kieran@ullrich.co.uk",
      "SmsTo": "sed",
      "ReplyTemplateIdCustomer": 130,
      "ReplyTemplateIdUser": 456,
      "ReplyTemplateIdCatmast": 145,
      "ReplyTemplateIdEmail": 793,
      "RtiCustomerSms": 38,
      "ReplyTemplateIdUserSms": 733,
      "ReplyTemplateIdCatmastSms": 349,
      "ReplyTemplateIdSms": 846,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 828
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 671
    }
  }
}
```
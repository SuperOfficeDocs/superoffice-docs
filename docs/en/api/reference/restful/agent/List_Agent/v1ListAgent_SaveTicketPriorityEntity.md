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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 271,
  "Name": "McCullough, Gaylord and Kirlin",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 315,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 703,
  "MonStart": "2016-05-17T03:41:53.6057294+02:00",
  "MonStop": "2003-09-17T03:41:53.6057294+02:00",
  "TueStart": "2002-06-02T03:41:53.6057294+02:00",
  "TueStop": "2023-05-25T03:41:53.6057294+02:00",
  "WedStart": "2003-10-02T03:41:53.6057294+02:00",
  "WedStop": "2012-05-10T03:41:53.6057294+02:00",
  "ThuStart": "2018-12-21T03:41:53.6057294+01:00",
  "ThuStop": "2010-12-23T03:41:53.6057294+01:00",
  "FriStart": "2022-09-22T03:41:53.6057294+02:00",
  "FriStop": "2016-12-06T03:41:53.6057294+01:00",
  "SatStart": "2010-01-27T03:41:53.6057294+01:00",
  "SatStop": "2024-09-01T03:41:53.6057294+02:00",
  "SunStart": "2006-11-05T03:41:53.6057294+01:00",
  "SunStop": "2008-12-01T03:41:53.6057294+01:00",
  "NonDates": [
    "itaque",
    "eligendi"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 774,
      "AlertLevel": 166,
      "AlertTimeout": 599,
      "Action": 740,
      "DelegateTo": 914,
      "ScriptId": 835,
      "EmailTo": "garnet.hudson@nikolaus.biz",
      "SmsTo": "recusandae",
      "ReplyTemplateIdCustomer": 185,
      "ReplyTemplateIdUser": 224,
      "ReplyTemplateIdCatmast": 457,
      "ReplyTemplateIdEmail": 173,
      "RtiCustomerSms": 777,
      "ReplyTemplateIdUserSms": 768,
      "ReplyTemplateIdCatmastSms": 474,
      "ReplyTemplateIdSms": 689
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 216,
  "Name": "Tremblay, Bartell and Schmeler",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 250,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 497,
  "MonStart": "2011-12-12T03:41:53.6057294+01:00",
  "MonStop": "2001-12-23T03:41:53.6057294+01:00",
  "TueStart": "2010-04-05T03:41:53.6057294+02:00",
  "TueStop": "2005-09-25T03:41:53.6057294+02:00",
  "WedStart": "2024-02-26T03:41:53.6057294+01:00",
  "WedStop": "2015-02-21T03:41:53.6057294+01:00",
  "ThuStart": "2011-09-24T03:41:53.6057294+02:00",
  "ThuStop": "2000-07-07T03:41:53.6057294+02:00",
  "FriStart": "2023-06-16T03:41:53.6057294+02:00",
  "FriStop": "2007-06-14T03:41:53.6057294+02:00",
  "SatStart": "2013-03-22T03:41:53.6057294+01:00",
  "SatStop": "2011-09-27T03:41:53.6057294+02:00",
  "SunStart": "2008-06-07T03:41:53.6057294+02:00",
  "SunStop": "2023-02-17T03:41:53.6057294+01:00",
  "NonDates": [
    "iure",
    "blanditiis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 640,
      "AlertLevel": 944,
      "AlertTimeout": 310,
      "Action": 420,
      "DelegateTo": 690,
      "ScriptId": 375,
      "EmailTo": "brielle@gorczany.uk",
      "SmsTo": "velit",
      "ReplyTemplateIdCustomer": 639,
      "ReplyTemplateIdUser": 612,
      "ReplyTemplateIdCatmast": 718,
      "ReplyTemplateIdEmail": 953,
      "RtiCustomerSms": 702,
      "ReplyTemplateIdUserSms": 547,
      "ReplyTemplateIdCatmastSms": 642,
      "ReplyTemplateIdSms": 312,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 256
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 557
    }
  }
}
```
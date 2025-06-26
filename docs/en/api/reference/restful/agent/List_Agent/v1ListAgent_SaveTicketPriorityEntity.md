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
  "TicketPriorityId": 32,
  "Name": "Reinger, Cremin and Heaney",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 440,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 859,
  "MonStart": "2009-06-09T03:45:23.6235756+02:00",
  "MonStop": "2021-02-20T03:45:23.6235756+01:00",
  "TueStart": "2019-12-08T03:45:23.6235756+01:00",
  "TueStop": "2001-04-18T03:45:23.6235756+02:00",
  "WedStart": "2005-10-21T03:45:23.6235756+02:00",
  "WedStop": "2022-11-19T03:45:23.6235756+01:00",
  "ThuStart": "2022-01-29T03:45:23.6235756+01:00",
  "ThuStop": "2021-02-25T03:45:23.6235756+01:00",
  "FriStart": "2022-03-05T03:45:23.6235756+01:00",
  "FriStop": "2010-02-05T03:45:23.6235756+01:00",
  "SatStart": "2025-05-12T03:45:23.6235756+02:00",
  "SatStop": "2012-08-24T03:45:23.6235756+02:00",
  "SunStart": "2024-09-21T03:45:23.6235756+02:00",
  "SunStop": "2006-12-08T03:45:23.6235756+01:00",
  "NonDates": [
    "ab",
    "quibusdam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 264,
      "AlertLevel": 789,
      "AlertTimeout": 306,
      "Action": 409,
      "DelegateTo": 523,
      "ScriptId": 460,
      "EmailTo": "aletha@leannon.ca",
      "SmsTo": "consequatur",
      "ReplyTemplateIdCustomer": 63,
      "ReplyTemplateIdUser": 903,
      "ReplyTemplateIdCatmast": 406,
      "ReplyTemplateIdEmail": 918,
      "RtiCustomerSms": 415,
      "ReplyTemplateIdUserSms": 430,
      "ReplyTemplateIdCatmastSms": 23,
      "ReplyTemplateIdSms": 194
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 30,
  "Name": "Jacobs-Green",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 93,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 813,
  "MonStart": "2018-08-31T03:45:23.6235756+02:00",
  "MonStop": "2003-09-17T03:45:23.6235756+02:00",
  "TueStart": "2002-12-15T03:45:23.6235756+01:00",
  "TueStop": "2009-06-20T03:45:23.6235756+02:00",
  "WedStart": "2003-04-07T03:45:23.6235756+02:00",
  "WedStop": "1999-01-19T03:45:23.6235756+01:00",
  "ThuStart": "2013-06-05T03:45:23.6235756+02:00",
  "ThuStop": "2008-08-03T03:45:23.6235756+02:00",
  "FriStart": "2005-02-08T03:45:23.6235756+01:00",
  "FriStop": "2012-08-07T03:45:23.6235756+02:00",
  "SatStart": "1999-02-27T03:45:23.6235756+01:00",
  "SatStop": "2016-05-24T03:45:23.6235756+02:00",
  "SunStart": "2016-01-05T03:45:23.6235756+01:00",
  "SunStop": "2011-05-25T03:45:23.6235756+02:00",
  "NonDates": [
    "repellendus",
    "pariatur"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 813,
      "AlertLevel": 493,
      "AlertTimeout": 540,
      "Action": 734,
      "DelegateTo": 383,
      "ScriptId": 379,
      "EmailTo": "ezra@schaden.info",
      "SmsTo": "qui",
      "ReplyTemplateIdCustomer": 589,
      "ReplyTemplateIdUser": 563,
      "ReplyTemplateIdCatmast": 801,
      "ReplyTemplateIdEmail": 744,
      "RtiCustomerSms": 332,
      "ReplyTemplateIdUserSms": 692,
      "ReplyTemplateIdCatmastSms": 782,
      "ReplyTemplateIdSms": 815,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 232
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 426
    }
  }
}
```
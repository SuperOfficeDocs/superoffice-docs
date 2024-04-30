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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 31,
  "Name": "Rempel-Bosco",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 971,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 434,
  "MonStart": "2013-02-09T11:44:33.9158989+01:00",
  "MonStop": "2012-04-10T11:44:33.9158989+02:00",
  "TueStart": "2020-07-22T11:44:33.9158989+02:00",
  "TueStop": "2009-06-06T11:44:33.9158989+02:00",
  "WedStart": "2004-09-27T11:44:33.9158989+02:00",
  "WedStop": "2005-03-13T11:44:33.9158989+01:00",
  "ThuStart": "2004-11-23T11:44:33.9158989+01:00",
  "ThuStop": "2001-05-28T11:44:33.9158989+02:00",
  "FriStart": "2008-08-26T11:44:33.9158989+02:00",
  "FriStop": "2005-01-06T11:44:33.9158989+01:00",
  "SatStart": "2012-09-10T11:44:33.9158989+02:00",
  "SatStop": "2021-05-16T11:44:33.9158989+02:00",
  "SunStart": "2005-05-07T11:44:33.9158989+02:00",
  "SunStop": "1999-04-12T11:44:33.9158989+02:00",
  "NonDates": [
    "fugit",
    "qui"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 684,
      "AlertLevel": 670,
      "AlertTimeout": 28,
      "Action": 344,
      "DelegateTo": 996,
      "ScriptId": 664,
      "EmailTo": "earnestine@schmeler.info",
      "SmsTo": "vitae",
      "ReplyTemplateIdCustomer": 3,
      "ReplyTemplateIdUser": 234,
      "ReplyTemplateIdCatmast": 788,
      "ReplyTemplateIdEmail": 745,
      "RtiCustomerSms": 666,
      "ReplyTemplateIdUserSms": 435,
      "ReplyTemplateIdCatmastSms": 311,
      "ReplyTemplateIdSms": 91
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 270,
  "Name": "Considine-Kihn",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 658,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 317,
  "MonStart": "2022-05-06T11:44:33.9158989+02:00",
  "MonStop": "2000-06-13T11:44:33.9158989+02:00",
  "TueStart": "2013-03-26T11:44:33.9158989+01:00",
  "TueStop": "2002-07-16T11:44:33.9158989+02:00",
  "WedStart": "2014-09-28T11:44:33.9158989+02:00",
  "WedStop": "2018-08-04T11:44:33.9158989+02:00",
  "ThuStart": "2001-01-29T11:44:33.9158989+01:00",
  "ThuStop": "2008-08-26T11:44:33.9158989+02:00",
  "FriStart": "2003-02-21T11:44:33.9158989+01:00",
  "FriStop": "2014-12-05T11:44:33.9158989+01:00",
  "SatStart": "2018-03-31T11:44:33.9158989+02:00",
  "SatStop": "2018-04-10T11:44:33.9158989+02:00",
  "SunStart": "1998-07-15T11:44:33.9158989+02:00",
  "SunStop": "2003-07-27T11:44:33.9158989+02:00",
  "NonDates": [
    "et",
    "fugit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 392,
      "AlertLevel": 259,
      "AlertTimeout": 960,
      "Action": 308,
      "DelegateTo": 450,
      "ScriptId": 959,
      "EmailTo": "annamarie_rodriguez@wilderman.name",
      "SmsTo": "quos",
      "ReplyTemplateIdCustomer": 873,
      "ReplyTemplateIdUser": 722,
      "ReplyTemplateIdCatmast": 859,
      "ReplyTemplateIdEmail": 296,
      "RtiCustomerSms": 237,
      "ReplyTemplateIdUserSms": 470,
      "ReplyTemplateIdCatmastSms": 115,
      "ReplyTemplateIdSms": 810,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 411
    }
  }
}
```
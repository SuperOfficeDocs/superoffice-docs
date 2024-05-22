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
  "TicketPriorityId": 629,
  "Name": "McGlynn, Moore and Roob",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 738,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 379,
  "MonStart": "2015-04-03T12:57:34.2273331+02:00",
  "MonStop": "2004-04-24T12:57:34.2273331+02:00",
  "TueStart": "2013-12-06T12:57:34.2273331+01:00",
  "TueStop": "2006-04-27T12:57:34.2273331+02:00",
  "WedStart": "1997-06-27T12:57:34.2273331+02:00",
  "WedStop": "2005-03-21T12:57:34.2273331+01:00",
  "ThuStart": "2013-02-02T12:57:34.2273331+01:00",
  "ThuStop": "2000-03-22T12:57:34.2273331+01:00",
  "FriStart": "2021-11-15T12:57:34.2273331+01:00",
  "FriStop": "2011-11-30T12:57:34.2273331+01:00",
  "SatStart": "2005-02-02T12:57:34.2273331+01:00",
  "SatStop": "2000-08-01T12:57:34.2273331+02:00",
  "SunStart": "2013-04-18T12:57:34.2273331+02:00",
  "SunStop": "2004-01-16T12:57:34.2273331+01:00",
  "NonDates": [
    "dolores",
    "tempora"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 216,
      "AlertLevel": 613,
      "AlertTimeout": 435,
      "Action": 276,
      "DelegateTo": 725,
      "ScriptId": 607,
      "EmailTo": "liam@spinka.biz",
      "SmsTo": "eum",
      "ReplyTemplateIdCustomer": 529,
      "ReplyTemplateIdUser": 924,
      "ReplyTemplateIdCatmast": 764,
      "ReplyTemplateIdEmail": 489,
      "RtiCustomerSms": 256,
      "ReplyTemplateIdUserSms": 200,
      "ReplyTemplateIdCatmastSms": 399,
      "ReplyTemplateIdSms": 48
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 44,
  "Name": "Kunze Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 164,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 538,
  "MonStart": "2015-08-05T12:57:34.2273331+02:00",
  "MonStop": "2021-01-12T12:57:34.2273331+01:00",
  "TueStart": "2013-02-02T12:57:34.2273331+01:00",
  "TueStop": "2002-01-29T12:57:34.2273331+01:00",
  "WedStart": "2005-02-21T12:57:34.2273331+01:00",
  "WedStop": "2021-09-20T12:57:34.2273331+02:00",
  "ThuStart": "2008-01-14T12:57:34.2273331+01:00",
  "ThuStop": "2016-02-07T12:57:34.2273331+01:00",
  "FriStart": "2017-11-24T12:57:34.2273331+01:00",
  "FriStop": "2020-03-15T12:57:34.2273331+01:00",
  "SatStart": "1998-11-14T12:57:34.2273331+01:00",
  "SatStop": "2010-10-24T12:57:34.2273331+02:00",
  "SunStart": "2000-11-16T12:57:34.2273331+01:00",
  "SunStop": "2006-12-22T12:57:34.2273331+01:00",
  "NonDates": [
    "temporibus",
    "quaerat"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 735,
      "AlertLevel": 80,
      "AlertTimeout": 900,
      "Action": 127,
      "DelegateTo": 386,
      "ScriptId": 72,
      "EmailTo": "arlo@faykilback.co.uk",
      "SmsTo": "porro",
      "ReplyTemplateIdCustomer": 138,
      "ReplyTemplateIdUser": 308,
      "ReplyTemplateIdCatmast": 250,
      "ReplyTemplateIdEmail": 333,
      "RtiCustomerSms": 775,
      "ReplyTemplateIdUserSms": 826,
      "ReplyTemplateIdCatmastSms": 766,
      "ReplyTemplateIdSms": 320,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 700
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 403
    }
  }
}
```
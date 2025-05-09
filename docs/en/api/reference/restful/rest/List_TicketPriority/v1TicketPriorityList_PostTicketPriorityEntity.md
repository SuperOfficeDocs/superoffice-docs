---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
generated: true
---

# POST List/TicketPriority/Items

```http
POST /api/v1/List/TicketPriority/Items
```

Create a new TicketPriorityEntity list item


Calls the List agent service SaveTicketPriorityEntity.







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

## Request Body: newEntity 

The TicketPriorityEntity to be created. 

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
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 274,
  "Name": "Torphy, Gaylord and Gaylord",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 425,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 812,
  "MonStart": "2005-07-16T16:32:49.0244447+02:00",
  "MonStop": "2002-12-12T16:32:49.0244447+01:00",
  "TueStart": "2008-07-10T16:32:49.0244447+02:00",
  "TueStop": "2011-05-28T16:32:49.0244447+02:00",
  "WedStart": "2011-08-16T16:32:49.0244447+02:00",
  "WedStop": "2005-02-12T16:32:49.0244447+01:00",
  "ThuStart": "2013-04-15T16:32:49.0244447+02:00",
  "ThuStop": "2024-06-18T16:32:49.0244447+02:00",
  "FriStart": "2007-10-21T16:32:49.0244447+02:00",
  "FriStop": "2005-09-27T16:32:49.0244447+02:00",
  "SatStart": "2007-09-10T16:32:49.0244447+02:00",
  "SatStop": "2006-07-10T16:32:49.0244447+02:00",
  "SunStart": "1999-06-20T16:32:49.0244447+02:00",
  "SunStop": "2013-04-25T16:32:49.0244447+02:00",
  "NonDates": [
    "consectetur",
    "dolor"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 951,
      "AlertLevel": 235,
      "AlertTimeout": 973,
      "Action": 319,
      "DelegateTo": 825,
      "ScriptId": 755,
      "EmailTo": "gloria_schaefer@oconnerlockman.biz",
      "SmsTo": "non",
      "ReplyTemplateIdCustomer": 731,
      "ReplyTemplateIdUser": 185,
      "ReplyTemplateIdCatmast": 343,
      "ReplyTemplateIdEmail": 192,
      "RtiCustomerSms": 31,
      "ReplyTemplateIdUserSms": 184,
      "ReplyTemplateIdCatmastSms": 276,
      "ReplyTemplateIdSms": 918
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 512,
  "Name": "Tillman Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 763,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 996,
  "MonStart": "2008-02-14T16:32:49.0244447+01:00",
  "MonStop": "2002-05-02T16:32:49.0244447+02:00",
  "TueStart": "2003-11-18T16:32:49.0244447+01:00",
  "TueStop": "2021-02-16T16:32:49.0244447+01:00",
  "WedStart": "2018-09-04T16:32:49.0244447+02:00",
  "WedStop": "2023-02-26T16:32:49.0244447+01:00",
  "ThuStart": "2001-07-30T16:32:49.0244447+02:00",
  "ThuStop": "2001-02-27T16:32:49.0244447+01:00",
  "FriStart": "2011-05-15T16:32:49.0244447+02:00",
  "FriStop": "2016-11-27T16:32:49.0244447+01:00",
  "SatStart": "2002-08-22T16:32:49.0244447+02:00",
  "SatStop": "2006-03-21T16:32:49.0244447+01:00",
  "SunStart": "2011-09-25T16:32:49.0244447+02:00",
  "SunStop": "2016-04-14T16:32:49.0244447+02:00",
  "NonDates": [
    "nihil",
    "rerum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 846,
      "AlertLevel": 18,
      "AlertTimeout": 549,
      "Action": 232,
      "DelegateTo": 153,
      "ScriptId": 837,
      "EmailTo": "ramona_harber@howell.co.uk",
      "SmsTo": "alias",
      "ReplyTemplateIdCustomer": 856,
      "ReplyTemplateIdUser": 683,
      "ReplyTemplateIdCatmast": 660,
      "ReplyTemplateIdEmail": 986,
      "RtiCustomerSms": 928,
      "ReplyTemplateIdUserSms": 700,
      "ReplyTemplateIdCatmastSms": 191,
      "ReplyTemplateIdSms": 177,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 203
    }
  }
}
```
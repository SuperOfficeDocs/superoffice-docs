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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 621,
  "Name": "Shields Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 499,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 590,
  "MonStart": "2020-01-17T16:00:49.3834069+01:00",
  "MonStop": "2009-05-09T16:00:49.3834069+02:00",
  "TueStart": "2010-05-09T16:00:49.3834069+02:00",
  "TueStop": "2008-09-14T16:00:49.3834069+02:00",
  "WedStart": "2018-07-30T16:00:49.3834069+02:00",
  "WedStop": "2001-12-24T16:00:49.3834069+01:00",
  "ThuStart": "1997-03-05T16:00:49.3834069+01:00",
  "ThuStop": "2020-02-13T16:00:49.3834069+01:00",
  "FriStart": "2020-05-09T16:00:49.3834069+02:00",
  "FriStop": "2005-05-29T16:00:49.3834069+02:00",
  "SatStart": "2007-07-26T16:00:49.3834069+02:00",
  "SatStop": "2002-06-29T16:00:49.3834069+02:00",
  "SunStart": "2002-11-25T16:00:49.3834069+01:00",
  "SunStop": "2009-09-17T16:00:49.3834069+02:00",
  "NonDates": [
    "consectetur",
    "qui"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 342,
      "AlertLevel": 548,
      "AlertTimeout": 326,
      "Action": 652,
      "DelegateTo": 42,
      "ScriptId": 958,
      "EmailTo": "laverne_sauer@mitchell.info",
      "SmsTo": "quibusdam",
      "ReplyTemplateIdCustomer": 376,
      "ReplyTemplateIdUser": 357,
      "ReplyTemplateIdCatmast": 183,
      "ReplyTemplateIdEmail": 588,
      "RtiCustomerSms": 754,
      "ReplyTemplateIdUserSms": 362,
      "ReplyTemplateIdCatmastSms": 335,
      "ReplyTemplateIdSms": 919
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 336,
  "Name": "Gerlach, Corkery and Emard",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 61,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 153,
  "MonStart": "2007-06-21T16:00:49.3834069+02:00",
  "MonStop": "1998-12-09T16:00:49.3834069+01:00",
  "TueStart": "2018-07-18T16:00:49.3834069+02:00",
  "TueStop": "2010-02-03T16:00:49.3834069+01:00",
  "WedStart": "2023-04-26T16:00:49.3834069+02:00",
  "WedStop": "1996-02-17T16:00:49.3834069+01:00",
  "ThuStart": "1997-10-24T16:00:49.3834069+02:00",
  "ThuStop": "2015-05-07T16:00:49.3834069+02:00",
  "FriStart": "1997-09-11T16:00:49.3834069+02:00",
  "FriStop": "2020-12-20T16:00:49.3834069+01:00",
  "SatStart": "2021-04-21T16:00:49.3834069+02:00",
  "SatStop": "2001-11-11T16:00:49.3834069+01:00",
  "SunStart": "2001-11-01T16:00:49.3834069+01:00",
  "SunStop": "1998-12-06T16:00:49.3834069+01:00",
  "NonDates": [
    "omnis",
    "magnam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 471,
      "AlertLevel": 229,
      "AlertTimeout": 522,
      "Action": 233,
      "DelegateTo": 571,
      "ScriptId": 540,
      "EmailTo": "jazmyn@fisherschmidt.com",
      "SmsTo": "impedit",
      "ReplyTemplateIdCustomer": 905,
      "ReplyTemplateIdUser": 942,
      "ReplyTemplateIdCatmast": 628,
      "ReplyTemplateIdEmail": 939,
      "RtiCustomerSms": 126,
      "ReplyTemplateIdUserSms": 173,
      "ReplyTemplateIdCatmastSms": 43,
      "ReplyTemplateIdSms": 384,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 10
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 164
    }
  }
}
```
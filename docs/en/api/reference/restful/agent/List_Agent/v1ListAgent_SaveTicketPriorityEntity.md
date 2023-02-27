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
  "TicketPriorityId": 889,
  "Name": "Sanford, Greenfelder and VonRueden",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 456,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 680,
  "MonStart": "2022-03-24T14:19:03.7019992+01:00",
  "MonStop": "2000-12-19T14:19:03.7019992+01:00",
  "TueStart": "2022-11-22T14:19:03.7019992+01:00",
  "TueStop": "2000-02-22T14:19:03.7019992+01:00",
  "WedStart": "2012-08-06T14:19:03.7019992+02:00",
  "WedStop": "2003-04-10T14:19:03.7019992+02:00",
  "ThuStart": "2022-04-20T14:19:03.7019992+02:00",
  "ThuStop": "2008-06-16T14:19:03.7019992+02:00",
  "FriStart": "2021-11-17T14:19:03.7019992+01:00",
  "FriStop": "2004-04-16T14:19:03.7019992+02:00",
  "SatStart": "2004-12-05T14:19:03.7019992+01:00",
  "SatStop": "2011-06-17T14:19:03.7019992+02:00",
  "SunStart": "1998-10-01T14:19:03.7019992+02:00",
  "SunStop": "2011-05-08T14:19:03.7019992+02:00",
  "NonDates": [
    "mollitia",
    "fugit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 847,
      "AlertLevel": 939,
      "AlertTimeout": 255,
      "Action": 506,
      "DelegateTo": 442,
      "ScriptId": 669,
      "EmailTo": "louisa.gusikowski@runteberge.name",
      "SmsTo": "temporibus",
      "ReplyTemplateIdCustomer": 689,
      "ReplyTemplateIdUser": 513,
      "ReplyTemplateIdCatmast": 897,
      "ReplyTemplateIdEmail": 810,
      "RtiCustomerSms": 929,
      "ReplyTemplateIdUserSms": 653,
      "ReplyTemplateIdCatmastSms": 392,
      "ReplyTemplateIdSms": 97
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 444,
  "Name": "Cruickshank Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 476,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 28,
  "MonStart": "1998-12-24T14:19:03.7019992+01:00",
  "MonStop": "2006-12-23T14:19:03.7019992+01:00",
  "TueStart": "2018-01-11T14:19:03.7019992+01:00",
  "TueStop": "2002-11-15T14:19:03.7019992+01:00",
  "WedStart": "1997-08-06T14:19:03.7019992+02:00",
  "WedStop": "2001-12-01T14:19:03.7019992+01:00",
  "ThuStart": "2017-11-08T14:19:03.7019992+01:00",
  "ThuStop": "2015-04-10T14:19:03.7019992+02:00",
  "FriStart": "2006-02-27T14:19:03.7019992+01:00",
  "FriStop": "2003-04-10T14:19:03.7019992+02:00",
  "SatStart": "2016-02-16T14:19:03.7019992+01:00",
  "SatStop": "2021-12-05T14:19:03.7019992+01:00",
  "SunStart": "2016-09-12T14:19:03.7019992+02:00",
  "SunStop": "2005-04-23T14:19:03.7019992+02:00",
  "NonDates": [
    "quo",
    "quo"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 33,
      "AlertLevel": 216,
      "AlertTimeout": 907,
      "Action": 768,
      "DelegateTo": 602,
      "ScriptId": 506,
      "EmailTo": "ned_reinger@feil.us",
      "SmsTo": "corrupti",
      "ReplyTemplateIdCustomer": 942,
      "ReplyTemplateIdUser": 84,
      "ReplyTemplateIdCatmast": 167,
      "ReplyTemplateIdEmail": 230,
      "RtiCustomerSms": 351,
      "ReplyTemplateIdUserSms": 756,
      "ReplyTemplateIdCatmastSms": 403,
      "ReplyTemplateIdSms": 39,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 958
    }
  }
}
```
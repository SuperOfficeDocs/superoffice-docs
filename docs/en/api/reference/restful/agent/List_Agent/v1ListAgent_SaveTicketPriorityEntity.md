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
  "TicketPriorityId": 225,
  "Name": "Bahringer, Pacocha and Steuber",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 932,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 451,
  "MonStart": "2004-04-08T12:01:27.97842+02:00",
  "MonStop": "2017-01-31T12:01:27.97842+01:00",
  "TueStart": "2000-03-02T12:01:27.97842+01:00",
  "TueStop": "2015-04-05T12:01:27.97842+02:00",
  "WedStart": "2018-06-21T12:01:27.97842+02:00",
  "WedStop": "2016-09-06T12:01:27.97842+02:00",
  "ThuStart": "2017-04-02T12:01:27.97842+02:00",
  "ThuStop": "1999-02-25T12:01:27.97842+01:00",
  "FriStart": "2018-05-29T12:01:27.97842+02:00",
  "FriStop": "2017-04-25T12:01:27.97842+02:00",
  "SatStart": "2000-12-04T12:01:27.97842+01:00",
  "SatStop": "1999-07-22T12:01:27.97842+02:00",
  "SunStart": "2011-04-27T12:01:27.97842+02:00",
  "SunStop": "2008-06-04T12:01:27.97842+02:00",
  "NonDates": [
    "aut",
    "cupiditate"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 666,
      "AlertLevel": 153,
      "AlertTimeout": 163,
      "Action": 406,
      "DelegateTo": 50,
      "ScriptId": 32,
      "EmailTo": "moises@bernierbeahan.ca",
      "SmsTo": "aut",
      "ReplyTemplateIdCustomer": 927,
      "ReplyTemplateIdUser": 981,
      "ReplyTemplateIdCatmast": 742,
      "ReplyTemplateIdEmail": 803,
      "RtiCustomerSms": 589,
      "ReplyTemplateIdUserSms": 925,
      "ReplyTemplateIdCatmastSms": 762,
      "ReplyTemplateIdSms": 787
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 243,
  "Name": "Beer, Bahringer and Collier",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 554,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 210,
  "MonStart": "2003-10-23T12:01:27.97842+02:00",
  "MonStop": "2015-02-16T12:01:27.97842+01:00",
  "TueStart": "2023-03-05T12:01:27.97842+01:00",
  "TueStop": "2022-03-21T12:01:27.97842+01:00",
  "WedStart": "2016-10-04T12:01:27.97842+02:00",
  "WedStop": "2001-12-30T12:01:27.97842+01:00",
  "ThuStart": "2009-05-10T12:01:27.97842+02:00",
  "ThuStop": "2020-12-15T12:01:27.97842+01:00",
  "FriStart": "2022-08-25T12:01:27.97842+02:00",
  "FriStop": "2010-04-04T12:01:27.97842+02:00",
  "SatStart": "2003-10-07T12:01:27.97842+02:00",
  "SatStop": "2016-03-24T12:01:27.97842+01:00",
  "SunStart": "1998-07-21T12:01:27.97842+02:00",
  "SunStop": "2004-12-29T12:01:27.97842+01:00",
  "NonDates": [
    "adipisci",
    "doloribus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 145,
      "AlertLevel": 335,
      "AlertTimeout": 344,
      "Action": 376,
      "DelegateTo": 764,
      "ScriptId": 668,
      "EmailTo": "vernice_goodwin@walter.ca",
      "SmsTo": "qui",
      "ReplyTemplateIdCustomer": 597,
      "ReplyTemplateIdUser": 886,
      "ReplyTemplateIdCatmast": 465,
      "ReplyTemplateIdEmail": 133,
      "RtiCustomerSms": 967,
      "ReplyTemplateIdUserSms": 455,
      "ReplyTemplateIdCatmastSms": 305,
      "ReplyTemplateIdSms": 499,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 458
    }
  }
}
```
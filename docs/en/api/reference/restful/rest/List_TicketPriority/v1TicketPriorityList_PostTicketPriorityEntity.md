---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 933,
  "Name": "Schowalter, Powlowski and Volkman",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 387,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 395,
  "MonStart": "2018-06-12T17:37:40.4155002+02:00",
  "MonStop": "2012-05-18T17:37:40.4155002+02:00",
  "TueStart": "2013-04-11T17:37:40.4155002+02:00",
  "TueStop": "2002-04-04T17:37:40.4155002+02:00",
  "WedStart": "2002-02-28T17:37:40.4155002+01:00",
  "WedStop": "2008-09-02T17:37:40.4155002+02:00",
  "ThuStart": "2012-08-05T17:37:40.4155002+02:00",
  "ThuStop": "2014-10-24T17:37:40.4155002+02:00",
  "FriStart": "2004-03-19T17:37:40.4155002+01:00",
  "FriStop": "2011-03-23T17:37:40.4155002+01:00",
  "SatStart": "2005-09-10T17:37:40.4155002+02:00",
  "SatStop": "2020-07-26T17:37:40.4155002+02:00",
  "SunStart": "2022-03-14T17:37:40.4155002+01:00",
  "SunStop": "2022-11-27T17:37:40.4155002+01:00",
  "NonDates": [
    "neque",
    "quia"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 891,
      "AlertLevel": 914,
      "AlertTimeout": 678,
      "Action": 250,
      "DelegateTo": 527,
      "ScriptId": 1001,
      "EmailTo": "kaylee@jerde.name",
      "SmsTo": "est",
      "ReplyTemplateIdCustomer": 495,
      "ReplyTemplateIdUser": 441,
      "ReplyTemplateIdCatmast": 267,
      "ReplyTemplateIdEmail": 41,
      "RtiCustomerSms": 268,
      "ReplyTemplateIdUserSms": 986,
      "ReplyTemplateIdCatmastSms": 922,
      "ReplyTemplateIdSms": 240
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 905,
  "Name": "Powlowski Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 515,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 327,
  "MonStart": "2002-10-29T17:37:40.4165009+01:00",
  "MonStop": "2007-10-26T17:37:40.4165009+02:00",
  "TueStart": "2013-04-18T17:37:40.4165009+02:00",
  "TueStop": "2022-10-05T17:37:40.4165009+02:00",
  "WedStart": "2007-10-17T17:37:40.4165009+02:00",
  "WedStop": "2003-08-24T17:37:40.4165009+02:00",
  "ThuStart": "2003-06-03T17:37:40.4165009+02:00",
  "ThuStop": "2015-01-31T17:37:40.4165009+01:00",
  "FriStart": "2017-09-14T17:37:40.4165009+02:00",
  "FriStop": "2013-11-08T17:37:40.4165009+01:00",
  "SatStart": "1996-06-30T17:37:40.4165009+02:00",
  "SatStop": "2017-12-25T17:37:40.4165009+01:00",
  "SunStart": "2001-12-17T17:37:40.4165009+01:00",
  "SunStop": "2000-07-05T17:37:40.4165009+02:00",
  "NonDates": [
    "sit",
    "ex"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 921,
      "AlertLevel": 267,
      "AlertTimeout": 975,
      "Action": 88,
      "DelegateTo": 213,
      "ScriptId": 54,
      "EmailTo": "turner_schoen@ondricka.com",
      "SmsTo": "enim",
      "ReplyTemplateIdCustomer": 358,
      "ReplyTemplateIdUser": 673,
      "ReplyTemplateIdCatmast": 258,
      "ReplyTemplateIdEmail": 888,
      "RtiCustomerSms": 814,
      "ReplyTemplateIdUserSms": 347,
      "ReplyTemplateIdCatmastSms": 260,
      "ReplyTemplateIdSms": 702,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 868
    }
  }
}
```
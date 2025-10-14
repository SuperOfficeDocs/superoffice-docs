---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
generated: true
content_type: reference
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 298,
  "Name": "Schmidt, Hoppe and Hagenes",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 764,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 985,
  "MonStart": "2023-06-25T03:40:57.1500758+02:00",
  "MonStop": "2021-07-29T03:40:57.1500758+02:00",
  "TueStart": "2001-09-14T03:40:57.1500758+02:00",
  "TueStop": "2013-01-16T03:40:57.1500758+01:00",
  "WedStart": "2003-04-25T03:40:57.1500758+02:00",
  "WedStop": "2010-05-05T03:40:57.1500758+02:00",
  "ThuStart": "2012-03-24T03:40:57.1500758+01:00",
  "ThuStop": "2018-09-23T03:40:57.1500758+02:00",
  "FriStart": "2003-12-14T03:40:57.1500758+01:00",
  "FriStop": "2000-02-06T03:40:57.1500758+01:00",
  "SatStart": "2022-01-14T03:40:57.1500758+01:00",
  "SatStop": "1999-12-24T03:40:57.1500758+01:00",
  "SunStart": "2014-10-11T03:40:57.1500758+02:00",
  "SunStop": "2018-03-15T03:40:57.1500758+01:00",
  "NonDates": [
    "ratione",
    "eum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 462,
      "AlertLevel": 572,
      "AlertTimeout": 114,
      "Action": 736,
      "DelegateTo": 809,
      "ScriptId": 462,
      "EmailTo": "freddy@doylepouros.ca",
      "SmsTo": "id",
      "ReplyTemplateIdCustomer": 456,
      "ReplyTemplateIdUser": 251,
      "ReplyTemplateIdCatmast": 348,
      "ReplyTemplateIdEmail": 50,
      "RtiCustomerSms": 41,
      "ReplyTemplateIdUserSms": 921,
      "ReplyTemplateIdCatmastSms": 517,
      "ReplyTemplateIdSms": 854
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 40,
  "Name": "Sporer, Morissette and Jenkins",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 392,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 338,
  "MonStart": "2023-05-11T03:40:57.1500758+02:00",
  "MonStop": "2021-03-17T03:40:57.1500758+01:00",
  "TueStart": "2009-05-25T03:40:57.1500758+02:00",
  "TueStop": "2014-06-03T03:40:57.1500758+02:00",
  "WedStart": "2017-10-01T03:40:57.1500758+02:00",
  "WedStop": "2007-05-14T03:40:57.1500758+02:00",
  "ThuStart": "2021-07-14T03:40:57.1500758+02:00",
  "ThuStop": "2001-09-03T03:40:57.1500758+02:00",
  "FriStart": "2005-04-15T03:40:57.1500758+02:00",
  "FriStop": "2012-01-31T03:40:57.1500758+01:00",
  "SatStart": "2019-07-02T03:40:57.1500758+02:00",
  "SatStop": "2025-06-22T03:40:57.1500758+02:00",
  "SunStart": "2012-01-04T03:40:57.1500758+01:00",
  "SunStop": "2021-12-16T03:40:57.1500758+01:00",
  "NonDates": [
    "aut",
    "quis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 915,
      "AlertLevel": 657,
      "AlertTimeout": 625,
      "Action": 358,
      "DelegateTo": 703,
      "ScriptId": 632,
      "EmailTo": "green@harris.ca",
      "SmsTo": "distinctio",
      "ReplyTemplateIdCustomer": 684,
      "ReplyTemplateIdUser": 185,
      "ReplyTemplateIdCatmast": 314,
      "ReplyTemplateIdEmail": 489,
      "RtiCustomerSms": 842,
      "ReplyTemplateIdUserSms": 718,
      "ReplyTemplateIdCatmastSms": 602,
      "ReplyTemplateIdSms": 971,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 86
    }
  }
}
```
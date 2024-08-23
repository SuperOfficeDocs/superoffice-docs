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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 909,
  "Name": "Kirlin, Nitzsche and Bergstrom",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 821,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 574,
  "MonStart": "2012-12-21T13:28:33.2263448+01:00",
  "MonStop": "2001-05-31T13:28:33.2263448+02:00",
  "TueStart": "2011-04-03T13:28:33.2263448+02:00",
  "TueStop": "2017-01-28T13:28:33.2263448+01:00",
  "WedStart": "2004-07-17T13:28:33.2263448+02:00",
  "WedStop": "2019-07-01T13:28:33.2263448+02:00",
  "ThuStart": "2004-05-13T13:28:33.2263448+02:00",
  "ThuStop": "2013-04-16T13:28:33.2263448+02:00",
  "FriStart": "2014-10-17T13:28:33.2263448+02:00",
  "FriStop": "2004-08-27T13:28:33.2263448+02:00",
  "SatStart": "2017-06-01T13:28:33.2263448+02:00",
  "SatStop": "2002-07-08T13:28:33.2263448+02:00",
  "SunStart": "2002-08-05T13:28:33.2263448+02:00",
  "SunStop": "2004-07-15T13:28:33.2263448+02:00",
  "NonDates": [
    "nostrum",
    "animi"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 423,
      "AlertLevel": 998,
      "AlertTimeout": 425,
      "Action": 768,
      "DelegateTo": 338,
      "ScriptId": 124,
      "EmailTo": "savanah@lueilwitz.name",
      "SmsTo": "omnis",
      "ReplyTemplateIdCustomer": 148,
      "ReplyTemplateIdUser": 936,
      "ReplyTemplateIdCatmast": 353,
      "ReplyTemplateIdEmail": 623,
      "RtiCustomerSms": 543,
      "ReplyTemplateIdUserSms": 371,
      "ReplyTemplateIdCatmastSms": 818,
      "ReplyTemplateIdSms": 266
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 951,
  "Name": "Grant Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 19,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 614,
  "MonStart": "2020-08-15T13:28:33.2263448+02:00",
  "MonStop": "2006-12-23T13:28:33.2263448+01:00",
  "TueStart": "2002-10-04T13:28:33.2263448+02:00",
  "TueStop": "2024-07-19T13:28:33.2263448+02:00",
  "WedStart": "2007-01-10T13:28:33.2263448+01:00",
  "WedStop": "2000-09-01T13:28:33.2263448+02:00",
  "ThuStart": "1997-06-04T13:28:33.2263448+02:00",
  "ThuStop": "2010-04-02T13:28:33.2263448+02:00",
  "FriStart": "2021-03-15T13:28:33.2263448+01:00",
  "FriStop": "2002-04-19T13:28:33.2263448+02:00",
  "SatStart": "2006-10-12T13:28:33.2263448+02:00",
  "SatStop": "2019-11-02T13:28:33.2263448+01:00",
  "SunStart": "2021-03-26T13:28:33.2263448+01:00",
  "SunStop": "1997-10-08T13:28:33.2263448+02:00",
  "NonDates": [
    "eum",
    "omnis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 210,
      "AlertLevel": 754,
      "AlertTimeout": 698,
      "Action": 876,
      "DelegateTo": 985,
      "ScriptId": 559,
      "EmailTo": "lilly.altenwerth@schummschmidt.co.uk",
      "SmsTo": "corrupti",
      "ReplyTemplateIdCustomer": 750,
      "ReplyTemplateIdUser": 766,
      "ReplyTemplateIdCatmast": 167,
      "ReplyTemplateIdEmail": 151,
      "RtiCustomerSms": 148,
      "ReplyTemplateIdUserSms": 269,
      "ReplyTemplateIdCatmastSms": 185,
      "ReplyTemplateIdSms": 138,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 854
    }
  }
}
```
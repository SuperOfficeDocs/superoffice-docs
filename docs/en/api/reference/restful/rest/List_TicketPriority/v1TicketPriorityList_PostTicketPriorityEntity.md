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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 155,
  "Name": "McDermott-Weimann",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 191,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 414,
  "MonStart": "2006-10-18T02:49:52.5784525+02:00",
  "MonStop": "2016-09-19T02:49:52.5784525+02:00",
  "TueStart": "2022-04-21T02:49:52.5784525+02:00",
  "TueStop": "2004-09-13T02:49:52.5784525+02:00",
  "WedStart": "1998-10-29T02:49:52.5784525+01:00",
  "WedStop": "2019-08-19T02:49:52.5784525+02:00",
  "ThuStart": "2013-10-01T02:49:52.5784525+02:00",
  "ThuStop": "2022-10-13T02:49:52.5784525+02:00",
  "FriStart": "2003-07-09T02:49:52.5784525+02:00",
  "FriStop": "2005-04-25T02:49:52.5784525+02:00",
  "SatStart": "1996-03-02T02:49:52.5784525+01:00",
  "SatStop": "2012-12-11T02:49:52.5784525+01:00",
  "SunStart": "2015-05-23T02:49:52.5784525+02:00",
  "SunStop": "2006-02-08T02:49:52.5784525+01:00",
  "NonDates": [
    "qui",
    "quam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 1001,
      "AlertLevel": 776,
      "AlertTimeout": 819,
      "Action": 212,
      "DelegateTo": 149,
      "ScriptId": 972,
      "EmailTo": "isabell_romaguera@mann.ca",
      "SmsTo": "soluta",
      "ReplyTemplateIdCustomer": 196,
      "ReplyTemplateIdUser": 878,
      "ReplyTemplateIdCatmast": 662,
      "ReplyTemplateIdEmail": 523,
      "RtiCustomerSms": 452,
      "ReplyTemplateIdUserSms": 447,
      "ReplyTemplateIdCatmastSms": 471,
      "ReplyTemplateIdSms": 294
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 857,
  "Name": "Adams, Ryan and Cummings",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 879,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 253,
  "MonStart": "2004-03-31T02:49:52.5784525+02:00",
  "MonStop": "2011-06-21T02:49:52.5784525+02:00",
  "TueStart": "2011-07-15T02:49:52.5784525+02:00",
  "TueStop": "2004-07-20T02:49:52.5784525+02:00",
  "WedStart": "2020-09-28T02:49:52.5784525+02:00",
  "WedStop": "2004-09-20T02:49:52.5784525+02:00",
  "ThuStart": "2021-02-18T02:49:52.5784525+01:00",
  "ThuStop": "2004-06-10T02:49:52.5784525+02:00",
  "FriStart": "2017-05-14T02:49:52.5784525+02:00",
  "FriStop": "2014-02-16T02:49:52.5784525+01:00",
  "SatStart": "2018-08-18T02:49:52.5784525+02:00",
  "SatStop": "2001-11-02T02:49:52.5784525+01:00",
  "SunStart": "1998-03-16T02:49:52.5784525+01:00",
  "SunStop": "1997-09-29T02:49:52.5784525+02:00",
  "NonDates": [
    "quaerat",
    "voluptatem"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 669,
      "AlertLevel": 199,
      "AlertTimeout": 56,
      "Action": 135,
      "DelegateTo": 928,
      "ScriptId": 34,
      "EmailTo": "angie_nader@kerluke.com",
      "SmsTo": "ipsum",
      "ReplyTemplateIdCustomer": 246,
      "ReplyTemplateIdUser": 153,
      "ReplyTemplateIdCatmast": 896,
      "ReplyTemplateIdEmail": 491,
      "RtiCustomerSms": 225,
      "ReplyTemplateIdUserSms": 930,
      "ReplyTemplateIdCatmastSms": 870,
      "ReplyTemplateIdSms": 28,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 315
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 514
    }
  }
}
```
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
  "TicketPriorityId": 462,
  "Name": "Rutherford, Bauch and Hickle",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 716,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 941,
  "MonStart": "2013-04-05T13:28:23.0231319+02:00",
  "MonStop": "2016-07-14T13:28:23.0231319+02:00",
  "TueStart": "1999-05-02T13:28:23.0231319+02:00",
  "TueStop": "2018-12-30T13:28:23.0231319+01:00",
  "WedStart": "2011-06-24T13:28:23.0231319+02:00",
  "WedStop": "2002-09-29T13:28:23.0231319+02:00",
  "ThuStart": "2021-11-22T13:28:23.0231319+01:00",
  "ThuStop": "2008-06-01T13:28:23.0231319+02:00",
  "FriStart": "2021-06-16T13:28:23.0231319+02:00",
  "FriStop": "2012-09-30T13:28:23.0231319+02:00",
  "SatStart": "2003-01-04T13:28:23.0231319+01:00",
  "SatStop": "2006-04-17T13:28:23.0231319+02:00",
  "SunStart": "2008-07-06T13:28:23.0231319+02:00",
  "SunStop": "2000-04-15T13:28:23.0231319+02:00",
  "NonDates": [
    "qui",
    "recusandae"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 935,
      "AlertLevel": 861,
      "AlertTimeout": 861,
      "Action": 84,
      "DelegateTo": 848,
      "ScriptId": 188,
      "EmailTo": "colt@legros.ca",
      "SmsTo": "veritatis",
      "ReplyTemplateIdCustomer": 75,
      "ReplyTemplateIdUser": 209,
      "ReplyTemplateIdCatmast": 723,
      "ReplyTemplateIdEmail": 546,
      "RtiCustomerSms": 707,
      "ReplyTemplateIdUserSms": 459,
      "ReplyTemplateIdCatmastSms": 383,
      "ReplyTemplateIdSms": 315
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 125,
  "Name": "Fahey, Rempel and Mosciski",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 932,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 187,
  "MonStart": "2016-12-21T13:28:23.0231319+01:00",
  "MonStop": "2000-02-22T13:28:23.0231319+01:00",
  "TueStart": "2012-09-28T13:28:23.0231319+02:00",
  "TueStop": "2002-01-14T13:28:23.0231319+01:00",
  "WedStart": "2001-07-01T13:28:23.0231319+02:00",
  "WedStop": "2014-02-07T13:28:23.0231319+01:00",
  "ThuStart": "2009-02-14T13:28:23.0231319+01:00",
  "ThuStop": "2023-10-03T13:28:23.0231319+02:00",
  "FriStart": "2019-11-20T13:28:23.0231319+01:00",
  "FriStop": "2000-09-06T13:28:23.0231319+02:00",
  "SatStart": "2020-02-26T13:28:23.0231319+01:00",
  "SatStop": "1997-06-20T13:28:23.0231319+02:00",
  "SunStart": "2001-09-12T13:28:23.0231319+02:00",
  "SunStop": "2008-01-17T13:28:23.0231319+01:00",
  "NonDates": [
    "unde",
    "aut"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 681,
      "AlertLevel": 247,
      "AlertTimeout": 476,
      "Action": 607,
      "DelegateTo": 656,
      "ScriptId": 695,
      "EmailTo": "lolita@hamill.ca",
      "SmsTo": "consequatur",
      "ReplyTemplateIdCustomer": 601,
      "ReplyTemplateIdUser": 47,
      "ReplyTemplateIdCatmast": 789,
      "ReplyTemplateIdEmail": 315,
      "RtiCustomerSms": 135,
      "ReplyTemplateIdUserSms": 96,
      "ReplyTemplateIdCatmastSms": 812,
      "ReplyTemplateIdSms": 676,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 542
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 840
    }
  }
}
```
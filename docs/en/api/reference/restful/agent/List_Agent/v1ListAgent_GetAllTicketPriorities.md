---
title: POST Agents/List/GetAllTicketPriorities
uid: v1ListAgent_GetAllTicketPriorities
generated: true
---

# POST Agents/List/GetAllTicketPriorities

```http
POST /api/v1/Agents/List/GetAllTicketPriorities
```

Returns all available ticket priorities.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetAllTicketPriorities?$select=name,department,category/id
```


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

## Request Body: request 

IncludeDeleted 

| Property Name | Type |  Description |
|----------------|------|--------------|
| IncludeDeleted | Boolean |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/List/GetAllTicketPriorities
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "IncludeDeleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TicketPriorityId": 558,
    "Name": "Breitenberg, Eichmann and Lebsack",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 356,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 250,
    "MonStart": "2008-02-28T12:01:27.9159153+01:00",
    "MonStop": "2024-08-04T12:01:27.9159153+02:00",
    "TueStart": "2020-07-05T12:01:27.9159153+02:00",
    "TueStop": "2001-05-30T12:01:27.9159153+02:00",
    "WedStart": "2021-04-22T12:01:27.9159153+02:00",
    "WedStop": "2014-07-09T12:01:27.9159153+02:00",
    "ThuStart": "1998-04-25T12:01:27.9159153+02:00",
    "ThuStop": "1998-02-10T12:01:27.9159153+01:00",
    "FriStart": "2015-07-02T12:01:27.9159153+02:00",
    "FriStop": "1999-04-14T12:01:27.9159153+02:00",
    "SatStart": "1999-03-26T12:01:27.9159153+01:00",
    "SatStop": "2017-03-02T12:01:27.9159153+01:00",
    "SunStart": "2005-03-28T12:01:27.9159153+02:00",
    "SunStop": "2021-07-22T12:01:27.9159153+02:00",
    "NonDates": [
      "veritatis",
      "voluptas"
    ],
    "EscalationLevels": [
      {
        "TicketAlertId": 847,
        "AlertLevel": 271,
        "AlertTimeout": 128,
        "Action": 178,
        "DelegateTo": 654,
        "ScriptId": 216,
        "EmailTo": "willy.zieme@bayer.uk",
        "SmsTo": "necessitatibus",
        "ReplyTemplateIdCustomer": 122,
        "ReplyTemplateIdUser": 193,
        "ReplyTemplateIdCatmast": 594,
        "ReplyTemplateIdEmail": 564,
        "RtiCustomerSms": 661,
        "ReplyTemplateIdUserSms": 146,
        "ReplyTemplateIdCatmastSms": 986,
        "ReplyTemplateIdSms": 981,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 476
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 201
      }
    }
  }
]
```
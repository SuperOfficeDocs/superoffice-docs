---
title: POST Agents/List/GetAllTicketPriorities
uid: v1ListAgent_GetAllTicketPriorities
generated: true
content_type: reference
---

# POST Agents/List/GetAllTicketPriorities

```http
POST /api/v1/Agents/List/GetAllTicketPriorities
```

Returns all available ticket priorities.


NsApiSlow threshold: 5000 ms.






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
    "TicketPriorityId": 840,
    "Name": "Schoen LLC",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 983,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 635,
    "MonStart": "2006-02-20T02:30:47.3819557+01:00",
    "MonStop": "2019-04-03T02:30:47.3819557+02:00",
    "TueStart": "2011-01-12T02:30:47.3819557+01:00",
    "TueStop": "2009-03-25T02:30:47.3819557+01:00",
    "WedStart": "2016-10-16T02:30:47.3819557+02:00",
    "WedStop": "2008-06-17T02:30:47.3819557+02:00",
    "ThuStart": "2002-03-07T02:30:47.3819557+01:00",
    "ThuStop": "2013-10-25T02:30:47.3819557+02:00",
    "FriStart": "2004-05-16T02:30:47.3819557+02:00",
    "FriStop": "2024-07-22T02:30:47.3819557+02:00",
    "SatStart": "2024-12-28T02:30:47.3819557+01:00",
    "SatStop": "2011-12-19T02:30:47.3819557+01:00",
    "SunStart": "2003-06-28T02:30:47.3819557+02:00",
    "SunStop": "2018-01-02T02:30:47.3819557+01:00",
    "NonDates": [
      "qui",
      "sunt"
    ],
    "EscalationLevels": [
      {
        "TicketAlertId": 862,
        "AlertLevel": 312,
        "AlertTimeout": 237,
        "Action": 354,
        "DelegateTo": 366,
        "ScriptId": 211,
        "EmailTo": "jeffrey.hoeger@goyettelind.com",
        "SmsTo": "quidem",
        "ReplyTemplateIdCustomer": 714,
        "ReplyTemplateIdUser": 978,
        "ReplyTemplateIdCatmast": 407,
        "ReplyTemplateIdEmail": 534,
        "RtiCustomerSms": 763,
        "ReplyTemplateIdUserSms": 645,
        "ReplyTemplateIdCatmastSms": 650,
        "ReplyTemplateIdSms": 15,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 348
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 440
      }
    }
  }
]
```
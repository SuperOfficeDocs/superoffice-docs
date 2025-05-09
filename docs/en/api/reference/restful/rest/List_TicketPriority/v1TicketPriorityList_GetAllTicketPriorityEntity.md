---
title: GET List/TicketPriority/Items
uid: v1TicketPriorityList_GetAllTicketPriorityEntity
generated: true
---

# GET List/TicketPriority/Items

```http
GET /api/v1/List/TicketPriority/Items
```

Gets a list of all TicketPriorityEntity list items.


Calls the List agent service GetAllTicketPriorityEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| includeDeleted | bool |   |

```http
GET /api/v1/List/TicketPriority/Items?includeDeleted=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TicketPriorityId": 588,
    "Name": "Osinski-D'Amore",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 715,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 339,
    "MonStart": "2004-04-22T16:32:49.0244447+02:00",
    "MonStop": "1998-12-20T16:32:49.0244447+01:00",
    "TueStart": "1999-09-27T16:32:49.0244447+02:00",
    "TueStop": "2010-01-08T16:32:49.0244447+01:00",
    "WedStart": "1999-05-02T16:32:49.0244447+02:00",
    "WedStop": "2017-05-11T16:32:49.0244447+02:00",
    "ThuStart": "2016-11-04T16:32:49.0244447+01:00",
    "ThuStop": "2007-08-16T16:32:49.0244447+02:00",
    "FriStart": "1999-11-27T16:32:49.0244447+01:00",
    "FriStop": "2023-07-10T16:32:49.0244447+02:00",
    "SatStart": "2005-12-26T16:32:49.0244447+01:00",
    "SatStop": "1998-02-03T16:32:49.0244447+01:00",
    "SunStart": "2022-07-30T16:32:49.0244447+02:00",
    "SunStop": "2004-06-12T16:32:49.0244447+02:00",
    "NonDates": [
      "sed",
      "repudiandae"
    ],
    "EscalationLevels": [
      {
        "TicketAlertId": 481,
        "AlertLevel": 4,
        "AlertTimeout": 50,
        "Action": 931,
        "DelegateTo": 748,
        "ScriptId": 77,
        "EmailTo": "julianne@greenholt.uk",
        "SmsTo": "quod",
        "ReplyTemplateIdCustomer": 506,
        "ReplyTemplateIdUser": 318,
        "ReplyTemplateIdCatmast": 517,
        "ReplyTemplateIdEmail": 142,
        "RtiCustomerSms": 74,
        "ReplyTemplateIdUserSms": 106,
        "ReplyTemplateIdCatmastSms": 224,
        "ReplyTemplateIdSms": 327,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 618
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 202
      }
    }
  }
]
```
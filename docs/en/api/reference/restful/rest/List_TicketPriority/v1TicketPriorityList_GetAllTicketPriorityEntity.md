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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TicketPriorityId": 207,
    "Name": "Conroy-Stoltenberg",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 891,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 36,
    "MonStart": "2021-02-03T10:18:01.1918781+01:00",
    "MonStop": "2018-08-02T10:18:01.1918781+02:00",
    "TueStart": "2012-11-14T10:18:01.1918781+01:00",
    "TueStop": "2011-01-03T10:18:01.1918781+01:00",
    "WedStart": "2020-03-10T10:18:01.1918781+01:00",
    "WedStop": "2019-07-27T10:18:01.1918781+02:00",
    "ThuStart": "2012-10-22T10:18:01.1918781+02:00",
    "ThuStop": "1998-03-17T10:18:01.1918781+01:00",
    "FriStart": "2002-10-03T10:18:01.1918781+02:00",
    "FriStop": "2002-03-13T10:18:01.1918781+01:00",
    "SatStart": "2020-03-02T10:18:01.1918781+01:00",
    "SatStop": "2005-02-07T10:18:01.1918781+01:00",
    "SunStart": "2001-10-08T10:18:01.1918781+02:00",
    "SunStop": "2015-06-15T10:18:01.1918781+02:00",
    "NonDates": [
      "nostrum",
      "et"
    ],
    "EscalationLevels": [
      {
        "TicketAlertId": 210,
        "AlertLevel": 929,
        "AlertTimeout": 578,
        "Action": 751,
        "DelegateTo": 482,
        "ScriptId": 160,
        "EmailTo": "albertha_murphy@wisozkyost.uk",
        "SmsTo": "sit",
        "ReplyTemplateIdCustomer": 694,
        "ReplyTemplateIdUser": 868,
        "ReplyTemplateIdCatmast": 702,
        "ReplyTemplateIdEmail": 42,
        "RtiCustomerSms": 590,
        "ReplyTemplateIdUserSms": 821,
        "ReplyTemplateIdCatmastSms": 183,
        "ReplyTemplateIdSms": 11,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 63
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 322
      }
    }
  }
]
```
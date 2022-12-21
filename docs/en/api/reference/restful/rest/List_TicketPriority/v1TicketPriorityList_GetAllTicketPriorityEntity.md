---
title: GET List/TicketPriority/Items
uid: v1TicketPriorityList_GetAllTicketPriorityEntity
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


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
    "TicketPriorityId": 265,
    "Name": "Thompson, O'Conner and Champlin",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 240,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 628,
    "MonStart": "2006-06-22T02:49:52.5784525+02:00",
    "MonStop": "2018-10-17T02:49:52.5784525+02:00",
    "TueStart": "2002-07-17T02:49:52.5784525+02:00",
    "TueStop": "2001-04-22T02:49:52.5784525+02:00",
    "WedStart": "2020-07-21T02:49:52.5784525+02:00",
    "WedStop": "2002-11-26T02:49:52.5784525+01:00",
    "ThuStart": "2011-04-02T02:49:52.5784525+02:00",
    "ThuStop": "2017-03-18T02:49:52.5784525+01:00",
    "FriStart": "2001-12-20T02:49:52.5784525+01:00",
    "FriStop": "2010-04-17T02:49:52.5784525+02:00",
    "SatStart": "2020-09-28T02:49:52.5784525+02:00",
    "SatStop": "2006-06-15T02:49:52.5784525+02:00",
    "SunStart": "2019-08-05T02:49:52.5784525+02:00",
    "SunStop": "2010-02-23T02:49:52.5784525+01:00",
    "NonDates": [
      "nulla",
      "magnam"
    ],
    "EscalationLevels": [
      {
        "TicketAlertId": 871,
        "AlertLevel": 891,
        "AlertTimeout": 56,
        "Action": 544,
        "DelegateTo": 805,
        "ScriptId": 308,
        "EmailTo": "kamille_bergstrom@schinner.name",
        "SmsTo": "iusto",
        "ReplyTemplateIdCustomer": 766,
        "ReplyTemplateIdUser": 234,
        "ReplyTemplateIdCatmast": 203,
        "ReplyTemplateIdEmail": 775,
        "RtiCustomerSms": 641,
        "ReplyTemplateIdUserSms": 71,
        "ReplyTemplateIdCatmastSms": 839,
        "ReplyTemplateIdSms": 518,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 916
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 102
      }
    }
  }
]
```
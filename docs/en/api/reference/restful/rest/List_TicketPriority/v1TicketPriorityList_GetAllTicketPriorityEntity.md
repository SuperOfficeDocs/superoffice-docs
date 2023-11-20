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
GET /api/v1/List/TicketPriority/Items?includeDeleted=True
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
    "TicketPriorityId": 41,
    "Name": "Vandervort Group",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 159,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 556,
    "MonStart": "2007-12-10T13:38:18.2650127+01:00",
    "MonStop": "2014-04-26T13:38:18.2650127+02:00",
    "TueStart": "2005-04-19T13:38:18.2650127+02:00",
    "TueStop": "2012-02-28T13:38:18.2650127+01:00",
    "WedStart": "1996-07-22T13:38:18.2650127+02:00",
    "WedStop": "2017-03-28T13:38:18.2650127+02:00",
    "ThuStart": "2002-03-07T13:38:18.2650127+01:00",
    "ThuStop": "2018-05-06T13:38:18.2650127+02:00",
    "FriStart": "2020-10-24T13:38:18.2650127+02:00",
    "FriStop": "2015-09-22T13:38:18.2650127+02:00",
    "SatStart": "2009-03-19T13:38:18.2650127+01:00",
    "SatStop": "2019-03-20T13:38:18.2650127+01:00",
    "SunStart": "2015-07-23T13:38:18.2650127+02:00",
    "SunStop": "1996-11-09T13:38:18.2650127+01:00",
    "NonDates": [
      "dicta",
      "necessitatibus"
    ],
    "EscalationLevels": [
      {
        "TicketAlertId": 778,
        "AlertLevel": 528,
        "AlertTimeout": 721,
        "Action": 584,
        "DelegateTo": 384,
        "ScriptId": 404,
        "EmailTo": "cleta@vandervortpaucek.biz",
        "SmsTo": "beatae",
        "ReplyTemplateIdCustomer": 955,
        "ReplyTemplateIdUser": 189,
        "ReplyTemplateIdCatmast": 144,
        "ReplyTemplateIdEmail": 259,
        "RtiCustomerSms": 700,
        "ReplyTemplateIdUserSms": 427,
        "ReplyTemplateIdCatmastSms": 310,
        "ReplyTemplateIdSms": 773,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 902
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 255
      }
    }
  }
]
```
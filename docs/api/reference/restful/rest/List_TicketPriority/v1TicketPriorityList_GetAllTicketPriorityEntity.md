---
title: GET List/TicketPriority/Items
id: v1TicketPriorityList_GetAllTicketPriorityEntity
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
| NonDates | array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime |
| EscalationLevels | array | Escalation levels bound to the parent priority |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TicketPriorityId": 541,
    "Name": "Donnelly Group",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 963,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 794,
    "MonStart": "2015-05-11T18:25:52.3066381+02:00",
    "MonStop": "2020-11-20T18:25:52.3066381+01:00",
    "TueStart": "2007-03-04T18:25:52.3066381+01:00",
    "TueStop": "2005-02-23T18:25:52.3066381+01:00",
    "WedStart": "1997-05-09T18:25:52.3066381+02:00",
    "WedStop": "1997-03-27T18:25:52.3066381+01:00",
    "ThuStart": "1997-10-23T18:25:52.3066381+02:00",
    "ThuStop": "2006-05-03T18:25:52.3066381+02:00",
    "FriStart": "2011-04-17T18:25:52.3066381+02:00",
    "FriStop": "2002-11-23T18:25:52.3066381+01:00",
    "SatStart": "2011-05-17T18:25:52.3066381+02:00",
    "SatStop": "1999-03-28T18:25:52.3066381+02:00",
    "SunStart": "2013-01-21T18:25:52.3066381+01:00",
    "SunStop": "2017-09-21T18:25:52.3066381+02:00",
    "NonDates": [
      "asperiores",
      "fugiat"
    ],
    "EscalationLevels": [
      {
        "TicketAlertId": 39,
        "AlertLevel": 17,
        "AlertTimeout": 211,
        "Action": 907,
        "DelegateTo": 654,
        "ScriptId": 849,
        "EmailTo": "coralie_hauck@metz.co.uk",
        "SmsTo": "provident",
        "ReplyTemplateIdCustomer": 125,
        "ReplyTemplateIdUser": 211,
        "ReplyTemplateIdCatmast": 309,
        "ReplyTemplateIdEmail": 765,
        "RtiCustomerSms": 584,
        "ReplyTemplateIdUserSms": 471,
        "ReplyTemplateIdCatmastSms": 972,
        "ReplyTemplateIdSms": 882,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 919
          }
        }
      }
    ],
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 997
      }
    }
  }
]
```
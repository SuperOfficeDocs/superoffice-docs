---
title: PUT List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_PutTicketPriorityEntity
generated: true
---

# PUT List/TicketPriority/Items/{id}

```http
PUT /api/v1/List/TicketPriority/Items/{id}
```

Updates the existing TicketPriorityEntity


Calls the List agent service SaveTicketPriorityEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of TicketPriorityEntity to be saved. **Required** |



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

The details of TicketPriorityEntity to be saved. 

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
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 421,
  "Name": "Zemlak Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 289,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 234,
  "MonStart": "1998-07-25T03:45:29.2484114+02:00",
  "MonStop": "1999-05-02T03:45:29.2484114+02:00",
  "TueStart": "2002-06-26T03:45:29.2484114+02:00",
  "TueStop": "2015-11-12T03:45:29.2484114+01:00",
  "WedStart": "2023-08-07T03:45:29.2484114+02:00",
  "WedStop": "2002-10-07T03:45:29.2484114+02:00",
  "ThuStart": "2007-12-20T03:45:29.2484114+01:00",
  "ThuStop": "2025-04-25T03:45:29.2484114+02:00",
  "FriStart": "2019-05-06T03:45:29.2484114+02:00",
  "FriStop": "2001-10-05T03:45:29.2484114+02:00",
  "SatStart": "2009-08-30T03:45:29.2484114+02:00",
  "SatStop": "2018-10-19T03:45:29.2484114+02:00",
  "SunStart": "2016-10-11T03:45:29.2484114+02:00",
  "SunStop": "2022-12-09T03:45:29.2484114+01:00",
  "NonDates": [
    "aspernatur",
    "et"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 313,
      "AlertLevel": 109,
      "AlertTimeout": 745,
      "Action": 196,
      "DelegateTo": 821,
      "ScriptId": 98,
      "EmailTo": "adrian@harrisgulgowski.co.uk",
      "SmsTo": "ipsum",
      "ReplyTemplateIdCustomer": 194,
      "ReplyTemplateIdUser": 204,
      "ReplyTemplateIdCatmast": 603,
      "ReplyTemplateIdEmail": 497,
      "RtiCustomerSms": 184,
      "ReplyTemplateIdUserSms": 621,
      "ReplyTemplateIdCatmastSms": 801,
      "ReplyTemplateIdSms": 271
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 801,
  "Name": "Hane, Smitham and Goyette",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 342,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 706,
  "MonStart": "2017-12-14T03:45:29.2484114+01:00",
  "MonStop": "2022-05-13T03:45:29.2484114+02:00",
  "TueStart": "2008-04-21T03:45:29.2484114+02:00",
  "TueStop": "2017-11-24T03:45:29.2484114+01:00",
  "WedStart": "2024-10-26T03:45:29.2484114+02:00",
  "WedStop": "2000-09-01T03:45:29.2484114+02:00",
  "ThuStart": "2024-12-08T03:45:29.2484114+01:00",
  "ThuStop": "2025-04-08T03:45:29.2484114+02:00",
  "FriStart": "2023-03-25T03:45:29.2484114+01:00",
  "FriStop": "2003-05-06T03:45:29.2484114+02:00",
  "SatStart": "2006-05-20T03:45:29.2484114+02:00",
  "SatStop": "2003-10-03T03:45:29.2484114+02:00",
  "SunStart": "2021-06-07T03:45:29.2484114+02:00",
  "SunStop": "2003-11-14T03:45:29.2484114+01:00",
  "NonDates": [
    "labore",
    "eos"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 582,
      "AlertLevel": 864,
      "AlertTimeout": 57,
      "Action": 852,
      "DelegateTo": 279,
      "ScriptId": 901,
      "EmailTo": "roosevelt_lindgren@oreilly.ca",
      "SmsTo": "ex",
      "ReplyTemplateIdCustomer": 99,
      "ReplyTemplateIdUser": 340,
      "ReplyTemplateIdCatmast": 175,
      "ReplyTemplateIdEmail": 817,
      "RtiCustomerSms": 163,
      "ReplyTemplateIdUserSms": 887,
      "ReplyTemplateIdCatmastSms": 193,
      "ReplyTemplateIdSms": 976,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 366
    }
  }
}
```
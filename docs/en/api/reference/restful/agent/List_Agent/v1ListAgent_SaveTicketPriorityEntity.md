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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 332,
  "Name": "Runolfsdottir-Goldner",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 442,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 234,
  "MonStart": "2024-02-05T13:14:06.1164195+01:00",
  "MonStop": "2004-02-27T13:14:06.1164195+01:00",
  "TueStart": "2005-07-02T13:14:06.1164195+02:00",
  "TueStop": "2012-08-13T13:14:06.1164195+02:00",
  "WedStart": "2010-08-08T13:14:06.1164195+02:00",
  "WedStop": "2017-01-09T13:14:06.1164195+01:00",
  "ThuStart": "2023-04-03T13:14:06.1164195+02:00",
  "ThuStop": "1997-11-09T13:14:06.1164195+01:00",
  "FriStart": "2023-03-04T13:14:06.1164195+01:00",
  "FriStop": "2016-09-12T13:14:06.1164195+02:00",
  "SatStart": "2006-07-04T13:14:06.1164195+02:00",
  "SatStop": "2015-12-04T13:14:06.1164195+01:00",
  "SunStart": "2017-05-23T13:14:06.1164195+02:00",
  "SunStop": "2016-03-23T13:14:06.1164195+01:00",
  "NonDates": [
    "praesentium",
    "esse"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 689,
      "AlertLevel": 187,
      "AlertTimeout": 814,
      "Action": 325,
      "DelegateTo": 154,
      "ScriptId": 119,
      "EmailTo": "clay_volkman@roob.com",
      "SmsTo": "explicabo",
      "ReplyTemplateIdCustomer": 754,
      "ReplyTemplateIdUser": 150,
      "ReplyTemplateIdCatmast": 932,
      "ReplyTemplateIdEmail": 340,
      "RtiCustomerSms": 619,
      "ReplyTemplateIdUserSms": 294,
      "ReplyTemplateIdCatmastSms": 7,
      "ReplyTemplateIdSms": 45
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 764,
  "Name": "Schmitt-O'Keefe",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 158,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 826,
  "MonStart": "2016-06-10T13:14:06.1164195+02:00",
  "MonStop": "2014-11-03T13:14:06.1164195+01:00",
  "TueStart": "2017-10-04T13:14:06.1164195+02:00",
  "TueStop": "2012-02-01T13:14:06.1164195+01:00",
  "WedStart": "2000-10-19T13:14:06.1164195+02:00",
  "WedStop": "2018-01-02T13:14:06.1164195+01:00",
  "ThuStart": "2021-10-25T13:14:06.1164195+02:00",
  "ThuStop": "2003-10-13T13:14:06.1164195+02:00",
  "FriStart": "2018-01-29T13:14:06.1164195+01:00",
  "FriStop": "2019-12-16T13:14:06.1164195+01:00",
  "SatStart": "2022-04-11T13:14:06.1164195+02:00",
  "SatStop": "2018-09-26T13:14:06.1164195+02:00",
  "SunStart": "2010-07-13T13:14:06.1164195+02:00",
  "SunStop": "1999-05-17T13:14:06.1164195+02:00",
  "NonDates": [
    "nobis",
    "ab"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 157,
      "AlertLevel": 8,
      "AlertTimeout": 398,
      "Action": 264,
      "DelegateTo": 873,
      "ScriptId": 134,
      "EmailTo": "gregory.schimmel@durgan.name",
      "SmsTo": "est",
      "ReplyTemplateIdCustomer": 658,
      "ReplyTemplateIdUser": 463,
      "ReplyTemplateIdCatmast": 543,
      "ReplyTemplateIdEmail": 963,
      "RtiCustomerSms": 401,
      "ReplyTemplateIdUserSms": 697,
      "ReplyTemplateIdCatmastSms": 474,
      "ReplyTemplateIdSms": 239,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 220
    }
  }
}
```
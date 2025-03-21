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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 682,
  "Name": "Fahey Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 812,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 394,
  "MonStart": "2019-12-26T14:13:40.5471977+01:00",
  "MonStop": "2005-07-06T14:13:40.5471977+02:00",
  "TueStart": "2021-09-23T14:13:40.5471977+02:00",
  "TueStop": "2002-04-14T14:13:40.5471977+02:00",
  "WedStart": "2006-12-12T14:13:40.5471977+01:00",
  "WedStop": "2020-03-04T14:13:40.5471977+01:00",
  "ThuStart": "2002-07-08T14:13:40.5471977+02:00",
  "ThuStop": "2006-03-28T14:13:40.5471977+02:00",
  "FriStart": "2018-09-10T14:13:40.5471977+02:00",
  "FriStop": "2001-05-06T14:13:40.5471977+02:00",
  "SatStart": "2018-06-16T14:13:40.5471977+02:00",
  "SatStop": "2022-03-04T14:13:40.5471977+01:00",
  "SunStart": "2023-02-19T14:13:40.5471977+01:00",
  "SunStop": "2014-06-23T14:13:40.5471977+02:00",
  "NonDates": [
    "explicabo",
    "ipsum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 811,
      "AlertLevel": 727,
      "AlertTimeout": 126,
      "Action": 334,
      "DelegateTo": 214,
      "ScriptId": 303,
      "EmailTo": "alisa@bruen.ca",
      "SmsTo": "autem",
      "ReplyTemplateIdCustomer": 310,
      "ReplyTemplateIdUser": 750,
      "ReplyTemplateIdCatmast": 620,
      "ReplyTemplateIdEmail": 131,
      "RtiCustomerSms": 851,
      "ReplyTemplateIdUserSms": 10,
      "ReplyTemplateIdCatmastSms": 985,
      "ReplyTemplateIdSms": 924
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 545,
  "Name": "Weimann Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 517,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 828,
  "MonStart": "2003-06-08T14:13:40.5471977+02:00",
  "MonStop": "2018-02-02T14:13:40.5471977+01:00",
  "TueStart": "2025-01-09T14:13:40.5471977+01:00",
  "TueStop": "2003-09-04T14:13:40.5471977+02:00",
  "WedStart": "2019-05-19T14:13:40.5471977+02:00",
  "WedStop": "2015-06-20T14:13:40.5471977+02:00",
  "ThuStart": "2013-07-29T14:13:40.5471977+02:00",
  "ThuStop": "2004-01-05T14:13:40.5471977+01:00",
  "FriStart": "2022-05-13T14:13:40.5471977+02:00",
  "FriStop": "2010-11-08T14:13:40.5471977+01:00",
  "SatStart": "2015-06-23T14:13:40.5471977+02:00",
  "SatStop": "2022-10-21T14:13:40.5471977+02:00",
  "SunStart": "1999-06-08T14:13:40.5471977+02:00",
  "SunStop": "2016-11-21T14:13:40.5471977+01:00",
  "NonDates": [
    "et",
    "dolores"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 323,
      "AlertLevel": 851,
      "AlertTimeout": 61,
      "Action": 551,
      "DelegateTo": 663,
      "ScriptId": 342,
      "EmailTo": "ulises@williamson.info",
      "SmsTo": "voluptatum",
      "ReplyTemplateIdCustomer": 400,
      "ReplyTemplateIdUser": 563,
      "ReplyTemplateIdCatmast": 347,
      "ReplyTemplateIdEmail": 359,
      "RtiCustomerSms": 838,
      "ReplyTemplateIdUserSms": 665,
      "ReplyTemplateIdCatmastSms": 648,
      "ReplyTemplateIdSms": 287,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 152
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 667
    }
  }
}
```
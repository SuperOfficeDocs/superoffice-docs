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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 918,
  "Name": "Hegmann-Harris",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 59,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 383,
  "MonStart": "2012-04-15T10:17:55.7384214+02:00",
  "MonStop": "2021-05-21T10:17:55.7384214+02:00",
  "TueStart": "2024-04-16T10:17:55.7384214+02:00",
  "TueStop": "1998-06-16T10:17:55.7384214+02:00",
  "WedStart": "2005-03-21T10:17:55.7384214+01:00",
  "WedStop": "2022-07-26T10:17:55.7384214+02:00",
  "ThuStart": "2024-09-08T10:17:55.7384214+02:00",
  "ThuStop": "2023-12-17T10:17:55.7384214+01:00",
  "FriStart": "2002-11-06T10:17:55.7384214+01:00",
  "FriStop": "1998-01-04T10:17:55.7384214+01:00",
  "SatStart": "2013-11-30T10:17:55.7384214+01:00",
  "SatStop": "2015-04-20T10:17:55.7384214+02:00",
  "SunStart": "2007-02-04T10:17:55.7384214+01:00",
  "SunStop": "2002-01-12T10:17:55.7384214+01:00",
  "NonDates": [
    "aperiam",
    "rerum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 102,
      "AlertLevel": 731,
      "AlertTimeout": 933,
      "Action": 493,
      "DelegateTo": 217,
      "ScriptId": 70,
      "EmailTo": "dexter_kub@abshiremacejkovic.biz",
      "SmsTo": "quia",
      "ReplyTemplateIdCustomer": 766,
      "ReplyTemplateIdUser": 322,
      "ReplyTemplateIdCatmast": 501,
      "ReplyTemplateIdEmail": 804,
      "RtiCustomerSms": 203,
      "ReplyTemplateIdUserSms": 375,
      "ReplyTemplateIdCatmastSms": 853,
      "ReplyTemplateIdSms": 378
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 925,
  "Name": "Bayer, Abshire and Purdy",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 143,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 463,
  "MonStart": "2023-07-03T10:17:55.7384214+02:00",
  "MonStop": "2002-01-30T10:17:55.7384214+01:00",
  "TueStart": "2018-08-16T10:17:55.7384214+02:00",
  "TueStop": "2012-03-19T10:17:55.7384214+01:00",
  "WedStart": "2008-03-26T10:17:55.7384214+01:00",
  "WedStop": "1998-05-17T10:17:55.7384214+02:00",
  "ThuStart": "2009-03-27T10:17:55.7384214+01:00",
  "ThuStop": "2016-02-02T10:17:55.7384214+01:00",
  "FriStart": "2018-11-15T10:17:55.7384214+01:00",
  "FriStop": "2010-06-29T10:17:55.7384214+02:00",
  "SatStart": "2018-09-30T10:17:55.7384214+02:00",
  "SatStop": "2010-12-23T10:17:55.7384214+01:00",
  "SunStart": "2019-10-24T10:17:55.7384214+02:00",
  "SunStop": "2019-10-21T10:17:55.7384214+02:00",
  "NonDates": [
    "inventore",
    "illum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 899,
      "AlertLevel": 431,
      "AlertTimeout": 787,
      "Action": 730,
      "DelegateTo": 877,
      "ScriptId": 636,
      "EmailTo": "chyna.kihn@dickenspouros.uk",
      "SmsTo": "consequatur",
      "ReplyTemplateIdCustomer": 512,
      "ReplyTemplateIdUser": 726,
      "ReplyTemplateIdCatmast": 770,
      "ReplyTemplateIdEmail": 846,
      "RtiCustomerSms": 328,
      "ReplyTemplateIdUserSms": 898,
      "ReplyTemplateIdCatmastSms": 562,
      "ReplyTemplateIdSms": 129,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 987
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 799
    }
  }
}
```
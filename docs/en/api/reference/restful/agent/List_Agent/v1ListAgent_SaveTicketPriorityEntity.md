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
  "TicketPriorityId": 566,
  "Name": "Beatty Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 403,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 659,
  "MonStart": "2014-02-15T04:22:27.0497008+01:00",
  "MonStop": "2019-08-23T04:22:27.0497008+02:00",
  "TueStart": "2024-05-31T04:22:27.0497008+02:00",
  "TueStop": "2012-02-29T04:22:27.0497008+01:00",
  "WedStart": "2003-11-28T04:22:27.0497008+01:00",
  "WedStop": "2020-06-23T04:22:27.0497008+02:00",
  "ThuStart": "2005-04-13T04:22:27.0497008+02:00",
  "ThuStop": "2020-06-13T04:22:27.0497008+02:00",
  "FriStart": "2009-03-18T04:22:27.0497008+01:00",
  "FriStop": "2002-03-05T04:22:27.0497008+01:00",
  "SatStart": "2008-04-22T04:22:27.0497008+02:00",
  "SatStop": "2020-02-03T04:22:27.0497008+01:00",
  "SunStart": "2005-12-16T04:22:27.0497008+01:00",
  "SunStop": "2019-08-12T04:22:27.0497008+02:00",
  "NonDates": [
    "eum",
    "assumenda"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 594,
      "AlertLevel": 550,
      "AlertTimeout": 120,
      "Action": 20,
      "DelegateTo": 279,
      "ScriptId": 475,
      "EmailTo": "ruthe.brekke@schoen.com",
      "SmsTo": "id",
      "ReplyTemplateIdCustomer": 504,
      "ReplyTemplateIdUser": 596,
      "ReplyTemplateIdCatmast": 882,
      "ReplyTemplateIdEmail": 817,
      "RtiCustomerSms": 1000,
      "ReplyTemplateIdUserSms": 234,
      "ReplyTemplateIdCatmastSms": 889,
      "ReplyTemplateIdSms": 640
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 407,
  "Name": "Thiel-Heidenreich",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 135,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 86,
  "MonStart": "2008-06-21T04:22:27.0497008+02:00",
  "MonStop": "2020-11-17T04:22:27.0497008+01:00",
  "TueStart": "2010-04-08T04:22:27.0497008+02:00",
  "TueStop": "2002-09-19T04:22:27.0497008+02:00",
  "WedStart": "2020-06-08T04:22:27.0497008+02:00",
  "WedStop": "2018-04-03T04:22:27.0497008+02:00",
  "ThuStart": "1999-05-23T04:22:27.0497008+02:00",
  "ThuStop": "2018-12-17T04:22:27.0497008+01:00",
  "FriStart": "2014-01-17T04:22:27.0497008+01:00",
  "FriStop": "2018-03-28T04:22:27.0497008+02:00",
  "SatStart": "2005-04-07T04:22:27.0497008+02:00",
  "SatStop": "2011-10-25T04:22:27.0497008+02:00",
  "SunStart": "2010-02-06T04:22:27.0497008+01:00",
  "SunStop": "2011-02-10T04:22:27.0497008+01:00",
  "NonDates": [
    "et",
    "quod"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 948,
      "AlertLevel": 767,
      "AlertTimeout": 350,
      "Action": 244,
      "DelegateTo": 741,
      "ScriptId": 465,
      "EmailTo": "ricardo@olsonkautzer.co.uk",
      "SmsTo": "quibusdam",
      "ReplyTemplateIdCustomer": 25,
      "ReplyTemplateIdUser": 145,
      "ReplyTemplateIdCatmast": 782,
      "ReplyTemplateIdEmail": 369,
      "RtiCustomerSms": 600,
      "ReplyTemplateIdUserSms": 754,
      "ReplyTemplateIdCatmastSms": 502,
      "ReplyTemplateIdSms": 150,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 735
    }
  }
}
```
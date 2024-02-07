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
  "TicketPriorityId": 587,
  "Name": "Gaylord-Rempel",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 698,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 23,
  "MonStart": "2019-09-14T16:54:55.6329856+02:00",
  "MonStop": "2007-11-27T16:54:55.6329856+01:00",
  "TueStart": "2006-11-06T16:54:55.6329856+01:00",
  "TueStop": "2012-04-01T16:54:55.6329856+02:00",
  "WedStart": "2023-01-09T16:54:55.6329856+01:00",
  "WedStop": "2009-04-08T16:54:55.6329856+02:00",
  "ThuStart": "2004-09-06T16:54:55.6329856+02:00",
  "ThuStop": "2006-10-20T16:54:55.6329856+02:00",
  "FriStart": "2021-12-01T16:54:55.6329856+01:00",
  "FriStop": "2017-03-03T16:54:55.6329856+01:00",
  "SatStart": "2013-07-11T16:54:55.6329856+02:00",
  "SatStop": "2008-08-29T16:54:55.6329856+02:00",
  "SunStart": "2023-12-26T16:54:55.6329856+01:00",
  "SunStop": "2021-09-18T16:54:55.6329856+02:00",
  "NonDates": [
    "saepe",
    "illo"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 981,
      "AlertLevel": 420,
      "AlertTimeout": 753,
      "Action": 509,
      "DelegateTo": 950,
      "ScriptId": 357,
      "EmailTo": "leonora_abshire@ward.ca",
      "SmsTo": "aspernatur",
      "ReplyTemplateIdCustomer": 339,
      "ReplyTemplateIdUser": 750,
      "ReplyTemplateIdCatmast": 249,
      "ReplyTemplateIdEmail": 375,
      "RtiCustomerSms": 692,
      "ReplyTemplateIdUserSms": 980,
      "ReplyTemplateIdCatmastSms": 812,
      "ReplyTemplateIdSms": 784
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 75,
  "Name": "Nader LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 106,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 157,
  "MonStart": "2003-10-14T16:54:55.6329856+02:00",
  "MonStop": "2020-06-06T16:54:55.6329856+02:00",
  "TueStart": "2009-08-11T16:54:55.6329856+02:00",
  "TueStop": "2011-03-07T16:54:55.6329856+01:00",
  "WedStart": "1998-01-21T16:54:55.6329856+01:00",
  "WedStop": "2007-09-17T16:54:55.6329856+02:00",
  "ThuStart": "2016-08-05T16:54:55.6329856+02:00",
  "ThuStop": "2005-08-01T16:54:55.6329856+02:00",
  "FriStart": "2014-07-23T16:54:55.6329856+02:00",
  "FriStop": "2019-01-26T16:54:55.6329856+01:00",
  "SatStart": "2016-06-28T16:54:55.6329856+02:00",
  "SatStop": "2012-05-22T16:54:55.6329856+02:00",
  "SunStart": "2021-09-25T16:54:55.6329856+02:00",
  "SunStop": "2009-07-30T16:54:55.6329856+02:00",
  "NonDates": [
    "odit",
    "deleniti"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 886,
      "AlertLevel": 94,
      "AlertTimeout": 14,
      "Action": 378,
      "DelegateTo": 206,
      "ScriptId": 688,
      "EmailTo": "nick@volkmansipes.name",
      "SmsTo": "illo",
      "ReplyTemplateIdCustomer": 515,
      "ReplyTemplateIdUser": 233,
      "ReplyTemplateIdCatmast": 197,
      "ReplyTemplateIdEmail": 268,
      "RtiCustomerSms": 624,
      "ReplyTemplateIdUserSms": 443,
      "ReplyTemplateIdCatmastSms": 5,
      "ReplyTemplateIdSms": 23,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 657
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 684
    }
  }
}
```
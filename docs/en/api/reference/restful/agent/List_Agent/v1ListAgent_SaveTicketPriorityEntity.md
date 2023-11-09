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
  "TicketPriorityId": 102,
  "Name": "Goldner Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 942,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 110,
  "MonStart": "1999-03-30T11:06:34.7708179+02:00",
  "MonStop": "2003-06-07T11:06:34.7708179+02:00",
  "TueStart": "2019-12-25T11:06:34.7708179+01:00",
  "TueStop": "2020-10-29T11:06:34.7708179+01:00",
  "WedStart": "2012-08-09T11:06:34.7708179+02:00",
  "WedStop": "2013-11-08T11:06:34.7708179+01:00",
  "ThuStart": "2018-12-18T11:06:34.7708179+01:00",
  "ThuStop": "2008-10-24T11:06:34.7708179+02:00",
  "FriStart": "2021-06-29T11:06:34.7708179+02:00",
  "FriStop": "2018-03-29T11:06:34.7708179+02:00",
  "SatStart": "2010-11-06T11:06:34.7708179+01:00",
  "SatStop": "2004-07-02T11:06:34.7708179+02:00",
  "SunStart": "2008-03-30T11:06:34.7708179+02:00",
  "SunStop": "2008-10-04T11:06:34.7708179+02:00",
  "NonDates": [
    "et",
    "consequuntur"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 897,
      "AlertLevel": 653,
      "AlertTimeout": 27,
      "Action": 661,
      "DelegateTo": 299,
      "ScriptId": 692,
      "EmailTo": "walton@rutherford.name",
      "SmsTo": "est",
      "ReplyTemplateIdCustomer": 65,
      "ReplyTemplateIdUser": 230,
      "ReplyTemplateIdCatmast": 879,
      "ReplyTemplateIdEmail": 198,
      "RtiCustomerSms": 532,
      "ReplyTemplateIdUserSms": 571,
      "ReplyTemplateIdCatmastSms": 768,
      "ReplyTemplateIdSms": 733
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 604,
  "Name": "Turner Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 113,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 779,
  "MonStart": "2021-06-24T11:06:34.7708179+02:00",
  "MonStop": "2005-01-25T11:06:34.7708179+01:00",
  "TueStart": "2017-04-28T11:06:34.7708179+02:00",
  "TueStop": "2023-05-23T11:06:34.7708179+02:00",
  "WedStart": "2005-10-19T11:06:34.7708179+02:00",
  "WedStop": "2012-10-05T11:06:34.7708179+02:00",
  "ThuStart": "2012-02-02T11:06:34.7708179+01:00",
  "ThuStop": "2022-12-27T11:06:34.7708179+01:00",
  "FriStart": "2000-01-04T11:06:34.7708179+01:00",
  "FriStop": "2002-01-08T11:06:34.7708179+01:00",
  "SatStart": "1999-01-24T11:06:34.7708179+01:00",
  "SatStop": "2016-11-25T11:06:34.7708179+01:00",
  "SunStart": "2022-09-18T11:06:34.7708179+02:00",
  "SunStop": "2017-06-10T11:06:34.7708179+02:00",
  "NonDates": [
    "nesciunt",
    "est"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 454,
      "AlertLevel": 437,
      "AlertTimeout": 663,
      "Action": 650,
      "DelegateTo": 265,
      "ScriptId": 237,
      "EmailTo": "katlynn@runteskiles.com",
      "SmsTo": "excepturi",
      "ReplyTemplateIdCustomer": 751,
      "ReplyTemplateIdUser": 314,
      "ReplyTemplateIdCatmast": 678,
      "ReplyTemplateIdEmail": 601,
      "RtiCustomerSms": 586,
      "ReplyTemplateIdUserSms": 55,
      "ReplyTemplateIdCatmastSms": 374,
      "ReplyTemplateIdSms": 709,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 920
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 801
    }
  }
}
```
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 911,
  "Name": "Olson-Raynor",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 717,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 947,
  "MonStart": "2009-02-14T11:16:09.3815779+01:00",
  "MonStop": "2021-02-23T11:16:09.3815779+01:00",
  "TueStart": "2015-04-21T11:16:09.3815779+02:00",
  "TueStop": "1997-07-21T11:16:09.3815779+02:00",
  "WedStart": "1998-09-17T11:16:09.3815779+02:00",
  "WedStop": "2003-02-15T11:16:09.3815779+01:00",
  "ThuStart": "2004-11-01T11:16:09.3815779+01:00",
  "ThuStop": "2013-12-06T11:16:09.3815779+01:00",
  "FriStart": "2002-08-26T11:16:09.3815779+02:00",
  "FriStop": "2004-07-05T11:16:09.3815779+02:00",
  "SatStart": "1999-08-21T11:16:09.3815779+02:00",
  "SatStop": "2020-06-06T11:16:09.3815779+02:00",
  "SunStart": "2021-04-03T11:16:09.3815779+02:00",
  "SunStop": "2013-02-26T11:16:09.3815779+01:00",
  "NonDates": [
    "repellendus",
    "illum"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 17,
      "AlertLevel": 743,
      "AlertTimeout": 369,
      "Action": 75,
      "DelegateTo": 192,
      "ScriptId": 692,
      "EmailTo": "corene@wiegand.biz",
      "SmsTo": "voluptate",
      "ReplyTemplateIdCustomer": 672,
      "ReplyTemplateIdUser": 315,
      "ReplyTemplateIdCatmast": 109,
      "ReplyTemplateIdEmail": 667,
      "RtiCustomerSms": 294,
      "ReplyTemplateIdUserSms": 944,
      "ReplyTemplateIdCatmastSms": 489,
      "ReplyTemplateIdSms": 179
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 561,
  "Name": "Weissnat, Balistreri and Lemke",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 648,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 995,
  "MonStart": "2013-12-13T11:16:09.3815779+01:00",
  "MonStop": "2002-12-16T11:16:09.3815779+01:00",
  "TueStart": "2003-06-06T11:16:09.3815779+02:00",
  "TueStop": "2016-03-15T11:16:09.3815779+01:00",
  "WedStart": "1997-05-03T11:16:09.3815779+02:00",
  "WedStop": "2015-05-04T11:16:09.3815779+02:00",
  "ThuStart": "2009-07-01T11:16:09.3815779+02:00",
  "ThuStop": "2001-06-23T11:16:09.3815779+02:00",
  "FriStart": "2010-11-12T11:16:09.3815779+01:00",
  "FriStop": "2008-01-15T11:16:09.3815779+01:00",
  "SatStart": "2022-10-07T11:16:09.3815779+02:00",
  "SatStop": "2017-02-08T11:16:09.3815779+01:00",
  "SunStart": "2022-07-17T11:16:09.3815779+02:00",
  "SunStop": "1998-09-11T11:16:09.3815779+02:00",
  "NonDates": [
    "doloremque",
    "quaerat"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 185,
      "AlertLevel": 500,
      "AlertTimeout": 363,
      "Action": 581,
      "DelegateTo": 263,
      "ScriptId": 223,
      "EmailTo": "gordon@cartwright.name",
      "SmsTo": "fugiat",
      "ReplyTemplateIdCustomer": 370,
      "ReplyTemplateIdUser": 185,
      "ReplyTemplateIdCatmast": 683,
      "ReplyTemplateIdEmail": 675,
      "RtiCustomerSms": 467,
      "ReplyTemplateIdUserSms": 441,
      "ReplyTemplateIdCatmastSms": 664,
      "ReplyTemplateIdSms": 184,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 963
    }
  }
}
```
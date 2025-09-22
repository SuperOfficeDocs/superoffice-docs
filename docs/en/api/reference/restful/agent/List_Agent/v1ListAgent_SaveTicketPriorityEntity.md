---
title: POST Agents/List/SaveTicketPriorityEntity
uid: v1ListAgent_SaveTicketPriorityEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveTicketPriorityEntity

```http
POST /api/v1/Agents/List/SaveTicketPriorityEntity
```

Updates the existing TicketPriorityEntity or creates a new TicketPriorityEntity if the id parameter is 0.








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

## Request Body: ticketPriorityEntity 

The TicketPriorityEntity that is saved 

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
  "TicketPriorityId": 497,
  "Name": "Sauer-Ferry",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 632,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 338,
  "MonStart": "2020-01-09T11:24:48.1876539+01:00",
  "MonStop": "2005-03-24T11:24:48.1876539+01:00",
  "TueStart": "2001-03-22T11:24:48.1876539+01:00",
  "TueStop": "2024-11-08T11:24:48.1876539+01:00",
  "WedStart": "2015-11-15T11:24:48.1876539+01:00",
  "WedStop": "2021-11-15T11:24:48.1876539+01:00",
  "ThuStart": "2011-03-15T11:24:48.1876539+01:00",
  "ThuStop": "2024-10-04T11:24:48.1876539+02:00",
  "FriStart": "2018-02-23T11:24:48.1876539+01:00",
  "FriStop": "2010-10-31T11:24:48.1876539+01:00",
  "SatStart": "2008-05-15T11:24:48.1876539+02:00",
  "SatStop": "2022-07-14T11:24:48.1876539+02:00",
  "SunStart": "2018-12-07T11:24:48.1876539+01:00",
  "SunStop": "2025-08-09T11:24:48.1876539+02:00",
  "NonDates": [
    "sunt",
    "fuga"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 296,
      "AlertLevel": 720,
      "AlertTimeout": 980,
      "Action": 219,
      "DelegateTo": 713,
      "ScriptId": 377,
      "EmailTo": "josianne_blanda@hilllswaniawski.name",
      "SmsTo": "velit",
      "ReplyTemplateIdCustomer": 533,
      "ReplyTemplateIdUser": 288,
      "ReplyTemplateIdCatmast": 560,
      "ReplyTemplateIdEmail": 368,
      "RtiCustomerSms": 357,
      "ReplyTemplateIdUserSms": 771,
      "ReplyTemplateIdCatmastSms": 647,
      "ReplyTemplateIdSms": 144
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 835,
  "Name": "Mayer Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 685,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 754,
  "MonStart": "2014-08-26T11:24:48.1876539+02:00",
  "MonStop": "2014-02-07T11:24:48.1876539+01:00",
  "TueStart": "2019-11-12T11:24:48.1876539+01:00",
  "TueStop": "1998-09-29T11:24:48.1876539+02:00",
  "WedStart": "2002-03-22T11:24:48.1876539+01:00",
  "WedStop": "2002-06-16T11:24:48.1876539+02:00",
  "ThuStart": "2015-04-01T11:24:48.1876539+02:00",
  "ThuStop": "2007-04-15T11:24:48.1876539+02:00",
  "FriStart": "2009-06-18T11:24:48.1876539+02:00",
  "FriStop": "2024-10-03T11:24:48.1876539+02:00",
  "SatStart": "2025-01-26T11:24:48.1876539+01:00",
  "SatStop": "2009-05-02T11:24:48.1876539+02:00",
  "SunStart": "2017-02-13T11:24:48.1876539+01:00",
  "SunStop": "2004-04-07T11:24:48.1876539+02:00",
  "NonDates": [
    "ab",
    "doloremque"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 445,
      "AlertLevel": 226,
      "AlertTimeout": 449,
      "Action": 954,
      "DelegateTo": 504,
      "ScriptId": 149,
      "EmailTo": "coralie@kuhicgutmann.biz",
      "SmsTo": "voluptas",
      "ReplyTemplateIdCustomer": 394,
      "ReplyTemplateIdUser": 221,
      "ReplyTemplateIdCatmast": 309,
      "ReplyTemplateIdEmail": 642,
      "RtiCustomerSms": 514,
      "ReplyTemplateIdUserSms": 936,
      "ReplyTemplateIdCatmastSms": 517,
      "ReplyTemplateIdSms": 487,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 472
    }
  }
}
```
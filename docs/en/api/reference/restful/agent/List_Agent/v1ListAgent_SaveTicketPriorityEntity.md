---
title: POST Agents/List/SaveTicketPriorityEntity
uid: v1ListAgent_SaveTicketPriorityEntity
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
  "TicketPriorityId": 108,
  "Name": "Kemmer LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 463,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 623,
  "MonStart": "2016-08-15T15:29:22.1072711+02:00",
  "MonStop": "2020-09-01T15:29:22.1072711+02:00",
  "TueStart": "2020-03-14T15:29:22.1072711+01:00",
  "TueStop": "2005-11-02T15:29:22.1072711+01:00",
  "WedStart": "1999-05-03T15:29:22.1072711+02:00",
  "WedStop": "1997-12-09T15:29:22.1072711+01:00",
  "ThuStart": "2015-05-09T15:29:22.1072711+02:00",
  "ThuStop": "2015-06-20T15:29:22.1072711+02:00",
  "FriStart": "2002-04-20T15:29:22.1072711+02:00",
  "FriStop": "2006-09-04T15:29:22.1072711+02:00",
  "SatStart": "2003-12-30T15:29:22.1072711+01:00",
  "SatStop": "2018-09-30T15:29:22.1072711+02:00",
  "SunStart": "1998-07-01T15:29:22.1072711+02:00",
  "SunStop": "1996-07-29T15:29:22.1072711+02:00",
  "NonDates": [
    "aut",
    "sit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 848,
      "AlertLevel": 175,
      "AlertTimeout": 824,
      "Action": 604,
      "DelegateTo": 190,
      "ScriptId": 277,
      "EmailTo": "haven.lehner@terry.name",
      "SmsTo": "vero",
      "ReplyTemplateIdCustomer": 1000,
      "ReplyTemplateIdUser": 737,
      "ReplyTemplateIdCatmast": 950,
      "ReplyTemplateIdEmail": 815,
      "RtiCustomerSms": 434,
      "ReplyTemplateIdUserSms": 431,
      "ReplyTemplateIdCatmastSms": 445,
      "ReplyTemplateIdSms": 588
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 148,
  "Name": "Swaniawski-Connelly",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 450,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 344,
  "MonStart": "2000-08-08T15:29:22.1077704+02:00",
  "MonStop": "2022-12-16T15:29:22.1077704+01:00",
  "TueStart": "1998-10-31T15:29:22.1077704+01:00",
  "TueStop": "2021-02-23T15:29:22.1077704+01:00",
  "WedStart": "2001-02-16T15:29:22.1077704+01:00",
  "WedStop": "2014-01-06T15:29:22.1077704+01:00",
  "ThuStart": "2005-04-16T15:29:22.1077704+02:00",
  "ThuStop": "2010-05-03T15:29:22.1077704+02:00",
  "FriStart": "2002-01-28T15:29:22.1077704+01:00",
  "FriStop": "2020-06-12T15:29:22.1077704+02:00",
  "SatStart": "2020-06-15T15:29:22.1077704+02:00",
  "SatStop": "1997-02-09T15:29:22.1077704+01:00",
  "SunStart": "2002-08-16T15:29:22.1077704+02:00",
  "SunStop": "2017-07-22T15:29:22.1077704+02:00",
  "NonDates": [
    "natus",
    "suscipit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 183,
      "AlertLevel": 549,
      "AlertTimeout": 782,
      "Action": 750,
      "DelegateTo": 409,
      "ScriptId": 153,
      "EmailTo": "jessyca_ziemann@bodechamplin.com",
      "SmsTo": "repellendus",
      "ReplyTemplateIdCustomer": 667,
      "ReplyTemplateIdUser": 179,
      "ReplyTemplateIdCatmast": 327,
      "ReplyTemplateIdEmail": 771,
      "RtiCustomerSms": 87,
      "ReplyTemplateIdUserSms": 981,
      "ReplyTemplateIdCatmastSms": 534,
      "ReplyTemplateIdSms": 759,
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
      "FieldType": "System.Int32",
      "FieldLength": 517
    }
  }
}
```
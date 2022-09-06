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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 566,
  "Name": "Bartell-Hartmann",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 116,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 272,
  "MonStart": "2020-10-01T11:10:27.2644531+02:00",
  "MonStop": "2012-12-06T11:10:27.2644531+01:00",
  "TueStart": "2000-06-19T11:10:27.2644531+02:00",
  "TueStop": "2017-11-08T11:10:27.2644531+01:00",
  "WedStart": "2014-07-01T11:10:27.2644531+02:00",
  "WedStop": "2020-05-02T11:10:27.2644531+02:00",
  "ThuStart": "2002-11-09T11:10:27.2644531+01:00",
  "ThuStop": "2020-04-08T11:10:27.2644531+02:00",
  "FriStart": "2019-08-13T11:10:27.2644531+02:00",
  "FriStop": "2011-11-20T11:10:27.2644531+01:00",
  "SatStart": "2015-03-13T11:10:27.2644531+01:00",
  "SatStop": "2009-09-04T11:10:27.2644531+02:00",
  "SunStart": "2007-03-19T11:10:27.2644531+01:00",
  "SunStop": "2009-05-26T11:10:27.2644531+02:00",
  "NonDates": [
    "veritatis",
    "culpa"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 90,
      "AlertLevel": 598,
      "AlertTimeout": 233,
      "Action": 25,
      "DelegateTo": 431,
      "ScriptId": 603,
      "EmailTo": "ahmad@haagnitzsche.name",
      "SmsTo": "explicabo",
      "ReplyTemplateIdCustomer": 970,
      "ReplyTemplateIdUser": 654,
      "ReplyTemplateIdCatmast": 956,
      "ReplyTemplateIdEmail": 3,
      "RtiCustomerSms": 151,
      "ReplyTemplateIdUserSms": 858,
      "ReplyTemplateIdCatmastSms": 893,
      "ReplyTemplateIdSms": 215
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 560,
  "Name": "Schumm, Feeney and Spencer",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 874,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 687,
  "MonStart": "2001-11-27T11:10:27.2654529+01:00",
  "MonStop": "2003-01-18T11:10:27.2654529+01:00",
  "TueStart": "1997-04-29T11:10:27.2654529+02:00",
  "TueStop": "2017-09-01T11:10:27.2654529+02:00",
  "WedStart": "2010-07-17T11:10:27.2654529+02:00",
  "WedStop": "2017-12-07T11:10:27.2654529+01:00",
  "ThuStart": "1998-11-21T11:10:27.2654529+01:00",
  "ThuStop": "1996-12-15T11:10:27.2654529+01:00",
  "FriStart": "2000-03-28T11:10:27.2654529+02:00",
  "FriStop": "2009-04-10T11:10:27.2654529+02:00",
  "SatStart": "2017-12-21T11:10:27.2654529+01:00",
  "SatStop": "2005-10-16T11:10:27.2654529+02:00",
  "SunStart": "2004-04-30T11:10:27.2654529+02:00",
  "SunStop": "2014-12-19T11:10:27.2654529+01:00",
  "NonDates": [
    "autem",
    "vel"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 640,
      "AlertLevel": 137,
      "AlertTimeout": 936,
      "Action": 373,
      "DelegateTo": 618,
      "ScriptId": 191,
      "EmailTo": "maximo@turcottebalistreri.ca",
      "SmsTo": "enim",
      "ReplyTemplateIdCustomer": 106,
      "ReplyTemplateIdUser": 741,
      "ReplyTemplateIdCatmast": 641,
      "ReplyTemplateIdEmail": 62,
      "RtiCustomerSms": 475,
      "ReplyTemplateIdUserSms": 442,
      "ReplyTemplateIdCatmastSms": 367,
      "ReplyTemplateIdSms": 115,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 163
    }
  }
}
```

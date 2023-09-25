---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
generated: true
---

# POST List/TicketPriority/Items

```http
POST /api/v1/List/TicketPriority/Items
```

Create a new TicketPriorityEntity list item


Calls the List agent service SaveTicketPriorityEntity.







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

## Request Body: newEntity 

The TicketPriorityEntity to be created. 

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
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 627,
  "Name": "Treutel LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 244,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 934,
  "MonStart": "2002-12-16T03:24:52.4431914+01:00",
  "MonStop": "2011-03-20T03:24:52.4431914+01:00",
  "TueStart": "2008-06-27T03:24:52.4431914+02:00",
  "TueStop": "1996-10-08T03:24:52.4431914+02:00",
  "WedStart": "2017-05-04T03:24:52.4431914+02:00",
  "WedStop": "2015-06-10T03:24:52.4431914+02:00",
  "ThuStart": "1998-01-08T03:24:52.4431914+01:00",
  "ThuStop": "2015-01-12T03:24:52.4431914+01:00",
  "FriStart": "2008-10-23T03:24:52.4431914+02:00",
  "FriStop": "2006-05-09T03:24:52.4431914+02:00",
  "SatStart": "2008-09-22T03:24:52.4431914+02:00",
  "SatStop": "2017-02-17T03:24:52.4431914+01:00",
  "SunStart": "2002-01-14T03:24:52.4431914+01:00",
  "SunStop": "2019-09-23T03:24:52.4431914+02:00",
  "NonDates": [
    "iusto",
    "aliquid"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 917,
      "AlertLevel": 106,
      "AlertTimeout": 313,
      "Action": 739,
      "DelegateTo": 138,
      "ScriptId": 590,
      "EmailTo": "rhett_schultz@lindhagenes.uk",
      "SmsTo": "enim",
      "ReplyTemplateIdCustomer": 152,
      "ReplyTemplateIdUser": 297,
      "ReplyTemplateIdCatmast": 362,
      "ReplyTemplateIdEmail": 641,
      "RtiCustomerSms": 654,
      "ReplyTemplateIdUserSms": 460,
      "ReplyTemplateIdCatmastSms": 367,
      "ReplyTemplateIdSms": 187
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 655,
  "Name": "Gleichner, Kassulke and Thompson",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 445,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 121,
  "MonStart": "2003-12-31T03:24:52.4431914+01:00",
  "MonStop": "2021-08-22T03:24:52.4431914+02:00",
  "TueStart": "2004-01-10T03:24:52.4431914+01:00",
  "TueStop": "2017-09-26T03:24:52.4431914+02:00",
  "WedStart": "2002-12-31T03:24:52.4431914+01:00",
  "WedStop": "2000-06-24T03:24:52.4431914+02:00",
  "ThuStart": "2004-06-03T03:24:52.4431914+02:00",
  "ThuStop": "2014-01-30T03:24:52.4431914+01:00",
  "FriStart": "1996-09-29T03:24:52.4431914+02:00",
  "FriStop": "2002-02-09T03:24:52.4431914+01:00",
  "SatStart": "2006-06-18T03:24:52.4431914+02:00",
  "SatStop": "2015-10-03T03:24:52.4431914+02:00",
  "SunStart": "1999-01-14T03:24:52.4431914+01:00",
  "SunStop": "2001-09-23T03:24:52.4431914+02:00",
  "NonDates": [
    "culpa",
    "dignissimos"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 129,
      "AlertLevel": 366,
      "AlertTimeout": 456,
      "Action": 219,
      "DelegateTo": 692,
      "ScriptId": 234,
      "EmailTo": "maxine_runte@goodwin.us",
      "SmsTo": "sequi",
      "ReplyTemplateIdCustomer": 355,
      "ReplyTemplateIdUser": 692,
      "ReplyTemplateIdCatmast": 923,
      "ReplyTemplateIdEmail": 41,
      "RtiCustomerSms": 623,
      "ReplyTemplateIdUserSms": 998,
      "ReplyTemplateIdCatmastSms": 184,
      "ReplyTemplateIdSms": 294,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 462
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 307
    }
  }
}
```
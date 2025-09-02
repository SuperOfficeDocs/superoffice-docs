---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
generated: true
content_type: reference
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 732,
  "Name": "Christiansen Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 213,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 649,
  "MonStart": "1999-01-24T03:47:00.8942898+01:00",
  "MonStop": "2018-02-21T03:47:00.8942898+01:00",
  "TueStart": "2021-12-04T03:47:00.8942898+01:00",
  "TueStop": "2002-11-09T03:47:00.8942898+01:00",
  "WedStart": "2016-09-02T03:47:00.8942898+02:00",
  "WedStop": "2009-06-17T03:47:00.8942898+02:00",
  "ThuStart": "2001-11-02T03:47:00.8942898+01:00",
  "ThuStop": "2021-02-09T03:47:00.8942898+01:00",
  "FriStart": "2024-06-06T03:47:00.8942898+02:00",
  "FriStop": "2004-10-26T03:47:00.8942898+02:00",
  "SatStart": "2003-01-28T03:47:00.8942898+01:00",
  "SatStop": "1999-06-30T03:47:00.8942898+02:00",
  "SunStart": "2008-04-14T03:47:00.8942898+02:00",
  "SunStop": "2025-05-25T03:47:00.8942898+02:00",
  "NonDates": [
    "eum",
    "voluptas"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 842,
      "AlertLevel": 450,
      "AlertTimeout": 134,
      "Action": 762,
      "DelegateTo": 885,
      "ScriptId": 574,
      "EmailTo": "humberto.farrell@gradyboehm.com",
      "SmsTo": "et",
      "ReplyTemplateIdCustomer": 71,
      "ReplyTemplateIdUser": 268,
      "ReplyTemplateIdCatmast": 820,
      "ReplyTemplateIdEmail": 885,
      "RtiCustomerSms": 664,
      "ReplyTemplateIdUserSms": 717,
      "ReplyTemplateIdCatmastSms": 894,
      "ReplyTemplateIdSms": 638
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 223,
  "Name": "Botsford, Mayert and Bode",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 528,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 908,
  "MonStart": "2003-06-20T03:47:00.9099142+02:00",
  "MonStop": "2010-04-20T03:47:00.9099142+02:00",
  "TueStart": "1998-08-16T03:47:00.9099142+02:00",
  "TueStop": "2004-05-05T03:47:00.9099142+02:00",
  "WedStart": "2017-10-09T03:47:00.9099142+02:00",
  "WedStop": "2003-08-05T03:47:00.9099142+02:00",
  "ThuStart": "2007-11-24T03:47:00.9099142+01:00",
  "ThuStop": "2014-09-22T03:47:00.9099142+02:00",
  "FriStart": "2002-12-15T03:47:00.9099142+01:00",
  "FriStop": "2012-05-08T03:47:00.9099142+02:00",
  "SatStart": "2010-07-07T03:47:00.9099142+02:00",
  "SatStop": "2001-02-25T03:47:00.9099142+01:00",
  "SunStart": "2006-02-13T03:47:00.9099142+01:00",
  "SunStop": "2021-05-04T03:47:00.9099142+02:00",
  "NonDates": [
    "distinctio",
    "velit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 689,
      "AlertLevel": 616,
      "AlertTimeout": 348,
      "Action": 89,
      "DelegateTo": 498,
      "ScriptId": 328,
      "EmailTo": "bonnie_hirthe@kub.name",
      "SmsTo": "vitae",
      "ReplyTemplateIdCustomer": 949,
      "ReplyTemplateIdUser": 267,
      "ReplyTemplateIdCatmast": 632,
      "ReplyTemplateIdEmail": 720,
      "RtiCustomerSms": 201,
      "ReplyTemplateIdUserSms": 559,
      "ReplyTemplateIdCatmastSms": 907,
      "ReplyTemplateIdSms": 357,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 525
    }
  }
}
```
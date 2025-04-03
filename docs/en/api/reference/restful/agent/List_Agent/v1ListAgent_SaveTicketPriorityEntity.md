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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 218,
  "Name": "Larkin-Jacobi",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 31,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 950,
  "MonStart": "2011-05-23T14:28:22.1022648+02:00",
  "MonStop": "2010-05-22T14:28:22.1022648+02:00",
  "TueStart": "2010-11-03T14:28:22.1022648+01:00",
  "TueStop": "2024-07-28T14:28:22.1022648+02:00",
  "WedStart": "2013-07-31T14:28:22.1022648+02:00",
  "WedStop": "2008-05-20T14:28:22.1022648+02:00",
  "ThuStart": "2004-05-28T14:28:22.1022648+02:00",
  "ThuStop": "2012-03-29T14:28:22.1022648+02:00",
  "FriStart": "2001-02-03T14:28:22.1022648+01:00",
  "FriStop": "2017-05-07T14:28:22.1022648+02:00",
  "SatStart": "2005-12-25T14:28:22.1022648+01:00",
  "SatStop": "1999-04-29T14:28:22.1022648+02:00",
  "SunStart": "2015-06-30T14:28:22.1022648+02:00",
  "SunStop": "2020-06-17T14:28:22.1022648+02:00",
  "NonDates": [
    "earum",
    "blanditiis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 816,
      "AlertLevel": 942,
      "AlertTimeout": 851,
      "Action": 505,
      "DelegateTo": 483,
      "ScriptId": 809,
      "EmailTo": "makayla@mosciskihackett.ca",
      "SmsTo": "velit",
      "ReplyTemplateIdCustomer": 525,
      "ReplyTemplateIdUser": 604,
      "ReplyTemplateIdCatmast": 903,
      "ReplyTemplateIdEmail": 160,
      "RtiCustomerSms": 761,
      "ReplyTemplateIdUserSms": 832,
      "ReplyTemplateIdCatmastSms": 143,
      "ReplyTemplateIdSms": 438
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 574,
  "Name": "Lubowitz-Zulauf",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 791,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 826,
  "MonStart": "2021-12-28T14:28:22.1022648+01:00",
  "MonStop": "2016-09-24T14:28:22.1022648+02:00",
  "TueStart": "2011-03-22T14:28:22.1022648+01:00",
  "TueStop": "2009-11-20T14:28:22.1022648+01:00",
  "WedStart": "2007-03-13T14:28:22.1022648+01:00",
  "WedStop": "2019-01-22T14:28:22.1022648+01:00",
  "ThuStart": "2001-06-16T14:28:22.1022648+02:00",
  "ThuStop": "1997-12-18T14:28:22.1022648+01:00",
  "FriStart": "2017-06-27T14:28:22.1022648+02:00",
  "FriStop": "2007-11-24T14:28:22.1022648+01:00",
  "SatStart": "2006-07-22T14:28:22.1022648+02:00",
  "SatStop": "2009-11-23T14:28:22.1022648+01:00",
  "SunStart": "2015-11-05T14:28:22.1022648+01:00",
  "SunStop": "2024-11-06T14:28:22.1022648+01:00",
  "NonDates": [
    "voluptas",
    "reprehenderit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 414,
      "AlertLevel": 931,
      "AlertTimeout": 65,
      "Action": 236,
      "DelegateTo": 716,
      "ScriptId": 727,
      "EmailTo": "rebekah.will@schuppe.info",
      "SmsTo": "suscipit",
      "ReplyTemplateIdCustomer": 541,
      "ReplyTemplateIdUser": 430,
      "ReplyTemplateIdCatmast": 158,
      "ReplyTemplateIdEmail": 449,
      "RtiCustomerSms": 549,
      "ReplyTemplateIdUserSms": 927,
      "ReplyTemplateIdCatmastSms": 803,
      "ReplyTemplateIdSms": 441,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 247
    }
  }
}
```
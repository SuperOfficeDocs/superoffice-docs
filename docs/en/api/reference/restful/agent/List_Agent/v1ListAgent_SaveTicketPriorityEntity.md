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
  "TicketPriorityId": 270,
  "Name": "Smitham, Beier and Prohaska",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 371,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 293,
  "MonStart": "2001-01-16T13:57:12.575585+01:00",
  "MonStop": "2003-06-14T13:57:12.575585+02:00",
  "TueStart": "2007-09-22T13:57:12.575585+02:00",
  "TueStop": "2016-10-17T13:57:12.575585+02:00",
  "WedStart": "2017-04-28T13:57:12.575585+02:00",
  "WedStop": "2005-04-29T13:57:12.575585+02:00",
  "ThuStart": "2004-10-30T13:57:12.575585+02:00",
  "ThuStop": "2003-07-16T13:57:12.575585+02:00",
  "FriStart": "2015-08-26T13:57:12.575585+02:00",
  "FriStop": "2014-01-22T13:57:12.575585+01:00",
  "SatStart": "2014-05-29T13:57:12.575585+02:00",
  "SatStop": "2021-05-04T13:57:12.575585+02:00",
  "SunStart": "2011-11-09T13:57:12.575585+01:00",
  "SunStop": "2011-08-27T13:57:12.575585+02:00",
  "NonDates": [
    "fuga",
    "consequatur"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 16,
      "AlertLevel": 577,
      "AlertTimeout": 37,
      "Action": 359,
      "DelegateTo": 591,
      "ScriptId": 934,
      "EmailTo": "tristin.kirlin@green.us",
      "SmsTo": "repellendus",
      "ReplyTemplateIdCustomer": 70,
      "ReplyTemplateIdUser": 720,
      "ReplyTemplateIdCatmast": 868,
      "ReplyTemplateIdEmail": 581,
      "RtiCustomerSms": 673,
      "ReplyTemplateIdUserSms": 931,
      "ReplyTemplateIdCatmastSms": 669,
      "ReplyTemplateIdSms": 744
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 100,
  "Name": "Lynch, VonRueden and Volkman",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 835,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 762,
  "MonStart": "2020-03-01T13:57:12.575585+01:00",
  "MonStop": "2007-10-31T13:57:12.575585+01:00",
  "TueStart": "2015-08-10T13:57:12.575585+02:00",
  "TueStop": "2015-10-30T13:57:12.575585+01:00",
  "WedStart": "2014-02-21T13:57:12.575585+01:00",
  "WedStop": "2007-01-23T13:57:12.575585+01:00",
  "ThuStart": "1999-06-01T13:57:12.575585+02:00",
  "ThuStop": "2008-08-28T13:57:12.575585+02:00",
  "FriStart": "2023-09-14T13:57:12.575585+02:00",
  "FriStop": "2009-01-20T13:57:12.575585+01:00",
  "SatStart": "2009-10-31T13:57:12.575585+01:00",
  "SatStop": "2011-11-12T13:57:12.575585+01:00",
  "SunStart": "1996-12-10T13:57:12.575585+01:00",
  "SunStop": "1998-10-07T13:57:12.575585+02:00",
  "NonDates": [
    "in",
    "expedita"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 995,
      "AlertLevel": 153,
      "AlertTimeout": 794,
      "Action": 648,
      "DelegateTo": 591,
      "ScriptId": 498,
      "EmailTo": "korbin_ziemann@stoltenberg.name",
      "SmsTo": "corrupti",
      "ReplyTemplateIdCustomer": 535,
      "ReplyTemplateIdUser": 264,
      "ReplyTemplateIdCatmast": 736,
      "ReplyTemplateIdEmail": 177,
      "RtiCustomerSms": 710,
      "ReplyTemplateIdUserSms": 462,
      "ReplyTemplateIdCatmastSms": 7,
      "ReplyTemplateIdSms": 914,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 564
    }
  }
}
```
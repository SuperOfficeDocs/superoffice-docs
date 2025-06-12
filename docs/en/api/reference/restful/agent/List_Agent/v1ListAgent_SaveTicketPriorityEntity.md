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
  "TicketPriorityId": 303,
  "Name": "Ratke Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 111,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 564,
  "MonStart": "2011-10-14T17:54:03.3202006+02:00",
  "MonStop": "1999-09-20T17:54:03.3202006+02:00",
  "TueStart": "2022-04-11T17:54:03.3202006+02:00",
  "TueStop": "2007-03-18T17:54:03.3202006+01:00",
  "WedStart": "1998-04-30T17:54:03.3202006+02:00",
  "WedStop": "2020-09-23T17:54:03.3202006+02:00",
  "ThuStart": "2023-03-22T17:54:03.3202006+01:00",
  "ThuStop": "1998-05-07T17:54:03.3202006+02:00",
  "FriStart": "2019-01-24T17:54:03.3202006+01:00",
  "FriStop": "2019-03-07T17:54:03.3202006+01:00",
  "SatStart": "2010-02-01T17:54:03.3202006+01:00",
  "SatStop": "2004-09-15T17:54:03.3202006+02:00",
  "SunStart": "2013-02-27T17:54:03.3202006+01:00",
  "SunStop": "1998-04-08T17:54:03.3202006+02:00",
  "NonDates": [
    "perspiciatis",
    "similique"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 32,
      "AlertLevel": 968,
      "AlertTimeout": 720,
      "Action": 771,
      "DelegateTo": 687,
      "ScriptId": 526,
      "EmailTo": "breana@okuneva.biz",
      "SmsTo": "explicabo",
      "ReplyTemplateIdCustomer": 185,
      "ReplyTemplateIdUser": 507,
      "ReplyTemplateIdCatmast": 629,
      "ReplyTemplateIdEmail": 115,
      "RtiCustomerSms": 548,
      "ReplyTemplateIdUserSms": 652,
      "ReplyTemplateIdCatmastSms": 115,
      "ReplyTemplateIdSms": 752
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 527,
  "Name": "Brakus, Smith and Cronin",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 554,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 935,
  "MonStart": "2012-12-25T17:54:03.3202006+01:00",
  "MonStop": "2001-08-07T17:54:03.3202006+02:00",
  "TueStart": "2009-02-15T17:54:03.3202006+01:00",
  "TueStop": "2007-02-22T17:54:03.3202006+01:00",
  "WedStart": "2016-03-25T17:54:03.3202006+01:00",
  "WedStop": "2018-05-03T17:54:03.3202006+02:00",
  "ThuStart": "2010-01-18T17:54:03.3202006+01:00",
  "ThuStop": "2007-03-07T17:54:03.3202006+01:00",
  "FriStart": "2009-10-30T17:54:03.3202006+01:00",
  "FriStop": "2010-01-22T17:54:03.3202006+01:00",
  "SatStart": "2014-12-31T17:54:03.3202006+01:00",
  "SatStop": "2002-09-05T17:54:03.3202006+02:00",
  "SunStart": "2019-03-19T17:54:03.3202006+01:00",
  "SunStop": "2004-05-28T17:54:03.3202006+02:00",
  "NonDates": [
    "aperiam",
    "voluptatem"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 803,
      "AlertLevel": 829,
      "AlertTimeout": 962,
      "Action": 59,
      "DelegateTo": 652,
      "ScriptId": 891,
      "EmailTo": "joshua_skiles@daremohr.us",
      "SmsTo": "et",
      "ReplyTemplateIdCustomer": 441,
      "ReplyTemplateIdUser": 479,
      "ReplyTemplateIdCatmast": 706,
      "ReplyTemplateIdEmail": 497,
      "RtiCustomerSms": 750,
      "ReplyTemplateIdUserSms": 435,
      "ReplyTemplateIdCatmastSms": 74,
      "ReplyTemplateIdSms": 506,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 23
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 831
    }
  }
}
```
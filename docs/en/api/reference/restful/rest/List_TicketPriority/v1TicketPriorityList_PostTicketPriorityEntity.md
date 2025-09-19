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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 160,
  "Name": "Leffler, Schoen and Jewess",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 752,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 721,
  "MonStart": "1999-10-28T03:41:59.6367262+02:00",
  "MonStop": "2011-06-13T03:41:59.6367262+02:00",
  "TueStart": "2022-08-13T03:41:59.6367262+02:00",
  "TueStop": "2016-05-25T03:41:59.6367262+02:00",
  "WedStart": "2018-02-14T03:41:59.6367262+01:00",
  "WedStop": "2000-04-03T03:41:59.6367262+02:00",
  "ThuStart": "2010-07-30T03:41:59.6367262+02:00",
  "ThuStop": "2017-03-17T03:41:59.6367262+01:00",
  "FriStart": "2006-11-15T03:41:59.6367262+01:00",
  "FriStop": "2002-08-04T03:41:59.6367262+02:00",
  "SatStart": "2009-06-09T03:41:59.6367262+02:00",
  "SatStop": "2000-09-01T03:41:59.6367262+02:00",
  "SunStart": "2003-11-07T03:41:59.6367262+01:00",
  "SunStop": "1998-06-20T03:41:59.6367262+02:00",
  "NonDates": [
    "eum",
    "totam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 553,
      "AlertLevel": 160,
      "AlertTimeout": 378,
      "Action": 849,
      "DelegateTo": 418,
      "ScriptId": 498,
      "EmailTo": "leanne@hackettschmidt.us",
      "SmsTo": "id",
      "ReplyTemplateIdCustomer": 63,
      "ReplyTemplateIdUser": 170,
      "ReplyTemplateIdCatmast": 224,
      "ReplyTemplateIdEmail": 312,
      "RtiCustomerSms": 534,
      "ReplyTemplateIdUserSms": 779,
      "ReplyTemplateIdCatmastSms": 924,
      "ReplyTemplateIdSms": 773
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 622,
  "Name": "Schmeler Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 948,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 862,
  "MonStart": "2021-12-10T03:41:59.6367262+01:00",
  "MonStop": "2015-12-02T03:41:59.6367262+01:00",
  "TueStart": "2010-02-11T03:41:59.6367262+01:00",
  "TueStop": "2001-04-03T03:41:59.6367262+02:00",
  "WedStart": "2000-07-30T03:41:59.6367262+02:00",
  "WedStop": "2011-12-24T03:41:59.6367262+01:00",
  "ThuStart": "2005-06-20T03:41:59.6367262+02:00",
  "ThuStop": "2017-09-07T03:41:59.6367262+02:00",
  "FriStart": "2000-11-21T03:41:59.6367262+01:00",
  "FriStop": "2008-12-11T03:41:59.6367262+01:00",
  "SatStart": "2011-12-04T03:41:59.6367262+01:00",
  "SatStop": "2018-10-02T03:41:59.6367262+02:00",
  "SunStart": "2018-10-04T03:41:59.6367262+02:00",
  "SunStop": "2003-03-16T03:41:59.6367262+01:00",
  "NonDates": [
    "modi",
    "libero"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 166,
      "AlertLevel": 397,
      "AlertTimeout": 313,
      "Action": 367,
      "DelegateTo": 488,
      "ScriptId": 708,
      "EmailTo": "rasheed.wyman@padbergheller.info",
      "SmsTo": "natus",
      "ReplyTemplateIdCustomer": 593,
      "ReplyTemplateIdUser": 103,
      "ReplyTemplateIdCatmast": 736,
      "ReplyTemplateIdEmail": 315,
      "RtiCustomerSms": 14,
      "ReplyTemplateIdUserSms": 319,
      "ReplyTemplateIdCatmastSms": 865,
      "ReplyTemplateIdSms": 919,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 357
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 195
    }
  }
}
```
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
  "TicketPriorityId": 321,
  "Name": "Schmeler, Schmeler and Schumm",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 506,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 700,
  "MonStart": "2022-04-04T23:04:06.0099934+02:00",
  "MonStop": "2007-08-01T23:04:06.0099934+02:00",
  "TueStart": "2001-12-14T23:04:06.0099934+01:00",
  "TueStop": "2014-07-23T23:04:06.0099934+02:00",
  "WedStart": "1998-05-08T23:04:06.0099934+02:00",
  "WedStop": "2002-11-04T23:04:06.0099934+01:00",
  "ThuStart": "2008-12-20T23:04:06.0099934+01:00",
  "ThuStop": "2007-02-01T23:04:06.0099934+01:00",
  "FriStart": "2014-07-12T23:04:06.0099934+02:00",
  "FriStop": "2002-09-29T23:04:06.0099934+02:00",
  "SatStart": "2023-01-08T23:04:06.0099934+01:00",
  "SatStop": "2014-10-13T23:04:06.0099934+02:00",
  "SunStart": "2017-06-07T23:04:06.0099934+02:00",
  "SunStop": "2015-11-08T23:04:06.0099934+01:00",
  "NonDates": [
    "dolorem",
    "ab"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 350,
      "AlertLevel": 525,
      "AlertTimeout": 982,
      "Action": 393,
      "DelegateTo": 14,
      "ScriptId": 266,
      "EmailTo": "dario.rowe@lindgren.info",
      "SmsTo": "et",
      "ReplyTemplateIdCustomer": 496,
      "ReplyTemplateIdUser": 219,
      "ReplyTemplateIdCatmast": 571,
      "ReplyTemplateIdEmail": 588,
      "RtiCustomerSms": 567,
      "ReplyTemplateIdUserSms": 268,
      "ReplyTemplateIdCatmastSms": 409,
      "ReplyTemplateIdSms": 356
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 954,
  "Name": "Erdman Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 522,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 230,
  "MonStart": "1999-02-25T23:04:06.0104936+01:00",
  "MonStop": "2004-11-06T23:04:06.0104936+01:00",
  "TueStart": "2010-11-16T23:04:06.0104936+01:00",
  "TueStop": "2021-03-28T23:04:06.0104936+02:00",
  "WedStart": "2013-12-21T23:04:06.0104936+01:00",
  "WedStop": "2012-03-29T23:04:06.0104936+02:00",
  "ThuStart": "2002-08-04T23:04:06.0104936+02:00",
  "ThuStop": "2000-01-30T23:04:06.0104936+01:00",
  "FriStart": "2012-04-18T23:04:06.0104936+02:00",
  "FriStop": "2001-09-24T23:04:06.0104936+02:00",
  "SatStart": "2015-07-30T23:04:06.0104936+02:00",
  "SatStop": "2019-12-09T23:04:06.0104936+01:00",
  "SunStart": "2021-05-04T23:04:06.0104936+02:00",
  "SunStop": "2007-07-27T23:04:06.0104936+02:00",
  "NonDates": [
    "distinctio",
    "esse"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 507,
      "AlertLevel": 951,
      "AlertTimeout": 153,
      "Action": 515,
      "DelegateTo": 116,
      "ScriptId": 301,
      "EmailTo": "sierra@walshpollich.ca",
      "SmsTo": "eos",
      "ReplyTemplateIdCustomer": 931,
      "ReplyTemplateIdUser": 737,
      "ReplyTemplateIdCatmast": 931,
      "ReplyTemplateIdEmail": 435,
      "RtiCustomerSms": 909,
      "ReplyTemplateIdUserSms": 15,
      "ReplyTemplateIdCatmastSms": 334,
      "ReplyTemplateIdSms": 522,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 832
    }
  }
}
```
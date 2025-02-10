---
title: PUT List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_PutTicketPriorityEntity
generated: true
---

# PUT List/TicketPriority/Items/{id}

```http
PUT /api/v1/List/TicketPriority/Items/{id}
```

Updates the existing TicketPriorityEntity


Calls the List agent service SaveTicketPriorityEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of TicketPriorityEntity to be saved. **Required** |



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

The details of TicketPriorityEntity to be saved. 

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
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 350,
  "Name": "Heller LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 112,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 448,
  "MonStart": "2002-06-16T12:01:33.6832402+02:00",
  "MonStop": "2008-12-10T12:01:33.6832402+01:00",
  "TueStart": "2024-02-03T12:01:33.6832402+01:00",
  "TueStop": "2007-06-20T12:01:33.6832402+02:00",
  "WedStart": "2005-07-18T12:01:33.6832402+02:00",
  "WedStop": "2016-06-19T12:01:33.6832402+02:00",
  "ThuStart": "2005-10-03T12:01:33.6832402+02:00",
  "ThuStop": "2011-02-03T12:01:33.6832402+01:00",
  "FriStart": "2023-09-29T12:01:33.6832402+02:00",
  "FriStop": "2024-01-16T12:01:33.6832402+01:00",
  "SatStart": "2002-03-01T12:01:33.6832402+01:00",
  "SatStop": "1999-06-06T12:01:33.6832402+02:00",
  "SunStart": "2014-08-05T12:01:33.6832402+02:00",
  "SunStop": "2006-01-23T12:01:33.6832402+01:00",
  "NonDates": [
    "laudantium",
    "saepe"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 151,
      "AlertLevel": 787,
      "AlertTimeout": 118,
      "Action": 778,
      "DelegateTo": 747,
      "ScriptId": 724,
      "EmailTo": "skye@stamm.info",
      "SmsTo": "corrupti",
      "ReplyTemplateIdCustomer": 3,
      "ReplyTemplateIdUser": 740,
      "ReplyTemplateIdCatmast": 853,
      "ReplyTemplateIdEmail": 246,
      "RtiCustomerSms": 14,
      "ReplyTemplateIdUserSms": 297,
      "ReplyTemplateIdCatmastSms": 152,
      "ReplyTemplateIdSms": 832
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 246,
  "Name": "Kilback, Mitchell and O'Connell",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 687,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 537,
  "MonStart": "2010-06-26T12:01:33.6832402+02:00",
  "MonStop": "2015-06-29T12:01:33.6832402+02:00",
  "TueStart": "2016-11-27T12:01:33.6832402+01:00",
  "TueStop": "2010-02-03T12:01:33.6832402+01:00",
  "WedStart": "2022-02-12T12:01:33.6832402+01:00",
  "WedStop": "2009-10-19T12:01:33.6832402+02:00",
  "ThuStart": "2018-06-12T12:01:33.6832402+02:00",
  "ThuStop": "2012-12-17T12:01:33.6832402+01:00",
  "FriStart": "2022-01-05T12:01:33.6832402+01:00",
  "FriStop": "2021-04-04T12:01:33.6832402+02:00",
  "SatStart": "2020-11-11T12:01:33.6832402+01:00",
  "SatStop": "2011-12-07T12:01:33.6832402+01:00",
  "SunStart": "2015-02-12T12:01:33.6832402+01:00",
  "SunStop": "2013-01-19T12:01:33.6832402+01:00",
  "NonDates": [
    "magni",
    "praesentium"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 309,
      "AlertLevel": 153,
      "AlertTimeout": 453,
      "Action": 363,
      "DelegateTo": 730,
      "ScriptId": 778,
      "EmailTo": "joan.corkery@greenholt.com",
      "SmsTo": "quia",
      "ReplyTemplateIdCustomer": 710,
      "ReplyTemplateIdUser": 79,
      "ReplyTemplateIdCatmast": 469,
      "ReplyTemplateIdEmail": 886,
      "RtiCustomerSms": 795,
      "ReplyTemplateIdUserSms": 957,
      "ReplyTemplateIdCatmastSms": 199,
      "ReplyTemplateIdSms": 199,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 297
    }
  }
}
```
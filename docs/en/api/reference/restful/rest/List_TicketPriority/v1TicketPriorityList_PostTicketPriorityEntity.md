---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 722,
  "Name": "Schmeler, Ankunding and Balistreri",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 531,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 448,
  "MonStart": "2005-06-05T11:22:46.2409792+02:00",
  "MonStop": "2005-10-15T11:22:46.2409792+02:00",
  "TueStart": "2008-04-07T11:22:46.2409792+02:00",
  "TueStop": "2022-11-11T11:22:46.2409792+01:00",
  "WedStart": "2003-07-01T11:22:46.2409792+02:00",
  "WedStop": "2009-01-27T11:22:46.2409792+01:00",
  "ThuStart": "2015-08-08T11:22:46.2409792+02:00",
  "ThuStop": "2005-06-28T11:22:46.2409792+02:00",
  "FriStart": "2015-09-09T11:22:46.2409792+02:00",
  "FriStop": "2006-10-25T11:22:46.2409792+02:00",
  "SatStart": "2019-08-07T11:22:46.2409792+02:00",
  "SatStop": "2001-05-11T11:22:46.2409792+02:00",
  "SunStart": "2014-06-20T11:22:46.2409792+02:00",
  "SunStop": "2015-05-08T11:22:46.2409792+02:00",
  "NonDates": [
    "molestias",
    "in"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 39,
      "AlertLevel": 57,
      "AlertTimeout": 208,
      "Action": 232,
      "DelegateTo": 980,
      "ScriptId": 575,
      "EmailTo": "osvaldo@okeefe.biz",
      "SmsTo": "voluptas",
      "ReplyTemplateIdCustomer": 140,
      "ReplyTemplateIdUser": 302,
      "ReplyTemplateIdCatmast": 120,
      "ReplyTemplateIdEmail": 834,
      "RtiCustomerSms": 267,
      "ReplyTemplateIdUserSms": 879,
      "ReplyTemplateIdCatmastSms": 903,
      "ReplyTemplateIdSms": 534
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 57,
  "Name": "Tromp Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 775,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 718,
  "MonStart": "2006-03-10T11:22:46.2409792+01:00",
  "MonStop": "2012-02-12T11:22:46.2409792+01:00",
  "TueStart": "1996-03-10T11:22:46.2409792+01:00",
  "TueStop": "2001-11-04T11:22:46.2409792+01:00",
  "WedStart": "2008-08-17T11:22:46.2409792+02:00",
  "WedStop": "2017-07-11T11:22:46.2409792+02:00",
  "ThuStart": "2005-01-31T11:22:46.2409792+01:00",
  "ThuStop": "1996-10-29T11:22:46.2409792+01:00",
  "FriStart": "2017-06-13T11:22:46.2409792+02:00",
  "FriStop": "2001-10-02T11:22:46.2409792+02:00",
  "SatStart": "1998-09-06T11:22:46.2409792+02:00",
  "SatStop": "2016-01-05T11:22:46.2409792+01:00",
  "SunStart": "2014-03-08T11:22:46.2409792+01:00",
  "SunStop": "2006-09-22T11:22:46.2409792+02:00",
  "NonDates": [
    "perspiciatis",
    "similique"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 643,
      "AlertLevel": 447,
      "AlertTimeout": 273,
      "Action": 479,
      "DelegateTo": 129,
      "ScriptId": 780,
      "EmailTo": "ramona.koss@witting.biz",
      "SmsTo": "nostrum",
      "ReplyTemplateIdCustomer": 484,
      "ReplyTemplateIdUser": 42,
      "ReplyTemplateIdCatmast": 833,
      "ReplyTemplateIdEmail": 297,
      "RtiCustomerSms": 560,
      "ReplyTemplateIdUserSms": 79,
      "ReplyTemplateIdCatmastSms": 53,
      "ReplyTemplateIdSms": 494,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 899
    }
  }
}
```
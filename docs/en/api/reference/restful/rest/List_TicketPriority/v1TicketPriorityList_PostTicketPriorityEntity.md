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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 312,
  "Name": "Haag LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 394,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 185,
  "MonStart": "2005-11-18T11:44:43.398025+01:00",
  "MonStop": "2008-11-26T11:44:43.398025+01:00",
  "TueStart": "1997-06-20T11:44:43.398025+02:00",
  "TueStop": "2013-09-26T11:44:43.398025+02:00",
  "WedStart": "2000-07-26T11:44:43.398025+02:00",
  "WedStop": "2015-04-30T11:44:43.398025+02:00",
  "ThuStart": "2004-06-11T11:44:43.398025+02:00",
  "ThuStop": "2015-05-22T11:44:43.398025+02:00",
  "FriStart": "2018-04-20T11:44:43.398025+02:00",
  "FriStop": "2023-04-06T11:44:43.398025+02:00",
  "SatStart": "2006-08-06T11:44:43.398025+02:00",
  "SatStop": "1999-07-02T11:44:43.398025+02:00",
  "SunStart": "2011-01-05T11:44:43.398025+01:00",
  "SunStop": "2017-10-02T11:44:43.398025+02:00",
  "NonDates": [
    "neque",
    "deleniti"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 753,
      "AlertLevel": 275,
      "AlertTimeout": 965,
      "Action": 96,
      "DelegateTo": 290,
      "ScriptId": 12,
      "EmailTo": "merl_emard@johnson.uk",
      "SmsTo": "nulla",
      "ReplyTemplateIdCustomer": 828,
      "ReplyTemplateIdUser": 491,
      "ReplyTemplateIdCatmast": 461,
      "ReplyTemplateIdEmail": 71,
      "RtiCustomerSms": 569,
      "ReplyTemplateIdUserSms": 672,
      "ReplyTemplateIdCatmastSms": 422,
      "ReplyTemplateIdSms": 815
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 316,
  "Name": "Gerhold-Hartmann",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 584,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 928,
  "MonStart": "2008-07-17T11:44:43.398025+02:00",
  "MonStop": "1999-09-21T11:44:43.398025+02:00",
  "TueStart": "2004-04-08T11:44:43.398025+02:00",
  "TueStop": "2000-12-12T11:44:43.398025+01:00",
  "WedStart": "1997-08-26T11:44:43.398025+02:00",
  "WedStop": "1997-11-13T11:44:43.398025+01:00",
  "ThuStart": "2013-11-05T11:44:43.398025+01:00",
  "ThuStop": "2005-03-20T11:44:43.398025+01:00",
  "FriStart": "2007-02-23T11:44:43.398025+01:00",
  "FriStop": "2000-09-01T11:44:43.398025+02:00",
  "SatStart": "1999-11-21T11:44:43.398025+01:00",
  "SatStop": "2000-10-05T11:44:43.398025+02:00",
  "SunStart": "2015-11-12T11:44:43.398025+01:00",
  "SunStop": "2008-10-03T11:44:43.398025+02:00",
  "NonDates": [
    "sit",
    "facilis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 923,
      "AlertLevel": 274,
      "AlertTimeout": 27,
      "Action": 217,
      "DelegateTo": 874,
      "ScriptId": 408,
      "EmailTo": "deanna@lockmanheidenreich.info",
      "SmsTo": "qui",
      "ReplyTemplateIdCustomer": 189,
      "ReplyTemplateIdUser": 635,
      "ReplyTemplateIdCatmast": 751,
      "ReplyTemplateIdEmail": 791,
      "RtiCustomerSms": 690,
      "ReplyTemplateIdUserSms": 789,
      "ReplyTemplateIdCatmastSms": 386,
      "ReplyTemplateIdSms": 947,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 732
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 409
    }
  }
}
```
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 57,
  "Name": "Ryan-Batz",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 402,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 381,
  "MonStart": "2004-12-22T14:13:50.3064464+01:00",
  "MonStop": "2011-07-09T14:13:50.3064464+02:00",
  "TueStart": "1999-08-21T14:13:50.3064464+02:00",
  "TueStop": "2024-08-23T14:13:50.3064464+02:00",
  "WedStart": "2002-08-22T14:13:50.3064464+02:00",
  "WedStop": "2010-10-02T14:13:50.3064464+02:00",
  "ThuStart": "2017-03-11T14:13:50.3064464+01:00",
  "ThuStop": "2016-11-04T14:13:50.3064464+01:00",
  "FriStart": "2011-01-18T14:13:50.3064464+01:00",
  "FriStop": "2013-03-28T14:13:50.3064464+01:00",
  "SatStart": "2004-08-31T14:13:50.3064464+02:00",
  "SatStop": "2007-07-01T14:13:50.3064464+02:00",
  "SunStart": "2018-12-16T14:13:50.3064464+01:00",
  "SunStop": "2012-10-23T14:13:50.3064464+02:00",
  "NonDates": [
    "et",
    "omnis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 942,
      "AlertLevel": 808,
      "AlertTimeout": 151,
      "Action": 631,
      "DelegateTo": 248,
      "ScriptId": 326,
      "EmailTo": "una@reilly.co.uk",
      "SmsTo": "tempore",
      "ReplyTemplateIdCustomer": 90,
      "ReplyTemplateIdUser": 302,
      "ReplyTemplateIdCatmast": 555,
      "ReplyTemplateIdEmail": 213,
      "RtiCustomerSms": 107,
      "ReplyTemplateIdUserSms": 383,
      "ReplyTemplateIdCatmastSms": 283,
      "ReplyTemplateIdSms": 350
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 242,
  "Name": "Cronin, Gerhold and Bailey",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 604,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 452,
  "MonStart": "1999-12-16T14:13:50.3064464+01:00",
  "MonStop": "2023-12-19T14:13:50.3064464+01:00",
  "TueStart": "2000-05-13T14:13:50.3064464+02:00",
  "TueStop": "2010-01-11T14:13:50.3064464+01:00",
  "WedStart": "1999-07-13T14:13:50.3064464+02:00",
  "WedStop": "2003-08-12T14:13:50.3064464+02:00",
  "ThuStart": "2020-01-24T14:13:50.3064464+01:00",
  "ThuStop": "2014-11-19T14:13:50.3064464+01:00",
  "FriStart": "2012-01-01T14:13:50.3064464+01:00",
  "FriStop": "2013-05-27T14:13:50.3064464+02:00",
  "SatStart": "2004-01-22T14:13:50.3064464+01:00",
  "SatStop": "1999-07-08T14:13:50.3064464+02:00",
  "SunStart": "2012-04-15T14:13:50.3064464+02:00",
  "SunStop": "2009-05-02T14:13:50.3064464+02:00",
  "NonDates": [
    "aut",
    "aspernatur"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 139,
      "AlertLevel": 908,
      "AlertTimeout": 603,
      "Action": 416,
      "DelegateTo": 105,
      "ScriptId": 626,
      "EmailTo": "frida_glover@swaniawskihodkiewicz.biz",
      "SmsTo": "modi",
      "ReplyTemplateIdCustomer": 434,
      "ReplyTemplateIdUser": 905,
      "ReplyTemplateIdCatmast": 639,
      "ReplyTemplateIdEmail": 686,
      "RtiCustomerSms": 700,
      "ReplyTemplateIdUserSms": 438,
      "ReplyTemplateIdCatmastSms": 572,
      "ReplyTemplateIdSms": 895,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 693
    }
  }
}
```
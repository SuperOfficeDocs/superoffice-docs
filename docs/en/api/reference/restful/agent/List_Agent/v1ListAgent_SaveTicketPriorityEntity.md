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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 136,
  "Name": "Ledner-Zboncak",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 154,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 599,
  "MonStart": "2006-01-21T16:32:39.320696+01:00",
  "MonStop": "2023-09-29T16:32:39.320696+02:00",
  "TueStart": "2008-08-14T16:32:39.320696+02:00",
  "TueStop": "2015-06-01T16:32:39.320696+02:00",
  "WedStart": "1998-01-03T16:32:39.320696+01:00",
  "WedStop": "2016-04-09T16:32:39.320696+02:00",
  "ThuStart": "2009-09-22T16:32:39.320696+02:00",
  "ThuStop": "2004-08-27T16:32:39.320696+02:00",
  "FriStart": "2023-06-02T16:32:39.320696+02:00",
  "FriStop": "2003-07-02T16:32:39.320696+02:00",
  "SatStart": "2011-07-25T16:32:39.320696+02:00",
  "SatStop": "2009-08-11T16:32:39.320696+02:00",
  "SunStart": "2020-12-25T16:32:39.320696+01:00",
  "SunStop": "2013-04-03T16:32:39.320696+02:00",
  "NonDates": [
    "et",
    "molestias"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 753,
      "AlertLevel": 238,
      "AlertTimeout": 27,
      "Action": 681,
      "DelegateTo": 938,
      "ScriptId": 325,
      "EmailTo": "maryjane.cassin@hesseldicki.us",
      "SmsTo": "expedita",
      "ReplyTemplateIdCustomer": 333,
      "ReplyTemplateIdUser": 318,
      "ReplyTemplateIdCatmast": 593,
      "ReplyTemplateIdEmail": 58,
      "RtiCustomerSms": 138,
      "ReplyTemplateIdUserSms": 971,
      "ReplyTemplateIdCatmastSms": 245,
      "ReplyTemplateIdSms": 429
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 313,
  "Name": "Streich, Goyette and Will",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 893,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 526,
  "MonStart": "2020-06-28T16:32:39.320696+02:00",
  "MonStop": "2003-12-03T16:32:39.320696+01:00",
  "TueStart": "2018-03-20T16:32:39.320696+01:00",
  "TueStop": "2020-04-01T16:32:39.320696+02:00",
  "WedStart": "2008-05-11T16:32:39.320696+02:00",
  "WedStop": "2012-11-13T16:32:39.320696+01:00",
  "ThuStart": "2015-03-04T16:32:39.320696+01:00",
  "ThuStop": "2009-09-22T16:32:39.320696+02:00",
  "FriStart": "2008-03-05T16:32:39.320696+01:00",
  "FriStop": "2021-03-11T16:32:39.320696+01:00",
  "SatStart": "2010-05-13T16:32:39.320696+02:00",
  "SatStop": "2000-11-18T16:32:39.320696+01:00",
  "SunStart": "2010-01-12T16:32:39.320696+01:00",
  "SunStop": "2000-07-04T16:32:39.320696+02:00",
  "NonDates": [
    "consequuntur",
    "officia"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 560,
      "AlertLevel": 349,
      "AlertTimeout": 202,
      "Action": 134,
      "DelegateTo": 174,
      "ScriptId": 128,
      "EmailTo": "rosalinda@schinner.us",
      "SmsTo": "sit",
      "ReplyTemplateIdCustomer": 146,
      "ReplyTemplateIdUser": 144,
      "ReplyTemplateIdCatmast": 611,
      "ReplyTemplateIdEmail": 192,
      "RtiCustomerSms": 112,
      "ReplyTemplateIdUserSms": 564,
      "ReplyTemplateIdCatmastSms": 289,
      "ReplyTemplateIdSms": 667,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 968
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 581
    }
  }
}
```
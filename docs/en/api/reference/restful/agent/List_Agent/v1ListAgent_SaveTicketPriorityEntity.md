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
  "TicketPriorityId": 515,
  "Name": "Nikolaus LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 613,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 456,
  "MonStart": "2003-12-23T04:02:01.8784808+01:00",
  "MonStop": "2006-07-21T04:02:01.8784808+02:00",
  "TueStart": "2002-04-25T04:02:01.8784808+02:00",
  "TueStop": "2021-05-04T04:02:01.8784808+02:00",
  "WedStart": "2006-04-10T04:02:01.8784808+02:00",
  "WedStop": "2019-07-17T04:02:01.8784808+02:00",
  "ThuStart": "2013-03-19T04:02:01.8784808+01:00",
  "ThuStop": "2005-12-28T04:02:01.8784808+01:00",
  "FriStart": "2008-11-23T04:02:01.8784808+01:00",
  "FriStop": "2014-04-26T04:02:01.8784808+02:00",
  "SatStart": "2010-05-08T04:02:01.8784808+02:00",
  "SatStop": "2008-10-24T04:02:01.8784808+02:00",
  "SunStart": "2016-02-08T04:02:01.8784808+01:00",
  "SunStop": "2017-10-28T04:02:01.8784808+02:00",
  "NonDates": [
    "explicabo",
    "eos"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 495,
      "AlertLevel": 510,
      "AlertTimeout": 156,
      "Action": 514,
      "DelegateTo": 184,
      "ScriptId": 383,
      "EmailTo": "elinore.gibson@feil.uk",
      "SmsTo": "quidem",
      "ReplyTemplateIdCustomer": 329,
      "ReplyTemplateIdUser": 846,
      "ReplyTemplateIdCatmast": 855,
      "ReplyTemplateIdEmail": 309,
      "RtiCustomerSms": 482,
      "ReplyTemplateIdUserSms": 511,
      "ReplyTemplateIdCatmastSms": 580,
      "ReplyTemplateIdSms": 855
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 804,
  "Name": "Crooks-Skiles",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 372,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 817,
  "MonStart": "2007-07-11T04:02:01.8784808+02:00",
  "MonStop": "2009-11-30T04:02:01.8784808+01:00",
  "TueStart": "1998-11-19T04:02:01.8784808+01:00",
  "TueStop": "2023-07-26T04:02:01.8784808+02:00",
  "WedStart": "2013-07-11T04:02:01.8784808+02:00",
  "WedStop": "2006-03-04T04:02:01.8784808+01:00",
  "ThuStart": "2015-11-15T04:02:01.8784808+01:00",
  "ThuStop": "2020-12-09T04:02:01.8784808+01:00",
  "FriStart": "2012-02-16T04:02:01.8784808+01:00",
  "FriStop": "2015-11-23T04:02:01.8784808+01:00",
  "SatStart": "2009-02-22T04:02:01.8784808+01:00",
  "SatStop": "2001-09-29T04:02:01.8784808+02:00",
  "SunStart": "2001-01-24T04:02:01.8784808+01:00",
  "SunStop": "2023-07-11T04:02:01.8784808+02:00",
  "NonDates": [
    "minus",
    "aut"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 552,
      "AlertLevel": 714,
      "AlertTimeout": 1000,
      "Action": 299,
      "DelegateTo": 774,
      "ScriptId": 889,
      "EmailTo": "alysa@block.com",
      "SmsTo": "iste",
      "ReplyTemplateIdCustomer": 495,
      "ReplyTemplateIdUser": 764,
      "ReplyTemplateIdCatmast": 558,
      "ReplyTemplateIdEmail": 630,
      "RtiCustomerSms": 774,
      "ReplyTemplateIdUserSms": 854,
      "ReplyTemplateIdCatmastSms": 598,
      "ReplyTemplateIdSms": 490,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 24
    }
  }
}
```
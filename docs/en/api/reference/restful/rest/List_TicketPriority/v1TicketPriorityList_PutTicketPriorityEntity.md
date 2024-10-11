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
  "TicketPriorityId": 476,
  "Name": "Weissnat, Becker and Daugherty",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 911,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 884,
  "MonStart": "1999-09-15T03:44:58.1874634+02:00",
  "MonStop": "2002-02-18T03:44:58.1874634+01:00",
  "TueStart": "2019-11-07T03:44:58.1874634+01:00",
  "TueStop": "2003-01-30T03:44:58.1874634+01:00",
  "WedStart": "2002-04-09T03:44:58.1874634+02:00",
  "WedStop": "2014-04-13T03:44:58.1874634+02:00",
  "ThuStart": "2000-08-15T03:44:58.1874634+02:00",
  "ThuStop": "2002-04-20T03:44:58.1874634+02:00",
  "FriStart": "2012-11-03T03:44:58.1874634+01:00",
  "FriStop": "2023-10-09T03:44:58.1874634+02:00",
  "SatStart": "2002-09-07T03:44:58.1874634+02:00",
  "SatStop": "2018-09-25T03:44:58.1874634+02:00",
  "SunStart": "2009-09-17T03:44:58.1874634+02:00",
  "SunStop": "2015-07-15T03:44:58.1874634+02:00",
  "NonDates": [
    "dolorum",
    "quo"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 824,
      "AlertLevel": 969,
      "AlertTimeout": 701,
      "Action": 393,
      "DelegateTo": 700,
      "ScriptId": 647,
      "EmailTo": "orland_langosh@langworth.uk",
      "SmsTo": "est",
      "ReplyTemplateIdCustomer": 489,
      "ReplyTemplateIdUser": 871,
      "ReplyTemplateIdCatmast": 337,
      "ReplyTemplateIdEmail": 593,
      "RtiCustomerSms": 426,
      "ReplyTemplateIdUserSms": 766,
      "ReplyTemplateIdCatmastSms": 317,
      "ReplyTemplateIdSms": 445
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 65,
  "Name": "Emard, Wehner and Langosh",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 650,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 89,
  "MonStart": "2004-10-18T03:44:58.2030872+02:00",
  "MonStop": "2019-02-18T03:44:58.2030872+01:00",
  "TueStart": "2005-09-19T03:44:58.2030872+02:00",
  "TueStop": "2018-06-17T03:44:58.2030872+02:00",
  "WedStart": "2007-03-07T03:44:58.2030872+01:00",
  "WedStop": "2000-04-12T03:44:58.2030872+02:00",
  "ThuStart": "2008-04-28T03:44:58.2030872+02:00",
  "ThuStop": "2010-12-12T03:44:58.2030872+01:00",
  "FriStart": "2013-06-26T03:44:58.2030872+02:00",
  "FriStop": "2022-12-05T03:44:58.2030872+01:00",
  "SatStart": "2001-02-01T03:44:58.2030872+01:00",
  "SatStop": "2001-07-19T03:44:58.2030872+02:00",
  "SunStart": "2017-08-20T03:44:58.2030872+02:00",
  "SunStop": "2006-10-04T03:44:58.2030872+02:00",
  "NonDates": [
    "sit",
    "repellendus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 404,
      "AlertLevel": 975,
      "AlertTimeout": 118,
      "Action": 12,
      "DelegateTo": 172,
      "ScriptId": 941,
      "EmailTo": "frederick.schmeler@langworth.biz",
      "SmsTo": "sed",
      "ReplyTemplateIdCustomer": 418,
      "ReplyTemplateIdUser": 325,
      "ReplyTemplateIdCatmast": 991,
      "ReplyTemplateIdEmail": 658,
      "RtiCustomerSms": 24,
      "ReplyTemplateIdUserSms": 799,
      "ReplyTemplateIdCatmastSms": 523,
      "ReplyTemplateIdSms": 130,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 632
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 392
    }
  }
}
```
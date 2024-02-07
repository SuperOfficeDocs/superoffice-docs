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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 701,
  "Name": "Price-Cummings",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 991,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 571,
  "MonStart": "2013-10-28T16:55:31.1357955+01:00",
  "MonStop": "2004-07-28T16:55:31.1357955+02:00",
  "TueStart": "2005-06-16T16:55:31.1357955+02:00",
  "TueStop": "2022-05-17T16:55:31.1357955+02:00",
  "WedStart": "2010-03-28T16:55:31.1357955+02:00",
  "WedStop": "1996-11-18T16:55:31.1357955+01:00",
  "ThuStart": "2017-08-21T16:55:31.1357955+02:00",
  "ThuStop": "1998-10-08T16:55:31.1357955+02:00",
  "FriStart": "2007-10-24T16:55:31.1357955+02:00",
  "FriStop": "2013-03-09T16:55:31.1357955+01:00",
  "SatStart": "2007-09-18T16:55:31.1357955+02:00",
  "SatStop": "2000-10-30T16:55:31.1357955+01:00",
  "SunStart": "2009-04-17T16:55:31.1357955+02:00",
  "SunStop": "2000-10-08T16:55:31.1357955+02:00",
  "NonDates": [
    "et",
    "soluta"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 593,
      "AlertLevel": 239,
      "AlertTimeout": 875,
      "Action": 904,
      "DelegateTo": 644,
      "ScriptId": 822,
      "EmailTo": "alejandra.mayert@wilderman.com",
      "SmsTo": "est",
      "ReplyTemplateIdCustomer": 754,
      "ReplyTemplateIdUser": 875,
      "ReplyTemplateIdCatmast": 96,
      "ReplyTemplateIdEmail": 709,
      "RtiCustomerSms": 532,
      "ReplyTemplateIdUserSms": 198,
      "ReplyTemplateIdCatmastSms": 226,
      "ReplyTemplateIdSms": 857
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 956,
  "Name": "Reilly-Skiles",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 703,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 76,
  "MonStart": "2019-12-21T16:55:31.1378143+01:00",
  "MonStop": "2002-03-12T16:55:31.1378143+01:00",
  "TueStart": "2010-04-02T16:55:31.1378143+02:00",
  "TueStop": "2023-07-30T16:55:31.1378143+02:00",
  "WedStart": "2021-10-08T16:55:31.1378143+02:00",
  "WedStop": "2006-02-03T16:55:31.1378143+01:00",
  "ThuStart": "2007-03-19T16:55:31.1378143+01:00",
  "ThuStop": "2016-04-11T16:55:31.1378143+02:00",
  "FriStart": "2013-04-28T16:55:31.1378143+02:00",
  "FriStop": "2012-12-15T16:55:31.1378143+01:00",
  "SatStart": "2017-03-03T16:55:31.1378143+01:00",
  "SatStop": "1998-02-06T16:55:31.1378143+01:00",
  "SunStart": "1999-09-22T16:55:31.1378143+02:00",
  "SunStop": "2007-11-20T16:55:31.1378143+01:00",
  "NonDates": [
    "suscipit",
    "explicabo"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 569,
      "AlertLevel": 40,
      "AlertTimeout": 593,
      "Action": 569,
      "DelegateTo": 246,
      "ScriptId": 20,
      "EmailTo": "waino_brakus@murazik.us",
      "SmsTo": "et",
      "ReplyTemplateIdCustomer": 45,
      "ReplyTemplateIdUser": 86,
      "ReplyTemplateIdCatmast": 87,
      "ReplyTemplateIdEmail": 910,
      "RtiCustomerSms": 84,
      "ReplyTemplateIdUserSms": 587,
      "ReplyTemplateIdCatmastSms": 89,
      "ReplyTemplateIdSms": 902,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 135
    }
  }
}
```
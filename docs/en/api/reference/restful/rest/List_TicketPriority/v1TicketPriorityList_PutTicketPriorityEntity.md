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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 631,
  "Name": "Wehner, O'Reilly and Kassulke",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 460,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 710,
  "MonStart": "2023-04-23T23:04:06.0189926+02:00",
  "MonStop": "2016-04-29T23:04:06.0189926+02:00",
  "TueStart": "2010-02-06T23:04:06.0189926+01:00",
  "TueStop": "2002-08-26T23:04:06.0189926+02:00",
  "WedStart": "2022-09-02T23:04:06.0189926+02:00",
  "WedStop": "2004-08-09T23:04:06.0189926+02:00",
  "ThuStart": "2003-06-17T23:04:06.0189926+02:00",
  "ThuStop": "2008-01-25T23:04:06.0189926+01:00",
  "FriStart": "2003-05-07T23:04:06.0189926+02:00",
  "FriStop": "2019-01-14T23:04:06.0189926+01:00",
  "SatStart": "2000-05-24T23:04:06.0189926+02:00",
  "SatStop": "2004-09-02T23:04:06.0189926+02:00",
  "SunStart": "2000-05-09T23:04:06.0189926+02:00",
  "SunStop": "2008-11-26T23:04:06.0189926+01:00",
  "NonDates": [
    "libero",
    "ullam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 149,
      "AlertLevel": 793,
      "AlertTimeout": 983,
      "Action": 504,
      "DelegateTo": 435,
      "ScriptId": 522,
      "EmailTo": "myriam_block@auer.us",
      "SmsTo": "id",
      "ReplyTemplateIdCustomer": 675,
      "ReplyTemplateIdUser": 419,
      "ReplyTemplateIdCatmast": 548,
      "ReplyTemplateIdEmail": 601,
      "RtiCustomerSms": 43,
      "ReplyTemplateIdUserSms": 334,
      "ReplyTemplateIdCatmastSms": 288,
      "ReplyTemplateIdSms": 814
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 44,
  "Name": "Greenholt Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 870,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 38,
  "MonStart": "1999-05-26T23:04:06.0199991+02:00",
  "MonStop": "2020-02-01T23:04:06.0199991+01:00",
  "TueStart": "2020-02-03T23:04:06.0199991+01:00",
  "TueStop": "2019-02-01T23:04:06.0199991+01:00",
  "WedStart": "2011-10-09T23:04:06.0199991+02:00",
  "WedStop": "2010-08-29T23:04:06.0199991+02:00",
  "ThuStart": "1998-12-06T23:04:06.0199991+01:00",
  "ThuStop": "2000-06-01T23:04:06.0199991+02:00",
  "FriStart": "2021-03-10T23:04:06.0199991+01:00",
  "FriStop": "2023-03-07T23:04:06.0199991+01:00",
  "SatStart": "2007-06-28T23:04:06.0199991+02:00",
  "SatStop": "2013-06-28T23:04:06.0199991+02:00",
  "SunStart": "2004-11-09T23:04:06.0199991+01:00",
  "SunStop": "2001-04-25T23:04:06.0199991+02:00",
  "NonDates": [
    "similique",
    "ut"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 672,
      "AlertLevel": 150,
      "AlertTimeout": 421,
      "Action": 405,
      "DelegateTo": 324,
      "ScriptId": 482,
      "EmailTo": "mossie.goodwin@willms.biz",
      "SmsTo": "consectetur",
      "ReplyTemplateIdCustomer": 895,
      "ReplyTemplateIdUser": 937,
      "ReplyTemplateIdCatmast": 423,
      "ReplyTemplateIdEmail": 877,
      "RtiCustomerSms": 112,
      "ReplyTemplateIdUserSms": 746,
      "ReplyTemplateIdCatmastSms": 483,
      "ReplyTemplateIdSms": 389,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 738
    }
  }
}
```
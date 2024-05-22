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
  "TicketPriorityId": 976,
  "Name": "Hansen, Wuckert and Mayer",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 450,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 802,
  "MonStart": "2004-10-11T12:57:43.8082251+02:00",
  "MonStop": "2022-02-26T12:57:43.8082251+01:00",
  "TueStart": "2001-09-02T12:57:43.8082251+02:00",
  "TueStop": "2021-12-25T12:57:43.8082251+01:00",
  "WedStart": "2024-04-24T12:57:43.8082251+02:00",
  "WedStop": "2007-02-17T12:57:43.8082251+01:00",
  "ThuStart": "1999-05-06T12:57:43.8082251+02:00",
  "ThuStop": "2001-04-20T12:57:43.8082251+02:00",
  "FriStart": "2023-01-14T12:57:43.8082251+01:00",
  "FriStop": "1997-05-13T12:57:43.8082251+02:00",
  "SatStart": "2004-04-09T12:57:43.8082251+02:00",
  "SatStop": "2020-08-24T12:57:43.8082251+02:00",
  "SunStart": "2013-07-20T12:57:43.8082251+02:00",
  "SunStop": "1997-07-26T12:57:43.8082251+02:00",
  "NonDates": [
    "et",
    "omnis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 980,
      "AlertLevel": 310,
      "AlertTimeout": 581,
      "Action": 2,
      "DelegateTo": 460,
      "ScriptId": 988,
      "EmailTo": "emmie@durgan.co.uk",
      "SmsTo": "assumenda",
      "ReplyTemplateIdCustomer": 285,
      "ReplyTemplateIdUser": 415,
      "ReplyTemplateIdCatmast": 708,
      "ReplyTemplateIdEmail": 859,
      "RtiCustomerSms": 295,
      "ReplyTemplateIdUserSms": 394,
      "ReplyTemplateIdCatmastSms": 708,
      "ReplyTemplateIdSms": 364
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 162,
  "Name": "Bartoletti, Bogan and Adams",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 451,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 728,
  "MonStart": "2018-08-02T12:57:43.8082251+02:00",
  "MonStop": "2011-05-09T12:57:43.8082251+02:00",
  "TueStart": "2014-01-05T12:57:43.8082251+01:00",
  "TueStop": "2020-07-17T12:57:43.8082251+02:00",
  "WedStart": "2016-11-24T12:57:43.8082251+01:00",
  "WedStop": "2020-09-14T12:57:43.8082251+02:00",
  "ThuStart": "2018-06-01T12:57:43.8082251+02:00",
  "ThuStop": "2020-07-28T12:57:43.8082251+02:00",
  "FriStart": "2013-06-08T12:57:43.8082251+02:00",
  "FriStop": "2024-03-28T12:57:43.8082251+01:00",
  "SatStart": "2015-03-03T12:57:43.8082251+01:00",
  "SatStop": "2009-06-08T12:57:43.8082251+02:00",
  "SunStart": "2011-11-05T12:57:43.8082251+01:00",
  "SunStop": "2023-01-25T12:57:43.8082251+01:00",
  "NonDates": [
    "nihil",
    "voluptatem"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 877,
      "AlertLevel": 671,
      "AlertTimeout": 600,
      "Action": 999,
      "DelegateTo": 68,
      "ScriptId": 457,
      "EmailTo": "bessie@lindgren.biz",
      "SmsTo": "ex",
      "ReplyTemplateIdCustomer": 721,
      "ReplyTemplateIdUser": 516,
      "ReplyTemplateIdCatmast": 249,
      "ReplyTemplateIdEmail": 135,
      "RtiCustomerSms": 174,
      "ReplyTemplateIdUserSms": 259,
      "ReplyTemplateIdCatmastSms": 707,
      "ReplyTemplateIdSms": 173,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 692
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 831
    }
  }
}
```
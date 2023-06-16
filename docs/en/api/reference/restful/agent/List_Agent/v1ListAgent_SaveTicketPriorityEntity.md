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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 828,
  "Name": "Hodkiewicz, Heaney and McClure",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 27,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 789,
  "MonStart": "1996-03-09T16:00:41.2268306+01:00",
  "MonStop": "2018-04-13T16:00:41.2268306+02:00",
  "TueStart": "2002-12-08T16:00:41.2268306+01:00",
  "TueStop": "2016-12-05T16:00:41.2268306+01:00",
  "WedStart": "2023-04-21T16:00:41.2268306+02:00",
  "WedStop": "1996-09-10T16:00:41.2268306+02:00",
  "ThuStart": "1998-03-13T16:00:41.2268306+01:00",
  "ThuStop": "2017-12-31T16:00:41.2268306+01:00",
  "FriStart": "2022-03-25T16:00:41.2268306+01:00",
  "FriStop": "2003-01-16T16:00:41.2268306+01:00",
  "SatStart": "2008-11-08T16:00:41.2268306+01:00",
  "SatStop": "2008-07-29T16:00:41.2268306+02:00",
  "SunStart": "2019-02-17T16:00:41.2268306+01:00",
  "SunStop": "2017-11-09T16:00:41.2268306+01:00",
  "NonDates": [
    "deleniti",
    "optio"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 625,
      "AlertLevel": 44,
      "AlertTimeout": 493,
      "Action": 48,
      "DelegateTo": 950,
      "ScriptId": 844,
      "EmailTo": "jewel.bauch@corwin.us",
      "SmsTo": "dolores",
      "ReplyTemplateIdCustomer": 241,
      "ReplyTemplateIdUser": 606,
      "ReplyTemplateIdCatmast": 272,
      "ReplyTemplateIdEmail": 997,
      "RtiCustomerSms": 18,
      "ReplyTemplateIdUserSms": 831,
      "ReplyTemplateIdCatmastSms": 352,
      "ReplyTemplateIdSms": 219
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 566,
  "Name": "Kub, Rath and Von",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 34,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 992,
  "MonStart": "2016-11-23T16:00:41.2268306+01:00",
  "MonStop": "2020-02-16T16:00:41.2268306+01:00",
  "TueStart": "2007-03-25T16:00:41.2268306+02:00",
  "TueStop": "2019-09-18T16:00:41.2268306+02:00",
  "WedStart": "2008-02-14T16:00:41.2268306+01:00",
  "WedStop": "1996-01-30T16:00:41.2268306+01:00",
  "ThuStart": "1996-05-11T16:00:41.2268306+02:00",
  "ThuStop": "2023-02-06T16:00:41.2268306+01:00",
  "FriStart": "2012-04-22T16:00:41.2268306+02:00",
  "FriStop": "2016-08-31T16:00:41.2268306+02:00",
  "SatStart": "2000-01-30T16:00:41.2268306+01:00",
  "SatStop": "1997-08-24T16:00:41.2268306+02:00",
  "SunStart": "1996-10-04T16:00:41.2268306+02:00",
  "SunStop": "2002-08-15T16:00:41.2268306+02:00",
  "NonDates": [
    "exercitationem",
    "quis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 642,
      "AlertLevel": 111,
      "AlertTimeout": 263,
      "Action": 627,
      "DelegateTo": 760,
      "ScriptId": 218,
      "EmailTo": "napoleon.doyle@hansen.name",
      "SmsTo": "itaque",
      "ReplyTemplateIdCustomer": 714,
      "ReplyTemplateIdUser": 955,
      "ReplyTemplateIdCatmast": 442,
      "ReplyTemplateIdEmail": 66,
      "RtiCustomerSms": 43,
      "ReplyTemplateIdUserSms": 475,
      "ReplyTemplateIdCatmastSms": 589,
      "ReplyTemplateIdSms": 97,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 303
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 432
    }
  }
}
```
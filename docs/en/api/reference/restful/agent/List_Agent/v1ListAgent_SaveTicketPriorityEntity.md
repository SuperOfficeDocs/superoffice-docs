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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 948,
  "Name": "Thiel, Swift and DuBuque",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 610,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 596,
  "MonStart": "2009-02-08T02:38:21.5420262+01:00",
  "MonStop": "2021-12-22T02:38:21.5420262+01:00",
  "TueStart": "2003-11-11T02:38:21.5420262+01:00",
  "TueStop": "2015-11-02T02:38:21.5420262+01:00",
  "WedStart": "2000-05-12T02:38:21.5420262+02:00",
  "WedStop": "1999-04-12T02:38:21.5420262+02:00",
  "ThuStart": "2023-10-14T02:38:21.5420262+02:00",
  "ThuStop": "2000-11-28T02:38:21.5420262+01:00",
  "FriStart": "1997-12-18T02:38:21.5420262+01:00",
  "FriStop": "1999-04-21T02:38:21.5420262+02:00",
  "SatStart": "2013-01-26T02:38:21.5420262+01:00",
  "SatStop": "2014-05-01T02:38:21.5420262+02:00",
  "SunStart": "2017-07-30T02:38:21.5420262+02:00",
  "SunStop": "2008-06-23T02:38:21.5420262+02:00",
  "NonDates": [
    "voluptatem",
    "accusamus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 181,
      "AlertLevel": 680,
      "AlertTimeout": 906,
      "Action": 471,
      "DelegateTo": 396,
      "ScriptId": 580,
      "EmailTo": "bradly@grady.name",
      "SmsTo": "minus",
      "ReplyTemplateIdCustomer": 360,
      "ReplyTemplateIdUser": 31,
      "ReplyTemplateIdCatmast": 485,
      "ReplyTemplateIdEmail": 654,
      "RtiCustomerSms": 972,
      "ReplyTemplateIdUserSms": 502,
      "ReplyTemplateIdCatmastSms": 828,
      "ReplyTemplateIdSms": 164
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 987,
  "Name": "Kunze-Reinger",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 43,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 790,
  "MonStart": "2007-11-18T02:38:21.5420262+01:00",
  "MonStop": "2024-12-07T02:38:21.5420262+01:00",
  "TueStart": "2003-09-28T02:38:21.5420262+02:00",
  "TueStop": "2023-10-28T02:38:21.5420262+02:00",
  "WedStart": "2021-05-09T02:38:21.5420262+02:00",
  "WedStop": "2014-06-01T02:38:21.5420262+02:00",
  "ThuStart": "2018-01-24T02:38:21.5420262+01:00",
  "ThuStop": "2013-10-12T02:38:21.5420262+02:00",
  "FriStart": "2003-03-05T02:38:21.5420262+01:00",
  "FriStop": "1999-12-02T02:38:21.5420262+01:00",
  "SatStart": "2010-04-07T02:38:21.5420262+02:00",
  "SatStop": "2017-09-29T02:38:21.5420262+02:00",
  "SunStart": "2021-01-10T02:38:21.5420262+01:00",
  "SunStop": "2024-01-26T02:38:21.5420262+01:00",
  "NonDates": [
    "aut",
    "ab"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 381,
      "AlertLevel": 464,
      "AlertTimeout": 646,
      "Action": 478,
      "DelegateTo": 604,
      "ScriptId": 507,
      "EmailTo": "terrell_connelly@robelblanda.info",
      "SmsTo": "doloremque",
      "ReplyTemplateIdCustomer": 984,
      "ReplyTemplateIdUser": 60,
      "ReplyTemplateIdCatmast": 465,
      "ReplyTemplateIdEmail": 572,
      "RtiCustomerSms": 488,
      "ReplyTemplateIdUserSms": 207,
      "ReplyTemplateIdCatmastSms": 948,
      "ReplyTemplateIdSms": 802,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 634
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 991
    }
  }
}
```
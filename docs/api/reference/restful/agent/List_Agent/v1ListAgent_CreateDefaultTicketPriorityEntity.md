---
title: POST Agents/List/CreateDefaultTicketPriorityEntity
uid: v1ListAgent_CreateDefaultTicketPriorityEntity
---

# POST Agents/List/CreateDefaultTicketPriorityEntity

```http
POST /api/v1/Agents/List/CreateDefaultTicketPriorityEntity
```

Set default values into a new TicketPriorityEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/CreateDefaultTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 837,
  "Name": "Hilll, Durgan and Bins",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 474,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 3,
  "MonStart": "2018-07-24T11:10:27.2634526+02:00",
  "MonStop": "2019-10-01T11:10:27.2634526+02:00",
  "TueStart": "2020-05-07T11:10:27.2634526+02:00",
  "TueStop": "2005-10-02T11:10:27.2634526+02:00",
  "WedStart": "2012-02-16T11:10:27.2634526+01:00",
  "WedStop": "2015-09-19T11:10:27.2634526+02:00",
  "ThuStart": "2009-02-01T11:10:27.2634526+01:00",
  "ThuStop": "1997-02-27T11:10:27.2634526+01:00",
  "FriStart": "2010-10-09T11:10:27.2634526+02:00",
  "FriStop": "2016-04-22T11:10:27.2634526+02:00",
  "SatStart": "2007-02-25T11:10:27.2634526+01:00",
  "SatStop": "2006-01-25T11:10:27.2634526+01:00",
  "SunStart": "2007-04-04T11:10:27.2634526+02:00",
  "SunStop": "2007-02-21T11:10:27.2634526+01:00",
  "NonDates": [
    "voluptatem",
    "facere"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 299,
      "AlertLevel": 87,
      "AlertTimeout": 273,
      "Action": 646,
      "DelegateTo": 607,
      "ScriptId": 399,
      "EmailTo": "brock_fahey@pourosjohns.co.uk",
      "SmsTo": "esse",
      "ReplyTemplateIdCustomer": 555,
      "ReplyTemplateIdUser": 433,
      "ReplyTemplateIdCatmast": 85,
      "ReplyTemplateIdEmail": 164,
      "RtiCustomerSms": 302,
      "ReplyTemplateIdUserSms": 884,
      "ReplyTemplateIdCatmastSms": 26,
      "ReplyTemplateIdSms": 457,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 50
    }
  }
}
```
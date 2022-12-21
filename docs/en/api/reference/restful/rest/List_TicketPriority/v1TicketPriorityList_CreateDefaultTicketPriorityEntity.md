---
title: GET List/TicketPriority/Items/Default
uid: v1TicketPriorityList_CreateDefaultTicketPriorityEntity
---

# GET List/TicketPriority/Items/Default

```http
GET /api/v1/List/TicketPriority/Items/Default
```

Gets a default TicketPriorityEntity list item.








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
GET /api/v1/List/TicketPriority/Items/Default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 709,
  "Name": "Blick Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 432,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 983,
  "MonStart": "2013-05-02T02:49:52.5784525+02:00",
  "MonStop": "1996-01-11T02:49:52.5784525+01:00",
  "TueStart": "2010-10-26T02:49:52.5784525+02:00",
  "TueStop": "2008-04-22T02:49:52.5784525+02:00",
  "WedStart": "2020-04-01T02:49:52.5784525+02:00",
  "WedStop": "2014-01-30T02:49:52.5784525+01:00",
  "ThuStart": "2008-09-02T02:49:52.5784525+02:00",
  "ThuStop": "1999-06-17T02:49:52.5784525+02:00",
  "FriStart": "1997-05-14T02:49:52.5784525+02:00",
  "FriStop": "2021-02-08T02:49:52.5784525+01:00",
  "SatStart": "2016-08-22T02:49:52.5784525+02:00",
  "SatStop": "2019-01-08T02:49:52.5784525+01:00",
  "SunStart": "2020-09-14T02:49:52.5784525+02:00",
  "SunStop": "2008-06-05T02:49:52.5784525+02:00",
  "NonDates": [
    "ipsum",
    "impedit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 478,
      "AlertLevel": 195,
      "AlertTimeout": 427,
      "Action": 901,
      "DelegateTo": 3,
      "ScriptId": 961,
      "EmailTo": "brenden_weissnat@harberwehner.info",
      "SmsTo": "facilis",
      "ReplyTemplateIdCustomer": 617,
      "ReplyTemplateIdUser": 433,
      "ReplyTemplateIdCatmast": 131,
      "ReplyTemplateIdEmail": 820,
      "RtiCustomerSms": 970,
      "ReplyTemplateIdUserSms": 659,
      "ReplyTemplateIdCatmastSms": 680,
      "ReplyTemplateIdSms": 303,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 646
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 875
    }
  }
}
```
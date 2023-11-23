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
  "TicketPriorityId": 618,
  "Name": "Hahn-Carroll",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 189,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 56,
  "MonStart": "1998-07-12T13:38:13.7177215+02:00",
  "MonStop": "2006-11-19T13:38:13.7177215+01:00",
  "TueStart": "2001-06-05T13:38:13.7177215+02:00",
  "TueStop": "2000-03-07T13:38:13.7177215+01:00",
  "WedStart": "2000-02-24T13:38:13.7177215+01:00",
  "WedStop": "2011-07-09T13:38:13.7177215+02:00",
  "ThuStart": "2010-04-04T13:38:13.7177215+02:00",
  "ThuStop": "2004-10-18T13:38:13.7177215+02:00",
  "FriStart": "1999-08-03T13:38:13.7177215+02:00",
  "FriStop": "2019-06-19T13:38:13.7177215+02:00",
  "SatStart": "2006-06-07T13:38:13.7177215+02:00",
  "SatStop": "2018-08-30T13:38:13.7177215+02:00",
  "SunStart": "2003-01-27T13:38:13.7177215+01:00",
  "SunStop": "2018-11-03T13:38:13.7177215+01:00",
  "NonDates": [
    "quae",
    "ea"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 799,
      "AlertLevel": 743,
      "AlertTimeout": 195,
      "Action": 317,
      "DelegateTo": 953,
      "ScriptId": 854,
      "EmailTo": "jazmyne_koelpin@koepp.co.uk",
      "SmsTo": "sapiente",
      "ReplyTemplateIdCustomer": 334,
      "ReplyTemplateIdUser": 249,
      "ReplyTemplateIdCatmast": 842,
      "ReplyTemplateIdEmail": 35,
      "RtiCustomerSms": 143,
      "ReplyTemplateIdUserSms": 117,
      "ReplyTemplateIdCatmastSms": 478,
      "ReplyTemplateIdSms": 46
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 581,
  "Name": "Ondricka, Homenick and Ebert",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 106,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 246,
  "MonStart": "2009-04-01T13:38:13.7177215+02:00",
  "MonStop": "2013-12-21T13:38:13.7177215+01:00",
  "TueStart": "2011-11-13T13:38:13.7177215+01:00",
  "TueStop": "2017-05-31T13:38:13.7177215+02:00",
  "WedStart": "2014-03-27T13:38:13.7177215+01:00",
  "WedStop": "2005-05-27T13:38:13.7177215+02:00",
  "ThuStart": "2007-02-16T13:38:13.7177215+01:00",
  "ThuStop": "2011-02-05T13:38:13.7177215+01:00",
  "FriStart": "2021-05-28T13:38:13.7177215+02:00",
  "FriStop": "2022-11-30T13:38:13.7177215+01:00",
  "SatStart": "2018-08-19T13:38:13.7177215+02:00",
  "SatStop": "2022-06-21T13:38:13.7177215+02:00",
  "SunStart": "1999-07-25T13:38:13.7177215+02:00",
  "SunStop": "2005-10-04T13:38:13.7177215+02:00",
  "NonDates": [
    "dolores",
    "ut"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 277,
      "AlertLevel": 139,
      "AlertTimeout": 662,
      "Action": 281,
      "DelegateTo": 242,
      "ScriptId": 784,
      "EmailTo": "litzy@gutmann.co.uk",
      "SmsTo": "sint",
      "ReplyTemplateIdCustomer": 182,
      "ReplyTemplateIdUser": 192,
      "ReplyTemplateIdCatmast": 377,
      "ReplyTemplateIdEmail": 894,
      "RtiCustomerSms": 784,
      "ReplyTemplateIdUserSms": 238,
      "ReplyTemplateIdCatmastSms": 300,
      "ReplyTemplateIdSms": 193,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 470
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 61
    }
  }
}
```
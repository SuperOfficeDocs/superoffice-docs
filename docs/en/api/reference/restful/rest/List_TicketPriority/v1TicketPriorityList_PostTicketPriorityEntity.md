---
title: POST List/TicketPriority/Items
uid: v1TicketPriorityList_PostTicketPriorityEntity
generated: true
---

# POST List/TicketPriority/Items

```http
POST /api/v1/List/TicketPriority/Items
```

Create a new TicketPriorityEntity list item


Calls the List agent service SaveTicketPriorityEntity.







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

## Request Body: newEntity 

The TicketPriorityEntity to be created. 

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
POST /api/v1/List/TicketPriority/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 606,
  "Name": "Borer-Larson",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 175,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 528,
  "MonStart": "2021-07-11T14:13:50.3064464+02:00",
  "MonStop": "2000-05-31T14:13:50.3064464+02:00",
  "TueStart": "2002-06-10T14:13:50.3064464+02:00",
  "TueStop": "2021-02-26T14:13:50.3064464+01:00",
  "WedStart": "2022-11-25T14:13:50.3064464+01:00",
  "WedStop": "2012-10-04T14:13:50.3064464+02:00",
  "ThuStart": "2012-02-26T14:13:50.3064464+01:00",
  "ThuStop": "2015-02-20T14:13:50.3064464+01:00",
  "FriStart": "2018-05-30T14:13:50.3064464+02:00",
  "FriStop": "2009-02-21T14:13:50.3064464+01:00",
  "SatStart": "2022-06-21T14:13:50.3064464+02:00",
  "SatStop": "2001-04-18T14:13:50.3064464+02:00",
  "SunStart": "1998-01-17T14:13:50.3064464+01:00",
  "SunStop": "2013-02-09T14:13:50.3064464+01:00",
  "NonDates": [
    "dolores",
    "dolor"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 413,
      "AlertLevel": 121,
      "AlertTimeout": 166,
      "Action": 131,
      "DelegateTo": 441,
      "ScriptId": 588,
      "EmailTo": "joesph@schoenmurazik.info",
      "SmsTo": "illum",
      "ReplyTemplateIdCustomer": 601,
      "ReplyTemplateIdUser": 4,
      "ReplyTemplateIdCatmast": 312,
      "ReplyTemplateIdEmail": 801,
      "RtiCustomerSms": 936,
      "ReplyTemplateIdUserSms": 348,
      "ReplyTemplateIdCatmastSms": 179,
      "ReplyTemplateIdSms": 358
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 477,
  "Name": "Cole, Tromp and Williamson",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 633,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 579,
  "MonStart": "2009-11-04T14:13:50.3064464+01:00",
  "MonStop": "2008-12-15T14:13:50.3064464+01:00",
  "TueStart": "2009-11-23T14:13:50.3064464+01:00",
  "TueStop": "2020-11-03T14:13:50.3064464+01:00",
  "WedStart": "2016-06-05T14:13:50.3064464+02:00",
  "WedStop": "2012-02-04T14:13:50.3064464+01:00",
  "ThuStart": "2019-08-20T14:13:50.3064464+02:00",
  "ThuStop": "2006-06-01T14:13:50.3064464+02:00",
  "FriStart": "2014-02-08T14:13:50.3064464+01:00",
  "FriStop": "2001-11-09T14:13:50.3064464+01:00",
  "SatStart": "2014-03-19T14:13:50.3064464+01:00",
  "SatStop": "2013-09-13T14:13:50.3064464+02:00",
  "SunStart": "2020-07-21T14:13:50.3064464+02:00",
  "SunStop": "2013-05-30T14:13:50.3064464+02:00",
  "NonDates": [
    "repellat",
    "et"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 259,
      "AlertLevel": 649,
      "AlertTimeout": 933,
      "Action": 808,
      "DelegateTo": 706,
      "ScriptId": 373,
      "EmailTo": "brielle@bashirianwitting.co.uk",
      "SmsTo": "et",
      "ReplyTemplateIdCustomer": 94,
      "ReplyTemplateIdUser": 612,
      "ReplyTemplateIdCatmast": 208,
      "ReplyTemplateIdEmail": 980,
      "RtiCustomerSms": 825,
      "ReplyTemplateIdUserSms": 65,
      "ReplyTemplateIdCatmastSms": 310,
      "ReplyTemplateIdSms": 194,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 900
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 566
    }
  }
}
```
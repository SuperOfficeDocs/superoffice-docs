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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 334,
  "Name": "Abbott, Torp and Kertzmann",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 828,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 900,
  "MonStart": "2002-07-09T14:28:27.7426615+02:00",
  "MonStop": "2002-08-16T14:28:27.7426615+02:00",
  "TueStart": "2000-01-14T14:28:27.7426615+01:00",
  "TueStop": "2016-09-16T14:28:27.7426615+02:00",
  "WedStart": "2011-07-02T14:28:27.7426615+02:00",
  "WedStop": "2016-09-19T14:28:27.7426615+02:00",
  "ThuStart": "2015-02-22T14:28:27.7426615+01:00",
  "ThuStop": "2004-09-13T14:28:27.7426615+02:00",
  "FriStart": "2018-10-16T14:28:27.7426615+02:00",
  "FriStop": "2019-04-29T14:28:27.7426615+02:00",
  "SatStart": "2017-12-17T14:28:27.7426615+01:00",
  "SatStop": "2012-02-17T14:28:27.7426615+01:00",
  "SunStart": "2007-07-09T14:28:27.7426615+02:00",
  "SunStop": "2013-04-07T14:28:27.7426615+02:00",
  "NonDates": [
    "perferendis",
    "id"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 348,
      "AlertLevel": 536,
      "AlertTimeout": 45,
      "Action": 192,
      "DelegateTo": 110,
      "ScriptId": 678,
      "EmailTo": "damaris_skiles@treutel.us",
      "SmsTo": "explicabo",
      "ReplyTemplateIdCustomer": 145,
      "ReplyTemplateIdUser": 658,
      "ReplyTemplateIdCatmast": 208,
      "ReplyTemplateIdEmail": 37,
      "RtiCustomerSms": 520,
      "ReplyTemplateIdUserSms": 590,
      "ReplyTemplateIdCatmastSms": 113,
      "ReplyTemplateIdSms": 165
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 735,
  "Name": "Kuvalis LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 69,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 970,
  "MonStart": "2017-01-15T14:28:27.7582989+01:00",
  "MonStop": "2008-11-28T14:28:27.7582989+01:00",
  "TueStart": "2011-12-21T14:28:27.7582989+01:00",
  "TueStop": "1998-11-08T14:28:27.7582989+01:00",
  "WedStart": "2004-12-06T14:28:27.7582989+01:00",
  "WedStop": "2012-07-23T14:28:27.7582989+02:00",
  "ThuStart": "2001-12-28T14:28:27.7582989+01:00",
  "ThuStop": "2004-11-03T14:28:27.7582989+01:00",
  "FriStart": "2006-01-20T14:28:27.7582989+01:00",
  "FriStop": "2004-06-01T14:28:27.7582989+02:00",
  "SatStart": "2010-04-24T14:28:27.7582989+02:00",
  "SatStop": "1999-09-06T14:28:27.7582989+02:00",
  "SunStart": "2003-07-02T14:28:27.7582989+02:00",
  "SunStop": "2002-09-07T14:28:27.7582989+02:00",
  "NonDates": [
    "voluptate",
    "repudiandae"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 714,
      "AlertLevel": 661,
      "AlertTimeout": 42,
      "Action": 840,
      "DelegateTo": 693,
      "ScriptId": 690,
      "EmailTo": "ursula@jacobi.info",
      "SmsTo": "maxime",
      "ReplyTemplateIdCustomer": 729,
      "ReplyTemplateIdUser": 248,
      "ReplyTemplateIdCatmast": 471,
      "ReplyTemplateIdEmail": 70,
      "RtiCustomerSms": 827,
      "ReplyTemplateIdUserSms": 971,
      "ReplyTemplateIdCatmastSms": 737,
      "ReplyTemplateIdSms": 814,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 240
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 362
    }
  }
}
```
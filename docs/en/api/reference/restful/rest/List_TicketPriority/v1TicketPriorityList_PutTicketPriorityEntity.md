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
  "TicketPriorityId": 158,
  "Name": "Wisozk Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 497,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 763,
  "MonStart": "2010-12-24T11:06:43.1159494+01:00",
  "MonStop": "2012-06-05T11:06:43.1159494+02:00",
  "TueStart": "2015-03-18T11:06:43.1159494+01:00",
  "TueStop": "2018-04-01T11:06:43.1159494+02:00",
  "WedStart": "2014-10-17T11:06:43.1159494+02:00",
  "WedStop": "2017-05-30T11:06:43.1159494+02:00",
  "ThuStart": "2010-01-25T11:06:43.1159494+01:00",
  "ThuStop": "2022-10-08T11:06:43.1159494+02:00",
  "FriStart": "2000-10-20T11:06:43.1159494+02:00",
  "FriStop": "1998-09-04T11:06:43.1159494+02:00",
  "SatStart": "2000-01-01T11:06:43.1159494+01:00",
  "SatStop": "2011-06-13T11:06:43.1159494+02:00",
  "SunStart": "2007-01-10T11:06:43.1159494+01:00",
  "SunStop": "2013-11-29T11:06:43.1159494+01:00",
  "NonDates": [
    "vero",
    "iure"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 450,
      "AlertLevel": 684,
      "AlertTimeout": 464,
      "Action": 135,
      "DelegateTo": 809,
      "ScriptId": 695,
      "EmailTo": "luigi_zemlak@nicolas.info",
      "SmsTo": "repudiandae",
      "ReplyTemplateIdCustomer": 962,
      "ReplyTemplateIdUser": 616,
      "ReplyTemplateIdCatmast": 980,
      "ReplyTemplateIdEmail": 557,
      "RtiCustomerSms": 663,
      "ReplyTemplateIdUserSms": 949,
      "ReplyTemplateIdCatmastSms": 483,
      "ReplyTemplateIdSms": 877
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 847,
  "Name": "Muller LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 907,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 453,
  "MonStart": "2015-12-21T11:06:43.1159494+01:00",
  "MonStop": "1997-09-16T11:06:43.1159494+02:00",
  "TueStart": "2023-10-15T11:06:43.1159494+02:00",
  "TueStop": "2005-06-28T11:06:43.1159494+02:00",
  "WedStart": "2003-12-29T11:06:43.1159494+01:00",
  "WedStop": "2016-04-03T11:06:43.1159494+02:00",
  "ThuStart": "2021-09-14T11:06:43.1159494+02:00",
  "ThuStop": "2019-02-19T11:06:43.1159494+01:00",
  "FriStart": "1996-08-05T11:06:43.1159494+02:00",
  "FriStop": "1998-08-26T11:06:43.1159494+02:00",
  "SatStart": "1998-09-06T11:06:43.1159494+02:00",
  "SatStop": "2012-10-20T11:06:43.1159494+02:00",
  "SunStart": "2012-07-20T11:06:43.1159494+02:00",
  "SunStop": "2005-06-05T11:06:43.1159494+02:00",
  "NonDates": [
    "et",
    "voluptas"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 810,
      "AlertLevel": 81,
      "AlertTimeout": 315,
      "Action": 321,
      "DelegateTo": 768,
      "ScriptId": 336,
      "EmailTo": "hipolito@ryan.us",
      "SmsTo": "consequatur",
      "ReplyTemplateIdCustomer": 264,
      "ReplyTemplateIdUser": 252,
      "ReplyTemplateIdCatmast": 223,
      "ReplyTemplateIdEmail": 485,
      "RtiCustomerSms": 261,
      "ReplyTemplateIdUserSms": 391,
      "ReplyTemplateIdCatmastSms": 960,
      "ReplyTemplateIdSms": 1000,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 669
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
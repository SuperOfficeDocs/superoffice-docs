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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 601,
  "Name": "Heaney, Braun and Hudson",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 170,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 200,
  "MonStart": "2022-02-11T04:02:07.447468+01:00",
  "MonStop": "2002-07-01T04:02:07.447468+02:00",
  "TueStart": "2016-04-24T04:02:07.447468+02:00",
  "TueStop": "2010-07-07T04:02:07.447468+02:00",
  "WedStart": "2014-03-10T04:02:07.447468+01:00",
  "WedStop": "2015-08-10T04:02:07.447468+02:00",
  "ThuStart": "2008-01-30T04:02:07.447468+01:00",
  "ThuStop": "2020-10-13T04:02:07.447468+02:00",
  "FriStart": "2007-07-10T04:02:07.447468+02:00",
  "FriStop": "2023-11-30T04:02:07.447468+01:00",
  "SatStart": "2014-10-07T04:02:07.447468+02:00",
  "SatStop": "2022-05-21T04:02:07.447468+02:00",
  "SunStart": "2006-06-08T04:02:07.447468+02:00",
  "SunStop": "2010-10-03T04:02:07.447468+02:00",
  "NonDates": [
    "repudiandae",
    "exercitationem"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 381,
      "AlertLevel": 354,
      "AlertTimeout": 407,
      "Action": 818,
      "DelegateTo": 307,
      "ScriptId": 554,
      "EmailTo": "claudie@schinner.ca",
      "SmsTo": "illum",
      "ReplyTemplateIdCustomer": 735,
      "ReplyTemplateIdUser": 654,
      "ReplyTemplateIdCatmast": 540,
      "ReplyTemplateIdEmail": 2,
      "RtiCustomerSms": 197,
      "ReplyTemplateIdUserSms": 828,
      "ReplyTemplateIdCatmastSms": 327,
      "ReplyTemplateIdSms": 634
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 271,
  "Name": "Ankunding-Rippin",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 567,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 468,
  "MonStart": "2000-11-21T04:02:07.447468+01:00",
  "MonStop": "2008-07-27T04:02:07.447468+02:00",
  "TueStart": "2002-09-09T04:02:07.447468+02:00",
  "TueStop": "2023-11-13T04:02:07.447468+01:00",
  "WedStart": "2016-05-16T04:02:07.447468+02:00",
  "WedStop": "2015-12-22T04:02:07.447468+01:00",
  "ThuStart": "2019-09-02T04:02:07.447468+02:00",
  "ThuStop": "1997-06-23T04:02:07.447468+02:00",
  "FriStart": "2003-07-17T04:02:07.447468+02:00",
  "FriStop": "1997-12-09T04:02:07.447468+01:00",
  "SatStart": "2021-11-26T04:02:07.447468+01:00",
  "SatStop": "2015-02-26T04:02:07.447468+01:00",
  "SunStart": "2021-06-11T04:02:07.447468+02:00",
  "SunStop": "2001-07-21T04:02:07.447468+02:00",
  "NonDates": [
    "iusto",
    "consequatur"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 367,
      "AlertLevel": 632,
      "AlertTimeout": 828,
      "Action": 607,
      "DelegateTo": 564,
      "ScriptId": 914,
      "EmailTo": "maximus.ernser@fahey.com",
      "SmsTo": "temporibus",
      "ReplyTemplateIdCustomer": 271,
      "ReplyTemplateIdUser": 316,
      "ReplyTemplateIdCatmast": 901,
      "ReplyTemplateIdEmail": 724,
      "RtiCustomerSms": 994,
      "ReplyTemplateIdUserSms": 743,
      "ReplyTemplateIdCatmastSms": 188,
      "ReplyTemplateIdSms": 968,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 121
    }
  }
}
```
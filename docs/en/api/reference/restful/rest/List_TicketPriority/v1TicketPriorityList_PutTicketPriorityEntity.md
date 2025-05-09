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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 916,
  "Name": "Berge Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 910,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 303,
  "MonStart": "2022-11-23T16:32:49.0244447+01:00",
  "MonStop": "2000-01-02T16:32:49.0244447+01:00",
  "TueStart": "2008-10-28T16:32:49.0244447+01:00",
  "TueStop": "2004-01-23T16:32:49.0244447+01:00",
  "WedStart": "2000-01-03T16:32:49.0244447+01:00",
  "WedStop": "2011-03-26T16:32:49.0244447+01:00",
  "ThuStart": "2007-09-30T16:32:49.0244447+02:00",
  "ThuStop": "2020-11-15T16:32:49.0244447+01:00",
  "FriStart": "2017-07-10T16:32:49.0244447+02:00",
  "FriStop": "2017-09-05T16:32:49.0244447+02:00",
  "SatStart": "2010-06-20T16:32:49.0244447+02:00",
  "SatStop": "2004-04-15T16:32:49.0244447+02:00",
  "SunStart": "2021-09-14T16:32:49.0244447+02:00",
  "SunStop": "2005-04-01T16:32:49.0244447+02:00",
  "NonDates": [
    "distinctio",
    "veniam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 295,
      "AlertLevel": 148,
      "AlertTimeout": 311,
      "Action": 324,
      "DelegateTo": 705,
      "ScriptId": 964,
      "EmailTo": "mona_von@labadiebradtke.biz",
      "SmsTo": "omnis",
      "ReplyTemplateIdCustomer": 498,
      "ReplyTemplateIdUser": 976,
      "ReplyTemplateIdCatmast": 587,
      "ReplyTemplateIdEmail": 428,
      "RtiCustomerSms": 967,
      "ReplyTemplateIdUserSms": 229,
      "ReplyTemplateIdCatmastSms": 205,
      "ReplyTemplateIdSms": 423
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 634,
  "Name": "Schaden-Walsh",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 750,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 514,
  "MonStart": "2007-01-31T16:32:49.0244447+01:00",
  "MonStop": "1999-01-29T16:32:49.0244447+01:00",
  "TueStart": "2005-05-26T16:32:49.0244447+02:00",
  "TueStop": "2004-02-29T16:32:49.0244447+01:00",
  "WedStart": "1999-09-02T16:32:49.0244447+02:00",
  "WedStop": "2011-01-24T16:32:49.0244447+01:00",
  "ThuStart": "2019-01-30T16:32:49.0244447+01:00",
  "ThuStop": "2015-11-15T16:32:49.0244447+01:00",
  "FriStart": "2016-05-18T16:32:49.0244447+02:00",
  "FriStop": "2006-12-23T16:32:49.0244447+01:00",
  "SatStart": "2019-03-25T16:32:49.0244447+01:00",
  "SatStop": "2006-03-10T16:32:49.0244447+01:00",
  "SunStart": "2010-12-26T16:32:49.0244447+01:00",
  "SunStop": "2022-09-17T16:32:49.0244447+02:00",
  "NonDates": [
    "velit",
    "perspiciatis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 796,
      "AlertLevel": 206,
      "AlertTimeout": 996,
      "Action": 768,
      "DelegateTo": 874,
      "ScriptId": 562,
      "EmailTo": "modesto@treutelzemlak.uk",
      "SmsTo": "dolor",
      "ReplyTemplateIdCustomer": 251,
      "ReplyTemplateIdUser": 896,
      "ReplyTemplateIdCatmast": 184,
      "ReplyTemplateIdEmail": 708,
      "RtiCustomerSms": 265,
      "ReplyTemplateIdUserSms": 88,
      "ReplyTemplateIdCatmastSms": 296,
      "ReplyTemplateIdSms": 974,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 380
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 468
    }
  }
}
```
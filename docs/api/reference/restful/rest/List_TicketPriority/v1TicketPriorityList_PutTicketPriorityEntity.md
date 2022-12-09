---
title: PUT List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_PutTicketPriorityEntity
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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 582,
  "Name": "Sporer-Dicki",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 250,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 983,
  "MonStart": "2003-07-05T02:49:52.5784525+02:00",
  "MonStop": "2001-11-26T02:49:52.5784525+01:00",
  "TueStart": "2014-02-20T02:49:52.5784525+01:00",
  "TueStop": "2016-05-27T02:49:52.5784525+02:00",
  "WedStart": "2019-11-11T02:49:52.5784525+01:00",
  "WedStop": "2002-09-12T02:49:52.5784525+02:00",
  "ThuStart": "2008-05-24T02:49:52.5784525+02:00",
  "ThuStop": "2012-02-14T02:49:52.5784525+01:00",
  "FriStart": "1997-05-16T02:49:52.5784525+02:00",
  "FriStop": "2009-12-11T02:49:52.5784525+01:00",
  "SatStart": "2002-03-14T02:49:52.5784525+01:00",
  "SatStop": "1996-06-20T02:49:52.5784525+02:00",
  "SunStart": "2020-04-27T02:49:52.5784525+02:00",
  "SunStop": "2009-10-30T02:49:52.5784525+01:00",
  "NonDates": [
    "ut",
    "necessitatibus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 445,
      "AlertLevel": 807,
      "AlertTimeout": 48,
      "Action": 666,
      "DelegateTo": 435,
      "ScriptId": 8,
      "EmailTo": "shea@corkery.biz",
      "SmsTo": "enim",
      "ReplyTemplateIdCustomer": 572,
      "ReplyTemplateIdUser": 640,
      "ReplyTemplateIdCatmast": 579,
      "ReplyTemplateIdEmail": 329,
      "RtiCustomerSms": 471,
      "ReplyTemplateIdUserSms": 58,
      "ReplyTemplateIdCatmastSms": 65,
      "ReplyTemplateIdSms": 310
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 107,
  "Name": "Brakus, Ernser and Wisozk",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 467,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 474,
  "MonStart": "1999-08-13T02:49:52.5784525+02:00",
  "MonStop": "2006-10-31T02:49:52.5784525+01:00",
  "TueStart": "1997-12-23T02:49:52.5784525+01:00",
  "TueStop": "2004-08-04T02:49:52.5784525+02:00",
  "WedStart": "1995-10-24T02:49:52.5784525+02:00",
  "WedStop": "2001-11-17T02:49:52.5784525+01:00",
  "ThuStart": "2012-01-10T02:49:52.5784525+01:00",
  "ThuStop": "2015-11-11T02:49:52.5784525+01:00",
  "FriStart": "2013-04-12T02:49:52.5784525+02:00",
  "FriStop": "2018-05-15T02:49:52.5784525+02:00",
  "SatStart": "1996-10-27T02:49:52.5784525+01:00",
  "SatStop": "1999-10-16T02:49:52.5784525+02:00",
  "SunStart": "2005-09-10T02:49:52.5784525+02:00",
  "SunStop": "2010-11-13T02:49:52.5784525+01:00",
  "NonDates": [
    "in",
    "illo"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 46,
      "AlertLevel": 937,
      "AlertTimeout": 493,
      "Action": 903,
      "DelegateTo": 282,
      "ScriptId": 908,
      "EmailTo": "ruthe.turcotte@harber.uk",
      "SmsTo": "voluptatem",
      "ReplyTemplateIdCustomer": 315,
      "ReplyTemplateIdUser": 988,
      "ReplyTemplateIdCatmast": 525,
      "ReplyTemplateIdEmail": 640,
      "RtiCustomerSms": 6,
      "ReplyTemplateIdUserSms": 347,
      "ReplyTemplateIdCatmastSms": 887,
      "ReplyTemplateIdSms": 225,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 833
    }
  }
}
```
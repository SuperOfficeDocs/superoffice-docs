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
  "TicketPriorityId": 657,
  "Name": "O'Conner Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 738,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 919,
  "MonStart": "2013-03-06T11:10:54.6859295+01:00",
  "MonStop": "1995-06-27T11:10:54.6859295+02:00",
  "TueStart": "2014-01-28T11:10:54.6859295+01:00",
  "TueStop": "1995-11-18T11:10:54.6859295+01:00",
  "WedStart": "2018-10-22T11:10:54.6859295+02:00",
  "WedStop": "2002-04-06T11:10:54.6859295+02:00",
  "ThuStart": "2021-08-10T11:10:54.6859295+02:00",
  "ThuStop": "2013-06-04T11:10:54.6859295+02:00",
  "FriStart": "2004-03-29T11:10:54.6859295+02:00",
  "FriStop": "2008-12-24T11:10:54.6859295+01:00",
  "SatStart": "2004-06-13T11:10:54.6859295+02:00",
  "SatStop": "2013-08-12T11:10:54.6859295+02:00",
  "SunStart": "1998-07-04T11:10:54.6859295+02:00",
  "SunStop": "2018-03-08T11:10:54.6859295+01:00",
  "NonDates": [
    "et",
    "alias"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 269,
      "AlertLevel": 848,
      "AlertTimeout": 101,
      "Action": 233,
      "DelegateTo": 210,
      "ScriptId": 259,
      "EmailTo": "major.okon@kleinmann.us",
      "SmsTo": "aut",
      "ReplyTemplateIdCustomer": 102,
      "ReplyTemplateIdUser": 932,
      "ReplyTemplateIdCatmast": 972,
      "ReplyTemplateIdEmail": 449,
      "RtiCustomerSms": 417,
      "ReplyTemplateIdUserSms": 57,
      "ReplyTemplateIdCatmastSms": 651,
      "ReplyTemplateIdSms": 341
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 824,
  "Name": "Christiansen Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 120,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 689,
  "MonStart": "1999-08-06T11:10:54.6869296+02:00",
  "MonStop": "2003-07-06T11:10:54.6869296+02:00",
  "TueStart": "2000-03-23T11:10:54.6869296+01:00",
  "TueStop": "2021-10-11T11:10:54.6869296+02:00",
  "WedStart": "2002-12-11T11:10:54.6869296+01:00",
  "WedStop": "2008-10-26T11:10:54.6869296+01:00",
  "ThuStart": "2019-10-03T11:10:54.6869296+02:00",
  "ThuStop": "2021-04-11T11:10:54.6869296+02:00",
  "FriStart": "2011-01-25T11:10:54.6869296+01:00",
  "FriStop": "1997-11-26T11:10:54.6869296+01:00",
  "SatStart": "2006-08-03T11:10:54.6869296+02:00",
  "SatStop": "2005-04-09T11:10:54.6869296+02:00",
  "SunStart": "2021-09-23T11:10:54.6869296+02:00",
  "SunStop": "1997-06-03T11:10:54.6869296+02:00",
  "NonDates": [
    "voluptatum",
    "commodi"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 193,
      "AlertLevel": 160,
      "AlertTimeout": 844,
      "Action": 23,
      "DelegateTo": 411,
      "ScriptId": 16,
      "EmailTo": "mylene@stoltenberg.name",
      "SmsTo": "optio",
      "ReplyTemplateIdCustomer": 469,
      "ReplyTemplateIdUser": 62,
      "ReplyTemplateIdCatmast": 696,
      "ReplyTemplateIdEmail": 85,
      "RtiCustomerSms": 339,
      "ReplyTemplateIdUserSms": 253,
      "ReplyTemplateIdCatmastSms": 199,
      "ReplyTemplateIdSms": 481,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 382
    }
  }
}
```
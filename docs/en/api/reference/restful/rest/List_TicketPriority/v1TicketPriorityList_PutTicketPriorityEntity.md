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
  "TicketPriorityId": 734,
  "Name": "Dach Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 190,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 186,
  "MonStart": "2001-01-31T13:38:18.2650127+01:00",
  "MonStop": "2015-12-12T13:38:18.2650127+01:00",
  "TueStart": "2014-06-15T13:38:18.2650127+02:00",
  "TueStop": "2020-01-22T13:38:18.2650127+01:00",
  "WedStart": "2015-04-12T13:38:18.2650127+02:00",
  "WedStop": "2021-02-15T13:38:18.2650127+01:00",
  "ThuStart": "2023-05-03T13:38:18.2650127+02:00",
  "ThuStop": "2010-07-26T13:38:18.2650127+02:00",
  "FriStart": "2002-02-22T13:38:18.2650127+01:00",
  "FriStop": "2008-07-19T13:38:18.2650127+02:00",
  "SatStart": "2010-01-11T13:38:18.2650127+01:00",
  "SatStop": "2017-12-29T13:38:18.2650127+01:00",
  "SunStart": "1996-07-20T13:38:18.2650127+02:00",
  "SunStop": "2006-10-30T13:38:18.2650127+01:00",
  "NonDates": [
    "pariatur",
    "id"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 711,
      "AlertLevel": 961,
      "AlertTimeout": 48,
      "Action": 348,
      "DelegateTo": 9,
      "ScriptId": 888,
      "EmailTo": "jennyfer_schamberger@eichmannterry.us",
      "SmsTo": "cumque",
      "ReplyTemplateIdCustomer": 656,
      "ReplyTemplateIdUser": 624,
      "ReplyTemplateIdCatmast": 556,
      "ReplyTemplateIdEmail": 494,
      "RtiCustomerSms": 726,
      "ReplyTemplateIdUserSms": 854,
      "ReplyTemplateIdCatmastSms": 50,
      "ReplyTemplateIdSms": 631
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 493,
  "Name": "Dach, Conn and Crona",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 930,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 714,
  "MonStart": "1999-10-21T13:38:18.2650127+02:00",
  "MonStop": "2003-09-17T13:38:18.2650127+02:00",
  "TueStart": "2020-09-22T13:38:18.2650127+02:00",
  "TueStop": "2017-11-16T13:38:18.2650127+01:00",
  "WedStart": "2009-03-20T13:38:18.2650127+01:00",
  "WedStop": "2004-06-28T13:38:18.2650127+02:00",
  "ThuStart": "2003-08-17T13:38:18.2650127+02:00",
  "ThuStop": "2000-04-14T13:38:18.2650127+02:00",
  "FriStart": "2004-07-01T13:38:18.2650127+02:00",
  "FriStop": "1997-05-10T13:38:18.2650127+02:00",
  "SatStart": "1998-11-29T13:38:18.2650127+01:00",
  "SatStop": "2022-02-21T13:38:18.2650127+01:00",
  "SunStart": "2018-09-03T13:38:18.2650127+02:00",
  "SunStop": "2023-06-20T13:38:18.2650127+02:00",
  "NonDates": [
    "ut",
    "et"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 820,
      "AlertLevel": 59,
      "AlertTimeout": 885,
      "Action": 127,
      "DelegateTo": 652,
      "ScriptId": 464,
      "EmailTo": "herminio_dickens@schuppelittel.biz",
      "SmsTo": "nihil",
      "ReplyTemplateIdCustomer": 894,
      "ReplyTemplateIdUser": 906,
      "ReplyTemplateIdCatmast": 942,
      "ReplyTemplateIdEmail": 397,
      "RtiCustomerSms": 422,
      "ReplyTemplateIdUserSms": 984,
      "ReplyTemplateIdCatmastSms": 62,
      "ReplyTemplateIdSms": 21,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 104
    }
  }
}
```
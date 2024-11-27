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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 175,
  "Name": "Mertz-Hansen",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 226,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 770,
  "MonStart": "2020-06-21T14:45:14.0836771+02:00",
  "MonStop": "2022-01-28T14:45:14.0836771+01:00",
  "TueStart": "2020-04-10T14:45:14.0836771+02:00",
  "TueStop": "2016-10-28T14:45:14.0836771+02:00",
  "WedStart": "2020-08-21T14:45:14.0836771+02:00",
  "WedStop": "2011-10-02T14:45:14.0836771+02:00",
  "ThuStart": "2004-05-01T14:45:14.0836771+02:00",
  "ThuStop": "2010-03-06T14:45:14.0836771+01:00",
  "FriStart": "2006-12-21T14:45:14.0836771+01:00",
  "FriStop": "2015-03-13T14:45:14.0836771+01:00",
  "SatStart": "2010-06-08T14:45:14.0836771+02:00",
  "SatStop": "2008-09-19T14:45:14.0836771+02:00",
  "SunStart": "2022-04-16T14:45:14.0836771+02:00",
  "SunStop": "2017-04-23T14:45:14.0836771+02:00",
  "NonDates": [
    "sint",
    "quod"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 208,
      "AlertLevel": 11,
      "AlertTimeout": 879,
      "Action": 780,
      "DelegateTo": 742,
      "ScriptId": 228,
      "EmailTo": "caleigh.fisher@pollich.uk",
      "SmsTo": "accusamus",
      "ReplyTemplateIdCustomer": 621,
      "ReplyTemplateIdUser": 107,
      "ReplyTemplateIdCatmast": 388,
      "ReplyTemplateIdEmail": 540,
      "RtiCustomerSms": 321,
      "ReplyTemplateIdUserSms": 85,
      "ReplyTemplateIdCatmastSms": 924,
      "ReplyTemplateIdSms": 922
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 600,
  "Name": "Gulgowski, Ward and Pagac",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 397,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 670,
  "MonStart": "2000-02-29T14:45:14.0836771+01:00",
  "MonStop": "2003-05-28T14:45:14.0836771+02:00",
  "TueStart": "2018-08-10T14:45:14.0836771+02:00",
  "TueStop": "2023-07-13T14:45:14.0836771+02:00",
  "WedStart": "2019-10-19T14:45:14.0836771+02:00",
  "WedStop": "2012-12-01T14:45:14.0836771+01:00",
  "ThuStart": "2021-10-24T14:45:14.0836771+02:00",
  "ThuStop": "1998-07-09T14:45:14.0836771+02:00",
  "FriStart": "2020-07-21T14:45:14.0836771+02:00",
  "FriStop": "2017-04-16T14:45:14.0836771+02:00",
  "SatStart": "2011-04-16T14:45:14.0836771+02:00",
  "SatStop": "2017-01-15T14:45:14.0836771+01:00",
  "SunStart": "2023-10-10T14:45:14.0836771+02:00",
  "SunStop": "2006-02-22T14:45:14.0836771+01:00",
  "NonDates": [
    "laboriosam",
    "quidem"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 62,
      "AlertLevel": 270,
      "AlertTimeout": 712,
      "Action": 83,
      "DelegateTo": 738,
      "ScriptId": 300,
      "EmailTo": "hope@rodriguez.co.uk",
      "SmsTo": "tenetur",
      "ReplyTemplateIdCustomer": 681,
      "ReplyTemplateIdUser": 597,
      "ReplyTemplateIdCatmast": 222,
      "ReplyTemplateIdEmail": 466,
      "RtiCustomerSms": 999,
      "ReplyTemplateIdUserSms": 261,
      "ReplyTemplateIdCatmastSms": 445,
      "ReplyTemplateIdSms": 391,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 300
    }
  }
}
```
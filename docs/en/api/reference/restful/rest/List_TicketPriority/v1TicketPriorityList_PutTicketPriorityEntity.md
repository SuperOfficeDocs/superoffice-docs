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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 704,
  "Name": "Wilkinson-Lakin",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 984,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 833,
  "MonStart": "2009-10-06T17:37:40.4185007+02:00",
  "MonStop": "2006-11-14T17:37:40.4185007+01:00",
  "TueStart": "2014-05-13T17:37:40.4185007+02:00",
  "TueStop": "2018-08-25T17:37:40.4185007+02:00",
  "WedStart": "2021-07-16T17:37:40.4185007+02:00",
  "WedStop": "2013-08-30T17:37:40.4185007+02:00",
  "ThuStart": "2019-02-18T17:37:40.4185007+01:00",
  "ThuStop": "2013-10-17T17:37:40.4185007+02:00",
  "FriStart": "2001-11-09T17:37:40.4185007+01:00",
  "FriStop": "2008-12-17T17:37:40.4185007+01:00",
  "SatStart": "2010-07-09T17:37:40.4185007+02:00",
  "SatStop": "2014-07-18T17:37:40.4185007+02:00",
  "SunStart": "1998-06-14T17:37:40.4185007+02:00",
  "SunStop": "2006-07-29T17:37:40.4185007+02:00",
  "NonDates": [
    "sequi",
    "nobis"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 303,
      "AlertLevel": 796,
      "AlertTimeout": 960,
      "Action": 360,
      "DelegateTo": 722,
      "ScriptId": 907,
      "EmailTo": "adrienne@hyattnitzsche.co.uk",
      "SmsTo": "non",
      "ReplyTemplateIdCustomer": 802,
      "ReplyTemplateIdUser": 502,
      "ReplyTemplateIdCatmast": 351,
      "ReplyTemplateIdEmail": 443,
      "RtiCustomerSms": 431,
      "ReplyTemplateIdUserSms": 168,
      "ReplyTemplateIdCatmastSms": 524,
      "ReplyTemplateIdSms": 663
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
  "Name": "Nitzsche, Crist and Legros",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 183,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 823,
  "MonStart": "2011-03-17T17:37:40.4215007+01:00",
  "MonStop": "2014-09-19T17:37:40.4215007+02:00",
  "TueStart": "2007-10-20T17:37:40.4215007+02:00",
  "TueStop": "2002-05-29T17:37:40.4215007+02:00",
  "WedStart": "2010-05-17T17:37:40.4215007+02:00",
  "WedStop": "2010-01-13T17:37:40.4215007+01:00",
  "ThuStart": "2016-05-06T17:37:40.4215007+02:00",
  "ThuStop": "2017-02-15T17:37:40.4215007+01:00",
  "FriStart": "2019-01-19T17:37:40.4215007+01:00",
  "FriStop": "1998-12-16T17:37:40.4215007+01:00",
  "SatStart": "2011-05-13T17:37:40.4215007+02:00",
  "SatStop": "2023-01-06T17:37:40.4215007+01:00",
  "SunStart": "2016-05-04T17:37:40.4215007+02:00",
  "SunStop": "2006-08-15T17:37:40.4215007+02:00",
  "NonDates": [
    "consequuntur",
    "voluptas"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 608,
      "AlertLevel": 94,
      "AlertTimeout": 433,
      "Action": 780,
      "DelegateTo": 929,
      "ScriptId": 244,
      "EmailTo": "orpha_crooks@lefflercassin.ca",
      "SmsTo": "veniam",
      "ReplyTemplateIdCustomer": 281,
      "ReplyTemplateIdUser": 334,
      "ReplyTemplateIdCatmast": 451,
      "ReplyTemplateIdEmail": 261,
      "RtiCustomerSms": 955,
      "ReplyTemplateIdUserSms": 573,
      "ReplyTemplateIdCatmastSms": 997,
      "ReplyTemplateIdSms": 479,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 774
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 600
    }
  }
}
```
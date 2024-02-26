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
  "TicketPriorityId": 643,
  "Name": "Homenick-Reichert",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 116,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 802,
  "MonStart": "1997-07-11T10:30:33.2897031+02:00",
  "MonStop": "2001-04-12T10:30:33.2897031+02:00",
  "TueStart": "2004-06-13T10:30:33.2897031+02:00",
  "TueStop": "2016-05-07T10:30:33.2897031+02:00",
  "WedStart": "2012-03-04T10:30:33.2897031+01:00",
  "WedStop": "2020-04-18T10:30:33.2897031+02:00",
  "ThuStart": "2017-11-05T10:30:33.2897031+01:00",
  "ThuStop": "2000-05-11T10:30:33.2897031+02:00",
  "FriStart": "2019-01-05T10:30:33.2897031+01:00",
  "FriStop": "1998-02-03T10:30:33.2897031+01:00",
  "SatStart": "2012-02-07T10:30:33.2897031+01:00",
  "SatStop": "1997-11-11T10:30:33.2897031+01:00",
  "SunStart": "2018-04-17T10:30:33.2897031+02:00",
  "SunStop": "2014-07-04T10:30:33.2897031+02:00",
  "NonDates": [
    "tempora",
    "enim"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 978,
      "AlertLevel": 748,
      "AlertTimeout": 625,
      "Action": 637,
      "DelegateTo": 497,
      "ScriptId": 940,
      "EmailTo": "alvah@rempel.uk",
      "SmsTo": "delectus",
      "ReplyTemplateIdCustomer": 448,
      "ReplyTemplateIdUser": 434,
      "ReplyTemplateIdCatmast": 990,
      "ReplyTemplateIdEmail": 182,
      "RtiCustomerSms": 424,
      "ReplyTemplateIdUserSms": 505,
      "ReplyTemplateIdCatmastSms": 498,
      "ReplyTemplateIdSms": 489
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 967,
  "Name": "Botsford-Cummings",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 749,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 327,
  "MonStart": "1999-04-14T10:30:33.3053746+02:00",
  "MonStop": "2020-06-10T10:30:33.3053746+02:00",
  "TueStart": "1997-12-06T10:30:33.3053746+01:00",
  "TueStop": "2006-09-27T10:30:33.3053746+02:00",
  "WedStart": "2023-08-11T10:30:33.3053746+02:00",
  "WedStop": "1998-04-03T10:30:33.3053746+02:00",
  "ThuStart": "2013-02-14T10:30:33.3053746+01:00",
  "ThuStop": "2016-12-10T10:30:33.3053746+01:00",
  "FriStart": "2001-01-23T10:30:33.3053746+01:00",
  "FriStop": "2016-09-13T10:30:33.3053746+02:00",
  "SatStart": "2001-10-26T10:30:33.3053746+02:00",
  "SatStop": "2009-09-08T10:30:33.3053746+02:00",
  "SunStart": "2014-08-03T10:30:33.3053746+02:00",
  "SunStop": "2015-11-05T10:30:33.3053746+01:00",
  "NonDates": [
    "voluptas",
    "magnam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 626,
      "AlertLevel": 438,
      "AlertTimeout": 951,
      "Action": 285,
      "DelegateTo": 930,
      "ScriptId": 437,
      "EmailTo": "chet@heathcote.com",
      "SmsTo": "delectus",
      "ReplyTemplateIdCustomer": 406,
      "ReplyTemplateIdUser": 988,
      "ReplyTemplateIdCatmast": 801,
      "ReplyTemplateIdEmail": 660,
      "RtiCustomerSms": 37,
      "ReplyTemplateIdUserSms": 117,
      "ReplyTemplateIdCatmastSms": 957,
      "ReplyTemplateIdSms": 157,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 169
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 886
    }
  }
}
```
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 825,
  "Name": "Bosco, Carroll and McKenzie",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 492,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 308,
  "MonStart": "2005-12-11T11:22:46.2409792+01:00",
  "MonStop": "2016-05-04T11:22:46.2409792+02:00",
  "TueStart": "2009-11-23T11:22:46.2409792+01:00",
  "TueStop": "2016-08-29T11:22:46.2409792+02:00",
  "WedStart": "2012-11-30T11:22:46.2409792+01:00",
  "WedStop": "2022-02-12T11:22:46.2409792+01:00",
  "ThuStart": "2011-07-06T11:22:46.2409792+02:00",
  "ThuStop": "2011-01-01T11:22:46.2409792+01:00",
  "FriStart": "2019-04-15T11:22:46.2409792+02:00",
  "FriStop": "2008-05-12T11:22:46.2409792+02:00",
  "SatStart": "2017-10-02T11:22:46.2409792+02:00",
  "SatStop": "2019-11-30T11:22:46.2409792+01:00",
  "SunStart": "2003-07-03T11:22:46.2409792+02:00",
  "SunStop": "2005-09-30T11:22:46.2409792+02:00",
  "NonDates": [
    "sit",
    "voluptatibus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 53,
      "AlertLevel": 222,
      "AlertTimeout": 190,
      "Action": 60,
      "DelegateTo": 134,
      "ScriptId": 343,
      "EmailTo": "freddy.herzog@hills.co.uk",
      "SmsTo": "rem",
      "ReplyTemplateIdCustomer": 949,
      "ReplyTemplateIdUser": 666,
      "ReplyTemplateIdCatmast": 19,
      "ReplyTemplateIdEmail": 491,
      "RtiCustomerSms": 122,
      "ReplyTemplateIdUserSms": 809,
      "ReplyTemplateIdCatmastSms": 467,
      "ReplyTemplateIdSms": 147
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 643,
  "Name": "Pollich, Fadel and Bechtelar",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 661,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 643,
  "MonStart": "2010-06-04T11:22:46.2409792+02:00",
  "MonStop": "1999-12-25T11:22:46.2409792+01:00",
  "TueStart": "2021-05-21T11:22:46.2409792+02:00",
  "TueStop": "1996-12-27T11:22:46.2409792+01:00",
  "WedStart": "2006-02-05T11:22:46.2409792+01:00",
  "WedStop": "1995-10-10T11:22:46.2409792+02:00",
  "ThuStart": "2016-04-11T11:22:46.2409792+02:00",
  "ThuStop": "2009-09-18T11:22:46.2409792+02:00",
  "FriStart": "2012-03-26T11:22:46.2409792+02:00",
  "FriStop": "2011-01-30T11:22:46.2409792+01:00",
  "SatStart": "1997-09-29T11:22:46.2409792+02:00",
  "SatStop": "1996-02-29T11:22:46.2409792+01:00",
  "SunStart": "1999-02-27T11:22:46.2409792+01:00",
  "SunStop": "1995-11-21T11:22:46.2409792+01:00",
  "NonDates": [
    "modi",
    "qui"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 67,
      "AlertLevel": 544,
      "AlertTimeout": 12,
      "Action": 378,
      "DelegateTo": 735,
      "ScriptId": 339,
      "EmailTo": "drew_crona@emmerich.co.uk",
      "SmsTo": "ullam",
      "ReplyTemplateIdCustomer": 883,
      "ReplyTemplateIdUser": 419,
      "ReplyTemplateIdCatmast": 831,
      "ReplyTemplateIdEmail": 894,
      "RtiCustomerSms": 916,
      "ReplyTemplateIdUserSms": 600,
      "ReplyTemplateIdCatmastSms": 865,
      "ReplyTemplateIdSms": 126,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 293
    }
  }
}
```
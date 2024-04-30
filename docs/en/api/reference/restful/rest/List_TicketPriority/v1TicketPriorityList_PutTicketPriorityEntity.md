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
  "TicketPriorityId": 959,
  "Name": "Beer Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 432,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 837,
  "MonStart": "2003-08-01T11:44:43.398025+02:00",
  "MonStop": "2013-05-25T11:44:43.398025+02:00",
  "TueStart": "2014-04-13T11:44:43.398025+02:00",
  "TueStop": "2012-11-15T11:44:43.398025+01:00",
  "WedStart": "1997-04-23T11:44:43.398025+02:00",
  "WedStop": "2006-01-14T11:44:43.398025+01:00",
  "ThuStart": "2021-02-16T11:44:43.398025+01:00",
  "ThuStop": "1998-03-05T11:44:43.398025+01:00",
  "FriStart": "2016-09-08T11:44:43.398025+02:00",
  "FriStop": "2020-10-11T11:44:43.398025+02:00",
  "SatStart": "2007-06-16T11:44:43.398025+02:00",
  "SatStop": "2016-07-11T11:44:43.398025+02:00",
  "SunStart": "2020-11-17T11:44:43.398025+01:00",
  "SunStop": "2012-12-17T11:44:43.398025+01:00",
  "NonDates": [
    "aut",
    "amet"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 504,
      "AlertLevel": 58,
      "AlertTimeout": 135,
      "Action": 757,
      "DelegateTo": 2,
      "ScriptId": 333,
      "EmailTo": "melba@baumbach.uk",
      "SmsTo": "et",
      "ReplyTemplateIdCustomer": 161,
      "ReplyTemplateIdUser": 575,
      "ReplyTemplateIdCatmast": 280,
      "ReplyTemplateIdEmail": 470,
      "RtiCustomerSms": 22,
      "ReplyTemplateIdUserSms": 57,
      "ReplyTemplateIdCatmastSms": 164,
      "ReplyTemplateIdSms": 673
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 887,
  "Name": "Bode Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 115,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 674,
  "MonStart": "2024-01-19T11:44:43.398025+01:00",
  "MonStop": "2020-03-19T11:44:43.398025+01:00",
  "TueStart": "1998-02-18T11:44:43.398025+01:00",
  "TueStop": "2013-07-28T11:44:43.398025+02:00",
  "WedStart": "2004-03-06T11:44:43.398025+01:00",
  "WedStop": "2015-05-01T11:44:43.398025+02:00",
  "ThuStart": "2017-12-01T11:44:43.398025+01:00",
  "ThuStop": "2014-07-11T11:44:43.398025+02:00",
  "FriStart": "1999-06-24T11:44:43.398025+02:00",
  "FriStop": "2022-08-02T11:44:43.398025+02:00",
  "SatStart": "2022-06-27T11:44:43.398025+02:00",
  "SatStop": "2017-04-12T11:44:43.398025+02:00",
  "SunStart": "2001-07-27T11:44:43.398025+02:00",
  "SunStop": "2015-12-13T11:44:43.398025+01:00",
  "NonDates": [
    "debitis",
    "nemo"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 412,
      "AlertLevel": 598,
      "AlertTimeout": 619,
      "Action": 227,
      "DelegateTo": 362,
      "ScriptId": 732,
      "EmailTo": "carson@marksfeest.us",
      "SmsTo": "iste",
      "ReplyTemplateIdCustomer": 679,
      "ReplyTemplateIdUser": 992,
      "ReplyTemplateIdCatmast": 855,
      "ReplyTemplateIdEmail": 738,
      "RtiCustomerSms": 503,
      "ReplyTemplateIdUserSms": 848,
      "ReplyTemplateIdCatmastSms": 157,
      "ReplyTemplateIdSms": 937,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 357
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 805
    }
  }
}
```
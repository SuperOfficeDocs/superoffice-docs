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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 401,
  "Name": "Roberts, Anderson and Kilback",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 195,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 890,
  "MonStart": "2014-05-07T15:29:31.6694734+02:00",
  "MonStop": "2006-01-21T15:29:31.6694734+01:00",
  "TueStart": "2002-04-01T15:29:31.6694734+02:00",
  "TueStop": "2002-06-20T15:29:31.6694734+02:00",
  "WedStart": "2005-12-29T15:29:31.6694734+01:00",
  "WedStop": "2013-08-06T15:29:31.6694734+02:00",
  "ThuStart": "2004-08-24T15:29:31.6694734+02:00",
  "ThuStop": "2018-10-14T15:29:31.6694734+02:00",
  "FriStart": "2000-08-03T15:29:31.6694734+02:00",
  "FriStop": "2011-05-18T15:29:31.6694734+02:00",
  "SatStart": "1996-04-02T15:29:31.6694734+02:00",
  "SatStop": "2006-09-19T15:29:31.6694734+02:00",
  "SunStart": "2006-05-16T15:29:31.6694734+02:00",
  "SunStop": "2015-01-12T15:29:31.6694734+01:00",
  "NonDates": [
    "esse",
    "optio"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 532,
      "AlertLevel": 628,
      "AlertTimeout": 14,
      "Action": 43,
      "DelegateTo": 911,
      "ScriptId": 626,
      "EmailTo": "kayleigh@little.us",
      "SmsTo": "quaerat",
      "ReplyTemplateIdCustomer": 145,
      "ReplyTemplateIdUser": 635,
      "ReplyTemplateIdCatmast": 775,
      "ReplyTemplateIdEmail": 41,
      "RtiCustomerSms": 434,
      "ReplyTemplateIdUserSms": 422,
      "ReplyTemplateIdCatmastSms": 549,
      "ReplyTemplateIdSms": 218
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 446,
  "Name": "Ledner LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 405,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 219,
  "MonStart": "2015-02-10T15:29:31.6704724+01:00",
  "MonStop": "2011-09-06T15:29:31.6704724+02:00",
  "TueStart": "2015-02-20T15:29:31.6704724+01:00",
  "TueStop": "2006-11-22T15:29:31.6704724+01:00",
  "WedStart": "2021-01-03T15:29:31.6704724+01:00",
  "WedStop": "2008-07-13T15:29:31.6704724+02:00",
  "ThuStart": "2017-10-23T15:29:31.6704724+02:00",
  "ThuStop": "2003-01-09T15:29:31.6704724+01:00",
  "FriStart": "2021-03-07T15:29:31.6704724+01:00",
  "FriStop": "2009-04-04T15:29:31.6704724+02:00",
  "SatStart": "2017-05-03T15:29:31.6704724+02:00",
  "SatStop": "2010-10-14T15:29:31.6704724+02:00",
  "SunStart": "2014-06-11T15:29:31.6704724+02:00",
  "SunStop": "2008-11-22T15:29:31.6704724+01:00",
  "NonDates": [
    "facere",
    "sint"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 668,
      "AlertLevel": 858,
      "AlertTimeout": 313,
      "Action": 245,
      "DelegateTo": 995,
      "ScriptId": 840,
      "EmailTo": "amani@smithamcummerata.com",
      "SmsTo": "nihil",
      "ReplyTemplateIdCustomer": 836,
      "ReplyTemplateIdUser": 613,
      "ReplyTemplateIdCatmast": 656,
      "ReplyTemplateIdEmail": 801,
      "RtiCustomerSms": 546,
      "ReplyTemplateIdUserSms": 290,
      "ReplyTemplateIdCatmastSms": 560,
      "ReplyTemplateIdSms": 453,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 689
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 164
    }
  }
}
```
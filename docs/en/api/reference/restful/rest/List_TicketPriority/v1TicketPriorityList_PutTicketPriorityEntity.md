---
title: PUT List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_PutTicketPriorityEntity
generated: true
content_type: reference
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
  "TicketPriorityId": 925,
  "Name": "Johnston Inc and Sons",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 190,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 337,
  "MonStart": "2002-08-24T03:47:00.9099142+02:00",
  "MonStop": "2004-10-29T03:47:00.9099142+02:00",
  "TueStart": "2011-06-29T03:47:00.9099142+02:00",
  "TueStop": "2008-08-09T03:47:00.9099142+02:00",
  "WedStart": "2019-05-27T03:47:00.9099142+02:00",
  "WedStop": "2022-09-26T03:47:00.9099142+02:00",
  "ThuStart": "2019-05-09T03:47:00.9099142+02:00",
  "ThuStop": "1999-01-24T03:47:00.9099142+01:00",
  "FriStart": "2009-03-24T03:47:00.9099142+01:00",
  "FriStop": "2007-12-16T03:47:00.9099142+01:00",
  "SatStart": "2007-09-10T03:47:00.9099142+02:00",
  "SatStop": "2001-05-30T03:47:00.9099142+02:00",
  "SunStart": "2016-04-16T03:47:00.9099142+02:00",
  "SunStop": "2015-07-10T03:47:00.9099142+02:00",
  "NonDates": [
    "cumque",
    "velit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 183,
      "AlertLevel": 548,
      "AlertTimeout": 259,
      "Action": 295,
      "DelegateTo": 323,
      "ScriptId": 371,
      "EmailTo": "kathlyn@mcclure.name",
      "SmsTo": "est",
      "ReplyTemplateIdCustomer": 705,
      "ReplyTemplateIdUser": 253,
      "ReplyTemplateIdCatmast": 490,
      "ReplyTemplateIdEmail": 199,
      "RtiCustomerSms": 295,
      "ReplyTemplateIdUserSms": 41,
      "ReplyTemplateIdCatmastSms": 661,
      "ReplyTemplateIdSms": 415
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 616,
  "Name": "Turner, West and Willms",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 53,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 977,
  "MonStart": "2007-10-03T03:47:00.9099142+02:00",
  "MonStop": "2015-09-03T03:47:00.9099142+02:00",
  "TueStart": "2000-10-02T03:47:00.9099142+02:00",
  "TueStop": "2001-06-17T03:47:00.9099142+02:00",
  "WedStart": "2019-11-12T03:47:00.9099142+01:00",
  "WedStop": "2021-11-26T03:47:00.9099142+01:00",
  "ThuStart": "2022-12-14T03:47:00.9099142+01:00",
  "ThuStop": "2019-09-17T03:47:00.9099142+02:00",
  "FriStart": "2006-08-23T03:47:00.9099142+02:00",
  "FriStop": "2008-03-25T03:47:00.9099142+01:00",
  "SatStart": "2017-08-07T03:47:00.9099142+02:00",
  "SatStop": "2015-05-01T03:47:00.9099142+02:00",
  "SunStart": "2015-04-07T03:47:00.9099142+02:00",
  "SunStop": "2014-10-04T03:47:00.9099142+02:00",
  "NonDates": [
    "vero",
    "corrupti"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 311,
      "AlertLevel": 803,
      "AlertTimeout": 297,
      "Action": 855,
      "DelegateTo": 846,
      "ScriptId": 643,
      "EmailTo": "coralie_hamill@mayertswift.name",
      "SmsTo": "ad",
      "ReplyTemplateIdCustomer": 207,
      "ReplyTemplateIdUser": 457,
      "ReplyTemplateIdCatmast": 996,
      "ReplyTemplateIdEmail": 931,
      "RtiCustomerSms": 600,
      "ReplyTemplateIdUserSms": 951,
      "ReplyTemplateIdCatmastSms": 449,
      "ReplyTemplateIdSms": 18,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 259
    }
  }
}
```
---
title: PUT List/TicketCategory/Items/{id}
id: v1TicketCategoryList_PutTicketCategoryEntity
---

# PUT List/TicketCategory/Items/{id}

```http
PUT /api/v1/List/TicketCategory/Items/{id}
```

Updates the existing TicketCategoryEntity

Calls the List agent service SaveTicketCategoryEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of TicketCategoryEntity to be saved. **Required** |



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

The details of TicketCategoryEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketCategoryId | int32 | The id of the ticket category. (primary key) |
| ParentId | int32 | The parent category for this category. -1 if this is a toplevel category. |
| Name | string | The (short) name of this category. E.g. &amp;apos;support&amp;apos;. |
| Fullname | string | The fullname (compiled from parents&amp;apos; names) for this category. E.g. &amp;apos;norway/product A/support&amp;apos;. |
| CategoryMaster | int32 | The user associated with this category. |
| Flags | string | A bitmask representing flags for this category. |
| DelegateMethod | string | An integer indicating the delegation method for this category. |
| ExternalName | string | The external name for this category, used for the customer frontend. |
| ClosingStatus | string | An integer indicating if new requests should have the &amp;apos;close request&amp;apos; in this category checked as default, or if the users preferences should be selected. |
| MsgClosingStatus | string | An integer indicating if new messages should have the &amp;apos;close request&amp;apos; in this category checked as default, or if the users preferences should be selected. |
| AssignmentLag | int32 | Number of minutes we shall override the assignment if a customer sends consecutive messages to this category |
| ReplyTemplate | int32 | Reply template to merge with messages posted in this category |
| NotificationEmail | string | Comma separated list of addresses to notify when requests are redelegated to (unassigned) in this category. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketCategoryEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketCategoryEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

This entity describes the meta data for a ticket category, and provides special operations on it.



Carrier object for TicketCategoryEntity.
Services for the TicketCategoryEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketCategoryId | int32 | The id of the ticket category. (primary key) |
| ParentId | int32 | The parent category for this category. -1 if this is a toplevel category. |
| Name | string | The (short) name of this category. E.g. &amp;apos;support&amp;apos;. |
| Fullname | string | The fullname (compiled from parents&amp;apos; names) for this category. E.g. &amp;apos;norway/product A/support&amp;apos;. |
| CategoryMaster | int32 | The user associated with this category. |
| Flags | string | A bitmask representing flags for this category. |
| DelegateMethod | string | An integer indicating the delegation method for this category. |
| ExternalName | string | The external name for this category, used for the customer frontend. |
| ClosingStatus | string | An integer indicating if new requests should have the &amp;apos;close request&amp;apos; in this category checked as default, or if the users preferences should be selected. |
| MsgClosingStatus | string | An integer indicating if new messages should have the &amp;apos;close request&amp;apos; in this category checked as default, or if the users preferences should be selected. |
| AssignmentLag | int32 | Number of minutes we shall override the assignment if a customer sends consecutive messages to this category |
| ReplyTemplate | int32 | Reply template to merge with messages posted in this category |
| NotificationEmail | string | Comma separated list of addresses to notify when requests are redelegated to (unassigned) in this category. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketCategoryEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketCategoryEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/TicketCategory/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 649,
  "ParentId": 939,
  "Name": "McGlynn Inc and Sons",
  "Fullname": "at",
  "CategoryMaster": 355,
  "Flags": "AcceptWhenReplying",
  "DelegateMethod": "Even",
  "ExternalName": "Fay-Berge",
  "ClosingStatus": "Active",
  "MsgClosingStatus": "Active",
  "AssignmentLag": 726,
  "ReplyTemplate": 917,
  "NotificationEmail": "zachery.mcglynn@ortizhagenes.us",
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "tempora"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 214,
  "ParentId": 727,
  "Name": "Kuhn Group",
  "Fullname": "dolorem",
  "CategoryMaster": 96,
  "Flags": "AcceptWhenReplying",
  "DelegateMethod": "Even",
  "ExternalName": "Marks, Runolfsdottir and Bosco",
  "ClosingStatus": "Active",
  "MsgClosingStatus": "Active",
  "AssignmentLag": 1000,
  "ReplyTemplate": 566,
  "NotificationEmail": "ally.padberg@stracketremblay.biz",
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "autem"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 505
    }
  }
}
```
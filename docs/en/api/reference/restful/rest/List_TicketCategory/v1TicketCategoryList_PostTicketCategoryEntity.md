---
title: POST List/TicketCategory/Items
uid: v1TicketCategoryList_PostTicketCategoryEntity
---

# POST List/TicketCategory/Items

```http
POST /api/v1/List/TicketCategory/Items
```

Create a new TicketCategoryEntity list item


Calls the List agent service SaveTicketCategoryEntity.







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

## Request Body: newEntity 

The TicketCategoryEntity to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketCategoryId | Integer | The id of the ticket category. (primary key) |
| ParentId | Integer | The parent category for this category. -1 if this is a toplevel category. |
| Name | String | The (short) name of this category. E.g. &amp;apos;support&amp;apos;. |
| Fullname | String | The fullname (compiled from parents&amp;apos; names) for this category. E.g. &amp;apos;norway/product A/support&amp;apos;. |
| CategoryMaster | Integer | The user associated with this category. |
| Flags | String | A bitmask representing flags for this category. |
| DelegateMethod | String | An integer indicating the delegation method for this category. |
| ExternalName | String | The external name for this category, used for the customer frontend. |
| ClosingStatus | String | Determines the default status used in the GUI when creating a ticket |
| MsgClosingStatus | String | Determines the default status used in the GUI when adding a request to a ticket |
| AssignmentLag | Integer | Number of minutes we shall override the assignment if a customer sends consecutive messages to this category |
| ReplyTemplate | Integer | Reply template to merge with messages posted in this category |
| NotificationEmail | String | Comma separated list of addresses to notify when requests are redelegated to (unassigned) in this category. |
| DefaultTicketStatus | TicketStatusEntity | Default status for new tickets, if 0 then there is a fallback to a user-dependent value |
| DefaultMessageStatus | TicketStatusEntity | Default status for new messages, if 0 then there is a fallback to a user-dependent value |
| EffectiveReplyTemplateId | Integer | Id of reply template to merge into messages, whose ticket belongs to this category. Also takes into account 'Apply to subcategories' on parent categories. This is a calculated, readonly field. |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.TicketCategoryEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketCategoryEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketCategoryEntity

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
| ClosingStatus | string | Determines the default status used in the GUI when creating a ticket |
| MsgClosingStatus | string | Determines the default status used in the GUI when adding a request to a ticket |
| AssignmentLag | int32 | Number of minutes we shall override the assignment if a customer sends consecutive messages to this category |
| ReplyTemplate | int32 | Reply template to merge with messages posted in this category |
| NotificationEmail | string | Comma separated list of addresses to notify when requests are redelegated to (unassigned) in this category. |
| DefaultTicketStatus | TicketStatusEntity | Default status for new tickets, if 0 then there is a fallback to a user-dependent value |
| DefaultMessageStatus | TicketStatusEntity | Default status for new messages, if 0 then there is a fallback to a user-dependent value |
| EffectiveReplyTemplateId | int32 | Id of reply template to merge into messages, whose ticket belongs to this category. Also takes into account 'Apply to subcategories' on parent categories. This is a calculated, readonly field. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketCategoryEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketCategoryEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/List/TicketCategory/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 637,
  "ParentId": 466,
  "Name": "Ratke, Jakubowski and Jacobi",
  "Fullname": "sit",
  "CategoryMaster": 840,
  "Flags": "AcceptWhenReplying",
  "DelegateMethod": "Even",
  "ExternalName": "Dare-Reichert",
  "ClosingStatus": "Active",
  "MsgClosingStatus": "Active",
  "AssignmentLag": 985,
  "ReplyTemplate": 127,
  "NotificationEmail": "devonte@labadie.ca",
  "DefaultTicketStatus": null,
  "DefaultMessageStatus": null,
  "EffectiveReplyTemplateId": 622,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "laudantium"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 254,
  "ParentId": 999,
  "Name": "Simonis, Turcotte and Stanton",
  "Fullname": "nihil",
  "CategoryMaster": 350,
  "Flags": "AcceptWhenReplying",
  "DelegateMethod": "Even",
  "ExternalName": "Grant Group",
  "ClosingStatus": "Active",
  "MsgClosingStatus": "Active",
  "AssignmentLag": 170,
  "ReplyTemplate": 76,
  "NotificationEmail": "allison_kemmer@hilll.biz",
  "DefaultTicketStatus": null,
  "DefaultMessageStatus": null,
  "EffectiveReplyTemplateId": 1001,
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "tenetur"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "commodi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 801
    }
  }
}
```
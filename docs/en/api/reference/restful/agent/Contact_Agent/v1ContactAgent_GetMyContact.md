---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 268,
  "Name": "Kunze LLC",
  "Department": "",
  "OrgNr": "839688",
  "Number1": "794390",
  "Number2": "1518550",
  "UpdatedDate": "2018-12-21T14:32:02.3274115+01:00",
  "CreatedDate": "2024-10-05T14:32:02.3274115+02:00",
  "Emails": [
    {
      "Value": "laborum",
      "StrippedValue": "voluptas",
      "Description": "Integrated radical challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "voluptas",
      "Description": "Integrated radical challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 815,
      "Name": "Flatley-Lowe",
      "ToolTip": "Nam porro.",
      "Deleted": false,
      "Rank": 320,
      "Type": "nesciunt",
      "ColorBlock": 130,
      "IconHint": "nobis",
      "Selected": false,
      "LastChanged": "2005-03-10T14:32:02.3274115+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Gianni Boyle PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "doloribus",
      "Description": "Persistent client-driven contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "doloribus",
      "Description": "Persistent client-driven contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "velit",
      "StrippedValue": "assumenda",
      "Description": "Switchable clear-thinking secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "assumenda",
      "Description": "Switchable clear-thinking secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aliquid",
      "StrippedValue": "error",
      "Description": "Diverse eco-centric contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "error",
      "Description": "Diverse eco-centric contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    }
  ],
  "Description": "Horizontal regional challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "magnam",
      "PersonId": 846,
      "Mrmrs": "in",
      "Firstname": "Harmon",
      "Lastname": "Rath",
      "MiddleName": "Braun, Carter and Jerde",
      "Title": "praesentium",
      "Description": "Reverse-engineered object-oriented internet solution",
      "Email": "bria@bartoletti.com",
      "FullName": "Barrett Shields",
      "DirectPhone": "(140)776-9222",
      "FormalName": "Shields-Heaney",
      "CountryId": 776,
      "ContactId": 801,
      "ContactName": "Schinner-Treutel",
      "Retired": 908,
      "Rank": 752,
      "ActiveInterests": 102,
      "ContactDepartment": "",
      "ContactCountryId": 287,
      "ContactOrgNr": "1286326",
      "FaxPhone": "1-393-687-7785 x2402",
      "MobilePhone": "295-491-7106 x4312",
      "ContactPhone": "1-673-675-3608",
      "AssociateName": "Leuschke-Kautzer",
      "AssociateId": 378,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "temporibus",
      "Kanalname": "qui",
      "Post1": "sed",
      "Post2": "vel",
      "Post3": "enim",
      "EmailName": "unique@fritsch.biz",
      "ContactFullName": "Mrs. Cletus Adrien Vandervort",
      "ActiveErpLinks": 440,
      "TicketPriorityId": 703,
      "SupportLanguageId": 822,
      "SupportAssociateId": 269,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1197138",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 381
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 135,
  "GroupId": 79,
  "ActiveStatusMonitorId": 457,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 304,
  "DbiAgentId": 131,
  "DbiLastSyncronized": "2009-04-06T14:32:02.3274115+02:00",
  "DbiKey": "alias",
  "DbiLastModified": "2019-12-01T14:32:02.3274115+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 703,
  "ActiveErpLinks": 803,
  "BounceEmails": [
    "jalyn_bauch@schulist.co.uk",
    "yasmin.kohler@weissnat.biz"
  ],
  "Domains": [
    "at",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Elinor Schumm",
    "SuperOffice:2": "Dawson Smith"
  },
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "illo"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "in"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 719
    }
  }
}
```
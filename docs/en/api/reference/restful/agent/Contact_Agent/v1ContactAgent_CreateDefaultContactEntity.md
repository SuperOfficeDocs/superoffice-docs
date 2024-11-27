---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 247,
  "Name": "Gislason, McDermott and Prosacco",
  "Department": "",
  "OrgNr": "172222",
  "Number1": "1412510",
  "Number2": "164658",
  "UpdatedDate": "2020-03-16T14:45:05.0377355+01:00",
  "CreatedDate": "2019-07-01T14:45:05.0377355+02:00",
  "Emails": [
    {
      "Value": "occaecati",
      "StrippedValue": "qui",
      "Description": "Robust reciprocal budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "qui",
      "Description": "Robust reciprocal budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 234,
      "Name": "Smitham, Kemmer and Gorczany",
      "ToolTip": "Odio maxime enim a ut.",
      "Deleted": false,
      "Rank": 569,
      "Type": "consequatur",
      "ColorBlock": 669,
      "IconHint": "at",
      "Selected": false,
      "LastChanged": "2020-03-30T14:45:05.0377355+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "esse",
      "Hidden": true,
      "FullName": "Mrs. Jazlyn Armstrong",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 400
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "labore",
      "StrippedValue": "nemo",
      "Description": "Customer-focused optimizing contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "nemo",
      "Description": "Customer-focused optimizing contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptate",
      "StrippedValue": "et",
      "Description": "Organic bandwidth-monitored software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "et",
      "Description": "Organic bandwidth-monitored software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "minus",
      "Description": "Cross-group transitional archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "minus",
      "Description": "Cross-group transitional archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Description": "Implemented modular middleware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repellat",
      "PersonId": 271,
      "Mrmrs": "exercitationem",
      "Firstname": "Alison",
      "Lastname": "Klein",
      "MiddleName": "Rolfson, Gleichner and Klein",
      "Title": "dolor",
      "Description": "Decentralized holistic contingency",
      "Email": "berta.dicki@mcdermott.uk",
      "FullName": "Liliana Wiza MD",
      "DirectPhone": "840.155.3750",
      "FormalName": "Mills, Bruen and Doyle",
      "CountryId": 110,
      "ContactId": 861,
      "ContactName": "McDermott-Greenfelder",
      "Retired": 733,
      "Rank": 146,
      "ActiveInterests": 500,
      "ContactDepartment": "",
      "ContactCountryId": 24,
      "ContactOrgNr": "883681",
      "FaxPhone": "1-287-339-9957 x05107",
      "MobilePhone": "834.041.3192",
      "ContactPhone": "(308)778-8480",
      "AssociateName": "Zboncak-Jacobson",
      "AssociateId": 895,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "animi",
      "Kanalname": "non",
      "Post1": "esse",
      "Post2": "distinctio",
      "Post3": "accusamus",
      "EmailName": "boris@schmeler.us",
      "ContactFullName": "Bradly Dach",
      "ActiveErpLinks": 834,
      "TicketPriorityId": 655,
      "SupportLanguageId": 633,
      "SupportAssociateId": 520,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "consequatur",
  "Xstop": false,
  "ActiveInterests": 240,
  "GroupId": 677,
  "ActiveStatusMonitorId": 715,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 943,
  "DbiAgentId": 520,
  "DbiLastSyncronized": "1999-07-09T14:45:05.0377355+02:00",
  "DbiKey": "nihil",
  "DbiLastModified": "2020-08-23T14:45:05.0377355+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 58,
  "ActiveErpLinks": 647,
  "BounceEmails": [
    "bud_howell@crooks.co.uk",
    "nona_terry@dickinsoncorwin.co.uk"
  ],
  "Domains": [
    "atque",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Hoyt Murazik",
    "SuperOffice:2": "Miss Janessa Chelsea Beer"
  },
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "reprehenderit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 389
    }
  }
}
```
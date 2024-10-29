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
  "ContactId": 348,
  "Name": "King, Crist and Gulgowski",
  "Department": "",
  "OrgNr": "734491",
  "Number1": "1020108",
  "Number2": "519573",
  "UpdatedDate": "2001-02-24T13:14:05.6320153+01:00",
  "CreatedDate": "2020-11-23T13:14:05.6320153+01:00",
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "omnis",
      "Description": "Customizable coherent ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "omnis",
      "Description": "Customizable coherent ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 746,
      "Name": "Rempel-Hettinger",
      "ToolTip": "Blanditiis nulla.",
      "Deleted": false,
      "Rank": 84,
      "Type": "nulla",
      "ColorBlock": 720,
      "IconHint": "hic",
      "Selected": false,
      "LastChanged": "2022-04-25T13:14:05.6320153+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Cale Mertz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "ad",
      "Description": "Enhanced multi-tasking policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "ad",
      "Description": "Enhanced multi-tasking policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "recusandae",
      "StrippedValue": "deleniti",
      "Description": "Diverse bottom-line strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "deleniti",
      "Description": "Diverse bottom-line strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "enim",
      "StrippedValue": "ea",
      "Description": "Centralized well-modulated monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 5
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "ea",
      "Description": "Centralized well-modulated monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 5
        }
      }
    }
  ],
  "Description": "Streamlined analyzing customer loyalty",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "a",
      "PersonId": 36,
      "Mrmrs": "eos",
      "Firstname": "Frederik",
      "Lastname": "Reynolds",
      "MiddleName": "Dibbert, Hirthe and McLaughlin",
      "Title": "hic",
      "Description": "Self-enabling static pricing structure",
      "Email": "tristian@hammes.us",
      "FullName": "Cody Durgan",
      "DirectPhone": "(127)300-4341",
      "FormalName": "Kassulke-Kautzer",
      "CountryId": 963,
      "ContactId": 844,
      "ContactName": "Bailey-Walsh",
      "Retired": 247,
      "Rank": 909,
      "ActiveInterests": 920,
      "ContactDepartment": "",
      "ContactCountryId": 397,
      "ContactOrgNr": "1148975",
      "FaxPhone": "(004)237-8758",
      "MobilePhone": "(639)002-9316 x1787",
      "ContactPhone": "1-207-143-3117 x79275",
      "AssociateName": "Boehm Inc and Sons",
      "AssociateId": 580,
      "UsePersonAddress": true,
      "ContactFax": "assumenda",
      "Kanafname": "velit",
      "Kanalname": "ducimus",
      "Post1": "dolores",
      "Post2": "et",
      "Post3": "molestias",
      "EmailName": "theo_fay@stiedemann.info",
      "ContactFullName": "Lafayette Ebert",
      "ActiveErpLinks": 979,
      "TicketPriorityId": 715,
      "SupportLanguageId": 29,
      "SupportAssociateId": 298,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "totam",
  "Xstop": false,
  "ActiveInterests": 650,
  "GroupId": 204,
  "ActiveStatusMonitorId": 253,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 100,
  "DbiAgentId": 756,
  "DbiLastSyncronized": "1999-06-14T13:14:05.6320153+02:00",
  "DbiKey": "soluta",
  "DbiLastModified": "2009-06-25T13:14:05.6320153+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 976,
  "ActiveErpLinks": 583,
  "BounceEmails": [
    "felipe@collins.ca",
    "jammie@collins.name"
  ],
  "Domains": [
    "ut",
    "natus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1334586895"
  },
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "dolores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 127
    }
  }
}
```
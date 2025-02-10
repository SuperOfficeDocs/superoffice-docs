---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=911
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 313,
  "Name": "Waelchi, Paucek and Morissette",
  "Department": "",
  "OrgNr": "1445161",
  "Number1": "1122689",
  "Number2": "778239",
  "UpdatedDate": "2022-01-26T12:01:27.4783858+01:00",
  "CreatedDate": "2022-06-21T12:01:27.4783858+02:00",
  "Emails": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "quae",
      "Description": "Assimilated composite flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "quae",
      "Description": "Assimilated composite flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 580,
      "Name": "Monahan LLC",
      "ToolTip": "Culpa expedita.",
      "Deleted": false,
      "Rank": 372,
      "Type": "ipsam",
      "ColorBlock": 92,
      "IconHint": "saepe",
      "Selected": false,
      "LastChanged": "2002-08-02T12:01:27.4783858+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "animi",
      "Hidden": true,
      "FullName": "Audreanne Bartell V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 263
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ad",
      "StrippedValue": "suscipit",
      "Description": "Reverse-engineered object-oriented structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "suscipit",
      "Description": "Reverse-engineered object-oriented structure",
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
  "Phones": [
    {
      "Value": "soluta",
      "StrippedValue": "est",
      "Description": "Virtual system-worthy encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "est",
      "Description": "Virtual system-worthy encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "corporis",
      "Description": "Reactive context-sensitive structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "corporis",
      "Description": "Reactive context-sensitive structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    }
  ],
  "Description": "Operative coherent customer loyalty",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 142,
      "Mrmrs": "culpa",
      "Firstname": "Jon",
      "Lastname": "Lebsack",
      "MiddleName": "Effertz-Schuppe",
      "Title": "laboriosam",
      "Description": "Reduced multimedia data-warehouse",
      "Email": "stephany_huel@bogisich.com",
      "FullName": "Euna Eichmann",
      "DirectPhone": "951-089-4108 x6006",
      "FormalName": "Bahringer, Pollich and Beier",
      "CountryId": 87,
      "ContactId": 890,
      "ContactName": "Abshire Inc and Sons",
      "Retired": 394,
      "Rank": 16,
      "ActiveInterests": 642,
      "ContactDepartment": "",
      "ContactCountryId": 971,
      "ContactOrgNr": "800996",
      "FaxPhone": "968-625-2620 x2109",
      "MobilePhone": "399.582.3077",
      "ContactPhone": "(197)176-9361 x336",
      "AssociateName": "Leuschke Inc and Sons",
      "AssociateId": 742,
      "UsePersonAddress": false,
      "ContactFax": "iste",
      "Kanafname": "illo",
      "Kanalname": "similique",
      "Post1": "repudiandae",
      "Post2": "debitis",
      "Post3": "quas",
      "EmailName": "wilford.wisoky@mooregoyette.com",
      "ContactFullName": "Wayne Thompson",
      "ActiveErpLinks": 192,
      "TicketPriorityId": 969,
      "SupportLanguageId": 383,
      "SupportAssociateId": 912,
      "CategoryName": "VIP Customer",
      "PersonNumber": "410775",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 795
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "odit",
  "Xstop": true,
  "ActiveInterests": 162,
  "GroupId": 323,
  "ActiveStatusMonitorId": 15,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 805,
  "DbiAgentId": 642,
  "DbiLastSyncronized": "2022-05-01T12:01:27.4783858+02:00",
  "DbiKey": "tempore",
  "DbiLastModified": "2020-02-01T12:01:27.4783858+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 362,
  "ActiveErpLinks": 558,
  "BounceEmails": [
    "lesley@murray.uk",
    "thaddeus@smitham.co.uk"
  ],
  "Domains": [
    "deleniti",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Houston Dare",
    "SuperOffice:2": "Rosendo Gerard Hilpert DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "magnam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 234
    }
  }
}
```
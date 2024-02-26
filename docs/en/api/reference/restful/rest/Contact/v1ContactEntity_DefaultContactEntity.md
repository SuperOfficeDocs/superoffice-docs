---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 14 Jul 2007 10:30:31 G7T

{
  "ContactId": 458,
  "Name": "Fadel-Tremblay",
  "Department": "",
  "OrgNr": "642259",
  "Number1": "466583",
  "Number2": "1498262",
  "UpdatedDate": "2007-07-14T10:30:31.8543093+02:00",
  "CreatedDate": "2021-03-18T10:30:31.8543093+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "hic",
      "Description": "Cloned 24 hour help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "hic",
      "Description": "Cloned 24 hour help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 352,
      "Name": "Littel-Jaskolski",
      "ToolTip": "Eum ut et maxime.",
      "Deleted": false,
      "Rank": 65,
      "Type": "quasi",
      "ColorBlock": 458,
      "IconHint": "illum",
      "Selected": false,
      "LastChanged": "2014-03-21T10:30:31.8543093+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "quibusdam",
      "Hidden": false,
      "FullName": "Brisa Bosco",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 725
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "ut",
      "Description": "Down-sized executive adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "ut",
      "Description": "Down-sized executive adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "repellendus",
      "StrippedValue": "molestiae",
      "Description": "Progressive optimal orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "molestiae",
      "Description": "Progressive optimal orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "officiis",
      "StrippedValue": "dicta",
      "Description": "Mandatory executive installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 408
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "dicta",
      "Description": "Mandatory executive installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 408
        }
      }
    }
  ],
  "Description": "Stand-alone stable time-frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 505,
      "Mrmrs": "omnis",
      "Firstname": "Sylvan",
      "Lastname": "Kreiger",
      "MiddleName": "Herzog Inc and Sons",
      "Title": "aut",
      "Description": "Fundamental value-added firmware",
      "Email": "eda@littel.ca",
      "FullName": "Jo Wava Klein DDS",
      "DirectPhone": "1-718-682-5935 x207",
      "FormalName": "Rutherford Inc and Sons",
      "CountryId": 952,
      "ContactId": 459,
      "ContactName": "Jacobson Inc and Sons",
      "Retired": 221,
      "Rank": 984,
      "ActiveInterests": 449,
      "ContactDepartment": "",
      "ContactCountryId": 36,
      "ContactOrgNr": "1214260",
      "FaxPhone": "150.222.3241 x5715",
      "MobilePhone": "1-980-344-2735 x686",
      "ContactPhone": "(973)078-6953 x2970",
      "AssociateName": "Oberbrunner, Witting and Heathcote",
      "AssociateId": 983,
      "UsePersonAddress": false,
      "ContactFax": "veniam",
      "Kanafname": "quaerat",
      "Kanalname": "aperiam",
      "Post1": "quaerat",
      "Post2": "nihil",
      "Post3": "doloremque",
      "EmailName": "marcella.maggio@kozey.co.uk",
      "ContactFullName": "Ms. Tyrell Sipes V",
      "ActiveErpLinks": 718,
      "TicketPriorityId": 478,
      "SupportLanguageId": 443,
      "SupportAssociateId": 561,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "odit",
  "Xstop": false,
  "ActiveInterests": 550,
  "GroupId": 459,
  "ActiveStatusMonitorId": 323,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 592,
  "DbiAgentId": 998,
  "DbiLastSyncronized": "2011-05-31T10:30:31.8543093+02:00",
  "DbiKey": "culpa",
  "DbiLastModified": "2004-06-16T10:30:31.8543093+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 693,
  "ActiveErpLinks": 929,
  "BounceEmails": [
    "denis@larkinwelch.ca",
    "riley@kiehn.uk"
  ],
  "Domains": [
    "quod",
    "veniam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "789075176",
    "SuperOffice:2": "Ms. Claudie Barrows"
  },
  "ExtraFields": {
    "ExtraFields1": "earum",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "minus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 974
    }
  }
}
```
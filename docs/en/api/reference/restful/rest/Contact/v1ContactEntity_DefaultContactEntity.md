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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 27 Aug 2012 04:02:06 G8T

{
  "ContactId": 891,
  "Name": "Kling Group",
  "Department": "",
  "OrgNr": "1022087",
  "Number1": "689132",
  "Number2": "216396",
  "UpdatedDate": "2012-08-27T04:02:06.3686697+02:00",
  "CreatedDate": "2019-01-02T04:02:06.3686697+01:00",
  "Emails": [
    {
      "Value": "porro",
      "StrippedValue": "aut",
      "Description": "Customizable intermediate attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 242
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "aut",
      "Description": "Customizable intermediate attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 242
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 498,
      "Name": "Stoltenberg-Wiegand",
      "ToolTip": "Ipsa fugit quaerat corrupti.",
      "Deleted": false,
      "Rank": 573,
      "Type": "exercitationem",
      "ColorBlock": 113,
      "IconHint": "sunt",
      "Selected": false,
      "LastChanged": "2004-08-06T04:02:06.3686697+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "quod",
      "Hidden": true,
      "FullName": "Tyshawn Kilback",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 280
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eaque",
      "StrippedValue": "ratione",
      "Description": "Multi-lateral user-facing local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 532
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "ratione",
      "Description": "Multi-lateral user-facing local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 532
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iusto",
      "StrippedValue": "voluptatibus",
      "Description": "Stand-alone 3rd generation help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "voluptatibus",
      "Description": "Stand-alone 3rd generation help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "commodi",
      "StrippedValue": "quasi",
      "Description": "Inverse full-range access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "quasi",
      "Description": "Inverse full-range access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "Description": "Ameliorated secondary challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 915,
      "Mrmrs": "quo",
      "Firstname": "Ward",
      "Lastname": "Ziemann",
      "MiddleName": "Jewess, Jast and Ebert",
      "Title": "sint",
      "Description": "Enhanced logistical hardware",
      "Email": "kiel.kris@durganmarvin.ca",
      "FullName": "Angeline Lueilwitz",
      "DirectPhone": "303-441-8541 x961",
      "FormalName": "Feil, Carter and Bartoletti",
      "CountryId": 223,
      "ContactId": 905,
      "ContactName": "Ledner-Metz",
      "Retired": 319,
      "Rank": 111,
      "ActiveInterests": 129,
      "ContactDepartment": "",
      "ContactCountryId": 768,
      "ContactOrgNr": "469153",
      "FaxPhone": "323.607.6411",
      "MobilePhone": "1-577-875-5322 x9683",
      "ContactPhone": "1-794-111-7394",
      "AssociateName": "Franecki LLC",
      "AssociateId": 630,
      "UsePersonAddress": false,
      "ContactFax": "sunt",
      "Kanafname": "autem",
      "Kanalname": "vero",
      "Post1": "dignissimos",
      "Post2": "excepturi",
      "Post3": "tempore",
      "EmailName": "rene_stokes@pfannerstillwilkinson.info",
      "ContactFullName": "Ms. Ken Matilda Ernser DVM",
      "ActiveErpLinks": 518,
      "TicketPriorityId": 13,
      "SupportLanguageId": 472,
      "SupportAssociateId": 37,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "distinctio",
  "Xstop": true,
  "ActiveInterests": 668,
  "GroupId": 275,
  "ActiveStatusMonitorId": 314,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 365,
  "DbiAgentId": 631,
  "DbiLastSyncronized": "2022-01-15T04:02:06.384293+01:00",
  "DbiKey": "libero",
  "DbiLastModified": "2020-06-22T04:02:06.384293+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 647,
  "ActiveErpLinks": 464,
  "BounceEmails": [
    "bernard@hodkiewicz.com",
    "clare_johnson@rutherford.ca"
  ],
  "Domains": [
    "facilis",
    "praesentium"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Litzy Harris"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "vel"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 942
    }
  }
}
```
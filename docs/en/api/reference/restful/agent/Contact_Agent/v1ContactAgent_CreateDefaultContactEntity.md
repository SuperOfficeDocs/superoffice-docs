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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 168,
  "Name": "Streich, Frami and Romaguera",
  "Department": "",
  "OrgNr": "845201",
  "Number1": "1531615",
  "Number2": "1702790",
  "UpdatedDate": "2021-01-13T14:32:02.2649237+01:00",
  "CreatedDate": "2014-03-31T14:32:02.2649237+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "possimus",
      "Description": "Mandatory reciprocal attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 233
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "possimus",
      "Description": "Mandatory reciprocal attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 233
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 759,
      "Name": "Leannon Inc and Sons",
      "ToolTip": "Qui delectus libero et eos.",
      "Deleted": false,
      "Rank": 463,
      "Type": "sit",
      "ColorBlock": 950,
      "IconHint": "maiores",
      "Selected": true,
      "LastChanged": "2008-12-04T14:32:02.2649237+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Vance Hickle DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 765
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "magnam",
      "StrippedValue": "commodi",
      "Description": "Robust optimal initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 383
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "commodi",
      "Description": "Robust optimal initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 383
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "ducimus",
      "Description": "Virtual client-driven orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "ducimus",
      "Description": "Virtual client-driven orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "enim",
      "StrippedValue": "similique",
      "Description": "Seamless system-worthy local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "similique",
      "Description": "Seamless system-worthy local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    }
  ],
  "Description": "Mandatory full-range superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 44,
      "Mrmrs": "inventore",
      "Firstname": "Velva",
      "Lastname": "Casper",
      "MiddleName": "Eichmann Inc and Sons",
      "Title": "sunt",
      "Description": "Innovative didactic intranet",
      "Email": "muhammad_lebsack@larkinharris.info",
      "FullName": "Seth Bernhard",
      "DirectPhone": "1-366-028-4900 x937",
      "FormalName": "Abernathy, Kertzmann and Bernier",
      "CountryId": 315,
      "ContactId": 626,
      "ContactName": "Little-Von",
      "Retired": 460,
      "Rank": 417,
      "ActiveInterests": 767,
      "ContactDepartment": "transition interactive portals",
      "ContactCountryId": 285,
      "ContactOrgNr": "1258017",
      "FaxPhone": "(273)144-3243 x313",
      "MobilePhone": "680-461-9918 x68030",
      "ContactPhone": "1-849-002-9032 x9330",
      "AssociateName": "Kohler-Shields",
      "AssociateId": 510,
      "UsePersonAddress": true,
      "ContactFax": "inventore",
      "Kanafname": "reiciendis",
      "Kanalname": "quaerat",
      "Post1": "autem",
      "Post2": "nisi",
      "Post3": "provident",
      "EmailName": "otis@kossdibbert.info",
      "ContactFullName": "Emile Koepp",
      "ActiveErpLinks": 89,
      "TicketPriorityId": 345,
      "SupportLanguageId": 517,
      "SupportAssociateId": 294,
      "CategoryName": "VIP Customer",
      "PersonNumber": "774598",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 894
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": false,
  "ActiveInterests": 378,
  "GroupId": 957,
  "ActiveStatusMonitorId": 35,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 929,
  "DbiAgentId": 190,
  "DbiLastSyncronized": "1999-08-08T14:32:02.2649237+02:00",
  "DbiKey": "quia",
  "DbiLastModified": "2003-07-26T14:32:02.2649237+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 914,
  "ActiveErpLinks": 317,
  "BounceEmails": [
    "jerald@jacobs.co.uk",
    "haskell.gleason@schaden.co.uk"
  ],
  "Domains": [
    "debitis",
    "quae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "dolores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 44
    }
  }
}
```
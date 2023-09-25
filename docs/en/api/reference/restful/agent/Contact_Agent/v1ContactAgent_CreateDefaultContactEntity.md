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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 76,
  "Name": "Lind Group",
  "Department": "",
  "OrgNr": "1094778",
  "Number1": "1017526",
  "Number2": "837083",
  "UpdatedDate": "2009-05-05T03:24:47.3770673+02:00",
  "CreatedDate": "2003-08-29T03:24:47.3770673+02:00",
  "Emails": [
    {
      "Value": "officia",
      "StrippedValue": "a",
      "Description": "Devolved tangible benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "a",
      "Description": "Devolved tangible benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 726,
      "Name": "Beier-Ratke",
      "ToolTip": "Omnis sed.",
      "Deleted": false,
      "Rank": 829,
      "Type": "in",
      "ColorBlock": 502,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "1999-01-20T03:24:47.3770673+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "in",
      "Hidden": true,
      "FullName": "Esmeralda Gislason",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "sed",
      "Description": "Switchable neutral pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "sed",
      "Description": "Switchable neutral pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iste",
      "StrippedValue": "voluptatem",
      "Description": "Operative client-driven internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 111
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "voluptatem",
      "Description": "Operative client-driven internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 111
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "doloribus",
      "StrippedValue": "repellat",
      "Description": "Compatible methodical instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 372
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "repellat",
      "Description": "Compatible methodical instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 372
        }
      }
    }
  ],
  "Description": "Expanded multimedia synergy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laudantium",
      "PersonId": 812,
      "Mrmrs": "beatae",
      "Firstname": "Billy",
      "Lastname": "Gerhold",
      "MiddleName": "Homenick, O'Hara and Hansen",
      "Title": "iste",
      "Description": "Self-enabling empowering capability",
      "Email": "marlee@rau.co.uk",
      "FullName": "Zachery Purdy",
      "DirectPhone": "(488)497-5028",
      "FormalName": "Labadie Group",
      "CountryId": 573,
      "ContactId": 812,
      "ContactName": "Gleason LLC",
      "Retired": 525,
      "Rank": 232,
      "ActiveInterests": 897,
      "ContactDepartment": "",
      "ContactCountryId": 793,
      "ContactOrgNr": "146870",
      "FaxPhone": "625.954.7793",
      "MobilePhone": "(969)581-4565 x7364",
      "ContactPhone": "(832)097-8233",
      "AssociateName": "Raynor, Blanda and Brown",
      "AssociateId": 544,
      "UsePersonAddress": false,
      "ContactFax": "dolorum",
      "Kanafname": "sed",
      "Kanalname": "deleniti",
      "Post1": "facere",
      "Post2": "esse",
      "Post3": "dolore",
      "EmailName": "sherman@abshire.co.uk",
      "ContactFullName": "Miss Jerel Lori Witting II",
      "ActiveErpLinks": 958,
      "TicketPriorityId": 133,
      "SupportLanguageId": 151,
      "SupportAssociateId": 55,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 888
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "consequatur",
  "Xstop": true,
  "ActiveInterests": 653,
  "GroupId": 803,
  "ActiveStatusMonitorId": 188,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 193,
  "DbiAgentId": 232,
  "DbiLastSyncronized": "2007-10-31T03:24:47.3770673+01:00",
  "DbiKey": "ut",
  "DbiLastModified": "2019-02-12T03:24:47.3770673+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 49,
  "ActiveErpLinks": 474,
  "BounceEmails": [
    "willa_koepp@johnston.name",
    "iliana.price@mann.com"
  ],
  "Domains": [
    "dolorem",
    "facilis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Aniyah Monahan"
  },
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 236
    }
  }
}
```
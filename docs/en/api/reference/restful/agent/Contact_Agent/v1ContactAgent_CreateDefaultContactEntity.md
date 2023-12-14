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
  "ContactId": 521,
  "Name": "Reilly-Langosh",
  "Department": "",
  "OrgNr": "1213241",
  "Number1": "865577",
  "Number2": "1364114",
  "UpdatedDate": "2016-11-05T13:57:11.8549366+01:00",
  "CreatedDate": "2012-04-13T13:57:11.8549366+02:00",
  "Emails": [
    {
      "Value": "nam",
      "StrippedValue": "et",
      "Description": "Synergistic fresh-thinking complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "et",
      "Description": "Synergistic fresh-thinking complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 762,
      "Name": "Lakin, Corwin and Reichert",
      "ToolTip": "Quisquam ut dolores illo blanditiis error commodi quam.",
      "Deleted": true,
      "Rank": 171,
      "Type": "eligendi",
      "ColorBlock": 243,
      "IconHint": "debitis",
      "Selected": false,
      "LastChanged": "2009-10-30T13:57:11.8549366+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "recusandae",
      "StyleHint": "consectetur",
      "Hidden": true,
      "FullName": "Jarrell Schowalter IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "animi",
      "StrippedValue": "ea",
      "Description": "Re-engineered zero administration parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 286
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "ea",
      "Description": "Re-engineered zero administration parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 286
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "maiores",
      "StrippedValue": "neque",
      "Description": "Organic bottom-line analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "neque",
      "Description": "Organic bottom-line analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "deserunt",
      "Description": "Managed bottom-line projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 934
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "deserunt",
      "Description": "Managed bottom-line projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 934
        }
      }
    }
  ],
  "Description": "Switchable regional orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nobis",
      "PersonId": 679,
      "Mrmrs": "debitis",
      "Firstname": "Kamryn",
      "Lastname": "Crona",
      "MiddleName": "Ratke-Ratke",
      "Title": "voluptatem",
      "Description": "Secured actuating protocol",
      "Email": "gene@blockfeest.co.uk",
      "FullName": "Verner Kennedy Cummerata I",
      "DirectPhone": "(281)980-4524 x879",
      "FormalName": "Ryan LLC",
      "CountryId": 456,
      "ContactId": 670,
      "ContactName": "Conn-Vandervort",
      "Retired": 405,
      "Rank": 281,
      "ActiveInterests": 901,
      "ContactDepartment": "",
      "ContactCountryId": 899,
      "ContactOrgNr": "491285",
      "FaxPhone": "1-626-279-6614 x179",
      "MobilePhone": "925-406-9847",
      "ContactPhone": "1-725-443-8415",
      "AssociateName": "Skiles Inc and Sons",
      "AssociateId": 41,
      "UsePersonAddress": true,
      "ContactFax": "perspiciatis",
      "Kanafname": "aut",
      "Kanalname": "hic",
      "Post1": "et",
      "Post2": "magni",
      "Post3": "perferendis",
      "EmailName": "zelda.okon@bosconolan.uk",
      "ContactFullName": "Marquise Weimann",
      "ActiveErpLinks": 809,
      "TicketPriorityId": 864,
      "SupportLanguageId": 546,
      "SupportAssociateId": 696,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 725
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ex",
  "Xstop": false,
  "ActiveInterests": 959,
  "GroupId": 776,
  "ActiveStatusMonitorId": 295,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 590,
  "DbiAgentId": 631,
  "DbiLastSyncronized": "2022-01-29T13:57:11.8549366+01:00",
  "DbiKey": "odit",
  "DbiLastModified": "2015-02-05T13:57:11.8549366+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 512,
  "ActiveErpLinks": 726,
  "BounceEmails": [
    "daryl.ebert@hills.info",
    "bobby@beier.co.uk"
  ],
  "Domains": [
    "minus",
    "magnam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Peter Valentine Pfannerstill",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "reiciendis"
  },
  "CustomFields": {
    "CustomFields1": "eius",
    "CustomFields2": "ex"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 625
    }
  }
}
```
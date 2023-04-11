---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 19,
  "Name": "Beahan-Ratke",
  "Department": "",
  "OrgNr": "1010021",
  "Number1": "1490320",
  "Number2": "1565680",
  "UpdatedDate": "2015-05-02T15:29:21.0637857+02:00",
  "CreatedDate": "2006-11-26T15:29:21.0637857+01:00",
  "Emails": [
    {
      "Value": "hic",
      "StrippedValue": "eligendi",
      "Description": "Customizable stable ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "eligendi",
      "Description": "Customizable stable ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 242,
      "Name": "Reichel Inc and Sons",
      "ToolTip": "Hic id et vitae.",
      "Deleted": true,
      "Rank": 807,
      "Type": "ut",
      "ColorBlock": 81,
      "IconHint": "sint",
      "Selected": false,
      "LastChanged": "2013-06-17T15:29:21.0637857+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "vel",
      "Hidden": false,
      "FullName": "Mrs. Aniya Trantow DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 710
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "eveniet",
      "Description": "Synergistic full-range website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 3
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "eveniet",
      "Description": "Synergistic full-range website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 3
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "veritatis",
      "StrippedValue": "quis",
      "Description": "Future-proofed national model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "quis",
      "Description": "Future-proofed national model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "illo",
      "StrippedValue": "est",
      "Description": "Cross-group national hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "est",
      "Description": "Cross-group national hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    }
  ],
  "Description": "Networked client-driven array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repellendus",
      "PersonId": 133,
      "Mrmrs": "et",
      "Firstname": "Antonio",
      "Lastname": "Kris",
      "MiddleName": "Shields, Block and Daugherty",
      "Title": "incidunt",
      "Description": "Fully-configurable 5th generation implementation",
      "Email": "tracy_bernhard@swift.co.uk",
      "FullName": "Bart Johns Sr.",
      "DirectPhone": "020.552.5136 x246",
      "FormalName": "Bartoletti-Hackett",
      "CountryId": 187,
      "ContactId": 994,
      "ContactName": "Koss-Littel",
      "Retired": 219,
      "Rank": 865,
      "ActiveInterests": 299,
      "ContactDepartment": "monetize value-added e-business",
      "ContactCountryId": 30,
      "ContactOrgNr": "1092197",
      "FaxPhone": "017.852.0784 x7196",
      "MobilePhone": "(497)751-2321 x96269",
      "ContactPhone": "030-745-4181 x0287",
      "AssociateName": "McDermott LLC",
      "AssociateId": 39,
      "UsePersonAddress": false,
      "ContactFax": "aspernatur",
      "Kanafname": "voluptatem",
      "Kanalname": "exercitationem",
      "Post1": "reiciendis",
      "Post2": "dolore",
      "Post3": "et",
      "EmailName": "toney@haley.info",
      "ContactFullName": "Chaim Ledner",
      "ActiveErpLinks": 655,
      "TicketPriorityId": 952,
      "SupportLanguageId": 500,
      "SupportAssociateId": 830,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "in",
  "Xstop": true,
  "ActiveInterests": 431,
  "GroupId": 29,
  "ActiveStatusMonitorId": 251,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 648,
  "DbiAgentId": 387,
  "DbiLastSyncronized": "2002-02-28T15:29:21.0682853+01:00",
  "DbiKey": "neque",
  "DbiLastModified": "2018-07-21T15:29:21.0682853+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 379,
  "ActiveErpLinks": 923,
  "BounceEmails": [
    "jannie_hand@pourosgreen.us",
    "simone@zemlak.uk"
  ],
  "Domains": [
    "qui",
    "ipsum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2092515538",
    "SuperOffice:2": "Milan Mossie Brekke Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "autem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 258
    }
  }
}
```
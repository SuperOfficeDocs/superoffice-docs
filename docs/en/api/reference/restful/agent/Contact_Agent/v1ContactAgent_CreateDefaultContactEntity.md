---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Loading default values into a new ContactEntity.








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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 86,
  "Name": "Powlowski-Larson",
  "Department": "",
  "OrgNr": "1517634",
  "Number1": "1224618",
  "Number2": "641448",
  "UpdatedDate": "2012-12-30T11:24:47.7345473+01:00",
  "CreatedDate": "2018-09-29T11:24:47.7345473+02:00",
  "Emails": [
    {
      "Value": "fugiat",
      "StrippedValue": "quaerat",
      "Description": "Proactive demand-driven paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "quaerat",
      "Description": "Proactive demand-driven paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 712,
      "Name": "Stokes, Padberg and Feil",
      "ToolTip": "Et dolorem provident perspiciatis quibusdam.",
      "Deleted": false,
      "Rank": 87,
      "Type": "earum",
      "ColorBlock": 67,
      "IconHint": "exercitationem",
      "Selected": true,
      "LastChanged": "2016-02-16T11:24:47.7345473+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "architecto",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Susanna Mertz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 100
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "odit",
      "Description": "Seamless object-oriented concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 958
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "odit",
      "Description": "Seamless object-oriented concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 958
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quos",
      "StrippedValue": "quo",
      "Description": "Profound cohesive moratorium",
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
      "Value": "quos",
      "StrippedValue": "quo",
      "Description": "Profound cohesive moratorium",
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
  "Faxes": [
    {
      "Value": "autem",
      "StrippedValue": "deleniti",
      "Description": "Future-proofed local concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "deleniti",
      "Description": "Future-proofed local concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "Description": "Synchronised actuating hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "expedita",
      "PersonId": 468,
      "Mrmrs": "culpa",
      "Firstname": "Else",
      "Lastname": "Will",
      "MiddleName": "Kris, Johnson and Volkman",
      "Title": "nihil",
      "Description": "Open-source systematic productivity",
      "Email": "kathlyn.trantow@mccullough.com",
      "FullName": "River Frederic Reichert DVM",
      "DirectPhone": "225.933.3114 x8944",
      "FormalName": "Lang-Hane",
      "CountryId": 870,
      "ContactId": 982,
      "ContactName": "Nikolaus, Bauch and Barton",
      "Retired": 16,
      "Rank": 311,
      "ActiveInterests": 487,
      "ContactDepartment": "",
      "ContactCountryId": 693,
      "ContactOrgNr": "1846642",
      "FaxPhone": "(077)324-4976",
      "MobilePhone": "509.565.4148 x267",
      "ContactPhone": "963.253.0310 x91622",
      "AssociateName": "Hermann-Ferry",
      "AssociateId": 84,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "officia",
      "Kanalname": "nihil",
      "Post1": "non",
      "Post2": "reprehenderit",
      "Post3": "quam",
      "EmailName": "morris@satterfield.uk",
      "ContactFullName": "Lionel Kemmer",
      "ActiveErpLinks": 318,
      "TicketPriorityId": 262,
      "SupportLanguageId": 847,
      "SupportAssociateId": 510,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1087221",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ea",
  "Xstop": false,
  "ActiveInterests": 954,
  "GroupId": 480,
  "ActiveStatusMonitorId": 291,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 453,
  "DbiAgentId": 592,
  "DbiLastSyncronized": "2014-03-02T11:24:47.7345473+01:00",
  "DbiKey": "dignissimos",
  "DbiLastModified": "2015-02-10T11:24:47.7345473+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 659,
  "ActiveErpLinks": 757,
  "BounceEmails": [
    "oceane@reingergraham.ca",
    "sandra@kessler.co.uk"
  ],
  "Domains": [
    "impedit",
    "velit"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Mona Scot Adams",
    "SuperOffice:2": "Leola Lebsack"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "voluptate",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 466
    }
  }
}
```
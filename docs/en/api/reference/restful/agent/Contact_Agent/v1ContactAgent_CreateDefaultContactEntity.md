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
  "ContactId": 224,
  "Name": "Graham, Hessel and Beatty",
  "Department": "",
  "OrgNr": "210686",
  "Number1": "901370",
  "Number2": "1817667",
  "UpdatedDate": "2022-05-04T12:19:44.8517429+02:00",
  "CreatedDate": "2016-08-14T12:19:44.8517429+02:00",
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "repudiandae",
      "Description": "Fundamental didactic core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 603
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "repudiandae",
      "Description": "Fundamental didactic core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 603
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 997,
      "Name": "Kozey, Weber and Veum",
      "ToolTip": "Aut nisi aut esse ut ea.",
      "Deleted": true,
      "Rank": 376,
      "Type": "harum",
      "ColorBlock": 883,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2018-01-11T12:19:44.8517429+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "expedita",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Laney Schuster",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "quam",
      "Description": "Multi-layered fault-tolerant definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "quam",
      "Description": "Multi-layered fault-tolerant definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "occaecati",
      "StrippedValue": "est",
      "Description": "Implemented modular application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 308
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "est",
      "Description": "Implemented modular application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 308
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "sit",
      "Description": "Public-key encompassing artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 456
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sit",
      "Description": "Public-key encompassing artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 456
        }
      }
    }
  ],
  "Description": "Re-contextualized 3rd generation algorithm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "totam",
      "PersonId": 511,
      "Mrmrs": "unde",
      "Firstname": "Laney",
      "Lastname": "Bartoletti",
      "MiddleName": "Ziemann-Carter",
      "Title": "corporis",
      "Description": "Total logistical core",
      "Email": "kara.champlin@krajcik.uk",
      "FullName": "Miss Manley Estefania Schroeder",
      "DirectPhone": "685.610.4746 x50015",
      "FormalName": "Kiehn, Johnson and Rath",
      "CountryId": 503,
      "ContactId": 934,
      "ContactName": "Beatty-Hansen",
      "Retired": 24,
      "Rank": 32,
      "ActiveInterests": 920,
      "ContactDepartment": "",
      "ContactCountryId": 898,
      "ContactOrgNr": "626677",
      "FaxPhone": "(320)369-3141 x4421",
      "MobilePhone": "475-249-3849 x27666",
      "ContactPhone": "1-689-654-2312",
      "AssociateName": "Turner LLC",
      "AssociateId": 761,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "a",
      "Kanalname": "et",
      "Post1": "dolore",
      "Post2": "dolorem",
      "Post3": "laudantium",
      "EmailName": "everett_collier@maggiostrosin.com",
      "ContactFullName": "Dr. Rosalyn Nolan",
      "ActiveErpLinks": 54,
      "TicketPriorityId": 862,
      "SupportLanguageId": 156,
      "SupportAssociateId": 929,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 87
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "fugiat",
  "Xstop": true,
  "ActiveInterests": 16,
  "GroupId": 257,
  "ActiveStatusMonitorId": 953,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 815,
  "DbiAgentId": 807,
  "DbiLastSyncronized": "2001-06-08T12:19:44.8673486+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2019-07-06T12:19:44.8673486+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 882,
  "ActiveErpLinks": 809,
  "BounceEmails": [
    "nia.funk@collierkoelpin.com",
    "gerhard@turnerblanda.ca"
  ],
  "Domains": [
    "sequi",
    "quam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Marvin Davis Sr.",
    "SuperOffice:2": "Alexander Jennie Cole DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 438
    }
  }
}
```
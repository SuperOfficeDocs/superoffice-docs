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
  "ContactId": 877,
  "Name": "Jenkins, Cole and Berge",
  "Department": "",
  "OrgNr": "942794",
  "Number1": "285184",
  "Number2": "1464106",
  "UpdatedDate": "2010-01-06T10:30:23.2730672+01:00",
  "CreatedDate": "2008-02-07T10:30:23.2730672+01:00",
  "Emails": [
    {
      "Value": "natus",
      "StrippedValue": "iste",
      "Description": "Reverse-engineered intangible structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 206
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "iste",
      "Description": "Reverse-engineered intangible structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 206
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 955,
      "Name": "Schowalter, Weber and Weimann",
      "ToolTip": "Quia culpa.",
      "Deleted": true,
      "Rank": 103,
      "Type": "sed",
      "ColorBlock": 722,
      "IconHint": "ea",
      "Selected": false,
      "LastChanged": "2022-05-23T10:30:23.2730672+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "placeat",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Mrs. Ilene Enoch Witting DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quis",
      "StrippedValue": "ea",
      "Description": "Public-key maximized architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "ea",
      "Description": "Public-key maximized architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "id",
      "StrippedValue": "doloremque",
      "Description": "Profit-focused bi-directional ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "doloremque",
      "Description": "Profit-focused bi-directional ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "architecto",
      "StrippedValue": "in",
      "Description": "Programmable transitional intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "in",
      "Description": "Programmable transitional intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    }
  ],
  "Description": "Assimilated clear-thinking knowledge base",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quas",
      "PersonId": 607,
      "Mrmrs": "facilis",
      "Firstname": "Jazmyne",
      "Lastname": "Beier",
      "MiddleName": "Hansen Inc and Sons",
      "Title": "quis",
      "Description": "Business-focused mission-critical matrix",
      "Email": "lucius.haley@grimeshirthe.biz",
      "FullName": "Cloyd Cummings I",
      "DirectPhone": "143.880.3887 x52989",
      "FormalName": "Skiles-Pollich",
      "CountryId": 186,
      "ContactId": 54,
      "ContactName": "Williamson-Schulist",
      "Retired": 105,
      "Rank": 589,
      "ActiveInterests": 64,
      "ContactDepartment": "",
      "ContactCountryId": 103,
      "ContactOrgNr": "954664",
      "FaxPhone": "1-736-219-9468 x536",
      "MobilePhone": "1-116-270-4561",
      "ContactPhone": "1-093-971-2603",
      "AssociateName": "Fadel, Torphy and Collier",
      "AssociateId": 118,
      "UsePersonAddress": false,
      "ContactFax": "reiciendis",
      "Kanafname": "omnis",
      "Kanalname": "vel",
      "Post1": "amet",
      "Post2": "repudiandae",
      "Post3": "delectus",
      "EmailName": "janis@armstrongcarter.co.uk",
      "ContactFullName": "Ms. Devonte Ransom Koepp MD",
      "ActiveErpLinks": 40,
      "TicketPriorityId": 388,
      "SupportLanguageId": 932,
      "SupportAssociateId": 816,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "rem",
  "Xstop": false,
  "ActiveInterests": 97,
  "GroupId": 478,
  "ActiveStatusMonitorId": 225,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 335,
  "DbiAgentId": 682,
  "DbiLastSyncronized": "2008-08-10T10:30:23.2730672+02:00",
  "DbiKey": "consequatur",
  "DbiLastModified": "2001-12-27T10:30:23.2730672+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 12,
  "ActiveErpLinks": 107,
  "BounceEmails": [
    "kadin.connelly@white.ca",
    "germaine@pagacwiegand.uk"
  ],
  "Domains": [
    "praesentium",
    "amet"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Parker Rath DVM",
    "SuperOffice:2": "Justen Powlowski"
  },
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "blanditiis"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "delectus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 766
    }
  }
}
```
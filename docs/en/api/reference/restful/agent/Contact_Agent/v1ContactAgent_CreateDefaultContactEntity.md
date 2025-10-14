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


NsApiSlow threshold: 2000 ms.







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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 828,
  "Name": "Hayes, Marvin and Denesik",
  "Department": "",
  "OrgNr": "850935",
  "Number1": "1085735",
  "Number2": "656598",
  "UpdatedDate": "2022-05-25T03:40:46.2800664+02:00",
  "CreatedDate": "2014-12-18T03:40:46.2800664+01:00",
  "Emails": [
    {
      "Value": "aliquam",
      "StrippedValue": "cupiditate",
      "Description": "Profound 5th generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "cupiditate",
      "Description": "Profound 5th generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 657,
      "Name": "Murazik-Runolfsson",
      "ToolTip": "Optio vel aut laboriosam voluptas.",
      "Deleted": true,
      "Rank": 69,
      "Type": "ratione",
      "ColorBlock": 293,
      "IconHint": "culpa",
      "Selected": false,
      "LastChanged": "2023-12-28T03:40:46.2800664+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "ut",
      "Hidden": true,
      "FullName": "Miss Gunnar Wolf MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 724
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quasi",
      "StrippedValue": "corporis",
      "Description": "Profound systemic software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "corporis",
      "Description": "Profound systemic software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "molestias",
      "StrippedValue": "consequatur",
      "Description": "Persistent impactful core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "consequatur",
      "Description": "Persistent impactful core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "quidem",
      "Description": "Cross-group heuristic function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quidem",
      "Description": "Cross-group heuristic function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "Description": "Synchronised discrete website",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "atque",
      "PersonId": 247,
      "Mrmrs": "natus",
      "Firstname": "Reyes",
      "Lastname": "Mosciski",
      "MiddleName": "Goyette Inc and Sons",
      "Title": "quo",
      "Description": "Stand-alone bifurcated superstructure",
      "Email": "louvenia@hellertillman.name",
      "FullName": "Jarrod Wiza",
      "DirectPhone": "1-758-160-1966 x428",
      "FormalName": "Hintz, Yost and Durgan",
      "CountryId": 71,
      "ContactId": 309,
      "ContactName": "Little-Pacocha",
      "Retired": 333,
      "Rank": 944,
      "ActiveInterests": 468,
      "ContactDepartment": "",
      "ContactCountryId": 489,
      "ContactOrgNr": "1639617",
      "FaxPhone": "1-203-985-9926 x35185",
      "MobilePhone": "025-616-2831",
      "ContactPhone": "(805)925-5034 x11348",
      "AssociateName": "Reichel, Sanford and Konopelski",
      "AssociateId": 98,
      "UsePersonAddress": true,
      "ContactFax": "expedita",
      "Kanafname": "quis",
      "Kanalname": "ut",
      "Post1": "similique",
      "Post2": "cupiditate",
      "Post3": "placeat",
      "EmailName": "gregg@schummstiedemann.ca",
      "ContactFullName": "Mrs. Raegan Frami V",
      "ActiveErpLinks": 397,
      "TicketPriorityId": 967,
      "SupportLanguageId": 739,
      "SupportAssociateId": 536,
      "CategoryName": "VIP Customer",
      "PersonNumber": "988718",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 277
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "provident",
  "Xstop": true,
  "ActiveInterests": 963,
  "GroupId": 74,
  "ActiveStatusMonitorId": 725,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 898,
  "DbiAgentId": 997,
  "DbiLastSyncronized": "2025-05-04T03:40:46.2800664+02:00",
  "DbiKey": "sint",
  "DbiLastModified": "2002-03-17T03:40:46.2800664+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 513,
  "ActiveErpLinks": 605,
  "BounceEmails": [
    "fatima.hamill@windlermoore.info",
    "faustino@naderdaugherty.info"
  ],
  "Domains": [
    "velit",
    "temporibus"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Finn Raynor",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "officiis",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "facere"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 616
    }
  }
}
```
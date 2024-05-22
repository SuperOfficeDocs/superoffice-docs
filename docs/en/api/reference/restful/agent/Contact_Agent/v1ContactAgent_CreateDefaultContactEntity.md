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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 14,
  "Name": "Parker LLC",
  "Department": "",
  "OrgNr": "1229166",
  "Number1": "895450",
  "Number2": "532612",
  "UpdatedDate": "1997-12-12T12:57:33.461855+01:00",
  "CreatedDate": "2008-09-12T12:57:33.461855+02:00",
  "Emails": [
    {
      "Value": "ullam",
      "StrippedValue": "illo",
      "Description": "Face to face demand-driven encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "illo",
      "Description": "Face to face demand-driven encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 485,
      "Name": "Harvey-Monahan",
      "ToolTip": "Iusto quos quia non accusantium saepe et.",
      "Deleted": true,
      "Rank": 79,
      "Type": "incidunt",
      "ColorBlock": 41,
      "IconHint": "ducimus",
      "Selected": false,
      "LastChanged": "2001-08-22T12:57:33.461855+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "provident",
      "Hidden": false,
      "FullName": "Adriana Kautzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 13
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "vel",
      "Description": "Visionary systemic encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 338
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "vel",
      "Description": "Visionary systemic encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 338
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vitae",
      "StrippedValue": "ut",
      "Description": "Seamless discrete open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 757
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "ut",
      "Description": "Seamless discrete open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 757
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eligendi",
      "StrippedValue": "autem",
      "Description": "Function-based neutral database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 963
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "autem",
      "Description": "Function-based neutral database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 963
        }
      }
    }
  ],
  "Description": "Innovative exuding system engine",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 226,
      "Mrmrs": "alias",
      "Firstname": "Elmira",
      "Lastname": "Gleichner",
      "MiddleName": "McKenzie-Beer",
      "Title": "molestiae",
      "Description": "Front-line scalable standardization",
      "Email": "zachery.herman@johnson.info",
      "FullName": "Prof. Lydia Baumbach",
      "DirectPhone": "029-701-4666",
      "FormalName": "Beatty Group",
      "CountryId": 852,
      "ContactId": 431,
      "ContactName": "Nitzsche, Schimmel and Ullrich",
      "Retired": 79,
      "Rank": 576,
      "ActiveInterests": 550,
      "ContactDepartment": "",
      "ContactCountryId": 128,
      "ContactOrgNr": "1354654",
      "FaxPhone": "(744)958-6763 x973",
      "MobilePhone": "1-719-135-0707 x274",
      "ContactPhone": "389-499-3517 x56374",
      "AssociateName": "Cassin Inc and Sons",
      "AssociateId": 86,
      "UsePersonAddress": false,
      "ContactFax": "non",
      "Kanafname": "nostrum",
      "Kanalname": "esse",
      "Post1": "veniam",
      "Post2": "voluptas",
      "Post3": "laudantium",
      "EmailName": "uriel.johnston@hudson.com",
      "ContactFullName": "Dr. Fritz Nienow V",
      "ActiveErpLinks": 846,
      "TicketPriorityId": 75,
      "SupportLanguageId": 238,
      "SupportAssociateId": 317,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "est",
  "Xstop": true,
  "ActiveInterests": 576,
  "GroupId": 548,
  "ActiveStatusMonitorId": 101,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 563,
  "DbiAgentId": 459,
  "DbiLastSyncronized": "2012-09-24T12:57:33.461855+02:00",
  "DbiKey": "architecto",
  "DbiLastModified": "2014-05-10T12:57:33.461855+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 427,
  "ActiveErpLinks": 820,
  "BounceEmails": [
    "darion@raynor.ca",
    "daisha.wintheiser@boyerzboncak.ca"
  ],
  "Domains": [
    "voluptas",
    "ipsa"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Alene Edison Kuhn V",
    "SuperOffice:2": "Carey Conroy"
  },
  "ExtraFields": {
    "ExtraFields1": "laborum",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 853
    }
  }
}
```
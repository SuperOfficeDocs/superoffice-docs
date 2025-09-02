---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
content_type: reference
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
```


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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 581,
  "Name": "Jaskolski-Cartwright",
  "Department": "",
  "OrgNr": "1308867",
  "Number1": "1379308",
  "Number2": "516450",
  "UpdatedDate": "2024-02-02T03:46:54.5195154+01:00",
  "CreatedDate": "2007-12-26T03:46:54.5195154+01:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "voluptatibus",
      "Description": "Centralized mobile frame",
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
      "StrippedValue": "voluptatibus",
      "Description": "Centralized mobile frame",
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
  "Interests": [
    {
      "Id": 886,
      "Name": "Lemke, Bednar and Effertz",
      "ToolTip": "Repellat ullam tempora commodi et rerum quia sunt.",
      "Deleted": true,
      "Rank": 123,
      "Type": "debitis",
      "ColorBlock": 783,
      "IconHint": "veritatis",
      "Selected": false,
      "LastChanged": "2022-11-26T03:46:54.5195154+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Lucius Daugherty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "error",
      "StrippedValue": "voluptas",
      "Description": "Total value-added paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "voluptas",
      "Description": "Total value-added paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "debitis",
      "Description": "Horizontal coherent instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "debitis",
      "Description": "Horizontal coherent instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "corporis",
      "Description": "Assimilated systemic product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 949
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "corporis",
      "Description": "Assimilated systemic product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 949
        }
      }
    }
  ],
  "Description": "Front-line background hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "atque",
      "PersonId": 91,
      "Mrmrs": "fugiat",
      "Firstname": "Ottis",
      "Lastname": "Hills",
      "MiddleName": "Brakus-McClure",
      "Title": "ex",
      "Description": "Exclusive multi-state hierarchy",
      "Email": "litzy@greenholttremblay.info",
      "FullName": "Leif Cartwright",
      "DirectPhone": "(638)098-2899 x96785",
      "FormalName": "Ondricka, Cronin and Rogahn",
      "CountryId": 980,
      "ContactId": 128,
      "ContactName": "Baumbach LLC",
      "Retired": 342,
      "Rank": 974,
      "ActiveInterests": 361,
      "ContactDepartment": "",
      "ContactCountryId": 101,
      "ContactOrgNr": "1296138",
      "FaxPhone": "445.019.0634",
      "MobilePhone": "1-625-106-8068 x923",
      "ContactPhone": "1-443-519-4857 x1424",
      "AssociateName": "Ruecker-Parker",
      "AssociateId": 938,
      "UsePersonAddress": true,
      "ContactFax": "ipsum",
      "Kanafname": "repellendus",
      "Kanalname": "neque",
      "Post1": "perspiciatis",
      "Post2": "et",
      "Post3": "ab",
      "EmailName": "isidro.luettgen@vandervort.name",
      "ContactFullName": "Nettie Powlowski",
      "ActiveErpLinks": 937,
      "TicketPriorityId": 297,
      "SupportLanguageId": 698,
      "SupportAssociateId": 823,
      "CategoryName": "VIP Customer",
      "PersonNumber": "965804",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 750
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 951,
  "GroupId": 201,
  "ActiveStatusMonitorId": 776,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 704,
  "DbiAgentId": 74,
  "DbiLastSyncronized": "2016-04-07T03:46:54.5195154+02:00",
  "DbiKey": "pariatur",
  "DbiLastModified": "2007-04-11T03:46:54.5195154+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 830,
  "ActiveErpLinks": 364,
  "BounceEmails": [
    "jordane@block.co.uk",
    "coy@dach.name"
  ],
  "Domains": [
    "atque",
    "eligendi"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Justyn Weimann",
    "SuperOffice:2": "Ms. Mable Xzavier Kling"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "doloremque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 908
    }
  }
}
```
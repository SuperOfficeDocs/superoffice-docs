---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 851
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 290,
  "Name": "Metz-Cummings",
  "Department": "",
  "OrgNr": "1323611",
  "Number1": "489181",
  "Number2": "940614",
  "UpdatedDate": "2025-04-14T03:41:53.2776196+02:00",
  "CreatedDate": "2008-10-09T03:41:53.2776196+02:00",
  "Emails": [
    {
      "Value": "laudantium",
      "StrippedValue": "dolor",
      "Description": "Organic impactful matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 970
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "dolor",
      "Description": "Organic impactful matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 970
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 889,
      "Name": "Daniel, Sipes and Willms",
      "ToolTip": "Doloribus facilis.",
      "Deleted": true,
      "Rank": 124,
      "Type": "et",
      "ColorBlock": 695,
      "IconHint": "eveniet",
      "Selected": false,
      "LastChanged": "2011-01-19T03:41:53.2776196+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "atque",
      "StyleHint": "animi",
      "Hidden": false,
      "FullName": "Dr. Meaghan Homenick DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 604
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eum",
      "StrippedValue": "corrupti",
      "Description": "Up-sized explicit neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "corrupti",
      "Description": "Up-sized explicit neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolor",
      "StrippedValue": "alias",
      "Description": "Down-sized client-driven architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 531
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "alias",
      "Description": "Down-sized client-driven architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 531
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "saepe",
      "StrippedValue": "sed",
      "Description": "Synchronised multimedia success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "sed",
      "Description": "Synchronised multimedia success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    }
  ],
  "Description": "Function-based regional product",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 441,
      "Mrmrs": "cum",
      "Firstname": "Tod",
      "Lastname": "Feil",
      "MiddleName": "Kuhlman, Schuster and Grant",
      "Title": "sit",
      "Description": "Extended zero administration capacity",
      "Email": "emery@haley.ca",
      "FullName": "Dorothy Zieme",
      "DirectPhone": "(798)158-7889 x266",
      "FormalName": "Rutherford-Kuhlman",
      "CountryId": 732,
      "ContactId": 557,
      "ContactName": "Klein LLC",
      "Retired": 493,
      "Rank": 708,
      "ActiveInterests": 86,
      "ContactDepartment": "",
      "ContactCountryId": 666,
      "ContactOrgNr": "1717546",
      "FaxPhone": "(461)267-7098 x5018",
      "MobilePhone": "474.788.9923 x71157",
      "ContactPhone": "(882)562-9982",
      "AssociateName": "Sanford-Koch",
      "AssociateId": 859,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "debitis",
      "Kanalname": "suscipit",
      "Post1": "inventore",
      "Post2": "quas",
      "Post3": "quo",
      "EmailName": "marcus@erdman.info",
      "ContactFullName": "Pedro Waelchi DVM",
      "ActiveErpLinks": 139,
      "TicketPriorityId": 300,
      "SupportLanguageId": 891,
      "SupportAssociateId": 988,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1345089",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": true,
  "ActiveInterests": 158,
  "GroupId": 193,
  "ActiveStatusMonitorId": 937,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 596,
  "DbiAgentId": 123,
  "DbiLastSyncronized": "2013-05-25T03:41:53.2776196+02:00",
  "DbiKey": "consequatur",
  "DbiLastModified": "2016-01-07T03:41:53.2776196+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 596,
  "ActiveErpLinks": 833,
  "BounceEmails": [
    "amos.marvin@wisozkhyatt.info",
    "andrew@bradtke.co.uk"
  ],
  "Domains": [
    "sequi",
    "qui"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Miss Daisy Dibbert"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 321
    }
  }
}
```
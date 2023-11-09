---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 545
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 91,
  "Name": "Nolan Group",
  "Department": "",
  "OrgNr": "838574",
  "Number1": "753748",
  "Number2": "1905233",
  "UpdatedDate": "2015-04-16T11:06:34.1591606+02:00",
  "CreatedDate": "2006-09-19T11:06:34.1591606+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "suscipit",
      "Description": "Proactive grid-enabled policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 408
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "suscipit",
      "Description": "Proactive grid-enabled policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 408
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 7,
      "Name": "Cummerata, Luettgen and Towne",
      "ToolTip": "Et atque explicabo necessitatibus ipsum dolore saepe.",
      "Deleted": true,
      "Rank": 933,
      "Type": "quasi",
      "ColorBlock": 29,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2009-09-14T11:06:34.1591606+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "accusamus",
      "StyleHint": "beatae",
      "Hidden": true,
      "FullName": "Idell Ledner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 951
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "velit",
      "Description": "Centralized attitude-oriented paradigm",
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
      "Value": "qui",
      "StrippedValue": "velit",
      "Description": "Centralized attitude-oriented paradigm",
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
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "vitae",
      "Description": "Mandatory 24 hour budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "vitae",
      "Description": "Mandatory 24 hour budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "deserunt",
      "StrippedValue": "ut",
      "Description": "Networked coherent model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "ut",
      "Description": "Networked coherent model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "Description": "Devolved high-level installation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quis",
      "PersonId": 354,
      "Mrmrs": "nam",
      "Firstname": "Colin",
      "Lastname": "Hintz",
      "MiddleName": "Jacobson, McLaughlin and Dooley",
      "Title": "voluptatem",
      "Description": "Ameliorated needs-based artificial intelligence",
      "Email": "annabell@sanford.biz",
      "FullName": "Taya Hodkiewicz Sr.",
      "DirectPhone": "320.326.9451",
      "FormalName": "Keebler-Gottlieb",
      "CountryId": 191,
      "ContactId": 496,
      "ContactName": "Ortiz Group",
      "Retired": 630,
      "Rank": 231,
      "ActiveInterests": 788,
      "ContactDepartment": "",
      "ContactCountryId": 776,
      "ContactOrgNr": "1205276",
      "FaxPhone": "119-837-8956 x110",
      "MobilePhone": "(031)316-9480 x0621",
      "ContactPhone": "1-447-647-4721 x921",
      "AssociateName": "Connelly, Kerluke and Morissette",
      "AssociateId": 523,
      "UsePersonAddress": false,
      "ContactFax": "culpa",
      "Kanafname": "aut",
      "Kanalname": "similique",
      "Post1": "tempore",
      "Post2": "veniam",
      "Post3": "incidunt",
      "EmailName": "monserrat@gulgowski.biz",
      "ContactFullName": "Rashad Friesen",
      "ActiveErpLinks": 901,
      "TicketPriorityId": 263,
      "SupportLanguageId": 715,
      "SupportAssociateId": 175,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ea",
  "Xstop": true,
  "ActiveInterests": 827,
  "GroupId": 530,
  "ActiveStatusMonitorId": 768,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 592,
  "DbiAgentId": 728,
  "DbiLastSyncronized": "2013-07-25T11:06:34.1601668+02:00",
  "DbiKey": "voluptatibus",
  "DbiLastModified": "2002-08-13T11:06:34.1601668+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 813,
  "ActiveErpLinks": 293,
  "BounceEmails": [
    "tony.kerluke@ebert.info",
    "tom.pacocha@klein.com"
  ],
  "Domains": [
    "eius",
    "quasi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2013936907",
    "SuperOffice:2": "Stuart Kirlin IV"
  },
  "ExtraFields": {
    "ExtraFields1": "praesentium",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "blanditiis",
    "CustomFields2": "expedita"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 43
    }
  }
}
```
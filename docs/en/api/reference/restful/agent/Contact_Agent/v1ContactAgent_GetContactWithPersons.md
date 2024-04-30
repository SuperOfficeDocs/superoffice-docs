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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 430
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 791,
  "Name": "Zieme, Dickinson and Stoltenberg",
  "Department": "",
  "OrgNr": "1034205",
  "Number1": "603479",
  "Number2": "1408609",
  "UpdatedDate": "2013-04-18T11:16:08.8972183+02:00",
  "CreatedDate": "2014-07-03T11:16:08.8972183+02:00",
  "Emails": [
    {
      "Value": "minima",
      "StrippedValue": "dolorem",
      "Description": "Decentralized incremental policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "dolorem",
      "Description": "Decentralized incremental policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 806,
      "Name": "VonRueden, Zulauf and Mann",
      "ToolTip": "Et impedit ut ut sint esse qui distinctio.",
      "Deleted": true,
      "Rank": 939,
      "Type": "veritatis",
      "ColorBlock": 82,
      "IconHint": "explicabo",
      "Selected": false,
      "LastChanged": "2013-08-08T11:16:08.8972183+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Nick Ullrich DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "laudantium",
      "StrippedValue": "expedita",
      "Description": "Compatible disintermediate solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "expedita",
      "Description": "Compatible disintermediate solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quam",
      "StrippedValue": "distinctio",
      "Description": "Horizontal mission-critical approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "distinctio",
      "Description": "Horizontal mission-critical approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nesciunt",
      "StrippedValue": "eos",
      "Description": "Innovative responsive protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "eos",
      "Description": "Innovative responsive protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    }
  ],
  "Description": "Innovative directional workforce",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 289,
      "Mrmrs": "non",
      "Firstname": "Susana",
      "Lastname": "Swaniawski",
      "MiddleName": "Berge LLC",
      "Title": "eum",
      "Description": "Total even-keeled frame",
      "Email": "kale_rice@veumdaniel.co.uk",
      "FullName": "Reed Hane",
      "DirectPhone": "1-589-477-4609 x753",
      "FormalName": "Leannon Group",
      "CountryId": 686,
      "ContactId": 343,
      "ContactName": "Shields, Nolan and Feeney",
      "Retired": 828,
      "Rank": 491,
      "ActiveInterests": 802,
      "ContactDepartment": "",
      "ContactCountryId": 878,
      "ContactOrgNr": "1427913",
      "FaxPhone": "178.578.9572",
      "MobilePhone": "145.581.6266",
      "ContactPhone": "821.084.4182",
      "AssociateName": "Kiehn-Ernser",
      "AssociateId": 564,
      "UsePersonAddress": true,
      "ContactFax": "porro",
      "Kanafname": "qui",
      "Kanalname": "dolore",
      "Post1": "esse",
      "Post2": "ratione",
      "Post3": "qui",
      "EmailName": "darryl@mann.co.uk",
      "ContactFullName": "D'angelo Wyman",
      "ActiveErpLinks": 131,
      "TicketPriorityId": 576,
      "SupportLanguageId": 370,
      "SupportAssociateId": 495,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 43
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "accusantium",
  "Xstop": false,
  "ActiveInterests": 819,
  "GroupId": 914,
  "ActiveStatusMonitorId": 797,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 281,
  "DbiAgentId": 807,
  "DbiLastSyncronized": "2014-07-04T11:16:08.8972183+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2020-02-06T11:16:08.8972183+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 464,
  "ActiveErpLinks": 98,
  "BounceEmails": [
    "geoffrey_kohler@leannon.info",
    "teagan_towne@ondricka.co.uk"
  ],
  "Domains": [
    "voluptas",
    "voluptas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Nina O'Hara",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 168
    }
  }
}
```
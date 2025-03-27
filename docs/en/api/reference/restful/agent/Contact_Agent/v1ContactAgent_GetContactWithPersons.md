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
  "ContactId": 35
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 769,
  "Name": "Stark LLC",
  "Department": "",
  "OrgNr": "861104",
  "Number1": "683700",
  "Number2": "825093",
  "UpdatedDate": "2001-05-29T02:38:21.0420796+02:00",
  "CreatedDate": "2019-04-02T02:38:21.0420796+02:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "amet",
      "Description": "De-engineered static forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "amet",
      "Description": "De-engineered static forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 310,
      "Name": "Renner, Kling and Erdman",
      "ToolTip": "Quia tenetur dolorem quia est placeat impedit voluptatibus.",
      "Deleted": true,
      "Rank": 960,
      "Type": "modi",
      "ColorBlock": 430,
      "IconHint": "nostrum",
      "Selected": true,
      "LastChanged": "2024-01-13T02:38:21.0420796+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "natus",
      "StyleHint": "minus",
      "Hidden": false,
      "FullName": "Mr. Daryl Buford Hills V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "inventore",
      "Description": "Business-focused user-facing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 734
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "inventore",
      "Description": "Business-focused user-facing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 734
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "dolorum",
      "Description": "Upgradable multi-state database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 817
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "dolorum",
      "Description": "Upgradable multi-state database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 817
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "reiciendis",
      "StrippedValue": "accusamus",
      "Description": "Focused object-oriented analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 719
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "accusamus",
      "Description": "Focused object-oriented analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 719
        }
      }
    }
  ],
  "Description": "Future-proofed 4th generation projection",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 322,
      "Mrmrs": "vel",
      "Firstname": "Kendra",
      "Lastname": "Yost",
      "MiddleName": "Mueller, Nicolas and Stanton",
      "Title": "officiis",
      "Description": "Enterprise-wide tangible hub",
      "Email": "dannie_carroll@lind.ca",
      "FullName": "Gianni Zaria Sporer II",
      "DirectPhone": "1-928-294-8551 x75876",
      "FormalName": "Cassin, Runte and Cartwright",
      "CountryId": 933,
      "ContactId": 678,
      "ContactName": "Miller, Weber and Von",
      "Retired": 290,
      "Rank": 519,
      "ActiveInterests": 968,
      "ContactDepartment": "",
      "ContactCountryId": 999,
      "ContactOrgNr": "584987",
      "FaxPhone": "(472)841-8911 x7574",
      "MobilePhone": "1-318-014-8946 x04219",
      "ContactPhone": "(466)641-5433 x0754",
      "AssociateName": "Stracke-Mraz",
      "AssociateId": 363,
      "UsePersonAddress": false,
      "ContactFax": "sequi",
      "Kanafname": "aut",
      "Kanalname": "quo",
      "Post1": "blanditiis",
      "Post2": "fugit",
      "Post3": "qui",
      "EmailName": "edmund@volkmankoss.info",
      "ContactFullName": "Jevon Dickens",
      "ActiveErpLinks": 672,
      "TicketPriorityId": 241,
      "SupportLanguageId": 380,
      "SupportAssociateId": 858,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1668722",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "id",
  "Xstop": false,
  "ActiveInterests": 307,
  "GroupId": 598,
  "ActiveStatusMonitorId": 943,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 918,
  "DbiAgentId": 844,
  "DbiLastSyncronized": "2016-09-11T02:38:21.0420796+02:00",
  "DbiKey": "facilis",
  "DbiLastModified": "2019-10-01T02:38:21.0420796+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 133,
  "ActiveErpLinks": 553,
  "BounceEmails": [
    "santiago.jakubowski@collins.co.uk",
    "ewell_hirthe@faheycummerata.ca"
  ],
  "Domains": [
    "ipsum",
    "atque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ladarius McClure",
    "SuperOffice:2": "Dr. Herminia Stroman Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "illo"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 286
    }
  }
}
```
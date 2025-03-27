---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 888,
  "Name": "Cassin, Yost and Fritsch",
  "Department": "",
  "OrgNr": "54384",
  "Number1": "784454",
  "Number2": "787551",
  "UpdatedDate": "2003-10-16T02:38:21.0577061+02:00",
  "CreatedDate": "2019-04-06T02:38:21.0577061+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "maiores",
      "Description": "Persistent multimedia circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 798
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "maiores",
      "Description": "Persistent multimedia circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 798
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 25,
      "Name": "Schulist Inc and Sons",
      "ToolTip": "Sit voluptatem debitis minima et et est.",
      "Deleted": false,
      "Rank": 291,
      "Type": "tempora",
      "ColorBlock": 949,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2023-09-22T02:38:21.0577061+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "corrupti",
      "Hidden": true,
      "FullName": "Mrs. Edmond Nona Morissette MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 249
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "itaque",
      "StrippedValue": "et",
      "Description": "Polarised uniform contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 800
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "et",
      "Description": "Polarised uniform contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 800
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "beatae",
      "StrippedValue": "fugiat",
      "Description": "Open-source non-volatile complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "fugiat",
      "Description": "Open-source non-volatile complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ullam",
      "StrippedValue": "eveniet",
      "Description": "Virtual cohesive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "eveniet",
      "Description": "Virtual cohesive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "Description": "Front-line even-keeled portal",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "culpa",
      "PersonId": 497,
      "Mrmrs": "ut",
      "Firstname": "Rigoberto",
      "Lastname": "Kohler",
      "MiddleName": "Pouros LLC",
      "Title": "sunt",
      "Description": "Switchable uniform customer loyalty",
      "Email": "eddie.langworth@beahanfeeney.com",
      "FullName": "Dr. Junior Boyer IV",
      "DirectPhone": "790-213-1503 x07403",
      "FormalName": "O'Connell Inc and Sons",
      "CountryId": 967,
      "ContactId": 691,
      "ContactName": "Padberg-Leannon",
      "Retired": 668,
      "Rank": 580,
      "ActiveInterests": 506,
      "ContactDepartment": "",
      "ContactCountryId": 179,
      "ContactOrgNr": "573394",
      "FaxPhone": "380-694-3904",
      "MobilePhone": "1-718-334-3113 x4000",
      "ContactPhone": "1-838-390-6041",
      "AssociateName": "Schowalter, Bradtke and Stokes",
      "AssociateId": 200,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "quibusdam",
      "Kanalname": "est",
      "Post1": "ratione",
      "Post2": "dolorem",
      "Post3": "aut",
      "EmailName": "kristoffer_bernier@carroll.co.uk",
      "ContactFullName": "Emil Hyatt",
      "ActiveErpLinks": 290,
      "TicketPriorityId": 556,
      "SupportLanguageId": 293,
      "SupportAssociateId": 725,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1022249",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 679
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 6,
  "GroupId": 959,
  "ActiveStatusMonitorId": 181,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 239,
  "DbiAgentId": 701,
  "DbiLastSyncronized": "2019-09-01T02:38:21.0577061+02:00",
  "DbiKey": "dolores",
  "DbiLastModified": "1998-09-18T02:38:21.0577061+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 763,
  "ActiveErpLinks": 799,
  "BounceEmails": [
    "kay.barton@bergnaumwehner.com",
    "larissa@heathcote.ca"
  ],
  "Domains": [
    "magni",
    "maxime"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Fay Kunze",
    "SuperOffice:2": "Mr. Leonora Nienow III"
  },
  "ExtraFields": {
    "ExtraFields1": "commodi",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 970
    }
  }
}
```
---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=True
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

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 03 Sep 2021 10:18:00 G9T

{
  "ContactId": 485,
  "Name": "King LLC",
  "Department": "",
  "OrgNr": "1343526",
  "Number1": "1147406",
  "Number2": "1135825",
  "UpdatedDate": "2021-09-03T10:18:00.3011917+02:00",
  "CreatedDate": "2011-10-15T10:18:00.3011917+02:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "eum",
      "Description": "Compatible heuristic model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "eum",
      "Description": "Compatible heuristic model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 435,
      "Name": "Conn, Casper and Strosin",
      "ToolTip": "Perspiciatis corrupti cum consequatur eligendi esse veritatis commodi.",
      "Deleted": false,
      "Rank": 481,
      "Type": "aut",
      "ColorBlock": 90,
      "IconHint": "aut",
      "Selected": true,
      "LastChanged": "2000-09-26T10:18:00.3011917+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "ex",
      "Hidden": true,
      "FullName": "Steve Breitenberg",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 60
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "rerum",
      "Description": "Cross-platform 3rd generation focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 564
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "rerum",
      "Description": "Cross-platform 3rd generation focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 564
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "tenetur",
      "StrippedValue": "et",
      "Description": "Fully-configurable non-volatile utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "et",
      "Description": "Fully-configurable non-volatile utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ab",
      "StrippedValue": "ad",
      "Description": "Compatible optimal website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 709
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "ad",
      "Description": "Compatible optimal website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 709
        }
      }
    }
  ],
  "Description": "User-centric exuding conglomeration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "recusandae",
      "PersonId": 720,
      "Mrmrs": "maxime",
      "Firstname": "Ricky",
      "Lastname": "Gleichner",
      "MiddleName": "Hoppe Group",
      "Title": "officiis",
      "Description": "Programmable non-volatile application",
      "Email": "michale.nitzsche@hayes.ca",
      "FullName": "Ariel Torp",
      "DirectPhone": "830.425.8159 x88478",
      "FormalName": "Bogisich-Ledner",
      "CountryId": 397,
      "ContactId": 463,
      "ContactName": "Ondricka LLC",
      "Retired": 373,
      "Rank": 42,
      "ActiveInterests": 870,
      "ContactDepartment": "",
      "ContactCountryId": 594,
      "ContactOrgNr": "859431",
      "FaxPhone": "1-798-947-9760",
      "MobilePhone": "1-863-735-4723",
      "ContactPhone": "728.233.2244",
      "AssociateName": "Cronin, Schuppe and Dach",
      "AssociateId": 637,
      "UsePersonAddress": true,
      "ContactFax": "laboriosam",
      "Kanafname": "est",
      "Kanalname": "est",
      "Post1": "suscipit",
      "Post2": "illo",
      "Post3": "voluptas",
      "EmailName": "courtney@gibsonwalsh.us",
      "ContactFullName": "Dr. Hattie Elenora Roob V",
      "ActiveErpLinks": 447,
      "TicketPriorityId": 227,
      "SupportLanguageId": 403,
      "SupportAssociateId": 425,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 555
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 282,
  "GroupId": 802,
  "ActiveStatusMonitorId": 329,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 156,
  "DbiAgentId": 96,
  "DbiLastSyncronized": "2016-04-25T10:18:00.3011917+02:00",
  "DbiKey": "incidunt",
  "DbiLastModified": "2024-08-13T10:18:00.3011917+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 175,
  "ActiveErpLinks": 581,
  "BounceEmails": [
    "eveline@homenick.biz",
    "shanel.gulgowski@lakin.biz"
  ],
  "Domains": [
    "accusantium",
    "nisi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Al Kautzer",
    "SuperOffice:2": "Joaquin Schumm"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 762
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
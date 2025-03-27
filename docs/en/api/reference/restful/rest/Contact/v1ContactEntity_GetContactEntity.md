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
GET /api/v1/Contact/{id}?fk=False
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
Last-Modified: Tue, 21 Sep 2021 02:38:25 G9T

{
  "ContactId": 164,
  "Name": "Bradtke, Donnelly and Lueilwitz",
  "Department": "",
  "OrgNr": "628870",
  "Number1": "741369",
  "Number2": "1271197",
  "UpdatedDate": "2021-09-21T02:38:25.979826+02:00",
  "CreatedDate": "1999-04-10T02:38:25.979826+02:00",
  "Emails": [
    {
      "Value": "molestias",
      "StrippedValue": "vero",
      "Description": "Team-oriented directional monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 581
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "vero",
      "Description": "Team-oriented directional monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 581
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 578,
      "Name": "Denesik, Kreiger and Kreiger",
      "ToolTip": "Magnam et consequatur ut rem impedit eveniet aut.",
      "Deleted": true,
      "Rank": 430,
      "Type": "cum",
      "ColorBlock": 375,
      "IconHint": "perferendis",
      "Selected": false,
      "LastChanged": "2006-01-28T02:38:25.979826+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "odio",
      "Hidden": false,
      "FullName": "Abner DuBuque",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 684
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "est",
      "Description": "Multi-layered 24 hour benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "est",
      "Description": "Multi-layered 24 hour benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 300
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "officia",
      "StrippedValue": "culpa",
      "Description": "Optimized zero defect infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "culpa",
      "Description": "Optimized zero defect infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "tenetur",
      "Description": "Programmable 24 hour service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "tenetur",
      "Description": "Programmable 24 hour service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "Description": "Stand-alone 4th generation focus group",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "saepe",
      "PersonId": 721,
      "Mrmrs": "repellendus",
      "Firstname": "Jana",
      "Lastname": "Russel",
      "MiddleName": "Abbott-Schroeder",
      "Title": "quidem",
      "Description": "Automated attitude-oriented knowledge user",
      "Email": "austyn@schadendoyle.co.uk",
      "FullName": "Misty Dedric Brown PhD",
      "DirectPhone": "200-520-5617 x70878",
      "FormalName": "Nolan, Bailey and Torphy",
      "CountryId": 943,
      "ContactId": 552,
      "ContactName": "Boyer Group",
      "Retired": 809,
      "Rank": 100,
      "ActiveInterests": 701,
      "ContactDepartment": "",
      "ContactCountryId": 612,
      "ContactOrgNr": "661707",
      "FaxPhone": "(785)823-3395 x052",
      "MobilePhone": "1-524-945-4605 x21007",
      "ContactPhone": "675.705.7068 x04248",
      "AssociateName": "Welch, Rau and Boyle",
      "AssociateId": 961,
      "UsePersonAddress": false,
      "ContactFax": "consequuntur",
      "Kanafname": "magni",
      "Kanalname": "necessitatibus",
      "Post1": "rem",
      "Post2": "et",
      "Post3": "dolores",
      "EmailName": "scotty@little.co.uk",
      "ContactFullName": "Wilford Paucek",
      "ActiveErpLinks": 797,
      "TicketPriorityId": 498,
      "SupportLanguageId": 148,
      "SupportAssociateId": 398,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1310875",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 856,
  "GroupId": 777,
  "ActiveStatusMonitorId": 844,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 600,
  "DbiAgentId": 707,
  "DbiLastSyncronized": "2016-09-04T02:38:25.979826+02:00",
  "DbiKey": "commodi",
  "DbiLastModified": "2023-05-30T02:38:25.979826+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 879,
  "ActiveErpLinks": 557,
  "BounceEmails": [
    "jannie.legros@stark.com",
    "taylor.feest@kovacekwuckert.uk"
  ],
  "Domains": [
    "non",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Maeve Karolann Bosco I",
    "SuperOffice:2": "2145885753"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 24
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
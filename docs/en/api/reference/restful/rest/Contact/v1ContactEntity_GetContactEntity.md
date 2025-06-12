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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 02 Feb 2021 17:54:08 G2T

{
  "ContactId": 431,
  "Name": "Bauch LLC",
  "Department": "",
  "OrgNr": "987819",
  "Number1": "895389",
  "Number2": "1229025",
  "UpdatedDate": "2021-02-02T17:54:08.0855828+01:00",
  "CreatedDate": "2024-10-27T17:54:08.0855828+01:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "harum",
      "Description": "Visionary global framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 714
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "harum",
      "Description": "Visionary global framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 714
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 99,
      "Name": "Schimmel, Roberts and Homenick",
      "ToolTip": "Accusamus aut culpa eveniet voluptatem soluta laudantium maxime.",
      "Deleted": false,
      "Rank": 431,
      "Type": "animi",
      "ColorBlock": 338,
      "IconHint": "illum",
      "Selected": true,
      "LastChanged": "2002-07-08T17:54:08.0855828+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "iure",
      "Hidden": true,
      "FullName": "Maybelle Graham",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "reiciendis",
      "StrippedValue": "est",
      "Description": "Team-oriented optimizing application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 588
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "est",
      "Description": "Team-oriented optimizing application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 588
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sunt",
      "StrippedValue": "quo",
      "Description": "Streamlined fault-tolerant array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 415
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "quo",
      "Description": "Streamlined fault-tolerant array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 415
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "in",
      "StrippedValue": "vel",
      "Description": "Realigned interactive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 982
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "vel",
      "Description": "Realigned interactive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 982
        }
      }
    }
  ],
  "Description": "Virtual demand-driven internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "veniam",
      "PersonId": 209,
      "Mrmrs": "quo",
      "Firstname": "Darlene",
      "Lastname": "Bartell",
      "MiddleName": "Torphy Inc and Sons",
      "Title": "tempora",
      "Description": "Profit-focused zero defect throughput",
      "Email": "zoey@hoegerstracke.com",
      "FullName": "Lysanne Schultz",
      "DirectPhone": "1-954-986-1037",
      "FormalName": "Christiansen Inc and Sons",
      "CountryId": 863,
      "ContactId": 353,
      "ContactName": "Koch-Zulauf",
      "Retired": 26,
      "Rank": 452,
      "ActiveInterests": 67,
      "ContactDepartment": "",
      "ContactCountryId": 251,
      "ContactOrgNr": "501862",
      "FaxPhone": "1-917-366-2036",
      "MobilePhone": "(857)761-3541 x2470",
      "ContactPhone": "1-918-141-0170 x685",
      "AssociateName": "Mann Inc and Sons",
      "AssociateId": 453,
      "UsePersonAddress": false,
      "ContactFax": "asperiores",
      "Kanafname": "beatae",
      "Kanalname": "quo",
      "Post1": "omnis",
      "Post2": "soluta",
      "Post3": "nemo",
      "EmailName": "mariane_glover@turcotteadams.com",
      "ContactFullName": "Dr. Darian Ratke",
      "ActiveErpLinks": 726,
      "TicketPriorityId": 902,
      "SupportLanguageId": 375,
      "SupportAssociateId": 200,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1107477",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 435
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eveniet",
  "Xstop": false,
  "ActiveInterests": 117,
  "GroupId": 556,
  "ActiveStatusMonitorId": 475,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 935,
  "DbiAgentId": 319,
  "DbiLastSyncronized": "2009-01-13T17:54:08.0855828+01:00",
  "DbiKey": "cupiditate",
  "DbiLastModified": "2011-07-18T17:54:08.0855828+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 970,
  "ActiveErpLinks": 303,
  "BounceEmails": [
    "sven_lind@pfannerstill.biz",
    "kelton@cremin.biz"
  ],
  "Domains": [
    "in",
    "ab"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Madyson Koch",
    "SuperOffice:2": "1684058970"
  },
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "accusamus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 640
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
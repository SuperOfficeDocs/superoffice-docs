---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=475
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 92,
  "Name": "Labadie-Schroeder",
  "Department": "",
  "OrgNr": "542489",
  "Number1": "1005016",
  "Number2": "675776",
  "UpdatedDate": "2017-11-19T03:45:23.1704803+01:00",
  "CreatedDate": "2009-01-29T03:45:23.1704803+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "commodi",
      "Description": "Exclusive optimal framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "commodi",
      "Description": "Exclusive optimal framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 645,
      "Name": "Murray, Pfannerstill and Jacobson",
      "ToolTip": "Qui voluptatem reprehenderit.",
      "Deleted": false,
      "Rank": 574,
      "Type": "corporis",
      "ColorBlock": 251,
      "IconHint": "occaecati",
      "Selected": false,
      "LastChanged": "2009-06-13T03:45:23.1704803+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "recusandae",
      "Hidden": true,
      "FullName": "Lavada Bayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 680
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "blanditiis",
      "Description": "Reactive object-oriented emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "blanditiis",
      "Description": "Reactive object-oriented emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolore",
      "StrippedValue": "incidunt",
      "Description": "Organized grid-enabled projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "incidunt",
      "Description": "Organized grid-enabled projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "quam",
      "Description": "Cloned user-facing website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 88
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "quam",
      "Description": "Cloned user-facing website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 88
        }
      }
    }
  ],
  "Description": "Digitized assymetric internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatibus",
      "PersonId": 849,
      "Mrmrs": "dolorum",
      "Firstname": "Janice",
      "Lastname": "Gorczany",
      "MiddleName": "Leuschke LLC",
      "Title": "vero",
      "Description": "User-centric mission-critical extranet",
      "Email": "shania_sporer@kshlerin.uk",
      "FullName": "Hazle Leffler",
      "DirectPhone": "420-631-2212 x155",
      "FormalName": "Hettinger LLC",
      "CountryId": 560,
      "ContactId": 722,
      "ContactName": "Lakin-Ankunding",
      "Retired": 12,
      "Rank": 379,
      "ActiveInterests": 523,
      "ContactDepartment": "",
      "ContactCountryId": 155,
      "ContactOrgNr": "1385173",
      "FaxPhone": "1-459-802-1636",
      "MobilePhone": "1-442-593-1545 x974",
      "ContactPhone": "551-177-0655 x5730",
      "AssociateName": "Schroeder, Waters and Koelpin",
      "AssociateId": 431,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "ut",
      "Kanalname": "adipisci",
      "Post1": "cupiditate",
      "Post2": "est",
      "Post3": "totam",
      "EmailName": "clotilde@wuckertmurray.ca",
      "ContactFullName": "Jessie Waters",
      "ActiveErpLinks": 748,
      "TicketPriorityId": 433,
      "SupportLanguageId": 733,
      "SupportAssociateId": 549,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1204760",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quae",
  "Xstop": false,
  "ActiveInterests": 845,
  "GroupId": 838,
  "ActiveStatusMonitorId": 864,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 60,
  "DbiAgentId": 897,
  "DbiLastSyncronized": "2013-07-12T03:45:23.1704803+02:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2016-10-08T03:45:23.1704803+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 180,
  "ActiveErpLinks": 729,
  "BounceEmails": [
    "tevin.funk@schneider.uk",
    "john_reinger@jones.info"
  ],
  "Domains": [
    "qui",
    "quod"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1461934978"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "nesciunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 407
    }
  }
}
```
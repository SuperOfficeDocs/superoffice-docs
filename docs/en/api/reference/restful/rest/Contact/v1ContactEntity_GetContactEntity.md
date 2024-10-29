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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 12 Aug 2003 13:14:10 G8T

{
  "ContactId": 326,
  "Name": "Hodkiewicz, Homenick and Greenfelder",
  "Department": "",
  "OrgNr": "430736",
  "Number1": "1286971",
  "Number2": "679908",
  "UpdatedDate": "2003-08-12T13:14:10.726658+02:00",
  "CreatedDate": "2005-09-15T13:14:10.726658+02:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "molestiae",
      "Description": "Multi-layered content-based capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 934
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "molestiae",
      "Description": "Multi-layered content-based capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 934
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 514,
      "Name": "Ryan-Johns",
      "ToolTip": "Corrupti dolore expedita dolorem et et voluptatem.",
      "Deleted": false,
      "Rank": 233,
      "Type": "aperiam",
      "ColorBlock": 914,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2014-05-16T13:14:10.726658+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "temporibus",
      "Hidden": false,
      "FullName": "Mrs. Rosemarie Hirthe IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "est",
      "Description": "Optimized incremental ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "est",
      "Description": "Optimized incremental ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eius",
      "StrippedValue": "sunt",
      "Description": "De-engineered demand-driven open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "sunt",
      "Description": "De-engineered demand-driven open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "error",
      "StrippedValue": "dolorum",
      "Description": "Secured tangible function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "dolorum",
      "Description": "Secured tangible function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    }
  ],
  "Description": "Business-focused composite flexibility",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 301,
      "Mrmrs": "consectetur",
      "Firstname": "Vicky",
      "Lastname": "Smitham",
      "MiddleName": "Olson LLC",
      "Title": "nihil",
      "Description": "Open-source 5th generation intranet",
      "Email": "freida.gorczany@block.biz",
      "FullName": "Ahmad White",
      "DirectPhone": "(815)305-1938 x7900",
      "FormalName": "Pouros, Tromp and Leuschke",
      "CountryId": 134,
      "ContactId": 354,
      "ContactName": "Kshlerin Inc and Sons",
      "Retired": 978,
      "Rank": 880,
      "ActiveInterests": 913,
      "ContactDepartment": "",
      "ContactCountryId": 32,
      "ContactOrgNr": "1486676",
      "FaxPhone": "(827)138-2770 x390",
      "MobilePhone": "453.162.7760 x01785",
      "ContactPhone": "675.382.1972 x5219",
      "AssociateName": "Marquardt, Kautzer and Beahan",
      "AssociateId": 755,
      "UsePersonAddress": false,
      "ContactFax": "ad",
      "Kanafname": "nihil",
      "Kanalname": "accusamus",
      "Post1": "dolore",
      "Post2": "et",
      "Post3": "beatae",
      "EmailName": "rhett.kshlerin@strosintowne.com",
      "ContactFullName": "Miss Gage Chance Bahringer",
      "ActiveErpLinks": 562,
      "TicketPriorityId": 168,
      "SupportLanguageId": 921,
      "SupportAssociateId": 164,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 773
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "reiciendis",
  "Xstop": false,
  "ActiveInterests": 785,
  "GroupId": 961,
  "ActiveStatusMonitorId": 121,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 766,
  "DbiAgentId": 822,
  "DbiLastSyncronized": "2009-09-02T13:14:10.726658+02:00",
  "DbiKey": "dolores",
  "DbiLastModified": "2015-08-16T13:14:10.726658+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 678,
  "ActiveErpLinks": 22,
  "BounceEmails": [
    "omari@cummingsbaumbach.uk",
    "bennett_barton@blandahowe.biz"
  ],
  "Domains": [
    "rerum",
    "nam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Felicity Idella Gleason",
    "SuperOffice:2": "659192419"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "atque"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "quod"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 790
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```
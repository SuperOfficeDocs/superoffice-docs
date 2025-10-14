---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
content_type: reference
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

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
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 211
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 859,
  "Name": "Bednar, Mertz and Smith",
  "Department": "",
  "OrgNr": "945393",
  "Number1": "1822076",
  "Number2": "1393878",
  "UpdatedDate": "2024-09-27T03:40:46.436868+02:00",
  "CreatedDate": "2019-11-05T03:40:46.436868+01:00",
  "Emails": [
    {
      "Value": "similique",
      "StrippedValue": "architecto",
      "Description": "Multi-channelled 5th generation array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "architecto",
      "Description": "Multi-channelled 5th generation array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 255,
      "Name": "Stehr-Becker",
      "ToolTip": "Animi ut.",
      "Deleted": false,
      "Rank": 892,
      "Type": "itaque",
      "ColorBlock": 40,
      "IconHint": "eum",
      "Selected": false,
      "LastChanged": "2018-01-29T03:40:46.436868+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "at",
      "Hidden": true,
      "FullName": "Sandra Rempel I",
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
  "Urls": [
    {
      "Value": "placeat",
      "StrippedValue": "ipsa",
      "Description": "Quality-focused empowering paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "ipsa",
      "Description": "Quality-focused empowering paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "odio",
      "StrippedValue": "dicta",
      "Description": "Total static firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "dicta",
      "Description": "Total static firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "saepe",
      "StrippedValue": "ipsum",
      "Description": "Triple-buffered stable capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 383
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "ipsum",
      "Description": "Triple-buffered stable capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 383
        }
      }
    }
  ],
  "Description": "Inverse executive throughput",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quo",
      "PersonId": 98,
      "Mrmrs": "aut",
      "Firstname": "Jett",
      "Lastname": "Cruickshank",
      "MiddleName": "Konopelski Inc and Sons",
      "Title": "dolorem",
      "Description": "Compatible explicit pricing structure",
      "Email": "newton.bashirian@dickens.com",
      "FullName": "Liliana Walsh",
      "DirectPhone": "(836)843-0359 x9897",
      "FormalName": "Nolan, Bogan and Windler",
      "CountryId": 469,
      "ContactId": 64,
      "ContactName": "Berge, Smith and Bogan",
      "Retired": 522,
      "Rank": 681,
      "ActiveInterests": 448,
      "ContactDepartment": "",
      "ContactCountryId": 943,
      "ContactOrgNr": "1359127",
      "FaxPhone": "740.915.6742 x118",
      "MobilePhone": "1-855-008-5401",
      "ContactPhone": "1-684-440-4413 x9634",
      "AssociateName": "Bednar, Mayer and Okuneva",
      "AssociateId": 736,
      "UsePersonAddress": false,
      "ContactFax": "optio",
      "Kanafname": "qui",
      "Kanalname": "mollitia",
      "Post1": "nostrum",
      "Post2": "omnis",
      "Post3": "est",
      "EmailName": "camylle@zboncak.us",
      "ContactFullName": "Lola Donavon Goyette IV",
      "ActiveErpLinks": 823,
      "TicketPriorityId": 762,
      "SupportLanguageId": 519,
      "SupportAssociateId": 84,
      "CategoryName": "VIP Customer",
      "PersonNumber": "106432",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 656
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "maiores",
  "Xstop": false,
  "ActiveInterests": 646,
  "GroupId": 475,
  "ActiveStatusMonitorId": 180,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 374,
  "DbiAgentId": 311,
  "DbiLastSyncronized": "2023-02-11T03:40:46.4524939+01:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2005-02-13T03:40:46.4524939+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 725,
  "ActiveErpLinks": 384,
  "BounceEmails": [
    "webster@christiansen.info",
    "javon_ernser@kulas.us"
  ],
  "Domains": [
    "facere",
    "optio"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "1732025615",
    "SuperOffice:2": "1708841328"
  },
  "ExtraFields": {
    "ExtraFields1": "nulla",
    "ExtraFields2": "excepturi"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "aliquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 815
    }
  }
}
```
---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The identifier of the ContactEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=466
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 879,
  "Name": "Sauer-Streich",
  "Department": "",
  "OrgNr": "839550",
  "Number1": "1090953",
  "Number2": "641694",
  "UpdatedDate": "2002-07-14T03:40:46.3743647+02:00",
  "CreatedDate": "2018-12-07T03:40:46.3743647+01:00",
  "Emails": [
    {
      "Value": "quis",
      "StrippedValue": "maiores",
      "Description": "Streamlined intangible hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "maiores",
      "Description": "Streamlined intangible hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 679,
      "Name": "Brekke-Farrell",
      "ToolTip": "Accusantium officia nesciunt rerum rerum necessitatibus.",
      "Deleted": false,
      "Rank": 663,
      "Type": "eius",
      "ColorBlock": 642,
      "IconHint": "enim",
      "Selected": true,
      "LastChanged": "2014-06-07T03:40:46.3743647+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "ipsam",
      "Hidden": true,
      "FullName": "Karley O'Keefe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "mollitia",
      "Description": "Robust grid-enabled extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 356
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "mollitia",
      "Description": "Robust grid-enabled extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 356
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sunt",
      "StrippedValue": "voluptas",
      "Description": "Up-sized real-time interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "voluptas",
      "Description": "Up-sized real-time interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequuntur",
      "StrippedValue": "harum",
      "Description": "Re-engineered motivating installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 141
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "harum",
      "Description": "Re-engineered motivating installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 141
        }
      }
    }
  ],
  "Description": "Upgradable directional website",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vero",
      "PersonId": 693,
      "Mrmrs": "voluptas",
      "Firstname": "Marlen",
      "Lastname": "Kiehn",
      "MiddleName": "Spencer, Mueller and Price",
      "Title": "sapiente",
      "Description": "Multi-layered assymetric architecture",
      "Email": "edythe.leffler@harriscrona.us",
      "FullName": "Jazmin Ahmed Konopelski DDS",
      "DirectPhone": "1-192-939-0410",
      "FormalName": "Hagenes Group",
      "CountryId": 423,
      "ContactId": 51,
      "ContactName": "Lindgren-Lubowitz",
      "Retired": 325,
      "Rank": 226,
      "ActiveInterests": 643,
      "ContactDepartment": "",
      "ContactCountryId": 328,
      "ContactOrgNr": "879860",
      "FaxPhone": "958.325.8884 x499",
      "MobilePhone": "745.451.4540",
      "ContactPhone": "1-334-084-6219 x4707",
      "AssociateName": "Labadie, Streich and Champlin",
      "AssociateId": 636,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "error",
      "Kanalname": "ducimus",
      "Post1": "magni",
      "Post2": "et",
      "Post3": "neque",
      "EmailName": "donato@upton.uk",
      "ContactFullName": "Mr. Corbin Shana Schumm",
      "ActiveErpLinks": 991,
      "TicketPriorityId": 946,
      "SupportLanguageId": 353,
      "SupportAssociateId": 212,
      "CategoryName": "VIP Customer",
      "PersonNumber": "482473",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 589
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "cum",
  "Xstop": false,
  "ActiveInterests": 229,
  "GroupId": 200,
  "ActiveStatusMonitorId": 283,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 729,
  "DbiAgentId": 987,
  "DbiLastSyncronized": "2000-07-15T03:40:46.38999+02:00",
  "DbiKey": "animi",
  "DbiLastModified": "2016-09-12T03:40:46.38999+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 517,
  "ActiveErpLinks": 119,
  "BounceEmails": [
    "maddison.schuster@halvorson.biz",
    "lorenz@koeppwintheiser.com"
  ],
  "Domains": [
    "ea",
    "tempore"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Kelley Will Muller Sr.",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "maiores",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "nam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 405
    }
  }
}
```
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







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The identifier of the ContactEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=190
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 679,
  "Name": "Jenkins LLC",
  "Department": "",
  "OrgNr": "338710",
  "Number1": "1034342",
  "Number2": "1738068",
  "UpdatedDate": "2019-03-05T11:24:47.7501716+01:00",
  "CreatedDate": "2019-04-02T11:24:47.7501716+02:00",
  "Emails": [
    {
      "Value": "tempora",
      "StrippedValue": "consequatur",
      "Description": "Self-enabling empowering moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "consequatur",
      "Description": "Self-enabling empowering moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 339,
      "Name": "Stehr, Roob and Sawayn",
      "ToolTip": "Corrupti architecto modi nobis quia ipsam.",
      "Deleted": true,
      "Rank": 841,
      "Type": "accusamus",
      "ColorBlock": 795,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2007-09-11T11:24:47.7501716+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "hic",
      "Hidden": true,
      "FullName": "Vito Jessyca Baumbach Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 968
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quae",
      "StrippedValue": "alias",
      "Description": "Business-focused national capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "alias",
      "Description": "Business-focused national capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "molestiae",
      "StrippedValue": "ut",
      "Description": "Versatile context-sensitive info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 803
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "ut",
      "Description": "Versatile context-sensitive info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 803
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "accusamus",
      "StrippedValue": "voluptas",
      "Description": "Fundamental systemic paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "voluptas",
      "Description": "Fundamental systemic paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    }
  ],
  "Description": "Diverse executive superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequatur",
      "PersonId": 496,
      "Mrmrs": "voluptatem",
      "Firstname": "Nasir",
      "Lastname": "D'Amore",
      "MiddleName": "Bashirian-Willms",
      "Title": "illo",
      "Description": "Enhanced even-keeled encryption",
      "Email": "marianna.satterfield@ruecker.biz",
      "FullName": "Kenna Ibrahim Fritsch Sr.",
      "DirectPhone": "(696)723-0632 x573",
      "FormalName": "Haag Inc and Sons",
      "CountryId": 395,
      "ContactId": 870,
      "ContactName": "Toy LLC",
      "Retired": 486,
      "Rank": 959,
      "ActiveInterests": 786,
      "ContactDepartment": "",
      "ContactCountryId": 384,
      "ContactOrgNr": "227996",
      "FaxPhone": "(142)031-3066",
      "MobilePhone": "000-131-9291 x97196",
      "ContactPhone": "(260)770-5580",
      "AssociateName": "Sauer-Davis",
      "AssociateId": 894,
      "UsePersonAddress": false,
      "ContactFax": "id",
      "Kanafname": "aut",
      "Kanalname": "nesciunt",
      "Post1": "rerum",
      "Post2": "tempora",
      "Post3": "assumenda",
      "EmailName": "jaclyn@cronin.info",
      "ContactFullName": "Mr. Darrion Kohler",
      "ActiveErpLinks": 632,
      "TicketPriorityId": 159,
      "SupportLanguageId": 927,
      "SupportAssociateId": 790,
      "CategoryName": "VIP Customer",
      "PersonNumber": "905346",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "corrupti",
  "Xstop": true,
  "ActiveInterests": 935,
  "GroupId": 412,
  "ActiveStatusMonitorId": 306,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 773,
  "DbiAgentId": 125,
  "DbiLastSyncronized": "2006-04-11T11:24:47.7657959+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2009-09-05T11:24:47.7657959+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 520,
  "ActiveErpLinks": 500,
  "BounceEmails": [
    "johnathon@turcotte.info",
    "chaim@lehner.info"
  ],
  "Domains": [
    "voluptas",
    "beatae"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Korey Hegmann Sr.",
    "SuperOffice:2": "587122365"
  },
  "ExtraFields": {
    "ExtraFields1": "dolore",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 215
    }
  }
}
```
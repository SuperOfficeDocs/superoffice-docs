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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=889
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 82,
  "Name": "Streich Group",
  "Department": "",
  "OrgNr": "929804",
  "Number1": "1109536",
  "Number2": "654715",
  "UpdatedDate": "2016-02-08T14:45:05.0689788+01:00",
  "CreatedDate": "2020-08-08T14:45:05.0689788+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "consequatur",
      "Description": "Open-architected systemic utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "consequatur",
      "Description": "Open-architected systemic utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 533,
      "Name": "Weimann-Kerluke",
      "ToolTip": "Quos qui non enim dolorem.",
      "Deleted": true,
      "Rank": 969,
      "Type": "nam",
      "ColorBlock": 864,
      "IconHint": "provident",
      "Selected": false,
      "LastChanged": "2008-11-17T14:45:05.0689788+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "placeat",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Aiyana Beahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 952
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "atque",
      "StrippedValue": "aspernatur",
      "Description": "Streamlined empowering challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "aspernatur",
      "Description": "Streamlined empowering challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "sapiente",
      "Description": "Organic 3rd generation framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "sapiente",
      "Description": "Organic 3rd generation framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "labore",
      "StrippedValue": "explicabo",
      "Description": "De-engineered zero tolerance process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 692
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "explicabo",
      "Description": "De-engineered zero tolerance process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 692
        }
      }
    }
  ],
  "Description": "User-friendly fresh-thinking neural-net",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "recusandae",
      "PersonId": 469,
      "Mrmrs": "tempora",
      "Firstname": "Camron",
      "Lastname": "Hickle",
      "MiddleName": "Reynolds Group",
      "Title": "ea",
      "Description": "Diverse value-added database",
      "Email": "prudence@bruen.biz",
      "FullName": "Hayley Hintz",
      "DirectPhone": "925-406-7689",
      "FormalName": "Stiedemann-Ward",
      "CountryId": 668,
      "ContactId": 427,
      "ContactName": "Zieme, Schiller and Kihn",
      "Retired": 34,
      "Rank": 958,
      "ActiveInterests": 748,
      "ContactDepartment": "",
      "ContactCountryId": 364,
      "ContactOrgNr": "865088",
      "FaxPhone": "389.823.6348 x164",
      "MobilePhone": "(480)228-0737 x58410",
      "ContactPhone": "474.305.2114 x0659",
      "AssociateName": "Schmeler Group",
      "AssociateId": 686,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "velit",
      "Kanalname": "quis",
      "Post1": "consequatur",
      "Post2": "repellat",
      "Post3": "itaque",
      "EmailName": "fritz_price@maggiogleason.info",
      "ContactFullName": "Julianne Nigel Hills DDS",
      "ActiveErpLinks": 27,
      "TicketPriorityId": 537,
      "SupportLanguageId": 894,
      "SupportAssociateId": 32,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 839
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "aliquid",
  "Xstop": false,
  "ActiveInterests": 939,
  "GroupId": 676,
  "ActiveStatusMonitorId": 62,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 537,
  "DbiAgentId": 162,
  "DbiLastSyncronized": "2011-06-06T14:45:05.0689788+02:00",
  "DbiKey": "labore",
  "DbiLastModified": "2018-02-11T14:45:05.0689788+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 151,
  "ActiveErpLinks": 971,
  "BounceEmails": [
    "brody@feil.co.uk",
    "markus.buckridge@lueilwitz.biz"
  ],
  "Domains": [
    "sint",
    "officiis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Nadia Mante",
    "SuperOffice:2": "696991680"
  },
  "ExtraFields": {
    "ExtraFields1": "reprehenderit",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "eaque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 128
    }
  }
}
```
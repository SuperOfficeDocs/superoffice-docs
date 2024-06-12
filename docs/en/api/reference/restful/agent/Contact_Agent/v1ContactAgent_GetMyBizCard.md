---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 931,
  "Name": "Dicki-Ratke",
  "Department": "",
  "OrgNr": "1242639",
  "Number1": "247436",
  "Number2": "597712",
  "UpdatedDate": "2016-03-06T04:22:26.2621843+01:00",
  "CreatedDate": "2003-09-29T04:22:26.2621843+02:00",
  "Emails": [
    {
      "Value": "pariatur",
      "StrippedValue": "deleniti",
      "Description": "Networked maximized hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "deleniti",
      "Description": "Networked maximized hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 51,
      "Name": "Donnelly, Mante and Wehner",
      "ToolTip": "Ullam quasi error ullam natus quas a.",
      "Deleted": false,
      "Rank": 991,
      "Type": "consectetur",
      "ColorBlock": 916,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2011-11-03T04:22:26.2621843+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "ea",
      "Hidden": false,
      "FullName": "Mrs. Emelie Schuppe DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "exercitationem",
      "Description": "Innovative intangible local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "exercitationem",
      "Description": "Innovative intangible local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dignissimos",
      "StrippedValue": "molestiae",
      "Description": "Re-engineered needs-based attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 716
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "molestiae",
      "Description": "Re-engineered needs-based attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 716
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "excepturi",
      "StrippedValue": "id",
      "Description": "Polarised logistical focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 703
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "id",
      "Description": "Polarised logistical focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 703
        }
      }
    }
  ],
  "Description": "Public-key 6th generation standardization",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "alias",
      "PersonId": 715,
      "Mrmrs": "eius",
      "Firstname": "Fredrick",
      "Lastname": "Gutmann",
      "MiddleName": "Larson LLC",
      "Title": "blanditiis",
      "Description": "Down-sized composite firmware",
      "Email": "verdie@funkdibbert.name",
      "FullName": "Floyd Hodkiewicz",
      "DirectPhone": "(062)671-7830 x3623",
      "FormalName": "Runte-Shanahan",
      "CountryId": 999,
      "ContactId": 469,
      "ContactName": "Fadel-Bartell",
      "Retired": 701,
      "Rank": 579,
      "ActiveInterests": 227,
      "ContactDepartment": "",
      "ContactCountryId": 190,
      "ContactOrgNr": "1748056",
      "FaxPhone": "541-315-9957",
      "MobilePhone": "(996)616-9426 x9196",
      "ContactPhone": "682-810-0840",
      "AssociateName": "Price-Zieme",
      "AssociateId": 643,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "atque",
      "Kanalname": "non",
      "Post1": "in",
      "Post2": "consequatur",
      "Post3": "quidem",
      "EmailName": "oleta_heller@cruickshankschimmel.info",
      "ContactFullName": "Carlie Predovic",
      "ActiveErpLinks": 335,
      "TicketPriorityId": 107,
      "SupportLanguageId": 965,
      "SupportAssociateId": 511,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "excepturi",
  "Xstop": false,
  "ActiveInterests": 827,
  "GroupId": 244,
  "ActiveStatusMonitorId": 610,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 803,
  "DbiAgentId": 476,
  "DbiLastSyncronized": "2024-03-23T04:22:26.2621843+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2024-05-18T04:22:26.2621843+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 814,
  "ActiveErpLinks": 930,
  "BounceEmails": [
    "rhea.boehm@bayer.com",
    "rose@white.name"
  ],
  "Domains": [
    "accusantium",
    "neque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "523110665",
    "SuperOffice:2": "Theo Lesch Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "excepturi",
    "CustomFields2": "magnam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 863
    }
  }
}
```
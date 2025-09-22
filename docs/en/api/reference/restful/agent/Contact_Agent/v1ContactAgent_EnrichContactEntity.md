---
title: POST Agents/Contact/EnrichContactEntity
uid: v1ContactAgent_EnrichContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/EnrichContactEntity

```http
POST /api/v1/Agents/Contact/EnrichContactEntity
```

Enrich a contact with data from the AI Enrichment service.


This will update the contact with address, phone number, and email.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/EnrichContactEntity?$select=name,department,category/id
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

ContactEntity, EnrichId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| EnrichId | String |  |

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
POST /api/v1/Agents/Contact/EnrichContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "EnrichId": "qui"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 599,
  "Name": "Christiansen, Lehner and Reichel",
  "Department": "",
  "OrgNr": "602777",
  "Number1": "1219365",
  "Number2": "1148882",
  "UpdatedDate": "2015-11-08T11:24:47.8282933+01:00",
  "CreatedDate": "2001-09-05T11:24:47.8282933+02:00",
  "Emails": [
    {
      "Value": "expedita",
      "StrippedValue": "qui",
      "Description": "Right-sized dynamic task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "qui",
      "Description": "Right-sized dynamic task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 621,
      "Name": "Tremblay-Hand",
      "ToolTip": "Praesentium aliquid labore ut.",
      "Deleted": false,
      "Rank": 570,
      "Type": "nihil",
      "ColorBlock": 801,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2005-08-02T11:24:47.8282933+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "labore",
      "StyleHint": "nulla",
      "Hidden": false,
      "FullName": "Mrs. Kirk Mikayla Ledner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "aut",
      "Description": "Diverse mission-critical adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "aut",
      "Description": "Diverse mission-critical adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "accusantium",
      "StrippedValue": "doloremque",
      "Description": "Advanced motivating workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 674
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "doloremque",
      "Description": "Advanced motivating workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 674
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nihil",
      "StrippedValue": "et",
      "Description": "Organized optimal solution",
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
      "Value": "nihil",
      "StrippedValue": "et",
      "Description": "Organized optimal solution",
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
  "Description": "Persevering 4th generation portal",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 131,
      "Mrmrs": "nemo",
      "Firstname": "Alden",
      "Lastname": "Hansen",
      "MiddleName": "Hermann, Dooley and Bednar",
      "Title": "velit",
      "Description": "Advanced impactful protocol",
      "Email": "bettie@strosin.ca",
      "FullName": "Prof. Krystal Dell Yundt",
      "DirectPhone": "1-808-842-8655 x82501",
      "FormalName": "Wolff, Batz and Vandervort",
      "CountryId": 364,
      "ContactId": 775,
      "ContactName": "Abshire, Kilback and Batz",
      "Retired": 527,
      "Rank": 881,
      "ActiveInterests": 447,
      "ContactDepartment": "",
      "ContactCountryId": 432,
      "ContactOrgNr": "1763569",
      "FaxPhone": "770.356.8677 x7229",
      "MobilePhone": "379.723.3849",
      "ContactPhone": "505-911-1083",
      "AssociateName": "Buckridge LLC",
      "AssociateId": 135,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "qui",
      "Kanalname": "impedit",
      "Post1": "non",
      "Post2": "qui",
      "Post3": "tenetur",
      "EmailName": "piper@wisozk.uk",
      "ContactFullName": "Chloe Homenick",
      "ActiveErpLinks": 479,
      "TicketPriorityId": 675,
      "SupportLanguageId": 925,
      "SupportAssociateId": 621,
      "CategoryName": "VIP Customer",
      "PersonNumber": "435235",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 81
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "iure",
  "Xstop": false,
  "ActiveInterests": 425,
  "GroupId": 945,
  "ActiveStatusMonitorId": 19,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 37,
  "DbiAgentId": 301,
  "DbiLastSyncronized": "2000-07-20T11:24:47.8282933+02:00",
  "DbiKey": "a",
  "DbiLastModified": "2019-07-11T11:24:47.8282933+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 697,
  "ActiveErpLinks": 206,
  "BounceEmails": [
    "loyal@williamsonbogisich.ca",
    "fermin.fritsch@kassulke.biz"
  ],
  "Domains": [
    "et",
    "ut"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Jeffery Willie Bednar MD",
    "SuperOffice:2": "1773172416"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 741
    }
  }
}
```
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
  "ContactId": 853,
  "Name": "Hoppe LLC",
  "Department": "",
  "OrgNr": "465715",
  "Number1": "907262",
  "Number2": "890357",
  "UpdatedDate": "2012-04-13T13:13:22.4457582+02:00",
  "CreatedDate": "2018-05-16T13:13:22.4457582+02:00",
  "Emails": [
    {
      "Value": "quae",
      "StrippedValue": "dolor",
      "Description": "Reverse-engineered zero defect frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 721
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "dolor",
      "Description": "Reverse-engineered zero defect frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 721
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 88,
      "Name": "Reilly, Weimann and Kuvalis",
      "ToolTip": "Minus molestiae.",
      "Deleted": true,
      "Rank": 140,
      "Type": "dolores",
      "ColorBlock": 287,
      "IconHint": "voluptatum",
      "Selected": true,
      "LastChanged": "2017-11-07T13:13:22.4457582+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "sequi",
      "Hidden": false,
      "FullName": "Lavinia Becker Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 502
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "perspiciatis",
      "Description": "Persevering multimedia moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "perspiciatis",
      "Description": "Persevering multimedia moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "totam",
      "StrippedValue": "alias",
      "Description": "Up-sized dedicated collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 407
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "alias",
      "Description": "Up-sized dedicated collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 407
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "numquam",
      "StrippedValue": "consequatur",
      "Description": "Down-sized grid-enabled support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "consequatur",
      "Description": "Down-sized grid-enabled support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    }
  ],
  "Description": "De-engineered leading edge framework",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 279,
      "Mrmrs": "autem",
      "Firstname": "Misael",
      "Lastname": "Hand",
      "MiddleName": "Little-Kautzer",
      "Title": "est",
      "Description": "Up-sized transitional contingency",
      "Email": "king_rogahn@kulashowe.uk",
      "FullName": "King Raymundo Crist DVM",
      "DirectPhone": "1-208-921-4808 x17515",
      "FormalName": "O'Hara, Hahn and Heller",
      "CountryId": 78,
      "ContactId": 566,
      "ContactName": "Ratke LLC",
      "Retired": 525,
      "Rank": 854,
      "ActiveInterests": 724,
      "ContactDepartment": "",
      "ContactCountryId": 740,
      "ContactOrgNr": "1065314",
      "FaxPhone": "073-174-2416",
      "MobilePhone": "487.526.1921",
      "ContactPhone": "1-344-194-2024 x812",
      "AssociateName": "Purdy-Gutkowski",
      "AssociateId": 533,
      "UsePersonAddress": false,
      "ContactFax": "quae",
      "Kanafname": "alias",
      "Kanalname": "ut",
      "Post1": "veritatis",
      "Post2": "optio",
      "Post3": "quia",
      "EmailName": "rashawn@torphybrakus.biz",
      "ContactFullName": "Prof. Trisha DuBuque",
      "ActiveErpLinks": 252,
      "TicketPriorityId": 706,
      "SupportLanguageId": 579,
      "SupportAssociateId": 636,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 267
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 49,
  "GroupId": 704,
  "ActiveStatusMonitorId": 160,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 943,
  "DbiAgentId": 450,
  "DbiLastSyncronized": "2001-09-19T13:13:22.4457582+02:00",
  "DbiKey": "ratione",
  "DbiLastModified": "2006-07-22T13:13:22.4457582+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 875,
  "ActiveErpLinks": 84,
  "BounceEmails": [
    "asha@schuppekulas.com",
    "dewayne.emmerich@rolfson.com"
  ],
  "Domains": [
    "voluptatum",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Beau Schumm",
    "SuperOffice:2": "Torrey Heaney"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 901
    }
  }
}
```
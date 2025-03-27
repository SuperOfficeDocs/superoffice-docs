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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 193,
  "Name": "Kshlerin-Rau",
  "Department": "",
  "OrgNr": "166198",
  "Number1": "1019882",
  "Number2": "1113448",
  "UpdatedDate": "2014-10-20T02:38:21.0577061+02:00",
  "CreatedDate": "1999-08-14T02:38:21.0577061+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "magni",
      "Description": "Decentralized full-range portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "magni",
      "Description": "Decentralized full-range portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 245
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 123,
      "Name": "Brekke, Mueller and Klocko",
      "ToolTip": "Corporis quia accusantium unde quisquam temporibus.",
      "Deleted": true,
      "Rank": 879,
      "Type": "facilis",
      "ColorBlock": 554,
      "IconHint": "sapiente",
      "Selected": false,
      "LastChanged": "2011-12-04T02:38:21.0577061+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "ex",
      "Hidden": false,
      "FullName": "Josianne Kassulke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 525
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "iusto",
      "StrippedValue": "quia",
      "Description": "Self-enabling 3rd generation model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 311
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "quia",
      "Description": "Self-enabling 3rd generation model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 311
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ex",
      "StrippedValue": "autem",
      "Description": "Multi-tiered didactic functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 577
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "autem",
      "Description": "Multi-tiered didactic functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 577
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aspernatur",
      "StrippedValue": "vero",
      "Description": "Ameliorated foreground standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 298
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "vero",
      "Description": "Ameliorated foreground standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 298
        }
      }
    }
  ],
  "Description": "Operative multi-state policy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "beatae",
      "PersonId": 202,
      "Mrmrs": "et",
      "Firstname": "Roberta",
      "Lastname": "Bayer",
      "MiddleName": "Bosco-Schimmel",
      "Title": "harum",
      "Description": "Proactive client-server portal",
      "Email": "jacklyn@zieme.us",
      "FullName": "Dr. Jerrell Annalise Erdman",
      "DirectPhone": "798-743-5400 x3034",
      "FormalName": "Kuphal LLC",
      "CountryId": 288,
      "ContactId": 417,
      "ContactName": "Russel-Gislason",
      "Retired": 487,
      "Rank": 954,
      "ActiveInterests": 996,
      "ContactDepartment": "",
      "ContactCountryId": 568,
      "ContactOrgNr": "1049399",
      "FaxPhone": "1-607-083-9379 x2915",
      "MobilePhone": "644-452-7512 x6037",
      "ContactPhone": "(119)575-5408",
      "AssociateName": "Legros-Rice",
      "AssociateId": 643,
      "UsePersonAddress": false,
      "ContactFax": "repudiandae",
      "Kanafname": "et",
      "Kanalname": "et",
      "Post1": "aut",
      "Post2": "doloribus",
      "Post3": "laboriosam",
      "EmailName": "alfonso_will@cronin.info",
      "ContactFullName": "Asha Willms Sr.",
      "ActiveErpLinks": 373,
      "TicketPriorityId": 904,
      "SupportLanguageId": 273,
      "SupportAssociateId": 15,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1290439",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 572,
  "GroupId": 101,
  "ActiveStatusMonitorId": 257,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 994,
  "DbiAgentId": 154,
  "DbiLastSyncronized": "2009-12-16T02:38:21.0577061+01:00",
  "DbiKey": "deserunt",
  "DbiLastModified": "2003-10-22T02:38:21.0577061+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 36,
  "ActiveErpLinks": 870,
  "BounceEmails": [
    "waino.koelpin@ferry.name",
    "antonetta.jewess@tillman.us"
  ],
  "Domains": [
    "cupiditate",
    "velit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "330360120"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 501
    }
  }
}
```
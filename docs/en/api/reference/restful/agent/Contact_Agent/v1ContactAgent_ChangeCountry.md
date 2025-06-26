---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 421
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 999,
  "Name": "Brekke, Gibson and Kirlin",
  "Department": "",
  "OrgNr": "483015",
  "Number1": "959534",
  "Number2": "548740",
  "UpdatedDate": "2020-01-09T03:45:23.2017113+01:00",
  "CreatedDate": "2018-03-24T03:45:23.2017113+01:00",
  "Emails": [
    {
      "Value": "officiis",
      "StrippedValue": "dolorem",
      "Description": "Public-key real-time infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "dolorem",
      "Description": "Public-key real-time infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 220,
      "Name": "Bogisich-Streich",
      "ToolTip": "Tenetur animi molestiae omnis et.",
      "Deleted": false,
      "Rank": 218,
      "Type": "non",
      "ColorBlock": 145,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2000-02-25T03:45:23.2017113+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "officia",
      "Hidden": false,
      "FullName": "Ms. Sherwood Gusikowski IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 639
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "natus",
      "Description": "Stand-alone fresh-thinking middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "natus",
      "Description": "Stand-alone fresh-thinking middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "molestiae",
      "StrippedValue": "nobis",
      "Description": "Total dynamic budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "nobis",
      "Description": "Total dynamic budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "excepturi",
      "StrippedValue": "sint",
      "Description": "Down-sized secondary contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "sint",
      "Description": "Down-sized secondary contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    }
  ],
  "Description": "Extended demand-driven neural-net",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "libero",
      "PersonId": 904,
      "Mrmrs": "beatae",
      "Firstname": "Larry",
      "Lastname": "Hackett",
      "MiddleName": "Runte LLC",
      "Title": "blanditiis",
      "Description": "Down-sized systemic infrastructure",
      "Email": "adrien@denesik.ca",
      "FullName": "Elsa Grimes",
      "DirectPhone": "059-681-2208",
      "FormalName": "Kozey, Senger and Tremblay",
      "CountryId": 608,
      "ContactId": 250,
      "ContactName": "Langosh, Borer and Hane",
      "Retired": 136,
      "Rank": 482,
      "ActiveInterests": 346,
      "ContactDepartment": "",
      "ContactCountryId": 787,
      "ContactOrgNr": "313717",
      "FaxPhone": "318-430-2296",
      "MobilePhone": "987-017-5167 x5627",
      "ContactPhone": "269.211.4817 x05162",
      "AssociateName": "Paucek LLC",
      "AssociateId": 170,
      "UsePersonAddress": false,
      "ContactFax": "aperiam",
      "Kanafname": "inventore",
      "Kanalname": "quam",
      "Post1": "ipsam",
      "Post2": "ut",
      "Post3": "in",
      "EmailName": "dovie.stoltenberg@mrazdeckow.uk",
      "ContactFullName": "Mr. Annamae Murphy",
      "ActiveErpLinks": 740,
      "TicketPriorityId": 443,
      "SupportLanguageId": 63,
      "SupportAssociateId": 747,
      "CategoryName": "VIP Customer",
      "PersonNumber": "730485",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 406
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eos",
  "Xstop": false,
  "ActiveInterests": 383,
  "GroupId": 957,
  "ActiveStatusMonitorId": 646,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 173,
  "DbiAgentId": 551,
  "DbiLastSyncronized": "2020-03-28T03:45:23.2017113+01:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "2003-12-02T03:45:23.2017113+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 946,
  "ActiveErpLinks": 797,
  "BounceEmails": [
    "louvenia@upton.co.uk",
    "laron_greenholt@jonesbins.us"
  ],
  "Domains": [
    "eaque",
    "nostrum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Melyna Langosh",
    "SuperOffice:2": "Howard Koepp"
  },
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "officiis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 876
    }
  }
}
```
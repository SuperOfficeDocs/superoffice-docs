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
  "ToCountryId": 546
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 639,
  "Name": "Bode, Marquardt and White",
  "Department": "",
  "OrgNr": "1623852",
  "Number1": "847815",
  "Number2": "765538",
  "UpdatedDate": "2025-04-18T03:41:53.2932434+02:00",
  "CreatedDate": "2003-12-16T03:41:53.2932434+01:00",
  "Emails": [
    {
      "Value": "fugiat",
      "StrippedValue": "at",
      "Description": "Organized clear-thinking customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "at",
      "Description": "Organized clear-thinking customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 950,
      "Name": "Stark Group",
      "ToolTip": "Quia fugiat commodi ad iure.",
      "Deleted": false,
      "Rank": 37,
      "Type": "praesentium",
      "ColorBlock": 167,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2000-07-12T03:41:53.2932434+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "maxime",
      "Hidden": false,
      "FullName": "Ms. Shanna Gleason III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 866
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ex",
      "StrippedValue": "sed",
      "Description": "Vision-oriented object-oriented analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "sed",
      "Description": "Vision-oriented object-oriented analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iure",
      "StrippedValue": "aut",
      "Description": "Persistent contextually-based encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "aut",
      "Description": "Persistent contextually-based encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "natus",
      "Description": "Seamless 6th generation system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 292
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "natus",
      "Description": "Seamless 6th generation system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 292
        }
      }
    }
  ],
  "Description": "Multi-layered tangible orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "corrupti",
      "PersonId": 38,
      "Mrmrs": "aut",
      "Firstname": "Vickie",
      "Lastname": "Armstrong",
      "MiddleName": "Heathcote Group",
      "Title": "nihil",
      "Description": "Advanced bandwidth-monitored internet solution",
      "Email": "breanne@dicki.info",
      "FullName": "Shaun Tillman",
      "DirectPhone": "057.969.5297 x01562",
      "FormalName": "Kuhic-Bashirian",
      "CountryId": 464,
      "ContactId": 404,
      "ContactName": "Roob Group",
      "Retired": 980,
      "Rank": 812,
      "ActiveInterests": 94,
      "ContactDepartment": "",
      "ContactCountryId": 890,
      "ContactOrgNr": "861491",
      "FaxPhone": "352.525.1187 x43455",
      "MobilePhone": "255.789.0903",
      "ContactPhone": "(357)444-9546 x97311",
      "AssociateName": "Collins-Upton",
      "AssociateId": 958,
      "UsePersonAddress": false,
      "ContactFax": "odit",
      "Kanafname": "quis",
      "Kanalname": "enim",
      "Post1": "a",
      "Post2": "inventore",
      "Post3": "earum",
      "EmailName": "audra.walter@flatley.us",
      "ContactFullName": "Dr. Marley Colby Hirthe I",
      "ActiveErpLinks": 614,
      "TicketPriorityId": 498,
      "SupportLanguageId": 130,
      "SupportAssociateId": 720,
      "CategoryName": "VIP Customer",
      "PersonNumber": "897267",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "impedit",
  "Xstop": true,
  "ActiveInterests": 868,
  "GroupId": 593,
  "ActiveStatusMonitorId": 123,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 341,
  "DbiAgentId": 339,
  "DbiLastSyncronized": "2017-10-30T03:41:53.2932434+01:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2019-02-15T03:41:53.2932434+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 959,
  "ActiveErpLinks": 196,
  "BounceEmails": [
    "timmy_runte@keelingsipes.co.uk",
    "green@hamill.us"
  ],
  "Domains": [
    "alias",
    "cupiditate"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Rhea Stroman"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "eius"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 398
    }
  }
}
```
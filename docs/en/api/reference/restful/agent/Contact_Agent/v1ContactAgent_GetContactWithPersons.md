---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 414
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 950,
  "Name": "Jast Group",
  "Department": "",
  "OrgNr": "884062",
  "Number1": "1356867",
  "Number2": "1099149",
  "UpdatedDate": "2000-10-04T11:24:47.7657959+02:00",
  "CreatedDate": "2006-09-28T11:24:47.7657959+02:00",
  "Emails": [
    {
      "Value": "fugiat",
      "StrippedValue": "rerum",
      "Description": "Team-oriented uniform knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "rerum",
      "Description": "Team-oriented uniform knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 593,
      "Name": "Feeney-Bednar",
      "ToolTip": "Eum voluptatem expedita odio doloribus est tenetur.",
      "Deleted": false,
      "Rank": 544,
      "Type": "molestiae",
      "ColorBlock": 636,
      "IconHint": "odit",
      "Selected": false,
      "LastChanged": "2015-04-18T11:24:47.7657959+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "optio",
      "StyleHint": "error",
      "Hidden": false,
      "FullName": "Prof. Alva Tyree Jacobson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 962
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "nihil",
      "Description": "Enhanced attitude-oriented neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "nihil",
      "Description": "Enhanced attitude-oriented neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "corporis",
      "Description": "Compatible high-level knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "corporis",
      "Description": "Compatible high-level knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sapiente",
      "StrippedValue": "deleniti",
      "Description": "Reverse-engineered high-level service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 942
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "deleniti",
      "Description": "Reverse-engineered high-level service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 942
        }
      }
    }
  ],
  "Description": "Customer-focused transitional analyzer",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "modi",
      "PersonId": 388,
      "Mrmrs": "dolores",
      "Firstname": "Clovis",
      "Lastname": "Langworth",
      "MiddleName": "Abbott LLC",
      "Title": "quas",
      "Description": "Stand-alone real-time capacity",
      "Email": "daisha_tremblay@feesthayes.name",
      "FullName": "Royal Bernhard",
      "DirectPhone": "372.481.5170 x003",
      "FormalName": "Bernier-Dickinson",
      "CountryId": 195,
      "ContactId": 957,
      "ContactName": "Hickle-Gutmann",
      "Retired": 177,
      "Rank": 421,
      "ActiveInterests": 722,
      "ContactDepartment": "",
      "ContactCountryId": 145,
      "ContactOrgNr": "1538252",
      "FaxPhone": "031-069-5449 x2469",
      "MobilePhone": "471-688-2626 x34649",
      "ContactPhone": "(042)128-5966",
      "AssociateName": "Rohan-Wisoky",
      "AssociateId": 721,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "sit",
      "Kanalname": "modi",
      "Post1": "sit",
      "Post2": "voluptas",
      "Post3": "quam",
      "EmailName": "jerel@mcculloughgutmann.info",
      "ContactFullName": "Colin Hackett",
      "ActiveErpLinks": 951,
      "TicketPriorityId": 316,
      "SupportLanguageId": 515,
      "SupportAssociateId": 859,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1017397",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 178,
  "GroupId": 345,
  "ActiveStatusMonitorId": 724,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 444,
  "DbiAgentId": 322,
  "DbiLastSyncronized": "2011-06-26T11:24:47.7657959+02:00",
  "DbiKey": "harum",
  "DbiLastModified": "2015-02-28T11:24:47.7657959+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 889,
  "ActiveErpLinks": 303,
  "BounceEmails": [
    "waylon@reichert.biz",
    "melisa@schroeder.com"
  ],
  "Domains": [
    "voluptatem",
    "id"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Israel Senger PhD",
    "SuperOffice:2": "423598253"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 823
    }
  }
}
```
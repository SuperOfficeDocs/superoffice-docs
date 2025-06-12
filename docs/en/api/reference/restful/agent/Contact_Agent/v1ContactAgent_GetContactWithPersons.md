---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
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
  "ContactId": 197
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 788,
  "Name": "Bahringer Inc and Sons",
  "Department": "",
  "OrgNr": "1644542",
  "Number1": "1230206",
  "Number2": "1322458",
  "UpdatedDate": "2024-01-18T17:54:02.8514704+01:00",
  "CreatedDate": "2016-02-12T17:54:02.8514704+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "et",
      "Description": "Persistent contextually-based functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 477
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "et",
      "Description": "Persistent contextually-based functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 477
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 17,
      "Name": "Moore-Rau",
      "ToolTip": "Iste quam neque a totam cum voluptates.",
      "Deleted": false,
      "Rank": 56,
      "Type": "quia",
      "ColorBlock": 709,
      "IconHint": "excepturi",
      "Selected": true,
      "LastChanged": "2016-07-10T17:54:02.8514704+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "atque",
      "StyleHint": "non",
      "Hidden": true,
      "FullName": "Miss Morton Cassin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "distinctio",
      "Description": "Ergonomic asynchronous concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "distinctio",
      "Description": "Ergonomic asynchronous concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "porro",
      "StrippedValue": "quis",
      "Description": "Synergized encompassing knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "quis",
      "Description": "Synergized encompassing knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "provident",
      "Description": "Intuitive bifurcated superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "provident",
      "Description": "Intuitive bifurcated superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    }
  ],
  "Description": "Intuitive secondary system engine",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rerum",
      "PersonId": 390,
      "Mrmrs": "ut",
      "Firstname": "Kody",
      "Lastname": "Hackett",
      "MiddleName": "Bayer, Bayer and Labadie",
      "Title": "maxime",
      "Description": "Advanced 3rd generation Graphic Interface",
      "Email": "pattie_ratke@torphy.name",
      "FullName": "Carrie Reichert III",
      "DirectPhone": "1-778-986-6031",
      "FormalName": "Daniel, Bradtke and Hartmann",
      "CountryId": 677,
      "ContactId": 942,
      "ContactName": "Nienow Inc and Sons",
      "Retired": 132,
      "Rank": 791,
      "ActiveInterests": 831,
      "ContactDepartment": "",
      "ContactCountryId": 84,
      "ContactOrgNr": "1828294",
      "FaxPhone": "749.102.5407",
      "MobilePhone": "679.768.5345 x48045",
      "ContactPhone": "1-347-900-3508",
      "AssociateName": "Kuphal-Roberts",
      "AssociateId": 447,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "iste",
      "Kanalname": "rerum",
      "Post1": "assumenda",
      "Post2": "quod",
      "Post3": "odio",
      "EmailName": "nickolas@wintheiserterry.com",
      "ContactFullName": "Mrs. Faustino Hansen DDS",
      "ActiveErpLinks": 292,
      "TicketPriorityId": 586,
      "SupportLanguageId": 244,
      "SupportAssociateId": 815,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1314464",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 868
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolor",
  "Xstop": false,
  "ActiveInterests": 452,
  "GroupId": 616,
  "ActiveStatusMonitorId": 927,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 774,
  "DbiAgentId": 633,
  "DbiLastSyncronized": "1998-03-16T17:54:02.8670938+01:00",
  "DbiKey": "minima",
  "DbiLastModified": "2022-06-13T17:54:02.8670938+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 730,
  "ActiveErpLinks": 21,
  "BounceEmails": [
    "maxime@dibbert.uk",
    "kiana@senger.uk"
  ],
  "Domains": [
    "aliquam",
    "quos"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Vallie Runolfsdottir",
    "SuperOffice:2": "Johan Stanton"
  },
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "expedita"
  },
  "CustomFields": {
    "CustomFields1": "quas",
    "CustomFields2": "assumenda"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 629
    }
  }
}
```
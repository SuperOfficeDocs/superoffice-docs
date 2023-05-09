---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 69
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 777,
  "Name": "Steuber, Mitchell and Mills",
  "Department": "",
  "OrgNr": "594672",
  "Number1": "717453",
  "Number2": "199546",
  "UpdatedDate": "2003-04-09T03:51:26.8499374+02:00",
  "CreatedDate": "2017-01-03T03:51:26.8499374+01:00",
  "Emails": [
    {
      "Value": "quis",
      "StrippedValue": "optio",
      "Description": "Face to face client-driven success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 451
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "optio",
      "Description": "Face to face client-driven success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 451
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 861,
      "Name": "Eichmann-Grimes",
      "ToolTip": "Sit magni qui ut quo.",
      "Deleted": false,
      "Rank": 709,
      "Type": "ullam",
      "ColorBlock": 296,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "2017-07-17T03:51:26.8499374+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "inventore",
      "Hidden": false,
      "FullName": "Miss Abraham Muller V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 760
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "occaecati",
      "StrippedValue": "et",
      "Description": "Synchronised leading edge local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 632
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "et",
      "Description": "Synchronised leading edge local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 632
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nisi",
      "StrippedValue": "est",
      "Description": "Mandatory optimal focus group",
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
      "Value": "nisi",
      "StrippedValue": "est",
      "Description": "Mandatory optimal focus group",
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
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "doloribus",
      "Description": "Diverse secondary array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "doloribus",
      "Description": "Diverse secondary array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    }
  ],
  "Description": "Optional maximized artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "minima",
      "PersonId": 452,
      "Mrmrs": "qui",
      "Firstname": "Burdette",
      "Lastname": "Reilly",
      "MiddleName": "Gislason, D'Amore and Stehr",
      "Title": "tenetur",
      "Description": "Synergistic grid-enabled structure",
      "Email": "michaela@stroman.name",
      "FullName": "Dr. Mervin Amani Cartwright",
      "DirectPhone": "959-714-2850",
      "FormalName": "Trantow, Hessel and Bergnaum",
      "CountryId": 69,
      "ContactId": 628,
      "ContactName": "Orn-Marquardt",
      "Retired": 756,
      "Rank": 90,
      "ActiveInterests": 751,
      "ContactDepartment": "",
      "ContactCountryId": 879,
      "ContactOrgNr": "1121312",
      "FaxPhone": "460.614.7211",
      "MobilePhone": "856.363.3838 x6425",
      "ContactPhone": "230-538-6521 x73508",
      "AssociateName": "Kertzmann-Rutherford",
      "AssociateId": 452,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "dolor",
      "Kanalname": "ullam",
      "Post1": "dolore",
      "Post2": "rerum",
      "Post3": "hic",
      "EmailName": "fanny@schiller.info",
      "ContactFullName": "Kathryn Kassulke",
      "ActiveErpLinks": 845,
      "TicketPriorityId": 935,
      "SupportLanguageId": 16,
      "SupportAssociateId": 647,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "temporibus",
  "Xstop": false,
  "ActiveInterests": 463,
  "GroupId": 652,
  "ActiveStatusMonitorId": 151,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 565,
  "DbiAgentId": 613,
  "DbiLastSyncronized": "1996-02-28T03:51:26.8655518+01:00",
  "DbiKey": "aliquam",
  "DbiLastModified": "2016-03-13T03:51:26.8655518+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 397,
  "ActiveErpLinks": 88,
  "BounceEmails": [
    "sylvan@schmittschneider.com",
    "serena@kshlerin.name"
  ],
  "Domains": [
    "repellendus",
    "esse"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "616504438",
    "SuperOffice:2": "1071154022"
  },
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "optio"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 737
    }
  }
}
```
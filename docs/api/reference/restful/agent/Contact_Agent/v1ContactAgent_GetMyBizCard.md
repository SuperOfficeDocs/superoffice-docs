---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
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

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

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
  "ContactId": 167,
  "Name": "Leuschke Inc and Sons",
  "Department": "",
  "OrgNr": "1156666",
  "Number1": "1605113",
  "Number2": "483104",
  "UpdatedDate": "2013-06-25T11:10:26.3134247+02:00",
  "CreatedDate": "2014-04-08T11:10:26.3134247+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "quisquam",
      "Description": "Synergized composite capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "quisquam",
      "Description": "Synergized composite capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 396,
      "Name": "Crooks-Schulist",
      "ToolTip": "Consectetur ipsa magnam deserunt inventore ducimus nihil occaecati.",
      "Deleted": false,
      "Rank": 153,
      "Type": "autem",
      "ColorBlock": 456,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2002-05-26T11:10:26.3134247+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugit",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Aditya Blanda",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 760
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "aliquid",
      "Description": "Seamless systematic attitude",
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
      "Value": "ab",
      "StrippedValue": "aliquid",
      "Description": "Seamless systematic attitude",
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
  "Phones": [
    {
      "Value": "magni",
      "StrippedValue": "vel",
      "Description": "Automated incremental project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "vel",
      "Description": "Automated incremental project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "porro",
      "StrippedValue": "dignissimos",
      "Description": "Triple-buffered zero tolerance flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "dignissimos",
      "Description": "Triple-buffered zero tolerance flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    }
  ],
  "Description": "Streamlined web-enabled projection",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 665,
      "Mrmrs": "ad",
      "Firstname": "Joy",
      "Lastname": "Schroeder",
      "MiddleName": "Cummings, Sporer and Predovic",
      "Title": "nesciunt",
      "Description": "Synergistic web-enabled solution",
      "Email": "serenity@walker.uk",
      "FullName": "Shania Evangeline Thompson V",
      "DirectPhone": "269.494.4267",
      "FormalName": "Berge-Feil",
      "CountryId": 15,
      "ContactId": 9,
      "ContactName": "Bode Group",
      "Retired": 935,
      "Rank": 455,
      "ActiveInterests": 271,
      "ContactDepartment": "",
      "ContactCountryId": 691,
      "ContactOrgNr": "864024",
      "FaxPhone": "426.230.9182 x8707",
      "MobilePhone": "987.912.2829 x70559",
      "ContactPhone": "537.593.4613",
      "AssociateName": "Adams LLC",
      "AssociateId": 788,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "in",
      "Kanalname": "animi",
      "Post1": "asperiores",
      "Post2": "voluptas",
      "Post3": "rerum",
      "EmailName": "paul.gulgowski@beahan.com",
      "ContactFullName": "Braxton Halvorson",
      "ActiveErpLinks": 830,
      "TicketPriorityId": 557,
      "SupportLanguageId": 740,
      "SupportAssociateId": 221,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nulla",
  "Xstop": false,
  "ActiveInterests": 48,
  "GroupId": 615,
  "ActiveStatusMonitorId": 448,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 918,
  "DbiAgentId": 546,
  "DbiLastSyncronized": "2010-03-07T11:10:26.3174539+01:00",
  "DbiKey": "quo",
  "DbiLastModified": "2005-09-24T11:10:26.3174539+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 928,
  "ActiveErpLinks": 866,
  "BounceEmails": [
    "leonel_von@greennicolas.com",
    "brad@fahey.uk"
  ],
  "Domains": [
    "quo",
    "suscipit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "doloremque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 883
    }
  }
}
```
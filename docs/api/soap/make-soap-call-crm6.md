---
# Mandatory fields.
title: make_soap_call_crm_6       # (Required) Very important for SEO.
description: How to make SOAP calls with CRM 6 # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords: authentication
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to make SOAP calls with CRM 6

SOAP calls can be made by .Net or Java clients.

## Pre-requisites

It is essential to create a website in the web server before implementing any client application. And also, we have to make sure that all the following DLLs are included in the *Bin* directory of the website.

* SOCore.dll
* SoDateBase.dll
* SoMail.dll
* SuperOffice.Legacy.dll
* SuperOffice.Services.dll
* SuperOffice.Services.Implementation.dll
* SuperOffice.Services.Proxy.dll
* SuperOffice.Utilities.Verifiers.dll
* SuperOffice.Web.Services.dll

Then in the client application, we need to [add a web reference][1] to the services provided by this website. The client application can be designed using these web services.

The following example is one such client application written in .Net. We have
used `http://localhost/SuperOffice/Contact.asmx` as a name of the web service and `ContactRef` as a web reference name.

## Authenticate

The authentication details of a web service are passed in the SOAP header. The SOAP header element contains the application-specific information.

[!code-csharp[CS](includes/servicestest1-crm6.cs?range=1-19)]

Here we have first created an instance of the proxy object (Contact). Then we have set the `SOCredentials` property. **SOCredentials** is an object representation SoCredentialsHeader element, which is an element in the SOAP message header. It contains application-specific information about the SOAP message. The `SoCredentials.Secret` property is comprised of the `AuthenticationType`, the number of days since January 1, 2000, `UserId`, and password. They are all mandatory to authenticate against the web service.

## Generate secret

The following method shows how the secret is generated.

[!code-csharp[CS](includes/servicestest1-crm6.cs?range=21-49)]

## Calling the service

> [!NOTE]
> Make sure that the correct values to the elements of the database property in the `web.config` file. This determines the database from which we want to retrieve the data.

Here we retrieve an instance of the `ContactEntity` class using the `GetContactEntity` method of the `Contact` proxy object. This method will call the web services, we can retrieve, create, update, and delete a contact in this manner.

```csharp
//Obtain an instance of the Contact using the Authenticate() method
ContactRef.Contact myContact = Authenticate();

//Retrieve a ContactEntity
ContactRef.ContactEntity myContactEntity = myContact.GetContactEntity(15);

//Obtain the properties of the Contact
string name = myContactEntity.Name;

//Change the department property of Contact
myContactEntity.Department = "Sales";

//Stop the Contact
myContactEntity.Xstop = true;

//Save the Contact
myContact.SaveContactEntity(ref myContactEntity);
```

<!-- Referenced links -->
[1]: ../services/call-ws-from-dotnet-std-tools/add-web-reference.md

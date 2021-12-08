---
title: Calling SOAP using the NetServer proxy
uid: call_soap_ws_nuget
description: Calling SOAP using the NetServer proxy
author: Bergfrid Dias
so.date: 12.03.2021
keywords: API, web services, proxy, WebAPI, SOAP, SuperOffice.Service.dll, modes, DefaultMode
so.topic: howto
# so.envir:
# so.client:
---

# Calling SOAP using the NetServer proxy

This section explains how to access SuperOffice web services from .NET using SuperOffice tools.

Whether targeting a local or remote database, an **SoSession** is the object that maintains a user's principal. The **secret** is calculated for us during the `Authenticate` call. The proxy objects returned will automatically add the SOAP authentication header for us. This makes working with the SOAP services much simpler. See the [Authentication][2] section for more information.

> [!CAUTION]
> There is no secret used here: the username and password are passed in clear-text, so you should use HTTPS if you are going to be doing this over the open internet.

## Locally

In this case, everything runs within the same process.

![03][img1]

To call a NetServer web service locally:

1. Add the following NetServer binaries to your application (project references).

    * SoCore.dll
    * SuperOffice.Service.dll
    * SuperOffice.Service.Implementation.dll

2. In the application’s configuration file, set `DefaultMode` to **Local**.

    ```XML
    <Services>
      <addkey="DefaultMode" value="Local" />
    </Services>
    ```

3. Call the web service. Use the namespaces of the binaries in the `using` section of your code file:

    ```csharp
    using SuperOffice.CRM.Services;

    using (SoSession mySession = SoSession.Authenticate("sam", "sam"))
    {
      //Instantiate the agent
      using(ContactAgent contactAgent = new ContactAgent())
      {
        //Create a Contacts array and assign values
        Contact[] myContacts = new Contact[5];
        myContacts = contactAgent.GetMyContacts();

        ContactEntity contactEntity = contactAgent.CreateDefaultContactEntity();
        contactEntity.Name = "Supra Inc.";
        // ... populate contact properties
        contactAgent.SaveContactEntity(contactEntity);
      }
    }
    ```

## Remotely

The application calls the services proxy, which calls the remote web services via SOAP. This corresponds to the following diagram:

![04][img2]

To call a NetServer web service remotely:

1. Set up the NetServer-provided web services as an application in IIS. Make sure that all the following DLLs are included in the *Bin* directory of the website. You will also need the SVC files.

    * SOCore.dll
    * SoDateBase.dll
    * SuperOffice.Plugins.dll
    * SuperOffice.Services.dll - Internal interface declarations
    * SuperOffice.Services.Implementation.dll - The business logic implementation
    * SuperOffice.Services.Wcf.dll - The WCF interface declarations
    * SuperOffice.Services.WcfService.dll - The WCF web service logic; calls *SuperOffice.Services.dll*
    * SuperOffice.Web.Globalization.dll - Translation utilities
    * ICSharpCode.SharpZipLib.dll

2. In the application’s configuration file, set `DefaultMode` to **Remote**.

    ```XML
    <Services>
      <addkey="DefaultMode" value="Remote" />
      <addkey="RemoteBaseURL" value="http://hostname/WebServices/" />
    </Services>
    ```

    The URL of the remote web services is determined by the **RemoteBaseURL** configuration setting.

3. Now you can call the web services using the same agent pattern as before (local mode).

## A word about modes

The constructors return implementation objects that talk directly to the database or proxy objects that talk to the back-end via SOAP. The advantage of this is that it gives flexibility since you can run everything on one box or two separate boxes without changing the program. Only the config file needs to be changed.

The diagram depicts the data path taken when communicating with the Services layer.

![Service communication modes and data path][img3]

The Client represents a .NET application that has referenced *SuperOffice.Services.dll*. The lines, depending on the `<Services><DefaultMode>` configuration setting, represent the data path to communicate with the database.

> [!TIP]
> Use local mode when the application resides on the same server as the database or within the same domain.

When opted to operate in **local mode**, *SuperOffice.Services.dll* uses both Rows and OSQL to populate lite-serializable versions of intrinsic types, such as Appointment, Contact, and Person. These are the same objects returned by calling the web service, but in this case, **don't require a round-trip across the internet**. Smart, huh?

In **remote mode**, *SuperOffice.Services.dll* uses proxy classes. They are similar to what you get when generating custom proxies but enhanced to increase completeness and usability.

* When running locally, `new ContactAgent()` returns a `ContactAgentImpl` that lives in the *SuperOffice.CRM.Services.Implementation.dll*.
* When running remotely, `new ContactAgent()` returns a `ContactAgentProxy` that lives in the *SuperOffice.CRM.Services.Proxy.dll*.

The application code can't tell the difference between the two because the call only promises to return something that implements the `ContactAgent` interface – which both the local implementation and the proxy object do.

For more information, see the [NetServer configuration][1] section.

<!-- Referenced links -->
[1]: ../../config/services.md

<!-- Referenced images -->
[img1]: media/image003.gif
[img2]: media/image004.gif
[img3]: media/servicedatapath-sm.png

---
title: Calling through a NetServer proxy
uid: call_service_using_ns_proxy
description: Calling through a NetServer proxyincluding spaces.
author: {github-id}
so.date:
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# Calling through a NetServer proxy

To call a NetServer service through a proxy as a web service you have to set up the NetServer provided web services as an application in the IIS. After configuring the IIS application you can call the web services using the same agent pattern as before.

We change the configuration to indicate that we are calling a remote web service rather than using a local implementation of the web service.

This corresponds to the following diagram:

![04][img1]

The Application calls the services proxy, which calls the remote web services via SOAP.

The application’s configuration file will need to be changed to reflect the following changes so that the NetServer Services will be called through the proxy.

```XML
<Services>
  <addkey="DefaultMode" value="Remote" />
  <addkey="RemoteBaseURL" value="http://hostname/WebServices/" />
</Services>
```

What happens when the application’s config file is changed from running Local to Remote is that the `AgentFactory` returns a different type of objects when its various factory functions are called.

* When running locally, the new ContactAgent() returns a `ContactAgentImpl` that lives in the *SuperOffice.CRM.Services.Implementation.dll*.
* When running remotely, the new ContactAgent() returns a `ContactAgentProxy` that lives in the *SuperOffice.CRM.Services.Proxy.dll*.

The application code cannot tell the difference between the 2 because the `GetContactAgent()` call only promises to return something which implements the `IContactAgent` interface – which both the local implementation and the proxy object do.

For the `AgentFactory` to return the proxy rather than the implementation object, we would change the Implementation reference in the previous example to the *SuperOffice.Services.Proxy.dll* assembly which will look like the following.

![05][img2]

The proxy object will use Microsoft's WSE toolkit to do a SOAP call to the remote URL specified in the config file. If WSE is not installed, an error will occur during the processing of a configuration file required to service this request.

The web service at the other end of the URL also has a *web.config* file, which must specify that the service implementation is run locally. This is done by having the following in *web.config* for the web services:

```XML
<Services>
  <addkey="DefaultMode" value="Local" />
</Services>
```

Microsoft’s Web-Service Enhancements are used to provide the SOAP message handling, while the *web.config* file of the web services must also contain the right WSE sections. Given below are the configurations that you have to add to the *web.config* file:

```XML
<system.web>
  <webServices>
    <soapExtensionTypes></soapExtensionTypes>
    <soapServerProtocolFactory type="Microsoft.Web.Services3.WseProtocolFactory,
        Microsoft.Web.Services3, Version=3.0.0.0, Culture=neutral,
        PublicKeyToken=31bf3856ad364e35"/>
    <soapExtensionImporterTypes>
      <add type="Microsoft.Web.Services3.Description.WseExtensionImporter,
         Microsoft.Web.Services3, Version=3.0.0.0, Culture=neutral,
         PublicKeyToken=31bf3856ad364e35"/>
    </soapExtensionImporterTypes>
  </webServices>
  <customErrors mode="RemoteOnly"/>
  <authentication mode="None"/>
  <authorization>
    <allow users="*"/>
  </authorization>
  <identity impersonate="true"/>
  <sessionState mode="InProc" stateConnectionString="tcpip=127.0.0.1:42424" 
    sqlConnectionString="data source=127.0.0.1;Trusted_Connection=yes" cookieless="false"  
    timeout="20"/>
  <globalization requestEncoding="utf-8" responseEncoding="utf-8"/>
</system.web>

<microsoft.web.services3>
</microsoft.web.services3>
```

<!-- Referenced images -->
[img1]: media/image004.gif
[img2]: media/image005.jpg

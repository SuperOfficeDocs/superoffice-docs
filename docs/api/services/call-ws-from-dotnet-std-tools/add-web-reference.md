---
title: add_web_reference
description: How to add a web reference
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto
---

# How to add a web reference

To add a web reference to a project:

1. Right-click the project in the Visual Studio solution explorer.

2. From the panel that pops up, click **Add Web reference**.

    ![01][img1]

3. Type a web service URL in the combo-box on the top and click **Go**.

4. After the URL is validated, enter the name you plan to use in the project and click the **Add Reference** button.

## Using more than one service

Because you first need to call the `SoPrincipal` service and then call the `Contact` service, you need several web-service references to get any useful work done.

The problem is that having multiple references leads to multiple namespaces, each with the same classes defined separately. Thus, you end up with 3 incompatible copies of the `SoCredential` data-carrier class. This is rather annoying since you can't use the result from the `Authenticate` call when you call a different web service.

To fix this, you need to convince Visual Studio to put all the service references in one namespace, so that they all share the same copy of the data-carrier classes.

### Add a service reference

![add ref][2]

This will add a `Service` reference to the project. It describes the URL and WSDL and is used to generate the WCF SOAP proxies that your code will use to call the web services.

### Turn on Show-all-files

![ws][3]

The web service reference node hides a lot of generated files.

Turn on **Show-all-files** by clicking the button in the Solution Explorer header.

We want to change the one hidden behind the *Reference.svcmap* file.

### Add services to the MetadataSources

In the *Reference.svcmap* XML file you will find a `<MetadataSources>` node:

```XML
<MetadataSources>
  <MetadataSource 
     Address="http://localhost/4003/SoPrincipal.svc" 
     Protocol="http" SourceId="1" />
</MetadataSources>
```

Change this by adding the other services you want to use. Then save and close the file.

```XML
<MetadataSources>
  <MetadataSource 
     Address="http://localhost/4003/SoPrincipal.svc" 
     Protocol="http" SourceId="1" />
  <MetadataSource 
     Address="http://localhost/4003/Contact.svc" 
     Protocol="http" SourceId="2" />
  <MetadataSource 
     Address="http://localhost/4003/Project.svc" 
     Protocol="http" SourceId="3" />
</MetadataSources>
```

### Update the service reference

Right-click the `Service` reference and select the **Update Service Reference** menu item. This will cause Visual Studio to fetch all the services referenced in the MetadataSources list, and generate all the services into the same namespace.

You will see a lot more files generated inside the service reference folder.

You can turn off **Show-all-files** now if they are distracting.

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/add-ref-2008.png
[img3]: media/web-service.png

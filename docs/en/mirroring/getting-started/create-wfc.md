---
title: Create WFC
uid: create_mirroring_wfc
description: Get your mirroring service up and running in 10 minutes or less using NuGet
author: SuperOffice Product and Engineering
keywords: mirroring, WFC, appSettings
content_type: howto
deployment: online
platform: web
---

# Get your mirroring service up and running in 10 minutes or less using NuGet

Although you are free to implement the mirroring service to support any database you prefer, SuperOffice provides a complete implementation of the database mirroring interface as a NuGet package.

This walk-through will guide you through creating a new WCF service from scratch using the [SuperOffice.Crm.Online.Mirroring package][1], and help you have a running service in just a few minutes.

These steps were documented using Visual Studio 2015.

> [!NOTE]
> You can download the completed result of these steps on GitHub.
> View the [DevNet-Database-Mirroring repository][3] on GitHub.

## Create a new WCF Service Application in Visual Studio

1. In Visual Studio, click **File**, then **New**, and then **Project**.

2. In the **New Project** dialog, expand the **WCF** section and select to create a new **WCF Service Application**.

    ![x -screenshot][img1]

3. In the **Solution Explorer**, delete the following files: *IService1.cs*, *Service1.svc*, and *Service1.cs*.

    Before:

    ![x -screenshot][img2]

    After:

    ![x -screenshot][img3]

## Install the NuGet package

1. Open the **Package Manager Console:**

    * Click **Tools**, then **NuGet Package Manager**, and then **Package Manager Console**.

2. Start the installation by typing: `Install-Package SuperOffice.Crm.Online.Mirroring`

    ![x -screenshot][img4]

3. Verify that the packages have been added:

    1. When you see the *successfully installed* message in the **Package Manager Console**, go back to the **Solution Explorer**.

    2. Confirm that you have a new assembly references and that the following files have been added to your project: *MirroringClientService.svc*, *MirroringClientService.cs,* and *Private.txt*.

    3. Open the *package.config* file and check that you now have the new Mirroring package and its 2 dependencies. Your package versions may be different, and that is OK.

    ![x -screenshot][img5]

> [!TIP]
> During installation, you will see a lot of data scroll by in the NuGet **Package Manager Console**. The Package Manager inspects the `SuperOffice.Crm.Online.Mirroring` package and tries to download and add dependencies to your project.

### Key points during package installation

* package name (`SuperOffice.Crm.Online.Mirroring`)
* `System.IdentityModel.Tokens.Jwt` dependency
* `SuperOffice.Crm.Online.Core` dependency
* **successfully installed** message

These are underlined with red in the following screenshot:

![x -screenshot][img6]

## Update settings in web.config

The functionality in the *MirroringClientService.cs* file helps you resolve a tenant's context identifier to a particular database, create the database if necessary, discover and provide the service's **ApplicationToken**, as well as the private certificate key it must use to sign the token placed in the **AuthenticationResponse** message. However, you must still provide those key pieces of information in the project's *web.config* file.

![x -screenshot][img7]

### appSettings section

**SoAppId:** set to client ID (application environment-specific)

**ConnectionBase:** the partial connection string used to connect your SQL Server host

**MirrorDatabaseName:** will be used as a template for accessing the specific database on that server based on the context identifier passed to this service from SuperOffice

**PrivateFileKey:** the name of the file that contains your private certificate key in the RSA XML `<RSAKeyPair>` and `<RSAKeyValue>` format. **Critical for initial authentication!**

You get the private certificate key for all environments from SuperOffice.

![x -screenshot][img8]

### system.serviceModel section

Because synchronizing a database requires a lot of data, it's important to set size options to the maximum capabilities for the mirroring service.

A complete system.serviceModel configuration example:

```xml
<system.serviceModel>
  <behaviors>
    <serviceBehaviors>
      <behavior>
        <!-- To avoid disclosing metadata information, 
             set the values below to false before deployment -->
        <serviceMetadata httpGetEnabled="false" httpsGetEnabled="false" />
        <!-- To receive exception details in faults for debugging purposes, 
             set the value below to true. Set to false before deployment to 
             avoid disclosing exception information -->
        <serviceDebug includeExceptionDetailInFaults="false" />
      </behavior>
    </serviceBehaviors>
  </behaviors>
  <protocolMapping>
    <add binding="basicHttpBinding" scheme="https" bindingConfiguration="DbMirroring" />
  </protocolMapping>
  <serviceHostingEnvironment aspNetCompatibilityEnabled="true" multipleSiteBindingsEnabled="true" />
  <bindings>
    <basicHttpBinding>
      <binding name="DbMirroring" 
               maxBufferPoolSize="2147483647" 
               maxReceivedMessageSize="2147483647" 
               maxBufferSize="2147483647">
        <!-- Uncomment the security element if experiencing 404 service not found or unavailable.-->  
        <!--<security mode="Transport"> <transport clientCredentialType="None" /> </security>-->
        <readerQuotas maxDepth="2147483647" 
                      maxStringContentLength="2147483647" 
                      maxArrayLength="2147483647" 
                      maxBytesPerRead="2147483647" 
                      maxNameTableCharCount="2147483647" />
      </binding>
    </basicHttpBinding>
  </bindings>
  <services>
    <service name="DatabaseMirroringProject.SuperOfficeMirror.MirroringClientService">
      <endpoint binding="basicHttpBinding" 
                bindingConfiguration="DbMirroring" 
                contract="SuperOffice.Online.Mirroring.Contract.IMirroringClientService" />
    </service>
  </services>
</system.serviceModel>
```

The naming and linking of key items are annotated in the following image.

![x -screenshot][img12]

## Expose service to a public secure URL

**Open the service in a browser:**

In the *solution* directory, right-click the *MirroringClientServer.svc* file, then click **View in Browser**.

Assuming everything is correctly in place, you will see the default IIS or IISExpress web service page.

![x -screenshot][img10]

Finally, you will want to expose this service to a public HTTPS URL for the [SuperOffice Mirroring Task][2] to access it.

**This will be the URL you must give SuperOffice when registering your application.**
Remember to specify this URL as the Database Mirror URL, not the Redirect URL.

![x -screenshot][img11]

<!-- Referenced links -->
[1]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Mirroring
[2]: ../mirroring-task.md
[3]: https://github.com/SuperOffice/devnet-database-mirroring

<!-- Referenced images -->
[img1]: media/createwcfservice.png
[img2]: media/wcfservicedefaultsolution.png
[img3]: media/wcfservicesolution.png
[img4]: media/installdatabasemirroring.png
[img5]: media/packageconfig.png
[img6]: media/installpackagesuccess.png
[img7]: media/solutionpostinstall.png
[img8]: media/webconfigpostinstall.png
[img10]: media/wcfserviceiniis.png
[img11]: media/wcfserviceiniis-https.png
[img12]: media/system-servicemodel-config.png

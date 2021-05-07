---
title: Create WFC
uid: create_mirroring_wfc
description: Get your mirroring service up and running in 10 minutes or less using NuGet
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Get your mirroring service up and running in 10 minutes or less using NuGet

Although you are free to implement the mirroring service to support any database you prefer, SuperOffice provides a complete implementation of the database mirroring interface as a NuGet package.

This walk-through will guide you through creating a new WCF service from scratch using the [SuperOffice.Crm.Online.Mirroring package][1], and help you have a running service in just a few minutes.

These steps were documented using Visual Studio 2015.

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

You get the private certificate key for SOD from SuperOffice. **You must provide your own certificates for the stage and production environments.**

![x -screenshot][img8]

### system.serviceModel section

Now present is a binding **ExtendedMaxSize**, because synchronizing database requires a lot of data, and in the services section a new service entry for the mirroring service.

![x -screenshot][img9]

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

<!-- Referenced images -->
[img1]: media/createwcfservice.png
[img2]: media/wcfservicedefaultsolution.png
[img3]: media/wcfservicesolution.png
[img4]: media/installdatabasemirroring.png
[img5]: media/packageconfig.png
[img6]: media/installpackagesuccess.png
[img7]: media/solutionpostinstall.png
[img8]: media/webconfigpostinstall.png
[img9]: media/webconfigpostinstallservermodel.png
[img10]: media/wcfserviceiniis.png
[img11]: media/wcfserviceiniis-https.png

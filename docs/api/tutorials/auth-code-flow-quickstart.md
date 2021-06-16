---
title: ASP.NET web application quick-start
uid: auth_code_flow_quickstart
description: ASP.NET web application quickstart
author: {github-id}
keywords: oidc, razor page
so.topic: guide
so.envir: cloud
so.client: online
---

# ASP.NET web application quick-start

A quick-start guide for getting you up and running with an ASP.NET Core Razor Page web application.

## Before you begin

* You must have a basic understanding of [OpenID Connect][4]. This example uses the [Authorization Code][5] flow.

* You have a [tenant][3] with a user for testing sign-in.

* You have [registered your application][2] with the following options:
  * OpenID Connect Authorization Code flow

  ![imageb65a.png][img1]

  * Your application redirect URL list must include the example application default URL:
    * **SSL**: `https://localhost:44310/callback`
    * Optionally, disable SSL, then the default URL is `http://localhost:54238/callback`

> [!NOTE]
> If you have **already registered your application**, replace the default URLs in the project property page (seen below) with your registered redirect URLs.
>
> Alternatively, send instructions to SuperOffice by [filling in the update form][6] to add these URLs to your application definition.

* you have received a unique application [client ID and secret][3]

* you have Visual Studio (community, professional, or enterprise edition)

## Quick-start

1. **Clone** or **download** the [SuperOffice.DevNet.RazorPages][7] from GitHub.

    `git clone https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi.git`

2. In Visual Studio, go to the *Source* directory and **open** the *SuperOffice.DevNet.RazorPages.sln* file.

    ![image8z7wl.png][2]

3. In the *appSettings.json* file, enter the **Environment**, **ClientId** and **ClientSecret** settings. The environment setting pertains to SuperOffice [online environment][8] where the application will be operating. The options are sod, stage, or online.

    * The ClientId and ClientSecret refer to the [application identifiers][3] used by OpenID Connect.

        ![image4oqhj.png][img3]

    * These settings populate the OpenID Connect configuration options during the application's initialization and are defined in the *Startup.cs* file.

        ![imagetudj9.png][img4]

    * The default RedirectURL for this website is defined in the application property page. When you are ready to deploy this application to another website, or URL, make sure to update your application redirectURL by filling in the [update application form][6]. These can be changed in two places. The first is in the applications **property pages**:

        ![image8m8u.png][img5]

    * Alternatively, in the solutions *Properties* folder, open the *launchSettings.json* file and change the applicationUrl and sslPort values.

    > [!NOTE]
    > The sslPort is only used if you enable SSL, seen in the previous image.

    ![imagecr9h.png][img6]

4. Under the **Build** menu, click **Build Solution**, or press the F6 key on the keyboard, to restore NuGet packages and build the solution file.

    ![imagewsa7m.png][img7]

5. From the **Debug** menu, click **Start Debugging**, or press the F5 key. Observe that the application runs and opens in the browser.

    ![imagem4ykq.png][img8]

6. Click the **Login** or **Contacts** link. The browser navigates to the SuperOffice SuperID sign-in page.

7. At this point, if you have multiple tenants, a list of available tenants is shown. Choose **a tenant** to grant access to your application.

    ![imageanls.png][img9]

8. If this is the 1st time accessing this tenant via this application, a consent dialog appears asking for application approval to gain access to your web service resources. Click **I approve**.

    ![imagepy4jr.png][img10]

9. The browser callback is shown and navigates to the website's index page showing the list of claims and tokens.

    ![imagexa6xa.png][img11]

10. Click the **Contacts** link and a list of all the contacts in the tenant will appear. This provides the opportunity to create a new company, or edit the name and department values for the listed companies.

    ![image8ao5w.png][img12]

## Next steps

Analyze the code.

The *Startup.cs* file contains information that:

* sets `Antiforgery` cookie accordingly so that form posts work as expected in an iframe
* sets the `SameSite` cookie to None by default, and to Unspecified in older browsers
* sets up the sign-out URL accordingly

The *ContactDbContext.cs* file acts as a local cache for Contact entities, as well as facilitates called to the SuperOffice WebApi REST API.

The *SoHttpRestClient.cs* file is an `HttpClient` helper class to make REST requests.

If you have any issues with the sample, please post an issue on the [repo issues page][10].

<!-- Referenced links -->
[2]: ../../../superoffice-docs/docs/apps/getting-started/get-app-keys.md
[3]: ../../../superoffice-docs/docs/apps/terminology.md
[4]: index.md
[5]: ../authentication/online/sign-in-user/auth-code-flow.md
[6]: ../../../superoffice-docs/docs/apps/manage/update-app.md
[7]: https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi
[8]: ../../../superoffice-docs/docs/apps/getting-started/app-envir.md
[10]: https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi/issues

<!-- Referenced images -->
[img1]: media/imageb65a.png
[img2]: media/image8z7wl.png
[img3]: media/image4oqhj.png
[img4]: media/imagetudj9.png
[img5]: media/image8m8u.png
[img6]: media/imagecr9h.png
[img7]: media/imagewsa7m.png
[img8]: media/imagem4ykq.png
[img9]: media/imageanls.png
[img10]: media/imagepy4jr.png
[img11]: media/imagexa6xa.png
[img12]: media/image8ao5w.png

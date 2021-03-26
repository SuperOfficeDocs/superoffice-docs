---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: set_up_reverse_proxy_iis # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Setting up a Reverse proxy on IIS8 for SuperOffice onsite # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: security
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: online                # cloud or onsite
so.client: web                 # online, web, win, pocket, or mobile
---

# Setting up a Reverse proxy on IIS8

Our recommended deployment scenario uses Reverse proxy on the DMZ server to access the internal server where SuperOffice Sales and Service are installed.

> [!NOTE]
> SuperOffice 8.1 requires that our clients are located on the same domain as seen from the users browser. This means `service.myorganization.com` and `crm.myorganization.com` from version 8.1 must be `socrm.myorganization.com/service` and `socrm.myorganization.com/sales`. It is not required to put Service in a subfolder, but it makes generating the URL rewrite rules a lot easier.

**Platform:** Windows Server 2012 R2 Standard

**Preparations:**

* An internal site installed in the Internal Server Network
* A public site in the DMZ available from the Internet (see [Scenario #2][1]

## Reverse Proxy on DMZ server

Install Web Server (IIS) using the **Add roles and Features Wizard** from the Server Manager Dashboard.

![Add roles and features wizard][img1]

Open the IIS Manager on the server level and on the right hand side under Actions select Get New Web Platform Components.

![2018-10-17_16-31-02.png][img2]

Download and install the Web Platform Installer which is an extension to the IIS Manager console.

![blobid0.png][img3]

Run it, select Products tab and find **Application Request Routing 3.0**. This will allow the server to function as a reverse proxy, proxying requests coming from users, to the NetServer.

![Application Request Routing 3.0][img4]

### Changes in Reverse proxy

1. Open up Application Request Routing Cache on the root node of the IIS server.
2. Click **Server proxy settings** on the right-hand menu.
3. Uncheck **Reverse rewrite host in response headers**.

![x][img5]

4. Click **Apply**.

From 8.1 we require our products (Sales and Service) to be installed on the same domain since authentication is only done by the Sales web client.

To set up support for your SuperOffice installation, we recommend setting up one site for SuperOffice Service and SuperOffice Sales web client. The site is just an empty shell which is not serving any content itself, but is only redirecting requests to the correct place. To illustrate, a potential setup could have SuperOffice Service at **socrm.myorganization.com/service** and SuperOffice CRM at **socrm.myorganization.com/sales**.

Set up the site as follows:

* Right-click the **Sites** folder in the **Connections** pane in IIS manager and click **Add website**.
* Give the site a descriptive name. If the site will redirect SuperOffice Service requests, name it **SuperOffice Service**.
* Set the **physical path** to an empty folder, for instance, create a folder at *C:\\SuperOfficeService*.
* Leave the binding type to **HTTP** for now and choose the correct IP-address you want the webserver to listen on.
* Enter the hostname that the site should respond to, for instance, `socrm.myorganization.com`

For each site we need to set up some URL-rewrite rules so that the requests hitting our proxy server will be redirected to the correct place. If both clients are installed on the same IIS site internally then we only need one rule set up.

Select the site and click **URL Rewrite**.

![URL Rewrite][img6]

Select **Add Rule(s)** from the action pane on the right and add a **Reverse Proxy** rule.

![Add reverse proxy rule][img7]

In the **Add Reverse Proxy Rules** dialog, enter the DNS hostname of the internal server that is hosting SuperOffice. For instance, when setting up proxy rules for SuperOffice where both Sale and Service is installed internally on the same site `socrm.INTERNAL.myorganization.com`, then  add `socrm.INTERNAL.myorganization.com` in the Server name of the rule. Uncheck the **Enable SSL Offloading box** and click **OK**.

![x][img8]

If you only want to expose Sales and this is installed on the internal server under `socrm.INTERNAL.myorganization.com/SuperOffice` then we need to modify the inbound rule to look like the following:

![x][img9]

Make sure that the proxy server can reach the internal servers and that it can resolve the DNS names that have been defined in the URL-rewrite rules.

The final rules should look something like this:

![x][img10]

Note that the CRM rule does not allow HTTPS in the **Action URL**, this should be changed when setting up HTTPS for the servers, but for now we can keep it at HTTP. Try browsing to the proxy server and to see if the rules are working properly. In my case I would browse to the following URLs. Note that only HTTP has been set up:

```text
http://socrm.myorganization.com/Sales
http://socrm.myorganization.com/Service/scripts/rms.fcgi
```

Add an outbound rule for the location header:

1. Add rule

![x][img11]

2. Enter the following values:

![x][img12]

* Name: **Rewrite location**
* Matching scope: **Server variable**
* Variable name: **RESPONSE\_LOCATION**
* Pattern: **(https?)://socrm.INTERNAL.myorganization.com(.\*)**
* Action: **Rewrite**
* Action properties:  **{R:1}://socrm.myorganization.com{R:2}**
* Replace existing server variable must be **checked**

## Application pool settings

To make sure the WCF services are working correctly, you have to change some settings in the application pool. Right click on the application pool and click on advanced settings. Under the category **General** you will find an option called **.NET CLR Version**. Change this option to **No Managed Code** in the drop-down menu.

### No Managed Code

This option is for applications that do not use the .NET framework. Since the App Pool is a proxy to forward requests, the .NET runtime is not needed.

![x][img13]

## Web Tools

To make Web Tools go through our proxy, we need to edit the *web.config* file of SuperOffice. In the `<client>` section, change the key **UrlHostOverride** to point to the hostname of the proxyserver.

![x][img14]

```xml
<add key="UrlSchemeOverride" value="http" />
<add key="UrlPortOverride" value="80" />
<add key="UrlHostOverride" value="socrm.myorganization.com" />
```

When enabling HTTPS, the value **UrlPortOverride** should be changed to **443** and **UrlSchemeOverride** should be changed to **HTTPS**. Note that to make HTTPS work with Web Tools, the certificate used on the proxy server needs to be a valid, signed certificate, otherwise the Web Tools client will not be able to make a connection. Self-signed certificates won't work.

Make sure that the **Client** section in the *web.config* file is defined at the top of the file inside the `<configSections>` directive. The screenshots below show what the file should look like.

![x][img15]

![x][img16]

If clients are unable to download the web tools client, then you need to allow communication to `https://www3.superoffice.com` which is our Download service.

## Changes in Service

The URLs for the Internal and External URL must be updated to match the external address.

![x][img17]

Or update directly in the database table called `<prefix>.config` - fields `cgi_url` and `cgi_url_internal`.

Note - running on HTTPS

SuperOffice Service may not use NetServer web services running on HTTPS, this means you have to use a nsEndPoint address in Service config file that use http:// and not https://

```html
[More info](javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions("ctl00$plhFullWidthContentArea$propMainBody$ctl00$ctl38$ctl00$btnBanner", "", false, "", "javascript:%20return%20false;", false, true)) "More info")
```

### Note regarding upgrades

To make sure later updates of Service runs successfully on the Internal web server, add a new registry key below *HKey\_Locale\_Machine\\Software\\Wow6432Node\\SuperOffice* Customer Service on the Internal webserver. This key should have the same string values as the internal site (basePath and instanceId), but the name of the key should be the same as the external website (proxy URL).

![x][img18]

Now when upgrading you will provide the external URL when it asks for the domain and it will not fail when it comes to the point where it should start EjScheduler here:

![x][img19]

## Using more than one internal webserver to redirect traffic to

To be able to redirect to several internal web services you need to add the following section to the *web.config* file in the `<configuration>` section on the proxy server.

```xml
<system.serviceModel>
  <serviceHostingEnvironment aspNetCompatibilityEnabled="true" multipleSiteBindingsEnabled="true" />
</system.serviceModel>
```

![x][img20]

Multiple site bindings enable multiple base addresses (enables the proxy to forward to multiple hosts).

### Exposing just the external customer parts of Service to the Internet

If you just want to expose the Customer center, Chat, or Mailings to the Internet, then you may only expose `socrm.myorganization.com/service/scripts/customer.exe/fcgi`. In addition, the static files need to be exposed as well. We do not have a strict categorization on which files need to be exposed and we do not see a security issue with exposing them, so our recommendation is to expose all static Service files (*/javascript*, */graphics*, and */css* with sub-folders. These files are the static files we distribute through our installers and no customer-specific files are located in these folders.

<!-- Referenced links -->
[1]: ../../security/deployment-scenarios.md

<!-- Referenced images -->
[img1]: media/server-role-security.jpg
[img2]: media/2018-10-17_16-31-02.png
[img3]: media/blobid0.png
[img4]: media/applicationrequestrouting.jpg
[img5]: media/reverserewritehost.png
[img6]: media/serviceurlrewrite.jpg
[img7]: media/reverseproxyrules.jpg
[img8]: media/addreverseproxyrule1.png
[img9]: media/editinboundrulenew.png
[img10]: media/finalrule1.png
[img11]: media/outboundrulelocationheader.png
[img12]: media/outboundrule1.png
[img13]: media/apppoolnomanaged.png
[img14]: media/clientconfig1.png
[img15]: media/configsections.png
[img16]: media/client_section_definition.png
[img17]: media/systemsettingsconfigurl.png
[img18]: media/registryadded.png
[img19]: media/regkey.png
[img20]: media/webconfigproxy.png

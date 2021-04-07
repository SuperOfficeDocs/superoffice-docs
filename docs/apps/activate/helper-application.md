---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: helper_application       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Helper for private applications # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Helper for private applications

Most custom (private) applications struggle getting started due to the bare minimum requirements.

The biggest hurdles most private applications have include:

* understanding the requirement to conduct an interactive installation
* setup a website to handle the redirect URL

## Required interactive installation

Even private applications must be granted permission to access tenant resources. Therefore, just like when a tenant administrator installs a public application from the SuperOffice App Store, private applications must also perform an interactive login sequence to prompt the user with the **Approval** page.

![AllowScreen.png][img1]

This login sequence is expected to be performed by the private application. Historically this step has required that you understand how to create a web application configured to authenticate using OpenID Connect.

Sometimes it may seem unnecessary, even overwhelming, to build a website *just* to authenticate with OpenID Connect. However, it’s the only way to establish an authorization contract between your private application and the tenant installation.

Nearly all private applications perform their tasks using non-interactive server-to-server communication, and therefore require the system user security token to do so. Because the `system user token` is only generated during the approval process, the only way to get this token is by receiving the `id_token` at the application’s redirect URL.

## Handle redirect URL

As stated in the previous section, an interactive installation sequence is performed using an OpenID Connect authentication flow. Once authentication is successful, the approval page is presented. When you click **I approve**, SuperOffice generates three OpenID Connect tokens and sends those back to your registered redirect URL. The three tokens are:

* `id_token`
* `access_token`
* `refresh_token`

Contained in the `id_token` is the `system user token`. This claim is necessary to carry out non-interactive server-to-server communications.

The `id_token` is a base64 encoded JSON Web Token (JWT), signed by SuperOffice when generated. While it is easy to decode it and extract the claims within, it’s recommended you validate the token to certify it has not been tampered with during transit.

Both the token validation and claim extraction adds additional layers of complexity *just* to build a private application. To help you get started faster, we have created a sample application that circumvents the above requirements.

## Introducing DevNet-tokens

We have [published a web application][1] that will help consultants get over the initial hurdles for building private online customizations.

To **use** the published web application as a helper, you must tell SuperOffice to add it's **redirect URL** to your registered application. You can have more than one redirect URLs. The redirect URL for the helper is:

`https://devnet-tokens.azurewebsites.net/openid/callback`

First created as an OpenID Connect/PassportJS code sample, the [source code][2] has evolved to make it easy for private applications to easily overcome the basic requirements.

All you need to do is navigate to it online and select **Sign In**.

![SignIn.PNG][img2]

On the next page, select your target environment and supply your applications `client_id` and `client_secret`, then select **Sign in**.

![SelectEnvironment.PNG][img3]

You are redirected to SuperOffice SuperID for authentication. Enter your username, then select **Next**.

![SuperIDEmail.png][img4]

Once authentication is successful, one of two things will appear.

If your SuperID user is associated with multiple tenants, you will first be presented with a tenant selection screen. Select the tenant you wish to associate with this `client_id` (private application).

![SelectTenant.png][img5]

You are shown the **Allow** page. Select **I approve** to continue.

![AllowScreen.png][img6]

Finally, you will be redirected to the DevNet-tokens account page where you may collect the system user token.

![AccountPage.png][img7]

This application is also useful when you want a fast way to get an access token and, using your favorite REST client, start to making REST calls to your tenant web API REST web services.

Another useful feature of this application, is the possibility to convert an RSA XML file into the PEM format. This is a common certificate format used for platforms such as NodeJS and PHP.

When signed in, you can use the **Token to Ticket** wizard to sign your system user token and send that off to SuperOffice to obtain a system user ticket credential. This doesn’t really have any practical benefits, but is included in the sample application source code for NodeJS demonstration purposes.

We also have samples that demonstrate how to exchange a system user token for a system user ticket in [.NET][3], [.NET Core][4], [PHP][5] and [Python][1].

<!-- Referenced links -->
[1]: https://devnet-tokens.azurewebsites.net/
[2]: https://github.com/SuperOffice/node-express-convert-certs-and-sys-token
[3]: https://github.com/SuperOffice/SuperOffice.DevNet.Online/tree/master/Source/SuperOffice.DevNet.Online.SystemUser.ServiceConsole
[4]: https://github.com/SuperOffice/SuperOffice.DevNet.Online.SystemUser.NetCore.Console
[5]: https://github.com/SuperOffice/devnet-php-oidc-soap
[6]: https://github.com/SuperOffice/devnet-python-system-user

<!-- Referenced images -->
[img1]: media/allowscreen.png
[img2]: media/signin.png
[img3]: media/selectenvironment.png
[img4]: media/superidemail.png
[img5]: media/selecttenant.png
[img7]: media/accountpage.png

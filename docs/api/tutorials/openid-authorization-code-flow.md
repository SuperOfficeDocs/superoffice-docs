---
title: OpenID Authorization Code flow
uid: oidc_auth_code_flow
description: OpenId Authorization Code flow
author: {github-id}
keywords:
so.topic: tutorial
so.envir: cloud
# so.client:
---

# OpenID Authorization Code flow

We will make a simple app that displays some information about recently added contacts in a web panel.

We will use the **Authorization Code** flow with 3 URLs:

* `/` Check if logged in: if not logged in, start login process with SuperID
* `/callback` Receive a call from SuperID login; call SuperID to get access token.
* `/app` Use the access token to get a list of contacts from SuperOffice.

The user will access the `/` URL or the `/app` URL and is redirected to SuperID because the app is not logged in.

SuperID will log the user in, and post back to `/callback` with the access tokens.

Once the access tokens are stored in the app session, calling `/app` will call the SuperOffice API to get a list of contacts and show them in a simple table.

## Make an Empty MVC App

![empty MVC app][img1]

Choose the **Empty** template but check the MVC reference.

![empty MVC template][img2]

This will get us a simple, clean folder structure:

![empty-folder-structure][img3]

You can run it and you should get a nice error page because we haven’t defined any views yet.

![1526999139989][img4]

If we take a peek at the *App_Start/RouteConfig.cs* file, we can see the default controller is **Home**, with default action **Index**.

```csharp
public static void RegisterRoutes(RouteCollection routes)
{
  routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
  routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
  );
}
```

## Add a Home controller

![home-controller-add][img5]

![home-controller-scaffold dialog][img6]

Name it **HomeController**. This is our main entry point. This is the starting point.

* If we are logged in, we want to redirect to the application logic that actually does the work.
* If we are not logged in, we want to kick off the log-in process with SuperID.

## Add home view

![home-view-add][img7]

![home-view-dialog][img8]

This will add some more packages to the project, but now we have a website.

![home-view-index][img9]

This homepage is just a placeholder, it will only be shown if there is an error.

## Set up IIS

The default is to use IIS Express, which runs on a non-standard port. Since our app is defined with a redirect URL of *Localhost/MvcTest*, we need to switch over to use IIS.

![iis config][img10]

## Add NuGet packages

![1526999538189][img11]

Add the **SuperOffice.CRM.Online.Core** package so we can decode the SuperID responses. This will also add the `System.IdentityModel.Tokens.JWT` package.

If we were going to use SOAP we would add `SuperOffice.NetServer.Services` – this would add the client code needed to talk to the web services API via SOAP. This will also bring in the `SuperOffice.NetServer.Core` package with the shared definitions. We are going to use REST APIs, so we don’t need these.

We will need to call SuperId from the server, so we need a REST client, like [RestSharp][1].

![restsharp][img12]

## Add app settings to web.config

The `SuperOffice.CRM.Online.Core` package has also added some app settings to the *web.config* file that we need to tweak.

```XML
<add key="SoAppId" value=""/>
<add key="SoFederationGateway" value="https://sod.superoffice.com/login/"/>
<add key="SuperIdCertificate" value="16b7fb8c3f9ab06885a800c64e64c97c4ab5e98c"/>
```

The gateway URL and the certificate id are fine, we don’t need to change these.

The `SoAppId` we need to fill in. We also need to add a couple of more settings for later.

```XML
<add key="SoAppId" value="a43a2b7a9302b4921881fcb75d578dc2"/>
<add key="SoAppToken" value="967a48226c9b343f6134b450f6bdfa2b"/>
<add key="SoAppUrl" value="https://localhost/mvctest/callback"/>
```

## Add X509 certificate to App_Data

Add the file *SOD_SuperOfficeFederatedLogin.crt* to the *App_Data* folder.

You can find the file in the <a href="../assets/downloads/superofficeonlinecertificates.zip" download>Online certificates ZIP</a>.

We need this X509 certificate to verify that the tokens we have received are actually from SuperId, and not from some hacker trying to trick us.

## Implement the home controller

The default action is to see if we are logged in and if we are not, then redirect to SuperId to get logged in. When SuperID is finished, it will redirect back to us, to our callback URL (`SoAppUrl` in the config file)

If we are logged in, we need to pass a bunch of parameters to SuperID’s OAuth URL, as described in [the documentation][3].

[!code-csharp[CS](includes/get-redirect.cs)]

To kick off the log-in process, we pass a random value as the `State` parameter. We store this in the `Session` so that we can check it later.

How do we know if we are logged in? We will put the access token we get into the server’s `Session` array when we get called back.  So if the `Session["LoggedIn"]` value is NULL, then we are not logged in. SuperID will call the `appUrl` (`https://localhost/mvctest/callback`) with values we can use to get the access and refresh tokens.

## Add a callback controller

![1526999798984][img13]

Add an empty controller, call it **CallbackController**.

The Callback controller is called from SuperID with two values: **state** and **code**

[!code-csharp[CS](includes/actionresult.cs)]

To handle the Authorization Code, we check the State value we stored earlier.

If they match, we can call the `OAuthHelper*` class to handle making a POST request to SuperID to get the OAuth refresh and access tokens. The SuperID response will also include a JWT which contains the URL for the REST API.

If the helper class did not throw an error, then we are logged in and we can move over to the actual app, which lives over in the **AppController**.

## Add OAuthHelper class

We need to get tokens from SuperID, using **RestSharp**, so we will put this into a separate class: `OAuthHelper`. RestSharp is a smart HTTP client that handles JSON for us. It can automatically de-serialize JSON for us if we define a class that looks like the response we get. SuperID’s response to an OAuth request looks like this:

```http
Response to POST to /login/common/oauth/tokens
{
"token_type": "Bearer",
"access_token": "8A:Cust12020.AR2s3phb0gXK8DP0NfoYlsrQAQAACIJ/KQ+cbGp0l9g8PJNlBCEZpsfT8F4XwFlYBjvw6xmM086Vckm0Mmh+fEPuoLspl+EgtQzD0F8Ka4qLFGWICvUg==",
"expires_in": 3600,
"refresh_token": "KSamN1Tp4sd26pZJSGK6JobrWOUWorIZ2Y5XxcAqX86F4fiT3",
"id_token": "eyJ0eXAiVRKZkVxMTZZdyJ9.eyJzdWIiOiJ0b255LnlhdGVzQHN1cGVyb2ZmaWNlLmNvbSIsImh0dHA6Ly9zY2hlbWVzLnN1cGVyb2ZmaWNlLm0dHBzOi8vc29kLnN1cGVyb2ZmaWNlLmNvbSIsImF1E1MTYyOTk1OTZ9.jVW0KWtOeaYV4V3372rSVosPQqlOsaOj6-Oew_Ompe9GZ932aQi6tcc7uXdaz9jmBgLh8mlIZWyW4rFcTnyLQzjjK3nSYWNxxvobQRntigD1KANvNNT3smxec6ST-j1uCUBCQrVNxILapXiUrJER4aMmAbFweWs9bbgfhR9_sQVQDmLbVw"
}
```

So we can make a class that matches the properties in the response, and RestSharp will map everything for us:

[!code-csharp[CS](includes/tokensresponse.cs)]

Now to get the token from SuperId we need to make the `OAuthHelper` class:

[!code-csharp[CS](includes/oauthhelper.cs)]

Before we store the tokens in the session, we must make sure that the JWT token is valid (signed by SuperID). If the tokens come from somewhere else, we need to reject the request.

[!code-csharp[CS](includes/storetokensinsession.cs)]

To validate the token, we use an X509 certificate and the **SuperIdTokenHandler** from the `Online.Core` package we added earlier.

[!code-csharp[CS](includes/validatetoken.cs)]

If the token is valid, a token object is returned, otherwise, an exception is thrown.

A valid token means that we can store the tokens in the Session object, which is what we started out checking for. When we get here, we are logged in.

## Add callback view

Add an Index view that can display an error message. The model for the view is just a string.

We add an `@model` string directive to the top of the view and use it to display the error message using `@model`

```html
@model string

@{
    ViewBag.Title = "Callback";
}

<h2>Callback</h2>

<h1>Error: @Model</h1>
```

The view is only displayed if the callback controller encounters an error:

```csharp
catch( Exception ex)
{
  object model = ex.Message;
  return View(model);
}
```

## Add an app controller

This is where the main app logic will go. We are logged in at this point, and we have an access token and a refresh token in our session state.

First, we check that the access token is set.

Then we check if the access token has expired. If it has, we need to get a new access token using the refresh token.

Then we can go get some data from the SuperOffice API, and use it to render a view.

[!code-csharp[CS](includes/appcontroller.cs)]

To refresh the Access token we use the OAuth helper we made before:

[!code-csharp[CS](includes/refreshaccesstoken.cs)]

Finally, we are ready to get the data from SuperOffice:

[!code-csharp[CS](includes/getdatafromso.cs)]

We are setting the authorization header to BEARER + the access token.

We are forcing RestSharp to get JSON rather than XML from the OData endpoint we are calling.

The OData v4 response looks like this:

```json
{
  "odata.metadata": "http://host/service/$metadata",
   "value": [
    {
      "name": "Orders",
      "kind": "EntitySet",
      "url":  "Orders"
    }]
}
```

So we need to make a serialization class that RestSharp can put the data into:

```csharp
public class ODataResponse
{
  public List<ContactModel> value { get; set; }
}
```

We don’t care about the OData meta-data link, so we don’t include it in our class.

We use a List rather than an Array to work around a problem with array constructors in the JSON serializer in RestSharp.

## Add app and contact models

Add two classes to *Models* folder: `AppModel` and `ContactModel`. These classes are used in the `ODataResponse`, and as the view-model for rendering the App index view.

The `AppModel` describes the App user interface.

[!code-csharp[CS](includes/appmodel.cs)]

The `ContactModel` describes the OData response we get back.

[!code-csharp[CS](includes/contactmodel.cs)]

## Add app view

![app-view][img14]

This generates an almost empty page for us. We need to render some information to it, using the `AppModel` instance:

```html
@model MvcTest.Models.AppModel
@{
    ViewBag.Title = "App";
}
 
<h2>App</h2>
@if (Model.Error != null)
{<h1>@Model.Error</h1> }
else
{
<p>This is where the app logic goes.</p>
<p><a href="@Model.BaseUrl">@Model.BaseUrl</a></p>
<p>Access token: @Model.AccessToken </p>
<p>Token expires: @Model.TimeLeft </p>
 
<table>
  <tr>
    <th>Name</th>
    <th>Category</th>
    <th>Created</th>
  </tr>
  @foreach (var item in Model.Contacts)
  {
    <tr>
      <td>@item.nameDepartment</td>
      <td>@item.category</td>
      <td>@item.registeredDate</td>
    </tr>
  }
</table>
}
```

## Ready to run

We are now ready to run the app!

Start the debugger (F5):

The browser and the app starts.

The Home controller does not find an access token in Session, so it redirects to SuperID

`https://sod.superoffice.com/Login/?oauth=1&sctx=eyJQYXJ0bmVyUmVkaXJlY3RVcmwiOm51wiUHJvbXB0IjpudWxsLCJJc0xvZ2dpbmdPdXQiOmZhbHNlLCJQb3N0TG9nb3V0UmVkaXJlY3RVcmwiOm51bGwsIkZlZFJlbWVtYmVyTWUiOmZhbHNlLCJOb25jZSI6bnVsbH0%3D`

SuperID has not set up a session for you yet, so it shows a login form:

![1527000848549][img15]

## Approve screen

![1527000875326][img16]

SuperID sees that this is the first time this app has called this particular tenant, so it shows an approval screen for the app.

If you click **I APPROVE** button, the authorization flow continues. The next time the app is run, the approval screen is not shown, since the approval is registered on the app + tenant.

SuperID redirects back to the callback URL we passed to SuperId at the start of the process.

## Callback call

SuperID redirects to `https://localhost/MvcTest/callback?state=1234&code=43IOJXjasdxy`

The Callback controller uses these to get a refresh + access token from SuperId directly.

Having gotten a valid JWT token from SuperId, it redirects to the App controller.

## App call

The application checks that we have an access token, and uses it to get a search result from SuperOffice. It then renders a page containing the search result.

The application calls

`https://sod.superoffice.com/Cust1234/api/v1/Contact?$select=contactId,nameDepartment,category,business,number,registeredDate`

with the Authorize header containing a Bearer access token.

This returns a simple JSON object containing an array of row objects.

This is rendered as a table using the App Index view:

![1527001011364][img17]

<!-- Referenced links -->
[1]: https://github.com/restsharp/RestSharp
[3]: ../authentication/online/index.md

<!-- Referenced images -->
[img1]: media/1526999027785.png
[img2]: media/empty-template.png
[img3]: media/empty-folder-structure.png
[img4]: media/server-error.png
[img5]: media/home-controller-add.png
[img6]: media/home-controller-scaffold.png
[img7]: media/home-view-add.png
[img8]: media/home-view-dialog.png
[img9]: media/home-view-index.png
[img10]: media/iis-config.png
[img11]: media/nuget-packages.png
[img12]: media/restsharp.png
[img13]: media/callback-controller-add.png
[img14]: media/app-view.png
[img15]: media/approve-login.png
[img16]: media/login-approve.png
[img17]: media/app-index-render.png

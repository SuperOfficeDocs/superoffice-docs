---
title: How to build your OAuth native app flow
uid: native_app_flow_tutorial
description: How to build your OAuth native app flow
author: {github-id}
keywords: oidc, authentication
so.topic: tutorial
so.envir: cloud
so.client: online
---

# How to build your OAuth native app flow

A native application is either a mobile application or application that runs on an operating system in a windowed frame, windowless service, or console application. This type of application is **not** the same as a browser-based web application.

Let's look at how to use IdentityModel’s OpenID Connect (OIDC) client library to authenticate towards SuperOffice SuperID using the native app workflow. It demonstrates how to set the required OpenID Connect options.

This guide uses a .NET Framework console application and is a copy of the [IdentityModel GitHub project][1] page.

There are a couple of extra lines of code to be aware of for SuperOffice SuperID, after setting the [client options][2]. You can [download the example code][3].

**Pre-requisites:**

* you have a tenant with a user for testing sign-on
* you have to have registered your application with a redirect URI of `http://127.0.0.1\:\d{4,10}/desktop-callback`
* you have received a unique application [client ID and secret][4]

## Set up your tools

1. In Visual Studio, create either a .NET Core or .NET Framework console application.

2. In the Package Manager Console, install the **IdentityModel OpenID Connect** client using the following command:

`Install-Package IdentityModel.OidcClient`

## Get started

1. Create a redirect URI using an available port on the loopback address `"^http://127.0.0.1\\:\\d{4,10}/desktop-callback$"`. You are free to use any path text instead of *desktop-callback*.

    ```csharp
    string redirectUri = string.Format("http://127.0.0.1:7890/desktop-callback/");
    ```

2. Create an **HttpListener** to listen for requests at that redirect URI:

    ```csharp
    var http = new HttpListener();
    http.Prefixes.Add(redirectUri);
    http.Start();
    ```

3. Set the OpenID Connect **client options**:

    ```csharp
    var options = new OidcClientOptions
    {
      Authority = "https://sod.superoffice.com/login",
      LoadProfile = false,
      ClientId = "YOUR\_APPLICATION\_ID",
      ClientSecret = "YOUR\_APPLICATION\_TOKEN",
      Scope = "openid profile api",
      RedirectUri = "http://127.0.0.1:7890/desktop-callback",
      ResponseMode = OidcClientOptions.AuthorizeResponseMode.FormPost,
      Flow = OidcClientOptions.AuthenticationFlow.Hybrid,
    };
    ```

4. Set the following **policy options** to ensure a smooth experience:
    * Validates the issuer name
    * Requires the response includes a token hash

    ```csharp
    options.Policy.Discovery.ValidateIssuerName = false;
    options.Policy.RequireAccessTokenHash = false;
    ```

5. Instantiate the OpenID Connect client, passing in the client options. Then call the `PrepareLoginAsync` method to validate the configuration options and set the nonce and state:

    ```csharp
    var client = new OidcClient(options);
    var state = await client.PrepareLoginAsync();
    ```

6. Open a system browser and then wait for the authorization response:

    ```csharp
    Process.Start(state.StartUrl);
    var context = await http.GetContextAsync();
    ```

7. Get the request body:

    ```csharp
    var formData = string.Empty;
    if (context.Request.HasEntityBody)
    {
        using (var body = context.Request.InputStream)
        {
            using (var reader = new System.IO.StreamReader(
                body,
                context.Request.ContentEncoding))
            {
                formData = reader.ReadToEnd();
            }
        }
    }
    ```

8. Send a useful reply to the browser before processing the JWT. For example, give a warning message informing that the browser is about to re-direct to the help center, and set the refresh properties to do so after 5 seconds.

    ```csharp
    // sends an HTTP response to the browser.
    var response = context.Response;
    // create HTML to send to the browser
    string responseString =
    @"<html>
        <head>
            <meta http-equiv='refresh'
                  content='5;url=https://community.superoffice.com'>
        </head>
        <body>
            <h1>Redirecting you to the SuperOffice Help Center...</h1>
        </body>
    </html>";
    // convert the markup to byte\[\] format
    var buffer = Encoding.UTF8.GetByte(responseString);
    response.ContentLength64 = buffer.Length;
    // get the response output stream to write to
    var responseOutput = response.OutputStream;
    // write the HTML to the output stream
    // and then close the stream.
    await responseOutput.WriteAsync(buffer, 0,buffer.Length);
    responseOutput.Close();
    ```

9. Process the result by sending the formData result to ProcessResponseAsync:

    ```csharp
    var result = await client.ProcessResponseAsync(formData, state);
    ```

## What do I get back from the server?

The result from ProcessResponseAsync is a **LoginResult**, which contains all of the details you might expect, such as the [access token][5] and [refresh token][5].

Other libraries may name their login result container something differently, but they should all contain the key elements.

```csharp
namespace IdentityModel.OidcClient
{
  public class LoginResult : Result
  {
    public virtual ClaimsPrincipal User { get; internal set; }
    public virtual string AccessToken { get; internal set; }
    public virtual string IdentityToken { get; internal set; }
    public virtual string RefreshToken { get; internal set; }
    public virtual DateTime AccessTokenExpiration { get; internal set; }
    public virtual DateTime AuthenticationTime { get; internal set; }
    public virtual HttpMessageHandler RefreshTokenHandler { get; internal set; }
  }
}
```

The following code fragment shows how you can access the user's claims to obtain the tenant's SOAP or REST web service endpoints:

```csharp
if (!result.IsError)
{
   // iterate over the list of claims
    foreach (var claim in result.User.Claims)
    {
        Console.WriteLine("{0}: {1}", claim.Type, claim.Value);
    }

    // write out the access token
    Console.WriteLine("Access token:\\n{0}", result.AccessToken);

    // if present, write out the refresh token
    if (!string.IsNullOrWhiteSpace(result.RefreshToken))
    {
        Console.WriteLine("Refresh token:\\n{0}", result.RefreshToken);
    }

    // get the base NetServer SOAP Endpoint
    string soapUrl = result.User.Claims.Where(c => c.Type.Contains("netserver_url")).Select(n => n.Value).FirstOrDefault();

    // get the base NetServer REST Endpoint
    string restUrl = result.User.Claims.Where(c => c.Type.Contains("webapi_url")).Select(n => n.Value).FirstOrDefault();
}
else // write out the authentication error
{
    Console.WriteLine("\\n\\nError:\\n{0}", result.Error);
}
```

## Troubleshooting

The **IdentityModel.OidcClient** package has a fairly long list of dependencies that will also be installed and listed in the *package.config* file.

Some of the packages in the .NET Framework sample may not update assembly references in the *app.config* file. If you make any changes, such as installing a new package, and run the application only to observe the following exception, you may have to examine the *app.config* file and update the `assemblyBindings` accordingly.

![Exception.png][img1]

Here, several of the assemblies were listed in the `assemblyBinding` element and needed to be updated from version 4.1.2.0 to 4.3.0 (installed with the packages).

I had to update the dependent versions from 4.1.2.0 to 4.0.3.

```xml
<runtime\>
  <assemblyBinding xmlns\="urn:schemas-microsoft-com:asm.v1"\>
    <dependentAssembly\>
      <assemblyIdentity name\="Newtonsoft.Json" publicKeyToken\="30ad4fe6b2a6aeed" culture\="neutral" />
      <bindingRedirect oldVersion\="0.0.0.0-11.0.0.0" newVersion\="11.0.0.0" />
    </dependentAssembly\>
    <dependentAssembly\>
      <assemblyIdentity name\="System.Runtime" publicKeyToken\="b03f5f7f11d50a3a" culture\="neutral" />
      <bindingRedirect oldVersion\="0.0.0.0-4.1.2.0" newVersion\="4.3.0" />
    </dependentAssembly\>
    <dependentAssembly\>
      <assemblyIdentity name\="System.Diagnostics.Tracing" publicKeyToken\="b03f5f7f11d50a3a" culture\="neutral" />
      <bindingRedirect oldVersion\="0.0.0.0-4.2.0.0" newVersion\="4.3.0" />
    </dependentAssembly\>
    <dependentAssembly\>
      <assemblyIdentity name\="System.Reflection" publicKeyToken\="b03f5f7f11d50a3a" culture\="neutral" />
      <bindingRedirect oldVersion\="0.0.0.0-4.1.2.0" newVersion\="4.3.0" />
    </dependentAssembly\>
    <dependentAssembly\>
      <assemblyIdentity name\="System.Linq.Expressions" publicKeyToken\="b03f5f7f11d50a3a" culture\="neutral" />
      <bindingRedirect oldVersion\="0.0.0.0-4.1.2.0" newVersion\="4.3.0" />
    </dependentAssembly\>
    <dependentAssembly\>
      <assemblyIdentity name\="System.Linq" publicKeyToken\="b03f5f7f11d50a3a" culture\="neutral" />
      <bindingRedirect oldVersion\="0.0.0.0-4.1.2.0" newVersion\="4.3.0" />
    </dependentAssembly\>
    <dependentAssembly\>
      <assemblyIdentity name\="System.Runtime.Extensions" publicKeyToken\="b03f5f7f11d50a3a" culture\="neutral" />
      <bindingRedirect oldVersion\="0.0.0.0-4.1.2.0" newVersion\="4.3.0" />
    </dependentAssembly\>
  </assemblyBinding\>
</runtime\>
```

<!-- Referenced links -->
[1]: https://github.com/IdentityModel/IdentityModel.OidcClient.Samples/tree/master/ConsoleSystemBrowser
[2]: native-app-quickstart.md
[3]: https://github.com/SuperOffice/SuperOffice.DevNet.OpenIDConnectNativeApp
[4]: ../../../superoffice-docs/docs/apps/terminology.md
[5]: ../authentication/online/api.md

<!-- Referenced images -->
[img1]: media/exception.png

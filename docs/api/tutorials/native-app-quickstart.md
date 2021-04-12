---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: native_app_quickstart       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Native console application quick-start # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Native console application quick-start

A quick-start guide for getting you up and running with a native console application.

## Before you begin

* you have a [tenant][1] with a user for testing sign-on

* you have [registered your application][2] with the following options:
  * OpenID Connect native app flow

    ![imaget19p.png][img1]

  * redirect URI of `^http://127.0.0.1\:\d{4,10}/desktop-callback$`

* you have received a unique application [client ID and secret][3]

* you have Visual Studio (community, professional, or enterprise edition)

## Quick-start

1. **Clone** or **download** the [SuperOffice.DevNet.OpenIDConnectNativeApp][4] from GitHub.

    `git clone https://github.com/SuperOffice/SuperOffice.DevNet.OpenIDConnectNativeApp.git​`

2. In Visual Studio, go to the *Source* directory and **open** the *SuperOffice.DevNet.OpenIDConnectNativeApp.sln* file.

    ![imageybe5d.png][img2]

3. Under the **Build** menu, click **Build Solution**, or **press** the **F6** key on the keyboard, to restore NuGet packages and build the solution file.

    ![x][img3]

4. From the **Debug** menu,  click **Start Debugging**, or **press** the **F5** key. Observe that the application runs and opens a console window.

    ![imagec4a0q.png][img4]

5. **Press** any key. The default browser window opens to the SuperOffice sign-in page.

    ![imagey4igu.png][img5]

6. At this point, if you have multiple tenants, a list of available tenants appear. Choose **a tenant** to grant access to your application.

    ![imagel1y3j.png][img6]

7. If this is the 1st time accessing this tenant via this application, a consent dialog appears asking for application approval to gain access to your web service resources. Click **I approve**.

    ![imageppiks.png][img7]

8. The browser callback is shown and eventually navigates to the SuperOffice community website. This default behavior is defined in the console application code.  

    ![x][img8]

9. The console application continues and dumps the contents of the response, including the `id_token`, `claims` and `access_token`.

    ![image6agno.png][img9]

## Next steps

At this point, you probably want to use `access_token` to send a request to the tenant's web services. The sample application uses the full .Net framework and you would, therefore, use the `WebRequest` class to send a request to the server to obtain data from the tenant.

The following code represents a basic method to issue a GET request that is later used to call the tenant web services.

```csharp
private static string GetData(string uri, string tokenType, string accessToken)
{
  HttpWebRequest httpWebRequest = WebRequest.CreateHttp(uri);
  httpWebRequest.Method = "GET";
  httpWebRequest.Accept = "application/json";
  httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, string.Concat(tokenType, " ", accessToken));
  var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
  using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
  {
    var responseText = streamReader.ReadToEnd();
    Console.WriteLine(responseText);
    return responseText;
  }
}
```

The 1st thing needed is the web service URL. In this case, I extract the base `webapi_url` (REST) and the current user's `associateId` from the claims.

```csharp
// result is the LoginResult provided by the OidcClient library used earlier in this sample

var webApiUrl = result.User.Claims.Where(c => c.Type.Contains("webapi_url")).Select(n => n.Value).FirstOrDefault();
var associateid = result.User.Claims.Where(c => c.Type.Contains("associateid")).Select(n => n.Value).FirstOrDefault();
```

Build up the search URL using a combination of the `webApiUrl` and the web service version URI to invoke an OData query against an archive provider search.

```csharp
// search the tenant for the companyId and personId of the logged in associate
// build up the OData query to perform a search using the InternalUsers archive provider
// https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-ArchiveProviders-InternalUsersArchiveProvider.htm

var uri = $"v1/Archive/InternalUsers?$entities=all&$select=contactId,personId&$filter=associateDbId eq {associateid}";

var queryResult = GetData(string.Concat(webApiUrl, uri), "Bearer", result.AccessToken);
```

### Search results

```javascript
{
  "odata.metadata": "https://sod.superoffice.com:443/Cust12345/api/v1/Archive//$metadata",
  "odata.nextLink": null,
  "value": [
    {
      "PrimaryKey": "5",
      "EntityName": "all",
      "personId": 5,
      "contactId": 2
    }
  ]
}
```

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/tenants/index.md
[2]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/get-app-keys.md
[3]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/terminology.md
[4]: https://github.com/SuperOffice/SuperOffice.DevNet.OpenIDConnectNativeApp

<!-- Referenced images -->
[img1]: media/imaget19p.png
[img2]: media/imageybe5d.png
[img3]: media/imageyxfai.png
[img4]: media/imagec4a0q.png
[img5]: media/imagey4igu.png
[img6]: media/imagel1y3j.png
[img7]: media/imageppiks.png
[img8]: media/imagergmjd.png
[img9]: media/image6agno.png

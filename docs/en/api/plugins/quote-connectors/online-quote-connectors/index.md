---
title: Online quote connectors
uid: online_quote_connector
description: Online quote connectors
author: SuperOffice Product and Engineering
keywords:
redirect_from: /en/api/netserver/plugins/quote-connectors/online-quote-connectors/index
---

# Online Quote Connectors

Quote connectors allow third parties to build a web service endpoint that supplies SuperOffice with product price-list and product details.

* [Online SOAP Quote Connector API][soap]
* [Online REST Quote Connector API][rest]

Use the [SuperOffice.Crm.Online.IntegrationServices][1] package to build a quote connector for SuperOffice Online. This has two package dependencies:

* [SuperOffice.Crm.Online.Core][2]
* [SuperOffice.NetServer.Services][3]

`SuperOffice.Crm.Online.Core` contains the authentication interface to successfully authenticate and connect to your quote connector web service endpoint.

`SuperOffice.NetServer.Services` is necessary because connectors often need to call the tenant's web services for additional information. The packet has additional dependencies.

In total you will have the following NuGet package dependencies:

* [SuperOffice.Crm.Online.Core][1]
* [SuperOffice.Crm.Online.IntegrationServices][2]
* [SuperOffice.NetServer.Core][9]
* [SuperOffice.NetServer.Services][3]
* [SuperOffice.ContinuousDatabase][4]
* [System.IdentityModel.Tokens.Jwt][5]

There is an example quote connector example included in our [SuperOffice.DevNet.Online][6] GitHub repository, located in the [IntegrationServer][7] folder. Take a look at the *README.md*  markdown file for more information.

> [!NOTE]
> The sample-project is for .Net Framework, as WCF is not officially supported in .Net Core. This is not a restriction in SuperOffice' packages, but an architectural decision made by Microsoft.

[!include[ask questions](../../../includes/get-help.md)]

Have fun building quote connectors for SuperOffice CRM Online!

<!-- Referenced links -->
[1]: https://www.nuget.org/packages/SuperOffice.Crm.Online.IntegrationServices
[2]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Core
[3]: https://www.nuget.org/packages/SuperOffice.NetServer.Services/
[4]: https://www.nuget.org/packages/SuperOffice.ContinuousDatabase/
[5]: https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt
[6]: https://github.com/SuperOffice/SuperOffice.DevNet.Online
[7]: https://github.com/SuperOffice/SuperOffice.DevNet.Online/tree/master/Source/SuperOffice.DevNet.Online.IntegrationServer
[9]: https://www.nuget.org/packages/SuperOffice.NetServer.Core/
[rest]: rest-quote-connector-api.md
[soap]: soap-quote-connector-api.md

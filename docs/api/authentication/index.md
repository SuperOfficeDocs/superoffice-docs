---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
uid: superoffice-authentication
description: Overview of SuperOffice API authentication.
author: AnthonyYates             # Your GitHub alias.
so.date: 05.08.2018
keywords: security,identity
so.topic: concept             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite, online                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# SuperOffice Authentication

## Introduction

One of the hardest things about getting started with new technologies is knowing where to begin. When it comes to application development and integrations, the obvious place is authentication.

SuperOffice has multiple data access layers, so lets' start with an overview of what the SuperOffice APIs have to offer.

Figure One: Overview of common SuperOffice API surface.

![auth][1]

SuperOffice COM APIs have been around the longest. The two main interfaces, IApplication and IDatabase, facilitate access to the Windows client application and the database. While IApplication exposes the capabilities to drive the application, IDatabase provides the capability to read and write to and from the SuperOffice database without having the Windows client running.

While SuperOffice Customer Service (CS) capabilities are vast, most of the functionality revolves around processing support tickets and internal processes using script automation. The CS SOAP services are limited, whereas the NetServer web services surface is much larger and the primary target for interacting with SuperOffice business entities. This article will not cover any more information about CS.

SuperOffice NetServer SOAP web services is a complete set of service endpoints that has the capability to support 100% of the SuperOffice web client functionality - which is more than the Windows client and COM could ever claim. In fact, CS is dependent on NetServer web services, as well as all the quote functionality in  the Window client! 

NetServer code, comprised of business entity classes, as well as row & row collections, supports the entire web services stack. All of this functionality gets pushed through NetServer's Objectified SQL (OSQL) classes for database vendor specific SQL generation.

The objective of this article is to introduce you to how to get past the first hurdle, authentication. All of the following sections assume you have access to a correctly configured SuperOffice database.

Each section will define all of the dependencies required to be in place for you to be able to successfully authenticate with the corresponding API.

The development environment used in these examples is Visual Studio and the language used C#.

If you do not have one of the SuperOffice clients installed (Windows or Web), you will want to download the Expander SDK to have the dll's necessary and COM interop libraries to complete the code examples below. The latest available for download at the time of this article was SuperOffice 7.5.

## SuperOffice Online

Read about online authentication in the [online environment](online/federated-auth.md) documentation.

## COM

This section assumes that you have a working installation of the SuperOffice Windows client on your development machine. If not, perhaps you want to try the NetServer sections below.

In contrast to NetServer-based development, COM-based SuperOffice development is the one case where you don't need to worry about configuration files. The only thing you need to decide at this point is whether you will interact with the Windows client or not.
### COM IApplication Interface

If you are required to interact with the Windows client, you will only need to make a COM reference to the SuperOffice Application Server 1.0 Type Library. Alternatively, you could make a reference to the SuperOffice generated COM interop dll.


Figure Two: COM Reference Dialog - Filtered to see SuperOffice libraries.

![com-app][2]
 

With a reference made, and the SuperOffice.COM.Application using statement declared, all it takes to instantiate the IApplication interface is to instanciate a new instance of the SoApplication class.

If the SuperOffice application was not already open, it will open now. If the application is not configured for single sign-on, you will be prompted for credentials now.

Figure Three: Instantiating the SuperOffice Windows client

![com-app][3]

Using the SoApplication type, you have complete access to both the SuperOffice Windows client, as well as access to the IDatabase interface, exposed in the SoApplication.Database property.

There are multiple examples of how to use IApplication in the SDK Help file, located in the SDK download or online.

### COM IDatabase Interface

Use the IDatabase interface when you must use COM and do not want to interact with the Windows client application.

First, make a COM reference to the SuperOfficeDB 7.0 Type Library. Alternatively, you could make a reference to the SuperOffice generated COM interop dll, SuperOfficeDB.Interop.dll, located in the SDK Interop folder (C:\Program Files (x86)\SuperOffice\Expander SDK\7.5.5154.200\Interop).

With a reference made, and the SuperOffice.COM.SuperOfficeDB using statement declared, it's possible to instanciate a new instance of the Database class. 

Figure Four: Instantiating the SuperOfficeDB class.

![com-app][4]

Using the Database class instance, call the Login method with either a normal user, external user, or system user credentials. 

When login is successful, your have a wide range of methods for reading and writing data to the SuperOffice database.

Please read more about the IDatabase APIs either in the SDK download, or here online.

NetServer Configuration
All NetServer integrations that use SuperOffice assemblies require settings in an applications' configuration file, app.config or web.config. This is not the case for custom web service proxies or REST. This only applies when an application make a file reference to SOCore.dll, SoDatabase.dll, and other required SuperOffice dlls.

Listing One: A configuration file with the essential SuperOffice sections defined.
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<configSections>
		<sectionGroup name="SuperOffice">
			<sectionGroup name="Security">
				<section name="Cryptography" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
			</sectionGroup>
			<section name="Diagnostics" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
			<sectionGroup name="Data">
				<section name="Session" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
				<section name="Database" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
				<section name="ImplicitAnonymous" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
				<section name="Explicit" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
			</sectionGroup>
			<section name="Documents" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
		</sectionGroup>
	</configSections>
	<SuperOffice>
		<Security>
			<Cryptography>
				<add key="SymmetricKey" value="p8/kDmMuw0xuQYFzaVat7lULlns+n/wPFP2bW5+4oTQ="/>
				<add key="SymmetricIV" value="1GbQjEeRbfL5EGVxH9a+og=="/>
				<add key="SymmetricSecret" value="SuperOffice NetServer Training"/>
			</Cryptography>
		</Security>
		<Diagnostics>
			<!-- Log errors (default 'True'). -->
			<add key="LogError" value="True"/>
			<!-- Log warnings (default 'False') -->
			<add key="LogWarning" value="True"/>
			<!-- Log general information. Includes SQL sent to the database-->
			<add key="LogInformation" value="False"/>
			<!-- Log to the OS event log (default 'True') -->
			<add key="LogToEventLog" value="False"/>
			<!-- Log to a LogFile (default 'False') -->
			<add key="LogToFile" value="True"/>
			<!-- Enable vebose mode -->
			<add key="EnableScaffolding" value="True"/>
			<!-- Folder where the logfile is written, must exist-->
			<add key="LogFolder" value="c:\temp"/>
		</Diagnostics>
		<Data>
			<Session>

				<add key="Mode" value="Process"/>
			</Session>
			<Database>
				<add key="DatabaseMajor" value="MSSQL"/>
				<add key="DatabaseMinor" value="8"/>
				<add key="Server" value="ServerName"/>
				<add key="Database" value="DatabaseName"/>
				<add key="CommandTimeOut" value="300"/>
				<add key="TablePrefix" value="CRM7"/>
				<add key="ConnectionString" value="Server=[@Server];Database=[@Database];User ID=[@User];Password=[@Password]"/>
			</Database>
			<Explicit>
				<add key="ExternalPersonAllowed" value="False"/>
				<add key="EmployeeAllowed" value="True"/>
				<add key="SystemAllowed" value="True"/>
				<add key="DBUser" value="DbUserName"/>
				<add key="DBPassword" value="DbUserPassword"/>
				<add key="CommonDBConnection" value="True"/>
			</Explicit>
		</Data>
		<Documents>
			<!-- Location of SO_ARC -->
			<add key="ArchivePath" value="C:\SO_ARC\"/>
			<!-- Location of template folder. -->
			<add key="TemporaryPath" value="c:\temp"/>
			<!-- Impersonate user document archive or the temporary folder  -->
			<add key="ImpersonateUser" value="False"/>
			<!-- Name of the user to impersonate with -->
			<add key="ArchiveUser" value=""/>
			<!-- Password of the user to impersonate with -->
			<add key="ArchivePassword" value=""/>
			<!-- Domain of the user to impersonate with -->
			<add key="ArchiveDomain" value=""/>
			<!-- Size of internal buffer in KB -->
			<add key="BufferSize" value="64"/>
		</Documents>
	</SuperOffice>
	<startup>
		<supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.1"/>
	</startup>
</configuration>
 ```

Only the bare essential elements are declared here. The most essential section, one that often causes connectivity problems, is the Data element section. The data element contains the session, database and explicit sections. 

Session determines how the authenticated session will exist at runtime. There are three options by default:

* Process
* Context
* Thread

Each session option determines where in memory the authenticated session will be available from. When session is Process, the authenticated SoSession is available to all synchronization contexts and threads. When session is Context, it is only available to routines passed to the same synchronization context. When session is Thread, the authenticated SoSession is only available on that thread. If another non-authenticated thread tried to use the SuperOffice API to get data, NetServer would throw an exception.

The Database section is used to define your database specific details, and will look slightly different then the example if you are targeting DB2 or Oracle.  More information about the database section can be found in the NetServer configuration section of the SDK.

The Explicit section allows an application to determine what type of users are authorized to use this application, as well as must set the database credentials, which map to both a database server user, and a SuperOffice system user.

## NetServer Core & Service Proxy Authentication using SoSession

While most data access layers only require database credentials for access database resources, SuperOffice requires a valid SuperOffice user too when authenticating using NetServer.

The user must establish an SoSession, which is an IPrincipal container, and has several overloads for authentication. Using explicit credentials is one of the most common ways to instantiate an SoSession.

Listing Two: Authenticate with username and password.

```csharp
//Explicit User Authentication
using (var session = SoSession.Authenticate("TY",""))
{
    Console.WriteLine(
        string.Format("Successfully authenticated {0} using credentials...",
        session.Principal.Associate)
    );
}
```

Another common scenario is single sign-on using the current Windows users credentials. There are two ways this can be accomplished, implicitly and explicitly.

Listing Three: Authenticate with current Windows user.

```csharp
//Implicit Windows User Authentication
using (var session = SoSession.Authenticate())
{
    Console.WriteLine(
        string.Format("Authenticated {0} using implicit Windows Identity...", 
        session.Principal.Associate)
    );
}


// or...Explicit Windows User Authentication

WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
using (var session = SoSession.Authenticate(identity))
{
    Console.WriteLine(string.Format("Successfully authenticated {0} using explicit Windows Identity...", 
        session.Principal.Associate));
}
```

Now let's look at the final authentication overloads, using an SoCredentials or SoCredentials.Ticket. SoCredentials only contains one property, Ticket. Ticket represents a stored credential record that can be used to authenticate a user.


Listing Four: Demonstrates a user authenticating, getting an SoCredentials, and then using the credential to authenticate.

```csharp
SoCredentials credentials = null;

//Explicit User Authentication
using (var session = SoSession.Authenticate("TY",""))
{
    //Save the SoCredentials...
    credentials = session.Principal.GetSafeCredentials();

    Console.WriteLine(
        string.Format("Successfully authenticated {0} using credentials...",
        session.Principal.Associate)
    );
}

//SoCredentials Authentication
using (var session = SoSession.Authenticate(credentials))
{
    Console.WriteLine(
        string.Format("Successfully authenticated {0} using credentials...",
        session.Principal.Associate)
    );
}


//Ticket as user Authentication
using (var session = SoSession.Authenticate(credentials.Ticket, ""))
{
    Console.WriteLine(
        string.Format("Successfully authenticated {0} using credentials...",
        session.Principal.Associate)
    );
}
```

SoSession is a disposable instance, and when out of scope will automatically close the connection and the invalidate the current SoSession.Principal. If your code tried to make API calls to the database after this NetServer will throw an exception.

So the next question is usually "Do I need to authenticate every time I want to use the API?" The answer is no. Most common in Window client application, you want to keep the SoSession open and valid for the lifetime of your application. You can store the SoSession variable as a global instance, just remember to call the SoSession.Dispose method to close any open connection when your application is closing.

Alternatively, another common scenario is to use Suspend and Continue.

Listing Five: Demonstrating SoSession Suspend and Continue.

```csharp

string sessionString = string.Empty;

//Suspend and Continue user Authentication
using (var session = SoSession.Authenticate(credentials.Ticket, ""))
{
    sessionString = session.Suspend();
}

//no valid session exists...

using (var newSession = SoSession.Continue(sessionString))
{
    //Valid session exists.
}

```

## NetServer Web Service Custom Proxies

For those who are not developing solutions using Microsoft .NET, and cannot make a reference to SuperOffice assemblies, they must relay on their own technology stacks to either generate SOAP proxies or roll their own.

In many cases, such as PHP and Python, application depend on loading the WSDL file for interacting with SuperOffice web services. In that case, we make those files available for downloads along in the [SOAP web services API reference](../api-reference/soap/index.md).

With the WSDL files, and using a tool like SOAPUI, raw SOAP requests sent to SuperOffice endpoints for testing. Figure Six demonstrates this using SOAPUI, wile Figure Seven demonstrates this using Fiddler2.

Figure Six: SOAPUI tool for testing SOAP endpoints.

![soapui][5]

Figure Seven: Manually composed SOAP request in Fiddler2.

![fiddler][6]

## SuperOffice REST / WebAPI Web Services

Introduced in SuperOffice version 8, REST support is finally here. To successfully use the REST API's, you must pass along credentials in each request header.

Figure Eight displays an HTML page that contains a few text boxes for; determining where, or what version of, the services reside, user name and password. With this required information, the user can specify a project id and click the Get button to execute an XMLHttpRequest.

Figure Eight: Example HTML page.

![request-page][7]

As seen in Listing Six, the setRequestHeader mefhod is used to add the Authorization header key entry with a value equal to "Basic " plus a base64 encoded representation of the user name, plus a colon, and password. Note the space following the word Basic. In the javascript code, we use the built-in DOM window.btoa(...) method to convert the value to base64. 

Alternatively, if the HTML page is running in the context of a SuperOffice web panel, and the application passes in the users SoCredential.Ticket, the REST request header also supports SOTicket, instead of Basic. In that case, the Authentication header value is "SOTicket " plus the ticket string. Once again, notice the space following SOTicket. Also note, in this case, do not use the window.btos(...) method to convert a Ticket to base64 because he ticket value is already base64 encoded.

Listing Six: HTML page markup.

```html
<script>
    _proj = {};
   
    function onGetId(f)
    {
        var urlbase = document.getElementById("url").value;
        
        var user = document.getElementById("user").value;
        var pass = document.getElementById("pass").value;
        
        var project = document.getElementById('projectid');
        var projectid = project.value;
        var url = urlbase + "/project/" + projectid;
        
        var req = new XMLHttpRequest();
        req.responseType = "json";
        req.open( "GET", url, true);
        req.withCredentials = true;
        req.setRequestHeader("Authorization", "Basic " + btoa(user + ":" + pass))
        req.onload = function() { onGetProject(req.response ); };
        req.onerror = function() { alert( "Request Error - check Console for details." ); };
        req.send();
        
        // Don't submit form
        return false;
    }
    
    function onGetProject(proj)
    {
        _proj = proj;
        
        var n = document.getElementById('project_name');
        var ti = document.getElementById('project_typeid');
        var tn = document.getElementById('project_typename');
        
        n.value = proj.Name;
        ti.value = proj.ProjectType.Id;         
        tn.value = proj.ProjectType.Value;         
    
        n.style.fontWeight = "normal";
        ti.style.fontWeight ="normal";
        tn.style.fontWeight = "normal";
    }


   function SaveProject()
    {
        var n = document.getElementById('project_name');
        var ti = document.getElementById('project_typeid');
        var tn = document.getElementById('project_typename');
        
        _proj.Name = n.value;
        _proj.ProjectType.Id = ti.value;         
        _proj.ProjectType.Name = tn.value;
                 
         var urlbase = document.getElementById("url").value;
         var user = document.getElementById("user").value;
         var pass = document.getElementById("pass").value;
         
         var project = document.getElementById('projectid');
         var projectid = project.value;
         var url = urlbase + "/project/" + projectid;
         
         var req = new XMLHttpRequest();
         req.responseType = "json";
         req.open( "PUT", url, true);
         req.withCredentials = true;
         req.setRequestHeader("Authorization", "Basic " + btoa(user + ":" + pass));
         req.setRequestHeader("Content-Type", 'application/json');
         req.onload = function() { onSaveProject(req.response); };
         req.onerror = function() { alert( "Request Error - check Console for details." ); };
         req.send( JSON.stringify( _proj ) );

         return false;
    }

    function onSaveProject(proj)
    {
        _proj = proj;
        
        var n = document.getElementById('project_name');
        var ti = document.getElementById('project_typeid');
        var tn = document.getElementById('project_typename');
        
        n.value = proj.Name;
        ti.value = proj.ProjectType.Id;         
        tn.value = proj.ProjectType.Value;
        
        n.style.fontWeight = "bold";
        ti.style.fontWeight ="bold";
        tn.style.fontWeight = "bold";         
    }

</script>
 ```

## Conclusion

SuperOffice supports several different access points to SuperOffice API's. Without knowing where to begin, it makes it almost impossible to successfully build an integration. The first place most applications must begin with is authentication, Once authentication is understood, and understanding at what data access level your application will integrate with SuperOffice, the remaining tasks should just be learning about the various entity and service API's for reading and writing data to the SuperOffice database.

<!-- Referenced links -->
[1]: media/authenticate-overview.png
[2]: media/com-add-reference.png
[3]: media/com-application-code.png
[4]: media/com-database-code.png
[5]: media/services-authenticate-soapui.png
[6]: media/services-authenticate-fiddler.png
[7]: media/simple-rest-page.png
---
title: Wrapped or unwrapped proxy
uid: wrapped_or_unwrapped_proxy
description: Wrapped or unwrapped proxy
author: {github-id}
so.date:
keywords:
so.topic: concept
# so.envir:
# so.client:
---

# Wrapped or unwrapped proxy

Proxy generators can generate calls in one of 2 ways: wrapped or unwrapped. The SOAP calls described by the WSDL take one parameter and return one result object. All the parameters to the call are placed on the parameter object. The proxy generator can choose to present the parameters as one object or as a list of parameters.

## Wrapped proxy

Wrapped proxies match the WSDL call and use one parameter object. A call using a wrapped proxy looks like this:

```csharp
Req r = new Req();
r.param1 = "foo";
r.param2 = 42;
Response res = agent.SomeMethod( r );
```

The order of the parameters is not important, because there is only one parameter to the call. The properties on the parameter object can be initialized in any order without affecting the call.

## Unwrapped proxy

By unwrapping the parameter object, the method signature looks more like a normal function call. A call using an unwrapped proxy looks like this:

```csharp
Response res = agent.SomeMethod( "foo", 42 );
```

The agent proxy will then copy the parameters into the request object and make the SOAP call for you. The unwrapped proxy is more familiar to developers.

The problem with unwrapping is that the order of parameters is lost unless the WSDL contains extra info. For 7.0 this information is not present, so unwrapped proxies will not always match the parameter order shown in the documentation.

The documentation says: `void SomeCall( name, associateId, flag )` The Wrapped proxy will have a request parameter object like this: `void SomeCall( SomeCallRequest request );` The order of the parameters is not significant.

The unwrapped proxy will look like this, with the parameters in alphabetical order:

```csharp
void SomeCall( int associateId, bool flag, string name );
```

In a future release, the parameters will be tagged with ordering information, making life for non-.Net clients simpler. But for now, you will need to pay careful attention to the order of parameters when making unwrapped SOAP proxy calls.

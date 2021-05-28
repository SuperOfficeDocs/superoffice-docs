---
uid: crmscript_global_encodebase64
title: encodeBase64
description: CRMScript function that encodes bytes to a base 64 string
intellisense: Void.encodeBase64
langref: 1
keywords: encodeBase64(Byte[]), encodeBase64(NSStream), encodeBase64(Byte[],bool), encodeBase64(NSStream,bool)
so.topic: reference
---

# String encodeBase64()

Encode bytes to a base 64 string. You can pass the data to encode as either `Byte[]` or `NSStream`. You can optionally pass a `Bool` to control if the encoded data should be wrapped with new lines or not.

Returns a Base64-encoded string.

## Functions

* String encodeBase64(Byte[] data)
* String encodeBase64(Byte[] data, bool wrapLines)
* String encodeBase64(NSStream data)
* String encodeBase64(NSStream data, bool wrapLines)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| data | Byte[] OR<br>NSStream | Data to encode |
| wrapLines | Bool | Controls if the encoded data should be wrapped with new lines |

---
uid: get-person-image-options
title: Get a person's image
description: Compare four ways to retrieve a person's image, and how each one behaves when no image exists.
keywords: person, image, PersonAgent, BLOBAgent, GetPersonImage
author: digitaldiina
date: 07.06.2026
version: 12.1
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
language: en
---

# Get a person's image

SuperOffice offers several ways to retrieve a person's image. They differ mainly in **how they behave when the person has no image**, so pick the option that matches how your integration needs to handle a missing picture.

## <a id="agent-methods"></a>Option 1: Agent methods

Two agent methods return a single person's image as binary data.

`POST /api/v1/Agents/Person/GetPersonImage` returns the image shown in the CRM application:

```http
POST /api/v1/Agents/Person/GetPersonImage
Content-Type: application/json; charset=utf-8

{
  "PersonId": 93
}
```

`POST /api/v1/Agents/BLOB/GetPersonImage` returns the same image through the BLOB agent instead:

```http
POST /api/v1/Agents/BLOB/GetPersonImage
Content-Type: application/json; charset=utf-8

{
  "PersonId": 21
}
```

Sample response from the BLOB agent call:

```http
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mNk+M9QDwADhgGAWjR9awAAAABJRU5ErkJggg=="
```

Both methods take only a `PersonId`. Neither accepts a size parameter — `GetPersonImage` on the BLOB agent has a companion method, `GetPersonImageWithSize`, described in [option 2][1].

> [!NOTE]
> If the person has no image, the two methods behave differently: `PersonAgent.GetPersonImage` returns an error, while `BLOBAgent.GetPersonImage` returns a 200 response with an empty result. If your integration must treat "no image" as a normal case rather than an error, prefer the BLOB agent method, or use [option 4][2] with `ifBlank` set explicitly.

## <a id="batch-and-sized-retrieval"></a>Option 2: Batch and sized retrieval

To fetch images for multiple people in one call, or to request a specific size, use `POST /api/v1/Agents/Person/GetPersonImages`:

```http
POST /api/v1/Agents/Person/GetPersonImages
Content-Type: application/json; charset=utf-8

{
  "PersonIds": [
    762,
    172
  ],
  "ScaledWidth": 87,
  "ScaledHeight": 578
}
```

```http
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 762,
    "ImageData": "GIF89....File contents as raw bytes..."
  },
  {
    "PersonId": 172,
    "ImageData": "GIF89....File contents as raw bytes..."
  }
]
```

`PersonIds` is the list of persons to fetch images for. `ScaledWidth` and `ScaledHeight` scale the returned images (in PNG format) to the given dimensions. The response is always `200 OK` — for a person with no image, the matching entry is still returned, but with empty `ImageData`. This makes `GetPersonImages` a safer choice than `GetPersonImage` when you're iterating over a list of people and don't want to handle a 404 for each one individually.

For a single image with a specific maximum size, use `POST /api/v1/Agents/BLOB/GetPersonImageWithSize` instead:

```http
POST /api/v1/Agents/BLOB/GetPersonImageWithSize
Content-Type: application/json; charset=utf-8

{
  "PersonId": 856,
  "Width": 1000,
  "Height": 80
}
```

## <a id="archive-provider"></a>Option 3: Archive provider

The `SimplePerson` archive provider exposes person data, including the image, through the OData-style archive search endpoint. Its `portraitThumbnail` column returns the person's image.

```http
GET /api/v1/Archive/SimplePerson?$select=personId,firstName,lastName,portraitThumbnail&$filter=personId=93
```

This approach is useful when you're already querying the archive for other person fields (name, category, contact) and want the thumbnail included in the same result set, rather than making a separate image call per person. Because it's a search/list provider, it naturally omits or blanks the `portraitThumbnail` value for people without an image, instead of returning an error.

## <a id="restful-api"></a>Option 4: RESTful API

The RESTful `Person` entity exposes the image directly on the resource, and lets you control what happens when the person has no image.

`GET /api/v1/Person/{personId}/Image` returns the picture, optionally scaled or converted:

```http
GET /api/v1/Person/{personId}/Image?w=180&h=180&ifBlank=SrNoPhoto
```

| Parameter | Type | Description |
| --- | --- | --- |
| w | int32 | Optional width of the returned bitmap. |
| h | int32 | Optional height of the returned bitmap. |
| type | string | Optional bitmap type: `JPEG`, `PNG`, or `GIF`. |
| ifBlank | enum | What to return when there is no picture: `Default`, `ClearPixel`, `SrNoPhoto`, `SrNoPhotoWithBorder`, `Null`, or `GenericFileIcon`. Default is `Null`, which returns a `404` error. |

By default (`ifBlank` not set), a person with no image returns `404`. Set `ifBlank` to one of the fallback values — for example `SrNoPhoto` — to get a placeholder image instead of an error:

```html
<img src="/api/v1/Person/{{id}}/Image?ifBlank=SrNoPhoto">
```

`GET /api/v1/Person/{personId}/ImageInfo` returns metadata about the stored image instead of the image itself:

```http
GET /api/v1/Person/{personId}/ImageInfo
```

```http
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BlobId": 731,
  "BlobSize": 632,
  "MimeType": "image/jpeg",
  "OriginalSize": 633,
  "ConceptualType": "PERSONPHOTO"
}
```

`ImageInfo` always responds `200 OK`, even when the person has no image — in that case the properties come back empty rather than the call failing. Use `ImageInfo` when you need to check whether an image exists (and its size or MIME type) without downloading the image itself.

## Which option to use

| If you need to... | Use |
| --- | --- |
| Get one person's image and treat "no image" as an error | Option 1, `PersonAgent.GetPersonImage` |
| Get one person's image and treat "no image" as a normal, empty result | Option 1, `BLOBAgent.GetPersonImage` |
| Get images for many people, or a specific size, in one call | Option 2 |
| Get a thumbnail alongside other person fields you're already querying | Option 3 |
| Control the fallback behavior yourself (placeholder image, icon, or blank) | Option 4, `Image` with `ifBlank` |
| Check whether an image exists, or its size/type, without fetching it | Option 4, `ImageInfo` |

<!-- Referenced links -->
[1]: #batch-and-sized-retrieval
[2]: #restful-api

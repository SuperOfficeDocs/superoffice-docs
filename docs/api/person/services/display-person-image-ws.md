---
title: Display person image
uid: display_person_image
description: How to display person's image using web services.
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: person, contact, web services, API, ImageUtility
so.topic: howto
# so.envir:
# so.client:
---

# Display person image

Displaying a person's picture involves using the `ImageUtility` to load the image via the web service, and then rendering the output in some way.

Here is an example of a web page that renders a person's image to PNG.

```csharp
int personId = 123;
int minWidth = 100;
int minHeight = 100;
int maxWidth = 1000;
int maxHeight = 1000;

ImageSize imageSize = new ImageSize( minWidth, minHeight, maxWidth, maxHeight);
FallbackStrategy fallbackStrategy = FallbackStrategy.SrNoPhoto;
bool border = true;
Color borderColor = Color.CadetBlue;

Image image = ImageUtility.GetPersonImage(_personId, imageSize, fallbackStrategy, border, borderColor);
if (image != null)
{
  Response.ContentType = "image/png";
  Encoder Enc = Encoder.RenderMethod;
  EncoderParameters EncParms = new EncoderParameters(1);
  EncoderParameter EncParm = new EncoderParameter(Enc, (byte)EncoderValue.RenderNonProgressive);
  EncParms.Param[0] = EncParm;

  MemoryStream ms = new MemoryStream();
  _image.Save(ms, ImageUtility.GetEncoderInfo("image/png"), EncParms);
  int bufferSize = SuperOffice.Configuration.ConfigFile.Documents.BufferSize * 1024;
  byte[] buffer = new byte[bufferSize];
  ms.Position = 0;
  int readBytes = 0;
  do
  {
    readBytes = ms.Read(buffer, 0, bufferSize);
    Response.OutputStream.Write(buffer, 0, readBytes);
    Response.OutputStream.Flush();
  }
  while (readBytes == bufferSize);
}
```

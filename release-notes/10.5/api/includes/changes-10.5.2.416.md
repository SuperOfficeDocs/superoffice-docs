---
uid: version_10.5.2.416_changes
date: 14.02.2025
---

## Changes from v10.5.2.332 and v10.5.2.416

---

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Modified Types

#### SuperOffice.Util.ImageUtilities is Modified

* New items
  * Method `GetAspect(Int32, Int32)`
  * Method `GetClearPixel(Size)`
  * Method `GetIntersectionRectangle(Size, Size, VerticalAlignment)`
  * Method `GetScaledImageOrDefaultImage(Image, ImageSize, FallbackStrategy, Func<Image>, Boolean, Color)`
  * Method `GetSrNoPhoto(Size, Color, Color, Boolean, String)`
  * Method `GetTextImage(Size, String, Font, Color, Color, Color, Boolean)`
  * Method `Max(Size, Size)`
  * Method `Min(Size, Size)`
  * Method `ScaleImage(Image, ImageSize, VerticalAlignment)`
  * Method `ScaleImage(Image, Double, Double, Size, Size, Color, VerticalAlignment)`

##### SuperOffice.Util.ImageUtilities.FallbackStrategy is New

##### SuperOffice.Util.ImageUtilities.ImageSize is New

##### SuperOffice.Util.ImageUtilities.ScaleStrategy is New

##### SuperOffice.Util.ImageUtilities.VerticalAlignment is New


### Assembly: SoDatabase

### Modified Types

#### SuperOffice.CRM.Cache.AssociateCache is Modified

* New items
  * Method `GetAssociateImage(Int32, Int32, Int32)`
  * Method `GetPersonImage(Int32)`

#### SuperOffice.CRM.Lists.AssociateMDOProviderBase is Modified

* Deleted items
  * Method `GetPersonImage(Int32)`


## Continuous Database

The following represent changes to SuperOffice database schema.



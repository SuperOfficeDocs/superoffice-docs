---
uid: help-da-udef
title: Brugerdefinerede felter
description: Brugerdefinerede felter
author: Bergfrid Dias
date: 01.29.2024
so-version: 10
keywords: udef, tilpasset felt, Brugerdefinered
topic: concept
audience: user
audience_tooltip: SuperOffice CRM
language: da
---

# Brugerdefinerede felter

Et *brugerdefineret* felt (udef) er et tilpasset felt, du tilføjer til en standard SuperOffice-databasetabel. Du kan udvide følgende enheder:

* Firma
* Kontakt
* Dokumenter
* Opfølgning
* Projekt
* Salg

Brugerdefinerede felter administreres i Indstillinger og vedligeholdelse, i **Felter**-skærmen. I applikationen er brugerdefinerede felter synlige på **Mere**-fanen for den enhed, de blev tilføjet til. For eksempel vises et brugerdefineret felt på et firma på **Mere**-fanen i Firma-skærmen.

> [!NOTE]
> Alle kan **opdatere** de data, der er gemt i et brugerdefineret felt. Kun en administrator kan tilføje (eller fjerne) et brugerdefineret felt. Du skal have en Development Tools-licens for at tilpasse layoutet af **Mere**-fanen og bruge side 1-felter.

## <a id="field-types" />Felttyper

* **Nummer**: heltal, ubegrænset antal cifre.
* **Kort tekst:**tekst på højst 39 tegn. Angiv i feltet **Tekstlængde**, som aktiveres, når du vælger denne indstilling, det maksimale antal tegn, brugerne kan skrive i dette felt.
* **Lang tekst:**tekst på højst 199 tegn. Angiv i feltet **Tekstlængde**, som aktiveres, når du vælger denne indstilling, det maksimale antal tegn, brugerne kan skrive i dette felt.
* **Dato**: dato mellem 01.01.1970 og 19.01.2038.
* **Ubegrænset dato**: enhver dato.
* **Afkrydsningsfelt**: et afkrydsningsfelt.
* **Liste**: en liste. Vælg en liste fra systemet i feltet nedenfor.
* **Decimal**: et nummer med decimaltegn.

## <a id="limit" />Maksimalt antal felter

Følgende begrænsninger gælder for antallet af tilpassede felter, du kan angive under hver fanerne Firma, Person, Projekt og Salg.

* **Nummer**, **Dato**, **Afkrydsningsfelt** og **Liste**: Højst 60 i alt.
* **Kort tekst** og **Ubegrænset dato**: Højst 40 i alt.
* **Lang tekst**: Højst 9 i alt.
* **Decimal**: Højst 10 i alt.

> [!NOTE]
> Fire af de brugerdefinerede felter i hver gruppe skal indekseres.

## <a id="index" />Indekserede felter

Indeksering er godt for brugeroplevelsen og ydeevnen. De første 4 felter af hver datetype er reserveret til indeks.

Du skal markere af i afkrydsningsfeltet, når du opretter feltet, for at tillade indeksering. Du kan markere op til 4 felter i hver af de 4 datatyper (Long, Double, String[40], String[200]) for hver enhed. For eksempel kan du indeksere 4 tal og 4 decimaler for en kontakt, men du kan ikke samtidig indeksere en dato - fordi alle Long-indekspositioner er optaget af tallene.

Hvis du vælger slet ikke at indeksere, spilder du i princippet 16 felter! Derfor reduceres det maksimale antal brugerdefinerede felter til 103.

## <a id="page-1" />Side 1-felt

Blandt de brugerdefinerede felter, der vises under fanen **Mere** i SuperOffice CRM, kan du vælge *tre* der skal fungere som side 1-felter (såkaldte, fordi de vises på "første side" på deres respektive skærmbilleder).

**Placering:**

* Fanen **Firma** på skærmbilledet Firma
* Fanen **Kontakt** på personkortet
* Fanen **Projekt** på skærmbilledet Projekt
* Fanen **Salg** på skærmbilledet Salg
* Fanen **Detaljer** på dialogboksen Dokument

> [!NOTE]
> Side-1 felt kræver licensen Development Tools og er ikke tilgængelig, hvis organisationen bruger en anden layout via [Skærmdesigneren][8].

## Eksempler

### Brugerdefinerede felter til virksomheder

Din virksomhed sælger software og brugersupporttjenester. Brugersupportafdelingen har brug for at vide, hvor mange medarbejdere og pc'er de forskellige kunder har. De har også brug for at vide, hvilken slags vedligeholdelsesaftale kunderne har, og hvornår de udløber.

Du kan derefter tilføje disse felter til skærmbilledet Virksomhed:

| Feltnavn | Type | Beskrivelse |
|---|---|---|
| Antal PC'er | Antal | Et talfelt, hvor du kan registrere antallet af pc'er. |
| Medarbejderantal | Antal | Et talfelt, hvor du kan registrere antallet af medarbejdere. |
| Vedligeholdelsesaftale | Liste | En liste over de forskellige typer vedligeholdelsesaftaler, du tilbyder. Listen skal [oprettes på skærmbilledet][3] Lister. |
| Kontrakten udløber | Dato | Et datofelt, hvor du kan registrere kontraktens udløbsdato. |
| Ansøgning A; Ansøgning B; Ansøgning C | Afkrydsningsfelt | Tre afkrydsningsfelter, hvor du kan markere de applikationer, som kunden har købt. |

> [!NOTE]
> De felter, du tilføjer, vises på fanen **Mere** på skærmbilledet Firma. Hvis du vil have dem vist på virksomhedskortet, [skal du angive dem som *side 1-felter*][1].

### Brugerdefinerede felter for salg

Når du opretter et salg, kan det være praktisk at indtaste de produkter, du har solgt, og hvor mange.

Du kan derefter tilføje disse felter til skærmbilledet Salg:

| Feltnavn | Type | Beskrivelse |
|---|---|---|
| Produkt | Lang tekst | Et tekstfelt, hvor du kan indtaste navnet på det produkt, der blev solgt. |
| Antal | Antal | Et talfelt, hvor du kan registrere antallet af solgte enheder. |

> [!TIP]
> Her kan du også bruge et listefelt, hvis du har oprettet en liste over de produkter, du sælger.

### Brugerdefinerede felter for projekter

Du ønsker, at budgettet for et projekt skal være let synligt for projektmedlemmerne.

Du kan derefter tilføje disse felter til skærmbilledet Projekt:

| Feltnavn | Type | Beskrivelse | Bemærkninger |
|---|---|---|---|
| Budget | Decimal | Et talfelt, hvor du kan angive en sum. | [Vælg, at feltet skal vises på side 1][1]. |

## Relateret indhold

* [Tilføj brugerdefinerede felt][2]

<!-- Referenced links -->
[1]: ../admin/edit-udef-layout.md#page-1
[2]: ../admin/add-udef.md
[3]: ../../admin/lists/learn/adding-user-defined-lists.md
[8]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
---
uid: help-nl-quote-template
title: Offertesjablonen en samenvoegvelden
description: Offertesjablonen en samenvoegvelden
keywords: offerte, offertesjabloon, sjabloon, offertedocument, offerte-details, samenvoegveld
author: Bergfrid Dias
date: 07.31.2024
version: 10
content_type: concept
language: nl
---

# Offertesjablonen en samenvoegvelden

Deze gids beschrijft de verschillende soorten offertesjablonen die beschikbaar zijn in SuperOffice CRM, samen met instructies voor het gebruik van samenvoegvelden om offertes en opdrachtbevestigingen aan te passen. Deze sjablonen omvatten het hoofd-offertedocument, offerte-details, opdrachtbevestigingen en bijbehorende e-mailsjablonen.

Een offerte bestaat vaak uit meer dan één product. Het is daarom noodzakelijk om een offerte-detailsjabloon (en een opdrachtbevestigingssjabloon) te maken waarin elk product in een tabel met verschillende groeperingen (zoals opties) wordt vermeld. De gebruiker kan alleen het offertedocument in Word bewerken. De offerte-details en opdrachtbevestiging worden alleen als PDF gegenereerd en kunnen niet door de gebruiker worden bewerkt. Alle offertesjablonen kunnen op de gebruikelijke manier worden bewerkt in Instellingen en Onderhoud.

## <a id="types"></a>Soorten offertesjablonen

SuperOffice biedt verschillende sjablonen voor het genereren van offertes. Deze sjablonen zijn toegankelijk en aanpasbaar in Instellingen en Onderhoud onder **Lijsten**.

| Type | Beschrijving | Formaat | Voorbeeld |
|---|---|---|---|
| Offerte | Hoofd-offertedocumentsjabloon | .doc of .docx | gemarkeerd in geel |
| Offerte-details | Sjabloon voor offertedetails | .pdf | gemarkeerd in paars |
| Opdrachtbevestiging | Sjabloon voor opdrachtbevestigingen | .pdf | gemarkeerd in roze |
| E-mailsjabloon | Sjablonen voor offerte- en opdrachtbevestigingse-mails | | gemarkeerd in oranje |

![Offerte - Documentsjabloon -screenshot][img1]

![Offerte - E-mailsjabloon -screenshot][img2]

### Offertedocument

De **offertesjabloon** is een combinatie van de hoofd-offerte-tekst (de begeleidende brief geschreven door de verkoper) en de offerte-details. Het offertedocument wordt gegenereerd wanneer je een [nieuwe offerte aanmaakt][7] of een bestaande offerte opent en **Klik om het offertedocument te maken** kiest. Het document wordt gegenereerd in .doc of .docx-formaat, wat bewerken na creatie mogelijk maakt. Het wordt automatisch opgeslagen onder het tabblad **Activiteiten** in de verkooppost. Het is ook beschikbaar via de link op het tabblad **Offerte**.

### Offerte-details

Het **offerte-detailssjabloon** [wordt automatisch samengevoegd](#usage) in het offertedocument waar het samenvoegveld `<<QuoteDetails>>` is geplaatst. Om het offerte-detailsdocument te genereren, klik je op **Verzenden** op het Offerte-scherm. Dit opent een dialoogvenster waarin je de gewenste lay-out kunt kiezen en het offerte-detailsjabloon kunt selecteren. Het document wordt gegenereerd in .pdf-formaat en kan niet worden bewerkt nadat het is aangemaakt.

![Offerte-details layout -screenshot][img3]

### Opdrachtbevestigingssjabloon

Om een **opdrachtbevestigingsdocument** te genereren, klik je op de knop **Bestelling plaatsen**. Dit opent een dialoogvenster waarin je kunt kiezen tussen **Verzend opdrachtbevestiging via e-mail** of direct het document genereren. De opdrachtbevestigingssjabloon wordt geselecteerd op basis van het verkooptype en is ingesteld in Instellingen en Onderhoud onder **Lijsten** > **Sale – Type, Stages, Quote**. Het document wordt gegenereerd in .pdf-formaat en kan niet worden bewerkt nadat het is aangemaakt.

![Offerte opdrachtbevestigingssjabloon keuze -screenshot][img4]

### E-mailsjabloon voor offerte en opdrachtbevestiging

Wanneer je offertes of opdrachtbevestigingen via e-mail verzendt, kun je een e-mailsjabloon kiezen. Voor offertes, klik op de **Verzenden**-knop en selecteer de sjabloon uit de lijst **E-mailtekst**. Voor opdrachtbevestigingen, klik op **Bestelling plaatsen**, kies **Verzend opdrachtbevestiging via e-mail**, selecteer de e-mailtekstsjabloon en taal, en klik vervolgens op **OK** om te verzenden.

![Offerte e-mail verzenden -screenshot][img5]

![Offerte opdrachtbevestiging verzenden -screenshot][img6]

## Samenvoegvelden in offertesjablonen

**Samenvoegvelden** in SuperOffice CRM offertesjablonen maken dynamische invoeging van details zoals productlijnen en opties mogelijk. In tegenstelling tot [standaard sjabloonvariabelen][1], volgen samenvoegvelden een specifieke structuur, of hiërarchie, om correcte gegevensintegratie te waarborgen.

Je kunt offertes en opdrachtbevestigingssjablonen aanpassen door samenvoegvelden in Microsoft Word te gebruiken. Samenvoegvelden stellen je in staat om specifieke offertinformatie in sjablonen in te voegen, terwijl standaard sjabloonvariabelen klantgegevens en andere details ophalen.

### <a id="structure"></a>Structuur van samenvoegvelden

Samenvoegvelden moeten een hiërarchische volgorde volgen: quote > alternative > group > line. Deze structuur wordt gedefinieerd met behulp van **TableStart** en **TableEnd** velden, die het begin en einde van elk tabelgebied markeren:

```text
«TableStart:quote»
  «TableStart:alternative»
    «GroupBy:productFamilyKey»«TableStart:group»
      «TableStart:line»
      «TableEnd:line»
    «TableEnd:group»
  «TableEnd:alternative»
«TableEnd:quote»
```

* quote: Het hoogste niveau, dat de gehele offerte vertegenwoordigt.
* alternative: Ingebed binnen offerte, gebruikt voor verschillende productopties.
* group: Ingebed binnen optie, gebruikt om producten te groeperen (optioneel).
* line: Ingebed binnen groep, die individuele productlijnen vertegenwoordigt.

> [!NOTE]
> Elke sjabloon moet de inschietvolgorde volgen en altijd beginnen met het hoogste niveau (quote). Het hoeft niet helemaal naar beneden te gaan, maar kan niet beginnen met optie of iets anders dan offerte.

## <a id="usage"></a>Gebruik van samenvoegvelden

Offerte-details omvatten gedetailleerde informatie zoals lijnen, prijzen en productnamen, meestal geplaatst in een aparte sjabloon van het hoofd-offertedocument. Als zowel het hoofd-document als de offerte-details worden gebruikt:

* Als het samenvoegveld `<<QuoteDetails>>` aanwezig is in het hoofd-document, worden de offerte-details op die plaats ingevoegd.
* Als het samenvoegveld `<<QuoteDetails>>` niet aanwezig is, worden de offerte-details aan het einde toegevoegd.

In beide gevallen wordt een enkele PDF gegenereerd die als bijlage bij de e-mail wordt toegevoegd.

Tags voor een specifieke tabel zijn beschikbaar vanaf de TableStart: tag van die tabel tot het einde ervan.

**Voorbeeld:**

[Lijnvelden][2] (zoals *line/name*) kunnen alleen binnen de lijn-tabel (`«TableStart:line» «TableEnd:line»`) worden geplaatst, terwijl optie-velden zowel binnen de optie-tabel als de onderliggende tabellen (groep en lijn) kunnen worden geplaatst.

![Offerte-details voorbeeld, TableStart -screenshot][img7]

### Groeperen en sorteren

**Groeperen:** Je kunt producten in de sjabloon groeperen door de **GroupBy** tag te gebruiken, met een lijn-niveau suffix, zoals `GroupBy:productFamilyKey` om producten te groeperen op basis van hun familie.

* De GroupBy tag is hoofdlettergevoelig en kan overal in het document worden geplaatst. Tijdens de runtime verdwijnt deze tag zonder enige tekst achter te laten.
* Slechts één GroupBy tag is toegestaan per sjabloon.

Wanneer een GroupBy tag aanwezig is, gebruik dan **TableStart** en **TableEnd** om het begin en einde van groep-gerelateerde secties te markeren. De **group/groupField** tag bevat de waarde van het groepsveld (bijvoorbeeld, productfamilie). De sectie tussen TableStart en TableEnd wordt herhaald voor elke unieke waarde van het groepsveld.

* Je kunt meerdere sets van TableStart en TableEnd secties hebben. Bijvoorbeeld, je wilt misschien een samenvattingstabel met totalen en afzonderlijke tabellen voor de lijnen in elke groep. In dit geval moet de samenvattingstabel geen interne TableStart:line/TableEnd:line sectie bevatten.

Binnen de groep (tussen TableStart en TableEnd), kun je velden toevoegen die specifiek zijn voor de groep.

**Sorteren:** Standaard worden offerte-lijnen in rangorde weergegeven, zoals gezien in de offerte-lijndata. Als groepering wordt gebruikt, worden groepen alfabetisch gesorteerd en lijnen binnen elke groep worden gesorteerd op rang.

Om de volgorde van offerte-lijnen te wijzigen, gebruik je de **OrderBy** tag, met een lijn-niveau suffix. Bijvoorbeeld, `OrderBy:name` sorteert producten alfabetisch op naam, en `OrderBy:vatInfo` sorteert producten op btw-status. Slechts één niveau van sortering wordt ondersteund.

### <a id ="culture"></a>Opmaak van numerieke en datumvelden

Numerieke en datumvelden kunnen worden opgemaakt om overeen te komen met de geselecteerde taal/cultuurinstellingen (beïnvloedt weergavevolgorde en scheidingstekens):

* **Numerieke velden:** Voor decimale waarden kun je het aantal decimalen specificeren (0, 2, of 5). Bijvoorbeeld, `line/totalPrice:2` zorgt voor twee decimalen. De decimale scheidingsteken is altijd volgens de gekozen taal/cultuur.

* **Datum en tijd velden:** Beschikbare formaten omvatten ShortDate, ShortTime, ShortDateTime, LongDate, LongTime, en LongDateTime. Bijvoorbeeld, `quote/sent:LongDateTime` voor volledige datum en tijd.

Als geen specifieke opmaak is ingesteld, wordt de standaard voor de gekozen taal gebruikt.

De werkelijke opmaak (decimale scheidingstekens, dag/maand volgorde, enz.) weerspiegelt de geselecteerde cultuur van de gebruiker, zoals gespecificeerd in de dialoogvensters **Verzend** en **Bestelling plaatsen**. Voor specifieke opmaakbehoeften, kun je de **Culture:** samenvoegveld in de sjabloon opnemen, en een [.NET cultuurcode][11] specificeren (zoals `Culture:de-CH` voor Zwitserduits) om de keuze van de gebruiker te overschrijven. Dit betekent dat een dergelijke cultuurcode moet worden ingebouwd in een speciale sjabloon genaamd Offerte voor Zwitser klanten of iets dergelijks.

> [!NOTE]
> Gebruik niet de Tabel voor taal- en cultuurnaam, codes en ISO-waarden methode van [C++ AppConfig objecten][12] als referentie, er zijn kleine verschillen.

Door deze richtlijnen te volgen, kun je effectief gebruik maken van samenvoegvelden om gedetailleerde, op maat gemaakte offerte- en opdrachtbevestigingssjablonen in SuperOffice CRM te creëren.

## Gerelateerde inhoud

* [Update offerte sjabloon][5]
* [Handleiding][6]
* [Samenvoegvelden referentie][3]
* [Sjabloonvariabele referentie][4]
* [System.Globalization.CultureInfo][11]
* [Aspose][13] (beheert documentgeneratie)

<!-- Referenced links -->
[1]: template-variables.md
[2]: ../merge-fields/line.md
[3]: ../merge-fields/index.md
[4]: ../variables/for-quote-line.md
[5]: ../admin/update-template.md
[6]: ../admin/update-template.md
[7]: ../../../sale/learn/quote/create.md
[11]: https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-5.0
[12]: https://docs.microsoft.com/en-us/previous-versions/commerce-server/ee825488(v=cs.20)
[13]: http://www.aspose.com

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/quote-list-document-template.png
[img2]: ../../../../media/loc/en/document/quote-list-email-template.png
[img3]: ../../../../media/loc/en/document/quote-layout.png
[img4]: ../../../../media/loc/en/document/quote-order-confirmation-template.png
[img5]: ../../../../media/loc/en/document/quote-send-email.png
[img6]: ../../../../media/loc/en/document/quote-send-confirmation.png
[img7]: ../../../../media/loc/en/document/tablestart-line.png

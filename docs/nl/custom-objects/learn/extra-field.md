---
uid: help-nl-extra-field
title: Extra veld
description: Extra veld
keywords: extra veld, aangepast, databasetabel
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Extra veld

[!include[License requirement](../../includes/req-dev-tools.md)]

Een *extra veld* is een aangepast veld dat je toevoegt aan een bestaande SuperOffice-databasetabel. Je kunt de volgende entiteiten uitbreiden:

* Categorie
* Bedrijf
* Contact
* FAQ-categorie en -item
* Bericht
* Verzoek
* Gebruiker
* Jouw [extra tabellen][6]

> [!NOTE]
> Extra velden bij een bedrijf of contact zijn niet hetzelfde als door de gebruiker gedefinieerde velden op die entiteiten!

Extra velden worden beheerd in **Instellingen en onderhoud**, op het scherm **Tabellen**.

## <a id="field-types"></a>Veldtypen

* Bool (ja/nee)
* Geheel getal
* Decimaal getal
* Tekst (kort)
* Tekst (lang)
* Datum
* Datum en tijd
* Tijd
* Tijdspanne
* Bijlage
* Dynamische link

Bovendien heeft elke entiteit een relatie type. Bijvoorbeeld de *contactrelatie*.

In tegenstelling tot door de gebruiker gedefinieerde velden worden extra velden toegevoegd als daadwerkelijke velden aan de databasetabellen. Er zijn geen vooraf gedefinieerde slots waarmee je rekening moet houden, en in wezen geen beperkingen.

### <a id="relation"></a>Relaties (vreemde sleutel, FK)

Databasetabellen zijn verbonden met *vreemde sleutel* (FK). Dit zijn veldtypen die eindigen op *relation*.

* Contactrelatie
* Bedrijfsrelatie
* Gebruikersrelatie
* Verzoekrelatie
* Categorie-relatie
* Prioriteitsrelatie
* FAQ-relatie
* Verkooprelatie
* Projectrelatie
* Afspraakrelatie
* Extratabelrelatie

#### Beschikbaar in pilot vanaf versie 10.3.4

Wanneer een relationeel veld is ingesteld om een-op-veel-relaties weer te geven, voegt het systeem automatisch een sectietabblad toe in gerelateerde standaardentiteiten. Dit is niet hetzelfde als het tabblad **Relaties** op de Bedrijf- en Contactschermen.

![Sectietabblad met extraveldrelatie -screenshot][img1]

#### Beschikbaar in pilot vanaf versie 10.3.7

Om de details van items in deze lijst te bekijken zonder elke entiteit afzonderlijk te openen:

1. Ga naar het zijpaneel en selecteer de weergave **Voorbeeld**.
2. Klik op een item in het relatiegebaseerde sectietabblad. Het zijpaneel toont een voorbeeld van de geselecteerde entiteit. In het voorbeeld kunt u:

    * Klik op een standaardentiteit om ernaartoe te gaan.
    * Klik op een aangepast object om een dialoogvenster te openen voor het bekijken of bewerken van aanvullende informatie.

![Voorbeeld extraveldrelatie -screenshot][img2]

## Gebruik

Extra velden kunnen bijvoorbeeld worden gebruikt als zoekcriteria en kolommen in de verkoop in SuperOffice CRM.

## Gerelateerde inhoud

* [Toon extra velden op het Details-tabblad][1]
* [Extra velden toevoegen][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/section-tab-for-relation.png
[img2]: ../../../media/loc/en/automation/preview-custom-object-from-side-panel.png

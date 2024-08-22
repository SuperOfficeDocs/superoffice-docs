---
uid: help-nl-extra-field
title: Extra veld
description: Extra veld
keywords: extra veld, aangepast, databasetabel
author: Bergfrid Dias
date: 01.30.2024
version: 10
topic: concept
audience: user
audience_tooltip: SuperOffice CRM
language: nl
---

# Extra veld

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

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

### Relaties (vreemde sleutel, FK)

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

## Gebruik

Extra velden kunnen bijvoorbeeld worden gebruikt als zoekcriteria en kolommen in de verkoop in SuperOffice CRM.

## Gerelateerde inhoud

* [Toon extra velden op het Details-tabblad][1]
* [Extra velden toevoegen][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

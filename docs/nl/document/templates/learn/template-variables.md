---
uid: help-nl-template-variables
title: Sjabloonvariabelen
description: Met sjabloonvariabelen kunt u de invoer van klantgegevens personaliseren en automatiseren
keywords: document, sjabloon, variable
author: Bergfrid Dias
date: 12.10.2024
version: 10.3
content_type: concept
language: nl
redirect_from: /nl/document/learn/template-variables
---

# Sjabloonvariabelen

Sjabloonvariabelen worden gebruikt om gegevens van SuperOffice in te voegen in e-mails, offerten, vergaderingsmeldingen, documentsjablonen enz. U kunt sjabloonvariabelen gebruiken om de invoer van klantgegevens (of gegevens van contact, verkoop en andere) in uw inhoud te personaliseren en te automatiseren en complexe offertes op te stellen.

## Voorbeeld: een e-mail personaliseren met sjabloonvariabelen

In plaats van deze tekst:

"Beste klant. Wilt u meer weten over hoe ons product uw bedrijf kan helpen nieuwe klanten te krijgen? Aarzel niet ons te bellen."

kunt u de volgende tekst verzenden:

"Hallo Chris. Wilt u meer weten over hoe ons product Car Care Ltd kan helpen nieuwe klanten te winnen? Bel Jan Weber bij SuperShop."

De ingevoerde tekst ziet er als volgt uit:

"Hallo **{atfn}**, Wilt u meer weten over hoe ons product **{name}** kan helpen nieuwe klanten te winnen? Bel dan **{cont}** op **{onam}**."

## How to use template variables

* Voor de gehele variabele moet u Ã©Ã©n lettertype en Ã©Ã©n lettergrootte gebruiken. Bovendien moet u alleen kleine letters typen. Als de voorkeur **Hoofdlettergevoelige sjabloonvariabelen gebruiken** echter is ingeschakeld, kan de sjabloonvariabele worden opgemaakt.

* U kunt gewone tekst en variabelen door elkaar gebruiken in het sjabloondocument: U kunt bijvoorbeeld sjabloonvariabelen invoeren die de naam en het adres van een bedrijf ophalen, een standaardtekst typen die in de brief wordt opgenomen en de variabele voor onze persoon invoeren om de brief af te sluiten.

* U kunt ook opvultekens gebruiken in het sjabloondocument (zie hieronder).

* De datum en tijd in sjabloonvariabelen worden bepaald door de systeemklok van de pc.

* In documenten van het bestandstype .doc in Office 2003 en ouder moet u punthaken - &lt; &gt; - gebruiken rondom de variabelen in plaats van gekrulde haken – { } –.

### Voorbeeld: notulen van de vergadering (koptekst)

Dit is een voorbeeld van een koptekst in vergaderingsnotulen (document of e-mail).

**Sjabloon:**

```text
{head}
Datum / Locatie:{sdat}, {city}
Aanwezig: {attn} ({name}), {auth} ({onam})
Niet aanwezig:
Notulist: {auth} ({auem})
```

**Resultaat:**

```text
Zomerverkoopcampagne - planning
Datum / Locatie: 15-12-2019, Londen
Aanwezig: Sara Miller (Liberty Ltd.), John Jones (SuperShop)
Niet aanwezig:
Notulist: John Jones (jj@supershop.com)
```

## Slimme variabelen van de bedrijfskaart

> [!NOTE]
> Adresvariabelen van de bedrijfskaart worden "slimme" sjabloonvariabelen genoemd. Dit betekent dat het systeem adresgegevens selecteert in een bepaalde volgorde. De variabelen in **vette tekst** hieronder (zoals **addr** en **plaats**) zijn slimme sjabloonvariabelen.

Wanneer u adresvariabelen van de bedrijfskaart gebruikt, selecteert het systeem adresgegevens in de volgende volgorde:

1. Als de optie **Gebruiken als postadres** actief is voor een persoon in het bedrijf, worden de adresgegevens van de persoon gebruikt.
2. Als de bovenstaande optie niet actief is, zullen de adresgegevens van het bedrijf worden gebruikt.
3. Als het postadres van het bedrijf leeg is, wordt het bezoekadres van het bedrijf gebruikt.

## Offertesjabloonvariabelen

Wanneer u offertes en producten in SuperOffice gebruikt, moet u offertesjablonen instellen. De sjablonen voor offertedocumenten, offertedetails en opdrachtbevestigingen verschillen van gewone documentsjablonen, omdat ze naast standaardsjabloonvariabelen ook "samenvoegvelden" gebruiken.

### Voorbeeld: opdrachtbevestiging (koptekst)

Sjabloonvariabelen voor offerten en opdrachtbevestigingen kunnen worden gebruikt binnen de context van een offerte.

**Sjabloon:**

```text
Besteldatum: {sdat}
Bestelnummer: {qnum}
Leveringsvoorwaarden: {qdev}
Betalingsvoorwaarden: {qpev}
Uw PO-nummer: {qpon}
Onze contactpersoon: {cont}
```

**Resultaat:**

```text
Besteldatum: 15-12-2019
Bestelnummer: 550012
Leveringsvoorwaarden: Bij levering inbegrepen
Betalingsvoorwaarden: 15 dagen
Uw PO-nummer: 70000882
Onze contactpersoon: John Jones
```

## Service- en marketingsjabloonvariabelen

Bij het genereren van e-mailsjablonen voor verzoeken en mailings (en berichtsjablonen) in Marketing, kunt u de e-mail of mailing personaliseren met sjabloonvariabelen. Deze variabelen verschillen enigszins van de variabelen die in documenten worden gebruikt.

## Referentie

De referentie is gegroepeerd per gebied. [Ga naar referentie][1]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->

---
uid: help-nl-template-variables
title: Sjabloonvariabelen
description: Met sjabloonvariabelen kunt u de invoer van klantgegevens personaliseren en automatiseren
author: SuperOffice RnD
so.date: 02.23.2023
keywords: document, sjabloon, variable
so.topic: concept
language: nl
---

# Sjabloonvariabelen

Sjabloonvariabelen worden gebruikt om gegevens van SuperOffice in te voegen in e-mails, offerten, vergaderingsmeldingen, documentsjablonen enz. U kunt sjabloonvariabelen gebruiken om de invoer van klantgegevens (of gegevens van contact, verkoop en andere) in uw inhoud te personaliseren en te automatiseren en complexe offertes op te stellen

> [!TIP]
> Bekijk alle verschillende [sjabloonvariabelen][2] die u voor de **bedrijfskaart**hebt.

## Voorbeelden

Hier laten we u enkele voorbeelden zien van het gebruik van sjabloonvariabelen. Veel van de voorbeelden gebruiken de standaardsjablonen in SuperOffice.

### Een e-mail personaliseren met sjabloonvariabelen

In plaats van deze tekst:

"Beste klant. Wilt u meer weten over hoe ons product uw bedrijf kan helpen nieuwe klanten te krijgen? Aarzel niet ons te bellen."

kunt u de volgende tekst verzenden:

"Hallo Chris. Wilt u meer weten over hoe ons product Car Care Ltd kan helpen nieuwe klanten te winnen? Bel Jan Weber bij SuperShop."

De ingevoerde tekst ziet er als volgt uit:

"Hallo **{atfn}**, Wilt u meer weten over hoe ons product **{name}** kan helpen nieuwe klanten te winnen? Bel dan **{cont}** op **{onam}**."

### Handtekeningen

Dit is een voorbeeld van een handtekening die door iedereen in uw bedrijf kan worden gebruikt.

```text
Met vriendelijke groet,
{auth}
{atit}
{onam}
Adres:{opad}, {ozip}{ocit}
Phone: {audp}
Mobiel nummer: {aupc}
{auem}
{owww} | Met vriendelijke groet,
John Jones
Verkoopmanager
SuperShop
Adres: High Street 12, 223-344, Springfield
Telefoon: 22334455
Mobiel nummer: 99887766
jj@supershop.com
supershop.com
```

### Notulen van de vergadering (koptekst)

Dit is een voorbeeld van een koptekst in vergaderingsnotulen (document of e-mail).

```text
{head}
Datum / Locatie:{sdat}, {city}
Aanwezig: {attn} ({name}), {auth} ({onam})
Niet aanwezig:
Notulist: {auth} ({auem})
Zomerverkoopcampagne - planning
Datum / Locatie: 15-12-2019, Londen
Aanwezig: Sara Miller (Liberty Ltd.), John Jones (SuperShop)
Niet aanwezig:
Notulist: John Jones (jj@supershop.com)
```

### Orderbevestiging (koptekst)

Sjabloonvariabelen voor offerten en orderbevestigingen kunnen worden gebruikt binnen de context van een offerte.

```text
Besteldatum: {sdat}
Bestelnummer: {qnum}
Leveringsvoorwaarden: {qdev}
Betalingsvoorwaarden: {qpev}
Uw PO-nummer: {qpon}
Onze contactpersoon: {cont}
Besteldatum: 15-12-2019
Bestelnummer: 550012
Leveringsvoorwaarden: Bij levering inbegrepen
Betalingsvoorwaarden: 15 dagen
Uw PO-nummer: 70000882
Onze contactpersoon: John Jones
```

## Sjabloonvariabelen gebruiken

* in documenten van het bestandstype .doc in Office 2003 en ouder moet u punthaken - &lt; &gt; - gebruiken rondom de variabelen in plaats van gekrulde haken – { } –.
* Voor de gehele variabele moet u Ã©Ã©n lettertype en Ã©Ã©n lettergrootte gebruiken. Bovendien moet u alleen kleine letters typen. Als de voorkeur **Hoofdlettergevoelige sjabloonvariabelen gebruiken** echter is ingeschakeld, kan de sjabloonvariabele worden opgemaakt.
* U kunt gewone tekst en variabelen door elkaar gebruiken in het sjabloondocument: U kunt bijvoorbeeld sjabloonvariabelen invoeren die de naam en het adres van een bedrijf ophalen, een standaardtekst typen die in de brief wordt opgenomen en de variabele voor onze persoon invoeren om de brief af te sluiten.
* U kunt ook opvultekens gebruiken in het sjabloondocument (zie hieronder).
* De datum en tijd in sjabloonvariabelen worden bepaald door de systeemklok van de pc.

> [!TIP]
> Nadat u een nieuw sjabloondocument hebt gemaakt, moet u het toevoegen via het scherm **Lijsten** in Instellingen en onderhoud om het te kunnen gebruiken in SuperOffice CRM.

## Opvultekens

Soms moet u opvultekens gebruiken in sjablonen om ervoor te zorgen dat een veldinhoud of -opmaak niet wordt gewijzigd of verwijderd als de inhoud in een veld korter is dan bepaald door de veldvariabele.

Met de variabele padd# geeft u op welk teken u gebruikt als opvulteken. Vervang het teken # door de ANSI-code van het teken dat u als opvulteken wilt gebruiken. U vindt meestal een lijst met ANSI-codes in de handleiding van het programma waarvoor u sjablonen maakt.

SuperOffice CRM heeft standaardwaarden voor opvultekens voor de meest algemeen gebruikte tekstverwerkings- of spreadsheettoepassingen. Meestal wordt een tijdelijk afbreekstreepje gebruikt, omdat dit niet op het scherm of op een afdruk wordt weergegeven. Voor toepassingen waarin de instelling onbekend is, wordt in SuperOffice CRM {padd32} gebruikt. Dit is de ANSI-code voor een spatie.

> [!TIP]
> Microsoft Word gebruikt {padd31} als opvulteken.

Als u geen opvultekens wilt gebruiken, gebruikt u de sjabloonvariabele {padd0}.

> [!NOTE]
> dit werkt alleen voor sequentiële documentindelingen, zoals Kladblok- en AmiPro-sjablonen zonder afbeeldingen.

Wanneer u {padd0} gebruikt, kunt u alle sjabloonvariabelen schrijven zonder lege tekens tussen de naam van de sjabloonvariabele en het laatste teken van de variabele (}).

## Variabelen van de bedrijfskaart

> [!NOTE]
> Adresvariabelen van de bedrijfskaart worden "slimme" sjabloonvariabelen genoemd. Dit betekent dat het systeem adresgegevens selecteert in een bepaalde volgorde. De variabelen in **vette tekst** hieronder (zoals **addr** en **plaats**) zijn slimme sjabloonvariabelen.

Wanneer u adresvariabelen van de bedrijfskaart gebruikt, selecteert het systeem adresgegevens in de volgende volgorde:

1. Als de optie **Gebruiken als postadres** actief is voor een persoon in het bedrijf, worden de adresgegevens van de persoon gebruikt.
2. Als de bovenstaande optie niet actief is, zullen de adresgegevens van het bedrijf worden gebruikt.
3. Als het postadres van het bedrijf leeg is, wordt het bezoekadres van het bedrijf gebruikt.

## Offertesjabloonvariabelen

Wanneer u offertes en producten in SuperOffice gebruikt, moet u offertesjablonen instellen en de variabelen zijn te vinden in een pdf die ook laat zien hoe u met offertesjablonen kunt werken.

De sjablonen voor offertedocumenten, offertedetails en orderbevestigingen verschillen van gewone documentsjablonen, omdat ze naast standaardsjabloonvariabelen ook "samenvoegvelden" gebruiken.

## Service- en marketingsjabloonvariabelen

Bij het genereren van e-mailsjablonen voor verzoeken en mailings (en berichtsjablonen) in Marketing, kunt u de e-mail of mailing personaliseren met sjabloonvariabelen. Deze variabelen verschillen enigszins van de variabelen die in documenten worden gebruikt.

## Referentie

De referentie is gegroepeerd per gebied. [Ga naar referentie][1]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/index.html
[2]:https://docs.superoffice.com/en/document/templates/variables/from-company-card.html

<!-- Referenced images -->

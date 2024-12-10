---
uid: help-da-template-variables
title: Skabelonvariabler
description: Med skabelonvariabler kan du tilpasse og automatisere indtastningen af kundedata
keywords: dokument, skabelon, variable
author: Bergfrid Dias
date: 12.10.2024
version: 10.3
topic: concept
language: da
---

# Skabelonvariabler

Skabelonvariabler bruges til at indsætte data fra SuperOffice i e-mails, tilbud, mødebeskeder, dokumentskabeloner osv. Du kan bruge skabelonvariabler til at tilpasse og automatisere indtastningen af kundedata (eller data fra kontakt, salg og andet) i dit indhold og oprette komplekse tilbud.

## Eksempel: Sådan tilpasser du en e-mail ved hjælp af skabelonvariabler

I stedet for denne tekst:

"Kære kunde. Vil du vide mere om, hvordan vores produkt kan hjælpe din virksomhed med at skaffe nye kunder? Så bedes du ringe til os."

kan du sende denne:

"Hej Christian. Vil du vide mere om, hvordan vores produkt kan hjælpe Bilbutikken A/S med at skaffe nye kunder? Ring til Jesper Nielsen i SuperShop."

Teksten du skriver ser således ud:

"Hej **{atfn}** Vil du vide mere om, hvordan vores produkt kan hjælpe **{name}** med at skaffe nye kunder? Så skal du endelige ringer til os **{cont}** på **{onam}**."

## Sådan bruger du skabelonvariabler

* Hele variablen skal være formateret med samme skrifttype og skriftstørrelse, og du må kun bruge små bogstaver. Hvis præferencen **Tillad store bogstaver i skabelonvariabler** er aktiveret, kan skabelonvariablen dog formateres.

* Du kan blande almindelig tekst og variabler i skabelondokumentet: Du kan f.eks. tilføje skabelonvariabler, som henter et firmas navn og adresse, indtaste en standardtekst, som skal indsættes i brevet, og tilføje variablen for vores kontakt som afslutning på brevet.

* Du kan også anvende såkaldte fyldtegn i skabelondokumentet (se nedenfor).

* Dato og klokkeslæt i skabelonvariabler styres af systemuret på pc'en.

* I dokumenter med filtypen .doc i Office 2003 og ældre skal du bruge klammer – &lt; &gt; – rundt om variablerne i stedet for krøllede parenteser – {} –.

### Eksempel: mødereferater (overskrift)

Dette er et eksempel på et sidehoved i et mødereferat (dokument eller e-mail).

**Skabelon:**

```text
{head}
Dato / Sted: {sdat}, {city}
Tilstede: {attn} ({name}), {auth} ({onam})
Fraværende:
Mødesekretær: {auth} ({auem})
```

**Resultat:**

```text
Sommersalgskampagne - planlægning
Dato / Sted: 15.12.2019, London
Tilstede: Sara Møller (Liberty A/S.), John Hansen (SuperShop)
Fraværende:
Mødesekretær: John Hansen (jh@supershop.com)
```

## Smart variables from the Company screen

Adressevariabler fra firmakortet kaldes "intelligente" skabelonvariabler. Det betyder, at systemet vælger adresseoplysninger i en bestemt rækkefølge:

1. Hvis indstillingen **Brug som postadresse** er aktiv for en person i firmaet, bruges personens adresseoplysninger.
2. Hvis ovenstående indstilling ikke er aktiv, bruges firmaets adresseoplysninger.
3. Hvis firmaets postadresse er tom, bliver firmaets gade/vej brugt.

## Skabelonvariabler for tilbud

Når du bruger tilbud og produkter i SuperOffice, skal du opsætte tilbudsskabeloner. Skabelonerne til tilbudsdokumenter, tilbudsdetaljer og ordrebekræftelser adskiller sig fra almindelige dokumentskabeloner, da de bruger "fletfelter" ud over standardskabelonvariabler.

### Eksempel: Ordrebekræftelse (overskrift)

Skabelonvariabler for tilbud og ordrebekræftelser kan bruges i forbindelse med et tilbud.

**Skabelon:**

```text
Ordredato: {sdat}
Ordrenummer: {qnum}
Leveringsbetingelser: {qdev}
Betalingsbetingelser: {qpev}
Dit PO-nummer: {qpon}
Vores kontaktperson: {cont}
```

**Resultat:**

```text
Ordredato: 15.12.2019
Ordrenummer: 550012
Leveringsbetingelser: Levering inkluderet
Betalingsbetingelser: 15 dage
Dit PO-nummer: 70000882
Vores kontakt: John Hansen
```

## Service og Marketing skabelonvariabler

Når du genererer mailskabeloner til anmodninger og forsendelser (og meddelelsesskabeloner) i Marketing, kan du tilpasse mailen eller mailingen med skabelonvariabler. Disse variabler er lidt forskellige fra dem, der bruges i dokumenter.

## Reference

Referencen er grupperet efter område. [Gå til reference][1]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->

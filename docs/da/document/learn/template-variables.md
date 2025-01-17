---
uid: help-da-template-variables
title: Skabelonvariabler
description: Med skabelonvariabler kan du tilpasse og automatisere indtastningen af kundedata
author: SuperOffice RnD
so.date: 02.23.2023
keywords: dokument, skabelon, fariable
so.topic: concept
language: da
---

# Skabelonvariabler

Skabelonvariabler bruges til at indsætte data fra SuperOffice i e-mails, tilbud, mødebeskeder, dokumentskabeloner osv. Du kan bruge skabelonvariabler til at tilpasse og automatisere indtastningen af kundedata (eller data fra kontakt, salg og andet) i dit indhold og oprette komplekse tilbud

> [!TIP]
> Se alle de forskellige [skabelonvariabler,][2] du har til **firmakortet**.

## Eksempler

Her viser vi dig nogle eksempler på, hvordan du bruger skabelonvariabler. Mange af eksemplerne bruger standardskabelonerne i SuperOffice.

### Sådan tilpasser du en e-mail ved hjælp af skabelonvariabler

I stedet for denne tekst:

"Kære kunde. Vil du vide mere om, hvordan vores produkt kan hjælpe din virksomhed med at skaffe nye kunder? Så bedes du ringe til os."

kan du sende denne:

"Hej Christian. Vil du vide mere om, hvordan vores produkt kan hjælpe Bilbutikken A/S med at skaffe nye kunder? Ring til Jesper Nielsen i SuperShop."

Teksten du skriver ser således ud:

"Hej **{atfn}** Vil du vide mere om, hvordan vores produkt kan hjælpe **{name}** med at skaffe nye kunder? Så skal du endelige ringer til os **{cont}** på **{onam}**."

### Signaturer

Dette er et eksempel på en signatur, der kan bruges af alle i virksomheden.

```text
Venlig hilsen
{auth}
{atit}
{onam}
Adresse: {opad}, {ozip} {ocit}
Telefon: {audp}
Mobiltelefon: {aupc}
{auem}
Med venlig hilsen
John Hansen
Salgschef
SuperShop
Adresse: Højgade 12, 2234, Springfelt
Telefon: 22334455
Mobiltelefon: 99887766
jh@supershop.com
supershop.com
```

### Mødereferater (overskrift)

Dette er et eksempel på et sidehoved i et mødereferat (dokument eller e-mail).

```text
{head}
Dato / Sted: {sdat}, {city}
Tilstede: {attn} ({name}), {auth} ({onam})
Fraværende:
Mødesekretær: {auth} ({auem})
Sommersalgskampagne - planlægning
Dato / Sted: 15.12.2019, London
Tilstede: Sara Møller (Liberty A/S.), John Hansen (SuperShop)
Fraværende:
Mødesekretær: John Hansen (jh@supershop.com)
```

### Ordrebekræftelse (overskrift)

Skabelonvariabler for tilbud og ordrebekræftelser kan bruges i forbindelse med et tilbud.

```text
Ordredato: {sdat}
Ordrenummer: {qnum}
Leveringsbetingelser: {qdev}
Betalingsbetingelser: {qpev}
Dit PO-nummer: {qpon}
Vores kontaktperson: {cont}
Ordredato: 15.12.2019
Ordrenummer: 550012
Leveringsbetingelser: Levering inkluderet
Betalingsbetingelser: 15 dage
Dit PO-nummer: 70000882
Vores kontakt: John Hansen
```

## Sådan bruges skabelonvariabler

* I dokumenter med filtypen .doc i Office 2003 og ældre skal du bruge klammer – &lt; &gt; – rundt om variablerne i stedet for krøllede parenteser – {} –.
* Hele variablen skal være formateret med samme skrifttype og skriftstørrelse, og du må kun bruge små bogstaver. Hvis præferencen **Tillad store bogstaver i skabelonvariabler** er aktiveret, kan skabelonvariablen dog formateres.
* Du kan blande almindelig tekst og variabler i skabelondokumentet: Du kan f.eks. tilføje skabelonvariabler, som henter et firmas navn og adresse, indtaste en standardtekst, som skal indsættes i brevet, og tilføje variablen for vores kontakt som afslutning på brevet.
* Du kan også anvende såkaldte fyldtegn i skabelondokumentet (se nedenfor).
* Dato og klokkeslæt i skabelonvariabler styres af systemuret på pc'en.

> [!TIP]
> Når du har oprettet et nyt skabelondokument, skal du tilføje det ved hjælp af skærmbilledet **Lister** i Indstillinger og vedligeholdelse for at kunne bruge den i SuperOffice CRM.

## Fyldtegn

Nogle gange kan det være nødvendigt at bruge fyldtegn i skabeloner for at sikre, at feltindhold eller -formatering ikke kan blive ændret eller slettet, hvis indholdet i et felt bliver kortere, end feltvariablen angiver.

Du kan bruge variablen padd# til at angive det fyldtegn, der skal bruges. Erstat #-tegnet med ANSI-koden for det tegn, du ønsker at bruge som fyldtegn. Du kan normalt finde en liste over ANSI-koder i håndbogen til det program, du opretter skabeloner for.

SuperOffice CRM har standardværdier for fyldtegn for de mest almindelige tekstbehandlings- og regnearksprogrammer. Normalt bruges blød bindestreg, fordi den ikke vises på skærmen eller på udskrifter. For programmer med ukendt konfiguration bruger SuperOffice CRM{padd32}, som er ANSI-koden for et mellemrum.

> [!TIP]
> Microsoft Word bruger {padd31} som fyldtegn.

Hvis du ikke ønsker at bruge fyldtegn, skal du bruge skabelonvariablen {padd0}.

> [!NOTE]
> Dette fungerer kun for dokumentformater, der er sekventielle, for eksempel Notesblok- og AmiPro-skabeloner uden grafik.

Når du bruger {padd0}, kan du skrive alle skabelonvariabler uden mellemrum mellem navnet på skabelonvariablen og det afsluttende variabeltegn (}).

## Variabler fra firmakortet

> [!NOTE]
> Adressevariabler fra firmakortet kaldes "intelligente" skabelonvariabler. Det betyder, at systemet vælger adresseoplysninger i en bestemt rækkefølge. Variablerne i **fed skrift** nedenfor (som f.eks. **addr** og **city**) er intelligente skabeloner.

Når du bruger adressevariabler fra firmakortet, vælger systemet adresseoplysninger i denne rækkefølge:

1. Hvis indstillingen **Brug som postadresse** er aktiv for en person i firmaet, bruges personens adresseoplysninger.
2. Hvis ovenstående indstilling ikke er aktiv, bruges firmaets adresseoplysninger.
3. Hvis firmaets postadresse er tom, bliver firmaets gade/vej brugt.

## Tilbud på skabelonvariabler

Når du bruger tilbud og produkter i SuperOffice, skal du opsætte tilbudsskabeloner, og variablerne findes i en pdf, der også viser, hvordan du arbejder med tilbudsskabeloner.

Skabelonerne til tilbudsdokumenter, tilbudsdetaljer og ordrebekræftelser adskiller sig fra almindelige dokumentskabeloner, da de bruger "fletfelter" ud over standardskabelonvariabler.

## Skabelonvariabler for service og marketing

Når du genererer mailskabeloner til anmodninger og forsendelser (og meddelelsesskabeloner) i Marketing, kan du tilpasse mailen eller mailingen med skabelonvariabler. Disse variabler er lidt forskellige fra dem, der bruges i dokumenter.

## Reference

Referencen er grupperet efter område. [Gå til reference][1]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/index.html
[2]:https://docs.superoffice.com/en/document/templates/variables/from-company-card.html

<!-- Referenced images -->

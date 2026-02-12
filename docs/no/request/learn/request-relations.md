---
uid: help-no-request-relations
title: Saksrelasjoner
description: Lær hvordan du kan koble relaterte saker ved hjelp av overordnede, underordnede og relaterte relasjoner for bedre å spore og administrere tilknyttede problemer i SuperOffice Service.
keywords: saksrelasjoner, koble saker, overordnet sak, underordnet sak, relaterte saker
author: digitaldiina
date: 02.17.2026
version: 11.10
content_type: howto
category: service
topic: request
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: no
---

# Saksrelasjoner

Saksrelasjoner lar deg koble saker for å vise forbindelser mellom problemer. Dette er nyttig når flere saker er relatert til samme problem, når en sak er avhengig av en annen, eller når du trenger å spore hierarkiske forbindelser mellom saker.

> [!NOTE]
> Saksrelasjoner brukes til å koble saker til andre saker. For å definere relasjoner mellom firmaer og personer, se [Firma- og personrelasjoner][4].

## Relasjonstyper

Det finnes tre typer saksrelasjoner:

* **Relatert:** En ikke-hierarkisk forbindelse mellom saker.

* **Overordnet:** En sak som har en eller flere underordnede saker.

* **Underordnet:** En sak som er koblet til en overordnet sak. Hver sak kan bare ha én overordnet sak.

## Brukstilfeller

Bruk **relatert** når saker er koblet, men ikke har et hierarki.

**Flere kunder som rapporterer samme problem**
Når forskjellige kunder rapporterer samme problem uavhengig av hverandre, kan du koble sakene som relaterte. Dette gir en flat visning av alle berørte kunder og bidrar til å sikre konsekvent kommunikasjon.

**Saker som inneholder flere spørsmål**
Hvis en sak inneholder urelaterte spørsmål, kan du dele den i separate saker for hver avdeling. Deretter kobler du dem som relaterte for å vise at de kommer fra samme sammenheng.

Bruk **overordnet og underordnet** når saker har et hierarkisk forhold eller avhengighet.

**Insidensporing med rotårsaksanalyse**
Opprett en overordnet sak for å spore det underliggende problemet. Koble hver kunderapport som en underordnet sak. En overordnet sak kan ha flere underordnede saker, men hver sak kan bare ha én overordnet.

**Håndtering av avhengigheter**
Når en sak må løses før en annen kan fullføres, kobler du dem ved hjelp av en overordnet-underordnet relasjon for tydelig å vise avhengigheten.

## Vis saksrelasjoner

Når en sak har en eller flere relasjoner, kan du se dem i fanen **Relasjoner** på saksskjermbildet.

### Listevisning

Standardvisningen viser relasjoner som en liste med følgende kolonner:

* Saks-ID
* Tittel
* Sist endret
* Eier
* Status
* Relasjonstype

![Saksrelasjoner i listevisning -screenshot][img1]

### Trevisning

Klikk på **Trevisning** for å vise relasjoner i en hierarkisk struktur, noe som gjør overordnede og underordnede relasjoner lettere å visualisere:

![Saksrelasjoner i trevisning -screenshot][img2]

> [!TIP]
> Fanen **Relasjoner** viser en oransje indikator når saken har en eller flere relasjoner, noe som gjør det enkelt å identifisere koblede saker med et blikk.

### Ulike perspektiver

Relasjoner er toveisorienterte. Begge saker i relasjonen viser forbindelsen:

* Hvis Sak A er **overordnet** for Sak B, vil Sak B vise Sak A som sin overordnede
* Hvis Sak A er **relatert** til Sak B, vil Sak B vise at den er relatert til Sak A

![Samme relasjon sett fra den relaterte saken -screenshot][img3]

## <a id="add"></a>Legg til saksrelasjon

Du kan legge til en relasjon fra følgende steder:

### Fra saksskjermbildet

1. Åpne saken du vil koble.

1. Velg fanen **Relasjoner**.

1. Klikk på **Ny relasjon**.

1. I feltet **Relasjonstype** velger du **Relatert**, **Overordnet** eller **Underordnet**.

1. I seksjonen **Koble til** velger du **Koble til eksisterende** (standard).

1. Begynn å skrive i søkefeltet for å finne saken du vil koble. Du kan søke etter saks-ID, tittel, firma eller person.

1. Velg saken fra listen. Du kan holde markøren over en sak i listen for å vise en forhåndsvisning av detaljene.

1. Legg eventuelt til en kommentar som forklarer relasjonen.

1. Klikk på **Koble** for å opprette koblingen.

### Fra detaljkortet Saker

1. Gå til et Firma-, Person-, Salg- eller Prosjektskjermbilde.

1. Velg detaljkortet **Saker**.

1. Høyreklikk på saken du vil opprette en relasjon fra.

1. Velg **Relasjoner** fra kontekstmenyen.

1. Følg trinn 4-9 ovenfor for å fullføre relasjonen.

![Kontekstmeny med alternativ for Relasjoner -screenshot][img4]

## Opprett ny sak som relasjon

I stedet for å koble til en eksisterende sak, kan du opprette en ny sak mens du etablerer relasjonen:

1. Følg trinnene ovenfor for å åpne dialogboksen **Relasjoner**.

1. I seksjonen **Koble til** velger du **Opprett ny sak**.

1. Fyll ut saksdetaljene.

1. Klikk på **Koble** for å opprette både den nye saken og koblingen samtidig.

## <a id="delete"></a>Fjern saksrelasjon

1. Åpne saken og velg fanen **Relasjoner**.

1. Finn relasjonen du vil fjerne.

1. Klikk på <i class="ph ph-x-circle" aria-label="Fjern ikon"></i> **Fjern relasjon** nederst i dialogboksen, eller høyreklikk på relasjonen og velg **Fjern relasjon**.

1. Bekreft slettingen.

Fjerning av en relasjon sletter kun koblingen. Sakene forblir uendret.

## Feilsøking

### Knappen Fjern relasjon kan ikke klikkes

Knappen **Fjern relasjon** er kun aktiv når du har valgt nøyaktig én relasjon. Sørg for at du har:

* Valgt en enkelt relasjon fra listen
* Ikke valgt flere relasjoner

### Kan ikke legge til overordnet eller underordnet relasjon

**Årsak:** En sak kan bare ha én overordnet. Hvis saken allerede har en overordnet, kan du ikke tilordne en annen overordnet relasjon.

**Løsning:** Fjern den eksisterende overordnede relasjonen først, eller bruk en **Relatert** relasjonstype i stedet, som tillater flere forbindelser.

### Kan ikke opprette relasjon

**Mulige årsaker:**

* **Duplikat relasjon:** De to sakene er allerede koblet. Sjekk fanen Relasjoner for å se om relasjonen allerede eksisterer.
* **Sirkulært hierarki:** Du kan ikke opprette en overordnet-underordnet relasjon som vil resultere i en sirkulær referanse (f.eks. Sak A er overordnet for Sak B, og Sak B er overordnet for Sak A).

**Løsning:** Kontroller eksisterende relasjoner og juster hierarkistrukturen din for å unngå sirkulære avhengigheter.

## Relatert innhold

* [Del sak][2]
* [Slå sammen saker][1]
* [Detaljkort for Saker][3]
* [Firma- og personrelasjoner][4]

<!-- Referenced links -->
[1]: merge.md
[2]: split-request.md
[3]: ../../learn/section-tabs/requests-tab.md
[4]: ../../learn/basics/relations.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/request-relations-archive.png
[img2]: ../../../media/loc/en/request/request-relations-tree.png
[img3]: ../../../media/loc/en/request/request-relations-perspective.png
[img4]: ../../../media/loc/en/request/request-relations-context-menu.png

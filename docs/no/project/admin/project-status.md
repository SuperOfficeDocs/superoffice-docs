---
uid: help-no-project-status
title: Prosjektstatus
description: Finn ut hvordan du legger til en ny prosjektstatus i SuperOffice CRM. Opprett og administrer forhåndsdefinerte statuser for å spore prosjektfaser og effektivisere arbeidsflyter.
keywords: legg til prosjektstatus, prosjektstatus, prosjekt, listen Prosjekt - Status
author: Bergfrid Dias
date: 01.31.2025
version: 10.5
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Prosjektstatus

[!include[Må være administrator](../../learn/includes/req-admin.md)]

Feltet **Status** i **Prosjekt**-kortet hjelper deg med å kategorisere og spore fremdriften i et prosjekt. Disse statusene er forhåndsdefinerte i listen **Prosjekt - Status**, som du kan administrere i **Lister** i **Innstillinger og vedlikehold**.

Statuser kan knyttes til [prosjekttyper][1], slik at du kan spesifisere hvilke statuser som skal være tilgjengelige for hver type. Hvis det ikke er definert en prosjektguide, vil feltet **Status** fortsatt være synlig i prosjektet, slik at brukere kan se og oppdatere prosjektets gjeldende status.

## Legge til en status

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **Prosjekt - Status** fra menyen. Fanen **Elementer** viser alle eksisterende statuser.

1. Klikk på **Legg til** for å åpne dialogboksen **Rediger listeelement**.

1. Skriv inn navnet på den nye statusen i feltet **Navn**. *(Obligatorisk)*

    Dette navnet vises i feltet **Status** i **Prosjekt**-bildet.

1. *(Valgfritt)* Legg til en beskrivelse i feltet **Beskrivelse** for å forklare hensikten med statusen.

1. Klikk **Lagre** for å bekrefte endringene eller **Avbryt** for å forkaste dem.

## Redigere eller slette en status

1. Følg trinn 1–2 i **Legge til en status** for å få tilgang til listen **Prosjekt - Status**.

1. For å redigere:
   1. Dobbeltklikk på ønsket status for å åpne dialogboksen **Rediger listeelement**.
   1. Oppdater feltene etter behov og klikk **Lagre**.

1. For å slette:
   1. Velg statusen i listen og klikk **Slett**.

    > [!CAUTION]
    > Hvis du sletter en status, fjernes den fra alle tilknyttede prosjekttyper og prosjektguider. Sørg for at statusen ikke er i aktiv bruk før du fortsetter.

## Gjenopprette en slettet prosjektstatus

Hvis en prosjektstatus har blitt slettet, kan du gjenopprette den fra listen **Prosjekt - Status**. Merk at en gjenopprettet status ikke automatisk gjenoppretter koblinger til tilknyttede prosjekttyper eller guider. Du må manuelt opprette disse koblingene på nytt hvis nødvendig.

Prosedyren er lik den for [gjenoppretting av en slettet prosjekttype][2].

## Relatert innhold

* [Legge til eller oppdatere prosjekttyper][1]
* [Opprette en prosjektguide][3]
* [Redigere en prosjektguide][4]
* [Flytte prosjekt til neste status][5]

<!-- Refererte lenker -->
[1]: project-type.md
[2]: project-type.md#restore
[3]: create-project-guide.md
[4]: edit-project-guide.md
[5]: ../learn/project-guides.md#change-status

---
uid: help-no-project-type
title: Prosjekttype
description: Finn ut hvordan du oppretter en ny prosjekttype i SuperOffice CRM. Definer navn, sett estimert varighet, knytt statuser og eventuelt en prosjektguide for en mer strukturert prosjektstyring.
keywords: legg til prosjekttype, prosjekttype, listen Prosjekt - Type, status, prosjekt
author: Bergfrid Dias
date: 01.31.2025
version: 10.5
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Prosjekttype

[!include[Må være administrator](../../learn/includes/req-admin.md)]

Feltet **Type** i **Prosjekt**-bildet kategoriserer prosjekter og definerer deres arbeidsflyt. Disse typene er forhåndsdefinerte i listen **Prosjekt - Type, status**, som du kan administrere i **Lister** i **Innstillinger og vedlikehold**.

Hvert prosjekt må ha en type, og disse typene kan knyttes til spesifikke [statuser][1] og eventuelt til [prosjektguider][4]. Prosjektguider gjør gjennomføringen enklere ved å lede brukerne gjennom forhåndsdefinerte faser, oppfølginger og dokumenter.

## Legge til en prosjekttype

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **Prosjekt - Type, status** fra menyen. Fanen **Elementer** viser alle eksisterende prosjekttyper.

1. Klikk på **Legg til** for å åpne dialogboksen **Rediger listeelement**.

    ![Dialogboks for redigering av prosjekttype -screenshot][img1]

1. Skriv inn et navn for prosjekttypen i feltet **Navn**. *(Obligatorisk)*

    Dette navnet vises i feltet **Type** i **Prosjekt**-bildet.

1. Angi en estimert varighet for prosjektet i feltet **Anslått tid for denne prosjekttypen** (antall uker, dager eller måneder).

    Dette bestemmer standard sluttdato når et nytt prosjekt opprettes.

1. Velg de nødvendige statusene i listen **Aktive statuser for denne prosjekttypen**.

    > [!NOTE]
    > For å knytte prosjekttypen til en prosjektguide, må du velge minst to statuser.

1. *(Valgfritt)* Merk av for **Denne prosjekttypen er tilknyttet en guide** hvis du vil at prosjekter av denne typen skal følge en prosjektguide.

1. *(Valgfritt)* Merk av for **Foreslå automatisk flytting av prosjektet til neste status** for å be brukerne om å [gå til neste status][5] når alle aktiviteter i den gjeldende statusen er fullført.

1. Legg til en beskrivelse av prosjekttypen i feltet **Beskrivelse**, hvis ønskelig.

1. Klikk **Lagre** for å bekrefte endringene eller **Avbryt** for å forkaste dem.

    Prosjekttypen legges nå til i listen **Elementer**. Gjenta disse trinnene for å legge til flere prosjekttyper.

## Redigere eller slette en prosjekttype

1. Følg trinn 1–2 ovenfor for å få tilgang til listen **Prosjekt - Type, status**.

1. For å redigere:
   * Dobbeltklikk på ønsket prosjekttype for å åpne dialogboksen **Rediger listeelement**.
   * Gjør nødvendige endringer og klikk **Lagre**.

1. For å slette:
   * Velg prosjekttypen i listen og klikk **Slett**.

    > [!CAUTION]
    > Hvis du sletter en prosjekttype, fjernes også koblingen til tilknyttede statuser og prosjektguider. Sørg for at typen ikke er i aktiv bruk før du fortsetter.

## <a id="restore"></a>Gjenopprette en slettet prosjekttype

Hvis en prosjekttype har blitt slettet, kan du gjenopprette den fra listen **Prosjekt - Type, status**. Merk at en gjenopprettet prosjekttype ikke automatisk gjenoppretter koblinger til tilknyttede prosjektstatuser eller guider. Du må manuelt opprette disse koblingene på nytt hvis nødvendig.

1. Gå til listen **Prosjekt - Type, status**.

1. Merk av for **Vis slettede elementer og overskrifter** nederst i bildet. Slettede elementer vises med gjennomstreking i fanen **Elementer**.

1. Dobbeltklikk på det slettede elementet du vil gjenopprette. Dialogboksen **Rediger listeelement** åpnes.

1. Klikk **Gjenopprett**.

1. Oppdater eventuelle nødvendige felt og klikk **Lagre**. Elementet er nå aktivt og vil vises i fanen **Elementer**.

## Relatert innhold

* [Legge til en prosjektstatus][1]
* [Opprette en prosjektguide][2]
* [Redigere en prosjektguide][3]

<!-- Refererte lenker -->
[1]: project-status.md
[2]: create-project-guide.md
[3]: edit-project-guide.md
[4]: ../learn/project-guides.md
[5]: ../learn/project-guides.md#change-status

<!-- Refererte bilder -->
[img1]: ../../../media/loc/en/project/edit-project-type.png

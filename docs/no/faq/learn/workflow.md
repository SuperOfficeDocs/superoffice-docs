---
uid: help-no-faq-workflow
title: Faser i arbeidsflyt
description: Faser i arbeidsflyt
author: SuperOffice RnD
date: 06.29.2022
keywords: FAQ
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: no
---

# Faser i arbeidsflyt

I en ny installasjon har du to standardfaser i arbeidsflyten: **Upublisert** og **Publisert**. Det er mulig å legge til flere trinn mellom disse. Du kan for eksempel sette opp en arbeidsflyt der en FAQ-oppføring sendes til korrekturlesing, slik at noen sjekker oppføringen og deretter publiserer den eller sender den upublisert tilbake til redigering.

## Opprett ny fase

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> i toppraden og velg **Kunnskapsbase** > **FAQ**.
1. Klikk på **Arbeidsflyt**-knappen. Du kommer til bildet **Vis arbeidsflyt**.
1. Klikk på **Nytt trinn**-knappen. Du kommer til bildet **Nytt trinn**.
1. Angi et beskrivende navn på trinnet i feltet **Navn**.
1. I listen **Plasser nytt trinn mellom** velger du hvor i prosessen du vil sette inn det nye trinnet.
1. Klikk på **OK**. Du kommer til bildet **Rediger trinn**.
1. I listen **Velg bruker** nederst i bildet velger du navnet på en bruker som skal ha tilgang til det aktuelle trinnet i arbeidsflyten.
1. Velg hvilket tilgangsnivå brukeren skal ha. Du kan velge mellom følgende alternativer:
    * **Kan flytte**: Brukeren har tillatelse til å endre fasen i arbeidsflyten for oppføringer (publisere eller avbryte publisering).
    * **Kan redigere**: Brukeren har rettigheter til å endre FAQ-oppføringer.
    * **Full tilgang**: Brukeren har alle rettigheter i forbindelse med arbeidsflyt.
1. Klikk på **+** for å legge til brukeren i listen under **Brukertilgang**.
1. Gjenta trinn 7–9 ovenfor hvis du vil legge til flere brukere.
1. Klikk på **OK**. Fasen opprettes og er nå tilgjengelig når du publiserer FAQ-oppføringer.

## Redigere trinn

Du kan endre både navnet på en fase og justere hvilke brukere som skal ha tilgang til den.

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> i toppraden og velg **Kunnskapsbase** > **FAQ**.
1. Klikk på **Arbeidsflyt**-knappen.
1. Klikk på navnet til fasen. Du kommer til bildet **Rediger trinn**.
1. Endre navnet hvis det er behov for det.
1. Juster hvilke brukere som skal ha tilgang til det aktuelle trinnet:
    * Hvis du vil legge til brukere, følger du fremgangsmåten ovenfor.
    * Hvis du vil fjerne brukere, velger du brukeren(e) det gjelder, og klikker på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> og velger **Fjern tilgang for utvalgte brukere**.
1. Klikk på **OK**. Endringene lagres.

## Slette fase

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> i toppraden og velg **Kunnskapsbase** > **FAQ**.
1. Klikk på **Arbeidsflyt**-knappen (<i class="ph ph-gear" aria-hidden="true"></i>).
1. Klikk på navnet til fasen. Du kommer til bildet **Rediger trinn**.
1. Klikk på **Slett**. Hvis fasen ikke har noen tilknyttede FAQ-oppføringer, slettes den umiddelbart.

   > [!NOTE]
   > Du kan ikke slette standardfasene **Upublisert** og **Publisert**.

1. Hvis den er koblet til FAQ-oppføringer, velger du hvilken fase i arbeidsflyten disse FAQ-oppføringene skal flyttes til. Velg ønsket fase i listen **Flytt til arbeidsflyt**.
1. Klikk på **Slett**. Fasen slettes, og tilknyttede FAQ-oppføringer flyttes til valgt fase.

## Publisere via arbeidsflyt

1. [Åpne FAQ-oppføringen][1].
1. Hvis du vil justere noe før publisering, følg prosedyren under [Publiser FAQ-oppføringer][2].
1. Klikk på knappen **Flytt fremover i arbeidsflyt** inntil **Publisert** vises i feltet **Arbeidsflytfase** i fanen **Detaljer**.

   > [!TIP]
   > Du kan velge å avbryte publiseringen av FAQ-oppføringen ved klikke på knappen **Flytt bakover i arbeidsflyt**.

<!-- Referenced links -->
[1]: view-entry.md
[2]: publish.md

<!-- Referenced images -->

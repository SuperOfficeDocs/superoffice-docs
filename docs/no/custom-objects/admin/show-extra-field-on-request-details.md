---
uid: help-no-extra-field-display
title: Vis ekstrafelt i fanen Detaljer
description: Vis ekstrafelt i fanen Detaljer
keywords: ekstrafelt, sak, layout, Skjermdesigner
author: Bergfrid Dias
date: 01.18.2024
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Vis ekstrafelt i fanen Detaljer

Scenario: Du har lagt til et ekstrafelt for firma (`contact` tabellen) som indikerer om et firma har en støtteavtale, og du ønsker å vise denne informasjonen når du ser på en sak.

<!-- markdownlint-disable-file MD051 -->
## Trinn

### [I den nye skjermen for saker med Skjermdesigner](#tab/screen-designer)

1. Gå til **Innstillinger og vedlikehold** > **Skjermdesigner** og velg fanen **Sak**.
1. Klikk på **Rediger oppsett** nederst.
1. Finn innstillingen for **Felter**.
1. Velg ditt felt.
1. Velg eventuelt passende stileringsalternativer.
1. Klikk på **Lagre** for å lagre innstillingene.

> [!TIP]
> Du kan også gruppere felt, legge til overskrifter for grupper og endre størrelsen på kolonner. [Lær mer om Skjermdesigner][1].

### [I klassisk Service](#tab/service)

I Service må du opprette en felles elementprofil.

1. Gå til **Innstillinger og vedlikehold** > **Systemdesign** og velg fanen **Profil**.

1. Velg **Systemskjermer**. Klikk deretter på **Vis sak**, pek på **Saksinfo**, og klikk på **Ny felles profil**.

1. Skriv inn et **navn** for den nye profilen.

1. Klikk på **Legg til kriterier**-knappen og gjør følgende:

    1. Skriv inn en UI-etikett for det ekstra feltet.
    1. Velg hvilket felt i databasen du vil hente data fra.
    1. Klikk på **OK**. Det nye kriteriet legges til under de andre.
    1. Eventuelt legg til flere kriterier.

1. Klikk **OK**. Den nye profilen er opprettet.

1. Klikk på hamburgemenyen igjen og velg **Roller**.

1. Velg en rolle (hvem som skal kunne se feltet på forespørslsesskjermen).

1. I dialogboksen, velg fanen **Profil**.

1. Fra listen **Ny elementprofil**, velg profilen du nettopp opprettet.

1. Klikk **OK** for å lagre innstillingene.

Alle brukere som har denne rollen, vil nå kunne se det ekstra feltet i fanen **Detaljer** i alle deres forespørsler.

***

<!-- Referenced links -->
[1]: ../../../en/ui/screen-designer/configurable-screens/working-with-fields.md

---
uid: help-da-extra-field-display
title: Vis ekstra felt på fanen Detaljer
description: Vis ekstra felt på fanen Detaljer
keywords: extra field, custom field, request, layout, screen designer
author: Bergfrid Dias
date: 0130.2024
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Vis ekstra felt på fanen Detaljer

Scenarie: Du har tilføjet et ekstra felt til virksomhed (`contact` tabellen), der angiver, om en virksomhed har en supportaftale, og du ønsker at vise den information, når du ser en anmodning.

<!-- markdownlint-disable-file MD051 -->
## Trin

### [I den nye anmodningsskærm med Screen Designer](#tab/screen-designer)

1. Gå til **Indstillinger og vedligeholdelse** > **Screen designer** og vælg fanen **Anmodninger**.
1. Klik på **Rediger layout** nederst.
1. Find indstillingen **Felter**.
1. Vælg dit felt.
1. Vælg eventuelt passende stylingmuligheder.
1. Klik på **Gem** for at gemme indstillingerne.

> [!TIP]
> Du kan også gruppere felter, tilføje overskrifter til grupper og ændre størrelsen på kolonner. [Læs mere om Screen Designer][1].

### [I klassisk Service](#tab/service)

I Service skal du oprette en fælles elementprofil.

1. Gå til **Indstillinger og vedligeholdelse** > **Systemdesign** og vælg fanen **Profil**.

1. Vælg **Systemskærme**. Klik derefter på **Vis billet**, peg på **billetinfo**, og klik på **Ny fælles profil**.

1. Indtast et **navn** til den nye profil.

1. Klik på **Tilføj kriterium**-knappen og udfør følgende:

    1. Indtast en UI-etiket til det ekstra felt.
    1. Vælg hvilket felt i databasen, du vil hente data fra.
    1. Klik på **OK**. Det nye kriterium tilføjes under de andre.
    1. Tilføj eventuelt flere kriterier.

1. Klik **OK**. Den nye profil er oprettet.

1. Klik på hamburgermenuen igen og vælg **Roller**.

1. Vælg en rolle (hvem der skal kunne se feltet på anmodningsskærmen).

1. I dialogboksen skal du vælge fanen **Profil**.

1. Fra listen **Ny elementprofil** skal du vælge profilen, du lige har oprettet.

1. Klik **OK** for at gemme indstillingerne.

Alle brugere, der har denne rolle, vil nu kunne se det ekstra felt på fanen **Detaljer** i alle deres anmodninger.

***

<!-- Referenced links -->
[1]: ../../../en/ui/screen-designer/configurable-screens/working-with-fields.md

---
uid: help-da-request-escalation
title: Eskaleringsniveauer
description: Eskaleringsniveauer
keywords: eskaleringsniveau, tilføj eskaleringsniveau, nyt niveau, eskalere, fanen Eskaleringsniveauer, sagsprioritet, sag, prioritet
author: Hanne Gunnarsson
date: 03.07.2025
version: 10.5.2
topic: howto
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Eskaleringsniveauer

For hver sag med **prioritet** kan du definere et eller flere eskaleringsniveauer, så systemet sender henvendelsen videre i organisationen, hvis den ikke bliver læst eller behandlet inden for en angivet tid.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Sådan definerer du nye niveauer

1. Klik på knappen **Sager** i navigatoren, og vælg fanen **Prioriteter**.

1. Vælg en prioritet, som du vil oprette eskaleringsniveauer for.

1. Vælg fanen **Eskaleringsniveauer** .

1. Klik på knappen **Tilføj**. Du opretter nu det første eskaleringsniveau.

1. Angiv følgende oplysninger:

    * **Indtræffer efter**
    * **Fordel igen til**
    * **Kør script**

    Detaljer om hvert felt er angivet nedenunder.

1. Under **Send svarskabelon** kan du definere, hvem der skal modtage en e-mail og SMS, når dette eskaleringsniveau udløses.

    Vælg afkrydsningsfelterne for **E-mail** eller **SMS** ud for hver modtager, og vælg den relevante svarskabelon. Hvis du vælger **Andre**, skal du indtaste de relevante e-mailadresser (brug kommaer) og telefonnumre i felterne nedenunder.

    > [!NOTE]
    > Hvis fanen **Send svarskabelon på SMS til** ikke vises, betyder det, at SMS ikke er aktiveret for den licens, du bruger. Kontakt den systemansvarlige for at få flere oplysninger.

1. Klik på **Gem**.

1. Gentag disse trin for at oprette yderligere eskaleringsniveauer.

1. Hvis du har oprettet flere eskaleringsniveauer, kan du definere den rækkefølge, de skal forekomme i, ved hjælp af pileknapperne nedenunder listen over eskaleringsniveauer.

## Indstillinger for eskalering

| Indstilling | Beskrivelse |
|---|---|
| Prioritet | Den prioritet, som eskaleringsniveauet skal knyttes til. |
| Indtræffer efter | Hvor lang tid der skal gå, før dette eskaleringsniveau aktiveres. Hvis det er angivet for prioriteten, at eskaleringen skal følge tidsrammen, vil det påvirke det klokkeslæt, der indtastes her. En prioritet med tidsramme fra mandag til fredag, 09.00 til 17.00, og første eskaleringsniveau efter 2 timer, eskaleres f.eks. mandag kl. 10.00, hvis sagen blev registreret fredag kl. 16.00. |
| Fordel igen til | Hvis du ønsker, at sagen skal sendes til en anden sagsbehandler, når dette eskaleringsniveau indtræffer, kan du markere denne valgmulighed. Vælg den ønskede bruger på listen. |
| Kør script | Hvis du ønsker, at der skal køres et script, når dette eskaleringsniveau indtræffer, kan du markere denne valgmulighed. Vælg det ønskede script på listen. |

## Indstillinger for Svarskabelon

| Indstilling | Beskrivelse |
|---|---|
| Kontaktperson | Hvis denne indstilling er valgt, sendes den svarskabelon, der er angivet i feltet til højre, til sagens person, når dette eskaleringsniveau forekommer. Vælg den ønskede svarskabelon på listen. |
| Sagsejer | Hvis denne indstilling er valgt, sendes den svarskabelon, der er angivet i feltet til højre, til sagens ejer, når dette eskaleringsniveau forekommer. Vælg den ønskede svarskabelon på listen. |
| Kategoriadministrator | Hvis denne indstilling er valgt, sendes den svarskabelon, der er angivet i feltet til højre, til den kategoriansvarlige, når dette eskaleringsniveau forekommer. Vælg den ønskede svarskabelon på listen. |
| Andre | Hvis denne indstilling er valgt, sendes den svarskabelon, der er angivet i feltet til højre, til den/de e-mailadresser, der er angivet i feltet nedenunder. Vælg den ønskede svarskabelon på listen. |
| E-mailadresse | Her indtaster du den e-mailadresse, som svarskabelonen i feltet **Andre** skal sendes til. Du kan tilføje flere adresser, hvis du sætter komma mellem dem. |

## Slet eskaleringsniveau

1. Vælg det eskaleringsniveau, du vil slette.
2. Klik på knappen **Slet** nederst i skærmbilledet.

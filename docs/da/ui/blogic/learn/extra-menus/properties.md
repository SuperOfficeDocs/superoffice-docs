---
uid: help-da-ui-extra-menu-properties
title: Egenskaber for menu
description: Egenskaber for menu
author: SuperOffice RnD
date: 06.29.2022
keywords: Tjeneste
topic: howto
language: da
---

# Egenskaber for menu

[!include[Legacy](../includes/legacy-extra-menus.md)]

Her kan du redigere egenskaberne for punkter i ekstramenuer og browserfaner.

* **Basisprogram**: Vælg et basisprogram her, hvis du ønsker, at indholdet i URL-feltet skal tilføjes i det valgte basisprogram. For at dette skal fungere, skal teksten i feltet URL skal starte med &action=...

* **URL**: Den webadresse, der åbnes, når brugeren klikker på menupunktet.

* **Tilføj id**: Tilføjer automatisk id'et på den aktuelle post i slutningen af webadressen.

* **Tilbage til samme skærmbillede**: Hvis du markerer dette felt, returneres brugerne automatisk til det skærmbillede, hvor der blev klikket på knappen (eller lignende). Ellers skal brugerne gøre dette manuelt.

  * Eksempel på, hvornår denne indstilling skal bruges: Hvis du opretter en knap (makro) på skærmbilledet Sag for at ændre sagens kategori, vil du også vende tilbage til den samme sag, når du har klikket på knappen.

  * Eksempel på, hvornår denne indstilling IKKE skal bruges: Hvis du opretter en knap (et script), der viser en masse information på skærmbilledet, skal du ikke have dette markeret, fordi du gerne vil se informationen på skærmbilledet. Det samme gælder eksterne URL-adresser, fordi du vil gå til webstedet, når du klikker på knappen.

* **Tilføj &lt;usec&gt;**: &lt;usec&gt; er sessionsnøglen til NetServer-sessionen. For at få et webpanel til at fungere med NetServer med brug af Godkendelse skal nøglen inkluderes.

* **Destination**: Destinationen på den webadresse, der åbnes. Du kan vælge, hvilket vindue URL'en skal åbnes i, ved at indtaste vinduets forekomstnavn i feltet **Mål**. Du kan skrive "_blank", hvis du altid vil åbne et nyt vindue/en ny fane, eller for eksempel "kunde" for at åbne et nyt vindue til dette menupunkt eller en gruppe menupunkter.

* **URL til ikon**: Hvis du ønsker at få vist et eget ikon foran menuen, kan du tilføje en webadresse til et billede her.

* **Position**: Bestemmer sorteringsrækkefølgen for ekstramenuerne (0 = top).

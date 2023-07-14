---
uid: help-da-automation-script-tracing
title: Sporing
description: Sporing
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRMScript, spor, debug
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Sporing

Sporingsfunktionen optager alle detaljer i udførelsen af et script eller en makro og gemmer dette i en logfil. Hver gang scriptet eller makroen udføres, optages udførelsen.

Du kan derefter undersøge udførelse af scriptet ved at spole tilbage og frem gennem optagelsen. Du får en komplet liste over alle de optagne udførelser af scriptet, og hvem der udførte scriptet. Det gør det muligt for dig at se, hvordan dine scripts har opført sig, og se alle variablerne på ethvert givet tidspunkt.

## Vis sporinger

Fanen **Sporing** indeholder en liste over alle sporinger. Klik på en sporing på listen for at få vist detaljerne.

## Start sporinger

* Gå til **CRMScript** > **Fejlfindingssessioner,** og klik på ![ikon][img1] **Start sporingsscripts** for at starte sporing af scripts på listen.
* Åbn et script eller en makro i **Fejlfinding**, og klik på ![ikon][img2] **Spor script**.
* Åbn et script eller en makro i fanen **Makroer og script**, og klik på ![ikon][img2] **Spor script**.

## Rediger sporinger

1. Klik på en sporing på listen **Sporing** for at åbne den.

2. Klik på ![ikonet][img3] **Rediger sporing**. Skærmbilledet **Rediger sporing** vises.

3. Udfyld de følgende felter:

    * **Beskrivelse**: Angiv en beskrivelse af sporingen, som gør den lettere at identificere.
    * **Brugerfilter**: Du kan spore scriptet for en bestemt bruger ved at vælge brugeren på listen.
    * **Opløsning af sporing**: Angiv samplingsfrekvensen for sporingsloggen.
        Eksempel: Angiv 1 for at logge alle kommandoer, der udføres af scriptet. Angiv 5 for at logge hver femte kommando, der udføres af scriptet.
    * **Behold sporinger**: Vælg, hvor længe sporingen skal beholdes.
    * **Aktiveret**: Vælg denne valgmulighed for at aktivere sporingen.

4. Klik på **OK**, når du er færdig.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/icons/run-script.png
[img2]: ../../../../media/icons/btn-script-trace-small.png
[img3]: ../../../../media/icons/edit.png

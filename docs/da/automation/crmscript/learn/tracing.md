---
uid: help-da-automation-script-tracing
title: Sporing
description: Sporing
author: Bergfrid Dias
date: 12.20.2023
version: 10.2.11
keywords: CRMScript, spor, debug
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Sporing

Sporingsfunktionen optager alle detaljer i udførelsen af et script eller en makro og gemmer dette i en logfil. Hver gang scriptet eller makroen udføres, optages udførelsen.

Du kan derefter undersøge udførelse af scriptet ved at spole tilbage og frem gennem optagelsen. Du får en komplet liste over alle de optagne udførelser af scriptet, og hvem der udførte scriptet. Det gør det muligt for dig at se, hvordan dine scripts har opført sig, og se alle variablerne på ethvert givet tidspunkt.

## Vis sporinger

Fanen **Sporing** indeholder en liste over alle sporinger. Klik på en sporing på listen for at få vist detaljerne.

## Start sporing

1. Gør en af følgende:

    * Åbn et script eller en makro i **Fejlfinding**, og klik på **Spor script**.
    * Åbn et script eller en makro i fanen **Makroer og script**, og klik på **Spor script**.

2. Indtast en **Beskrivelse** af sporet, for at gøre det nemmere at identificere.
3. Valgfrit, indstil **Brugerfilter** hvis du ønsker et brugerspecifikt spor.
4. Valgfrit, specificér varsling og lagrings egenskaber. Se [liste over felter](#fields) nedenfor.
5. Vælg **Aktiveret** for at aktivere sporet.
6. Klik **OK** når du er færdig.

## Slå alle aktiverede spor til/fra

1. Gå til **CRMScript** > **Fejlfindingssessioner**.
2. Klik på **Start sporingsscripts** for at starte sporingen af scripts i listen.
    Klik på **Stop sporingsscripts** for at pause sporingen.

## Rediger sporing

1. Klik på en sporing i **Sporing** listen for at åbne den.
2. Klik **Rediger sporing**.
3. Opdater felterne som nødvendigt.
4. Klik **OK** når du er færdig.

![Spor CRMScript -screenshot][img4]

### <a id="fields"></a>Felt

| Felt | Beskrivelse |
|---|---|
| Beskrivelse | En forklaring af sporet, for at gøre det nemmere at identificere. |
| Brugerfilter | Begrænser sporingen til en bestemt bruger. |
| Opløsning af sporing | Samplingsfrekvensen af sporloggen. 1 - spor hver udførelse af skriptet; 5 - spor hver femte udførelse; og så videre. |
| Behold sporinger | Hvor længe at beholde et spor før det slettes. |
| Aktiveret | Aktiverer sporingen. |
| Giv besked | Om man skal sende varslingse-mails. |
| Maksimalt antal beskeder: | Begrænser antal e-mails sendt. |
| Notifikations-e-mail | Hvor man skal sende varsler. |
| Gem kun, hvis der er en ikke-håndteret undtagelse | Begrænser spor til undtagelser. |

<!-- Referenced links -->

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/automation/trace.png

---
uid: help-no-automation-script-tracing
title: Sporing
description: Sporing
author: Bergfrid Dias
date: 12.20.2023
version: 10.2.11
keywords: CRMScript, spor, feilsøking
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Sporing

Sporingsfunksjonen registrerer alle detaljer under kjøringen av skript eller makroer og lagrer dem i en logg. Hver gang skriptet eller makroen brukes, registreres kjøringen.

Deretter kan du undersøke skriptkjøringen ved å spole bakover- og forover i innspillingen. Du får en fullstendig liste over alle de innspilte kjøringene av skriptet, og hvem som kjørte skriptet. Dette gjør det mulig for deg å se hvordan skriptene fungerte, og se alle variabler på et gitt punkt.

## Se sporinger

I fanen **Sporing** finner du en oversikt over alle sporinger. Klikk på en sporing i listen for å vise detaljene.

## Start sporing

1. Gjør en av følgende:

    * Åpne et skript eller en makro i **Feilsøking**, og klikk deretter på **Spor skript**.
    * Åpne et skript eller en makro i fanen **Makroer og skript**, og klikk deretter på **Spor skript**.

2. Skriv inn en **Beskrivelse** av sporet, for å gjøre det lettere å identifisere.
3. Valgfritt, sett **Brukerfilter** hvis du vil ha et brukerspesifikt spor.
4. Valgfritt, spesifiser varsling og lagringsegenskaper. Se [liste over felt](#fields) nedenfor.
5. Velg **Aktivert** for å aktivere sporet.
6. Klikk **OK** når du er ferdig.

## Slå på/av alle aktiverte spor

1. Gå til **CRMScript** > **Feilsøkingssesjoner**.
2. Klikk på **Start sporing av skript** for å starte sporingen av skriptene i listen.
    Klikk på **Stopp sporing av skript** for å pause sporingen.

## Rediger sporing

1. Klikk på en sporing i listen **Sporing** for å åpne den.
2. Klikk **Rediger sporing**.
3. Oppdater feltene som nødvendig.
4. Klikk **OK** når du er ferdig.

![Spor CRMScript -screenshot][img4]

### <a id="fields"></a>Felt

| Felt | Beskrivelse |
|---|---|
| Beskrivelse | En forklaring av sporingen, for å gjøre den lettere å identifisere. |
| Brukerfilter | Begrenser sporingen til en bestemt bruker. |
| Sporingsoppløsning | Samplingsfrekvensen for sporeloggen. 1 - spor hver utførelse av skriptet; 5 - spor hver femte utførelse; og så videre. |
| Behold sporinger | Hvor lenge en sporingslogg skal beholdes før den slettes. |
| Aktivert | Aktiverer sporingen. |
| Varsle | Om man skal sende varslingse-poster. |
| Maks antall varslinger | Begrenser antall e-poster sendt. |
| E-post varsling | Hvor man skal sende varsler. |
| Kun lagre hvis det er et ubehandlet unntak | Begrenser spor til unntak. |

<!-- Referenced links -->

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/automation/trace.png

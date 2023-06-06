---
uid: help-no-automation-script-tracing
title: Sporing
description: Sporing
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRMScript, spor, feilsøking
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Sporing

Sporingsfunksjonen registrerer alle detaljer under kjøringen av skript eller makroer og lagrer dem i en logg. Hver gang skriptet eller makroen brukes, registreres kjøringen.

Deretter kan du undersøke skriptkjøringen ved å spole bakover- og forover i innspillingen. Du får en fullstendig liste over alle de innspilte kjøringene av skriptet, og hvem som kjørte skriptet. Dette gjør det mulig for deg å se hvordan skriptene fungerte, og se alle variabler på et gitt punkt.

## Se sporinger

I fanen **Sporing** finner du en oversikt over alle sporinger. Klikk på en sporing i listen for å vise detaljene.

## Start sporinger

* Gå til **CRMScript** > **Feilsøkingssesjoner**, og klikk deretter på ![ikon][img1] **Start sporing av skript** for å begynne å spore skriptene i listen.
* Åpne et skript eller en makro i **Feilsøking**, og klikk deretter på ![ikon][img2] **Spor skript**.
* Åpne et skript eller en makro i fanen **Makroer og skript**, og klikk deretter på ![ikon][img2] **Spor skript**.

## Redigere sporinger

1. Klikk på en sporing i listen **Sporing** for å åpne den.

2. Klikk på ![ikon][img3] **Rediger sporing**. Bildet **Rediger sporing** vises.

3. Fyll ut følgende felt:

    * **Beskrivelse**: Angi en beskrivelse av sporingen for å gjøre det lettere å identifisere den.
    * **Brukerfilter**: Hvis du vil spore skriptet for en bestemt bruker, velger du brukeren fra listen.
    * **Sporingsløsning**: Angi eksempelfrekvensen for sporingsloggen.
        Eksempel: Angi 1 for å logge hver kommando som kjøres av skriptet. Angi 5 for å logge hver femte kommando som kjøres av skriptet.
    * **Behold sporing**: Velg hvor lenge sporingsloggene skal beholdes.
    * **Aktivert**: Velg dette alternativet for å aktivere sporingen.

4. Klikk på **OK** når du er ferdig.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/icons/run-script.png
[img2]: ../../../../media/icons/btn-script-trace-small.png
[img3]: ../../../../media/icons/edit.png

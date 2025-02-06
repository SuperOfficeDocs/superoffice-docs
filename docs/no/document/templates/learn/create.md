---
uid: help-no-document-template-create
title: Opprette et maldokument
description: Hvordan opprette et maldokument
keywords: dokumentmal, dokument, mal
author: Bergfrid Dias, Terje Nøstdahl, samuelholmstroem
date: 07.31.2024
version: 10
topic: howto
language: no
---

# Opprette et maldokument

Hvis du vil sikre at alle i firmaet bruker de samme dokumentene, kan du opprette og legge til dine egne dokumentmaler for ulike filtyper. Bruk de tilgjengelige malvariablene til å tilpasse og automatisere registrering av kundeinformasjon i dokumentene dine.

Du oppretter en mal som et dokument i en applikasjon som er tilknyttet SuperOffice CRM, for eksempel et tekstbehandlingsprogram. Hvis du oppretter malen i Word, må du lagre den som et vanlig dokument (med filtypen **DOC** eller **DOCX**), ikke som en mal (med filtypen **DOT** eller **DOTX**).

Du kan også opprette maler i HTML-format og bruke HTML-redigeringsprogrammet for SuperOffice til å redigere malen.

> [!TIP]
> Hvis du vil legge til nye maler, kan du enkelt kopiere en eksisterende dokumentmalfil og redigere den etter behov.

## Trinn

1. Start ønsket applikasjon.
2. Opprett et nytt dokument.
3. Sett inn [malvariablene][1] du vil bruke, i malen, for eksempel variabler for navn, adresse og telefonnummer.
4. Lagre maldokumentet et sted der du enkelt kan finne det igjen.

Når du har definert en mal og lagret den i malmappen, må du [koble malen til SuperOffice CRM][2] for å kunne opprette dokumenter med den.

## Legg til flettefelt i tilbudsmal

Felter på tilbudslinjen som ikke er aktivert, vil ha tomme verdier for sine tagger – selv om du legger til data i databasen manuelt. For å bruke alle tagger, gå til tilbudsinnstillingene i Innstillinger og vedlikehold og aktiver alle felter.

For å sette inn felter i malen din, kan du bruke en av følgende metoder:

### Metode 1: Bruk Felt-dialogen

1. Plasser markøren der du vil sette inn feltet.

1. Klikk på **Sett inn** > **Hurtigdeler** > **Felt**.

    ![Hurtigdeler -screenshot][img1]

1. I listen **Feltnavn** skriver du "merge" for å markere **MergeField**.

1. I **Feltegenskaper** skriver du ditt [feltnavn][3] (uten «»):

    ![Feltegenskaper i Microsoft Word -screenshot][img2]

1. Klikk på **OK**, og variabelen vil bli satt inn i dokumentet ditt:

    ![Sett inn MERGEFIELD -screenshot][img3]

### Metode 2: Kopier og lim inn eksisterende felt (raskest)

1. **Kopier** et eksisterende felt fra malen. Sørg for å kopiere hele feltet, inkludert «».

2. **Lim inn** feltet i malen din der det trengs.

3. Høyreklikk på det innlimte feltet og velg **Rediger felt**.

4. I **Feltnavn**-boksen under **Feltegenskaper** skriver du inn eller limer inn det nye feltnavnet (uten «»).

5. **Klikk på OK**.

## Beregninger

Du kan utføre beregninger med flettefeltene.

### Netto pris per enhet

For å vise prisen per enhet etter rabatter, kan du legge til et flettefelt som dette:

```text
{= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}
```

**Trinn:**

1. Trykk Ctrl + F9 for å legge til et nytt flettefelt. Du vil se to krøllede parenteser { }.

1. Inne i parentesene:

    1. Legg til "= " og trykk Ctrl + F9 igjen.
    1. Legg til "MERGEFIELD line/totalPrice" i et nytt sett med parenteser.
    1. Skriv "/" og trykk deretter Ctrl + F9.
    1. Legg til "MERGEFIELD line/quantity" i det siste settet med parenteser.

1. Nå skal du ha et felt som ser slik ut: {= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}

## Relatert innhold

* [Hvordan jobbe med felter i Aspose Words][9]
* [Tilbudsmaler og flettefelter][4]
* [Flettefeltreferanse][3]
* [Malvariabelreferanse][6]

<!-- Referenced links -->
[1]: template-variables.md
[4]: quote-templates.md
[2]: ../admin/link-template.md
[3]: ../merge-fields/index.md
[6]: ../variables/for-quote-line.md
[9]: https://docs.aspose.com/words/net/fields-overview/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/word-insert-quick-parts.png
[img2]: ../../../../media/loc/en/document/word-field-dialog.png
[img3]: ../../../../media/loc/en/document/6764-11541.jpg

---
uid: help-da-document-template-create
title: Oprettelse af et skabelondokument
description: Oprettelse af et skabelondokument
keywords: document template, document, template
author: Bergfrid Dias, Terje Nøstdahl, samuelholmstroem
date: 02.25.2025
version: 10.5.2
topic: howto
language: da
---

# Oprettelse af et skabelondokument

For at sikre, at alle i firmaet bruger de samme dokumenter, kan du oprette og tilføje dine egne dokumentskabeloner til forskellige filtyper. Brug de tilgængelige skabelonvariabler til at tilpasse og automatisere indtastningen af kundeoplysninger i dine dokumenter.

Du opretter en skabelon som et dokument i et program, der er knyttet til SuperOffice CRM, f.eks. et tekstbehandlingsprogram. Hvis du opretter skabelonen i Word, skal du gemme den som et normalt dokument (med filtypen **DOC** eller **DOCX**) og ikke som en skabelon (med filtypen **DOT** eller **DOTX**).

Du kan også oprette skabeloner i HTML-format og bruge SuperOffice HTML-editoren til at redigere skabelonen.

> [!TIP]
> Hvis du vil tilføje nye skabeloner, kan du nemt kopiere en eksisterende dokumentskabelonfil og redigere den, så den passer til dine behov.

## Trin

1. Start det nødvendige program.
2. Opret et nyt dokument.
3. Indsæt de [skabelonvariabler][1], du vil bruge i skabelonen, f.eks. variabler for navn, adresse og telefonnummer.
4. Gem skabelondokumentet et sted, hvor du nemt kan finde det igen.

Når du har defineret en skabelon og gemt den i skabelonmappen, skal du [sammenkæde skabelonen med SuperOffice CRM][2] for at oprette dokumenter ud fra den.

## Tilføj fletfelt til tilbudsskabelon

Felter på tilbudslinjen, der ikke er aktiveret, vil have tomme værdier for deres tags – selvom du tilføjer data til databasen manuelt. For at bruge alle tags skal du gå til tilbudsindstillingerne i Indstillinger og vedligeholdelse og aktivere alle felter.

For at indsætte felter i din skabelon kan du bruge en af følgende metoder:

### Metode 1: Brug felt-dialogen

1. Placer markøren, hvor du vil indsætte feltet.

1. Klik på **Indsæt** > **Hurtige dele** > **Felt**.

    ![Hurtige dele -screenshot][img1]

1. I listen **Feltnavne** skal du skrive "merge" for at fremhæve **MergeField**.

1. I **Feltegenskaber** skal du skrive dit [feltnavn][3] (uden «»):

    ![Feltegenskaber i Microsoft Word -screenshot][img2]

1. Klik på **OK**, og variablen vil blive indsat i dit dokument:

    ![Indsæt MERGEFIELD -screenshot][img3]

### Metode 2: Kopier og indsæt eksisterende felter (hurtigst)

1. **Kopier** et eksisterende felt fra skabelonen. Sørg for at kopiere hele feltet, inklusive «» parenteserne.

2. **Indsæt** feltet i din skabelon, hvor det er nødvendigt.

3. Højreklik på det indsatte felt og vælg **Rediger felter**.

4. I **Feltnavn**-boksen under **Feltegenskaber** skal du indtaste eller indsætte det nye feltnavn (uden «»).

5. **Klik på OK**.

## Beregninger

Du kan udføre beregninger med fletfelterne.

### Nettopris pr. enhed

For at vise prisen pr. enhed efter rabatter kan du tilføje et fletfelt som dette:

```text
{= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}
```

**Trin:**

1. Tryk på Ctrl + F9 for at tilføje et nyt fletfelt. Du vil se to krøllede parenteser { }.

1. Inde i parenteserne:

    1. Tilføj "= " og tryk på Ctrl + F9 igen.
    1. Tilføj "MERGEFIELD line/totalPrice" i et nyt sæt parenteser.
    1. Skriv "/" og tryk derefter på Ctrl + F9.
    1. Tilføj "MERGEFIELD line/quantity" i det sidste sæt parenteser.

1. Nu skal du have et felt, der ser sådan ud: {= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}

## Relateret indhold

* [Sådan arbejder du med felter i Aspose Words][9]
* [Tilbudsskabeloner og fletfelter][4]
* [Fletfeltreference][3]
* [Skabelonvariabelreference][6]

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

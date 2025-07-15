---
uid: help-sv-edit-email-signature
title: Redigera signaturer
description: Hur du redigerar e-postsignatur och ärendesignatur
keywords: e-postsignatur, ärendesignatur, e-post, signatur
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Redigera signaturer

Standardmallarna innehåller mallvariabler som ersätts med data från SuperOffice, vilket säkerställer att dina signaturer alltid uppdateras med rätt information.

* **E-postsignatur:** Mallen innehåller variabler för ditt namn, företag, adress, telefonnummer, e-postadress, webbplats och så vidare [från ditt kontaktkort][3].

* **Ärendesignatur:** Mallen innehåller variabler för ditt namn, företag, e-postadress och så vidare specifikt för [svarsmallar][2].

> [!NOTE]
> Du kan inte blanda dessa två uppsättningar mallvariabler. Dessutom kan personliga signaturer inte åsidosättas av administratörer.

## Steg

1. Klicka på knappen **Personliga inställningar** (<i class="ph ph-user-circle" aria-hidden="true"></i>) i det övre fältet.

1. Välj **Redigera personlig e-postsignatur**.

1. I dialogrutan väljer du antingen fliken **E-postsignatur** eller **Ärendesignatur**.

1. Redigera texten och lägg till ytterligare innehåll.

    * Klicka på **[v]** i verktygsfältet för att lägga till variabler, eller gå till ovan länkade referenser för den kompletta listan över tillgängliga variabler.

    * Lägg till bilder och länkar med hjälp av knapparna i verktygsfältet. Du kan också dra och släppa länkar och bilder. Välj **Infoga länk** för att lägga till länkar till relevanta resurser eller sociala medier.

    ![Redigera personlig e-postsignatur -screenshot][img1]

1. Klicka på **Spara** när du är klar.

1. Valfritt: Testa signaturen genom att skicka ett e-postmeddelande till dig själv (för e-postsignaturer) eller genom att skapa ett nytt ärende (för ärendesignatur). Kontrollera att all information visas korrekt, att länkarna fungerar och att bilderna visas som avsett.

## Exempel

Detta är ett exempel på en signatur som kan användas av vem som helst i ditt företag.

**Mall:**

```text
Bästa hälsningar,
{auth}
{atit}
{onam}
Adress: {opad}, {ozip} {ocit}
Telefon: {audp}
Mobiltelefon: {aupc}
{auem}
{owww}
```

**Resultat:**

```text
Med vänlig hälsning,
Johan Jonsson
Försäljningschef
SuperShop
Adress: Storgatan 12, 123 45 Storstad
Telefon: 22334455
Mobiltelefon: 99887766
jj@supershop.com
supershop.com
```

## Relaterat innehåll

* [Ändra standardklienten för e-post i SuperOffice][1]

<!-- Referenced links -->
[1]: ../../email/learn/change-default-mail-client.md
[2]: ../../knowledge-base/learn/reply-templates/template-variables.md
[3]: ../../document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png

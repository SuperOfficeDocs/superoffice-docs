---
uid: help-sv-edit-email-signature
title: Redigera signaturer
description: Redigera e-postsignatur
keywords: e-post, signatur
author: Bergfrid Dias
date: 06.11.2024
version: 10.2.8
topic: howto
language: sv
audience: person
audience_tooltip: SuperOffice CRM
---

# Redigera signaturer

Standardmallarna innehåller mallvariabler som ersätts med data från SuperOffice, vilket säkerställer att dina signaturer alltid uppdateras med rätt information.

* **E-postsignatur:** Mallen innehåller variabler för ditt namn, företag, adress, telefonnummer, e-postadress, webbplats och så vidare [från ditt kontaktkort][3].

* **Ärandesignatur:** Mallen innehåller variabler för ditt namn, företag, e-postadress och så vidare specifikt för [svarsmallar][2].

> [!NOTE]
> Du kan inte blanda dessa två uppsättningar mallvariabler.

## Steg

1. Klicka på knappen **Personliga inställningar** i det övre fältet.

2. Välj **Redigera personlig e-postsignatur**.

3. Välj i dialogrutan antingen fliken **E-postsignatur** eller fliken **Ärandesignatur**.

4. Klicka på ![ikon][img2] för att öppna textredigerarens verktygsfält. Här har du olika alternativ för att redigera text och lägga till ytterligare innehåll.

    ![Redigera personlig e-postsignatur -screenshot][img1]

    * Klicka på ![ikon][img3] i verktygsfältet för att lägga till variabler, eller gå till ovan länkade referenser för den kompletta listan över tillgängliga mallvariabler.

    * Lägg till bilder och länkar med hjälp av knapparna i verktygsfältet. Du kan också dra och släppa länkar och bilder. Välj **Infoga länk** för att lägga till länkar till relevanta resurser eller sociala medier.

5. Klicka på **Spara** när du är klar.

6. Valfritt: Testa signaturen genom att skicka ett e-postmeddelande till dig själv (för e-postsignaturer) eller genom att skapa ett nytt ärende (för ärandesignatur). Kontrollera att all information visas korrekt, och att länkarna fungerar och bilderna visas som avsett.

## Exempel

Detta är ett exempel på en signatur som kan användas av vem som helst i ditt företag.

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

## Relaterade ämnen

* [Ändra standardklienten för e-post i SuperOffice][1]

<!-- Referenced links -->
[1]: ../../email/learn/change-default-mail-client.md
[2]: ../../request/reply-templates/learn/template-variables.md
[3]: ../../../en/document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/editor-toolbar-icon.png
[img3]: ../../../media/icons/sign-editor-variables.png
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png

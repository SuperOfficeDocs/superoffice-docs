---
uid: help-sv-adding-items-to-web-panel-list
title: Lägga till poster i listan Webbpanel
description: Lägga till poster i listan Webbpanel
author: SuperOffice RnD
so.date: 01.20.2023
keywords: lista, webbpanel
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Lägga till poster i listan GUI – Webbpanel

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

## Så fyller du i fält när posterna är webbadresser

1. Skriv in namnet på posten i fältet **Namn**. Det här namnet visas när du lägger till webbadressen i SuperOffice CRM.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Ange webbadressen, till exempel en webbplats eller en serverbaserad HTML-fil, i fältet **URL**. Högst upp finns information om hur du använder webbadresser med HTTP/HTTPS.

1. Ange namnet på det webbläsarfönster där webbadressen ska öppnas i fältet **Fönstrets namn**. Om du redan har lagt till ett eller flera fönsternamn sedan tidigare och vill använda samma namn, klickar du i fältet och väljer namnet i listan. Du kan även skriva ett nytt namn direkt i fältet. Det slutliga fönsternamnet visas med understrykning nedanför.

1. I listrutan **Synlig i** väljer du var webbadressen ska vara tillgänglig i SuperOffice CRM.
    * **Sidopanel**: Välj det här alternativet om webbadressen ska vara tillgänglig på sidopanelerna i SuperOffice CRM.

    * **Verktygsfältet**: Välj detta alternativ om webbadressen ska vara tillgänglig som en knapp i verktygsfältet.

    * **Navigatorknapp**: Välj det här alternativet om webbadressen ska vara tillgänglig som en knapp i navigatorn i SuperOffice CRM.

    * **Panel**: välj [ett alternativ i den här listan](#options) om webbadressen ska vara tillgänglig som en panel/flik i SuperOffice CRM.

    * **Dialogruta**: välj ett [alternativ i den här listan](#options) om du vill att webbadressen ska vara tillgänglig i en dialogruta.

    * **Meny**: välj ett [alternativ i den här listan](#options) om du vill att webbadressen ska vara tillgänglig på en av menyerna i SuperOffice CRM.

1. I listrutan **URL-format** kan du välja om [webbadressen][2] ska ha ANSI- eller Unicode-format (eller inget format).

1. Under **Visa** kan du markera alla rader som ska vara tillgängliga i webbläsaren som webbadressen öppnas i – menyrad, verktygsfält, adressrad och statusrad.

1. Under **Tillgänglig på** väljer du var du vill att webbadressen ska vara tillgänglig. Du kan välja flera av dessa alternativ samtidigt.
    * **SuperOffice CRM for Web**: när du använder webbversionen av SuperOffice CRM.
    * **Mobile CRM**: när du använder mobilversionen av SuperOffice CRM.

    Extra inställningar:
    * **Ladda alltid om** innehållet vid fliknavigering.
    * **Visa länk** för att öppna i separat fönster.

1. Klicka på listan **Ikon** för att välja en ikon för webbpanelen.

1. Skriv eventuellt en beskrivning av posten i fältet **Beskrivning**. Läs om [översättning][3].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> När du lägger till en webbadress kan det vara praktiskt att använda till exempel mallvariabeln för aktivt företag för att hämta information från andra applikationer via webbadressen. Webbadressen måste innehålla parametrar som i det här fiktiva exemplet: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn är mallvariabeln för organisationsnummer, men andra variabler, t.ex. företagsnamn &lt;name&gt;, företagets telefonnummer &lt;cpho&gt; och kontaktnamn &lt;attn&gt;, kan också användas.

## <a id="options" />Alternativ

### Panel

* **Företagskort**, **Kontaktkort**, **Projektkort**, **Urvalskort** och **Försäljningskort**: Ett kortkommando till webbadressen infogas högst upp på fliken **www** i fönstren Företag, Kontakt, Projekt, Urval och Försäljning. När du klickar på en genväg i SuperOffice CRM öppnas den aktuella webbplatsen i ett litet fönster med en rullningslist på fliken. Du kan också välja att klicka på **Öppna i eget fönster** om webbplatsen ska öppnas i ett separat fönster i webbläsaren.

* **Webbpanel**: webbadressen läggs till på webbpanelen i SuperOffice CRM. Därmed kan adressen öppnas som en sida på Internet. Om det finns flera definierade webbadresser för webbpanelen visas de som flikar på webbpanelens högra sida. Du öppnar webbpanelen genom att klicka på SuperOffice-logotypen längst upp till vänster i SuperOffice CRM.

* Detaljkort i fönstren Företag, Kontakt, Projekt och Försäljning: webbadressen läggs till som ett extra detaljkort i fönstret Företag/Kontakt/Projekt/Learn/Försäljning. När du väljer detaljkortet i SuperOffice CRM öppnas webbadressen. Du kan också välja att klicka på **Öppna i eget fönster** om webbplatsen ska öppnas i ett separat fönster i webbläsaren.

### Dialogruta

* **Dialogrutan för händelser**: Ett kortkommando till webbadressen infogas högst upp på fliken **www** i dialogrutan **Händelse**. Du kan också välja att klicka på **Öppna i eget fönster** om webbplatsen ska öppnas i ett separat fönster i webbläsaren.

* **Dialogrutan Dokument/Offert/Produkt**: Ett kortkommando till webbadressen infogas högst upp på fliken **www** i dialogrutorna.

### Meny

* **Verktygsmenyn**: webbadressen visas när användaren klickar på knappen **Verktyg** ![ikon][img1] i navigatorn eller väljer **Andra applikationer** i SuperOffice CRM.

* **Visa**-menyn: webbadressen visas när användaren väljer **Andra applikationer** i SuperOffice CRM.

## Är SuperOffice CRM for Web installerat på en HTTPS-sida?

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Relaterade ämnen

* [Lägg till en post på uppgiftsmenyn][1]
* [Lägg till en översättning][3]

<!-- Referenced links -->
[1]: add-items-to-task-menu.md
[2]: ../../../../en/ui/web-panels/url-encoding.md
[3]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-tools.png

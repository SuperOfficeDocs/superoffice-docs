---
uid: help-sv-add-web-panel
title: Lägg till webbpanel
description: Så lägger du till objekt i webbpanellistan i Inställningar och underhåll.
keywords: webbpanel, listan GUI - Webbpanel
author: digitaldiina
date: 10.13.2025
version: 11.5
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
content_type: howto
language: sv
index: true
redirect_from: /sv/admin/lists/learn/web-panel-add-item
---

# Lägg till webbpanel

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Var din webbpanel visas bestäms av *Synlig i*. Innehållet i din webbpanel bestäms av URL:en.

Webbpaneler definieras i listan **GUI - Webbpanel**, som du kan hantera i **Inställningar och underhåll** under **Listor**.

## Steg

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i navigatorn.

1. Välj **GUI - Webbpanel** från rullgardinsmenyn. Fliken **Objekt** visar alla befintliga webbpaneler.

1. Klicka på **Lägg till** för att öppna dialogrutan **Redigera listobjekt**.

1. Skriv in namnet på posten i fältet **Namn**. *(Obligatorisk)*

    * Det här namnet visas när du lägger till webbadressen i SuperOffice CRM.

1. Ange webbadressen, till exempel en webbplats eller en serverbaserad HTML-fil, i fältet **URL**. För detaljer om stödda URL-typer, se [Använda HTTP vs HTTPS-webbadresser](#https).

    * Om du lägger till en webbadress kan det vara användbart att använda mallvariabler för det aktiva företaget, till exempel för att hämta information från andra applikationer via en URL. Webbadressen måste ange parametrar, som i detta fiktiva exempel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn är här mallvariabeln för organisationsnumret, men andra variabler som företagsnamn &lt;name&gt;, företagstelefonnummer &lt;cpho&gt;, kontaktnamn &lt;attn&gt; kan också användas.

1. Ange namnet på det webbläsarfönster där webbadressen ska öppnas i fältet **Fönstrets namn**. Om du redan har lagt till ett eller flera fönsternamn sedan tidigare och vill använda samma namn, klickar du i fältet och väljer namnet i listan. Du kan även skriva ett nytt namn direkt i fältet. Det slutliga fönsternamnet visas med understrykning nedanför.

1. I listrutan **Synlig i** väljer du var webbpanelen ska visas i SuperOffice CRM.

    * Du kan välja mellan paneler, dialogrutor, menyer, verktygsfält eller sidopanelplatser.
    * För en fullständig lista över visningsalternativ, se [Visningsplatser för webbpaneler][8].

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

1. Klicka på **Spara** för att spara ändringarna eller **Avbryt** för att förkasta dem.

## Efter att ha sparat

När posten har sparats kan du:

* Ändra ordningen på poster med hjälp av pilknapparna till vänster om listan (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

* Ange ytterligare inställningar för varje post:
  * Vilka [användargrupper posten ska vara synlig för][7].
  * Vilken [rubrik][6] den ska visas under.

## <a id="fields"></a>Referens

| Inställning | Beskrivning |
|---|---|
| Namn | UI-etikett |
| Fönsternamn | ID för panelen, används i HTML:en som laddas in i panelerna. Måste vara unikt, använd prefix |
| Beskrivning | Verktygstips-text |
| URL | Plats för webbsidan |
| URL-kodning | Ingen, ANSI eller Unicode |
| Synlig i | Visningsplats |
| Tillgänglig på | Enhetstyp (webb, mobil) |
| Visa | Om menyrad, verktygsfält, adressfält och/eller statusfält ska visas |

## <a id="https"></a>Använda HTTP vs HTTPS-webbadresser

[!include[HTTPS restriction](../../../admin/lists/learn/includes/web-panels-and-https.md)]

## Lägg till webbpanel i Service (föråldrad)

I Service kallas webbpaneler för **extra webbläsarflikar**. Du kan lägga till samma typ av innehåll som för [extra menyer][4].

1. Logga in i SuperOffice Service.
1. Välj **Systemdesign** i hamburgermenyn och sedan **Webbpaneler**.
1. Peka på önskad visningsplats och klicka på **Ny webbpanel**.
1. Ange en UI-etikett (fliktext).
1. Välj antingen **Använd URL** eller **Använd skärmbild** och välj motsvarande detaljer.
1. Välj var det nya menyalternativet ska placeras från listan **Position** (0 = överst).
1. Klicka på **OK**.
1. Testa resultatet.

## Relaterat innehåll

* [Lägg till en post på uppgiftsmenyn][1]
* [Basprogram och URL-parametrar][5]

<!-- Referenced links -->
[1]: ../../../admin/lists/learn/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md
[6]: ../../../admin/lists/learn/organize/headings.md
[7]: ../../../admin/lists/learn/organize/user-group-filtering.md
[8]: index.md

<!-- Referenced images -->